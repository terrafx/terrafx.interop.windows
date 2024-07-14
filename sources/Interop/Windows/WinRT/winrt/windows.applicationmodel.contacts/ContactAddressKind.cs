// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactAddressKind.xml' path='doc/member[@name="ContactAddressKind"]/*' />
public enum ContactAddressKind
{
    /// <include file='ContactAddressKind.xml' path='doc/member[@name="ContactAddressKind.ContactAddressKind_Home"]/*' />
    ContactAddressKind_Home = 0,

    /// <include file='ContactAddressKind.xml' path='doc/member[@name="ContactAddressKind.ContactAddressKind_Work"]/*' />
    ContactAddressKind_Work = 1,

    /// <include file='ContactAddressKind.xml' path='doc/member[@name="ContactAddressKind.ContactAddressKind_Other"]/*' />
    ContactAddressKind_Other = 2,
}
