// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DFVF
{
    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_RESERVED0"]/*' />
    [NativeTypeName("#define D3DFVF_RESERVED0 0x001")]
    public const int D3DFVF_RESERVED0 = 0x001;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_POSITION_MASK"]/*' />
    [NativeTypeName("#define D3DFVF_POSITION_MASK 0x400E")]
    public const int D3DFVF_POSITION_MASK = 0x400E;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_XYZ"]/*' />
    [NativeTypeName("#define D3DFVF_XYZ 0x002")]
    public const int D3DFVF_XYZ = 0x002;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_XYZRHW"]/*' />
    [NativeTypeName("#define D3DFVF_XYZRHW 0x004")]
    public const int D3DFVF_XYZRHW = 0x004;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_XYZB1"]/*' />
    [NativeTypeName("#define D3DFVF_XYZB1 0x006")]
    public const int D3DFVF_XYZB1 = 0x006;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_XYZB2"]/*' />
    [NativeTypeName("#define D3DFVF_XYZB2 0x008")]
    public const int D3DFVF_XYZB2 = 0x008;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_XYZB3"]/*' />
    [NativeTypeName("#define D3DFVF_XYZB3 0x00a")]
    public const int D3DFVF_XYZB3 = 0x00a;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_XYZB4"]/*' />
    [NativeTypeName("#define D3DFVF_XYZB4 0x00c")]
    public const int D3DFVF_XYZB4 = 0x00c;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_XYZB5"]/*' />
    [NativeTypeName("#define D3DFVF_XYZB5 0x00e")]
    public const int D3DFVF_XYZB5 = 0x00e;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_XYZW"]/*' />
    [NativeTypeName("#define D3DFVF_XYZW 0x4002")]
    public const int D3DFVF_XYZW = 0x4002;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_NORMAL"]/*' />
    [NativeTypeName("#define D3DFVF_NORMAL 0x010")]
    public const int D3DFVF_NORMAL = 0x010;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_PSIZE"]/*' />
    [NativeTypeName("#define D3DFVF_PSIZE 0x020")]
    public const int D3DFVF_PSIZE = 0x020;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_DIFFUSE"]/*' />
    [NativeTypeName("#define D3DFVF_DIFFUSE 0x040")]
    public const int D3DFVF_DIFFUSE = 0x040;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_SPECULAR"]/*' />
    [NativeTypeName("#define D3DFVF_SPECULAR 0x080")]
    public const int D3DFVF_SPECULAR = 0x080;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_TEXCOUNT_MASK"]/*' />
    [NativeTypeName("#define D3DFVF_TEXCOUNT_MASK 0xf00")]
    public const int D3DFVF_TEXCOUNT_MASK = 0xf00;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_TEXCOUNT_SHIFT"]/*' />
    [NativeTypeName("#define D3DFVF_TEXCOUNT_SHIFT 8")]
    public const int D3DFVF_TEXCOUNT_SHIFT = 8;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_TEX0"]/*' />
    [NativeTypeName("#define D3DFVF_TEX0 0x000")]
    public const int D3DFVF_TEX0 = 0x000;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_TEX1"]/*' />
    [NativeTypeName("#define D3DFVF_TEX1 0x100")]
    public const int D3DFVF_TEX1 = 0x100;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_TEX2"]/*' />
    [NativeTypeName("#define D3DFVF_TEX2 0x200")]
    public const int D3DFVF_TEX2 = 0x200;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_TEX3"]/*' />
    [NativeTypeName("#define D3DFVF_TEX3 0x300")]
    public const int D3DFVF_TEX3 = 0x300;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_TEX4"]/*' />
    [NativeTypeName("#define D3DFVF_TEX4 0x400")]
    public const int D3DFVF_TEX4 = 0x400;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_TEX5"]/*' />
    [NativeTypeName("#define D3DFVF_TEX5 0x500")]
    public const int D3DFVF_TEX5 = 0x500;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_TEX6"]/*' />
    [NativeTypeName("#define D3DFVF_TEX6 0x600")]
    public const int D3DFVF_TEX6 = 0x600;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_TEX7"]/*' />
    [NativeTypeName("#define D3DFVF_TEX7 0x700")]
    public const int D3DFVF_TEX7 = 0x700;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_TEX8"]/*' />
    [NativeTypeName("#define D3DFVF_TEX8 0x800")]
    public const int D3DFVF_TEX8 = 0x800;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_LASTBETA_UBYTE4"]/*' />
    [NativeTypeName("#define D3DFVF_LASTBETA_UBYTE4 0x1000")]
    public const int D3DFVF_LASTBETA_UBYTE4 = 0x1000;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_LASTBETA_D3DCOLOR"]/*' />
    [NativeTypeName("#define D3DFVF_LASTBETA_D3DCOLOR 0x8000")]
    public const int D3DFVF_LASTBETA_D3DCOLOR = 0x8000;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_RESERVED2"]/*' />
    [NativeTypeName("#define D3DFVF_RESERVED2 0x6000")]
    public const int D3DFVF_RESERVED2 = 0x6000;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_TEXTUREFORMAT2"]/*' />
    [NativeTypeName("#define D3DFVF_TEXTUREFORMAT2 0")]
    public const int D3DFVF_TEXTUREFORMAT2 = 0;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_TEXTUREFORMAT1"]/*' />
    [NativeTypeName("#define D3DFVF_TEXTUREFORMAT1 3")]
    public const int D3DFVF_TEXTUREFORMAT1 = 3;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_TEXTUREFORMAT3"]/*' />
    [NativeTypeName("#define D3DFVF_TEXTUREFORMAT3 1")]
    public const int D3DFVF_TEXTUREFORMAT3 = 1;

    /// <include file='D3DFVF.xml' path='doc/member[@name="D3DFVF.D3DFVF_TEXTUREFORMAT4"]/*' />
    [NativeTypeName("#define D3DFVF_TEXTUREFORMAT4 2")]
    public const int D3DFVF_TEXTUREFORMAT4 = 2;
}
