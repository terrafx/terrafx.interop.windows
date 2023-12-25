// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='ContactFieldType.xml' path='doc/member[@name="ContactFieldType"]/*' />
public enum ContactFieldType
{
    /// <include file='ContactFieldType.xml' path='doc/member[@name="ContactFieldType.ContactFieldType_Email"]/*' />
    ContactFieldType_Email = 0,

    /// <include file='ContactFieldType.xml' path='doc/member[@name="ContactFieldType.ContactFieldType_PhoneNumber"]/*' />
    ContactFieldType_PhoneNumber = 1,

    /// <include file='ContactFieldType.xml' path='doc/member[@name="ContactFieldType.ContactFieldType_Location"]/*' />
    [Obsolete("Location  may be altered or unavailable for releases after Windows 8.1. Instead, use Address.")]
    ContactFieldType_Location = 2,

    /// <include file='ContactFieldType.xml' path='doc/member[@name="ContactFieldType.ContactFieldType_InstantMessage"]/*' />
    [Obsolete("InstantMessage  may be altered or unavailable for releases after Windows 8.1. Instead, use ConnectedServiceAccount.")]
    ContactFieldType_InstantMessage = 3,

    /// <include file='ContactFieldType.xml' path='doc/member[@name="ContactFieldType.ContactFieldType_Custom"]/*' />
    [Obsolete("Custom may be altered or unavailable for releases after Windows 8.1. Instead, use one of the specific types.")]
    ContactFieldType_Custom = 4,

    /// <include file='ContactFieldType.xml' path='doc/member[@name="ContactFieldType.ContactFieldType_ConnectedServiceAccount"]/*' />
    ContactFieldType_ConnectedServiceAccount = 5,

    /// <include file='ContactFieldType.xml' path='doc/member[@name="ContactFieldType.ContactFieldType_ImportantDate"]/*' />
    ContactFieldType_ImportantDate = 6,

    /// <include file='ContactFieldType.xml' path='doc/member[@name="ContactFieldType.ContactFieldType_Address"]/*' />
    ContactFieldType_Address = 7,

    /// <include file='ContactFieldType.xml' path='doc/member[@name="ContactFieldType.ContactFieldType_SignificantOther"]/*' />
    ContactFieldType_SignificantOther = 8,

    /// <include file='ContactFieldType.xml' path='doc/member[@name="ContactFieldType.ContactFieldType_Notes"]/*' />
    ContactFieldType_Notes = 9,

    /// <include file='ContactFieldType.xml' path='doc/member[@name="ContactFieldType.ContactFieldType_Website"]/*' />
    ContactFieldType_Website = 10,

    /// <include file='ContactFieldType.xml' path='doc/member[@name="ContactFieldType.ContactFieldType_JobInfo"]/*' />
    ContactFieldType_JobInfo = 11,
}
