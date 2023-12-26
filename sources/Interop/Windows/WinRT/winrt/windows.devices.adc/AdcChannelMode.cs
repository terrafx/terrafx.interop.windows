// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.adc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AdcChannelMode.xml' path='doc/member[@name="AdcChannelMode"]/*' />
public enum AdcChannelMode
{
    /// <include file='AdcChannelMode.xml' path='doc/member[@name="AdcChannelMode.AdcChannelMode_SingleEnded"]/*' />
    AdcChannelMode_SingleEnded = 0,

    /// <include file='AdcChannelMode.xml' path='doc/member[@name="AdcChannelMode.AdcChannelMode_Differential"]/*' />
    AdcChannelMode_Differential = 1,
}
