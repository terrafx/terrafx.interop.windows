// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop;
using static TerraFX.Interop.D3D_FEATURE_LEVEL;
using static TerraFX.Interop.D3D_PRIMITIVE_TOPOLOGY;
using static TerraFX.Interop.D3D_ROOT_SIGNATURE_VERSION;
using static TerraFX.Interop.D3D12_COMMAND_LIST_TYPE;
using static TerraFX.Interop.D3D12_COMPARISON_FUNC;
using static TerraFX.Interop.D3D12_DESCRIPTOR_HEAP_FLAGS;
using static TerraFX.Interop.D3D12_DESCRIPTOR_HEAP_TYPE;
using static TerraFX.Interop.D3D12_DESCRIPTOR_RANGE_FLAGS;
using static TerraFX.Interop.D3D12_DESCRIPTOR_RANGE_TYPE;
using static TerraFX.Interop.D3D12_FEATURE;
using static TerraFX.Interop.D3D12_FENCE_FLAGS;
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
using static TerraFX.Interop.DXGI_ADAPTER_FLAG;
using static TerraFX.Interop.DXGI_FORMAT;
using static TerraFX.Interop.DXGI_SWAP_EFFECT;
using static TerraFX.Interop.Windows;
using static TerraFX.Samples.DirectX.DXSampleHelper;

namespace TerraFX.Samples.WinForms
{
    public unsafe class Scene
    {
        private Vector2 _sizeXy;
        private readonly IntPtr _windowHandle;

        // Adapter info. true == CPU rendering, false == GPU rendering
        private readonly bool _useWarpDevice;

        // Root assets path
        private readonly string _assetsPath;

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
        private readonly ID3D12CommandAllocator*[] _commandAllocators;
        private ID3D12CommandQueue* _commandQueue;
        private ID3D12RootSignature* _rootSignature;
        private ID3D12DescriptorHeap* _rtvHeap;
        private ID3D12DescriptorHeap* _srvHeap;
        private ID3D12PipelineState* _pipelineState;
        private ID3D12GraphicsCommandList* _commandList;
        private uint _rtvDescriptorSize;
        private bool _isOnColorToggle;

        // App resources.
        private ID3D12Resource* _vertexBuffer;
        private D3D12_VERTEX_BUFFER_VIEW _vertexBufferView;
        private ID3D12Resource* _texture;

        // Synchronization objects.
        private uint _frameIndex; // the current back buffer index
        private HANDLE _fenceEvent;
        private ID3D12Fence* _fence;
        private readonly ulong[] _fenceValues;

        private ID3D12Debug* _debugController;
        private readonly uint _dxgiFactoryFlags;

        private bool _isTriangleWithTexture;

        public bool IsTriangleWithTexture
        {
            get { return _isTriangleWithTexture; }
            set { if (_isTriangleWithTexture != value) { _isTriangleWithTexture = value; ReInit(); Render(); } }
        }

        public Vector2 SizeXy
        {
            get { return _sizeXy; }
            set
            {
                var newSize = Vector2.Max(value, new Vector2(1, 1));
                if (SizeXy != newSize)
                {
                    _sizeXy = newSize;

                    fixed (IDXGISwapChain3** swapChain3 = &_swapChain)
                    {
                        var iid = IID_IDXGISwapChain3;
                        ThrowIfFailed(nameof(IDXGISwapChain1.QueryInterface), _swapChain->QueryInterface(&iid, (void**)swapChain3));
                    }

                    var swapChainDesc = new DXGI_SWAP_CHAIN_DESC();
                    ThrowIfFailed(nameof(IDXGISwapChain3.GetDesc), _swapChain->GetDesc(&swapChainDesc));

                    ThrowIfFailed(nameof(IDXGISwapChain3.ResizeBuffers), _swapChain->ResizeBuffers(
                        FrameCount, (uint)newSize.X, (uint)newSize.Y,
                        swapChainDesc.BufferDesc.Format, swapChainDesc.Flags));

                    _frameIndex = _swapChain->GetCurrentBackBufferIndex();
                }
            }
        }

        public float AspectRatio => _sizeXy.X / _sizeXy.Y;

        public bool UseWarpDevice => _useWarpDevice;

