// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_HANDLE_OPERATION_LIST.xml' path='doc/member[@name="MINIDUMP_HANDLE_OPERATION_LIST"]/*' />
public partial struct MINIDUMP_HANDLE_OPERATION_LIST
{
    /// <include file='MINIDUMP_HANDLE_OPERATION_LIST.xml' path='doc/member[@name="MINIDUMP_HANDLE_OPERATION_LIST.SizeOfHeader"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfHeader;

    /// <include file='MINIDUMP_HANDLE_OPERATION_LIST.xml' path='doc/member[@name="MINIDUMP_HANDLE_OPERATION_LIST.SizeOfEntry"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfEntry;

    /// <include file='MINIDUMP_HANDLE_OPERATION_LIST.xml' path='doc/member[@name="MINIDUMP_HANDLE_OPERATION_LIST.NumberOfEntries"]/*' />
    [NativeTypeName("ULONG32")]
    public uint NumberOfEntries;

    /// <include file='MINIDUMP_HANDLE_OPERATION_LIST.xml' path='doc/member[@name="MINIDUMP_HANDLE_OPERATION_LIST.Reserved"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Reserved;
}
