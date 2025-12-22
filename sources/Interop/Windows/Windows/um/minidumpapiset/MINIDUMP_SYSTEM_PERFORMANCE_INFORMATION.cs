// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION
{
    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.IdleProcessTime"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong IdleProcessTime;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.IoReadTransferCount"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong IoReadTransferCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.IoWriteTransferCount"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong IoWriteTransferCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.IoOtherTransferCount"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong IoOtherTransferCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.IoReadOperationCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint IoReadOperationCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.IoWriteOperationCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint IoWriteOperationCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.IoOtherOperationCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint IoOtherOperationCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.AvailablePages"]/*' />
    [NativeTypeName("ULONG")]
    public uint AvailablePages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CommittedPages"]/*' />
    [NativeTypeName("ULONG")]
    public uint CommittedPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CommitLimit"]/*' />
    [NativeTypeName("ULONG")]
    public uint CommitLimit;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.PeakCommitment"]/*' />
    [NativeTypeName("ULONG")]
    public uint PeakCommitment;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.PageFaultCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint PageFaultCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CopyOnWriteCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint CopyOnWriteCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.TransitionCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint TransitionCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CacheTransitionCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint CacheTransitionCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.DemandZeroCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint DemandZeroCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.PageReadCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint PageReadCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.PageReadIoCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint PageReadIoCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CacheReadCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint CacheReadCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CacheIoCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint CacheIoCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.DirtyPagesWriteCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint DirtyPagesWriteCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.DirtyWriteIoCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint DirtyWriteIoCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.MappedPagesWriteCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint MappedPagesWriteCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.MappedWriteIoCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint MappedWriteIoCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.PagedPoolPages"]/*' />
    [NativeTypeName("ULONG")]
    public uint PagedPoolPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.NonPagedPoolPages"]/*' />
    [NativeTypeName("ULONG")]
    public uint NonPagedPoolPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.PagedPoolAllocs"]/*' />
    [NativeTypeName("ULONG")]
    public uint PagedPoolAllocs;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.PagedPoolFrees"]/*' />
    [NativeTypeName("ULONG")]
    public uint PagedPoolFrees;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.NonPagedPoolAllocs"]/*' />
    [NativeTypeName("ULONG")]
    public uint NonPagedPoolAllocs;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.NonPagedPoolFrees"]/*' />
    [NativeTypeName("ULONG")]
    public uint NonPagedPoolFrees;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.FreeSystemPtes"]/*' />
    [NativeTypeName("ULONG")]
    public uint FreeSystemPtes;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.ResidentSystemCodePage"]/*' />
    [NativeTypeName("ULONG")]
    public uint ResidentSystemCodePage;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.TotalSystemDriverPages"]/*' />
    [NativeTypeName("ULONG")]
    public uint TotalSystemDriverPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.TotalSystemCodePages"]/*' />
    [NativeTypeName("ULONG")]
    public uint TotalSystemCodePages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.NonPagedPoolLookasideHits"]/*' />
    [NativeTypeName("ULONG")]
    public uint NonPagedPoolLookasideHits;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.PagedPoolLookasideHits"]/*' />
    [NativeTypeName("ULONG")]
    public uint PagedPoolLookasideHits;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.AvailablePagedPoolPages"]/*' />
    [NativeTypeName("ULONG")]
    public uint AvailablePagedPoolPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.ResidentSystemCachePage"]/*' />
    [NativeTypeName("ULONG")]
    public uint ResidentSystemCachePage;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.ResidentPagedPoolPage"]/*' />
    [NativeTypeName("ULONG")]
    public uint ResidentPagedPoolPage;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.ResidentSystemDriverPage"]/*' />
    [NativeTypeName("ULONG")]
    public uint ResidentSystemDriverPage;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcFastReadNoWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastReadNoWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcFastReadWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastReadWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcFastReadResourceMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastReadResourceMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcFastReadNotPossible"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastReadNotPossible;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcFastMdlReadNoWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastMdlReadNoWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcFastMdlReadWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastMdlReadWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcFastMdlReadResourceMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastMdlReadResourceMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcFastMdlReadNotPossible"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcFastMdlReadNotPossible;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcMapDataNoWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMapDataNoWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcMapDataWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMapDataWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcMapDataNoWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMapDataNoWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcMapDataWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMapDataWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcPinMappedDataCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcPinMappedDataCount;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcPinReadNoWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcPinReadNoWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcPinReadWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcPinReadWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcPinReadNoWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcPinReadNoWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcPinReadWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcPinReadWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcCopyReadNoWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcCopyReadNoWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcCopyReadWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcCopyReadWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcCopyReadNoWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcCopyReadNoWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcCopyReadWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcCopyReadWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcMdlReadNoWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMdlReadNoWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcMdlReadWait"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMdlReadWait;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcMdlReadNoWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMdlReadNoWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcMdlReadWaitMiss"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcMdlReadWaitMiss;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcReadAheadIos"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcReadAheadIos;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcLazyWriteIos"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcLazyWriteIos;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcLazyWritePages"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcLazyWritePages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcDataFlushes"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcDataFlushes;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcDataPages"]/*' />
    [NativeTypeName("ULONG")]
    public uint CcDataPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.ContextSwitches"]/*' />
    [NativeTypeName("ULONG")]
    public uint ContextSwitches;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.FirstLevelTbFills"]/*' />
    [NativeTypeName("ULONG")]
    public uint FirstLevelTbFills;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.SecondLevelTbFills"]/*' />
    [NativeTypeName("ULONG")]
    public uint SecondLevelTbFills;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.SystemCalls"]/*' />
    [NativeTypeName("ULONG")]
    public uint SystemCalls;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcTotalDirtyPages"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong CcTotalDirtyPages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.CcDirtyPageThreshold"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong CcDirtyPageThreshold;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.ResidentAvailablePages"]/*' />
    [NativeTypeName("LONG64")]
    public long ResidentAvailablePages;

    /// <include file='MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION.SharedCommittedPages"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong SharedCommittedPages;
}
