// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_THREAD_EX_CALLBACK.xml' path='doc/member[@name="MINIDUMP_THREAD_EX_CALLBACK"]/*' />
public unsafe partial struct MINIDUMP_THREAD_EX_CALLBACK
{
    /// <include file='MINIDUMP_THREAD_EX_CALLBACK.xml' path='doc/member[@name="MINIDUMP_THREAD_EX_CALLBACK.ThreadId"]/*' />
    [NativeTypeName("ULONG")]
    public uint ThreadId;

    /// <include file='MINIDUMP_THREAD_EX_CALLBACK.xml' path='doc/member[@name="MINIDUMP_THREAD_EX_CALLBACK.ThreadHandle"]/*' />
    public HANDLE ThreadHandle;

    /// <include file='MINIDUMP_THREAD_EX_CALLBACK.xml' path='doc/member[@name="MINIDUMP_THREAD_EX_CALLBACK.Context"]/*' />
    [NativeTypeName("CONTEXT")]
    public void* Context;

    /// <include file='MINIDUMP_THREAD_EX_CALLBACK.xml' path='doc/member[@name="MINIDUMP_THREAD_EX_CALLBACK.SizeOfContext"]/*' />
    [NativeTypeName("ULONG")]
    public uint SizeOfContext;

    /// <include file='MINIDUMP_THREAD_EX_CALLBACK.xml' path='doc/member[@name="MINIDUMP_THREAD_EX_CALLBACK.StackBase"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong StackBase;

    /// <include file='MINIDUMP_THREAD_EX_CALLBACK.xml' path='doc/member[@name="MINIDUMP_THREAD_EX_CALLBACK.StackEnd"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong StackEnd;

    /// <include file='MINIDUMP_THREAD_EX_CALLBACK.xml' path='doc/member[@name="MINIDUMP_THREAD_EX_CALLBACK.BackingStoreBase"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong BackingStoreBase;

    /// <include file='MINIDUMP_THREAD_EX_CALLBACK.xml' path='doc/member[@name="MINIDUMP_THREAD_EX_CALLBACK.BackingStoreEnd"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong BackingStoreEnd;
}
