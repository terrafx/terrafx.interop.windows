// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FACILITY
{
    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_NULL"]/*' />
    [NativeTypeName("#define FACILITY_NULL 0")]
    public const int FACILITY_NULL = 0;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_RPC"]/*' />
    [NativeTypeName("#define FACILITY_RPC 1")]
    public const int FACILITY_RPC = 1;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DISPATCH"]/*' />
    [NativeTypeName("#define FACILITY_DISPATCH 2")]
    public const int FACILITY_DISPATCH = 2;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_STORAGE"]/*' />
    [NativeTypeName("#define FACILITY_STORAGE 3")]
    public const int FACILITY_STORAGE = 3;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_ITF"]/*' />
    [NativeTypeName("#define FACILITY_ITF 4")]
    public const int FACILITY_ITF = 4;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WIN32"]/*' />
    [NativeTypeName("#define FACILITY_WIN32 7")]
    public const int FACILITY_WIN32 = 7;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WINDOWS"]/*' />
    [NativeTypeName("#define FACILITY_WINDOWS 8")]
    public const int FACILITY_WINDOWS = 8;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SSPI"]/*' />
    [NativeTypeName("#define FACILITY_SSPI 9")]
    public const int FACILITY_SSPI = 9;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SECURITY"]/*' />
    [NativeTypeName("#define FACILITY_SECURITY 9")]
    public const int FACILITY_SECURITY = 9;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_CONTROL"]/*' />
    [NativeTypeName("#define FACILITY_CONTROL 10")]
    public const int FACILITY_CONTROL = 10;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_CERT"]/*' />
    [NativeTypeName("#define FACILITY_CERT 11")]
    public const int FACILITY_CERT = 11;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_INTERNET"]/*' />
    [NativeTypeName("#define FACILITY_INTERNET 12")]
    public const int FACILITY_INTERNET = 12;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_MEDIASERVER"]/*' />
    [NativeTypeName("#define FACILITY_MEDIASERVER 13")]
    public const int FACILITY_MEDIASERVER = 13;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_MSMQ"]/*' />
    [NativeTypeName("#define FACILITY_MSMQ 14")]
    public const int FACILITY_MSMQ = 14;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SETUPAPI"]/*' />
    [NativeTypeName("#define FACILITY_SETUPAPI 15")]
    public const int FACILITY_SETUPAPI = 15;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SCARD"]/*' />
    [NativeTypeName("#define FACILITY_SCARD 16")]
    public const int FACILITY_SCARD = 16;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_COMPLUS"]/*' />
    [NativeTypeName("#define FACILITY_COMPLUS 17")]
    public const int FACILITY_COMPLUS = 17;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_AAF"]/*' />
    [NativeTypeName("#define FACILITY_AAF 18")]
    public const int FACILITY_AAF = 18;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_URT"]/*' />
    [NativeTypeName("#define FACILITY_URT 19")]
    public const int FACILITY_URT = 19;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_ACS"]/*' />
    [NativeTypeName("#define FACILITY_ACS 20")]
    public const int FACILITY_ACS = 20;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DPLAY"]/*' />
    [NativeTypeName("#define FACILITY_DPLAY 21")]
    public const int FACILITY_DPLAY = 21;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_UMI"]/*' />
    [NativeTypeName("#define FACILITY_UMI 22")]
    public const int FACILITY_UMI = 22;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SXS"]/*' />
    [NativeTypeName("#define FACILITY_SXS 23")]
    public const int FACILITY_SXS = 23;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WINDOWS_CE"]/*' />
    [NativeTypeName("#define FACILITY_WINDOWS_CE 24")]
    public const int FACILITY_WINDOWS_CE = 24;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_HTTP"]/*' />
    [NativeTypeName("#define FACILITY_HTTP 25")]
    public const int FACILITY_HTTP = 25;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USERMODE_COMMONLOG"]/*' />
    [NativeTypeName("#define FACILITY_USERMODE_COMMONLOG 26")]
    public const int FACILITY_USERMODE_COMMONLOG = 26;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WER"]/*' />
    [NativeTypeName("#define FACILITY_WER 27")]
    public const int FACILITY_WER = 27;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USERMODE_FILTER_MANAGER"]/*' />
    [NativeTypeName("#define FACILITY_USERMODE_FILTER_MANAGER 31")]
    public const int FACILITY_USERMODE_FILTER_MANAGER = 31;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_BACKGROUNDCOPY"]/*' />
    [NativeTypeName("#define FACILITY_BACKGROUNDCOPY 32")]
    public const int FACILITY_BACKGROUNDCOPY = 32;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_CONFIGURATION"]/*' />
    [NativeTypeName("#define FACILITY_CONFIGURATION 33")]
    public const int FACILITY_CONFIGURATION = 33;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WIA"]/*' />
    [NativeTypeName("#define FACILITY_WIA 33")]
    public const int FACILITY_WIA = 33;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_STATE_MANAGEMENT"]/*' />
    [NativeTypeName("#define FACILITY_STATE_MANAGEMENT 34")]
    public const int FACILITY_STATE_MANAGEMENT = 34;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_METADIRECTORY"]/*' />
    [NativeTypeName("#define FACILITY_METADIRECTORY 35")]
    public const int FACILITY_METADIRECTORY = 35;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WINDOWSUPDATE"]/*' />
    [NativeTypeName("#define FACILITY_WINDOWSUPDATE 36")]
    public const int FACILITY_WINDOWSUPDATE = 36;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DIRECTORYSERVICE"]/*' />
    [NativeTypeName("#define FACILITY_DIRECTORYSERVICE 37")]
    public const int FACILITY_DIRECTORYSERVICE = 37;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_GRAPHICS"]/*' />
    [NativeTypeName("#define FACILITY_GRAPHICS 38")]
    public const int FACILITY_GRAPHICS = 38;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SHELL"]/*' />
    [NativeTypeName("#define FACILITY_SHELL 39")]
    public const int FACILITY_SHELL = 39;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_NAP"]/*' />
    [NativeTypeName("#define FACILITY_NAP 39")]
    public const int FACILITY_NAP = 39;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_TPM_SERVICES"]/*' />
    [NativeTypeName("#define FACILITY_TPM_SERVICES 40")]
    public const int FACILITY_TPM_SERVICES = 40;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_TPM_SOFTWARE"]/*' />
    [NativeTypeName("#define FACILITY_TPM_SOFTWARE 41")]
    public const int FACILITY_TPM_SOFTWARE = 41;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_UI"]/*' />
    [NativeTypeName("#define FACILITY_UI 42")]
    public const int FACILITY_UI = 42;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_XAML"]/*' />
    [NativeTypeName("#define FACILITY_XAML 43")]
    public const int FACILITY_XAML = 43;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_ACTION_QUEUE"]/*' />
    [NativeTypeName("#define FACILITY_ACTION_QUEUE 44")]
    public const int FACILITY_ACTION_QUEUE = 44;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_PLA"]/*' />
    [NativeTypeName("#define FACILITY_PLA 48")]
    public const int FACILITY_PLA = 48;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WINDOWS_SETUP"]/*' />
    [NativeTypeName("#define FACILITY_WINDOWS_SETUP 48")]
    public const int FACILITY_WINDOWS_SETUP = 48;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_FVE"]/*' />
    [NativeTypeName("#define FACILITY_FVE 49")]
    public const int FACILITY_FVE = 49;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_FWP"]/*' />
    [NativeTypeName("#define FACILITY_FWP 50")]
    public const int FACILITY_FWP = 50;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WINRM"]/*' />
    [NativeTypeName("#define FACILITY_WINRM 51")]
    public const int FACILITY_WINRM = 51;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_NDIS"]/*' />
    [NativeTypeName("#define FACILITY_NDIS 52")]
    public const int FACILITY_NDIS = 52;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USERMODE_HYPERVISOR"]/*' />
    [NativeTypeName("#define FACILITY_USERMODE_HYPERVISOR 53")]
    public const int FACILITY_USERMODE_HYPERVISOR = 53;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_CMI"]/*' />
    [NativeTypeName("#define FACILITY_CMI 54")]
    public const int FACILITY_CMI = 54;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USERMODE_VIRTUALIZATION"]/*' />
    [NativeTypeName("#define FACILITY_USERMODE_VIRTUALIZATION 55")]
    public const int FACILITY_USERMODE_VIRTUALIZATION = 55;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USERMODE_VOLMGR"]/*' />
    [NativeTypeName("#define FACILITY_USERMODE_VOLMGR 56")]
    public const int FACILITY_USERMODE_VOLMGR = 56;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_BCD"]/*' />
    [NativeTypeName("#define FACILITY_BCD 57")]
    public const int FACILITY_BCD = 57;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USERMODE_VHD"]/*' />
    [NativeTypeName("#define FACILITY_USERMODE_VHD 58")]
    public const int FACILITY_USERMODE_VHD = 58;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USERMODE_HNS"]/*' />
    [NativeTypeName("#define FACILITY_USERMODE_HNS 59")]
    public const int FACILITY_USERMODE_HNS = 59;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SDIAG"]/*' />
    [NativeTypeName("#define FACILITY_SDIAG 60")]
    public const int FACILITY_SDIAG = 60;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WEBSERVICES"]/*' />
    [NativeTypeName("#define FACILITY_WEBSERVICES 61")]
    public const int FACILITY_WEBSERVICES = 61;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WINPE"]/*' />
    [NativeTypeName("#define FACILITY_WINPE 61")]
    public const int FACILITY_WINPE = 61;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WPN"]/*' />
    [NativeTypeName("#define FACILITY_WPN 62")]
    public const int FACILITY_WPN = 62;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WINDOWS_STORE"]/*' />
    [NativeTypeName("#define FACILITY_WINDOWS_STORE 63")]
    public const int FACILITY_WINDOWS_STORE = 63;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_INPUT"]/*' />
    [NativeTypeName("#define FACILITY_INPUT 64")]
    public const int FACILITY_INPUT = 64;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_QUIC"]/*' />
    [NativeTypeName("#define FACILITY_QUIC 65")]
    public const int FACILITY_QUIC = 65;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_EAP"]/*' />
    [NativeTypeName("#define FACILITY_EAP 66")]
    public const int FACILITY_EAP = 66;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_IORING"]/*' />
    [NativeTypeName("#define FACILITY_IORING 70")]
    public const int FACILITY_IORING = 70;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WINDOWS_DEFENDER"]/*' />
    [NativeTypeName("#define FACILITY_WINDOWS_DEFENDER 80")]
    public const int FACILITY_WINDOWS_DEFENDER = 80;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_OPC"]/*' />
    [NativeTypeName("#define FACILITY_OPC 81")]
    public const int FACILITY_OPC = 81;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_XPS"]/*' />
    [NativeTypeName("#define FACILITY_XPS 82")]
    public const int FACILITY_XPS = 82;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_MBN"]/*' />
    [NativeTypeName("#define FACILITY_MBN 84")]
    public const int FACILITY_MBN = 84;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_POWERSHELL"]/*' />
    [NativeTypeName("#define FACILITY_POWERSHELL 84")]
    public const int FACILITY_POWERSHELL = 84;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_RAS"]/*' />
    [NativeTypeName("#define FACILITY_RAS 83")]
    public const int FACILITY_RAS = 83;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_P2P_INT"]/*' />
    [NativeTypeName("#define FACILITY_P2P_INT 98")]
    public const int FACILITY_P2P_INT = 98;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_P2P"]/*' />
    [NativeTypeName("#define FACILITY_P2P 99")]
    public const int FACILITY_P2P = 99;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DAF"]/*' />
    [NativeTypeName("#define FACILITY_DAF 100")]
    public const int FACILITY_DAF = 100;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_BLUETOOTH_ATT"]/*' />
    [NativeTypeName("#define FACILITY_BLUETOOTH_ATT 101")]
    public const int FACILITY_BLUETOOTH_ATT = 101;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_AUDIO"]/*' />
    [NativeTypeName("#define FACILITY_AUDIO 102")]
    public const int FACILITY_AUDIO = 102;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_STATEREPOSITORY"]/*' />
    [NativeTypeName("#define FACILITY_STATEREPOSITORY 103")]
    public const int FACILITY_STATEREPOSITORY = 103;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_VISUALCPP"]/*' />
    [NativeTypeName("#define FACILITY_VISUALCPP 109")]
    public const int FACILITY_VISUALCPP = 109;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SCRIPT"]/*' />
    [NativeTypeName("#define FACILITY_SCRIPT 112")]
    public const int FACILITY_SCRIPT = 112;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_PARSE"]/*' />
    [NativeTypeName("#define FACILITY_PARSE 113")]
    public const int FACILITY_PARSE = 113;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_BLB"]/*' />
    [NativeTypeName("#define FACILITY_BLB 120")]
    public const int FACILITY_BLB = 120;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_BLB_CLI"]/*' />
    [NativeTypeName("#define FACILITY_BLB_CLI 121")]
    public const int FACILITY_BLB_CLI = 121;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WSBAPP"]/*' />
    [NativeTypeName("#define FACILITY_WSBAPP 122")]
    public const int FACILITY_WSBAPP = 122;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_BLBUI"]/*' />
    [NativeTypeName("#define FACILITY_BLBUI 128")]
    public const int FACILITY_BLBUI = 128;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USN"]/*' />
    [NativeTypeName("#define FACILITY_USN 129")]
    public const int FACILITY_USN = 129;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USERMODE_VOLSNAP"]/*' />
    [NativeTypeName("#define FACILITY_USERMODE_VOLSNAP 130")]
    public const int FACILITY_USERMODE_VOLSNAP = 130;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_TIERING"]/*' />
    [NativeTypeName("#define FACILITY_TIERING 131")]
    public const int FACILITY_TIERING = 131;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WSB_ONLINE"]/*' />
    [NativeTypeName("#define FACILITY_WSB_ONLINE 133")]
    public const int FACILITY_WSB_ONLINE = 133;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_ONLINE_ID"]/*' />
    [NativeTypeName("#define FACILITY_ONLINE_ID 134")]
    public const int FACILITY_ONLINE_ID = 134;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEVICE_UPDATE_AGENT"]/*' />
    [NativeTypeName("#define FACILITY_DEVICE_UPDATE_AGENT 135")]
    public const int FACILITY_DEVICE_UPDATE_AGENT = 135;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DRVSERVICING"]/*' />
    [NativeTypeName("#define FACILITY_DRVSERVICING 136")]
    public const int FACILITY_DRVSERVICING = 136;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DLS"]/*' />
    [NativeTypeName("#define FACILITY_DLS 153")]
    public const int FACILITY_DLS = 153;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DELIVERY_OPTIMIZATION"]/*' />
    [NativeTypeName("#define FACILITY_DELIVERY_OPTIMIZATION 208")]
    public const int FACILITY_DELIVERY_OPTIMIZATION = 208;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USERMODE_SPACES"]/*' />
    [NativeTypeName("#define FACILITY_USERMODE_SPACES 231")]
    public const int FACILITY_USERMODE_SPACES = 231;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USER_MODE_SECURITY_CORE"]/*' />
    [NativeTypeName("#define FACILITY_USER_MODE_SECURITY_CORE 232")]
    public const int FACILITY_USER_MODE_SECURITY_CORE = 232;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USERMODE_LICENSING"]/*' />
    [NativeTypeName("#define FACILITY_USERMODE_LICENSING 234")]
    public const int FACILITY_USERMODE_LICENSING = 234;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SOS"]/*' />
    [NativeTypeName("#define FACILITY_SOS 160")]
    public const int FACILITY_SOS = 160;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_OCP_UPDATE_AGENT"]/*' />
    [NativeTypeName("#define FACILITY_OCP_UPDATE_AGENT 173")]
    public const int FACILITY_OCP_UPDATE_AGENT = 173;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEBUGGERS"]/*' />
    [NativeTypeName("#define FACILITY_DEBUGGERS 176")]
    public const int FACILITY_DEBUGGERS = 176;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SPP"]/*' />
    [NativeTypeName("#define FACILITY_SPP 256")]
    public const int FACILITY_SPP = 256;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_RESTORE"]/*' />
    [NativeTypeName("#define FACILITY_RESTORE 256")]
    public const int FACILITY_RESTORE = 256;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DMSERVER"]/*' />
    [NativeTypeName("#define FACILITY_DMSERVER 256")]
    public const int FACILITY_DMSERVER = 256;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEPLOYMENT_SERVICES_SERVER"]/*' />
    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_SERVER 257")]
    public const int FACILITY_DEPLOYMENT_SERVICES_SERVER = 257;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEPLOYMENT_SERVICES_IMAGING"]/*' />
    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_IMAGING 258")]
    public const int FACILITY_DEPLOYMENT_SERVICES_IMAGING = 258;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEPLOYMENT_SERVICES_MANAGEMENT"]/*' />
    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_MANAGEMENT 259")]
    public const int FACILITY_DEPLOYMENT_SERVICES_MANAGEMENT = 259;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEPLOYMENT_SERVICES_UTIL"]/*' />
    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_UTIL 260")]
    public const int FACILITY_DEPLOYMENT_SERVICES_UTIL = 260;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEPLOYMENT_SERVICES_BINLSVC"]/*' />
    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_BINLSVC 261")]
    public const int FACILITY_DEPLOYMENT_SERVICES_BINLSVC = 261;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEPLOYMENT_SERVICES_PXE"]/*' />
    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_PXE 263")]
    public const int FACILITY_DEPLOYMENT_SERVICES_PXE = 263;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEPLOYMENT_SERVICES_TFTP"]/*' />
    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_TFTP 264")]
    public const int FACILITY_DEPLOYMENT_SERVICES_TFTP = 264;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEPLOYMENT_SERVICES_TRANSPORT_MANAGEMENT"]/*' />
    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_TRANSPORT_MANAGEMENT 272")]
    public const int FACILITY_DEPLOYMENT_SERVICES_TRANSPORT_MANAGEMENT = 272;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEPLOYMENT_SERVICES_DRIVER_PROVISIONING"]/*' />
    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_DRIVER_PROVISIONING 278")]
    public const int FACILITY_DEPLOYMENT_SERVICES_DRIVER_PROVISIONING = 278;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEPLOYMENT_SERVICES_MULTICAST_SERVER"]/*' />
    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_MULTICAST_SERVER 289")]
    public const int FACILITY_DEPLOYMENT_SERVICES_MULTICAST_SERVER = 289;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEPLOYMENT_SERVICES_MULTICAST_CLIENT"]/*' />
    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_MULTICAST_CLIENT 290")]
    public const int FACILITY_DEPLOYMENT_SERVICES_MULTICAST_CLIENT = 290;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEPLOYMENT_SERVICES_CONTENT_PROVIDER"]/*' />
    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_CONTENT_PROVIDER 293")]
    public const int FACILITY_DEPLOYMENT_SERVICES_CONTENT_PROVIDER = 293;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_HSP_SERVICES"]/*' />
    [NativeTypeName("#define FACILITY_HSP_SERVICES 296")]
    public const int FACILITY_HSP_SERVICES = 296;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_HSP_SOFTWARE"]/*' />
    [NativeTypeName("#define FACILITY_HSP_SOFTWARE 297")]
    public const int FACILITY_HSP_SOFTWARE = 297;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_LINGUISTIC_SERVICES"]/*' />
    [NativeTypeName("#define FACILITY_LINGUISTIC_SERVICES 305")]
    public const int FACILITY_LINGUISTIC_SERVICES = 305;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_AUDIOSTREAMING"]/*' />
    [NativeTypeName("#define FACILITY_AUDIOSTREAMING 1094")]
    public const int FACILITY_AUDIOSTREAMING = 1094;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_TTD"]/*' />
    [NativeTypeName("#define FACILITY_TTD 1490")]
    public const int FACILITY_TTD = 1490;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_ACCELERATOR"]/*' />
    [NativeTypeName("#define FACILITY_ACCELERATOR 1536")]
    public const int FACILITY_ACCELERATOR = 1536;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WMAAECMA"]/*' />
    [NativeTypeName("#define FACILITY_WMAAECMA 1996")]
    public const int FACILITY_WMAAECMA = 1996;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DIRECTMUSIC"]/*' />
    [NativeTypeName("#define FACILITY_DIRECTMUSIC 2168")]
    public const int FACILITY_DIRECTMUSIC = 2168;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DIRECT3D10"]/*' />
    [NativeTypeName("#define FACILITY_DIRECT3D10 2169")]
    public const int FACILITY_DIRECT3D10 = 2169;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DXGI"]/*' />
    [NativeTypeName("#define FACILITY_DXGI 2170")]
    public const int FACILITY_DXGI = 2170;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DXGI_DDI"]/*' />
    [NativeTypeName("#define FACILITY_DXGI_DDI 2171")]
    public const int FACILITY_DXGI_DDI = 2171;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DIRECT3D11"]/*' />
    [NativeTypeName("#define FACILITY_DIRECT3D11 2172")]
    public const int FACILITY_DIRECT3D11 = 2172;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DIRECT3D11_DEBUG"]/*' />
    [NativeTypeName("#define FACILITY_DIRECT3D11_DEBUG 2173")]
    public const int FACILITY_DIRECT3D11_DEBUG = 2173;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DIRECT3D12"]/*' />
    [NativeTypeName("#define FACILITY_DIRECT3D12 2174")]
    public const int FACILITY_DIRECT3D12 = 2174;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DIRECT3D12_DEBUG"]/*' />
    [NativeTypeName("#define FACILITY_DIRECT3D12_DEBUG 2175")]
    public const int FACILITY_DIRECT3D12_DEBUG = 2175;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DXCORE"]/*' />
    [NativeTypeName("#define FACILITY_DXCORE 2176")]
    public const int FACILITY_DXCORE = 2176;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_PRESENTATION"]/*' />
    [NativeTypeName("#define FACILITY_PRESENTATION 2177")]
    public const int FACILITY_PRESENTATION = 2177;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_LEAP"]/*' />
    [NativeTypeName("#define FACILITY_LEAP 2184")]
    public const int FACILITY_LEAP = 2184;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_AUDCLNT"]/*' />
    [NativeTypeName("#define FACILITY_AUDCLNT 2185")]
    public const int FACILITY_AUDCLNT = 2185;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WINCODEC_DWRITE_DWM"]/*' />
    [NativeTypeName("#define FACILITY_WINCODEC_DWRITE_DWM 2200")]
    public const int FACILITY_WINCODEC_DWRITE_DWM = 2200;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WINML"]/*' />
    [NativeTypeName("#define FACILITY_WINML 2192")]
    public const int FACILITY_WINML = 2192;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DIRECT2D"]/*' />
    [NativeTypeName("#define FACILITY_DIRECT2D 2201")]
    public const int FACILITY_DIRECT2D = 2201;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_DEFRAG"]/*' />
    [NativeTypeName("#define FACILITY_DEFRAG 2304")]
    public const int FACILITY_DEFRAG = 2304;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USERMODE_SDBUS"]/*' />
    [NativeTypeName("#define FACILITY_USERMODE_SDBUS 2305")]
    public const int FACILITY_USERMODE_SDBUS = 2305;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_JSCRIPT"]/*' />
    [NativeTypeName("#define FACILITY_JSCRIPT 2306")]
    public const int FACILITY_JSCRIPT = 2306;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_PIDGENX"]/*' />
    [NativeTypeName("#define FACILITY_PIDGENX 2561")]
    public const int FACILITY_PIDGENX = 2561;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_EAS"]/*' />
    [NativeTypeName("#define FACILITY_EAS 85")]
    public const int FACILITY_EAS = 85;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WEB"]/*' />
    [NativeTypeName("#define FACILITY_WEB 885")]
    public const int FACILITY_WEB = 885;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WEB_SOCKET"]/*' />
    [NativeTypeName("#define FACILITY_WEB_SOCKET 886")]
    public const int FACILITY_WEB_SOCKET = 886;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_MOBILE"]/*' />
    [NativeTypeName("#define FACILITY_MOBILE 1793")]
    public const int FACILITY_MOBILE = 1793;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SQLITE"]/*' />
    [NativeTypeName("#define FACILITY_SQLITE 1967")]
    public const int FACILITY_SQLITE = 1967;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SERVICE_FABRIC"]/*' />
    [NativeTypeName("#define FACILITY_SERVICE_FABRIC 1968")]
    public const int FACILITY_SERVICE_FABRIC = 1968;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_UTC"]/*' />
    [NativeTypeName("#define FACILITY_UTC 1989")]
    public const int FACILITY_UTC = 1989;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_WEP"]/*' />
    [NativeTypeName("#define FACILITY_WEP 2049")]
    public const int FACILITY_WEP = 2049;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_SYNCENGINE"]/*' />
    [NativeTypeName("#define FACILITY_SYNCENGINE 2050")]
    public const int FACILITY_SYNCENGINE = 2050;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_XBOX"]/*' />
    [NativeTypeName("#define FACILITY_XBOX 2339")]
    public const int FACILITY_XBOX = 2339;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_GAME"]/*' />
    [NativeTypeName("#define FACILITY_GAME 2340")]
    public const int FACILITY_GAME = 2340;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USERMODE_UNIONFS"]/*' />
    [NativeTypeName("#define FACILITY_USERMODE_UNIONFS 2341")]
    public const int FACILITY_USERMODE_UNIONFS = 2341;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USERMODE_PRM"]/*' />
    [NativeTypeName("#define FACILITY_USERMODE_PRM 2342")]
    public const int FACILITY_USERMODE_PRM = 2342;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_USERMODE_WIN_ACCEL"]/*' />
    [NativeTypeName("#define FACILITY_USERMODE_WIN_ACCEL 2343")]
    public const int FACILITY_USERMODE_WIN_ACCEL = 2343;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_PPF"]/*' />
    [NativeTypeName("#define FACILITY_PPF 2344")]
    public const int FACILITY_PPF = 2344;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_PIX"]/*' />
    [NativeTypeName("#define FACILITY_PIX 2748")]
    public const int FACILITY_PIX = 2748;

    /// <include file='FACILITY.xml' path='doc/member[@name="FACILITY.FACILITY_NT_BIT"]/*' />
    [NativeTypeName("#define FACILITY_NT_BIT 0x10000000")]
    public const int FACILITY_NT_BIT = 0x10000000;
}
