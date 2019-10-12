// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using TerraFX.Interop;
using static TerraFX.Interop.D3D_DRIVER_TYPE;
using static TerraFX.Interop.D3D_FEATURE_LEVEL;
using static TerraFX.Interop.D3D11;
using static TerraFX.Interop.Windows;

namespace TerraFX.Samples.DirectX.D3D11
{
    public abstract unsafe class DX11Sample : DXSample
    {
        protected DX11Sample(uint width, uint height, string name) : base(width, height, name)
        {
        }

        protected override unsafe bool SupportsRequiredDirect3DVersion(IDXGIAdapter1* adapter)
        {
            var featureLevel = D3D_FEATURE_LEVEL_11_0;
            return SUCCEEDED(D3D11CreateDevice((IDXGIAdapter*)adapter, D3D_DRIVER_TYPE_HARDWARE, Software: IntPtr.Zero, Flags: 0, &featureLevel, FeatureLevels: 1, D3D11_SDK_VERSION, ppDevice: null, pFeatureLevel: null, ppImmediateContext: null));
        }
    }
}
