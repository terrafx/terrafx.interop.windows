// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_REQUEST_SIZING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_SIZING_TYPE"]/*' />
public enum HTTP_REQUEST_SIZING_TYPE
{
    /// <include file='HTTP_REQUEST_SIZING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_SIZING_TYPE.HttpRequestSizingTypeTlsHandshakeLeg1ClientData"]/*' />
    HttpRequestSizingTypeTlsHandshakeLeg1ClientData,

    /// <include file='HTTP_REQUEST_SIZING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_SIZING_TYPE.HttpRequestSizingTypeTlsHandshakeLeg1ServerData"]/*' />
    HttpRequestSizingTypeTlsHandshakeLeg1ServerData,

    /// <include file='HTTP_REQUEST_SIZING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_SIZING_TYPE.HttpRequestSizingTypeTlsHandshakeLeg2ClientData"]/*' />
    HttpRequestSizingTypeTlsHandshakeLeg2ClientData,

    /// <include file='HTTP_REQUEST_SIZING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_SIZING_TYPE.HttpRequestSizingTypeTlsHandshakeLeg2ServerData"]/*' />
    HttpRequestSizingTypeTlsHandshakeLeg2ServerData,

    /// <include file='HTTP_REQUEST_SIZING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_SIZING_TYPE.HttpRequestSizingTypeHeaders"]/*' />
    HttpRequestSizingTypeHeaders,

    /// <include file='HTTP_REQUEST_SIZING_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_SIZING_TYPE.HttpRequestSizingTypeMax"]/*' />
    HttpRequestSizingTypeMax,
}
