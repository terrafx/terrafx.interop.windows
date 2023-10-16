// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12HelloTexture in https://github.com/Microsoft/DirectX-Graphics-Samples
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using TerraFX.Interop.DirectX;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.DirectX.D3D12;
using static TerraFX.Interop.DirectX.D3D12_COMPARISON_FUNC;
using static TerraFX.Interop.DirectX.D3D12_DESCRIPTOR_HEAP_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_DESCRIPTOR_HEAP_TYPE;
using static TerraFX.Interop.DirectX.D3D12_DESCRIPTOR_RANGE_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_DESCRIPTOR_RANGE_TYPE;
using static TerraFX.Interop.DirectX.D3D12_FEATURE;
using static TerraFX.Interop.DirectX.D3D12_HEAP_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_HEAP_TYPE;
using static TerraFX.Interop.DirectX.D3D12_INPUT_CLASSIFICATION;
using static TerraFX.Interop.DirectX.D3D12_PRIMITIVE_TOPOLOGY_TYPE;
using static TerraFX.Interop.DirectX.D3D12_RESOURCE_DIMENSION;
using static TerraFX.Interop.DirectX.D3D12_RESOURCE_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_RESOURCE_STATES;
using static TerraFX.Interop.DirectX.D3D12_ROOT_SIGNATURE_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_SHADER_VISIBILITY;
using static TerraFX.Interop.DirectX.D3D12_SRV_DIMENSION;
using static TerraFX.Interop.DirectX.D3D12_STATIC_BORDER_COLOR;
using static TerraFX.Interop.DirectX.D3D12_TEXTURE_ADDRESS_MODE;
using static TerraFX.Interop.DirectX.D3DCOMPILE;
using static TerraFX.Interop.DirectX.D3D_ROOT_SIGNATURE_VERSION;
using static TerraFX.Interop.DirectX.DirectX;
using static TerraFX.Interop.DirectX.DXGI_FORMAT;
using static TerraFX.Interop.Windows.Windows;
using static TerraFX.Samples.DirectX.DXSampleHelper;

namespace TerraFX.Samples.DirectX.D3D12;

[SupportedOSPlatform("windows10.0")]
public unsafe class HelloTexture12 : HelloTriangle12
{
    private const uint TextureWidth = 256;
    private const uint TextureHeight = 256;
    private const uint TexturePixelSize = 4;

    private ID3D12DescriptorHeap* _srvHeap;
    private ID3D12Resource* _texture;

    public HelloTexture12(string name) : base(name)
    {
    }

    protected override void CreateAssets()
    {
        using ComPtr<ID3D12Resource> textureUploadHeap = null;

        _texture = CreateTexture();
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
            var iid = __uuidof<ID3D12Resource>();

            var heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_DEFAULT);
            ThrowIfFailed(D3DDevice->CreateCommittedResource(
                &heapProperties,
                D3D12_HEAP_FLAG_NONE,
                &textureDesc,
                D3D12_RESOURCE_STATE_COPY_DEST,
                pOptimizedClearValue: null,
                iid,
                (void**)&texture
            ));

            var uploadBufferSize = GetRequiredIntermediateSize(texture, 0, 1);

