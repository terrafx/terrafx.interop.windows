// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The DWRITE_GLYPH_RUN public structure contains the information needed by renderers to draw glyph runs. All coordinates are in device independent pixels (DIPs).</summary>
    public unsafe struct DWRITE_GLYPH_RUN
    {
        /// <summary>The physical font face to draw with.</summary>
        public IDWriteFontFace* fontFace;

        /// <summary>Logical size of the font in DIPs, not points (equals 1/96 inch).</summary>
        [NativeTypeName("FLOAT")]
        public float fontEmSize;

        /// <summary>The number of glyphs.</summary>
        [NativeTypeName("UINT32")]
        public uint glyphCount;

        /// <summary>The indices to render.</summary>
        [NativeTypeName("UINT16[]")]
        public ushort* glyphIndices;

        /// <summary>Glyph advance widths.</summary>
        [NativeTypeName("FLOAT[]")]
        public float* glyphAdvances;

        /// <summary>Glyph offsets.</summary>
        [NativeTypeName("D3D12_MESSAGE_ID[]")]
        public DWRITE_GLYPH_OFFSET* glyphOffsets;

        /// <summary>If true, specifies that glyphs are rotated 90 degrees to the left and vertical metrics are used. Vertical writing is achieved by specifying isSideways = true and rotating the entire run 90 degrees to the right via a rotate transform.</summary>
        [NativeTypeName("BOOL")]
        public int isSideways;

        /// <summary>The implicit resolved bidi level of the run. Odd levels indicate right-to-left languages like Hebrew and Arabic, while even levels indicate left-to-right languages like English and Japanese (when written horizontally). For right-to-left languages, the text origin is on the right, and text should be drawn to the left.</summary>
        [NativeTypeName("UINT32")]
        public uint bidiLevel;
    }
}