        public Scene(Vector2 sizeXy, IntPtr windowHandle, bool useWarpDevice = false)
        {
            if (sizeXy.X <= 0 || sizeXy.Y <= 0)
            {
                throw new ArgumentException("width and height must be positive and non-zero");
            }

            _sizeXy = sizeXy;
            _windowHandle = windowHandle;
            _assetsPath = GetAssetsPath();

            _renderTargets = new ID3D12Resource*[FrameCount];
            _commandAllocators = new ID3D12CommandAllocator*[FrameCount];
            _fenceValues = new ulong[FrameCount];

            _viewport = new D3D12_VIEWPORT {
                TopLeftX = 0,
                TopLeftY = 0,
                Width = _sizeXy.X,
                Height = _sizeXy.Y,
                MinDepth = D3D12_MIN_DEPTH,
                MaxDepth = D3D12_MAX_DEPTH
            };

            _scissorRect = new RECT {
                left = 0,
                top = 0,
                right = unchecked((int)_sizeXy.X),
                bottom = unchecked((int)_sizeXy.Y)
            };

            _useWarpDevice = useWarpDevice;
            _isOnColorToggle = false;

            _dxgiFactoryFlags = DebugLayerEnable(_debugController);

            _isTriangleWithTexture = false;
            OnInit();
        }

        private uint DebugLayerEnable(ID3D12Debug* debugController)
        {
            var dxgiFactoryFlags = 0u;

#if DEBUG
            // Enable the debug layer (requires the Graphics Tools "optional feature").
            // NOTE: Enabling the debug layer after device creation will invalidate the active device.
            {
                var iid = IID_ID3D12Debug;
                if (SUCCEEDED(D3D12GetDebugInterface(&iid, (void**)&debugController)))
                {
                    debugController->EnableDebugLayer();
                    iid = IID_ID3D12Debug1;
                    ID3D12Debug1* debug1 = null;
                    if (SUCCEEDED(debugController->QueryInterface(&iid, (void**)&debug1)))
                    {
                        debug1->SetEnableGPUBasedValidation(TRUE);
                        debug1->SetEnableSynchronizedCommandQueueValidation(TRUE);
                    }

                    // Enable additional debug layers.
                    dxgiFactoryFlags |= DXGI_CREATE_FACTORY_DEBUG;
                }
            }
#endif
            return dxgiFactoryFlags;
        }

        public virtual void OnInit()
        {
            LoadPipeline();
            LoadAssets();
        }

        public virtual void ReInit()
        {
            { // Load pipeline after adapter, window and swapchain creation
                DestriptorHeapCreate();
                RenderTargetViewsCreate();
                CommandAllocatorCreate();
            }
            LoadAssets();
        }

        // Update frame-based values.
        public virtual void Update()
        {
        }

        private IDXGIFactory4* FactoryCreate(uint dxgiFactoryFlags)
        {
            IDXGIFactory4* factory;
            var iid = IID_IDXGIFactory4;
            ThrowIfFailed(nameof(CreateDXGIFactory2), CreateDXGIFactory2(dxgiFactoryFlags, &iid, (void**)&factory));
            return factory;
        }

        private IDXGIAdapter* AdapterCreate(IDXGIFactory4* factory, uint dxgiFactoryFlags)
        {
            IDXGIAdapter* adapter;
            var iid = IID_IDXGIFactory4;
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

            // Enable debug messages in debug mode.
            {
#if DEBUG
                ID3D12InfoQueue* infoQueue;
                iid = IID_ID3D12InfoQueue;
                ThrowIfFailed(nameof(ID3D12Device2.QueryInterface), _device->QueryInterface(&iid, (void**)&infoQueue));

                infoQueue->SetBreakOnSeverity(D3D12_MESSAGE_SEVERITY.D3D12_MESSAGE_SEVERITY_CORRUPTION, TRUE);
                infoQueue->SetBreakOnSeverity(D3D12_MESSAGE_SEVERITY.D3D12_MESSAGE_SEVERITY_ERROR, TRUE);
                infoQueue->SetBreakOnSeverity(D3D12_MESSAGE_SEVERITY.D3D12_MESSAGE_SEVERITY_WARNING, TRUE);

                // Suppress whole categories of messages
                //D3D12_MESSAGE_CATEGORY Categories[] = {};

                // Suppress messages based on their severity level
                const int SeveritiesCount = 1;
                var Severities = stackalloc D3D12_MESSAGE_SEVERITY[SeveritiesCount]
                {
                    D3D12_MESSAGE_SEVERITY.D3D12_MESSAGE_SEVERITY_INFO
                };

                // Suppress individual messages by their ID
                const int IDsCount = 3;
                var DenyIds = stackalloc D3D12_MESSAGE_ID[IDsCount] {
                    D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_CLEARRENDERTARGETVIEW_MISMATCHINGCLEARVALUE,   // I'm really not sure how to avoid this message.
                    D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_MAP_INVALID_NULLRANGE,                         // This warning occurs when using capture frame while graphics debugging.
                    D3D12_MESSAGE_ID.D3D12_MESSAGE_ID_UNMAP_INVALID_NULLRANGE,                       // This warning occurs when using capture frame while graphics debugging.
                };

                var NewFilter = new D3D12_INFO_QUEUE_FILTER {
                    //NewFilter.DenyList.NumCategories = _countof(Categories);
                    //NewFilter.DenyList.pCategoryList = Categories;
                    DenyList = new D3D12_INFO_QUEUE_FILTER_DESC {
                        //NumCategories ...
                        //Categories ...
                        NumSeverities = SeveritiesCount,
                        pSeverityList = Severities,
                        NumIDs = IDsCount,
                        pIDList = DenyIds,
                    },
                };

                ThrowIfFailed(nameof(ID3D12InfoQueue.PushStorageFilter), infoQueue->PushStorageFilter(&NewFilter));
#endif
            }

            return adapter;
        }

