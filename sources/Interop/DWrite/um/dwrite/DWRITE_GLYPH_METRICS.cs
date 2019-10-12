// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The DWRITE_GLYPH_METRICS structure specifies the metrics of an individual glyph. The units depend on how the metrics are obtained.</summary>
    public partial struct DWRITE_GLYPH_METRICS
    {
        /// <summary>Specifies the X offset from the glyph origin to the left edge of the black box. The glyph origin is the current horizontal writing position. A negative value means the black box extends to the left of the origin (often true for lowercase italic 'f').</summary>
        [NativeTypeName("INT32")]
        public int leftSideBearing;

        /// <summary>Specifies the X offset from the origin of the current glyph to the origin of the next glyph when writing horizontally.</summary>
        [NativeTypeName("UINT32")]
        public uint advanceWidth;

        /// <summary>Specifies the X offset from the right edge of the black box to the origin of the next glyph when writing horizontally. The value is negative when the right edge of the black box overhangs the layout box.</summary>
        [NativeTypeName("INT32")]
        public int rightSideBearing;

        /// <summary>Specifies the vertical offset from the vertical origin to the top of the black box. Thus, a positive value adds whitespace whereas a negative value means the glyph overhangs the top of the layout box.</summary>
        [NativeTypeName("INT32")]
        public int topSideBearing;

        /// <summary>Specifies the Y offset from the vertical origin of the current glyph to the vertical origin of the next glyph when writing vertically. (Note that the term "origin" by itself denotes the horizontal origin. The vertical origin is different. Its Y coordinate is specified by verticalOriginY value, and its X coordinate is half the advanceWidth to the right of the horizontal origin).</summary>
        [NativeTypeName("UINT32")]
        public uint advanceHeight;

        /// <summary>Specifies the vertical distance from the black box's bottom edge to the advance height. Positive when the bottom edge of the black box is within the layout box. Negative when the bottom edge of black box overhangs the layout box.</summary>
        [NativeTypeName("INT32")]
        public int bottomSideBearing;

        /// <summary>Specifies the Y coordinate of a glyph's vertical origin, in the font's design coordinate system. The y coordinate of a glyph's vertical origin is the sum of the glyph's top side bearing and the top (i.e. yMax) of the glyph's bounding box.</summary>
        [NativeTypeName("INT32")]
        public int verticalOriginY;
    }
}
