// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Morphology effect's top level properties.</summary>
    public enum D2D1_MORPHOLOGY_PROP : uint
    {
        /// <summary>Property Name: "Mode" Property Type: D2D1_MORPHOLOGY_MODE</summary>
        D2D1_MORPHOLOGY_PROP_MODE = 0,

        /// <summary>Property Name: "Width" Property Type: UINT32</summary>
        D2D1_MORPHOLOGY_PROP_WIDTH = 1,

        /// <summary>Property Name: "Height" Property Type: UINT32</summary>
        D2D1_MORPHOLOGY_PROP_HEIGHT = 2,

        D2D1_MORPHOLOGY_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
