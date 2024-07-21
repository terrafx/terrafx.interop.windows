// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode"]/*' />
public enum HttpStatusCode
{
    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_None"]/*' />
    HttpStatusCode_None = 0,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_Continue"]/*' />
    HttpStatusCode_Continue = 100,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_SwitchingProtocols"]/*' />
    HttpStatusCode_SwitchingProtocols = 101,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_Processing"]/*' />
    HttpStatusCode_Processing = 102,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_Ok"]/*' />
    HttpStatusCode_Ok = 200,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_Created"]/*' />
    HttpStatusCode_Created = 201,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_Accepted"]/*' />
    HttpStatusCode_Accepted = 202,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_NonAuthoritativeInformation"]/*' />
    HttpStatusCode_NonAuthoritativeInformation = 203,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_NoContent"]/*' />
    HttpStatusCode_NoContent = 204,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_ResetContent"]/*' />
    HttpStatusCode_ResetContent = 205,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_PartialContent"]/*' />
    HttpStatusCode_PartialContent = 206,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_MultiStatus"]/*' />
    HttpStatusCode_MultiStatus = 207,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_AlreadyReported"]/*' />
    HttpStatusCode_AlreadyReported = 208,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_IMUsed"]/*' />
    HttpStatusCode_IMUsed = 226,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_MultipleChoices"]/*' />
    HttpStatusCode_MultipleChoices = 300,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_MovedPermanently"]/*' />
    HttpStatusCode_MovedPermanently = 301,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_Found"]/*' />
    HttpStatusCode_Found = 302,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_SeeOther"]/*' />
    HttpStatusCode_SeeOther = 303,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_NotModified"]/*' />
    HttpStatusCode_NotModified = 304,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_UseProxy"]/*' />
    HttpStatusCode_UseProxy = 305,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_TemporaryRedirect"]/*' />
    HttpStatusCode_TemporaryRedirect = 307,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_PermanentRedirect"]/*' />
    HttpStatusCode_PermanentRedirect = 308,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_BadRequest"]/*' />
    HttpStatusCode_BadRequest = 400,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_Unauthorized"]/*' />
    HttpStatusCode_Unauthorized = 401,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_PaymentRequired"]/*' />
    HttpStatusCode_PaymentRequired = 402,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_Forbidden"]/*' />
    HttpStatusCode_Forbidden = 403,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_NotFound"]/*' />
    HttpStatusCode_NotFound = 404,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_MethodNotAllowed"]/*' />
    HttpStatusCode_MethodNotAllowed = 405,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_NotAcceptable"]/*' />
    HttpStatusCode_NotAcceptable = 406,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_ProxyAuthenticationRequired"]/*' />
    HttpStatusCode_ProxyAuthenticationRequired = 407,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_RequestTimeout"]/*' />
    HttpStatusCode_RequestTimeout = 408,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_Conflict"]/*' />
    HttpStatusCode_Conflict = 409,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_Gone"]/*' />
    HttpStatusCode_Gone = 410,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_LengthRequired"]/*' />
    HttpStatusCode_LengthRequired = 411,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_PreconditionFailed"]/*' />
    HttpStatusCode_PreconditionFailed = 412,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_RequestEntityTooLarge"]/*' />
    HttpStatusCode_RequestEntityTooLarge = 413,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_RequestUriTooLong"]/*' />
    HttpStatusCode_RequestUriTooLong = 414,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_UnsupportedMediaType"]/*' />
    HttpStatusCode_UnsupportedMediaType = 415,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_RequestedRangeNotSatisfiable"]/*' />
    HttpStatusCode_RequestedRangeNotSatisfiable = 416,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_ExpectationFailed"]/*' />
    HttpStatusCode_ExpectationFailed = 417,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_UnprocessableEntity"]/*' />
    HttpStatusCode_UnprocessableEntity = 422,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_Locked"]/*' />
    HttpStatusCode_Locked = 423,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_FailedDependency"]/*' />
    HttpStatusCode_FailedDependency = 424,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_UpgradeRequired"]/*' />
    HttpStatusCode_UpgradeRequired = 426,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_PreconditionRequired"]/*' />
    HttpStatusCode_PreconditionRequired = 428,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_TooManyRequests"]/*' />
    HttpStatusCode_TooManyRequests = 429,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_RequestHeaderFieldsTooLarge"]/*' />
    HttpStatusCode_RequestHeaderFieldsTooLarge = 431,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_InternalServerError"]/*' />
    HttpStatusCode_InternalServerError = 500,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_NotImplemented"]/*' />
    HttpStatusCode_NotImplemented = 501,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_BadGateway"]/*' />
    HttpStatusCode_BadGateway = 502,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_ServiceUnavailable"]/*' />
    HttpStatusCode_ServiceUnavailable = 503,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_GatewayTimeout"]/*' />
    HttpStatusCode_GatewayTimeout = 504,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_HttpVersionNotSupported"]/*' />
    HttpStatusCode_HttpVersionNotSupported = 505,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_VariantAlsoNegotiates"]/*' />
    HttpStatusCode_VariantAlsoNegotiates = 506,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_InsufficientStorage"]/*' />
    HttpStatusCode_InsufficientStorage = 507,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_LoopDetected"]/*' />
    HttpStatusCode_LoopDetected = 508,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_NotExtended"]/*' />
    HttpStatusCode_NotExtended = 510,

    /// <include file='HttpStatusCode.xml' path='doc/member[@name="HttpStatusCode.HttpStatusCode_NetworkAuthenticationRequired"]/*' />
    HttpStatusCode_NetworkAuthenticationRequired = 511,
}
