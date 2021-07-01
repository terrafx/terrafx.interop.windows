// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WIN32_FIND_DATAA
    {
        [NativeTypeName("DWORD")]
        public uint dwFileAttributes;

        public FILETIME ftCreationTime;

        public FILETIME ftLastAccessTime;

        public FILETIME ftLastWriteTime;

        [NativeTypeName("DWORD")]
        public uint nFileSizeHigh;

        [NativeTypeName("DWORD")]
        public uint nFileSizeLow;

        [NativeTypeName("DWORD")]
        public uint dwReserved0;

        [NativeTypeName("DWORD")]
        public uint dwReserved1;

        [NativeTypeName("CHAR [260]")]
        public fixed sbyte cFileName[260];

        [NativeTypeName("CHAR [14]")]
        public fixed sbyte cAlternateFileName[14];
    }
}
