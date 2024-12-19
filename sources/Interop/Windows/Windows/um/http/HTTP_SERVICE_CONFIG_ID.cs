// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVICE_CONFIG_ID.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_ID"]/*' />
public enum HTTP_SERVICE_CONFIG_ID
{
    /// <include file='HTTP_SERVICE_CONFIG_ID.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_ID.HttpServiceConfigIPListenList"]/*' />
    HttpServiceConfigIPListenList,

    /// <include file='HTTP_SERVICE_CONFIG_ID.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_ID.HttpServiceConfigSSLCertInfo"]/*' />
    HttpServiceConfigSSLCertInfo,

    /// <include file='HTTP_SERVICE_CONFIG_ID.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_ID.HttpServiceConfigUrlAclInfo"]/*' />
    HttpServiceConfigUrlAclInfo,

    /// <include file='HTTP_SERVICE_CONFIG_ID.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_ID.HttpServiceConfigTimeout"]/*' />
    HttpServiceConfigTimeout,

    /// <include file='HTTP_SERVICE_CONFIG_ID.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_ID.HttpServiceConfigCache"]/*' />
    HttpServiceConfigCache,

    /// <include file='HTTP_SERVICE_CONFIG_ID.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_ID.HttpServiceConfigSslSniCertInfo"]/*' />
    HttpServiceConfigSslSniCertInfo,

    /// <include file='HTTP_SERVICE_CONFIG_ID.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_ID.HttpServiceConfigSslCcsCertInfo"]/*' />
    HttpServiceConfigSslCcsCertInfo,

    /// <include file='HTTP_SERVICE_CONFIG_ID.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_ID.HttpServiceConfigSetting"]/*' />
    HttpServiceConfigSetting,

    /// <include file='HTTP_SERVICE_CONFIG_ID.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_ID.HttpServiceConfigSslCertInfoEx"]/*' />
    HttpServiceConfigSslCertInfoEx,

    /// <include file='HTTP_SERVICE_CONFIG_ID.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_ID.HttpServiceConfigSslSniCertInfoEx"]/*' />
    HttpServiceConfigSslSniCertInfoEx,

    /// <include file='HTTP_SERVICE_CONFIG_ID.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_ID.HttpServiceConfigSslCcsCertInfoEx"]/*' />
    HttpServiceConfigSslCcsCertInfoEx,

    /// <include file='HTTP_SERVICE_CONFIG_ID.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_ID.HttpServiceConfigSslScopedCcsCertInfo"]/*' />
    HttpServiceConfigSslScopedCcsCertInfo,

    /// <include file='HTTP_SERVICE_CONFIG_ID.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_ID.HttpServiceConfigSslScopedCcsCertInfoEx"]/*' />
    HttpServiceConfigSslScopedCcsCertInfoEx,

    /// <include file='HTTP_SERVICE_CONFIG_ID.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_ID.HttpServiceConfigMax"]/*' />
    HttpServiceConfigMax,
}
