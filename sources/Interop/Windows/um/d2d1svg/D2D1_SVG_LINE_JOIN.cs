// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1_LINE_JOIN;

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum D2D1_SVG_LINE_JOIN : uint
    {
        D2D1_SVG_LINE_JOIN_BEVEL = D2D1_LINE_JOIN_BEVEL,
        D2D1_SVG_LINE_JOIN_MITER = D2D1_LINE_JOIN_MITER_OR_BEVEL,
        D2D1_SVG_LINE_JOIN_ROUND = D2D1_LINE_JOIN_ROUND,
        D2D1_SVG_LINE_JOIN_FORCE_DWORD = 0xffffffff,
    }
}
