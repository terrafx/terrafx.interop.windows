// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TBM
{
    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETPOS"]/*' />
    [NativeTypeName("#define TBM_GETPOS (WM_USER)")]
    public const int TBM_GETPOS = (0x0400);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETRANGEMIN"]/*' />
    [NativeTypeName("#define TBM_GETRANGEMIN (WM_USER+1)")]
    public const int TBM_GETRANGEMIN = (0x0400 + 1);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETRANGEMAX"]/*' />
    [NativeTypeName("#define TBM_GETRANGEMAX (WM_USER+2)")]
    public const int TBM_GETRANGEMAX = (0x0400 + 2);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETTIC"]/*' />
    [NativeTypeName("#define TBM_GETTIC (WM_USER+3)")]
    public const int TBM_GETTIC = (0x0400 + 3);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETTIC"]/*' />
    [NativeTypeName("#define TBM_SETTIC (WM_USER+4)")]
    public const int TBM_SETTIC = (0x0400 + 4);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETPOS"]/*' />
    [NativeTypeName("#define TBM_SETPOS (WM_USER+5)")]
    public const int TBM_SETPOS = (0x0400 + 5);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETRANGE"]/*' />
    [NativeTypeName("#define TBM_SETRANGE (WM_USER+6)")]
    public const int TBM_SETRANGE = (0x0400 + 6);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETRANGEMIN"]/*' />
    [NativeTypeName("#define TBM_SETRANGEMIN (WM_USER+7)")]
    public const int TBM_SETRANGEMIN = (0x0400 + 7);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETRANGEMAX"]/*' />
    [NativeTypeName("#define TBM_SETRANGEMAX (WM_USER+8)")]
    public const int TBM_SETRANGEMAX = (0x0400 + 8);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_CLEARTICS"]/*' />
    [NativeTypeName("#define TBM_CLEARTICS (WM_USER+9)")]
    public const int TBM_CLEARTICS = (0x0400 + 9);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETSEL"]/*' />
    [NativeTypeName("#define TBM_SETSEL (WM_USER+10)")]
    public const int TBM_SETSEL = (0x0400 + 10);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETSELSTART"]/*' />
    [NativeTypeName("#define TBM_SETSELSTART (WM_USER+11)")]
    public const int TBM_SETSELSTART = (0x0400 + 11);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETSELEND"]/*' />
    [NativeTypeName("#define TBM_SETSELEND (WM_USER+12)")]
    public const int TBM_SETSELEND = (0x0400 + 12);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETPTICS"]/*' />
    [NativeTypeName("#define TBM_GETPTICS (WM_USER+14)")]
    public const int TBM_GETPTICS = (0x0400 + 14);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETTICPOS"]/*' />
    [NativeTypeName("#define TBM_GETTICPOS (WM_USER+15)")]
    public const int TBM_GETTICPOS = (0x0400 + 15);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETNUMTICS"]/*' />
    [NativeTypeName("#define TBM_GETNUMTICS (WM_USER+16)")]
    public const int TBM_GETNUMTICS = (0x0400 + 16);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETSELSTART"]/*' />
    [NativeTypeName("#define TBM_GETSELSTART (WM_USER+17)")]
    public const int TBM_GETSELSTART = (0x0400 + 17);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETSELEND"]/*' />
    [NativeTypeName("#define TBM_GETSELEND (WM_USER+18)")]
    public const int TBM_GETSELEND = (0x0400 + 18);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_CLEARSEL"]/*' />
    [NativeTypeName("#define TBM_CLEARSEL (WM_USER+19)")]
    public const int TBM_CLEARSEL = (0x0400 + 19);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETTICFREQ"]/*' />
    [NativeTypeName("#define TBM_SETTICFREQ (WM_USER+20)")]
    public const int TBM_SETTICFREQ = (0x0400 + 20);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETPAGESIZE"]/*' />
    [NativeTypeName("#define TBM_SETPAGESIZE (WM_USER+21)")]
    public const int TBM_SETPAGESIZE = (0x0400 + 21);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETPAGESIZE"]/*' />
    [NativeTypeName("#define TBM_GETPAGESIZE (WM_USER+22)")]
    public const int TBM_GETPAGESIZE = (0x0400 + 22);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETLINESIZE"]/*' />
    [NativeTypeName("#define TBM_SETLINESIZE (WM_USER+23)")]
    public const int TBM_SETLINESIZE = (0x0400 + 23);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETLINESIZE"]/*' />
    [NativeTypeName("#define TBM_GETLINESIZE (WM_USER+24)")]
    public const int TBM_GETLINESIZE = (0x0400 + 24);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETTHUMBRECT"]/*' />
    [NativeTypeName("#define TBM_GETTHUMBRECT (WM_USER+25)")]
    public const int TBM_GETTHUMBRECT = (0x0400 + 25);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETCHANNELRECT"]/*' />
    [NativeTypeName("#define TBM_GETCHANNELRECT (WM_USER+26)")]
    public const int TBM_GETCHANNELRECT = (0x0400 + 26);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETTHUMBLENGTH"]/*' />
    [NativeTypeName("#define TBM_SETTHUMBLENGTH (WM_USER+27)")]
    public const int TBM_SETTHUMBLENGTH = (0x0400 + 27);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETTHUMBLENGTH"]/*' />
    [NativeTypeName("#define TBM_GETTHUMBLENGTH (WM_USER+28)")]
    public const int TBM_GETTHUMBLENGTH = (0x0400 + 28);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETTOOLTIPS"]/*' />
    [NativeTypeName("#define TBM_SETTOOLTIPS (WM_USER+29)")]
    public const int TBM_SETTOOLTIPS = (0x0400 + 29);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETTOOLTIPS"]/*' />
    [NativeTypeName("#define TBM_GETTOOLTIPS (WM_USER+30)")]
    public const int TBM_GETTOOLTIPS = (0x0400 + 30);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETTIPSIDE"]/*' />
    [NativeTypeName("#define TBM_SETTIPSIDE (WM_USER+31)")]
    public const int TBM_SETTIPSIDE = (0x0400 + 31);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETBUDDY"]/*' />
    [NativeTypeName("#define TBM_SETBUDDY (WM_USER+32)")]
    public const int TBM_SETBUDDY = (0x0400 + 32);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETBUDDY"]/*' />
    [NativeTypeName("#define TBM_GETBUDDY (WM_USER+33)")]
    public const int TBM_GETBUDDY = (0x0400 + 33);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETPOSNOTIFY"]/*' />
    [NativeTypeName("#define TBM_SETPOSNOTIFY (WM_USER+34)")]
    public const int TBM_SETPOSNOTIFY = (0x0400 + 34);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_SETUNICODEFORMAT"]/*' />
    [NativeTypeName("#define TBM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
    public const int TBM_SETUNICODEFORMAT = (0x2000 + 5);

    /// <include file='TBM.xml' path='doc/member[@name="TBM.TBM_GETUNICODEFORMAT"]/*' />
    [NativeTypeName("#define TBM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
    public const int TBM_GETUNICODEFORMAT = (0x2000 + 6);
}
