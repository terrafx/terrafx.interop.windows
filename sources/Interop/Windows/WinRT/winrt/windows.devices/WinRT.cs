// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

public static partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_ILowLevelDevicesAggregateProvider"]/*' />
    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Devices_ILowLevelDevicesAggregateProvider = "Windows.Devices.ILowLevelDevicesAggregateProvider";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_ILowLevelDevicesAggregateProviderFactory"]/*' />
    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Devices_ILowLevelDevicesAggregateProviderFactory = "Windows.Devices.ILowLevelDevicesAggregateProviderFactory";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_ILowLevelDevicesController"]/*' />
    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Devices_ILowLevelDevicesController = "Windows.Devices.ILowLevelDevicesController";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_ILowLevelDevicesControllerStatics"]/*' />
    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Devices_ILowLevelDevicesControllerStatics = "Windows.Devices.ILowLevelDevicesControllerStatics";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RuntimeClass_Windows_Devices_LowLevelDevicesAggregateProvider"]/*' />
    [NativeTypeName("const WCHAR[49]")]
    public const string RuntimeClass_Windows_Devices_LowLevelDevicesAggregateProvider = "Windows.Devices.LowLevelDevicesAggregateProvider";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RuntimeClass_Windows_Devices_LowLevelDevicesController"]/*' />
    [NativeTypeName("const WCHAR[42]")]
    public const string RuntimeClass_Windows_Devices_LowLevelDevicesController = "Windows.Devices.LowLevelDevicesController";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WINDOWS_DEVICES_DEVICESLOWLEVELCONTRACT_VERSION"]/*' />
    [NativeTypeName("#define WINDOWS_DEVICES_DEVICESLOWLEVELCONTRACT_VERSION 0x30000")]
    public const int WINDOWS_DEVICES_DEVICESLOWLEVELCONTRACT_VERSION = 0x30000;
}
