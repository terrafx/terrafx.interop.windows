// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DDEVCAPS
{
    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_EXECUTESYSTEMMEMORY"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_EXECUTESYSTEMMEMORY 0x00000010L")]
    public const int D3DDEVCAPS_EXECUTESYSTEMMEMORY = 0x00000010;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_EXECUTEVIDEOMEMORY"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_EXECUTEVIDEOMEMORY 0x00000020L")]
    public const int D3DDEVCAPS_EXECUTEVIDEOMEMORY = 0x00000020;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_TLVERTEXSYSTEMMEMORY"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_TLVERTEXSYSTEMMEMORY 0x00000040L")]
    public const int D3DDEVCAPS_TLVERTEXSYSTEMMEMORY = 0x00000040;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_TLVERTEXVIDEOMEMORY"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_TLVERTEXVIDEOMEMORY 0x00000080L")]
    public const int D3DDEVCAPS_TLVERTEXVIDEOMEMORY = 0x00000080;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_TEXTURESYSTEMMEMORY"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_TEXTURESYSTEMMEMORY 0x00000100L")]
    public const int D3DDEVCAPS_TEXTURESYSTEMMEMORY = 0x00000100;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_TEXTUREVIDEOMEMORY"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_TEXTUREVIDEOMEMORY 0x00000200L")]
    public const int D3DDEVCAPS_TEXTUREVIDEOMEMORY = 0x00000200;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_DRAWPRIMTLVERTEX"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_DRAWPRIMTLVERTEX 0x00000400L")]
    public const int D3DDEVCAPS_DRAWPRIMTLVERTEX = 0x00000400;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_CANRENDERAFTERFLIP"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_CANRENDERAFTERFLIP 0x00000800L")]
    public const int D3DDEVCAPS_CANRENDERAFTERFLIP = 0x00000800;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_TEXTURENONLOCALVIDMEM"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_TEXTURENONLOCALVIDMEM 0x00001000L")]
    public const int D3DDEVCAPS_TEXTURENONLOCALVIDMEM = 0x00001000;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_DRAWPRIMITIVES2"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_DRAWPRIMITIVES2 0x00002000L")]
    public const int D3DDEVCAPS_DRAWPRIMITIVES2 = 0x00002000;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_SEPARATETEXTUREMEMORIES"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_SEPARATETEXTUREMEMORIES 0x00004000L")]
    public const int D3DDEVCAPS_SEPARATETEXTUREMEMORIES = 0x00004000;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_DRAWPRIMITIVES2EX"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_DRAWPRIMITIVES2EX 0x00008000L")]
    public const int D3DDEVCAPS_DRAWPRIMITIVES2EX = 0x00008000;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_HWTRANSFORMANDLIGHT"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_HWTRANSFORMANDLIGHT 0x00010000L")]
    public const int D3DDEVCAPS_HWTRANSFORMANDLIGHT = 0x00010000;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_CANBLTSYSTONONLOCAL"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_CANBLTSYSTONONLOCAL 0x00020000L")]
    public const int D3DDEVCAPS_CANBLTSYSTONONLOCAL = 0x00020000;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_HWRASTERIZATION"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_HWRASTERIZATION 0x00080000L")]
    public const int D3DDEVCAPS_HWRASTERIZATION = 0x00080000;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_PUREDEVICE"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_PUREDEVICE 0x00100000L")]
    public const int D3DDEVCAPS_PUREDEVICE = 0x00100000;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_QUINTICRTPATCHES"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_QUINTICRTPATCHES 0x00200000L")]
    public const int D3DDEVCAPS_QUINTICRTPATCHES = 0x00200000;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_RTPATCHES"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_RTPATCHES 0x00400000L")]
    public const int D3DDEVCAPS_RTPATCHES = 0x00400000;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_RTPATCHHANDLEZERO"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_RTPATCHHANDLEZERO 0x00800000L")]
    public const int D3DDEVCAPS_RTPATCHHANDLEZERO = 0x00800000;

    /// <include file='D3DDEVCAPS.xml' path='doc/member[@name="D3DDEVCAPS.D3DDEVCAPS_NPATCHES"]/*' />
    [NativeTypeName("#define D3DDEVCAPS_NPATCHES 0x01000000L")]
    public const int D3DDEVCAPS_NPATCHES = 0x01000000;
}
