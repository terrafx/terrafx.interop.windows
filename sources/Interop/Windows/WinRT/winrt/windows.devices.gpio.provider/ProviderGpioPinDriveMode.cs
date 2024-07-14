// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ProviderGpioPinDriveMode.xml' path='doc/member[@name="ProviderGpioPinDriveMode"]/*' />
public enum ProviderGpioPinDriveMode
{
    /// <include file='ProviderGpioPinDriveMode.xml' path='doc/member[@name="ProviderGpioPinDriveMode.ProviderGpioPinDriveMode_Input"]/*' />
    ProviderGpioPinDriveMode_Input = 0,

    /// <include file='ProviderGpioPinDriveMode.xml' path='doc/member[@name="ProviderGpioPinDriveMode.ProviderGpioPinDriveMode_Output"]/*' />
    ProviderGpioPinDriveMode_Output = 1,

    /// <include file='ProviderGpioPinDriveMode.xml' path='doc/member[@name="ProviderGpioPinDriveMode.ProviderGpioPinDriveMode_InputPullUp"]/*' />
    ProviderGpioPinDriveMode_InputPullUp = 2,

    /// <include file='ProviderGpioPinDriveMode.xml' path='doc/member[@name="ProviderGpioPinDriveMode.ProviderGpioPinDriveMode_InputPullDown"]/*' />
    ProviderGpioPinDriveMode_InputPullDown = 3,

    /// <include file='ProviderGpioPinDriveMode.xml' path='doc/member[@name="ProviderGpioPinDriveMode.ProviderGpioPinDriveMode_OutputOpenDrain"]/*' />
    ProviderGpioPinDriveMode_OutputOpenDrain = 4,

    /// <include file='ProviderGpioPinDriveMode.xml' path='doc/member[@name="ProviderGpioPinDriveMode.ProviderGpioPinDriveMode_OutputOpenDrainPullUp"]/*' />
    ProviderGpioPinDriveMode_OutputOpenDrainPullUp = 5,

    /// <include file='ProviderGpioPinDriveMode.xml' path='doc/member[@name="ProviderGpioPinDriveMode.ProviderGpioPinDriveMode_OutputOpenSource"]/*' />
    ProviderGpioPinDriveMode_OutputOpenSource = 6,

    /// <include file='ProviderGpioPinDriveMode.xml' path='doc/member[@name="ProviderGpioPinDriveMode.ProviderGpioPinDriveMode_OutputOpenSourcePullDown"]/*' />
    ProviderGpioPinDriveMode_OutputOpenSourcePullDown = 7,
}
