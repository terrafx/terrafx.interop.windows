// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactListOtherAppWriteAccess.xml' path='doc/member[@name="ContactListOtherAppWriteAccess"]/*' />
public enum ContactListOtherAppWriteAccess
{
    /// <include file='ContactListOtherAppWriteAccess.xml' path='doc/member[@name="ContactListOtherAppWriteAccess.ContactListOtherAppWriteAccess_None"]/*' />
    ContactListOtherAppWriteAccess_None = 0,

    /// <include file='ContactListOtherAppWriteAccess.xml' path='doc/member[@name="ContactListOtherAppWriteAccess.ContactListOtherAppWriteAccess_SystemOnly"]/*' />
    ContactListOtherAppWriteAccess_SystemOnly = 1,

    /// <include file='ContactListOtherAppWriteAccess.xml' path='doc/member[@name="ContactListOtherAppWriteAccess.ContactListOtherAppWriteAccess_Limited"]/*' />
    ContactListOtherAppWriteAccess_Limited = 2,
}
