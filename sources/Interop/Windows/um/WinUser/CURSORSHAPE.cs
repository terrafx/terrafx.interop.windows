// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CURSORSHAPE
    {
        public int xHotSpot;

        public int yHotSpot;

        public int cx;

        public int cy;

        public int cbWidth;

        [NativeTypeName("BYTE")]
        public byte Planes;

        [NativeTypeName("BYTE")]
        public byte BitsPixel;
    }
}
