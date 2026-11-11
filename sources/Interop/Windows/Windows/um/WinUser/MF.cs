// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MF
{
    /// <include file='MF.xml' path='doc/member[@name="MF.MF_INSERT"]/*' />
    [NativeTypeName("#define MF_INSERT 0x00000000L")]
    public const int MF_INSERT = 0x00000000;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_CHANGE"]/*' />
    [NativeTypeName("#define MF_CHANGE 0x00000080L")]
    public const int MF_CHANGE = 0x00000080;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_APPEND"]/*' />
    [NativeTypeName("#define MF_APPEND 0x00000100L")]
    public const int MF_APPEND = 0x00000100;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_DELETE"]/*' />
    [NativeTypeName("#define MF_DELETE 0x00000200L")]
    public const int MF_DELETE = 0x00000200;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_REMOVE"]/*' />
    [NativeTypeName("#define MF_REMOVE 0x00001000L")]
    public const int MF_REMOVE = 0x00001000;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_BYCOMMAND"]/*' />
    [NativeTypeName("#define MF_BYCOMMAND 0x00000000L")]
    public const int MF_BYCOMMAND = 0x00000000;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_BYPOSITION"]/*' />
    [NativeTypeName("#define MF_BYPOSITION 0x00000400L")]
    public const int MF_BYPOSITION = 0x00000400;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_SEPARATOR"]/*' />
    [NativeTypeName("#define MF_SEPARATOR 0x00000800L")]
    public const int MF_SEPARATOR = 0x00000800;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_ENABLED"]/*' />
    [NativeTypeName("#define MF_ENABLED 0x00000000L")]
    public const int MF_ENABLED = 0x00000000;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_GRAYED"]/*' />
    [NativeTypeName("#define MF_GRAYED 0x00000001L")]
    public const int MF_GRAYED = 0x00000001;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_DISABLED"]/*' />
    [NativeTypeName("#define MF_DISABLED 0x00000002L")]
    public const int MF_DISABLED = 0x00000002;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_UNCHECKED"]/*' />
    [NativeTypeName("#define MF_UNCHECKED 0x00000000L")]
    public const int MF_UNCHECKED = 0x00000000;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_CHECKED"]/*' />
    [NativeTypeName("#define MF_CHECKED 0x00000008L")]
    public const int MF_CHECKED = 0x00000008;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_USECHECKBITMAPS"]/*' />
    [NativeTypeName("#define MF_USECHECKBITMAPS 0x00000200L")]
    public const int MF_USECHECKBITMAPS = 0x00000200;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_STRING"]/*' />
    [NativeTypeName("#define MF_STRING 0x00000000L")]
    public const int MF_STRING = 0x00000000;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_BITMAP"]/*' />
    [NativeTypeName("#define MF_BITMAP 0x00000004L")]
    public const int MF_BITMAP = 0x00000004;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_OWNERDRAW"]/*' />
    [NativeTypeName("#define MF_OWNERDRAW 0x00000100L")]
    public const int MF_OWNERDRAW = 0x00000100;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_POPUP"]/*' />
    [NativeTypeName("#define MF_POPUP 0x00000010L")]
    public const int MF_POPUP = 0x00000010;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_MENUBARBREAK"]/*' />
    [NativeTypeName("#define MF_MENUBARBREAK 0x00000020L")]
    public const int MF_MENUBARBREAK = 0x00000020;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_MENUBREAK"]/*' />
    [NativeTypeName("#define MF_MENUBREAK 0x00000040L")]
    public const int MF_MENUBREAK = 0x00000040;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_UNHILITE"]/*' />
    [NativeTypeName("#define MF_UNHILITE 0x00000000L")]
    public const int MF_UNHILITE = 0x00000000;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_HILITE"]/*' />
    [NativeTypeName("#define MF_HILITE 0x00000080L")]
    public const int MF_HILITE = 0x00000080;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_DEFAULT"]/*' />
    [NativeTypeName("#define MF_DEFAULT 0x00001000L")]
    public const int MF_DEFAULT = 0x00001000;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_SYSMENU"]/*' />
    [NativeTypeName("#define MF_SYSMENU 0x00002000L")]
    public const int MF_SYSMENU = 0x00002000;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_HELP"]/*' />
    [NativeTypeName("#define MF_HELP 0x00004000L")]
    public const int MF_HELP = 0x00004000;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_RIGHTJUSTIFY"]/*' />
    [NativeTypeName("#define MF_RIGHTJUSTIFY 0x00004000L")]
    public const int MF_RIGHTJUSTIFY = 0x00004000;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_MOUSESELECT"]/*' />
    [NativeTypeName("#define MF_MOUSESELECT 0x00008000L")]
    public const int MF_MOUSESELECT = 0x00008000;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_END"]/*' />
    [NativeTypeName("#define MF_END 0x00000080L")]
    public const int MF_END = 0x00000080;
}
