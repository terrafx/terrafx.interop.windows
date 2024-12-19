// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE"]/*' />
public enum HTTP_REQUEST_TIMING_TYPE
{
    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeConnectionStart"]/*' />
    HttpRequestTimingTypeConnectionStart,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeDataStart"]/*' />
    HttpRequestTimingTypeDataStart,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeTlsCertificateLoadStart"]/*' />
    HttpRequestTimingTypeTlsCertificateLoadStart,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeTlsCertificateLoadEnd"]/*' />
    HttpRequestTimingTypeTlsCertificateLoadEnd,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeTlsHandshakeLeg1Start"]/*' />
    HttpRequestTimingTypeTlsHandshakeLeg1Start,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeTlsHandshakeLeg1End"]/*' />
    HttpRequestTimingTypeTlsHandshakeLeg1End,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeTlsHandshakeLeg2Start"]/*' />
    HttpRequestTimingTypeTlsHandshakeLeg2Start,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeTlsHandshakeLeg2End"]/*' />
    HttpRequestTimingTypeTlsHandshakeLeg2End,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeTlsAttributesQueryStart"]/*' />
    HttpRequestTimingTypeTlsAttributesQueryStart,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeTlsAttributesQueryEnd"]/*' />
    HttpRequestTimingTypeTlsAttributesQueryEnd,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeTlsClientCertQueryStart"]/*' />
    HttpRequestTimingTypeTlsClientCertQueryStart,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeTlsClientCertQueryEnd"]/*' />
    HttpRequestTimingTypeTlsClientCertQueryEnd,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeHttp2StreamStart"]/*' />
    HttpRequestTimingTypeHttp2StreamStart,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeHttp2HeaderDecodeStart"]/*' />
    HttpRequestTimingTypeHttp2HeaderDecodeStart,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeHttp2HeaderDecodeEnd"]/*' />
    HttpRequestTimingTypeHttp2HeaderDecodeEnd,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeRequestHeaderParseStart"]/*' />
    HttpRequestTimingTypeRequestHeaderParseStart,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeRequestHeaderParseEnd"]/*' />
    HttpRequestTimingTypeRequestHeaderParseEnd,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeRequestRoutingStart"]/*' />
    HttpRequestTimingTypeRequestRoutingStart,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeRequestRoutingEnd"]/*' />
    HttpRequestTimingTypeRequestRoutingEnd,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeRequestQueuedForInspection"]/*' />
    HttpRequestTimingTypeRequestQueuedForInspection,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeRequestDeliveredForInspection"]/*' />
    HttpRequestTimingTypeRequestDeliveredForInspection,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeRequestReturnedAfterInspection"]/*' />
    HttpRequestTimingTypeRequestReturnedAfterInspection,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeRequestQueuedForDelegation"]/*' />
    HttpRequestTimingTypeRequestQueuedForDelegation,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeRequestDeliveredForDelegation"]/*' />
    HttpRequestTimingTypeRequestDeliveredForDelegation,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeRequestReturnedAfterDelegation"]/*' />
    HttpRequestTimingTypeRequestReturnedAfterDelegation,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeRequestQueuedForIO"]/*' />
    HttpRequestTimingTypeRequestQueuedForIO,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeRequestDeliveredForIO"]/*' />
    HttpRequestTimingTypeRequestDeliveredForIO,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeHttp3StreamStart"]/*' />
    HttpRequestTimingTypeHttp3StreamStart,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeHttp3HeaderDecodeStart"]/*' />
    HttpRequestTimingTypeHttp3HeaderDecodeStart,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeHttp3HeaderDecodeEnd"]/*' />
    HttpRequestTimingTypeHttp3HeaderDecodeEnd,

    /// <include file='HTTP_REQUEST_TIMING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_TYPE.HttpRequestTimingTypeMax"]/*' />
    HttpRequestTimingTypeMax,
}
