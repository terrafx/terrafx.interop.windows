// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Contrast effect's top level properties.</summary>
    public enum D2D1_CONTRAST_PROP : uint
    {
        /// <summary>Property Name: "Contrast" Property Type: FLOAT</summary>
        D2D1_CONTRAST_PROP_CONTRAST = 0,

        /// <summary>Property Name: "ClampInput" Property Type: BOOL</summary>
        D2D1_CONTRAST_PROP_CLAMP_INPUT = 1,

        D2D1_CONTRAST_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
