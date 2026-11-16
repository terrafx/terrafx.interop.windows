// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TCS
{
    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_SCROLLOPPOSITE"]/*' />
    [NativeTypeName("#define TCS_SCROLLOPPOSITE 0x0001")]
    public const int TCS_SCROLLOPPOSITE = 0x0001;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_BOTTOM"]/*' />
    [NativeTypeName("#define TCS_BOTTOM 0x0002")]
    public const int TCS_BOTTOM = 0x0002;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_RIGHT"]/*' />
    [NativeTypeName("#define TCS_RIGHT 0x0002")]
    public const int TCS_RIGHT = 0x0002;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_MULTISELECT"]/*' />
    [NativeTypeName("#define TCS_MULTISELECT 0x0004")]
    public const int TCS_MULTISELECT = 0x0004;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_FLATBUTTONS"]/*' />
    [NativeTypeName("#define TCS_FLATBUTTONS 0x0008")]
    public const int TCS_FLATBUTTONS = 0x0008;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_FORCEICONLEFT"]/*' />
    [NativeTypeName("#define TCS_FORCEICONLEFT 0x0010")]
    public const int TCS_FORCEICONLEFT = 0x0010;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_FORCELABELLEFT"]/*' />
    [NativeTypeName("#define TCS_FORCELABELLEFT 0x0020")]
    public const int TCS_FORCELABELLEFT = 0x0020;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_HOTTRACK"]/*' />
    [NativeTypeName("#define TCS_HOTTRACK 0x0040")]
    public const int TCS_HOTTRACK = 0x0040;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_VERTICAL"]/*' />
    [NativeTypeName("#define TCS_VERTICAL 0x0080")]
    public const int TCS_VERTICAL = 0x0080;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_TABS"]/*' />
    [NativeTypeName("#define TCS_TABS 0x0000")]
    public const int TCS_TABS = 0x0000;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_BUTTONS"]/*' />
    [NativeTypeName("#define TCS_BUTTONS 0x0100")]
    public const int TCS_BUTTONS = 0x0100;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_SINGLELINE"]/*' />
    [NativeTypeName("#define TCS_SINGLELINE 0x0000")]
    public const int TCS_SINGLELINE = 0x0000;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_MULTILINE"]/*' />
    [NativeTypeName("#define TCS_MULTILINE 0x0200")]
    public const int TCS_MULTILINE = 0x0200;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_RIGHTJUSTIFY"]/*' />
    [NativeTypeName("#define TCS_RIGHTJUSTIFY 0x0000")]
    public const int TCS_RIGHTJUSTIFY = 0x0000;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_FIXEDWIDTH"]/*' />
    [NativeTypeName("#define TCS_FIXEDWIDTH 0x0400")]
    public const int TCS_FIXEDWIDTH = 0x0400;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_RAGGEDRIGHT"]/*' />
    [NativeTypeName("#define TCS_RAGGEDRIGHT 0x0800")]
    public const int TCS_RAGGEDRIGHT = 0x0800;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_FOCUSONBUTTONDOWN"]/*' />
    [NativeTypeName("#define TCS_FOCUSONBUTTONDOWN 0x1000")]
    public const int TCS_FOCUSONBUTTONDOWN = 0x1000;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_OWNERDRAWFIXED"]/*' />
    [NativeTypeName("#define TCS_OWNERDRAWFIXED 0x2000")]
    public const int TCS_OWNERDRAWFIXED = 0x2000;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_TOOLTIPS"]/*' />
    [NativeTypeName("#define TCS_TOOLTIPS 0x4000")]
    public const int TCS_TOOLTIPS = 0x4000;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_FOCUSNEVER"]/*' />
    [NativeTypeName("#define TCS_FOCUSNEVER 0x8000")]
    public const int TCS_FOCUSNEVER = 0x8000;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_EX_FLATSEPARATORS"]/*' />
    [NativeTypeName("#define TCS_EX_FLATSEPARATORS 0x00000001")]
    public const int TCS_EX_FLATSEPARATORS = 0x00000001;

    /// <include file='TCS.xml' path='doc/member[@name="TCS.TCS_EX_REGISTERDROP"]/*' />
    [NativeTypeName("#define TCS_EX_REGISTERDROP 0x00000002")]
    public const int TCS_EX_REGISTERDROP = 0x00000002;
}
