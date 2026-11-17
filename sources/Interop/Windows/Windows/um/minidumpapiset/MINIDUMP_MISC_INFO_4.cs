// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4"]/*' />
public partial struct MINIDUMP_MISC_INFO_4
{
    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.SizeOfInfo"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfInfo;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.Flags1"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Flags1;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.ProcessId"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessId;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.ProcessCreateTime"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessCreateTime;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.ProcessUserTime"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessUserTime;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.ProcessKernelTime"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessKernelTime;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.ProcessorMaxMhz"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessorMaxMhz;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.ProcessorCurrentMhz"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessorCurrentMhz;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.ProcessorMhzLimit"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessorMhzLimit;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.ProcessorMaxIdleState"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessorMaxIdleState;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.ProcessorCurrentIdleState"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessorCurrentIdleState;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.ProcessIntegrityLevel"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessIntegrityLevel;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.ProcessExecuteFlags"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessExecuteFlags;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.ProtectedProcess"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProtectedProcess;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.TimeZoneId"]/*' />
    [NativeTypeName("ULONG32")]
    public uint TimeZoneId;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.TimeZone"]/*' />
    public TIME_ZONE_INFORMATION TimeZone;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.BuildString"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _BuildString_e__FixedBuffer BuildString;

    /// <include file='MINIDUMP_MISC_INFO_4.xml' path='doc/member[@name="MINIDUMP_MISC_INFO_4.DbgBldStr"]/*' />
    [NativeTypeName("WCHAR[40]")]
    public _DbgBldStr_e__FixedBuffer DbgBldStr;

    /// <include file='_BuildString_e__FixedBuffer.xml' path='doc/member[@name="_BuildString_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _BuildString_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_DbgBldStr_e__FixedBuffer.xml' path='doc/member[@name="_DbgBldStr_e__FixedBuffer"]/*' />
    [InlineArray(40)]
    public partial struct _DbgBldStr_e__FixedBuffer
    {
        public char e0;
    }
}
