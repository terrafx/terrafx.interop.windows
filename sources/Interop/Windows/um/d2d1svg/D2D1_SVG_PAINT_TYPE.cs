// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_SVG_PAINT_TYPE : uint
    {
        D2D1_SVG_PAINT_TYPE_NONE = 0,
        D2D1_SVG_PAINT_TYPE_COLOR = 1,
        D2D1_SVG_PAINT_TYPE_CURRENT_COLOR = 2,
        D2D1_SVG_PAINT_TYPE_URI = 3,
        D2D1_SVG_PAINT_TYPE_URI_NONE = 4,
        D2D1_SVG_PAINT_TYPE_URI_COLOR = 5,
        D2D1_SVG_PAINT_TYPE_URI_CURRENT_COLOR = 6,
        D2D1_SVG_PAINT_TYPE_FORCE_DWORD = 0xffffffff,
    }
}
