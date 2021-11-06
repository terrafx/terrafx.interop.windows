// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct MINIDUMP_THREAD_INFO
    {
        [NativeTypeName("ULONG32")]
        public uint ThreadId;

        [NativeTypeName("ULONG32")]
        public uint DumpFlags;

        [NativeTypeName("ULONG32")]
        public uint DumpError;

        [NativeTypeName("ULONG32")]
        public uint ExitStatus;

        [NativeTypeName("ULONG64")]
        public ulong CreateTime;

        [NativeTypeName("ULONG64")]
        public ulong ExitTime;

        [NativeTypeName("ULONG64")]
        public ulong KernelTime;

        [NativeTypeName("ULONG64")]
        public ulong UserTime;

        [NativeTypeName("ULONG64")]
        public ulong StartAddress;

        [NativeTypeName("ULONG64")]
        public ulong Affinity;
    }
}
