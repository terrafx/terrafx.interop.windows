// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

public static partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12CalcSubresource"]/*' />
    public static uint D3D12CalcSubresource(uint MipSlice, uint ArraySlice, uint PlaneSlice, uint MipLevels, uint ArraySize)
    {
        return MipSlice + ArraySlice * MipLevels + PlaneSlice * MipLevels * ArraySize;
    }
}
