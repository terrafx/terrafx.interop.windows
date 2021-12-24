// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Gdiplus.BrushType;

namespace TerraFX.Interop.Gdiplus;

/// <include file='PenType.xml' path='doc/member[@name="PenType"]/*' />
public enum PenType
{
    /// <include file='PenType.xml' path='doc/member[@name="PenType.PenTypeSolidColor"]/*' />
    PenTypeSolidColor = BrushTypeSolidColor,

    /// <include file='PenType.xml' path='doc/member[@name="PenType.PenTypeHatchFill"]/*' />
    PenTypeHatchFill = BrushTypeHatchFill,

    /// <include file='PenType.xml' path='doc/member[@name="PenType.PenTypeTextureFill"]/*' />
    PenTypeTextureFill = BrushTypeTextureFill,

    /// <include file='PenType.xml' path='doc/member[@name="PenType.PenTypePathGradient"]/*' />
    PenTypePathGradient = BrushTypePathGradient,

    /// <include file='PenType.xml' path='doc/member[@name="PenType.PenTypeLinearGradient"]/*' />
    PenTypeLinearGradient = BrushTypeLinearGradient,

    /// <include file='PenType.xml' path='doc/member[@name="PenType.PenTypeUnknown"]/*' />
    PenTypeUnknown = -1,
}
