// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Scale effect's top level properties.</summary>
    public enum D2D1_SCALE_PROP : uint
    {
        /// <summary>Property Name: "Scale" Property Type: D2D1_VECTOR_2F</summary>
        D2D1_SCALE_PROP_SCALE = 0,

        /// <summary>Property Name: "CenterPoint" Property Type: D2D1_VECTOR_2F</summary>
        D2D1_SCALE_PROP_CENTER_POINT = 1,

        /// <summary>Property Name: "InterpolationMode" Property Type: D2D1_SCALE_INTERPOLATION_MODE</summary>
        D2D1_SCALE_PROP_INTERPOLATION_MODE = 2,

        /// <summary>Property Name: "BorderMode" Property Type: D2D1_BORDER_MODE</summary>
        D2D1_SCALE_PROP_BORDER_MODE = 3,

        /// <summary>Property Name: "Sharpness" Property Type: FLOAT</summary>
        D2D1_SCALE_PROP_SHARPNESS = 4,

        D2D1_SCALE_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