        // Helper function for acquiring the first available hardware adapter that supports the required Direct3D version.
        // If no such adapter can be found, returns null.
        protected IDXGIAdapter* GetHardwareAdapter(IDXGIFactory1* pFactory)
        {
            IDXGIAdapter1* adapter;
            ulong memoryMax = 0;
            IDXGIAdapter1* adapterMaxMemory = null;
            for (var adapterIndex = 0u; DXGI_ERROR_NOT_FOUND != pFactory->EnumAdapters1(adapterIndex, &adapter); ++adapterIndex)
            {
                DXGI_ADAPTER_DESC1 desc;
                _ = adapter->GetDesc1(&desc);

                if ((desc.Flags & (uint)DXGI_ADAPTER_FLAG_SOFTWARE) != 0)
                {
                    // Don't select the Basic Render Driver adapter.
                    // If you want a software adapter, pass in "/warp" on the command line.
                    continue;
                }

                // Check to see if the adapter supports the required Direct3D version,
                // but don't create the actual device yet.
                if (SupportsRequiredDirect3DVersion(adapter))
                {
                    // identify the GPU with the largest dedicated memory.
                    // useful on laptops that have an Intel 2d graphics chip
                    // and a dedicated GPU for 3d.
                    if (memoryMax < (ulong)desc.DedicatedVideoMemory)
                    {
                        memoryMax = (ulong)desc.DedicatedVideoMemory;
                        adapterMaxMemory = adapter;
                    }
                    break;
                }
            }
            return (IDXGIAdapter*)adapterMaxMemory;
        }

        protected virtual unsafe bool SupportsRequiredDirect3DVersion(IDXGIAdapter1* adapter)
        {
            var iid = IID_ID3D12Device;
            return SUCCEEDED(D3D12CreateDevice((IUnknown*)adapter, D3D_FEATURE_LEVEL_11_0, &iid, null));
        }

        private void CommandQueueCreate()
        {
            var queueDesc = new D3D12_COMMAND_QUEUE_DESC();

            fixed (ID3D12CommandQueue** commandQueue = &_commandQueue)
            {
                var iid = IID_ID3D12CommandQueue;
                ThrowIfFailed(nameof(ID3D12Device.CreateCommandQueue), _device->CreateCommandQueue(&queueDesc, &iid, (void**)commandQueue));
            }
        }

        private IDXGISwapChain1* SwapChainCreate(IDXGIFactory4* factory)
        {
            IDXGISwapChain1* swapChain = null;

            var swapChainDesc = new DXGI_SWAP_CHAIN_DESC1 {
                BufferCount = FrameCount,
                Width = (uint)_sizeXy.X,
                Height = (uint)_sizeXy.Y,
                Format = DXGI_FORMAT_R8G8B8A8_UNORM,
                BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT,
                SwapEffect = DXGI_SWAP_EFFECT_FLIP_DISCARD,
                SampleDesc = new DXGI_SAMPLE_DESC(count: 1, quality: 0),
            };

            ThrowIfFailed(nameof(IDXGIFactory4.CreateSwapChainForHwnd), factory->CreateSwapChainForHwnd(
                (IUnknown*)_commandQueue,         // Swap chain needs the queue so that it can force a flush on it.
                _windowHandle,
                &swapChainDesc,
                pFullscreenDesc: null,
                pRestrictToOutput: null,
                &swapChain
            ));

            fixed (IDXGISwapChain3** swapChain3 = &_swapChain)
            {
                var iid = IID_IDXGISwapChain3;
                ThrowIfFailed(nameof(IDXGISwapChain1.QueryInterface), swapChain->QueryInterface(&iid, (void**)swapChain3));
                _frameIndex = _swapChain->GetCurrentBackBufferIndex();
            }

            return swapChain;
        }

