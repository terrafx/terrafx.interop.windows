// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ERROR
{
    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EXPECTED_SECTION_NAME"]/*' />
    [NativeTypeName("#define ERROR_EXPECTED_SECTION_NAME (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0)")]
    public const uint ERROR_EXPECTED_SECTION_NAME = (0x20000000 | 0xC0000000 | 0);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_SECTION_NAME_LINE"]/*' />
    [NativeTypeName("#define ERROR_BAD_SECTION_NAME_LINE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|1)")]
    public const uint ERROR_BAD_SECTION_NAME_LINE = (0x20000000 | 0xC0000000 | 1);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECTION_NAME_TOO_LONG"]/*' />
    [NativeTypeName("#define ERROR_SECTION_NAME_TOO_LONG (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|2)")]
    public const uint ERROR_SECTION_NAME_TOO_LONG = (0x20000000 | 0xC0000000 | 2);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GENERAL_SYNTAX"]/*' />
    [NativeTypeName("#define ERROR_GENERAL_SYNTAX (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|3)")]
    public const uint ERROR_GENERAL_SYNTAX = (0x20000000 | 0xC0000000 | 3);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WRONG_INF_STYLE"]/*' />
    [NativeTypeName("#define ERROR_WRONG_INF_STYLE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x100)")]
    public const uint ERROR_WRONG_INF_STYLE = (0x20000000 | 0xC0000000 | 0x100);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECTION_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_SECTION_NOT_FOUND (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x101)")]
    public const uint ERROR_SECTION_NOT_FOUND = (0x20000000 | 0xC0000000 | 0x101);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LINE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_LINE_NOT_FOUND (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x102)")]
    public const uint ERROR_LINE_NOT_FOUND = (0x20000000 | 0xC0000000 | 0x102);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_BACKUP"]/*' />
    [NativeTypeName("#define ERROR_NO_BACKUP (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x103)")]
    public const uint ERROR_NO_BACKUP = (0x20000000 | 0xC0000000 | 0x103);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_ASSOCIATED_CLASS"]/*' />
    [NativeTypeName("#define ERROR_NO_ASSOCIATED_CLASS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x200)")]
    public const uint ERROR_NO_ASSOCIATED_CLASS = (0x20000000 | 0xC0000000 | 0x200);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLASS_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_CLASS_MISMATCH (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x201)")]
    public const uint ERROR_CLASS_MISMATCH = (0x20000000 | 0xC0000000 | 0x201);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DUPLICATE_FOUND"]/*' />
    [NativeTypeName("#define ERROR_DUPLICATE_FOUND (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x202)")]
    public const uint ERROR_DUPLICATE_FOUND = (0x20000000 | 0xC0000000 | 0x202);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_DRIVER_SELECTED"]/*' />
    [NativeTypeName("#define ERROR_NO_DRIVER_SELECTED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x203)")]
    public const uint ERROR_NO_DRIVER_SELECTED = (0x20000000 | 0xC0000000 | 0x203);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_KEY_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define ERROR_KEY_DOES_NOT_EXIST (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x204)")]
    public const uint ERROR_KEY_DOES_NOT_EXIST = (0x20000000 | 0xC0000000 | 0x204);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_DEVINST_NAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_DEVINST_NAME (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x205)")]
    public const uint ERROR_INVALID_DEVINST_NAME = (0x20000000 | 0xC0000000 | 0x205);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_CLASS"]/*' />
    [NativeTypeName("#define ERROR_INVALID_CLASS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x206)")]
    public const uint ERROR_INVALID_CLASS = (0x20000000 | 0xC0000000 | 0x206);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVINST_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_DEVINST_ALREADY_EXISTS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x207)")]
    public const uint ERROR_DEVINST_ALREADY_EXISTS = (0x20000000 | 0xC0000000 | 0x207);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVINFO_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define ERROR_DEVINFO_NOT_REGISTERED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x208)")]
    public const uint ERROR_DEVINFO_NOT_REGISTERED = (0x20000000 | 0xC0000000 | 0x208);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_REG_PROPERTY"]/*' />
    [NativeTypeName("#define ERROR_INVALID_REG_PROPERTY (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x209)")]
    public const uint ERROR_INVALID_REG_PROPERTY = (0x20000000 | 0xC0000000 | 0x209);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_INF"]/*' />
    [NativeTypeName("#define ERROR_NO_INF (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20A)")]
    public const uint ERROR_NO_INF = (0x20000000 | 0xC0000000 | 0x20A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SUCH_DEVINST"]/*' />
    [NativeTypeName("#define ERROR_NO_SUCH_DEVINST (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20B)")]
    public const uint ERROR_NO_SUCH_DEVINST = (0x20000000 | 0xC0000000 | 0x20B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_LOAD_CLASS_ICON"]/*' />
    [NativeTypeName("#define ERROR_CANT_LOAD_CLASS_ICON (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20C)")]
    public const uint ERROR_CANT_LOAD_CLASS_ICON = (0x20000000 | 0xC0000000 | 0x20C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_CLASS_INSTALLER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_CLASS_INSTALLER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20D)")]
    public const uint ERROR_INVALID_CLASS_INSTALLER = (0x20000000 | 0xC0000000 | 0x20D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DI_DO_DEFAULT"]/*' />
    [NativeTypeName("#define ERROR_DI_DO_DEFAULT (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20E)")]
    public const uint ERROR_DI_DO_DEFAULT = (0x20000000 | 0xC0000000 | 0x20E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DI_NOFILECOPY"]/*' />
    [NativeTypeName("#define ERROR_DI_NOFILECOPY (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20F)")]
    public const uint ERROR_DI_NOFILECOPY = (0x20000000 | 0xC0000000 | 0x20F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_HWPROFILE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_HWPROFILE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x210)")]
    public const uint ERROR_INVALID_HWPROFILE = (0x20000000 | 0xC0000000 | 0x210);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_DEVICE_SELECTED"]/*' />
    [NativeTypeName("#define ERROR_NO_DEVICE_SELECTED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x211)")]
    public const uint ERROR_NO_DEVICE_SELECTED = (0x20000000 | 0xC0000000 | 0x211);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVINFO_LIST_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_DEVINFO_LIST_LOCKED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x212)")]
    public const uint ERROR_DEVINFO_LIST_LOCKED = (0x20000000 | 0xC0000000 | 0x212);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVINFO_DATA_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_DEVINFO_DATA_LOCKED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x213)")]
    public const uint ERROR_DEVINFO_DATA_LOCKED = (0x20000000 | 0xC0000000 | 0x213);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DI_BAD_PATH"]/*' />
    [NativeTypeName("#define ERROR_DI_BAD_PATH (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x214)")]
    public const uint ERROR_DI_BAD_PATH = (0x20000000 | 0xC0000000 | 0x214);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_CLASSINSTALL_PARAMS"]/*' />
    [NativeTypeName("#define ERROR_NO_CLASSINSTALL_PARAMS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x215)")]
    public const uint ERROR_NO_CLASSINSTALL_PARAMS = (0x20000000 | 0xC0000000 | 0x215);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILEQUEUE_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_FILEQUEUE_LOCKED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x216)")]
    public const uint ERROR_FILEQUEUE_LOCKED = (0x20000000 | 0xC0000000 | 0x216);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_SERVICE_INSTALLSECT"]/*' />
    [NativeTypeName("#define ERROR_BAD_SERVICE_INSTALLSECT (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x217)")]
    public const uint ERROR_BAD_SERVICE_INSTALLSECT = (0x20000000 | 0xC0000000 | 0x217);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_CLASS_DRIVER_LIST"]/*' />
    [NativeTypeName("#define ERROR_NO_CLASS_DRIVER_LIST (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x218)")]
    public const uint ERROR_NO_CLASS_DRIVER_LIST = (0x20000000 | 0xC0000000 | 0x218);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_ASSOCIATED_SERVICE"]/*' />
    [NativeTypeName("#define ERROR_NO_ASSOCIATED_SERVICE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x219)")]
    public const uint ERROR_NO_ASSOCIATED_SERVICE = (0x20000000 | 0xC0000000 | 0x219);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_DEFAULT_DEVICE_INTERFACE"]/*' />
    [NativeTypeName("#define ERROR_NO_DEFAULT_DEVICE_INTERFACE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21A)")]
    public const uint ERROR_NO_DEFAULT_DEVICE_INTERFACE = (0x20000000 | 0xC0000000 | 0x21A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_INTERFACE_ACTIVE"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_INTERFACE_ACTIVE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21B)")]
    public const uint ERROR_DEVICE_INTERFACE_ACTIVE = (0x20000000 | 0xC0000000 | 0x21B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_INTERFACE_REMOVED"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_INTERFACE_REMOVED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21C)")]
    public const uint ERROR_DEVICE_INTERFACE_REMOVED = (0x20000000 | 0xC0000000 | 0x21C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_INTERFACE_INSTALLSECT"]/*' />
    [NativeTypeName("#define ERROR_BAD_INTERFACE_INSTALLSECT (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21D)")]
    public const uint ERROR_BAD_INTERFACE_INSTALLSECT = (0x20000000 | 0xC0000000 | 0x21D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SUCH_INTERFACE_CLASS"]/*' />
    [NativeTypeName("#define ERROR_NO_SUCH_INTERFACE_CLASS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21E)")]
    public const uint ERROR_NO_SUCH_INTERFACE_CLASS = (0x20000000 | 0xC0000000 | 0x21E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_REFERENCE_STRING"]/*' />
    [NativeTypeName("#define ERROR_INVALID_REFERENCE_STRING (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21F)")]
    public const uint ERROR_INVALID_REFERENCE_STRING = (0x20000000 | 0xC0000000 | 0x21F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_MACHINENAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_MACHINENAME (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x220)")]
    public const uint ERROR_INVALID_MACHINENAME = (0x20000000 | 0xC0000000 | 0x220);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REMOTE_COMM_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_REMOTE_COMM_FAILURE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x221)")]
    public const uint ERROR_REMOTE_COMM_FAILURE = (0x20000000 | 0xC0000000 | 0x221);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MACHINE_UNAVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_MACHINE_UNAVAILABLE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x222)")]
    public const uint ERROR_MACHINE_UNAVAILABLE = (0x20000000 | 0xC0000000 | 0x222);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_CONFIGMGR_SERVICES"]/*' />
    [NativeTypeName("#define ERROR_NO_CONFIGMGR_SERVICES (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x223)")]
    public const uint ERROR_NO_CONFIGMGR_SERVICES = (0x20000000 | 0xC0000000 | 0x223);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PROPPAGE_PROVIDER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PROPPAGE_PROVIDER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x224)")]
    public const uint ERROR_INVALID_PROPPAGE_PROVIDER = (0x20000000 | 0xC0000000 | 0x224);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SUCH_DEVICE_INTERFACE"]/*' />
    [NativeTypeName("#define ERROR_NO_SUCH_DEVICE_INTERFACE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x225)")]
    public const uint ERROR_NO_SUCH_DEVICE_INTERFACE = (0x20000000 | 0xC0000000 | 0x225);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DI_POSTPROCESSING_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_DI_POSTPROCESSING_REQUIRED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x226)")]
    public const uint ERROR_DI_POSTPROCESSING_REQUIRED = (0x20000000 | 0xC0000000 | 0x226);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_COINSTALLER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_COINSTALLER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x227)")]
    public const uint ERROR_INVALID_COINSTALLER = (0x20000000 | 0xC0000000 | 0x227);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_COMPAT_DRIVERS"]/*' />
    [NativeTypeName("#define ERROR_NO_COMPAT_DRIVERS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x228)")]
    public const uint ERROR_NO_COMPAT_DRIVERS = (0x20000000 | 0xC0000000 | 0x228);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_DEVICE_ICON"]/*' />
    [NativeTypeName("#define ERROR_NO_DEVICE_ICON (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x229)")]
    public const uint ERROR_NO_DEVICE_ICON = (0x20000000 | 0xC0000000 | 0x229);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_INF_LOGCONFIG"]/*' />
    [NativeTypeName("#define ERROR_INVALID_INF_LOGCONFIG (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22A)")]
    public const uint ERROR_INVALID_INF_LOGCONFIG = (0x20000000 | 0xC0000000 | 0x22A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DI_DONT_INSTALL"]/*' />
    [NativeTypeName("#define ERROR_DI_DONT_INSTALL (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22B)")]
    public const uint ERROR_DI_DONT_INSTALL = (0x20000000 | 0xC0000000 | 0x22B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_FILTER_DRIVER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_FILTER_DRIVER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22C)")]
    public const uint ERROR_INVALID_FILTER_DRIVER = (0x20000000 | 0xC0000000 | 0x22C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NON_WINDOWS_NT_DRIVER"]/*' />
    [NativeTypeName("#define ERROR_NON_WINDOWS_NT_DRIVER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22D)")]
    public const uint ERROR_NON_WINDOWS_NT_DRIVER = (0x20000000 | 0xC0000000 | 0x22D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NON_WINDOWS_DRIVER"]/*' />
    [NativeTypeName("#define ERROR_NON_WINDOWS_DRIVER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22E)")]
    public const uint ERROR_NON_WINDOWS_DRIVER = (0x20000000 | 0xC0000000 | 0x22E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_CATALOG_FOR_OEM_INF"]/*' />
    [NativeTypeName("#define ERROR_NO_CATALOG_FOR_OEM_INF (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22F)")]
    public const uint ERROR_NO_CATALOG_FOR_OEM_INF = (0x20000000 | 0xC0000000 | 0x22F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVINSTALL_QUEUE_NONNATIVE"]/*' />
    [NativeTypeName("#define ERROR_DEVINSTALL_QUEUE_NONNATIVE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x230)")]
    public const uint ERROR_DEVINSTALL_QUEUE_NONNATIVE = (0x20000000 | 0xC0000000 | 0x230);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_DISABLEABLE"]/*' />
    [NativeTypeName("#define ERROR_NOT_DISABLEABLE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x231)")]
    public const uint ERROR_NOT_DISABLEABLE = (0x20000000 | 0xC0000000 | 0x231);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_REMOVE_DEVINST"]/*' />
    [NativeTypeName("#define ERROR_CANT_REMOVE_DEVINST (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x232)")]
    public const uint ERROR_CANT_REMOVE_DEVINST = (0x20000000 | 0xC0000000 | 0x232);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_TARGET"]/*' />
    [NativeTypeName("#define ERROR_INVALID_TARGET (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x233)")]
    public const uint ERROR_INVALID_TARGET = (0x20000000 | 0xC0000000 | 0x233);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DRIVER_NONNATIVE"]/*' />
    [NativeTypeName("#define ERROR_DRIVER_NONNATIVE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x234)")]
    public const uint ERROR_DRIVER_NONNATIVE = (0x20000000 | 0xC0000000 | 0x234);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IN_WOW64"]/*' />
    [NativeTypeName("#define ERROR_IN_WOW64 (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x235)")]
    public const uint ERROR_IN_WOW64 = (0x20000000 | 0xC0000000 | 0x235);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SET_SYSTEM_RESTORE_POINT"]/*' />
    [NativeTypeName("#define ERROR_SET_SYSTEM_RESTORE_POINT (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x236)")]
    public const uint ERROR_SET_SYSTEM_RESTORE_POINT = (0x20000000 | 0xC0000000 | 0x236);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SCE_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_SCE_DISABLED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x238)")]
    public const uint ERROR_SCE_DISABLED = (0x20000000 | 0xC0000000 | 0x238);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNKNOWN_EXCEPTION"]/*' />
    [NativeTypeName("#define ERROR_UNKNOWN_EXCEPTION (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x239)")]
    public const uint ERROR_UNKNOWN_EXCEPTION = (0x20000000 | 0xC0000000 | 0x239);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PNP_REGISTRY_ERROR"]/*' />
    [NativeTypeName("#define ERROR_PNP_REGISTRY_ERROR (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23A)")]
    public const uint ERROR_PNP_REGISTRY_ERROR = (0x20000000 | 0xC0000000 | 0x23A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REMOTE_REQUEST_UNSUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_REMOTE_REQUEST_UNSUPPORTED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23B)")]
    public const uint ERROR_REMOTE_REQUEST_UNSUPPORTED = (0x20000000 | 0xC0000000 | 0x23B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_AN_INSTALLED_OEM_INF"]/*' />
    [NativeTypeName("#define ERROR_NOT_AN_INSTALLED_OEM_INF (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23C)")]
    public const uint ERROR_NOT_AN_INSTALLED_OEM_INF = (0x20000000 | 0xC0000000 | 0x23C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INF_IN_USE_BY_DEVICES"]/*' />
    [NativeTypeName("#define ERROR_INF_IN_USE_BY_DEVICES (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23D)")]
    public const uint ERROR_INF_IN_USE_BY_DEVICES = (0x20000000 | 0xC0000000 | 0x23D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DI_FUNCTION_OBSOLETE"]/*' />
    [NativeTypeName("#define ERROR_DI_FUNCTION_OBSOLETE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23E)")]
    public const uint ERROR_DI_FUNCTION_OBSOLETE = (0x20000000 | 0xC0000000 | 0x23E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_AUTHENTICODE_CATALOG"]/*' />
    [NativeTypeName("#define ERROR_NO_AUTHENTICODE_CATALOG (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23F)")]
    public const uint ERROR_NO_AUTHENTICODE_CATALOG = (0x20000000 | 0xC0000000 | 0x23F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_AUTHENTICODE_DISALLOWED"]/*' />
    [NativeTypeName("#define ERROR_AUTHENTICODE_DISALLOWED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x240)")]
    public const uint ERROR_AUTHENTICODE_DISALLOWED = (0x20000000 | 0xC0000000 | 0x240);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_AUTHENTICODE_TRUSTED_PUBLISHER"]/*' />
    [NativeTypeName("#define ERROR_AUTHENTICODE_TRUSTED_PUBLISHER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x241)")]
    public const uint ERROR_AUTHENTICODE_TRUSTED_PUBLISHER = (0x20000000 | 0xC0000000 | 0x241);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_AUTHENTICODE_TRUST_NOT_ESTABLISHED"]/*' />
    [NativeTypeName("#define ERROR_AUTHENTICODE_TRUST_NOT_ESTABLISHED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x242)")]
    public const uint ERROR_AUTHENTICODE_TRUST_NOT_ESTABLISHED = (0x20000000 | 0xC0000000 | 0x242);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_AUTHENTICODE_PUBLISHER_NOT_TRUSTED"]/*' />
    [NativeTypeName("#define ERROR_AUTHENTICODE_PUBLISHER_NOT_TRUSTED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x243)")]
    public const uint ERROR_AUTHENTICODE_PUBLISHER_NOT_TRUSTED = (0x20000000 | 0xC0000000 | 0x243);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SIGNATURE_OSATTRIBUTE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_SIGNATURE_OSATTRIBUTE_MISMATCH (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x244)")]
    public const uint ERROR_SIGNATURE_OSATTRIBUTE_MISMATCH = (0x20000000 | 0xC0000000 | 0x244);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ONLY_VALIDATE_VIA_AUTHENTICODE"]/*' />
    [NativeTypeName("#define ERROR_ONLY_VALIDATE_VIA_AUTHENTICODE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x245)")]
    public const uint ERROR_ONLY_VALIDATE_VIA_AUTHENTICODE = (0x20000000 | 0xC0000000 | 0x245);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_INSTALLER_NOT_READY"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_INSTALLER_NOT_READY (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x246)")]
    public const uint ERROR_DEVICE_INSTALLER_NOT_READY = (0x20000000 | 0xC0000000 | 0x246);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DRIVER_STORE_ADD_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DRIVER_STORE_ADD_FAILED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x247)")]
    public const uint ERROR_DRIVER_STORE_ADD_FAILED = (0x20000000 | 0xC0000000 | 0x247);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_INSTALL_BLOCKED"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_INSTALL_BLOCKED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x248)")]
    public const uint ERROR_DEVICE_INSTALL_BLOCKED = (0x20000000 | 0xC0000000 | 0x248);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DRIVER_INSTALL_BLOCKED"]/*' />
    [NativeTypeName("#define ERROR_DRIVER_INSTALL_BLOCKED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x249)")]
    public const uint ERROR_DRIVER_INSTALL_BLOCKED = (0x20000000 | 0xC0000000 | 0x249);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WRONG_INF_TYPE"]/*' />
    [NativeTypeName("#define ERROR_WRONG_INF_TYPE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x24A)")]
    public const uint ERROR_WRONG_INF_TYPE = (0x20000000 | 0xC0000000 | 0x24A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_HASH_NOT_IN_CATALOG"]/*' />
    [NativeTypeName("#define ERROR_FILE_HASH_NOT_IN_CATALOG (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x24B)")]
    public const uint ERROR_FILE_HASH_NOT_IN_CATALOG = (0x20000000 | 0xC0000000 | 0x24B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DRIVER_STORE_DELETE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DRIVER_STORE_DELETE_FAILED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x24C)")]
    public const uint ERROR_DRIVER_STORE_DELETE_FAILED = (0x20000000 | 0xC0000000 | 0x24C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNRECOVERABLE_STACK_OVERFLOW"]/*' />
    [NativeTypeName("#define ERROR_UNRECOVERABLE_STACK_OVERFLOW (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x300)")]
    public const uint ERROR_UNRECOVERABLE_STACK_OVERFLOW = (0x20000000 | 0xC0000000 | 0x300);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_DEFAULT_INTERFACE_DEVICE"]/*' />
    [NativeTypeName("#define ERROR_NO_DEFAULT_INTERFACE_DEVICE ERROR_NO_DEFAULT_DEVICE_INTERFACE")]
    public const uint ERROR_NO_DEFAULT_INTERFACE_DEVICE = (0x20000000 | 0xC0000000 | 0x21A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INTERFACE_DEVICE_ACTIVE"]/*' />
    [NativeTypeName("#define ERROR_INTERFACE_DEVICE_ACTIVE ERROR_DEVICE_INTERFACE_ACTIVE")]
    public const uint ERROR_INTERFACE_DEVICE_ACTIVE = (0x20000000 | 0xC0000000 | 0x21B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INTERFACE_DEVICE_REMOVED"]/*' />
    [NativeTypeName("#define ERROR_INTERFACE_DEVICE_REMOVED ERROR_DEVICE_INTERFACE_REMOVED")]
    public const uint ERROR_INTERFACE_DEVICE_REMOVED = (0x20000000 | 0xC0000000 | 0x21C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SUCH_INTERFACE_DEVICE"]/*' />
    [NativeTypeName("#define ERROR_NO_SUCH_INTERFACE_DEVICE ERROR_NO_SUCH_DEVICE_INTERFACE")]
    public const uint ERROR_NO_SUCH_INTERFACE_DEVICE = (0x20000000 | 0xC0000000 | 0x225);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_NOT_INSTALLED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x1000)")]
    public const uint ERROR_NOT_INSTALLED = (0x20000000 | 0xC0000000 | 0x1000);
}
