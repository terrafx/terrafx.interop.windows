// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class HTTP
{
    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_UNEXPECTED"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_UNEXPECTED _HRESULT_TYPEDEF_(0x80190001L)")]
    public const int HTTP_E_STATUS_UNEXPECTED = unchecked((int)(0x80190001));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_UNEXPECTED_REDIRECTION"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_UNEXPECTED_REDIRECTION _HRESULT_TYPEDEF_(0x80190003L)")]
    public const int HTTP_E_STATUS_UNEXPECTED_REDIRECTION = unchecked((int)(0x80190003));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_UNEXPECTED_CLIENT_ERROR"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_UNEXPECTED_CLIENT_ERROR _HRESULT_TYPEDEF_(0x80190004L)")]
    public const int HTTP_E_STATUS_UNEXPECTED_CLIENT_ERROR = unchecked((int)(0x80190004));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_UNEXPECTED_SERVER_ERROR"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_UNEXPECTED_SERVER_ERROR _HRESULT_TYPEDEF_(0x80190005L)")]
    public const int HTTP_E_STATUS_UNEXPECTED_SERVER_ERROR = unchecked((int)(0x80190005));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_AMBIGUOUS"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_AMBIGUOUS _HRESULT_TYPEDEF_(0x8019012CL)")]
    public const int HTTP_E_STATUS_AMBIGUOUS = unchecked((int)(0x8019012C));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_MOVED"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_MOVED _HRESULT_TYPEDEF_(0x8019012DL)")]
    public const int HTTP_E_STATUS_MOVED = unchecked((int)(0x8019012D));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_REDIRECT"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_REDIRECT _HRESULT_TYPEDEF_(0x8019012EL)")]
    public const int HTTP_E_STATUS_REDIRECT = unchecked((int)(0x8019012E));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_REDIRECT_METHOD"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_REDIRECT_METHOD _HRESULT_TYPEDEF_(0x8019012FL)")]
    public const int HTTP_E_STATUS_REDIRECT_METHOD = unchecked((int)(0x8019012F));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_NOT_MODIFIED"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_NOT_MODIFIED _HRESULT_TYPEDEF_(0x80190130L)")]
    public const int HTTP_E_STATUS_NOT_MODIFIED = unchecked((int)(0x80190130));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_USE_PROXY"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_USE_PROXY _HRESULT_TYPEDEF_(0x80190131L)")]
    public const int HTTP_E_STATUS_USE_PROXY = unchecked((int)(0x80190131));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_REDIRECT_KEEP_VERB"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_REDIRECT_KEEP_VERB _HRESULT_TYPEDEF_(0x80190133L)")]
    public const int HTTP_E_STATUS_REDIRECT_KEEP_VERB = unchecked((int)(0x80190133));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_BAD_REQUEST"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_BAD_REQUEST _HRESULT_TYPEDEF_(0x80190190L)")]
    public const int HTTP_E_STATUS_BAD_REQUEST = unchecked((int)(0x80190190));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_DENIED"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_DENIED _HRESULT_TYPEDEF_(0x80190191L)")]
    public const int HTTP_E_STATUS_DENIED = unchecked((int)(0x80190191));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_PAYMENT_REQ"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_PAYMENT_REQ _HRESULT_TYPEDEF_(0x80190192L)")]
    public const int HTTP_E_STATUS_PAYMENT_REQ = unchecked((int)(0x80190192));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_FORBIDDEN"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_FORBIDDEN _HRESULT_TYPEDEF_(0x80190193L)")]
    public const int HTTP_E_STATUS_FORBIDDEN = unchecked((int)(0x80190193));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_NOT_FOUND"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_NOT_FOUND _HRESULT_TYPEDEF_(0x80190194L)")]
    public const int HTTP_E_STATUS_NOT_FOUND = unchecked((int)(0x80190194));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_BAD_METHOD"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_BAD_METHOD _HRESULT_TYPEDEF_(0x80190195L)")]
    public const int HTTP_E_STATUS_BAD_METHOD = unchecked((int)(0x80190195));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_NONE_ACCEPTABLE"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_NONE_ACCEPTABLE _HRESULT_TYPEDEF_(0x80190196L)")]
    public const int HTTP_E_STATUS_NONE_ACCEPTABLE = unchecked((int)(0x80190196));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_PROXY_AUTH_REQ"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_PROXY_AUTH_REQ _HRESULT_TYPEDEF_(0x80190197L)")]
    public const int HTTP_E_STATUS_PROXY_AUTH_REQ = unchecked((int)(0x80190197));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_REQUEST_TIMEOUT"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_REQUEST_TIMEOUT _HRESULT_TYPEDEF_(0x80190198L)")]
    public const int HTTP_E_STATUS_REQUEST_TIMEOUT = unchecked((int)(0x80190198));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_CONFLICT"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_CONFLICT _HRESULT_TYPEDEF_(0x80190199L)")]
    public const int HTTP_E_STATUS_CONFLICT = unchecked((int)(0x80190199));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_GONE"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_GONE _HRESULT_TYPEDEF_(0x8019019AL)")]
    public const int HTTP_E_STATUS_GONE = unchecked((int)(0x8019019A));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_LENGTH_REQUIRED"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_LENGTH_REQUIRED _HRESULT_TYPEDEF_(0x8019019BL)")]
    public const int HTTP_E_STATUS_LENGTH_REQUIRED = unchecked((int)(0x8019019B));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_PRECOND_FAILED"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_PRECOND_FAILED _HRESULT_TYPEDEF_(0x8019019CL)")]
    public const int HTTP_E_STATUS_PRECOND_FAILED = unchecked((int)(0x8019019C));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_REQUEST_TOO_LARGE"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_REQUEST_TOO_LARGE _HRESULT_TYPEDEF_(0x8019019DL)")]
    public const int HTTP_E_STATUS_REQUEST_TOO_LARGE = unchecked((int)(0x8019019D));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_URI_TOO_LONG"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_URI_TOO_LONG _HRESULT_TYPEDEF_(0x8019019EL)")]
    public const int HTTP_E_STATUS_URI_TOO_LONG = unchecked((int)(0x8019019E));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_UNSUPPORTED_MEDIA"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_UNSUPPORTED_MEDIA _HRESULT_TYPEDEF_(0x8019019FL)")]
    public const int HTTP_E_STATUS_UNSUPPORTED_MEDIA = unchecked((int)(0x8019019F));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_RANGE_NOT_SATISFIABLE"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_RANGE_NOT_SATISFIABLE _HRESULT_TYPEDEF_(0x801901A0L)")]
    public const int HTTP_E_STATUS_RANGE_NOT_SATISFIABLE = unchecked((int)(0x801901A0));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_EXPECTATION_FAILED"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_EXPECTATION_FAILED _HRESULT_TYPEDEF_(0x801901A1L)")]
    public const int HTTP_E_STATUS_EXPECTATION_FAILED = unchecked((int)(0x801901A1));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_SERVER_ERROR"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_SERVER_ERROR _HRESULT_TYPEDEF_(0x801901F4L)")]
    public const int HTTP_E_STATUS_SERVER_ERROR = unchecked((int)(0x801901F4));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x801901F5L)")]
    public const int HTTP_E_STATUS_NOT_SUPPORTED = unchecked((int)(0x801901F5));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_BAD_GATEWAY"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_BAD_GATEWAY _HRESULT_TYPEDEF_(0x801901F6L)")]
    public const int HTTP_E_STATUS_BAD_GATEWAY = unchecked((int)(0x801901F6));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_SERVICE_UNAVAIL"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_SERVICE_UNAVAIL _HRESULT_TYPEDEF_(0x801901F7L)")]
    public const int HTTP_E_STATUS_SERVICE_UNAVAIL = unchecked((int)(0x801901F7));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_GATEWAY_TIMEOUT"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_GATEWAY_TIMEOUT _HRESULT_TYPEDEF_(0x801901F8L)")]
    public const int HTTP_E_STATUS_GATEWAY_TIMEOUT = unchecked((int)(0x801901F8));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_E_STATUS_VERSION_NOT_SUP"]/*' />
    [NativeTypeName("#define HTTP_E_STATUS_VERSION_NOT_SUP _HRESULT_TYPEDEF_(0x801901F9L)")]
    public const int HTTP_E_STATUS_VERSION_NOT_SUP = unchecked((int)(0x801901F9));
}
