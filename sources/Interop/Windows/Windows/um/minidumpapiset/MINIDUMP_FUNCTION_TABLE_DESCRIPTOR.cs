// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_FUNCTION_TABLE_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_FUNCTION_TABLE_DESCRIPTOR"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_FUNCTION_TABLE_DESCRIPTOR
{
    /// <include file='MINIDUMP_FUNCTION_TABLE_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_FUNCTION_TABLE_DESCRIPTOR.MinimumAddress"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong MinimumAddress;

    /// <include file='MINIDUMP_FUNCTION_TABLE_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_FUNCTION_TABLE_DESCRIPTOR.MaximumAddress"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong MaximumAddress;

    /// <include file='MINIDUMP_FUNCTION_TABLE_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_FUNCTION_TABLE_DESCRIPTOR.BaseAddress"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong BaseAddress;

    /// <include file='MINIDUMP_FUNCTION_TABLE_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_FUNCTION_TABLE_DESCRIPTOR.EntryCount"]/*' />
    [NativeTypeName("ULONG32")]
    public uint EntryCount;

    /// <include file='MINIDUMP_FUNCTION_TABLE_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_FUNCTION_TABLE_DESCRIPTOR.SizeOfAlignPad"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfAlignPad;
}
