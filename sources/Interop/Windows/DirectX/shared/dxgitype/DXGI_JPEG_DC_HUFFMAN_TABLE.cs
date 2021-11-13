// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX
{
    public unsafe partial struct DXGI_JPEG_DC_HUFFMAN_TABLE
    {
        [NativeTypeName("BYTE [12]")]
        public fixed byte CodeCounts[12];

        [NativeTypeName("BYTE [12]")]
        public fixed byte CodeValues[12];
    }
}
