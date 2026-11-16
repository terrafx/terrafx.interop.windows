// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class INET
{
    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_INVALID_URL"]/*' />
    [NativeTypeName("#define INET_E_INVALID_URL _HRESULT_TYPEDEF_(0x800C0002L)")]
    public const int INET_E_INVALID_URL = unchecked((int)(0x800C0002));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_NO_SESSION"]/*' />
    [NativeTypeName("#define INET_E_NO_SESSION _HRESULT_TYPEDEF_(0x800C0003L)")]
    public const int INET_E_NO_SESSION = unchecked((int)(0x800C0003));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_CANNOT_CONNECT"]/*' />
    [NativeTypeName("#define INET_E_CANNOT_CONNECT _HRESULT_TYPEDEF_(0x800C0004L)")]
    public const int INET_E_CANNOT_CONNECT = unchecked((int)(0x800C0004));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_RESOURCE_NOT_FOUND"]/*' />
    [NativeTypeName("#define INET_E_RESOURCE_NOT_FOUND _HRESULT_TYPEDEF_(0x800C0005L)")]
    public const int INET_E_RESOURCE_NOT_FOUND = unchecked((int)(0x800C0005));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_OBJECT_NOT_FOUND"]/*' />
    [NativeTypeName("#define INET_E_OBJECT_NOT_FOUND _HRESULT_TYPEDEF_(0x800C0006L)")]
    public const int INET_E_OBJECT_NOT_FOUND = unchecked((int)(0x800C0006));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_DATA_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define INET_E_DATA_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x800C0007L)")]
    public const int INET_E_DATA_NOT_AVAILABLE = unchecked((int)(0x800C0007));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_DOWNLOAD_FAILURE"]/*' />
    [NativeTypeName("#define INET_E_DOWNLOAD_FAILURE _HRESULT_TYPEDEF_(0x800C0008L)")]
    public const int INET_E_DOWNLOAD_FAILURE = unchecked((int)(0x800C0008));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_AUTHENTICATION_REQUIRED"]/*' />
    [NativeTypeName("#define INET_E_AUTHENTICATION_REQUIRED _HRESULT_TYPEDEF_(0x800C0009L)")]
    public const int INET_E_AUTHENTICATION_REQUIRED = unchecked((int)(0x800C0009));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_NO_VALID_MEDIA"]/*' />
    [NativeTypeName("#define INET_E_NO_VALID_MEDIA _HRESULT_TYPEDEF_(0x800C000AL)")]
    public const int INET_E_NO_VALID_MEDIA = unchecked((int)(0x800C000A));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_CONNECTION_TIMEOUT"]/*' />
    [NativeTypeName("#define INET_E_CONNECTION_TIMEOUT _HRESULT_TYPEDEF_(0x800C000BL)")]
    public const int INET_E_CONNECTION_TIMEOUT = unchecked((int)(0x800C000B));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_INVALID_REQUEST"]/*' />
    [NativeTypeName("#define INET_E_INVALID_REQUEST _HRESULT_TYPEDEF_(0x800C000CL)")]
    public const int INET_E_INVALID_REQUEST = unchecked((int)(0x800C000C));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_UNKNOWN_PROTOCOL"]/*' />
    [NativeTypeName("#define INET_E_UNKNOWN_PROTOCOL _HRESULT_TYPEDEF_(0x800C000DL)")]
    public const int INET_E_UNKNOWN_PROTOCOL = unchecked((int)(0x800C000D));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_SECURITY_PROBLEM"]/*' />
    [NativeTypeName("#define INET_E_SECURITY_PROBLEM _HRESULT_TYPEDEF_(0x800C000EL)")]
    public const int INET_E_SECURITY_PROBLEM = unchecked((int)(0x800C000E));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_CANNOT_LOAD_DATA"]/*' />
    [NativeTypeName("#define INET_E_CANNOT_LOAD_DATA _HRESULT_TYPEDEF_(0x800C000FL)")]
    public const int INET_E_CANNOT_LOAD_DATA = unchecked((int)(0x800C000F));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_CANNOT_INSTANTIATE_OBJECT"]/*' />
    [NativeTypeName("#define INET_E_CANNOT_INSTANTIATE_OBJECT _HRESULT_TYPEDEF_(0x800C0010L)")]
    public const int INET_E_CANNOT_INSTANTIATE_OBJECT = unchecked((int)(0x800C0010));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_INVALID_CERTIFICATE"]/*' />
    [NativeTypeName("#define INET_E_INVALID_CERTIFICATE _HRESULT_TYPEDEF_(0x800C0019L)")]
    public const int INET_E_INVALID_CERTIFICATE = unchecked((int)(0x800C0019));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_REDIRECT_FAILED"]/*' />
    [NativeTypeName("#define INET_E_REDIRECT_FAILED _HRESULT_TYPEDEF_(0x800C0014L)")]
    public const int INET_E_REDIRECT_FAILED = unchecked((int)(0x800C0014));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_REDIRECT_TO_DIR"]/*' />
    [NativeTypeName("#define INET_E_REDIRECT_TO_DIR _HRESULT_TYPEDEF_(0x800C0015L)")]
    public const int INET_E_REDIRECT_TO_DIR = unchecked((int)(0x800C0015));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_CANNOT_LOCK_REQUEST"]/*' />
    [NativeTypeName("#define INET_E_CANNOT_LOCK_REQUEST _HRESULT_TYPEDEF_(0x800C0016L)")]
    public const int INET_E_CANNOT_LOCK_REQUEST = unchecked((int)(0x800C0016));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_USE_EXTEND_BINDING"]/*' />
    [NativeTypeName("#define INET_E_USE_EXTEND_BINDING _HRESULT_TYPEDEF_(0x800C0017L)")]
    public const int INET_E_USE_EXTEND_BINDING = unchecked((int)(0x800C0017));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_TERMINATED_BIND"]/*' />
    [NativeTypeName("#define INET_E_TERMINATED_BIND _HRESULT_TYPEDEF_(0x800C0018L)")]
    public const int INET_E_TERMINATED_BIND = unchecked((int)(0x800C0018));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_RESERVED_1"]/*' />
    [NativeTypeName("#define INET_E_RESERVED_1 _HRESULT_TYPEDEF_(0x800C001AL)")]
    public const int INET_E_RESERVED_1 = unchecked((int)(0x800C001A));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_BLOCKED_REDIRECT_XSECURITYID"]/*' />
    [NativeTypeName("#define INET_E_BLOCKED_REDIRECT_XSECURITYID _HRESULT_TYPEDEF_(0x800C001BL)")]
    public const int INET_E_BLOCKED_REDIRECT_XSECURITYID = unchecked((int)(0x800C001B));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_DOMINJECTIONVALIDATION"]/*' />
    [NativeTypeName("#define INET_E_DOMINJECTIONVALIDATION _HRESULT_TYPEDEF_(0x800C001CL)")]
    public const int INET_E_DOMINJECTIONVALIDATION = unchecked((int)(0x800C001C));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_VTAB_SWITCH_FORCE_ENGINE"]/*' />
    [NativeTypeName("#define INET_E_VTAB_SWITCH_FORCE_ENGINE _HRESULT_TYPEDEF_(0x800C001DL)")]
    public const int INET_E_VTAB_SWITCH_FORCE_ENGINE = unchecked((int)(0x800C001D));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_HSTS_CERTIFICATE_ERROR"]/*' />
    [NativeTypeName("#define INET_E_HSTS_CERTIFICATE_ERROR _HRESULT_TYPEDEF_(0x800C001EL)")]
    public const int INET_E_HSTS_CERTIFICATE_ERROR = unchecked((int)(0x800C001E));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_RESERVED_2"]/*' />
    [NativeTypeName("#define INET_E_RESERVED_2 _HRESULT_TYPEDEF_(0x800C001FL)")]
    public const int INET_E_RESERVED_2 = unchecked((int)(0x800C001F));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_RESERVED_3"]/*' />
    [NativeTypeName("#define INET_E_RESERVED_3 _HRESULT_TYPEDEF_(0x800C0020L)")]
    public const int INET_E_RESERVED_3 = unchecked((int)(0x800C0020));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_RESERVED_4"]/*' />
    [NativeTypeName("#define INET_E_RESERVED_4 _HRESULT_TYPEDEF_(0x800C0021L)")]
    public const int INET_E_RESERVED_4 = unchecked((int)(0x800C0021));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_RESERVED_5"]/*' />
    [NativeTypeName("#define INET_E_RESERVED_5 _HRESULT_TYPEDEF_(0x800C0022L)")]
    public const int INET_E_RESERVED_5 = unchecked((int)(0x800C0022));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_ERROR_FIRST"]/*' />
    [NativeTypeName("#define INET_E_ERROR_FIRST _HRESULT_TYPEDEF_(0x800C0002L)")]
    public const int INET_E_ERROR_FIRST = unchecked((int)(0x800C0002));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_CODE_DOWNLOAD_DECLINED"]/*' />
    [NativeTypeName("#define INET_E_CODE_DOWNLOAD_DECLINED _HRESULT_TYPEDEF_(0x800C0100L)")]
    public const int INET_E_CODE_DOWNLOAD_DECLINED = unchecked((int)(0x800C0100));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_RESULT_DISPATCHED"]/*' />
    [NativeTypeName("#define INET_E_RESULT_DISPATCHED _HRESULT_TYPEDEF_(0x800C0200L)")]
    public const int INET_E_RESULT_DISPATCHED = unchecked((int)(0x800C0200));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_CANNOT_REPLACE_SFP_FILE"]/*' />
    [NativeTypeName("#define INET_E_CANNOT_REPLACE_SFP_FILE _HRESULT_TYPEDEF_(0x800C0300L)")]
    public const int INET_E_CANNOT_REPLACE_SFP_FILE = unchecked((int)(0x800C0300));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_CODE_INSTALL_SUPPRESSED"]/*' />
    [NativeTypeName("#define INET_E_CODE_INSTALL_SUPPRESSED _HRESULT_TYPEDEF_(0x800C0400L)")]
    public const int INET_E_CODE_INSTALL_SUPPRESSED = unchecked((int)(0x800C0400));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_CODE_INSTALL_BLOCKED_BY_HASH_POLICY"]/*' />
    [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_BY_HASH_POLICY _HRESULT_TYPEDEF_(0x800C0500L)")]
    public const int INET_E_CODE_INSTALL_BLOCKED_BY_HASH_POLICY = unchecked((int)(0x800C0500));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_DOWNLOAD_BLOCKED_BY_INPRIVATE"]/*' />
    [NativeTypeName("#define INET_E_DOWNLOAD_BLOCKED_BY_INPRIVATE _HRESULT_TYPEDEF_(0x800C0501L)")]
    public const int INET_E_DOWNLOAD_BLOCKED_BY_INPRIVATE = unchecked((int)(0x800C0501));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_CODE_INSTALL_BLOCKED_IMMERSIVE"]/*' />
    [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_IMMERSIVE _HRESULT_TYPEDEF_(0x800C0502L)")]
    public const int INET_E_CODE_INSTALL_BLOCKED_IMMERSIVE = unchecked((int)(0x800C0502));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_FORBIDFRAMING"]/*' />
    [NativeTypeName("#define INET_E_FORBIDFRAMING _HRESULT_TYPEDEF_(0x800C0503L)")]
    public const int INET_E_FORBIDFRAMING = unchecked((int)(0x800C0503));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_CODE_INSTALL_BLOCKED_ARM"]/*' />
    [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_ARM _HRESULT_TYPEDEF_(0x800C0504L)")]
    public const int INET_E_CODE_INSTALL_BLOCKED_ARM = unchecked((int)(0x800C0504));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_BLOCKED_PLUGGABLE_PROTOCOL"]/*' />
    [NativeTypeName("#define INET_E_BLOCKED_PLUGGABLE_PROTOCOL _HRESULT_TYPEDEF_(0x800C0505L)")]
    public const int INET_E_BLOCKED_PLUGGABLE_PROTOCOL = unchecked((int)(0x800C0505));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_BLOCKED_ENHANCEDPROTECTEDMODE"]/*' />
    [NativeTypeName("#define INET_E_BLOCKED_ENHANCEDPROTECTEDMODE _HRESULT_TYPEDEF_(0x800C0506L)")]
    public const int INET_E_BLOCKED_ENHANCEDPROTECTEDMODE = unchecked((int)(0x800C0506));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_CODE_INSTALL_BLOCKED_BITNESS"]/*' />
    [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_BITNESS _HRESULT_TYPEDEF_(0x800C0507L)")]
    public const int INET_E_CODE_INSTALL_BLOCKED_BITNESS = unchecked((int)(0x800C0507));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_DOWNLOAD_BLOCKED_BY_CSP"]/*' />
    [NativeTypeName("#define INET_E_DOWNLOAD_BLOCKED_BY_CSP _HRESULT_TYPEDEF_(0x800C0508L)")]
    public const int INET_E_DOWNLOAD_BLOCKED_BY_CSP = unchecked((int)(0x800C0508));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_ERROR_LAST"]/*' />
    [NativeTypeName("#define INET_E_ERROR_LAST INET_E_DOWNLOAD_BLOCKED_BY_CSP")]
    public const int INET_E_ERROR_LAST = unchecked((int)(0x800C0508));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_USE_DEFAULT_PROTOCOLHANDLER"]/*' />
    [NativeTypeName("#define INET_E_USE_DEFAULT_PROTOCOLHANDLER _HRESULT_TYPEDEF_(0x800C0011L)")]
    public const int INET_E_USE_DEFAULT_PROTOCOLHANDLER = unchecked((int)(0x800C0011));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_USE_DEFAULT_SETTING"]/*' />
    [NativeTypeName("#define INET_E_USE_DEFAULT_SETTING _HRESULT_TYPEDEF_(0x800C0012L)")]
    public const int INET_E_USE_DEFAULT_SETTING = unchecked((int)(0x800C0012));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_DEFAULT_ACTION"]/*' />
    [NativeTypeName("#define INET_E_DEFAULT_ACTION INET_E_USE_DEFAULT_PROTOCOLHANDLER")]
    public const int INET_E_DEFAULT_ACTION = unchecked((int)(0x800C0011));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_QUERYOPTION_UNKNOWN"]/*' />
    [NativeTypeName("#define INET_E_QUERYOPTION_UNKNOWN _HRESULT_TYPEDEF_(0x800C0013L)")]
    public const int INET_E_QUERYOPTION_UNKNOWN = unchecked((int)(0x800C0013));

    /// <include file='INET.xml' path='doc/member[@name="INET.INET_E_REDIRECTING"]/*' />
    [NativeTypeName("#define INET_E_REDIRECTING _HRESULT_TYPEDEF_(0x800C0014L)")]
    public const int INET_E_REDIRECTING = unchecked((int)(0x800C0014));
}
