// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Directional Blur effect's top level properties.</summary>
    public enum D2D1_DIRECTIONALBLUR_PROP : uint
    {
        /// <summary>Property Name: "StandardDeviation" Property Type: FLOAT</summary>
        D2D1_DIRECTIONALBLUR_PROP_STANDARD_DEVIATION = 0,

        /// <summary>Property Name: "Angle" Property Type: FLOAT</summary>
        D2D1_DIRECTIONALBLUR_PROP_ANGLE = 1,

        /// <summary>Property Name: "Optimization" Property Type: D2D1_DIRECTIONALBLUR_OPTIMIZATION</summary>
        D2D1_DIRECTIONALBLUR_PROP_OPTIMIZATION = 2,

        /// <summary>Property Name: "BorderMode" Property Type: D2D1_BORDER_MODE</summary>
        D2D1_DIRECTIONALBLUR_PROP_BORDER_MODE = 3,

        D2D1_DIRECTIONALBLUR_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
