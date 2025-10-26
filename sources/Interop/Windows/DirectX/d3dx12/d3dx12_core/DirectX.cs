// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;
using static TerraFX.Interop.DirectX.D3D12_FEATURE;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12CalcSubresource"]/*' />
    public static uint D3D12CalcSubresource(uint MipSlice, uint ArraySlice, uint PlaneSlice, uint MipLevels, uint ArraySize)
    {
        return MipSlice + ArraySlice * MipLevels + PlaneSlice * MipLevels * ArraySize;
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12GetFormatPlaneCount"]/*' />
    [return: NativeTypeName("UINT8")]
    public static byte D3D12GetFormatPlaneCount(ID3D12Device* pDevice, DXGI_FORMAT Format)
    {
        D3D12_FEATURE_DATA_FORMAT_INFO formatInfo = new D3D12_FEATURE_DATA_FORMAT_INFO
        {
            Format = Format,
            PlaneCount = 0,
        };

        if ((((HRESULT)(pDevice->CheckFeatureSupport(D3D12_FEATURE_FORMAT_INFO, &formatInfo, (uint)(sizeof(D3D12_FEATURE_DATA_FORMAT_INFO))))) < 0))
        {
            return 0;
        }

        return formatInfo.PlaneCount;
    }
}
