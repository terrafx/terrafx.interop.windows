// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_IO_CALLBACK.xml' path='doc/member[@name="MINIDUMP_IO_CALLBACK"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct MINIDUMP_IO_CALLBACK
{
    /// <include file='MINIDUMP_IO_CALLBACK.xml' path='doc/member[@name="MINIDUMP_IO_CALLBACK.Handle"]/*' />
    public HANDLE Handle;

    /// <include file='MINIDUMP_IO_CALLBACK.xml' path='doc/member[@name="MINIDUMP_IO_CALLBACK.Offset"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Offset;

    /// <include file='MINIDUMP_IO_CALLBACK.xml' path='doc/member[@name="MINIDUMP_IO_CALLBACK.Buffer"]/*' />
    [NativeTypeName("PVOID")]
    public void* Buffer;

    /// <include file='MINIDUMP_IO_CALLBACK.xml' path='doc/member[@name="MINIDUMP_IO_CALLBACK.BufferBytes"]/*' />
    [NativeTypeName("ULONG")]
    public uint BufferBytes;
}
