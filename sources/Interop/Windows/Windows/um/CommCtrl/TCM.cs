// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TCM
{
    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_FIRST"]/*' />
    [NativeTypeName("#define TCM_FIRST 0x1300")]
    public const int TCM_FIRST = 0x1300;

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_GETIMAGELIST"]/*' />
    [NativeTypeName("#define TCM_GETIMAGELIST (TCM_FIRST + 2)")]
    public const int TCM_GETIMAGELIST = (0x1300 + 2);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_SETIMAGELIST"]/*' />
    [NativeTypeName("#define TCM_SETIMAGELIST (TCM_FIRST + 3)")]
    public const int TCM_SETIMAGELIST = (0x1300 + 3);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_GETITEMCOUNT"]/*' />
    [NativeTypeName("#define TCM_GETITEMCOUNT (TCM_FIRST + 4)")]
    public const int TCM_GETITEMCOUNT = (0x1300 + 4);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_GETITEMA"]/*' />
    [NativeTypeName("#define TCM_GETITEMA (TCM_FIRST + 5)")]
    public const int TCM_GETITEMA = (0x1300 + 5);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_GETITEMW"]/*' />
    [NativeTypeName("#define TCM_GETITEMW (TCM_FIRST + 60)")]
    public const int TCM_GETITEMW = (0x1300 + 60);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_GETITEM"]/*' />
    [NativeTypeName("#define TCM_GETITEM TCM_GETITEMW")]
    public const int TCM_GETITEM = (0x1300 + 60);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_SETITEMA"]/*' />
    [NativeTypeName("#define TCM_SETITEMA (TCM_FIRST + 6)")]
    public const int TCM_SETITEMA = (0x1300 + 6);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_SETITEMW"]/*' />
    [NativeTypeName("#define TCM_SETITEMW (TCM_FIRST + 61)")]
    public const int TCM_SETITEMW = (0x1300 + 61);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_SETITEM"]/*' />
    [NativeTypeName("#define TCM_SETITEM TCM_SETITEMW")]
    public const int TCM_SETITEM = (0x1300 + 61);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_INSERTITEMA"]/*' />
    [NativeTypeName("#define TCM_INSERTITEMA (TCM_FIRST + 7)")]
    public const int TCM_INSERTITEMA = (0x1300 + 7);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_INSERTITEMW"]/*' />
    [NativeTypeName("#define TCM_INSERTITEMW (TCM_FIRST + 62)")]
    public const int TCM_INSERTITEMW = (0x1300 + 62);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_INSERTITEM"]/*' />
    [NativeTypeName("#define TCM_INSERTITEM TCM_INSERTITEMW")]
    public const int TCM_INSERTITEM = (0x1300 + 62);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_DELETEITEM"]/*' />
    [NativeTypeName("#define TCM_DELETEITEM (TCM_FIRST + 8)")]
    public const int TCM_DELETEITEM = (0x1300 + 8);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_DELETEALLITEMS"]/*' />
    [NativeTypeName("#define TCM_DELETEALLITEMS (TCM_FIRST + 9)")]
    public const int TCM_DELETEALLITEMS = (0x1300 + 9);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_GETITEMRECT"]/*' />
    [NativeTypeName("#define TCM_GETITEMRECT (TCM_FIRST + 10)")]
    public const int TCM_GETITEMRECT = (0x1300 + 10);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_GETCURSEL"]/*' />
    [NativeTypeName("#define TCM_GETCURSEL (TCM_FIRST + 11)")]
    public const int TCM_GETCURSEL = (0x1300 + 11);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_SETCURSEL"]/*' />
    [NativeTypeName("#define TCM_SETCURSEL (TCM_FIRST + 12)")]
    public const int TCM_SETCURSEL = (0x1300 + 12);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_HITTEST"]/*' />
    [NativeTypeName("#define TCM_HITTEST (TCM_FIRST + 13)")]
    public const int TCM_HITTEST = (0x1300 + 13);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_SETITEMEXTRA"]/*' />
    [NativeTypeName("#define TCM_SETITEMEXTRA (TCM_FIRST + 14)")]
    public const int TCM_SETITEMEXTRA = (0x1300 + 14);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_ADJUSTRECT"]/*' />
    [NativeTypeName("#define TCM_ADJUSTRECT (TCM_FIRST + 40)")]
    public const int TCM_ADJUSTRECT = (0x1300 + 40);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_SETITEMSIZE"]/*' />
    [NativeTypeName("#define TCM_SETITEMSIZE (TCM_FIRST + 41)")]
    public const int TCM_SETITEMSIZE = (0x1300 + 41);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_REMOVEIMAGE"]/*' />
    [NativeTypeName("#define TCM_REMOVEIMAGE (TCM_FIRST + 42)")]
    public const int TCM_REMOVEIMAGE = (0x1300 + 42);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_SETPADDING"]/*' />
    [NativeTypeName("#define TCM_SETPADDING (TCM_FIRST + 43)")]
    public const int TCM_SETPADDING = (0x1300 + 43);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_GETROWCOUNT"]/*' />
    [NativeTypeName("#define TCM_GETROWCOUNT (TCM_FIRST + 44)")]
    public const int TCM_GETROWCOUNT = (0x1300 + 44);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_GETTOOLTIPS"]/*' />
    [NativeTypeName("#define TCM_GETTOOLTIPS (TCM_FIRST + 45)")]
    public const int TCM_GETTOOLTIPS = (0x1300 + 45);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_SETTOOLTIPS"]/*' />
    [NativeTypeName("#define TCM_SETTOOLTIPS (TCM_FIRST + 46)")]
    public const int TCM_SETTOOLTIPS = (0x1300 + 46);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_GETCURFOCUS"]/*' />
    [NativeTypeName("#define TCM_GETCURFOCUS (TCM_FIRST + 47)")]
    public const int TCM_GETCURFOCUS = (0x1300 + 47);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_SETCURFOCUS"]/*' />
    [NativeTypeName("#define TCM_SETCURFOCUS (TCM_FIRST + 48)")]
    public const int TCM_SETCURFOCUS = (0x1300 + 48);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_SETMINTABWIDTH"]/*' />
    [NativeTypeName("#define TCM_SETMINTABWIDTH (TCM_FIRST + 49)")]
    public const int TCM_SETMINTABWIDTH = (0x1300 + 49);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_DESELECTALL"]/*' />
    [NativeTypeName("#define TCM_DESELECTALL (TCM_FIRST + 50)")]
    public const int TCM_DESELECTALL = (0x1300 + 50);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_HIGHLIGHTITEM"]/*' />
    [NativeTypeName("#define TCM_HIGHLIGHTITEM (TCM_FIRST + 51)")]
    public const int TCM_HIGHLIGHTITEM = (0x1300 + 51);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_SETEXTENDEDSTYLE"]/*' />
    [NativeTypeName("#define TCM_SETEXTENDEDSTYLE (TCM_FIRST + 52)")]
    public const int TCM_SETEXTENDEDSTYLE = (0x1300 + 52);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_GETEXTENDEDSTYLE"]/*' />
    [NativeTypeName("#define TCM_GETEXTENDEDSTYLE (TCM_FIRST + 53)")]
    public const int TCM_GETEXTENDEDSTYLE = (0x1300 + 53);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_SETUNICODEFORMAT"]/*' />
    [NativeTypeName("#define TCM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
    public const int TCM_SETUNICODEFORMAT = (0x2000 + 5);

    /// <include file='TCM.xml' path='doc/member[@name="TCM.TCM_GETUNICODEFORMAT"]/*' />
    [NativeTypeName("#define TCM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
    public const int TCM_GETUNICODEFORMAT = (0x2000 + 6);
}
