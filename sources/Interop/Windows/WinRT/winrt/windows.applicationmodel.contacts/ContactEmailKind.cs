// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactEmailKind.xml' path='doc/member[@name="ContactEmailKind"]/*' />
public enum ContactEmailKind
{
    /// <include file='ContactEmailKind.xml' path='doc/member[@name="ContactEmailKind.ContactEmailKind_Personal"]/*' />
    ContactEmailKind_Personal = 0,

    /// <include file='ContactEmailKind.xml' path='doc/member[@name="ContactEmailKind.ContactEmailKind_Work"]/*' />
    ContactEmailKind_Work = 1,

    /// <include file='ContactEmailKind.xml' path='doc/member[@name="ContactEmailKind.ContactEmailKind_Other"]/*' />
    ContactEmailKind_Other = 2,
}