        private void WindowAssociate(IDXGIFactory4* factory)
        {
            // This sample does not support fullscreen transitions.
            var hr = factory->MakeWindowAssociation(_windowHandle, DXGI_MWA_NO_ALT_ENTER);
            ThrowIfFailed(nameof(IDXGIFactory4.MakeWindowAssociation), hr);
        }

        private void DestriptorHeapCreate()
        {
            {
                // Describe and create a render target view (RTV) descriptor heap.
                var rtvHeapDesc = new D3D12_DESCRIPTOR_HEAP_DESC {
                    NumDescriptors = FrameCount,
                    Type = D3D12_DESCRIPTOR_HEAP_TYPE_RTV,
                    Flags = D3D12_DESCRIPTOR_HEAP_FLAG_NONE,
                };

                fixed (ID3D12DescriptorHeap** rtvHeap = &_rtvHeap)
                {
                    var iid = IID_ID3D12DescriptorHeap;
                    ThrowIfFailed(nameof(ID3D12Device.CreateDescriptorHeap),
                        _device->CreateDescriptorHeap(&rtvHeapDesc, &iid, (void**)rtvHeap));
                }

                _rtvDescriptorSize = _device->GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE_RTV);
            }

            if (IsTriangleWithTexture)
            {
                // Describe and create a shader resource view (SRV) heap for the texture.
                var srvHeapDesc = new D3D12_DESCRIPTOR_HEAP_DESC {
                    NumDescriptors = 1,
                    Type = D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV,
                    Flags = D3D12_DESCRIPTOR_HEAP_FLAG_SHADER_VISIBLE,
                };
                fixed (ID3D12DescriptorHeap** srvHeap = &_srvHeap)
                {
                    var iid = IID_ID3D12DescriptorHeap;
                    ThrowIfFailed(nameof(ID3D12Device.CreateDescriptorHeap),
                        _device->CreateDescriptorHeap(&srvHeapDesc, &iid, (void**)srvHeap));
                }
            }
        }

        private void RenderTargetViewsCreate()
        {
            var rtvHandle = _rtvHeap->GetCPUDescriptorHandleForHeapStart();

            // Create a RTV for each frame.
            for (var n = 0u; n < FrameCount; n++)
            {
                ID3D12Resource* renderTarget;
                {
                    var iid = IID_ID3D12Resource;
                    ThrowIfFailed(nameof(IDXGISwapChain3.GetBuffer), _swapChain->GetBuffer(n, &iid, (void**)&renderTarget));
                    _device->CreateRenderTargetView(renderTarget, pDesc: null, rtvHandle);
                    _ = rtvHandle.Offset(1, _rtvDescriptorSize);
                }
                _renderTargets[unchecked((int)n)] = renderTarget;
            }
        }

        private void CommandAllocatorCreate()
        {
            for (var n = 0u; n < FrameCount; n++)
            {
                fixed (ID3D12CommandAllocator** commandAllocator = &_commandAllocators[n])
                {
                    var iid = IID_ID3D12CommandAllocator;
                    ThrowIfFailed(nameof(ID3D12Device.CreateCommandAllocator),
                        _device->CreateCommandAllocator(D3D12_COMMAND_LIST_TYPE_DIRECT, &iid, (void**)commandAllocator));
                }
            }
        }

        // Load the rendering pipeline dependencies.
        private void LoadPipeline()
        {
            IDXGIFactory4* factory = null;
            IDXGIAdapter* adapter = null;
            IDXGISwapChain1* swapChain = null;

            try
            {
                factory = FactoryCreate(_dxgiFactoryFlags);
                adapter = AdapterCreate(factory, _dxgiFactoryFlags);
                CommandQueueCreate();
                WindowAssociate(factory);
                swapChain = SwapChainCreate(factory);
                DestriptorHeapCreate();
                RenderTargetViewsCreate();
                CommandAllocatorCreate();
            }
            finally
            {
                if (factory != null)
                {
                    _ = factory->Release();
                }

                if (adapter != null)
                {
                    _ = adapter->Release();
                }

                if (swapChain != null)
                {
                    _ = swapChain->Release();
                }
            }
        }

