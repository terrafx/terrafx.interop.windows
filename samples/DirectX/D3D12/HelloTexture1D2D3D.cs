// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12HelloConstBuffor in https://github.com/Microsoft/DirectX-Graphics-Samples
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System.Numerics;
using System.Runtime.CompilerServices;
using TerraFX.Interop;
using static TerraFX.Interop.D3D_PRIMITIVE_TOPOLOGY;
using static TerraFX.Interop.D3D_ROOT_SIGNATURE_VERSION;
using static TerraFX.Interop.D3D12_COMPARISON_FUNC;
using static TerraFX.Interop.D3D12_DESCRIPTOR_HEAP_FLAGS;
using static TerraFX.Interop.D3D12_DESCRIPTOR_HEAP_TYPE;
using static TerraFX.Interop.D3D12_DESCRIPTOR_RANGE_FLAGS;
using static TerraFX.Interop.D3D12_DESCRIPTOR_RANGE_TYPE;
using static TerraFX.Interop.D3D12_FEATURE;
using static TerraFX.Interop.D3D12_HEAP_FLAGS;
using static TerraFX.Interop.D3D12_HEAP_TYPE;
using static TerraFX.Interop.D3D12_INPUT_CLASSIFICATION;
using static TerraFX.Interop.D3D12_PRIMITIVE_TOPOLOGY_TYPE;
using static TerraFX.Interop.D3D12_RESOURCE_DIMENSION;
using static TerraFX.Interop.D3D12_RESOURCE_FLAGS;
using static TerraFX.Interop.D3D12_RESOURCE_STATES;
using static TerraFX.Interop.D3D12_ROOT_SIGNATURE_FLAGS;
using static TerraFX.Interop.D3D12_SHADER_VISIBILITY;
using static TerraFX.Interop.D3D12_SRV_DIMENSION;
using static TerraFX.Interop.D3D12_STATIC_BORDER_COLOR;
using static TerraFX.Interop.D3D12_TEXTURE_ADDRESS_MODE;
using static TerraFX.Interop.DXGI_FORMAT;
using static TerraFX.Interop.Windows;
using static TerraFX.Samples.DirectX.DXSampleHelper;

namespace TerraFX.Samples.DirectX.D3D12
{
    public unsafe class HelloTexture1D2D3D : DX12Sample
    {
        // triangle geometry (HelloTriangle)
        private ID3D12Resource* _vertexBuffer;
        private D3D12_VERTEX_BUFFER_VIEW _vertexBufferView;

        // checker board texture (HelloTexture)
        private const uint TextureWidth = 256;
        private const uint TextureHeight = 256;
        private const uint TexturePixelSize = 4;
        private ID3D12Resource* _texture;

        // animate the position (HelloConstBuffer)
        private ID3D12Resource* _constantBuffer;
        private byte* _constantBufferDataBegin;
        private SceneConstantBuffer _constantBufferData;

        // heap for both
        private ID3D12DescriptorHeap* _cbv_srv_Heap;

        public HelloTexture1D2D3D(string name) : base(name)
        {
        }


        protected override void CreateAssets()
        {
            using ComPtr<ID3D12Resource> textureUploadHeap = null;
            _constantBuffer = CreateConstantBuffer(out _constantBufferDataBegin);
            _texture = CreateTexture();
            _vertexBuffer = CreateVertexBuffer(out _vertexBufferView);
            base.CreateAssets();

            ID3D12Resource* CreateTexture()
            {
                // Describe and create a Texture2D.
                var textureDesc = new D3D12_RESOURCE_DESC {
                    MipLevels = 1,
                    Format = DXGI_FORMAT_R8G8B8A8_UNORM,
                    Width = TextureWidth,
                    Height = TextureHeight,
                    Flags = D3D12_RESOURCE_FLAG_NONE,
                    DepthOrArraySize = 1,
                    SampleDesc = new DXGI_SAMPLE_DESC {
                        Count = 1,
                        Quality = 0,
                    },
                    Dimension = D3D12_RESOURCE_DIMENSION_TEXTURE2D,
                };

                ID3D12Resource* texture;

                var heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_DEFAULT);
                var iid = IID_ID3D12Resource;
                ThrowIfFailed(nameof(ID3D12Device.CreateCommittedResource), D3DDevice->CreateCommittedResource(
                    &heapProperties,
                    D3D12_HEAP_FLAG_NONE,
                    &textureDesc,
                    D3D12_RESOURCE_STATE_COPY_DEST,
                    pOptimizedClearValue: null,
                    &iid,
                    (void**)&texture
                ));

                var uploadBufferSize = GetRequiredIntermediateSize(texture, 0, 1);

                // Create the GPU upload buffer.
                heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_UPLOAD);
                var bufferDesc = D3D12_RESOURCE_DESC.Buffer(uploadBufferSize);
                ThrowIfFailed(nameof(ID3D12Device.CreateCommittedResource), D3DDevice->CreateCommittedResource(
                    &heapProperties,
                    D3D12_HEAP_FLAG_NONE,
                    &bufferDesc,
                    D3D12_RESOURCE_STATE_GENERIC_READ,
                    pOptimizedClearValue: null,
                    &iid,
                    (void**)textureUploadHeap.GetAddressOf()
                ));

