// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DCAPS3
{
    /// <include file='D3DCAPS3.xml' path='doc/member[@name="D3DCAPS3.D3DCAPS3_RESERVED"]/*' />
    [NativeTypeName("#define D3DCAPS3_RESERVED 0x8000001fL")]
    public const uint D3DCAPS3_RESERVED = 0x8000001f;

    /// <include file='D3DCAPS3.xml' path='doc/member[@name="D3DCAPS3.D3DCAPS3_ALPHA_FULLSCREEN_FLIP_OR_DISCARD"]/*' />
    [NativeTypeName("#define D3DCAPS3_ALPHA_FULLSCREEN_FLIP_OR_DISCARD 0x00000020L")]
    public const int D3DCAPS3_ALPHA_FULLSCREEN_FLIP_OR_DISCARD = 0x00000020;

    /// <include file='D3DCAPS3.xml' path='doc/member[@name="D3DCAPS3.D3DCAPS3_LINEAR_TO_SRGB_PRESENTATION"]/*' />
    [NativeTypeName("#define D3DCAPS3_LINEAR_TO_SRGB_PRESENTATION 0x00000080L")]
    public const int D3DCAPS3_LINEAR_TO_SRGB_PRESENTATION = 0x00000080;

    /// <include file='D3DCAPS3.xml' path='doc/member[@name="D3DCAPS3.D3DCAPS3_COPY_TO_VIDMEM"]/*' />
    [NativeTypeName("#define D3DCAPS3_COPY_TO_VIDMEM 0x00000100L")]
    public const int D3DCAPS3_COPY_TO_VIDMEM = 0x00000100;

    /// <include file='D3DCAPS3.xml' path='doc/member[@name="D3DCAPS3.D3DCAPS3_COPY_TO_SYSTEMMEM"]/*' />
    [NativeTypeName("#define D3DCAPS3_COPY_TO_SYSTEMMEM 0x00000200L")]
    public const int D3DCAPS3_COPY_TO_SYSTEMMEM = 0x00000200;

    /// <include file='D3DCAPS3.xml' path='doc/member[@name="D3DCAPS3.D3DCAPS3_DXVAHD"]/*' />
    [NativeTypeName("#define D3DCAPS3_DXVAHD 0x00000400L")]
    public const int D3DCAPS3_DXVAHD = 0x00000400;

    /// <include file='D3DCAPS3.xml' path='doc/member[@name="D3DCAPS3.D3DCAPS3_DXVAHD_LIMITED"]/*' />
    [NativeTypeName("#define D3DCAPS3_DXVAHD_LIMITED 0x00000800L")]
    public const int D3DCAPS3_DXVAHD_LIMITED = 0x00000800;
}
