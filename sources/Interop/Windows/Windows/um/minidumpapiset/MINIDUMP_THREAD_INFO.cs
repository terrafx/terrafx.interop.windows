// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_THREAD_INFO.xml' path='doc/member[@name="MINIDUMP_THREAD_INFO"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_THREAD_INFO
{
    /// <include file='MINIDUMP_THREAD_INFO.xml' path='doc/member[@name="MINIDUMP_THREAD_INFO.ThreadId"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ThreadId;

    /// <include file='MINIDUMP_THREAD_INFO.xml' path='doc/member[@name="MINIDUMP_THREAD_INFO.DumpFlags"]/*' />
    [NativeTypeName("ULONG32")]
    public uint DumpFlags;

    /// <include file='MINIDUMP_THREAD_INFO.xml' path='doc/member[@name="MINIDUMP_THREAD_INFO.DumpError"]/*' />
    [NativeTypeName("ULONG32")]
    public uint DumpError;

    /// <include file='MINIDUMP_THREAD_INFO.xml' path='doc/member[@name="MINIDUMP_THREAD_INFO.ExitStatus"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ExitStatus;

    /// <include file='MINIDUMP_THREAD_INFO.xml' path='doc/member[@name="MINIDUMP_THREAD_INFO.CreateTime"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong CreateTime;

    /// <include file='MINIDUMP_THREAD_INFO.xml' path='doc/member[@name="MINIDUMP_THREAD_INFO.ExitTime"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ExitTime;

    /// <include file='MINIDUMP_THREAD_INFO.xml' path='doc/member[@name="MINIDUMP_THREAD_INFO.KernelTime"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong KernelTime;

    /// <include file='MINIDUMP_THREAD_INFO.xml' path='doc/member[@name="MINIDUMP_THREAD_INFO.UserTime"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong UserTime;

    /// <include file='MINIDUMP_THREAD_INFO.xml' path='doc/member[@name="MINIDUMP_THREAD_INFO.StartAddress"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong StartAddress;

    /// <include file='MINIDUMP_THREAD_INFO.xml' path='doc/member[@name="MINIDUMP_THREAD_INFO.Affinity"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Affinity;
}
