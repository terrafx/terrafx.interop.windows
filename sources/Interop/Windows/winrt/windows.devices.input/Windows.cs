// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const WCHAR [44]")]
        public const string InterfaceName_Windows_Devices_Input_IKeyboardCapabilities = "Windows.Devices.Input.IKeyboardCapabilities";

        [NativeTypeName("const WCHAR [41]")]
        public const string InterfaceName_Windows_Devices_Input_IMouseCapabilities = "Windows.Devices.Input.IMouseCapabilities";

        [NativeTypeName("const WCHAR [35]")]
        public const string InterfaceName_Windows_Devices_Input_IMouseDevice = "Windows.Devices.Input.IMouseDevice";

        [NativeTypeName("const WCHAR [42]")]
        public const string InterfaceName_Windows_Devices_Input_IMouseDeviceStatics = "Windows.Devices.Input.IMouseDeviceStatics";

        [NativeTypeName("const WCHAR [38]")]
        public const string InterfaceName_Windows_Devices_Input_IMouseEventArgs = "Windows.Devices.Input.IMouseEventArgs";

        [NativeTypeName("const WCHAR [41]")]
        public const string InterfaceName_Windows_Devices_Input_IPenButtonListener = "Windows.Devices.Input.IPenButtonListener";

        [NativeTypeName("const WCHAR [48]")]
        public const string InterfaceName_Windows_Devices_Input_IPenButtonListenerStatics = "Windows.Devices.Input.IPenButtonListenerStatics";

        [NativeTypeName("const WCHAR [33]")]
        public const string InterfaceName_Windows_Devices_Input_IPenDevice = "Windows.Devices.Input.IPenDevice";

        [NativeTypeName("const WCHAR [40]")]
        public const string InterfaceName_Windows_Devices_Input_IPenDeviceStatics = "Windows.Devices.Input.IPenDeviceStatics";

        [NativeTypeName("const WCHAR [39]")]
        public const string InterfaceName_Windows_Devices_Input_IPenDockListener = "Windows.Devices.Input.IPenDockListener";

        [NativeTypeName("const WCHAR [46]")]
        public const string InterfaceName_Windows_Devices_Input_IPenDockListenerStatics = "Windows.Devices.Input.IPenDockListenerStatics";

        [NativeTypeName("const WCHAR [42]")]
        public const string InterfaceName_Windows_Devices_Input_IPenDockedEventArgs = "Windows.Devices.Input.IPenDockedEventArgs";

        [NativeTypeName("const WCHAR [53]")]
        public const string InterfaceName_Windows_Devices_Input_IPenTailButtonClickedEventArgs = "Windows.Devices.Input.IPenTailButtonClickedEventArgs";

        [NativeTypeName("const WCHAR [59]")]
        public const string InterfaceName_Windows_Devices_Input_IPenTailButtonDoubleClickedEventArgs = "Windows.Devices.Input.IPenTailButtonDoubleClickedEventArgs";

        [NativeTypeName("const WCHAR [57]")]
        public const string InterfaceName_Windows_Devices_Input_IPenTailButtonLongPressedEventArgs = "Windows.Devices.Input.IPenTailButtonLongPressedEventArgs";

        [NativeTypeName("const WCHAR [44]")]
        public const string InterfaceName_Windows_Devices_Input_IPenUndockedEventArgs = "Windows.Devices.Input.IPenUndockedEventArgs";

        [NativeTypeName("const WCHAR [37]")]
        public const string InterfaceName_Windows_Devices_Input_IPointerDevice = "Windows.Devices.Input.IPointerDevice";

        [NativeTypeName("const WCHAR [38]")]
        public const string InterfaceName_Windows_Devices_Input_IPointerDevice2 = "Windows.Devices.Input.IPointerDevice2";

        [NativeTypeName("const WCHAR [44]")]
        public const string InterfaceName_Windows_Devices_Input_IPointerDeviceStatics = "Windows.Devices.Input.IPointerDeviceStatics";

        [NativeTypeName("const WCHAR [41]")]
        public const string InterfaceName_Windows_Devices_Input_ITouchCapabilities = "Windows.Devices.Input.ITouchCapabilities";

        [NativeTypeName("const WCHAR [43]")]
        public const string RuntimeClass_Windows_Devices_Input_KeyboardCapabilities = "Windows.Devices.Input.KeyboardCapabilities";

        [NativeTypeName("const WCHAR [40]")]
        public const string RuntimeClass_Windows_Devices_Input_MouseCapabilities = "Windows.Devices.Input.MouseCapabilities";

        [NativeTypeName("const WCHAR [34]")]
        public const string RuntimeClass_Windows_Devices_Input_MouseDevice = "Windows.Devices.Input.MouseDevice";

        [NativeTypeName("const WCHAR [37]")]
        public const string RuntimeClass_Windows_Devices_Input_MouseEventArgs = "Windows.Devices.Input.MouseEventArgs";

        [NativeTypeName("const WCHAR [40]")]
        public const string RuntimeClass_Windows_Devices_Input_PenButtonListener = "Windows.Devices.Input.PenButtonListener";

        [NativeTypeName("const WCHAR [32]")]
        public const string RuntimeClass_Windows_Devices_Input_PenDevice = "Windows.Devices.Input.PenDevice";

        [NativeTypeName("const WCHAR [38]")]
        public const string RuntimeClass_Windows_Devices_Input_PenDockListener = "Windows.Devices.Input.PenDockListener";

        [NativeTypeName("const WCHAR [41]")]
        public const string RuntimeClass_Windows_Devices_Input_PenDockedEventArgs = "Windows.Devices.Input.PenDockedEventArgs";

        [NativeTypeName("const WCHAR [52]")]
        public const string RuntimeClass_Windows_Devices_Input_PenTailButtonClickedEventArgs = "Windows.Devices.Input.PenTailButtonClickedEventArgs";

        [NativeTypeName("const WCHAR [58]")]
        public const string RuntimeClass_Windows_Devices_Input_PenTailButtonDoubleClickedEventArgs = "Windows.Devices.Input.PenTailButtonDoubleClickedEventArgs";

        [NativeTypeName("const WCHAR [56]")]
        public const string RuntimeClass_Windows_Devices_Input_PenTailButtonLongPressedEventArgs = "Windows.Devices.Input.PenTailButtonLongPressedEventArgs";

        [NativeTypeName("const WCHAR [43]")]
        public const string RuntimeClass_Windows_Devices_Input_PenUndockedEventArgs = "Windows.Devices.Input.PenUndockedEventArgs";

        [NativeTypeName("const WCHAR [36]")]
        public const string RuntimeClass_Windows_Devices_Input_PointerDevice = "Windows.Devices.Input.PointerDevice";

        [NativeTypeName("const WCHAR [40]")]
        public const string RuntimeClass_Windows_Devices_Input_TouchCapabilities = "Windows.Devices.Input.TouchCapabilities";

        public static readonly Guid IID_IKeyboardCapabilities = new Guid(0x3A3F9B56, 0x6798, 0x4BBC, 0x83, 0x3E, 0x0F, 0x34, 0xB1, 0x7C, 0x65, 0xFF);

        public static readonly Guid IID_IMouseCapabilities = new Guid(0xBCA5E023, 0x7DD9, 0x4B6B, 0x9A, 0x92, 0x55, 0xD4, 0x3C, 0xB3, 0x8F, 0x73);

        public static readonly Guid IID_IMouseDevice = new Guid(0x88EDF458, 0xF2C8, 0x49F4, 0xBE, 0x1F, 0xC2, 0x56, 0xB3, 0x88, 0xBC, 0x11);

        public static readonly Guid IID_IMouseDeviceStatics = new Guid(0x484A9045, 0x6D70, 0x49DB, 0x8E, 0x68, 0x46, 0xFF, 0xBD, 0x17, 0xD3, 0x8D);

        public static readonly Guid IID_IMouseEventArgs = new Guid(0xF625AA5D, 0x2354, 0x4CC7, 0x92, 0x30, 0x96, 0x94, 0x1C, 0x96, 0x9F, 0xDE);

        public static readonly Guid IID_IPenButtonListener = new Guid(0x8245C376, 0x1EE3, 0x53F7, 0xB1, 0xF7, 0x83, 0x34, 0xA1, 0x6F, 0x28, 0x15);

        public static readonly Guid IID_IPenButtonListenerStatics = new Guid(0x19A8A584, 0x862F, 0x5F69, 0xBF, 0xEA, 0x05, 0xF6, 0x58, 0x4F, 0x13, 0x3F);

        public static readonly Guid IID_IPenDevice = new Guid(0x31856EBA, 0xA738, 0x5A8C, 0xB8, 0xF6, 0xF9, 0x7E, 0xF6, 0x8D, 0x18, 0xEF);

        public static readonly Guid IID_IPenDeviceStatics = new Guid(0x9DFBBE01, 0x0966, 0x5180, 0xBC, 0xB4, 0xB8, 0x50, 0x60, 0xE3, 0x94, 0x79);

        public static readonly Guid IID_IPenDockListener = new Guid(0x759F4D90, 0x1DC0, 0x55CB, 0xAD, 0x18, 0xB9, 0x10, 0x14, 0x56, 0xF5, 0x92);

        public static readonly Guid IID_IPenDockListenerStatics = new Guid(0xCAB75E9A, 0x0016, 0x5C72, 0x96, 0x9E, 0xA9, 0x7E, 0x11, 0x99, 0x2A, 0x93);

        public static readonly Guid IID_IPenDockedEventArgs = new Guid(0xFD4277C6, 0xCA63, 0x5D4E, 0x9E, 0xD3, 0xA2, 0x8A, 0x54, 0x52, 0x1C, 0x8C);

        public static readonly Guid IID_IPenTailButtonClickedEventArgs = new Guid(0x5D2FB7B6, 0x6AD3, 0x5D3E, 0xAB, 0x29, 0x05, 0xEA, 0x24, 0x10, 0xE3, 0x90);

        public static readonly Guid IID_IPenTailButtonDoubleClickedEventArgs = new Guid(0x846321A2, 0x618A, 0x5478, 0xB0, 0x4C, 0xB3, 0x58, 0x23, 0x1D, 0xA4, 0xA7);

        public static readonly Guid IID_IPenTailButtonLongPressedEventArgs = new Guid(0xF37C606E, 0xC60A, 0x5F42, 0xB8, 0x18, 0xA5, 0x31, 0x12, 0x40, 0x6C, 0x13);

        public static readonly Guid IID_IPenUndockedEventArgs = new Guid(0xCCD09150, 0x261B, 0x59E6, 0xA5, 0xD4, 0xC1, 0x96, 0x4C, 0xD0, 0x3F, 0xEB);

        public static readonly Guid IID_IPointerDevice = new Guid(0x93C9BAFC, 0xEBCB, 0x467E, 0x82, 0xC6, 0x27, 0x6F, 0xEA, 0xE3, 0x6B, 0x5A);

        public static readonly Guid IID_IPointerDevice2 = new Guid(0xF8A6D2A0, 0xC484, 0x489F, 0xAE, 0x3E, 0x30, 0xD2, 0xEE, 0x1F, 0xFD, 0x3E);

        public static readonly Guid IID_IPointerDeviceStatics = new Guid(0xD8B89AA1, 0xD1C6, 0x416E, 0xBD, 0x8D, 0x57, 0x90, 0x91, 0x4D, 0xC5, 0x63);

        public static readonly Guid IID_ITouchCapabilities = new Guid(0x20DD55F9, 0x13F1, 0x46C8, 0x92, 0x85, 0x2C, 0x05, 0xFA, 0x3E, 0xDA, 0x6F);
    }
}
