// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12HelloTexture in https://github.com/Microsoft/DirectX-Graphics-Samples
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop;
using static TerraFX.Interop.D3D_FEATURE_LEVEL;
using static TerraFX.Interop.D3D_PRIMITIVE_TOPOLOGY;
using static TerraFX.Interop.D3D_ROOT_SIGNATURE_VERSION;
using static TerraFX.Interop.D3D12;
using static TerraFX.Interop.D3D12_BLEND;
using static TerraFX.Interop.D3D12_BLEND_OP;
using static TerraFX.Interop.D3D12_COLOR_WRITE_ENABLE;
using static TerraFX.Interop.D3D12_COMMAND_LIST_TYPE;
using static TerraFX.Interop.D3D12_CONSERVATIVE_RASTERIZATION_MODE;
using static TerraFX.Interop.D3D12_CPU_PAGE_PROPERTY;
using static TerraFX.Interop.D3D12_CULL_MODE;
using static TerraFX.Interop.D3D12_DESCRIPTOR_HEAP_FLAGS;
using static TerraFX.Interop.D3D12_DESCRIPTOR_HEAP_TYPE;
using static TerraFX.Interop.D3D12_DESCRIPTOR_RANGE_FLAGS;
using static TerraFX.Interop.D3D12_DESCRIPTOR_RANGE_TYPE;
using static TerraFX.Interop.D3D12_FEATURE;
using static TerraFX.Interop.D3D12_FENCE_FLAGS;
using static TerraFX.Interop.D3D12_FILL_MODE;
using static TerraFX.Interop.D3D12_HEAP_FLAGS;
using static TerraFX.Interop.D3D12_HEAP_TYPE;
using static TerraFX.Interop.D3D12_INPUT_CLASSIFICATION;
using static TerraFX.Interop.D3D12_LOGIC_OP;
using static TerraFX.Interop.D3D12_MEMORY_POOL;
using static TerraFX.Interop.D3D12_PRIMITIVE_TOPOLOGY_TYPE;
using static TerraFX.Interop.D3D12_RESOURCE_DIMENSION;
using static TerraFX.Interop.D3D12_RESOURCE_FLAGS;
using static TerraFX.Interop.D3D12_RESOURCE_STATES;
using static TerraFX.Interop.D3D12_ROOT_SIGNATURE_FLAGS;
using static TerraFX.Interop.D3D12_SHADER_VISIBILITY;
using static TerraFX.Interop.D3D12_SRV_DIMENSION;
using static TerraFX.Interop.D3D12_TEXTURE_LAYOUT;
using static TerraFX.Interop.D3DCompiler;
using static TerraFX.Interop.DXGI;
using static TerraFX.Interop.DXGI_FORMAT;
using static TerraFX.Interop.DXGI_SWAP_EFFECT;
using static TerraFX.Interop.Kernel32;
using static TerraFX.Interop.Windows;
using static TerraFX.Samples.DirectX.DXSampleHelper;

namespace TerraFX.Samples.DirectX.D3D12
{
    public unsafe class HelloTexture12 : DX12Sample
    {
        private const uint FrameCount = 2;
        private const uint TextureWidth = 256;
        private const uint TextureHeight = 256;
        private const uint TexturePixelSize = 4;    // The number of bytes used to represent a pixel in the texture.

        // Pipeline objects
        private D3D12_VIEWPORT _viewport;
        private RECT _scissorRect;
        private IDXGISwapChain3* _swapChain;
        private ID3D12Device* _device;
        private readonly ID3D12Resource*[] _renderTargets;
        private ID3D12CommandAllocator* _commandAllocator;
        private ID3D12CommandQueue* _commandQueue;
        private ID3D12RootSignature* _rootSignature;
        private ID3D12DescriptorHeap* _rtvHeap;
        private ID3D12DescriptorHeap* _srvHeap;
        private ID3D12PipelineState* _pipelineState;
        private ID3D12GraphicsCommandList* _commandList;
        private uint _rtvDescriptorSize;
        private uint _srvDescriptorSize;

        // App resources.
        private ID3D12Resource* _vertexBuffer;
        private D3D12_VERTEX_BUFFER_VIEW _vertexBufferView;
        private ID3D12Resource* _texture;

