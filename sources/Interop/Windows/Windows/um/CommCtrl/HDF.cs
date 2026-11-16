// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class HDF
{
    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_LEFT"]/*' />
    [NativeTypeName("#define HDF_LEFT 0x0000")]
    public const int HDF_LEFT = 0x0000;

    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_RIGHT"]/*' />
    [NativeTypeName("#define HDF_RIGHT 0x0001")]
    public const int HDF_RIGHT = 0x0001;

    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_CENTER"]/*' />
    [NativeTypeName("#define HDF_CENTER 0x0002")]
    public const int HDF_CENTER = 0x0002;

    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_JUSTIFYMASK"]/*' />
    [NativeTypeName("#define HDF_JUSTIFYMASK 0x0003")]
    public const int HDF_JUSTIFYMASK = 0x0003;

    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_RTLREADING"]/*' />
    [NativeTypeName("#define HDF_RTLREADING 0x0004")]
    public const int HDF_RTLREADING = 0x0004;

    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_BITMAP"]/*' />
    [NativeTypeName("#define HDF_BITMAP 0x2000")]
    public const int HDF_BITMAP = 0x2000;

    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_STRING"]/*' />
    [NativeTypeName("#define HDF_STRING 0x4000")]
    public const int HDF_STRING = 0x4000;

    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_OWNERDRAW"]/*' />
    [NativeTypeName("#define HDF_OWNERDRAW 0x8000")]
    public const int HDF_OWNERDRAW = 0x8000;

    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_IMAGE"]/*' />
    [NativeTypeName("#define HDF_IMAGE 0x0800")]
    public const int HDF_IMAGE = 0x0800;

    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_BITMAP_ON_RIGHT"]/*' />
    [NativeTypeName("#define HDF_BITMAP_ON_RIGHT 0x1000")]
    public const int HDF_BITMAP_ON_RIGHT = 0x1000;

    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_SORTUP"]/*' />
    [NativeTypeName("#define HDF_SORTUP 0x0400")]
    public const int HDF_SORTUP = 0x0400;

    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_SORTDOWN"]/*' />
    [NativeTypeName("#define HDF_SORTDOWN 0x0200")]
    public const int HDF_SORTDOWN = 0x0200;

    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_CHECKBOX"]/*' />
    [NativeTypeName("#define HDF_CHECKBOX 0x0040")]
    public const int HDF_CHECKBOX = 0x0040;

    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_CHECKED"]/*' />
    [NativeTypeName("#define HDF_CHECKED 0x0080")]
    public const int HDF_CHECKED = 0x0080;

    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_FIXEDWIDTH"]/*' />
    [NativeTypeName("#define HDF_FIXEDWIDTH 0x0100")]
    public const int HDF_FIXEDWIDTH = 0x0100;

    /// <include file='HDF.xml' path='doc/member[@name="HDF.HDF_SPLITBUTTON"]/*' />
    [NativeTypeName("#define HDF_SPLITBUTTON 0x1000000")]
    public const int HDF_SPLITBUTTON = 0x1000000;
}
