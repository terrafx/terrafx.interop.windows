// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailMessageBodyKind.xml' path='doc/member[@name="EmailMessageBodyKind"]/*' />
public enum EmailMessageBodyKind
{
    /// <include file='EmailMessageBodyKind.xml' path='doc/member[@name="EmailMessageBodyKind.EmailMessageBodyKind_Html"]/*' />
    EmailMessageBodyKind_Html = 0,

    /// <include file='EmailMessageBodyKind.xml' path='doc/member[@name="EmailMessageBodyKind.EmailMessageBodyKind_PlainText"]/*' />
    EmailMessageBodyKind_PlainText = 1,
}
