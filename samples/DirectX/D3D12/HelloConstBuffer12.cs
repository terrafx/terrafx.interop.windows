// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12HelloConstBuffor in https://github.com/Microsoft/DirectX-Graphics-Samples
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using TerraFX.Interop;
using static TerraFX.Interop.D3D_ROOT_SIGNATURE_VERSION;
using static TerraFX.Interop.D3D12_DESCRIPTOR_HEAP_FLAGS;
using static TerraFX.Interop.D3D12_DESCRIPTOR_HEAP_TYPE;
using static TerraFX.Interop.D3D12_DESCRIPTOR_RANGE_FLAGS;
using static TerraFX.Interop.D3D12_DESCRIPTOR_RANGE_TYPE;
using static TerraFX.Interop.D3D12_FEATURE;
using static TerraFX.Interop.D3D12_HEAP_FLAGS;
using static TerraFX.Interop.D3D12_HEAP_TYPE;
using static TerraFX.Interop.D3D12_INPUT_CLASSIFICATION;
using static TerraFX.Interop.D3D12_PRIMITIVE_TOPOLOGY_TYPE;
using static TerraFX.Interop.D3D12_RESOURCE_STATES;
using static TerraFX.Interop.D3D12_ROOT_SIGNATURE_FLAGS;
using static TerraFX.Interop.D3D12_SHADER_VISIBILITY;
using static TerraFX.Interop.DXGI_FORMAT;
using static TerraFX.Interop.Windows;
using static TerraFX.Samples.DirectX.DXSampleHelper;

namespace TerraFX.Samples.DirectX.D3D12
{
    public unsafe class HelloConstBuffer12 : HelloTriangle12
    {
        private ID3D12DescriptorHeap* _cbvHeap;
        private ID3D12Resource* _constantBuffer;
        private byte* _constantBufferDataBegin;
        private SceneConstantBuffer _constantBufferData;

        public HelloConstBuffer12(string name) : base(name)
        {
        }

        public override void OnUpdate(TimeSpan delta)
        {
            const float TranslationSpeed = 0.005f;
            const float OffsetBounds = 1.25f;

            _constantBufferData.Offset.X += TranslationSpeed;
            if (_constantBufferData.Offset.X > OffsetBounds)
            {
                _constantBufferData.Offset.X = -OffsetBounds;
            }
            Unsafe.CopyBlock(ref _constantBufferDataBegin[0], ref Unsafe.As<SceneConstantBuffer, byte>(ref _constantBufferData), (uint)sizeof(SceneConstantBuffer));
        }

        protected override void CreateBuffers()
        {
            base.CreateBuffers();
            _constantBuffer = CreateConstantBuffer(out _constantBufferDataBegin);

            ID3D12Resource* CreateConstantBuffer(out byte* constantBufferDataBegin)
            {
                ID3D12Resource* constantBuffer;

                var heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_UPLOAD);
                var bufferDesc = D3D12_RESOURCE_DESC.Buffer(1024 * 64);

                var iid = IID_ID3D12Resource;
                ThrowIfFailed(D3DDevice->CreateCommittedResource(&heapProperties, D3D12_HEAP_FLAG_NONE, &bufferDesc, D3D12_RESOURCE_STATE_GENERIC_READ, pOptimizedClearValue: null, &iid, (void**)&constantBuffer));

                var cbvDesc = new D3D12_CONSTANT_BUFFER_VIEW_DESC {
                    BufferLocation = constantBuffer->GetGPUVirtualAddress(),
                    SizeInBytes = (uint)((sizeof(SceneConstantBuffer) + 255) & ~255)    // CB size is required to be 256-byte aligned.
                };
                D3DDevice->CreateConstantBufferView(&cbvDesc, _cbvHeap->GetCPUDescriptorHandleForHeapStart());

                // Map and initialize the constant buffer. We don't unmap this until the
                // app closes. Keeping things mapped for the lifetime of the resource is okay.

                fixed (byte** pConstantBufferDataBegin = &constantBufferDataBegin)
                {
                    var readRange = new D3D12_RANGE(); // We do not intend to read from this resource on the CPU.
                    ThrowIfFailed(constantBuffer->Map(Subresource: 0, &readRange, (void**)pConstantBufferDataBegin));
                    Unsafe.CopyBlock(ref constantBufferDataBegin[0], ref Unsafe.As<SceneConstantBuffer, byte>(ref _constantBufferData), (uint)sizeof(SceneConstantBuffer));
                }

                return constantBuffer;
            }
        }

