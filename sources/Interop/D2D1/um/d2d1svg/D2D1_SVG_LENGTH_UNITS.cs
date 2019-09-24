// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies the units for an SVG length.</summary>
    public enum D2D1_SVG_LENGTH_UNITS : uint
    {
        /// <summary>The length is unitless.</summary>
        D2D1_SVG_LENGTH_UNITS_NUMBER = 0,

        /// <summary>The length is a percentage value.</summary>
        D2D1_SVG_LENGTH_UNITS_PERCENTAGE = 1,

        D2D1_SVG_LENGTH_UNITS_FORCE_DWORD = 0xFFFFFFFF
    }
}
