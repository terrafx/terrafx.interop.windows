// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Represents a color glyph run. The IDWriteFactory4::TranslateColorGlyphRun method returns an ordered collection of color glyph runs of varying types depending on what the font supports.</summary>
    /// <summary>For runs without any specific color, such as PNG data, the runColor field will be zero.</summary>
    public struct DWRITE_COLOR_GLYPH_RUN1
    {
        #region Fields
        public DWRITE_COLOR_GLYPH_RUN BaseValue;

        /// <summary>Type of glyph image format for this color run. Exactly one type will be set since TranslateColorGlyphRun has already broken down the run into separate parts.</summary>
        public DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat;

        /// <summary>Measuring mode to use for this glyph run.</summary>
        public DWRITE_MEASURING_MODE measuringMode;
        #endregion
    }
}
