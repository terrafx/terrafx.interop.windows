// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactCardHeaderKind.xml' path='doc/member[@name="ContactCardHeaderKind"]/*' />
public enum ContactCardHeaderKind
{
    /// <include file='ContactCardHeaderKind.xml' path='doc/member[@name="ContactCardHeaderKind.ContactCardHeaderKind_Default"]/*' />
    ContactCardHeaderKind_Default = 0,

    /// <include file='ContactCardHeaderKind.xml' path='doc/member[@name="ContactCardHeaderKind.ContactCardHeaderKind_Basic"]/*' />
    ContactCardHeaderKind_Basic = 1,

    /// <include file='ContactCardHeaderKind.xml' path='doc/member[@name="ContactCardHeaderKind.ContactCardHeaderKind_Enterprise"]/*' />
    ContactCardHeaderKind_Enterprise = 2,
}
