// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVICE_CONFIG_IP_LISTEN_PARAM.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_IP_LISTEN_PARAM"]/*' />
public unsafe partial struct HTTP_SERVICE_CONFIG_IP_LISTEN_PARAM
{
    /// <include file='HTTP_SERVICE_CONFIG_IP_LISTEN_PARAM.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_IP_LISTEN_PARAM.AddrLength"]/*' />
    public ushort AddrLength;

    /// <include file='HTTP_SERVICE_CONFIG_IP_LISTEN_PARAM.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_IP_LISTEN_PARAM.pAddress"]/*' />
    [NativeTypeName("PSOCKADDR")]
    public SOCKADDR* pAddress;
}
