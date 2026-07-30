// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_MEMORY_INFO_LIST.xml' path='doc/member[@name="MINIDUMP_MEMORY_INFO_LIST"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_MEMORY_INFO_LIST
{
    /// <include file='MINIDUMP_MEMORY_INFO_LIST.xml' path='doc/member[@name="MINIDUMP_MEMORY_INFO_LIST.SizeOfHeader"]/*' />
    [NativeTypeName("ULONG")]
    public uint SizeOfHeader;

    /// <include file='MINIDUMP_MEMORY_INFO_LIST.xml' path='doc/member[@name="MINIDUMP_MEMORY_INFO_LIST.SizeOfEntry"]/*' />
    [NativeTypeName("ULONG")]
    public uint SizeOfEntry;

    /// <include file='MINIDUMP_MEMORY_INFO_LIST.xml' path='doc/member[@name="MINIDUMP_MEMORY_INFO_LIST.NumberOfEntries"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong NumberOfEntries;
}
