// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DXSample.h in https://github.com/Microsoft/DirectX-Graphics-Samples
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Drawing;
using System.IO;
using System.Numerics;
using TerraFX.Interop;
using TerraFX.Samples.DirectX.D3D11;
using TerraFX.Samples.DirectX.D3D12;
using static TerraFX.Interop.DXGI_ADAPTER_FLAG;
using static TerraFX.Interop.DXGI_FORMAT;
using static TerraFX.Interop.Windows;
using static TerraFX.Samples.DirectX.DXSampleHelper;

namespace TerraFX.Samples.DirectX
{
    public abstract unsafe class DXSample : IDisposable
    {
        public static readonly DXSample[] Samples = {
            new HelloWindow11("D3D11.HelloWindow"),
            new HelloTriangle11("D3D11.HelloTriangle"),
            new HelloWindow12("D3D12.HelloWindow"),
            new HelloTriangle12("D3D12.HelloTriangle"),
            new HelloConstBuffer12("D3D12.HelloConstBuffer"),
            new HelloTexture12("D3D12.HelloTexture"),
            new HelloBundles12("D3D12.HelloBundles"),
            new HelloMultiSampling12("D3D12.HelloMultiSampling"),
        };

        private readonly string _assetsPath;
        private readonly string _name;
        private DXGI_FORMAT _backBufferFormat;
        private Vector4 _backgroundColor;
        private DXGI_FORMAT _depthBufferFormat;
        private float _dpi;
        private uint _frameCount;
        private uint _frameIndex;
        private IntPtr _hwnd;
        private bool _isWindowVisible;
        private Size _size;
        private bool _useWarpDevice;

        protected DXSample(string name)
        {
            _assetsPath = GetAssetsPath();
            _name = name;
        }

        ~DXSample()
        {
            Dispose(isDisposing: false);
        }

        public float AspectRatio => Size.Width / ((float)Size.Height);

        public string AssetsPath => _assetsPath;

        public DXGI_FORMAT BackBufferFormat => _backBufferFormat;

        public Vector4 BackgroundColor
        {
            get
            {
                return _backgroundColor;
            }

            set
            {
                _backgroundColor = value;
            }
        }

        public DXGI_FORMAT DepthBufferFormat => _depthBufferFormat;

        public float Dpi => _dpi;

        public uint FrameCount => _frameCount;

        public ref uint FrameIndex => ref _frameIndex;

        public IntPtr Hwnd => _hwnd;

        public bool IsWindowVisible => _isWindowVisible;

        public string Name => _name;

        public Size Size => _size;

        public bool UseWarpDevice => _useWarpDevice;

        public void Dispose()
        {
            Dispose(isDisposing: true);
            GC.SuppressFinalize(this);
        }

        public virtual void OnDestroy()
        {
            DestroyWindowSizeDependentResources();
            DestroyDeviceDependentResources();
        }

        public void OnInit(DXGI_FORMAT backBufferFormat, Vector4 backgroundColor, DXGI_FORMAT depthBufferFormat, float dpi, uint frameCount, IntPtr hwnd, bool isWindowVisible, Size size, bool useWarpDevice)
        {
            _backBufferFormat = (backBufferFormat != DXGI_FORMAT_UNKNOWN) ? backBufferFormat : DXGI_FORMAT_R8G8B8A8_UNORM;
            _backgroundColor = backgroundColor;
            _depthBufferFormat = (depthBufferFormat != DXGI_FORMAT_UNKNOWN) ? depthBufferFormat : DXGI_FORMAT_D32_FLOAT;
            _dpi = dpi;
            _frameCount = Math.Max(frameCount, 1);
            _hwnd = hwnd;
            _isWindowVisible = isWindowVisible;
            _size = size;
            _useWarpDevice = useWarpDevice;

            CreateDeviceDependentResources();
            CreateWindowSizeDependentResources();
        }

        public virtual void OnKeyDown(int key)
        {
        }

        public virtual void OnKeyUp(int key)
        {
        }

        public abstract void OnRender();

        public void OnDpiChanged(float dpi)
        {
            _dpi = dpi;
            OnWindowSizeChanged(Size);
        }

        public void OnWindowSizeChanged(Size size)
        {
            if (size != _size)
            {
                _size = size;

                DestroyWindowSizeDependentResources();
                CreateWindowSizeDependentResources();
            }
        }

        public abstract void OnUpdate();

        public void OnVisibilityChanged(bool isVisible)
        {
            _isWindowVisible = isVisible;
        }

        protected abstract void CreateDeviceDependentResources();

        protected abstract void CreateWindowSizeDependentResources();

        protected abstract void DestroyDeviceDependentResources();

        protected abstract void DestroyWindowSizeDependentResources();

        protected virtual void Dispose(bool isDisposing) => OnDestroy();

        // Helper function for resolving the full path of assets
        protected string GetAssetFullPath(string assetName) => Path.Combine(AssetsPath, assetName);

        // Helper function for acquiring the first available hardware adapter that supports the required Direct3D version.
        // If no such adapter can be found, returns null.
        protected IDXGIAdapter1* GetHardwareAdapter(IDXGIFactory1* pFactory)
        {
            IDXGIAdapter1* adapter;

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

                // Check to see if the adapter supports the required Direct3D version, but don't create the
                // actual device yet.
                if (SupportsRequiredDirect3DVersion(adapter))
                {
                    break;
                }
            }

            return adapter;
        }

        protected abstract bool SupportsRequiredDirect3DVersion(IDXGIAdapter1* adapter);
    }
}
