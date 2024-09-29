// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_THREAD.xml' path='doc/member[@name="MINIDUMP_THREAD"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_THREAD
{
    /// <include file='MINIDUMP_THREAD.xml' path='doc/member[@name="MINIDUMP_THREAD.ThreadId"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ThreadId;

    /// <include file='MINIDUMP_THREAD.xml' path='doc/member[@name="MINIDUMP_THREAD.SuspendCount"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SuspendCount;

    /// <include file='MINIDUMP_THREAD.xml' path='doc/member[@name="MINIDUMP_THREAD.PriorityClass"]/*' />
    [NativeTypeName("ULONG32")]
    public uint PriorityClass;

    /// <include file='MINIDUMP_THREAD.xml' path='doc/member[@name="MINIDUMP_THREAD.Priority"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Priority;

    /// <include file='MINIDUMP_THREAD.xml' path='doc/member[@name="MINIDUMP_THREAD.Teb"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Teb;

    /// <include file='MINIDUMP_THREAD.xml' path='doc/member[@name="MINIDUMP_THREAD.Stack"]/*' />
    public MINIDUMP_MEMORY_DESCRIPTOR Stack;

    /// <include file='MINIDUMP_THREAD.xml' path='doc/member[@name="MINIDUMP_THREAD.ThreadContext"]/*' />
    public MINIDUMP_LOCATION_DESCRIPTOR ThreadContext;
}
