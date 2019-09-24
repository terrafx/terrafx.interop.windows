// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Defines when font resources should be subset during printing.</summary>
    public enum D2D1_PRINT_FONT_SUBSET_MODE : uint
    {
        /// <summary>Subset for used glyphs, send and discard font resource after every five pages</summary>
        D2D1_PRINT_FONT_SUBSET_MODE_DEFAULT = 0,

        /// <summary>Subset for used glyphs, send and discard font resource after each page</summary>
        D2D1_PRINT_FONT_SUBSET_MODE_EACHPAGE = 1,

        /// <summary>Do not subset, reuse font for all pages, send it after first page</summary>
        D2D1_PRINT_FONT_SUBSET_MODE_NONE = 2,

        D2D1_PRINT_FONT_SUBSET_MODE_FORCE_DWORD = 0xFFFFFFFF
    }
}
