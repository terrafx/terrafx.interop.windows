// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_CHANNEL_BIND_INFO.xml' path='doc/member[@name="HTTP_CHANNEL_BIND_INFO"]/*' />
public unsafe partial struct HTTP_CHANNEL_BIND_INFO
{
    /// <include file='HTTP_CHANNEL_BIND_INFO.xml' path='doc/member[@name="HTTP_CHANNEL_BIND_INFO.Hardening"]/*' />
    public HTTP_AUTHENTICATION_HARDENING_LEVELS Hardening;

    /// <include file='HTTP_CHANNEL_BIND_INFO.xml' path='doc/member[@name="HTTP_CHANNEL_BIND_INFO.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='HTTP_CHANNEL_BIND_INFO.xml' path='doc/member[@name="HTTP_CHANNEL_BIND_INFO.ServiceNames"]/*' />
    [NativeTypeName("PHTTP_SERVICE_BINDING_BASE *")]
    public HTTP_SERVICE_BINDING_BASE** ServiceNames;

    /// <include file='HTTP_CHANNEL_BIND_INFO.xml' path='doc/member[@name="HTTP_CHANNEL_BIND_INFO.NumberOfServiceNames"]/*' />
    [NativeTypeName("ULONG")]
    public uint NumberOfServiceNames;
}
