// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Drawing;
using TerraFX.Interop;
using static TerraFX.Interop.D3D_DRIVER_TYPE;
using static TerraFX.Interop.D3D_FEATURE_LEVEL;
using static TerraFX.Interop.DXGI_SWAP_EFFECT;
using static TerraFX.Interop.Windows;
using static TerraFX.Samples.DirectX.DXSampleHelper;

namespace TerraFX.Samples.DirectX.D3D11
{
    public abstract unsafe class DX11Sample : DXSample
    {
        private ID3D11Device* _d3dDevice;
        private IDXGIAdapter1* _dxgiAdapter;
        private IDXGIFactory1* _dxgiFactory;
        private IDXGISwapChain* _swapChain;
        private ID3D11DeviceContext* _immediateContext;
        private ID3D11RenderTargetView* _renderTargetView;
        private D3D11_VIEWPORT _viewport;
        private RECT _scissorRect;

        public DX11Sample(string name) : base(name)
        {
        }

        public ID3D11Device* D3DDevice => _d3dDevice;

        public IDXGIAdapter1* DxgiAdapter => _dxgiAdapter;

        public IDXGIFactory1* DxgiFactory => _dxgiFactory;

        public ID3D11DeviceContext* ImmediateContext => _immediateContext;

        public ID3D11RenderTargetView* RenderTargetView => _renderTargetView;

        public ref RECT ScissorRect => ref _scissorRect;

        public IDXGISwapChain* SwapChain => _swapChain;

        public ref D3D11_VIEWPORT Viewport => ref _viewport;

        protected virtual void CreateAssets()
        {
        }

        protected override void CreateDeviceDependentResources()
        {
            _dxgiFactory = CreateDxgiFactory();
            _dxgiAdapter = GetDxgiAdapter();
            _d3dDevice = CreateD3DDevice(out _immediateContext);

            CreateAssets();

            ID3D11Device* CreateD3DDevice(out ID3D11DeviceContext* pImmediateContext)
            {
                ID3D11Device* d3dDevice;
                ID3D11DeviceContext* immediateContext;

                var featureLevel = D3D_FEATURE_LEVEL_11_0;
                ThrowIfFailed(nameof(D3D11CreateDevice), D3D11CreateDevice((IDXGIAdapter*)DxgiAdapter, D3D_DRIVER_TYPE_HARDWARE, Software: (HMODULE)(NULL), Flags: 0, &featureLevel, FeatureLevels: 1, D3D11_SDK_VERSION, &d3dDevice, pFeatureLevel: null, &immediateContext));

                pImmediateContext = immediateContext;
                return d3dDevice;
            }

            IDXGIFactory1* CreateDxgiFactory()
            {
                IDXGIFactory1* dxgiFactory;

                var iid = IID_IDXGIFactory1;
                ThrowIfFailed(nameof(CreateDXGIFactory1), CreateDXGIFactory1(&iid, (void**)&dxgiFactory));

                return dxgiFactory;
            }

            IDXGIAdapter1* GetDxgiAdapter()
            {
                if (UseWarpDevice)
                {
                    throw new NotImplementedException("WARP Device not supported for D3D11.");
                }
                else
                {
                    return GetHardwareAdapter(_dxgiFactory);
                }
            }
        }

        protected virtual void CreateResourceViews()
        {
            _renderTargetView = CreateRenderTargetView();

            ID3D11RenderTargetView* CreateRenderTargetView()
            {
                using ComPtr<ID3D11Resource> backBuffer = null;

                var iid = IID_ID3D11Texture2D;
                ThrowIfFailed(nameof(IDXGISwapChain.GetBuffer), SwapChain->GetBuffer(0, &iid, (void**)backBuffer.GetAddressOf()));

                ID3D11RenderTargetView* renderTargetView;
                ThrowIfFailed(nameof(ID3D11Device.CreateRenderTargetView), D3DDevice->CreateRenderTargetView(backBuffer.Get(), null, &renderTargetView));
                return renderTargetView;
            }
        }

