// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailMessageResponseKind.xml' path='doc/member[@name="EmailMessageResponseKind"]/*' />
public enum EmailMessageResponseKind
{
    /// <include file='EmailMessageResponseKind.xml' path='doc/member[@name="EmailMessageResponseKind.EmailMessageResponseKind_None"]/*' />
    EmailMessageResponseKind_None = 0,

    /// <include file='EmailMessageResponseKind.xml' path='doc/member[@name="EmailMessageResponseKind.EmailMessageResponseKind_Reply"]/*' />
    EmailMessageResponseKind_Reply = 1,

    /// <include file='EmailMessageResponseKind.xml' path='doc/member[@name="EmailMessageResponseKind.EmailMessageResponseKind_ReplyAll"]/*' />
    EmailMessageResponseKind_ReplyAll = 2,

    /// <include file='EmailMessageResponseKind.xml' path='doc/member[@name="EmailMessageResponseKind.EmailMessageResponseKind_Forward"]/*' />
    EmailMessageResponseKind_Forward = 3,
}
