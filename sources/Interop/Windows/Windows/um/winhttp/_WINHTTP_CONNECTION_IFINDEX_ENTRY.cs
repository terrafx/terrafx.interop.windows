// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='_WINHTTP_CONNECTION_IFINDEX_ENTRY.xml' path='doc/member[@name="_WINHTTP_CONNECTION_IFINDEX_ENTRY"]/*' />
public unsafe partial struct _WINHTTP_CONNECTION_IFINDEX_ENTRY
{
    /// <include file='_WINHTTP_CONNECTION_IFINDEX_ENTRY.xml' path='doc/member[@name="_WINHTTP_CONNECTION_IFINDEX_ENTRY.pwszConnectionName"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pwszConnectionName;

    /// <include file='_WINHTTP_CONNECTION_IFINDEX_ENTRY.xml' path='doc/member[@name="_WINHTTP_CONNECTION_IFINDEX_ENTRY.dwIfIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwIfIndex;
}