        // Synchronization objects.
        private uint _frameIndex;
        private HANDLE _fenceEvent;
        private ID3D12Fence* _fence;
        private ulong _fenceValue;

        public HelloTexture12(uint width, uint height, string name)
            : base(width, height, name)
        {
            _renderTargets = new ID3D12Resource*[FrameCount];

            _viewport = new D3D12_VIEWPORT {
                TopLeftX = 0,
                TopLeftY = 0,
                Width = width,
                Height = height,
                MinDepth = D3D12_MIN_DEPTH,
                MaxDepth = D3D12_MAX_DEPTH
            };

            _scissorRect = new RECT {
                left = 0,
                top = 0,
                right = unchecked((int)width),
                bottom = unchecked((int)height)
            };
        }

        public override void OnInit()
        {
            LoadPipeline();
            LoadAssets();
        }

        // Update frame-based values.
        public override void OnUpdate()
        {
        }

        // Render the scene.
        public override void OnRender()
        {
            // Record all the commands we need to render the scene into the command list.
            PopulateCommandList();

            // Execute the command list.
            const int CommandListsCount = 1;
            var ppCommandLists = stackalloc ID3D12CommandList*[CommandListsCount] {
                (ID3D12CommandList*)_commandList,
            };
            _commandQueue->ExecuteCommandLists(CommandListsCount, ppCommandLists);

            // Present the frame.
            ThrowIfFailed(nameof(IDXGISwapChain3.Present), _swapChain->Present(SyncInterval: 1, Flags: 0));

            WaitForPreviousFrame();
        }

        public override void OnDestroy()
        {
            // Ensure that the GPU is no longer referencing resources that are about to be
            // cleaned up by the destructor.
            WaitForPreviousFrame();

            _ = CloseHandle(_fenceEvent);
        }

