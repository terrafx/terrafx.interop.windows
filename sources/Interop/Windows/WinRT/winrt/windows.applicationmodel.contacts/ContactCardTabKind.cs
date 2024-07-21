// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactCardTabKind.xml' path='doc/member[@name="ContactCardTabKind"]/*' />
public enum ContactCardTabKind
{
    /// <include file='ContactCardTabKind.xml' path='doc/member[@name="ContactCardTabKind.ContactCardTabKind_Default"]/*' />
    ContactCardTabKind_Default = 0,

    /// <include file='ContactCardTabKind.xml' path='doc/member[@name="ContactCardTabKind.ContactCardTabKind_Email"]/*' />
    ContactCardTabKind_Email = 1,

    /// <include file='ContactCardTabKind.xml' path='doc/member[@name="ContactCardTabKind.ContactCardTabKind_Messaging"]/*' />
    ContactCardTabKind_Messaging = 2,

    /// <include file='ContactCardTabKind.xml' path='doc/member[@name="ContactCardTabKind.ContactCardTabKind_Phone"]/*' />
    ContactCardTabKind_Phone = 3,

    /// <include file='ContactCardTabKind.xml' path='doc/member[@name="ContactCardTabKind.ContactCardTabKind_Video"]/*' />
    ContactCardTabKind_Video = 4,

    /// <include file='ContactCardTabKind.xml' path='doc/member[@name="ContactCardTabKind.ContactCardTabKind_OrganizationalHierarchy"]/*' />
    ContactCardTabKind_OrganizationalHierarchy = 5,
}
