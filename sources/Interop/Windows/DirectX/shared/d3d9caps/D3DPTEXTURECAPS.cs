// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DPTEXTURECAPS
{
    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_PERSPECTIVE"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_PERSPECTIVE 0x00000001L")]
    public const int D3DPTEXTURECAPS_PERSPECTIVE = 0x00000001;

    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_POW2"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_POW2 0x00000002L")]
    public const int D3DPTEXTURECAPS_POW2 = 0x00000002;

    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_ALPHA"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_ALPHA 0x00000004L")]
    public const int D3DPTEXTURECAPS_ALPHA = 0x00000004;

    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_SQUAREONLY"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_SQUAREONLY 0x00000020L")]
    public const int D3DPTEXTURECAPS_SQUAREONLY = 0x00000020;

    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_TEXREPEATNOTSCALEDBYSIZE"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_TEXREPEATNOTSCALEDBYSIZE 0x00000040L")]
    public const int D3DPTEXTURECAPS_TEXREPEATNOTSCALEDBYSIZE = 0x00000040;

    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_ALPHAPALETTE"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_ALPHAPALETTE 0x00000080L")]
    public const int D3DPTEXTURECAPS_ALPHAPALETTE = 0x00000080;

    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_NONPOW2CONDITIONAL"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_NONPOW2CONDITIONAL 0x00000100L")]
    public const int D3DPTEXTURECAPS_NONPOW2CONDITIONAL = 0x00000100;

    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_PROJECTED"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_PROJECTED 0x00000400L")]
    public const int D3DPTEXTURECAPS_PROJECTED = 0x00000400;

    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_CUBEMAP"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_CUBEMAP 0x00000800L")]
    public const int D3DPTEXTURECAPS_CUBEMAP = 0x00000800;

    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_VOLUMEMAP"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_VOLUMEMAP 0x00002000L")]
    public const int D3DPTEXTURECAPS_VOLUMEMAP = 0x00002000;

    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_MIPMAP"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_MIPMAP 0x00004000L")]
    public const int D3DPTEXTURECAPS_MIPMAP = 0x00004000;

    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_MIPVOLUMEMAP"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_MIPVOLUMEMAP 0x00008000L")]
    public const int D3DPTEXTURECAPS_MIPVOLUMEMAP = 0x00008000;

    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_MIPCUBEMAP"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_MIPCUBEMAP 0x00010000L")]
    public const int D3DPTEXTURECAPS_MIPCUBEMAP = 0x00010000;

    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_CUBEMAP_POW2"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_CUBEMAP_POW2 0x00020000L")]
    public const int D3DPTEXTURECAPS_CUBEMAP_POW2 = 0x00020000;

    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_VOLUMEMAP_POW2"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_VOLUMEMAP_POW2 0x00040000L")]
    public const int D3DPTEXTURECAPS_VOLUMEMAP_POW2 = 0x00040000;

    /// <include file='D3DPTEXTURECAPS.xml' path='doc/member[@name="D3DPTEXTURECAPS.D3DPTEXTURECAPS_NOPROJECTEDBUMPENV"]/*' />
    [NativeTypeName("#define D3DPTEXTURECAPS_NOPROJECTEDBUMPENV 0x00200000L")]
    public const int D3DPTEXTURECAPS_NOPROJECTEDBUMPENV = 0x00200000;
}
