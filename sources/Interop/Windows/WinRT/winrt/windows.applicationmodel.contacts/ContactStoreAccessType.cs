// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactStoreAccessType.xml' path='doc/member[@name="ContactStoreAccessType"]/*' />
public enum ContactStoreAccessType
{
    /// <include file='ContactStoreAccessType.xml' path='doc/member[@name="ContactStoreAccessType.ContactStoreAccessType_AppContactsReadWrite"]/*' />
    ContactStoreAccessType_AppContactsReadWrite = 0,

    /// <include file='ContactStoreAccessType.xml' path='doc/member[@name="ContactStoreAccessType.ContactStoreAccessType_AllContactsReadOnly"]/*' />
    ContactStoreAccessType_AllContactsReadOnly = 1,

    /// <include file='ContactStoreAccessType.xml' path='doc/member[@name="ContactStoreAccessType.ContactStoreAccessType_AllContactsReadWrite"]/*' />
    ContactStoreAccessType_AllContactsReadWrite = 2,
}
