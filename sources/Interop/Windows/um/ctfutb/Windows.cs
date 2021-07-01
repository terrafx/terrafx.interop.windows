// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define TF_FLOATINGLANGBAR_WNDTITLEW L\"TF_FloatingLangBar_WndTitle\"")]
        public const string TF_FLOATINGLANGBAR_WNDTITLEW = "TF_FloatingLangBar_WndTitle";

        [NativeTypeName("#define TF_FLOATINGLANGBAR_WNDTITLEA \"TF_FloatingLangBar_WndTitle\"")]
        public static ReadOnlySpan<byte> TF_FLOATINGLANGBAR_WNDTITLEA => new byte[] { 0x54, 0x46, 0x5F, 0x46, 0x6C, 0x6F, 0x61, 0x74, 0x69, 0x6E, 0x67, 0x4C, 0x61, 0x6E, 0x67, 0x42, 0x61, 0x72, 0x5F, 0x57, 0x6E, 0x64, 0x54, 0x69, 0x74, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define TF_FLOATINGLANGBAR_WNDTITLE TF_FLOATINGLANGBAR_WNDTITLEW")]
        public const string TF_FLOATINGLANGBAR_WNDTITLE = "TF_FloatingLangBar_WndTitle";

        [NativeTypeName("#define TF_LBI_ICON 0x00000001")]
        public const int TF_LBI_ICON = 0x00000001;

        [NativeTypeName("#define TF_LBI_TEXT 0x00000002")]
        public const int TF_LBI_TEXT = 0x00000002;

        [NativeTypeName("#define TF_LBI_TOOLTIP 0x00000004")]
        public const int TF_LBI_TOOLTIP = 0x00000004;

        [NativeTypeName("#define TF_LBI_BITMAP 0x00000008")]
        public const int TF_LBI_BITMAP = 0x00000008;

        [NativeTypeName("#define TF_LBI_BALLOON 0x00000010")]
        public const int TF_LBI_BALLOON = 0x00000010;

        [NativeTypeName("#define TF_LBI_CUSTOMUI 0x00000020")]
        public const int TF_LBI_CUSTOMUI = 0x00000020;

        [NativeTypeName("#define TF_LBI_BTNALL (TF_LBI_ICON | TF_LBI_TEXT | TF_LBI_TOOLTIP)")]
        public const int TF_LBI_BTNALL = (0x00000001 | 0x00000002 | 0x00000004);

        [NativeTypeName("#define TF_LBI_BMPBTNALL (TF_LBI_BITMAP | TF_LBI_TEXT | TF_LBI_TOOLTIP)")]
        public const int TF_LBI_BMPBTNALL = (0x00000008 | 0x00000002 | 0x00000004);

        [NativeTypeName("#define TF_LBI_BMPALL (TF_LBI_BITMAP | TF_LBI_TOOLTIP)")]
        public const int TF_LBI_BMPALL = (0x00000008 | 0x00000004);

        [NativeTypeName("#define TF_LBI_STATUS 0x00010000")]
        public const int TF_LBI_STATUS = 0x00010000;

        [NativeTypeName("#define TF_LBI_STYLE_HIDDENSTATUSCONTROL 0x00000001")]
        public const int TF_LBI_STYLE_HIDDENSTATUSCONTROL = 0x00000001;

        [NativeTypeName("#define TF_LBI_STYLE_SHOWNINTRAY 0x00000002")]
        public const int TF_LBI_STYLE_SHOWNINTRAY = 0x00000002;

        [NativeTypeName("#define TF_LBI_STYLE_HIDEONNOOTHERITEMS 0x00000004")]
        public const int TF_LBI_STYLE_HIDEONNOOTHERITEMS = 0x00000004;

        [NativeTypeName("#define TF_LBI_STYLE_SHOWNINTRAYONLY 0x00000008")]
        public const int TF_LBI_STYLE_SHOWNINTRAYONLY = 0x00000008;

        [NativeTypeName("#define TF_LBI_STYLE_HIDDENBYDEFAULT 0x00000010")]
        public const int TF_LBI_STYLE_HIDDENBYDEFAULT = 0x00000010;

        [NativeTypeName("#define TF_LBI_STYLE_TEXTCOLORICON 0x00000020")]
        public const int TF_LBI_STYLE_TEXTCOLORICON = 0x00000020;

        [NativeTypeName("#define TF_LBI_STYLE_BTN_BUTTON 0x00010000")]
        public const int TF_LBI_STYLE_BTN_BUTTON = 0x00010000;

        [NativeTypeName("#define TF_LBI_STYLE_BTN_MENU 0x00020000")]
        public const int TF_LBI_STYLE_BTN_MENU = 0x00020000;

        [NativeTypeName("#define TF_LBI_STYLE_BTN_TOGGLE 0x00040000")]
        public const int TF_LBI_STYLE_BTN_TOGGLE = 0x00040000;

        [NativeTypeName("#define TF_LBI_STATUS_HIDDEN 0x00000001")]
        public const int TF_LBI_STATUS_HIDDEN = 0x00000001;

        [NativeTypeName("#define TF_LBI_STATUS_DISABLED 0x00000002")]
        public const int TF_LBI_STATUS_DISABLED = 0x00000002;

        [NativeTypeName("#define TF_LBI_STATUS_BTN_TOGGLED 0x00010000")]
        public const int TF_LBI_STATUS_BTN_TOGGLED = 0x00010000;

        [NativeTypeName("#define TF_LBI_BMPF_VERTICAL 0x00000001")]
        public const int TF_LBI_BMPF_VERTICAL = 0x00000001;

        [NativeTypeName("#define TF_SFT_SHOWNORMAL 0x00000001")]
        public const int TF_SFT_SHOWNORMAL = 0x00000001;

        [NativeTypeName("#define TF_SFT_DOCK 0x00000002")]
        public const int TF_SFT_DOCK = 0x00000002;

        [NativeTypeName("#define TF_SFT_MINIMIZED 0x00000004")]
        public const int TF_SFT_MINIMIZED = 0x00000004;

        [NativeTypeName("#define TF_SFT_HIDDEN 0x00000008")]
        public const int TF_SFT_HIDDEN = 0x00000008;

        [NativeTypeName("#define TF_SFT_NOTRANSPARENCY 0x00000010")]
        public const int TF_SFT_NOTRANSPARENCY = 0x00000010;

        [NativeTypeName("#define TF_SFT_LOWTRANSPARENCY 0x00000020")]
        public const int TF_SFT_LOWTRANSPARENCY = 0x00000020;

        [NativeTypeName("#define TF_SFT_HIGHTRANSPARENCY 0x00000040")]
        public const int TF_SFT_HIGHTRANSPARENCY = 0x00000040;

        [NativeTypeName("#define TF_SFT_LABELS 0x00000080")]
        public const int TF_SFT_LABELS = 0x00000080;

        [NativeTypeName("#define TF_SFT_NOLABELS 0x00000100")]
        public const int TF_SFT_NOLABELS = 0x00000100;

        [NativeTypeName("#define TF_SFT_EXTRAICONSONMINIMIZED 0x00000200")]
        public const int TF_SFT_EXTRAICONSONMINIMIZED = 0x00000200;

        [NativeTypeName("#define TF_SFT_NOEXTRAICONSONMINIMIZED 0x00000400")]
        public const int TF_SFT_NOEXTRAICONSONMINIMIZED = 0x00000400;

        [NativeTypeName("#define TF_SFT_DESKBAND 0x00000800")]
        public const int TF_SFT_DESKBAND = 0x00000800;

        [NativeTypeName("#define TF_INVALIDMENUITEM (UINT)(-1)")]
        public const uint TF_INVALIDMENUITEM = unchecked((uint)(-1));

        [NativeTypeName("#define TF_DTLBI_USEPROFILEICON 0x00000001")]
        public const int TF_DTLBI_USEPROFILEICON = 0x00000001;

        [NativeTypeName("#define TF_LBI_DESC_MAXLEN ( 32 )")]
        public const int TF_LBI_DESC_MAXLEN = (32);

        [NativeTypeName("#define TF_LBMENUF_CHECKED ( 0x1 )")]
        public const int TF_LBMENUF_CHECKED = (0x1);

        [NativeTypeName("#define TF_LBMENUF_SUBMENU ( 0x2 )")]
        public const int TF_LBMENUF_SUBMENU = (0x2);

        [NativeTypeName("#define TF_LBMENUF_SEPARATOR ( 0x4 )")]
        public const int TF_LBMENUF_SEPARATOR = (0x4);

        [NativeTypeName("#define TF_LBMENUF_RADIOCHECKED ( 0x8 )")]
        public const int TF_LBMENUF_RADIOCHECKED = (0x8);

        [NativeTypeName("#define TF_LBMENUF_GRAYED ( 0x10 )")]
        public const int TF_LBMENUF_GRAYED = (0x10);

        public static readonly Guid IID_ITfLangBarMgr = new Guid(0x87955690, 0xE627, 0x11D2, 0x8D, 0xDB, 0x00, 0x10, 0x5A, 0x27, 0x99, 0xB5);

        public static readonly Guid IID_ITfLangBarEventSink = new Guid(0x18A4E900, 0xE0AE, 0x11D2, 0xAF, 0xDD, 0x00, 0x10, 0x5A, 0x27, 0x99, 0xB5);

        public static readonly Guid IID_ITfLangBarItemSink = new Guid(0x57DBE1A0, 0xDE25, 0x11D2, 0xAF, 0xDD, 0x00, 0x10, 0x5A, 0x27, 0x99, 0xB5);

        public static readonly Guid IID_IEnumTfLangBarItems = new Guid(0x583F34D0, 0xDE25, 0x11D2, 0xAF, 0xDD, 0x00, 0x10, 0x5A, 0x27, 0x99, 0xB5);

        public static readonly Guid IID_ITfLangBarItemMgr = new Guid(0xBA468C55, 0x9956, 0x4FB1, 0xA5, 0x9D, 0x52, 0xA7, 0xDD, 0x7C, 0xC6, 0xAA);

        public static readonly Guid IID_ITfLangBarItem = new Guid(0x73540D69, 0xEDEB, 0x4EE9, 0x96, 0xC9, 0x23, 0xAA, 0x30, 0xB2, 0x59, 0x16);

        public static readonly Guid IID_ITfSystemLangBarItemSink = new Guid(0x1449D9AB, 0x13CF, 0x4687, 0xAA, 0x3E, 0x8D, 0x8B, 0x18, 0x57, 0x43, 0x96);

        public static readonly Guid IID_ITfSystemLangBarItem = new Guid(0x1E13E9EC, 0x6B33, 0x4D4A, 0xB5, 0xEB, 0x8A, 0x92, 0xF0, 0x29, 0xF3, 0x56);

        public static readonly Guid IID_ITfSystemLangBarItemText = new Guid(0x5C4CE0E5, 0xBA49, 0x4B52, 0xAC, 0x6B, 0x3B, 0x39, 0x7B, 0x4F, 0x70, 0x1F);

        public static readonly Guid IID_ITfSystemDeviceTypeLangBarItem = new Guid(0x45672EB9, 0x9059, 0x46A2, 0x83, 0x8D, 0x45, 0x30, 0x35, 0x5F, 0x6A, 0x77);

        public static readonly Guid IID_ITfLangBarItemButton = new Guid(0x28C7F1D0, 0xDE25, 0x11D2, 0xAF, 0xDD, 0x00, 0x10, 0x5A, 0x27, 0x99, 0xB5);

        public static readonly Guid IID_ITfLangBarItemBitmapButton = new Guid(0xA26A0525, 0x3FAE, 0x4FA0, 0x89, 0xEE, 0x88, 0xA9, 0x64, 0xF9, 0xF1, 0xB5);

        public static readonly Guid IID_ITfLangBarItemBitmap = new Guid(0x73830352, 0xD722, 0x4179, 0xAD, 0xA5, 0xF0, 0x45, 0xC9, 0x8D, 0xF3, 0x55);

        public static readonly Guid IID_ITfLangBarItemBalloon = new Guid(0x01C2D285, 0xD3C7, 0x4B7B, 0xB5, 0xB5, 0xD9, 0x74, 0x11, 0xD0, 0xC2, 0x83);

        public static readonly Guid IID_ITfMenu = new Guid(0x6F8A98E4, 0xAAA0, 0x4F15, 0x8C, 0x5B, 0x07, 0xE0, 0xDF, 0x0A, 0x3D, 0xD8);
    }
}
