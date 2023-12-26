// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactAnnotationOperations.xml' path='doc/member[@name="ContactAnnotationOperations"]/*' />
[NativeTypeName("unsigned int")]
public enum ContactAnnotationOperations : uint
{
    /// <include file='ContactAnnotationOperations.xml' path='doc/member[@name="ContactAnnotationOperations.ContactAnnotationOperations_None"]/*' />
    ContactAnnotationOperations_None = 0,

    /// <include file='ContactAnnotationOperations.xml' path='doc/member[@name="ContactAnnotationOperations.ContactAnnotationOperations_ContactProfile"]/*' />
    ContactAnnotationOperations_ContactProfile = 0x1,

    /// <include file='ContactAnnotationOperations.xml' path='doc/member[@name="ContactAnnotationOperations.ContactAnnotationOperations_Message"]/*' />
    ContactAnnotationOperations_Message = 0x2,

    /// <include file='ContactAnnotationOperations.xml' path='doc/member[@name="ContactAnnotationOperations.ContactAnnotationOperations_AudioCall"]/*' />
    ContactAnnotationOperations_AudioCall = 0x4,

    /// <include file='ContactAnnotationOperations.xml' path='doc/member[@name="ContactAnnotationOperations.ContactAnnotationOperations_VideoCall"]/*' />
    ContactAnnotationOperations_VideoCall = 0x8,

    /// <include file='ContactAnnotationOperations.xml' path='doc/member[@name="ContactAnnotationOperations.ContactAnnotationOperations_SocialFeeds"]/*' />
    ContactAnnotationOperations_SocialFeeds = 0x10,

    /// <include file='ContactAnnotationOperations.xml' path='doc/member[@name="ContactAnnotationOperations.ContactAnnotationOperations_Share"]/*' />
    ContactAnnotationOperations_Share = 0x20,
}
