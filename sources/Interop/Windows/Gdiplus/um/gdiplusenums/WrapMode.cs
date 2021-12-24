// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

/// <include file='WrapMode.xml' path='doc/member[@name="WrapMode"]/*' />
public enum WrapMode
{
    /// <include file='WrapMode.xml' path='doc/member[@name="WrapMode.WrapModeTile"]/*' />
    WrapModeTile,

    /// <include file='WrapMode.xml' path='doc/member[@name="WrapMode.WrapModeTileFlipX"]/*' />
    WrapModeTileFlipX,

    /// <include file='WrapMode.xml' path='doc/member[@name="WrapMode.WrapModeTileFlipY"]/*' />
    WrapModeTileFlipY,

    /// <include file='WrapMode.xml' path='doc/member[@name="WrapMode.WrapModeTileFlipXY"]/*' />
    WrapModeTileFlipXY,

    /// <include file='WrapMode.xml' path='doc/member[@name="WrapMode.WrapModeClamp"]/*' />
    WrapModeClamp,
}