        // Load the rendering pipeline dependencies.
        private void LoadPipeline()
        {
            Guid iid;
            ID3D12Debug* debugController = null;
            IDXGIFactory4* factory = null;
            IDXGIAdapter* adapter = null;
            IDXGISwapChain1* swapChain = null;

            try
            {
                var dxgiFactoryFlags = 0u;

#if DEBUG
                // Enable the debug layer (requires the Graphics Tools "optional feature").
                // NOTE: Enabling the debug layer after device creation will invalidate the active device.
                {
                    iid = IID_ID3D12Debug;
                    if (SUCCEEDED(D3D12GetDebugInterface(&iid, (void**)&debugController)))
                    {
                        debugController->EnableDebugLayer();

                        // Enable additional debug layers.
                        dxgiFactoryFlags |= DXGI_CREATE_FACTORY_DEBUG;
                    }
                }
#endif

                iid = IID_IDXGIFactory4;
                ThrowIfFailed(nameof(CreateDXGIFactory2), CreateDXGIFactory2(dxgiFactoryFlags, &iid, (void**)&factory));

                if (UseWarpDevice)
                {
                    iid = IID_IDXGIAdapter;
                    ThrowIfFailed(nameof(IDXGIFactory4.EnumWarpAdapter), factory->EnumWarpAdapter(&iid, (void**)&adapter));
                }
                else
                {
                    adapter = GetHardwareAdapter((IDXGIFactory1*)factory);
                }

                fixed (ID3D12Device** device = &_device)
                {
                    iid = IID_ID3D12Device;
                    ThrowIfFailed(nameof(D3D12CreateDevice), D3D12CreateDevice((IUnknown*)adapter, D3D_FEATURE_LEVEL_11_0, &iid, (void**)device));
                }

                // Describe and create the command queue.
                var queueDesc = new D3D12_COMMAND_QUEUE_DESC();

                fixed (ID3D12CommandQueue** commandQueue = &_commandQueue)
                {
                    iid = IID_ID3D12CommandQueue;
                    ThrowIfFailed(nameof(ID3D12Device.CreateCommandQueue), _device->CreateCommandQueue(&queueDesc, &iid, (void**)commandQueue));
                }

                // Describe and create the swap chain.
                var swapChainDesc = new DXGI_SWAP_CHAIN_DESC1 {
                    BufferCount = FrameCount,
                    Width = Width,
                    Height = Height,
                    Format = DXGI_FORMAT_R8G8B8A8_UNORM,
                    BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT,
                    SwapEffect = DXGI_SWAP_EFFECT_FLIP_DISCARD,
                    SampleDesc = new DXGI_SAMPLE_DESC(count: 1, quality: 0),
                };

                ThrowIfFailed(nameof(IDXGIFactory4.CreateSwapChainForHwnd), factory->CreateSwapChainForHwnd(
                    (IUnknown*)_commandQueue,         // Swap chain needs the queue so that it can force a flush on it.
                    Win32Application.Hwnd,
                    &swapChainDesc,
                    pFullscreenDesc: null,
                    pRestrictToOutput: null,
                    &swapChain
                ));

                // This sample does not support fullscreen transitions.
                ThrowIfFailed(nameof(IDXGIFactory4.MakeWindowAssociation), factory->MakeWindowAssociation(Win32Application.Hwnd, DXGI_MWA_NO_ALT_ENTER));

                fixed (IDXGISwapChain3** swapChain3 = &_swapChain)
                {
                    iid = IID_IDXGISwapChain3;
                    ThrowIfFailed(nameof(IDXGISwapChain1.QueryInterface), swapChain->QueryInterface(&iid, (void**)swapChain3));
                    _frameIndex = _swapChain->GetCurrentBackBufferIndex();
                }

                // Create descriptor heaps.
                {
                    // Describe and create a render target view (RTV) descriptor heap.
                    var rtvHeapDesc = new D3D12_DESCRIPTOR_HEAP_DESC {
                        NumDescriptors = FrameCount,
                        Type = D3D12_DESCRIPTOR_HEAP_TYPE_RTV,
                    };

                    fixed (ID3D12DescriptorHeap** rtvHeap = &_rtvHeap)
                    {
                        iid = IID_ID3D12DescriptorHeap;
                        ThrowIfFailed(nameof(ID3D12Device.CreateDescriptorHeap), _device->CreateDescriptorHeap(&rtvHeapDesc, &iid, (void**)rtvHeap));
                    }

                    _rtvDescriptorSize = _device->GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE_RTV);

                    // Describe and create a shader resource view (SRV) heap for the texture.
                    var srvHeapDesc = new D3D12_DESCRIPTOR_HEAP_DESC {
                        NumDescriptors = 1,
                        Type = D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV,
                        Flags = D3D12_DESCRIPTOR_HEAP_FLAG_SHADER_VISIBLE,
                    };
                    fixed (ID3D12DescriptorHeap** srvHeap = &_srvHeap)
                    {
                        iid = IID_ID3D12DescriptorHeap;
                        ThrowIfFailed(nameof(ID3D12Device.CreateDescriptorHeap), _device->CreateDescriptorHeap(&srvHeapDesc, &iid, (void**)srvHeap));
                    }

                    _srvDescriptorSize = _device->GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV);
                }

                // Create frame resources.
                {
                    var rtvHandle = _rtvHeap->GetCPUDescriptorHandleForHeapStart();

                    // Create a RTV for each frame.
                    iid = IID_ID3D12Resource;

                    for (var n = 0u; n < FrameCount; n++)
                    {
                        ID3D12Resource* renderTarget;
                        {
                            ThrowIfFailed(nameof(IDXGISwapChain3.GetBuffer), _swapChain->GetBuffer(n, &iid, (void**)&renderTarget));
                            _device->CreateRenderTargetView(renderTarget, pDesc: null, rtvHandle);
                            rtvHandle.Offset(1, _rtvDescriptorSize);
                        }
                        _renderTargets[unchecked((int)n)] = renderTarget;
                    }
                }

