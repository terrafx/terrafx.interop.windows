// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='KERB_QUERY_S4U2PROXY_CACHE_REQUEST.xml' path='doc/member[@name="KERB_QUERY_S4U2PROXY_CACHE_REQUEST"]/*' />
public partial struct KERB_QUERY_S4U2PROXY_CACHE_REQUEST
{
    /// <include file='KERB_QUERY_S4U2PROXY_CACHE_REQUEST.xml' path='doc/member[@name="KERB_QUERY_S4U2PROXY_CACHE_REQUEST.MessageType"]/*' />
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;

    /// <include file='KERB_QUERY_S4U2PROXY_CACHE_REQUEST.xml' path='doc/member[@name="KERB_QUERY_S4U2PROXY_CACHE_REQUEST.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='KERB_QUERY_S4U2PROXY_CACHE_REQUEST.xml' path='doc/member[@name="KERB_QUERY_S4U2PROXY_CACHE_REQUEST.LogonId"]/*' />
    public LUID LogonId;
}