        protected override void CreateWindowSizeDependentResources()
        {
            if (_swapChain != null)
            {
                ThrowIfFailed(nameof(IDXGISwapChain.ResizeBuffers), _swapChain->ResizeBuffers(FrameCount, (uint)Size.Width, (uint)Size.Height, BackBufferFormat, 0));
            }
            else
            {
                _swapChain = CreateSwapChain();
            }

            CreateResourceViews();

            _viewport = new D3D11_VIEWPORT {
                TopLeftX = 0,
                TopLeftY = 0,
                Width = Size.Width,
                Height = Size.Height,
                MinDepth = D3D12_MIN_DEPTH,
                MaxDepth = D3D12_MAX_DEPTH
            };

            _scissorRect = new RECT {
                left = 0,
                top = 0,
                right = Size.Width,
                bottom = Size.Height
            };

            IDXGISwapChain* CreateSwapChain()
            {
                var swapChainDesc = new DXGI_SWAP_CHAIN_DESC {
                    BufferDesc = new DXGI_MODE_DESC {
                        Width = (uint)Size.Width,
                        Height = (uint)Size.Height,
                        Format = BackBufferFormat,
                    },
                    SampleDesc = new DXGI_SAMPLE_DESC {
                        Count = 1
                    },
                    BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT,
                    BufferCount = FrameCount,
                    OutputWindow = Hwnd,
                    Windowed = TRUE,
                    SwapEffect = DXGI_SWAP_EFFECT_DISCARD,
                };

                IDXGISwapChain* swapChain;

                ThrowIfFailed(nameof(IDXGIFactory1.CreateSwapChain), DxgiFactory->CreateSwapChain((IUnknown*)D3DDevice, &swapChainDesc, &swapChain));

                return swapChain;
            }
        }

        // Render the scene.
        public override void OnRender()
        {
            SetImmediateContextState();

            var renderTargetView = RenderTargetView;
            var backgroundColor = BackgroundColor;

            ImmediateContext->ClearRenderTargetView(renderTargetView, (float*)&backgroundColor);
            ImmediateContext->OMSetRenderTargets(1, &renderTargetView, pDepthStencilView: null);

            Draw();

            ThrowIfFailed(nameof(IDXGISwapChain.Present), _swapChain->Present(SyncInterval: 1, Flags: 0));
        }

        public override void OnDestroy() => _immediateContext->ClearState();

        protected virtual void DestroyAssets()
        {
        }

        protected override void DestroyDeviceDependentResources()
        {
            DestroyAssets();

            DestroyImmediateContext();
            DestroyD3DDevice();
            DestroyDxgiAdapter();
            DestroyDxgiFactory();

            void DestroyD3DDevice()
            {
                var d3dDevice = _d3dDevice;

                if (d3dDevice != null)
                {
                    _d3dDevice = null;
                    _ = d3dDevice->Release();
                }
            }

            void DestroyDxgiAdapter()
            {
                var dxgiAdapter = _dxgiAdapter;

                if (dxgiAdapter != null)
                {
                    _dxgiAdapter = null;
                    _ = dxgiAdapter->Release();
                }
            }

            void DestroyDxgiFactory()
            {
                var dxgiFactory = _dxgiFactory;

                if (dxgiFactory != null)
                {
                    _dxgiFactory = null;
                    _ = dxgiFactory->Release();
                }
            }

            void DestroyImmediateContext()
            {
                var immediateContext = _immediateContext;

                if (immediateContext != null)
                {
                    _immediateContext = null;
                    _ = immediateContext->Release();
                }
            }
        }

        protected virtual void DestroyResourceViews()
        {
            DestroyRenderTargetView();

            void DestroyRenderTargetView()
            {
                var renderTargetView = _renderTargetView;

                if (renderTargetView != null)
                {
                    _renderTargetView = null;
                    _ = renderTargetView->Release();
                }
            }
        }

        protected override void DestroyWindowSizeDependentResources()
        {
            DestroyResourceViews();
            DestroySwapChain();

            void DestroySwapChain()
            {
                var swapChain = _swapChain;

                if (swapChain != null)
                {
                    _swapChain = null;
                    _ = swapChain->Release();
                }
            }
        }

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

            var device = _d3dDevice;

            if (device != null)
            {
                _d3dDevice = null;
                _ = device->Release();
            }

            var renderTarget = _renderTargetView;

            if (renderTarget != null)
            {
                _renderTargetView = null;
                _ = renderTarget->Release();
            }

            base.Dispose(isDisposing);
        }

        protected abstract void Draw();

        protected virtual void SetImmediateContextState()
        {
            fixed (D3D11_VIEWPORT* viewport = &Viewport)
            {
                ImmediateContext->RSSetViewports(1, viewport);
            }

            fixed (RECT* scissorRect = &ScissorRect)
            {
                ImmediateContext->RSSetScissorRects(1, scissorRect);
            }
        }

        protected override unsafe bool SupportsRequiredDirect3DVersion(IDXGIAdapter1* adapter)
        {
            var featureLevel = D3D_FEATURE_LEVEL_11_0;
            return SUCCEEDED(D3D11CreateDevice((IDXGIAdapter*)adapter, D3D_DRIVER_TYPE_HARDWARE, Software: (HMODULE)(NULL), Flags: 0, &featureLevel, FeatureLevels: 1, D3D11_SDK_VERSION, ppDevice: null, pFeatureLevel: null, ppImmediateContext: null));
        }
    }
}
