// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CONSOLE_FONT_INFOEX
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint nFont;

        public COORD dwFontSize;

        [NativeTypeName("UINT")]
        public uint FontFamily;

        [NativeTypeName("UINT")]
        public uint FontWeight;

        [NativeTypeName("WCHAR [32]")]
        public fixed ushort FaceName[32];
    }
}
