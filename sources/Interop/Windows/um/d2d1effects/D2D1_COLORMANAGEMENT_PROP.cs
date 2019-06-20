// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Color Management effect's top level properties.</summary>
    public enum D2D1_COLORMANAGEMENT_PROP : uint
    {
        /// <summary>Property Name: "SourceColorContext" Property Type: ID2D1ColorContext *</summary>
        D2D1_COLORMANAGEMENT_PROP_SOURCE_COLOR_CONTEXT = 0,

        /// <summary>Property Name: "SourceRenderingIntent" Property Type: D2D1_RENDERING_INTENT</summary>
        D2D1_COLORMANAGEMENT_PROP_SOURCE_RENDERING_INTENT = 1,

        /// <summary>Property Name: "DestinationColorContext" Property Type: ID2D1ColorContext *</summary>
        D2D1_COLORMANAGEMENT_PROP_DESTINATION_COLOR_CONTEXT = 2,

        /// <summary>Property Name: "DestinationRenderingIntent" Property Type: D2D1_RENDERING_INTENT</summary>
        D2D1_COLORMANAGEMENT_PROP_DESTINATION_RENDERING_INTENT = 3,

        /// <summary>Property Name: "AlphaMode" Property Type: D2D1_COLORMANAGEMENT_ALPHA_MODE</summary>
        D2D1_COLORMANAGEMENT_PROP_ALPHA_MODE = 4,

        /// <summary>Property Name: "Quality" Property Type: D2D1_COLORMANAGEMENT_QUALITY</summary>
        D2D1_COLORMANAGEMENT_PROP_QUALITY = 5,

        D2D1_COLORMANAGEMENT_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
