// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Represents a color glyph run. The IDWriteFactory2::TranslateColorGlyphRun method returns an ordered collection of color glyph runs, which can be layered on top of each other to produce a color representation of the given base glyph run.</summary>
    public unsafe struct DWRITE_COLOR_GLYPH_RUN
    {
        /// <summary>Glyph run to render.</summary>
        public DWRITE_GLYPH_RUN glyphRun;

        /// <summary>Optional glyph run description.</summary>
        public DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription;

        /// <summary>Location at which to draw this glyph run.</summary>
        [NativeTypeName("FLOAT")]
        public float baselineOriginX;

        [NativeTypeName("FLOAT")]
        public float baselineOriginY;

        /// <summary>Color to use for this layer, if any. This is the same color that IDWriteFontFace2::GetPaletteEntries would return for the current palette index if the paletteIndex member is less than 0xFFFF. If the paletteIndex member is 0xFFFF then there is no associated palette entry, this member is set to { 0, 0, 0, 0 }, and the client should use the current foreground brush.</summary>
        [NativeTypeName("DWRITE_COLOR_F")]
        public DXGI_RGBA runColor;

        /// <summary>Zero-based index of this layer's color entry in the current color palette, or 0xFFFF if this layer is to be rendered using the current foreground brush.</summary>
        [NativeTypeName("UINT16")]
        public ushort paletteIndex;
    }
}
