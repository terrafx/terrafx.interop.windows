// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_SYSTEM_BASIC_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_INFORMATION"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_SYSTEM_BASIC_INFORMATION
{
    /// <include file='MINIDUMP_SYSTEM_BASIC_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_INFORMATION.TimerResolution"]/*' />
    [NativeTypeName("ULONG")]
    public uint TimerResolution;

    /// <include file='MINIDUMP_SYSTEM_BASIC_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_INFORMATION.PageSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint PageSize;

    /// <include file='MINIDUMP_SYSTEM_BASIC_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_INFORMATION.NumberOfPhysicalPages"]/*' />
    [NativeTypeName("ULONG")]
    public uint NumberOfPhysicalPages;

    /// <include file='MINIDUMP_SYSTEM_BASIC_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_INFORMATION.LowestPhysicalPageNumber"]/*' />
    [NativeTypeName("ULONG")]
    public uint LowestPhysicalPageNumber;

    /// <include file='MINIDUMP_SYSTEM_BASIC_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_INFORMATION.HighestPhysicalPageNumber"]/*' />
    [NativeTypeName("ULONG")]
    public uint HighestPhysicalPageNumber;

    /// <include file='MINIDUMP_SYSTEM_BASIC_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_INFORMATION.AllocationGranularity"]/*' />
    [NativeTypeName("ULONG")]
    public uint AllocationGranularity;

    /// <include file='MINIDUMP_SYSTEM_BASIC_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_INFORMATION.MinimumUserModeAddress"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong MinimumUserModeAddress;

    /// <include file='MINIDUMP_SYSTEM_BASIC_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_INFORMATION.MaximumUserModeAddress"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong MaximumUserModeAddress;

    /// <include file='MINIDUMP_SYSTEM_BASIC_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_INFORMATION.ActiveProcessorsAffinityMask"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ActiveProcessorsAffinityMask;

    /// <include file='MINIDUMP_SYSTEM_BASIC_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_INFORMATION.NumberOfProcessors"]/*' />
    [NativeTypeName("ULONG")]
    public uint NumberOfProcessors;
}
