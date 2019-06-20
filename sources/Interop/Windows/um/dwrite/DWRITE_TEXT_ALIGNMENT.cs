// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Alignment of paragraph text along the reading direction axis relative to the leading and trailing edge of the layout box.</summary>
    public enum DWRITE_TEXT_ALIGNMENT
    {
        /// <summary>The leading edge of the paragraph text is aligned to the layout box's leading edge.</summary>
        DWRITE_TEXT_ALIGNMENT_LEADING,

        /// <summary>The trailing edge of the paragraph text is aligned to the layout box's trailing edge.</summary>
        DWRITE_TEXT_ALIGNMENT_TRAILING,

        /// <summary>The center of the paragraph text is aligned to the center of the layout box.</summary>
        DWRITE_TEXT_ALIGNMENT_CENTER,

        /// <summary>Align text to the leading side, and also justify text to fill the lines.</summary>
        DWRITE_TEXT_ALIGNMENT_JUSTIFIED
    }
}
