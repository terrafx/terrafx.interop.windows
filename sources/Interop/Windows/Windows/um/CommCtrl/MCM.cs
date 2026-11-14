// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MCM
{
    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_FIRST"]/*' />
    [NativeTypeName("#define MCM_FIRST 0x1000")]
    public const int MCM_FIRST = 0x1000;

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETCURSEL"]/*' />
    [NativeTypeName("#define MCM_GETCURSEL (MCM_FIRST + 1)")]
    public const int MCM_GETCURSEL = (0x1000 + 1);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_SETCURSEL"]/*' />
    [NativeTypeName("#define MCM_SETCURSEL (MCM_FIRST + 2)")]
    public const int MCM_SETCURSEL = (0x1000 + 2);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETMAXSELCOUNT"]/*' />
    [NativeTypeName("#define MCM_GETMAXSELCOUNT (MCM_FIRST + 3)")]
    public const int MCM_GETMAXSELCOUNT = (0x1000 + 3);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_SETMAXSELCOUNT"]/*' />
    [NativeTypeName("#define MCM_SETMAXSELCOUNT (MCM_FIRST + 4)")]
    public const int MCM_SETMAXSELCOUNT = (0x1000 + 4);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETSELRANGE"]/*' />
    [NativeTypeName("#define MCM_GETSELRANGE (MCM_FIRST + 5)")]
    public const int MCM_GETSELRANGE = (0x1000 + 5);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_SETSELRANGE"]/*' />
    [NativeTypeName("#define MCM_SETSELRANGE (MCM_FIRST + 6)")]
    public const int MCM_SETSELRANGE = (0x1000 + 6);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETMONTHRANGE"]/*' />
    [NativeTypeName("#define MCM_GETMONTHRANGE (MCM_FIRST + 7)")]
    public const int MCM_GETMONTHRANGE = (0x1000 + 7);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_SETDAYSTATE"]/*' />
    [NativeTypeName("#define MCM_SETDAYSTATE (MCM_FIRST + 8)")]
    public const int MCM_SETDAYSTATE = (0x1000 + 8);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETMINREQRECT"]/*' />
    [NativeTypeName("#define MCM_GETMINREQRECT (MCM_FIRST + 9)")]
    public const int MCM_GETMINREQRECT = (0x1000 + 9);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_SETCOLOR"]/*' />
    [NativeTypeName("#define MCM_SETCOLOR (MCM_FIRST + 10)")]
    public const int MCM_SETCOLOR = (0x1000 + 10);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETCOLOR"]/*' />
    [NativeTypeName("#define MCM_GETCOLOR (MCM_FIRST + 11)")]
    public const int MCM_GETCOLOR = (0x1000 + 11);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_SETTODAY"]/*' />
    [NativeTypeName("#define MCM_SETTODAY (MCM_FIRST + 12)")]
    public const int MCM_SETTODAY = (0x1000 + 12);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETTODAY"]/*' />
    [NativeTypeName("#define MCM_GETTODAY (MCM_FIRST + 13)")]
    public const int MCM_GETTODAY = (0x1000 + 13);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_HITTEST"]/*' />
    [NativeTypeName("#define MCM_HITTEST (MCM_FIRST + 14)")]
    public const int MCM_HITTEST = (0x1000 + 14);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_SETFIRSTDAYOFWEEK"]/*' />
    [NativeTypeName("#define MCM_SETFIRSTDAYOFWEEK (MCM_FIRST + 15)")]
    public const int MCM_SETFIRSTDAYOFWEEK = (0x1000 + 15);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETFIRSTDAYOFWEEK"]/*' />
    [NativeTypeName("#define MCM_GETFIRSTDAYOFWEEK (MCM_FIRST + 16)")]
    public const int MCM_GETFIRSTDAYOFWEEK = (0x1000 + 16);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETRANGE"]/*' />
    [NativeTypeName("#define MCM_GETRANGE (MCM_FIRST + 17)")]
    public const int MCM_GETRANGE = (0x1000 + 17);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_SETRANGE"]/*' />
    [NativeTypeName("#define MCM_SETRANGE (MCM_FIRST + 18)")]
    public const int MCM_SETRANGE = (0x1000 + 18);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETMONTHDELTA"]/*' />
    [NativeTypeName("#define MCM_GETMONTHDELTA (MCM_FIRST + 19)")]
    public const int MCM_GETMONTHDELTA = (0x1000 + 19);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_SETMONTHDELTA"]/*' />
    [NativeTypeName("#define MCM_SETMONTHDELTA (MCM_FIRST + 20)")]
    public const int MCM_SETMONTHDELTA = (0x1000 + 20);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETMAXTODAYWIDTH"]/*' />
    [NativeTypeName("#define MCM_GETMAXTODAYWIDTH (MCM_FIRST + 21)")]
    public const int MCM_GETMAXTODAYWIDTH = (0x1000 + 21);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_SETUNICODEFORMAT"]/*' />
    [NativeTypeName("#define MCM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
    public const int MCM_SETUNICODEFORMAT = (0x2000 + 5);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETUNICODEFORMAT"]/*' />
    [NativeTypeName("#define MCM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
    public const int MCM_GETUNICODEFORMAT = (0x2000 + 6);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETCURRENTVIEW"]/*' />
    [NativeTypeName("#define MCM_GETCURRENTVIEW (MCM_FIRST + 22)")]
    public const int MCM_GETCURRENTVIEW = (0x1000 + 22);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETCALENDARCOUNT"]/*' />
    [NativeTypeName("#define MCM_GETCALENDARCOUNT (MCM_FIRST + 23)")]
    public const int MCM_GETCALENDARCOUNT = (0x1000 + 23);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETCALENDARGRIDINFO"]/*' />
    [NativeTypeName("#define MCM_GETCALENDARGRIDINFO (MCM_FIRST + 24)")]
    public const int MCM_GETCALENDARGRIDINFO = (0x1000 + 24);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETCALID"]/*' />
    [NativeTypeName("#define MCM_GETCALID (MCM_FIRST + 27)")]
    public const int MCM_GETCALID = (0x1000 + 27);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_SETCALID"]/*' />
    [NativeTypeName("#define MCM_SETCALID (MCM_FIRST + 28)")]
    public const int MCM_SETCALID = (0x1000 + 28);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_SIZERECTTOMIN"]/*' />
    [NativeTypeName("#define MCM_SIZERECTTOMIN (MCM_FIRST + 29)")]
    public const int MCM_SIZERECTTOMIN = (0x1000 + 29);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_SETCALENDARBORDER"]/*' />
    [NativeTypeName("#define MCM_SETCALENDARBORDER (MCM_FIRST + 30)")]
    public const int MCM_SETCALENDARBORDER = (0x1000 + 30);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_GETCALENDARBORDER"]/*' />
    [NativeTypeName("#define MCM_GETCALENDARBORDER (MCM_FIRST + 31)")]
    public const int MCM_GETCALENDARBORDER = (0x1000 + 31);

    /// <include file='MCM.xml' path='doc/member[@name="MCM.MCM_SETCURRENTVIEW"]/*' />
    [NativeTypeName("#define MCM_SETCURRENTVIEW (MCM_FIRST + 32)")]
    public const int MCM_SETCURRENTVIEW = (0x1000 + 32);
}
