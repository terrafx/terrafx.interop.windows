// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_REQUEST_PROPERTY.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY"]/*' />
public enum HTTP_REQUEST_PROPERTY
{
    /// <include file='HTTP_REQUEST_PROPERTY.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY.HttpRequestPropertyIsb"]/*' />
    HttpRequestPropertyIsb,

    /// <include file='HTTP_REQUEST_PROPERTY.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY.HttpRequestPropertyTcpInfoV0"]/*' />
    HttpRequestPropertyTcpInfoV0,

    /// <include file='HTTP_REQUEST_PROPERTY.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY.HttpRequestPropertyQuicStats"]/*' />
    HttpRequestPropertyQuicStats,

    /// <include file='HTTP_REQUEST_PROPERTY.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY.HttpRequestPropertyTcpInfoV1"]/*' />
    HttpRequestPropertyTcpInfoV1,

    /// <include file='HTTP_REQUEST_PROPERTY.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY.HttpRequestPropertySni"]/*' />
    HttpRequestPropertySni,

    /// <include file='HTTP_REQUEST_PROPERTY.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY.HttpRequestPropertyStreamError"]/*' />
    HttpRequestPropertyStreamError,

    /// <include file='HTTP_REQUEST_PROPERTY.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY.HttpRequestPropertyWskApiTimings"]/*' />
    HttpRequestPropertyWskApiTimings,

    /// <include file='HTTP_REQUEST_PROPERTY.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY.HttpRequestPropertyQuicApiTimings"]/*' />
    HttpRequestPropertyQuicApiTimings,

    /// <include file='HTTP_REQUEST_PROPERTY.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY.HttpRequestPropertyQuicStatsV2"]/*' />
    HttpRequestPropertyQuicStatsV2,

    /// <include file='HTTP_REQUEST_PROPERTY.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY.HttpRequestPropertyQuicStreamStats"]/*' />
    HttpRequestPropertyQuicStreamStats,

    /// <include file='HTTP_REQUEST_PROPERTY.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY.HttpRequestPropertyTcpInfoV2"]/*' />
    HttpRequestPropertyTcpInfoV2,

    /// <include file='HTTP_REQUEST_PROPERTY.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY.HttpRequestPropertyTlsClientHello"]/*' />
    HttpRequestPropertyTlsClientHello,
}
