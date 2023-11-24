// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DWRITE_PAINT_COLOR.xml' path='doc/member[@name="DWRITE_PAINT_COLOR"]/*' />
public partial struct DWRITE_PAINT_COLOR
{
    /// <include file='DWRITE_PAINT_COLOR.xml' path='doc/member[@name="DWRITE_PAINT_COLOR.value"]/*' />
    [NativeTypeName("DWRITE_COLOR_F")]
    public DXGI_RGBA value;

    /// <include file='DWRITE_PAINT_COLOR.xml' path='doc/member[@name="DWRITE_PAINT_COLOR.paletteEntryIndex"]/*' />
    [NativeTypeName("UINT16")]
    public ushort paletteEntryIndex;

    /// <include file='DWRITE_PAINT_COLOR.xml' path='doc/member[@name="DWRITE_PAINT_COLOR.alphaMultiplier"]/*' />
    public float alphaMultiplier;

    /// <include file='DWRITE_PAINT_COLOR.xml' path='doc/member[@name="DWRITE_PAINT_COLOR.colorAttributes"]/*' />
    public DWRITE_PAINT_ATTRIBUTES colorAttributes;
}
