// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Word wrapping in multiline paragraph.</summary>
    public enum DWRITE_WORD_WRAPPING
    {
        /// <summary>Words are broken across lines to avoid text overflowing the layout box.</summary>
        DWRITE_WORD_WRAPPING_WRAP = 0,

        /// <summary>Words are kept within the same line even when it overflows the layout box. This option is often used with scrolling to reveal overflow text. </summary>
        DWRITE_WORD_WRAPPING_NO_WRAP = 1,

        /// <summary>Words are broken across lines to avoid text overflowing the layout box. Emergency wrapping occurs if the word is larger than the maximum width.</summary>
        DWRITE_WORD_WRAPPING_EMERGENCY_BREAK = 2,

        /// <summary>Only wrap whole words, never breaking words (emergency wrapping) when the layout width is too small for even a single word.</summary>
        DWRITE_WORD_WRAPPING_WHOLE_WORD = 3,

        /// <summary>Wrap between any valid characters clusters.</summary>
        DWRITE_WORD_WRAPPING_CHARACTER = 4, }
}
