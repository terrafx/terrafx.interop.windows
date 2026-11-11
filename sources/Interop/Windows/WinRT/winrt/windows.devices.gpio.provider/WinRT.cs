// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.provider.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

public static partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_Gpio_Provider_IGpioControllerProvider"]/*' />
    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_Devices_Gpio_Provider_IGpioControllerProvider = "Windows.Devices.Gpio.Provider.IGpioControllerProvider";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_Gpio_Provider_IGpioPinProvider"]/*' />
    [NativeTypeName("const WCHAR[47]")]
    public const string InterfaceName_Windows_Devices_Gpio_Provider_IGpioPinProvider = "Windows.Devices.Gpio.Provider.IGpioPinProvider";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_Gpio_Provider_IGpioPinProviderValueChangedEventArgs"]/*' />
    [NativeTypeName("const WCHAR[68]")]
    public const string InterfaceName_Windows_Devices_Gpio_Provider_IGpioPinProviderValueChangedEventArgs = "Windows.Devices.Gpio.Provider.IGpioPinProviderValueChangedEventArgs";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_Gpio_Provider_IGpioPinProviderValueChangedEventArgsFactory"]/*' />
    [NativeTypeName("const WCHAR[75]")]
    public const string InterfaceName_Windows_Devices_Gpio_Provider_IGpioPinProviderValueChangedEventArgsFactory = "Windows.Devices.Gpio.Provider.IGpioPinProviderValueChangedEventArgsFactory";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_Gpio_Provider_IGpioProvider"]/*' />
    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_Devices_Gpio_Provider_IGpioProvider = "Windows.Devices.Gpio.Provider.IGpioProvider";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RuntimeClass_Windows_Devices_Gpio_Provider_GpioPinProviderValueChangedEventArgs"]/*' />
    [NativeTypeName("const WCHAR[67]")]
    public const string RuntimeClass_Windows_Devices_Gpio_Provider_GpioPinProviderValueChangedEventArgs = "Windows.Devices.Gpio.Provider.GpioPinProviderValueChangedEventArgs";
}
