// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TVS
{
    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_HASBUTTONS"]/*' />
    [NativeTypeName("#define TVS_HASBUTTONS 0x0001")]
    public const int TVS_HASBUTTONS = 0x0001;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_HASLINES"]/*' />
    [NativeTypeName("#define TVS_HASLINES 0x0002")]
    public const int TVS_HASLINES = 0x0002;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_LINESATROOT"]/*' />
    [NativeTypeName("#define TVS_LINESATROOT 0x0004")]
    public const int TVS_LINESATROOT = 0x0004;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_EDITLABELS"]/*' />
    [NativeTypeName("#define TVS_EDITLABELS 0x0008")]
    public const int TVS_EDITLABELS = 0x0008;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_DISABLEDRAGDROP"]/*' />
    [NativeTypeName("#define TVS_DISABLEDRAGDROP 0x0010")]
    public const int TVS_DISABLEDRAGDROP = 0x0010;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_SHOWSELALWAYS"]/*' />
    [NativeTypeName("#define TVS_SHOWSELALWAYS 0x0020")]
    public const int TVS_SHOWSELALWAYS = 0x0020;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_RTLREADING"]/*' />
    [NativeTypeName("#define TVS_RTLREADING 0x0040")]
    public const int TVS_RTLREADING = 0x0040;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_NOTOOLTIPS"]/*' />
    [NativeTypeName("#define TVS_NOTOOLTIPS 0x0080")]
    public const int TVS_NOTOOLTIPS = 0x0080;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_CHECKBOXES"]/*' />
    [NativeTypeName("#define TVS_CHECKBOXES 0x0100")]
    public const int TVS_CHECKBOXES = 0x0100;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_TRACKSELECT"]/*' />
    [NativeTypeName("#define TVS_TRACKSELECT 0x0200")]
    public const int TVS_TRACKSELECT = 0x0200;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_SINGLEEXPAND"]/*' />
    [NativeTypeName("#define TVS_SINGLEEXPAND 0x0400")]
    public const int TVS_SINGLEEXPAND = 0x0400;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_INFOTIP"]/*' />
    [NativeTypeName("#define TVS_INFOTIP 0x0800")]
    public const int TVS_INFOTIP = 0x0800;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_FULLROWSELECT"]/*' />
    [NativeTypeName("#define TVS_FULLROWSELECT 0x1000")]
    public const int TVS_FULLROWSELECT = 0x1000;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_NOSCROLL"]/*' />
    [NativeTypeName("#define TVS_NOSCROLL 0x2000")]
    public const int TVS_NOSCROLL = 0x2000;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_NONEVENHEIGHT"]/*' />
    [NativeTypeName("#define TVS_NONEVENHEIGHT 0x4000")]
    public const int TVS_NONEVENHEIGHT = 0x4000;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_NOHSCROLL"]/*' />
    [NativeTypeName("#define TVS_NOHSCROLL 0x8000")]
    public const int TVS_NOHSCROLL = 0x8000;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_EX_NOSINGLECOLLAPSE"]/*' />
    [NativeTypeName("#define TVS_EX_NOSINGLECOLLAPSE 0x0001")]
    public const int TVS_EX_NOSINGLECOLLAPSE = 0x0001;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_EX_MULTISELECT"]/*' />
    [NativeTypeName("#define TVS_EX_MULTISELECT 0x0002")]
    public const int TVS_EX_MULTISELECT = 0x0002;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_EX_DOUBLEBUFFER"]/*' />
    [NativeTypeName("#define TVS_EX_DOUBLEBUFFER 0x0004")]
    public const int TVS_EX_DOUBLEBUFFER = 0x0004;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_EX_NOINDENTSTATE"]/*' />
    [NativeTypeName("#define TVS_EX_NOINDENTSTATE 0x0008")]
    public const int TVS_EX_NOINDENTSTATE = 0x0008;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_EX_RICHTOOLTIP"]/*' />
    [NativeTypeName("#define TVS_EX_RICHTOOLTIP 0x0010")]
    public const int TVS_EX_RICHTOOLTIP = 0x0010;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_EX_AUTOHSCROLL"]/*' />
    [NativeTypeName("#define TVS_EX_AUTOHSCROLL 0x0020")]
    public const int TVS_EX_AUTOHSCROLL = 0x0020;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_EX_FADEINOUTEXPANDOS"]/*' />
    [NativeTypeName("#define TVS_EX_FADEINOUTEXPANDOS 0x0040")]
    public const int TVS_EX_FADEINOUTEXPANDOS = 0x0040;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_EX_PARTIALCHECKBOXES"]/*' />
    [NativeTypeName("#define TVS_EX_PARTIALCHECKBOXES 0x0080")]
    public const int TVS_EX_PARTIALCHECKBOXES = 0x0080;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_EX_EXCLUSIONCHECKBOXES"]/*' />
    [NativeTypeName("#define TVS_EX_EXCLUSIONCHECKBOXES 0x0100")]
    public const int TVS_EX_EXCLUSIONCHECKBOXES = 0x0100;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_EX_DIMMEDCHECKBOXES"]/*' />
    [NativeTypeName("#define TVS_EX_DIMMEDCHECKBOXES 0x0200")]
    public const int TVS_EX_DIMMEDCHECKBOXES = 0x0200;

    /// <include file='TVS.xml' path='doc/member[@name="TVS.TVS_EX_DRAWIMAGEASYNC"]/*' />
    [NativeTypeName("#define TVS_EX_DRAWIMAGEASYNC 0x0400")]
    public const int TVS_EX_DRAWIMAGEASYNC = 0x0400;
}
