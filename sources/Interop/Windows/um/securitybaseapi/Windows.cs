// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/securitybaseapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheck([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* PrivilegeSet, [NativeTypeName("LPDWORD")] uint* PrivilegeSetLength, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] int* AccessStatus);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckAndAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPWSTR")] ushort* ObjectTypeName, [NativeTypeName("LPWSTR")] ushort* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] int* AccessStatus, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckByType([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* PrivilegeSet, [NativeTypeName("LPDWORD")] uint* PrivilegeSetLength, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] int* AccessStatus);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckByTypeResultList([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* PrivilegeSet, [NativeTypeName("LPDWORD")] uint* PrivilegeSetLength, [NativeTypeName("LPDWORD")] uint* GrantedAccessList, [NativeTypeName("LPDWORD")] uint* AccessStatusList);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckByTypeAndAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPCWSTR")] ushort* ObjectTypeName, [NativeTypeName("LPCWSTR")] ushort* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] int* AccessStatus, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPCWSTR")] ushort* ObjectTypeName, [NativeTypeName("LPCWSTR")] ushort* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccessList, [NativeTypeName("LPDWORD")] uint* AccessStatusList, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmByHandleW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("LPCWSTR")] ushort* ObjectTypeName, [NativeTypeName("LPCWSTR")] ushort* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccessList, [NativeTypeName("LPDWORD")] uint* AccessStatusList, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddAccessAllowedAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddAccessAllowedAceEx([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddAccessAllowedObjectAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("GUID *")] Guid* ObjectTypeGuid, [NativeTypeName("GUID *")] Guid* InheritedObjectTypeGuid, [NativeTypeName("PSID")] void* pSid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddAccessDeniedAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddAccessDeniedAceEx([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddAccessDeniedObjectAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("GUID *")] Guid* ObjectTypeGuid, [NativeTypeName("GUID *")] Guid* InheritedObjectTypeGuid, [NativeTypeName("PSID")] void* pSid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint dwStartingAceIndex, [NativeTypeName("LPVOID")] void* pAceList, [NativeTypeName("DWORD")] uint nAceListLength);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddAuditAccessAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint dwAccessMask, [NativeTypeName("PSID")] void* pSid, [NativeTypeName("BOOL")] int bAuditSuccess, [NativeTypeName("BOOL")] int bAuditFailure);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddAuditAccessAceEx([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint dwAccessMask, [NativeTypeName("PSID")] void* pSid, [NativeTypeName("BOOL")] int bAuditSuccess, [NativeTypeName("BOOL")] int bAuditFailure);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddAuditAccessObjectAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("GUID *")] Guid* ObjectTypeGuid, [NativeTypeName("GUID *")] Guid* InheritedObjectTypeGuid, [NativeTypeName("PSID")] void* pSid, [NativeTypeName("BOOL")] int bAuditSuccess, [NativeTypeName("BOOL")] int bAuditFailure);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddMandatoryAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint MandatoryPolicy, [NativeTypeName("PSID")] void* pLabelSid);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddResourceAttributeAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid, [NativeTypeName("PCLAIM_SECURITY_ATTRIBUTES_INFORMATION")] CLAIM_SECURITY_ATTRIBUTES_INFORMATION* pAttributeInfo, [NativeTypeName("PDWORD")] uint* pReturnLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddScopedPolicyIDAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustTokenGroups([NativeTypeName("HANDLE")] IntPtr TokenHandle, [NativeTypeName("BOOL")] int ResetToDefault, [NativeTypeName("PTOKEN_GROUPS")] TOKEN_GROUPS* NewState, [NativeTypeName("DWORD")] uint BufferLength, [NativeTypeName("PTOKEN_GROUPS")] TOKEN_GROUPS* PreviousState, [NativeTypeName("PDWORD")] uint* ReturnLength);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustTokenPrivileges([NativeTypeName("HANDLE")] IntPtr TokenHandle, [NativeTypeName("BOOL")] int DisableAllPrivileges, [NativeTypeName("PTOKEN_PRIVILEGES")] TOKEN_PRIVILEGES* NewState, [NativeTypeName("DWORD")] uint BufferLength, [NativeTypeName("PTOKEN_PRIVILEGES")] TOKEN_PRIVILEGES* PreviousState, [NativeTypeName("PDWORD")] uint* ReturnLength);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AllocateAndInitializeSid([NativeTypeName("PSID_IDENTIFIER_AUTHORITY")] SID_IDENTIFIER_AUTHORITY* pIdentifierAuthority, [NativeTypeName("BYTE")] byte nSubAuthorityCount, [NativeTypeName("DWORD")] uint nSubAuthority0, [NativeTypeName("DWORD")] uint nSubAuthority1, [NativeTypeName("DWORD")] uint nSubAuthority2, [NativeTypeName("DWORD")] uint nSubAuthority3, [NativeTypeName("DWORD")] uint nSubAuthority4, [NativeTypeName("DWORD")] uint nSubAuthority5, [NativeTypeName("DWORD")] uint nSubAuthority6, [NativeTypeName("DWORD")] uint nSubAuthority7, [NativeTypeName("PSID *")] void** pSid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AllocateLocallyUniqueId([NativeTypeName("PLUID")] LUID* Luid);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AreAllAccessesGranted([NativeTypeName("DWORD")] uint GrantedAccess, [NativeTypeName("DWORD")] uint DesiredAccess);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AreAnyAccessesGranted([NativeTypeName("DWORD")] uint GrantedAccess, [NativeTypeName("DWORD")] uint DesiredAccess);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckTokenMembership([NativeTypeName("HANDLE")] IntPtr TokenHandle, [NativeTypeName("PSID")] void* SidToCheck, [NativeTypeName("PBOOL")] int* IsMember);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckTokenCapability([NativeTypeName("HANDLE")] IntPtr TokenHandle, [NativeTypeName("PSID")] void* CapabilitySidToCheck, [NativeTypeName("PBOOL")] int* HasCapability);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAppContainerAce([NativeTypeName("PACL")] ACL* Acl, [NativeTypeName("DWORD")] uint StartingAceIndex, [NativeTypeName("PVOID *")] void** AppContainerAce, [NativeTypeName("DWORD *")] uint* AppContainerAceIndex);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckTokenMembershipEx([NativeTypeName("HANDLE")] IntPtr TokenHandle, [NativeTypeName("PSID")] void* SidToCheck, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PBOOL")] int* IsMember);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ConvertToAutoInheritPrivateObjectSecurity([NativeTypeName("PSECURITY_DESCRIPTOR")] void* ParentDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* CurrentSecurityDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** NewSecurityDescriptor, [NativeTypeName("GUID *")] Guid* ObjectType, [NativeTypeName("BOOLEAN")] byte IsDirectoryObject, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopySid([NativeTypeName("DWORD")] uint nDestinationSidLength, [NativeTypeName("PSID")] void* pDestinationSid, [NativeTypeName("PSID")] void* pSourceSid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreatePrivateObjectSecurity([NativeTypeName("PSECURITY_DESCRIPTOR")] void* ParentDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* CreatorDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** NewDescriptor, [NativeTypeName("BOOL")] int IsDirectoryObject, [NativeTypeName("HANDLE")] IntPtr Token, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreatePrivateObjectSecurityEx([NativeTypeName("PSECURITY_DESCRIPTOR")] void* ParentDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* CreatorDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** NewDescriptor, [NativeTypeName("GUID *")] Guid* ObjectType, [NativeTypeName("BOOL")] int IsContainerObject, [NativeTypeName("ULONG")] uint AutoInheritFlags, [NativeTypeName("HANDLE")] IntPtr Token, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreatePrivateObjectSecurityWithMultipleInheritance([NativeTypeName("PSECURITY_DESCRIPTOR")] void* ParentDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* CreatorDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** NewDescriptor, [NativeTypeName("GUID **")] Guid** ObjectTypes, [NativeTypeName("ULONG")] uint GuidCount, [NativeTypeName("BOOL")] int IsContainerObject, [NativeTypeName("ULONG")] uint AutoInheritFlags, [NativeTypeName("HANDLE")] IntPtr Token, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateRestrictedToken([NativeTypeName("HANDLE")] IntPtr ExistingTokenHandle, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint DisableSidCount, [NativeTypeName("PSID_AND_ATTRIBUTES")] SID_AND_ATTRIBUTES* SidsToDisable, [NativeTypeName("DWORD")] uint DeletePrivilegeCount, [NativeTypeName("PLUID_AND_ATTRIBUTES")] LUID_AND_ATTRIBUTES* PrivilegesToDelete, [NativeTypeName("DWORD")] uint RestrictedSidCount, [NativeTypeName("PSID_AND_ATTRIBUTES")] SID_AND_ATTRIBUTES* SidsToRestrict, [NativeTypeName("PHANDLE")] IntPtr* NewTokenHandle);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateWellKnownSid(WELL_KNOWN_SID_TYPE WellKnownSidType, [NativeTypeName("PSID")] void* DomainSid, [NativeTypeName("PSID")] void* pSid, [NativeTypeName("DWORD *")] uint* cbSid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EqualDomainSid([NativeTypeName("PSID")] void* pSid1, [NativeTypeName("PSID")] void* pSid2, [NativeTypeName("BOOL *")] int* pfEqual);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceIndex);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyPrivateObjectSecurity([NativeTypeName("PSECURITY_DESCRIPTOR *")] void** ObjectDescriptor);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DuplicateToken([NativeTypeName("HANDLE")] IntPtr ExistingTokenHandle, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, [NativeTypeName("PHANDLE")] IntPtr* DuplicateTokenHandle);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DuplicateTokenEx([NativeTypeName("HANDLE")] IntPtr hExistingToken, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTokenAttributes, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, TOKEN_TYPE TokenType, [NativeTypeName("PHANDLE")] IntPtr* phNewToken);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EqualPrefixSid([NativeTypeName("PSID")] void* pSid1, [NativeTypeName("PSID")] void* pSid2);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EqualSid([NativeTypeName("PSID")] void* pSid1, [NativeTypeName("PSID")] void* pSid2);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindFirstFreeAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("LPVOID *")] void** pAce);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* FreeSid([NativeTypeName("PSID")] void* pSid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceIndex, [NativeTypeName("LPVOID *")] void** pAce);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAclInformation([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("LPVOID")] void* pAclInformation, [NativeTypeName("DWORD")] uint nAclInformationLength, ACL_INFORMATION_CLASS dwAclInformationClass);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileSecurityW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("SECURITY_INFORMATION")] uint RequestedInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetKernelObjectSecurity([NativeTypeName("HANDLE")] IntPtr Handle, [NativeTypeName("SECURITY_INFORMATION")] uint RequestedInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLengthSid([NativeTypeName("PSID")] void* pSid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPrivateObjectSecurity([NativeTypeName("PSECURITY_DESCRIPTOR")] void* ObjectDescriptor, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* ResultantDescriptor, [NativeTypeName("DWORD")] uint DescriptorLength, [NativeTypeName("PDWORD")] uint* ReturnLength);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSecurityDescriptorControl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR_CONTROL")] ushort* pControl, [NativeTypeName("LPDWORD")] uint* lpdwRevision);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSecurityDescriptorDacl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("LPBOOL")] int* lpbDaclPresent, [NativeTypeName("PACL *")] ACL** pDacl, [NativeTypeName("LPBOOL")] int* lpbDaclDefaulted);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSecurityDescriptorGroup([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSID *")] void** pGroup, [NativeTypeName("LPBOOL")] int* lpbGroupDefaulted);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetSecurityDescriptorLength([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSecurityDescriptorOwner([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSID *")] void** pOwner, [NativeTypeName("LPBOOL")] int* lpbOwnerDefaulted);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetSecurityDescriptorRMControl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PUCHAR")] byte* RMControl);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSecurityDescriptorSacl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("LPBOOL")] int* lpbSaclPresent, [NativeTypeName("PACL *")] ACL** pSacl, [NativeTypeName("LPBOOL")] int* lpbSaclDefaulted);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PSID_IDENTIFIER_AUTHORITY")]
        public static extern SID_IDENTIFIER_AUTHORITY* GetSidIdentifierAuthority([NativeTypeName("PSID")] void* pSid);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetSidLengthRequired([NativeTypeName("UCHAR")] byte nSubAuthorityCount);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PDWORD")]
        public static extern uint* GetSidSubAuthority([NativeTypeName("PSID")] void* pSid, [NativeTypeName("DWORD")] uint nSubAuthority);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PUCHAR")]
        public static extern byte* GetSidSubAuthorityCount([NativeTypeName("PSID")] void* pSid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTokenInformation([NativeTypeName("HANDLE")] IntPtr TokenHandle, TOKEN_INFORMATION_CLASS TokenInformationClass, [NativeTypeName("LPVOID")] void* TokenInformation, [NativeTypeName("DWORD")] uint TokenInformationLength, [NativeTypeName("PDWORD")] uint* ReturnLength);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowsAccountDomainSid([NativeTypeName("PSID")] void* pSid, [NativeTypeName("PSID")] void* pDomainSid, [NativeTypeName("DWORD *")] uint* cbDomainSid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImpersonateAnonymousToken([NativeTypeName("HANDLE")] IntPtr ThreadHandle);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImpersonateLoggedOnUser([NativeTypeName("HANDLE")] IntPtr hToken);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImpersonateSelf(SECURITY_IMPERSONATION_LEVEL ImpersonationLevel);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeAcl([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint nAclLength, [NativeTypeName("DWORD")] uint dwAclRevision);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeSecurityDescriptor([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("DWORD")] uint dwRevision);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeSid([NativeTypeName("PSID")] void* Sid, [NativeTypeName("PSID_IDENTIFIER_AUTHORITY")] SID_IDENTIFIER_AUTHORITY* pIdentifierAuthority, [NativeTypeName("BYTE")] byte nSubAuthorityCount);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsTokenRestricted([NativeTypeName("HANDLE")] IntPtr TokenHandle);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsValidAcl([NativeTypeName("PACL")] ACL* pAcl);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsValidSecurityDescriptor([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsValidSid([NativeTypeName("PSID")] void* pSid);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWellKnownSid([NativeTypeName("PSID")] void* pSid, WELL_KNOWN_SID_TYPE WellKnownSidType);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MakeAbsoluteSD([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSelfRelativeSecurityDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pAbsoluteSecurityDescriptor, [NativeTypeName("LPDWORD")] uint* lpdwAbsoluteSecurityDescriptorSize, [NativeTypeName("PACL")] ACL* pDacl, [NativeTypeName("LPDWORD")] uint* lpdwDaclSize, [NativeTypeName("PACL")] ACL* pSacl, [NativeTypeName("LPDWORD")] uint* lpdwSaclSize, [NativeTypeName("PSID")] void* pOwner, [NativeTypeName("LPDWORD")] uint* lpdwOwnerSize, [NativeTypeName("PSID")] void* pPrimaryGroup, [NativeTypeName("LPDWORD")] uint* lpdwPrimaryGroupSize);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MakeSelfRelativeSD([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pAbsoluteSecurityDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSelfRelativeSecurityDescriptor, [NativeTypeName("LPDWORD")] uint* lpdwBufferLength);

        [DllImport("advapi32", ExactSpelling = true)]
        public static extern void MapGenericMask([NativeTypeName("PDWORD")] uint* AccessMask, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectCloseAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("BOOL")] int GenerateOnClose);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectDeleteAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("BOOL")] int GenerateOnClose);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectOpenAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPWSTR")] ushort* ObjectTypeName, [NativeTypeName("LPWSTR")] ushort* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("DWORD")] uint GrantedAccess, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("BOOL")] int AccessGranted, [NativeTypeName("LPBOOL")] int* GenerateOnClose);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectPrivilegeAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, [NativeTypeName("BOOL")] int AccessGranted);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PrivilegeCheck([NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* RequiredPrivileges, [NativeTypeName("LPBOOL")] int* pfResult);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PrivilegedServiceAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPCWSTR")] ushort* ServiceName, [NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, [NativeTypeName("BOOL")] int AccessGranted);

        [DllImport("advapi32", ExactSpelling = true)]
        public static extern void QuerySecurityAccessMask([NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("LPDWORD")] uint* DesiredAccess);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RevertToSelf();

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetAclInformation([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("LPVOID")] void* pAclInformation, [NativeTypeName("DWORD")] uint nAclInformationLength, ACL_INFORMATION_CLASS dwAclInformationClass);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileSecurityW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetKernelObjectSecurity([NativeTypeName("HANDLE")] IntPtr Handle, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPrivateObjectSecurity([NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* ModificationDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** ObjectsSecurityDescriptor, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("HANDLE")] IntPtr Token);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPrivateObjectSecurityEx([NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* ModificationDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** ObjectsSecurityDescriptor, [NativeTypeName("ULONG")] uint AutoInheritFlags, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("HANDLE")] IntPtr Token);

        [DllImport("advapi32", ExactSpelling = true)]
        public static extern void SetSecurityAccessMask([NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("LPDWORD")] uint* DesiredAccess);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSecurityDescriptorControl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("SECURITY_DESCRIPTOR_CONTROL")] ushort ControlBitsOfInterest, [NativeTypeName("SECURITY_DESCRIPTOR_CONTROL")] ushort ControlBitsToSet);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSecurityDescriptorDacl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("BOOL")] int bDaclPresent, [NativeTypeName("PACL")] ACL* pDacl, [NativeTypeName("BOOL")] int bDaclDefaulted);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSecurityDescriptorGroup([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSID")] void* pGroup, [NativeTypeName("BOOL")] int bGroupDefaulted);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSecurityDescriptorOwner([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSID")] void* pOwner, [NativeTypeName("BOOL")] int bOwnerDefaulted);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetSecurityDescriptorRMControl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PUCHAR")] byte* RMControl);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSecurityDescriptorSacl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("BOOL")] int bSaclPresent, [NativeTypeName("PACL")] ACL* pSacl, [NativeTypeName("BOOL")] int bSaclDefaulted);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetTokenInformation([NativeTypeName("HANDLE")] IntPtr TokenHandle, TOKEN_INFORMATION_CLASS TokenInformationClass, [NativeTypeName("LPVOID")] void* TokenInformation, [NativeTypeName("DWORD")] uint TokenInformationLength);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCachedSigningLevel([NativeTypeName("PHANDLE")] IntPtr* SourceFiles, [NativeTypeName("ULONG")] uint SourceFileCount, [NativeTypeName("ULONG")] uint Flags, [NativeTypeName("HANDLE")] IntPtr TargetFile);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCachedSigningLevel([NativeTypeName("HANDLE")] IntPtr File, [NativeTypeName("PULONG")] uint* Flags, [NativeTypeName("PULONG")] uint* SigningLevel, [NativeTypeName("PUCHAR")] byte* Thumbprint, [NativeTypeName("PULONG")] uint* ThumbprintSize, [NativeTypeName("PULONG")] uint* ThumbprintAlgorithm);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int CveEventWrite([NativeTypeName("PCWSTR")] ushort* CveId, [NativeTypeName("PCWSTR")] ushort* AdditionalDetails);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeriveCapabilitySidsFromName([NativeTypeName("LPCWSTR")] ushort* CapName, [NativeTypeName("PSID **")] void*** CapabilityGroupSids, [NativeTypeName("DWORD *")] uint* CapabilityGroupSidCount, [NativeTypeName("PSID **")] void*** CapabilitySids, [NativeTypeName("DWORD *")] uint* CapabilitySidCount);

        [NativeTypeName("#define AccessCheckAndAuditAlarm AccessCheckAndAuditAlarmW")]
        public static delegate*<ushort*, void*, ushort*, ushort*, void*, uint, GENERIC_MAPPING*, int, uint*, int*, int*, int> AccessCheckAndAuditAlarm => &AccessCheckAndAuditAlarmW;

        [NativeTypeName("#define AccessCheckByTypeAndAuditAlarm AccessCheckByTypeAndAuditAlarmW")]
        public static delegate*<ushort*, void*, ushort*, ushort*, void*, void*, uint, AUDIT_EVENT_TYPE, uint, OBJECT_TYPE_LIST*, uint, GENERIC_MAPPING*, int, uint*, int*, int*, int> AccessCheckByTypeAndAuditAlarm => &AccessCheckByTypeAndAuditAlarmW;

        [NativeTypeName("#define AccessCheckByTypeResultListAndAuditAlarm AccessCheckByTypeResultListAndAuditAlarmW")]
        public static delegate*<ushort*, void*, ushort*, ushort*, void*, void*, uint, AUDIT_EVENT_TYPE, uint, OBJECT_TYPE_LIST*, uint, GENERIC_MAPPING*, int, uint*, uint*, int*, int> AccessCheckByTypeResultListAndAuditAlarm => &AccessCheckByTypeResultListAndAuditAlarmW;

        [NativeTypeName("#define AccessCheckByTypeResultListAndAuditAlarmByHandle AccessCheckByTypeResultListAndAuditAlarmByHandleW")]
        public static delegate*<ushort*, void*, IntPtr, ushort*, ushort*, void*, void*, uint, AUDIT_EVENT_TYPE, uint, OBJECT_TYPE_LIST*, uint, GENERIC_MAPPING*, int, uint*, uint*, int*, int> AccessCheckByTypeResultListAndAuditAlarmByHandle => &AccessCheckByTypeResultListAndAuditAlarmByHandleW;

        [NativeTypeName("#define GetFileSecurity GetFileSecurityW")]
        public static delegate*<ushort*, uint, void*, uint, uint*, int> GetFileSecurity => &GetFileSecurityW;

        [NativeTypeName("#define ObjectCloseAuditAlarm ObjectCloseAuditAlarmW")]
        public static delegate*<ushort*, void*, int, int> ObjectCloseAuditAlarm => &ObjectCloseAuditAlarmW;

        [NativeTypeName("#define ObjectDeleteAuditAlarm ObjectDeleteAuditAlarmW")]
        public static delegate*<ushort*, void*, int, int> ObjectDeleteAuditAlarm => &ObjectDeleteAuditAlarmW;

        [NativeTypeName("#define ObjectOpenAuditAlarm ObjectOpenAuditAlarmW")]
        public static delegate*<ushort*, void*, ushort*, ushort*, void*, IntPtr, uint, uint, PRIVILEGE_SET*, int, int, int*, int> ObjectOpenAuditAlarm => &ObjectOpenAuditAlarmW;

        [NativeTypeName("#define ObjectPrivilegeAuditAlarm ObjectPrivilegeAuditAlarmW")]
        public static delegate*<ushort*, void*, IntPtr, uint, PRIVILEGE_SET*, int, int> ObjectPrivilegeAuditAlarm => &ObjectPrivilegeAuditAlarmW;

        [NativeTypeName("#define PrivilegedServiceAuditAlarm PrivilegedServiceAuditAlarmW")]
        public static delegate*<ushort*, ushort*, IntPtr, PRIVILEGE_SET*, int, int> PrivilegedServiceAuditAlarm => &PrivilegedServiceAuditAlarmW;

        [NativeTypeName("#define SetFileSecurity SetFileSecurityW")]
        public static delegate*<ushort*, uint, void*, int> SetFileSecurity => &SetFileSecurityW;
    }
}
