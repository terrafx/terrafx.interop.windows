// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class LVM
{
    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_FIRST"]/*' />
    [NativeTypeName("#define LVM_FIRST 0x1000")]
    public const int LVM_FIRST = 0x1000;

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETUNICODEFORMAT"]/*' />
    [NativeTypeName("#define LVM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
    public const int LVM_SETUNICODEFORMAT = (0x2000 + 5);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETUNICODEFORMAT"]/*' />
    [NativeTypeName("#define LVM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
    public const int LVM_GETUNICODEFORMAT = (0x2000 + 6);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETBKCOLOR"]/*' />
    [NativeTypeName("#define LVM_GETBKCOLOR (LVM_FIRST + 0)")]
    public const int LVM_GETBKCOLOR = (0x1000 + 0);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETBKCOLOR"]/*' />
    [NativeTypeName("#define LVM_SETBKCOLOR (LVM_FIRST + 1)")]
    public const int LVM_SETBKCOLOR = (0x1000 + 1);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETIMAGELIST"]/*' />
    [NativeTypeName("#define LVM_GETIMAGELIST (LVM_FIRST + 2)")]
    public const int LVM_GETIMAGELIST = (0x1000 + 2);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETIMAGELIST"]/*' />
    [NativeTypeName("#define LVM_SETIMAGELIST (LVM_FIRST + 3)")]
    public const int LVM_SETIMAGELIST = (0x1000 + 3);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETITEMCOUNT"]/*' />
    [NativeTypeName("#define LVM_GETITEMCOUNT (LVM_FIRST + 4)")]
    public const int LVM_GETITEMCOUNT = (0x1000 + 4);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETITEMA"]/*' />
    [NativeTypeName("#define LVM_GETITEMA (LVM_FIRST + 5)")]
    public const int LVM_GETITEMA = (0x1000 + 5);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETITEMW"]/*' />
    [NativeTypeName("#define LVM_GETITEMW (LVM_FIRST + 75)")]
    public const int LVM_GETITEMW = (0x1000 + 75);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETITEM"]/*' />
    [NativeTypeName("#define LVM_GETITEM LVM_GETITEMW")]
    public const int LVM_GETITEM = (0x1000 + 75);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETITEMA"]/*' />
    [NativeTypeName("#define LVM_SETITEMA (LVM_FIRST + 6)")]
    public const int LVM_SETITEMA = (0x1000 + 6);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETITEMW"]/*' />
    [NativeTypeName("#define LVM_SETITEMW (LVM_FIRST + 76)")]
    public const int LVM_SETITEMW = (0x1000 + 76);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETITEM"]/*' />
    [NativeTypeName("#define LVM_SETITEM LVM_SETITEMW")]
    public const int LVM_SETITEM = (0x1000 + 76);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_INSERTITEMA"]/*' />
    [NativeTypeName("#define LVM_INSERTITEMA (LVM_FIRST + 7)")]
    public const int LVM_INSERTITEMA = (0x1000 + 7);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_INSERTITEMW"]/*' />
    [NativeTypeName("#define LVM_INSERTITEMW (LVM_FIRST + 77)")]
    public const int LVM_INSERTITEMW = (0x1000 + 77);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_INSERTITEM"]/*' />
    [NativeTypeName("#define LVM_INSERTITEM LVM_INSERTITEMW")]
    public const int LVM_INSERTITEM = (0x1000 + 77);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_DELETEITEM"]/*' />
    [NativeTypeName("#define LVM_DELETEITEM (LVM_FIRST + 8)")]
    public const int LVM_DELETEITEM = (0x1000 + 8);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_DELETEALLITEMS"]/*' />
    [NativeTypeName("#define LVM_DELETEALLITEMS (LVM_FIRST + 9)")]
    public const int LVM_DELETEALLITEMS = (0x1000 + 9);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETCALLBACKMASK"]/*' />
    [NativeTypeName("#define LVM_GETCALLBACKMASK (LVM_FIRST + 10)")]
    public const int LVM_GETCALLBACKMASK = (0x1000 + 10);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETCALLBACKMASK"]/*' />
    [NativeTypeName("#define LVM_SETCALLBACKMASK (LVM_FIRST + 11)")]
    public const int LVM_SETCALLBACKMASK = (0x1000 + 11);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETNEXTITEM"]/*' />
    [NativeTypeName("#define LVM_GETNEXTITEM (LVM_FIRST + 12)")]
    public const int LVM_GETNEXTITEM = (0x1000 + 12);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_FINDITEMA"]/*' />
    [NativeTypeName("#define LVM_FINDITEMA (LVM_FIRST + 13)")]
    public const int LVM_FINDITEMA = (0x1000 + 13);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_FINDITEMW"]/*' />
    [NativeTypeName("#define LVM_FINDITEMW (LVM_FIRST + 83)")]
    public const int LVM_FINDITEMW = (0x1000 + 83);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_FINDITEM"]/*' />
    [NativeTypeName("#define LVM_FINDITEM LVM_FINDITEMW")]
    public const int LVM_FINDITEM = (0x1000 + 83);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETITEMRECT"]/*' />
    [NativeTypeName("#define LVM_GETITEMRECT (LVM_FIRST + 14)")]
    public const int LVM_GETITEMRECT = (0x1000 + 14);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETITEMPOSITION"]/*' />
    [NativeTypeName("#define LVM_SETITEMPOSITION (LVM_FIRST + 15)")]
    public const int LVM_SETITEMPOSITION = (0x1000 + 15);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETITEMPOSITION"]/*' />
    [NativeTypeName("#define LVM_GETITEMPOSITION (LVM_FIRST + 16)")]
    public const int LVM_GETITEMPOSITION = (0x1000 + 16);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETSTRINGWIDTHA"]/*' />
    [NativeTypeName("#define LVM_GETSTRINGWIDTHA (LVM_FIRST + 17)")]
    public const int LVM_GETSTRINGWIDTHA = (0x1000 + 17);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETSTRINGWIDTHW"]/*' />
    [NativeTypeName("#define LVM_GETSTRINGWIDTHW (LVM_FIRST + 87)")]
    public const int LVM_GETSTRINGWIDTHW = (0x1000 + 87);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETSTRINGWIDTH"]/*' />
    [NativeTypeName("#define LVM_GETSTRINGWIDTH LVM_GETSTRINGWIDTHW")]
    public const int LVM_GETSTRINGWIDTH = (0x1000 + 87);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_HITTEST"]/*' />
    [NativeTypeName("#define LVM_HITTEST (LVM_FIRST + 18)")]
    public const int LVM_HITTEST = (0x1000 + 18);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_ENSUREVISIBLE"]/*' />
    [NativeTypeName("#define LVM_ENSUREVISIBLE (LVM_FIRST + 19)")]
    public const int LVM_ENSUREVISIBLE = (0x1000 + 19);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SCROLL"]/*' />
    [NativeTypeName("#define LVM_SCROLL (LVM_FIRST + 20)")]
    public const int LVM_SCROLL = (0x1000 + 20);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_REDRAWITEMS"]/*' />
    [NativeTypeName("#define LVM_REDRAWITEMS (LVM_FIRST + 21)")]
    public const int LVM_REDRAWITEMS = (0x1000 + 21);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_ARRANGE"]/*' />
    [NativeTypeName("#define LVM_ARRANGE (LVM_FIRST + 22)")]
    public const int LVM_ARRANGE = (0x1000 + 22);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_EDITLABELA"]/*' />
    [NativeTypeName("#define LVM_EDITLABELA (LVM_FIRST + 23)")]
    public const int LVM_EDITLABELA = (0x1000 + 23);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_EDITLABELW"]/*' />
    [NativeTypeName("#define LVM_EDITLABELW (LVM_FIRST + 118)")]
    public const int LVM_EDITLABELW = (0x1000 + 118);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_EDITLABEL"]/*' />
    [NativeTypeName("#define LVM_EDITLABEL LVM_EDITLABELW")]
    public const int LVM_EDITLABEL = (0x1000 + 118);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETEDITCONTROL"]/*' />
    [NativeTypeName("#define LVM_GETEDITCONTROL (LVM_FIRST + 24)")]
    public const int LVM_GETEDITCONTROL = (0x1000 + 24);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETCOLUMNA"]/*' />
    [NativeTypeName("#define LVM_GETCOLUMNA (LVM_FIRST + 25)")]
    public const int LVM_GETCOLUMNA = (0x1000 + 25);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETCOLUMNW"]/*' />
    [NativeTypeName("#define LVM_GETCOLUMNW (LVM_FIRST + 95)")]
    public const int LVM_GETCOLUMNW = (0x1000 + 95);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETCOLUMN"]/*' />
    [NativeTypeName("#define LVM_GETCOLUMN LVM_GETCOLUMNW")]
    public const int LVM_GETCOLUMN = (0x1000 + 95);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETCOLUMNA"]/*' />
    [NativeTypeName("#define LVM_SETCOLUMNA (LVM_FIRST + 26)")]
    public const int LVM_SETCOLUMNA = (0x1000 + 26);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETCOLUMNW"]/*' />
    [NativeTypeName("#define LVM_SETCOLUMNW (LVM_FIRST + 96)")]
    public const int LVM_SETCOLUMNW = (0x1000 + 96);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETCOLUMN"]/*' />
    [NativeTypeName("#define LVM_SETCOLUMN LVM_SETCOLUMNW")]
    public const int LVM_SETCOLUMN = (0x1000 + 96);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_INSERTCOLUMNA"]/*' />
    [NativeTypeName("#define LVM_INSERTCOLUMNA (LVM_FIRST + 27)")]
    public const int LVM_INSERTCOLUMNA = (0x1000 + 27);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_INSERTCOLUMNW"]/*' />
    [NativeTypeName("#define LVM_INSERTCOLUMNW (LVM_FIRST + 97)")]
    public const int LVM_INSERTCOLUMNW = (0x1000 + 97);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_INSERTCOLUMN"]/*' />
    [NativeTypeName("#define LVM_INSERTCOLUMN LVM_INSERTCOLUMNW")]
    public const int LVM_INSERTCOLUMN = (0x1000 + 97);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_DELETECOLUMN"]/*' />
    [NativeTypeName("#define LVM_DELETECOLUMN (LVM_FIRST + 28)")]
    public const int LVM_DELETECOLUMN = (0x1000 + 28);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETCOLUMNWIDTH"]/*' />
    [NativeTypeName("#define LVM_GETCOLUMNWIDTH (LVM_FIRST + 29)")]
    public const int LVM_GETCOLUMNWIDTH = (0x1000 + 29);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETCOLUMNWIDTH"]/*' />
    [NativeTypeName("#define LVM_SETCOLUMNWIDTH (LVM_FIRST + 30)")]
    public const int LVM_SETCOLUMNWIDTH = (0x1000 + 30);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETHEADER"]/*' />
    [NativeTypeName("#define LVM_GETHEADER (LVM_FIRST + 31)")]
    public const int LVM_GETHEADER = (0x1000 + 31);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_CREATEDRAGIMAGE"]/*' />
    [NativeTypeName("#define LVM_CREATEDRAGIMAGE (LVM_FIRST + 33)")]
    public const int LVM_CREATEDRAGIMAGE = (0x1000 + 33);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETVIEWRECT"]/*' />
    [NativeTypeName("#define LVM_GETVIEWRECT (LVM_FIRST + 34)")]
    public const int LVM_GETVIEWRECT = (0x1000 + 34);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETTEXTCOLOR"]/*' />
    [NativeTypeName("#define LVM_GETTEXTCOLOR (LVM_FIRST + 35)")]
    public const int LVM_GETTEXTCOLOR = (0x1000 + 35);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETTEXTCOLOR"]/*' />
    [NativeTypeName("#define LVM_SETTEXTCOLOR (LVM_FIRST + 36)")]
    public const int LVM_SETTEXTCOLOR = (0x1000 + 36);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETTEXTBKCOLOR"]/*' />
    [NativeTypeName("#define LVM_GETTEXTBKCOLOR (LVM_FIRST + 37)")]
    public const int LVM_GETTEXTBKCOLOR = (0x1000 + 37);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETTEXTBKCOLOR"]/*' />
    [NativeTypeName("#define LVM_SETTEXTBKCOLOR (LVM_FIRST + 38)")]
    public const int LVM_SETTEXTBKCOLOR = (0x1000 + 38);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETTOPINDEX"]/*' />
    [NativeTypeName("#define LVM_GETTOPINDEX (LVM_FIRST + 39)")]
    public const int LVM_GETTOPINDEX = (0x1000 + 39);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETCOUNTPERPAGE"]/*' />
    [NativeTypeName("#define LVM_GETCOUNTPERPAGE (LVM_FIRST + 40)")]
    public const int LVM_GETCOUNTPERPAGE = (0x1000 + 40);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETORIGIN"]/*' />
    [NativeTypeName("#define LVM_GETORIGIN (LVM_FIRST + 41)")]
    public const int LVM_GETORIGIN = (0x1000 + 41);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_UPDATE"]/*' />
    [NativeTypeName("#define LVM_UPDATE (LVM_FIRST + 42)")]
    public const int LVM_UPDATE = (0x1000 + 42);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETITEMSTATE"]/*' />
    [NativeTypeName("#define LVM_SETITEMSTATE (LVM_FIRST + 43)")]
    public const int LVM_SETITEMSTATE = (0x1000 + 43);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETITEMSTATE"]/*' />
    [NativeTypeName("#define LVM_GETITEMSTATE (LVM_FIRST + 44)")]
    public const int LVM_GETITEMSTATE = (0x1000 + 44);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETITEMTEXTA"]/*' />
    [NativeTypeName("#define LVM_GETITEMTEXTA (LVM_FIRST + 45)")]
    public const int LVM_GETITEMTEXTA = (0x1000 + 45);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETITEMTEXTW"]/*' />
    [NativeTypeName("#define LVM_GETITEMTEXTW (LVM_FIRST + 115)")]
    public const int LVM_GETITEMTEXTW = (0x1000 + 115);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETITEMTEXT"]/*' />
    [NativeTypeName("#define LVM_GETITEMTEXT LVM_GETITEMTEXTW")]
    public const int LVM_GETITEMTEXT = (0x1000 + 115);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETITEMTEXTA"]/*' />
    [NativeTypeName("#define LVM_SETITEMTEXTA (LVM_FIRST + 46)")]
    public const int LVM_SETITEMTEXTA = (0x1000 + 46);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETITEMTEXTW"]/*' />
    [NativeTypeName("#define LVM_SETITEMTEXTW (LVM_FIRST + 116)")]
    public const int LVM_SETITEMTEXTW = (0x1000 + 116);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETITEMTEXT"]/*' />
    [NativeTypeName("#define LVM_SETITEMTEXT LVM_SETITEMTEXTW")]
    public const int LVM_SETITEMTEXT = (0x1000 + 116);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETITEMCOUNT"]/*' />
    [NativeTypeName("#define LVM_SETITEMCOUNT (LVM_FIRST + 47)")]
    public const int LVM_SETITEMCOUNT = (0x1000 + 47);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SORTITEMS"]/*' />
    [NativeTypeName("#define LVM_SORTITEMS (LVM_FIRST + 48)")]
    public const int LVM_SORTITEMS = (0x1000 + 48);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETITEMPOSITION32"]/*' />
    [NativeTypeName("#define LVM_SETITEMPOSITION32 (LVM_FIRST + 49)")]
    public const int LVM_SETITEMPOSITION32 = (0x1000 + 49);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETSELECTEDCOUNT"]/*' />
    [NativeTypeName("#define LVM_GETSELECTEDCOUNT (LVM_FIRST + 50)")]
    public const int LVM_GETSELECTEDCOUNT = (0x1000 + 50);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETITEMSPACING"]/*' />
    [NativeTypeName("#define LVM_GETITEMSPACING (LVM_FIRST + 51)")]
    public const int LVM_GETITEMSPACING = (0x1000 + 51);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETISEARCHSTRINGA"]/*' />
    [NativeTypeName("#define LVM_GETISEARCHSTRINGA (LVM_FIRST + 52)")]
    public const int LVM_GETISEARCHSTRINGA = (0x1000 + 52);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETISEARCHSTRINGW"]/*' />
    [NativeTypeName("#define LVM_GETISEARCHSTRINGW (LVM_FIRST + 117)")]
    public const int LVM_GETISEARCHSTRINGW = (0x1000 + 117);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETISEARCHSTRING"]/*' />
    [NativeTypeName("#define LVM_GETISEARCHSTRING LVM_GETISEARCHSTRINGW")]
    public const int LVM_GETISEARCHSTRING = (0x1000 + 117);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETICONSPACING"]/*' />
    [NativeTypeName("#define LVM_SETICONSPACING (LVM_FIRST + 53)")]
    public const int LVM_SETICONSPACING = (0x1000 + 53);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETEXTENDEDLISTVIEWSTYLE"]/*' />
    [NativeTypeName("#define LVM_SETEXTENDEDLISTVIEWSTYLE (LVM_FIRST + 54)")]
    public const int LVM_SETEXTENDEDLISTVIEWSTYLE = (0x1000 + 54);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETEXTENDEDLISTVIEWSTYLE"]/*' />
    [NativeTypeName("#define LVM_GETEXTENDEDLISTVIEWSTYLE (LVM_FIRST + 55)")]
    public const int LVM_GETEXTENDEDLISTVIEWSTYLE = (0x1000 + 55);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETSUBITEMRECT"]/*' />
    [NativeTypeName("#define LVM_GETSUBITEMRECT (LVM_FIRST + 56)")]
    public const int LVM_GETSUBITEMRECT = (0x1000 + 56);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SUBITEMHITTEST"]/*' />
    [NativeTypeName("#define LVM_SUBITEMHITTEST (LVM_FIRST + 57)")]
    public const int LVM_SUBITEMHITTEST = (0x1000 + 57);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETCOLUMNORDERARRAY"]/*' />
    [NativeTypeName("#define LVM_SETCOLUMNORDERARRAY (LVM_FIRST + 58)")]
    public const int LVM_SETCOLUMNORDERARRAY = (0x1000 + 58);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETCOLUMNORDERARRAY"]/*' />
    [NativeTypeName("#define LVM_GETCOLUMNORDERARRAY (LVM_FIRST + 59)")]
    public const int LVM_GETCOLUMNORDERARRAY = (0x1000 + 59);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETHOTITEM"]/*' />
    [NativeTypeName("#define LVM_SETHOTITEM (LVM_FIRST + 60)")]
    public const int LVM_SETHOTITEM = (0x1000 + 60);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETHOTITEM"]/*' />
    [NativeTypeName("#define LVM_GETHOTITEM (LVM_FIRST + 61)")]
    public const int LVM_GETHOTITEM = (0x1000 + 61);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETHOTCURSOR"]/*' />
    [NativeTypeName("#define LVM_SETHOTCURSOR (LVM_FIRST + 62)")]
    public const int LVM_SETHOTCURSOR = (0x1000 + 62);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETHOTCURSOR"]/*' />
    [NativeTypeName("#define LVM_GETHOTCURSOR (LVM_FIRST + 63)")]
    public const int LVM_GETHOTCURSOR = (0x1000 + 63);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_APPROXIMATEVIEWRECT"]/*' />
    [NativeTypeName("#define LVM_APPROXIMATEVIEWRECT (LVM_FIRST + 64)")]
    public const int LVM_APPROXIMATEVIEWRECT = (0x1000 + 64);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETWORKAREAS"]/*' />
    [NativeTypeName("#define LVM_SETWORKAREAS (LVM_FIRST + 65)")]
    public const int LVM_SETWORKAREAS = (0x1000 + 65);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETWORKAREAS"]/*' />
    [NativeTypeName("#define LVM_GETWORKAREAS (LVM_FIRST + 70)")]
    public const int LVM_GETWORKAREAS = (0x1000 + 70);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETNUMBEROFWORKAREAS"]/*' />
    [NativeTypeName("#define LVM_GETNUMBEROFWORKAREAS (LVM_FIRST + 73)")]
    public const int LVM_GETNUMBEROFWORKAREAS = (0x1000 + 73);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETSELECTIONMARK"]/*' />
    [NativeTypeName("#define LVM_GETSELECTIONMARK (LVM_FIRST + 66)")]
    public const int LVM_GETSELECTIONMARK = (0x1000 + 66);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETSELECTIONMARK"]/*' />
    [NativeTypeName("#define LVM_SETSELECTIONMARK (LVM_FIRST + 67)")]
    public const int LVM_SETSELECTIONMARK = (0x1000 + 67);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETHOVERTIME"]/*' />
    [NativeTypeName("#define LVM_SETHOVERTIME (LVM_FIRST + 71)")]
    public const int LVM_SETHOVERTIME = (0x1000 + 71);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETHOVERTIME"]/*' />
    [NativeTypeName("#define LVM_GETHOVERTIME (LVM_FIRST + 72)")]
    public const int LVM_GETHOVERTIME = (0x1000 + 72);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETTOOLTIPS"]/*' />
    [NativeTypeName("#define LVM_SETTOOLTIPS (LVM_FIRST + 74)")]
    public const int LVM_SETTOOLTIPS = (0x1000 + 74);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETTOOLTIPS"]/*' />
    [NativeTypeName("#define LVM_GETTOOLTIPS (LVM_FIRST + 78)")]
    public const int LVM_GETTOOLTIPS = (0x1000 + 78);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SORTITEMSEX"]/*' />
    [NativeTypeName("#define LVM_SORTITEMSEX (LVM_FIRST + 81)")]
    public const int LVM_SORTITEMSEX = (0x1000 + 81);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETBKIMAGEA"]/*' />
    [NativeTypeName("#define LVM_SETBKIMAGEA (LVM_FIRST + 68)")]
    public const int LVM_SETBKIMAGEA = (0x1000 + 68);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETBKIMAGEW"]/*' />
    [NativeTypeName("#define LVM_SETBKIMAGEW (LVM_FIRST + 138)")]
    public const int LVM_SETBKIMAGEW = (0x1000 + 138);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETBKIMAGEA"]/*' />
    [NativeTypeName("#define LVM_GETBKIMAGEA (LVM_FIRST + 69)")]
    public const int LVM_GETBKIMAGEA = (0x1000 + 69);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETBKIMAGEW"]/*' />
    [NativeTypeName("#define LVM_GETBKIMAGEW (LVM_FIRST + 139)")]
    public const int LVM_GETBKIMAGEW = (0x1000 + 139);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETSELECTEDCOLUMN"]/*' />
    [NativeTypeName("#define LVM_SETSELECTEDCOLUMN (LVM_FIRST + 140)")]
    public const int LVM_SETSELECTEDCOLUMN = (0x1000 + 140);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETVIEW"]/*' />
    [NativeTypeName("#define LVM_SETVIEW (LVM_FIRST + 142)")]
    public const int LVM_SETVIEW = (0x1000 + 142);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETVIEW"]/*' />
    [NativeTypeName("#define LVM_GETVIEW (LVM_FIRST + 143)")]
    public const int LVM_GETVIEW = (0x1000 + 143);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_INSERTGROUP"]/*' />
    [NativeTypeName("#define LVM_INSERTGROUP (LVM_FIRST + 145)")]
    public const int LVM_INSERTGROUP = (0x1000 + 145);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETGROUPINFO"]/*' />
    [NativeTypeName("#define LVM_SETGROUPINFO (LVM_FIRST + 147)")]
    public const int LVM_SETGROUPINFO = (0x1000 + 147);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETGROUPINFO"]/*' />
    [NativeTypeName("#define LVM_GETGROUPINFO (LVM_FIRST + 149)")]
    public const int LVM_GETGROUPINFO = (0x1000 + 149);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_REMOVEGROUP"]/*' />
    [NativeTypeName("#define LVM_REMOVEGROUP (LVM_FIRST + 150)")]
    public const int LVM_REMOVEGROUP = (0x1000 + 150);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_MOVEGROUP"]/*' />
    [NativeTypeName("#define LVM_MOVEGROUP (LVM_FIRST + 151)")]
    public const int LVM_MOVEGROUP = (0x1000 + 151);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETGROUPCOUNT"]/*' />
    [NativeTypeName("#define LVM_GETGROUPCOUNT (LVM_FIRST + 152)")]
    public const int LVM_GETGROUPCOUNT = (0x1000 + 152);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETGROUPINFOBYINDEX"]/*' />
    [NativeTypeName("#define LVM_GETGROUPINFOBYINDEX (LVM_FIRST + 153)")]
    public const int LVM_GETGROUPINFOBYINDEX = (0x1000 + 153);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_MOVEITEMTOGROUP"]/*' />
    [NativeTypeName("#define LVM_MOVEITEMTOGROUP (LVM_FIRST + 154)")]
    public const int LVM_MOVEITEMTOGROUP = (0x1000 + 154);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETGROUPRECT"]/*' />
    [NativeTypeName("#define LVM_GETGROUPRECT (LVM_FIRST + 98)")]
    public const int LVM_GETGROUPRECT = (0x1000 + 98);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETGROUPMETRICS"]/*' />
    [NativeTypeName("#define LVM_SETGROUPMETRICS (LVM_FIRST + 155)")]
    public const int LVM_SETGROUPMETRICS = (0x1000 + 155);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETGROUPMETRICS"]/*' />
    [NativeTypeName("#define LVM_GETGROUPMETRICS (LVM_FIRST + 156)")]
    public const int LVM_GETGROUPMETRICS = (0x1000 + 156);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_ENABLEGROUPVIEW"]/*' />
    [NativeTypeName("#define LVM_ENABLEGROUPVIEW (LVM_FIRST + 157)")]
    public const int LVM_ENABLEGROUPVIEW = (0x1000 + 157);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SORTGROUPS"]/*' />
    [NativeTypeName("#define LVM_SORTGROUPS (LVM_FIRST + 158)")]
    public const int LVM_SORTGROUPS = (0x1000 + 158);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_INSERTGROUPSORTED"]/*' />
    [NativeTypeName("#define LVM_INSERTGROUPSORTED (LVM_FIRST + 159)")]
    public const int LVM_INSERTGROUPSORTED = (0x1000 + 159);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_REMOVEALLGROUPS"]/*' />
    [NativeTypeName("#define LVM_REMOVEALLGROUPS (LVM_FIRST + 160)")]
    public const int LVM_REMOVEALLGROUPS = (0x1000 + 160);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_HASGROUP"]/*' />
    [NativeTypeName("#define LVM_HASGROUP (LVM_FIRST + 161)")]
    public const int LVM_HASGROUP = (0x1000 + 161);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETGROUPSTATE"]/*' />
    [NativeTypeName("#define LVM_GETGROUPSTATE (LVM_FIRST + 92)")]
    public const int LVM_GETGROUPSTATE = (0x1000 + 92);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETFOCUSEDGROUP"]/*' />
    [NativeTypeName("#define LVM_GETFOCUSEDGROUP (LVM_FIRST + 93)")]
    public const int LVM_GETFOCUSEDGROUP = (0x1000 + 93);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETTILEVIEWINFO"]/*' />
    [NativeTypeName("#define LVM_SETTILEVIEWINFO (LVM_FIRST + 162)")]
    public const int LVM_SETTILEVIEWINFO = (0x1000 + 162);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETTILEVIEWINFO"]/*' />
    [NativeTypeName("#define LVM_GETTILEVIEWINFO (LVM_FIRST + 163)")]
    public const int LVM_GETTILEVIEWINFO = (0x1000 + 163);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETTILEINFO"]/*' />
    [NativeTypeName("#define LVM_SETTILEINFO (LVM_FIRST + 164)")]
    public const int LVM_SETTILEINFO = (0x1000 + 164);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETTILEINFO"]/*' />
    [NativeTypeName("#define LVM_GETTILEINFO (LVM_FIRST + 165)")]
    public const int LVM_GETTILEINFO = (0x1000 + 165);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETINSERTMARK"]/*' />
    [NativeTypeName("#define LVM_SETINSERTMARK (LVM_FIRST + 166)")]
    public const int LVM_SETINSERTMARK = (0x1000 + 166);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETINSERTMARK"]/*' />
    [NativeTypeName("#define LVM_GETINSERTMARK (LVM_FIRST + 167)")]
    public const int LVM_GETINSERTMARK = (0x1000 + 167);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_INSERTMARKHITTEST"]/*' />
    [NativeTypeName("#define LVM_INSERTMARKHITTEST (LVM_FIRST + 168)")]
    public const int LVM_INSERTMARKHITTEST = (0x1000 + 168);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETINSERTMARKRECT"]/*' />
    [NativeTypeName("#define LVM_GETINSERTMARKRECT (LVM_FIRST + 169)")]
    public const int LVM_GETINSERTMARKRECT = (0x1000 + 169);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETINSERTMARKCOLOR"]/*' />
    [NativeTypeName("#define LVM_SETINSERTMARKCOLOR (LVM_FIRST + 170)")]
    public const int LVM_SETINSERTMARKCOLOR = (0x1000 + 170);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETINSERTMARKCOLOR"]/*' />
    [NativeTypeName("#define LVM_GETINSERTMARKCOLOR (LVM_FIRST + 171)")]
    public const int LVM_GETINSERTMARKCOLOR = (0x1000 + 171);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETINFOTIP"]/*' />
    [NativeTypeName("#define LVM_SETINFOTIP (LVM_FIRST + 173)")]
    public const int LVM_SETINFOTIP = (0x1000 + 173);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETSELECTEDCOLUMN"]/*' />
    [NativeTypeName("#define LVM_GETSELECTEDCOLUMN (LVM_FIRST + 174)")]
    public const int LVM_GETSELECTEDCOLUMN = (0x1000 + 174);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_ISGROUPVIEWENABLED"]/*' />
    [NativeTypeName("#define LVM_ISGROUPVIEWENABLED (LVM_FIRST + 175)")]
    public const int LVM_ISGROUPVIEWENABLED = (0x1000 + 175);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETOUTLINECOLOR"]/*' />
    [NativeTypeName("#define LVM_GETOUTLINECOLOR (LVM_FIRST + 176)")]
    public const int LVM_GETOUTLINECOLOR = (0x1000 + 176);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETOUTLINECOLOR"]/*' />
    [NativeTypeName("#define LVM_SETOUTLINECOLOR (LVM_FIRST + 177)")]
    public const int LVM_SETOUTLINECOLOR = (0x1000 + 177);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_CANCELEDITLABEL"]/*' />
    [NativeTypeName("#define LVM_CANCELEDITLABEL (LVM_FIRST + 179)")]
    public const int LVM_CANCELEDITLABEL = (0x1000 + 179);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_MAPINDEXTOID"]/*' />
    [NativeTypeName("#define LVM_MAPINDEXTOID (LVM_FIRST + 180)")]
    public const int LVM_MAPINDEXTOID = (0x1000 + 180);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_MAPIDTOINDEX"]/*' />
    [NativeTypeName("#define LVM_MAPIDTOINDEX (LVM_FIRST + 181)")]
    public const int LVM_MAPIDTOINDEX = (0x1000 + 181);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_ISITEMVISIBLE"]/*' />
    [NativeTypeName("#define LVM_ISITEMVISIBLE (LVM_FIRST + 182)")]
    public const int LVM_ISITEMVISIBLE = (0x1000 + 182);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETEMPTYTEXT"]/*' />
    [NativeTypeName("#define LVM_GETEMPTYTEXT (LVM_FIRST + 204)")]
    public const int LVM_GETEMPTYTEXT = (0x1000 + 204);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETFOOTERRECT"]/*' />
    [NativeTypeName("#define LVM_GETFOOTERRECT (LVM_FIRST + 205)")]
    public const int LVM_GETFOOTERRECT = (0x1000 + 205);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETFOOTERINFO"]/*' />
    [NativeTypeName("#define LVM_GETFOOTERINFO (LVM_FIRST + 206)")]
    public const int LVM_GETFOOTERINFO = (0x1000 + 206);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETFOOTERITEMRECT"]/*' />
    [NativeTypeName("#define LVM_GETFOOTERITEMRECT (LVM_FIRST + 207)")]
    public const int LVM_GETFOOTERITEMRECT = (0x1000 + 207);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETFOOTERITEM"]/*' />
    [NativeTypeName("#define LVM_GETFOOTERITEM (LVM_FIRST + 208)")]
    public const int LVM_GETFOOTERITEM = (0x1000 + 208);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETITEMINDEXRECT"]/*' />
    [NativeTypeName("#define LVM_GETITEMINDEXRECT (LVM_FIRST + 209)")]
    public const int LVM_GETITEMINDEXRECT = (0x1000 + 209);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETITEMINDEXSTATE"]/*' />
    [NativeTypeName("#define LVM_SETITEMINDEXSTATE (LVM_FIRST + 210)")]
    public const int LVM_SETITEMINDEXSTATE = (0x1000 + 210);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETNEXTITEMINDEX"]/*' />
    [NativeTypeName("#define LVM_GETNEXTITEMINDEX (LVM_FIRST + 211)")]
    public const int LVM_GETNEXTITEMINDEX = (0x1000 + 211);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_SETBKIMAGE"]/*' />
    [NativeTypeName("#define LVM_SETBKIMAGE LVM_SETBKIMAGEW")]
    public const int LVM_SETBKIMAGE = (0x1000 + 138);

    /// <include file='LVM.xml' path='doc/member[@name="LVM.LVM_GETBKIMAGE"]/*' />
    [NativeTypeName("#define LVM_GETBKIMAGE LVM_GETBKIMAGEW")]
    public const int LVM_GETBKIMAGE = (0x1000 + 139);
}
