// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Spot-Specular effect's top level properties.</summary>
    public enum D2D1_SPOTSPECULAR_PROP : uint
    {
        /// <summary>Property Name: "LightPosition" Property Type: D2D1_VECTOR_3F</summary>
        D2D1_SPOTSPECULAR_PROP_LIGHT_POSITION = 0,

        /// <summary>Property Name: "PointsAt" Property Type: D2D1_VECTOR_3F</summary>
        D2D1_SPOTSPECULAR_PROP_POINTS_AT = 1,

        /// <summary>Property Name: "Focus" Property Type: FLOAT</summary>
        D2D1_SPOTSPECULAR_PROP_FOCUS = 2,

        /// <summary>Property Name: "LimitingConeAngle" Property Type: FLOAT</summary>
        D2D1_SPOTSPECULAR_PROP_LIMITING_CONE_ANGLE = 3,

        /// <summary>Property Name: "SpecularExponent" Property Type: FLOAT</summary>
        D2D1_SPOTSPECULAR_PROP_SPECULAR_EXPONENT = 4,

        /// <summary>Property Name: "SpecularConstant" Property Type: FLOAT</summary>
        D2D1_SPOTSPECULAR_PROP_SPECULAR_CONSTANT = 5,

        /// <summary>Property Name: "SurfaceScale" Property Type: FLOAT</summary>
        D2D1_SPOTSPECULAR_PROP_SURFACE_SCALE = 6,

        /// <summary>Property Name: "Color" Property Type: D2D1_VECTOR_3F</summary>
        D2D1_SPOTSPECULAR_PROP_COLOR = 7,

        /// <summary>Property Name: "KernelUnitLength" Property Type: D2D1_VECTOR_2F</summary>
        D2D1_SPOTSPECULAR_PROP_KERNEL_UNIT_LENGTH = 8,

        /// <summary>Property Name: "ScaleMode" Property Type: D2D1_SPOTSPECULAR_SCALE_MODE</summary>
        D2D1_SPOTSPECULAR_PROP_SCALE_MODE = 9,

        D2D1_SPOTSPECULAR_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
