// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class LVCFMT
{
    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_LEFT"]/*' />
    [NativeTypeName("#define LVCFMT_LEFT 0x0000")]
    public const int LVCFMT_LEFT = 0x0000;

    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_RIGHT"]/*' />
    [NativeTypeName("#define LVCFMT_RIGHT 0x0001")]
    public const int LVCFMT_RIGHT = 0x0001;

    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_CENTER"]/*' />
    [NativeTypeName("#define LVCFMT_CENTER 0x0002")]
    public const int LVCFMT_CENTER = 0x0002;

    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_JUSTIFYMASK"]/*' />
    [NativeTypeName("#define LVCFMT_JUSTIFYMASK 0x0003")]
    public const int LVCFMT_JUSTIFYMASK = 0x0003;

    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_IMAGE"]/*' />
    [NativeTypeName("#define LVCFMT_IMAGE 0x0800")]
    public const int LVCFMT_IMAGE = 0x0800;

    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_BITMAP_ON_RIGHT"]/*' />
    [NativeTypeName("#define LVCFMT_BITMAP_ON_RIGHT 0x1000")]
    public const int LVCFMT_BITMAP_ON_RIGHT = 0x1000;

    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_COL_HAS_IMAGES"]/*' />
    [NativeTypeName("#define LVCFMT_COL_HAS_IMAGES 0x8000")]
    public const int LVCFMT_COL_HAS_IMAGES = 0x8000;

    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_FIXED_WIDTH"]/*' />
    [NativeTypeName("#define LVCFMT_FIXED_WIDTH 0x00100")]
    public const int LVCFMT_FIXED_WIDTH = 0x00100;

    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_NO_DPI_SCALE"]/*' />
    [NativeTypeName("#define LVCFMT_NO_DPI_SCALE 0x40000")]
    public const int LVCFMT_NO_DPI_SCALE = 0x40000;

    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_FIXED_RATIO"]/*' />
    [NativeTypeName("#define LVCFMT_FIXED_RATIO 0x80000")]
    public const int LVCFMT_FIXED_RATIO = 0x80000;

    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_LINE_BREAK"]/*' />
    [NativeTypeName("#define LVCFMT_LINE_BREAK 0x100000")]
    public const int LVCFMT_LINE_BREAK = 0x100000;

    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_FILL"]/*' />
    [NativeTypeName("#define LVCFMT_FILL 0x200000")]
    public const int LVCFMT_FILL = 0x200000;

    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_WRAP"]/*' />
    [NativeTypeName("#define LVCFMT_WRAP 0x400000")]
    public const int LVCFMT_WRAP = 0x400000;

    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_NO_TITLE"]/*' />
    [NativeTypeName("#define LVCFMT_NO_TITLE 0x800000")]
    public const int LVCFMT_NO_TITLE = 0x800000;

    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_TILE_PLACEMENTMASK"]/*' />
    [NativeTypeName("#define LVCFMT_TILE_PLACEMENTMASK (LVCFMT_LINE_BREAK | LVCFMT_FILL)")]
    public const int LVCFMT_TILE_PLACEMENTMASK = (0x100000 | 0x200000);

    /// <include file='LVCFMT.xml' path='doc/member[@name="LVCFMT.LVCFMT_SPLITBUTTON"]/*' />
    [NativeTypeName("#define LVCFMT_SPLITBUTTON 0x1000000")]
    public const int LVCFMT_SPLITBUTTON = 0x1000000;
}
