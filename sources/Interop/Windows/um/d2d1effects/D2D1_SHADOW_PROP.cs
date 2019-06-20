// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Shadow effect's top level properties.</summary>
    public enum D2D1_SHADOW_PROP : uint
    {
        /// <summary>Property Name: "BlurStandardDeviation" Property Type: FLOAT</summary>
        D2D1_SHADOW_PROP_BLUR_STANDARD_DEVIATION = 0,

        /// <summary>Property Name: "Color" Property Type: D2D1_VECTOR_4F</summary>
        D2D1_SHADOW_PROP_COLOR = 1,

        /// <summary>Property Name: "Optimization" Property Type: D2D1_SHADOW_OPTIMIZATION</summary>
        D2D1_SHADOW_PROP_OPTIMIZATION = 2,

        D2D1_SHADOW_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
