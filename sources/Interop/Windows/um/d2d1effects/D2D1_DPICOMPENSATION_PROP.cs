// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the DPI Compensation effect's top level properties.</summary>
    public enum D2D1_DPICOMPENSATION_PROP : uint
    {
        /// <summary>Property Name: "InterpolationMode" Property Type: D2D1_DPICOMPENSATION_INTERPOLATION_MODE</summary>
        D2D1_DPICOMPENSATION_PROP_INTERPOLATION_MODE = 0,

        /// <summary>Property Name: "BorderMode" Property Type: D2D1_BORDER_MODE</summary>
        D2D1_DPICOMPENSATION_PROP_BORDER_MODE = 1,

        /// <summary>Property Name: "InputDpi" Property Type: D2D1_VECTOR_2F</summary>
        D2D1_DPICOMPENSATION_PROP_INPUT_DPI = 2,

        D2D1_DPICOMPENSATION_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
