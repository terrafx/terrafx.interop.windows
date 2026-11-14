// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.radios.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

public static partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_Radios_IRadio"]/*' />
    [NativeTypeName("const WCHAR[30]")]
    public const string InterfaceName_Windows_Devices_Radios_IRadio = "Windows.Devices.Radios.IRadio";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Devices_Radios_IRadioStatics"]/*' />
    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Devices_Radios_IRadioStatics = "Windows.Devices.Radios.IRadioStatics";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RuntimeClass_Windows_Devices_Radios_Radio"]/*' />
    [NativeTypeName("const WCHAR[29]")]
    public const string RuntimeClass_Windows_Devices_Radios_Radio = "Windows.Devices.Radios.Radio";
}
