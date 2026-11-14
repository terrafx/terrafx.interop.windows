// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SPAPI
{
    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_EXPECTED_SECTION_NAME"]/*' />
    [NativeTypeName("#define SPAPI_E_EXPECTED_SECTION_NAME _HRESULT_TYPEDEF_(0x800F0000L)")]
    public const int SPAPI_E_EXPECTED_SECTION_NAME = unchecked((int)(0x800F0000));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_BAD_SECTION_NAME_LINE"]/*' />
    [NativeTypeName("#define SPAPI_E_BAD_SECTION_NAME_LINE _HRESULT_TYPEDEF_(0x800F0001L)")]
    public const int SPAPI_E_BAD_SECTION_NAME_LINE = unchecked((int)(0x800F0001));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_SECTION_NAME_TOO_LONG"]/*' />
    [NativeTypeName("#define SPAPI_E_SECTION_NAME_TOO_LONG _HRESULT_TYPEDEF_(0x800F0002L)")]
    public const int SPAPI_E_SECTION_NAME_TOO_LONG = unchecked((int)(0x800F0002));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_GENERAL_SYNTAX"]/*' />
    [NativeTypeName("#define SPAPI_E_GENERAL_SYNTAX _HRESULT_TYPEDEF_(0x800F0003L)")]
    public const int SPAPI_E_GENERAL_SYNTAX = unchecked((int)(0x800F0003));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_WRONG_INF_STYLE"]/*' />
    [NativeTypeName("#define SPAPI_E_WRONG_INF_STYLE _HRESULT_TYPEDEF_(0x800F0100L)")]
    public const int SPAPI_E_WRONG_INF_STYLE = unchecked((int)(0x800F0100));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_SECTION_NOT_FOUND"]/*' />
    [NativeTypeName("#define SPAPI_E_SECTION_NOT_FOUND _HRESULT_TYPEDEF_(0x800F0101L)")]
    public const int SPAPI_E_SECTION_NOT_FOUND = unchecked((int)(0x800F0101));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_LINE_NOT_FOUND"]/*' />
    [NativeTypeName("#define SPAPI_E_LINE_NOT_FOUND _HRESULT_TYPEDEF_(0x800F0102L)")]
    public const int SPAPI_E_LINE_NOT_FOUND = unchecked((int)(0x800F0102));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_BACKUP"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_BACKUP _HRESULT_TYPEDEF_(0x800F0103L)")]
    public const int SPAPI_E_NO_BACKUP = unchecked((int)(0x800F0103));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_ASSOCIATED_CLASS"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_ASSOCIATED_CLASS _HRESULT_TYPEDEF_(0x800F0200L)")]
    public const int SPAPI_E_NO_ASSOCIATED_CLASS = unchecked((int)(0x800F0200));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_CLASS_MISMATCH"]/*' />
    [NativeTypeName("#define SPAPI_E_CLASS_MISMATCH _HRESULT_TYPEDEF_(0x800F0201L)")]
    public const int SPAPI_E_CLASS_MISMATCH = unchecked((int)(0x800F0201));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DUPLICATE_FOUND"]/*' />
    [NativeTypeName("#define SPAPI_E_DUPLICATE_FOUND _HRESULT_TYPEDEF_(0x800F0202L)")]
    public const int SPAPI_E_DUPLICATE_FOUND = unchecked((int)(0x800F0202));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_DRIVER_SELECTED"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_DRIVER_SELECTED _HRESULT_TYPEDEF_(0x800F0203L)")]
    public const int SPAPI_E_NO_DRIVER_SELECTED = unchecked((int)(0x800F0203));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_KEY_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define SPAPI_E_KEY_DOES_NOT_EXIST _HRESULT_TYPEDEF_(0x800F0204L)")]
    public const int SPAPI_E_KEY_DOES_NOT_EXIST = unchecked((int)(0x800F0204));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_INVALID_DEVINST_NAME"]/*' />
    [NativeTypeName("#define SPAPI_E_INVALID_DEVINST_NAME _HRESULT_TYPEDEF_(0x800F0205L)")]
    public const int SPAPI_E_INVALID_DEVINST_NAME = unchecked((int)(0x800F0205));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_INVALID_CLASS"]/*' />
    [NativeTypeName("#define SPAPI_E_INVALID_CLASS _HRESULT_TYPEDEF_(0x800F0206L)")]
    public const int SPAPI_E_INVALID_CLASS = unchecked((int)(0x800F0206));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DEVINST_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define SPAPI_E_DEVINST_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x800F0207L)")]
    public const int SPAPI_E_DEVINST_ALREADY_EXISTS = unchecked((int)(0x800F0207));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DEVINFO_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define SPAPI_E_DEVINFO_NOT_REGISTERED _HRESULT_TYPEDEF_(0x800F0208L)")]
    public const int SPAPI_E_DEVINFO_NOT_REGISTERED = unchecked((int)(0x800F0208));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_INVALID_REG_PROPERTY"]/*' />
    [NativeTypeName("#define SPAPI_E_INVALID_REG_PROPERTY _HRESULT_TYPEDEF_(0x800F0209L)")]
    public const int SPAPI_E_INVALID_REG_PROPERTY = unchecked((int)(0x800F0209));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_INF"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_INF _HRESULT_TYPEDEF_(0x800F020AL)")]
    public const int SPAPI_E_NO_INF = unchecked((int)(0x800F020A));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_SUCH_DEVINST"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_SUCH_DEVINST _HRESULT_TYPEDEF_(0x800F020BL)")]
    public const int SPAPI_E_NO_SUCH_DEVINST = unchecked((int)(0x800F020B));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_CANT_LOAD_CLASS_ICON"]/*' />
    [NativeTypeName("#define SPAPI_E_CANT_LOAD_CLASS_ICON _HRESULT_TYPEDEF_(0x800F020CL)")]
    public const int SPAPI_E_CANT_LOAD_CLASS_ICON = unchecked((int)(0x800F020C));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_INVALID_CLASS_INSTALLER"]/*' />
    [NativeTypeName("#define SPAPI_E_INVALID_CLASS_INSTALLER _HRESULT_TYPEDEF_(0x800F020DL)")]
    public const int SPAPI_E_INVALID_CLASS_INSTALLER = unchecked((int)(0x800F020D));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DI_DO_DEFAULT"]/*' />
    [NativeTypeName("#define SPAPI_E_DI_DO_DEFAULT _HRESULT_TYPEDEF_(0x800F020EL)")]
    public const int SPAPI_E_DI_DO_DEFAULT = unchecked((int)(0x800F020E));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DI_NOFILECOPY"]/*' />
    [NativeTypeName("#define SPAPI_E_DI_NOFILECOPY _HRESULT_TYPEDEF_(0x800F020FL)")]
    public const int SPAPI_E_DI_NOFILECOPY = unchecked((int)(0x800F020F));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_INVALID_HWPROFILE"]/*' />
    [NativeTypeName("#define SPAPI_E_INVALID_HWPROFILE _HRESULT_TYPEDEF_(0x800F0210L)")]
    public const int SPAPI_E_INVALID_HWPROFILE = unchecked((int)(0x800F0210));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_DEVICE_SELECTED"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_DEVICE_SELECTED _HRESULT_TYPEDEF_(0x800F0211L)")]
    public const int SPAPI_E_NO_DEVICE_SELECTED = unchecked((int)(0x800F0211));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DEVINFO_LIST_LOCKED"]/*' />
    [NativeTypeName("#define SPAPI_E_DEVINFO_LIST_LOCKED _HRESULT_TYPEDEF_(0x800F0212L)")]
    public const int SPAPI_E_DEVINFO_LIST_LOCKED = unchecked((int)(0x800F0212));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DEVINFO_DATA_LOCKED"]/*' />
    [NativeTypeName("#define SPAPI_E_DEVINFO_DATA_LOCKED _HRESULT_TYPEDEF_(0x800F0213L)")]
    public const int SPAPI_E_DEVINFO_DATA_LOCKED = unchecked((int)(0x800F0213));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DI_BAD_PATH"]/*' />
    [NativeTypeName("#define SPAPI_E_DI_BAD_PATH _HRESULT_TYPEDEF_(0x800F0214L)")]
    public const int SPAPI_E_DI_BAD_PATH = unchecked((int)(0x800F0214));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_CLASSINSTALL_PARAMS"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_CLASSINSTALL_PARAMS _HRESULT_TYPEDEF_(0x800F0215L)")]
    public const int SPAPI_E_NO_CLASSINSTALL_PARAMS = unchecked((int)(0x800F0215));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_FILEQUEUE_LOCKED"]/*' />
    [NativeTypeName("#define SPAPI_E_FILEQUEUE_LOCKED _HRESULT_TYPEDEF_(0x800F0216L)")]
    public const int SPAPI_E_FILEQUEUE_LOCKED = unchecked((int)(0x800F0216));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_BAD_SERVICE_INSTALLSECT"]/*' />
    [NativeTypeName("#define SPAPI_E_BAD_SERVICE_INSTALLSECT _HRESULT_TYPEDEF_(0x800F0217L)")]
    public const int SPAPI_E_BAD_SERVICE_INSTALLSECT = unchecked((int)(0x800F0217));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_CLASS_DRIVER_LIST"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_CLASS_DRIVER_LIST _HRESULT_TYPEDEF_(0x800F0218L)")]
    public const int SPAPI_E_NO_CLASS_DRIVER_LIST = unchecked((int)(0x800F0218));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_ASSOCIATED_SERVICE"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_ASSOCIATED_SERVICE _HRESULT_TYPEDEF_(0x800F0219L)")]
    public const int SPAPI_E_NO_ASSOCIATED_SERVICE = unchecked((int)(0x800F0219));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_DEFAULT_DEVICE_INTERFACE"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_DEFAULT_DEVICE_INTERFACE _HRESULT_TYPEDEF_(0x800F021AL)")]
    public const int SPAPI_E_NO_DEFAULT_DEVICE_INTERFACE = unchecked((int)(0x800F021A));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DEVICE_INTERFACE_ACTIVE"]/*' />
    [NativeTypeName("#define SPAPI_E_DEVICE_INTERFACE_ACTIVE _HRESULT_TYPEDEF_(0x800F021BL)")]
    public const int SPAPI_E_DEVICE_INTERFACE_ACTIVE = unchecked((int)(0x800F021B));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DEVICE_INTERFACE_REMOVED"]/*' />
    [NativeTypeName("#define SPAPI_E_DEVICE_INTERFACE_REMOVED _HRESULT_TYPEDEF_(0x800F021CL)")]
    public const int SPAPI_E_DEVICE_INTERFACE_REMOVED = unchecked((int)(0x800F021C));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_BAD_INTERFACE_INSTALLSECT"]/*' />
    [NativeTypeName("#define SPAPI_E_BAD_INTERFACE_INSTALLSECT _HRESULT_TYPEDEF_(0x800F021DL)")]
    public const int SPAPI_E_BAD_INTERFACE_INSTALLSECT = unchecked((int)(0x800F021D));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_SUCH_INTERFACE_CLASS"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_SUCH_INTERFACE_CLASS _HRESULT_TYPEDEF_(0x800F021EL)")]
    public const int SPAPI_E_NO_SUCH_INTERFACE_CLASS = unchecked((int)(0x800F021E));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_INVALID_REFERENCE_STRING"]/*' />
    [NativeTypeName("#define SPAPI_E_INVALID_REFERENCE_STRING _HRESULT_TYPEDEF_(0x800F021FL)")]
    public const int SPAPI_E_INVALID_REFERENCE_STRING = unchecked((int)(0x800F021F));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_INVALID_MACHINENAME"]/*' />
    [NativeTypeName("#define SPAPI_E_INVALID_MACHINENAME _HRESULT_TYPEDEF_(0x800F0220L)")]
    public const int SPAPI_E_INVALID_MACHINENAME = unchecked((int)(0x800F0220));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_REMOTE_COMM_FAILURE"]/*' />
    [NativeTypeName("#define SPAPI_E_REMOTE_COMM_FAILURE _HRESULT_TYPEDEF_(0x800F0221L)")]
    public const int SPAPI_E_REMOTE_COMM_FAILURE = unchecked((int)(0x800F0221));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_MACHINE_UNAVAILABLE"]/*' />
    [NativeTypeName("#define SPAPI_E_MACHINE_UNAVAILABLE _HRESULT_TYPEDEF_(0x800F0222L)")]
    public const int SPAPI_E_MACHINE_UNAVAILABLE = unchecked((int)(0x800F0222));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_CONFIGMGR_SERVICES"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_CONFIGMGR_SERVICES _HRESULT_TYPEDEF_(0x800F0223L)")]
    public const int SPAPI_E_NO_CONFIGMGR_SERVICES = unchecked((int)(0x800F0223));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_INVALID_PROPPAGE_PROVIDER"]/*' />
    [NativeTypeName("#define SPAPI_E_INVALID_PROPPAGE_PROVIDER _HRESULT_TYPEDEF_(0x800F0224L)")]
    public const int SPAPI_E_INVALID_PROPPAGE_PROVIDER = unchecked((int)(0x800F0224));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_SUCH_DEVICE_INTERFACE"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_SUCH_DEVICE_INTERFACE _HRESULT_TYPEDEF_(0x800F0225L)")]
    public const int SPAPI_E_NO_SUCH_DEVICE_INTERFACE = unchecked((int)(0x800F0225));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DI_POSTPROCESSING_REQUIRED"]/*' />
    [NativeTypeName("#define SPAPI_E_DI_POSTPROCESSING_REQUIRED _HRESULT_TYPEDEF_(0x800F0226L)")]
    public const int SPAPI_E_DI_POSTPROCESSING_REQUIRED = unchecked((int)(0x800F0226));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_INVALID_COINSTALLER"]/*' />
    [NativeTypeName("#define SPAPI_E_INVALID_COINSTALLER _HRESULT_TYPEDEF_(0x800F0227L)")]
    public const int SPAPI_E_INVALID_COINSTALLER = unchecked((int)(0x800F0227));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_COMPAT_DRIVERS"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_COMPAT_DRIVERS _HRESULT_TYPEDEF_(0x800F0228L)")]
    public const int SPAPI_E_NO_COMPAT_DRIVERS = unchecked((int)(0x800F0228));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_DEVICE_ICON"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_DEVICE_ICON _HRESULT_TYPEDEF_(0x800F0229L)")]
    public const int SPAPI_E_NO_DEVICE_ICON = unchecked((int)(0x800F0229));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_INVALID_INF_LOGCONFIG"]/*' />
    [NativeTypeName("#define SPAPI_E_INVALID_INF_LOGCONFIG _HRESULT_TYPEDEF_(0x800F022AL)")]
    public const int SPAPI_E_INVALID_INF_LOGCONFIG = unchecked((int)(0x800F022A));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DI_DONT_INSTALL"]/*' />
    [NativeTypeName("#define SPAPI_E_DI_DONT_INSTALL _HRESULT_TYPEDEF_(0x800F022BL)")]
    public const int SPAPI_E_DI_DONT_INSTALL = unchecked((int)(0x800F022B));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_INVALID_FILTER_DRIVER"]/*' />
    [NativeTypeName("#define SPAPI_E_INVALID_FILTER_DRIVER _HRESULT_TYPEDEF_(0x800F022CL)")]
    public const int SPAPI_E_INVALID_FILTER_DRIVER = unchecked((int)(0x800F022C));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NON_WINDOWS_NT_DRIVER"]/*' />
    [NativeTypeName("#define SPAPI_E_NON_WINDOWS_NT_DRIVER _HRESULT_TYPEDEF_(0x800F022DL)")]
    public const int SPAPI_E_NON_WINDOWS_NT_DRIVER = unchecked((int)(0x800F022D));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NON_WINDOWS_DRIVER"]/*' />
    [NativeTypeName("#define SPAPI_E_NON_WINDOWS_DRIVER _HRESULT_TYPEDEF_(0x800F022EL)")]
    public const int SPAPI_E_NON_WINDOWS_DRIVER = unchecked((int)(0x800F022E));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_CATALOG_FOR_OEM_INF"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_CATALOG_FOR_OEM_INF _HRESULT_TYPEDEF_(0x800F022FL)")]
    public const int SPAPI_E_NO_CATALOG_FOR_OEM_INF = unchecked((int)(0x800F022F));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DEVINSTALL_QUEUE_NONNATIVE"]/*' />
    [NativeTypeName("#define SPAPI_E_DEVINSTALL_QUEUE_NONNATIVE _HRESULT_TYPEDEF_(0x800F0230L)")]
    public const int SPAPI_E_DEVINSTALL_QUEUE_NONNATIVE = unchecked((int)(0x800F0230));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NOT_DISABLEABLE"]/*' />
    [NativeTypeName("#define SPAPI_E_NOT_DISABLEABLE _HRESULT_TYPEDEF_(0x800F0231L)")]
    public const int SPAPI_E_NOT_DISABLEABLE = unchecked((int)(0x800F0231));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_CANT_REMOVE_DEVINST"]/*' />
    [NativeTypeName("#define SPAPI_E_CANT_REMOVE_DEVINST _HRESULT_TYPEDEF_(0x800F0232L)")]
    public const int SPAPI_E_CANT_REMOVE_DEVINST = unchecked((int)(0x800F0232));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_INVALID_TARGET"]/*' />
    [NativeTypeName("#define SPAPI_E_INVALID_TARGET _HRESULT_TYPEDEF_(0x800F0233L)")]
    public const int SPAPI_E_INVALID_TARGET = unchecked((int)(0x800F0233));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DRIVER_NONNATIVE"]/*' />
    [NativeTypeName("#define SPAPI_E_DRIVER_NONNATIVE _HRESULT_TYPEDEF_(0x800F0234L)")]
    public const int SPAPI_E_DRIVER_NONNATIVE = unchecked((int)(0x800F0234));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_IN_WOW64"]/*' />
    [NativeTypeName("#define SPAPI_E_IN_WOW64 _HRESULT_TYPEDEF_(0x800F0235L)")]
    public const int SPAPI_E_IN_WOW64 = unchecked((int)(0x800F0235));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_SET_SYSTEM_RESTORE_POINT"]/*' />
    [NativeTypeName("#define SPAPI_E_SET_SYSTEM_RESTORE_POINT _HRESULT_TYPEDEF_(0x800F0236L)")]
    public const int SPAPI_E_SET_SYSTEM_RESTORE_POINT = unchecked((int)(0x800F0236));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_INCORRECTLY_COPIED_INF"]/*' />
    [NativeTypeName("#define SPAPI_E_INCORRECTLY_COPIED_INF _HRESULT_TYPEDEF_(0x800F0237L)")]
    public const int SPAPI_E_INCORRECTLY_COPIED_INF = unchecked((int)(0x800F0237));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_SCE_DISABLED"]/*' />
    [NativeTypeName("#define SPAPI_E_SCE_DISABLED _HRESULT_TYPEDEF_(0x800F0238L)")]
    public const int SPAPI_E_SCE_DISABLED = unchecked((int)(0x800F0238));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_UNKNOWN_EXCEPTION"]/*' />
    [NativeTypeName("#define SPAPI_E_UNKNOWN_EXCEPTION _HRESULT_TYPEDEF_(0x800F0239L)")]
    public const int SPAPI_E_UNKNOWN_EXCEPTION = unchecked((int)(0x800F0239));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_PNP_REGISTRY_ERROR"]/*' />
    [NativeTypeName("#define SPAPI_E_PNP_REGISTRY_ERROR _HRESULT_TYPEDEF_(0x800F023AL)")]
    public const int SPAPI_E_PNP_REGISTRY_ERROR = unchecked((int)(0x800F023A));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_REMOTE_REQUEST_UNSUPPORTED"]/*' />
    [NativeTypeName("#define SPAPI_E_REMOTE_REQUEST_UNSUPPORTED _HRESULT_TYPEDEF_(0x800F023BL)")]
    public const int SPAPI_E_REMOTE_REQUEST_UNSUPPORTED = unchecked((int)(0x800F023B));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NOT_AN_INSTALLED_OEM_INF"]/*' />
    [NativeTypeName("#define SPAPI_E_NOT_AN_INSTALLED_OEM_INF _HRESULT_TYPEDEF_(0x800F023CL)")]
    public const int SPAPI_E_NOT_AN_INSTALLED_OEM_INF = unchecked((int)(0x800F023C));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_INF_IN_USE_BY_DEVICES"]/*' />
    [NativeTypeName("#define SPAPI_E_INF_IN_USE_BY_DEVICES _HRESULT_TYPEDEF_(0x800F023DL)")]
    public const int SPAPI_E_INF_IN_USE_BY_DEVICES = unchecked((int)(0x800F023D));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DI_FUNCTION_OBSOLETE"]/*' />
    [NativeTypeName("#define SPAPI_E_DI_FUNCTION_OBSOLETE _HRESULT_TYPEDEF_(0x800F023EL)")]
    public const int SPAPI_E_DI_FUNCTION_OBSOLETE = unchecked((int)(0x800F023E));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_NO_AUTHENTICODE_CATALOG"]/*' />
    [NativeTypeName("#define SPAPI_E_NO_AUTHENTICODE_CATALOG _HRESULT_TYPEDEF_(0x800F023FL)")]
    public const int SPAPI_E_NO_AUTHENTICODE_CATALOG = unchecked((int)(0x800F023F));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_AUTHENTICODE_DISALLOWED"]/*' />
    [NativeTypeName("#define SPAPI_E_AUTHENTICODE_DISALLOWED _HRESULT_TYPEDEF_(0x800F0240L)")]
    public const int SPAPI_E_AUTHENTICODE_DISALLOWED = unchecked((int)(0x800F0240));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_AUTHENTICODE_TRUSTED_PUBLISHER"]/*' />
    [NativeTypeName("#define SPAPI_E_AUTHENTICODE_TRUSTED_PUBLISHER _HRESULT_TYPEDEF_(0x800F0241L)")]
    public const int SPAPI_E_AUTHENTICODE_TRUSTED_PUBLISHER = unchecked((int)(0x800F0241));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_AUTHENTICODE_TRUST_NOT_ESTABLISHED"]/*' />
    [NativeTypeName("#define SPAPI_E_AUTHENTICODE_TRUST_NOT_ESTABLISHED _HRESULT_TYPEDEF_(0x800F0242L)")]
    public const int SPAPI_E_AUTHENTICODE_TRUST_NOT_ESTABLISHED = unchecked((int)(0x800F0242));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_AUTHENTICODE_PUBLISHER_NOT_TRUSTED"]/*' />
    [NativeTypeName("#define SPAPI_E_AUTHENTICODE_PUBLISHER_NOT_TRUSTED _HRESULT_TYPEDEF_(0x800F0243L)")]
    public const int SPAPI_E_AUTHENTICODE_PUBLISHER_NOT_TRUSTED = unchecked((int)(0x800F0243));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_SIGNATURE_OSATTRIBUTE_MISMATCH"]/*' />
    [NativeTypeName("#define SPAPI_E_SIGNATURE_OSATTRIBUTE_MISMATCH _HRESULT_TYPEDEF_(0x800F0244L)")]
    public const int SPAPI_E_SIGNATURE_OSATTRIBUTE_MISMATCH = unchecked((int)(0x800F0244));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_ONLY_VALIDATE_VIA_AUTHENTICODE"]/*' />
    [NativeTypeName("#define SPAPI_E_ONLY_VALIDATE_VIA_AUTHENTICODE _HRESULT_TYPEDEF_(0x800F0245L)")]
    public const int SPAPI_E_ONLY_VALIDATE_VIA_AUTHENTICODE = unchecked((int)(0x800F0245));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DEVICE_INSTALLER_NOT_READY"]/*' />
    [NativeTypeName("#define SPAPI_E_DEVICE_INSTALLER_NOT_READY _HRESULT_TYPEDEF_(0x800F0246L)")]
    public const int SPAPI_E_DEVICE_INSTALLER_NOT_READY = unchecked((int)(0x800F0246));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DRIVER_STORE_ADD_FAILED"]/*' />
    [NativeTypeName("#define SPAPI_E_DRIVER_STORE_ADD_FAILED _HRESULT_TYPEDEF_(0x800F0247L)")]
    public const int SPAPI_E_DRIVER_STORE_ADD_FAILED = unchecked((int)(0x800F0247));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DEVICE_INSTALL_BLOCKED"]/*' />
    [NativeTypeName("#define SPAPI_E_DEVICE_INSTALL_BLOCKED _HRESULT_TYPEDEF_(0x800F0248L)")]
    public const int SPAPI_E_DEVICE_INSTALL_BLOCKED = unchecked((int)(0x800F0248));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DRIVER_INSTALL_BLOCKED"]/*' />
    [NativeTypeName("#define SPAPI_E_DRIVER_INSTALL_BLOCKED _HRESULT_TYPEDEF_(0x800F0249L)")]
    public const int SPAPI_E_DRIVER_INSTALL_BLOCKED = unchecked((int)(0x800F0249));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_WRONG_INF_TYPE"]/*' />
    [NativeTypeName("#define SPAPI_E_WRONG_INF_TYPE _HRESULT_TYPEDEF_(0x800F024AL)")]
    public const int SPAPI_E_WRONG_INF_TYPE = unchecked((int)(0x800F024A));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_FILE_HASH_NOT_IN_CATALOG"]/*' />
    [NativeTypeName("#define SPAPI_E_FILE_HASH_NOT_IN_CATALOG _HRESULT_TYPEDEF_(0x800F024BL)")]
    public const int SPAPI_E_FILE_HASH_NOT_IN_CATALOG = unchecked((int)(0x800F024B));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_DRIVER_STORE_DELETE_FAILED"]/*' />
    [NativeTypeName("#define SPAPI_E_DRIVER_STORE_DELETE_FAILED _HRESULT_TYPEDEF_(0x800F024CL)")]
    public const int SPAPI_E_DRIVER_STORE_DELETE_FAILED = unchecked((int)(0x800F024C));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_UNRECOVERABLE_STACK_OVERFLOW"]/*' />
    [NativeTypeName("#define SPAPI_E_UNRECOVERABLE_STACK_OVERFLOW _HRESULT_TYPEDEF_(0x800F0300L)")]
    public const int SPAPI_E_UNRECOVERABLE_STACK_OVERFLOW = unchecked((int)(0x800F0300));

    /// <include file='SPAPI.xml' path='doc/member[@name="SPAPI.SPAPI_E_ERROR_NOT_INSTALLED"]/*' />
    [NativeTypeName("#define SPAPI_E_ERROR_NOT_INSTALLED _HRESULT_TYPEDEF_(0x800F1000L)")]
    public const int SPAPI_E_ERROR_NOT_INSTALLED = unchecked((int)(0x800F1000));
}