                // Copy data to the intermediate upload heap and then schedule a copy
                // from the upload heap to the Texture2D.
                var textureData = GenerateTextureData();
                var rowPitch = TextureWidth * TexturePixelSize;
                var slicePitch = rowPitch * TextureHeight;
                D3D12_SUBRESOURCE_DATA textureSubresourceData;
                fixed (byte* pTextureData = &textureData[0])
                {
                    textureSubresourceData = new D3D12_SUBRESOURCE_DATA {
                        pData = (void*)pTextureData,
                        RowPitch = (nint)rowPitch,
                        SlicePitch = (nint)slicePitch,
                    };
                }
                UpdateSubresources(GraphicsCommandList, texture, textureUploadHeap, 0, 0, 1, &textureSubresourceData);
                var barrier = D3D12_RESOURCE_BARRIER.InitTransition(texture, D3D12_RESOURCE_STATE_COPY_DEST, D3D12_RESOURCE_STATE_PIXEL_SHADER_RESOURCE);
                GraphicsCommandList->ResourceBarrier(1, &barrier);

                // Describe and create a SRV for the texture.
                var srvDesc = new D3D12_SHADER_RESOURCE_VIEW_DESC {
                    Shader4ComponentMapping = D3D12_DEFAULT_SHADER_4_COMPONENT_MAPPING,
                    Format = textureDesc.Format,
                    ViewDimension = D3D12_SRV_DIMENSION_TEXTURE2D,
                };
                srvDesc.Anonymous.Texture2D.MipLevels = 1;

                var incrementSize = D3DDevice->GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV);
                var incrementedHandle = new D3D12_CPU_DESCRIPTOR_HANDLE(_cbv_srv_Heap->GetCPUDescriptorHandleForHeapStart(), (int)incrementSize);
                D3DDevice->CreateShaderResourceView(texture, &srvDesc,  incrementedHandle);

                return texture;


