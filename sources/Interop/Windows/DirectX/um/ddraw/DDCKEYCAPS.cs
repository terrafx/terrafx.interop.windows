// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDCKEYCAPS
{
    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_DESTBLT"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_DESTBLT 0x00000001l")]
    public const int DDCKEYCAPS_DESTBLT = 0x00000001;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_DESTBLTCLRSPACE"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_DESTBLTCLRSPACE 0x00000002l")]
    public const int DDCKEYCAPS_DESTBLTCLRSPACE = 0x00000002;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_DESTBLTCLRSPACEYUV"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_DESTBLTCLRSPACEYUV 0x00000004l")]
    public const int DDCKEYCAPS_DESTBLTCLRSPACEYUV = 0x00000004;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_DESTBLTYUV"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_DESTBLTYUV 0x00000008l")]
    public const int DDCKEYCAPS_DESTBLTYUV = 0x00000008;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_DESTOVERLAY"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_DESTOVERLAY 0x00000010l")]
    public const int DDCKEYCAPS_DESTOVERLAY = 0x00000010;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_DESTOVERLAYCLRSPACE"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_DESTOVERLAYCLRSPACE 0x00000020l")]
    public const int DDCKEYCAPS_DESTOVERLAYCLRSPACE = 0x00000020;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_DESTOVERLAYCLRSPACEYUV"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_DESTOVERLAYCLRSPACEYUV 0x00000040l")]
    public const int DDCKEYCAPS_DESTOVERLAYCLRSPACEYUV = 0x00000040;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_DESTOVERLAYONEACTIVE"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_DESTOVERLAYONEACTIVE 0x00000080l")]
    public const int DDCKEYCAPS_DESTOVERLAYONEACTIVE = 0x00000080;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_DESTOVERLAYYUV"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_DESTOVERLAYYUV 0x00000100l")]
    public const int DDCKEYCAPS_DESTOVERLAYYUV = 0x00000100;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_SRCBLT"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_SRCBLT 0x00000200l")]
    public const int DDCKEYCAPS_SRCBLT = 0x00000200;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_SRCBLTCLRSPACE"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_SRCBLTCLRSPACE 0x00000400l")]
    public const int DDCKEYCAPS_SRCBLTCLRSPACE = 0x00000400;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_SRCBLTCLRSPACEYUV"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_SRCBLTCLRSPACEYUV 0x00000800l")]
    public const int DDCKEYCAPS_SRCBLTCLRSPACEYUV = 0x00000800;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_SRCBLTYUV"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_SRCBLTYUV 0x00001000l")]
    public const int DDCKEYCAPS_SRCBLTYUV = 0x00001000;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_SRCOVERLAY"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_SRCOVERLAY 0x00002000l")]
    public const int DDCKEYCAPS_SRCOVERLAY = 0x00002000;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_SRCOVERLAYCLRSPACE"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_SRCOVERLAYCLRSPACE 0x00004000l")]
    public const int DDCKEYCAPS_SRCOVERLAYCLRSPACE = 0x00004000;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_SRCOVERLAYCLRSPACEYUV"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_SRCOVERLAYCLRSPACEYUV 0x00008000l")]
    public const int DDCKEYCAPS_SRCOVERLAYCLRSPACEYUV = 0x00008000;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_SRCOVERLAYONEACTIVE"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_SRCOVERLAYONEACTIVE 0x00010000l")]
    public const int DDCKEYCAPS_SRCOVERLAYONEACTIVE = 0x00010000;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_SRCOVERLAYYUV"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_SRCOVERLAYYUV 0x00020000l")]
    public const int DDCKEYCAPS_SRCOVERLAYYUV = 0x00020000;

    /// <include file='DDCKEYCAPS.xml' path='doc/member[@name="DDCKEYCAPS.DDCKEYCAPS_NOCOSTOVERLAY"]/*' />
    [NativeTypeName("#define DDCKEYCAPS_NOCOSTOVERLAY 0x00040000l")]
    public const int DDCKEYCAPS_NOCOSTOVERLAY = 0x00040000;
}
