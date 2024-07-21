// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AddContactResult.xml' path='doc/member[@name="AddContactResult"]/*' />
public enum AddContactResult
{
    /// <include file='AddContactResult.xml' path='doc/member[@name="AddContactResult.AddContactResult_Added"]/*' />
    AddContactResult_Added = 0,

    /// <include file='AddContactResult.xml' path='doc/member[@name="AddContactResult.AddContactResult_AlreadyAdded"]/*' />
    AddContactResult_AlreadyAdded = 1,

    /// <include file='AddContactResult.xml' path='doc/member[@name="AddContactResult.AddContactResult_Unavailable"]/*' />
    AddContactResult_Unavailable = 2,
}
