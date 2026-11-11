// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class LVS
{
    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_ICON"]/*' />
    [NativeTypeName("#define LVS_ICON 0x0000")]
    public const int LVS_ICON = 0x0000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_REPORT"]/*' />
    [NativeTypeName("#define LVS_REPORT 0x0001")]
    public const int LVS_REPORT = 0x0001;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_SMALLICON"]/*' />
    [NativeTypeName("#define LVS_SMALLICON 0x0002")]
    public const int LVS_SMALLICON = 0x0002;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_LIST"]/*' />
    [NativeTypeName("#define LVS_LIST 0x0003")]
    public const int LVS_LIST = 0x0003;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_TYPEMASK"]/*' />
    [NativeTypeName("#define LVS_TYPEMASK 0x0003")]
    public const int LVS_TYPEMASK = 0x0003;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_SINGLESEL"]/*' />
    [NativeTypeName("#define LVS_SINGLESEL 0x0004")]
    public const int LVS_SINGLESEL = 0x0004;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_SHOWSELALWAYS"]/*' />
    [NativeTypeName("#define LVS_SHOWSELALWAYS 0x0008")]
    public const int LVS_SHOWSELALWAYS = 0x0008;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_SORTASCENDING"]/*' />
    [NativeTypeName("#define LVS_SORTASCENDING 0x0010")]
    public const int LVS_SORTASCENDING = 0x0010;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_SORTDESCENDING"]/*' />
    [NativeTypeName("#define LVS_SORTDESCENDING 0x0020")]
    public const int LVS_SORTDESCENDING = 0x0020;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_SHAREIMAGELISTS"]/*' />
    [NativeTypeName("#define LVS_SHAREIMAGELISTS 0x0040")]
    public const int LVS_SHAREIMAGELISTS = 0x0040;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_NOLABELWRAP"]/*' />
    [NativeTypeName("#define LVS_NOLABELWRAP 0x0080")]
    public const int LVS_NOLABELWRAP = 0x0080;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_AUTOARRANGE"]/*' />
    [NativeTypeName("#define LVS_AUTOARRANGE 0x0100")]
    public const int LVS_AUTOARRANGE = 0x0100;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EDITLABELS"]/*' />
    [NativeTypeName("#define LVS_EDITLABELS 0x0200")]
    public const int LVS_EDITLABELS = 0x0200;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_OWNERDATA"]/*' />
    [NativeTypeName("#define LVS_OWNERDATA 0x1000")]
    public const int LVS_OWNERDATA = 0x1000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_NOSCROLL"]/*' />
    [NativeTypeName("#define LVS_NOSCROLL 0x2000")]
    public const int LVS_NOSCROLL = 0x2000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_TYPESTYLEMASK"]/*' />
    [NativeTypeName("#define LVS_TYPESTYLEMASK 0xfc00")]
    public const int LVS_TYPESTYLEMASK = 0xfc00;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_ALIGNTOP"]/*' />
    [NativeTypeName("#define LVS_ALIGNTOP 0x0000")]
    public const int LVS_ALIGNTOP = 0x0000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_ALIGNLEFT"]/*' />
    [NativeTypeName("#define LVS_ALIGNLEFT 0x0800")]
    public const int LVS_ALIGNLEFT = 0x0800;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_ALIGNMASK"]/*' />
    [NativeTypeName("#define LVS_ALIGNMASK 0x0c00")]
    public const int LVS_ALIGNMASK = 0x0c00;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_OWNERDRAWFIXED"]/*' />
    [NativeTypeName("#define LVS_OWNERDRAWFIXED 0x0400")]
    public const int LVS_OWNERDRAWFIXED = 0x0400;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_NOCOLUMNHEADER"]/*' />
    [NativeTypeName("#define LVS_NOCOLUMNHEADER 0x4000")]
    public const int LVS_NOCOLUMNHEADER = 0x4000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_NOSORTHEADER"]/*' />
    [NativeTypeName("#define LVS_NOSORTHEADER 0x8000")]
    public const int LVS_NOSORTHEADER = 0x8000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_GRIDLINES"]/*' />
    [NativeTypeName("#define LVS_EX_GRIDLINES 0x00000001")]
    public const int LVS_EX_GRIDLINES = 0x00000001;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_SUBITEMIMAGES"]/*' />
    [NativeTypeName("#define LVS_EX_SUBITEMIMAGES 0x00000002")]
    public const int LVS_EX_SUBITEMIMAGES = 0x00000002;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_CHECKBOXES"]/*' />
    [NativeTypeName("#define LVS_EX_CHECKBOXES 0x00000004")]
    public const int LVS_EX_CHECKBOXES = 0x00000004;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_TRACKSELECT"]/*' />
    [NativeTypeName("#define LVS_EX_TRACKSELECT 0x00000008")]
    public const int LVS_EX_TRACKSELECT = 0x00000008;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_HEADERDRAGDROP"]/*' />
    [NativeTypeName("#define LVS_EX_HEADERDRAGDROP 0x00000010")]
    public const int LVS_EX_HEADERDRAGDROP = 0x00000010;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_FULLROWSELECT"]/*' />
    [NativeTypeName("#define LVS_EX_FULLROWSELECT 0x00000020")]
    public const int LVS_EX_FULLROWSELECT = 0x00000020;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_ONECLICKACTIVATE"]/*' />
    [NativeTypeName("#define LVS_EX_ONECLICKACTIVATE 0x00000040")]
    public const int LVS_EX_ONECLICKACTIVATE = 0x00000040;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_TWOCLICKACTIVATE"]/*' />
    [NativeTypeName("#define LVS_EX_TWOCLICKACTIVATE 0x00000080")]
    public const int LVS_EX_TWOCLICKACTIVATE = 0x00000080;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_FLATSB"]/*' />
    [NativeTypeName("#define LVS_EX_FLATSB 0x00000100")]
    public const int LVS_EX_FLATSB = 0x00000100;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_REGIONAL"]/*' />
    [NativeTypeName("#define LVS_EX_REGIONAL 0x00000200")]
    public const int LVS_EX_REGIONAL = 0x00000200;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_INFOTIP"]/*' />
    [NativeTypeName("#define LVS_EX_INFOTIP 0x00000400")]
    public const int LVS_EX_INFOTIP = 0x00000400;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_UNDERLINEHOT"]/*' />
    [NativeTypeName("#define LVS_EX_UNDERLINEHOT 0x00000800")]
    public const int LVS_EX_UNDERLINEHOT = 0x00000800;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_UNDERLINECOLD"]/*' />
    [NativeTypeName("#define LVS_EX_UNDERLINECOLD 0x00001000")]
    public const int LVS_EX_UNDERLINECOLD = 0x00001000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_MULTIWORKAREAS"]/*' />
    [NativeTypeName("#define LVS_EX_MULTIWORKAREAS 0x00002000")]
    public const int LVS_EX_MULTIWORKAREAS = 0x00002000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_LABELTIP"]/*' />
    [NativeTypeName("#define LVS_EX_LABELTIP 0x00004000")]
    public const int LVS_EX_LABELTIP = 0x00004000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_BORDERSELECT"]/*' />
    [NativeTypeName("#define LVS_EX_BORDERSELECT 0x00008000")]
    public const int LVS_EX_BORDERSELECT = 0x00008000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_DOUBLEBUFFER"]/*' />
    [NativeTypeName("#define LVS_EX_DOUBLEBUFFER 0x00010000")]
    public const int LVS_EX_DOUBLEBUFFER = 0x00010000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_HIDELABELS"]/*' />
    [NativeTypeName("#define LVS_EX_HIDELABELS 0x00020000")]
    public const int LVS_EX_HIDELABELS = 0x00020000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_SINGLEROW"]/*' />
    [NativeTypeName("#define LVS_EX_SINGLEROW 0x00040000")]
    public const int LVS_EX_SINGLEROW = 0x00040000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_SNAPTOGRID"]/*' />
    [NativeTypeName("#define LVS_EX_SNAPTOGRID 0x00080000")]
    public const int LVS_EX_SNAPTOGRID = 0x00080000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_SIMPLESELECT"]/*' />
    [NativeTypeName("#define LVS_EX_SIMPLESELECT 0x00100000")]
    public const int LVS_EX_SIMPLESELECT = 0x00100000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_JUSTIFYCOLUMNS"]/*' />
    [NativeTypeName("#define LVS_EX_JUSTIFYCOLUMNS 0x00200000")]
    public const int LVS_EX_JUSTIFYCOLUMNS = 0x00200000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_TRANSPARENTBKGND"]/*' />
    [NativeTypeName("#define LVS_EX_TRANSPARENTBKGND 0x00400000")]
    public const int LVS_EX_TRANSPARENTBKGND = 0x00400000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_TRANSPARENTSHADOWTEXT"]/*' />
    [NativeTypeName("#define LVS_EX_TRANSPARENTSHADOWTEXT 0x00800000")]
    public const int LVS_EX_TRANSPARENTSHADOWTEXT = 0x00800000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_AUTOAUTOARRANGE"]/*' />
    [NativeTypeName("#define LVS_EX_AUTOAUTOARRANGE 0x01000000")]
    public const int LVS_EX_AUTOAUTOARRANGE = 0x01000000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_HEADERINALLVIEWS"]/*' />
    [NativeTypeName("#define LVS_EX_HEADERINALLVIEWS 0x02000000")]
    public const int LVS_EX_HEADERINALLVIEWS = 0x02000000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_AUTOCHECKSELECT"]/*' />
    [NativeTypeName("#define LVS_EX_AUTOCHECKSELECT 0x08000000")]
    public const int LVS_EX_AUTOCHECKSELECT = 0x08000000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_AUTOSIZECOLUMNS"]/*' />
    [NativeTypeName("#define LVS_EX_AUTOSIZECOLUMNS 0x10000000")]
    public const int LVS_EX_AUTOSIZECOLUMNS = 0x10000000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_COLUMNSNAPPOINTS"]/*' />
    [NativeTypeName("#define LVS_EX_COLUMNSNAPPOINTS 0x40000000")]
    public const int LVS_EX_COLUMNSNAPPOINTS = 0x40000000;

    /// <include file='LVS.xml' path='doc/member[@name="LVS.LVS_EX_COLUMNOVERFLOW"]/*' />
    [NativeTypeName("#define LVS_EX_COLUMNOVERFLOW 0x80000000")]
    public const uint LVS_EX_COLUMNOVERFLOW = 0x80000000;
}
