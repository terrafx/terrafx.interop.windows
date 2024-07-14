// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailMessageSmimeKind.xml' path='doc/member[@name="EmailMessageSmimeKind"]/*' />
public enum EmailMessageSmimeKind
{
    /// <include file='EmailMessageSmimeKind.xml' path='doc/member[@name="EmailMessageSmimeKind.EmailMessageSmimeKind_None"]/*' />
    EmailMessageSmimeKind_None = 0,

    /// <include file='EmailMessageSmimeKind.xml' path='doc/member[@name="EmailMessageSmimeKind.EmailMessageSmimeKind_ClearSigned"]/*' />
    EmailMessageSmimeKind_ClearSigned = 1,

    /// <include file='EmailMessageSmimeKind.xml' path='doc/member[@name="EmailMessageSmimeKind.EmailMessageSmimeKind_OpaqueSigned"]/*' />
    EmailMessageSmimeKind_OpaqueSigned = 2,

    /// <include file='EmailMessageSmimeKind.xml' path='doc/member[@name="EmailMessageSmimeKind.EmailMessageSmimeKind_Encrypted"]/*' />
    EmailMessageSmimeKind_Encrypted = 3,
}
