// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Sepia effect's top level properties.</summary>
    public enum D2D1_SEPIA_PROP : uint
    {
        /// <summary>Property Name: "Intensity" Property Type: FLOAT</summary>
        D2D1_SEPIA_PROP_INTENSITY = 0,

        /// <summary>Property Name: "AlphaMode" Property Type: D2D1_ALPHA_MODE</summary>
        D2D1_SEPIA_PROP_ALPHA_MODE = 1,

        D2D1_SEPIA_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
