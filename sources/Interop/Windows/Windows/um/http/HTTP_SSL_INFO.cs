// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SSL_INFO.xml' path='doc/member[@name="HTTP_SSL_INFO"]/*' />
public unsafe partial struct HTTP_SSL_INFO
{
    /// <include file='HTTP_SSL_INFO.xml' path='doc/member[@name="HTTP_SSL_INFO.ServerCertKeySize"]/*' />
    public ushort ServerCertKeySize;

    /// <include file='HTTP_SSL_INFO.xml' path='doc/member[@name="HTTP_SSL_INFO.ConnectionKeySize"]/*' />
    public ushort ConnectionKeySize;

    /// <include file='HTTP_SSL_INFO.xml' path='doc/member[@name="HTTP_SSL_INFO.ServerCertIssuerSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint ServerCertIssuerSize;

    /// <include file='HTTP_SSL_INFO.xml' path='doc/member[@name="HTTP_SSL_INFO.ServerCertSubjectSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint ServerCertSubjectSize;

    /// <include file='HTTP_SSL_INFO.xml' path='doc/member[@name="HTTP_SSL_INFO.pServerCertIssuer"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* pServerCertIssuer;

    /// <include file='HTTP_SSL_INFO.xml' path='doc/member[@name="HTTP_SSL_INFO.pServerCertSubject"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* pServerCertSubject;

    /// <include file='HTTP_SSL_INFO.xml' path='doc/member[@name="HTTP_SSL_INFO.pClientCertInfo"]/*' />
    [NativeTypeName("PHTTP_SSL_CLIENT_CERT_INFO")]
    public HTTP_SSL_CLIENT_CERT_INFO* pClientCertInfo;

    /// <include file='HTTP_SSL_INFO.xml' path='doc/member[@name="HTTP_SSL_INFO.SslClientCertNegotiated"]/*' />
    [NativeTypeName("ULONG")]
    public uint SslClientCertNegotiated;
}
