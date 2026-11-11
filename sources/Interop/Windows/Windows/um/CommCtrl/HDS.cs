// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class HDS
{
    /// <include file='HDS.xml' path='doc/member[@name="HDS.HDS_HORZ"]/*' />
    [NativeTypeName("#define HDS_HORZ 0x0000")]
    public const int HDS_HORZ = 0x0000;

    /// <include file='HDS.xml' path='doc/member[@name="HDS.HDS_BUTTONS"]/*' />
    [NativeTypeName("#define HDS_BUTTONS 0x0002")]
    public const int HDS_BUTTONS = 0x0002;

    /// <include file='HDS.xml' path='doc/member[@name="HDS.HDS_HOTTRACK"]/*' />
    [NativeTypeName("#define HDS_HOTTRACK 0x0004")]
    public const int HDS_HOTTRACK = 0x0004;

    /// <include file='HDS.xml' path='doc/member[@name="HDS.HDS_HIDDEN"]/*' />
    [NativeTypeName("#define HDS_HIDDEN 0x0008")]
    public const int HDS_HIDDEN = 0x0008;

    /// <include file='HDS.xml' path='doc/member[@name="HDS.HDS_DRAGDROP"]/*' />
    [NativeTypeName("#define HDS_DRAGDROP 0x0040")]
    public const int HDS_DRAGDROP = 0x0040;

    /// <include file='HDS.xml' path='doc/member[@name="HDS.HDS_FULLDRAG"]/*' />
    [NativeTypeName("#define HDS_FULLDRAG 0x0080")]
    public const int HDS_FULLDRAG = 0x0080;

    /// <include file='HDS.xml' path='doc/member[@name="HDS.HDS_FILTERBAR"]/*' />
    [NativeTypeName("#define HDS_FILTERBAR 0x0100")]
    public const int HDS_FILTERBAR = 0x0100;

    /// <include file='HDS.xml' path='doc/member[@name="HDS.HDS_FLAT"]/*' />
    [NativeTypeName("#define HDS_FLAT 0x0200")]
    public const int HDS_FLAT = 0x0200;

    /// <include file='HDS.xml' path='doc/member[@name="HDS.HDS_CHECKBOXES"]/*' />
    [NativeTypeName("#define HDS_CHECKBOXES 0x0400")]
    public const int HDS_CHECKBOXES = 0x0400;

    /// <include file='HDS.xml' path='doc/member[@name="HDS.HDS_NOSIZING"]/*' />
    [NativeTypeName("#define HDS_NOSIZING 0x0800")]
    public const int HDS_NOSIZING = 0x0800;

    /// <include file='HDS.xml' path='doc/member[@name="HDS.HDS_OVERFLOW"]/*' />
    [NativeTypeName("#define HDS_OVERFLOW 0x1000")]
    public const int HDS_OVERFLOW = 0x1000;
}
