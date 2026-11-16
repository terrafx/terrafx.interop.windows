// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MCHT
{
    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_TITLE"]/*' />
    [NativeTypeName("#define MCHT_TITLE 0x00010000")]
    public const int MCHT_TITLE = 0x00010000;

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_CALENDAR"]/*' />
    [NativeTypeName("#define MCHT_CALENDAR 0x00020000")]
    public const int MCHT_CALENDAR = 0x00020000;

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_TODAYLINK"]/*' />
    [NativeTypeName("#define MCHT_TODAYLINK 0x00030000")]
    public const int MCHT_TODAYLINK = 0x00030000;

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_CALENDARCONTROL"]/*' />
    [NativeTypeName("#define MCHT_CALENDARCONTROL 0x00100000")]
    public const int MCHT_CALENDARCONTROL = 0x00100000;

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_NEXT"]/*' />
    [NativeTypeName("#define MCHT_NEXT 0x01000000")]
    public const int MCHT_NEXT = 0x01000000;

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_PREV"]/*' />
    [NativeTypeName("#define MCHT_PREV 0x02000000")]
    public const int MCHT_PREV = 0x02000000;

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_NOWHERE"]/*' />
    [NativeTypeName("#define MCHT_NOWHERE 0x00000000")]
    public const int MCHT_NOWHERE = 0x00000000;

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_TITLEBK"]/*' />
    [NativeTypeName("#define MCHT_TITLEBK (MCHT_TITLE)")]
    public const int MCHT_TITLEBK = (0x00010000);

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_TITLEMONTH"]/*' />
    [NativeTypeName("#define MCHT_TITLEMONTH (MCHT_TITLE | 0x0001)")]
    public const int MCHT_TITLEMONTH = (0x00010000 | 0x0001);

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_TITLEYEAR"]/*' />
    [NativeTypeName("#define MCHT_TITLEYEAR (MCHT_TITLE | 0x0002)")]
    public const int MCHT_TITLEYEAR = (0x00010000 | 0x0002);

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_TITLEBTNNEXT"]/*' />
    [NativeTypeName("#define MCHT_TITLEBTNNEXT (MCHT_TITLE | MCHT_NEXT | 0x0003)")]
    public const int MCHT_TITLEBTNNEXT = (0x00010000 | 0x01000000 | 0x0003);

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_TITLEBTNPREV"]/*' />
    [NativeTypeName("#define MCHT_TITLEBTNPREV (MCHT_TITLE | MCHT_PREV | 0x0003)")]
    public const int MCHT_TITLEBTNPREV = (0x00010000 | 0x02000000 | 0x0003);

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_CALENDARBK"]/*' />
    [NativeTypeName("#define MCHT_CALENDARBK (MCHT_CALENDAR)")]
    public const int MCHT_CALENDARBK = (0x00020000);

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_CALENDARDATE"]/*' />
    [NativeTypeName("#define MCHT_CALENDARDATE (MCHT_CALENDAR | 0x0001)")]
    public const int MCHT_CALENDARDATE = (0x00020000 | 0x0001);

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_CALENDARDATENEXT"]/*' />
    [NativeTypeName("#define MCHT_CALENDARDATENEXT (MCHT_CALENDARDATE | MCHT_NEXT)")]
    public const int MCHT_CALENDARDATENEXT = ((0x00020000 | 0x0001) | 0x01000000);

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_CALENDARDATEPREV"]/*' />
    [NativeTypeName("#define MCHT_CALENDARDATEPREV (MCHT_CALENDARDATE | MCHT_PREV)")]
    public const int MCHT_CALENDARDATEPREV = ((0x00020000 | 0x0001) | 0x02000000);

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_CALENDARDAY"]/*' />
    [NativeTypeName("#define MCHT_CALENDARDAY (MCHT_CALENDAR | 0x0002)")]
    public const int MCHT_CALENDARDAY = (0x00020000 | 0x0002);

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_CALENDARWEEKNUM"]/*' />
    [NativeTypeName("#define MCHT_CALENDARWEEKNUM (MCHT_CALENDAR | 0x0003)")]
    public const int MCHT_CALENDARWEEKNUM = (0x00020000 | 0x0003);

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_CALENDARDATEMIN"]/*' />
    [NativeTypeName("#define MCHT_CALENDARDATEMIN (MCHT_CALENDAR | 0x0004)")]
    public const int MCHT_CALENDARDATEMIN = (0x00020000 | 0x0004);

    /// <include file='MCHT.xml' path='doc/member[@name="MCHT.MCHT_CALENDARDATEMAX"]/*' />
    [NativeTypeName("#define MCHT_CALENDARDATEMAX (MCHT_CALENDAR | 0x0005)")]
    public const int MCHT_CALENDARDATEMAX = (0x00020000 | 0x0005);
}
