// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.radios.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RadioState.xml' path='doc/member[@name="RadioState"]/*' />
public enum RadioState
{
    /// <include file='RadioState.xml' path='doc/member[@name="RadioState.RadioState_Unknown"]/*' />
    RadioState_Unknown = 0,

    /// <include file='RadioState.xml' path='doc/member[@name="RadioState.RadioState_On"]/*' />
    RadioState_On = 1,

    /// <include file='RadioState.xml' path='doc/member[@name="RadioState.RadioState_Off"]/*' />
    RadioState_Off = 2,

    /// <include file='RadioState.xml' path='doc/member[@name="RadioState.RadioState_Disabled"]/*' />
    RadioState_Disabled = 3,
}
