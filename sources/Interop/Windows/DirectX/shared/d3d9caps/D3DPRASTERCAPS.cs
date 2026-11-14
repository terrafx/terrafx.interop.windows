// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DPRASTERCAPS
{
    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_DITHER"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_DITHER 0x00000001L")]
    public const int D3DPRASTERCAPS_DITHER = 0x00000001;

    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_ZTEST"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_ZTEST 0x00000010L")]
    public const int D3DPRASTERCAPS_ZTEST = 0x00000010;

    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_FOGVERTEX"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_FOGVERTEX 0x00000080L")]
    public const int D3DPRASTERCAPS_FOGVERTEX = 0x00000080;

    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_FOGTABLE"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_FOGTABLE 0x00000100L")]
    public const int D3DPRASTERCAPS_FOGTABLE = 0x00000100;

    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_MIPMAPLODBIAS"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_MIPMAPLODBIAS 0x00002000L")]
    public const int D3DPRASTERCAPS_MIPMAPLODBIAS = 0x00002000;

    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_ZBUFFERLESSHSR"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_ZBUFFERLESSHSR 0x00008000L")]
    public const int D3DPRASTERCAPS_ZBUFFERLESSHSR = 0x00008000;

    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_FOGRANGE"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_FOGRANGE 0x00010000L")]
    public const int D3DPRASTERCAPS_FOGRANGE = 0x00010000;

    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_ANISOTROPY"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_ANISOTROPY 0x00020000L")]
    public const int D3DPRASTERCAPS_ANISOTROPY = 0x00020000;

    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_WBUFFER"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_WBUFFER 0x00040000L")]
    public const int D3DPRASTERCAPS_WBUFFER = 0x00040000;

    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_WFOG"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_WFOG 0x00100000L")]
    public const int D3DPRASTERCAPS_WFOG = 0x00100000;

    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_ZFOG"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_ZFOG 0x00200000L")]
    public const int D3DPRASTERCAPS_ZFOG = 0x00200000;

    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_COLORPERSPECTIVE"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_COLORPERSPECTIVE 0x00400000L")]
    public const int D3DPRASTERCAPS_COLORPERSPECTIVE = 0x00400000;

    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_SCISSORTEST"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_SCISSORTEST 0x01000000L")]
    public const int D3DPRASTERCAPS_SCISSORTEST = 0x01000000;

    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_SLOPESCALEDEPTHBIAS"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_SLOPESCALEDEPTHBIAS 0x02000000L")]
    public const int D3DPRASTERCAPS_SLOPESCALEDEPTHBIAS = 0x02000000;

    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_DEPTHBIAS"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_DEPTHBIAS 0x04000000L")]
    public const int D3DPRASTERCAPS_DEPTHBIAS = 0x04000000;

    /// <include file='D3DPRASTERCAPS.xml' path='doc/member[@name="D3DPRASTERCAPS.D3DPRASTERCAPS_MULTISAMPLE_TOGGLE"]/*' />
    [NativeTypeName("#define D3DPRASTERCAPS_MULTISAMPLE_TOGGLE 0x08000000L")]
    public const int D3DPRASTERCAPS_MULTISAMPLE_TOGGLE = 0x08000000;
}
