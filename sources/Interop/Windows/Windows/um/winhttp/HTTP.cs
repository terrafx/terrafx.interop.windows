// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class HTTP
{
    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_CONTINUE"]/*' />
    [NativeTypeName("#define HTTP_STATUS_CONTINUE 100")]
    public const int HTTP_STATUS_CONTINUE = 100;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_SWITCH_PROTOCOLS"]/*' />
    [NativeTypeName("#define HTTP_STATUS_SWITCH_PROTOCOLS 101")]
    public const int HTTP_STATUS_SWITCH_PROTOCOLS = 101;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_OK"]/*' />
    [NativeTypeName("#define HTTP_STATUS_OK 200")]
    public const int HTTP_STATUS_OK = 200;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_CREATED"]/*' />
    [NativeTypeName("#define HTTP_STATUS_CREATED 201")]
    public const int HTTP_STATUS_CREATED = 201;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_ACCEPTED"]/*' />
    [NativeTypeName("#define HTTP_STATUS_ACCEPTED 202")]
    public const int HTTP_STATUS_ACCEPTED = 202;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_PARTIAL"]/*' />
    [NativeTypeName("#define HTTP_STATUS_PARTIAL 203")]
    public const int HTTP_STATUS_PARTIAL = 203;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_NO_CONTENT"]/*' />
    [NativeTypeName("#define HTTP_STATUS_NO_CONTENT 204")]
    public const int HTTP_STATUS_NO_CONTENT = 204;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_RESET_CONTENT"]/*' />
    [NativeTypeName("#define HTTP_STATUS_RESET_CONTENT 205")]
    public const int HTTP_STATUS_RESET_CONTENT = 205;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_PARTIAL_CONTENT"]/*' />
    [NativeTypeName("#define HTTP_STATUS_PARTIAL_CONTENT 206")]
    public const int HTTP_STATUS_PARTIAL_CONTENT = 206;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_WEBDAV_MULTI_STATUS"]/*' />
    [NativeTypeName("#define HTTP_STATUS_WEBDAV_MULTI_STATUS 207")]
    public const int HTTP_STATUS_WEBDAV_MULTI_STATUS = 207;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_AMBIGUOUS"]/*' />
    [NativeTypeName("#define HTTP_STATUS_AMBIGUOUS 300")]
    public const int HTTP_STATUS_AMBIGUOUS = 300;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_MOVED"]/*' />
    [NativeTypeName("#define HTTP_STATUS_MOVED 301")]
    public const int HTTP_STATUS_MOVED = 301;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_REDIRECT"]/*' />
    [NativeTypeName("#define HTTP_STATUS_REDIRECT 302")]
    public const int HTTP_STATUS_REDIRECT = 302;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_REDIRECT_METHOD"]/*' />
    [NativeTypeName("#define HTTP_STATUS_REDIRECT_METHOD 303")]
    public const int HTTP_STATUS_REDIRECT_METHOD = 303;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_NOT_MODIFIED"]/*' />
    [NativeTypeName("#define HTTP_STATUS_NOT_MODIFIED 304")]
    public const int HTTP_STATUS_NOT_MODIFIED = 304;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_USE_PROXY"]/*' />
    [NativeTypeName("#define HTTP_STATUS_USE_PROXY 305")]
    public const int HTTP_STATUS_USE_PROXY = 305;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_REDIRECT_KEEP_VERB"]/*' />
    [NativeTypeName("#define HTTP_STATUS_REDIRECT_KEEP_VERB 307")]
    public const int HTTP_STATUS_REDIRECT_KEEP_VERB = 307;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_PERMANENT_REDIRECT"]/*' />
    [NativeTypeName("#define HTTP_STATUS_PERMANENT_REDIRECT 308")]
    public const int HTTP_STATUS_PERMANENT_REDIRECT = 308;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_BAD_REQUEST"]/*' />
    [NativeTypeName("#define HTTP_STATUS_BAD_REQUEST 400")]
    public const int HTTP_STATUS_BAD_REQUEST = 400;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_DENIED"]/*' />
    [NativeTypeName("#define HTTP_STATUS_DENIED 401")]
    public const int HTTP_STATUS_DENIED = 401;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_PAYMENT_REQ"]/*' />
    [NativeTypeName("#define HTTP_STATUS_PAYMENT_REQ 402")]
    public const int HTTP_STATUS_PAYMENT_REQ = 402;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_FORBIDDEN"]/*' />
    [NativeTypeName("#define HTTP_STATUS_FORBIDDEN 403")]
    public const int HTTP_STATUS_FORBIDDEN = 403;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_NOT_FOUND"]/*' />
    [NativeTypeName("#define HTTP_STATUS_NOT_FOUND 404")]
    public const int HTTP_STATUS_NOT_FOUND = 404;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_BAD_METHOD"]/*' />
    [NativeTypeName("#define HTTP_STATUS_BAD_METHOD 405")]
    public const int HTTP_STATUS_BAD_METHOD = 405;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_NONE_ACCEPTABLE"]/*' />
    [NativeTypeName("#define HTTP_STATUS_NONE_ACCEPTABLE 406")]
    public const int HTTP_STATUS_NONE_ACCEPTABLE = 406;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_PROXY_AUTH_REQ"]/*' />
    [NativeTypeName("#define HTTP_STATUS_PROXY_AUTH_REQ 407")]
    public const int HTTP_STATUS_PROXY_AUTH_REQ = 407;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_REQUEST_TIMEOUT"]/*' />
    [NativeTypeName("#define HTTP_STATUS_REQUEST_TIMEOUT 408")]
    public const int HTTP_STATUS_REQUEST_TIMEOUT = 408;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_CONFLICT"]/*' />
    [NativeTypeName("#define HTTP_STATUS_CONFLICT 409")]
    public const int HTTP_STATUS_CONFLICT = 409;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_GONE"]/*' />
    [NativeTypeName("#define HTTP_STATUS_GONE 410")]
    public const int HTTP_STATUS_GONE = 410;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_LENGTH_REQUIRED"]/*' />
    [NativeTypeName("#define HTTP_STATUS_LENGTH_REQUIRED 411")]
    public const int HTTP_STATUS_LENGTH_REQUIRED = 411;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_PRECOND_FAILED"]/*' />
    [NativeTypeName("#define HTTP_STATUS_PRECOND_FAILED 412")]
    public const int HTTP_STATUS_PRECOND_FAILED = 412;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_REQUEST_TOO_LARGE"]/*' />
    [NativeTypeName("#define HTTP_STATUS_REQUEST_TOO_LARGE 413")]
    public const int HTTP_STATUS_REQUEST_TOO_LARGE = 413;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_URI_TOO_LONG"]/*' />
    [NativeTypeName("#define HTTP_STATUS_URI_TOO_LONG 414")]
    public const int HTTP_STATUS_URI_TOO_LONG = 414;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_UNSUPPORTED_MEDIA"]/*' />
    [NativeTypeName("#define HTTP_STATUS_UNSUPPORTED_MEDIA 415")]
    public const int HTTP_STATUS_UNSUPPORTED_MEDIA = 415;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_RETRY_WITH"]/*' />
    [NativeTypeName("#define HTTP_STATUS_RETRY_WITH 449")]
    public const int HTTP_STATUS_RETRY_WITH = 449;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_SERVER_ERROR"]/*' />
    [NativeTypeName("#define HTTP_STATUS_SERVER_ERROR 500")]
    public const int HTTP_STATUS_SERVER_ERROR = 500;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define HTTP_STATUS_NOT_SUPPORTED 501")]
    public const int HTTP_STATUS_NOT_SUPPORTED = 501;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_BAD_GATEWAY"]/*' />
    [NativeTypeName("#define HTTP_STATUS_BAD_GATEWAY 502")]
    public const int HTTP_STATUS_BAD_GATEWAY = 502;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_SERVICE_UNAVAIL"]/*' />
    [NativeTypeName("#define HTTP_STATUS_SERVICE_UNAVAIL 503")]
    public const int HTTP_STATUS_SERVICE_UNAVAIL = 503;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_GATEWAY_TIMEOUT"]/*' />
    [NativeTypeName("#define HTTP_STATUS_GATEWAY_TIMEOUT 504")]
    public const int HTTP_STATUS_GATEWAY_TIMEOUT = 504;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_VERSION_NOT_SUP"]/*' />
    [NativeTypeName("#define HTTP_STATUS_VERSION_NOT_SUP 505")]
    public const int HTTP_STATUS_VERSION_NOT_SUP = 505;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_FIRST"]/*' />
    [NativeTypeName("#define HTTP_STATUS_FIRST HTTP_STATUS_CONTINUE")]
    public const int HTTP_STATUS_FIRST = 100;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_STATUS_LAST"]/*' />
    [NativeTypeName("#define HTTP_STATUS_LAST HTTP_STATUS_VERSION_NOT_SUP")]
    public const int HTTP_STATUS_LAST = 505;
}
