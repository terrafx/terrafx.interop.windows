// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DWRITE_PAINT_TYPE.xml' path='doc/member[@name="DWRITE_PAINT_TYPE"]/*' />
public enum DWRITE_PAINT_TYPE
{
    /// <include file='DWRITE_PAINT_TYPE.xml' path='doc/member[@name="DWRITE_PAINT_TYPE.DWRITE_PAINT_TYPE_NONE"]/*' />
    DWRITE_PAINT_TYPE_NONE,

    /// <include file='DWRITE_PAINT_TYPE.xml' path='doc/member[@name="DWRITE_PAINT_TYPE.DWRITE_PAINT_TYPE_LAYERS"]/*' />
    DWRITE_PAINT_TYPE_LAYERS,

    /// <include file='DWRITE_PAINT_TYPE.xml' path='doc/member[@name="DWRITE_PAINT_TYPE.DWRITE_PAINT_TYPE_SOLID_GLYPH"]/*' />
    DWRITE_PAINT_TYPE_SOLID_GLYPH,

    /// <include file='DWRITE_PAINT_TYPE.xml' path='doc/member[@name="DWRITE_PAINT_TYPE.DWRITE_PAINT_TYPE_SOLID"]/*' />
    DWRITE_PAINT_TYPE_SOLID,

    /// <include file='DWRITE_PAINT_TYPE.xml' path='doc/member[@name="DWRITE_PAINT_TYPE.DWRITE_PAINT_TYPE_LINEAR_GRADIENT"]/*' />
    DWRITE_PAINT_TYPE_LINEAR_GRADIENT,

    /// <include file='DWRITE_PAINT_TYPE.xml' path='doc/member[@name="DWRITE_PAINT_TYPE.DWRITE_PAINT_TYPE_RADIAL_GRADIENT"]/*' />
    DWRITE_PAINT_TYPE_RADIAL_GRADIENT,

    /// <include file='DWRITE_PAINT_TYPE.xml' path='doc/member[@name="DWRITE_PAINT_TYPE.DWRITE_PAINT_TYPE_SWEEP_GRADIENT"]/*' />
    DWRITE_PAINT_TYPE_SWEEP_GRADIENT,

    /// <include file='DWRITE_PAINT_TYPE.xml' path='doc/member[@name="DWRITE_PAINT_TYPE.DWRITE_PAINT_TYPE_GLYPH"]/*' />
    DWRITE_PAINT_TYPE_GLYPH,

    /// <include file='DWRITE_PAINT_TYPE.xml' path='doc/member[@name="DWRITE_PAINT_TYPE.DWRITE_PAINT_TYPE_COLOR_GLYPH"]/*' />
    DWRITE_PAINT_TYPE_COLOR_GLYPH,

    /// <include file='DWRITE_PAINT_TYPE.xml' path='doc/member[@name="DWRITE_PAINT_TYPE.DWRITE_PAINT_TYPE_TRANSFORM"]/*' />
    DWRITE_PAINT_TYPE_TRANSFORM,

    /// <include file='DWRITE_PAINT_TYPE.xml' path='doc/member[@name="DWRITE_PAINT_TYPE.DWRITE_PAINT_TYPE_COMPOSITE"]/*' />
    DWRITE_PAINT_TYPE_COMPOSITE,
}
