// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

/// <include file='LineCap.xml' path='doc/member[@name="LineCap"]/*' />
public enum LineCap
{
    /// <include file='LineCap.xml' path='doc/member[@name="LineCap.LineCapFlat"]/*' />
    LineCapFlat = 0,

    /// <include file='LineCap.xml' path='doc/member[@name="LineCap.LineCapSquare"]/*' />
    LineCapSquare = 1,

    /// <include file='LineCap.xml' path='doc/member[@name="LineCap.LineCapRound"]/*' />
    LineCapRound = 2,

    /// <include file='LineCap.xml' path='doc/member[@name="LineCap.LineCapTriangle"]/*' />
    LineCapTriangle = 3,

    /// <include file='LineCap.xml' path='doc/member[@name="LineCap.LineCapNoAnchor"]/*' />
    LineCapNoAnchor = 0x10,

    /// <include file='LineCap.xml' path='doc/member[@name="LineCap.LineCapSquareAnchor"]/*' />
    LineCapSquareAnchor = 0x11,

    /// <include file='LineCap.xml' path='doc/member[@name="LineCap.LineCapRoundAnchor"]/*' />
    LineCapRoundAnchor = 0x12,

    /// <include file='LineCap.xml' path='doc/member[@name="LineCap.LineCapDiamondAnchor"]/*' />
    LineCapDiamondAnchor = 0x13,

    /// <include file='LineCap.xml' path='doc/member[@name="LineCap.LineCapArrowAnchor"]/*' />
    LineCapArrowAnchor = 0x14,

    /// <include file='LineCap.xml' path='doc/member[@name="LineCap.LineCapCustom"]/*' />
    LineCapCustom = 0xff,

    /// <include file='LineCap.xml' path='doc/member[@name="LineCap.LineCapAnchorMask"]/*' />
    LineCapAnchorMask = 0xf0,
}
