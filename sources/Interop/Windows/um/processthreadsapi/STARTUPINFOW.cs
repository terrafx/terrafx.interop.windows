// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct STARTUPINFOW
    {
        [NativeTypeName("DWORD")]
        public uint cb;

        [NativeTypeName("LPWSTR")]
        public ushort* lpReserved;

        [NativeTypeName("LPWSTR")]
        public ushort* lpDesktop;

        [NativeTypeName("LPWSTR")]
        public ushort* lpTitle;

        [NativeTypeName("DWORD")]
        public uint dwX;

        [NativeTypeName("DWORD")]
        public uint dwY;

        [NativeTypeName("DWORD")]
        public uint dwXSize;

        [NativeTypeName("DWORD")]
        public uint dwYSize;

        [NativeTypeName("DWORD")]
        public uint dwXCountChars;

        [NativeTypeName("DWORD")]
        public uint dwYCountChars;

        [NativeTypeName("DWORD")]
        public uint dwFillAttribute;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("WORD")]
        public ushort wShowWindow;

        [NativeTypeName("WORD")]
        public ushort cbReserved2;

        [NativeTypeName("LPBYTE")]
        public byte* lpReserved2;

        [NativeTypeName("HANDLE")]
        public IntPtr hStdInput;

        [NativeTypeName("HANDLE")]
        public IntPtr hStdOutput;

        [NativeTypeName("HANDLE")]
        public IntPtr hStdError;
    }
}
