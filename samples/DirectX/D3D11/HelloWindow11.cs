// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using TerraFX.Interop;
using static TerraFX.Interop.D3D_DRIVER_TYPE;
using static TerraFX.Interop.D3D_FEATURE_LEVEL;
using static TerraFX.Interop.DXGI_FORMAT;
using static TerraFX.Interop.DXGI_SWAP_EFFECT;
using static TerraFX.Interop.Windows;
using static TerraFX.Samples.DirectX.DXSampleHelper;

namespace TerraFX.Samples.DirectX.D3D11
{
    public unsafe class HelloWindow11 : DX11Sample
    {
        private const uint FrameCount = 2;

        private IDXGISwapChain* _swapChain;
        private ID3D11Device* _device;
        private ID3D11DeviceContext* _immediateContext;
        private ID3D11RenderTargetView* _renderTarget;

        public HelloWindow11(uint width, uint height, string name)
            : base(width, height, name)
        {
        }

        public override void OnInit()
        {
            Guid iid;
            IDXGIFactory1* factory = null;
            IDXGIAdapter* adapter = null;
            ID3D11Texture2D* backBuffer = null;

            try
            {
                iid = IID_IDXGIFactory1;
                ThrowIfFailed(nameof(CreateDXGIFactory1), CreateDXGIFactory1(&iid, (void**)&factory));

                if (UseWarpDevice)
                {
                    throw new NotImplementedException("WARP Device not supported for D3D11.");
                }
                else
                {
                    adapter = GetHardwareAdapter(factory);
                }

                fixed (ID3D11Device** device = &_device)
                fixed (ID3D11DeviceContext** immediateContext = &_immediateContext)
                {
                    var featureLevel = D3D_FEATURE_LEVEL_11_0;
                    ThrowIfFailed(nameof(D3D11CreateDevice), D3D11CreateDevice(adapter, D3D_DRIVER_TYPE_HARDWARE, Software: IntPtr.Zero, Flags: 0, &featureLevel, FeatureLevels: 1, D3D11_SDK_VERSION, device, pFeatureLevel: null, immediateContext));
                }

                // Describe and create the swap chain.
                var swapChainDesc = new DXGI_SWAP_CHAIN_DESC {
                    BufferDesc = new DXGI_MODE_DESC {
                        Width = Width,
                        Height = Height,
                        Format = DXGI_FORMAT_R8G8B8A8_UNORM,
                    },
                    SampleDesc = new DXGI_SAMPLE_DESC {
                        Count = 1
                    },
                    BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT,
                    BufferCount = FrameCount,
                    OutputWindow = Win32Application.Hwnd,
                    Windowed = TRUE,
                    SwapEffect = DXGI_SWAP_EFFECT_DISCARD,
                };

                fixed (IDXGISwapChain** swapChain = &_swapChain)
                {
                    ThrowIfFailed(nameof(IDXGIFactory1.CreateSwapChain), factory->CreateSwapChain(
                        (IUnknown*)_device,
                        &swapChainDesc,
                        swapChain
                    ));
                }

                // This sample does not support fullscreen transitions.
                ThrowIfFailed(nameof(IDXGIFactory.MakeWindowAssociation), factory->MakeWindowAssociation(Win32Application.Hwnd, DXGI_MWA_NO_ALT_ENTER));

                fixed (ID3D11RenderTargetView** renderTarget = &_renderTarget)
                {
                    iid = IID_ID3D11Texture2D;

                    ThrowIfFailed(nameof(IDXGISwapChain.GetBuffer), _swapChain->GetBuffer(0, &iid, (void**)&backBuffer));
                    ThrowIfFailed(nameof(ID3D11Device.CreateRenderTargetView), _device->CreateRenderTargetView((ID3D11Resource*)backBuffer, null, renderTarget));

                    _immediateContext->OMSetRenderTargets(1, renderTarget, pDepthStencilView: null);
                }

                var vp = new D3D11_VIEWPORT {
                    Width = Width,
                    Height = Height,
                    MinDepth = 0.0f,
                    MaxDepth = 1.0f,
                    TopLeftX = 0,
                    TopLeftY = 0,
                };
                _immediateContext->RSSetViewports(1, &vp);
            }
            finally
            {
                if (backBuffer != null)
                {
                    _ = backBuffer->Release();
                }

                if (adapter != null)
                {
                    _ = adapter->Release();
                }

                if (factory != null)
                {
                    _ = factory->Release();
                }
            }
        }

        // Update frame-based values.
        public override void OnUpdate()
        {
        }

        // Render the scene.
        public override void OnRender()
        {
            var clearColor = stackalloc float[4];
            {
                clearColor[0] = 0.0f;
                clearColor[1] = 0.2f;
                clearColor[2] = 0.4f;
                clearColor[3] = 1.0f;
            }
            _immediateContext->ClearRenderTargetView(_renderTarget, clearColor);

            ThrowIfFailed(nameof(IDXGISwapChain.Present), _swapChain->Present(0, 0));
        }

        public override void OnDestroy() => _immediateContext->ClearState();

        protected override void Dispose(bool isDisposing)
        {
            var swapChain = _swapChain;

            if (swapChain != null)
            {
                _swapChain = null;
                _ = swapChain->Release();
            }

            var immediateContext = _immediateContext;

            if (immediateContext != null)
            {
                _immediateContext = null;
                _ = immediateContext->Release();
            }

            var device = _device;

            if (device != null)
            {
                _device = null;
                _ = device->Release();
            }

            var renderTarget = _renderTarget;

            if (renderTarget != null)
            {
                _renderTarget = null;
                _ = renderTarget->Release();
            }

            base.Dispose(isDisposing);
        }
    }
}
