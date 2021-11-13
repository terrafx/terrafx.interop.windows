// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.1")]
    public partial struct D3D11_TILE_REGION_SIZE
    {
        public uint NumTiles;

        public BOOL bUseBox;

        public uint Width;

        [NativeTypeName("UINT16")]
        public ushort Height;

        [NativeTypeName("UINT16")]
        public ushort Depth;
    }
}
