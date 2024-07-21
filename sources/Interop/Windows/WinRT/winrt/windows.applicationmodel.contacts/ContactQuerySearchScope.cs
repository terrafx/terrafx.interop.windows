// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactQuerySearchScope.xml' path='doc/member[@name="ContactQuerySearchScope"]/*' />
public enum ContactQuerySearchScope
{
    /// <include file='ContactQuerySearchScope.xml' path='doc/member[@name="ContactQuerySearchScope.ContactQuerySearchScope_Local"]/*' />
    ContactQuerySearchScope_Local = 0,

    /// <include file='ContactQuerySearchScope.xml' path='doc/member[@name="ContactQuerySearchScope.ContactQuerySearchScope_Server"]/*' />
    ContactQuerySearchScope_Server = 1,
}
