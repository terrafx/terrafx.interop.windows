// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneSimState.xml' path='doc/member[@name="PhoneSimState"]/*' />
public enum PhoneSimState
{
    /// <include file='PhoneSimState.xml' path='doc/member[@name="PhoneSimState.PhoneSimState_Unknown"]/*' />
    PhoneSimState_Unknown = 0,

    /// <include file='PhoneSimState.xml' path='doc/member[@name="PhoneSimState.PhoneSimState_PinNotRequired"]/*' />
    PhoneSimState_PinNotRequired = 1,

    /// <include file='PhoneSimState.xml' path='doc/member[@name="PhoneSimState.PhoneSimState_PinUnlocked"]/*' />
    PhoneSimState_PinUnlocked = 2,

    /// <include file='PhoneSimState.xml' path='doc/member[@name="PhoneSimState.PhoneSimState_PinLocked"]/*' />
    PhoneSimState_PinLocked = 3,

    /// <include file='PhoneSimState.xml' path='doc/member[@name="PhoneSimState.PhoneSimState_PukLocked"]/*' />
    PhoneSimState_PukLocked = 4,

    /// <include file='PhoneSimState.xml' path='doc/member[@name="PhoneSimState.PhoneSimState_NotInserted"]/*' />
    PhoneSimState_NotInserted = 5,

    /// <include file='PhoneSimState.xml' path='doc/member[@name="PhoneSimState.PhoneSimState_Invalid"]/*' />
    PhoneSimState_Invalid = 6,

    /// <include file='PhoneSimState.xml' path='doc/member[@name="PhoneSimState.PhoneSimState_Disabled"]/*' />
    PhoneSimState_Disabled = 7,
}
