// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DPTADDRESSCAPS
{
    /// <include file='D3DPTADDRESSCAPS.xml' path='doc/member[@name="D3DPTADDRESSCAPS.D3DPTADDRESSCAPS_WRAP"]/*' />
    [NativeTypeName("#define D3DPTADDRESSCAPS_WRAP 0x00000001L")]
    public const int D3DPTADDRESSCAPS_WRAP = 0x00000001;

    /// <include file='D3DPTADDRESSCAPS.xml' path='doc/member[@name="D3DPTADDRESSCAPS.D3DPTADDRESSCAPS_MIRROR"]/*' />
    [NativeTypeName("#define D3DPTADDRESSCAPS_MIRROR 0x00000002L")]
    public const int D3DPTADDRESSCAPS_MIRROR = 0x00000002;

    /// <include file='D3DPTADDRESSCAPS.xml' path='doc/member[@name="D3DPTADDRESSCAPS.D3DPTADDRESSCAPS_CLAMP"]/*' />
    [NativeTypeName("#define D3DPTADDRESSCAPS_CLAMP 0x00000004L")]
    public const int D3DPTADDRESSCAPS_CLAMP = 0x00000004;

    /// <include file='D3DPTADDRESSCAPS.xml' path='doc/member[@name="D3DPTADDRESSCAPS.D3DPTADDRESSCAPS_BORDER"]/*' />
    [NativeTypeName("#define D3DPTADDRESSCAPS_BORDER 0x00000008L")]
    public const int D3DPTADDRESSCAPS_BORDER = 0x00000008;

    /// <include file='D3DPTADDRESSCAPS.xml' path='doc/member[@name="D3DPTADDRESSCAPS.D3DPTADDRESSCAPS_INDEPENDENTUV"]/*' />
    [NativeTypeName("#define D3DPTADDRESSCAPS_INDEPENDENTUV 0x00000010L")]
    public const int D3DPTADDRESSCAPS_INDEPENDENTUV = 0x00000010;

    /// <include file='D3DPTADDRESSCAPS.xml' path='doc/member[@name="D3DPTADDRESSCAPS.D3DPTADDRESSCAPS_MIRRORONCE"]/*' />
    [NativeTypeName("#define D3DPTADDRESSCAPS_MIRRORONCE 0x00000020L")]
    public const int D3DPTADDRESSCAPS_MIRRORONCE = 0x00000020;
}
