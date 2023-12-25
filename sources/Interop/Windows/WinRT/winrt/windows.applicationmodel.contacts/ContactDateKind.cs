// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactDateKind.xml' path='doc/member[@name="ContactDateKind"]/*' />
public enum ContactDateKind
{
    /// <include file='ContactDateKind.xml' path='doc/member[@name="ContactDateKind.ContactDateKind_Birthday"]/*' />
    ContactDateKind_Birthday = 0,

    /// <include file='ContactDateKind.xml' path='doc/member[@name="ContactDateKind.ContactDateKind_Anniversary"]/*' />
    ContactDateKind_Anniversary = 1,

    /// <include file='ContactDateKind.xml' path='doc/member[@name="ContactDateKind.ContactDateKind_Other"]/*' />
    ContactDateKind_Other = 2,
}