            // Create the GPU upload buffer.
            heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_UPLOAD);
            var bufferDesc = D3D12_RESOURCE_DESC.Buffer(uploadBufferSize);
            ThrowIfFailed(D3DDevice->CreateCommittedResource(
                &heapProperties,
                D3D12_HEAP_FLAG_NONE,
                &bufferDesc,
                D3D12_RESOURCE_STATE_GENERIC_READ,
                pOptimizedClearValue: null,
                iid,
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
            _ = UpdateSubresources(GraphicsCommandList, texture, textureUploadHeap, 0, 0, 1, &textureSubresourceData);
            var barrier = D3D12_RESOURCE_BARRIER.InitTransition(texture, D3D12_RESOURCE_STATE_COPY_DEST, D3D12_RESOURCE_STATE_PIXEL_SHADER_RESOURCE);
            GraphicsCommandList->ResourceBarrier(1, &barrier);

            // Describe and create a SRV for the texture.
            var srvDesc = new D3D12_SHADER_RESOURCE_VIEW_DESC {
                Shader4ComponentMapping = D3D12_DEFAULT_SHADER_4_COMPONENT_MAPPING,
                Format = textureDesc.Format,
                ViewDimension = D3D12_SRV_DIMENSION_TEXTURE2D,
            };
            srvDesc.Anonymous.Texture2D.MipLevels = 1;

            D3DDevice->CreateShaderResourceView(texture, &srvDesc, _srvHeap->GetCPUDescriptorHandleForHeapStart());

            return texture;
        }

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

    protected override void CreateDescriptorHeaps()
    {
        base.CreateDescriptorHeaps();
        _srvHeap = CreateSRVHeap();

        ID3D12DescriptorHeap* CreateSRVHeap()
        {
            var srvHeapDesc = new D3D12_DESCRIPTOR_HEAP_DESC {
                NumDescriptors = 1,
                Type = D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV,
                Flags = D3D12_DESCRIPTOR_HEAP_FLAG_SHADER_VISIBLE,
            };

            ID3D12DescriptorHeap* srvHeap;
            ThrowIfFailed(D3DDevice->CreateDescriptorHeap(&srvHeapDesc, __uuidof<ID3D12DescriptorHeap>(), (void**)&srvHeap));

            return srvHeap;
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
        fixed (char* fileName = GetAssetFullPath(@"D3D12\Assets\Shaders\HelloTexture.hlsl"))
        {
            var entryPoint = 0x00006E69614D5356;    // VSMain
            var target = 0x0000305F355F7376;        // vs_5_0
            ThrowIfFailed(D3DCompileFromFile(fileName, pDefines: null, pInclude: null, (sbyte*)&entryPoint, (sbyte*)&target, compileFlags, Flags2: 0, vertexShader.GetAddressOf(), ppErrorMsgs: null));

            entryPoint = 0x00006E69614D5350;        // PSMain
            target = 0x0000305F355F7370;            // ps_5_0
            ThrowIfFailed(D3DCompileFromFile(fileName, pDefines: null, pInclude: null, (sbyte*)&entryPoint, (sbyte*)&target, compileFlags, Flags2: 0, pixelShader.GetAddressOf(), ppErrorMsgs: null));
        }

        // Define the vertex input layout.
        const int InputElementDescsCount = 2;

        var semanticName0 = stackalloc ulong[2] {
            0x4E4F495449534F50,     // POSITION
            0x0000000000000000,
        };

        var semanticName1 = stackalloc ulong[2] {
            0x44524F4F43584554,     // TEXCOORD
            0x0000000000000000,
        };

        var inputElementDescs = stackalloc D3D12_INPUT_ELEMENT_DESC[InputElementDescsCount] {
            new D3D12_INPUT_ELEMENT_DESC {
                SemanticName = (sbyte*)semanticName0,
                Format = DXGI_FORMAT_R32G32B32_FLOAT,
                InputSlotClass = D3D12_INPUT_CLASSIFICATION_PER_VERTEX_DATA,
            },
            new D3D12_INPUT_ELEMENT_DESC {
                SemanticName = (sbyte*)semanticName1,
                Format = DXGI_FORMAT_R32G32_FLOAT,
                AlignedByteOffset = 12,
                InputSlotClass = D3D12_INPUT_CLASSIFICATION_PER_VERTEX_DATA,
            },
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
            DepthStencilState = new D3D12_DEPTH_STENCIL_DESC {
                DepthEnable = FALSE,
                StencilEnable = FALSE,
            },
            SampleMask = uint.MaxValue,
            PrimitiveTopologyType = D3D12_PRIMITIVE_TOPOLOGY_TYPE_TRIANGLE,
            NumRenderTargets = 1,
            SampleDesc = new DXGI_SAMPLE_DESC(count: 1, quality: 0),
        };
        psoDesc.RTVFormats[0] = DXGI_FORMAT_R8G8B8A8_UNORM;

        ID3D12PipelineState* pipelineState;
        ThrowIfFailed(D3DDevice->CreateGraphicsPipelineState(&psoDesc, __uuidof<ID3D12PipelineState>(), (void**)&pipelineState));

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

        if (D3DDevice->CheckFeatureSupport(D3D12_FEATURE_ROOT_SIGNATURE, &featureData, (uint)sizeof(D3D12_FEATURE)).FAILED)
        {
            featureData.HighestVersion = D3D_ROOT_SIGNATURE_VERSION_1_0;
        }

        const int RangesCount = 1;
        var ranges = stackalloc D3D12_DESCRIPTOR_RANGE1[RangesCount];
        ranges[0].Init(D3D12_DESCRIPTOR_RANGE_TYPE_SRV, 1, 0, 0, D3D12_DESCRIPTOR_RANGE_FLAG_DATA_STATIC);

        const int RootParametersCount = 1;
        var rootParameters = stackalloc D3D12_ROOT_PARAMETER1[RootParametersCount];
        rootParameters[0].InitAsDescriptorTable(1, ranges, D3D12_SHADER_VISIBILITY_PIXEL);

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

        var rootSignatureDesc = new D3D12_VERSIONED_ROOT_SIGNATURE_DESC();
        rootSignatureDesc.Init_1_1(RootParametersCount, rootParameters, 1, &sampler, D3D12_ROOT_SIGNATURE_FLAG_ALLOW_INPUT_ASSEMBLER_INPUT_LAYOUT);

        ThrowIfFailed(D3D12SerializeVersionedRootSignature(
            &rootSignatureDesc, featureData.HighestVersion, signature.GetAddressOf(), error.GetAddressOf()));

        ID3D12RootSignature* rootSignature;
        ThrowIfFailed(D3DDevice->CreateRootSignature(0, signature.Get()->GetBufferPointer(), signature.Get()->GetBufferSize(), __uuidof<ID3D12RootSignature>(), (void**)&rootSignature));

        return rootSignature;
    }

    protected override unsafe ID3D12Resource* CreateVertexBuffer(out D3D12_VERTEX_BUFFER_VIEW vertexBufferView)
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

        ThrowIfFailed(D3DDevice->CreateCommittedResource(
            &heapProperties,
            D3D12_HEAP_FLAG_NONE,
            &bufferDesc,
            D3D12_RESOURCE_STATE_GENERIC_READ,
            pOptimizedClearValue: null,
            __uuidof<ID3D12Resource>(),
            (void**)&vertexBuffer
        ));

        // Copy the triangle data to the vertex buffer.
        var readRange = new D3D12_RANGE();
        byte* pVertexDataBegin;
        ThrowIfFailed(vertexBuffer->Map(Subresource: 0, &readRange, (void**)&pVertexDataBegin));
        Unsafe.CopyBlock(pVertexDataBegin, triangleVertices, vertexBufferSize);
        vertexBuffer->Unmap(0, null);

        // Initialize the vertex buffer view.
        vertexBufferView.BufferLocation = vertexBuffer->GetGPUVirtualAddress();
        vertexBufferView.StrideInBytes = (uint)sizeof(Vertex);
        vertexBufferView.SizeInBytes = vertexBufferSize;

        return vertexBuffer;
    }

    protected override void DestroyAssets()
    {
        DestroyTexture();
        base.DestroyAssets();

        void DestroyTexture()
        {
            var texture = _texture;

            if (texture != null)
            {
                _texture = null;
                _ = texture->Release();
            }
        }
    }

    protected override void DestroyDescriptorHeaps()
    {
        DestroySRVHeap();
        base.DestroyDescriptorHeaps();

        void DestroySRVHeap()
        {
            var srvHeap = _srvHeap;

            if (srvHeap != null)
            {
                _srvHeap = null;
                _ = srvHeap->Release();
            }
        }
    }

    protected override void SetGraphicsCommandListState()
    {
        base.SetGraphicsCommandListState();

        const uint HeapsCount = 1;
        var ppHeaps = stackalloc ID3D12DescriptorHeap*[(int)HeapsCount] {
            _srvHeap
        };
        GraphicsCommandList->SetDescriptorHeaps(HeapsCount, ppHeaps);

        GraphicsCommandList->SetGraphicsRootDescriptorTable(0, _srvHeap->GetGPUDescriptorHandleForHeapStart());
    }

    internal new struct Vertex
    {
        public Vector3 Position;

        public Vector2 UV;
    }
}
