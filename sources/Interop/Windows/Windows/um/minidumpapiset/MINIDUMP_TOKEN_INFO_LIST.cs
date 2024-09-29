// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_TOKEN_INFO_LIST.xml' path='doc/member[@name="MINIDUMP_TOKEN_INFO_LIST"]/*' />
public partial struct MINIDUMP_TOKEN_INFO_LIST
{
    /// <include file='MINIDUMP_TOKEN_INFO_LIST.xml' path='doc/member[@name="MINIDUMP_TOKEN_INFO_LIST.TokenListSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint TokenListSize;

    /// <include file='MINIDUMP_TOKEN_INFO_LIST.xml' path='doc/member[@name="MINIDUMP_TOKEN_INFO_LIST.TokenListEntries"]/*' />
    [NativeTypeName("ULONG")]
    public uint TokenListEntries;

    /// <include file='MINIDUMP_TOKEN_INFO_LIST.xml' path='doc/member[@name="MINIDUMP_TOKEN_INFO_LIST.ListHeaderSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint ListHeaderSize;

    /// <include file='MINIDUMP_TOKEN_INFO_LIST.xml' path='doc/member[@name="MINIDUMP_TOKEN_INFO_LIST.ElementHeaderSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint ElementHeaderSize;
}
