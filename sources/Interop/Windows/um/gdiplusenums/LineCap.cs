// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum LineCap
    {
        LineCapFlat = 0,
        LineCapSquare = 1,
        LineCapRound = 2,
        LineCapTriangle = 3,
        LineCapNoAnchor = 0x10,
        LineCapSquareAnchor = 0x11,
        LineCapRoundAnchor = 0x12,
        LineCapDiamondAnchor = 0x13,
        LineCapArrowAnchor = 0x14,
        LineCapCustom = 0xff,
        LineCapAnchorMask = 0xf0,
    }
}
