// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Posterize effect's top level properties.</summary>
    public enum D2D1_POSTERIZE_PROP : uint
    {
        /// <summary>Property Name: "RedValueCount" Property Type: UINT32</summary>
        D2D1_POSTERIZE_PROP_RED_VALUE_COUNT = 0,

        /// <summary>Property Name: "GreenValueCount" Property Type: UINT32</summary>
        D2D1_POSTERIZE_PROP_GREEN_VALUE_COUNT = 1,

        /// <summary>Property Name: "BlueValueCount" Property Type: UINT32</summary>
        D2D1_POSTERIZE_PROP_BLUE_VALUE_COUNT = 2,

        D2D1_POSTERIZE_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
