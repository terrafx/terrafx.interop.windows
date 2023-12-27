// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailMailboxCreateFolderStatus.xml' path='doc/member[@name="EmailMailboxCreateFolderStatus"]/*' />
public enum EmailMailboxCreateFolderStatus
{
    /// <include file='EmailMailboxCreateFolderStatus.xml' path='doc/member[@name="EmailMailboxCreateFolderStatus.EmailMailboxCreateFolderStatus_Success"]/*' />
    EmailMailboxCreateFolderStatus_Success = 0,

    /// <include file='EmailMailboxCreateFolderStatus.xml' path='doc/member[@name="EmailMailboxCreateFolderStatus.EmailMailboxCreateFolderStatus_NetworkError"]/*' />
    EmailMailboxCreateFolderStatus_NetworkError = 1,

    /// <include file='EmailMailboxCreateFolderStatus.xml' path='doc/member[@name="EmailMailboxCreateFolderStatus.EmailMailboxCreateFolderStatus_PermissionsError"]/*' />
    EmailMailboxCreateFolderStatus_PermissionsError = 2,

    /// <include file='EmailMailboxCreateFolderStatus.xml' path='doc/member[@name="EmailMailboxCreateFolderStatus.EmailMailboxCreateFolderStatus_ServerError"]/*' />
    EmailMailboxCreateFolderStatus_ServerError = 3,

    /// <include file='EmailMailboxCreateFolderStatus.xml' path='doc/member[@name="EmailMailboxCreateFolderStatus.EmailMailboxCreateFolderStatus_UnknownFailure"]/*' />
    EmailMailboxCreateFolderStatus_UnknownFailure = 4,

    /// <include file='EmailMailboxCreateFolderStatus.xml' path='doc/member[@name="EmailMailboxCreateFolderStatus.EmailMailboxCreateFolderStatus_NameCollision"]/*' />
    EmailMailboxCreateFolderStatus_NameCollision = 5,

    /// <include file='EmailMailboxCreateFolderStatus.xml' path='doc/member[@name="EmailMailboxCreateFolderStatus.EmailMailboxCreateFolderStatus_ServerRejected"]/*' />
    EmailMailboxCreateFolderStatus_ServerRejected = 6,
}
