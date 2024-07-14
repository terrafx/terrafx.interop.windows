// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailQueryKind.xml' path='doc/member[@name="EmailQueryKind"]/*' />
public enum EmailQueryKind
{
    /// <include file='EmailQueryKind.xml' path='doc/member[@name="EmailQueryKind.EmailQueryKind_All"]/*' />
    EmailQueryKind_All = 0,

    /// <include file='EmailQueryKind.xml' path='doc/member[@name="EmailQueryKind.EmailQueryKind_Important"]/*' />
    EmailQueryKind_Important = 1,

    /// <include file='EmailQueryKind.xml' path='doc/member[@name="EmailQueryKind.EmailQueryKind_Flagged"]/*' />
    EmailQueryKind_Flagged = 2,

    /// <include file='EmailQueryKind.xml' path='doc/member[@name="EmailQueryKind.EmailQueryKind_Unread"]/*' />
    EmailQueryKind_Unread = 3,

    /// <include file='EmailQueryKind.xml' path='doc/member[@name="EmailQueryKind.EmailQueryKind_Read"]/*' />
    EmailQueryKind_Read = 4,

    /// <include file='EmailQueryKind.xml' path='doc/member[@name="EmailQueryKind.EmailQueryKind_Unseen"]/*' />
    EmailQueryKind_Unseen = 5,
}
