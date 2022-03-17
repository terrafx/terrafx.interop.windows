// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D12_TILE_REGION_SIZE"]/*' />
public partial struct D3D12_TILE_REGION_SIZE
{
    /// <include file='D3D12_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D12_TILE_REGION_SIZE.NumTiles"]/*' />
    public uint NumTiles;

    /// <include file='D3D12_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D12_TILE_REGION_SIZE.UseBox"]/*' />
    public BOOL UseBox;

    /// <include file='D3D12_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D12_TILE_REGION_SIZE.Width"]/*' />
    public uint Width;

    /// <include file='D3D12_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D12_TILE_REGION_SIZE.Height"]/*' />
    [NativeTypeName("UINT16")]
    public ushort Height;

    /// <include file='D3D12_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D12_TILE_REGION_SIZE.Depth"]/*' />
    [NativeTypeName("UINT16")]
    public ushort Depth;
}
