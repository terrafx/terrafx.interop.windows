// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Whether to enable grid-fitting of glyph outlines (a.k.a. hinting).</summary>
    public enum DWRITE_GRID_FIT_MODE
    {
        /// <summary>Choose grid fitting base on the font's gasp table information.</summary>
        DWRITE_GRID_FIT_MODE_DEFAULT,

        /// <summary>Always disable grid fitting, using the ideal glyph outlines.</summary>
        DWRITE_GRID_FIT_MODE_DISABLED,

        /// <summary>Enable grid fitting, adjusting glyph outlines for device pixel display.</summary>
        DWRITE_GRID_FIT_MODE_ENABLED
    }
}
