// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ntstatus.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FACILITY
{
    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEBUGGER"]/*' />
    [NativeTypeName("#define FACILITY_DEBUGGER 0x1")]
    public const int FACILITY_DEBUGGER = 0x1;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_RPC_RUNTIME"]/*' />
    [NativeTypeName("#define FACILITY_RPC_RUNTIME 0x2")]
    public const int FACILITY_RPC_RUNTIME = 0x2;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_RPC_STUBS"]/*' />
    [NativeTypeName("#define FACILITY_RPC_STUBS 0x3")]
    public const int FACILITY_RPC_STUBS = 0x3;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_IO_ERROR_CODE"]/*' />
    [NativeTypeName("#define FACILITY_IO_ERROR_CODE 0x4")]
    public const int FACILITY_IO_ERROR_CODE = 0x4;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_CODCLASS_ERROR_CODE"]/*' />
    [NativeTypeName("#define FACILITY_CODCLASS_ERROR_CODE 0x6")]
    public const int FACILITY_CODCLASS_ERROR_CODE = 0x6;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_NTWIN32"]/*' />
    [NativeTypeName("#define FACILITY_NTWIN32 0x7")]
    public const int FACILITY_NTWIN32 = 0x7;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_NTCERT"]/*' />
    [NativeTypeName("#define FACILITY_NTCERT 0x8")]
    public const int FACILITY_NTCERT = 0x8;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_NTSSPI"]/*' />
    [NativeTypeName("#define FACILITY_NTSSPI 0x9")]
    public const int FACILITY_NTSSPI = 0x9;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_TERMINAL_SERVER"]/*' />
    [NativeTypeName("#define FACILITY_TERMINAL_SERVER 0xA")]
    public const int FACILITY_TERMINAL_SERVER = 0xA;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USB_ERROR_CODE"]/*' />
    [NativeTypeName("#define FACILITY_USB_ERROR_CODE 0x10")]
    public const int FACILITY_USB_ERROR_CODE = 0x10;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_HID_ERROR_CODE"]/*' />
    [NativeTypeName("#define FACILITY_HID_ERROR_CODE 0x11")]
    public const int FACILITY_HID_ERROR_CODE = 0x11;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_FIREWIRE_ERROR_CODE"]/*' />
    [NativeTypeName("#define FACILITY_FIREWIRE_ERROR_CODE 0x12")]
    public const int FACILITY_FIREWIRE_ERROR_CODE = 0x12;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_CLUSTER_ERROR_CODE"]/*' />
    [NativeTypeName("#define FACILITY_CLUSTER_ERROR_CODE 0x13")]
    public const int FACILITY_CLUSTER_ERROR_CODE = 0x13;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_ACPI_ERROR_CODE"]/*' />
    [NativeTypeName("#define FACILITY_ACPI_ERROR_CODE 0x14")]
    public const int FACILITY_ACPI_ERROR_CODE = 0x14;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SXS_ERROR_CODE"]/*' />
    [NativeTypeName("#define FACILITY_SXS_ERROR_CODE 0x15")]
    public const int FACILITY_SXS_ERROR_CODE = 0x15;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_TRANSACTION"]/*' />
    [NativeTypeName("#define FACILITY_TRANSACTION 0x19")]
    public const int FACILITY_TRANSACTION = 0x19;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_COMMONLOG"]/*' />
    [NativeTypeName("#define FACILITY_COMMONLOG 0x1A")]
    public const int FACILITY_COMMONLOG = 0x1A;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_VIDEO"]/*' />
    [NativeTypeName("#define FACILITY_VIDEO 0x1B")]
    public const int FACILITY_VIDEO = 0x1B;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_FILTER_MANAGER"]/*' />
    [NativeTypeName("#define FACILITY_FILTER_MANAGER 0x1C")]
    public const int FACILITY_FILTER_MANAGER = 0x1C;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_MONITOR"]/*' />
    [NativeTypeName("#define FACILITY_MONITOR 0x1D")]
    public const int FACILITY_MONITOR = 0x1D;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_GRAPHICS_KERNEL"]/*' />
    [NativeTypeName("#define FACILITY_GRAPHICS_KERNEL 0x1E")]
    public const int FACILITY_GRAPHICS_KERNEL = 0x1E;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_CAMERA"]/*' />
    [NativeTypeName("#define FACILITY_CAMERA 0x1F")]
    public const int FACILITY_CAMERA = 0x1F;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DRIVER_FRAMEWORK"]/*' />
    [NativeTypeName("#define FACILITY_DRIVER_FRAMEWORK 0x20")]
    public const int FACILITY_DRIVER_FRAMEWORK = 0x20;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_FVE_ERROR_CODE"]/*' />
    [NativeTypeName("#define FACILITY_FVE_ERROR_CODE 0x21")]
    public const int FACILITY_FVE_ERROR_CODE = 0x21;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_FWP_ERROR_CODE"]/*' />
    [NativeTypeName("#define FACILITY_FWP_ERROR_CODE 0x22")]
    public const int FACILITY_FWP_ERROR_CODE = 0x22;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_NDIS_ERROR_CODE"]/*' />
    [NativeTypeName("#define FACILITY_NDIS_ERROR_CODE 0x23")]
    public const int FACILITY_NDIS_ERROR_CODE = 0x23;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_QUIC_ERROR_CODE"]/*' />
    [NativeTypeName("#define FACILITY_QUIC_ERROR_CODE 0x24")]
    public const int FACILITY_QUIC_ERROR_CODE = 0x24;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_TPM"]/*' />
    [NativeTypeName("#define FACILITY_TPM 0x29")]
    public const int FACILITY_TPM = 0x29;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_RTPM"]/*' />
    [NativeTypeName("#define FACILITY_RTPM 0x2A")]
    public const int FACILITY_RTPM = 0x2A;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_HYPERVISOR"]/*' />
    [NativeTypeName("#define FACILITY_HYPERVISOR 0x35")]
    public const int FACILITY_HYPERVISOR = 0x35;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_IPSEC"]/*' />
    [NativeTypeName("#define FACILITY_IPSEC 0x36")]
    public const int FACILITY_IPSEC = 0x36;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_VIRTUALIZATION"]/*' />
    [NativeTypeName("#define FACILITY_VIRTUALIZATION 0x37")]
    public const int FACILITY_VIRTUALIZATION = 0x37;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_VOLMGR"]/*' />
    [NativeTypeName("#define FACILITY_VOLMGR 0x38")]
    public const int FACILITY_VOLMGR = 0x38;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_BCD_ERROR_CODE"]/*' />
    [NativeTypeName("#define FACILITY_BCD_ERROR_CODE 0x39")]
    public const int FACILITY_BCD_ERROR_CODE = 0x39;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WIN32K_NTUSER"]/*' />
    [NativeTypeName("#define FACILITY_WIN32K_NTUSER 0x3E")]
    public const int FACILITY_WIN32K_NTUSER = 0x3E;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WIN32K_NTGDI"]/*' />
    [NativeTypeName("#define FACILITY_WIN32K_NTGDI 0x3F")]
    public const int FACILITY_WIN32K_NTGDI = 0x3F;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_RESUME_KEY_FILTER"]/*' />
    [NativeTypeName("#define FACILITY_RESUME_KEY_FILTER 0x40")]
    public const int FACILITY_RESUME_KEY_FILTER = 0x40;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_RDBSS"]/*' />
    [NativeTypeName("#define FACILITY_RDBSS 0x41")]
    public const int FACILITY_RDBSS = 0x41;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_BTH_ATT"]/*' />
    [NativeTypeName("#define FACILITY_BTH_ATT 0x42")]
    public const int FACILITY_BTH_ATT = 0x42;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SECUREBOOT"]/*' />
    [NativeTypeName("#define FACILITY_SECUREBOOT 0x43")]
    public const int FACILITY_SECUREBOOT = 0x43;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_AUDIO_KERNEL"]/*' />
    [NativeTypeName("#define FACILITY_AUDIO_KERNEL 0x44")]
    public const int FACILITY_AUDIO_KERNEL = 0x44;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_VSM"]/*' />
    [NativeTypeName("#define FACILITY_VSM 0x45")]
    public const int FACILITY_VSM = 0x45;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_NT_IORING"]/*' />
    [NativeTypeName("#define FACILITY_NT_IORING 0x46")]
    public const int FACILITY_NT_IORING = 0x46;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_VOLSNAP"]/*' />
    [NativeTypeName("#define FACILITY_VOLSNAP 0x50")]
    public const int FACILITY_VOLSNAP = 0x50;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SDBUS"]/*' />
    [NativeTypeName("#define FACILITY_SDBUS 0x51")]
    public const int FACILITY_SDBUS = 0x51;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SHARED_VHDX"]/*' />
    [NativeTypeName("#define FACILITY_SHARED_VHDX 0x5C")]
    public const int FACILITY_SHARED_VHDX = 0x5C;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SMB"]/*' />
    [NativeTypeName("#define FACILITY_SMB 0x5D")]
    public const int FACILITY_SMB = 0x5D;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_XVS"]/*' />
    [NativeTypeName("#define FACILITY_XVS 0x5E")]
    public const int FACILITY_XVS = 0x5E;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_INTERIX"]/*' />
    [NativeTypeName("#define FACILITY_INTERIX 0x99")]
    public const int FACILITY_INTERIX = 0x99;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SPACES"]/*' />
    [NativeTypeName("#define FACILITY_SPACES 0xE7")]
    public const int FACILITY_SPACES = 0xE7;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SECURITY_CORE"]/*' />
    [NativeTypeName("#define FACILITY_SECURITY_CORE 0xE8")]
    public const int FACILITY_SECURITY_CORE = 0xE8;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SYSTEM_INTEGRITY"]/*' />
    [NativeTypeName("#define FACILITY_SYSTEM_INTEGRITY 0xE9")]
    public const int FACILITY_SYSTEM_INTEGRITY = 0xE9;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_LICENSING"]/*' />
    [NativeTypeName("#define FACILITY_LICENSING 0xEA")]
    public const int FACILITY_LICENSING = 0xEA;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_PLATFORM_MANIFEST"]/*' />
    [NativeTypeName("#define FACILITY_PLATFORM_MANIFEST 0xEB")]
    public const int FACILITY_PLATFORM_MANIFEST = 0xEB;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_APP_EXEC"]/*' />
    [NativeTypeName("#define FACILITY_APP_EXEC 0xEC")]
    public const int FACILITY_APP_EXEC = 0xEC;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_UNIONFS"]/*' />
    [NativeTypeName("#define FACILITY_UNIONFS 0xED")]
    public const int FACILITY_UNIONFS = 0xED;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_PLATFORM_RUNTIME_MECHANISM"]/*' />
    [NativeTypeName("#define FACILITY_PLATFORM_RUNTIME_MECHANISM 0xEE")]
    public const int FACILITY_PLATFORM_RUNTIME_MECHANISM = 0xEE;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WIN_ACCEL"]/*' />
    [NativeTypeName("#define FACILITY_WIN_ACCEL 0xEF")]
    public const int FACILITY_WIN_ACCEL = 0xEF;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_MAXIMUM_VALUE"]/*' />
    [NativeTypeName("#define FACILITY_MAXIMUM_VALUE 0xF0")]
    public const int FACILITY_MAXIMUM_VALUE = 0xF0;
}
