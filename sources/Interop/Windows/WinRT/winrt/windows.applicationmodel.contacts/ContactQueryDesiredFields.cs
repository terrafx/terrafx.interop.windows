// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactQueryDesiredFields.xml' path='doc/member[@name="ContactQueryDesiredFields"]/*' />
[NativeTypeName("unsigned int")]
public enum ContactQueryDesiredFields : uint
{
    /// <include file='ContactQueryDesiredFields.xml' path='doc/member[@name="ContactQueryDesiredFields.ContactQueryDesiredFields_None"]/*' />
    ContactQueryDesiredFields_None = 0,

    /// <include file='ContactQueryDesiredFields.xml' path='doc/member[@name="ContactQueryDesiredFields.ContactQueryDesiredFields_PhoneNumber"]/*' />
    ContactQueryDesiredFields_PhoneNumber = 0x1,

    /// <include file='ContactQueryDesiredFields.xml' path='doc/member[@name="ContactQueryDesiredFields.ContactQueryDesiredFields_EmailAddress"]/*' />
    ContactQueryDesiredFields_EmailAddress = 0x2,

    /// <include file='ContactQueryDesiredFields.xml' path='doc/member[@name="ContactQueryDesiredFields.ContactQueryDesiredFields_PostalAddress"]/*' />
    ContactQueryDesiredFields_PostalAddress = 0x4,
}
