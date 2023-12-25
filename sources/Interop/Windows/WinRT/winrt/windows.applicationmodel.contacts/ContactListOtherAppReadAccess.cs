// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactListOtherAppReadAccess.xml' path='doc/member[@name="ContactListOtherAppReadAccess"]/*' />
public enum ContactListOtherAppReadAccess
{
    /// <include file='ContactListOtherAppReadAccess.xml' path='doc/member[@name="ContactListOtherAppReadAccess.ContactListOtherAppReadAccess_SystemOnly"]/*' />
    ContactListOtherAppReadAccess_SystemOnly = 0,

    /// <include file='ContactListOtherAppReadAccess.xml' path='doc/member[@name="ContactListOtherAppReadAccess.ContactListOtherAppReadAccess_Limited"]/*' />
    ContactListOtherAppReadAccess_Limited = 1,

    /// <include file='ContactListOtherAppReadAccess.xml' path='doc/member[@name="ContactListOtherAppReadAccess.ContactListOtherAppReadAccess_Full"]/*' />
    ContactListOtherAppReadAccess_Full = 2,

    /// <include file='ContactListOtherAppReadAccess.xml' path='doc/member[@name="ContactListOtherAppReadAccess.ContactListOtherAppReadAccess_None"]/*' />
    ContactListOtherAppReadAccess_None = 3,
}
