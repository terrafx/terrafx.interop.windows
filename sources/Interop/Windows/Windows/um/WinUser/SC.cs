// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SC
{
    /// <include file='SC.xml' path='doc/member[@name="SC.SC_SIZE"]/*' />
    [NativeTypeName("#define SC_SIZE 0xF000")]
    public const int SC_SIZE = 0xF000;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_MOVE"]/*' />
    [NativeTypeName("#define SC_MOVE 0xF010")]
    public const int SC_MOVE = 0xF010;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_MINIMIZE"]/*' />
    [NativeTypeName("#define SC_MINIMIZE 0xF020")]
    public const int SC_MINIMIZE = 0xF020;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_MAXIMIZE"]/*' />
    [NativeTypeName("#define SC_MAXIMIZE 0xF030")]
    public const int SC_MAXIMIZE = 0xF030;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_NEXTWINDOW"]/*' />
    [NativeTypeName("#define SC_NEXTWINDOW 0xF040")]
    public const int SC_NEXTWINDOW = 0xF040;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_PREVWINDOW"]/*' />
    [NativeTypeName("#define SC_PREVWINDOW 0xF050")]
    public const int SC_PREVWINDOW = 0xF050;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_CLOSE"]/*' />
    [NativeTypeName("#define SC_CLOSE 0xF060")]
    public const int SC_CLOSE = 0xF060;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_VSCROLL"]/*' />
    [NativeTypeName("#define SC_VSCROLL 0xF070")]
    public const int SC_VSCROLL = 0xF070;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_HSCROLL"]/*' />
    [NativeTypeName("#define SC_HSCROLL 0xF080")]
    public const int SC_HSCROLL = 0xF080;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_MOUSEMENU"]/*' />
    [NativeTypeName("#define SC_MOUSEMENU 0xF090")]
    public const int SC_MOUSEMENU = 0xF090;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_KEYMENU"]/*' />
    [NativeTypeName("#define SC_KEYMENU 0xF100")]
    public const int SC_KEYMENU = 0xF100;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_ARRANGE"]/*' />
    [NativeTypeName("#define SC_ARRANGE 0xF110")]
    public const int SC_ARRANGE = 0xF110;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_RESTORE"]/*' />
    [NativeTypeName("#define SC_RESTORE 0xF120")]
    public const int SC_RESTORE = 0xF120;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_TASKLIST"]/*' />
    [NativeTypeName("#define SC_TASKLIST 0xF130")]
    public const int SC_TASKLIST = 0xF130;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_SCREENSAVE"]/*' />
    [NativeTypeName("#define SC_SCREENSAVE 0xF140")]
    public const int SC_SCREENSAVE = 0xF140;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_HOTKEY"]/*' />
    [NativeTypeName("#define SC_HOTKEY 0xF150")]
    public const int SC_HOTKEY = 0xF150;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_DEFAULT"]/*' />
    [NativeTypeName("#define SC_DEFAULT 0xF160")]
    public const int SC_DEFAULT = 0xF160;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_MONITORPOWER"]/*' />
    [NativeTypeName("#define SC_MONITORPOWER 0xF170")]
    public const int SC_MONITORPOWER = 0xF170;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_CONTEXTHELP"]/*' />
    [NativeTypeName("#define SC_CONTEXTHELP 0xF180")]
    public const int SC_CONTEXTHELP = 0xF180;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_SEPARATOR"]/*' />
    [NativeTypeName("#define SC_SEPARATOR 0xF00F")]
    public const int SC_SEPARATOR = 0xF00F;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_ICON"]/*' />
    [NativeTypeName("#define SC_ICON SC_MINIMIZE")]
    public const int SC_ICON = 0xF020;

    /// <include file='SC.xml' path='doc/member[@name="SC.SC_ZOOM"]/*' />
    [NativeTypeName("#define SC_ZOOM SC_MAXIMIZE")]
    public const int SC_ZOOM = 0xF030;
}
