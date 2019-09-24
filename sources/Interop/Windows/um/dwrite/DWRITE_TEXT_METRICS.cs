// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Overall metrics associated with text after layout. All coordinates are in device independent pixels (DIPs).</summary>
    public struct DWRITE_TEXT_METRICS
    {
        /// <summary>Left-most point of formatted text relative to layout box (excluding any glyph overhang).</summary>
        [NativeTypeName("FLOAT")]
        public float left;

        /// <summary>Top-most point of formatted text relative to layout box (excluding any glyph overhang).</summary>
        [NativeTypeName("FLOAT")]
        public float top;

        /// <summary>The width of the formatted text ignoring trailing whitespace at the end of each line.</summary>
        [NativeTypeName("FLOAT")]
        public float width;

        /// <summary>The width of the formatted text taking into account the trailing whitespace at the end of each line.</summary>
        [NativeTypeName("FLOAT")]
        public float widthIncludingTrailingWhitespace;

        /// <summary>The height of the formatted text. The height of an empty string is determined by the size of the default font's line height.</summary>
        [NativeTypeName("FLOAT")]
        public float height;

        /// <summary>Initial width given to the layout. Depending on whether the text was wrapped or not, it can be either larger or smaller than the text content width.</summary>
        [NativeTypeName("FLOAT")]
        public float layoutWidth;

        /// <summary>Initial height given to the layout. Depending on the length of the text, it may be larger or smaller than the text content height.</summary>
        [NativeTypeName("FLOAT")]
        public float layoutHeight;

        /// <summary>The maximum reordering count of any line of text, used to calculate the most number of hit-testing boxes needed. If the layout has no bidirectional text or no text at all, the minimum level is 1.</summary>
        [NativeTypeName("UINT32")]
        public uint maxBidiReorderingDepth;

        /// <summary>Total number of lines.</summary>
        [NativeTypeName("UINT32")]
        public uint lineCount;
    }
}
