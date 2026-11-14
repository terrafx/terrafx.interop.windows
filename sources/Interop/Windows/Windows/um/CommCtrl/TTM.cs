// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TTM
{
    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_ACTIVATE"]/*' />
    [NativeTypeName("#define TTM_ACTIVATE (WM_USER + 1)")]
    public const int TTM_ACTIVATE = (0x0400 + 1);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_SETDELAYTIME"]/*' />
    [NativeTypeName("#define TTM_SETDELAYTIME (WM_USER + 3)")]
    public const int TTM_SETDELAYTIME = (0x0400 + 3);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_ADDTOOLA"]/*' />
    [NativeTypeName("#define TTM_ADDTOOLA (WM_USER + 4)")]
    public const int TTM_ADDTOOLA = (0x0400 + 4);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_ADDTOOLW"]/*' />
    [NativeTypeName("#define TTM_ADDTOOLW (WM_USER + 50)")]
    public const int TTM_ADDTOOLW = (0x0400 + 50);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_DELTOOLA"]/*' />
    [NativeTypeName("#define TTM_DELTOOLA (WM_USER + 5)")]
    public const int TTM_DELTOOLA = (0x0400 + 5);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_DELTOOLW"]/*' />
    [NativeTypeName("#define TTM_DELTOOLW (WM_USER + 51)")]
    public const int TTM_DELTOOLW = (0x0400 + 51);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_NEWTOOLRECTA"]/*' />
    [NativeTypeName("#define TTM_NEWTOOLRECTA (WM_USER + 6)")]
    public const int TTM_NEWTOOLRECTA = (0x0400 + 6);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_NEWTOOLRECTW"]/*' />
    [NativeTypeName("#define TTM_NEWTOOLRECTW (WM_USER + 52)")]
    public const int TTM_NEWTOOLRECTW = (0x0400 + 52);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_RELAYEVENT"]/*' />
    [NativeTypeName("#define TTM_RELAYEVENT (WM_USER + 7)")]
    public const int TTM_RELAYEVENT = (0x0400 + 7);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETTOOLINFOA"]/*' />
    [NativeTypeName("#define TTM_GETTOOLINFOA (WM_USER + 8)")]
    public const int TTM_GETTOOLINFOA = (0x0400 + 8);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETTOOLINFOW"]/*' />
    [NativeTypeName("#define TTM_GETTOOLINFOW (WM_USER + 53)")]
    public const int TTM_GETTOOLINFOW = (0x0400 + 53);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_SETTOOLINFOA"]/*' />
    [NativeTypeName("#define TTM_SETTOOLINFOA (WM_USER + 9)")]
    public const int TTM_SETTOOLINFOA = (0x0400 + 9);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_SETTOOLINFOW"]/*' />
    [NativeTypeName("#define TTM_SETTOOLINFOW (WM_USER + 54)")]
    public const int TTM_SETTOOLINFOW = (0x0400 + 54);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_HITTESTA"]/*' />
    [NativeTypeName("#define TTM_HITTESTA (WM_USER +10)")]
    public const int TTM_HITTESTA = (0x0400 + 10);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_HITTESTW"]/*' />
    [NativeTypeName("#define TTM_HITTESTW (WM_USER +55)")]
    public const int TTM_HITTESTW = (0x0400 + 55);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETTEXTA"]/*' />
    [NativeTypeName("#define TTM_GETTEXTA (WM_USER +11)")]
    public const int TTM_GETTEXTA = (0x0400 + 11);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETTEXTW"]/*' />
    [NativeTypeName("#define TTM_GETTEXTW (WM_USER +56)")]
    public const int TTM_GETTEXTW = (0x0400 + 56);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_UPDATETIPTEXTA"]/*' />
    [NativeTypeName("#define TTM_UPDATETIPTEXTA (WM_USER +12)")]
    public const int TTM_UPDATETIPTEXTA = (0x0400 + 12);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_UPDATETIPTEXTW"]/*' />
    [NativeTypeName("#define TTM_UPDATETIPTEXTW (WM_USER +57)")]
    public const int TTM_UPDATETIPTEXTW = (0x0400 + 57);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETTOOLCOUNT"]/*' />
    [NativeTypeName("#define TTM_GETTOOLCOUNT (WM_USER +13)")]
    public const int TTM_GETTOOLCOUNT = (0x0400 + 13);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_ENUMTOOLSA"]/*' />
    [NativeTypeName("#define TTM_ENUMTOOLSA (WM_USER +14)")]
    public const int TTM_ENUMTOOLSA = (0x0400 + 14);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_ENUMTOOLSW"]/*' />
    [NativeTypeName("#define TTM_ENUMTOOLSW (WM_USER +58)")]
    public const int TTM_ENUMTOOLSW = (0x0400 + 58);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETCURRENTTOOLA"]/*' />
    [NativeTypeName("#define TTM_GETCURRENTTOOLA (WM_USER + 15)")]
    public const int TTM_GETCURRENTTOOLA = (0x0400 + 15);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETCURRENTTOOLW"]/*' />
    [NativeTypeName("#define TTM_GETCURRENTTOOLW (WM_USER + 59)")]
    public const int TTM_GETCURRENTTOOLW = (0x0400 + 59);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_WINDOWFROMPOINT"]/*' />
    [NativeTypeName("#define TTM_WINDOWFROMPOINT (WM_USER + 16)")]
    public const int TTM_WINDOWFROMPOINT = (0x0400 + 16);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_TRACKACTIVATE"]/*' />
    [NativeTypeName("#define TTM_TRACKACTIVATE (WM_USER + 17)")]
    public const int TTM_TRACKACTIVATE = (0x0400 + 17);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_TRACKPOSITION"]/*' />
    [NativeTypeName("#define TTM_TRACKPOSITION (WM_USER + 18)")]
    public const int TTM_TRACKPOSITION = (0x0400 + 18);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_SETTIPBKCOLOR"]/*' />
    [NativeTypeName("#define TTM_SETTIPBKCOLOR (WM_USER + 19)")]
    public const int TTM_SETTIPBKCOLOR = (0x0400 + 19);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_SETTIPTEXTCOLOR"]/*' />
    [NativeTypeName("#define TTM_SETTIPTEXTCOLOR (WM_USER + 20)")]
    public const int TTM_SETTIPTEXTCOLOR = (0x0400 + 20);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETDELAYTIME"]/*' />
    [NativeTypeName("#define TTM_GETDELAYTIME (WM_USER + 21)")]
    public const int TTM_GETDELAYTIME = (0x0400 + 21);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETTIPBKCOLOR"]/*' />
    [NativeTypeName("#define TTM_GETTIPBKCOLOR (WM_USER + 22)")]
    public const int TTM_GETTIPBKCOLOR = (0x0400 + 22);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETTIPTEXTCOLOR"]/*' />
    [NativeTypeName("#define TTM_GETTIPTEXTCOLOR (WM_USER + 23)")]
    public const int TTM_GETTIPTEXTCOLOR = (0x0400 + 23);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_SETMAXTIPWIDTH"]/*' />
    [NativeTypeName("#define TTM_SETMAXTIPWIDTH (WM_USER + 24)")]
    public const int TTM_SETMAXTIPWIDTH = (0x0400 + 24);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETMAXTIPWIDTH"]/*' />
    [NativeTypeName("#define TTM_GETMAXTIPWIDTH (WM_USER + 25)")]
    public const int TTM_GETMAXTIPWIDTH = (0x0400 + 25);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_SETMARGIN"]/*' />
    [NativeTypeName("#define TTM_SETMARGIN (WM_USER + 26)")]
    public const int TTM_SETMARGIN = (0x0400 + 26);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETMARGIN"]/*' />
    [NativeTypeName("#define TTM_GETMARGIN (WM_USER + 27)")]
    public const int TTM_GETMARGIN = (0x0400 + 27);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_POP"]/*' />
    [NativeTypeName("#define TTM_POP (WM_USER + 28)")]
    public const int TTM_POP = (0x0400 + 28);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_UPDATE"]/*' />
    [NativeTypeName("#define TTM_UPDATE (WM_USER + 29)")]
    public const int TTM_UPDATE = (0x0400 + 29);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETBUBBLESIZE"]/*' />
    [NativeTypeName("#define TTM_GETBUBBLESIZE (WM_USER + 30)")]
    public const int TTM_GETBUBBLESIZE = (0x0400 + 30);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_ADJUSTRECT"]/*' />
    [NativeTypeName("#define TTM_ADJUSTRECT (WM_USER + 31)")]
    public const int TTM_ADJUSTRECT = (0x0400 + 31);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_SETTITLEA"]/*' />
    [NativeTypeName("#define TTM_SETTITLEA (WM_USER + 32)")]
    public const int TTM_SETTITLEA = (0x0400 + 32);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_SETTITLEW"]/*' />
    [NativeTypeName("#define TTM_SETTITLEW (WM_USER + 33)")]
    public const int TTM_SETTITLEW = (0x0400 + 33);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_POPUP"]/*' />
    [NativeTypeName("#define TTM_POPUP (WM_USER + 34)")]
    public const int TTM_POPUP = (0x0400 + 34);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETTITLE"]/*' />
    [NativeTypeName("#define TTM_GETTITLE (WM_USER + 35)")]
    public const int TTM_GETTITLE = (0x0400 + 35);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_ADDTOOL"]/*' />
    [NativeTypeName("#define TTM_ADDTOOL TTM_ADDTOOLW")]
    public const int TTM_ADDTOOL = (0x0400 + 50);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_DELTOOL"]/*' />
    [NativeTypeName("#define TTM_DELTOOL TTM_DELTOOLW")]
    public const int TTM_DELTOOL = (0x0400 + 51);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_NEWTOOLRECT"]/*' />
    [NativeTypeName("#define TTM_NEWTOOLRECT TTM_NEWTOOLRECTW")]
    public const int TTM_NEWTOOLRECT = (0x0400 + 52);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETTOOLINFO"]/*' />
    [NativeTypeName("#define TTM_GETTOOLINFO TTM_GETTOOLINFOW")]
    public const int TTM_GETTOOLINFO = (0x0400 + 53);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_SETTOOLINFO"]/*' />
    [NativeTypeName("#define TTM_SETTOOLINFO TTM_SETTOOLINFOW")]
    public const int TTM_SETTOOLINFO = (0x0400 + 54);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_HITTEST"]/*' />
    [NativeTypeName("#define TTM_HITTEST TTM_HITTESTW")]
    public const int TTM_HITTEST = (0x0400 + 55);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETTEXT"]/*' />
    [NativeTypeName("#define TTM_GETTEXT TTM_GETTEXTW")]
    public const int TTM_GETTEXT = (0x0400 + 56);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_UPDATETIPTEXT"]/*' />
    [NativeTypeName("#define TTM_UPDATETIPTEXT TTM_UPDATETIPTEXTW")]
    public const int TTM_UPDATETIPTEXT = (0x0400 + 57);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_ENUMTOOLS"]/*' />
    [NativeTypeName("#define TTM_ENUMTOOLS TTM_ENUMTOOLSW")]
    public const int TTM_ENUMTOOLS = (0x0400 + 58);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_GETCURRENTTOOL"]/*' />
    [NativeTypeName("#define TTM_GETCURRENTTOOL TTM_GETCURRENTTOOLW")]
    public const int TTM_GETCURRENTTOOL = (0x0400 + 59);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_SETTITLE"]/*' />
    [NativeTypeName("#define TTM_SETTITLE TTM_SETTITLEW")]
    public const int TTM_SETTITLE = (0x0400 + 33);

    /// <include file='TTM.xml' path='doc/member[@name="TTM.TTM_SETWINDOWTHEME"]/*' />
    [NativeTypeName("#define TTM_SETWINDOWTHEME CCM_SETWINDOWTHEME")]
    public const int TTM_SETWINDOWTHEME = (0x2000 + 0xb);
}
