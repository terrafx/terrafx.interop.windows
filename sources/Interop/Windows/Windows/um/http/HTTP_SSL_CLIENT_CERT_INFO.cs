// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SSL_CLIENT_CERT_INFO.xml' path='doc/member[@name="HTTP_SSL_CLIENT_CERT_INFO"]/*' />
public unsafe partial struct HTTP_SSL_CLIENT_CERT_INFO
{
    /// <include file='HTTP_SSL_CLIENT_CERT_INFO.xml' path='doc/member[@name="HTTP_SSL_CLIENT_CERT_INFO.CertFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint CertFlags;

    /// <include file='HTTP_SSL_CLIENT_CERT_INFO.xml' path='doc/member[@name="HTTP_SSL_CLIENT_CERT_INFO.CertEncodedSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint CertEncodedSize;

    /// <include file='HTTP_SSL_CLIENT_CERT_INFO.xml' path='doc/member[@name="HTTP_SSL_CLIENT_CERT_INFO.pCertEncoded"]/*' />
    [NativeTypeName("PUCHAR")]
    public byte* pCertEncoded;

    /// <include file='HTTP_SSL_CLIENT_CERT_INFO.xml' path='doc/member[@name="HTTP_SSL_CLIENT_CERT_INFO.Token"]/*' />
    public HANDLE Token;

    /// <include file='HTTP_SSL_CLIENT_CERT_INFO.xml' path='doc/member[@name="HTTP_SSL_CLIENT_CERT_INFO.CertDeniedByMapper"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte CertDeniedByMapper;
}
