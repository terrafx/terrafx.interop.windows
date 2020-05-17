// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/microsoft/Windows-classic-samples/blob/master/Samples/Win7Samples/multimedia/DirectWrite/TextDialogSample/TextDialog.cpp
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using TerraFX.Interop;
using TerraFX.Samples.DirectX.D3D12;
using static TerraFX.Interop.Windows;

namespace TerraFX.Samples.DirectX.DWrite
{
    public unsafe class HelloWrite : DX12Sample
    {
        // DWrite resources
        private IDWriteFactory* _writeFactory;
        private IDWriteTextFormat* _writeTextFormat;
        private ID2D1Factory* _d2d1Factory;
        private ID2D1HwndRenderTarget* _hWndRenderTarget;
        private ID2D1SolidColorBrush* _solidBrush;
        private IntPtr _hWnd;
        private string _text;
        public string Text => _text;

        private const uint FrameCount = 2;

        // Pipeline objects
        private RECT _rect;

        public HelloWrite(uint width, uint height, string name, IntPtr hWnd = default)
            : base(width, height, name)
        {
            _rect = new RECT {
                left = 0,
                top = 0,
                right = unchecked((int)width),
                bottom = unchecked((int)height)
            };

            _hWnd = hWnd;
            _hWndRenderTarget = null;
            _text = "Hello World";
        }

        public override void OnInit()
        {
            if (_hWnd == IntPtr.Zero)
            {
                _hWnd = Win32Application.Hwnd;
            }

            _ = CreateDeviceIndependentResources();
        }

        // Update frame-based values.
        public override void OnUpdate()
        {
        }

        // Render the scene.
        public override void OnRender() => _ = DrawD2DContent();

        public override void OnDestroy() => DiscardDeviceResources();

        /// <summary>
        /// This method is used to create resources which are not bound  
        /// to any device. Their lifetime effectively extends for the    
        /// duration of the app. These resources include the Direct2D and
        /// DirectWrite factories; and a DirectWrite Text Format object  
        /// (used for identifying particular font characteristics) and   
        /// a Direct2D geometry.                                         
        /// </summary>
        /// <returns></returns>
        private HRESULT CreateDeviceIndependentResources()
        {
            HRESULT hr;
            Guid iid;
            ID2D1Factory* d2d1Factory = null;
            IDWriteFactory* writeFactory = null;
            IDWriteTextFormat* writeTextFormat = null;

            var dxgiFactoryFlags = 0u;
#if DEBUG
            // Enable the debug layer (requires the Graphics Tools "optional feature").
            // NOTE: Enabling the debug layer after device creation will invalidate the active device.
            {
                ID3D12Debug* debugController = null;
                iid = IID_ID3D12Debug;
                if (SUCCEEDED(D3D12GetDebugInterface(&iid, (void**)&debugController)))
                {
                    debugController->EnableDebugLayer();

                    // Enable additional debug layers.
                    dxgiFactoryFlags |= DXGI_CREATE_FACTORY_DEBUG;
                }
            }
#endif
            {
                iid = IID_ID2D1Factory;
                hr = D2D1CreateFactory(D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_SINGLE_THREADED, &iid, (void**)&d2d1Factory);
                iid = IID_IDWriteFactory;
                if (SUCCEEDED(hr))
                {
                    hr = DWriteCreateFactory(DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED, &iid, (IUnknown**)&writeFactory);
                }

                _text = "Hello World via DirectWrite";

                if (SUCCEEDED(hr))
                {
                    fixed (char* pFontFamily = "Gabriola")
                    {
                        fixed (char* pLocaleName = "en-us")
                        {
                            hr = writeFactory->CreateTextFormat(
                                (ushort*)pFontFamily,
                                null,                       // Font collection (null sets it to use the system font collection).
                                DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_REGULAR,
                                DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_NORMAL,
                                DWRITE_FONT_STRETCH.DWRITE_FONT_STRETCH_NORMAL,
                                72.0f,
                                (ushort*)pLocaleName,
                                &writeTextFormat
                                );
                        }
                    }
                }

                // Center align (horizontally) the text
                if (SUCCEEDED(hr))
                {
                    hr = writeTextFormat->SetTextAlignment(DWRITE_TEXT_ALIGNMENT.DWRITE_TEXT_ALIGNMENT_CENTER);
                }

                if (SUCCEEDED(hr))
                {
                    hr = writeTextFormat->SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT.DWRITE_PARAGRAPH_ALIGNMENT_CENTER);
                }

                if (SUCCEEDED(hr))
                {
                    _d2d1Factory = d2d1Factory;
                    _writeFactory = writeFactory;
                    _writeTextFormat = writeTextFormat;
                }
            }

