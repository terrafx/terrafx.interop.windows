// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgitype.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DXGI_JPEG_AC_HUFFMAN_TABLE
    {
        [NativeTypeName("BYTE [16]")]
        public fixed byte CodeCounts[16];

        [NativeTypeName("BYTE [162]")]
        public fixed byte CodeValues[162];
    }
}
