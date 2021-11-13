// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct EXCEPTION_RECORD64
    {
        [NativeTypeName("DWORD")]
        public uint ExceptionCode;

        [NativeTypeName("DWORD")]
        public uint ExceptionFlags;

        [NativeTypeName("DWORD64")]
        public ulong ExceptionRecord;

        [NativeTypeName("DWORD64")]
        public ulong ExceptionAddress;

        [NativeTypeName("DWORD")]
        public uint NumberParameters;

        [NativeTypeName("DWORD")]
        public uint __unusedAlignment;

        [NativeTypeName("DWORD64 [15]")]
        public fixed ulong ExceptionInformation[15];
    }
}
