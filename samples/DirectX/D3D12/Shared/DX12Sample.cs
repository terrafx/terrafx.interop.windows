// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using TerraFX.Interop;
using static TerraFX.Interop.D3D_FEATURE_LEVEL;
using static TerraFX.Interop.D3D12;
using static TerraFX.Interop.Windows;

namespace TerraFX.Samples.DirectX.D3D12
{
    public abstract unsafe class DX12Sample : DXSample
    {
        protected DX12Sample(uint width, uint height, string name) : base(width, height, name)
        {
        }

        protected override unsafe bool SupportsRequiredDirect3DVersion(IDXGIAdapter1* adapter)
        {
            var iid = IID_ID3D12Device;
            return SUCCEEDED(D3D12CreateDevice((IUnknown*)adapter, D3D_FEATURE_LEVEL_11_0, &iid, null));
        }
    }
}
