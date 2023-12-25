// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ColorTemperaturePreset.xml' path='doc/member[@name="ColorTemperaturePreset"]/*' />
public enum ColorTemperaturePreset
{
    /// <include file='ColorTemperaturePreset.xml' path='doc/member[@name="ColorTemperaturePreset.ColorTemperaturePreset_Auto"]/*' />
    ColorTemperaturePreset_Auto = 0,

    /// <include file='ColorTemperaturePreset.xml' path='doc/member[@name="ColorTemperaturePreset.ColorTemperaturePreset_Manual"]/*' />
    ColorTemperaturePreset_Manual = 1,

    /// <include file='ColorTemperaturePreset.xml' path='doc/member[@name="ColorTemperaturePreset.ColorTemperaturePreset_Cloudy"]/*' />
    ColorTemperaturePreset_Cloudy = 2,

    /// <include file='ColorTemperaturePreset.xml' path='doc/member[@name="ColorTemperaturePreset.ColorTemperaturePreset_Daylight"]/*' />
    ColorTemperaturePreset_Daylight = 3,

    /// <include file='ColorTemperaturePreset.xml' path='doc/member[@name="ColorTemperaturePreset.ColorTemperaturePreset_Flash"]/*' />
    ColorTemperaturePreset_Flash = 4,

    /// <include file='ColorTemperaturePreset.xml' path='doc/member[@name="ColorTemperaturePreset.ColorTemperaturePreset_Fluorescent"]/*' />
    ColorTemperaturePreset_Fluorescent = 5,

    /// <include file='ColorTemperaturePreset.xml' path='doc/member[@name="ColorTemperaturePreset.ColorTemperaturePreset_Tungsten"]/*' />
    ColorTemperaturePreset_Tungsten = 6,

    /// <include file='ColorTemperaturePreset.xml' path='doc/member[@name="ColorTemperaturePreset.ColorTemperaturePreset_Candlelight"]/*' />
    ColorTemperaturePreset_Candlelight = 7,
}