        private void RootSignatureCreate(ID3DBlob* signature, ID3DBlob* error)
        {
            if (!IsTriangleWithTexture)
            {
                // Create an empty root signature.
                var rootSignatureDesc = new D3D12_ROOT_SIGNATURE_DESC {
                    Flags = D3D12_ROOT_SIGNATURE_FLAG_ALLOW_INPUT_ASSEMBLER_INPUT_LAYOUT
                };

                ThrowIfFailed(nameof(D3D12SerializeRootSignature), D3D12SerializeRootSignature(&rootSignatureDesc, D3D_ROOT_SIGNATURE_VERSION_1, &signature, &error));
            }
            else
            {
                // Create the root signature.
                var featureData = new D3D12_FEATURE_DATA_ROOT_SIGNATURE {
                    // This is the highest version the sample supports. If CheckFeatureSupport succeeds, the HighestVersion returned will not be greater than this.
                    HighestVersion = D3D_ROOT_SIGNATURE_VERSION_1_1
                };

                if (FAILED(_device->CheckFeatureSupport(D3D12_FEATURE_ROOT_SIGNATURE, &featureData, (uint)sizeof(D3D12_FEATURE))))
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

                ThrowIfFailed(nameof(D3D12SerializeVersionedRootSignature), D3D12SerializeVersionedRootSignature(
                    &rootSignatureDesc, featureData.HighestVersion, &signature, &error));
            }

            fixed (ID3D12RootSignature** rootSignature = &_rootSignature)
            {
                var iid = IID_ID3D12RootSignature;
                ThrowIfFailed(nameof(ID3D12Device.CreateRootSignature),
                    _device->CreateRootSignature(nodeMask: 0, signature->GetBufferPointer(), signature->GetBufferSize(), &iid, (void**)rootSignature));
            }
        }

        // Helper function for resolving the full path of assets
        protected string GetAssetFullPath(string assetName) => Path.Combine(_assetsPath, assetName);

