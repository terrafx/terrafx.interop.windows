// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DisplayBrightnessOverrideScenario.xml' path='doc/member[@name="DisplayBrightnessOverrideScenario"]/*' />
public enum DisplayBrightnessOverrideScenario
{
    /// <include file='DisplayBrightnessOverrideScenario.xml' path='doc/member[@name="DisplayBrightnessOverrideScenario.DisplayBrightnessOverrideScenario_IdleBrightness"]/*' />
    DisplayBrightnessOverrideScenario_IdleBrightness = 0,

    /// <include file='DisplayBrightnessOverrideScenario.xml' path='doc/member[@name="DisplayBrightnessOverrideScenario.DisplayBrightnessOverrideScenario_BarcodeReadingBrightness"]/*' />
    DisplayBrightnessOverrideScenario_BarcodeReadingBrightness = 1,

    /// <include file='DisplayBrightnessOverrideScenario.xml' path='doc/member[@name="DisplayBrightnessOverrideScenario.DisplayBrightnessOverrideScenario_FullBrightness"]/*' />
    DisplayBrightnessOverrideScenario_FullBrightness = 2,
}