        protected override void CreateDescriptorHeaps()
        {
            _cbvHeap = CreateCBVHeap();
            base.CreateDescriptorHeaps();

            ID3D12DescriptorHeap* CreateCBVHeap()
            {
                var cbvHeapDesc = new D3D12_DESCRIPTOR_HEAP_DESC {
                    NumDescriptors = 1,
                    Flags = D3D12_DESCRIPTOR_HEAP_FLAG_SHADER_VISIBLE,
                    Type = D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV,
                };

                ID3D12DescriptorHeap* cbvHeap;

                var iid = IID_ID3D12DescriptorHeap;
                ThrowIfFailed(D3DDevice->CreateDescriptorHeap(&cbvHeapDesc, &iid, (void**)&cbvHeap));

                return cbvHeap;
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
            fixed (char* fileName = GetAssetFullPath(@"D3D12\Assets\Shaders\HelloConstBuffer.hlsl"))
            {
                var entryPoint = 0x00006E69614D5356;    // VSMain
                var target = 0x0000305F355F7376;        // vs_5_0
                ThrowIfFailed(D3DCompileFromFile((ushort*)fileName, pDefines: null, pInclude: null, (sbyte*)&entryPoint, (sbyte*)&target, compileFlags, Flags2: 0, vertexShader.GetAddressOf(), ppErrorMsgs: null));

                entryPoint = 0x00006E69614D5350;        // PSMain
                target = 0x0000305F355F7370;            // ps_5_0
                ThrowIfFailed(D3DCompileFromFile((ushort*)fileName, pDefines: null, pInclude: null, (sbyte*)&entryPoint, (sbyte*)&target, compileFlags, Flags2: 0, pixelShader.GetAddressOf(), ppErrorMsgs: null));
            }

            // Define the vertex input layout.
            const int InputElementDescsCount = 2;

            var semanticName0 = stackalloc ulong[2] {
                0x4E4F495449534F50,     // POSITION
                0x0000000000000000,
            };

            var semanticName1 = stackalloc ulong[1] {
                0x000000524F4C4F43,     // COLOR
            };

            var inputElementDescs = stackalloc D3D12_INPUT_ELEMENT_DESC[InputElementDescsCount] {
                new D3D12_INPUT_ELEMENT_DESC {
                    SemanticName = (sbyte*)semanticName0,
                    Format = DXGI_FORMAT_R32G32B32_FLOAT,
                    InputSlotClass = D3D12_INPUT_CLASSIFICATION_PER_VERTEX_DATA,
                },
                new D3D12_INPUT_ELEMENT_DESC {
                    SemanticName = (sbyte*)semanticName1,
                    Format = DXGI_FORMAT_R32G32B32A32_FLOAT,
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
                DepthStencilState = D3D12_DEPTH_STENCIL_DESC.DEFAULT,
                SampleMask = uint.MaxValue,
                PrimitiveTopologyType = D3D12_PRIMITIVE_TOPOLOGY_TYPE_TRIANGLE,
                NumRenderTargets = 1,
                SampleDesc = new DXGI_SAMPLE_DESC(count: 1, quality: 0),
            };
            psoDesc.DepthStencilState.DepthEnable = FALSE;
            psoDesc.RTVFormats[0] = DXGI_FORMAT_R8G8B8A8_UNORM;

            ID3D12PipelineState* pipelineState;

            var iid = IID_ID3D12PipelineState;
            ThrowIfFailed(D3DDevice->CreateGraphicsPipelineState(&psoDesc, &iid, (void**)&pipelineState));

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

            if (FAILED(D3DDevice->CheckFeatureSupport(D3D12_FEATURE_ROOT_SIGNATURE, &featureData, (uint)sizeof(D3D12_FEATURE_DATA_ROOT_SIGNATURE))))
            {
                featureData.HighestVersion = D3D_ROOT_SIGNATURE_VERSION_1_0;
            }

            const int RangesCount = 1;
            var ranges = stackalloc D3D12_DESCRIPTOR_RANGE1[RangesCount];
            const int RootParametersCount = 1;
            var rootParameters = stackalloc D3D12_ROOT_PARAMETER1[RootParametersCount];

            ranges[0].Init(D3D12_DESCRIPTOR_RANGE_TYPE_CBV, 1, 0, 0, D3D12_DESCRIPTOR_RANGE_FLAG_DATA_STATIC);
            rootParameters[0].InitAsDescriptorTable(RangesCount, ranges, D3D12_SHADER_VISIBILITY_VERTEX);

            // Allow input layout and deny unnecessary access to certain pipeline stages.
            var rootSignatureFlags =
                D3D12_ROOT_SIGNATURE_FLAG_ALLOW_INPUT_ASSEMBLER_INPUT_LAYOUT |
                D3D12_ROOT_SIGNATURE_FLAG_DENY_HULL_SHADER_ROOT_ACCESS |
                D3D12_ROOT_SIGNATURE_FLAG_DENY_DOMAIN_SHADER_ROOT_ACCESS |
                D3D12_ROOT_SIGNATURE_FLAG_DENY_GEOMETRY_SHADER_ROOT_ACCESS |
                D3D12_ROOT_SIGNATURE_FLAG_DENY_PIXEL_SHADER_ROOT_ACCESS;

            var rootSignatureDesc = new D3D12_VERSIONED_ROOT_SIGNATURE_DESC();
            rootSignatureDesc.Init_1_1(RootParametersCount, rootParameters, 0, null, rootSignatureFlags);

            ThrowIfFailed(D3D12SerializeVersionedRootSignature(&rootSignatureDesc, featureData.HighestVersion, signature.GetAddressOf(), error.GetAddressOf()));

            ID3D12RootSignature* rootSignature;

            var iid = IID_ID3D12RootSignature;
            ThrowIfFailed(D3DDevice->CreateRootSignature(0, signature.Get()->GetBufferPointer(), signature.Get()->GetBufferSize(), &iid, (void**)&rootSignature));

            return rootSignature;
        }

        protected override void DestroyBuffers()
        {
            DestroyConstantBuffer();
            base.DestroyBuffers();

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
        }

        protected override void DestroyDescriptorHeaps()
        {
            DestroyCBVHeap();
            base.DestroyDescriptorHeaps();

            void DestroyCBVHeap()
            {
                var cbvHeap = _cbvHeap;

                if (cbvHeap != null)
                {
                    _cbvHeap = null;
                    _ = cbvHeap->Release();
                }
            }
        }

        protected override void SetGraphicsCommandListState()
        {
            base.SetGraphicsCommandListState();

            const uint HeapsCount = 1;
            var ppHeaps = stackalloc ID3D12DescriptorHeap*[(int)HeapsCount] {
                _cbvHeap
            };
            GraphicsCommandList->SetDescriptorHeaps(HeapsCount, ppHeaps);
            GraphicsCommandList->SetGraphicsRootDescriptorTable(0, _cbvHeap->GetGPUDescriptorHandleForHeapStart());
        }

        private struct SceneConstantBuffer
        {
            public Vector4 Offset;
        };
    }
}
