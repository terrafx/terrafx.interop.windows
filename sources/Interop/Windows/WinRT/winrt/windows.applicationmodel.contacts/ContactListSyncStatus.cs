// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactListSyncStatus.xml' path='doc/member[@name="ContactListSyncStatus"]/*' />
public enum ContactListSyncStatus
{
    /// <include file='ContactListSyncStatus.xml' path='doc/member[@name="ContactListSyncStatus.ContactListSyncStatus_Idle"]/*' />
    ContactListSyncStatus_Idle = 0,

    /// <include file='ContactListSyncStatus.xml' path='doc/member[@name="ContactListSyncStatus.ContactListSyncStatus_Syncing"]/*' />
    ContactListSyncStatus_Syncing = 1,

    /// <include file='ContactListSyncStatus.xml' path='doc/member[@name="ContactListSyncStatus.ContactListSyncStatus_UpToDate"]/*' />
    ContactListSyncStatus_UpToDate = 2,

    /// <include file='ContactListSyncStatus.xml' path='doc/member[@name="ContactListSyncStatus.ContactListSyncStatus_AuthenticationError"]/*' />
    ContactListSyncStatus_AuthenticationError = 3,

    /// <include file='ContactListSyncStatus.xml' path='doc/member[@name="ContactListSyncStatus.ContactListSyncStatus_PolicyError"]/*' />
    ContactListSyncStatus_PolicyError = 4,

    /// <include file='ContactListSyncStatus.xml' path='doc/member[@name="ContactListSyncStatus.ContactListSyncStatus_UnknownError"]/*' />
    ContactListSyncStatus_UnknownError = 5,

    /// <include file='ContactListSyncStatus.xml' path='doc/member[@name="ContactListSyncStatus.ContactListSyncStatus_ManualAccountRemovalRequired"]/*' />
    ContactListSyncStatus_ManualAccountRemovalRequired = 6,
}
