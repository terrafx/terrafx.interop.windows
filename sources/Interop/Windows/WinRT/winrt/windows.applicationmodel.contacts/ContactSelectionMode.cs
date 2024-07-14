// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactSelectionMode.xml' path='doc/member[@name="ContactSelectionMode"]/*' />
public enum ContactSelectionMode
{
    /// <include file='ContactSelectionMode.xml' path='doc/member[@name="ContactSelectionMode.ContactSelectionMode_Contacts"]/*' />
    ContactSelectionMode_Contacts = 0,

    /// <include file='ContactSelectionMode.xml' path='doc/member[@name="ContactSelectionMode.ContactSelectionMode_Fields"]/*' />
    ContactSelectionMode_Fields = 1,
}
