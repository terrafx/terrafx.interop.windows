// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.power.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[31]")]
    public const string InterfaceName_Windows_Devices_Power_IBattery = "Windows.Devices.Power.IBattery";

    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Devices_Power_IBatteryReport = "Windows.Devices.Power.IBatteryReport";

    [NativeTypeName("const WCHAR[38]")]
    public const string InterfaceName_Windows_Devices_Power_IBatteryStatics = "Windows.Devices.Power.IBatteryStatics";

    [NativeTypeName("const WCHAR[30]")]
    public const string RuntimeClass_Windows_Devices_Power_Battery = "Windows.Devices.Power.Battery";

    [NativeTypeName("const WCHAR[36]")]
    public const string RuntimeClass_Windows_Devices_Power_BatteryReport = "Windows.Devices.Power.BatteryReport";
}
