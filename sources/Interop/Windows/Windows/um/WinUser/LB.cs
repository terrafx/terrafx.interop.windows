// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class LB
{
    /// <include file='LB.xml' path='doc/member[@name="LB.LB_CTLCODE"]/*' />
    [NativeTypeName("#define LB_CTLCODE 0L")]
    public const int LB_CTLCODE = 0;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_OKAY"]/*' />
    [NativeTypeName("#define LB_OKAY 0")]
    public const int LB_OKAY = 0;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_ERR"]/*' />
    [NativeTypeName("#define LB_ERR (-1)")]
    public const int LB_ERR = (-1);

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_ERRSPACE"]/*' />
    [NativeTypeName("#define LB_ERRSPACE (-2)")]
    public const int LB_ERRSPACE = (-2);

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_ADDSTRING"]/*' />
    [NativeTypeName("#define LB_ADDSTRING 0x0180")]
    public const int LB_ADDSTRING = 0x0180;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_INSERTSTRING"]/*' />
    [NativeTypeName("#define LB_INSERTSTRING 0x0181")]
    public const int LB_INSERTSTRING = 0x0181;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_DELETESTRING"]/*' />
    [NativeTypeName("#define LB_DELETESTRING 0x0182")]
    public const int LB_DELETESTRING = 0x0182;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_SELITEMRANGEEX"]/*' />
    [NativeTypeName("#define LB_SELITEMRANGEEX 0x0183")]
    public const int LB_SELITEMRANGEEX = 0x0183;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_RESETCONTENT"]/*' />
    [NativeTypeName("#define LB_RESETCONTENT 0x0184")]
    public const int LB_RESETCONTENT = 0x0184;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_SETSEL"]/*' />
    [NativeTypeName("#define LB_SETSEL 0x0185")]
    public const int LB_SETSEL = 0x0185;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_SETCURSEL"]/*' />
    [NativeTypeName("#define LB_SETCURSEL 0x0186")]
    public const int LB_SETCURSEL = 0x0186;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETSEL"]/*' />
    [NativeTypeName("#define LB_GETSEL 0x0187")]
    public const int LB_GETSEL = 0x0187;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETCURSEL"]/*' />
    [NativeTypeName("#define LB_GETCURSEL 0x0188")]
    public const int LB_GETCURSEL = 0x0188;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETTEXT"]/*' />
    [NativeTypeName("#define LB_GETTEXT 0x0189")]
    public const int LB_GETTEXT = 0x0189;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETTEXTLEN"]/*' />
    [NativeTypeName("#define LB_GETTEXTLEN 0x018A")]
    public const int LB_GETTEXTLEN = 0x018A;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETCOUNT"]/*' />
    [NativeTypeName("#define LB_GETCOUNT 0x018B")]
    public const int LB_GETCOUNT = 0x018B;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_SELECTSTRING"]/*' />
    [NativeTypeName("#define LB_SELECTSTRING 0x018C")]
    public const int LB_SELECTSTRING = 0x018C;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_DIR"]/*' />
    [NativeTypeName("#define LB_DIR 0x018D")]
    public const int LB_DIR = 0x018D;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETTOPINDEX"]/*' />
    [NativeTypeName("#define LB_GETTOPINDEX 0x018E")]
    public const int LB_GETTOPINDEX = 0x018E;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_FINDSTRING"]/*' />
    [NativeTypeName("#define LB_FINDSTRING 0x018F")]
    public const int LB_FINDSTRING = 0x018F;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETSELCOUNT"]/*' />
    [NativeTypeName("#define LB_GETSELCOUNT 0x0190")]
    public const int LB_GETSELCOUNT = 0x0190;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETSELITEMS"]/*' />
    [NativeTypeName("#define LB_GETSELITEMS 0x0191")]
    public const int LB_GETSELITEMS = 0x0191;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_SETTABSTOPS"]/*' />
    [NativeTypeName("#define LB_SETTABSTOPS 0x0192")]
    public const int LB_SETTABSTOPS = 0x0192;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETHORIZONTALEXTENT"]/*' />
    [NativeTypeName("#define LB_GETHORIZONTALEXTENT 0x0193")]
    public const int LB_GETHORIZONTALEXTENT = 0x0193;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_SETHORIZONTALEXTENT"]/*' />
    [NativeTypeName("#define LB_SETHORIZONTALEXTENT 0x0194")]
    public const int LB_SETHORIZONTALEXTENT = 0x0194;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_SETCOLUMNWIDTH"]/*' />
    [NativeTypeName("#define LB_SETCOLUMNWIDTH 0x0195")]
    public const int LB_SETCOLUMNWIDTH = 0x0195;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_ADDFILE"]/*' />
    [NativeTypeName("#define LB_ADDFILE 0x0196")]
    public const int LB_ADDFILE = 0x0196;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_SETTOPINDEX"]/*' />
    [NativeTypeName("#define LB_SETTOPINDEX 0x0197")]
    public const int LB_SETTOPINDEX = 0x0197;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETITEMRECT"]/*' />
    [NativeTypeName("#define LB_GETITEMRECT 0x0198")]
    public const int LB_GETITEMRECT = 0x0198;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETITEMDATA"]/*' />
    [NativeTypeName("#define LB_GETITEMDATA 0x0199")]
    public const int LB_GETITEMDATA = 0x0199;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_SETITEMDATA"]/*' />
    [NativeTypeName("#define LB_SETITEMDATA 0x019A")]
    public const int LB_SETITEMDATA = 0x019A;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_SELITEMRANGE"]/*' />
    [NativeTypeName("#define LB_SELITEMRANGE 0x019B")]
    public const int LB_SELITEMRANGE = 0x019B;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_SETANCHORINDEX"]/*' />
    [NativeTypeName("#define LB_SETANCHORINDEX 0x019C")]
    public const int LB_SETANCHORINDEX = 0x019C;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETANCHORINDEX"]/*' />
    [NativeTypeName("#define LB_GETANCHORINDEX 0x019D")]
    public const int LB_GETANCHORINDEX = 0x019D;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_SETCARETINDEX"]/*' />
    [NativeTypeName("#define LB_SETCARETINDEX 0x019E")]
    public const int LB_SETCARETINDEX = 0x019E;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETCARETINDEX"]/*' />
    [NativeTypeName("#define LB_GETCARETINDEX 0x019F")]
    public const int LB_GETCARETINDEX = 0x019F;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_SETITEMHEIGHT"]/*' />
    [NativeTypeName("#define LB_SETITEMHEIGHT 0x01A0")]
    public const int LB_SETITEMHEIGHT = 0x01A0;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETITEMHEIGHT"]/*' />
    [NativeTypeName("#define LB_GETITEMHEIGHT 0x01A1")]
    public const int LB_GETITEMHEIGHT = 0x01A1;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_FINDSTRINGEXACT"]/*' />
    [NativeTypeName("#define LB_FINDSTRINGEXACT 0x01A2")]
    public const int LB_FINDSTRINGEXACT = 0x01A2;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_SETLOCALE"]/*' />
    [NativeTypeName("#define LB_SETLOCALE 0x01A5")]
    public const int LB_SETLOCALE = 0x01A5;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETLOCALE"]/*' />
    [NativeTypeName("#define LB_GETLOCALE 0x01A6")]
    public const int LB_GETLOCALE = 0x01A6;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_SETCOUNT"]/*' />
    [NativeTypeName("#define LB_SETCOUNT 0x01A7")]
    public const int LB_SETCOUNT = 0x01A7;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_INITSTORAGE"]/*' />
    [NativeTypeName("#define LB_INITSTORAGE 0x01A8")]
    public const int LB_INITSTORAGE = 0x01A8;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_ITEMFROMPOINT"]/*' />
    [NativeTypeName("#define LB_ITEMFROMPOINT 0x01A9")]
    public const int LB_ITEMFROMPOINT = 0x01A9;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_GETLISTBOXINFO"]/*' />
    [NativeTypeName("#define LB_GETLISTBOXINFO 0x01B2")]
    public const int LB_GETLISTBOXINFO = 0x01B2;

    /// <include file='LB.xml' path='doc/member[@name="LB.LB_MSGMAX"]/*' />
    [NativeTypeName("#define LB_MSGMAX 0x01B3")]
    public const int LB_MSGMAX = 0x01B3;
}
