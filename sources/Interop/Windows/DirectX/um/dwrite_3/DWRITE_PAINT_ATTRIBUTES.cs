// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DWRITE_PAINT_ATTRIBUTES.xml' path='doc/member[@name="DWRITE_PAINT_ATTRIBUTES"]/*' />
public enum DWRITE_PAINT_ATTRIBUTES
{
    /// <include file='DWRITE_PAINT_ATTRIBUTES.xml' path='doc/member[@name="DWRITE_PAINT_ATTRIBUTES.DWRITE_PAINT_ATTRIBUTES_NONE"]/*' />
    DWRITE_PAINT_ATTRIBUTES_NONE = 0,

    /// <include file='DWRITE_PAINT_ATTRIBUTES.xml' path='doc/member[@name="DWRITE_PAINT_ATTRIBUTES.DWRITE_PAINT_ATTRIBUTES_USES_PALETTE"]/*' />
    DWRITE_PAINT_ATTRIBUTES_USES_PALETTE = 0x01,

    /// <include file='DWRITE_PAINT_ATTRIBUTES.xml' path='doc/member[@name="DWRITE_PAINT_ATTRIBUTES.DWRITE_PAINT_ATTRIBUTES_USES_TEXT_COLOR"]/*' />
    DWRITE_PAINT_ATTRIBUTES_USES_TEXT_COLOR = 0x02,
}
