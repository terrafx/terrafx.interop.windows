// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.pwm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PwmPulsePolarity.xml' path='doc/member[@name="PwmPulsePolarity"]/*' />
public enum PwmPulsePolarity
{
    /// <include file='PwmPulsePolarity.xml' path='doc/member[@name="PwmPulsePolarity.PwmPulsePolarity_ActiveHigh"]/*' />
    PwmPulsePolarity_ActiveHigh = 0,

    /// <include file='PwmPulsePolarity.xml' path='doc/member[@name="PwmPulsePolarity.PwmPulsePolarity_ActiveLow"]/*' />
    PwmPulsePolarity_ActiveLow = 1,
}