                fixed (ID3D12CommandAllocator** commandAllocator = &_commandAllocator)
                {
                    iid = IID_ID3D12CommandAllocator;
                    ThrowIfFailed(nameof(ID3D12Device.CreateRenderTargetView), _device->CreateCommandAllocator(D3D12_COMMAND_LIST_TYPE_DIRECT, &iid, (void**)commandAllocator));
                }
            }
            finally
            {
                if (debugController != null)
                {
                    debugController->Release();
                }

                if (factory != null)
                {
                    factory->Release();
                }

                if (adapter != null)
                {
                    adapter->Release();
                }

                if (swapChain != null)
                {
                    swapChain->Release();
                }
            }
        }

        // Load the sample assets.
        private void LoadAssets()
        {
            Guid iid;
            ID3DBlob* signature = null;
            ID3DBlob* error = null;
            ID3DBlob* vertexShader = null;
            ID3DBlob* pixelShader = null;

            try
            {
                // Create the root signature.
                {
                    bool isThisUseful = false; // transferred here from C# HelloTriangle, is not in C++ HelloTexture, but without it crashes on CreateRootSignature
                    if (isThisUseful)
                    {
                        var rootSignatureDesc1 = new D3D12_ROOT_SIGNATURE_DESC {
                            Flags = D3D12_ROOT_SIGNATURE_FLAG_ALLOW_INPUT_ASSEMBLER_INPUT_LAYOUT
                        };

                        ThrowIfFailed(nameof(D3D12SerializeRootSignature), D3D12SerializeRootSignature(&rootSignatureDesc1, D3D_ROOT_SIGNATURE_VERSION_1, &signature, &error));
                    }

                    fixed (ID3D12RootSignature** rootSignature = &_rootSignature)
                    {
                        iid = IID_ID3D12RootSignature;
                        ThrowIfFailed(nameof(ID3D12Device._CreateRootSignature), _device->CreateRootSignature(nodeMask: 0, signature->GetBufferPointer(), signature->GetBufferSize(), &iid, (void**)rootSignature));
                    }

                    var featureData = new D3D12_FEATURE_DATA_ROOT_SIGNATURE {
                        // This is the highest version the sample supports. If CheckFeatureSupport succeeds, the HighestVersion returned will not be greater than this.
                        HighestVersion = D3D_ROOT_SIGNATURE_VERSION_1_1
                    };

                    if (FAILED(_device->CheckFeatureSupport(D3D12_FEATURE_ROOT_SIGNATURE, &featureData, (uint)sizeof(D3D12_FEATURE_DATA_ROOT_SIGNATURE))))
                    {
                        featureData.HighestVersion = D3D_ROOT_SIGNATURE_VERSION_1_0;
                    }

                    const int RangesCount = 1;
                    var ranges = stackalloc D3D12_DESCRIPTOR_RANGE1[RangesCount];
                    const int RootParametersCount = 1;
                    var rootParameters = stackalloc D3D12_ROOT_PARAMETER1[RootParametersCount];
                    ranges[0].Init(D3D12_DESCRIPTOR_RANGE_TYPE_SRV, 1, 0, 0, D3D12_DESCRIPTOR_RANGE_FLAG_DATA_STATIC);
                    rootParameters[0].InitAsDescriptorTable(1, ranges, D3D12_SHADER_VISIBILITY_VERTEX);

                    var sampler = new D3D12_STATIC_SAMPLER_DESC {  // IB: use new or stackalloc here?
                        Filter = D3D12_FILTER.D3D12_FILTER_MIN_MAG_MIP_POINT,
                        AddressU = D3D12_TEXTURE_ADDRESS_MODE.D3D12_TEXTURE_ADDRESS_MODE_BORDER,
                        AddressV = D3D12_TEXTURE_ADDRESS_MODE.D3D12_TEXTURE_ADDRESS_MODE_BORDER,
                        AddressW = D3D12_TEXTURE_ADDRESS_MODE.D3D12_TEXTURE_ADDRESS_MODE_BORDER,
                        MipLODBias = 0,
                        MaxAnisotropy = 0,
                        ComparisonFunc = D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_NEVER,
                        BorderColor = D3D12_STATIC_BORDER_COLOR.D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK,
                        MinLOD = 0.0f,
                        MaxLOD = D3D12_FLOAT32_MAX,
                        ShaderRegister = 0,
                        RegisterSpace = 0,
                        ShaderVisibility = D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_PIXEL,
                    };

                    var rootSignatureDesc = new D3D12_VERSIONED_ROOT_SIGNATURE_DESC();
                    rootSignatureDesc.Init_1_1(RootParametersCount, rootParameters, 1, &sampler, D3D12_ROOT_SIGNATURE_FLAG_ALLOW_INPUT_ASSEMBLER_INPUT_LAYOUT);

                    ThrowIfFailed(nameof(D3D12SerializeVersionedRootSignature), D3D12SerializeVersionedRootSignature(
                        &rootSignatureDesc, featureData.HighestVersion, &signature, &error));
                }

                // Create the pipeline state, which includes compiling and loading shaders.
                {
                    var compileFlags = 0u;

#if DEBUG
                    // Enable better shader debugging with the graphics debugging tools.
                    compileFlags |= D3DCOMPILE_DEBUG | D3DCOMPILE_SKIP_OPTIMIZATION;
#endif
                    fixed (char* fileName = GetAssetFullPath(@"D3D12\Assets\Shaders\HelloTexture.hlsl"))
                    {
                        var entryPoint = 0x00006E69614D5356;    // VSMain
                        var target = 0x0000305F355F7376;        // vs_5_0
                        ThrowIfFailed(nameof(D3DCompileFromFile), D3DCompileFromFile((ushort*)fileName, pDefines: null, pInclude: null, (sbyte*)&entryPoint, (sbyte*)&target, compileFlags, Flags2: 0, &vertexShader, ppErrorMsgs: null));

                        entryPoint = 0x00006E69614D5350;        // PSMain
                        target = 0x0000305F355F7370;            // ps_5_0
                        ThrowIfFailed(nameof(D3DCompileFromFile), D3DCompileFromFile((ushort*)fileName, pDefines: null, pInclude: null, (sbyte*)&entryPoint, (sbyte*)&target, compileFlags, Flags2: 0, &pixelShader, ppErrorMsgs: null));
                    }

                    // Define the vertex input layout.
                    const int InputElementDescsCount = 2;

                    var semanticName0 = stackalloc ulong[2] {
                        0x4E4F495449534F50,     // POSITION
                        0x0000000000000000,
                    };

                    var semanticName1 = stackalloc ulong[1] {
                        0x44524f4f43584554,     // TEXCOORD
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
                        pRootSignature = _rootSignature,
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

                    fixed (ID3D12PipelineState** pipelineState = &_pipelineState)
                    {
                        iid = IID_ID3D12PipelineState;
                        ThrowIfFailed(nameof(ID3D12Device._CreateGraphicsPipelineState), _device->CreateGraphicsPipelineState(&psoDesc, &iid, (void**)pipelineState));
                    }
                }

                // Create the command list.
                fixed (ID3D12GraphicsCommandList** commandList = &_commandList)
                {
                    iid = IID_ID3D12GraphicsCommandList;
                    ThrowIfFailed(nameof(ID3D12Device.CreateCommandList), _device->CreateCommandList(nodeMask: 0, D3D12_COMMAND_LIST_TYPE_DIRECT, _commandAllocator, _pipelineState, &iid, (void**)commandList));
                }

                // Create the vertex buffer.
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
                    fixed (ID3D12Resource** vertexBuffer = &_vertexBuffer)
                    {
                        var heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_UPLOAD);
                        var bufferDesc = D3D12_RESOURCE_DESC.Buffer(vertexBufferSize);

                        iid = IID_ID3D12Resource;
                        ThrowIfFailed(nameof(ID3D12Device._CreateCommittedResource), _device->CreateCommittedResource(
                            &heapProperties,
                            D3D12_HEAP_FLAG_NONE,
                            &bufferDesc,
                            D3D12_RESOURCE_STATE_GENERIC_READ,
                            pOptimizedClearValue: null,
                            &iid,
                            (void**)vertexBuffer
                        ));
                    }

                    // Copy the triangle data to the vertex buffer.
                    var readRange = new D3D12_RANGE();

                    byte* pVertexDataBegin;
                    ThrowIfFailed(nameof(ID3D12Resource._Map), _vertexBuffer->Map(Subresource: 0, &readRange, (void**)&pVertexDataBegin));
                    Unsafe.CopyBlock(pVertexDataBegin, triangleVertices, vertexBufferSize);
                    _vertexBuffer->Unmap(0, null);

                    // Initialize the vertex buffer view.
                    _vertexBufferView.BufferLocation = _vertexBuffer->GetGPUVirtualAddress();
                    _vertexBufferView.StrideInBytes = (uint)sizeof(Vertex);
                    _vertexBufferView.SizeInBytes = vertexBufferSize;
                }

                // Note: ComPtr's are CPU objects but this resource needs to stay in scope until
                // the command list that references it has finished executing on the GPU.
                // We will flush the GPU at the end of this method to ensure the resource is not
                // prematurely destroyed.
                ID3D12Resource* textureUploadHeap;

                // Create the texture.
                {
                    // Describe and create a Texture2D.
                    var textureDesc = new D3D12_RESOURCE_DESC {
                        MipLevels = 1,
                        Format = DXGI_FORMAT_R8G8B8A8_UNORM,
                        Width = TextureWidth,
                        Height = TextureHeight,
                        Flags = D3D12_RESOURCE_FLAG_NONE,
                        DepthOrArraySize = 1,
                        Dimension = D3D12_RESOURCE_DIMENSION_TEXTURE2D,
                    };
                    textureDesc.SampleDesc.Count = 1;
                    textureDesc.SampleDesc.Quality = 0;

                    var heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_DEFAULT);
                    iid = IID_ID3D12Resource;
                    ThrowIfFailed(nameof(ID3D12Device._CreateCommittedResource), _device->CreateCommittedResource(
                        &heapProperties,
                        D3D12_HEAP_FLAG_NONE,
                        &textureDesc,
                        D3D12_RESOURCE_STATE_COPY_DEST,
                        pOptimizedClearValue: null,
                        &iid,
                        (void**)_texture
                    ));

                    ulong uploadBufferSize = GetRequiredIntermediateSize(_texture, 0, 1);

                    // Create the GPU upload buffer.
                    heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_UPLOAD);
                    var bufferDesc = D3D12_RESOURCE_DESC.Buffer(uploadBufferSize);
                    ThrowIfFailed(nameof(ID3D12Device._CreateCommittedResource), _device->CreateCommittedResource(
                    &heapProperties,
                        D3D12_HEAP_FLAG_NONE,
                        &bufferDesc,
                        D3D12_RESOURCE_STATE_GENERIC_READ,
                        pOptimizedClearValue: null,
                        &iid,
                        (void**)&textureUploadHeap
                    ));

                    // Copy data to the intermediate upload heap and then schedule a copy 
                    // from the upload heap to the Texture2D.
                    byte[] texture = GenerateTextureData();
                    uint rowPitch = TextureWidth * TexturePixelSize;
                    uint slicePitch = rowPitch * TextureHeight;
                    D3D12_SUBRESOURCE_DATA textureData;
                    fixed (byte* pTexture = &texture[0])
                    {
                        textureData = new D3D12_SUBRESOURCE_DATA {
                            pData = (void*)pTexture,
                            RowPitch = (IntPtr)(&rowPitch),
                            SlicePitch = (IntPtr)(&slicePitch),
                        };
                    }
                    UpdateSubresources(_commandList, _texture, textureUploadHeap, 0, 0, 1, &textureData);
                    var barrier = D3D12_RESOURCE_BARRIER.InitTransition(_texture, D3D12_RESOURCE_STATE_COPY_DEST, D3D12_RESOURCE_STATE_PIXEL_SHADER_RESOURCE);
                    _commandList->ResourceBarrier(1, &barrier);
                    // Describe and create a SRV for the texture.
                    var srvDesc = new D3D12_SHADER_RESOURCE_VIEW_DESC {
                        Shader4ComponentMapping = D3D12_DEFAULT_SHADER_4_COMPONENT_MAPPING,
                        Format = textureDesc.Format,
                        ViewDimension = D3D12_SRV_DIMENSION_TEXTURE2D,
                    };
                    srvDesc.Anonymous.Texture2D.MipLevels = 1;
                    
                    _device->CreateShaderResourceView(_texture, &srvDesc, _srvHeap->GetCPUDescriptorHandleForHeapStart());
                }

                // Close the command list and execute it to begin the initial GPU setup.
                ThrowIfFailed(nameof(ID3D12GraphicsCommandList.Close), _commandList->Close());


                const uint HeapsCount = 1;
                var ppHeaps = stackalloc ID3D12DescriptorHeap*[(int)HeapsCount] {
                    _srvHeap
                };
                _commandList->SetDescriptorHeaps(HeapsCount, ppHeaps);


                const int CommandListsCount = 1;
                var ppCommandLists = stackalloc ID3D12CommandList*[CommandListsCount] {
                    (ID3D12CommandList*)_commandList,
                };
                _commandQueue->ExecuteCommandLists(CommandListsCount, ppCommandLists);

                // Create synchronization objects and wait until assets have been uploaded to the GPU.
                {
                    fixed (ID3D12Fence** fence = &_fence)
                    {
                        iid = IID_ID3D12Fence;
                        ThrowIfFailed(nameof(ID3D12Device.CreateFence), _device->CreateFence(0, D3D12_FENCE_FLAG_NONE, &iid, (void**)fence));
                        _fenceValue = 1;
                    }

                    // Create an event handle to use for frame synchronization.
                    _fenceEvent = CreateEventW(lpEventAttributes: null, bManualReset: FALSE, bInitialState: FALSE, lpName: null);
                    if (_fenceEvent == null)
                    {
                        var hr = Marshal.GetHRForLastWin32Error();
                        Marshal.ThrowExceptionForHR(hr);
                    }

                    // Wait for the command list to execute; we are reusing the same command
                    // list in our main loop but for now, we just want to wait for setup to
                    // complete before continuing.
                    WaitForPreviousFrame();
                }
            }
            finally
            {
                if (signature != null)
                {
                    signature->Release();
                }

                if (error != null)
                {
                    error->Release();
                }

                if (vertexShader != null)
                {
                    vertexShader->Release();
                }

                if (pixelShader != null)
                {
                    pixelShader->Release();
                }
            }
        }

        // Generate a simple black and white checkerboard texture.
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
                    uint x = n % RowPitch;
                    uint y = n / RowPitch;
                    uint i = x / CellPitch;
                    uint j = y / CellHeight;

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


        private void PopulateCommandList()
        {
            // Command list allocators can only be reset when the associated
            // command lists have finished execution on the GPU; apps should use
            // fences to determine GPU execution progress.
            ThrowIfFailed(nameof(ID3D12CommandAllocator.Reset), _commandAllocator->Reset());

            // However, when ExecuteCommandList() is called on a particular command
            // list, that command list can then be reset at any time and must be before
            // re-recording.
            ThrowIfFailed(nameof(ID3D12GraphicsCommandList.Reset), _commandList->Reset(_commandAllocator, _pipelineState));

            // Set necessary state.
            _commandList->SetGraphicsRootSignature(_rootSignature);

            const uint HeapsCount = 1;
            var ppHeaps = stackalloc ID3D12DescriptorHeap*[(int)HeapsCount] {
                _srvHeap
            };
            _commandList->SetDescriptorHeaps(HeapsCount, ppHeaps);

            _commandList->SetGraphicsRootDescriptorTable(0, _srvHeap->GetGPUDescriptorHandleForHeapStart());

            fixed (D3D12_VIEWPORT* viewport = &_viewport)
            {
                _commandList->RSSetViewports(1, viewport);
            }

            fixed (RECT* scissorRect = &_scissorRect)
            {
                _commandList->RSSetScissorRects(1, scissorRect);
            }

            // Indicate that the back buffer will be used as a render target.
            var barrier = D3D12_RESOURCE_BARRIER.InitTransition(_renderTargets[unchecked((int)_frameIndex)], D3D12_RESOURCE_STATE_PRESENT, D3D12_RESOURCE_STATE_RENDER_TARGET);
            _commandList->ResourceBarrier(1, &barrier);

            var rtvHandle = _rtvHeap->GetCPUDescriptorHandleForHeapStart();
            rtvHandle.ptr = (UIntPtr)((byte*)rtvHandle.ptr + (_frameIndex * _rtvDescriptorSize));
            _commandList->OMSetRenderTargets(1, &rtvHandle, FALSE, null);

            // Record commands.
            var clearColor = stackalloc float[4] { 0.0f, 0.2f, 0.4f, 1.0f };
            _commandList->ClearRenderTargetView(rtvHandle, clearColor, NumRects: 0, null);
            _commandList->IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST);

            fixed (D3D12_VERTEX_BUFFER_VIEW* vertexBufferView = &_vertexBufferView)
            {
                _commandList->IASetVertexBuffers(StartSlot: 0, 1, vertexBufferView);
            }

            _commandList->DrawInstanced(VertexCountPerInstance: 3, InstanceCount: 1, StartVertexLocation: 0, StartInstanceLocation: 0);

            // Indicate that the back buffer will now be used to present.
            barrier = D3D12_RESOURCE_BARRIER.InitTransition(_renderTargets[unchecked((int)_frameIndex)], D3D12_RESOURCE_STATE_RENDER_TARGET, D3D12_RESOURCE_STATE_PRESENT);
            _commandList->ResourceBarrier(1, &barrier);

            ThrowIfFailed(nameof(ID3D12GraphicsCommandList.Close), _commandList->Close());
        }

        private void WaitForPreviousFrame()
        {
            // WAITING FOR THE FRAME TO COMPLETE BEFORE CONTINUING IS NOT BEST PRACTICE.
            // This is code implemented as such for simplicity. The D3D12HelloFrameBuffering
            // sample illustrates how to use fences for efficient resource usage and to
            // maximize GPU utilization.

            // Signal and increment the fence value.
            var fence = _fenceValue;
            ThrowIfFailed(nameof(ID3D12CommandQueue.Signal), _commandQueue->Signal(_fence, fence));
            _fenceValue++;

            // Wait until the previous frame is finished.
            if (_fence->GetCompletedValue() < fence)
            {
                ThrowIfFailed(nameof(ID3D12Fence.SetEventOnCompletion), _fence->SetEventOnCompletion(fence, _fenceEvent));
                _ = WaitForSingleObject(_fenceEvent, INFINITE);
            }

            _frameIndex = _swapChain->GetCurrentBackBufferIndex();
        }

        protected override void Dispose(bool isDisposing)
        {
            var swapChain = _swapChain;

            if (swapChain != null)
            {
                _swapChain = null;
                _ = swapChain->Release();
            }

            var device = _device;

            if (device != null)
            {
                _device = null;
                _ = device->Release();
            }

            for (var index = 0; index < FrameCount; index++)
            {
                var renderTarget = _renderTargets[index];

                if (renderTarget != null)
                {
                    _renderTargets[index] = null;
                    _ = renderTarget->Release();
                }
            }

            var commandAllocator = _commandAllocator;

            if (commandAllocator != null)
            {
                _commandAllocator = null;
                _ = commandAllocator->Release();
            }

            var commandQueue = _commandQueue;

            if (commandQueue != null)
            {
                _commandQueue = null;
                _ = commandQueue->Release();
            }

            var rootSignature = _rootSignature;

            if (rootSignature != null)
            {
                _rootSignature = null;
                _ = rootSignature->Release();
            }

            var rtvHeap = _rtvHeap;

            if (rtvHeap != null)
            {
                _rtvHeap = null;
                _ = rtvHeap->Release();
            }

            var pipelineState = _pipelineState;

            if (pipelineState != null)
            {
                _pipelineState = null;
                _ = pipelineState->Release();
            }

            var commandList = _commandList;

            if (commandList != null)
            {
                _commandList = null;
                _ = commandList->Release();
            }

            var vertexBuffer = _vertexBuffer;

            if (vertexBuffer != null)
            {
                _vertexBuffer = null;
                _ = vertexBuffer->Release();
            }

            var texture = _texture;

            if (texture != null)
            {
                _texture = null;
                _ = texture->Release();
            }

            var fence = _fence;

            if (fence != null)
            {
                _fence = null;
                _ = fence->Release();
            }

            base.Dispose(isDisposing);
        }

        private struct Vertex
        {
            public Vector3 Position;

            public Vector2 UV;
        }
    }
}
