// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailSpecialFolderKind.xml' path='doc/member[@name="EmailSpecialFolderKind"]/*' />
public enum EmailSpecialFolderKind
{
    /// <include file='EmailSpecialFolderKind.xml' path='doc/member[@name="EmailSpecialFolderKind.EmailSpecialFolderKind_None"]/*' />
    EmailSpecialFolderKind_None = 0,

    /// <include file='EmailSpecialFolderKind.xml' path='doc/member[@name="EmailSpecialFolderKind.EmailSpecialFolderKind_Root"]/*' />
    EmailSpecialFolderKind_Root = 1,

    /// <include file='EmailSpecialFolderKind.xml' path='doc/member[@name="EmailSpecialFolderKind.EmailSpecialFolderKind_Inbox"]/*' />
    EmailSpecialFolderKind_Inbox = 2,

    /// <include file='EmailSpecialFolderKind.xml' path='doc/member[@name="EmailSpecialFolderKind.EmailSpecialFolderKind_Outbox"]/*' />
    EmailSpecialFolderKind_Outbox = 3,

    /// <include file='EmailSpecialFolderKind.xml' path='doc/member[@name="EmailSpecialFolderKind.EmailSpecialFolderKind_Drafts"]/*' />
    EmailSpecialFolderKind_Drafts = 4,

    /// <include file='EmailSpecialFolderKind.xml' path='doc/member[@name="EmailSpecialFolderKind.EmailSpecialFolderKind_DeletedItems"]/*' />
    EmailSpecialFolderKind_DeletedItems = 5,

    /// <include file='EmailSpecialFolderKind.xml' path='doc/member[@name="EmailSpecialFolderKind.EmailSpecialFolderKind_Sent"]/*' />
    EmailSpecialFolderKind_Sent = 6,
}
