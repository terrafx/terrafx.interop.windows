// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>How to align glyphs to the margin.</summary>
    public enum DWRITE_OPTICAL_ALIGNMENT
    {
        /// <summary>Align to the default metrics of the glyph.</summary>
        DWRITE_OPTICAL_ALIGNMENT_NONE,

        /// <summary>Align glyphs to the margins. Without this, some small whitespace may be present between the text and the margin from the glyph's side bearing values. Note that glyphs may still overhang outside the margin, such as flourishes or italic slants.</summary>
        DWRITE_OPTICAL_ALIGNMENT_NO_SIDE_BEARINGS,
    }
}
