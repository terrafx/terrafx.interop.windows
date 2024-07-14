// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactFieldCategory.xml' path='doc/member[@name="ContactFieldCategory"]/*' />
public enum ContactFieldCategory
{
    /// <include file='ContactFieldCategory.xml' path='doc/member[@name="ContactFieldCategory.ContactFieldCategory_None"]/*' />
    ContactFieldCategory_None = 0,

    /// <include file='ContactFieldCategory.xml' path='doc/member[@name="ContactFieldCategory.ContactFieldCategory_Home"]/*' />
    ContactFieldCategory_Home = 1,

    /// <include file='ContactFieldCategory.xml' path='doc/member[@name="ContactFieldCategory.ContactFieldCategory_Work"]/*' />
    ContactFieldCategory_Work = 2,

    /// <include file='ContactFieldCategory.xml' path='doc/member[@name="ContactFieldCategory.ContactFieldCategory_Mobile"]/*' />
    ContactFieldCategory_Mobile = 3,

    /// <include file='ContactFieldCategory.xml' path='doc/member[@name="ContactFieldCategory.ContactFieldCategory_Other"]/*' />
    ContactFieldCategory_Other = 4,
}
