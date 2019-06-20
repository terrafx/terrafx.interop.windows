// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Straighten effect's top level properties.</summary>
    public enum D2D1_STRAIGHTEN_PROP : uint
    {
        /// <summary>Property Name: "Angle" Property Type: FLOAT</summary>
        D2D1_STRAIGHTEN_PROP_ANGLE = 0,

        /// <summary>Property Name: "MaintainSize" Property Type: BOOL</summary>
        D2D1_STRAIGHTEN_PROP_MAINTAIN_SIZE = 1,

        /// <summary>Property Name: "ScaleMode" Property Type: D2D1_STRAIGHTEN_SCALE_MODE</summary>
        D2D1_STRAIGHTEN_PROP_SCALE_MODE = 2,

        D2D1_STRAIGHTEN_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