                byte[] GenerateTextureData()
                {
                    const uint RowPitch = TextureWidth * TexturePixelSize;
                    const uint CellPitch = RowPitch >> 3;        // The width of a cell in the checkboard texture.
                    const uint CellHeight = TextureWidth >> 3;    // The height of a cell in the checkerboard texture.
                    const uint TextureSize = RowPitch * TextureHeight;

                    var data = new byte[TextureSize];
                    fixed (byte* pData = &data[0])
                    {
                        for (uint n = 0; n < TextureSize; n += TexturePixelSize)
                        {
                            var x = n % RowPitch;
                            var y = n / RowPitch;
                            var i = x / CellPitch;
                            var j = y / CellHeight;

                            if (i % 2 == j % 2)
                            {
                                pData[n] = 0x00;        // R
                                pData[n + 1] = 0x00;    // G
                                pData[n + 2] = 0x00;    // B
                                pData[n + 3] = 0xff;    // A
                            }
                            else
                            {
                                pData[n] = 0xff;        // R
                                pData[n + 1] = 0xff;    // G
                                pData[n + 2] = 0xff;    // B
                                pData[n + 3] = 0xff;    // A
                            }
                        }
                    }

                    return data;
                }
            }


            ID3D12Resource* CreateVertexBuffer(out D3D12_VERTEX_BUFFER_VIEW vertexBufferView)
            {
                // Define the geometry for a triangle.
                const int TriangleVerticesCount = 3;
                var triangleVertices = stackalloc Vertex[TriangleVerticesCount] {
                    new Vertex {
                        Position = new Vector3(0.0f, 0.25f * AspectRatio, 0.0f),
                        UV = new Vector2(0.5f, 0.0f)
                    },
                    new Vertex {
                        Position = new Vector3(0.25f, -0.25f * AspectRatio, 0.0f),
                        UV = new Vector2(1.0f, 1.0f)
                    },
                    new Vertex {
                        Position = new Vector3(-0.25f, -0.25f * AspectRatio, 0.0f),
                        UV = new Vector2(0.0f, 1.0f)
                    },
                };

                var vertexBufferSize = (uint)sizeof(Vertex) * TriangleVerticesCount;

                // Note: using upload heaps to transfer static data like vert buffers is not
                // recommended. Every time the GPU needs it, the upload heap will be marshalled
                // over. Please read up on Default Heap usage. An upload heap is used here for
                // code simplicity and because there are very few verts to actually transfer.
                ID3D12Resource* vertexBuffer;

                var heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_UPLOAD);
                var bufferDesc = D3D12_RESOURCE_DESC.Buffer(vertexBufferSize);

                var iid = IID_ID3D12Resource;
                ThrowIfFailed(nameof(ID3D12Device.CreateCommittedResource), D3DDevice->CreateCommittedResource(
                    &heapProperties,
                    D3D12_HEAP_FLAG_NONE,
                    &bufferDesc,
                    D3D12_RESOURCE_STATE_GENERIC_READ,
                    pOptimizedClearValue: null,
                    &iid,
                    (void**)&vertexBuffer
                ));

                // Copy the triangle data to the vertex buffer.
                var readRange = new D3D12_RANGE();

                byte* pVertexDataBegin;
                ThrowIfFailed(nameof(ID3D12Resource.Map), vertexBuffer->Map(Subresource: 0, &readRange, (void**)&pVertexDataBegin));
                Unsafe.CopyBlock(pVertexDataBegin, triangleVertices, vertexBufferSize);
                vertexBuffer->Unmap(0, null);

                // Initialize the vertex buffer view.
                vertexBufferView.BufferLocation = vertexBuffer->GetGPUVirtualAddress();
                vertexBufferView.StrideInBytes = (uint)sizeof(Vertex);
                vertexBufferView.SizeInBytes = vertexBufferSize;

                return vertexBuffer;
            }


            ID3D12Resource* CreateConstantBuffer(out byte* constantBufferDataBegin)
            {
                _constantBufferData = new SceneConstantBuffer();
                _constantBufferData.Matrix4x4 = Matrix4x4.Identity;

                ID3D12Resource* constantBuffer;

                var heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_UPLOAD);
                var bufferDesc = D3D12_RESOURCE_DESC.Buffer(1024 * 64);

                var iid = IID_ID3D12Resource;
                ThrowIfFailed(nameof(ID3D12Device.CreateCommittedResource), D3DDevice->CreateCommittedResource(&heapProperties, D3D12_HEAP_FLAG_NONE, &bufferDesc, D3D12_RESOURCE_STATE_GENERIC_READ, pOptimizedClearValue: null, &iid, (void**)&constantBuffer));

                var cbvDesc = new D3D12_CONSTANT_BUFFER_VIEW_DESC {
                    BufferLocation = constantBuffer->GetGPUVirtualAddress(),
                    SizeInBytes = (uint)((sizeof(SceneConstantBuffer) + 255) & ~255)    // CB size is required to be 256-byte aligned.
                };
                D3DDevice->CreateConstantBufferView(&cbvDesc, _cbv_srv_Heap->GetCPUDescriptorHandleForHeapStart());

                // Map and initialize the constant buffer. We don't unmap this until the
                // app closes. Keeping things mapped for the lifetime of the resource is okay.

                fixed (byte** pConstantBufferDataBegin = &constantBufferDataBegin)
                {
                    var readRange = new D3D12_RANGE(); // We do not intend to read from this resource on the CPU.
                    ThrowIfFailed(nameof(ID3D12Resource.Map), constantBuffer->Map(Subresource: 0, &readRange, (void**)pConstantBufferDataBegin));
                    Unsafe.CopyBlock(ref constantBufferDataBegin[0], ref Unsafe.As<SceneConstantBuffer, byte>(ref _constantBufferData), (uint)sizeof(SceneConstantBuffer));
                }

                return constantBuffer;
            }
        }

        protected override void CreateDescriptorHeaps()
        {
            base.CreateDescriptorHeaps();
            _cbv_srv_Heap = CreateCbvSrvHeap();

            ID3D12DescriptorHeap* CreateCbvSrvHeap()
            {
                var cbvSrvHeapDesc = new D3D12_DESCRIPTOR_HEAP_DESC {
                    NumDescriptors = 2,
                    Flags = D3D12_DESCRIPTOR_HEAP_FLAG_SHADER_VISIBLE,
                    Type = D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV,
                };

                ID3D12DescriptorHeap* cbvSrvHeap;

                var iid = IID_ID3D12DescriptorHeap;
                ThrowIfFailed(nameof(ID3D12Device.CreateDescriptorHeap), D3DDevice->CreateDescriptorHeap(&cbvSrvHeapDesc, &iid, (void**)&cbvSrvHeap));

                return cbvSrvHeap;
            }
        }

        protected override unsafe ID3D12PipelineState* CreatePipelineState()
        {
            using ComPtr<ID3DBlob> pixelShader = null;
            using ComPtr<ID3DBlob> vertexShader = null;

            var compileFlags = 0u;

#if DEBUG
            // Enable better shader debugging with the graphics debugging tools.
            compileFlags |= D3DCOMPILE_DEBUG | D3DCOMPILE_SKIP_OPTIMIZATION;
#endif
            fixed (char* fileName = GetAssetFullPath(@"D3D12\Assets\Shaders\HelloTexture1D2D3D.hlsl"))
            {
                var entryPoint = 0x00006E69614D5356;    // VSMain
                var target = 0x0000305F355F7376;        // vs_5_0
                ThrowIfFailed(nameof(D3DCompileFromFile), D3DCompileFromFile((ushort*)fileName, pDefines: null, pInclude: null, (sbyte*)&entryPoint, (sbyte*)&target, compileFlags, Flags2: 0, vertexShader.GetAddressOf(), ppErrorMsgs: null));

                entryPoint = 0x00006E69614D5350;        // PSMain
                target = 0x0000305F355F7370;            // ps_5_0
                ThrowIfFailed(nameof(D3DCompileFromFile), D3DCompileFromFile((ushort*)fileName, pDefines: null, pInclude: null, (sbyte*)&entryPoint, (sbyte*)&target, compileFlags, Flags2: 0, pixelShader.GetAddressOf(), ppErrorMsgs: null));
            }

            // Define the vertex input layout.
            const int InputElementDescsCount = 2;

            var semanticNamePosition = stackalloc ulong[2] {
                0x4E4F495449534F50,     // POSITION
                0x0000000000000000,
            };

            var semanticNameTexCoord = stackalloc ulong[2] {
                0x44524F4F43584554,     // TEXCOORD
                0x0000000000000000,
            };

            var positionElement = new D3D12_INPUT_ELEMENT_DESC {
                SemanticName = (sbyte*)semanticNamePosition,
                Format = DXGI_FORMAT_R32G32B32_FLOAT,
                InputSlotClass = D3D12_INPUT_CLASSIFICATION_PER_VERTEX_DATA,
            };

            var texCoordElement = new D3D12_INPUT_ELEMENT_DESC {
                SemanticName = (sbyte*)semanticNameTexCoord,
                Format = DXGI_FORMAT_R32G32_FLOAT,
                AlignedByteOffset = 12,
                InputSlotClass = D3D12_INPUT_CLASSIFICATION_PER_VERTEX_DATA,
            };

            var inputElementDescs = stackalloc D3D12_INPUT_ELEMENT_DESC[InputElementDescsCount] {
                positionElement,
                texCoordElement,
            };

            var depthStencilState = new D3D12_DEPTH_STENCIL_DESC {
                DepthEnable = FALSE,
                StencilEnable = FALSE,
            };

            // Describe and create the graphics pipeline state object (PSO).
            var psoDesc = new D3D12_GRAPHICS_PIPELINE_STATE_DESC {
                InputLayout = new D3D12_INPUT_LAYOUT_DESC {
                    pInputElementDescs = inputElementDescs,
                    NumElements = InputElementDescsCount,
                },
                pRootSignature = RootSignature,
                VS = new D3D12_SHADER_BYTECODE(vertexShader),
                PS = new D3D12_SHADER_BYTECODE(pixelShader),
                RasterizerState = D3D12_RASTERIZER_DESC.DEFAULT,
                BlendState = D3D12_BLEND_DESC.DEFAULT,
                DepthStencilState = depthStencilState,
                SampleMask = uint.MaxValue,
                PrimitiveTopologyType = D3D12_PRIMITIVE_TOPOLOGY_TYPE_TRIANGLE,
                NumRenderTargets = 1,
                SampleDesc = new DXGI_SAMPLE_DESC(count: 1, quality: 0),
            };
            psoDesc.RTVFormats[0] = DXGI_FORMAT_R8G8B8A8_UNORM;

            ID3D12PipelineState* pipelineState;
            var iid = IID_ID3D12PipelineState;
            ThrowIfFailed(nameof(ID3D12Device.CreateGraphicsPipelineState), D3DDevice->CreateGraphicsPipelineState(&psoDesc, &iid, (void**)&pipelineState));

            return pipelineState;
        }

        protected override unsafe ID3D12RootSignature* CreateRootSignature()
        {
            using ComPtr<ID3DBlob> signature = null;
            using ComPtr<ID3DBlob> error = null;

            var featureData = new D3D12_FEATURE_DATA_ROOT_SIGNATURE {
                // This is the highest version the sample supports. If CheckFeatureSupport succeeds, the HighestVersion returned will not be greater than this.
                HighestVersion = D3D_ROOT_SIGNATURE_VERSION_1_1
            };

            if (FAILED(D3DDevice->CheckFeatureSupport(D3D12_FEATURE_ROOT_SIGNATURE, &featureData, (uint)sizeof(D3D12_FEATURE))))
            {
                featureData.HighestVersion = D3D_ROOT_SIGNATURE_VERSION_1_0;
            }

            const int RootParametersCount = 2;
            var rootParameters = stackalloc D3D12_ROOT_PARAMETER1[RootParametersCount];

            { // const buffer
                const int RangesCount = 1;
                var ranges = stackalloc D3D12_DESCRIPTOR_RANGE1[RangesCount];

                ranges[0].Init(D3D12_DESCRIPTOR_RANGE_TYPE_CBV, 1, 0, 0, D3D12_DESCRIPTOR_RANGE_FLAG_DATA_STATIC);
                rootParameters[0].InitAsDescriptorTable(RangesCount, ranges, D3D12_SHADER_VISIBILITY_VERTEX);
            }

            { // texture
                const int RangesCount = 1;
                var ranges = stackalloc D3D12_DESCRIPTOR_RANGE1[RangesCount];

                ranges[0].Init(D3D12_DESCRIPTOR_RANGE_TYPE_SRV, 1, 0, 0, D3D12_DESCRIPTOR_RANGE_FLAG_DATA_STATIC);

                rootParameters[1].InitAsDescriptorTable(RangesCount, ranges, D3D12_SHADER_VISIBILITY_PIXEL);
            }

            var sampler = new D3D12_STATIC_SAMPLER_DESC {
                Filter = D3D12_FILTER.D3D12_FILTER_MIN_MAG_MIP_POINT,
                AddressU = D3D12_TEXTURE_ADDRESS_MODE_BORDER,
                AddressV = D3D12_TEXTURE_ADDRESS_MODE_BORDER,
                AddressW = D3D12_TEXTURE_ADDRESS_MODE_BORDER,
                MipLODBias = 0,
                MaxAnisotropy = 0,
                ComparisonFunc = D3D12_COMPARISON_FUNC_NEVER,
                BorderColor = D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK,
                MinLOD = 0.0f,
                MaxLOD = D3D12_FLOAT32_MAX,
                ShaderRegister = 0,
                RegisterSpace = 0,
                ShaderVisibility = D3D12_SHADER_VISIBILITY_PIXEL,
            };

            var rootSignatureFlags = // Allow input layout and deny unnecessary access to certain pipeline stages.
                D3D12_ROOT_SIGNATURE_FLAG_ALLOW_INPUT_ASSEMBLER_INPUT_LAYOUT
                | D3D12_ROOT_SIGNATURE_FLAG_DENY_HULL_SHADER_ROOT_ACCESS
                | D3D12_ROOT_SIGNATURE_FLAG_DENY_DOMAIN_SHADER_ROOT_ACCESS
                | D3D12_ROOT_SIGNATURE_FLAG_DENY_GEOMETRY_SHADER_ROOT_ACCESS
                ;

            var rootSignatureDesc = new D3D12_VERSIONED_ROOT_SIGNATURE_DESC();
            rootSignatureDesc.Init_1_1(RootParametersCount, rootParameters, 1, &sampler, rootSignatureFlags);

            ThrowIfFailed(nameof(D3D12SerializeVersionedRootSignature), D3D12SerializeVersionedRootSignature(&rootSignatureDesc, featureData.HighestVersion, signature.GetAddressOf(), error.GetAddressOf()));

            ID3D12RootSignature* rootSignature;

            var iid = IID_ID3D12RootSignature;
            ThrowIfFailed(nameof(ID3D12Device.CreateRootSignature), D3DDevice->CreateRootSignature(0, signature.Get()->GetBufferPointer(), signature.Get()->GetBufferSize(), &iid, (void**)&rootSignature));

            return rootSignature;
        }

        public override void OnUpdate()
        {
            const float ScaleSpeed = 1.005f;
            const float ScaleBounds = 1.25f;

            float scale = _constantBufferData.Matrix4x4.M11 * ScaleSpeed;

            if (scale > ScaleBounds)
            {
                scale = 1.0f / ScaleBounds;
            }
            _constantBufferData.Matrix4x4.M11 = scale;
            _constantBufferData.Matrix4x4.M22 = scale;
            _constantBufferData.Matrix4x4.M33 = scale;
            Unsafe.CopyBlock(ref _constantBufferDataBegin[0], ref Unsafe.As<SceneConstantBuffer, byte>(ref _constantBufferData), (uint)sizeof(SceneConstantBuffer));
        }

        protected override void Draw()
        {
            GraphicsCommandList->IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST);

            fixed (D3D12_VERTEX_BUFFER_VIEW* vertexBufferView = &_vertexBufferView)
            {
                GraphicsCommandList->IASetVertexBuffers(StartSlot: 0, 1, vertexBufferView);
            }

            GraphicsCommandList->DrawInstanced(VertexCountPerInstance: 3, InstanceCount: 1, StartVertexLocation: 0, StartInstanceLocation: 0);
        }

        protected override void DestroyAssets()
        {
            DestroyConstantBuffer();
            DestroyTexture();
            DestroyVertexBuffer();
            base.DestroyAssets();

            void DestroyConstantBuffer()
            {
                var constantBuffer = _constantBuffer;

                if (constantBuffer != null)
                {
                    _constantBuffer = null;

                    var writtenRange = new D3D12_RANGE();
                    constantBuffer->Unmap(Subresource: 0, &writtenRange);

                    _ = constantBuffer->Release();
                }
            }

            void DestroyTexture()
            {
                var texture = _texture;

                if (texture != null)
                {
                    _texture = null;
                    _ = texture->Release();
                }
            }

            void DestroyVertexBuffer()
            {
                var vertexBuffer = _vertexBuffer;

                if (vertexBuffer != null)
                {
                    _vertexBuffer = null;
                    _ = vertexBuffer->Release();
                }
            }
        }

        protected override void DestroyDescriptorHeaps()
        {
            DestroyCbvSrvHeap();
            base.DestroyDescriptorHeaps();

            void DestroyCbvSrvHeap()
            {
                var cbvSrvHeap = _cbv_srv_Heap;

                if (cbvSrvHeap != null)
                {
                    _cbv_srv_Heap = null;
                    _ = cbvSrvHeap->Release();
                }
            }
        }

        protected override void SetGraphicsCommandListState()
        {
            base.SetGraphicsCommandListState();

            const uint HeapsCount = 1;
            var ppHeaps = stackalloc ID3D12DescriptorHeap*[(int)HeapsCount] {
                _cbv_srv_Heap,
            };
            GraphicsCommandList->SetDescriptorHeaps(HeapsCount, ppHeaps);
            GraphicsCommandList->SetGraphicsRootDescriptorTable(0, _cbv_srv_Heap->GetGPUDescriptorHandleForHeapStart());
        }

        public struct Vertex
        {
            public Vector3 Position;
            public System.Numerics.Vector2 UV;
        }

        private struct SceneConstantBuffer
        {
            public System.Numerics.Matrix4x4 Matrix4x4;
        }
    }
}
