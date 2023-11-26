// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DWRITE_BITMAP_DATA_BGRA32.xml' path='doc/member[@name="DWRITE_BITMAP_DATA_BGRA32"]/*' />
public unsafe partial struct DWRITE_BITMAP_DATA_BGRA32
{
    /// <include file='DWRITE_BITMAP_DATA_BGRA32.xml' path='doc/member[@name="DWRITE_BITMAP_DATA_BGRA32.width"]/*' />
    [NativeTypeName("UINT32")]
    public uint width;

    /// <include file='DWRITE_BITMAP_DATA_BGRA32.xml' path='doc/member[@name="DWRITE_BITMAP_DATA_BGRA32.height"]/*' />
    [NativeTypeName("UINT32")]
    public uint height;

    /// <include file='DWRITE_BITMAP_DATA_BGRA32.xml' path='doc/member[@name="DWRITE_BITMAP_DATA_BGRA32.pixels"]/*' />
    [NativeTypeName("UINT32 *")]
    public uint* pixels;
}
