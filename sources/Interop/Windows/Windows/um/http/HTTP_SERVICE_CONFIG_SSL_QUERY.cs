// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVICE_CONFIG_SSL_QUERY.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_QUERY"]/*' />
public partial struct HTTP_SERVICE_CONFIG_SSL_QUERY
{
    /// <include file='HTTP_SERVICE_CONFIG_SSL_QUERY.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_QUERY.QueryDesc"]/*' />
    public HTTP_SERVICE_CONFIG_QUERY_TYPE QueryDesc;

    /// <include file='HTTP_SERVICE_CONFIG_SSL_QUERY.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_QUERY.KeyDesc"]/*' />
    public HTTP_SERVICE_CONFIG_SSL_KEY KeyDesc;

    /// <include file='HTTP_SERVICE_CONFIG_SSL_QUERY.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_QUERY.dwToken"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwToken;
}
