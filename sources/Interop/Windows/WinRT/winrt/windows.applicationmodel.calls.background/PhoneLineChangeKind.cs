// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneLineChangeKind.xml' path='doc/member[@name="PhoneLineChangeKind"]/*' />
public enum PhoneLineChangeKind
{
    /// <include file='PhoneLineChangeKind.xml' path='doc/member[@name="PhoneLineChangeKind.PhoneLineChangeKind_Added"]/*' />
    PhoneLineChangeKind_Added = 0,

    /// <include file='PhoneLineChangeKind.xml' path='doc/member[@name="PhoneLineChangeKind.PhoneLineChangeKind_Removed"]/*' />
    PhoneLineChangeKind_Removed = 1,

    /// <include file='PhoneLineChangeKind.xml' path='doc/member[@name="PhoneLineChangeKind.PhoneLineChangeKind_PropertiesChanged"]/*' />
    PhoneLineChangeKind_PropertiesChanged = 2,
}
