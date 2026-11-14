// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDBLT
{
    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ALPHADEST"]/*' />
    [NativeTypeName("#define DDBLT_ALPHADEST 0x00000001l")]
    public const int DDBLT_ALPHADEST = 0x00000001;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ALPHADESTCONSTOVERRIDE"]/*' />
    [NativeTypeName("#define DDBLT_ALPHADESTCONSTOVERRIDE 0x00000002l")]
    public const int DDBLT_ALPHADESTCONSTOVERRIDE = 0x00000002;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ALPHADESTNEG"]/*' />
    [NativeTypeName("#define DDBLT_ALPHADESTNEG 0x00000004l")]
    public const int DDBLT_ALPHADESTNEG = 0x00000004;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ALPHADESTSURFACEOVERRIDE"]/*' />
    [NativeTypeName("#define DDBLT_ALPHADESTSURFACEOVERRIDE 0x00000008l")]
    public const int DDBLT_ALPHADESTSURFACEOVERRIDE = 0x00000008;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ALPHAEDGEBLEND"]/*' />
    [NativeTypeName("#define DDBLT_ALPHAEDGEBLEND 0x00000010l")]
    public const int DDBLT_ALPHAEDGEBLEND = 0x00000010;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ALPHASRC"]/*' />
    [NativeTypeName("#define DDBLT_ALPHASRC 0x00000020l")]
    public const int DDBLT_ALPHASRC = 0x00000020;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ALPHASRCCONSTOVERRIDE"]/*' />
    [NativeTypeName("#define DDBLT_ALPHASRCCONSTOVERRIDE 0x00000040l")]
    public const int DDBLT_ALPHASRCCONSTOVERRIDE = 0x00000040;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ALPHASRCNEG"]/*' />
    [NativeTypeName("#define DDBLT_ALPHASRCNEG 0x00000080l")]
    public const int DDBLT_ALPHASRCNEG = 0x00000080;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ALPHASRCSURFACEOVERRIDE"]/*' />
    [NativeTypeName("#define DDBLT_ALPHASRCSURFACEOVERRIDE 0x00000100l")]
    public const int DDBLT_ALPHASRCSURFACEOVERRIDE = 0x00000100;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ASYNC"]/*' />
    [NativeTypeName("#define DDBLT_ASYNC 0x00000200l")]
    public const int DDBLT_ASYNC = 0x00000200;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_COLORFILL"]/*' />
    [NativeTypeName("#define DDBLT_COLORFILL 0x00000400l")]
    public const int DDBLT_COLORFILL = 0x00000400;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_DDFX"]/*' />
    [NativeTypeName("#define DDBLT_DDFX 0x00000800l")]
    public const int DDBLT_DDFX = 0x00000800;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_DDROPS"]/*' />
    [NativeTypeName("#define DDBLT_DDROPS 0x00001000l")]
    public const int DDBLT_DDROPS = 0x00001000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_KEYDEST"]/*' />
    [NativeTypeName("#define DDBLT_KEYDEST 0x00002000l")]
    public const int DDBLT_KEYDEST = 0x00002000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_KEYDESTOVERRIDE"]/*' />
    [NativeTypeName("#define DDBLT_KEYDESTOVERRIDE 0x00004000l")]
    public const int DDBLT_KEYDESTOVERRIDE = 0x00004000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_KEYSRC"]/*' />
    [NativeTypeName("#define DDBLT_KEYSRC 0x00008000l")]
    public const int DDBLT_KEYSRC = 0x00008000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_KEYSRCOVERRIDE"]/*' />
    [NativeTypeName("#define DDBLT_KEYSRCOVERRIDE 0x00010000l")]
    public const int DDBLT_KEYSRCOVERRIDE = 0x00010000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ROP"]/*' />
    [NativeTypeName("#define DDBLT_ROP 0x00020000l")]
    public const int DDBLT_ROP = 0x00020000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ROTATIONANGLE"]/*' />
    [NativeTypeName("#define DDBLT_ROTATIONANGLE 0x00040000l")]
    public const int DDBLT_ROTATIONANGLE = 0x00040000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ZBUFFER"]/*' />
    [NativeTypeName("#define DDBLT_ZBUFFER 0x00080000l")]
    public const int DDBLT_ZBUFFER = 0x00080000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ZBUFFERDESTCONSTOVERRIDE"]/*' />
    [NativeTypeName("#define DDBLT_ZBUFFERDESTCONSTOVERRIDE 0x00100000l")]
    public const int DDBLT_ZBUFFERDESTCONSTOVERRIDE = 0x00100000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ZBUFFERDESTOVERRIDE"]/*' />
    [NativeTypeName("#define DDBLT_ZBUFFERDESTOVERRIDE 0x00200000l")]
    public const int DDBLT_ZBUFFERDESTOVERRIDE = 0x00200000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ZBUFFERSRCCONSTOVERRIDE"]/*' />
    [NativeTypeName("#define DDBLT_ZBUFFERSRCCONSTOVERRIDE 0x00400000l")]
    public const int DDBLT_ZBUFFERSRCCONSTOVERRIDE = 0x00400000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_ZBUFFERSRCOVERRIDE"]/*' />
    [NativeTypeName("#define DDBLT_ZBUFFERSRCOVERRIDE 0x00800000l")]
    public const int DDBLT_ZBUFFERSRCOVERRIDE = 0x00800000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_WAIT"]/*' />
    [NativeTypeName("#define DDBLT_WAIT 0x01000000l")]
    public const int DDBLT_WAIT = 0x01000000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_DEPTHFILL"]/*' />
    [NativeTypeName("#define DDBLT_DEPTHFILL 0x02000000l")]
    public const int DDBLT_DEPTHFILL = 0x02000000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_DONOTWAIT"]/*' />
    [NativeTypeName("#define DDBLT_DONOTWAIT 0x08000000l")]
    public const int DDBLT_DONOTWAIT = 0x08000000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_PRESENTATION"]/*' />
    [NativeTypeName("#define DDBLT_PRESENTATION 0x10000000l")]
    public const int DDBLT_PRESENTATION = 0x10000000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_LAST_PRESENTATION"]/*' />
    [NativeTypeName("#define DDBLT_LAST_PRESENTATION 0x20000000l")]
    public const int DDBLT_LAST_PRESENTATION = 0x20000000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_EXTENDED_FLAGS"]/*' />
    [NativeTypeName("#define DDBLT_EXTENDED_FLAGS 0x40000000l")]
    public const int DDBLT_EXTENDED_FLAGS = 0x40000000;

    /// <include file='DDBLT.xml' path='doc/member[@name="DDBLT.DDBLT_EXTENDED_LINEAR_CONTENT"]/*' />
    [NativeTypeName("#define DDBLT_EXTENDED_LINEAR_CONTENT 0x00000004l")]
    public const int DDBLT_EXTENDED_LINEAR_CONTENT = 0x00000004;
}
