// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ERROR
{
    [NativeTypeName("#define ERROR_EXPECTED_SECTION_NAME (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0)")]
    public const uint ERROR_EXPECTED_SECTION_NAME = (0x20000000 | 0xC0000000 | 0);

    [NativeTypeName("#define ERROR_BAD_SECTION_NAME_LINE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|1)")]
    public const uint ERROR_BAD_SECTION_NAME_LINE = (0x20000000 | 0xC0000000 | 1);

    [NativeTypeName("#define ERROR_SECTION_NAME_TOO_LONG (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|2)")]
    public const uint ERROR_SECTION_NAME_TOO_LONG = (0x20000000 | 0xC0000000 | 2);

    [NativeTypeName("#define ERROR_GENERAL_SYNTAX (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|3)")]
    public const uint ERROR_GENERAL_SYNTAX = (0x20000000 | 0xC0000000 | 3);

    [NativeTypeName("#define ERROR_WRONG_INF_STYLE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x100)")]
    public const uint ERROR_WRONG_INF_STYLE = (0x20000000 | 0xC0000000 | 0x100);

    [NativeTypeName("#define ERROR_SECTION_NOT_FOUND (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x101)")]
    public const uint ERROR_SECTION_NOT_FOUND = (0x20000000 | 0xC0000000 | 0x101);

    [NativeTypeName("#define ERROR_LINE_NOT_FOUND (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x102)")]
    public const uint ERROR_LINE_NOT_FOUND = (0x20000000 | 0xC0000000 | 0x102);

    [NativeTypeName("#define ERROR_NO_BACKUP (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x103)")]
    public const uint ERROR_NO_BACKUP = (0x20000000 | 0xC0000000 | 0x103);

    [NativeTypeName("#define ERROR_NO_ASSOCIATED_CLASS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x200)")]
    public const uint ERROR_NO_ASSOCIATED_CLASS = (0x20000000 | 0xC0000000 | 0x200);

    [NativeTypeName("#define ERROR_CLASS_MISMATCH (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x201)")]
    public const uint ERROR_CLASS_MISMATCH = (0x20000000 | 0xC0000000 | 0x201);

    [NativeTypeName("#define ERROR_DUPLICATE_FOUND (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x202)")]
    public const uint ERROR_DUPLICATE_FOUND = (0x20000000 | 0xC0000000 | 0x202);

    [NativeTypeName("#define ERROR_NO_DRIVER_SELECTED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x203)")]
    public const uint ERROR_NO_DRIVER_SELECTED = (0x20000000 | 0xC0000000 | 0x203);

    [NativeTypeName("#define ERROR_KEY_DOES_NOT_EXIST (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x204)")]
    public const uint ERROR_KEY_DOES_NOT_EXIST = (0x20000000 | 0xC0000000 | 0x204);

    [NativeTypeName("#define ERROR_INVALID_DEVINST_NAME (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x205)")]
    public const uint ERROR_INVALID_DEVINST_NAME = (0x20000000 | 0xC0000000 | 0x205);

    [NativeTypeName("#define ERROR_INVALID_CLASS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x206)")]
    public const uint ERROR_INVALID_CLASS = (0x20000000 | 0xC0000000 | 0x206);

    [NativeTypeName("#define ERROR_DEVINST_ALREADY_EXISTS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x207)")]
    public const uint ERROR_DEVINST_ALREADY_EXISTS = (0x20000000 | 0xC0000000 | 0x207);

    [NativeTypeName("#define ERROR_DEVINFO_NOT_REGISTERED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x208)")]
    public const uint ERROR_DEVINFO_NOT_REGISTERED = (0x20000000 | 0xC0000000 | 0x208);

    [NativeTypeName("#define ERROR_INVALID_REG_PROPERTY (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x209)")]
    public const uint ERROR_INVALID_REG_PROPERTY = (0x20000000 | 0xC0000000 | 0x209);

    [NativeTypeName("#define ERROR_NO_INF (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20A)")]
    public const uint ERROR_NO_INF = (0x20000000 | 0xC0000000 | 0x20A);

    [NativeTypeName("#define ERROR_NO_SUCH_DEVINST (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20B)")]
    public const uint ERROR_NO_SUCH_DEVINST = (0x20000000 | 0xC0000000 | 0x20B);

    [NativeTypeName("#define ERROR_CANT_LOAD_CLASS_ICON (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20C)")]
    public const uint ERROR_CANT_LOAD_CLASS_ICON = (0x20000000 | 0xC0000000 | 0x20C);

    [NativeTypeName("#define ERROR_INVALID_CLASS_INSTALLER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20D)")]
    public const uint ERROR_INVALID_CLASS_INSTALLER = (0x20000000 | 0xC0000000 | 0x20D);

    [NativeTypeName("#define ERROR_DI_DO_DEFAULT (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20E)")]
    public const uint ERROR_DI_DO_DEFAULT = (0x20000000 | 0xC0000000 | 0x20E);

    [NativeTypeName("#define ERROR_DI_NOFILECOPY (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20F)")]
    public const uint ERROR_DI_NOFILECOPY = (0x20000000 | 0xC0000000 | 0x20F);

    [NativeTypeName("#define ERROR_INVALID_HWPROFILE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x210)")]
    public const uint ERROR_INVALID_HWPROFILE = (0x20000000 | 0xC0000000 | 0x210);

    [NativeTypeName("#define ERROR_NO_DEVICE_SELECTED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x211)")]
    public const uint ERROR_NO_DEVICE_SELECTED = (0x20000000 | 0xC0000000 | 0x211);

    [NativeTypeName("#define ERROR_DEVINFO_LIST_LOCKED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x212)")]
    public const uint ERROR_DEVINFO_LIST_LOCKED = (0x20000000 | 0xC0000000 | 0x212);

    [NativeTypeName("#define ERROR_DEVINFO_DATA_LOCKED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x213)")]
    public const uint ERROR_DEVINFO_DATA_LOCKED = (0x20000000 | 0xC0000000 | 0x213);

    [NativeTypeName("#define ERROR_DI_BAD_PATH (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x214)")]
    public const uint ERROR_DI_BAD_PATH = (0x20000000 | 0xC0000000 | 0x214);

    [NativeTypeName("#define ERROR_NO_CLASSINSTALL_PARAMS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x215)")]
    public const uint ERROR_NO_CLASSINSTALL_PARAMS = (0x20000000 | 0xC0000000 | 0x215);

    [NativeTypeName("#define ERROR_FILEQUEUE_LOCKED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x216)")]
    public const uint ERROR_FILEQUEUE_LOCKED = (0x20000000 | 0xC0000000 | 0x216);

    [NativeTypeName("#define ERROR_BAD_SERVICE_INSTALLSECT (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x217)")]
    public const uint ERROR_BAD_SERVICE_INSTALLSECT = (0x20000000 | 0xC0000000 | 0x217);

    [NativeTypeName("#define ERROR_NO_CLASS_DRIVER_LIST (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x218)")]
    public const uint ERROR_NO_CLASS_DRIVER_LIST = (0x20000000 | 0xC0000000 | 0x218);

    [NativeTypeName("#define ERROR_NO_ASSOCIATED_SERVICE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x219)")]
    public const uint ERROR_NO_ASSOCIATED_SERVICE = (0x20000000 | 0xC0000000 | 0x219);

    [NativeTypeName("#define ERROR_NO_DEFAULT_DEVICE_INTERFACE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21A)")]
    public const uint ERROR_NO_DEFAULT_DEVICE_INTERFACE = (0x20000000 | 0xC0000000 | 0x21A);

    [NativeTypeName("#define ERROR_DEVICE_INTERFACE_ACTIVE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21B)")]
    public const uint ERROR_DEVICE_INTERFACE_ACTIVE = (0x20000000 | 0xC0000000 | 0x21B);

    [NativeTypeName("#define ERROR_DEVICE_INTERFACE_REMOVED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21C)")]
    public const uint ERROR_DEVICE_INTERFACE_REMOVED = (0x20000000 | 0xC0000000 | 0x21C);

    [NativeTypeName("#define ERROR_BAD_INTERFACE_INSTALLSECT (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21D)")]
    public const uint ERROR_BAD_INTERFACE_INSTALLSECT = (0x20000000 | 0xC0000000 | 0x21D);

    [NativeTypeName("#define ERROR_NO_SUCH_INTERFACE_CLASS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21E)")]
    public const uint ERROR_NO_SUCH_INTERFACE_CLASS = (0x20000000 | 0xC0000000 | 0x21E);

    [NativeTypeName("#define ERROR_INVALID_REFERENCE_STRING (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21F)")]
    public const uint ERROR_INVALID_REFERENCE_STRING = (0x20000000 | 0xC0000000 | 0x21F);

    [NativeTypeName("#define ERROR_INVALID_MACHINENAME (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x220)")]
    public const uint ERROR_INVALID_MACHINENAME = (0x20000000 | 0xC0000000 | 0x220);

    [NativeTypeName("#define ERROR_REMOTE_COMM_FAILURE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x221)")]
    public const uint ERROR_REMOTE_COMM_FAILURE = (0x20000000 | 0xC0000000 | 0x221);

    [NativeTypeName("#define ERROR_MACHINE_UNAVAILABLE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x222)")]
    public const uint ERROR_MACHINE_UNAVAILABLE = (0x20000000 | 0xC0000000 | 0x222);

    [NativeTypeName("#define ERROR_NO_CONFIGMGR_SERVICES (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x223)")]
    public const uint ERROR_NO_CONFIGMGR_SERVICES = (0x20000000 | 0xC0000000 | 0x223);

    [NativeTypeName("#define ERROR_INVALID_PROPPAGE_PROVIDER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x224)")]
    public const uint ERROR_INVALID_PROPPAGE_PROVIDER = (0x20000000 | 0xC0000000 | 0x224);

    [NativeTypeName("#define ERROR_NO_SUCH_DEVICE_INTERFACE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x225)")]
    public const uint ERROR_NO_SUCH_DEVICE_INTERFACE = (0x20000000 | 0xC0000000 | 0x225);

    [NativeTypeName("#define ERROR_DI_POSTPROCESSING_REQUIRED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x226)")]
    public const uint ERROR_DI_POSTPROCESSING_REQUIRED = (0x20000000 | 0xC0000000 | 0x226);

    [NativeTypeName("#define ERROR_INVALID_COINSTALLER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x227)")]
    public const uint ERROR_INVALID_COINSTALLER = (0x20000000 | 0xC0000000 | 0x227);

    [NativeTypeName("#define ERROR_NO_COMPAT_DRIVERS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x228)")]
    public const uint ERROR_NO_COMPAT_DRIVERS = (0x20000000 | 0xC0000000 | 0x228);

    [NativeTypeName("#define ERROR_NO_DEVICE_ICON (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x229)")]
    public const uint ERROR_NO_DEVICE_ICON = (0x20000000 | 0xC0000000 | 0x229);

    [NativeTypeName("#define ERROR_INVALID_INF_LOGCONFIG (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22A)")]
    public const uint ERROR_INVALID_INF_LOGCONFIG = (0x20000000 | 0xC0000000 | 0x22A);

    [NativeTypeName("#define ERROR_DI_DONT_INSTALL (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22B)")]
    public const uint ERROR_DI_DONT_INSTALL = (0x20000000 | 0xC0000000 | 0x22B);

    [NativeTypeName("#define ERROR_INVALID_FILTER_DRIVER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22C)")]
    public const uint ERROR_INVALID_FILTER_DRIVER = (0x20000000 | 0xC0000000 | 0x22C);

    [NativeTypeName("#define ERROR_NON_WINDOWS_NT_DRIVER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22D)")]
    public const uint ERROR_NON_WINDOWS_NT_DRIVER = (0x20000000 | 0xC0000000 | 0x22D);

    [NativeTypeName("#define ERROR_NON_WINDOWS_DRIVER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22E)")]
    public const uint ERROR_NON_WINDOWS_DRIVER = (0x20000000 | 0xC0000000 | 0x22E);

    [NativeTypeName("#define ERROR_NO_CATALOG_FOR_OEM_INF (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22F)")]
    public const uint ERROR_NO_CATALOG_FOR_OEM_INF = (0x20000000 | 0xC0000000 | 0x22F);

    [NativeTypeName("#define ERROR_DEVINSTALL_QUEUE_NONNATIVE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x230)")]
    public const uint ERROR_DEVINSTALL_QUEUE_NONNATIVE = (0x20000000 | 0xC0000000 | 0x230);

    [NativeTypeName("#define ERROR_NOT_DISABLEABLE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x231)")]
    public const uint ERROR_NOT_DISABLEABLE = (0x20000000 | 0xC0000000 | 0x231);

    [NativeTypeName("#define ERROR_CANT_REMOVE_DEVINST (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x232)")]
    public const uint ERROR_CANT_REMOVE_DEVINST = (0x20000000 | 0xC0000000 | 0x232);

    [NativeTypeName("#define ERROR_INVALID_TARGET (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x233)")]
    public const uint ERROR_INVALID_TARGET = (0x20000000 | 0xC0000000 | 0x233);

    [NativeTypeName("#define ERROR_DRIVER_NONNATIVE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x234)")]
    public const uint ERROR_DRIVER_NONNATIVE = (0x20000000 | 0xC0000000 | 0x234);

    [NativeTypeName("#define ERROR_IN_WOW64 (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x235)")]
    public const uint ERROR_IN_WOW64 = (0x20000000 | 0xC0000000 | 0x235);

    [NativeTypeName("#define ERROR_SET_SYSTEM_RESTORE_POINT (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x236)")]
    public const uint ERROR_SET_SYSTEM_RESTORE_POINT = (0x20000000 | 0xC0000000 | 0x236);

    [NativeTypeName("#define ERROR_SCE_DISABLED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x238)")]
    public const uint ERROR_SCE_DISABLED = (0x20000000 | 0xC0000000 | 0x238);

    [NativeTypeName("#define ERROR_UNKNOWN_EXCEPTION (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x239)")]
    public const uint ERROR_UNKNOWN_EXCEPTION = (0x20000000 | 0xC0000000 | 0x239);

    [NativeTypeName("#define ERROR_PNP_REGISTRY_ERROR (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23A)")]
    public const uint ERROR_PNP_REGISTRY_ERROR = (0x20000000 | 0xC0000000 | 0x23A);

    [NativeTypeName("#define ERROR_REMOTE_REQUEST_UNSUPPORTED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23B)")]
    public const uint ERROR_REMOTE_REQUEST_UNSUPPORTED = (0x20000000 | 0xC0000000 | 0x23B);

    [NativeTypeName("#define ERROR_NOT_AN_INSTALLED_OEM_INF (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23C)")]
    public const uint ERROR_NOT_AN_INSTALLED_OEM_INF = (0x20000000 | 0xC0000000 | 0x23C);

    [NativeTypeName("#define ERROR_INF_IN_USE_BY_DEVICES (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23D)")]
    public const uint ERROR_INF_IN_USE_BY_DEVICES = (0x20000000 | 0xC0000000 | 0x23D);

    [NativeTypeName("#define ERROR_DI_FUNCTION_OBSOLETE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23E)")]
    public const uint ERROR_DI_FUNCTION_OBSOLETE = (0x20000000 | 0xC0000000 | 0x23E);

    [NativeTypeName("#define ERROR_NO_AUTHENTICODE_CATALOG (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23F)")]
    public const uint ERROR_NO_AUTHENTICODE_CATALOG = (0x20000000 | 0xC0000000 | 0x23F);

    [NativeTypeName("#define ERROR_AUTHENTICODE_DISALLOWED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x240)")]
    public const uint ERROR_AUTHENTICODE_DISALLOWED = (0x20000000 | 0xC0000000 | 0x240);

    [NativeTypeName("#define ERROR_AUTHENTICODE_TRUSTED_PUBLISHER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x241)")]
    public const uint ERROR_AUTHENTICODE_TRUSTED_PUBLISHER = (0x20000000 | 0xC0000000 | 0x241);

    [NativeTypeName("#define ERROR_AUTHENTICODE_TRUST_NOT_ESTABLISHED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x242)")]
    public const uint ERROR_AUTHENTICODE_TRUST_NOT_ESTABLISHED = (0x20000000 | 0xC0000000 | 0x242);

    [NativeTypeName("#define ERROR_AUTHENTICODE_PUBLISHER_NOT_TRUSTED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x243)")]
    public const uint ERROR_AUTHENTICODE_PUBLISHER_NOT_TRUSTED = (0x20000000 | 0xC0000000 | 0x243);

    [NativeTypeName("#define ERROR_SIGNATURE_OSATTRIBUTE_MISMATCH (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x244)")]
    public const uint ERROR_SIGNATURE_OSATTRIBUTE_MISMATCH = (0x20000000 | 0xC0000000 | 0x244);

    [NativeTypeName("#define ERROR_ONLY_VALIDATE_VIA_AUTHENTICODE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x245)")]
    public const uint ERROR_ONLY_VALIDATE_VIA_AUTHENTICODE = (0x20000000 | 0xC0000000 | 0x245);

    [NativeTypeName("#define ERROR_DEVICE_INSTALLER_NOT_READY (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x246)")]
    public const uint ERROR_DEVICE_INSTALLER_NOT_READY = (0x20000000 | 0xC0000000 | 0x246);

    [NativeTypeName("#define ERROR_DRIVER_STORE_ADD_FAILED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x247)")]
    public const uint ERROR_DRIVER_STORE_ADD_FAILED = (0x20000000 | 0xC0000000 | 0x247);

    [NativeTypeName("#define ERROR_DEVICE_INSTALL_BLOCKED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x248)")]
    public const uint ERROR_DEVICE_INSTALL_BLOCKED = (0x20000000 | 0xC0000000 | 0x248);

    [NativeTypeName("#define ERROR_DRIVER_INSTALL_BLOCKED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x249)")]
    public const uint ERROR_DRIVER_INSTALL_BLOCKED = (0x20000000 | 0xC0000000 | 0x249);

    [NativeTypeName("#define ERROR_WRONG_INF_TYPE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x24A)")]
    public const uint ERROR_WRONG_INF_TYPE = (0x20000000 | 0xC0000000 | 0x24A);

    [NativeTypeName("#define ERROR_FILE_HASH_NOT_IN_CATALOG (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x24B)")]
    public const uint ERROR_FILE_HASH_NOT_IN_CATALOG = (0x20000000 | 0xC0000000 | 0x24B);

    [NativeTypeName("#define ERROR_DRIVER_STORE_DELETE_FAILED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x24C)")]
    public const uint ERROR_DRIVER_STORE_DELETE_FAILED = (0x20000000 | 0xC0000000 | 0x24C);

    [NativeTypeName("#define ERROR_UNRECOVERABLE_STACK_OVERFLOW (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x300)")]
    public const uint ERROR_UNRECOVERABLE_STACK_OVERFLOW = (0x20000000 | 0xC0000000 | 0x300);

    [NativeTypeName("#define ERROR_NO_DEFAULT_INTERFACE_DEVICE ERROR_NO_DEFAULT_DEVICE_INTERFACE")]
    public const uint ERROR_NO_DEFAULT_INTERFACE_DEVICE = (0x20000000 | 0xC0000000 | 0x21A);

    [NativeTypeName("#define ERROR_INTERFACE_DEVICE_ACTIVE ERROR_DEVICE_INTERFACE_ACTIVE")]
    public const uint ERROR_INTERFACE_DEVICE_ACTIVE = (0x20000000 | 0xC0000000 | 0x21B);

    [NativeTypeName("#define ERROR_INTERFACE_DEVICE_REMOVED ERROR_DEVICE_INTERFACE_REMOVED")]
    public const uint ERROR_INTERFACE_DEVICE_REMOVED = (0x20000000 | 0xC0000000 | 0x21C);

    [NativeTypeName("#define ERROR_NO_SUCH_INTERFACE_DEVICE ERROR_NO_SUCH_DEVICE_INTERFACE")]
    public const uint ERROR_NO_SUCH_INTERFACE_DEVICE = (0x20000000 | 0xC0000000 | 0x225);

    [NativeTypeName("#define ERROR_NOT_INSTALLED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x1000)")]
    public const uint ERROR_NOT_INSTALLED = (0x20000000 | 0xC0000000 | 0x1000);
}
