// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WVR
{
    /// <include file='WVR.xml' path='doc/member[@name="WVR.WVR_ALIGNTOP"]/*' />
    [NativeTypeName("#define WVR_ALIGNTOP 0x0010")]
    public const int WVR_ALIGNTOP = 0x0010;

    /// <include file='WVR.xml' path='doc/member[@name="WVR.WVR_ALIGNLEFT"]/*' />
    [NativeTypeName("#define WVR_ALIGNLEFT 0x0020")]
    public const int WVR_ALIGNLEFT = 0x0020;

    /// <include file='WVR.xml' path='doc/member[@name="WVR.WVR_ALIGNBOTTOM"]/*' />
    [NativeTypeName("#define WVR_ALIGNBOTTOM 0x0040")]
    public const int WVR_ALIGNBOTTOM = 0x0040;

    /// <include file='WVR.xml' path='doc/member[@name="WVR.WVR_ALIGNRIGHT"]/*' />
    [NativeTypeName("#define WVR_ALIGNRIGHT 0x0080")]
    public const int WVR_ALIGNRIGHT = 0x0080;

    /// <include file='WVR.xml' path='doc/member[@name="WVR.WVR_HREDRAW"]/*' />
    [NativeTypeName("#define WVR_HREDRAW 0x0100")]
    public const int WVR_HREDRAW = 0x0100;

    /// <include file='WVR.xml' path='doc/member[@name="WVR.WVR_VREDRAW"]/*' />
    [NativeTypeName("#define WVR_VREDRAW 0x0200")]
    public const int WVR_VREDRAW = 0x0200;

    /// <include file='WVR.xml' path='doc/member[@name="WVR.WVR_REDRAW"]/*' />
    [NativeTypeName("#define WVR_REDRAW (WVR_HREDRAW | \\\r\n                            WVR_VREDRAW)")]
    public const int WVR_REDRAW = (0x0100 | 0x0200);

    /// <include file='WVR.xml' path='doc/member[@name="WVR.WVR_VALIDRECTS"]/*' />
    [NativeTypeName("#define WVR_VALIDRECTS 0x0400")]
    public const int WVR_VALIDRECTS = 0x0400;
}
