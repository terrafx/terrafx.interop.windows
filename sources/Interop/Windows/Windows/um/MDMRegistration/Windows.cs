// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MDMRegistration.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

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

        [NativeTypeName("#define MDM_REGISTRATION_FACILITY_CODE 25")]
        public const int MDM_REGISTRATION_FACILITY_CODE = 25;

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
