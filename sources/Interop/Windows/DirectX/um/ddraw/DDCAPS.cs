// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDCAPS
{
    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_3D"]/*' />
    [NativeTypeName("#define DDCAPS_3D 0x00000001l")]
    public const int DDCAPS_3D = 0x00000001;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_ALIGNBOUNDARYDEST"]/*' />
    [NativeTypeName("#define DDCAPS_ALIGNBOUNDARYDEST 0x00000002l")]
    public const int DDCAPS_ALIGNBOUNDARYDEST = 0x00000002;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_ALIGNSIZEDEST"]/*' />
    [NativeTypeName("#define DDCAPS_ALIGNSIZEDEST 0x00000004l")]
    public const int DDCAPS_ALIGNSIZEDEST = 0x00000004;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_ALIGNBOUNDARYSRC"]/*' />
    [NativeTypeName("#define DDCAPS_ALIGNBOUNDARYSRC 0x00000008l")]
    public const int DDCAPS_ALIGNBOUNDARYSRC = 0x00000008;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_ALIGNSIZESRC"]/*' />
    [NativeTypeName("#define DDCAPS_ALIGNSIZESRC 0x00000010l")]
    public const int DDCAPS_ALIGNSIZESRC = 0x00000010;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_ALIGNSTRIDE"]/*' />
    [NativeTypeName("#define DDCAPS_ALIGNSTRIDE 0x00000020l")]
    public const int DDCAPS_ALIGNSTRIDE = 0x00000020;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_BLT"]/*' />
    [NativeTypeName("#define DDCAPS_BLT 0x00000040l")]
    public const int DDCAPS_BLT = 0x00000040;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_BLTQUEUE"]/*' />
    [NativeTypeName("#define DDCAPS_BLTQUEUE 0x00000080l")]
    public const int DDCAPS_BLTQUEUE = 0x00000080;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_BLTFOURCC"]/*' />
    [NativeTypeName("#define DDCAPS_BLTFOURCC 0x00000100l")]
    public const int DDCAPS_BLTFOURCC = 0x00000100;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_BLTSTRETCH"]/*' />
    [NativeTypeName("#define DDCAPS_BLTSTRETCH 0x00000200l")]
    public const int DDCAPS_BLTSTRETCH = 0x00000200;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_GDI"]/*' />
    [NativeTypeName("#define DDCAPS_GDI 0x00000400l")]
    public const int DDCAPS_GDI = 0x00000400;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_OVERLAY"]/*' />
    [NativeTypeName("#define DDCAPS_OVERLAY 0x00000800l")]
    public const int DDCAPS_OVERLAY = 0x00000800;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_OVERLAYCANTCLIP"]/*' />
    [NativeTypeName("#define DDCAPS_OVERLAYCANTCLIP 0x00001000l")]
    public const int DDCAPS_OVERLAYCANTCLIP = 0x00001000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_OVERLAYFOURCC"]/*' />
    [NativeTypeName("#define DDCAPS_OVERLAYFOURCC 0x00002000l")]
    public const int DDCAPS_OVERLAYFOURCC = 0x00002000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_OVERLAYSTRETCH"]/*' />
    [NativeTypeName("#define DDCAPS_OVERLAYSTRETCH 0x00004000l")]
    public const int DDCAPS_OVERLAYSTRETCH = 0x00004000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_PALETTE"]/*' />
    [NativeTypeName("#define DDCAPS_PALETTE 0x00008000l")]
    public const int DDCAPS_PALETTE = 0x00008000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_PALETTEVSYNC"]/*' />
    [NativeTypeName("#define DDCAPS_PALETTEVSYNC 0x00010000l")]
    public const int DDCAPS_PALETTEVSYNC = 0x00010000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_READSCANLINE"]/*' />
    [NativeTypeName("#define DDCAPS_READSCANLINE 0x00020000l")]
    public const int DDCAPS_READSCANLINE = 0x00020000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_RESERVED1"]/*' />
    [NativeTypeName("#define DDCAPS_RESERVED1 0x00040000l")]
    public const int DDCAPS_RESERVED1 = 0x00040000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_VBI"]/*' />
    [NativeTypeName("#define DDCAPS_VBI 0x00080000l")]
    public const int DDCAPS_VBI = 0x00080000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_ZBLTS"]/*' />
    [NativeTypeName("#define DDCAPS_ZBLTS 0x00100000l")]
    public const int DDCAPS_ZBLTS = 0x00100000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_ZOVERLAYS"]/*' />
    [NativeTypeName("#define DDCAPS_ZOVERLAYS 0x00200000l")]
    public const int DDCAPS_ZOVERLAYS = 0x00200000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_COLORKEY"]/*' />
    [NativeTypeName("#define DDCAPS_COLORKEY 0x00400000l")]
    public const int DDCAPS_COLORKEY = 0x00400000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_ALPHA"]/*' />
    [NativeTypeName("#define DDCAPS_ALPHA 0x00800000l")]
    public const int DDCAPS_ALPHA = 0x00800000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_COLORKEYHWASSIST"]/*' />
    [NativeTypeName("#define DDCAPS_COLORKEYHWASSIST 0x01000000l")]
    public const int DDCAPS_COLORKEYHWASSIST = 0x01000000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_NOHARDWARE"]/*' />
    [NativeTypeName("#define DDCAPS_NOHARDWARE 0x02000000l")]
    public const int DDCAPS_NOHARDWARE = 0x02000000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_BLTCOLORFILL"]/*' />
    [NativeTypeName("#define DDCAPS_BLTCOLORFILL 0x04000000l")]
    public const int DDCAPS_BLTCOLORFILL = 0x04000000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_BANKSWITCHED"]/*' />
    [NativeTypeName("#define DDCAPS_BANKSWITCHED 0x08000000l")]
    public const int DDCAPS_BANKSWITCHED = 0x08000000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_BLTDEPTHFILL"]/*' />
    [NativeTypeName("#define DDCAPS_BLTDEPTHFILL 0x10000000l")]
    public const int DDCAPS_BLTDEPTHFILL = 0x10000000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_CANCLIP"]/*' />
    [NativeTypeName("#define DDCAPS_CANCLIP 0x20000000l")]
    public const int DDCAPS_CANCLIP = 0x20000000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_CANCLIPSTRETCHED"]/*' />
    [NativeTypeName("#define DDCAPS_CANCLIPSTRETCHED 0x40000000l")]
    public const int DDCAPS_CANCLIPSTRETCHED = 0x40000000;

    /// <include file='DDCAPS.xml' path='doc/member[@name="DDCAPS.DDCAPS_CANBLTSYSMEM"]/*' />
    [NativeTypeName("#define DDCAPS_CANBLTSYSMEM 0x80000000l")]
    public const uint DDCAPS_CANBLTSYSMEM = 0x80000000;
}
