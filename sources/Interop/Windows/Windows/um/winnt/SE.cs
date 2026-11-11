// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SE
{
    /// <include file='SE.xml' path='doc/member[@name="SE.SE_GROUP_MANDATORY"]/*' />
    [NativeTypeName("#define SE_GROUP_MANDATORY (0x00000001L)")]
    public const int SE_GROUP_MANDATORY = (0x00000001);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_GROUP_ENABLED_BY_DEFAULT"]/*' />
    [NativeTypeName("#define SE_GROUP_ENABLED_BY_DEFAULT (0x00000002L)")]
    public const int SE_GROUP_ENABLED_BY_DEFAULT = (0x00000002);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_GROUP_ENABLED"]/*' />
    [NativeTypeName("#define SE_GROUP_ENABLED (0x00000004L)")]
    public const int SE_GROUP_ENABLED = (0x00000004);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_GROUP_OWNER"]/*' />
    [NativeTypeName("#define SE_GROUP_OWNER (0x00000008L)")]
    public const int SE_GROUP_OWNER = (0x00000008);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_GROUP_USE_FOR_DENY_ONLY"]/*' />
    [NativeTypeName("#define SE_GROUP_USE_FOR_DENY_ONLY (0x00000010L)")]
    public const int SE_GROUP_USE_FOR_DENY_ONLY = (0x00000010);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_GROUP_INTEGRITY"]/*' />
    [NativeTypeName("#define SE_GROUP_INTEGRITY (0x00000020L)")]
    public const int SE_GROUP_INTEGRITY = (0x00000020);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_GROUP_INTEGRITY_ENABLED"]/*' />
    [NativeTypeName("#define SE_GROUP_INTEGRITY_ENABLED (0x00000040L)")]
    public const int SE_GROUP_INTEGRITY_ENABLED = (0x00000040);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_GROUP_LOGON_ID"]/*' />
    [NativeTypeName("#define SE_GROUP_LOGON_ID (0xC0000000L)")]
    public const uint SE_GROUP_LOGON_ID = (0xC0000000);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_GROUP_RESOURCE"]/*' />
    [NativeTypeName("#define SE_GROUP_RESOURCE (0x20000000L)")]
    public const int SE_GROUP_RESOURCE = (0x20000000);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_GROUP_VALID_ATTRIBUTES"]/*' />
    [NativeTypeName("#define SE_GROUP_VALID_ATTRIBUTES (SE_GROUP_MANDATORY          | \\\r\n                                            SE_GROUP_ENABLED_BY_DEFAULT | \\\r\n                                            SE_GROUP_ENABLED            | \\\r\n                                            SE_GROUP_OWNER              | \\\r\n                                            SE_GROUP_USE_FOR_DENY_ONLY  | \\\r\n                                            SE_GROUP_LOGON_ID           | \\\r\n                                            SE_GROUP_RESOURCE           | \\\r\n                                            SE_GROUP_INTEGRITY          | \\\r\n                                            SE_GROUP_INTEGRITY_ENABLED)")]
    public const uint SE_GROUP_VALID_ATTRIBUTES = ((0x00000001) | (0x00000002) | (0x00000004) | (0x00000008) | (0x00000010) | (0xC0000000) | (0x20000000) | (0x00000020) | (0x00000040));

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_OWNER_DEFAULTED"]/*' />
    [NativeTypeName("#define SE_OWNER_DEFAULTED (0x0001)")]
    public const int SE_OWNER_DEFAULTED = (0x0001);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_GROUP_DEFAULTED"]/*' />
    [NativeTypeName("#define SE_GROUP_DEFAULTED (0x0002)")]
    public const int SE_GROUP_DEFAULTED = (0x0002);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_DACL_PRESENT"]/*' />
    [NativeTypeName("#define SE_DACL_PRESENT (0x0004)")]
    public const int SE_DACL_PRESENT = (0x0004);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_DACL_DEFAULTED"]/*' />
    [NativeTypeName("#define SE_DACL_DEFAULTED (0x0008)")]
    public const int SE_DACL_DEFAULTED = (0x0008);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SACL_PRESENT"]/*' />
    [NativeTypeName("#define SE_SACL_PRESENT (0x0010)")]
    public const int SE_SACL_PRESENT = (0x0010);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SACL_DEFAULTED"]/*' />
    [NativeTypeName("#define SE_SACL_DEFAULTED (0x0020)")]
    public const int SE_SACL_DEFAULTED = (0x0020);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_DACL_AUTO_INHERIT_REQ"]/*' />
    [NativeTypeName("#define SE_DACL_AUTO_INHERIT_REQ (0x0100)")]
    public const int SE_DACL_AUTO_INHERIT_REQ = (0x0100);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SACL_AUTO_INHERIT_REQ"]/*' />
    [NativeTypeName("#define SE_SACL_AUTO_INHERIT_REQ (0x0200)")]
    public const int SE_SACL_AUTO_INHERIT_REQ = (0x0200);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_DACL_AUTO_INHERITED"]/*' />
    [NativeTypeName("#define SE_DACL_AUTO_INHERITED (0x0400)")]
    public const int SE_DACL_AUTO_INHERITED = (0x0400);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SACL_AUTO_INHERITED"]/*' />
    [NativeTypeName("#define SE_SACL_AUTO_INHERITED (0x0800)")]
    public const int SE_SACL_AUTO_INHERITED = (0x0800);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_DACL_PROTECTED"]/*' />
    [NativeTypeName("#define SE_DACL_PROTECTED (0x1000)")]
    public const int SE_DACL_PROTECTED = (0x1000);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SACL_PROTECTED"]/*' />
    [NativeTypeName("#define SE_SACL_PROTECTED (0x2000)")]
    public const int SE_SACL_PROTECTED = (0x2000);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_RM_CONTROL_VALID"]/*' />
    [NativeTypeName("#define SE_RM_CONTROL_VALID (0x4000)")]
    public const int SE_RM_CONTROL_VALID = (0x4000);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SELF_RELATIVE"]/*' />
    [NativeTypeName("#define SE_SELF_RELATIVE (0x8000)")]
    public const int SE_SELF_RELATIVE = (0x8000);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_PRIVILEGE_ENABLED_BY_DEFAULT"]/*' />
    [NativeTypeName("#define SE_PRIVILEGE_ENABLED_BY_DEFAULT (0x00000001L)")]
    public const int SE_PRIVILEGE_ENABLED_BY_DEFAULT = (0x00000001);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_PRIVILEGE_ENABLED"]/*' />
    [NativeTypeName("#define SE_PRIVILEGE_ENABLED (0x00000002L)")]
    public const int SE_PRIVILEGE_ENABLED = (0x00000002);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_PRIVILEGE_REMOVED"]/*' />
    [NativeTypeName("#define SE_PRIVILEGE_REMOVED (0X00000004L)")]
    public const int SE_PRIVILEGE_REMOVED = (0X00000004);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_PRIVILEGE_USED_FOR_ACCESS"]/*' />
    [NativeTypeName("#define SE_PRIVILEGE_USED_FOR_ACCESS (0x80000000L)")]
    public const uint SE_PRIVILEGE_USED_FOR_ACCESS = (0x80000000);

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_PRIVILEGE_VALID_ATTRIBUTES"]/*' />
    [NativeTypeName("#define SE_PRIVILEGE_VALID_ATTRIBUTES (SE_PRIVILEGE_ENABLED_BY_DEFAULT | \\\r\n                                         SE_PRIVILEGE_ENABLED            | \\\r\n                                         SE_PRIVILEGE_REMOVED            | \\\r\n                                         SE_PRIVILEGE_USED_FOR_ACCESS)")]
    public const uint SE_PRIVILEGE_VALID_ATTRIBUTES = ((0x00000001) | (0x00000002) | (0X00000004) | (0x80000000));

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SECURITY_DESCRIPTOR_FLAG_NO_OWNER_ACE"]/*' />
    [NativeTypeName("#define SE_SECURITY_DESCRIPTOR_FLAG_NO_OWNER_ACE 0x00000001")]
    public const int SE_SECURITY_DESCRIPTOR_FLAG_NO_OWNER_ACE = 0x00000001;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SECURITY_DESCRIPTOR_FLAG_NO_LABEL_ACE"]/*' />
    [NativeTypeName("#define SE_SECURITY_DESCRIPTOR_FLAG_NO_LABEL_ACE 0x00000002")]
    public const int SE_SECURITY_DESCRIPTOR_FLAG_NO_LABEL_ACE = 0x00000002;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SECURITY_DESCRIPTOR_FLAG_NO_ACCESS_FILTER_ACE"]/*' />
    [NativeTypeName("#define SE_SECURITY_DESCRIPTOR_FLAG_NO_ACCESS_FILTER_ACE 0x00000004")]
    public const int SE_SECURITY_DESCRIPTOR_FLAG_NO_ACCESS_FILTER_ACE = 0x00000004;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SECURITY_DESCRIPTOR_VALID_FLAGS"]/*' />
    [NativeTypeName("#define SE_SECURITY_DESCRIPTOR_VALID_FLAGS 0x00000007")]
    public const int SE_SECURITY_DESCRIPTOR_VALID_FLAGS = 0x00000007;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ACCESS_CHECK_FLAG_NO_LEARNING_MODE_LOGGING"]/*' />
    [NativeTypeName("#define SE_ACCESS_CHECK_FLAG_NO_LEARNING_MODE_LOGGING 0x00000008")]
    public const int SE_ACCESS_CHECK_FLAG_NO_LEARNING_MODE_LOGGING = 0x00000008;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ACCESS_CHECK_VALID_FLAGS"]/*' />
    [NativeTypeName("#define SE_ACCESS_CHECK_VALID_FLAGS 0x00000008")]
    public const int SE_ACCESS_CHECK_VALID_FLAGS = 0x00000008;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_CREATE_TOKEN_NAME"]/*' />
    [NativeTypeName("#define SE_CREATE_TOKEN_NAME TEXT(\"SeCreateTokenPrivilege\")")]
    public const string SE_CREATE_TOKEN_NAME = "SeCreateTokenPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ASSIGNPRIMARYTOKEN_NAME"]/*' />
    [NativeTypeName("#define SE_ASSIGNPRIMARYTOKEN_NAME TEXT(\"SeAssignPrimaryTokenPrivilege\")")]
    public const string SE_ASSIGNPRIMARYTOKEN_NAME = "SeAssignPrimaryTokenPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_LOCK_MEMORY_NAME"]/*' />
    [NativeTypeName("#define SE_LOCK_MEMORY_NAME TEXT(\"SeLockMemoryPrivilege\")")]
    public const string SE_LOCK_MEMORY_NAME = "SeLockMemoryPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_INCREASE_QUOTA_NAME"]/*' />
    [NativeTypeName("#define SE_INCREASE_QUOTA_NAME TEXT(\"SeIncreaseQuotaPrivilege\")")]
    public const string SE_INCREASE_QUOTA_NAME = "SeIncreaseQuotaPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_UNSOLICITED_INPUT_NAME"]/*' />
    [NativeTypeName("#define SE_UNSOLICITED_INPUT_NAME TEXT(\"SeUnsolicitedInputPrivilege\")")]
    public const string SE_UNSOLICITED_INPUT_NAME = "SeUnsolicitedInputPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_MACHINE_ACCOUNT_NAME"]/*' />
    [NativeTypeName("#define SE_MACHINE_ACCOUNT_NAME TEXT(\"SeMachineAccountPrivilege\")")]
    public const string SE_MACHINE_ACCOUNT_NAME = "SeMachineAccountPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_TCB_NAME"]/*' />
    [NativeTypeName("#define SE_TCB_NAME TEXT(\"SeTcbPrivilege\")")]
    public const string SE_TCB_NAME = "SeTcbPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SECURITY_NAME"]/*' />
    [NativeTypeName("#define SE_SECURITY_NAME TEXT(\"SeSecurityPrivilege\")")]
    public const string SE_SECURITY_NAME = "SeSecurityPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_TAKE_OWNERSHIP_NAME"]/*' />
    [NativeTypeName("#define SE_TAKE_OWNERSHIP_NAME TEXT(\"SeTakeOwnershipPrivilege\")")]
    public const string SE_TAKE_OWNERSHIP_NAME = "SeTakeOwnershipPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_LOAD_DRIVER_NAME"]/*' />
    [NativeTypeName("#define SE_LOAD_DRIVER_NAME TEXT(\"SeLoadDriverPrivilege\")")]
    public const string SE_LOAD_DRIVER_NAME = "SeLoadDriverPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SYSTEM_PROFILE_NAME"]/*' />
    [NativeTypeName("#define SE_SYSTEM_PROFILE_NAME TEXT(\"SeSystemProfilePrivilege\")")]
    public const string SE_SYSTEM_PROFILE_NAME = "SeSystemProfilePrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SYSTEMTIME_NAME"]/*' />
    [NativeTypeName("#define SE_SYSTEMTIME_NAME TEXT(\"SeSystemtimePrivilege\")")]
    public const string SE_SYSTEMTIME_NAME = "SeSystemtimePrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_PROF_SINGLE_PROCESS_NAME"]/*' />
    [NativeTypeName("#define SE_PROF_SINGLE_PROCESS_NAME TEXT(\"SeProfileSingleProcessPrivilege\")")]
    public const string SE_PROF_SINGLE_PROCESS_NAME = "SeProfileSingleProcessPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_INC_BASE_PRIORITY_NAME"]/*' />
    [NativeTypeName("#define SE_INC_BASE_PRIORITY_NAME TEXT(\"SeIncreaseBasePriorityPrivilege\")")]
    public const string SE_INC_BASE_PRIORITY_NAME = "SeIncreaseBasePriorityPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_CREATE_PAGEFILE_NAME"]/*' />
    [NativeTypeName("#define SE_CREATE_PAGEFILE_NAME TEXT(\"SeCreatePagefilePrivilege\")")]
    public const string SE_CREATE_PAGEFILE_NAME = "SeCreatePagefilePrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_CREATE_PERMANENT_NAME"]/*' />
    [NativeTypeName("#define SE_CREATE_PERMANENT_NAME TEXT(\"SeCreatePermanentPrivilege\")")]
    public const string SE_CREATE_PERMANENT_NAME = "SeCreatePermanentPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_BACKUP_NAME"]/*' />
    [NativeTypeName("#define SE_BACKUP_NAME TEXT(\"SeBackupPrivilege\")")]
    public const string SE_BACKUP_NAME = "SeBackupPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_RESTORE_NAME"]/*' />
    [NativeTypeName("#define SE_RESTORE_NAME TEXT(\"SeRestorePrivilege\")")]
    public const string SE_RESTORE_NAME = "SeRestorePrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SHUTDOWN_NAME"]/*' />
    [NativeTypeName("#define SE_SHUTDOWN_NAME TEXT(\"SeShutdownPrivilege\")")]
    public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_DEBUG_NAME"]/*' />
    [NativeTypeName("#define SE_DEBUG_NAME TEXT(\"SeDebugPrivilege\")")]
    public const string SE_DEBUG_NAME = "SeDebugPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_AUDIT_NAME"]/*' />
    [NativeTypeName("#define SE_AUDIT_NAME TEXT(\"SeAuditPrivilege\")")]
    public const string SE_AUDIT_NAME = "SeAuditPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SYSTEM_ENVIRONMENT_NAME"]/*' />
    [NativeTypeName("#define SE_SYSTEM_ENVIRONMENT_NAME TEXT(\"SeSystemEnvironmentPrivilege\")")]
    public const string SE_SYSTEM_ENVIRONMENT_NAME = "SeSystemEnvironmentPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_CHANGE_NOTIFY_NAME"]/*' />
    [NativeTypeName("#define SE_CHANGE_NOTIFY_NAME TEXT(\"SeChangeNotifyPrivilege\")")]
    public const string SE_CHANGE_NOTIFY_NAME = "SeChangeNotifyPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_REMOTE_SHUTDOWN_NAME"]/*' />
    [NativeTypeName("#define SE_REMOTE_SHUTDOWN_NAME TEXT(\"SeRemoteShutdownPrivilege\")")]
    public const string SE_REMOTE_SHUTDOWN_NAME = "SeRemoteShutdownPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_UNDOCK_NAME"]/*' />
    [NativeTypeName("#define SE_UNDOCK_NAME TEXT(\"SeUndockPrivilege\")")]
    public const string SE_UNDOCK_NAME = "SeUndockPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SYNC_AGENT_NAME"]/*' />
    [NativeTypeName("#define SE_SYNC_AGENT_NAME TEXT(\"SeSyncAgentPrivilege\")")]
    public const string SE_SYNC_AGENT_NAME = "SeSyncAgentPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ENABLE_DELEGATION_NAME"]/*' />
    [NativeTypeName("#define SE_ENABLE_DELEGATION_NAME TEXT(\"SeEnableDelegationPrivilege\")")]
    public const string SE_ENABLE_DELEGATION_NAME = "SeEnableDelegationPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_MANAGE_VOLUME_NAME"]/*' />
    [NativeTypeName("#define SE_MANAGE_VOLUME_NAME TEXT(\"SeManageVolumePrivilege\")")]
    public const string SE_MANAGE_VOLUME_NAME = "SeManageVolumePrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_IMPERSONATE_NAME"]/*' />
    [NativeTypeName("#define SE_IMPERSONATE_NAME TEXT(\"SeImpersonatePrivilege\")")]
    public const string SE_IMPERSONATE_NAME = "SeImpersonatePrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_CREATE_GLOBAL_NAME"]/*' />
    [NativeTypeName("#define SE_CREATE_GLOBAL_NAME TEXT(\"SeCreateGlobalPrivilege\")")]
    public const string SE_CREATE_GLOBAL_NAME = "SeCreateGlobalPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_TRUSTED_CREDMAN_ACCESS_NAME"]/*' />
    [NativeTypeName("#define SE_TRUSTED_CREDMAN_ACCESS_NAME TEXT(\"SeTrustedCredManAccessPrivilege\")")]
    public const string SE_TRUSTED_CREDMAN_ACCESS_NAME = "SeTrustedCredManAccessPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_RELABEL_NAME"]/*' />
    [NativeTypeName("#define SE_RELABEL_NAME TEXT(\"SeRelabelPrivilege\")")]
    public const string SE_RELABEL_NAME = "SeRelabelPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_INC_WORKING_SET_NAME"]/*' />
    [NativeTypeName("#define SE_INC_WORKING_SET_NAME TEXT(\"SeIncreaseWorkingSetPrivilege\")")]
    public const string SE_INC_WORKING_SET_NAME = "SeIncreaseWorkingSetPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_TIME_ZONE_NAME"]/*' />
    [NativeTypeName("#define SE_TIME_ZONE_NAME TEXT(\"SeTimeZonePrivilege\")")]
    public const string SE_TIME_ZONE_NAME = "SeTimeZonePrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_CREATE_SYMBOLIC_LINK_NAME"]/*' />
    [NativeTypeName("#define SE_CREATE_SYMBOLIC_LINK_NAME TEXT(\"SeCreateSymbolicLinkPrivilege\")")]
    public const string SE_CREATE_SYMBOLIC_LINK_NAME = "SeCreateSymbolicLinkPrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_DELEGATE_SESSION_USER_IMPERSONATE_NAME"]/*' />
    [NativeTypeName("#define SE_DELEGATE_SESSION_USER_IMPERSONATE_NAME TEXT(\"SeDelegateSessionUserImpersonatePrivilege\")")]
    public const string SE_DELEGATE_SESSION_USER_IMPERSONATE_NAME = "SeDelegateSessionUserImpersonatePrivilege";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ACTIVATE_AS_USER_CAPABILITY"]/*' />
    [NativeTypeName("#define SE_ACTIVATE_AS_USER_CAPABILITY L\"activateAsUser\"")]
    public const string SE_ACTIVATE_AS_USER_CAPABILITY = "activateAsUser";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_CONSTRAINED_IMPERSONATION_CAPABILITY"]/*' />
    [NativeTypeName("#define SE_CONSTRAINED_IMPERSONATION_CAPABILITY L\"constrainedImpersonation\"")]
    public const string SE_CONSTRAINED_IMPERSONATION_CAPABILITY = "constrainedImpersonation";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SESSION_IMPERSONATION_CAPABILITY"]/*' />
    [NativeTypeName("#define SE_SESSION_IMPERSONATION_CAPABILITY L\"sessionImpersonation\"")]
    public const string SE_SESSION_IMPERSONATION_CAPABILITY = "sessionImpersonation";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_MUMA_CAPABILITY"]/*' />
    [NativeTypeName("#define SE_MUMA_CAPABILITY L\"muma\"")]
    public const string SE_MUMA_CAPABILITY = "muma";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_DEVELOPMENT_MODE_NETWORK_CAPABILITY"]/*' />
    [NativeTypeName("#define SE_DEVELOPMENT_MODE_NETWORK_CAPABILITY L\"developmentModeNetwork\"")]
    public const string SE_DEVELOPMENT_MODE_NETWORK_CAPABILITY = "developmentModeNetwork";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_LEARNING_MODE_LOGGING_CAPABILITY"]/*' />
    [NativeTypeName("#define SE_LEARNING_MODE_LOGGING_CAPABILITY L\"learningModeLogging\"")]
    public const string SE_LEARNING_MODE_LOGGING_CAPABILITY = "learningModeLogging";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_PERMISSIVE_LEARNING_MODE_CAPABILITY"]/*' />
    [NativeTypeName("#define SE_PERMISSIVE_LEARNING_MODE_CAPABILITY L\"permissiveLearningMode\"")]
    public const string SE_PERMISSIVE_LEARNING_MODE_CAPABILITY = "permissiveLearningMode";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_APP_SILO_VOLUME_ROOT_MINIMAL_CAPABILITY"]/*' />
    [NativeTypeName("#define SE_APP_SILO_VOLUME_ROOT_MINIMAL_CAPABILITY L\"isolatedWin32-volumeRootMinimal\"")]
    public const string SE_APP_SILO_VOLUME_ROOT_MINIMAL_CAPABILITY = "isolatedWin32-volumeRootMinimal";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_APP_SILO_PROFILES_ROOT_MINIMAL_CAPABILITY"]/*' />
    [NativeTypeName("#define SE_APP_SILO_PROFILES_ROOT_MINIMAL_CAPABILITY L\"isolatedWin32-profilesRootMinimal\"")]
    public const string SE_APP_SILO_PROFILES_ROOT_MINIMAL_CAPABILITY = "isolatedWin32-profilesRootMinimal";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_APP_SILO_USER_PROFILE_MINIMAL_CAPABILITY"]/*' />
    [NativeTypeName("#define SE_APP_SILO_USER_PROFILE_MINIMAL_CAPABILITY L\"isolatedWin32-userProfileMinimal\"")]
    public const string SE_APP_SILO_USER_PROFILE_MINIMAL_CAPABILITY = "isolatedWin32-userProfileMinimal";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_APP_SILO_PROMPT_FOR_ACCESS_CAPABILITY"]/*' />
    [NativeTypeName("#define SE_APP_SILO_PROMPT_FOR_ACCESS_CAPABILITY L\"isolatedWin32-promptForAccess\"")]
    public const string SE_APP_SILO_PROMPT_FOR_ACCESS_CAPABILITY = "isolatedWin32-promptForAccess";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_APP_SILO_ACCESS_TO_PUBLISHER_DIRECTORY_CAPABILITY"]/*' />
    [NativeTypeName("#define SE_APP_SILO_ACCESS_TO_PUBLISHER_DIRECTORY_CAPABILITY L\"isolatedWin32-accessToPublisherDirectory\"")]
    public const string SE_APP_SILO_ACCESS_TO_PUBLISHER_DIRECTORY_CAPABILITY = "isolatedWin32-accessToPublisherDirectory";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_APP_SILO_PRINT_CAPABILITY"]/*' />
    [NativeTypeName("#define SE_APP_SILO_PRINT_CAPABILITY L\"isolatedWin32-print\"")]
    public const string SE_APP_SILO_PRINT_CAPABILITY = "isolatedWin32-print";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_APP_SILO_SCANNER_CAPABILITY"]/*' />
    [NativeTypeName("#define SE_APP_SILO_SCANNER_CAPABILITY L\"isolatedWin32-scanner\"")]
    public const string SE_APP_SILO_SCANNER_CAPABILITY = "isolatedWin32-scanner";

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_UNCHECKED"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_UNCHECKED 0x00000000")]
    public const int SE_SIGNING_LEVEL_UNCHECKED = 0x00000000;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_UNSIGNED"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_UNSIGNED 0x00000001")]
    public const int SE_SIGNING_LEVEL_UNSIGNED = 0x00000001;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_ENTERPRISE"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_ENTERPRISE 0x00000002")]
    public const int SE_SIGNING_LEVEL_ENTERPRISE = 0x00000002;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_CUSTOM_1"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_CUSTOM_1 0x00000003")]
    public const int SE_SIGNING_LEVEL_CUSTOM_1 = 0x00000003;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_DEVELOPER"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_DEVELOPER SE_SIGNING_LEVEL_CUSTOM_1")]
    public const int SE_SIGNING_LEVEL_DEVELOPER = 0x00000003;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_AUTHENTICODE"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_AUTHENTICODE 0x00000004")]
    public const int SE_SIGNING_LEVEL_AUTHENTICODE = 0x00000004;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_CUSTOM_2"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_CUSTOM_2 0x00000005")]
    public const int SE_SIGNING_LEVEL_CUSTOM_2 = 0x00000005;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_STORE"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_STORE 0x00000006")]
    public const int SE_SIGNING_LEVEL_STORE = 0x00000006;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_CUSTOM_3"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_CUSTOM_3 0x00000007")]
    public const int SE_SIGNING_LEVEL_CUSTOM_3 = 0x00000007;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_ANTIMALWARE"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_ANTIMALWARE SE_SIGNING_LEVEL_CUSTOM_3")]
    public const int SE_SIGNING_LEVEL_ANTIMALWARE = 0x00000007;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_MICROSOFT"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_MICROSOFT 0x00000008")]
    public const int SE_SIGNING_LEVEL_MICROSOFT = 0x00000008;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_CUSTOM_4"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_CUSTOM_4 0x00000009")]
    public const int SE_SIGNING_LEVEL_CUSTOM_4 = 0x00000009;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_CUSTOM_5"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_CUSTOM_5 0x0000000A")]
    public const int SE_SIGNING_LEVEL_CUSTOM_5 = 0x0000000A;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_DYNAMIC_CODEGEN"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_DYNAMIC_CODEGEN 0x0000000B")]
    public const int SE_SIGNING_LEVEL_DYNAMIC_CODEGEN = 0x0000000B;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_WINDOWS"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_WINDOWS 0x0000000C")]
    public const int SE_SIGNING_LEVEL_WINDOWS = 0x0000000C;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_CUSTOM_7"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_CUSTOM_7 0x0000000D")]
    public const int SE_SIGNING_LEVEL_CUSTOM_7 = 0x0000000D;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_WINDOWS_TCB"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_WINDOWS_TCB 0x0000000E")]
    public const int SE_SIGNING_LEVEL_WINDOWS_TCB = 0x0000000E;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_SIGNING_LEVEL_CUSTOM_6"]/*' />
    [NativeTypeName("#define SE_SIGNING_LEVEL_CUSTOM_6 0x0000000F")]
    public const int SE_SIGNING_LEVEL_CUSTOM_6 = 0x0000000F;
}
