// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDOVER
{
    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_ALPHADEST"]/*' />
    [NativeTypeName("#define DDOVER_ALPHADEST 0x00000001l")]
    public const int DDOVER_ALPHADEST = 0x00000001;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_ALPHADESTCONSTOVERRIDE"]/*' />
    [NativeTypeName("#define DDOVER_ALPHADESTCONSTOVERRIDE 0x00000002l")]
    public const int DDOVER_ALPHADESTCONSTOVERRIDE = 0x00000002;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_ALPHADESTNEG"]/*' />
    [NativeTypeName("#define DDOVER_ALPHADESTNEG 0x00000004l")]
    public const int DDOVER_ALPHADESTNEG = 0x00000004;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_ALPHADESTSURFACEOVERRIDE"]/*' />
    [NativeTypeName("#define DDOVER_ALPHADESTSURFACEOVERRIDE 0x00000008l")]
    public const int DDOVER_ALPHADESTSURFACEOVERRIDE = 0x00000008;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_ALPHAEDGEBLEND"]/*' />
    [NativeTypeName("#define DDOVER_ALPHAEDGEBLEND 0x00000010l")]
    public const int DDOVER_ALPHAEDGEBLEND = 0x00000010;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_ALPHASRC"]/*' />
    [NativeTypeName("#define DDOVER_ALPHASRC 0x00000020l")]
    public const int DDOVER_ALPHASRC = 0x00000020;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_ALPHASRCCONSTOVERRIDE"]/*' />
    [NativeTypeName("#define DDOVER_ALPHASRCCONSTOVERRIDE 0x00000040l")]
    public const int DDOVER_ALPHASRCCONSTOVERRIDE = 0x00000040;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_ALPHASRCNEG"]/*' />
    [NativeTypeName("#define DDOVER_ALPHASRCNEG 0x00000080l")]
    public const int DDOVER_ALPHASRCNEG = 0x00000080;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_ALPHASRCSURFACEOVERRIDE"]/*' />
    [NativeTypeName("#define DDOVER_ALPHASRCSURFACEOVERRIDE 0x00000100l")]
    public const int DDOVER_ALPHASRCSURFACEOVERRIDE = 0x00000100;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_HIDE"]/*' />
    [NativeTypeName("#define DDOVER_HIDE 0x00000200l")]
    public const int DDOVER_HIDE = 0x00000200;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_KEYDEST"]/*' />
    [NativeTypeName("#define DDOVER_KEYDEST 0x00000400l")]
    public const int DDOVER_KEYDEST = 0x00000400;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_KEYDESTOVERRIDE"]/*' />
    [NativeTypeName("#define DDOVER_KEYDESTOVERRIDE 0x00000800l")]
    public const int DDOVER_KEYDESTOVERRIDE = 0x00000800;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_KEYSRC"]/*' />
    [NativeTypeName("#define DDOVER_KEYSRC 0x00001000l")]
    public const int DDOVER_KEYSRC = 0x00001000;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_KEYSRCOVERRIDE"]/*' />
    [NativeTypeName("#define DDOVER_KEYSRCOVERRIDE 0x00002000l")]
    public const int DDOVER_KEYSRCOVERRIDE = 0x00002000;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_SHOW"]/*' />
    [NativeTypeName("#define DDOVER_SHOW 0x00004000l")]
    public const int DDOVER_SHOW = 0x00004000;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_ADDDIRTYRECT"]/*' />
    [NativeTypeName("#define DDOVER_ADDDIRTYRECT 0x00008000l")]
    public const int DDOVER_ADDDIRTYRECT = 0x00008000;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_REFRESHDIRTYRECTS"]/*' />
    [NativeTypeName("#define DDOVER_REFRESHDIRTYRECTS 0x00010000l")]
    public const int DDOVER_REFRESHDIRTYRECTS = 0x00010000;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_REFRESHALL"]/*' />
    [NativeTypeName("#define DDOVER_REFRESHALL 0x00020000l")]
    public const int DDOVER_REFRESHALL = 0x00020000;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_DDFX"]/*' />
    [NativeTypeName("#define DDOVER_DDFX 0x00080000l")]
    public const int DDOVER_DDFX = 0x00080000;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_AUTOFLIP"]/*' />
    [NativeTypeName("#define DDOVER_AUTOFLIP 0x00100000l")]
    public const int DDOVER_AUTOFLIP = 0x00100000;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_BOB"]/*' />
    [NativeTypeName("#define DDOVER_BOB 0x00200000l")]
    public const int DDOVER_BOB = 0x00200000;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_OVERRIDEBOBWEAVE"]/*' />
    [NativeTypeName("#define DDOVER_OVERRIDEBOBWEAVE 0x00400000l")]
    public const int DDOVER_OVERRIDEBOBWEAVE = 0x00400000;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_INTERLEAVED"]/*' />
    [NativeTypeName("#define DDOVER_INTERLEAVED 0x00800000l")]
    public const int DDOVER_INTERLEAVED = 0x00800000;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_BOBHARDWARE"]/*' />
    [NativeTypeName("#define DDOVER_BOBHARDWARE 0x01000000l")]
    public const int DDOVER_BOBHARDWARE = 0x01000000;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_ARGBSCALEFACTORS"]/*' />
    [NativeTypeName("#define DDOVER_ARGBSCALEFACTORS 0x02000000l")]
    public const int DDOVER_ARGBSCALEFACTORS = 0x02000000;

    /// <include file='DDOVER.xml' path='doc/member[@name="DDOVER.DDOVER_DEGRADEARGBSCALING"]/*' />
    [NativeTypeName("#define DDOVER_DEGRADEARGBSCALING 0x04000000l")]
    public const int DDOVER_DEGRADEARGBSCALING = 0x04000000;
}
