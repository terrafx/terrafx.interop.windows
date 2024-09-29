// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_THREAD_INFO_LIST.xml' path='doc/member[@name="MINIDUMP_THREAD_INFO_LIST"]/*' />
public partial struct MINIDUMP_THREAD_INFO_LIST
{
    /// <include file='MINIDUMP_THREAD_INFO_LIST.xml' path='doc/member[@name="MINIDUMP_THREAD_INFO_LIST.SizeOfHeader"]/*' />
    [NativeTypeName("ULONG")]
    public uint SizeOfHeader;

    /// <include file='MINIDUMP_THREAD_INFO_LIST.xml' path='doc/member[@name="MINIDUMP_THREAD_INFO_LIST.SizeOfEntry"]/*' />
    [NativeTypeName("ULONG")]
    public uint SizeOfEntry;

    /// <include file='MINIDUMP_THREAD_INFO_LIST.xml' path='doc/member[@name="MINIDUMP_THREAD_INFO_LIST.NumberOfEntries"]/*' />
    [NativeTypeName("ULONG")]
    public uint NumberOfEntries;
}