            return hr;
        }

        /// <summary>
        /// This method creates resources which are bound to a particular
        /// D3D device. It's all centralized here, in case the resources 
        /// need to be recreated in case of D3D device loss (eg. display 
        /// change, remoting, removal of video card, etc).               
        /// </summary>
        /// <returns></returns>
        private HRESULT CreateDeviceResources()
        {
            HRESULT hr = S_OK;
            ID2D1HwndRenderTarget* hwvdRenderTarget = null;
            ID2D1SolidColorBrush* solidBrush = null;

            var rect = new RECT(_rect.left, _rect.top, _rect.right, _rect.bottom);

            var size = new D2D_SIZE_U(width: (uint)(rect.right - rect.left), height: (uint)(rect.bottom - rect.top));

            if (_hWndRenderTarget == null)
            {
                // Create a Direct2D render target.
                var renderPops = RenderTargetProperties();
                var hWndRenderPops = HwndRenderTargetProperties(_hWnd, size);
                hr = _d2d1Factory->CreateHwndRenderTarget(
                    &renderPops,
                    &hWndRenderPops,
                    &hwvdRenderTarget
                    );

                // Create a brush.
                if (SUCCEEDED(hr))
                {
                    var orange = new DXGI_RGBA(226 / 255f, 149 / 255f, 0, 1);
                    hr = hwvdRenderTarget->CreateSolidColorBrush(
                        &orange,
                        &solidBrush
                        );
                }

                if (SUCCEEDED(hr))
                {
                    _hWndRenderTarget = hwvdRenderTarget;
                    _solidBrush = solidBrush;
                }
            }

            return hr;
        }

        /// <summary>
        /// Discard device-specific resources which need to be recreated 
        /// when a D3D device is lost                                    
        /// </summary>
        private void DiscardDeviceResources()
        {
            if (_hWndRenderTarget != null)
            {
                _ = _hWndRenderTarget->Release();
            }

            if (_solidBrush != null)
            {
                _ = _solidBrush->Release();
            }
        }

        /// <summary>
        /// This method will draw text using the IDWriteTextLayout   
        /// via the Direct2D render target                           
        /// </summary>
        /// <returns></returns>
        private HRESULT DrawText()
        {
            var rect = new D2D_RECT_F(_rect.left, _rect.top, _rect.right, _rect.bottom);
            var brush = _solidBrush;
            fixed (char* pText = _text)
            {
                _hWndRenderTarget->DrawText((ushort*)pText, (uint)_text.Length, _writeTextFormat, &rect, (ID2D1Brush*)brush);
            }
            return S_OK;
        }

        /// <summary>
        /// Note that this function will not render anything if the window
        /// is occluded (eg. obscured by other windows or off monitor).   
        /// Also, this function will automatically discard device-specific
        /// resources if the D3D device disappears during execution, and  
        /// will recreate the resources the next time it's invoked.       
        /// </summary>
        /// <returns></returns>
        private HRESULT DrawD2DContent()
        {
            var hr = CreateDeviceResources();
            var pRT = _hWndRenderTarget;

            if (0 == (pRT->CheckWindowState() & D2D1_WINDOW_STATE.D2D1_WINDOW_STATE_OCCLUDED))
            {
                pRT->BeginDraw();

                var identity = IdentityMatrix;
                pRT->SetTransform(&identity);

                var darkBlue = new DXGI_RGBA(0, 25 / 255f, 70 / 255f, 1);
                pRT->Clear(&darkBlue);

                // Call the DrawText method of this class.
                if (SUCCEEDED(hr))
                {
                    _ = DrawText();
                }

                if (SUCCEEDED(hr))
                {
                    hr = pRT->EndDraw();
                }
            }

            if (FAILED(hr))
            {
                DiscardDeviceResources();
            }

            return hr;
        }

        protected override void Dispose(bool isDisposing)
        {
            DiscardDeviceResources();
            base.Dispose(isDisposing);
        }
    }
}
