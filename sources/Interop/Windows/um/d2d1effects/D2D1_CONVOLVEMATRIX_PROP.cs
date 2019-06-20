// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Convolve Matrix effect's top level properties.</summary>
    public enum D2D1_CONVOLVEMATRIX_PROP : uint
    {
        /// <summary>Property Name: "KernelUnitLength" Property Type: D2D1_VECTOR_2F</summary>
        D2D1_CONVOLVEMATRIX_PROP_KERNEL_UNIT_LENGTH = 0,

        /// <summary>Property Name: "ScaleMode" Property Type: D2D1_CONVOLVEMATRIX_SCALE_MODE</summary>
        D2D1_CONVOLVEMATRIX_PROP_SCALE_MODE = 1,

        /// <summary>Property Name: "KernelSizeX" Property Type: UINT32</summary>
        D2D1_CONVOLVEMATRIX_PROP_KERNEL_SIZE_X = 2,

        /// <summary>Property Name: "KernelSizeY" Property Type: UINT32</summary>
        D2D1_CONVOLVEMATRIX_PROP_KERNEL_SIZE_Y = 3,

        /// <summary>Property Name: "KernelMatrix" Property Type: (blob)</summary>
        D2D1_CONVOLVEMATRIX_PROP_KERNEL_MATRIX = 4,

        /// <summary>Property Name: "Divisor" Property Type: FLOAT</summary>
        D2D1_CONVOLVEMATRIX_PROP_DIVISOR = 5,

        /// <summary>Property Name: "Bias" Property Type: FLOAT</summary>
        D2D1_CONVOLVEMATRIX_PROP_BIAS = 6,

        /// <summary>Property Name: "KernelOffset" Property Type: D2D1_VECTOR_2F</summary>
        D2D1_CONVOLVEMATRIX_PROP_KERNEL_OFFSET = 7,

        /// <summary>Property Name: "PreserveAlpha" Property Type: BOOL</summary>
        D2D1_CONVOLVEMATRIX_PROP_PRESERVE_ALPHA = 8,

        /// <summary>Property Name: "BorderMode" Property Type: D2D1_BORDER_MODE</summary>
        D2D1_CONVOLVEMATRIX_PROP_BORDER_MODE = 9,

        /// <summary>Property Name: "ClampOutput" Property Type: BOOL</summary>
        D2D1_CONVOLVEMATRIX_PROP_CLAMP_OUTPUT = 10,

        D2D1_CONVOLVEMATRIX_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
