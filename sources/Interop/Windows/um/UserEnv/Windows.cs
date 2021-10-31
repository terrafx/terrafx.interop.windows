// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL LoadUserProfileA(HANDLE hToken, [NativeTypeName("LPPROFILEINFOA")] PROFILEINFOA* lpProfileInfo);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL LoadUserProfileW(HANDLE hToken, [NativeTypeName("LPPROFILEINFOW")] PROFILEINFOW* lpProfileInfo);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnloadUserProfile(HANDLE hToken, HANDLE hProfile);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetProfilesDirectoryA([NativeTypeName("LPSTR")] sbyte* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetProfilesDirectoryW([NativeTypeName("LPWSTR")] ushort* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetProfileType([NativeTypeName("DWORD *")] uint* dwFlags);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DeleteProfileA([NativeTypeName("LPCSTR")] sbyte* lpSidString, [NativeTypeName("LPCSTR")] sbyte* lpProfilePath, [NativeTypeName("LPCSTR")] sbyte* lpComputerName);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DeleteProfileW([NativeTypeName("LPCWSTR")] ushort* lpSidString, [NativeTypeName("LPCWSTR")] ushort* lpProfilePath, [NativeTypeName("LPCWSTR")] ushort* lpComputerName);

        [DllImport("userenv", ExactSpelling = true)]
        public static extern HRESULT CreateProfile([NativeTypeName("LPCWSTR")] ushort* pszUserSid, [NativeTypeName("LPCWSTR")] ushort* pszUserName, [NativeTypeName("LPWSTR")] ushort* pszProfilePath, [NativeTypeName("DWORD")] uint cchProfilePath);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetDefaultUserProfileDirectoryA([NativeTypeName("LPSTR")] sbyte* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetDefaultUserProfileDirectoryW([NativeTypeName("LPWSTR")] ushort* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetAllUsersProfileDirectoryA([NativeTypeName("LPSTR")] sbyte* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetAllUsersProfileDirectoryW([NativeTypeName("LPWSTR")] ushort* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetUserProfileDirectoryA(HANDLE hToken, [NativeTypeName("LPSTR")] sbyte* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetUserProfileDirectoryW(HANDLE hToken, [NativeTypeName("LPWSTR")] ushort* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CreateEnvironmentBlock([NativeTypeName("LPVOID *")] void** lpEnvironment, HANDLE hToken, BOOL bInherit);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DestroyEnvironmentBlock([NativeTypeName("LPVOID")] void* lpEnvironment);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ExpandEnvironmentStringsForUserA(HANDLE hToken, [NativeTypeName("LPCSTR")] sbyte* lpSrc, [NativeTypeName("LPSTR")] sbyte* lpDest, [NativeTypeName("DWORD")] uint dwSize);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ExpandEnvironmentStringsForUserW(HANDLE hToken, [NativeTypeName("LPCWSTR")] ushort* lpSrc, [NativeTypeName("LPWSTR")] ushort* lpDest, [NativeTypeName("DWORD")] uint dwSize);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL RefreshPolicy(BOOL bMachine);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL RefreshPolicyEx(BOOL bMachine, [NativeTypeName("DWORD")] uint dwOptions);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern HANDLE EnterCriticalPolicySection(BOOL bMachine);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL LeaveCriticalPolicySection(HANDLE hSection);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL RegisterGPNotification(HANDLE hEvent, BOOL bMachine);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnregisterGPNotification(HANDLE hEvent);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetGPOListA(HANDLE hToken, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpHostName, [NativeTypeName("LPCSTR")] sbyte* lpComputerName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PGROUP_POLICY_OBJECTA *")] GROUP_POLICY_OBJECTA** pGPOList);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetGPOListW(HANDLE hToken, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpHostName, [NativeTypeName("LPCWSTR")] ushort* lpComputerName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PGROUP_POLICY_OBJECTW *")] GROUP_POLICY_OBJECTW** pGPOList);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL FreeGPOListA([NativeTypeName("PGROUP_POLICY_OBJECTA")] GROUP_POLICY_OBJECTA* pGPOList);

        [DllImport("userenv", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL FreeGPOListW([NativeTypeName("PGROUP_POLICY_OBJECTW")] GROUP_POLICY_OBJECTW* pGPOList);

        [DllImport("userenv", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetAppliedGPOListA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* pMachineName, [NativeTypeName("PSID")] void* pSidUser, [NativeTypeName("GUID *")] Guid* pGuidExtension, [NativeTypeName("PGROUP_POLICY_OBJECTA *")] GROUP_POLICY_OBJECTA** ppGPOList);

        [DllImport("userenv", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetAppliedGPOListW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pMachineName, [NativeTypeName("PSID")] void* pSidUser, [NativeTypeName("GUID *")] Guid* pGuidExtension, [NativeTypeName("PGROUP_POLICY_OBJECTW *")] GROUP_POLICY_OBJECTW** ppGPOList);

        [DllImport("userenv", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ProcessGroupPolicyCompleted([NativeTypeName("REFGPEXTENSIONID")] Guid* extensionId, ASYNCCOMPLETIONHANDLE pAsyncHandle, [NativeTypeName("DWORD")] uint dwStatus);

        [DllImport("userenv", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ProcessGroupPolicyCompletedEx([NativeTypeName("REFGPEXTENSIONID")] Guid* extensionId, ASYNCCOMPLETIONHANDLE pAsyncHandle, [NativeTypeName("DWORD")] uint dwStatus, HRESULT RsopStatus);

        [DllImport("userenv", ExactSpelling = true)]
        public static extern HRESULT RsopAccessCheckByType([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSID")] void* pPrincipalSelfSid, [NativeTypeName("PRSOPTOKEN")] void* pRsopToken, [NativeTypeName("DWORD")] uint dwDesiredAccessMask, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* pObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* pGenericMapping, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* pPrivilegeSet, [NativeTypeName("LPDWORD")] uint* pdwPrivilegeSetLength, [NativeTypeName("LPDWORD")] uint* pdwGrantedAccessMask, [NativeTypeName("LPBOOL")] BOOL* pbAccessStatus);

        [DllImport("userenv", ExactSpelling = true)]
        public static extern HRESULT RsopFileAccessCheck([NativeTypeName("LPWSTR")] ushort* pszFileName, [NativeTypeName("PRSOPTOKEN")] void* pRsopToken, [NativeTypeName("DWORD")] uint dwDesiredAccessMask, [NativeTypeName("LPDWORD")] uint* pdwGrantedAccessMask, [NativeTypeName("LPBOOL")] BOOL* pbAccessStatus);

        [DllImport("userenv", ExactSpelling = true)]
        public static extern HRESULT RsopSetPolicySettingStatus([NativeTypeName("DWORD")] uint dwFlags, IWbemServices* pServices, IWbemClassObject* pSettingInstance, [NativeTypeName("DWORD")] uint nInfo, POLICYSETTINGSTATUSINFO* pStatus);

        [DllImport("userenv", ExactSpelling = true)]
        public static extern HRESULT RsopResetPolicySettingStatus([NativeTypeName("DWORD")] uint dwFlags, IWbemServices* pServices, IWbemClassObject* pSettingInstance);

        [DllImport("userenv", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GenerateGPNotification(BOOL bMachine, [NativeTypeName("LPCWSTR")] ushort* lpwszMgmtProduct, [NativeTypeName("DWORD")] uint dwMgmtProductOptions);

        [DllImport("userenv", ExactSpelling = true)]
        public static extern HRESULT CreateAppContainerProfile([NativeTypeName("PCWSTR")] ushort* pszAppContainerName, [NativeTypeName("PCWSTR")] ushort* pszDisplayName, [NativeTypeName("PCWSTR")] ushort* pszDescription, [NativeTypeName("PSID_AND_ATTRIBUTES")] SID_AND_ATTRIBUTES* pCapabilities, [NativeTypeName("DWORD")] uint dwCapabilityCount, [NativeTypeName("PSID *")] void** ppSidAppContainerSid);

        [DllImport("userenv", ExactSpelling = true)]
        public static extern HRESULT DeleteAppContainerProfile([NativeTypeName("PCWSTR")] ushort* pszAppContainerName);

        [DllImport("userenv", ExactSpelling = true)]
        public static extern HRESULT GetAppContainerRegistryLocation([NativeTypeName("REGSAM")] uint desiredAccess, [NativeTypeName("PHKEY")] HKEY* phAppContainerKey);

        [DllImport("userenv", ExactSpelling = true)]
        public static extern HRESULT GetAppContainerFolderPath([NativeTypeName("PCWSTR")] ushort* pszAppContainerSid, [NativeTypeName("PWSTR *")] ushort** ppszPath);

        [DllImport("userenv", ExactSpelling = true)]
        public static extern HRESULT DeriveRestrictedAppContainerSidFromAppContainerSidAndRestrictedName([NativeTypeName("PSID")] void* psidAppContainerSid, [NativeTypeName("PCWSTR")] ushort* pszRestrictedAppContainerName, [NativeTypeName("PSID *")] void** ppsidRestrictedAppContainerSid);

        [DllImport("userenv", ExactSpelling = true)]
        public static extern HRESULT DeriveAppContainerSidFromAppContainerName([NativeTypeName("PCWSTR")] ushort* pszAppContainerName, [NativeTypeName("PSID *")] void** ppsidAppContainerSid);

        [NativeTypeName("#define PI_NOUI 0x00000001")]
        public const int PI_NOUI = 0x00000001;

        [NativeTypeName("#define PI_APPLYPOLICY 0x00000002")]
        public const int PI_APPLYPOLICY = 0x00000002;

        [NativeTypeName("#define LoadUserProfile LoadUserProfileW")]
        public static delegate*<HANDLE, PROFILEINFOW*, BOOL> LoadUserProfile => &LoadUserProfileW;

        [NativeTypeName("#define GetProfilesDirectory GetProfilesDirectoryW")]
        public static delegate*<ushort*, uint*, BOOL> GetProfilesDirectory => &GetProfilesDirectoryW;

        [NativeTypeName("#define PT_TEMPORARY 0x00000001")]
        public const int PT_TEMPORARY = 0x00000001;

        [NativeTypeName("#define PT_ROAMING 0x00000002")]
        public const int PT_ROAMING = 0x00000002;

        [NativeTypeName("#define PT_MANDATORY 0x00000004")]
        public const int PT_MANDATORY = 0x00000004;

        [NativeTypeName("#define PT_ROAMING_PREEXISTING 0x00000008")]
        public const int PT_ROAMING_PREEXISTING = 0x00000008;

        [NativeTypeName("#define DeleteProfile DeleteProfileW")]
        public static delegate*<ushort*, ushort*, ushort*, BOOL> DeleteProfile => &DeleteProfileW;

        [NativeTypeName("#define GetDefaultUserProfileDirectory GetDefaultUserProfileDirectoryW")]
        public static delegate*<ushort*, uint*, BOOL> GetDefaultUserProfileDirectory => &GetDefaultUserProfileDirectoryW;

        [NativeTypeName("#define GetAllUsersProfileDirectory GetAllUsersProfileDirectoryW")]
        public static delegate*<ushort*, uint*, BOOL> GetAllUsersProfileDirectory => &GetAllUsersProfileDirectoryW;

        [NativeTypeName("#define GetUserProfileDirectory GetUserProfileDirectoryW")]
        public static delegate*<HANDLE, ushort*, uint*, BOOL> GetUserProfileDirectory => &GetUserProfileDirectoryW;

        [NativeTypeName("#define ExpandEnvironmentStringsForUser ExpandEnvironmentStringsForUserW")]
        public static delegate*<HANDLE, ushort*, ushort*, uint, BOOL> ExpandEnvironmentStringsForUser => &ExpandEnvironmentStringsForUserW;

        [NativeTypeName("#define RP_FORCE 1")]
        public const int RP_FORCE = 1;

        [NativeTypeName("#define RP_SYNC 2")]
        public const int RP_SYNC = 2;

        [NativeTypeName("#define GPC_BLOCK_POLICY 0x00000001")]
        public const int GPC_BLOCK_POLICY = 0x00000001;

        [NativeTypeName("#define GPO_FLAG_DISABLE 0x00000001")]
        public const int GPO_FLAG_DISABLE = 0x00000001;

        [NativeTypeName("#define GPO_FLAG_FORCE 0x00000002")]
        public const int GPO_FLAG_FORCE = 0x00000002;

        [NativeTypeName("#define GPO_LIST_FLAG_MACHINE 0x00000001")]
        public const int GPO_LIST_FLAG_MACHINE = 0x00000001;

        [NativeTypeName("#define GPO_LIST_FLAG_SITEONLY 0x00000002")]
        public const int GPO_LIST_FLAG_SITEONLY = 0x00000002;

        [NativeTypeName("#define GPO_LIST_FLAG_NO_WMIFILTERS 0x00000004")]
        public const int GPO_LIST_FLAG_NO_WMIFILTERS = 0x00000004;

        [NativeTypeName("#define GPO_LIST_FLAG_NO_SECURITYFILTERS 0x00000008")]
        public const int GPO_LIST_FLAG_NO_SECURITYFILTERS = 0x00000008;

        [NativeTypeName("#define GetGPOList GetGPOListW")]
        public static delegate*<HANDLE, ushort*, ushort*, ushort*, uint, GROUP_POLICY_OBJECTW**, BOOL> GetGPOList => &GetGPOListW;

        [NativeTypeName("#define FreeGPOList FreeGPOListW")]
        public static delegate*<GROUP_POLICY_OBJECTW*, BOOL> FreeGPOList => &FreeGPOListW;

        [NativeTypeName("#define GetAppliedGPOList GetAppliedGPOListW")]
        public static delegate*<uint, ushort*, void*, Guid*, GROUP_POLICY_OBJECTW**, uint> GetAppliedGPOList => &GetAppliedGPOListW;

        [NativeTypeName("#define GP_DLLNAME TEXT(\"DllName\")")]
        public const string GP_DLLNAME = "DllName";

        [NativeTypeName("#define GP_ENABLEASYNCHRONOUSPROCESSING TEXT(\"EnableAsynchronousProcessing\")")]
        public const string GP_ENABLEASYNCHRONOUSPROCESSING = "EnableAsynchronousProcessing";

        [NativeTypeName("#define GP_MAXNOGPOLISTCHANGESINTERVAL TEXT(\"MaxNoGPOListChangesInterval\")")]
        public const string GP_MAXNOGPOLISTCHANGESINTERVAL = "MaxNoGPOListChangesInterval";

        [NativeTypeName("#define GP_NOBACKGROUNDPOLICY TEXT(\"NoBackgroundPolicy\")")]
        public const string GP_NOBACKGROUNDPOLICY = "NoBackgroundPolicy";

        [NativeTypeName("#define GP_NOGPOLISTCHANGES TEXT(\"NoGPOListChanges\")")]
        public const string GP_NOGPOLISTCHANGES = "NoGPOListChanges";

        [NativeTypeName("#define GP_NOMACHINEPOLICY TEXT(\"NoMachinePolicy\")")]
        public const string GP_NOMACHINEPOLICY = "NoMachinePolicy";

        [NativeTypeName("#define GP_NOSLOWLINK TEXT(\"NoSlowLink\")")]
        public const string GP_NOSLOWLINK = "NoSlowLink";

        [NativeTypeName("#define GP_NOTIFYLINKTRANSITION TEXT(\"NotifyLinkTransition\")")]
        public const string GP_NOTIFYLINKTRANSITION = "NotifyLinkTransition";

        [NativeTypeName("#define GP_NOUSERPOLICY TEXT(\"NoUserPolicy\")")]
        public const string GP_NOUSERPOLICY = "NoUserPolicy";

        [NativeTypeName("#define GP_PERUSERLOCALSETTINGS TEXT(\"PerUserLocalSettings\")")]
        public const string GP_PERUSERLOCALSETTINGS = "PerUserLocalSettings";

        [NativeTypeName("#define GP_PROCESSGROUPPOLICY TEXT(\"ProcessGroupPolicy\")")]
        public const string GP_PROCESSGROUPPOLICY = "ProcessGroupPolicy";

        [NativeTypeName("#define GP_REQUIRESSUCCESSFULREGISTRY TEXT(\"RequiresSuccessfulRegistry\")")]
        public const string GP_REQUIRESSUCCESSFULREGISTRY = "RequiresSuccessfulRegistry";

        [NativeTypeName("#define GPO_INFO_FLAG_MACHINE 0x00000001")]
        public const int GPO_INFO_FLAG_MACHINE = 0x00000001;

        [NativeTypeName("#define GPO_INFO_FLAG_BACKGROUND 0x00000010")]
        public const int GPO_INFO_FLAG_BACKGROUND = 0x00000010;

        [NativeTypeName("#define GPO_INFO_FLAG_SLOWLINK 0x00000020")]
        public const int GPO_INFO_FLAG_SLOWLINK = 0x00000020;

        [NativeTypeName("#define GPO_INFO_FLAG_VERBOSE 0x00000040")]
        public const int GPO_INFO_FLAG_VERBOSE = 0x00000040;

        [NativeTypeName("#define GPO_INFO_FLAG_NOCHANGES 0x00000080")]
        public const int GPO_INFO_FLAG_NOCHANGES = 0x00000080;

        [NativeTypeName("#define GPO_INFO_FLAG_LINKTRANSITION 0x00000100")]
        public const int GPO_INFO_FLAG_LINKTRANSITION = 0x00000100;

        [NativeTypeName("#define GPO_INFO_FLAG_LOGRSOP_TRANSITION 0x00000200")]
        public const int GPO_INFO_FLAG_LOGRSOP_TRANSITION = 0x00000200;

        [NativeTypeName("#define GPO_INFO_FLAG_FORCED_REFRESH 0x00000400")]
        public const int GPO_INFO_FLAG_FORCED_REFRESH = 0x00000400;

        [NativeTypeName("#define GPO_INFO_FLAG_SAFEMODE_BOOT 0x00000800")]
        public const int GPO_INFO_FLAG_SAFEMODE_BOOT = 0x00000800;

        [NativeTypeName("#define GPO_INFO_FLAG_ASYNC_FOREGROUND 0x00001000")]
        public const int GPO_INFO_FLAG_ASYNC_FOREGROUND = 0x00001000;

        [NativeTypeName("#define FLAG_NO_GPO_FILTER 0x80000000")]
        public const uint FLAG_NO_GPO_FILTER = 0x80000000;

        [NativeTypeName("#define FLAG_NO_CSE_INVOKE 0x40000000")]
        public const int FLAG_NO_CSE_INVOKE = 0x40000000;

        [NativeTypeName("#define FLAG_ASSUME_SLOW_LINK 0x20000000")]
        public const int FLAG_ASSUME_SLOW_LINK = 0x20000000;

        [NativeTypeName("#define FLAG_LOOPBACK_MERGE 0x10000000")]
        public const int FLAG_LOOPBACK_MERGE = 0x10000000;

        [NativeTypeName("#define FLAG_LOOPBACK_REPLACE 0x08000000")]
        public const int FLAG_LOOPBACK_REPLACE = 0x08000000;

        [NativeTypeName("#define FLAG_ASSUME_USER_WQLFILTER_TRUE 0x04000000")]
        public const int FLAG_ASSUME_USER_WQLFILTER_TRUE = 0x04000000;

        [NativeTypeName("#define FLAG_ASSUME_COMP_WQLFILTER_TRUE 0x02000000")]
        public const int FLAG_ASSUME_COMP_WQLFILTER_TRUE = 0x02000000;

        [NativeTypeName("#define FLAG_PLANNING_MODE 0x01000000")]
        public const int FLAG_PLANNING_MODE = 0x01000000;

        [NativeTypeName("#define FLAG_NO_USER 0x00000001")]
        public const int FLAG_NO_USER = 0x00000001;

        [NativeTypeName("#define FLAG_NO_COMPUTER 0x00000002")]
        public const int FLAG_NO_COMPUTER = 0x00000002;

        [NativeTypeName("#define FLAG_FORCE_CREATENAMESPACE 0x00000004")]
        public const int FLAG_FORCE_CREATENAMESPACE = 0x00000004;

        [NativeTypeName("#define RSOP_USER_ACCESS_DENIED 0x00000001")]
        public const int RSOP_USER_ACCESS_DENIED = 0x00000001;

        [NativeTypeName("#define RSOP_COMPUTER_ACCESS_DENIED 0x00000002")]
        public const int RSOP_COMPUTER_ACCESS_DENIED = 0x00000002;

        [NativeTypeName("#define RSOP_TEMPNAMESPACE_EXISTS 0x00000004")]
        public const int RSOP_TEMPNAMESPACE_EXISTS = 0x00000004;
    }
}
