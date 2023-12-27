// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserDataTaskListSyncStatus.xml' path='doc/member[@name="UserDataTaskListSyncStatus"]/*' />
public enum UserDataTaskListSyncStatus
{
    /// <include file='UserDataTaskListSyncStatus.xml' path='doc/member[@name="UserDataTaskListSyncStatus.UserDataTaskListSyncStatus_Idle"]/*' />
    UserDataTaskListSyncStatus_Idle = 0,

    /// <include file='UserDataTaskListSyncStatus.xml' path='doc/member[@name="UserDataTaskListSyncStatus.UserDataTaskListSyncStatus_Syncing"]/*' />
    UserDataTaskListSyncStatus_Syncing = 1,

    /// <include file='UserDataTaskListSyncStatus.xml' path='doc/member[@name="UserDataTaskListSyncStatus.UserDataTaskListSyncStatus_UpToDate"]/*' />
    UserDataTaskListSyncStatus_UpToDate = 2,

    /// <include file='UserDataTaskListSyncStatus.xml' path='doc/member[@name="UserDataTaskListSyncStatus.UserDataTaskListSyncStatus_AuthenticationError"]/*' />
    UserDataTaskListSyncStatus_AuthenticationError = 3,

    /// <include file='UserDataTaskListSyncStatus.xml' path='doc/member[@name="UserDataTaskListSyncStatus.UserDataTaskListSyncStatus_PolicyError"]/*' />
    UserDataTaskListSyncStatus_PolicyError = 4,

    /// <include file='UserDataTaskListSyncStatus.xml' path='doc/member[@name="UserDataTaskListSyncStatus.UserDataTaskListSyncStatus_UnknownError"]/*' />
    UserDataTaskListSyncStatus_UnknownError = 5,
}
