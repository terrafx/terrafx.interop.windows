// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WS
{
    /// <include file='WS.xml' path='doc/member[@name="WS.WS_S_ASYNC"]/*' />
    [NativeTypeName("#define WS_S_ASYNC _HRESULT_TYPEDEF_(0x003D0000L)")]
    public const int WS_S_ASYNC = ((int)(0x003D0000));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_S_END"]/*' />
    [NativeTypeName("#define WS_S_END _HRESULT_TYPEDEF_(0x003D0001L)")]
    public const int WS_S_END = ((int)(0x003D0001));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_INVALID_FORMAT"]/*' />
    [NativeTypeName("#define WS_E_INVALID_FORMAT _HRESULT_TYPEDEF_(0x803D0000L)")]
    public const int WS_E_INVALID_FORMAT = unchecked((int)(0x803D0000));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_OBJECT_FAULTED"]/*' />
    [NativeTypeName("#define WS_E_OBJECT_FAULTED _HRESULT_TYPEDEF_(0x803D0001L)")]
    public const int WS_E_OBJECT_FAULTED = unchecked((int)(0x803D0001));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_NUMERIC_OVERFLOW"]/*' />
    [NativeTypeName("#define WS_E_NUMERIC_OVERFLOW _HRESULT_TYPEDEF_(0x803D0002L)")]
    public const int WS_E_NUMERIC_OVERFLOW = unchecked((int)(0x803D0002));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_INVALID_OPERATION"]/*' />
    [NativeTypeName("#define WS_E_INVALID_OPERATION _HRESULT_TYPEDEF_(0x803D0003L)")]
    public const int WS_E_INVALID_OPERATION = unchecked((int)(0x803D0003));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_OPERATION_ABORTED"]/*' />
    [NativeTypeName("#define WS_E_OPERATION_ABORTED _HRESULT_TYPEDEF_(0x803D0004L)")]
    public const int WS_E_OPERATION_ABORTED = unchecked((int)(0x803D0004));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_ENDPOINT_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define WS_E_ENDPOINT_ACCESS_DENIED _HRESULT_TYPEDEF_(0x803D0005L)")]
    public const int WS_E_ENDPOINT_ACCESS_DENIED = unchecked((int)(0x803D0005));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_OPERATION_TIMED_OUT"]/*' />
    [NativeTypeName("#define WS_E_OPERATION_TIMED_OUT _HRESULT_TYPEDEF_(0x803D0006L)")]
    public const int WS_E_OPERATION_TIMED_OUT = unchecked((int)(0x803D0006));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_OPERATION_ABANDONED"]/*' />
    [NativeTypeName("#define WS_E_OPERATION_ABANDONED _HRESULT_TYPEDEF_(0x803D0007L)")]
    public const int WS_E_OPERATION_ABANDONED = unchecked((int)(0x803D0007));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define WS_E_QUOTA_EXCEEDED _HRESULT_TYPEDEF_(0x803D0008L)")]
    public const int WS_E_QUOTA_EXCEEDED = unchecked((int)(0x803D0008));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_NO_TRANSLATION_AVAILABLE"]/*' />
    [NativeTypeName("#define WS_E_NO_TRANSLATION_AVAILABLE _HRESULT_TYPEDEF_(0x803D0009L)")]
    public const int WS_E_NO_TRANSLATION_AVAILABLE = unchecked((int)(0x803D0009));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_SECURITY_VERIFICATION_FAILURE"]/*' />
    [NativeTypeName("#define WS_E_SECURITY_VERIFICATION_FAILURE _HRESULT_TYPEDEF_(0x803D000AL)")]
    public const int WS_E_SECURITY_VERIFICATION_FAILURE = unchecked((int)(0x803D000A));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_ADDRESS_IN_USE"]/*' />
    [NativeTypeName("#define WS_E_ADDRESS_IN_USE _HRESULT_TYPEDEF_(0x803D000BL)")]
    public const int WS_E_ADDRESS_IN_USE = unchecked((int)(0x803D000B));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_ADDRESS_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define WS_E_ADDRESS_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x803D000CL)")]
    public const int WS_E_ADDRESS_NOT_AVAILABLE = unchecked((int)(0x803D000C));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_ENDPOINT_NOT_FOUND"]/*' />
    [NativeTypeName("#define WS_E_ENDPOINT_NOT_FOUND _HRESULT_TYPEDEF_(0x803D000DL)")]
    public const int WS_E_ENDPOINT_NOT_FOUND = unchecked((int)(0x803D000D));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_ENDPOINT_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define WS_E_ENDPOINT_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x803D000EL)")]
    public const int WS_E_ENDPOINT_NOT_AVAILABLE = unchecked((int)(0x803D000E));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_ENDPOINT_FAILURE"]/*' />
    [NativeTypeName("#define WS_E_ENDPOINT_FAILURE _HRESULT_TYPEDEF_(0x803D000FL)")]
    public const int WS_E_ENDPOINT_FAILURE = unchecked((int)(0x803D000F));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_ENDPOINT_UNREACHABLE"]/*' />
    [NativeTypeName("#define WS_E_ENDPOINT_UNREACHABLE _HRESULT_TYPEDEF_(0x803D0010L)")]
    public const int WS_E_ENDPOINT_UNREACHABLE = unchecked((int)(0x803D0010));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_ENDPOINT_ACTION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define WS_E_ENDPOINT_ACTION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803D0011L)")]
    public const int WS_E_ENDPOINT_ACTION_NOT_SUPPORTED = unchecked((int)(0x803D0011));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_ENDPOINT_TOO_BUSY"]/*' />
    [NativeTypeName("#define WS_E_ENDPOINT_TOO_BUSY _HRESULT_TYPEDEF_(0x803D0012L)")]
    public const int WS_E_ENDPOINT_TOO_BUSY = unchecked((int)(0x803D0012));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_ENDPOINT_FAULT_RECEIVED"]/*' />
    [NativeTypeName("#define WS_E_ENDPOINT_FAULT_RECEIVED _HRESULT_TYPEDEF_(0x803D0013L)")]
    public const int WS_E_ENDPOINT_FAULT_RECEIVED = unchecked((int)(0x803D0013));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_ENDPOINT_DISCONNECTED"]/*' />
    [NativeTypeName("#define WS_E_ENDPOINT_DISCONNECTED _HRESULT_TYPEDEF_(0x803D0014L)")]
    public const int WS_E_ENDPOINT_DISCONNECTED = unchecked((int)(0x803D0014));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_PROXY_FAILURE"]/*' />
    [NativeTypeName("#define WS_E_PROXY_FAILURE _HRESULT_TYPEDEF_(0x803D0015L)")]
    public const int WS_E_PROXY_FAILURE = unchecked((int)(0x803D0015));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_PROXY_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define WS_E_PROXY_ACCESS_DENIED _HRESULT_TYPEDEF_(0x803D0016L)")]
    public const int WS_E_PROXY_ACCESS_DENIED = unchecked((int)(0x803D0016));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define WS_E_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803D0017L)")]
    public const int WS_E_NOT_SUPPORTED = unchecked((int)(0x803D0017));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_PROXY_REQUIRES_BASIC_AUTH"]/*' />
    [NativeTypeName("#define WS_E_PROXY_REQUIRES_BASIC_AUTH _HRESULT_TYPEDEF_(0x803D0018L)")]
    public const int WS_E_PROXY_REQUIRES_BASIC_AUTH = unchecked((int)(0x803D0018));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_PROXY_REQUIRES_DIGEST_AUTH"]/*' />
    [NativeTypeName("#define WS_E_PROXY_REQUIRES_DIGEST_AUTH _HRESULT_TYPEDEF_(0x803D0019L)")]
    public const int WS_E_PROXY_REQUIRES_DIGEST_AUTH = unchecked((int)(0x803D0019));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_PROXY_REQUIRES_NTLM_AUTH"]/*' />
    [NativeTypeName("#define WS_E_PROXY_REQUIRES_NTLM_AUTH _HRESULT_TYPEDEF_(0x803D001AL)")]
    public const int WS_E_PROXY_REQUIRES_NTLM_AUTH = unchecked((int)(0x803D001A));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_PROXY_REQUIRES_NEGOTIATE_AUTH"]/*' />
    [NativeTypeName("#define WS_E_PROXY_REQUIRES_NEGOTIATE_AUTH _HRESULT_TYPEDEF_(0x803D001BL)")]
    public const int WS_E_PROXY_REQUIRES_NEGOTIATE_AUTH = unchecked((int)(0x803D001B));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_SERVER_REQUIRES_BASIC_AUTH"]/*' />
    [NativeTypeName("#define WS_E_SERVER_REQUIRES_BASIC_AUTH _HRESULT_TYPEDEF_(0x803D001CL)")]
    public const int WS_E_SERVER_REQUIRES_BASIC_AUTH = unchecked((int)(0x803D001C));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_SERVER_REQUIRES_DIGEST_AUTH"]/*' />
    [NativeTypeName("#define WS_E_SERVER_REQUIRES_DIGEST_AUTH _HRESULT_TYPEDEF_(0x803D001DL)")]
    public const int WS_E_SERVER_REQUIRES_DIGEST_AUTH = unchecked((int)(0x803D001D));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_SERVER_REQUIRES_NTLM_AUTH"]/*' />
    [NativeTypeName("#define WS_E_SERVER_REQUIRES_NTLM_AUTH _HRESULT_TYPEDEF_(0x803D001EL)")]
    public const int WS_E_SERVER_REQUIRES_NTLM_AUTH = unchecked((int)(0x803D001E));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_SERVER_REQUIRES_NEGOTIATE_AUTH"]/*' />
    [NativeTypeName("#define WS_E_SERVER_REQUIRES_NEGOTIATE_AUTH _HRESULT_TYPEDEF_(0x803D001FL)")]
    public const int WS_E_SERVER_REQUIRES_NEGOTIATE_AUTH = unchecked((int)(0x803D001F));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_INVALID_ENDPOINT_URL"]/*' />
    [NativeTypeName("#define WS_E_INVALID_ENDPOINT_URL _HRESULT_TYPEDEF_(0x803D0020L)")]
    public const int WS_E_INVALID_ENDPOINT_URL = unchecked((int)(0x803D0020));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_OTHER"]/*' />
    [NativeTypeName("#define WS_E_OTHER _HRESULT_TYPEDEF_(0x803D0021L)")]
    public const int WS_E_OTHER = unchecked((int)(0x803D0021));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_SECURITY_TOKEN_EXPIRED"]/*' />
    [NativeTypeName("#define WS_E_SECURITY_TOKEN_EXPIRED _HRESULT_TYPEDEF_(0x803D0022L)")]
    public const int WS_E_SECURITY_TOKEN_EXPIRED = unchecked((int)(0x803D0022));

    /// <include file='WS.xml' path='doc/member[@name="WS.WS_E_SECURITY_SYSTEM_FAILURE"]/*' />
    [NativeTypeName("#define WS_E_SECURITY_SYSTEM_FAILURE _HRESULT_TYPEDEF_(0x803D0023L)")]
    public const int WS_E_SECURITY_SYSTEM_FAILURE = unchecked((int)(0x803D0023));
}