        // Create the pipeline state, which includes compiling and loading shaders.
        private void PipelineStateWithShadersCreate(ID3DBlob* vertexShader, ID3DBlob* pixelShader)
        {
            var compileFlags = 0u;
#if DEBUG
            // Enable better shader debugging with the graphics debugging tools.
            compileFlags |= D3DCOMPILE_DEBUG | D3DCOMPILE_SKIP_OPTIMIZATION;
#endif
            var shaderFile = IsTriangleWithTexture
                ? @"Assets\Shaders\HelloTexture.hlsl"
                : @"Assets\Shaders\HelloTriangle.hlsl";
            fixed (char* fileName = GetAssetFullPath(shaderFile))
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

            var semanticNamePosition = stackalloc ulong[2] {
                0x4E4F495449534F50,     // POSITION
                0x0000000000000000,
            };

            var semanticNameColor = stackalloc ulong[1] {
                0x000000524F4C4F43,     // COLOR
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

            var colorElement = new D3D12_INPUT_ELEMENT_DESC {
                SemanticName = (sbyte*)semanticNameColor,
                Format = DXGI_FORMAT_R32G32B32A32_FLOAT,
                AlignedByteOffset = 12,
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
                IsTriangleWithTexture ? texCoordElement : colorElement,
            };

            var depthStencilState = IsTriangleWithTexture
                ? new D3D12_DEPTH_STENCIL_DESC {
                    DepthEnable = FALSE,
                    StencilEnable = FALSE,
                }
                : new D3D12_DEPTH_STENCIL_DESC {
                    DepthEnable = FALSE,
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
                DepthStencilState = depthStencilState,
                SampleMask = uint.MaxValue,
                PrimitiveTopologyType = D3D12_PRIMITIVE_TOPOLOGY_TYPE_TRIANGLE,
                NumRenderTargets = 1,
                SampleDesc = new DXGI_SAMPLE_DESC(count: 1, quality: 0),
            };
            psoDesc.RTVFormats[0] = DXGI_FORMAT_R8G8B8A8_UNORM;

            fixed (ID3D12PipelineState** pipelineState = &_pipelineState)
            {
                var iid = IID_ID3D12PipelineState;
                ThrowIfFailed(nameof(ID3D12Device.CreateGraphicsPipelineState),
                    _device->CreateGraphicsPipelineState(&psoDesc, &iid, (void**)pipelineState));
            }
        }

        private void CommandListCreate()
        {
            fixed (ID3D12GraphicsCommandList** commandList = &_commandList)
            {
                var iid = IID_ID3D12GraphicsCommandList;
                ThrowIfFailed(nameof(ID3D12Device.CreateCommandList),
                    _device->CreateCommandList(nodeMask: 0, D3D12_COMMAND_LIST_TYPE_DIRECT, _commandAllocators[_frameIndex], _pipelineState, &iid, (void**)commandList));
            }
        }

        private void CommandListClose()
        {
            var hr = _commandList->Close();
            ThrowIfFailed(nameof(ID3D12GraphicsCommandList.Close), hr);
        }

        private void ColorTriangleVertexBufferCreate()
        {
            // Define the geometry for a triangle.
            const int TriangleVerticesCount = 3;
            var triangleVertices = stackalloc ColorVertex[TriangleVerticesCount] {
                new ColorVertex {
                    Position = new Vector3(0.0f, 0.25f * AspectRatio, 0.0f),
                    Color = new Vector4(1.0f, 0.0f, 0.0f, 1.0f)
                },
                new ColorVertex {
                    Position = new Vector3(0.25f, -0.25f * AspectRatio, 0.0f),
                    Color = new Vector4(0.0f, 1.0f, 0.0f, 1.0f)
                },
                new ColorVertex {
                    Position = new Vector3(-0.25f, -0.25f * AspectRatio, 0.0f),
                    Color = new Vector4(0.0f, 0.0f, 1.0f, 1.0f)
                },
            };

            var vertexBufferSize = (uint)sizeof(ColorVertex) * TriangleVerticesCount;

            // Note: using upload heaps to transfer static data like vert buffers is not
            // recommended. Every time the GPU needs it, the upload heap will be marshalled
            // over. Please read up on Default Heap usage. An upload heap is used here for
            // code simplicity and because there are very few verts to actually transfer.
            fixed (ID3D12Resource** vertexBuffer = &_vertexBuffer)
            {
                var heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_UPLOAD);
                var bufferDesc = D3D12_RESOURCE_DESC.Buffer(vertexBufferSize);

                var iid = IID_ID3D12Resource;
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
            ThrowIfFailed(nameof(ID3D12Resource.Map), _vertexBuffer->Map(Subresource: 0, &readRange, (void**)&pVertexDataBegin));
            Unsafe.CopyBlock(pVertexDataBegin, triangleVertices, vertexBufferSize);
            _vertexBuffer->Unmap(0, null);

            // Initialize the vertex buffer view.
            _vertexBufferView.BufferLocation = _vertexBuffer->GetGPUVirtualAddress();
            _vertexBufferView.StrideInBytes = (uint)sizeof(ColorVertex);
            _vertexBufferView.SizeInBytes = vertexBufferSize;
        }

        private void TextureTriangleVertexBufferCreate()
        {
            // Define the geometry for a triangle.
            const int TriangleVerticesCount = 3;
            var triangleVertices = stackalloc TextureVertex[TriangleVerticesCount] {
                new TextureVertex {
                    Position = new Vector3(0.0f, 0.25f * AspectRatio, 0.0f),
                    UV = new Vector2(0.5f, 0.0f)
                },
                new TextureVertex {
                    Position = new Vector3(0.25f, -0.25f * AspectRatio, 0.0f),
                    UV = new Vector2(1.0f, 1.0f)
                },
                new TextureVertex {
                    Position = new Vector3(-0.25f, -0.25f * AspectRatio, 0.0f),
                    UV = new Vector2(0.0f, 1.0f)
                },
            };

            var vertexBufferSize = (uint)sizeof(TextureVertex) * TriangleVerticesCount;

            // Note: using upload heaps to transfer static data like vert buffers is not
            // recommended. Every time the GPU needs it, the upload heap will be marshalled
            // over. Please read up on Default Heap usage. An upload heap is used here for
            // code simplicity and because there are very few verts to actually transfer.
            fixed (ID3D12Resource** vertexBuffer = &_vertexBuffer)
            {
                var heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_UPLOAD);
                var bufferDesc = D3D12_RESOURCE_DESC.Buffer(vertexBufferSize);

                var iid = IID_ID3D12Resource;
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
            ThrowIfFailed(nameof(ID3D12Resource.Map), _vertexBuffer->Map(Subresource: 0, &readRange, (void**)&pVertexDataBegin));
            Unsafe.CopyBlock(pVertexDataBegin, triangleVertices, vertexBufferSize);
            _vertexBuffer->Unmap(0, null);

            // Initialize the vertex buffer view.
            _vertexBufferView.BufferLocation = _vertexBuffer->GetGPUVirtualAddress();
            _vertexBufferView.StrideInBytes = (uint)sizeof(TextureVertex);
            _vertexBufferView.SizeInBytes = vertexBufferSize;
        }

        private void TextureHeapCreate()
        {
            // Note: textureUploadHeap needs to stay in scope until
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
                    SampleDesc = new DXGI_SAMPLE_DESC {
                        Count = 1,
                        Quality = 0,
                    },
                    Dimension = D3D12_RESOURCE_DIMENSION_TEXTURE2D,
                };

                fixed (ID3D12Resource** pTexture = &_texture)
                {
                    var heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_DEFAULT);
                    var iid = IID_ID3D12Resource;
                    ThrowIfFailed(nameof(ID3D12Device._CreateCommittedResource), _device->CreateCommittedResource(
                        &heapProperties,
                        D3D12_HEAP_FLAG_NONE,
                        &textureDesc,
                        D3D12_RESOURCE_STATE_COPY_DEST,
                        pOptimizedClearValue: null,
                        &iid,
                        (void**)pTexture
                    ));

                    var uploadBufferSize = GetRequiredIntermediateSize(_texture, 0, 1);

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
                }

