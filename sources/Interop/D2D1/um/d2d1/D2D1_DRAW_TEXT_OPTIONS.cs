// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    /// <summary>Modifications made to the draw text call that influence how the text is rendered.</summary>
    [Flags]
    public enum D2D1_DRAW_TEXT_OPTIONS : uint
    {
        /// <summary>Do not snap the baseline of the text vertically.</summary>
        D2D1_DRAW_TEXT_OPTIONS_NO_SNAP = 0x00000001,

        /// <summary>Clip the text to the content bounds.</summary>
        D2D1_DRAW_TEXT_OPTIONS_CLIP = 0x00000002,

        /// <summary>Render color versions of glyphs if defined by the font.</summary>
        D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT = 0x00000004,

        /// <summary>Bitmap origins of color glyph bitmaps are not snapped.</summary>
        D2D1_DRAW_TEXT_OPTIONS_DISABLE_COLOR_BITMAP_SNAPPING = 0x00000008,

        D2D1_DRAW_TEXT_OPTIONS_NONE = 0x00000000,

        D2D1_DRAW_TEXT_OPTIONS_FORCE_DWORD = 0xFFFFFFFF
    }
}
