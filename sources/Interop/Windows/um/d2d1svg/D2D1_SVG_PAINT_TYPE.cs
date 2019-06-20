// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies the paint type for an SVG fill or stroke.</summary>
    public enum D2D1_SVG_PAINT_TYPE : uint
    {
        /// <summary>The fill or stroke is not rendered.</summary>
        D2D1_SVG_PAINT_TYPE_NONE = 0,

        /// <summary>A solid color is rendered.</summary>
        D2D1_SVG_PAINT_TYPE_COLOR = 1,

        /// <summary>The current color is rendered.</summary>
        D2D1_SVG_PAINT_TYPE_CURRENT_COLOR = 2,

        /// <summary>A paint server, defined by another element in the SVG document, is used.</summary>
        D2D1_SVG_PAINT_TYPE_URI = 3,

        /// <summary>A paint server, defined by another element in the SVG document, is used. If the paint server reference is invalid, fall back to D2D1_SVG_PAINT_TYPE_NONE.</summary>
        D2D1_SVG_PAINT_TYPE_URI_NONE = 4,

        /// <summary>A paint server, defined by another element in the SVG document, is used. If the paint server reference is invalid, fall back to D2D1_SVG_PAINT_TYPE_COLOR.</summary>
        D2D1_SVG_PAINT_TYPE_URI_COLOR = 5,

        /// <summary>A paint server, defined by another element in the SVG document, is used. If the paint server reference is invalid, fall back to D2D1_SVG_PAINT_TYPE_CURRENT_COLOR.</summary>
        D2D1_SVG_PAINT_TYPE_URI_CURRENT_COLOR = 6,

        D2D1_SVG_PAINT_TYPE_FORCE_DWORD = 0xFFFFFFFF
    }
}
