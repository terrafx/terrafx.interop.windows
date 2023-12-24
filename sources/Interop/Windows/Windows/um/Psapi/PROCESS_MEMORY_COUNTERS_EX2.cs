// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PROCESS_MEMORY_COUNTERS_EX2.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX2"]/*' />
public partial struct PROCESS_MEMORY_COUNTERS_EX2
{
    /// <include file='PROCESS_MEMORY_COUNTERS_EX2.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX2.cb"]/*' />
    [NativeTypeName("DWORD")]
    public uint cb;

    /// <include file='PROCESS_MEMORY_COUNTERS_EX2.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX2.PageFaultCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint PageFaultCount;

    /// <include file='PROCESS_MEMORY_COUNTERS_EX2.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX2.PeakWorkingSetSize"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint PeakWorkingSetSize;

    /// <include file='PROCESS_MEMORY_COUNTERS_EX2.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX2.WorkingSetSize"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint WorkingSetSize;

    /// <include file='PROCESS_MEMORY_COUNTERS_EX2.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX2.QuotaPeakPagedPoolUsage"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint QuotaPeakPagedPoolUsage;

    /// <include file='PROCESS_MEMORY_COUNTERS_EX2.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX2.QuotaPagedPoolUsage"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint QuotaPagedPoolUsage;

    /// <include file='PROCESS_MEMORY_COUNTERS_EX2.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX2.QuotaPeakNonPagedPoolUsage"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint QuotaPeakNonPagedPoolUsage;

    /// <include file='PROCESS_MEMORY_COUNTERS_EX2.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX2.QuotaNonPagedPoolUsage"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint QuotaNonPagedPoolUsage;

    /// <include file='PROCESS_MEMORY_COUNTERS_EX2.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX2.PagefileUsage"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint PagefileUsage;

    /// <include file='PROCESS_MEMORY_COUNTERS_EX2.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX2.PeakPagefileUsage"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint PeakPagefileUsage;

    /// <include file='PROCESS_MEMORY_COUNTERS_EX2.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX2.PrivateUsage"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint PrivateUsage;

    /// <include file='PROCESS_MEMORY_COUNTERS_EX2.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX2.PrivateWorkingSetSize"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint PrivateWorkingSetSize;

    /// <include file='PROCESS_MEMORY_COUNTERS_EX2.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX2.SharedCommitUsage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong SharedCommitUsage;
}
