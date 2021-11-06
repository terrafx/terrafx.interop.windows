// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct MINIDUMP_PROCESS_VM_COUNTERS_2
    {
        public ushort Revision;

        public ushort Flags;

        [NativeTypeName("ULONG")]
        public uint PageFaultCount;

        [NativeTypeName("ULONG64")]
        public ulong PeakWorkingSetSize;

        [NativeTypeName("ULONG64")]
        public ulong WorkingSetSize;

        [NativeTypeName("ULONG64")]
        public ulong QuotaPeakPagedPoolUsage;

        [NativeTypeName("ULONG64")]
        public ulong QuotaPagedPoolUsage;

        [NativeTypeName("ULONG64")]
        public ulong QuotaPeakNonPagedPoolUsage;

        [NativeTypeName("ULONG64")]
        public ulong QuotaNonPagedPoolUsage;

        [NativeTypeName("ULONG64")]
        public ulong PagefileUsage;

        [NativeTypeName("ULONG64")]
        public ulong PeakPagefileUsage;

        [NativeTypeName("ULONG64")]
        public ulong PeakVirtualSize;

        [NativeTypeName("ULONG64")]
        public ulong VirtualSize;

        [NativeTypeName("ULONG64")]
        public ulong PrivateUsage;

        [NativeTypeName("ULONG64")]
        public ulong PrivateWorkingSetSize;

        [NativeTypeName("ULONG64")]
        public ulong SharedCommitUsage;

        [NativeTypeName("ULONG64")]
        public ulong JobSharedCommitUsage;

        [NativeTypeName("ULONG64")]
        public ulong JobPrivateCommitUsage;

        [NativeTypeName("ULONG64")]
        public ulong JobPeakPrivateCommitUsage;

        [NativeTypeName("ULONG64")]
        public ulong JobPrivateCommitLimit;

        [NativeTypeName("ULONG64")]
        public ulong JobTotalCommitLimit;
    }
}
