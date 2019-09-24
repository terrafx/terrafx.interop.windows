// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Text granularity used to trim text overflowing the layout box.</summary>
    public enum DWRITE_TRIMMING_GRANULARITY
    {
        /// <summary>No trimming occurs. Text flows beyond the layout width.</summary>
        DWRITE_TRIMMING_GRANULARITY_NONE,

        /// <summary>Trimming occurs at character cluster boundary.</summary>
        DWRITE_TRIMMING_GRANULARITY_CHARACTER,

        /// <summary>Trimming occurs at word boundary.</summary>
        DWRITE_TRIMMING_GRANULARITY_WORD
    }
}
