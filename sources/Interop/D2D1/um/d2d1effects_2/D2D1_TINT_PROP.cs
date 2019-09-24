// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Tint effect's top level properties.</summary>
    public enum D2D1_TINT_PROP : uint
    {
        /// <summary>Property Name: "Color" Property Type: D2D1_VECTOR_4F</summary>
        D2D1_TINT_PROP_COLOR = 0,

        /// <summary>Property Name: "ClampOutput" Property Type: BOOL</summary>
        D2D1_TINT_PROP_CLAMP_OUTPUT = 1,

        D2D1_TINT_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
