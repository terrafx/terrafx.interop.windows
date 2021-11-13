// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MDMRegistration.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [SupportedOSPlatform("windows8.1")]
        [DllImport("mdmregistration", ExactSpelling = true)]
        public static extern HRESULT GetDeviceRegistrationInfo(REGISTRATION_INFORMATION_CLASS DeviceInformationClass, [NativeTypeName("PVOID *")] void** ppDeviceRegistrationInfo);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("mdmregistration", ExactSpelling = true)]
        public static extern HRESULT IsDeviceRegisteredWithManagement(BOOL* pfIsDeviceRegisteredWithManagement, [NativeTypeName("DWORD")] uint cchUPN, [NativeTypeName("LPWSTR")] ushort* pszUPN);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("mdmregistration", ExactSpelling = true)]
        public static extern HRESULT IsManagementRegistrationAllowed(BOOL* pfIsManagementRegistrationAllowed);

        [DllImport("mdmregistration", ExactSpelling = true)]
        public static extern HRESULT IsMdmUxWithoutAadAllowed(BOOL* isEnrollmentAllowed);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("mdmregistration", ExactSpelling = true)]
        public static extern HRESULT SetManagedExternally(BOOL IsManagedExternally);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("mdmregistration", ExactSpelling = true)]
        public static extern HRESULT DiscoverManagementService([NativeTypeName("LPCWSTR")] ushort* pszUPN, [NativeTypeName("PMANAGEMENT_SERVICE_INFO *")] MANAGEMENT_SERVICE_INFO** ppMgmtInfo);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("mdmregistration", ExactSpelling = true)]
        public static extern HRESULT RegisterDeviceWithManagementUsingAADCredentials(HANDLE UserToken);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("mdmregistration", ExactSpelling = true)]
        public static extern HRESULT RegisterDeviceWithManagementUsingAADDeviceCredentials();

        [DllImport("mdmregistration", ExactSpelling = true)]
        public static extern HRESULT RegisterDeviceWithManagementUsingAADDeviceCredentials2([NativeTypeName("PCWSTR")] ushort* MDMApplicationID);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("mdmregistration", ExactSpelling = true)]
        public static extern HRESULT RegisterDeviceWithManagement([NativeTypeName("LPCWSTR")] ushort* pszUPN, [NativeTypeName("LPCWSTR")] ushort* ppszMDMServiceUri, [NativeTypeName("LPCWSTR")] ushort* ppzsAccessToken);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("mdmregistration", ExactSpelling = true)]
        public static extern HRESULT UnregisterDeviceWithManagement([NativeTypeName("LPCWSTR")] ushort* enrollmentID);

        [DllImport("mdmregistration", ExactSpelling = true)]
        public static extern HRESULT GetDeviceManagementConfigInfo([NativeTypeName("PCWSTR")] ushort* providerID, [NativeTypeName("DWORD *")] uint* configStringBufferLength, [NativeTypeName("PWSTR")] ushort* configString);

        [DllImport("mdmregistration", ExactSpelling = true)]
        public static extern HRESULT SetDeviceManagementConfigInfo([NativeTypeName("PCWSTR")] ushort* providerID, [NativeTypeName("PCWSTR")] ushort* configString);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("mdmregistration", ExactSpelling = true)]
        public static extern HRESULT GetManagementAppHyperlink([NativeTypeName("DWORD")] uint cchHyperlink, [NativeTypeName("LPWSTR")] ushort* pszHyperlink);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("mdmregistration", ExactSpelling = true)]
        public static extern HRESULT DiscoverManagementServiceEx([NativeTypeName("LPCWSTR")] ushort* pszUPN, [NativeTypeName("LPCWSTR")] ushort* pszDiscoveryServiceCandidate, [NativeTypeName("PMANAGEMENT_SERVICE_INFO *")] MANAGEMENT_SERVICE_INFO** ppMgmtInfo);

        [NativeTypeName("#define E_DATATYPE_MISMATCH HRESULT_FROM_WIN32(ERROR_DATATYPE_MISMATCH)")]
        public static HRESULT E_DATATYPE_MISMATCH => HRESULT_FROM_WIN32(1629);

        [NativeTypeName("#define MDM_REGISTRATION_FACILITY_CODE 25")]
        public const int MDM_REGISTRATION_FACILITY_CODE = 25;

        [NativeTypeName("#define DEVICE_ENROLLER_FACILITY_CODE 24")]
        public const int DEVICE_ENROLLER_FACILITY_CODE = 24;

        [NativeTypeName("#define MREGISTER_E_DEVICE_MESSAGE_FORMAT_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 1)")]
        public const int MREGISTER_E_DEVICE_MESSAGE_FORMAT_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(1))));

        [NativeTypeName("#define MREGISTER_E_DEVICE_AUTHENTICATION_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 2)")]
        public const int MREGISTER_E_DEVICE_AUTHENTICATION_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(2))));

        [NativeTypeName("#define MREGISTER_E_DEVICE_AUTHORIZATION_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 3)")]
        public const int MREGISTER_E_DEVICE_AUTHORIZATION_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(3))));

        [NativeTypeName("#define MREGISTER_E_DEVICE_CERTIFCATEREQUEST_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 4)")]
        public const int MREGISTER_E_DEVICE_CERTIFCATEREQUEST_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(4))));

        [NativeTypeName("#define MENROLL_E_DEVICE_CERTIFCATEREQUEST_ERROR MAKE_HRESULT(SEVERITY_ERROR, DEVICE_ENROLLER_FACILITY_CODE, 4)")]
        public const int MENROLL_E_DEVICE_CERTIFCATEREQUEST_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(24) << 16) | ((uint)(4))));

        [NativeTypeName("#define MREGISTER_E_DEVICE_CONFIGMGRSERVER_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 5)")]
        public const int MREGISTER_E_DEVICE_CONFIGMGRSERVER_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(5))));

        [NativeTypeName("#define MREGISTER_E_DEVICE_INTERNALSERVICE_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 6)")]
        public const int MREGISTER_E_DEVICE_INTERNALSERVICE_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(6))));

        [NativeTypeName("#define MREGISTER_E_DEVICE_INVALIDSECURITY_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 7)")]
        public const int MREGISTER_E_DEVICE_INVALIDSECURITY_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(7))));

        [NativeTypeName("#define MREGISTER_E_DEVICE_UNKNOWN_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 8)")]
        public const int MREGISTER_E_DEVICE_UNKNOWN_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(8))));

        [NativeTypeName("#define MREGISTER_E_REGISTRATION_IN_PROGRESS MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 9)")]
        public const int MREGISTER_E_REGISTRATION_IN_PROGRESS = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(9))));

        [NativeTypeName("#define MREGISTER_E_DEVICE_ALREADY_REGISTERED MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 10)")]
        public const int MREGISTER_E_DEVICE_ALREADY_REGISTERED = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(10))));

        [NativeTypeName("#define MREGISTER_E_DEVICE_NOT_REGISTERED MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 11)")]
        public const int MREGISTER_E_DEVICE_NOT_REGISTERED = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(11))));

        [NativeTypeName("#define MENROLL_E_DEVICE_NOT_ENROLLED MAKE_HRESULT(SEVERITY_ERROR, DEVICE_ENROLLER_FACILITY_CODE, 11)")]
        public const int MENROLL_E_DEVICE_NOT_ENROLLED = unchecked((int)(((uint)(1) << 31) | ((uint)(24) << 16) | ((uint)(11))));

        [NativeTypeName("#define MREGISTER_E_DISCOVERY_REDIRECTED MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 12)")]
        public const int MREGISTER_E_DISCOVERY_REDIRECTED = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(12))));

        [NativeTypeName("#define MREGISTER_E_DEVICE_NOT_AD_REGISTERED_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 13)")]
        public const int MREGISTER_E_DEVICE_NOT_AD_REGISTERED_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(13))));

        [NativeTypeName("#define MREGISTER_E_DISCOVERY_FAILED MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 14)")]
        public const int MREGISTER_E_DISCOVERY_FAILED = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(14))));

        [NativeTypeName("#define MENROLL_E_DEVICECAPREACHED MAKE_HRESULT(SEVERITY_ERROR, DEVICE_ENROLLER_FACILITY_CODE, 19)")]
        public const int MENROLL_E_DEVICECAPREACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(24) << 16) | ((uint)(19))));

        [NativeTypeName("#define MENROLL_E_NOTSUPPORTED MAKE_HRESULT(SEVERITY_ERROR, DEVICE_ENROLLER_FACILITY_CODE, 21)")]
        public const int MENROLL_E_NOTSUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(24) << 16) | ((uint)(21))));

        [NativeTypeName("#define MENROLL_E_USERLICENSE MAKE_HRESULT(SEVERITY_ERROR, DEVICE_ENROLLER_FACILITY_CODE, 24)")]
        public const int MENROLL_E_USERLICENSE = unchecked((int)(((uint)(1) << 31) | ((uint)(24) << 16) | ((uint)(24))));

        [NativeTypeName("#define MENROLL_E_USER_CANCELED MAKE_HRESULT(SEVERITY_ERROR, DEVICE_ENROLLER_FACILITY_CODE, 42)")]
        public const int MENROLL_E_USER_CANCELED = unchecked((int)(((uint)(1) << 31) | ((uint)(24) << 16) | ((uint)(42))));

        [NativeTypeName("#define DEVICEREGISTRATIONTYPE_MDM_ONLY 0")]
        public const int DEVICEREGISTRATIONTYPE_MDM_ONLY = 0;

        [NativeTypeName("#define DEVICEREGISTRATIONTYPE_MAM 5")]
        public const int DEVICEREGISTRATIONTYPE_MAM = 5;

        [NativeTypeName("#define DEVICEREGISTRATIONTYPE_MDM_DEVICEWIDE_WITH_AAD 6")]
        public const int DEVICEREGISTRATIONTYPE_MDM_DEVICEWIDE_WITH_AAD = 6;

        [NativeTypeName("#define DEVICEREGISTRATIONTYPE_MDM_USERSPECIFIC_WITH_AAD 13")]
        public const int DEVICEREGISTRATIONTYPE_MDM_USERSPECIFIC_WITH_AAD = 13;
    }
}
