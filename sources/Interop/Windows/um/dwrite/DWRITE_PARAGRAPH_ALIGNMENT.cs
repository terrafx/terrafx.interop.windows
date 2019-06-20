// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Alignment of paragraph text along the flow direction axis relative to the flow's beginning and ending edge of the layout box.</summary>
    public enum DWRITE_PARAGRAPH_ALIGNMENT
    {
        /// <summary>The first line of paragraph is aligned to the flow's beginning edge of the layout box.</summary>
        DWRITE_PARAGRAPH_ALIGNMENT_NEAR,

        /// <summary>The last line of paragraph is aligned to the flow's ending edge of the layout box.</summary>
        DWRITE_PARAGRAPH_ALIGNMENT_FAR,

        /// <summary>The center of the paragraph is aligned to the center of the flow of the layout box.</summary>
        DWRITE_PARAGRAPH_ALIGNMENT_CENTER
    }
}
