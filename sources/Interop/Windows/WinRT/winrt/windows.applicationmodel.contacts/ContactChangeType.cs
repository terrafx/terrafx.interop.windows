// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactChangeType.xml' path='doc/member[@name="ContactChangeType"]/*' />
public enum ContactChangeType
{
    /// <include file='ContactChangeType.xml' path='doc/member[@name="ContactChangeType.ContactChangeType_Created"]/*' />
    ContactChangeType_Created = 0,

    /// <include file='ContactChangeType.xml' path='doc/member[@name="ContactChangeType.ContactChangeType_Modified"]/*' />
    ContactChangeType_Modified = 1,

    /// <include file='ContactChangeType.xml' path='doc/member[@name="ContactChangeType.ContactChangeType_Deleted"]/*' />
    ContactChangeType_Deleted = 2,

    /// <include file='ContactChangeType.xml' path='doc/member[@name="ContactChangeType.ContactChangeType_ChangeTrackingLost"]/*' />
    ContactChangeType_ChangeTrackingLost = 3,
}
