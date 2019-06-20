// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Chroma Key effect's top level properties.</summary>
    public enum D2D1_CHROMAKEY_PROP : uint
    {
        /// <summary>Property Name: "Color" Property Type: D2D1_VECTOR_3F</summary>
        D2D1_CHROMAKEY_PROP_COLOR = 0,

        /// <summary>Property Name: "Tolerance" Property Type: FLOAT</summary>
        D2D1_CHROMAKEY_PROP_TOLERANCE = 1,

        /// <summary>Property Name: "InvertAlpha" Property Type: BOOL</summary>
        D2D1_CHROMAKEY_PROP_INVERT_ALPHA = 2,

        /// <summary>Property Name: "Feather" Property Type: BOOL</summary>
        D2D1_CHROMAKEY_PROP_FEATHER = 3,

        D2D1_CHROMAKEY_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
