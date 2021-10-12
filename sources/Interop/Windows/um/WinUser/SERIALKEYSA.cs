// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SERIALKEYSA
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("LPSTR")]
        public sbyte* lpszActivePort;

        [NativeTypeName("LPSTR")]
        public sbyte* lpszPort;

        [NativeTypeName("UINT")]
        public uint iBaudRate;

        [NativeTypeName("UINT")]
        public uint iPortState;

        [NativeTypeName("UINT")]
        public uint iActive;
    }
}
