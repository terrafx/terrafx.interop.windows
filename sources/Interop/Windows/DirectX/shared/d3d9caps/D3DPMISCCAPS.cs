// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DPMISCCAPS
{
    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_MASKZ"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_MASKZ 0x00000002L")]
    public const int D3DPMISCCAPS_MASKZ = 0x00000002;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_CULLNONE"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_CULLNONE 0x00000010L")]
    public const int D3DPMISCCAPS_CULLNONE = 0x00000010;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_CULLCW"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_CULLCW 0x00000020L")]
    public const int D3DPMISCCAPS_CULLCW = 0x00000020;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_CULLCCW"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_CULLCCW 0x00000040L")]
    public const int D3DPMISCCAPS_CULLCCW = 0x00000040;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_COLORWRITEENABLE"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_COLORWRITEENABLE 0x00000080L")]
    public const int D3DPMISCCAPS_COLORWRITEENABLE = 0x00000080;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_CLIPPLANESCALEDPOINTS"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_CLIPPLANESCALEDPOINTS 0x00000100L")]
    public const int D3DPMISCCAPS_CLIPPLANESCALEDPOINTS = 0x00000100;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_CLIPTLVERTS"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_CLIPTLVERTS 0x00000200L")]
    public const int D3DPMISCCAPS_CLIPTLVERTS = 0x00000200;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_TSSARGTEMP"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_TSSARGTEMP 0x00000400L")]
    public const int D3DPMISCCAPS_TSSARGTEMP = 0x00000400;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_BLENDOP"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_BLENDOP 0x00000800L")]
    public const int D3DPMISCCAPS_BLENDOP = 0x00000800;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_NULLREFERENCE"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_NULLREFERENCE 0x00001000L")]
    public const int D3DPMISCCAPS_NULLREFERENCE = 0x00001000;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_INDEPENDENTWRITEMASKS"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_INDEPENDENTWRITEMASKS 0x00004000L")]
    public const int D3DPMISCCAPS_INDEPENDENTWRITEMASKS = 0x00004000;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_PERSTAGECONSTANT"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_PERSTAGECONSTANT 0x00008000L")]
    public const int D3DPMISCCAPS_PERSTAGECONSTANT = 0x00008000;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_FOGANDSPECULARALPHA"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_FOGANDSPECULARALPHA 0x00010000L")]
    public const int D3DPMISCCAPS_FOGANDSPECULARALPHA = 0x00010000;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_SEPARATEALPHABLEND"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_SEPARATEALPHABLEND 0x00020000L")]
    public const int D3DPMISCCAPS_SEPARATEALPHABLEND = 0x00020000;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_MRTINDEPENDENTBITDEPTHS"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_MRTINDEPENDENTBITDEPTHS 0x00040000L")]
    public const int D3DPMISCCAPS_MRTINDEPENDENTBITDEPTHS = 0x00040000;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_MRTPOSTPIXELSHADERBLENDING"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_MRTPOSTPIXELSHADERBLENDING 0x00080000L")]
    public const int D3DPMISCCAPS_MRTPOSTPIXELSHADERBLENDING = 0x00080000;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_FOGVERTEXCLAMPED"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_FOGVERTEXCLAMPED 0x00100000L")]
    public const int D3DPMISCCAPS_FOGVERTEXCLAMPED = 0x00100000;

    /// <include file='D3DPMISCCAPS.xml' path='doc/member[@name="D3DPMISCCAPS.D3DPMISCCAPS_POSTBLENDSRGBCONVERT"]/*' />
    [NativeTypeName("#define D3DPMISCCAPS_POSTBLENDSRGBCONVERT 0x00200000L")]
    public const int D3DPMISCCAPS_POSTBLENDSRGBCONVERT = 0x00200000;
}
