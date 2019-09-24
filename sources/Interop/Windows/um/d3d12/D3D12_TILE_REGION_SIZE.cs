// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public struct D3D12_TILE_REGION_SIZE
    {
        [NativeTypeName("UINT")]
        public uint NumTiles;

        [NativeTypeName("BOOL")]
        public int UseBox;

        [NativeTypeName("UINT")]
        public uint Width;

        [NativeTypeName("UINT16")]
        public ushort Height;

        [NativeTypeName("UINT16")]
        public ushort Depth;

        public D3D12_TILE_REGION_SIZE(uint numTiles, int useBox, uint width, ushort height, ushort depth)
        {
            NumTiles = numTiles;
            UseBox = useBox;
            Width = width;
            Height = height;
            Depth = depth;
        }
    }
}
