// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static partial class TF
{
    /// <include file='TF.xml' path='doc/member[@name="TF.TF_FLOATINGLANGBAR_WNDTITLEW"]/*' />
    [NativeTypeName("#define TF_FLOATINGLANGBAR_WNDTITLEW L\"TF_FloatingLangBar_WndTitle\"")]
    public const string TF_FLOATINGLANGBAR_WNDTITLEW = "TF_FloatingLangBar_WndTitle";

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_FLOATINGLANGBAR_WNDTITLEA"]/*' />
    [NativeTypeName("#define TF_FLOATINGLANGBAR_WNDTITLEA \"TF_FloatingLangBar_WndTitle\"")]
    public static ReadOnlySpan<byte> TF_FLOATINGLANGBAR_WNDTITLEA => "TF_FloatingLangBar_WndTitle"u8;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_FLOATINGLANGBAR_WNDTITLE"]/*' />
    [NativeTypeName("#define TF_FLOATINGLANGBAR_WNDTITLE TF_FLOATINGLANGBAR_WNDTITLEW")]
    public const string TF_FLOATINGLANGBAR_WNDTITLE = "TF_FloatingLangBar_WndTitle";

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_ICON"]/*' />
    [NativeTypeName("#define TF_LBI_ICON 0x00000001")]
    public const int TF_LBI_ICON = 0x00000001;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_TEXT"]/*' />
    [NativeTypeName("#define TF_LBI_TEXT 0x00000002")]
    public const int TF_LBI_TEXT = 0x00000002;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_TOOLTIP"]/*' />
    [NativeTypeName("#define TF_LBI_TOOLTIP 0x00000004")]
    public const int TF_LBI_TOOLTIP = 0x00000004;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_BITMAP"]/*' />
    [NativeTypeName("#define TF_LBI_BITMAP 0x00000008")]
    public const int TF_LBI_BITMAP = 0x00000008;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_BALLOON"]/*' />
    [NativeTypeName("#define TF_LBI_BALLOON 0x00000010")]
    public const int TF_LBI_BALLOON = 0x00000010;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_CUSTOMUI"]/*' />
    [NativeTypeName("#define TF_LBI_CUSTOMUI 0x00000020")]
    public const int TF_LBI_CUSTOMUI = 0x00000020;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_BTNALL"]/*' />
    [NativeTypeName("#define TF_LBI_BTNALL (TF_LBI_ICON | TF_LBI_TEXT | TF_LBI_TOOLTIP)")]
    public const int TF_LBI_BTNALL = (0x00000001 | 0x00000002 | 0x00000004);

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_BMPBTNALL"]/*' />
    [NativeTypeName("#define TF_LBI_BMPBTNALL (TF_LBI_BITMAP | TF_LBI_TEXT | TF_LBI_TOOLTIP)")]
    public const int TF_LBI_BMPBTNALL = (0x00000008 | 0x00000002 | 0x00000004);

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_BMPALL"]/*' />
    [NativeTypeName("#define TF_LBI_BMPALL (TF_LBI_BITMAP | TF_LBI_TOOLTIP)")]
    public const int TF_LBI_BMPALL = (0x00000008 | 0x00000004);

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_STATUS"]/*' />
    [NativeTypeName("#define TF_LBI_STATUS 0x00010000")]
    public const int TF_LBI_STATUS = 0x00010000;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_STYLE_HIDDENSTATUSCONTROL"]/*' />
    [NativeTypeName("#define TF_LBI_STYLE_HIDDENSTATUSCONTROL 0x00000001")]
    public const int TF_LBI_STYLE_HIDDENSTATUSCONTROL = 0x00000001;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_STYLE_SHOWNINTRAY"]/*' />
    [NativeTypeName("#define TF_LBI_STYLE_SHOWNINTRAY 0x00000002")]
    public const int TF_LBI_STYLE_SHOWNINTRAY = 0x00000002;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_STYLE_HIDEONNOOTHERITEMS"]/*' />
    [NativeTypeName("#define TF_LBI_STYLE_HIDEONNOOTHERITEMS 0x00000004")]
    public const int TF_LBI_STYLE_HIDEONNOOTHERITEMS = 0x00000004;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_STYLE_SHOWNINTRAYONLY"]/*' />
    [NativeTypeName("#define TF_LBI_STYLE_SHOWNINTRAYONLY 0x00000008")]
    public const int TF_LBI_STYLE_SHOWNINTRAYONLY = 0x00000008;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_STYLE_HIDDENBYDEFAULT"]/*' />
    [NativeTypeName("#define TF_LBI_STYLE_HIDDENBYDEFAULT 0x00000010")]
    public const int TF_LBI_STYLE_HIDDENBYDEFAULT = 0x00000010;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_STYLE_TEXTCOLORICON"]/*' />
    [NativeTypeName("#define TF_LBI_STYLE_TEXTCOLORICON 0x00000020")]
    public const int TF_LBI_STYLE_TEXTCOLORICON = 0x00000020;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_STYLE_BTN_BUTTON"]/*' />
    [NativeTypeName("#define TF_LBI_STYLE_BTN_BUTTON 0x00010000")]
    public const int TF_LBI_STYLE_BTN_BUTTON = 0x00010000;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_STYLE_BTN_MENU"]/*' />
    [NativeTypeName("#define TF_LBI_STYLE_BTN_MENU 0x00020000")]
    public const int TF_LBI_STYLE_BTN_MENU = 0x00020000;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_STYLE_BTN_TOGGLE"]/*' />
    [NativeTypeName("#define TF_LBI_STYLE_BTN_TOGGLE 0x00040000")]
    public const int TF_LBI_STYLE_BTN_TOGGLE = 0x00040000;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_STATUS_HIDDEN"]/*' />
    [NativeTypeName("#define TF_LBI_STATUS_HIDDEN 0x00000001")]
    public const int TF_LBI_STATUS_HIDDEN = 0x00000001;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_STATUS_DISABLED"]/*' />
    [NativeTypeName("#define TF_LBI_STATUS_DISABLED 0x00000002")]
    public const int TF_LBI_STATUS_DISABLED = 0x00000002;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_STATUS_BTN_TOGGLED"]/*' />
    [NativeTypeName("#define TF_LBI_STATUS_BTN_TOGGLED 0x00010000")]
    public const int TF_LBI_STATUS_BTN_TOGGLED = 0x00010000;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_BMPF_VERTICAL"]/*' />
    [NativeTypeName("#define TF_LBI_BMPF_VERTICAL 0x00000001")]
    public const int TF_LBI_BMPF_VERTICAL = 0x00000001;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_SFT_SHOWNORMAL"]/*' />
    [NativeTypeName("#define TF_SFT_SHOWNORMAL 0x00000001")]
    public const int TF_SFT_SHOWNORMAL = 0x00000001;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_SFT_DOCK"]/*' />
    [NativeTypeName("#define TF_SFT_DOCK 0x00000002")]
    public const int TF_SFT_DOCK = 0x00000002;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_SFT_MINIMIZED"]/*' />
    [NativeTypeName("#define TF_SFT_MINIMIZED 0x00000004")]
    public const int TF_SFT_MINIMIZED = 0x00000004;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_SFT_HIDDEN"]/*' />
    [NativeTypeName("#define TF_SFT_HIDDEN 0x00000008")]
    public const int TF_SFT_HIDDEN = 0x00000008;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_SFT_NOTRANSPARENCY"]/*' />
    [NativeTypeName("#define TF_SFT_NOTRANSPARENCY 0x00000010")]
    public const int TF_SFT_NOTRANSPARENCY = 0x00000010;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_SFT_LOWTRANSPARENCY"]/*' />
    [NativeTypeName("#define TF_SFT_LOWTRANSPARENCY 0x00000020")]
    public const int TF_SFT_LOWTRANSPARENCY = 0x00000020;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_SFT_HIGHTRANSPARENCY"]/*' />
    [NativeTypeName("#define TF_SFT_HIGHTRANSPARENCY 0x00000040")]
    public const int TF_SFT_HIGHTRANSPARENCY = 0x00000040;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_SFT_LABELS"]/*' />
    [NativeTypeName("#define TF_SFT_LABELS 0x00000080")]
    public const int TF_SFT_LABELS = 0x00000080;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_SFT_NOLABELS"]/*' />
    [NativeTypeName("#define TF_SFT_NOLABELS 0x00000100")]
    public const int TF_SFT_NOLABELS = 0x00000100;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_SFT_EXTRAICONSONMINIMIZED"]/*' />
    [NativeTypeName("#define TF_SFT_EXTRAICONSONMINIMIZED 0x00000200")]
    public const int TF_SFT_EXTRAICONSONMINIMIZED = 0x00000200;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_SFT_NOEXTRAICONSONMINIMIZED"]/*' />
    [NativeTypeName("#define TF_SFT_NOEXTRAICONSONMINIMIZED 0x00000400")]
    public const int TF_SFT_NOEXTRAICONSONMINIMIZED = 0x00000400;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_SFT_DESKBAND"]/*' />
    [NativeTypeName("#define TF_SFT_DESKBAND 0x00000800")]
    public const int TF_SFT_DESKBAND = 0x00000800;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_INVALIDMENUITEM"]/*' />
    [NativeTypeName("#define TF_INVALIDMENUITEM (UINT)(-1)")]
    public const uint TF_INVALIDMENUITEM = unchecked((uint)(-1));

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_DTLBI_USEPROFILEICON"]/*' />
    [NativeTypeName("#define TF_DTLBI_USEPROFILEICON 0x00000001")]
    public const int TF_DTLBI_USEPROFILEICON = 0x00000001;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBI_DESC_MAXLEN"]/*' />
    [NativeTypeName("#define TF_LBI_DESC_MAXLEN ( 32 )")]
    public const int TF_LBI_DESC_MAXLEN = (32);

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBMENUF_CHECKED"]/*' />
    [NativeTypeName("#define TF_LBMENUF_CHECKED ( 0x1 )")]
    public const int TF_LBMENUF_CHECKED = (0x1);

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBMENUF_SUBMENU"]/*' />
    [NativeTypeName("#define TF_LBMENUF_SUBMENU ( 0x2 )")]
    public const int TF_LBMENUF_SUBMENU = (0x2);

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBMENUF_SEPARATOR"]/*' />
    [NativeTypeName("#define TF_LBMENUF_SEPARATOR ( 0x4 )")]
    public const int TF_LBMENUF_SEPARATOR = (0x4);

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBMENUF_RADIOCHECKED"]/*' />
    [NativeTypeName("#define TF_LBMENUF_RADIOCHECKED ( 0x8 )")]
    public const int TF_LBMENUF_RADIOCHECKED = (0x8);

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_LBMENUF_GRAYED"]/*' />
    [NativeTypeName("#define TF_LBMENUF_GRAYED ( 0x10 )")]
    public const int TF_LBMENUF_GRAYED = (0x10);
}
