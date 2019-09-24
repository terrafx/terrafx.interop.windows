// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1_CAP_STYLE;

namespace TerraFX.Interop
{
    /// <summary>Specifies a value for the SVG stroke-linecap property.</summary>
    public enum D2D1_SVG_LINE_CAP : uint
    {
        /// <summary>The property is set to SVG's 'butt' value.</summary>
        D2D1_SVG_LINE_CAP_BUTT = D2D1_CAP_STYLE_FLAT,

        /// <summary>The property is set to SVG's 'square' value.</summary>
        D2D1_SVG_LINE_CAP_SQUARE = D2D1_CAP_STYLE_SQUARE,

        /// <summary>The property is set to SVG's 'round' value.</summary>
        D2D1_SVG_LINE_CAP_ROUND = D2D1_CAP_STYLE_ROUND,

        D2D1_SVG_LINE_CAP_FORCE_DWORD = 0xFFFFFFFF
    }
}
