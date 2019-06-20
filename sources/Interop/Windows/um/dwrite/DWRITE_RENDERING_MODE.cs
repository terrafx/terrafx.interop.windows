// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Represents a method of rendering glyphs.</summary>
    public enum DWRITE_RENDERING_MODE
    {
        /// <summary>Specifies that the rendering mode is determined automatically based on the font and size.</summary>
        DWRITE_RENDERING_MODE_DEFAULT,

        /// <summary>Specifies that no antialiasing is performed. Each pixel is either set to the foreground color of the text or retains the color of the background.</summary>
        DWRITE_RENDERING_MODE_ALIASED,

        /// <summary>Specifies that antialiasing is performed in the horizontal direction and the appearance of glyphs is layout-compatible with GDI using CLEARTYPE_QUALITY. Use DWRITE_MEASURING_MODE_GDI_CLASSIC to get glyph advances. The antialiasing may be either ClearType or grayscale depending on the text antialiasing mode.</summary>
        DWRITE_RENDERING_MODE_GDI_CLASSIC,

        /// <summary>Specifies that antialiasing is performed in the horizontal direction and the appearance of glyphs is layout-compatible with GDI using CLEARTYPE_NATURAL_QUALITY. Glyph advances are close to the font design advances, but are still rounded to whole pixels. Use DWRITE_MEASURING_MODE_GDI_NATURAL to get glyph advances. The antialiasing may be either ClearType or grayscale depending on the text antialiasing mode.</summary>
        DWRITE_RENDERING_MODE_GDI_NATURAL,

        /// <summary>Specifies that antialiasing is performed in the horizontal direction. This rendering mode allows glyphs to be positioned with subpixel precision and is therefore suitable for natural (i.e., resolution-independent) layout. The antialiasing may be either ClearType or grayscale depending on the text antialiasing mode.</summary>
        DWRITE_RENDERING_MODE_NATURAL,

        /// <summary>Similar to natural mode except that antialiasing is performed in both the horizontal and vertical directions. This is typically used at larger sizes to make curves and diagonal lines look smoother. The antialiasing may be either ClearType or grayscale depending on the text antialiasing mode.</summary>
        DWRITE_RENDERING_MODE_NATURAL_SYMMETRIC,

        /// <summary>Specifies that rendering should bypass the rasterizer and use the outlines directly. This is typically used at very large sizes.</summary>
        DWRITE_RENDERING_MODE_OUTLINE,

        // The following names are obsolete, but are kept as aliases to avoid breaking existing code. Each of these rendering modes may result in either ClearType or grayscale antialiasing depending on the DWRITE_TEXT_ANTIALIASING_MODE.
        DWRITE_RENDERING_MODE_CLEARTYPE_GDI_CLASSIC = DWRITE_RENDERING_MODE_GDI_CLASSIC,

        DWRITE_RENDERING_MODE_CLEARTYPE_GDI_NATURAL = DWRITE_RENDERING_MODE_GDI_NATURAL,

        DWRITE_RENDERING_MODE_CLEARTYPE_NATURAL = DWRITE_RENDERING_MODE_NATURAL,

        DWRITE_RENDERING_MODE_CLEARTYPE_NATURAL_SYMMETRIC = DWRITE_RENDERING_MODE_NATURAL_SYMMETRIC
    }
}
