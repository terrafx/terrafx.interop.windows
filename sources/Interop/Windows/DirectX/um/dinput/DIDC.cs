// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIDC
{
    /// <include file='DIDC.xml' path='doc/member[@name="DIDC.DIDC_ATTACHED"]/*' />
    [NativeTypeName("#define DIDC_ATTACHED 0x00000001")]
    public const int DIDC_ATTACHED = 0x00000001;

    /// <include file='DIDC.xml' path='doc/member[@name="DIDC.DIDC_POLLEDDEVICE"]/*' />
    [NativeTypeName("#define DIDC_POLLEDDEVICE 0x00000002")]
    public const int DIDC_POLLEDDEVICE = 0x00000002;

    /// <include file='DIDC.xml' path='doc/member[@name="DIDC.DIDC_EMULATED"]/*' />
    [NativeTypeName("#define DIDC_EMULATED 0x00000004")]
    public const int DIDC_EMULATED = 0x00000004;

    /// <include file='DIDC.xml' path='doc/member[@name="DIDC.DIDC_POLLEDDATAFORMAT"]/*' />
    [NativeTypeName("#define DIDC_POLLEDDATAFORMAT 0x00000008")]
    public const int DIDC_POLLEDDATAFORMAT = 0x00000008;

    /// <include file='DIDC.xml' path='doc/member[@name="DIDC.DIDC_FORCEFEEDBACK"]/*' />
    [NativeTypeName("#define DIDC_FORCEFEEDBACK 0x00000100")]
    public const int DIDC_FORCEFEEDBACK = 0x00000100;

    /// <include file='DIDC.xml' path='doc/member[@name="DIDC.DIDC_FFATTACK"]/*' />
    [NativeTypeName("#define DIDC_FFATTACK 0x00000200")]
    public const int DIDC_FFATTACK = 0x00000200;

    /// <include file='DIDC.xml' path='doc/member[@name="DIDC.DIDC_FFFADE"]/*' />
    [NativeTypeName("#define DIDC_FFFADE 0x00000400")]
    public const int DIDC_FFFADE = 0x00000400;

    /// <include file='DIDC.xml' path='doc/member[@name="DIDC.DIDC_SATURATION"]/*' />
    [NativeTypeName("#define DIDC_SATURATION 0x00000800")]
    public const int DIDC_SATURATION = 0x00000800;

    /// <include file='DIDC.xml' path='doc/member[@name="DIDC.DIDC_POSNEGCOEFFICIENTS"]/*' />
    [NativeTypeName("#define DIDC_POSNEGCOEFFICIENTS 0x00001000")]
    public const int DIDC_POSNEGCOEFFICIENTS = 0x00001000;

    /// <include file='DIDC.xml' path='doc/member[@name="DIDC.DIDC_POSNEGSATURATION"]/*' />
    [NativeTypeName("#define DIDC_POSNEGSATURATION 0x00002000")]
    public const int DIDC_POSNEGSATURATION = 0x00002000;

    /// <include file='DIDC.xml' path='doc/member[@name="DIDC.DIDC_DEADBAND"]/*' />
    [NativeTypeName("#define DIDC_DEADBAND 0x00004000")]
    public const int DIDC_DEADBAND = 0x00004000;

    /// <include file='DIDC.xml' path='doc/member[@name="DIDC.DIDC_STARTDELAY"]/*' />
    [NativeTypeName("#define DIDC_STARTDELAY 0x00008000")]
    public const int DIDC_STARTDELAY = 0x00008000;

    /// <include file='DIDC.xml' path='doc/member[@name="DIDC.DIDC_ALIAS"]/*' />
    [NativeTypeName("#define DIDC_ALIAS 0x00010000")]
    public const int DIDC_ALIAS = 0x00010000;

    /// <include file='DIDC.xml' path='doc/member[@name="DIDC.DIDC_PHANTOM"]/*' />
    [NativeTypeName("#define DIDC_PHANTOM 0x00020000")]
    public const int DIDC_PHANTOM = 0x00020000;

    /// <include file='DIDC.xml' path='doc/member[@name="DIDC.DIDC_HIDDEN"]/*' />
    [NativeTypeName("#define DIDC_HIDDEN 0x00040000")]
    public const int DIDC_HIDDEN = 0x00040000;
}
