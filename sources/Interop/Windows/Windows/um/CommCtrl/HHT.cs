// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class HHT
{
    /// <include file='HHT.xml' path='doc/member[@name="HHT.HHT_NOWHERE"]/*' />
    [NativeTypeName("#define HHT_NOWHERE 0x0001")]
    public const int HHT_NOWHERE = 0x0001;

    /// <include file='HHT.xml' path='doc/member[@name="HHT.HHT_ONHEADER"]/*' />
    [NativeTypeName("#define HHT_ONHEADER 0x0002")]
    public const int HHT_ONHEADER = 0x0002;

    /// <include file='HHT.xml' path='doc/member[@name="HHT.HHT_ONDIVIDER"]/*' />
    [NativeTypeName("#define HHT_ONDIVIDER 0x0004")]
    public const int HHT_ONDIVIDER = 0x0004;

    /// <include file='HHT.xml' path='doc/member[@name="HHT.HHT_ONDIVOPEN"]/*' />
    [NativeTypeName("#define HHT_ONDIVOPEN 0x0008")]
    public const int HHT_ONDIVOPEN = 0x0008;

    /// <include file='HHT.xml' path='doc/member[@name="HHT.HHT_ONFILTER"]/*' />
    [NativeTypeName("#define HHT_ONFILTER 0x0010")]
    public const int HHT_ONFILTER = 0x0010;

    /// <include file='HHT.xml' path='doc/member[@name="HHT.HHT_ONFILTERBUTTON"]/*' />
    [NativeTypeName("#define HHT_ONFILTERBUTTON 0x0020")]
    public const int HHT_ONFILTERBUTTON = 0x0020;

    /// <include file='HHT.xml' path='doc/member[@name="HHT.HHT_ABOVE"]/*' />
    [NativeTypeName("#define HHT_ABOVE 0x0100")]
    public const int HHT_ABOVE = 0x0100;

    /// <include file='HHT.xml' path='doc/member[@name="HHT.HHT_BELOW"]/*' />
    [NativeTypeName("#define HHT_BELOW 0x0200")]
    public const int HHT_BELOW = 0x0200;

    /// <include file='HHT.xml' path='doc/member[@name="HHT.HHT_TORIGHT"]/*' />
    [NativeTypeName("#define HHT_TORIGHT 0x0400")]
    public const int HHT_TORIGHT = 0x0400;

    /// <include file='HHT.xml' path='doc/member[@name="HHT.HHT_TOLEFT"]/*' />
    [NativeTypeName("#define HHT_TOLEFT 0x0800")]
    public const int HHT_TOLEFT = 0x0800;

    /// <include file='HHT.xml' path='doc/member[@name="HHT.HHT_ONITEMSTATEICON"]/*' />
    [NativeTypeName("#define HHT_ONITEMSTATEICON 0x1000")]
    public const int HHT_ONITEMSTATEICON = 0x1000;

    /// <include file='HHT.xml' path='doc/member[@name="HHT.HHT_ONDROPDOWN"]/*' />
    [NativeTypeName("#define HHT_ONDROPDOWN 0x2000")]
    public const int HHT_ONDROPDOWN = 0x2000;

    /// <include file='HHT.xml' path='doc/member[@name="HHT.HHT_ONOVERFLOW"]/*' />
    [NativeTypeName("#define HHT_ONOVERFLOW 0x4000")]
    public const int HHT_ONOVERFLOW = 0x4000;
}
