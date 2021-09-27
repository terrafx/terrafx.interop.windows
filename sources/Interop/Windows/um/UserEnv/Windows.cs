// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LoadUserProfileA([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("LPPROFILEINFOA")] PROFILEINFOA* lpProfileInfo);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LoadUserProfileW([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("LPPROFILEINFOW")] PROFILEINFOW* lpProfileInfo);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnloadUserProfile([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("HANDLE")] IntPtr hProfile);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProfilesDirectoryA([NativeTypeName("LPSTR")] sbyte* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProfilesDirectoryW([NativeTypeName("LPWSTR")] ushort* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProfileType([NativeTypeName("DWORD *")] uint* dwFlags);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteProfileA([NativeTypeName("LPCSTR")] sbyte* lpSidString, [NativeTypeName("LPCSTR")] sbyte* lpProfilePath, [NativeTypeName("LPCSTR")] sbyte* lpComputerName);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteProfileW([NativeTypeName("LPCWSTR")] ushort* lpSidString, [NativeTypeName("LPCWSTR")] ushort* lpProfilePath, [NativeTypeName("LPCWSTR")] ushort* lpComputerName);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateProfile([NativeTypeName("LPCWSTR")] ushort* pszUserSid, [NativeTypeName("LPCWSTR")] ushort* pszUserName, [NativeTypeName("LPWSTR")] ushort* pszProfilePath, [NativeTypeName("DWORD")] uint cchProfilePath);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDefaultUserProfileDirectoryA([NativeTypeName("LPSTR")] sbyte* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDefaultUserProfileDirectoryW([NativeTypeName("LPWSTR")] ushort* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAllUsersProfileDirectoryA([NativeTypeName("LPSTR")] sbyte* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAllUsersProfileDirectoryW([NativeTypeName("LPWSTR")] ushort* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserProfileDirectoryA([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("LPSTR")] sbyte* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserProfileDirectoryW([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("LPWSTR")] ushort* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateEnvironmentBlock([NativeTypeName("LPVOID *")] void** lpEnvironment, [NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("BOOL")] int bInherit);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyEnvironmentBlock([NativeTypeName("LPVOID")] void* lpEnvironment);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExpandEnvironmentStringsForUserA([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("LPCSTR")] sbyte* lpSrc, [NativeTypeName("LPSTR")] sbyte* lpDest, [NativeTypeName("DWORD")] uint dwSize);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExpandEnvironmentStringsForUserW([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("LPCWSTR")] ushort* lpSrc, [NativeTypeName("LPWSTR")] ushort* lpDest, [NativeTypeName("DWORD")] uint dwSize);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RefreshPolicy([NativeTypeName("BOOL")] int bMachine);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RefreshPolicyEx([NativeTypeName("BOOL")] int bMachine, [NativeTypeName("DWORD")] uint dwOptions);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr EnterCriticalPolicySection([NativeTypeName("BOOL")] int bMachine);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LeaveCriticalPolicySection([NativeTypeName("HANDLE")] IntPtr hSection);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterGPNotification([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("BOOL")] int bMachine);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterGPNotification([NativeTypeName("HANDLE")] IntPtr hEvent);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGPOListA([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpHostName, [NativeTypeName("LPCSTR")] sbyte* lpComputerName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PGROUP_POLICY_OBJECTA *")] GROUP_POLICY_OBJECTA** pGPOList);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGPOListW([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpHostName, [NativeTypeName("LPCWSTR")] ushort* lpComputerName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PGROUP_POLICY_OBJECTW *")] GROUP_POLICY_OBJECTW** pGPOList);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FreeGPOListA([NativeTypeName("PGROUP_POLICY_OBJECTA")] GROUP_POLICY_OBJECTA* pGPOList);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FreeGPOListW([NativeTypeName("PGROUP_POLICY_OBJECTW")] GROUP_POLICY_OBJECTW* pGPOList);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetAppliedGPOListA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* pMachineName, [NativeTypeName("PSID")] void* pSidUser, [NativeTypeName("GUID *")] Guid* pGuidExtension, [NativeTypeName("PGROUP_POLICY_OBJECTA *")] GROUP_POLICY_OBJECTA** ppGPOList);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetAppliedGPOListW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pMachineName, [NativeTypeName("PSID")] void* pSidUser, [NativeTypeName("GUID *")] Guid* pGuidExtension, [NativeTypeName("PGROUP_POLICY_OBJECTW *")] GROUP_POLICY_OBJECTW** ppGPOList);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ProcessGroupPolicyCompleted([NativeTypeName("REFGPEXTENSIONID")] Guid* extensionId, [NativeTypeName("ASYNCCOMPLETIONHANDLE")] nuint pAsyncHandle, [NativeTypeName("DWORD")] uint dwStatus);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ProcessGroupPolicyCompletedEx([NativeTypeName("REFGPEXTENSIONID")] Guid* extensionId, [NativeTypeName("ASYNCCOMPLETIONHANDLE")] nuint pAsyncHandle, [NativeTypeName("DWORD")] uint dwStatus, [NativeTypeName("HRESULT")] int RsopStatus);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RsopAccessCheckByType([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSID")] void* pPrincipalSelfSid, [NativeTypeName("PRSOPTOKEN")] void* pRsopToken, [NativeTypeName("DWORD")] uint dwDesiredAccessMask, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* pObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* pGenericMapping, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* pPrivilegeSet, [NativeTypeName("LPDWORD")] uint* pdwPrivilegeSetLength, [NativeTypeName("LPDWORD")] uint* pdwGrantedAccessMask, [NativeTypeName("LPBOOL")] int* pbAccessStatus);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RsopFileAccessCheck([NativeTypeName("LPWSTR")] ushort* pszFileName, [NativeTypeName("PRSOPTOKEN")] void* pRsopToken, [NativeTypeName("DWORD")] uint dwDesiredAccessMask, [NativeTypeName("LPDWORD")] uint* pdwGrantedAccessMask, [NativeTypeName("LPBOOL")] int* pbAccessStatus);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RsopSetPolicySettingStatus([NativeTypeName("DWORD")] uint dwFlags, IWbemServices* pServices, IWbemClassObject* pSettingInstance, [NativeTypeName("DWORD")] uint nInfo, POLICYSETTINGSTATUSINFO* pStatus);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RsopResetPolicySettingStatus([NativeTypeName("DWORD")] uint dwFlags, IWbemServices* pServices, IWbemClassObject* pSettingInstance);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GenerateGPNotification([NativeTypeName("BOOL")] int bMachine, [NativeTypeName("LPCWSTR")] ushort* lpwszMgmtProduct, [NativeTypeName("DWORD")] uint dwMgmtProductOptions);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateAppContainerProfile([NativeTypeName("PCWSTR")] ushort* pszAppContainerName, [NativeTypeName("PCWSTR")] ushort* pszDisplayName, [NativeTypeName("PCWSTR")] ushort* pszDescription, [NativeTypeName("PSID_AND_ATTRIBUTES")] SID_AND_ATTRIBUTES* pCapabilities, [NativeTypeName("DWORD")] uint dwCapabilityCount, [NativeTypeName("PSID *")] void** ppSidAppContainerSid);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DeleteAppContainerProfile([NativeTypeName("PCWSTR")] ushort* pszAppContainerName);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetAppContainerRegistryLocation([NativeTypeName("REGSAM")] uint desiredAccess, [NativeTypeName("PHKEY")] IntPtr* phAppContainerKey);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetAppContainerFolderPath([NativeTypeName("PCWSTR")] ushort* pszAppContainerSid, [NativeTypeName("PWSTR *")] ushort** ppszPath);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DeriveRestrictedAppContainerSidFromAppContainerSidAndRestrictedName([NativeTypeName("PSID")] void* psidAppContainerSid, [NativeTypeName("PCWSTR")] ushort* pszRestrictedAppContainerName, [NativeTypeName("PSID *")] void** ppsidRestrictedAppContainerSid);

        [DllImport("Userenv", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DeriveAppContainerSidFromAppContainerName([NativeTypeName("PCWSTR")] ushort* pszAppContainerName, [NativeTypeName("PSID *")] void** ppsidAppContainerSid);

        [NativeTypeName("#define PI_NOUI 0x00000001")]
        public const int PI_NOUI = 0x00000001;

        [NativeTypeName("#define PI_APPLYPOLICY 0x00000002")]
        public const int PI_APPLYPOLICY = 0x00000002;

        [NativeTypeName("#define LoadUserProfile LoadUserProfileW")]
        public static delegate*<IntPtr, PROFILEINFOW*, int> LoadUserProfile => &LoadUserProfileW;

        [NativeTypeName("#define GetProfilesDirectory GetProfilesDirectoryW")]
        public static delegate*<ushort*, uint*, int> GetProfilesDirectory => &GetProfilesDirectoryW;

        [NativeTypeName("#define PT_TEMPORARY 0x00000001")]
        public const int PT_TEMPORARY = 0x00000001;

        [NativeTypeName("#define PT_ROAMING 0x00000002")]
        public const int PT_ROAMING = 0x00000002;

        [NativeTypeName("#define PT_MANDATORY 0x00000004")]
        public const int PT_MANDATORY = 0x00000004;

        [NativeTypeName("#define PT_ROAMING_PREEXISTING 0x00000008")]
        public const int PT_ROAMING_PREEXISTING = 0x00000008;

        [NativeTypeName("#define DeleteProfile DeleteProfileW")]
        public static delegate*<ushort*, ushort*, ushort*, int> DeleteProfile => &DeleteProfileW;

        [NativeTypeName("#define GetDefaultUserProfileDirectory GetDefaultUserProfileDirectoryW")]
        public static delegate*<ushort*, uint*, int> GetDefaultUserProfileDirectory => &GetDefaultUserProfileDirectoryW;

        [NativeTypeName("#define GetAllUsersProfileDirectory GetAllUsersProfileDirectoryW")]
        public static delegate*<ushort*, uint*, int> GetAllUsersProfileDirectory => &GetAllUsersProfileDirectoryW;

        [NativeTypeName("#define GetUserProfileDirectory GetUserProfileDirectoryW")]
        public static delegate*<IntPtr, ushort*, uint*, int> GetUserProfileDirectory => &GetUserProfileDirectoryW;

        [NativeTypeName("#define ExpandEnvironmentStringsForUser ExpandEnvironmentStringsForUserW")]
        public static delegate*<IntPtr, ushort*, ushort*, uint, int> ExpandEnvironmentStringsForUser => &ExpandEnvironmentStringsForUserW;

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
        public static delegate*<IntPtr, ushort*, ushort*, ushort*, uint, GROUP_POLICY_OBJECTW**, int> GetGPOList => &GetGPOListW;

        [NativeTypeName("#define FreeGPOList FreeGPOListW")]
        public static delegate*<GROUP_POLICY_OBJECTW*, int> FreeGPOList => &FreeGPOListW;

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
