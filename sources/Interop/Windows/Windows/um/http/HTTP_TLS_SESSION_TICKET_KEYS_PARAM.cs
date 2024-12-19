// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_TLS_SESSION_TICKET_KEYS_PARAM.xml' path='doc/member[@name="HTTP_TLS_SESSION_TICKET_KEYS_PARAM"]/*' />
public unsafe partial struct HTTP_TLS_SESSION_TICKET_KEYS_PARAM
{
    /// <include file='HTTP_TLS_SESSION_TICKET_KEYS_PARAM.xml' path='doc/member[@name="HTTP_TLS_SESSION_TICKET_KEYS_PARAM.SessionTicketKeyCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint SessionTicketKeyCount;

    /// <include file='HTTP_TLS_SESSION_TICKET_KEYS_PARAM.xml' path='doc/member[@name="HTTP_TLS_SESSION_TICKET_KEYS_PARAM.SessionTicketKeys"]/*' />
    [NativeTypeName("PVOID")]
    public void* SessionTicketKeys;
}
