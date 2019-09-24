// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Border effect's top level properties.</summary>
    public enum D2D1_BORDER_PROP : uint
    {
        /// <summary>Property Name: "EdgeModeX" Property Type: D2D1_BORDER_EDGE_MODE</summary>
        D2D1_BORDER_PROP_EDGE_MODE_X = 0,

        /// <summary>Property Name: "EdgeModeY" Property Type: D2D1_BORDER_EDGE_MODE</summary>
        D2D1_BORDER_PROP_EDGE_MODE_Y = 1,

        D2D1_BORDER_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
