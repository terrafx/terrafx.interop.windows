// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct DWRITE_FONT_METRICS1
    {
        #region Fields
        public DWRITE_FONT_METRICS BaseValue;

        /// <summary>Left edge of accumulated bounding blackbox of all glyphs in the font.</summary>
        [NativeTypeName("INT16")]
        public short glyphBoxLeft;

        /// <summary>Top edge of accumulated bounding blackbox of all glyphs in the font.</summary>
        [NativeTypeName("INT16")]
        public short glyphBoxTop;

        /// <summary>Right edge of accumulated bounding blackbox of all glyphs in the font.</summary>
        [NativeTypeName("INT16")]
        public short glyphBoxRight;

        /// <summary>Bottom edge of accumulated bounding blackbox of all glyphs in the font.</summary>
        [NativeTypeName("INT16")]
        public short glyphBoxBottom;

        /// <summary>Horizontal position of the subscript relative to the baseline origin. This is typically negative (to the left) in italic/oblique fonts, and zero in regular fonts.</summary>
        [NativeTypeName("INT16")]
        public short subscriptPositionX;

        /// <summary>Vertical position of the subscript relative to the baseline. This is typically negative.</summary>
        [NativeTypeName("INT16")]
        public short subscriptPositionY;

        /// <summary>Horizontal size of the subscript em box in design units, used to scale the simulated subscript relative to the full em box size. This the numerator of the scaling ratio where denominator is the design units per em. If this member is zero, the font does not specify a scale factor, and the client should use its own policy.</summary>
        [NativeTypeName("INT16")]
        public short subscriptSizeX;

        /// <summary>Vertical size of the subscript em box in design units, used to scale the simulated subscript relative to the full em box size. This the numerator of the scaling ratio where denominator is the design units per em. If this member is zero, the font does not specify a scale factor, and the client should use its own policy.</summary>
        [NativeTypeName("INT16")]
        public short subscriptSizeY;

        /// <summary>Horizontal position of the superscript relative to the baseline origin. This is typically positive (to the right) in italic/oblique fonts, and zero in regular fonts.</summary>
        [NativeTypeName("INT16")]
        public short superscriptPositionX;

        /// <summary>Vertical position of the superscript relative to the baseline. This is typically positive.</summary>
        [NativeTypeName("INT16")]
        public short superscriptPositionY;

        /// <summary>Horizontal size of the superscript em box in design units, used to scale the simulated superscript relative to the full em box size. This the numerator of the scaling ratio where denominator is the design units per em. If this member is zero, the font does not specify a scale factor, and the client should use its own policy.</summary>
        [NativeTypeName("INT16")]
        public short superscriptSizeX;

        /// <summary>Vertical size of the superscript em box in design units, used to scale the simulated superscript relative to the full em box size. This the numerator of the scaling ratio where denominator is the design units per em. If this member is zero, the font does not specify a scale factor, and the client should use its own policy.</summary>
        [NativeTypeName("INT16")]
        public short superscriptSizeY;

        /// <summary>Indicates that the ascent, descent, and lineGap are based on newer 'typographic' values in the font, rather than legacy values.</summary>
        [NativeTypeName("BOOL")]
        public int hasTypographicMetrics;
        #endregion
    }
}
