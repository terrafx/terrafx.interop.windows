// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIDOI
{
    /// <include file='DIDOI.xml' path='doc/member[@name="DIDOI.DIDOI_FFACTUATOR"]/*' />
    [NativeTypeName("#define DIDOI_FFACTUATOR 0x00000001")]
    public const int DIDOI_FFACTUATOR = 0x00000001;

    /// <include file='DIDOI.xml' path='doc/member[@name="DIDOI.DIDOI_FFEFFECTTRIGGER"]/*' />
    [NativeTypeName("#define DIDOI_FFEFFECTTRIGGER 0x00000002")]
    public const int DIDOI_FFEFFECTTRIGGER = 0x00000002;

    /// <include file='DIDOI.xml' path='doc/member[@name="DIDOI.DIDOI_POLLED"]/*' />
    [NativeTypeName("#define DIDOI_POLLED 0x00008000")]
    public const int DIDOI_POLLED = 0x00008000;

    /// <include file='DIDOI.xml' path='doc/member[@name="DIDOI.DIDOI_ASPECTPOSITION"]/*' />
    [NativeTypeName("#define DIDOI_ASPECTPOSITION 0x00000100")]
    public const int DIDOI_ASPECTPOSITION = 0x00000100;

    /// <include file='DIDOI.xml' path='doc/member[@name="DIDOI.DIDOI_ASPECTVELOCITY"]/*' />
    [NativeTypeName("#define DIDOI_ASPECTVELOCITY 0x00000200")]
    public const int DIDOI_ASPECTVELOCITY = 0x00000200;

    /// <include file='DIDOI.xml' path='doc/member[@name="DIDOI.DIDOI_ASPECTACCEL"]/*' />
    [NativeTypeName("#define DIDOI_ASPECTACCEL 0x00000300")]
    public const int DIDOI_ASPECTACCEL = 0x00000300;

    /// <include file='DIDOI.xml' path='doc/member[@name="DIDOI.DIDOI_ASPECTFORCE"]/*' />
    [NativeTypeName("#define DIDOI_ASPECTFORCE 0x00000400")]
    public const int DIDOI_ASPECTFORCE = 0x00000400;

    /// <include file='DIDOI.xml' path='doc/member[@name="DIDOI.DIDOI_ASPECTMASK"]/*' />
    [NativeTypeName("#define DIDOI_ASPECTMASK 0x00000F00")]
    public const int DIDOI_ASPECTMASK = 0x00000F00;

    /// <include file='DIDOI.xml' path='doc/member[@name="DIDOI.DIDOI_GUIDISUSAGE"]/*' />
    [NativeTypeName("#define DIDOI_GUIDISUSAGE 0x00010000")]
    public const int DIDOI_GUIDISUSAGE = 0x00010000;
}
