// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_VM_PRE_READ_CALLBACK.xml' path='doc/member[@name="MINIDUMP_VM_PRE_READ_CALLBACK"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct MINIDUMP_VM_PRE_READ_CALLBACK
{
    /// <include file='MINIDUMP_VM_PRE_READ_CALLBACK.xml' path='doc/member[@name="MINIDUMP_VM_PRE_READ_CALLBACK.Offset"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Offset;

    /// <include file='MINIDUMP_VM_PRE_READ_CALLBACK.xml' path='doc/member[@name="MINIDUMP_VM_PRE_READ_CALLBACK.Buffer"]/*' />
    [NativeTypeName("PVOID")]
    public void* Buffer;

    /// <include file='MINIDUMP_VM_PRE_READ_CALLBACK.xml' path='doc/member[@name="MINIDUMP_VM_PRE_READ_CALLBACK.Size"]/*' />
    [NativeTypeName("ULONG")]
    public uint Size;
}
