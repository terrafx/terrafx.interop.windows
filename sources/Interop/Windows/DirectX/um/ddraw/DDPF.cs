// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDPF
{
    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_ALPHAPIXELS"]/*' />
    [NativeTypeName("#define DDPF_ALPHAPIXELS 0x00000001l")]
    public const int DDPF_ALPHAPIXELS = 0x00000001;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_ALPHA"]/*' />
    [NativeTypeName("#define DDPF_ALPHA 0x00000002l")]
    public const int DDPF_ALPHA = 0x00000002;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_FOURCC"]/*' />
    [NativeTypeName("#define DDPF_FOURCC 0x00000004l")]
    public const int DDPF_FOURCC = 0x00000004;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_PALETTEINDEXED4"]/*' />
    [NativeTypeName("#define DDPF_PALETTEINDEXED4 0x00000008l")]
    public const int DDPF_PALETTEINDEXED4 = 0x00000008;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_PALETTEINDEXEDTO8"]/*' />
    [NativeTypeName("#define DDPF_PALETTEINDEXEDTO8 0x00000010l")]
    public const int DDPF_PALETTEINDEXEDTO8 = 0x00000010;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_PALETTEINDEXED8"]/*' />
    [NativeTypeName("#define DDPF_PALETTEINDEXED8 0x00000020l")]
    public const int DDPF_PALETTEINDEXED8 = 0x00000020;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_RGB"]/*' />
    [NativeTypeName("#define DDPF_RGB 0x00000040l")]
    public const int DDPF_RGB = 0x00000040;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_COMPRESSED"]/*' />
    [NativeTypeName("#define DDPF_COMPRESSED 0x00000080l")]
    public const int DDPF_COMPRESSED = 0x00000080;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_RGBTOYUV"]/*' />
    [NativeTypeName("#define DDPF_RGBTOYUV 0x00000100l")]
    public const int DDPF_RGBTOYUV = 0x00000100;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_YUV"]/*' />
    [NativeTypeName("#define DDPF_YUV 0x00000200l")]
    public const int DDPF_YUV = 0x00000200;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_ZBUFFER"]/*' />
    [NativeTypeName("#define DDPF_ZBUFFER 0x00000400l")]
    public const int DDPF_ZBUFFER = 0x00000400;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_PALETTEINDEXED1"]/*' />
    [NativeTypeName("#define DDPF_PALETTEINDEXED1 0x00000800l")]
    public const int DDPF_PALETTEINDEXED1 = 0x00000800;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_PALETTEINDEXED2"]/*' />
    [NativeTypeName("#define DDPF_PALETTEINDEXED2 0x00001000l")]
    public const int DDPF_PALETTEINDEXED2 = 0x00001000;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_ZPIXELS"]/*' />
    [NativeTypeName("#define DDPF_ZPIXELS 0x00002000l")]
    public const int DDPF_ZPIXELS = 0x00002000;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_STENCILBUFFER"]/*' />
    [NativeTypeName("#define DDPF_STENCILBUFFER 0x00004000l")]
    public const int DDPF_STENCILBUFFER = 0x00004000;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_ALPHAPREMULT"]/*' />
    [NativeTypeName("#define DDPF_ALPHAPREMULT 0x00008000l")]
    public const int DDPF_ALPHAPREMULT = 0x00008000;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_LUMINANCE"]/*' />
    [NativeTypeName("#define DDPF_LUMINANCE 0x00020000l")]
    public const int DDPF_LUMINANCE = 0x00020000;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_BUMPLUMINANCE"]/*' />
    [NativeTypeName("#define DDPF_BUMPLUMINANCE 0x00040000l")]
    public const int DDPF_BUMPLUMINANCE = 0x00040000;

    /// <include file='DDPF.xml' path='doc/member[@name="DDPF.DDPF_BUMPDUDV"]/*' />
    [NativeTypeName("#define DDPF_BUMPDUDV 0x00080000l")]
    public const int DDPF_BUMPDUDV = 0x00080000;
}
