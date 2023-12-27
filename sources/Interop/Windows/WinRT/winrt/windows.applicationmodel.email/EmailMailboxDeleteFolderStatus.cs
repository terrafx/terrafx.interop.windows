// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailMailboxDeleteFolderStatus.xml' path='doc/member[@name="EmailMailboxDeleteFolderStatus"]/*' />
public enum EmailMailboxDeleteFolderStatus
{
    /// <include file='EmailMailboxDeleteFolderStatus.xml' path='doc/member[@name="EmailMailboxDeleteFolderStatus.EmailMailboxDeleteFolderStatus_Success"]/*' />
    EmailMailboxDeleteFolderStatus_Success = 0,

    /// <include file='EmailMailboxDeleteFolderStatus.xml' path='doc/member[@name="EmailMailboxDeleteFolderStatus.EmailMailboxDeleteFolderStatus_NetworkError"]/*' />
    EmailMailboxDeleteFolderStatus_NetworkError = 1,

    /// <include file='EmailMailboxDeleteFolderStatus.xml' path='doc/member[@name="EmailMailboxDeleteFolderStatus.EmailMailboxDeleteFolderStatus_PermissionsError"]/*' />
    EmailMailboxDeleteFolderStatus_PermissionsError = 2,

    /// <include file='EmailMailboxDeleteFolderStatus.xml' path='doc/member[@name="EmailMailboxDeleteFolderStatus.EmailMailboxDeleteFolderStatus_ServerError"]/*' />
    EmailMailboxDeleteFolderStatus_ServerError = 3,

    /// <include file='EmailMailboxDeleteFolderStatus.xml' path='doc/member[@name="EmailMailboxDeleteFolderStatus.EmailMailboxDeleteFolderStatus_UnknownFailure"]/*' />
    EmailMailboxDeleteFolderStatus_UnknownFailure = 4,

    /// <include file='EmailMailboxDeleteFolderStatus.xml' path='doc/member[@name="EmailMailboxDeleteFolderStatus.EmailMailboxDeleteFolderStatus_CouldNotDeleteEverything"]/*' />
    EmailMailboxDeleteFolderStatus_CouldNotDeleteEverything = 5,
}
