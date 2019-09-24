// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Highlights and Shadows effect's top level properties.</summary>
    public enum D2D1_HIGHLIGHTSANDSHADOWS_PROP : uint
    {
        /// <summary>Property Name: "Highlights" Property Type: FLOAT</summary>
        D2D1_HIGHLIGHTSANDSHADOWS_PROP_HIGHLIGHTS = 0,

        /// <summary>Property Name: "Shadows" Property Type: FLOAT</summary>
        D2D1_HIGHLIGHTSANDSHADOWS_PROP_SHADOWS = 1,

        /// <summary>Property Name: "Clarity" Property Type: FLOAT</summary>
        D2D1_HIGHLIGHTSANDSHADOWS_PROP_CLARITY = 2,

        /// <summary>Property Name: "InputGamma" Property Type: D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA</summary>
        D2D1_HIGHLIGHTSANDSHADOWS_PROP_INPUT_GAMMA = 3,

        /// <summary>Property Name: "MaskBlurRadius" Property Type: FLOAT</summary>
        D2D1_HIGHLIGHTSANDSHADOWS_PROP_MASK_BLUR_RADIUS = 4,

        D2D1_HIGHLIGHTSANDSHADOWS_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
