// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIEFT
{
    /// <include file='DIEFT.xml' path='doc/member[@name="DIEFT.DIEFT_ALL"]/*' />
    [NativeTypeName("#define DIEFT_ALL 0x00000000")]
    public const int DIEFT_ALL = 0x00000000;

    /// <include file='DIEFT.xml' path='doc/member[@name="DIEFT.DIEFT_CONSTANTFORCE"]/*' />
    [NativeTypeName("#define DIEFT_CONSTANTFORCE 0x00000001")]
    public const int DIEFT_CONSTANTFORCE = 0x00000001;

    /// <include file='DIEFT.xml' path='doc/member[@name="DIEFT.DIEFT_RAMPFORCE"]/*' />
    [NativeTypeName("#define DIEFT_RAMPFORCE 0x00000002")]
    public const int DIEFT_RAMPFORCE = 0x00000002;

    /// <include file='DIEFT.xml' path='doc/member[@name="DIEFT.DIEFT_PERIODIC"]/*' />
    [NativeTypeName("#define DIEFT_PERIODIC 0x00000003")]
    public const int DIEFT_PERIODIC = 0x00000003;

    /// <include file='DIEFT.xml' path='doc/member[@name="DIEFT.DIEFT_CONDITION"]/*' />
    [NativeTypeName("#define DIEFT_CONDITION 0x00000004")]
    public const int DIEFT_CONDITION = 0x00000004;

    /// <include file='DIEFT.xml' path='doc/member[@name="DIEFT.DIEFT_CUSTOMFORCE"]/*' />
    [NativeTypeName("#define DIEFT_CUSTOMFORCE 0x00000005")]
    public const int DIEFT_CUSTOMFORCE = 0x00000005;

    /// <include file='DIEFT.xml' path='doc/member[@name="DIEFT.DIEFT_HARDWARE"]/*' />
    [NativeTypeName("#define DIEFT_HARDWARE 0x000000FF")]
    public const int DIEFT_HARDWARE = 0x000000FF;

    /// <include file='DIEFT.xml' path='doc/member[@name="DIEFT.DIEFT_FFATTACK"]/*' />
    [NativeTypeName("#define DIEFT_FFATTACK 0x00000200")]
    public const int DIEFT_FFATTACK = 0x00000200;

    /// <include file='DIEFT.xml' path='doc/member[@name="DIEFT.DIEFT_FFFADE"]/*' />
    [NativeTypeName("#define DIEFT_FFFADE 0x00000400")]
    public const int DIEFT_FFFADE = 0x00000400;

    /// <include file='DIEFT.xml' path='doc/member[@name="DIEFT.DIEFT_SATURATION"]/*' />
    [NativeTypeName("#define DIEFT_SATURATION 0x00000800")]
    public const int DIEFT_SATURATION = 0x00000800;

    /// <include file='DIEFT.xml' path='doc/member[@name="DIEFT.DIEFT_POSNEGCOEFFICIENTS"]/*' />
    [NativeTypeName("#define DIEFT_POSNEGCOEFFICIENTS 0x00001000")]
    public const int DIEFT_POSNEGCOEFFICIENTS = 0x00001000;

    /// <include file='DIEFT.xml' path='doc/member[@name="DIEFT.DIEFT_POSNEGSATURATION"]/*' />
    [NativeTypeName("#define DIEFT_POSNEGSATURATION 0x00002000")]
    public const int DIEFT_POSNEGSATURATION = 0x00002000;

    /// <include file='DIEFT.xml' path='doc/member[@name="DIEFT.DIEFT_DEADBAND"]/*' />
    [NativeTypeName("#define DIEFT_DEADBAND 0x00004000")]
    public const int DIEFT_DEADBAND = 0x00004000;

    /// <include file='DIEFT.xml' path='doc/member[@name="DIEFT.DIEFT_STARTDELAY"]/*' />
    [NativeTypeName("#define DIEFT_STARTDELAY 0x00008000")]
    public const int DIEFT_STARTDELAY = 0x00008000;
}
