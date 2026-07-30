// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_THREAD_EX.xml' path='doc/member[@name="MINIDUMP_THREAD_EX"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_THREAD_EX
{
    /// <include file='MINIDUMP_THREAD_EX.xml' path='doc/member[@name="MINIDUMP_THREAD_EX.ThreadId"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ThreadId;

    /// <include file='MINIDUMP_THREAD_EX.xml' path='doc/member[@name="MINIDUMP_THREAD_EX.SuspendCount"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SuspendCount;

    /// <include file='MINIDUMP_THREAD_EX.xml' path='doc/member[@name="MINIDUMP_THREAD_EX.PriorityClass"]/*' />
    [NativeTypeName("ULONG32")]
    public uint PriorityClass;

    /// <include file='MINIDUMP_THREAD_EX.xml' path='doc/member[@name="MINIDUMP_THREAD_EX.Priority"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Priority;

    /// <include file='MINIDUMP_THREAD_EX.xml' path='doc/member[@name="MINIDUMP_THREAD_EX.Teb"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Teb;

    /// <include file='MINIDUMP_THREAD_EX.xml' path='doc/member[@name="MINIDUMP_THREAD_EX.Stack"]/*' />
    public MINIDUMP_MEMORY_DESCRIPTOR Stack;

    /// <include file='MINIDUMP_THREAD_EX.xml' path='doc/member[@name="MINIDUMP_THREAD_EX.ThreadContext"]/*' />
    public MINIDUMP_LOCATION_DESCRIPTOR ThreadContext;

    /// <include file='MINIDUMP_THREAD_EX.xml' path='doc/member[@name="MINIDUMP_THREAD_EX.BackingStore"]/*' />
    public MINIDUMP_MEMORY_DESCRIPTOR BackingStore;
}
