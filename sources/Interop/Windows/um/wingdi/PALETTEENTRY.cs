// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct PALETTEENTRY
    {
        [NativeTypeName("BYTE")]
        public byte peRed;

        [NativeTypeName("BYTE")]
        public byte peGreen;

        [NativeTypeName("BYTE")]
        public byte peBlue;

        [NativeTypeName("BYTE")]
        public byte peFlags;
    }
}
