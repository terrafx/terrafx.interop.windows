// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Distant-Diffuse effect's top level properties.</summary>
    public enum D2D1_DISTANTDIFFUSE_PROP : uint
    {
        /// <summary>Property Name: "Azimuth" Property Type: FLOAT</summary>
        D2D1_DISTANTDIFFUSE_PROP_AZIMUTH = 0,

        /// <summary>Property Name: "Elevation" Property Type: FLOAT</summary>
        D2D1_DISTANTDIFFUSE_PROP_ELEVATION = 1,

        /// <summary>Property Name: "DiffuseConstant" Property Type: FLOAT</summary>
        D2D1_DISTANTDIFFUSE_PROP_DIFFUSE_CONSTANT = 2,

        /// <summary>Property Name: "SurfaceScale" Property Type: FLOAT</summary>
        D2D1_DISTANTDIFFUSE_PROP_SURFACE_SCALE = 3,

        /// <summary>Property Name: "Color" Property Type: D2D1_VECTOR_3F</summary>
        D2D1_DISTANTDIFFUSE_PROP_COLOR = 4,

        /// <summary>Property Name: "KernelUnitLength" Property Type: D2D1_VECTOR_2F</summary>
        D2D1_DISTANTDIFFUSE_PROP_KERNEL_UNIT_LENGTH = 5,

        /// <summary>Property Name: "ScaleMode" Property Type: D2D1_DISTANTDIFFUSE_SCALE_MODE</summary>
        D2D1_DISTANTDIFFUSE_PROP_SCALE_MODE = 6,

        D2D1_DISTANTDIFFUSE_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
