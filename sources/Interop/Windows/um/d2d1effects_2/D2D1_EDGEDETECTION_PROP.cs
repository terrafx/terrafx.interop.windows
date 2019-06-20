// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Edge Detection effect's top level properties.</summary>
    public enum D2D1_EDGEDETECTION_PROP : uint
    {
        /// <summary>Property Name: "Strength" Property Type: FLOAT</summary>
        D2D1_EDGEDETECTION_PROP_STRENGTH = 0,

        /// <summary>Property Name: "BlurRadius" Property Type: FLOAT</summary>
        D2D1_EDGEDETECTION_PROP_BLUR_RADIUS = 1,

        /// <summary>Property Name: "Mode" Property Type: D2D1_EDGEDETECTION_MODE</summary>
        D2D1_EDGEDETECTION_PROP_MODE = 2,

        /// <summary>Property Name: "OverlayEdges" Property Type: BOOL</summary>
        D2D1_EDGEDETECTION_PROP_OVERLAY_EDGES = 3,

        /// <summary>Property Name: "AlphaMode" Property Type: D2D1_ALPHA_MODE</summary>
        D2D1_EDGEDETECTION_PROP_ALPHA_MODE = 4,

        D2D1_EDGEDETECTION_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
