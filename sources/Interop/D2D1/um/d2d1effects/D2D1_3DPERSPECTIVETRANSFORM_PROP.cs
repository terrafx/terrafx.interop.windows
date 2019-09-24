// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the 3D Perspective Transform effect's top level properties.</summary>
    public enum D2D1_3DPERSPECTIVETRANSFORM_PROP : uint
    {
        /// <summary>Property Name: "InterpolationMode" Property Type: D2D1_3DPERSPECTIVETRANSFORM_INTERPOLATION_MODE</summary>
        D2D1_3DPERSPECTIVETRANSFORM_PROP_INTERPOLATION_MODE = 0,

        /// <summary>Property Name: "BorderMode" Property Type: D2D1_BORDER_MODE</summary>
        D2D1_3DPERSPECTIVETRANSFORM_PROP_BORDER_MODE = 1,

        /// <summary>Property Name: "Depth" Property Type: FLOAT</summary>
        D2D1_3DPERSPECTIVETRANSFORM_PROP_DEPTH = 2,

        /// <summary>Property Name: "PerspectiveOrigin" Property Type: D2D1_VECTOR_2F</summary>
        D2D1_3DPERSPECTIVETRANSFORM_PROP_PERSPECTIVE_ORIGIN = 3,

        /// <summary>Property Name: "LocalOffset" Property Type: D2D1_VECTOR_3F</summary>
        D2D1_3DPERSPECTIVETRANSFORM_PROP_LOCAL_OFFSET = 4,

        /// <summary>Property Name: "GlobalOffset" Property Type: D2D1_VECTOR_3F</summary>
        D2D1_3DPERSPECTIVETRANSFORM_PROP_GLOBAL_OFFSET = 5,

        /// <summary>Property Name: "RotationOrigin" Property Type: D2D1_VECTOR_3F</summary>
        D2D1_3DPERSPECTIVETRANSFORM_PROP_ROTATION_ORIGIN = 6,

        /// <summary>Property Name: "Rotation" Property Type: D2D1_VECTOR_3F</summary>
        D2D1_3DPERSPECTIVETRANSFORM_PROP_ROTATION = 7,

        D2D1_3DPERSPECTIVETRANSFORM_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
