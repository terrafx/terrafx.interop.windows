// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Temperature And Tint effect's top level properties.</summary>
    public enum D2D1_TEMPERATUREANDTINT_PROP : uint
    {
        /// <summary>Property Name: "Temperature" Property Type: FLOAT</summary>
        D2D1_TEMPERATUREANDTINT_PROP_TEMPERATURE = 0,

        /// <summary>Property Name: "Tint" Property Type: FLOAT</summary>
        D2D1_TEMPERATUREANDTINT_PROP_TINT = 1,

        D2D1_TEMPERATUREANDTINT_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
