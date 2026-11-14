// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DFM
{
    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_MERGECONTEXTMENU"]/*' />
    [NativeTypeName("#define DFM_MERGECONTEXTMENU 1")]
    public const int DFM_MERGECONTEXTMENU = 1;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_INVOKECOMMAND"]/*' />
    [NativeTypeName("#define DFM_INVOKECOMMAND 2")]
    public const int DFM_INVOKECOMMAND = 2;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_GETHELPTEXT"]/*' />
    [NativeTypeName("#define DFM_GETHELPTEXT 5")]
    public const int DFM_GETHELPTEXT = 5;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_WM_MEASUREITEM"]/*' />
    [NativeTypeName("#define DFM_WM_MEASUREITEM 6")]
    public const int DFM_WM_MEASUREITEM = 6;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_WM_DRAWITEM"]/*' />
    [NativeTypeName("#define DFM_WM_DRAWITEM 7")]
    public const int DFM_WM_DRAWITEM = 7;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_WM_INITMENUPOPUP"]/*' />
    [NativeTypeName("#define DFM_WM_INITMENUPOPUP 8")]
    public const int DFM_WM_INITMENUPOPUP = 8;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_VALIDATECMD"]/*' />
    [NativeTypeName("#define DFM_VALIDATECMD 9")]
    public const int DFM_VALIDATECMD = 9;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_MERGECONTEXTMENU_TOP"]/*' />
    [NativeTypeName("#define DFM_MERGECONTEXTMENU_TOP 10")]
    public const int DFM_MERGECONTEXTMENU_TOP = 10;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_GETHELPTEXTW"]/*' />
    [NativeTypeName("#define DFM_GETHELPTEXTW 11")]
    public const int DFM_GETHELPTEXTW = 11;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_INVOKECOMMANDEX"]/*' />
    [NativeTypeName("#define DFM_INVOKECOMMANDEX 12")]
    public const int DFM_INVOKECOMMANDEX = 12;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_MAPCOMMANDNAME"]/*' />
    [NativeTypeName("#define DFM_MAPCOMMANDNAME 13")]
    public const int DFM_MAPCOMMANDNAME = 13;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_GETDEFSTATICID"]/*' />
    [NativeTypeName("#define DFM_GETDEFSTATICID 14")]
    public const int DFM_GETDEFSTATICID = 14;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_GETVERBW"]/*' />
    [NativeTypeName("#define DFM_GETVERBW 15")]
    public const int DFM_GETVERBW = 15;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_GETVERBA"]/*' />
    [NativeTypeName("#define DFM_GETVERBA 16")]
    public const int DFM_GETVERBA = 16;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_MERGECONTEXTMENU_BOTTOM"]/*' />
    [NativeTypeName("#define DFM_MERGECONTEXTMENU_BOTTOM 17")]
    public const int DFM_MERGECONTEXTMENU_BOTTOM = 17;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_MODIFYQCMFLAGS"]/*' />
    [NativeTypeName("#define DFM_MODIFYQCMFLAGS 18")]
    public const int DFM_MODIFYQCMFLAGS = 18;

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_CMD_DELETE"]/*' />
    [NativeTypeName("#define DFM_CMD_DELETE ((UINT)-1)")]
    public const uint DFM_CMD_DELETE = unchecked((uint)(-1));

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_CMD_MOVE"]/*' />
    [NativeTypeName("#define DFM_CMD_MOVE ((UINT)-2)")]
    public const uint DFM_CMD_MOVE = unchecked((uint)(-2));

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_CMD_COPY"]/*' />
    [NativeTypeName("#define DFM_CMD_COPY ((UINT)-3)")]
    public const uint DFM_CMD_COPY = unchecked((uint)(-3));

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_CMD_LINK"]/*' />
    [NativeTypeName("#define DFM_CMD_LINK ((UINT)-4)")]
    public const uint DFM_CMD_LINK = unchecked((uint)(-4));

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_CMD_PROPERTIES"]/*' />
    [NativeTypeName("#define DFM_CMD_PROPERTIES ((UINT)-5)")]
    public const uint DFM_CMD_PROPERTIES = unchecked((uint)(-5));

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_CMD_NEWFOLDER"]/*' />
    [NativeTypeName("#define DFM_CMD_NEWFOLDER ((UINT)-6)")]
    public const uint DFM_CMD_NEWFOLDER = unchecked((uint)(-6));

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_CMD_PASTE"]/*' />
    [NativeTypeName("#define DFM_CMD_PASTE ((UINT)-7)")]
    public const uint DFM_CMD_PASTE = unchecked((uint)(-7));

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_CMD_VIEWLIST"]/*' />
    [NativeTypeName("#define DFM_CMD_VIEWLIST ((UINT)-8)")]
    public const uint DFM_CMD_VIEWLIST = unchecked((uint)(-8));

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_CMD_VIEWDETAILS"]/*' />
    [NativeTypeName("#define DFM_CMD_VIEWDETAILS ((UINT)-9)")]
    public const uint DFM_CMD_VIEWDETAILS = unchecked((uint)(-9));

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_CMD_PASTELINK"]/*' />
    [NativeTypeName("#define DFM_CMD_PASTELINK ((UINT)-10)")]
    public const uint DFM_CMD_PASTELINK = unchecked((uint)(-10));

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_CMD_PASTESPECIAL"]/*' />
    [NativeTypeName("#define DFM_CMD_PASTESPECIAL ((UINT)-11)")]
    public const uint DFM_CMD_PASTESPECIAL = unchecked((uint)(-11));

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_CMD_MODALPROP"]/*' />
    [NativeTypeName("#define DFM_CMD_MODALPROP ((UINT)-12)")]
    public const uint DFM_CMD_MODALPROP = unchecked((uint)(-12));

    /// <include file='DFM.xml' path='doc/member[@name="DFM.DFM_CMD_RENAME"]/*' />
    [NativeTypeName("#define DFM_CMD_RENAME ((UINT)-13)")]
    public const uint DFM_CMD_RENAME = unchecked((uint)(-13));
}
