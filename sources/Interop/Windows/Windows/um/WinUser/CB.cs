// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CB
{
    /// <include file='CB.xml' path='doc/member[@name="CB.CB_OKAY"]/*' />
    [NativeTypeName("#define CB_OKAY 0")]
    public const int CB_OKAY = 0;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_ERR"]/*' />
    [NativeTypeName("#define CB_ERR (-1)")]
    public const int CB_ERR = (-1);

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_ERRSPACE"]/*' />
    [NativeTypeName("#define CB_ERRSPACE (-2)")]
    public const int CB_ERRSPACE = (-2);

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_GETEDITSEL"]/*' />
    [NativeTypeName("#define CB_GETEDITSEL 0x0140")]
    public const int CB_GETEDITSEL = 0x0140;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_LIMITTEXT"]/*' />
    [NativeTypeName("#define CB_LIMITTEXT 0x0141")]
    public const int CB_LIMITTEXT = 0x0141;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_SETEDITSEL"]/*' />
    [NativeTypeName("#define CB_SETEDITSEL 0x0142")]
    public const int CB_SETEDITSEL = 0x0142;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_ADDSTRING"]/*' />
    [NativeTypeName("#define CB_ADDSTRING 0x0143")]
    public const int CB_ADDSTRING = 0x0143;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_DELETESTRING"]/*' />
    [NativeTypeName("#define CB_DELETESTRING 0x0144")]
    public const int CB_DELETESTRING = 0x0144;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_DIR"]/*' />
    [NativeTypeName("#define CB_DIR 0x0145")]
    public const int CB_DIR = 0x0145;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_GETCOUNT"]/*' />
    [NativeTypeName("#define CB_GETCOUNT 0x0146")]
    public const int CB_GETCOUNT = 0x0146;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_GETCURSEL"]/*' />
    [NativeTypeName("#define CB_GETCURSEL 0x0147")]
    public const int CB_GETCURSEL = 0x0147;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_GETLBTEXT"]/*' />
    [NativeTypeName("#define CB_GETLBTEXT 0x0148")]
    public const int CB_GETLBTEXT = 0x0148;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_GETLBTEXTLEN"]/*' />
    [NativeTypeName("#define CB_GETLBTEXTLEN 0x0149")]
    public const int CB_GETLBTEXTLEN = 0x0149;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_INSERTSTRING"]/*' />
    [NativeTypeName("#define CB_INSERTSTRING 0x014A")]
    public const int CB_INSERTSTRING = 0x014A;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_RESETCONTENT"]/*' />
    [NativeTypeName("#define CB_RESETCONTENT 0x014B")]
    public const int CB_RESETCONTENT = 0x014B;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_FINDSTRING"]/*' />
    [NativeTypeName("#define CB_FINDSTRING 0x014C")]
    public const int CB_FINDSTRING = 0x014C;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_SELECTSTRING"]/*' />
    [NativeTypeName("#define CB_SELECTSTRING 0x014D")]
    public const int CB_SELECTSTRING = 0x014D;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_SETCURSEL"]/*' />
    [NativeTypeName("#define CB_SETCURSEL 0x014E")]
    public const int CB_SETCURSEL = 0x014E;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_SHOWDROPDOWN"]/*' />
    [NativeTypeName("#define CB_SHOWDROPDOWN 0x014F")]
    public const int CB_SHOWDROPDOWN = 0x014F;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_GETITEMDATA"]/*' />
    [NativeTypeName("#define CB_GETITEMDATA 0x0150")]
    public const int CB_GETITEMDATA = 0x0150;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_SETITEMDATA"]/*' />
    [NativeTypeName("#define CB_SETITEMDATA 0x0151")]
    public const int CB_SETITEMDATA = 0x0151;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_GETDROPPEDCONTROLRECT"]/*' />
    [NativeTypeName("#define CB_GETDROPPEDCONTROLRECT 0x0152")]
    public const int CB_GETDROPPEDCONTROLRECT = 0x0152;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_SETITEMHEIGHT"]/*' />
    [NativeTypeName("#define CB_SETITEMHEIGHT 0x0153")]
    public const int CB_SETITEMHEIGHT = 0x0153;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_GETITEMHEIGHT"]/*' />
    [NativeTypeName("#define CB_GETITEMHEIGHT 0x0154")]
    public const int CB_GETITEMHEIGHT = 0x0154;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_SETEXTENDEDUI"]/*' />
    [NativeTypeName("#define CB_SETEXTENDEDUI 0x0155")]
    public const int CB_SETEXTENDEDUI = 0x0155;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_GETEXTENDEDUI"]/*' />
    [NativeTypeName("#define CB_GETEXTENDEDUI 0x0156")]
    public const int CB_GETEXTENDEDUI = 0x0156;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_GETDROPPEDSTATE"]/*' />
    [NativeTypeName("#define CB_GETDROPPEDSTATE 0x0157")]
    public const int CB_GETDROPPEDSTATE = 0x0157;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_FINDSTRINGEXACT"]/*' />
    [NativeTypeName("#define CB_FINDSTRINGEXACT 0x0158")]
    public const int CB_FINDSTRINGEXACT = 0x0158;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_SETLOCALE"]/*' />
    [NativeTypeName("#define CB_SETLOCALE 0x0159")]
    public const int CB_SETLOCALE = 0x0159;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_GETLOCALE"]/*' />
    [NativeTypeName("#define CB_GETLOCALE 0x015A")]
    public const int CB_GETLOCALE = 0x015A;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_GETTOPINDEX"]/*' />
    [NativeTypeName("#define CB_GETTOPINDEX 0x015b")]
    public const int CB_GETTOPINDEX = 0x015b;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_SETTOPINDEX"]/*' />
    [NativeTypeName("#define CB_SETTOPINDEX 0x015c")]
    public const int CB_SETTOPINDEX = 0x015c;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_GETHORIZONTALEXTENT"]/*' />
    [NativeTypeName("#define CB_GETHORIZONTALEXTENT 0x015d")]
    public const int CB_GETHORIZONTALEXTENT = 0x015d;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_SETHORIZONTALEXTENT"]/*' />
    [NativeTypeName("#define CB_SETHORIZONTALEXTENT 0x015e")]
    public const int CB_SETHORIZONTALEXTENT = 0x015e;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_GETDROPPEDWIDTH"]/*' />
    [NativeTypeName("#define CB_GETDROPPEDWIDTH 0x015f")]
    public const int CB_GETDROPPEDWIDTH = 0x015f;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_SETDROPPEDWIDTH"]/*' />
    [NativeTypeName("#define CB_SETDROPPEDWIDTH 0x0160")]
    public const int CB_SETDROPPEDWIDTH = 0x0160;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_INITSTORAGE"]/*' />
    [NativeTypeName("#define CB_INITSTORAGE 0x0161")]
    public const int CB_INITSTORAGE = 0x0161;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_GETCOMBOBOXINFO"]/*' />
    [NativeTypeName("#define CB_GETCOMBOBOXINFO 0x0164")]
    public const int CB_GETCOMBOBOXINFO = 0x0164;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_MSGMAX"]/*' />
    [NativeTypeName("#define CB_MSGMAX 0x0165")]
    public const int CB_MSGMAX = 0x0165;
}
