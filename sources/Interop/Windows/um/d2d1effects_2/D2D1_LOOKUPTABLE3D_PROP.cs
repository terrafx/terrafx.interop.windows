// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Lookup Table 3D effect's top level properties.</summary>
    public enum D2D1_LOOKUPTABLE3D_PROP : uint
    {
        /// <summary>Property Name: "Lut" Property Type: IUnknown *</summary>
        D2D1_LOOKUPTABLE3D_PROP_LUT = 0,

        /// <summary>Property Name: "AlphaMode" Property Type: D2D1_ALPHA_MODE</summary>
        D2D1_LOOKUPTABLE3D_PROP_ALPHA_MODE = 1,

        D2D1_LOOKUPTABLE3D_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
