// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVICE_CONFIG_SSL_KEY.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_KEY"]/*' />
public unsafe partial struct HTTP_SERVICE_CONFIG_SSL_KEY
{
    /// <include file='HTTP_SERVICE_CONFIG_SSL_KEY.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_KEY.pIpPort"]/*' />
    [NativeTypeName("PSOCKADDR")]
    public SOCKADDR* pIpPort;
}
