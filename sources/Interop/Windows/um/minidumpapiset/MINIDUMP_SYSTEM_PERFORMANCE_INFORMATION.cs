// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION
    {
        [NativeTypeName("ULONG64")]
        public ulong IdleProcessTime;

        [NativeTypeName("ULONG64")]
        public ulong IoReadTransferCount;

        [NativeTypeName("ULONG64")]
        public ulong IoWriteTransferCount;

        [NativeTypeName("ULONG64")]
        public ulong IoOtherTransferCount;

        [NativeTypeName("ULONG")]
        public uint IoReadOperationCount;

        [NativeTypeName("ULONG")]
        public uint IoWriteOperationCount;

        [NativeTypeName("ULONG")]
        public uint IoOtherOperationCount;

        [NativeTypeName("ULONG")]
        public uint AvailablePages;

        [NativeTypeName("ULONG")]
        public uint CommittedPages;

        [NativeTypeName("ULONG")]
        public uint CommitLimit;

        [NativeTypeName("ULONG")]
        public uint PeakCommitment;

        [NativeTypeName("ULONG")]
        public uint PageFaultCount;

        [NativeTypeName("ULONG")]
        public uint CopyOnWriteCount;

        [NativeTypeName("ULONG")]
        public uint TransitionCount;

        [NativeTypeName("ULONG")]
        public uint CacheTransitionCount;

        [NativeTypeName("ULONG")]
        public uint DemandZeroCount;

        [NativeTypeName("ULONG")]
        public uint PageReadCount;

        [NativeTypeName("ULONG")]
        public uint PageReadIoCount;

        [NativeTypeName("ULONG")]
        public uint CacheReadCount;

        [NativeTypeName("ULONG")]
        public uint CacheIoCount;

        [NativeTypeName("ULONG")]
        public uint DirtyPagesWriteCount;

        [NativeTypeName("ULONG")]
        public uint DirtyWriteIoCount;

        [NativeTypeName("ULONG")]
        public uint MappedPagesWriteCount;

        [NativeTypeName("ULONG")]
        public uint MappedWriteIoCount;

        [NativeTypeName("ULONG")]
        public uint PagedPoolPages;

        [NativeTypeName("ULONG")]
        public uint NonPagedPoolPages;

        [NativeTypeName("ULONG")]
        public uint PagedPoolAllocs;

        [NativeTypeName("ULONG")]
        public uint PagedPoolFrees;

        [NativeTypeName("ULONG")]
        public uint NonPagedPoolAllocs;

        [NativeTypeName("ULONG")]
        public uint NonPagedPoolFrees;

        [NativeTypeName("ULONG")]
        public uint FreeSystemPtes;

        [NativeTypeName("ULONG")]
        public uint ResidentSystemCodePage;

        [NativeTypeName("ULONG")]
        public uint TotalSystemDriverPages;

        [NativeTypeName("ULONG")]
        public uint TotalSystemCodePages;

        [NativeTypeName("ULONG")]
        public uint NonPagedPoolLookasideHits;

        [NativeTypeName("ULONG")]
        public uint PagedPoolLookasideHits;

        [NativeTypeName("ULONG")]
        public uint AvailablePagedPoolPages;

        [NativeTypeName("ULONG")]
        public uint ResidentSystemCachePage;

        [NativeTypeName("ULONG")]
        public uint ResidentPagedPoolPage;

        [NativeTypeName("ULONG")]
        public uint ResidentSystemDriverPage;

        [NativeTypeName("ULONG")]
        public uint CcFastReadNoWait;

        [NativeTypeName("ULONG")]
        public uint CcFastReadWait;

        [NativeTypeName("ULONG")]
        public uint CcFastReadResourceMiss;

        [NativeTypeName("ULONG")]
        public uint CcFastReadNotPossible;

        [NativeTypeName("ULONG")]
        public uint CcFastMdlReadNoWait;

        [NativeTypeName("ULONG")]
        public uint CcFastMdlReadWait;

        [NativeTypeName("ULONG")]
        public uint CcFastMdlReadResourceMiss;

        [NativeTypeName("ULONG")]
        public uint CcFastMdlReadNotPossible;

        [NativeTypeName("ULONG")]
        public uint CcMapDataNoWait;

        [NativeTypeName("ULONG")]
        public uint CcMapDataWait;

        [NativeTypeName("ULONG")]
        public uint CcMapDataNoWaitMiss;

        [NativeTypeName("ULONG")]
        public uint CcMapDataWaitMiss;

        [NativeTypeName("ULONG")]
        public uint CcPinMappedDataCount;

        [NativeTypeName("ULONG")]
        public uint CcPinReadNoWait;

        [NativeTypeName("ULONG")]
        public uint CcPinReadWait;

        [NativeTypeName("ULONG")]
        public uint CcPinReadNoWaitMiss;

        [NativeTypeName("ULONG")]
        public uint CcPinReadWaitMiss;

        [NativeTypeName("ULONG")]
        public uint CcCopyReadNoWait;

        [NativeTypeName("ULONG")]
        public uint CcCopyReadWait;

        [NativeTypeName("ULONG")]
        public uint CcCopyReadNoWaitMiss;

        [NativeTypeName("ULONG")]
        public uint CcCopyReadWaitMiss;

        [NativeTypeName("ULONG")]
        public uint CcMdlReadNoWait;

        [NativeTypeName("ULONG")]
        public uint CcMdlReadWait;

        [NativeTypeName("ULONG")]
        public uint CcMdlReadNoWaitMiss;

        [NativeTypeName("ULONG")]
        public uint CcMdlReadWaitMiss;

        [NativeTypeName("ULONG")]
        public uint CcReadAheadIos;

        [NativeTypeName("ULONG")]
        public uint CcLazyWriteIos;

        [NativeTypeName("ULONG")]
        public uint CcLazyWritePages;

        [NativeTypeName("ULONG")]
        public uint CcDataFlushes;

        [NativeTypeName("ULONG")]
        public uint CcDataPages;

        [NativeTypeName("ULONG")]
        public uint ContextSwitches;

        [NativeTypeName("ULONG")]
        public uint FirstLevelTbFills;

        [NativeTypeName("ULONG")]
        public uint SecondLevelTbFills;

        [NativeTypeName("ULONG")]
        public uint SystemCalls;

        [NativeTypeName("ULONG64")]
        public ulong CcTotalDirtyPages;

        [NativeTypeName("ULONG64")]
        public ulong CcDirtyPageThreshold;

        [NativeTypeName("LONG64")]
        public long ResidentAvailablePages;

        [NativeTypeName("ULONG64")]
        public ulong SharedCommittedPages;
    }
}
