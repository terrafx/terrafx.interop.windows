// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DisplayBrightnessOverrideOptions.xml' path='doc/member[@name="DisplayBrightnessOverrideOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum DisplayBrightnessOverrideOptions : uint
{
    /// <include file='DisplayBrightnessOverrideOptions.xml' path='doc/member[@name="DisplayBrightnessOverrideOptions.DisplayBrightnessOverrideOptions_None"]/*' />
    DisplayBrightnessOverrideOptions_None = 0,

    /// <include file='DisplayBrightnessOverrideOptions.xml' path='doc/member[@name="DisplayBrightnessOverrideOptions.DisplayBrightnessOverrideOptions_UseDimmedPolicyWhenBatteryIsLow"]/*' />
    DisplayBrightnessOverrideOptions_UseDimmedPolicyWhenBatteryIsLow = 0x1,
}
