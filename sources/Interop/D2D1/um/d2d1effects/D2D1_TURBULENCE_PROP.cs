// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Turbulence effect's top level properties.</summary>
    public enum D2D1_TURBULENCE_PROP : uint
    {
        /// <summary>Property Name: "Offset" Property Type: D2D1_VECTOR_2F</summary>
        D2D1_TURBULENCE_PROP_OFFSET = 0,

        /// <summary>Property Name: "Size" Property Type: D2D1_VECTOR_2F</summary>
        D2D1_TURBULENCE_PROP_SIZE = 1,

        /// <summary>Property Name: "BaseFrequency" Property Type: D2D1_VECTOR_2F</summary>
        D2D1_TURBULENCE_PROP_BASE_FREQUENCY = 2,

        /// <summary>Property Name: "NumOctaves" Property Type: UINT32</summary>
        D2D1_TURBULENCE_PROP_NUM_OCTAVES = 3,

        /// <summary>Property Name: "Seed" Property Type: INT32</summary>
        D2D1_TURBULENCE_PROP_SEED = 4,

        /// <summary>Property Name: "Noise" Property Type: D2D1_TURBULENCE_NOISE</summary>
        D2D1_TURBULENCE_PROP_NOISE = 5,

        /// <summary>Property Name: "Stitchable" Property Type: BOOL</summary>
        D2D1_TURBULENCE_PROP_STITCHABLE = 6,

        D2D1_TURBULENCE_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
