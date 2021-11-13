// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct ICONINFOEXA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public BOOL fIcon;

        [NativeTypeName("DWORD")]
        public uint xHotspot;

        [NativeTypeName("DWORD")]
        public uint yHotspot;

        public HBITMAP hbmMask;

        public HBITMAP hbmColor;

        [NativeTypeName("WORD")]
        public ushort wResID;

        [NativeTypeName("CHAR [260]")]
        public fixed sbyte szModName[260];

        [NativeTypeName("CHAR [260]")]
        public fixed sbyte szResName[260];
    }
}
