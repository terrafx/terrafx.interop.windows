// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_TILE_REGION_SIZE
    {
        [NativeTypeName("UINT")]
        public uint NumTiles;

        [NativeTypeName("BOOL")]
        public int bUseBox;

        [NativeTypeName("UINT")]
        public uint Width;

        [NativeTypeName("UINT16")]
        public ushort Height;

        [NativeTypeName("UINT16")]
        public ushort Depth;
    }
}
