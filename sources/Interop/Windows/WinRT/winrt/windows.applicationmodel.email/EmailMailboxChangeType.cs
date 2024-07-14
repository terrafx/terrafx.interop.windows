// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailMailboxChangeType.xml' path='doc/member[@name="EmailMailboxChangeType"]/*' />
public enum EmailMailboxChangeType
{
    /// <include file='EmailMailboxChangeType.xml' path='doc/member[@name="EmailMailboxChangeType.EmailMailboxChangeType_MessageCreated"]/*' />
    EmailMailboxChangeType_MessageCreated = 0,

    /// <include file='EmailMailboxChangeType.xml' path='doc/member[@name="EmailMailboxChangeType.EmailMailboxChangeType_MessageModified"]/*' />
    EmailMailboxChangeType_MessageModified = 1,

    /// <include file='EmailMailboxChangeType.xml' path='doc/member[@name="EmailMailboxChangeType.EmailMailboxChangeType_MessageDeleted"]/*' />
    EmailMailboxChangeType_MessageDeleted = 2,

    /// <include file='EmailMailboxChangeType.xml' path='doc/member[@name="EmailMailboxChangeType.EmailMailboxChangeType_FolderCreated"]/*' />
    EmailMailboxChangeType_FolderCreated = 3,

    /// <include file='EmailMailboxChangeType.xml' path='doc/member[@name="EmailMailboxChangeType.EmailMailboxChangeType_FolderModified"]/*' />
    EmailMailboxChangeType_FolderModified = 4,

    /// <include file='EmailMailboxChangeType.xml' path='doc/member[@name="EmailMailboxChangeType.EmailMailboxChangeType_FolderDeleted"]/*' />
    EmailMailboxChangeType_FolderDeleted = 5,

    /// <include file='EmailMailboxChangeType.xml' path='doc/member[@name="EmailMailboxChangeType.EmailMailboxChangeType_ChangeTrackingLost"]/*' />
    EmailMailboxChangeType_ChangeTrackingLost = 6,
}
