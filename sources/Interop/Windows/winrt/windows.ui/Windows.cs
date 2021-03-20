// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const WCHAR [24]")]
        public const string InterfaceName_Windows_UI_IColorHelper = "Windows.UI.IColorHelper";

        [NativeTypeName("const WCHAR [31]")]
        public const string InterfaceName_Windows_UI_IColorHelperStatics = "Windows.UI.IColorHelperStatics";

        [NativeTypeName("const WCHAR [32]")]
        public const string InterfaceName_Windows_UI_IColorHelperStatics2 = "Windows.UI.IColorHelperStatics2";

        [NativeTypeName("const WCHAR [19]")]
        public const string InterfaceName_Windows_UI_IColors = "Windows.UI.IColors";

        [NativeTypeName("const WCHAR [26]")]
        public const string InterfaceName_Windows_UI_IColorsStatics = "Windows.UI.IColorsStatics";

        [NativeTypeName("const WCHAR [26]")]
        public const string InterfaceName_Windows_UI_IUIContentRoot = "Windows.UI.IUIContentRoot";

        [NativeTypeName("const WCHAR [22]")]
        public const string InterfaceName_Windows_UI_IUIContext = "Windows.UI.IUIContext";

        [NativeTypeName("const WCHAR [23]")]
        public const string RuntimeClass_Windows_UI_ColorHelper = "Windows.UI.ColorHelper";

        [NativeTypeName("const WCHAR [18]")]
        public const string RuntimeClass_Windows_UI_Colors = "Windows.UI.Colors";

        [NativeTypeName("const WCHAR [25]")]
        public const string RuntimeClass_Windows_UI_UIContentRoot = "Windows.UI.UIContentRoot";

        [NativeTypeName("const WCHAR [21]")]
        public const string RuntimeClass_Windows_UI_UIContext = "Windows.UI.UIContext";

        public static readonly Guid IID_IColorHelper = new Guid(0x193CFBE7, 0x65C7, 0x4540, 0xAD, 0x08, 0x62, 0x83, 0xBA, 0x76, 0x87, 0x9A);

        public static readonly Guid IID_IColorHelperStatics = new Guid(0x8504DBEA, 0xFB6A, 0x4144, 0xA6, 0xC2, 0x33, 0x49, 0x9C, 0x92, 0x84, 0xF5);

        public static readonly Guid IID_IColorHelperStatics2 = new Guid(0x24D9AF02, 0x6EB0, 0x4B94, 0x85, 0x5C, 0xFC, 0xF0, 0x81, 0x8D, 0x9A, 0x16);

        public static readonly Guid IID_IColors = new Guid(0x9B8C9326, 0x4CA6, 0x4CE5, 0x89, 0x94, 0x9E, 0xFF, 0x65, 0xCA, 0xBD, 0xCC);

        public static readonly Guid IID_IColorsStatics = new Guid(0xCFF52E04, 0xCCA6, 0x4614, 0xA1, 0x7E, 0x75, 0x49, 0x10, 0xC8, 0x4A, 0x99);

        public static readonly Guid IID_IUIContentRoot = new Guid(0x1DFCBAC6, 0xB36B, 0x5CB9, 0x9B, 0xC5, 0x2B, 0x7A, 0x0E, 0xDD, 0xC3, 0x78);

        public static readonly Guid IID_IUIContext = new Guid(0xBB5CFACD, 0x5BD8, 0x59D0, 0xA5, 0x9E, 0x1C, 0x17, 0xA4, 0xD6, 0xD2, 0x43);
    }
}
