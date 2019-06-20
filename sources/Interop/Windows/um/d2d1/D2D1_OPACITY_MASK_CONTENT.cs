// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies what the contents are of an opacity mask.</summary>
    public enum D2D1_OPACITY_MASK_CONTENT : uint
    {
        /// <summary>The mask contains geometries or bitmaps.</summary>
        D2D1_OPACITY_MASK_CONTENT_GRAPHICS = 0,

        /// <summary>The mask contains text rendered using one of the natural text modes.</summary>
        D2D1_OPACITY_MASK_CONTENT_TEXT_NATURAL = 1,

        /// <summary>The mask contains text rendered using one of the GDI compatible text modes.</summary>
        D2D1_OPACITY_MASK_CONTENT_TEXT_GDI_COMPATIBLE = 2,

        D2D1_OPACITY_MASK_CONTENT_FORCE_DWORD = 0xFFFFFFFF
    }
}
