// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DLINECAPS
{
    /// <include file='D3DLINECAPS.xml' path='doc/member[@name="D3DLINECAPS.D3DLINECAPS_TEXTURE"]/*' />
    [NativeTypeName("#define D3DLINECAPS_TEXTURE 0x00000001L")]
    public const int D3DLINECAPS_TEXTURE = 0x00000001;

    /// <include file='D3DLINECAPS.xml' path='doc/member[@name="D3DLINECAPS.D3DLINECAPS_ZTEST"]/*' />
    [NativeTypeName("#define D3DLINECAPS_ZTEST 0x00000002L")]
    public const int D3DLINECAPS_ZTEST = 0x00000002;

    /// <include file='D3DLINECAPS.xml' path='doc/member[@name="D3DLINECAPS.D3DLINECAPS_BLEND"]/*' />
    [NativeTypeName("#define D3DLINECAPS_BLEND 0x00000004L")]
    public const int D3DLINECAPS_BLEND = 0x00000004;

    /// <include file='D3DLINECAPS.xml' path='doc/member[@name="D3DLINECAPS.D3DLINECAPS_ALPHACMP"]/*' />
    [NativeTypeName("#define D3DLINECAPS_ALPHACMP 0x00000008L")]
    public const int D3DLINECAPS_ALPHACMP = 0x00000008;

    /// <include file='D3DLINECAPS.xml' path='doc/member[@name="D3DLINECAPS.D3DLINECAPS_FOG"]/*' />
    [NativeTypeName("#define D3DLINECAPS_FOG 0x00000010L")]
    public const int D3DLINECAPS_FOG = 0x00000010;

    /// <include file='D3DLINECAPS.xml' path='doc/member[@name="D3DLINECAPS.D3DLINECAPS_ANTIALIAS"]/*' />
    [NativeTypeName("#define D3DLINECAPS_ANTIALIAS 0x00000020L")]
    public const int D3DLINECAPS_ANTIALIAS = 0x00000020;
}
