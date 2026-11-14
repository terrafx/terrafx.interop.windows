// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TBSTYLE
{
    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_BUTTON"]/*' />
    [NativeTypeName("#define TBSTYLE_BUTTON 0x0000")]
    public const int TBSTYLE_BUTTON = 0x0000;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_SEP"]/*' />
    [NativeTypeName("#define TBSTYLE_SEP 0x0001")]
    public const int TBSTYLE_SEP = 0x0001;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_CHECK"]/*' />
    [NativeTypeName("#define TBSTYLE_CHECK 0x0002")]
    public const int TBSTYLE_CHECK = 0x0002;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_GROUP"]/*' />
    [NativeTypeName("#define TBSTYLE_GROUP 0x0004")]
    public const int TBSTYLE_GROUP = 0x0004;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_CHECKGROUP"]/*' />
    [NativeTypeName("#define TBSTYLE_CHECKGROUP (TBSTYLE_GROUP | TBSTYLE_CHECK)")]
    public const int TBSTYLE_CHECKGROUP = (0x0004 | 0x0002);

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_DROPDOWN"]/*' />
    [NativeTypeName("#define TBSTYLE_DROPDOWN 0x0008")]
    public const int TBSTYLE_DROPDOWN = 0x0008;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_AUTOSIZE"]/*' />
    [NativeTypeName("#define TBSTYLE_AUTOSIZE 0x0010")]
    public const int TBSTYLE_AUTOSIZE = 0x0010;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_NOPREFIX"]/*' />
    [NativeTypeName("#define TBSTYLE_NOPREFIX 0x0020")]
    public const int TBSTYLE_NOPREFIX = 0x0020;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_TOOLTIPS"]/*' />
    [NativeTypeName("#define TBSTYLE_TOOLTIPS 0x0100")]
    public const int TBSTYLE_TOOLTIPS = 0x0100;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_WRAPABLE"]/*' />
    [NativeTypeName("#define TBSTYLE_WRAPABLE 0x0200")]
    public const int TBSTYLE_WRAPABLE = 0x0200;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_ALTDRAG"]/*' />
    [NativeTypeName("#define TBSTYLE_ALTDRAG 0x0400")]
    public const int TBSTYLE_ALTDRAG = 0x0400;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_FLAT"]/*' />
    [NativeTypeName("#define TBSTYLE_FLAT 0x0800")]
    public const int TBSTYLE_FLAT = 0x0800;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_LIST"]/*' />
    [NativeTypeName("#define TBSTYLE_LIST 0x1000")]
    public const int TBSTYLE_LIST = 0x1000;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_CUSTOMERASE"]/*' />
    [NativeTypeName("#define TBSTYLE_CUSTOMERASE 0x2000")]
    public const int TBSTYLE_CUSTOMERASE = 0x2000;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_REGISTERDROP"]/*' />
    [NativeTypeName("#define TBSTYLE_REGISTERDROP 0x4000")]
    public const int TBSTYLE_REGISTERDROP = 0x4000;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_TRANSPARENT"]/*' />
    [NativeTypeName("#define TBSTYLE_TRANSPARENT 0x8000")]
    public const int TBSTYLE_TRANSPARENT = 0x8000;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_EX_DRAWDDARROWS"]/*' />
    [NativeTypeName("#define TBSTYLE_EX_DRAWDDARROWS 0x00000001")]
    public const int TBSTYLE_EX_DRAWDDARROWS = 0x00000001;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_EX_MIXEDBUTTONS"]/*' />
    [NativeTypeName("#define TBSTYLE_EX_MIXEDBUTTONS 0x00000008")]
    public const int TBSTYLE_EX_MIXEDBUTTONS = 0x00000008;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_EX_HIDECLIPPEDBUTTONS"]/*' />
    [NativeTypeName("#define TBSTYLE_EX_HIDECLIPPEDBUTTONS 0x00000010")]
    public const int TBSTYLE_EX_HIDECLIPPEDBUTTONS = 0x00000010;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_EX_MULTICOLUMN"]/*' />
    [NativeTypeName("#define TBSTYLE_EX_MULTICOLUMN 0x00000002")]
    public const int TBSTYLE_EX_MULTICOLUMN = 0x00000002;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_EX_VERTICAL"]/*' />
    [NativeTypeName("#define TBSTYLE_EX_VERTICAL 0x00000004")]
    public const int TBSTYLE_EX_VERTICAL = 0x00000004;

    /// <include file='TBSTYLE.xml' path='doc/member[@name="TBSTYLE.TBSTYLE_EX_DOUBLEBUFFER"]/*' />
    [NativeTypeName("#define TBSTYLE_EX_DOUBLEBUFFER 0x00000080")]
    public const int TBSTYLE_EX_DOUBLEBUFFER = 0x00000080;
}
