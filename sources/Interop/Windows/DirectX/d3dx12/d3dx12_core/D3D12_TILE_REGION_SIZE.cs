// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D12_TILE_REGION_SIZE"]/*' />
[NativeTypeName("struct CD3DX12_TILE_REGION_SIZE : D3D12_TILE_REGION_SIZE")]
[NativeInheritance("D3D12_TILE_REGION_SIZE")]
public partial struct D3D12_TILE_REGION_SIZE
{
    public D3D12_TILE_REGION_SIZE(uint numTiles, BOOL useBox, uint width, [NativeTypeName("UINT16")] ushort height, [NativeTypeName("UINT16")] ushort depth)
    {
        NumTiles = numTiles;
        UseBox = useBox;
        Width = width;
        Height = height;
        Depth = depth;
    }
}
