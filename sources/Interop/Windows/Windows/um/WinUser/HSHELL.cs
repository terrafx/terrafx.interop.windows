// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class HSHELL
{
    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_WINDOWCREATED"]/*' />
    [NativeTypeName("#define HSHELL_WINDOWCREATED 1")]
    public const int HSHELL_WINDOWCREATED = 1;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_WINDOWDESTROYED"]/*' />
    [NativeTypeName("#define HSHELL_WINDOWDESTROYED 2")]
    public const int HSHELL_WINDOWDESTROYED = 2;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_ACTIVATESHELLWINDOW"]/*' />
    [NativeTypeName("#define HSHELL_ACTIVATESHELLWINDOW 3")]
    public const int HSHELL_ACTIVATESHELLWINDOW = 3;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_WINDOWACTIVATED"]/*' />
    [NativeTypeName("#define HSHELL_WINDOWACTIVATED 4")]
    public const int HSHELL_WINDOWACTIVATED = 4;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_GETMINRECT"]/*' />
    [NativeTypeName("#define HSHELL_GETMINRECT 5")]
    public const int HSHELL_GETMINRECT = 5;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_REDRAW"]/*' />
    [NativeTypeName("#define HSHELL_REDRAW 6")]
    public const int HSHELL_REDRAW = 6;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_TASKMAN"]/*' />
    [NativeTypeName("#define HSHELL_TASKMAN 7")]
    public const int HSHELL_TASKMAN = 7;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_LANGUAGE"]/*' />
    [NativeTypeName("#define HSHELL_LANGUAGE 8")]
    public const int HSHELL_LANGUAGE = 8;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_SYSMENU"]/*' />
    [NativeTypeName("#define HSHELL_SYSMENU 9")]
    public const int HSHELL_SYSMENU = 9;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_ENDTASK"]/*' />
    [NativeTypeName("#define HSHELL_ENDTASK 10")]
    public const int HSHELL_ENDTASK = 10;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_ACCESSIBILITYSTATE"]/*' />
    [NativeTypeName("#define HSHELL_ACCESSIBILITYSTATE 11")]
    public const int HSHELL_ACCESSIBILITYSTATE = 11;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_APPCOMMAND"]/*' />
    [NativeTypeName("#define HSHELL_APPCOMMAND 12")]
    public const int HSHELL_APPCOMMAND = 12;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_WINDOWREPLACED"]/*' />
    [NativeTypeName("#define HSHELL_WINDOWREPLACED 13")]
    public const int HSHELL_WINDOWREPLACED = 13;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_WINDOWREPLACING"]/*' />
    [NativeTypeName("#define HSHELL_WINDOWREPLACING 14")]
    public const int HSHELL_WINDOWREPLACING = 14;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_MONITORCHANGED"]/*' />
    [NativeTypeName("#define HSHELL_MONITORCHANGED 16")]
    public const int HSHELL_MONITORCHANGED = 16;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_HIGHBIT"]/*' />
    [NativeTypeName("#define HSHELL_HIGHBIT 0x8000")]
    public const int HSHELL_HIGHBIT = 0x8000;

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_FLASH"]/*' />
    [NativeTypeName("#define HSHELL_FLASH (HSHELL_REDRAW|HSHELL_HIGHBIT)")]
    public const int HSHELL_FLASH = (6 | 0x8000);

    /// <include file='HSHELL.xml' path='doc/member[@name="HSHELL.HSHELL_RUDEAPPACTIVATED"]/*' />
    [NativeTypeName("#define HSHELL_RUDEAPPACTIVATED (HSHELL_WINDOWACTIVATED|HSHELL_HIGHBIT)")]
    public const int HSHELL_RUDEAPPACTIVATED = (4 | 0x8000);
}
