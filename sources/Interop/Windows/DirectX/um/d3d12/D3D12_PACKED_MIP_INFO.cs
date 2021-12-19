// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PACKED_MIP_INFO.xml' path='doc/member[@name="D3D12_PACKED_MIP_INFO"]/*' />
public partial struct D3D12_PACKED_MIP_INFO
{
    /// <include file='D3D12_PACKED_MIP_INFO.xml' path='doc/member[@name="D3D12_PACKED_MIP_INFO.NumStandardMips"]/*' />
    [NativeTypeName("UINT8")]
    public byte NumStandardMips;

    /// <include file='D3D12_PACKED_MIP_INFO.xml' path='doc/member[@name="D3D12_PACKED_MIP_INFO.NumPackedMips"]/*' />
    [NativeTypeName("UINT8")]
    public byte NumPackedMips;

    /// <include file='D3D12_PACKED_MIP_INFO.xml' path='doc/member[@name="D3D12_PACKED_MIP_INFO.NumTilesForPackedMips"]/*' />
    public uint NumTilesForPackedMips;

    /// <include file='D3D12_PACKED_MIP_INFO.xml' path='doc/member[@name="D3D12_PACKED_MIP_INFO.StartTileIndexInOverallResource"]/*' />
    public uint StartTileIndexInOverallResource;
}
