// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TBS
{
    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_AUTOTICKS"]/*' />
    [NativeTypeName("#define TBS_AUTOTICKS 0x0001")]
    public const int TBS_AUTOTICKS = 0x0001;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_VERT"]/*' />
    [NativeTypeName("#define TBS_VERT 0x0002")]
    public const int TBS_VERT = 0x0002;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_HORZ"]/*' />
    [NativeTypeName("#define TBS_HORZ 0x0000")]
    public const int TBS_HORZ = 0x0000;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_TOP"]/*' />
    [NativeTypeName("#define TBS_TOP 0x0004")]
    public const int TBS_TOP = 0x0004;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_BOTTOM"]/*' />
    [NativeTypeName("#define TBS_BOTTOM 0x0000")]
    public const int TBS_BOTTOM = 0x0000;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_LEFT"]/*' />
    [NativeTypeName("#define TBS_LEFT 0x0004")]
    public const int TBS_LEFT = 0x0004;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_RIGHT"]/*' />
    [NativeTypeName("#define TBS_RIGHT 0x0000")]
    public const int TBS_RIGHT = 0x0000;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_BOTH"]/*' />
    [NativeTypeName("#define TBS_BOTH 0x0008")]
    public const int TBS_BOTH = 0x0008;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_NOTICKS"]/*' />
    [NativeTypeName("#define TBS_NOTICKS 0x0010")]
    public const int TBS_NOTICKS = 0x0010;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_ENABLESELRANGE"]/*' />
    [NativeTypeName("#define TBS_ENABLESELRANGE 0x0020")]
    public const int TBS_ENABLESELRANGE = 0x0020;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_FIXEDLENGTH"]/*' />
    [NativeTypeName("#define TBS_FIXEDLENGTH 0x0040")]
    public const int TBS_FIXEDLENGTH = 0x0040;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_NOTHUMB"]/*' />
    [NativeTypeName("#define TBS_NOTHUMB 0x0080")]
    public const int TBS_NOTHUMB = 0x0080;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_TOOLTIPS"]/*' />
    [NativeTypeName("#define TBS_TOOLTIPS 0x0100")]
    public const int TBS_TOOLTIPS = 0x0100;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_REVERSED"]/*' />
    [NativeTypeName("#define TBS_REVERSED 0x0200")]
    public const int TBS_REVERSED = 0x0200;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_DOWNISLEFT"]/*' />
    [NativeTypeName("#define TBS_DOWNISLEFT 0x0400")]
    public const int TBS_DOWNISLEFT = 0x0400;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_NOTIFYBEFOREMOVE"]/*' />
    [NativeTypeName("#define TBS_NOTIFYBEFOREMOVE 0x0800")]
    public const int TBS_NOTIFYBEFOREMOVE = 0x0800;

    /// <include file='TBS.xml' path='doc/member[@name="TBS.TBS_TRANSPARENTBKGND"]/*' />
    [NativeTypeName("#define TBS_TRANSPARENTBKGND 0x1000")]
    public const int TBS_TRANSPARENTBKGND = 0x1000;
}
