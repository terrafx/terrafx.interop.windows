// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailMailboxActionKind.xml' path='doc/member[@name="EmailMailboxActionKind"]/*' />
public enum EmailMailboxActionKind
{
    /// <include file='EmailMailboxActionKind.xml' path='doc/member[@name="EmailMailboxActionKind.EmailMailboxActionKind_MarkMessageAsSeen"]/*' />
    EmailMailboxActionKind_MarkMessageAsSeen = 0,

    /// <include file='EmailMailboxActionKind.xml' path='doc/member[@name="EmailMailboxActionKind.EmailMailboxActionKind_MarkMessageRead"]/*' />
    EmailMailboxActionKind_MarkMessageRead = 1,

    /// <include file='EmailMailboxActionKind.xml' path='doc/member[@name="EmailMailboxActionKind.EmailMailboxActionKind_ChangeMessageFlagState"]/*' />
    EmailMailboxActionKind_ChangeMessageFlagState = 2,

    /// <include file='EmailMailboxActionKind.xml' path='doc/member[@name="EmailMailboxActionKind.EmailMailboxActionKind_MoveMessage"]/*' />
    EmailMailboxActionKind_MoveMessage = 3,

    /// <include file='EmailMailboxActionKind.xml' path='doc/member[@name="EmailMailboxActionKind.EmailMailboxActionKind_SaveDraft"]/*' />
    EmailMailboxActionKind_SaveDraft = 4,

    /// <include file='EmailMailboxActionKind.xml' path='doc/member[@name="EmailMailboxActionKind.EmailMailboxActionKind_SendMessage"]/*' />
    EmailMailboxActionKind_SendMessage = 5,

    /// <include file='EmailMailboxActionKind.xml' path='doc/member[@name="EmailMailboxActionKind.EmailMailboxActionKind_CreateResponseReplyMessage"]/*' />
    EmailMailboxActionKind_CreateResponseReplyMessage = 6,

    /// <include file='EmailMailboxActionKind.xml' path='doc/member[@name="EmailMailboxActionKind.EmailMailboxActionKind_CreateResponseReplyAllMessage"]/*' />
    EmailMailboxActionKind_CreateResponseReplyAllMessage = 7,

    /// <include file='EmailMailboxActionKind.xml' path='doc/member[@name="EmailMailboxActionKind.EmailMailboxActionKind_CreateResponseForwardMessage"]/*' />
    EmailMailboxActionKind_CreateResponseForwardMessage = 8,

    /// <include file='EmailMailboxActionKind.xml' path='doc/member[@name="EmailMailboxActionKind.EmailMailboxActionKind_MoveFolder"]/*' />
    EmailMailboxActionKind_MoveFolder = 9,

    /// <include file='EmailMailboxActionKind.xml' path='doc/member[@name="EmailMailboxActionKind.EmailMailboxActionKind_MarkFolderForSyncEnabled"]/*' />
    EmailMailboxActionKind_MarkFolderForSyncEnabled = 10,
}
