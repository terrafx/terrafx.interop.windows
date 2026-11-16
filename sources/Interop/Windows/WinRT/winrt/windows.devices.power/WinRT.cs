// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.power.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

public static partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_Power_IBattery"]/*' />
    [NativeTypeName("const WCHAR[31]")]
    public const string InterfaceName_Windows_Devices_Power_IBattery = "Windows.Devices.Power.IBattery";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_Power_IBatteryReport"]/*' />
    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Devices_Power_IBatteryReport = "Windows.Devices.Power.IBatteryReport";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_Power_IBatteryStatics"]/*' />
    [NativeTypeName("const WCHAR[38]")]
    public const string InterfaceName_Windows_Devices_Power_IBatteryStatics = "Windows.Devices.Power.IBatteryStatics";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_Power_IPowerGridData"]/*' />
    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Devices_Power_IPowerGridData = "Windows.Devices.Power.IPowerGridData";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_Power_IPowerGridForecast"]/*' />
    [NativeTypeName("const WCHAR[41]")]
    public const string InterfaceName_Windows_Devices_Power_IPowerGridForecast = "Windows.Devices.Power.IPowerGridForecast";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_Power_IPowerGridForecastStatics"]/*' />
    [NativeTypeName("const WCHAR[48]")]
    public const string InterfaceName_Windows_Devices_Power_IPowerGridForecastStatics = "Windows.Devices.Power.IPowerGridForecastStatics";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RuntimeClass_Windows_Devices_Power_Battery"]/*' />
    [NativeTypeName("const WCHAR[30]")]
    public const string RuntimeClass_Windows_Devices_Power_Battery = "Windows.Devices.Power.Battery";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RuntimeClass_Windows_Devices_Power_BatteryReport"]/*' />
    [NativeTypeName("const WCHAR[36]")]
    public const string RuntimeClass_Windows_Devices_Power_BatteryReport = "Windows.Devices.Power.BatteryReport";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RuntimeClass_Windows_Devices_Power_PowerGridData"]/*' />
    [NativeTypeName("const WCHAR[36]")]
    public const string RuntimeClass_Windows_Devices_Power_PowerGridData = "Windows.Devices.Power.PowerGridData";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RuntimeClass_Windows_Devices_Power_PowerGridForecast"]/*' />
    [NativeTypeName("const WCHAR[40]")]
    public const string RuntimeClass_Windows_Devices_Power_PowerGridForecast = "Windows.Devices.Power.PowerGridForecast";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WINDOWS_DEVICES_POWER_POWERGRIDAPICONTRACT_VERSION"]/*' />
    [NativeTypeName("#define WINDOWS_DEVICES_POWER_POWERGRIDAPICONTRACT_VERSION 0x10000")]
    public const int WINDOWS_DEVICES_POWER_POWERGRIDAPICONTRACT_VERSION = 0x10000;
}
