// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2
{
    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.IdleProcessTime"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong IdleProcessTime;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.IoReadTransferCount"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong IoReadTransferCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.IoWriteTransferCount"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong IoWriteTransferCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.IoOtherTransferCount"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong IoOtherTransferCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.IoReadOperationCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint IoReadOperationCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.IoWriteOperationCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint IoWriteOperationCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.IoOtherOperationCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint IoOtherOperationCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.AvailablePages"]/*' />
    [NativeTypeName("ULONG")]
    public uint AvailablePages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CommittedPages"]/*' />
    [NativeTypeName("ULONG")]
    public uint CommittedPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CommitLimit"]/*' />
    [NativeTypeName("ULONG")]
    public uint CommitLimit;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.PeakCommitment"]/*' />
    [NativeTypeName("ULONG")]
    public uint PeakCommitment;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.PageFaultCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint PageFaultCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CopyOnWriteCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint CopyOnWriteCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.TransitionCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint TransitionCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CacheTransitionCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint CacheTransitionCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.DemandZeroCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint DemandZeroCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.PageReadCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint PageReadCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.PageReadIoCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint PageReadIoCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CacheReadCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint CacheReadCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CacheIoCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint CacheIoCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.DirtyPagesWriteCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint DirtyPagesWriteCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.DirtyWriteIoCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint DirtyWriteIoCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.MappedPagesWriteCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint MappedPagesWriteCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.MappedWriteIoCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint MappedWriteIoCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.PagedPoolPages"]/*' />
    [NativeTypeName("ULONG")]
    public uint PagedPoolPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.NonPagedPoolPages"]/*' />
    [NativeTypeName("ULONG")]
    public uint NonPagedPoolPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.PagedPoolAllocs"]/*' />
    [NativeTypeName("ULONG")]
    public uint PagedPoolAllocs;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.PagedPoolFrees"]/*' />
    [NativeTypeName("ULONG")]
    public uint PagedPoolFrees;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.NonPagedPoolAllocs"]/*' />
    [NativeTypeName("ULONG")]
    public uint NonPagedPoolAllocs;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.NonPagedPoolFrees"]/*' />
    [NativeTypeName("ULONG")]
    public uint NonPagedPoolFrees;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.FreeSystemPtes"]/*' />
    [NativeTypeName("ULONG")]
    public uint FreeSystemPtes;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.ResidentSystemCodePage"]/*' />
    [NativeTypeName("ULONG")]
    public uint ResidentSystemCodePage;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.TotalSystemDriverPages"]/*' />
    [NativeTypeName("ULONG")]
    public uint TotalSystemDriverPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.TotalSystemCodePages"]/*' />
    [NativeTypeName("ULONG")]
    public uint TotalSystemCodePages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.NonPagedPoolLookasideHits"]/*' />
    [NativeTypeName("ULONG")]
    public uint NonPagedPoolLookasideHits;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.PagedPoolLookasideHits"]/*' />
    [NativeTypeName("ULONG")]
    public uint PagedPoolLookasideHits;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.AvailablePagedPoolPages"]/*' />
    [NativeTypeName("ULONG")]
    public uint AvailablePagedPoolPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.ResidentSystemCachePage"]/*' />
    [NativeTypeName("ULONG")]
    public uint ResidentSystemCachePage;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.ResidentPagedPoolPage"]/*' />
    [NativeTypeName("ULONG")]
    public uint ResidentPagedPoolPage;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.ResidentSystemDriverPage"]/*' />
    [NativeTypeName("ULONG")]
    public uint ResidentSystemDriverPage;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcFastReadNoWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastReadNoWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcFastReadWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastReadWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcFastReadResourceMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastReadResourceMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcFastReadNotPossible"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastReadNotPossible;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcFastMdlReadNoWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastMdlReadNoWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcFastMdlReadWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastMdlReadWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcFastMdlReadResourceMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastMdlReadResourceMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcFastMdlReadNotPossible"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastMdlReadNotPossible;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcMapDataNoWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMapDataNoWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcMapDataWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMapDataWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcMapDataNoWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMapDataNoWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcMapDataWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMapDataWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcPinMappedDataCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcPinMappedDataCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcPinReadNoWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcPinReadNoWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcPinReadWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcPinReadWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcPinReadNoWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcPinReadNoWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcPinReadWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcPinReadWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcCopyReadNoWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcCopyReadNoWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcCopyReadWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcCopyReadWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcCopyReadNoWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcCopyReadNoWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcCopyReadWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcCopyReadWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcMdlReadNoWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMdlReadNoWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcMdlReadWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMdlReadWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcMdlReadNoWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMdlReadNoWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcMdlReadWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMdlReadWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcReadAheadIos"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcReadAheadIos;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcLazyWriteIos"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcLazyWriteIos;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcLazyWritePages"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcLazyWritePages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcDataFlushes"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcDataFlushes;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcDataPages"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcDataPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.ContextSwitches"]/*' />
    [NativeTypeName("ULONG")]
    public uint ContextSwitches;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.FirstLevelTbFills"]/*' />
    [NativeTypeName("ULONG")]
    public uint FirstLevelTbFills;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.SecondLevelTbFills"]/*' />
    [NativeTypeName("ULONG")]
    public uint SecondLevelTbFills;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.SystemCalls"]/*' />
    [NativeTypeName("ULONG")]
    public uint SystemCalls;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcTotalDirtyPages"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong CcTotalDirtyPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.CcDirtyPageThreshold"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong CcDirtyPageThreshold;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.ResidentAvailablePages"]/*' />
    [NativeTypeName("LONG64")]
    public long ResidentAvailablePages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.SharedCommittedPages"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong SharedCommittedPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.MdlPagesAllocated"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong MdlPagesAllocated;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.PfnDatabaseCommittedPages"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong PfnDatabaseCommittedPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.SystemPageTableCommittedPages"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SystemPageTableCommittedPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2.ContiguousPagesAllocated"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ContiguousPagesAllocated;
}
