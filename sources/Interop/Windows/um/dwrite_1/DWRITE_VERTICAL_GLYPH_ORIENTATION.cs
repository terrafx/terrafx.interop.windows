// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The desired kind of glyph orientation for the text. The client specifies this to the analyzer as the desired orientation, but note this is the client preference, and the constraints of the script will determine the final presentation.</summary>
    public enum DWRITE_VERTICAL_GLYPH_ORIENTATION
    {
        /// <summary>In vertical layout, naturally horizontal scripts (Latin, Thai, Arabic, Devanagari) rotate 90 degrees clockwise, while ideographic scripts (Chinese, Japanese, Korean) remain upright, 0 degrees.</summary>
        DWRITE_VERTICAL_GLYPH_ORIENTATION_DEFAULT,

        /// <summary>Ideographic scripts and scripts that permit stacking (Latin, Hebrew) are stacked in vertical reading layout. Connected scripts (Arabic, Syriac, 'Phags-pa, Ogham), which would otherwise look broken if glyphs were kept at 0 degrees, remain connected and rotate.</summary>
        DWRITE_VERTICAL_GLYPH_ORIENTATION_STACKED
    }
}
