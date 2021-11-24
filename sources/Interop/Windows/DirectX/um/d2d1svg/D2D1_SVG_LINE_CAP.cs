// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.DirectX.D2D1_CAP_STYLE;

namespace TerraFX.Interop.DirectX;

public enum D2D1_SVG_LINE_CAP : uint
{
    D2D1_SVG_LINE_CAP_BUTT = D2D1_CAP_STYLE_FLAT,
    D2D1_SVG_LINE_CAP_SQUARE = D2D1_CAP_STYLE_SQUARE,
    D2D1_SVG_LINE_CAP_ROUND = D2D1_CAP_STYLE_ROUND,
    D2D1_SVG_LINE_CAP_FORCE_DWORD = 0xffffffff,
}
