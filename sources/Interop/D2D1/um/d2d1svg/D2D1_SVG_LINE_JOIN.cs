// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1_LINE_JOIN;

namespace TerraFX.Interop
{
    /// <summary>Specifies a value for the SVG stroke-linejoin property.</summary>
    public enum D2D1_SVG_LINE_JOIN : uint
    {
        /// <summary>The property is set to SVG's 'bevel' value.</summary>
        D2D1_SVG_LINE_JOIN_BEVEL = D2D1_LINE_JOIN_BEVEL,

        /// <summary>The property is set to SVG's 'miter' value. Note that this is equivalent to D2D1_LINE_JOIN_MITER_OR_BEVEL, not D2D1_LINE_JOIN_MITER.</summary>
        D2D1_SVG_LINE_JOIN_MITER = D2D1_LINE_JOIN_MITER_OR_BEVEL,

        /// <summary>\ The property is set to SVG's 'round' value.</summary>
        D2D1_SVG_LINE_JOIN_ROUND = D2D1_LINE_JOIN_ROUND,

        D2D1_SVG_LINE_JOIN_FORCE_DWORD = 0xFFFFFFFF
    }
}
