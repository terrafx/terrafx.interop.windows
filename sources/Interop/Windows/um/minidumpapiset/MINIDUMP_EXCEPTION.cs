// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe partial struct MINIDUMP_EXCEPTION
    {
        [NativeTypeName("ULONG32")]
        public uint ExceptionCode;

        [NativeTypeName("ULONG32")]
        public uint ExceptionFlags;

        [NativeTypeName("ULONG64")]
        public ulong ExceptionRecord;

        [NativeTypeName("ULONG64")]
        public ulong ExceptionAddress;

        [NativeTypeName("ULONG32")]
        public uint NumberParameters;

        [NativeTypeName("ULONG32")]
        public uint __unusedAlignment;

        [NativeTypeName("ULONG64 [15]")]
        public fixed ulong ExceptionInformation[15];
    }
}
