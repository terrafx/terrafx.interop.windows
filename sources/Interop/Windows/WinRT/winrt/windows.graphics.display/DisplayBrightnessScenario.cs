// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DisplayBrightnessScenario.xml' path='doc/member[@name="DisplayBrightnessScenario"]/*' />
public enum DisplayBrightnessScenario
{
    /// <include file='DisplayBrightnessScenario.xml' path='doc/member[@name="DisplayBrightnessScenario.DisplayBrightnessScenario_DefaultBrightness"]/*' />
    DisplayBrightnessScenario_DefaultBrightness = 0,

    /// <include file='DisplayBrightnessScenario.xml' path='doc/member[@name="DisplayBrightnessScenario.DisplayBrightnessScenario_IdleBrightness"]/*' />
    DisplayBrightnessScenario_IdleBrightness = 1,

    /// <include file='DisplayBrightnessScenario.xml' path='doc/member[@name="DisplayBrightnessScenario.DisplayBrightnessScenario_BarcodeReadingBrightness"]/*' />
    DisplayBrightnessScenario_BarcodeReadingBrightness = 2,

    /// <include file='DisplayBrightnessScenario.xml' path='doc/member[@name="DisplayBrightnessScenario.DisplayBrightnessScenario_FullBrightness"]/*' />
    DisplayBrightnessScenario_FullBrightness = 3,
}
