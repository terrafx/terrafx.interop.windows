// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactPhoneKind.xml' path='doc/member[@name="ContactPhoneKind"]/*' />
public enum ContactPhoneKind
{
    /// <include file='ContactPhoneKind.xml' path='doc/member[@name="ContactPhoneKind.ContactPhoneKind_Home"]/*' />
    ContactPhoneKind_Home = 0,

    /// <include file='ContactPhoneKind.xml' path='doc/member[@name="ContactPhoneKind.ContactPhoneKind_Mobile"]/*' />
    ContactPhoneKind_Mobile = 1,

    /// <include file='ContactPhoneKind.xml' path='doc/member[@name="ContactPhoneKind.ContactPhoneKind_Work"]/*' />
    ContactPhoneKind_Work = 2,

    /// <include file='ContactPhoneKind.xml' path='doc/member[@name="ContactPhoneKind.ContactPhoneKind_Other"]/*' />
    ContactPhoneKind_Other = 3,

    /// <include file='ContactPhoneKind.xml' path='doc/member[@name="ContactPhoneKind.ContactPhoneKind_Pager"]/*' />
    ContactPhoneKind_Pager = 4,

    /// <include file='ContactPhoneKind.xml' path='doc/member[@name="ContactPhoneKind.ContactPhoneKind_BusinessFax"]/*' />
    ContactPhoneKind_BusinessFax = 5,

    /// <include file='ContactPhoneKind.xml' path='doc/member[@name="ContactPhoneKind.ContactPhoneKind_HomeFax"]/*' />
    ContactPhoneKind_HomeFax = 6,

    /// <include file='ContactPhoneKind.xml' path='doc/member[@name="ContactPhoneKind.ContactPhoneKind_Company"]/*' />
    ContactPhoneKind_Company = 7,

    /// <include file='ContactPhoneKind.xml' path='doc/member[@name="ContactPhoneKind.ContactPhoneKind_Assistant"]/*' />
    ContactPhoneKind_Assistant = 8,

    /// <include file='ContactPhoneKind.xml' path='doc/member[@name="ContactPhoneKind.ContactPhoneKind_Radio"]/*' />
    ContactPhoneKind_Radio = 9,
}
