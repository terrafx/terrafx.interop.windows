// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus"]/*' />
public enum WebErrorStatus
{
    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_Unknown"]/*' />
    WebErrorStatus_Unknown = 0,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_CertificateCommonNameIsIncorrect"]/*' />
    WebErrorStatus_CertificateCommonNameIsIncorrect = 1,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_CertificateExpired"]/*' />
    WebErrorStatus_CertificateExpired = 2,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_CertificateContainsErrors"]/*' />
    WebErrorStatus_CertificateContainsErrors = 3,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_CertificateRevoked"]/*' />
    WebErrorStatus_CertificateRevoked = 4,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_CertificateIsInvalid"]/*' />
    WebErrorStatus_CertificateIsInvalid = 5,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_ServerUnreachable"]/*' />
    WebErrorStatus_ServerUnreachable = 6,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_Timeout"]/*' />
    WebErrorStatus_Timeout = 7,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_ErrorHttpInvalidServerResponse"]/*' />
    WebErrorStatus_ErrorHttpInvalidServerResponse = 8,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_ConnectionAborted"]/*' />
    WebErrorStatus_ConnectionAborted = 9,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_ConnectionReset"]/*' />
    WebErrorStatus_ConnectionReset = 10,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_Disconnected"]/*' />
    WebErrorStatus_Disconnected = 11,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_HttpToHttpsOnRedirection"]/*' />
    WebErrorStatus_HttpToHttpsOnRedirection = 12,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_HttpsToHttpOnRedirection"]/*' />
    WebErrorStatus_HttpsToHttpOnRedirection = 13,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_CannotConnect"]/*' />
    WebErrorStatus_CannotConnect = 14,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_HostNameNotResolved"]/*' />
    WebErrorStatus_HostNameNotResolved = 15,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_OperationCanceled"]/*' />
    WebErrorStatus_OperationCanceled = 16,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_RedirectFailed"]/*' />
    WebErrorStatus_RedirectFailed = 17,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_UnexpectedStatusCode"]/*' />
    WebErrorStatus_UnexpectedStatusCode = 18,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_UnexpectedRedirection"]/*' />
    WebErrorStatus_UnexpectedRedirection = 19,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_UnexpectedClientError"]/*' />
    WebErrorStatus_UnexpectedClientError = 20,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_UnexpectedServerError"]/*' />
    WebErrorStatus_UnexpectedServerError = 21,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_InsufficientRangeSupport"]/*' />
    WebErrorStatus_InsufficientRangeSupport = 22,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_MissingContentLengthSupport"]/*' />
    WebErrorStatus_MissingContentLengthSupport = 23,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_MultipleChoices"]/*' />
    WebErrorStatus_MultipleChoices = 300,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_MovedPermanently"]/*' />
    WebErrorStatus_MovedPermanently = 301,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_Found"]/*' />
    WebErrorStatus_Found = 302,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_SeeOther"]/*' />
    WebErrorStatus_SeeOther = 303,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_NotModified"]/*' />
    WebErrorStatus_NotModified = 304,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_UseProxy"]/*' />
    WebErrorStatus_UseProxy = 305,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_TemporaryRedirect"]/*' />
    WebErrorStatus_TemporaryRedirect = 307,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_BadRequest"]/*' />
    WebErrorStatus_BadRequest = 400,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_Unauthorized"]/*' />
    WebErrorStatus_Unauthorized = 401,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_PaymentRequired"]/*' />
    WebErrorStatus_PaymentRequired = 402,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_Forbidden"]/*' />
    WebErrorStatus_Forbidden = 403,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_NotFound"]/*' />
    WebErrorStatus_NotFound = 404,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_MethodNotAllowed"]/*' />
    WebErrorStatus_MethodNotAllowed = 405,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_NotAcceptable"]/*' />
    WebErrorStatus_NotAcceptable = 406,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_ProxyAuthenticationRequired"]/*' />
    WebErrorStatus_ProxyAuthenticationRequired = 407,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_RequestTimeout"]/*' />
    WebErrorStatus_RequestTimeout = 408,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_Conflict"]/*' />
    WebErrorStatus_Conflict = 409,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_Gone"]/*' />
    WebErrorStatus_Gone = 410,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_LengthRequired"]/*' />
    WebErrorStatus_LengthRequired = 411,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_PreconditionFailed"]/*' />
    WebErrorStatus_PreconditionFailed = 412,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_RequestEntityTooLarge"]/*' />
    WebErrorStatus_RequestEntityTooLarge = 413,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_RequestUriTooLong"]/*' />
    WebErrorStatus_RequestUriTooLong = 414,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_UnsupportedMediaType"]/*' />
    WebErrorStatus_UnsupportedMediaType = 415,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_RequestedRangeNotSatisfiable"]/*' />
    WebErrorStatus_RequestedRangeNotSatisfiable = 416,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_ExpectationFailed"]/*' />
    WebErrorStatus_ExpectationFailed = 417,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_InternalServerError"]/*' />
    WebErrorStatus_InternalServerError = 500,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_NotImplemented"]/*' />
    WebErrorStatus_NotImplemented = 501,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_BadGateway"]/*' />
    WebErrorStatus_BadGateway = 502,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_ServiceUnavailable"]/*' />
    WebErrorStatus_ServiceUnavailable = 503,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_GatewayTimeout"]/*' />
    WebErrorStatus_GatewayTimeout = 504,

    /// <include file='WebErrorStatus.xml' path='doc/member[@name="WebErrorStatus.WebErrorStatus_HttpVersionNotSupported"]/*' />
    WebErrorStatus_HttpVersionNotSupported = 505,
}
