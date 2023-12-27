// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailMailboxSyncStatus.xml' path='doc/member[@name="EmailMailboxSyncStatus"]/*' />
public enum EmailMailboxSyncStatus
{
    /// <include file='EmailMailboxSyncStatus.xml' path='doc/member[@name="EmailMailboxSyncStatus.EmailMailboxSyncStatus_Idle"]/*' />
    EmailMailboxSyncStatus_Idle = 0,

    /// <include file='EmailMailboxSyncStatus.xml' path='doc/member[@name="EmailMailboxSyncStatus.EmailMailboxSyncStatus_Syncing"]/*' />
    EmailMailboxSyncStatus_Syncing = 1,

    /// <include file='EmailMailboxSyncStatus.xml' path='doc/member[@name="EmailMailboxSyncStatus.EmailMailboxSyncStatus_UpToDate"]/*' />
    EmailMailboxSyncStatus_UpToDate = 2,

    /// <include file='EmailMailboxSyncStatus.xml' path='doc/member[@name="EmailMailboxSyncStatus.EmailMailboxSyncStatus_AuthenticationError"]/*' />
    EmailMailboxSyncStatus_AuthenticationError = 3,

    /// <include file='EmailMailboxSyncStatus.xml' path='doc/member[@name="EmailMailboxSyncStatus.EmailMailboxSyncStatus_PolicyError"]/*' />
    EmailMailboxSyncStatus_PolicyError = 4,

    /// <include file='EmailMailboxSyncStatus.xml' path='doc/member[@name="EmailMailboxSyncStatus.EmailMailboxSyncStatus_UnknownError"]/*' />
    EmailMailboxSyncStatus_UnknownError = 5,

    /// <include file='EmailMailboxSyncStatus.xml' path='doc/member[@name="EmailMailboxSyncStatus.EmailMailboxSyncStatus_ManualAccountRemovalRequired"]/*' />
    EmailMailboxSyncStatus_ManualAccountRemovalRequired = 6,
}
