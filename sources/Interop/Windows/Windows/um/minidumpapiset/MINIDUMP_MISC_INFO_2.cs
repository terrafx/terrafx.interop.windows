// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_MISC_INFO_2.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_2"]/*' />
public partial struct MINIDUMP_MISC_INFO_2
{
    /// <include file='MINIDUMP_MISC_INFO_2.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_2.SizeOfInfo"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfInfo;

    /// <include file='MINIDUMP_MISC_INFO_2.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_2.Flags1"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Flags1;

    /// <include file='MINIDUMP_MISC_INFO_2.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_2.ProcessId"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessId;

    /// <include file='MINIDUMP_MISC_INFO_2.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_2.ProcessCreateTime"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessCreateTime;

    /// <include file='MINIDUMP_MISC_INFO_2.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_2.ProcessUserTime"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessUserTime;

    /// <include file='MINIDUMP_MISC_INFO_2.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_2.ProcessKernelTime"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessKernelTime;

    /// <include file='MINIDUMP_MISC_INFO_2.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_2.ProcessorMaxMhz"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessorMaxMhz;

    /// <include file='MINIDUMP_MISC_INFO_2.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_2.ProcessorCurrentMhz"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessorCurrentMhz;

    /// <include file='MINIDUMP_MISC_INFO_2.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_2.ProcessorMhzLimit"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessorMhzLimit;

    /// <include file='MINIDUMP_MISC_INFO_2.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_2.ProcessorMaxIdleState"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessorMaxIdleState;

    /// <include file='MINIDUMP_MISC_INFO_2.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_2.ProcessorCurrentIdleState"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessorCurrentIdleState;
}
