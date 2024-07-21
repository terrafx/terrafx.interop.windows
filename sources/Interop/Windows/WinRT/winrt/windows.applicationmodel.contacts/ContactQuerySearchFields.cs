// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactQuerySearchFields.xml' path='doc/member[@name="ContactQuerySearchFields"]/*' />
[NativeTypeName("unsigned int")]
public enum ContactQuerySearchFields : uint
{
    /// <include file='ContactQuerySearchFields.xml' path='doc/member[@name="ContactQuerySearchFields.ContactQuerySearchFields_None"]/*' />
    ContactQuerySearchFields_None = 0,

    /// <include file='ContactQuerySearchFields.xml' path='doc/member[@name="ContactQuerySearchFields.ContactQuerySearchFields_Name"]/*' />
    ContactQuerySearchFields_Name = 0x1,

    /// <include file='ContactQuerySearchFields.xml' path='doc/member[@name="ContactQuerySearchFields.ContactQuerySearchFields_Email"]/*' />
    ContactQuerySearchFields_Email = 0x2,

    /// <include file='ContactQuerySearchFields.xml' path='doc/member[@name="ContactQuerySearchFields.ContactQuerySearchFields_Phone"]/*' />
    ContactQuerySearchFields_Phone = 0x4,

    /// <include file='ContactQuerySearchFields.xml' path='doc/member[@name="ContactQuerySearchFields.ContactQuerySearchFields_All"]/*' />
    ContactQuerySearchFields_All = 0xffffffff,
}
