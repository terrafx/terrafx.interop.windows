// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D10_TEXCUBE_ARRAY_SRV1
    {
        public uint MostDetailedMip;

        public uint MipLevels;

        public uint First2DArrayFace;

        public uint NumCubes;
    }
}
