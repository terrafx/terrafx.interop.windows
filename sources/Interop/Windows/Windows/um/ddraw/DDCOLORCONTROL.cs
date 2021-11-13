// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct DDCOLORCONTROL
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("LONG")]
        public int lBrightness;

        [NativeTypeName("LONG")]
        public int lContrast;

        [NativeTypeName("LONG")]
        public int lHue;

        [NativeTypeName("LONG")]
        public int lSaturation;

        [NativeTypeName("LONG")]
        public int lSharpness;

        [NativeTypeName("LONG")]
        public int lGamma;

        [NativeTypeName("LONG")]
        public int lColorEnable;

        [NativeTypeName("DWORD")]
        public uint dwReserved1;
    }
}
