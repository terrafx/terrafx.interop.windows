// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DWRITE_PAINT_ELEMENT.xml' path='doc/member[@name="DWRITE_PAINT_ELEMENT"]/*' />
public partial struct DWRITE_PAINT_ELEMENT
{
    /// <include file='DWRITE_PAINT_ELEMENT.xml' path='doc/member[@name="DWRITE_PAINT_ELEMENT.paintType"]/*' />
    public DWRITE_PAINT_TYPE paintType;

    /// <include file='DWRITE_PAINT_ELEMENT.xml' path='doc/member[@name="DWRITE_PAINT_ELEMENT.paint"]/*' />
    [NativeTypeName("union PAINT_UNION")]
    public PAINT_UNION paint;

    /// <include file='PAINT_UNION.xml' path='doc/member[@name="PAINT_UNION"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct PAINT_UNION
    {
        /// <include file='PAINT_UNION.xml' path='doc/member[@name="PAINT_UNION.layers"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_LAYERS")]
        public PAINT_LAYERS layers;

        /// <include file='PAINT_UNION.xml' path='doc/member[@name="PAINT_UNION.solidGlyph"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_SOLID_GLYPH")]
        public PAINT_SOLID_GLYPH solidGlyph;

        /// <include file='PAINT_UNION.xml' path='doc/member[@name="PAINT_UNION.solid"]/*' />
        [FieldOffset(0)]
        public DWRITE_PAINT_COLOR solid;

        /// <include file='PAINT_UNION.xml' path='doc/member[@name="PAINT_UNION.linearGradient"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_LINEAR_GRADIENT")]
        public PAINT_LINEAR_GRADIENT linearGradient;

        /// <include file='PAINT_UNION.xml' path='doc/member[@name="PAINT_UNION.radialGradient"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_RADIAL_GRADIENT")]
        public PAINT_RADIAL_GRADIENT radialGradient;

        /// <include file='PAINT_UNION.xml' path='doc/member[@name="PAINT_UNION.sweepGradient"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_SWEEP_GRADIENT")]
        public PAINT_SWEEP_GRADIENT sweepGradient;

        /// <include file='PAINT_UNION.xml' path='doc/member[@name="PAINT_UNION.glyph"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_GLYPH")]
        public PAINT_GLYPH glyph;

        /// <include file='PAINT_UNION.xml' path='doc/member[@name="PAINT_UNION.colorGlyph"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_COLOR_GLYPH")]
        public PAINT_COLOR_GLYPH colorGlyph;

        /// <include file='PAINT_UNION.xml' path='doc/member[@name="PAINT_UNION.transform"]/*' />
        [FieldOffset(0)]
        public DWRITE_MATRIX transform;

        /// <include file='PAINT_UNION.xml' path='doc/member[@name="PAINT_UNION.composite"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_COMPOSITE")]
        public PAINT_COMPOSITE composite;

        /// <include file='PAINT_LAYERS.xml' path='doc/member[@name="PAINT_LAYERS"]/*' />
        public partial struct PAINT_LAYERS
        {
            /// <include file='PAINT_LAYERS.xml' path='doc/member[@name="PAINT_LAYERS.childCount"]/*' />
            [NativeTypeName("UINT32")]
            public uint childCount;
        }

        /// <include file='PAINT_SOLID_GLYPH.xml' path='doc/member[@name="PAINT_SOLID_GLYPH"]/*' />
        public partial struct PAINT_SOLID_GLYPH
        {
            /// <include file='PAINT_SOLID_GLYPH.xml' path='doc/member[@name="PAINT_SOLID_GLYPH.glyphIndex"]/*' />
            [NativeTypeName("UINT32")]
            public uint glyphIndex;

            /// <include file='PAINT_SOLID_GLYPH.xml' path='doc/member[@name="PAINT_SOLID_GLYPH.color"]/*' />
            public DWRITE_PAINT_COLOR color;
        }

        /// <include file='PAINT_LINEAR_GRADIENT.xml' path='doc/member[@name="PAINT_LINEAR_GRADIENT"]/*' />
        public partial struct PAINT_LINEAR_GRADIENT
        {
            /// <include file='PAINT_LINEAR_GRADIENT.xml' path='doc/member[@name="PAINT_LINEAR_GRADIENT.extendMode"]/*' />
            [NativeTypeName("UINT32")]
            public uint extendMode;

            /// <include file='PAINT_LINEAR_GRADIENT.xml' path='doc/member[@name="PAINT_LINEAR_GRADIENT.gradientStopCount"]/*' />
            [NativeTypeName("UINT32")]
            public uint gradientStopCount;

            /// <include file='PAINT_LINEAR_GRADIENT.xml' path='doc/member[@name="PAINT_LINEAR_GRADIENT.x0"]/*' />
            public float x0;

            /// <include file='PAINT_LINEAR_GRADIENT.xml' path='doc/member[@name="PAINT_LINEAR_GRADIENT.y0"]/*' />
            public float y0;

            /// <include file='PAINT_LINEAR_GRADIENT.xml' path='doc/member[@name="PAINT_LINEAR_GRADIENT.x1"]/*' />
            public float x1;

            /// <include file='PAINT_LINEAR_GRADIENT.xml' path='doc/member[@name="PAINT_LINEAR_GRADIENT.y1"]/*' />
            public float y1;

            /// <include file='PAINT_LINEAR_GRADIENT.xml' path='doc/member[@name="PAINT_LINEAR_GRADIENT.x2"]/*' />
            public float x2;

            /// <include file='PAINT_LINEAR_GRADIENT.xml' path='doc/member[@name="PAINT_LINEAR_GRADIENT.y2"]/*' />
            public float y2;
        }

        /// <include file='PAINT_RADIAL_GRADIENT.xml' path='doc/member[@name="PAINT_RADIAL_GRADIENT"]/*' />
        public partial struct PAINT_RADIAL_GRADIENT
        {
            /// <include file='PAINT_RADIAL_GRADIENT.xml' path='doc/member[@name="PAINT_RADIAL_GRADIENT.extendMode"]/*' />
            [NativeTypeName("UINT32")]
            public uint extendMode;

            /// <include file='PAINT_RADIAL_GRADIENT.xml' path='doc/member[@name="PAINT_RADIAL_GRADIENT.gradientStopCount"]/*' />
            [NativeTypeName("UINT32")]
            public uint gradientStopCount;

            /// <include file='PAINT_RADIAL_GRADIENT.xml' path='doc/member[@name="PAINT_RADIAL_GRADIENT.x0"]/*' />
            public float x0;

            /// <include file='PAINT_RADIAL_GRADIENT.xml' path='doc/member[@name="PAINT_RADIAL_GRADIENT.y0"]/*' />
            public float y0;

            /// <include file='PAINT_RADIAL_GRADIENT.xml' path='doc/member[@name="PAINT_RADIAL_GRADIENT.radius0"]/*' />
            public float radius0;

            /// <include file='PAINT_RADIAL_GRADIENT.xml' path='doc/member[@name="PAINT_RADIAL_GRADIENT.x1"]/*' />
            public float x1;

            /// <include file='PAINT_RADIAL_GRADIENT.xml' path='doc/member[@name="PAINT_RADIAL_GRADIENT.y1"]/*' />
            public float y1;

            /// <include file='PAINT_RADIAL_GRADIENT.xml' path='doc/member[@name="PAINT_RADIAL_GRADIENT.radius1"]/*' />
            public float radius1;
        }

        /// <include file='PAINT_SWEEP_GRADIENT.xml' path='doc/member[@name="PAINT_SWEEP_GRADIENT"]/*' />
        public partial struct PAINT_SWEEP_GRADIENT
        {
            /// <include file='PAINT_SWEEP_GRADIENT.xml' path='doc/member[@name="PAINT_SWEEP_GRADIENT.extendMode"]/*' />
            [NativeTypeName("UINT32")]
            public uint extendMode;

            /// <include file='PAINT_SWEEP_GRADIENT.xml' path='doc/member[@name="PAINT_SWEEP_GRADIENT.gradientStopCount"]/*' />
            [NativeTypeName("UINT32")]
            public uint gradientStopCount;

            /// <include file='PAINT_SWEEP_GRADIENT.xml' path='doc/member[@name="PAINT_SWEEP_GRADIENT.centerX"]/*' />
            public float centerX;

            /// <include file='PAINT_SWEEP_GRADIENT.xml' path='doc/member[@name="PAINT_SWEEP_GRADIENT.centerY"]/*' />
            public float centerY;

            /// <include file='PAINT_SWEEP_GRADIENT.xml' path='doc/member[@name="PAINT_SWEEP_GRADIENT.startAngle"]/*' />
            public float startAngle;

            /// <include file='PAINT_SWEEP_GRADIENT.xml' path='doc/member[@name="PAINT_SWEEP_GRADIENT.endAngle"]/*' />
            public float endAngle;
        }

        /// <include file='PAINT_GLYPH.xml' path='doc/member[@name="PAINT_GLYPH"]/*' />
        public partial struct PAINT_GLYPH
        {
            /// <include file='PAINT_GLYPH.xml' path='doc/member[@name="PAINT_GLYPH.glyphIndex"]/*' />
            [NativeTypeName("UINT32")]
            public uint glyphIndex;
        }

        /// <include file='PAINT_COLOR_GLYPH.xml' path='doc/member[@name="PAINT_COLOR_GLYPH"]/*' />
        public partial struct PAINT_COLOR_GLYPH
        {
            /// <include file='PAINT_COLOR_GLYPH.xml' path='doc/member[@name="PAINT_COLOR_GLYPH.glyphIndex"]/*' />
            [NativeTypeName("UINT32")]
            public uint glyphIndex;

            /// <include file='PAINT_COLOR_GLYPH.xml' path='doc/member[@name="PAINT_COLOR_GLYPH.clipBox"]/*' />
            public D2D_RECT_F clipBox;
        }

        /// <include file='PAINT_COMPOSITE.xml' path='doc/member[@name="PAINT_COMPOSITE"]/*' />
        public partial struct PAINT_COMPOSITE
        {
            /// <include file='PAINT_COMPOSITE.xml' path='doc/member[@name="PAINT_COMPOSITE.mode"]/*' />
            public DWRITE_COLOR_COMPOSITE_MODE mode;
        }
    }
}
