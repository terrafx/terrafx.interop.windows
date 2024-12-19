// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID"]/*' />
public enum HTTP_HEADER_ID
{
    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderCacheControl"]/*' />
    HttpHeaderCacheControl = 0,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderConnection"]/*' />
    HttpHeaderConnection = 1,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderDate"]/*' />
    HttpHeaderDate = 2,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderKeepAlive"]/*' />
    HttpHeaderKeepAlive = 3,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderPragma"]/*' />
    HttpHeaderPragma = 4,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderTrailer"]/*' />
    HttpHeaderTrailer = 5,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderTransferEncoding"]/*' />
    HttpHeaderTransferEncoding = 6,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderUpgrade"]/*' />
    HttpHeaderUpgrade = 7,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderVia"]/*' />
    HttpHeaderVia = 8,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderWarning"]/*' />
    HttpHeaderWarning = 9,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderAllow"]/*' />
    HttpHeaderAllow = 10,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderContentLength"]/*' />
    HttpHeaderContentLength = 11,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderContentType"]/*' />
    HttpHeaderContentType = 12,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderContentEncoding"]/*' />
    HttpHeaderContentEncoding = 13,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderContentLanguage"]/*' />
    HttpHeaderContentLanguage = 14,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderContentLocation"]/*' />
    HttpHeaderContentLocation = 15,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderContentMd5"]/*' />
    HttpHeaderContentMd5 = 16,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderContentRange"]/*' />
    HttpHeaderContentRange = 17,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderExpires"]/*' />
    HttpHeaderExpires = 18,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderLastModified"]/*' />
    HttpHeaderLastModified = 19,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderAccept"]/*' />
    HttpHeaderAccept = 20,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderAcceptCharset"]/*' />
    HttpHeaderAcceptCharset = 21,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderAcceptEncoding"]/*' />
    HttpHeaderAcceptEncoding = 22,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderAcceptLanguage"]/*' />
    HttpHeaderAcceptLanguage = 23,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderAuthorization"]/*' />
    HttpHeaderAuthorization = 24,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderCookie"]/*' />
    HttpHeaderCookie = 25,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderExpect"]/*' />
    HttpHeaderExpect = 26,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderFrom"]/*' />
    HttpHeaderFrom = 27,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderHost"]/*' />
    HttpHeaderHost = 28,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderIfMatch"]/*' />
    HttpHeaderIfMatch = 29,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderIfModifiedSince"]/*' />
    HttpHeaderIfModifiedSince = 30,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderIfNoneMatch"]/*' />
    HttpHeaderIfNoneMatch = 31,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderIfRange"]/*' />
    HttpHeaderIfRange = 32,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderIfUnmodifiedSince"]/*' />
    HttpHeaderIfUnmodifiedSince = 33,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderMaxForwards"]/*' />
    HttpHeaderMaxForwards = 34,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderProxyAuthorization"]/*' />
    HttpHeaderProxyAuthorization = 35,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderReferer"]/*' />
    HttpHeaderReferer = 36,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderRange"]/*' />
    HttpHeaderRange = 37,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderTe"]/*' />
    HttpHeaderTe = 38,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderTranslate"]/*' />
    HttpHeaderTranslate = 39,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderUserAgent"]/*' />
    HttpHeaderUserAgent = 40,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderRequestMaximum"]/*' />
    HttpHeaderRequestMaximum = 41,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderAcceptRanges"]/*' />
    HttpHeaderAcceptRanges = 20,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderAge"]/*' />
    HttpHeaderAge = 21,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderEtag"]/*' />
    HttpHeaderEtag = 22,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderLocation"]/*' />
    HttpHeaderLocation = 23,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderProxyAuthenticate"]/*' />
    HttpHeaderProxyAuthenticate = 24,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderRetryAfter"]/*' />
    HttpHeaderRetryAfter = 25,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderServer"]/*' />
    HttpHeaderServer = 26,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderSetCookie"]/*' />
    HttpHeaderSetCookie = 27,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderVary"]/*' />
    HttpHeaderVary = 28,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderWwwAuthenticate"]/*' />
    HttpHeaderWwwAuthenticate = 29,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderResponseMaximum"]/*' />
    HttpHeaderResponseMaximum = 30,

    /// <include file='HTTP_HEADER_ID.xml' path='doc/member[@name="HTTP_HEADER_ID.HttpHeaderMaximum"]/*' />
    HttpHeaderMaximum = 41,
}
