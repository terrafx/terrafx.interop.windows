// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SB
{
    /// <include file='SB.xml' path='doc/member[@name="SB.SB_SETTEXTA"]/*' />
    [NativeTypeName("#define SB_SETTEXTA (WM_USER+1)")]
    public const int SB_SETTEXTA = (0x0400 + 1);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_SETTEXTW"]/*' />
    [NativeTypeName("#define SB_SETTEXTW (WM_USER+11)")]
    public const int SB_SETTEXTW = (0x0400 + 11);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GETTEXTA"]/*' />
    [NativeTypeName("#define SB_GETTEXTA (WM_USER+2)")]
    public const int SB_GETTEXTA = (0x0400 + 2);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GETTEXTW"]/*' />
    [NativeTypeName("#define SB_GETTEXTW (WM_USER+13)")]
    public const int SB_GETTEXTW = (0x0400 + 13);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GETTEXTLENGTHA"]/*' />
    [NativeTypeName("#define SB_GETTEXTLENGTHA (WM_USER+3)")]
    public const int SB_GETTEXTLENGTHA = (0x0400 + 3);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GETTEXTLENGTHW"]/*' />
    [NativeTypeName("#define SB_GETTEXTLENGTHW (WM_USER+12)")]
    public const int SB_GETTEXTLENGTHW = (0x0400 + 12);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GETTEXT"]/*' />
    [NativeTypeName("#define SB_GETTEXT SB_GETTEXTW")]
    public const int SB_GETTEXT = (0x0400 + 13);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_SETTEXT"]/*' />
    [NativeTypeName("#define SB_SETTEXT SB_SETTEXTW")]
    public const int SB_SETTEXT = (0x0400 + 11);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GETTEXTLENGTH"]/*' />
    [NativeTypeName("#define SB_GETTEXTLENGTH SB_GETTEXTLENGTHW")]
    public const int SB_GETTEXTLENGTH = (0x0400 + 12);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_SETTIPTEXT"]/*' />
    [NativeTypeName("#define SB_SETTIPTEXT SB_SETTIPTEXTW")]
    public const int SB_SETTIPTEXT = (0x0400 + 17);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GETTIPTEXT"]/*' />
    [NativeTypeName("#define SB_GETTIPTEXT SB_GETTIPTEXTW")]
    public const int SB_GETTIPTEXT = (0x0400 + 19);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_SETPARTS"]/*' />
    [NativeTypeName("#define SB_SETPARTS (WM_USER+4)")]
    public const int SB_SETPARTS = (0x0400 + 4);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GETPARTS"]/*' />
    [NativeTypeName("#define SB_GETPARTS (WM_USER+6)")]
    public const int SB_GETPARTS = (0x0400 + 6);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GETBORDERS"]/*' />
    [NativeTypeName("#define SB_GETBORDERS (WM_USER+7)")]
    public const int SB_GETBORDERS = (0x0400 + 7);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_SETMINHEIGHT"]/*' />
    [NativeTypeName("#define SB_SETMINHEIGHT (WM_USER+8)")]
    public const int SB_SETMINHEIGHT = (0x0400 + 8);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_SIMPLE"]/*' />
    [NativeTypeName("#define SB_SIMPLE (WM_USER+9)")]
    public const int SB_SIMPLE = (0x0400 + 9);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GETRECT"]/*' />
    [NativeTypeName("#define SB_GETRECT (WM_USER+10)")]
    public const int SB_GETRECT = (0x0400 + 10);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_ISSIMPLE"]/*' />
    [NativeTypeName("#define SB_ISSIMPLE (WM_USER+14)")]
    public const int SB_ISSIMPLE = (0x0400 + 14);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_SETICON"]/*' />
    [NativeTypeName("#define SB_SETICON (WM_USER+15)")]
    public const int SB_SETICON = (0x0400 + 15);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_SETTIPTEXTA"]/*' />
    [NativeTypeName("#define SB_SETTIPTEXTA (WM_USER+16)")]
    public const int SB_SETTIPTEXTA = (0x0400 + 16);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_SETTIPTEXTW"]/*' />
    [NativeTypeName("#define SB_SETTIPTEXTW (WM_USER+17)")]
    public const int SB_SETTIPTEXTW = (0x0400 + 17);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GETTIPTEXTA"]/*' />
    [NativeTypeName("#define SB_GETTIPTEXTA (WM_USER+18)")]
    public const int SB_GETTIPTEXTA = (0x0400 + 18);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GETTIPTEXTW"]/*' />
    [NativeTypeName("#define SB_GETTIPTEXTW (WM_USER+19)")]
    public const int SB_GETTIPTEXTW = (0x0400 + 19);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GETICON"]/*' />
    [NativeTypeName("#define SB_GETICON (WM_USER+20)")]
    public const int SB_GETICON = (0x0400 + 20);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_SETUNICODEFORMAT"]/*' />
    [NativeTypeName("#define SB_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
    public const int SB_SETUNICODEFORMAT = (0x2000 + 5);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GETUNICODEFORMAT"]/*' />
    [NativeTypeName("#define SB_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
    public const int SB_GETUNICODEFORMAT = (0x2000 + 6);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_SETBKCOLOR"]/*' />
    [NativeTypeName("#define SB_SETBKCOLOR CCM_SETBKCOLOR")]
    public const int SB_SETBKCOLOR = (0x2000 + 1);

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_SIMPLEID"]/*' />
    [NativeTypeName("#define SB_SIMPLEID 0x00ff")]
    public const int SB_SIMPLEID = 0x00ff;
}
