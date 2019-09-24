// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Color Matrix effect's top level properties.</summary>
    public enum D2D1_COLORMATRIX_PROP : uint
    {
        /// <summary>Property Name: "ColorMatrix" Property Type: D2D1_MATRIX_5X4_F</summary>
        D2D1_COLORMATRIX_PROP_COLOR_MATRIX = 0,

        /// <summary>Property Name: "AlphaMode" Property Type: D2D1_COLORMATRIX_ALPHA_MODE</summary>
        D2D1_COLORMATRIX_PROP_ALPHA_MODE = 1,

        /// <summary>Property Name: "ClampOutput" Property Type: BOOL</summary>
        D2D1_COLORMATRIX_PROP_CLAMP_OUTPUT = 2,

        D2D1_COLORMATRIX_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
