// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Vignette effect's top level properties.</summary>
    public enum D2D1_VIGNETTE_PROP : uint
    {
        /// <summary>Property Name: "Color" Property Type: D2D1_VECTOR_4F</summary>
        D2D1_VIGNETTE_PROP_COLOR = 0,

        /// <summary>Property Name: "TransitionSize" Property Type: FLOAT</summary>
        D2D1_VIGNETTE_PROP_TRANSITION_SIZE = 1,

        /// <summary>Property Name: "Strength" Property Type: FLOAT</summary>
        D2D1_VIGNETTE_PROP_STRENGTH = 2,

        D2D1_VIGNETTE_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
