// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3"]/*' />
public partial struct MINIDUMP_MISC_INFO_3
{
    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.SizeOfInfo"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfInfo;

    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.Flags1"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Flags1;

    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.ProcessId"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessId;

    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.ProcessCreateTime"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessCreateTime;

    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.ProcessUserTime"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessUserTime;

    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.ProcessKernelTime"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessKernelTime;

    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.ProcessorMaxMhz"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessorMaxMhz;

    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.ProcessorCurrentMhz"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessorCurrentMhz;

    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.ProcessorMhzLimit"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessorMhzLimit;

    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.ProcessorMaxIdleState"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessorMaxIdleState;

    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.ProcessorCurrentIdleState"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessorCurrentIdleState;

    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.ProcessIntegrityLevel"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessIntegrityLevel;

    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.ProcessExecuteFlags"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessExecuteFlags;

    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.ProtectedProcess"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProtectedProcess;

    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.TimeZoneId"]/*' />
    [NativeTypeName("ULONG32")]
    public uint TimeZoneId;

    /// <include file='MINIDUMP_MISC_INFO_3.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_3.TimeZone"]/*' />
    public TIME_ZONE_INFORMATION TimeZone;
}
