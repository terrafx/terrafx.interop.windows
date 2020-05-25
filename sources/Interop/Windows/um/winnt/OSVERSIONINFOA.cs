// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct OSVERSIONINFOA
    {
        [NativeTypeName("DWORD")]
        public uint dwOSVersionInfoSize;

        [NativeTypeName("DWORD")]
        public uint dwMajorVersion;

        [NativeTypeName("DWORD")]
        public uint dwMinorVersion;

        [NativeTypeName("DWORD")]
        public uint dwBuildNumber;

        [NativeTypeName("DWORD")]
        public uint dwPlatformId;

        [NativeTypeName("CHAR [128]")]
        public fixed sbyte szCSDVersion[128];
    }
}
