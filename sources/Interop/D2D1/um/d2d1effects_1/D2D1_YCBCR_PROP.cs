// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the YCbCr effect's top level properties.</summary>
    public enum D2D1_YCBCR_PROP : uint
    {
        /// <summary>Property Name: "ChromaSubsampling" Property Type: D2D1_YCBCR_CHROMA_SUBSAMPLING</summary>
        D2D1_YCBCR_PROP_CHROMA_SUBSAMPLING = 0,

        /// <summary>Property Name: "TransformMatrix" Property Type: D2D1_MATRIX_3X2_F</summary>
        D2D1_YCBCR_PROP_TRANSFORM_MATRIX = 1,

        /// <summary>Property Name: "InterpolationMode" Property Type: D2D1_YCBCR_INTERPOLATION_MODE</summary>
        D2D1_YCBCR_PROP_INTERPOLATION_MODE = 2,

        D2D1_YCBCR_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
