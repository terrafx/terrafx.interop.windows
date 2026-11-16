// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SB
{
    /// <include file='SB.xml' path='doc/member[@name="SB.SB_MIN"]/*' />
    [NativeTypeName("#define SB_MIN 0")]
    public const int SB_MIN = 0;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_HORZ"]/*' />
    [NativeTypeName("#define SB_HORZ 0")]
    public const int SB_HORZ = 0;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_VERT"]/*' />
    [NativeTypeName("#define SB_VERT 1")]
    public const int SB_VERT = 1;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_CTL"]/*' />
    [NativeTypeName("#define SB_CTL 2")]
    public const int SB_CTL = 2;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_BOTH"]/*' />
    [NativeTypeName("#define SB_BOTH 3")]
    public const int SB_BOTH = 3;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_LINEUP"]/*' />
    [NativeTypeName("#define SB_LINEUP 0")]
    public const int SB_LINEUP = 0;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_LINELEFT"]/*' />
    [NativeTypeName("#define SB_LINELEFT 0")]
    public const int SB_LINELEFT = 0;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_LINEDOWN"]/*' />
    [NativeTypeName("#define SB_LINEDOWN 1")]
    public const int SB_LINEDOWN = 1;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_LINERIGHT"]/*' />
    [NativeTypeName("#define SB_LINERIGHT 1")]
    public const int SB_LINERIGHT = 1;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_PAGEUP"]/*' />
    [NativeTypeName("#define SB_PAGEUP 2")]
    public const int SB_PAGEUP = 2;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_PAGELEFT"]/*' />
    [NativeTypeName("#define SB_PAGELEFT 2")]
    public const int SB_PAGELEFT = 2;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_PAGEDOWN"]/*' />
    [NativeTypeName("#define SB_PAGEDOWN 3")]
    public const int SB_PAGEDOWN = 3;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_PAGERIGHT"]/*' />
    [NativeTypeName("#define SB_PAGERIGHT 3")]
    public const int SB_PAGERIGHT = 3;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_THUMBPOSITION"]/*' />
    [NativeTypeName("#define SB_THUMBPOSITION 4")]
    public const int SB_THUMBPOSITION = 4;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_THUMBTRACK"]/*' />
    [NativeTypeName("#define SB_THUMBTRACK 5")]
    public const int SB_THUMBTRACK = 5;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_TOP"]/*' />
    [NativeTypeName("#define SB_TOP 6")]
    public const int SB_TOP = 6;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_LEFT"]/*' />
    [NativeTypeName("#define SB_LEFT 6")]
    public const int SB_LEFT = 6;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_BOTTOM"]/*' />
    [NativeTypeName("#define SB_BOTTOM 7")]
    public const int SB_BOTTOM = 7;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_RIGHT"]/*' />
    [NativeTypeName("#define SB_RIGHT 7")]
    public const int SB_RIGHT = 7;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_ENDSCROLL"]/*' />
    [NativeTypeName("#define SB_ENDSCROLL 8")]
    public const int SB_ENDSCROLL = 8;
}
