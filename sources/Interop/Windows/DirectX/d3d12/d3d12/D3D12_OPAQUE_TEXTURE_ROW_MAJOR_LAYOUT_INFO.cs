// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO.xml' path='doc/member[@name="D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO"]/*' />
public partial struct D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO
{
    /// <include file='D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO.xml' path='doc/member[@name="D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO.IsRowMajor"]/*' />
    public BOOL IsRowMajor;

    /// <include file='D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO.xml' path='doc/member[@name="D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO.Offset"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Offset;

    /// <include file='D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO.xml' path='doc/member[@name="D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO.RowPitch"]/*' />
    [NativeTypeName("UINT64")]
    public ulong RowPitch;

    /// <include file='D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO.xml' path='doc/member[@name="D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO.Width"]/*' />
    public uint Width;

    /// <include file='D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO.xml' path='doc/member[@name="D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO.Height"]/*' />
    public uint Height;
}
