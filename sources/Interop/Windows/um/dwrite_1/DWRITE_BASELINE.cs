// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Baseline for text alignment.</summary>
    public enum DWRITE_BASELINE
    {
        /// <summary>The Roman baseline for horizontal, Central baseline for vertical.</summary>
        DWRITE_BASELINE_DEFAULT,

        /// <summary>The baseline used by alphabetic scripts such as Latin, Greek, Cyrillic.</summary>
        DWRITE_BASELINE_ROMAN,

        /// <summary>Central baseline, generally used for vertical text.</summary>
        DWRITE_BASELINE_CENTRAL,

        /// <summary>Mathematical baseline which math characters are centered on.</summary>
        DWRITE_BASELINE_MATH,

        /// <summary>Hanging baseline, used in scripts like Devanagari.</summary>
        DWRITE_BASELINE_HANGING,

        /// <summary>Ideographic bottom baseline for CJK, left in vertical.</summary>
        DWRITE_BASELINE_IDEOGRAPHIC_BOTTOM,

        /// <summary>Ideographic top baseline for CJK, right in vertical.</summary>
        DWRITE_BASELINE_IDEOGRAPHIC_TOP,

        /// <summary>The bottom-most extent in horizontal, left-most in vertical.</summary>
        DWRITE_BASELINE_MINIMUM,

        /// <summary>The top-most extent in horizontal, right-most in vertical.</summary>
        DWRITE_BASELINE_MAXIMUM, }
}
