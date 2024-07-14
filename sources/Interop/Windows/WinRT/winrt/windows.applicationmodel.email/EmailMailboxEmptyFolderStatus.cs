// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailMailboxEmptyFolderStatus.xml' path='doc/member[@name="EmailMailboxEmptyFolderStatus"]/*' />
public enum EmailMailboxEmptyFolderStatus
{
    /// <include file='EmailMailboxEmptyFolderStatus.xml' path='doc/member[@name="EmailMailboxEmptyFolderStatus.EmailMailboxEmptyFolderStatus_Success"]/*' />
    EmailMailboxEmptyFolderStatus_Success = 0,

    /// <include file='EmailMailboxEmptyFolderStatus.xml' path='doc/member[@name="EmailMailboxEmptyFolderStatus.EmailMailboxEmptyFolderStatus_NetworkError"]/*' />
    EmailMailboxEmptyFolderStatus_NetworkError = 1,

    /// <include file='EmailMailboxEmptyFolderStatus.xml' path='doc/member[@name="EmailMailboxEmptyFolderStatus.EmailMailboxEmptyFolderStatus_PermissionsError"]/*' />
    EmailMailboxEmptyFolderStatus_PermissionsError = 2,

    /// <include file='EmailMailboxEmptyFolderStatus.xml' path='doc/member[@name="EmailMailboxEmptyFolderStatus.EmailMailboxEmptyFolderStatus_ServerError"]/*' />
    EmailMailboxEmptyFolderStatus_ServerError = 3,

    /// <include file='EmailMailboxEmptyFolderStatus.xml' path='doc/member[@name="EmailMailboxEmptyFolderStatus.EmailMailboxEmptyFolderStatus_UnknownFailure"]/*' />
    EmailMailboxEmptyFolderStatus_UnknownFailure = 4,

    /// <include file='EmailMailboxEmptyFolderStatus.xml' path='doc/member[@name="EmailMailboxEmptyFolderStatus.EmailMailboxEmptyFolderStatus_CouldNotDeleteEverything"]/*' />
    EmailMailboxEmptyFolderStatus_CouldNotDeleteEverything = 5,
}
