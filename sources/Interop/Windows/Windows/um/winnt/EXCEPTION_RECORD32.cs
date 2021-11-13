// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct EXCEPTION_RECORD32
    {
        [NativeTypeName("DWORD")]
        public uint ExceptionCode;

        [NativeTypeName("DWORD")]
        public uint ExceptionFlags;

        [NativeTypeName("DWORD")]
        public uint ExceptionRecord;

        [NativeTypeName("DWORD")]
        public uint ExceptionAddress;

        [NativeTypeName("DWORD")]
        public uint NumberParameters;

        [NativeTypeName("DWORD [15]")]
        public fixed uint ExceptionInformation[15];
    }
}
