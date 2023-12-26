// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactRelationship.xml' path='doc/member[@name="ContactRelationship"]/*' />
public enum ContactRelationship
{
    /// <include file='ContactRelationship.xml' path='doc/member[@name="ContactRelationship.ContactRelationship_Other"]/*' />
    ContactRelationship_Other = 0,

    /// <include file='ContactRelationship.xml' path='doc/member[@name="ContactRelationship.ContactRelationship_Spouse"]/*' />
    ContactRelationship_Spouse = 1,

    /// <include file='ContactRelationship.xml' path='doc/member[@name="ContactRelationship.ContactRelationship_Partner"]/*' />
    ContactRelationship_Partner = 2,

    /// <include file='ContactRelationship.xml' path='doc/member[@name="ContactRelationship.ContactRelationship_Sibling"]/*' />
    ContactRelationship_Sibling = 3,

    /// <include file='ContactRelationship.xml' path='doc/member[@name="ContactRelationship.ContactRelationship_Parent"]/*' />
    ContactRelationship_Parent = 4,

    /// <include file='ContactRelationship.xml' path='doc/member[@name="ContactRelationship.ContactRelationship_Child"]/*' />
    ContactRelationship_Child = 5,
}
