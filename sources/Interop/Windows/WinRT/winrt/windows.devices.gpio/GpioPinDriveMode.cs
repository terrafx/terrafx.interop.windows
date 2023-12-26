// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GpioPinDriveMode.xml' path='doc/member[@name="GpioPinDriveMode"]/*' />
public enum GpioPinDriveMode
{
    /// <include file='GpioPinDriveMode.xml' path='doc/member[@name="GpioPinDriveMode.GpioPinDriveMode_Input"]/*' />
    GpioPinDriveMode_Input = 0,

    /// <include file='GpioPinDriveMode.xml' path='doc/member[@name="GpioPinDriveMode.GpioPinDriveMode_Output"]/*' />
    GpioPinDriveMode_Output = 1,

    /// <include file='GpioPinDriveMode.xml' path='doc/member[@name="GpioPinDriveMode.GpioPinDriveMode_InputPullUp"]/*' />
    GpioPinDriveMode_InputPullUp = 2,

    /// <include file='GpioPinDriveMode.xml' path='doc/member[@name="GpioPinDriveMode.GpioPinDriveMode_InputPullDown"]/*' />
    GpioPinDriveMode_InputPullDown = 3,

    /// <include file='GpioPinDriveMode.xml' path='doc/member[@name="GpioPinDriveMode.GpioPinDriveMode_OutputOpenDrain"]/*' />
    GpioPinDriveMode_OutputOpenDrain = 4,

    /// <include file='GpioPinDriveMode.xml' path='doc/member[@name="GpioPinDriveMode.GpioPinDriveMode_OutputOpenDrainPullUp"]/*' />
    GpioPinDriveMode_OutputOpenDrainPullUp = 5,

    /// <include file='GpioPinDriveMode.xml' path='doc/member[@name="GpioPinDriveMode.GpioPinDriveMode_OutputOpenSource"]/*' />
    GpioPinDriveMode_OutputOpenSource = 6,

    /// <include file='GpioPinDriveMode.xml' path='doc/member[@name="GpioPinDriveMode.GpioPinDriveMode_OutputOpenSourcePullDown"]/*' />
    GpioPinDriveMode_OutputOpenSourcePullDown = 7,
}
