// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.SECURITY_IMPERSONATION_LEVEL;

namespace TerraFX.Interop.Windows;

public static unsafe partial class SECURITY
{
    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MAX_SID_SIZE"]/*' />
    [NativeTypeName("#define SECURITY_MAX_SID_SIZE (sizeof(SID) - sizeof(DWORD) + (SID_MAX_SUB_AUTHORITIES * sizeof(DWORD)))")]
    public const uint SECURITY_MAX_SID_SIZE = (12 - 4 + ((15) * 4));

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MAX_SID_STRING_CHARACTERS"]/*' />
    [NativeTypeName("#define SECURITY_MAX_SID_STRING_CHARACTERS (2 + 4 + 15 + (11 * SID_MAX_SUB_AUTHORITIES) + 1)")]
    public const int SECURITY_MAX_SID_STRING_CHARACTERS = (2 + 4 + 15 + (11 * (15)) + 1);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_NULL_RID"]/*' />
    [NativeTypeName("#define SECURITY_NULL_RID (0x00000000L)")]
    public const int SECURITY_NULL_RID = (0x00000000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_WORLD_RID"]/*' />
    [NativeTypeName("#define SECURITY_WORLD_RID (0x00000000L)")]
    public const int SECURITY_WORLD_RID = (0x00000000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_LOCAL_RID"]/*' />
    [NativeTypeName("#define SECURITY_LOCAL_RID (0x00000000L)")]
    public const int SECURITY_LOCAL_RID = (0x00000000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_LOCAL_LOGON_RID"]/*' />
    [NativeTypeName("#define SECURITY_LOCAL_LOGON_RID (0x00000001L)")]
    public const int SECURITY_LOCAL_LOGON_RID = (0x00000001);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CREATOR_OWNER_RID"]/*' />
    [NativeTypeName("#define SECURITY_CREATOR_OWNER_RID (0x00000000L)")]
    public const int SECURITY_CREATOR_OWNER_RID = (0x00000000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CREATOR_GROUP_RID"]/*' />
    [NativeTypeName("#define SECURITY_CREATOR_GROUP_RID (0x00000001L)")]
    public const int SECURITY_CREATOR_GROUP_RID = (0x00000001);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CREATOR_OWNER_SERVER_RID"]/*' />
    [NativeTypeName("#define SECURITY_CREATOR_OWNER_SERVER_RID (0x00000002L)")]
    public const int SECURITY_CREATOR_OWNER_SERVER_RID = (0x00000002);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CREATOR_GROUP_SERVER_RID"]/*' />
    [NativeTypeName("#define SECURITY_CREATOR_GROUP_SERVER_RID (0x00000003L)")]
    public const int SECURITY_CREATOR_GROUP_SERVER_RID = (0x00000003);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CREATOR_OWNER_RIGHTS_RID"]/*' />
    [NativeTypeName("#define SECURITY_CREATOR_OWNER_RIGHTS_RID (0x00000004L)")]
    public const int SECURITY_CREATOR_OWNER_RIGHTS_RID = (0x00000004);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_DIALUP_RID"]/*' />
    [NativeTypeName("#define SECURITY_DIALUP_RID (0x00000001L)")]
    public const int SECURITY_DIALUP_RID = (0x00000001);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_NETWORK_RID"]/*' />
    [NativeTypeName("#define SECURITY_NETWORK_RID (0x00000002L)")]
    public const int SECURITY_NETWORK_RID = (0x00000002);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_BATCH_RID"]/*' />
    [NativeTypeName("#define SECURITY_BATCH_RID (0x00000003L)")]
    public const int SECURITY_BATCH_RID = (0x00000003);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_INTERACTIVE_RID"]/*' />
    [NativeTypeName("#define SECURITY_INTERACTIVE_RID (0x00000004L)")]
    public const int SECURITY_INTERACTIVE_RID = (0x00000004);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_LOGON_IDS_RID"]/*' />
    [NativeTypeName("#define SECURITY_LOGON_IDS_RID (0x00000005L)")]
    public const int SECURITY_LOGON_IDS_RID = (0x00000005);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_LOGON_IDS_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_LOGON_IDS_RID_COUNT (3L)")]
    public const int SECURITY_LOGON_IDS_RID_COUNT = (3);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_SERVICE_RID"]/*' />
    [NativeTypeName("#define SECURITY_SERVICE_RID (0x00000006L)")]
    public const int SECURITY_SERVICE_RID = (0x00000006);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANONYMOUS_LOGON_RID"]/*' />
    [NativeTypeName("#define SECURITY_ANONYMOUS_LOGON_RID (0x00000007L)")]
    public const int SECURITY_ANONYMOUS_LOGON_RID = (0x00000007);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PROXY_RID"]/*' />
    [NativeTypeName("#define SECURITY_PROXY_RID (0x00000008L)")]
    public const int SECURITY_PROXY_RID = (0x00000008);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ENTERPRISE_CONTROLLERS_RID"]/*' />
    [NativeTypeName("#define SECURITY_ENTERPRISE_CONTROLLERS_RID (0x00000009L)")]
    public const int SECURITY_ENTERPRISE_CONTROLLERS_RID = (0x00000009);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_SERVER_LOGON_RID"]/*' />
    [NativeTypeName("#define SECURITY_SERVER_LOGON_RID SECURITY_ENTERPRISE_CONTROLLERS_RID")]
    public const int SECURITY_SERVER_LOGON_RID = (0x00000009);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PRINCIPAL_SELF_RID"]/*' />
    [NativeTypeName("#define SECURITY_PRINCIPAL_SELF_RID (0x0000000AL)")]
    public const int SECURITY_PRINCIPAL_SELF_RID = (0x0000000A);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_AUTHENTICATED_USER_RID"]/*' />
    [NativeTypeName("#define SECURITY_AUTHENTICATED_USER_RID (0x0000000BL)")]
    public const int SECURITY_AUTHENTICATED_USER_RID = (0x0000000B);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_RESTRICTED_CODE_RID"]/*' />
    [NativeTypeName("#define SECURITY_RESTRICTED_CODE_RID (0x0000000CL)")]
    public const int SECURITY_RESTRICTED_CODE_RID = (0x0000000C);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_TERMINAL_SERVER_RID"]/*' />
    [NativeTypeName("#define SECURITY_TERMINAL_SERVER_RID (0x0000000DL)")]
    public const int SECURITY_TERMINAL_SERVER_RID = (0x0000000D);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_REMOTE_LOGON_RID"]/*' />
    [NativeTypeName("#define SECURITY_REMOTE_LOGON_RID (0x0000000EL)")]
    public const int SECURITY_REMOTE_LOGON_RID = (0x0000000E);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_THIS_ORGANIZATION_RID"]/*' />
    [NativeTypeName("#define SECURITY_THIS_ORGANIZATION_RID (0x0000000FL)")]
    public const int SECURITY_THIS_ORGANIZATION_RID = (0x0000000F);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_IUSER_RID"]/*' />
    [NativeTypeName("#define SECURITY_IUSER_RID (0x00000011L)")]
    public const int SECURITY_IUSER_RID = (0x00000011);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_LOCAL_SYSTEM_RID"]/*' />
    [NativeTypeName("#define SECURITY_LOCAL_SYSTEM_RID (0x00000012L)")]
    public const int SECURITY_LOCAL_SYSTEM_RID = (0x00000012);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_LOCAL_SERVICE_RID"]/*' />
    [NativeTypeName("#define SECURITY_LOCAL_SERVICE_RID (0x00000013L)")]
    public const int SECURITY_LOCAL_SERVICE_RID = (0x00000013);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_NETWORK_SERVICE_RID"]/*' />
    [NativeTypeName("#define SECURITY_NETWORK_SERVICE_RID (0x00000014L)")]
    public const int SECURITY_NETWORK_SERVICE_RID = (0x00000014);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_NT_NON_UNIQUE"]/*' />
    [NativeTypeName("#define SECURITY_NT_NON_UNIQUE (0x00000015L)")]
    public const int SECURITY_NT_NON_UNIQUE = (0x00000015);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_NT_NON_UNIQUE_SUB_AUTH_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_NT_NON_UNIQUE_SUB_AUTH_COUNT (3L)")]
    public const int SECURITY_NT_NON_UNIQUE_SUB_AUTH_COUNT = (3);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ENTERPRISE_READONLY_CONTROLLERS_RID"]/*' />
    [NativeTypeName("#define SECURITY_ENTERPRISE_READONLY_CONTROLLERS_RID (0x00000016L)")]
    public const int SECURITY_ENTERPRISE_READONLY_CONTROLLERS_RID = (0x00000016);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_BUILTIN_DOMAIN_RID"]/*' />
    [NativeTypeName("#define SECURITY_BUILTIN_DOMAIN_RID (0x00000020L)")]
    public const int SECURITY_BUILTIN_DOMAIN_RID = (0x00000020);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_WRITE_RESTRICTED_CODE_RID"]/*' />
    [NativeTypeName("#define SECURITY_WRITE_RESTRICTED_CODE_RID (0x00000021L)")]
    public const int SECURITY_WRITE_RESTRICTED_CODE_RID = (0x00000021);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PACKAGE_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_PACKAGE_BASE_RID (0x00000040L)")]
    public const int SECURITY_PACKAGE_BASE_RID = (0x00000040);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PACKAGE_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_PACKAGE_RID_COUNT (2L)")]
    public const int SECURITY_PACKAGE_RID_COUNT = (2);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PACKAGE_NTLM_RID"]/*' />
    [NativeTypeName("#define SECURITY_PACKAGE_NTLM_RID (0x0000000AL)")]
    public const int SECURITY_PACKAGE_NTLM_RID = (0x0000000A);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PACKAGE_SCHANNEL_RID"]/*' />
    [NativeTypeName("#define SECURITY_PACKAGE_SCHANNEL_RID (0x0000000EL)")]
    public const int SECURITY_PACKAGE_SCHANNEL_RID = (0x0000000E);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PACKAGE_DIGEST_RID"]/*' />
    [NativeTypeName("#define SECURITY_PACKAGE_DIGEST_RID (0x00000015L)")]
    public const int SECURITY_PACKAGE_DIGEST_RID = (0x00000015);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CRED_TYPE_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_CRED_TYPE_BASE_RID (0x00000041L)")]
    public const int SECURITY_CRED_TYPE_BASE_RID = (0x00000041);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CRED_TYPE_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_CRED_TYPE_RID_COUNT (2L)")]
    public const int SECURITY_CRED_TYPE_RID_COUNT = (2);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CRED_TYPE_THIS_ORG_CERT_RID"]/*' />
    [NativeTypeName("#define SECURITY_CRED_TYPE_THIS_ORG_CERT_RID (0x00000001L)")]
    public const int SECURITY_CRED_TYPE_THIS_ORG_CERT_RID = (0x00000001);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MIN_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_MIN_BASE_RID (0x00000050L)")]
    public const int SECURITY_MIN_BASE_RID = (0x00000050);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_SERVICE_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_SERVICE_ID_BASE_RID (0x00000050L)")]
    public const int SECURITY_SERVICE_ID_BASE_RID = (0x00000050);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_SERVICE_ID_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_SERVICE_ID_RID_COUNT (6L)")]
    public const int SECURITY_SERVICE_ID_RID_COUNT = (6);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_RESERVED_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_RESERVED_ID_BASE_RID (0x00000051L)")]
    public const int SECURITY_RESERVED_ID_BASE_RID = (0x00000051);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_APPPOOL_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_APPPOOL_ID_BASE_RID (0x00000052L)")]
    public const int SECURITY_APPPOOL_ID_BASE_RID = (0x00000052);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_APPPOOL_ID_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_APPPOOL_ID_RID_COUNT (6L)")]
    public const int SECURITY_APPPOOL_ID_RID_COUNT = (6);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_VIRTUALSERVER_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_VIRTUALSERVER_ID_BASE_RID (0x00000053L)")]
    public const int SECURITY_VIRTUALSERVER_ID_BASE_RID = (0x00000053);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_VIRTUALSERVER_ID_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_VIRTUALSERVER_ID_RID_COUNT (6L)")]
    public const int SECURITY_VIRTUALSERVER_ID_RID_COUNT = (6);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_USERMODEDRIVERHOST_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_USERMODEDRIVERHOST_ID_BASE_RID (0x00000054L)")]
    public const int SECURITY_USERMODEDRIVERHOST_ID_BASE_RID = (0x00000054);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_USERMODEDRIVERHOST_ID_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_USERMODEDRIVERHOST_ID_RID_COUNT (6L)")]
    public const int SECURITY_USERMODEDRIVERHOST_ID_RID_COUNT = (6);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_BASE_RID (0x00000055L)")]
    public const int SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_BASE_RID = (0x00000055);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_RID_COUNT (6L)")]
    public const int SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_RID_COUNT = (6);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_WMIHOST_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_WMIHOST_ID_BASE_RID (0x00000056L)")]
    public const int SECURITY_WMIHOST_ID_BASE_RID = (0x00000056);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_WMIHOST_ID_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_WMIHOST_ID_RID_COUNT (6L)")]
    public const int SECURITY_WMIHOST_ID_RID_COUNT = (6);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_TASK_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_TASK_ID_BASE_RID (0x00000057L)")]
    public const int SECURITY_TASK_ID_BASE_RID = (0x00000057);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_NFS_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_NFS_ID_BASE_RID (0x00000058L)")]
    public const int SECURITY_NFS_ID_BASE_RID = (0x00000058);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_COM_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_COM_ID_BASE_RID (0x00000059L)")]
    public const int SECURITY_COM_ID_BASE_RID = (0x00000059);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_WINDOW_MANAGER_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_WINDOW_MANAGER_BASE_RID (0x0000005AL)")]
    public const int SECURITY_WINDOW_MANAGER_BASE_RID = (0x0000005A);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_RDV_GFX_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_RDV_GFX_BASE_RID (0x0000005BL)")]
    public const int SECURITY_RDV_GFX_BASE_RID = (0x0000005B);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_DASHOST_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_DASHOST_ID_BASE_RID (0x0000005CL)")]
    public const int SECURITY_DASHOST_ID_BASE_RID = (0x0000005C);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_DASHOST_ID_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_DASHOST_ID_RID_COUNT (6L)")]
    public const int SECURITY_DASHOST_ID_RID_COUNT = (6);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_USERMANAGER_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_USERMANAGER_ID_BASE_RID (0x0000005DL)")]
    public const int SECURITY_USERMANAGER_ID_BASE_RID = (0x0000005D);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_USERMANAGER_ID_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_USERMANAGER_ID_RID_COUNT (6L)")]
    public const int SECURITY_USERMANAGER_ID_RID_COUNT = (6);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_WINRM_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_WINRM_ID_BASE_RID (0x0000005EL)")]
    public const int SECURITY_WINRM_ID_BASE_RID = (0x0000005E);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_WINRM_ID_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_WINRM_ID_RID_COUNT (6L)")]
    public const int SECURITY_WINRM_ID_RID_COUNT = (6);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CCG_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_CCG_ID_BASE_RID (0x0000005FL)")]
    public const int SECURITY_CCG_ID_BASE_RID = (0x0000005F);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_UMFD_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_UMFD_BASE_RID (0x00000060L)")]
    public const int SECURITY_UMFD_BASE_RID = (0x00000060);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_UNIQUIFIED_SERVICE_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_UNIQUIFIED_SERVICE_BASE_RID (0x00000061L)")]
    public const int SECURITY_UNIQUIFIED_SERVICE_BASE_RID = (0x00000061);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_VIRTUALACCOUNT_ID_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_VIRTUALACCOUNT_ID_RID_COUNT (6L)")]
    public const int SECURITY_VIRTUALACCOUNT_ID_RID_COUNT = (6);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_EDGE_CLOUD_INFRASTRUCTURE_SERVICE_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_EDGE_CLOUD_INFRASTRUCTURE_SERVICE_ID_BASE_RID (0x00000062L)")]
    public const int SECURITY_EDGE_CLOUD_INFRASTRUCTURE_SERVICE_ID_BASE_RID = (0x00000062);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_RESTRICTED_SERVICES_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_RESTRICTED_SERVICES_BASE_RID (0x00000063L)")]
    public const int SECURITY_RESTRICTED_SERVICES_BASE_RID = (0x00000063);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_RESTRICTED_SERVICES_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_RESTRICTED_SERVICES_RID_COUNT (6L)")]
    public const int SECURITY_RESTRICTED_SERVICES_RID_COUNT = (6);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_SHADOWADMINACCOUNT_RID"]/*' />
    [NativeTypeName("#define SECURITY_SHADOWADMINACCOUNT_RID (0x00000064L)")]
    public const int SECURITY_SHADOWADMINACCOUNT_RID = (0x00000064);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_AGENTIC_PLATFORM_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_AGENTIC_PLATFORM_BASE_RID (0x00000065L)")]
    public const int SECURITY_AGENTIC_PLATFORM_BASE_RID = (0x00000065);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MAX_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_MAX_BASE_RID (0x0000006FL)")]
    public const int SECURITY_MAX_BASE_RID = (0x0000006F);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MAX_ALWAYS_FILTERED"]/*' />
    [NativeTypeName("#define SECURITY_MAX_ALWAYS_FILTERED (0x000003E7L)")]
    public const int SECURITY_MAX_ALWAYS_FILTERED = (0x000003E7);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MIN_NEVER_FILTERED"]/*' />
    [NativeTypeName("#define SECURITY_MIN_NEVER_FILTERED (0x000003E8L)")]
    public const int SECURITY_MIN_NEVER_FILTERED = (0x000003E8);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_OTHER_ORGANIZATION_RID"]/*' />
    [NativeTypeName("#define SECURITY_OTHER_ORGANIZATION_RID (0x000003E8L)")]
    public const int SECURITY_OTHER_ORGANIZATION_RID = (0x000003E8);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_WINDOWSMOBILE_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_WINDOWSMOBILE_ID_BASE_RID (0x00000070L)")]
    public const int SECURITY_WINDOWSMOBILE_ID_BASE_RID = (0x00000070);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_INSTALLER_GROUP_CAPABILITY_BASE"]/*' />
    [NativeTypeName("#define SECURITY_INSTALLER_GROUP_CAPABILITY_BASE (0x20)")]
    public const int SECURITY_INSTALLER_GROUP_CAPABILITY_BASE = (0x20);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_INSTALLER_GROUP_CAPABILITY_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_INSTALLER_GROUP_CAPABILITY_RID_COUNT (9)")]
    public const int SECURITY_INSTALLER_GROUP_CAPABILITY_RID_COUNT = (9);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_INSTALLER_CAPABILITY_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_INSTALLER_CAPABILITY_RID_COUNT (10)")]
    public const int SECURITY_INSTALLER_CAPABILITY_RID_COUNT = (10);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_LOCAL_ACCOUNT_RID"]/*' />
    [NativeTypeName("#define SECURITY_LOCAL_ACCOUNT_RID (0x00000071L)")]
    public const int SECURITY_LOCAL_ACCOUNT_RID = (0x00000071);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_LOCAL_ACCOUNT_AND_ADMIN_RID"]/*' />
    [NativeTypeName("#define SECURITY_LOCAL_ACCOUNT_AND_ADMIN_RID (0x00000072L)")]
    public const int SECURITY_LOCAL_ACCOUNT_AND_ADMIN_RID = (0x00000072);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_APP_PACKAGE_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_APP_PACKAGE_BASE_RID (0x00000002L)")]
    public const int SECURITY_APP_PACKAGE_BASE_RID = (0x00000002);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_BUILTIN_APP_PACKAGE_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_BUILTIN_APP_PACKAGE_RID_COUNT (2L)")]
    public const int SECURITY_BUILTIN_APP_PACKAGE_RID_COUNT = (2);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_APP_PACKAGE_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_APP_PACKAGE_RID_COUNT (8L)")]
    public const int SECURITY_APP_PACKAGE_RID_COUNT = (8);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_BASE_RID (0x00000003L)")]
    public const int SECURITY_CAPABILITY_BASE_RID = (0x00000003);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_APP_RID"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_APP_RID (0x00000400L)")]
    public const int SECURITY_CAPABILITY_APP_RID = (0x00000400);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_APP_SILO_RID"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_APP_SILO_RID (0x00010000L)")]
    public const int SECURITY_CAPABILITY_APP_SILO_RID = (0x00010000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_BUILTIN_CAPABILITY_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_BUILTIN_CAPABILITY_RID_COUNT (2L)")]
    public const int SECURITY_BUILTIN_CAPABILITY_RID_COUNT = (2);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_RID_COUNT (5L)")]
    public const int SECURITY_CAPABILITY_RID_COUNT = (5);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PARENT_PACKAGE_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_PARENT_PACKAGE_RID_COUNT (SECURITY_APP_PACKAGE_RID_COUNT)")]
    public const int SECURITY_PARENT_PACKAGE_RID_COUNT = ((8));

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CHILD_PACKAGE_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_CHILD_PACKAGE_RID_COUNT (12L)")]
    public const int SECURITY_CHILD_PACKAGE_RID_COUNT = (12);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_BUILTIN_PACKAGE_ANY_PACKAGE"]/*' />
    [NativeTypeName("#define SECURITY_BUILTIN_PACKAGE_ANY_PACKAGE (0x00000001L)")]
    public const int SECURITY_BUILTIN_PACKAGE_ANY_PACKAGE = (0x00000001);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_BUILTIN_PACKAGE_ANY_RESTRICTED_PACKAGE"]/*' />
    [NativeTypeName("#define SECURITY_BUILTIN_PACKAGE_ANY_RESTRICTED_PACKAGE (0x00000002L)")]
    public const int SECURITY_BUILTIN_PACKAGE_ANY_RESTRICTED_PACKAGE = (0x00000002);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_INTERNET_CLIENT"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_INTERNET_CLIENT (0x00000001L)")]
    public const int SECURITY_CAPABILITY_INTERNET_CLIENT = (0x00000001);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_INTERNET_CLIENT_SERVER"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_INTERNET_CLIENT_SERVER (0x00000002L)")]
    public const int SECURITY_CAPABILITY_INTERNET_CLIENT_SERVER = (0x00000002);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_PRIVATE_NETWORK_CLIENT_SERVER"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_PRIVATE_NETWORK_CLIENT_SERVER (0x00000003L)")]
    public const int SECURITY_CAPABILITY_PRIVATE_NETWORK_CLIENT_SERVER = (0x00000003);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_PICTURES_LIBRARY"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_PICTURES_LIBRARY (0x00000004L)")]
    public const int SECURITY_CAPABILITY_PICTURES_LIBRARY = (0x00000004);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_VIDEOS_LIBRARY"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_VIDEOS_LIBRARY (0x00000005L)")]
    public const int SECURITY_CAPABILITY_VIDEOS_LIBRARY = (0x00000005);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_MUSIC_LIBRARY"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_MUSIC_LIBRARY (0x00000006L)")]
    public const int SECURITY_CAPABILITY_MUSIC_LIBRARY = (0x00000006);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_DOCUMENTS_LIBRARY"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_DOCUMENTS_LIBRARY (0x00000007L)")]
    public const int SECURITY_CAPABILITY_DOCUMENTS_LIBRARY = (0x00000007);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_ENTERPRISE_AUTHENTICATION"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_ENTERPRISE_AUTHENTICATION (0x00000008L)")]
    public const int SECURITY_CAPABILITY_ENTERPRISE_AUTHENTICATION = (0x00000008);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_SHARED_USER_CERTIFICATES"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_SHARED_USER_CERTIFICATES (0x00000009L)")]
    public const int SECURITY_CAPABILITY_SHARED_USER_CERTIFICATES = (0x00000009);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_REMOVABLE_STORAGE"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_REMOVABLE_STORAGE (0x0000000AL)")]
    public const int SECURITY_CAPABILITY_REMOVABLE_STORAGE = (0x0000000A);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_APPOINTMENTS"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_APPOINTMENTS (0x0000000BL)")]
    public const int SECURITY_CAPABILITY_APPOINTMENTS = (0x0000000B);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_CONTACTS"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_CONTACTS (0x0000000CL)")]
    public const int SECURITY_CAPABILITY_CONTACTS = (0x0000000C);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CAPABILITY_INTERNET_EXPLORER"]/*' />
    [NativeTypeName("#define SECURITY_CAPABILITY_INTERNET_EXPLORER (0x00001000L)")]
    public const int SECURITY_CAPABILITY_INTERNET_EXPLORER = (0x00001000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MANDATORY_UNTRUSTED_RID"]/*' />
    [NativeTypeName("#define SECURITY_MANDATORY_UNTRUSTED_RID (0x00000000L)")]
    public const int SECURITY_MANDATORY_UNTRUSTED_RID = (0x00000000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MANDATORY_LOW_RID"]/*' />
    [NativeTypeName("#define SECURITY_MANDATORY_LOW_RID (0x00001000L)")]
    public const int SECURITY_MANDATORY_LOW_RID = (0x00001000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MANDATORY_MEDIUM_RID"]/*' />
    [NativeTypeName("#define SECURITY_MANDATORY_MEDIUM_RID (0x00002000L)")]
    public const int SECURITY_MANDATORY_MEDIUM_RID = (0x00002000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MANDATORY_MEDIUM_PLUS_RID"]/*' />
    [NativeTypeName("#define SECURITY_MANDATORY_MEDIUM_PLUS_RID (SECURITY_MANDATORY_MEDIUM_RID + 0x100)")]
    public const int SECURITY_MANDATORY_MEDIUM_PLUS_RID = ((0x00002000) + 0x100);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MANDATORY_HIGH_RID"]/*' />
    [NativeTypeName("#define SECURITY_MANDATORY_HIGH_RID (0x00003000L)")]
    public const int SECURITY_MANDATORY_HIGH_RID = (0x00003000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MANDATORY_SYSTEM_RID"]/*' />
    [NativeTypeName("#define SECURITY_MANDATORY_SYSTEM_RID (0x00004000L)")]
    public const int SECURITY_MANDATORY_SYSTEM_RID = (0x00004000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MANDATORY_PROTECTED_PROCESS_RID"]/*' />
    [NativeTypeName("#define SECURITY_MANDATORY_PROTECTED_PROCESS_RID (0x00005000L)")]
    public const int SECURITY_MANDATORY_PROTECTED_PROCESS_RID = (0x00005000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MANDATORY_MEDIUM_PLUS_CREDUI_RID"]/*' />
    [NativeTypeName("#define SECURITY_MANDATORY_MEDIUM_PLUS_CREDUI_RID (SECURITY_MANDATORY_MEDIUM_RID + 0xA)")]
    public const int SECURITY_MANDATORY_MEDIUM_PLUS_CREDUI_RID = ((0x00002000) + 0xA);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MANDATORY_MAXIMUM_USER_RID"]/*' />
    [NativeTypeName("#define SECURITY_MANDATORY_MAXIMUM_USER_RID SECURITY_MANDATORY_SYSTEM_RID")]
    public const int SECURITY_MANDATORY_MAXIMUM_USER_RID = (0x00004000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_AUTHENTICATION_AUTHORITY_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_AUTHENTICATION_AUTHORITY_RID_COUNT (1L)")]
    public const int SECURITY_AUTHENTICATION_AUTHORITY_RID_COUNT = (1);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_AUTHENTICATION_AUTHORITY_ASSERTED_RID"]/*' />
    [NativeTypeName("#define SECURITY_AUTHENTICATION_AUTHORITY_ASSERTED_RID (0x00000001L)")]
    public const int SECURITY_AUTHENTICATION_AUTHORITY_ASSERTED_RID = (0x00000001);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_AUTHENTICATION_SERVICE_ASSERTED_RID"]/*' />
    [NativeTypeName("#define SECURITY_AUTHENTICATION_SERVICE_ASSERTED_RID (0x00000002L)")]
    public const int SECURITY_AUTHENTICATION_SERVICE_ASSERTED_RID = (0x00000002);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_AUTHENTICATION_FRESH_KEY_AUTH_RID"]/*' />
    [NativeTypeName("#define SECURITY_AUTHENTICATION_FRESH_KEY_AUTH_RID (0x00000003L)")]
    public const int SECURITY_AUTHENTICATION_FRESH_KEY_AUTH_RID = (0x00000003);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_AUTHENTICATION_KEY_TRUST_RID"]/*' />
    [NativeTypeName("#define SECURITY_AUTHENTICATION_KEY_TRUST_RID (0x00000004L)")]
    public const int SECURITY_AUTHENTICATION_KEY_TRUST_RID = (0x00000004);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_AUTHENTICATION_KEY_PROPERTY_MFA_RID"]/*' />
    [NativeTypeName("#define SECURITY_AUTHENTICATION_KEY_PROPERTY_MFA_RID (0x00000005L)")]
    public const int SECURITY_AUTHENTICATION_KEY_PROPERTY_MFA_RID = (0x00000005);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_AUTHENTICATION_KEY_PROPERTY_ATTESTATION_RID"]/*' />
    [NativeTypeName("#define SECURITY_AUTHENTICATION_KEY_PROPERTY_ATTESTATION_RID (0x00000006L)")]
    public const int SECURITY_AUTHENTICATION_KEY_PROPERTY_ATTESTATION_RID = (0x00000006);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PROCESS_TRUST_AUTHORITY_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_PROCESS_TRUST_AUTHORITY_RID_COUNT (2L)")]
    public const int SECURITY_PROCESS_TRUST_AUTHORITY_RID_COUNT = (2);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PROCESS_PROTECTION_TYPE_FULL_RID"]/*' />
    [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_TYPE_FULL_RID (0x00000400L)")]
    public const int SECURITY_PROCESS_PROTECTION_TYPE_FULL_RID = (0x00000400);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PROCESS_PROTECTION_TYPE_LITE_RID"]/*' />
    [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_TYPE_LITE_RID (0x00000200L)")]
    public const int SECURITY_PROCESS_PROTECTION_TYPE_LITE_RID = (0x00000200);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PROCESS_PROTECTION_TYPE_NONE_RID"]/*' />
    [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_TYPE_NONE_RID (0x00000000L)")]
    public const int SECURITY_PROCESS_PROTECTION_TYPE_NONE_RID = (0x00000000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PROCESS_PROTECTION_LEVEL_WINTCB_RID"]/*' />
    [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_LEVEL_WINTCB_RID (0x00002000L)")]
    public const int SECURITY_PROCESS_PROTECTION_LEVEL_WINTCB_RID = (0x00002000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PROCESS_PROTECTION_LEVEL_WINDOWS_RID"]/*' />
    [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_LEVEL_WINDOWS_RID (0x00001000L)")]
    public const int SECURITY_PROCESS_PROTECTION_LEVEL_WINDOWS_RID = (0x00001000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PROCESS_PROTECTION_LEVEL_APP_RID"]/*' />
    [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_LEVEL_APP_RID (0x00000800L)")]
    public const int SECURITY_PROCESS_PROTECTION_LEVEL_APP_RID = (0x00000800);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PROCESS_PROTECTION_LEVEL_ANTIMALWARE_RID"]/*' />
    [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_LEVEL_ANTIMALWARE_RID (0x00000600L)")]
    public const int SECURITY_PROCESS_PROTECTION_LEVEL_ANTIMALWARE_RID = (0x00000600);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PROCESS_PROTECTION_LEVEL_AUTHENTICODE_RID"]/*' />
    [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_LEVEL_AUTHENTICODE_RID (0x00000400L)")]
    public const int SECURITY_PROCESS_PROTECTION_LEVEL_AUTHENTICODE_RID = (0x00000400);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_PROCESS_PROTECTION_LEVEL_NONE_RID"]/*' />
    [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_LEVEL_NONE_RID (0x00000000L)")]
    public const int SECURITY_PROCESS_PROTECTION_LEVEL_NONE_RID = (0x00000000);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANTI_TAMPER_AUTHORITY_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_ANTI_TAMPER_AUTHORITY_RID_COUNT (8L)")]
    public const int SECURITY_ANTI_TAMPER_AUTHORITY_RID_COUNT = (8);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANTI_TAMPER_AUTHORITY_INSTANCE_RID_COUNT"]/*' />
    [NativeTypeName("#define SECURITY_ANTI_TAMPER_AUTHORITY_INSTANCE_RID_COUNT (3L)")]
    public const int SECURITY_ANTI_TAMPER_AUTHORITY_INSTANCE_RID_COUNT = (3);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANTI_TAMPER_APP_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_ANTI_TAMPER_APP_ID_BASE_RID (0x00000001L)")]
    public const int SECURITY_ANTI_TAMPER_APP_ID_BASE_RID = (0x00000001);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANTI_TAMPER_MUTABLE_APP_ID_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_ANTI_TAMPER_MUTABLE_APP_ID_BASE_RID (0x00000002L)")]
    public const int SECURITY_ANTI_TAMPER_MUTABLE_APP_ID_BASE_RID = (0x00000002);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANTI_TAMPER_APP_INSTANCE_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_ANTI_TAMPER_APP_INSTANCE_BASE_RID (0x00000003L)")]
    public const int SECURITY_ANTI_TAMPER_APP_INSTANCE_BASE_RID = (0x00000003);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANTI_TAMPER_ENTITLEMENT_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_ANTI_TAMPER_ENTITLEMENT_BASE_RID (0x00000004L)")]
    public const int SECURITY_ANTI_TAMPER_ENTITLEMENT_BASE_RID = (0x00000004);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANTI_TAMPER_APP_SUITE_BASE_RID"]/*' />
    [NativeTypeName("#define SECURITY_ANTI_TAMPER_APP_SUITE_BASE_RID (0x00000005L)")]
    public const int SECURITY_ANTI_TAMPER_APP_SUITE_BASE_RID = (0x00000005);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_TRUSTED_INSTALLER_RID1"]/*' />
    [NativeTypeName("#define SECURITY_TRUSTED_INSTALLER_RID1 956008885")]
    public const int SECURITY_TRUSTED_INSTALLER_RID1 = 956008885;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_TRUSTED_INSTALLER_RID2"]/*' />
    [NativeTypeName("#define SECURITY_TRUSTED_INSTALLER_RID2 3418522649")]
    public const long SECURITY_TRUSTED_INSTALLER_RID2 = 3418522649;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_TRUSTED_INSTALLER_RID3"]/*' />
    [NativeTypeName("#define SECURITY_TRUSTED_INSTALLER_RID3 1831038044")]
    public const int SECURITY_TRUSTED_INSTALLER_RID3 = 1831038044;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_TRUSTED_INSTALLER_RID4"]/*' />
    [NativeTypeName("#define SECURITY_TRUSTED_INSTALLER_RID4 1853292631")]
    public const int SECURITY_TRUSTED_INSTALLER_RID4 = 1853292631;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_TRUSTED_INSTALLER_RID5"]/*' />
    [NativeTypeName("#define SECURITY_TRUSTED_INSTALLER_RID5 2271478464")]
    public const long SECURITY_TRUSTED_INSTALLER_RID5 = 2271478464;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_DESCRIPTOR_REVISION"]/*' />
    [NativeTypeName("#define SECURITY_DESCRIPTOR_REVISION (1)")]
    public const int SECURITY_DESCRIPTOR_REVISION = (1);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_DESCRIPTOR_REVISION1"]/*' />
    [NativeTypeName("#define SECURITY_DESCRIPTOR_REVISION1 (1)")]
    public const int SECURITY_DESCRIPTOR_REVISION1 = (1);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_DESCRIPTOR_MIN_LENGTH"]/*' />
    [NativeTypeName("#define SECURITY_DESCRIPTOR_MIN_LENGTH (sizeof(SECURITY_DESCRIPTOR))")]
    public static uint SECURITY_DESCRIPTOR_MIN_LENGTH => unchecked((uint)((uint)(sizeof(SECURITY_DESCRIPTOR))));

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MAX_IMPERSONATION_LEVEL"]/*' />
    [NativeTypeName("#define SECURITY_MAX_IMPERSONATION_LEVEL SecurityDelegation")]
    public const SECURITY_IMPERSONATION_LEVEL SECURITY_MAX_IMPERSONATION_LEVEL = SecurityDelegation;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_MIN_IMPERSONATION_LEVEL"]/*' />
    [NativeTypeName("#define SECURITY_MIN_IMPERSONATION_LEVEL SecurityAnonymous")]
    public const SECURITY_IMPERSONATION_LEVEL SECURITY_MIN_IMPERSONATION_LEVEL = SecurityAnonymous;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_DYNAMIC_TRACKING"]/*' />
    [NativeTypeName("#define SECURITY_DYNAMIC_TRACKING (TRUE)")]
    public const int SECURITY_DYNAMIC_TRACKING = (1);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_STATIC_TRACKING"]/*' />
    [NativeTypeName("#define SECURITY_STATIC_TRACKING (FALSE)")]
    public const int SECURITY_STATIC_TRACKING = (0);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANTITAMPER_POLICY_PRESENT_GENERAL"]/*' />
    [NativeTypeName("#define SECURITY_ANTITAMPER_POLICY_PRESENT_GENERAL 0x00000001UL")]
    public const uint SECURITY_ANTITAMPER_POLICY_PRESENT_GENERAL = 0x00000001U;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANTITAMPER_POLICY_PRESENT_DEBUG"]/*' />
    [NativeTypeName("#define SECURITY_ANTITAMPER_POLICY_PRESENT_DEBUG 0x00000002UL")]
    public const uint SECURITY_ANTITAMPER_POLICY_PRESENT_DEBUG = 0x00000002U;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANTITAMPER_POLICY_PRESENT_UI"]/*' />
    [NativeTypeName("#define SECURITY_ANTITAMPER_POLICY_PRESENT_UI 0x00000004UL")]
    public const uint SECURITY_ANTITAMPER_POLICY_PRESENT_UI = 0x00000004U;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANTITAMPER_POLICY_PRESENT_PROCESS"]/*' />
    [NativeTypeName("#define SECURITY_ANTITAMPER_POLICY_PRESENT_PROCESS 0x00000008UL")]
    public const uint SECURITY_ANTITAMPER_POLICY_PRESENT_PROCESS = 0x00000008U;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANTITAMPER_POLICY_PRESENT_SIGNING"]/*' />
    [NativeTypeName("#define SECURITY_ANTITAMPER_POLICY_PRESENT_SIGNING 0x00000010UL")]
    public const uint SECURITY_ANTITAMPER_POLICY_PRESENT_SIGNING = 0x00000010U;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANTITAMPER_POLICY_PRESENT_MODULES"]/*' />
    [NativeTypeName("#define SECURITY_ANTITAMPER_POLICY_PRESENT_MODULES 0x00000020UL")]
    public const uint SECURITY_ANTITAMPER_POLICY_PRESENT_MODULES = 0x00000020U;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANTITAMPER_POLICY_PRESENT_VALID_MASK"]/*' />
    [NativeTypeName("#define SECURITY_ANTITAMPER_POLICY_PRESENT_VALID_MASK ( \\\r\n    SECURITY_ANTITAMPER_POLICY_PRESENT_GENERAL         | \\\r\n    SECURITY_ANTITAMPER_POLICY_PRESENT_DEBUG           | \\\r\n    SECURITY_ANTITAMPER_POLICY_PRESENT_UI              | \\\r\n    SECURITY_ANTITAMPER_POLICY_PRESENT_PROCESS         | \\\r\n    SECURITY_ANTITAMPER_POLICY_PRESENT_SIGNING         | \\\r\n    SECURITY_ANTITAMPER_POLICY_PRESENT_MODULES)")]
    public const uint SECURITY_ANTITAMPER_POLICY_PRESENT_VALID_MASK = (0x00000001U | 0x00000002U | 0x00000004U | 0x00000008U | 0x00000010U | 0x00000020U);
}
