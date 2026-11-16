// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PSM
{
    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETCURSEL"]/*' />
    [NativeTypeName("#define PSM_SETCURSEL (WM_USER + 101)")]
    public const int PSM_SETCURSEL = (0x0400 + 101);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_REMOVEPAGE"]/*' />
    [NativeTypeName("#define PSM_REMOVEPAGE (WM_USER + 102)")]
    public const int PSM_REMOVEPAGE = (0x0400 + 102);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_ADDPAGE"]/*' />
    [NativeTypeName("#define PSM_ADDPAGE (WM_USER + 103)")]
    public const int PSM_ADDPAGE = (0x0400 + 103);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_CHANGED"]/*' />
    [NativeTypeName("#define PSM_CHANGED (WM_USER + 104)")]
    public const int PSM_CHANGED = (0x0400 + 104);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_RESTARTWINDOWS"]/*' />
    [NativeTypeName("#define PSM_RESTARTWINDOWS (WM_USER + 105)")]
    public const int PSM_RESTARTWINDOWS = (0x0400 + 105);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_REBOOTSYSTEM"]/*' />
    [NativeTypeName("#define PSM_REBOOTSYSTEM (WM_USER + 106)")]
    public const int PSM_REBOOTSYSTEM = (0x0400 + 106);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_CANCELTOCLOSE"]/*' />
    [NativeTypeName("#define PSM_CANCELTOCLOSE (WM_USER + 107)")]
    public const int PSM_CANCELTOCLOSE = (0x0400 + 107);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_QUERYSIBLINGS"]/*' />
    [NativeTypeName("#define PSM_QUERYSIBLINGS (WM_USER + 108)")]
    public const int PSM_QUERYSIBLINGS = (0x0400 + 108);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_UNCHANGED"]/*' />
    [NativeTypeName("#define PSM_UNCHANGED (WM_USER + 109)")]
    public const int PSM_UNCHANGED = (0x0400 + 109);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_APPLY"]/*' />
    [NativeTypeName("#define PSM_APPLY (WM_USER + 110)")]
    public const int PSM_APPLY = (0x0400 + 110);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETTITLEA"]/*' />
    [NativeTypeName("#define PSM_SETTITLEA (WM_USER + 111)")]
    public const int PSM_SETTITLEA = (0x0400 + 111);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETTITLEW"]/*' />
    [NativeTypeName("#define PSM_SETTITLEW (WM_USER + 120)")]
    public const int PSM_SETTITLEW = (0x0400 + 120);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETTITLE"]/*' />
    [NativeTypeName("#define PSM_SETTITLE PSM_SETTITLEW")]
    public const int PSM_SETTITLE = (0x0400 + 120);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETWIZBUTTONS"]/*' />
    [NativeTypeName("#define PSM_SETWIZBUTTONS (WM_USER + 112)")]
    public const int PSM_SETWIZBUTTONS = (0x0400 + 112);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_PRESSBUTTON"]/*' />
    [NativeTypeName("#define PSM_PRESSBUTTON (WM_USER + 113)")]
    public const int PSM_PRESSBUTTON = (0x0400 + 113);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETCURSELID"]/*' />
    [NativeTypeName("#define PSM_SETCURSELID (WM_USER + 114)")]
    public const int PSM_SETCURSELID = (0x0400 + 114);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETFINISHTEXTA"]/*' />
    [NativeTypeName("#define PSM_SETFINISHTEXTA (WM_USER + 115)")]
    public const int PSM_SETFINISHTEXTA = (0x0400 + 115);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETFINISHTEXTW"]/*' />
    [NativeTypeName("#define PSM_SETFINISHTEXTW (WM_USER + 121)")]
    public const int PSM_SETFINISHTEXTW = (0x0400 + 121);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETFINISHTEXT"]/*' />
    [NativeTypeName("#define PSM_SETFINISHTEXT PSM_SETFINISHTEXTW")]
    public const int PSM_SETFINISHTEXT = (0x0400 + 121);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_GETTABCONTROL"]/*' />
    [NativeTypeName("#define PSM_GETTABCONTROL (WM_USER + 116)")]
    public const int PSM_GETTABCONTROL = (0x0400 + 116);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_ISDIALOGMESSAGE"]/*' />
    [NativeTypeName("#define PSM_ISDIALOGMESSAGE (WM_USER + 117)")]
    public const int PSM_ISDIALOGMESSAGE = (0x0400 + 117);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_GETCURRENTPAGEHWND"]/*' />
    [NativeTypeName("#define PSM_GETCURRENTPAGEHWND (WM_USER + 118)")]
    public const int PSM_GETCURRENTPAGEHWND = (0x0400 + 118);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_INSERTPAGE"]/*' />
    [NativeTypeName("#define PSM_INSERTPAGE (WM_USER + 119)")]
    public const int PSM_INSERTPAGE = (0x0400 + 119);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETHEADERTITLEA"]/*' />
    [NativeTypeName("#define PSM_SETHEADERTITLEA (WM_USER + 125)")]
    public const int PSM_SETHEADERTITLEA = (0x0400 + 125);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETHEADERTITLEW"]/*' />
    [NativeTypeName("#define PSM_SETHEADERTITLEW (WM_USER + 126)")]
    public const int PSM_SETHEADERTITLEW = (0x0400 + 126);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETHEADERTITLE"]/*' />
    [NativeTypeName("#define PSM_SETHEADERTITLE PSM_SETHEADERTITLEW")]
    public const int PSM_SETHEADERTITLE = (0x0400 + 126);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETHEADERSUBTITLEA"]/*' />
    [NativeTypeName("#define PSM_SETHEADERSUBTITLEA (WM_USER + 127)")]
    public const int PSM_SETHEADERSUBTITLEA = (0x0400 + 127);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETHEADERSUBTITLEW"]/*' />
    [NativeTypeName("#define PSM_SETHEADERSUBTITLEW (WM_USER + 128)")]
    public const int PSM_SETHEADERSUBTITLEW = (0x0400 + 128);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETHEADERSUBTITLE"]/*' />
    [NativeTypeName("#define PSM_SETHEADERSUBTITLE PSM_SETHEADERSUBTITLEW")]
    public const int PSM_SETHEADERSUBTITLE = (0x0400 + 128);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_HWNDTOINDEX"]/*' />
    [NativeTypeName("#define PSM_HWNDTOINDEX (WM_USER + 129)")]
    public const int PSM_HWNDTOINDEX = (0x0400 + 129);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_INDEXTOHWND"]/*' />
    [NativeTypeName("#define PSM_INDEXTOHWND (WM_USER + 130)")]
    public const int PSM_INDEXTOHWND = (0x0400 + 130);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_PAGETOINDEX"]/*' />
    [NativeTypeName("#define PSM_PAGETOINDEX (WM_USER + 131)")]
    public const int PSM_PAGETOINDEX = (0x0400 + 131);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_INDEXTOPAGE"]/*' />
    [NativeTypeName("#define PSM_INDEXTOPAGE (WM_USER + 132)")]
    public const int PSM_INDEXTOPAGE = (0x0400 + 132);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_IDTOINDEX"]/*' />
    [NativeTypeName("#define PSM_IDTOINDEX (WM_USER + 133)")]
    public const int PSM_IDTOINDEX = (0x0400 + 133);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_INDEXTOID"]/*' />
    [NativeTypeName("#define PSM_INDEXTOID (WM_USER + 134)")]
    public const int PSM_INDEXTOID = (0x0400 + 134);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_GETRESULT"]/*' />
    [NativeTypeName("#define PSM_GETRESULT (WM_USER + 135)")]
    public const int PSM_GETRESULT = (0x0400 + 135);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_RECALCPAGESIZES"]/*' />
    [NativeTypeName("#define PSM_RECALCPAGESIZES (WM_USER + 136)")]
    public const int PSM_RECALCPAGESIZES = (0x0400 + 136);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETNEXTTEXTW"]/*' />
    [NativeTypeName("#define PSM_SETNEXTTEXTW (WM_USER + 137)")]
    public const int PSM_SETNEXTTEXTW = (0x0400 + 137);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETNEXTTEXT"]/*' />
    [NativeTypeName("#define PSM_SETNEXTTEXT PSM_SETNEXTTEXTW")]
    public const int PSM_SETNEXTTEXT = (0x0400 + 137);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SHOWWIZBUTTONS"]/*' />
    [NativeTypeName("#define PSM_SHOWWIZBUTTONS (WM_USER + 138)")]
    public const int PSM_SHOWWIZBUTTONS = (0x0400 + 138);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_ENABLEWIZBUTTONS"]/*' />
    [NativeTypeName("#define PSM_ENABLEWIZBUTTONS (WM_USER + 139)")]
    public const int PSM_ENABLEWIZBUTTONS = (0x0400 + 139);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETBUTTONTEXTW"]/*' />
    [NativeTypeName("#define PSM_SETBUTTONTEXTW (WM_USER + 140)")]
    public const int PSM_SETBUTTONTEXTW = (0x0400 + 140);

    /// <include file='PSM.xml' path='doc/member[@name="PSM.PSM_SETBUTTONTEXT"]/*' />
    [NativeTypeName("#define PSM_SETBUTTONTEXT PSM_SETBUTTONTEXTW")]
    public const int PSM_SETBUTTONTEXT = (0x0400 + 140);
}
