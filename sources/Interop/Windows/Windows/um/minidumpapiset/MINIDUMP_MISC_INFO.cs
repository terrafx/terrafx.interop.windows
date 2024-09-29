// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_MISC_INFO.xml' path='doc/member[@name="MINIDUMP_MISC_INFO"]/*' />
public partial struct MINIDUMP_MISC_INFO
{
    /// <include file='MINIDUMP_MISC_INFO.xml' path='doc/member[@name="MINIDUMP_MISC_INFO.SizeOfInfo"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfInfo;

    /// <include file='MINIDUMP_MISC_INFO.xml' path='doc/member[@name="MINIDUMP_MISC_INFO.Flags1"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Flags1;

    /// <include file='MINIDUMP_MISC_INFO.xml' path='doc/member[@name="MINIDUMP_MISC_INFO.ProcessId"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessId;

    /// <include file='MINIDUMP_MISC_INFO.xml' path='doc/member[@name="MINIDUMP_MISC_INFO.ProcessCreateTime"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessCreateTime;

    /// <include file='MINIDUMP_MISC_INFO.xml' path='doc/member[@name="MINIDUMP_MISC_INFO.ProcessUserTime"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessUserTime;

    /// <include file='MINIDUMP_MISC_INFO.xml' path='doc/member[@name="MINIDUMP_MISC_INFO.ProcessKernelTime"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ProcessKernelTime;
}
