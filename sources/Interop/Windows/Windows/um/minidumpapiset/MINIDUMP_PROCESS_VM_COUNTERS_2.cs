// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_PROCESS_VM_COUNTERS_2
{
    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.Revision"]/*' />
    public ushort Revision;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.Flags"]/*' />
    public ushort Flags;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.PageFaultCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint PageFaultCount;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.PeakWorkingSetSize"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong PeakWorkingSetSize;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.WorkingSetSize"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong WorkingSetSize;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.QuotaPeakPagedPoolUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong QuotaPeakPagedPoolUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.QuotaPagedPoolUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong QuotaPagedPoolUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.QuotaPeakNonPagedPoolUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong QuotaPeakNonPagedPoolUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.QuotaNonPagedPoolUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong QuotaNonPagedPoolUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.PagefileUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong PagefileUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.PeakPagefileUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong PeakPagefileUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.PeakVirtualSize"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong PeakVirtualSize;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.VirtualSize"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong VirtualSize;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.PrivateUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong PrivateUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.PrivateWorkingSetSize"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong PrivateWorkingSetSize;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.SharedCommitUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong SharedCommitUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.JobSharedCommitUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong JobSharedCommitUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.JobPrivateCommitUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong JobPrivateCommitUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.JobPeakPrivateCommitUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong JobPeakPrivateCommitUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.JobPrivateCommitLimit"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong JobPrivateCommitLimit;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_2.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_2.JobTotalCommitLimit"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong JobTotalCommitLimit;
}