                // Copy data to the intermediate upload heap and then schedule a copy 
                // from the upload heap to the Texture2D.
                var texture = GenerateTextureData();
                var rowPitch = TextureWidth * TexturePixelSize;
                var slicePitch = rowPitch * TextureHeight;
                D3D12_SUBRESOURCE_DATA textureData;
                fixed (byte* pTexture = &texture[0])
                {
                    textureData = new D3D12_SUBRESOURCE_DATA {
                        pData = (void*)pTexture,
                        RowPitch = (nint)rowPitch,
                        SlicePitch = (nint)slicePitch,
                    };
                }
                _ = UpdateSubresources(_commandList, _texture, textureUploadHeap, 0, 0, 1, &textureData);
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

            const int CommandListsCount = 1;
            var ppCommandLists = stackalloc ID3D12CommandList*[CommandListsCount] {
                (ID3D12CommandList*)_commandList,
            };
            _commandQueue->ExecuteCommandLists(CommandListsCount, ppCommandLists);
        }

        // Generate a simple black and white checkerboard texture.
        private byte[] GenerateTextureData()
        {
            const uint RowPitch = TextureWidth * TexturePixelSize;
            const uint CellPitch = RowPitch >> 3;        // The width of a cell in the checkerboard texture.
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

        private void FenceCreate()
        {
            fixed (ID3D12Fence** fence = &_fence)
            {
                var iid = IID_ID3D12Fence;
                ThrowIfFailed(nameof(ID3D12Device.CreateFence), _device->CreateFence(_fenceValues[_frameIndex], D3D12_FENCE_FLAG_NONE, &iid, (void**)fence));
                ++_fenceValues[_frameIndex];
            }
        }

        private void FenceEventCreate()
        {
            _fenceEvent = CreateEventW(lpEventAttributes: null, bManualReset: FALSE, bInitialState: FALSE, lpName: null);
            if (_fenceEvent == null)
            {
                var hr = Marshal.GetHRForLastWin32Error();
                Marshal.ThrowExceptionForHR(hr);
            }
        }

        // Load the sample assets.
        private void LoadAssets()
        {
            ID3DBlob* signature = null;
            ID3DBlob* error = null;
            ID3DBlob* vertexShader = null;
            ID3DBlob* pixelShader = null;

            try
            {
                // Create an empty root signature.
                RootSignatureCreate(signature, error);

                PipelineStateWithShadersCreate(vertexShader, pixelShader);

                CommandListCreate();

                // Create the vertex buffer.
                if (IsTriangleWithTexture)
                {
                    TextureTriangleVertexBufferCreate();
                    TextureHeapCreate();
                }
                else
                {
                    // Command lists are created in the recording state, but there is nothing
                    // to record yet. The main loop expects it to be closed, so close it now.
                    CommandListClose();

                    ColorTriangleVertexBufferCreate();
                }

                // Create synchronization objects and wait until assets have been uploaded to the GPU.
                {
                    FenceCreate();

                    // Create an event handle to use for frame synchronization.
                    FenceEventCreate();

                    // Wait for the command list to execute; we are reusing the same command
                    // list in our main loop but for now, we just want to wait for setup to
                    // complete before continuing.
                    WaitForGpu();
                }
            }
            finally
            {
                if (signature != null)
                {
                    _ = signature->Release();
                }

                if (error != null)
                {
                    _ = error->Release();
                }

                if (vertexShader != null)
                {
                    _ = vertexShader->Release();
                }

                if (pixelShader != null)
                {
                    _ = pixelShader->Release();
                }
            }
        }

        private void CommandListPopulate()
        {
            // Command list allocators can only be reset when the associated
            // command lists have finished execution on the GPU; apps should use
            // fences to determine GPU execution progress.
            ThrowIfFailed(nameof(ID3D12CommandAllocator.Reset), _commandAllocators[_frameIndex]->Reset());

            // However, when ExecuteCommandList() is called on a particular command
            // list, that command list can then be reset at any time and must be before
            // re-recording.
            ThrowIfFailed(nameof(ID3D12GraphicsCommandList.Reset), _commandList->Reset(_commandAllocators[_frameIndex], _pipelineState));

            // Set necessary state.
            _commandList->SetGraphicsRootSignature(_rootSignature);

            if (IsTriangleWithTexture)
            {
                TextureHeapSet();
            }

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
            _isOnColorToggle = !_isOnColorToggle;
            var r = 0f;
            var g = _isOnColorToggle ? 25 / 255f : 54 / 255f;
            var b = _isOnColorToggle ? 70 / 255f : 52 / 255f;
            var clearColor = stackalloc float[4] { r, g, b, 1f };
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

        private void TextureHeapSet()
        {
            const uint HeapsCount = 1;
            var ppHeaps = stackalloc ID3D12DescriptorHeap*[(int)HeapsCount] {
                _srvHeap
            };
            _commandList->SetDescriptorHeaps(HeapsCount, ppHeaps);

            _commandList->SetGraphicsRootDescriptorTable(0, _srvHeap->GetGPUDescriptorHandleForHeapStart());
        }

        private void CommandListExecute()
        {
            const int CommandListsCount = 1;
            var ppCommandLists = stackalloc ID3D12CommandList*[CommandListsCount] {
                (ID3D12CommandList*)_commandList,
            };
            _commandQueue->ExecuteCommandLists(CommandListsCount, ppCommandLists);
        }

        private void FramePresent()
        {
            var hr = _swapChain->Present(SyncInterval: 1, Flags: 0);
            ThrowIfFailed(nameof(IDXGISwapChain3.Present), hr);
        }

        private void WaitForGpu()
        {
            // Schedule a Signal command in the queue.
            var fence = _fenceValues[_frameIndex];
            ThrowIfFailed(nameof(ID3D12CommandQueue.Signal), _commandQueue->Signal(_fence, fence));

            // Wait until the fence has been processed.
            ThrowIfFailed(nameof(ID3D12Fence.SetEventOnCompletion), _fence->SetEventOnCompletion(_fenceValues[_frameIndex], _fenceEvent));
            _ = WaitForSingleObjectEx(_fenceEvent, INFINITE, FALSE);

            // Increment the fence value for the current frame.
            ++_fenceValues[_frameIndex];
        }

        // Prepare to render the next frame.
        private void MoveToNextFrame()
        {
            // Schedule a Signal command in the queue.
            var currentFenceValue = _fenceValues[_frameIndex];
            ThrowIfFailed(nameof(ID3D12CommandQueue.Signal), _commandQueue->Signal(_fence, currentFenceValue));

            // Update the frame index.
            _frameIndex = _swapChain->GetCurrentBackBufferIndex();

            // If the next frame is not ready to be rendered yet, wait until it is ready.
            if (_fence->GetCompletedValue() < _fenceValues[_frameIndex])
            {
                ThrowIfFailed(nameof(ID3D12Fence.SetEventOnCompletion), _fence->SetEventOnCompletion(_fenceValues[_frameIndex], _fenceEvent));
                _ = WaitForSingleObjectEx(_fenceEvent, INFINITE, FALSE);
            }

            // Set the fence value for the next frame.
            _fenceValues[_frameIndex] = currentFenceValue + 1;
        }

        // Render the scene.
        public virtual void Render()
        {
            CommandListPopulate();
            CommandListExecute();
            FramePresent();
            MoveToNextFrame();
        }

        public virtual void OnDestroy()
        {
            // Ensure that the GPU is no longer referencing resources that are about to be
            // cleaned up by the destructor.
            WaitForGpu();

            _ = CloseHandle(_fenceEvent);
        }

        ~Scene()
        {
            Dispose(isDisposing: false);
        }

        public void Dispose()
        {
            Dispose(isDisposing: true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool isDisposing)
        {
            var debugController = _debugController;
            if (debugController != null)
            {
                _debugController = null;
                _ = debugController->Release();
            }

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

                var commandAllocator = _commandAllocators[index];
                if (commandAllocator != null)
                {
                    _commandAllocators[index] = null;
                    _ = commandAllocator->Release();
                }
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

            var srvHeap = _srvHeap;
            if (rtvHeap != null)
            {
                _srvHeap = null;
                _ = srvHeap->Release();
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
        }

        private struct ColorVertex
        {
            public Vector3 Position;
            public Vector4 Color;
        }
        private struct TextureVertex
        {
            public Vector3 Position;
            public Vector2 UV;
        }
    }
}
