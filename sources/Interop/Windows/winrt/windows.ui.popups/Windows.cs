// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const WCHAR [33]")]
        public const string InterfaceName_Windows_UI_Popups_IMessageDialog = "Windows.UI.Popups.IMessageDialog";

        [NativeTypeName("const WCHAR [40]")]
        public const string InterfaceName_Windows_UI_Popups_IMessageDialogFactory = "Windows.UI.Popups.IMessageDialogFactory";

        [NativeTypeName("const WCHAR [29]")]
        public const string InterfaceName_Windows_UI_Popups_IPopupMenu = "Windows.UI.Popups.IPopupMenu";

        [NativeTypeName("const WCHAR [29]")]
        public const string InterfaceName_Windows_UI_Popups_IUICommand = "Windows.UI.Popups.IUICommand";

        [NativeTypeName("const WCHAR [36]")]
        public const string InterfaceName_Windows_UI_Popups_IUICommandFactory = "Windows.UI.Popups.IUICommandFactory";

        [NativeTypeName("const WCHAR [32]")]
        public const string RuntimeClass_Windows_UI_Popups_MessageDialog = "Windows.UI.Popups.MessageDialog";

        [NativeTypeName("const WCHAR [28]")]
        public const string RuntimeClass_Windows_UI_Popups_PopupMenu = "Windows.UI.Popups.PopupMenu";

        [NativeTypeName("const WCHAR [28]")]
        public const string RuntimeClass_Windows_UI_Popups_UICommand = "Windows.UI.Popups.UICommand";

        [NativeTypeName("const WCHAR [37]")]
        public const string RuntimeClass_Windows_UI_Popups_UICommandSeparator = "Windows.UI.Popups.UICommandSeparator";

        public static readonly Guid IID_IUICommandInvokedHandler = new Guid(0xDAF77A4F, 0xC27A, 0x4298, 0x9A, 0xC6, 0x29, 0x22, 0xC4, 0x5E, 0x7D, 0xA6);

        public static readonly Guid IID_IMessageDialog = new Guid(0x33F59B01, 0x5325, 0x43AB, 0x9A, 0xB3, 0xBD, 0xAE, 0x44, 0x0E, 0x41, 0x21);

        public static readonly Guid IID_IMessageDialogFactory = new Guid(0x2D161777, 0xA66F, 0x4EA5, 0xBB, 0x87, 0x79, 0x3F, 0xFA, 0x49, 0x41, 0xF2);

        public static readonly Guid IID_IPopupMenu = new Guid(0x4E9BC6DC, 0x880D, 0x47FC, 0xA0, 0xA1, 0x72, 0xB6, 0x39, 0xE6, 0x25, 0x59);

        public static readonly Guid IID_IUICommand = new Guid(0x4FF93A75, 0x4145, 0x47FF, 0xAC, 0x7F, 0xDF, 0xF1, 0xC1, 0xFA, 0x5B, 0x0F);

        public static readonly Guid IID_IUICommandFactory = new Guid(0xA21A8189, 0x26B0, 0x4676, 0xAE, 0x94, 0x54, 0x04, 0x1B, 0xC1, 0x25, 0xE8);
    }
}
