// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVICE_CONFIG_SSL_PARAM.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_PARAM"]/*' />
public unsafe partial struct HTTP_SERVICE_CONFIG_SSL_PARAM
{
    /// <include file='HTTP_SERVICE_CONFIG_SSL_PARAM.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_PARAM.SslHashLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint SslHashLength;

    /// <include file='HTTP_SERVICE_CONFIG_SSL_PARAM.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_PARAM.pSslHash"]/*' />
    [NativeTypeName("PVOID")]
    public void* pSslHash;

    /// <include file='HTTP_SERVICE_CONFIG_SSL_PARAM.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_PARAM.AppId"]/*' />
    public Guid AppId;

    /// <include file='HTTP_SERVICE_CONFIG_SSL_PARAM.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_PARAM.pSslCertStoreName"]/*' />
    [NativeTypeName("PWSTR")]
    public char* pSslCertStoreName;

    /// <include file='HTTP_SERVICE_CONFIG_SSL_PARAM.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_PARAM.DefaultCertCheckMode"]/*' />
    [NativeTypeName("DWORD")]
    public uint DefaultCertCheckMode;

    /// <include file='HTTP_SERVICE_CONFIG_SSL_PARAM.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_PARAM.DefaultRevocationFreshnessTime"]/*' />
    [NativeTypeName("DWORD")]
    public uint DefaultRevocationFreshnessTime;

    /// <include file='HTTP_SERVICE_CONFIG_SSL_PARAM.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_PARAM.DefaultRevocationUrlRetrievalTimeout"]/*' />
    [NativeTypeName("DWORD")]
    public uint DefaultRevocationUrlRetrievalTimeout;

    /// <include file='HTTP_SERVICE_CONFIG_SSL_PARAM.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_PARAM.pDefaultSslCtlIdentifier"]/*' />
    [NativeTypeName("PWSTR")]
    public char* pDefaultSslCtlIdentifier;

    /// <include file='HTTP_SERVICE_CONFIG_SSL_PARAM.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_PARAM.pDefaultSslCtlStoreName"]/*' />
    [NativeTypeName("PWSTR")]
    public char* pDefaultSslCtlStoreName;

    /// <include file='HTTP_SERVICE_CONFIG_SSL_PARAM.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_PARAM.DefaultFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint DefaultFlags;
}
