// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIVOICE
{
    /// <include file='DIVOICE.xml' path='doc/member[@name="DIVOICE.DIVOICE_CHANNEL1"]/*' />
    [NativeTypeName("#define DIVOICE_CHANNEL1 0x83000401")]
    public const uint DIVOICE_CHANNEL1 = 0x83000401;

    /// <include file='DIVOICE.xml' path='doc/member[@name="DIVOICE.DIVOICE_CHANNEL2"]/*' />
    [NativeTypeName("#define DIVOICE_CHANNEL2 0x83000402")]
    public const uint DIVOICE_CHANNEL2 = 0x83000402;

    /// <include file='DIVOICE.xml' path='doc/member[@name="DIVOICE.DIVOICE_CHANNEL3"]/*' />
    [NativeTypeName("#define DIVOICE_CHANNEL3 0x83000403")]
    public const uint DIVOICE_CHANNEL3 = 0x83000403;

    /// <include file='DIVOICE.xml' path='doc/member[@name="DIVOICE.DIVOICE_CHANNEL4"]/*' />
    [NativeTypeName("#define DIVOICE_CHANNEL4 0x83000404")]
    public const uint DIVOICE_CHANNEL4 = 0x83000404;

    /// <include file='DIVOICE.xml' path='doc/member[@name="DIVOICE.DIVOICE_CHANNEL5"]/*' />
    [NativeTypeName("#define DIVOICE_CHANNEL5 0x83000405")]
    public const uint DIVOICE_CHANNEL5 = 0x83000405;

    /// <include file='DIVOICE.xml' path='doc/member[@name="DIVOICE.DIVOICE_CHANNEL6"]/*' />
    [NativeTypeName("#define DIVOICE_CHANNEL6 0x83000406")]
    public const uint DIVOICE_CHANNEL6 = 0x83000406;

    /// <include file='DIVOICE.xml' path='doc/member[@name="DIVOICE.DIVOICE_CHANNEL7"]/*' />
    [NativeTypeName("#define DIVOICE_CHANNEL7 0x83000407")]
    public const uint DIVOICE_CHANNEL7 = 0x83000407;

    /// <include file='DIVOICE.xml' path='doc/member[@name="DIVOICE.DIVOICE_CHANNEL8"]/*' />
    [NativeTypeName("#define DIVOICE_CHANNEL8 0x83000408")]
    public const uint DIVOICE_CHANNEL8 = 0x83000408;

    /// <include file='DIVOICE.xml' path='doc/member[@name="DIVOICE.DIVOICE_TEAM"]/*' />
    [NativeTypeName("#define DIVOICE_TEAM 0x83000409")]
    public const uint DIVOICE_TEAM = 0x83000409;

    /// <include file='DIVOICE.xml' path='doc/member[@name="DIVOICE.DIVOICE_ALL"]/*' />
    [NativeTypeName("#define DIVOICE_ALL 0x8300040A")]
    public const uint DIVOICE_ALL = 0x8300040A;

    /// <include file='DIVOICE.xml' path='doc/member[@name="DIVOICE.DIVOICE_RECORDMUTE"]/*' />
    [NativeTypeName("#define DIVOICE_RECORDMUTE 0x8300040B")]
    public const uint DIVOICE_RECORDMUTE = 0x8300040B;

    /// <include file='DIVOICE.xml' path='doc/member[@name="DIVOICE.DIVOICE_PLAYBACKMUTE"]/*' />
    [NativeTypeName("#define DIVOICE_PLAYBACKMUTE 0x8300040C")]
    public const uint DIVOICE_PLAYBACKMUTE = 0x8300040C;

    /// <include file='DIVOICE.xml' path='doc/member[@name="DIVOICE.DIVOICE_TRANSMIT"]/*' />
    [NativeTypeName("#define DIVOICE_TRANSMIT 0x8300040D")]
    public const uint DIVOICE_TRANSMIT = 0x8300040D;

    /// <include file='DIVOICE.xml' path='doc/member[@name="DIVOICE.DIVOICE_VOICECOMMAND"]/*' />
    [NativeTypeName("#define DIVOICE_VOICECOMMAND 0x83000410")]
    public const uint DIVOICE_VOICECOMMAND = 0x83000410;
}
