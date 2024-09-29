// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_PROCESS_VM_COUNTERS_1.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_1"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_PROCESS_VM_COUNTERS_1
{
    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_1.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_1.Revision"]/*' />
    public ushort Revision;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_1.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_1.PageFaultCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint PageFaultCount;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_1.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_1.PeakWorkingSetSize"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong PeakWorkingSetSize;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_1.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_1.WorkingSetSize"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong WorkingSetSize;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_1.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_1.QuotaPeakPagedPoolUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong QuotaPeakPagedPoolUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_1.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_1.QuotaPagedPoolUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong QuotaPagedPoolUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_1.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_1.QuotaPeakNonPagedPoolUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong QuotaPeakNonPagedPoolUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_1.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_1.QuotaNonPagedPoolUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong QuotaNonPagedPoolUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_1.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_1.PagefileUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong PagefileUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_1.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_1.PeakPagefileUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong PeakPagefileUsage;

    /// <include file='MINIDUMP_PROCESS_VM_COUNTERS_1.xml' path='doc/member[@name="MINIDUMP_PROCESS_VM_COUNTERS_1.PrivateUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong PrivateUsage;
}
