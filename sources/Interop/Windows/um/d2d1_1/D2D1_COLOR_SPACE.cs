// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Defines a color space.</summary>
    public enum D2D1_COLOR_SPACE : uint
    {
        /// <summary>The color space is described by accompanying data, such as a color profile.</summary>
        D2D1_COLOR_SPACE_CUSTOM = 0,

        /// <summary>The sRGB color space.</summary>
        D2D1_COLOR_SPACE_SRGB = 1,

        /// <summary>The scRGB color space.</summary>
        D2D1_COLOR_SPACE_SCRGB = 2,

        D2D1_COLOR_SPACE_FORCE_DWORD = 0xFFFFFFFF
    }
}
