// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIEDBSFL
{
    /// <include file='DIEDBSFL.xml' path='doc/member[@name="DIEDBSFL.DIEDBSFL_ATTACHEDONLY"]/*' />
    [NativeTypeName("#define DIEDBSFL_ATTACHEDONLY 0x00000000")]
    public const int DIEDBSFL_ATTACHEDONLY = 0x00000000;

    /// <include file='DIEDBSFL.xml' path='doc/member[@name="DIEDBSFL.DIEDBSFL_THISUSER"]/*' />
    [NativeTypeName("#define DIEDBSFL_THISUSER 0x00000010")]
    public const int DIEDBSFL_THISUSER = 0x00000010;

    /// <include file='DIEDBSFL.xml' path='doc/member[@name="DIEDBSFL.DIEDBSFL_FORCEFEEDBACK"]/*' />
    [NativeTypeName("#define DIEDBSFL_FORCEFEEDBACK DIEDFL_FORCEFEEDBACK")]
    public const int DIEDBSFL_FORCEFEEDBACK = 0x00000100;

    /// <include file='DIEDBSFL.xml' path='doc/member[@name="DIEDBSFL.DIEDBSFL_AVAILABLEDEVICES"]/*' />
    [NativeTypeName("#define DIEDBSFL_AVAILABLEDEVICES 0x00001000")]
    public const int DIEDBSFL_AVAILABLEDEVICES = 0x00001000;

    /// <include file='DIEDBSFL.xml' path='doc/member[@name="DIEDBSFL.DIEDBSFL_MULTIMICEKEYBOARDS"]/*' />
    [NativeTypeName("#define DIEDBSFL_MULTIMICEKEYBOARDS 0x00002000")]
    public const int DIEDBSFL_MULTIMICEKEYBOARDS = 0x00002000;

    /// <include file='DIEDBSFL.xml' path='doc/member[@name="DIEDBSFL.DIEDBSFL_NONGAMINGDEVICES"]/*' />
    [NativeTypeName("#define DIEDBSFL_NONGAMINGDEVICES 0x00004000")]
    public const int DIEDBSFL_NONGAMINGDEVICES = 0x00004000;

    /// <include file='DIEDBSFL.xml' path='doc/member[@name="DIEDBSFL.DIEDBSFL_VALID"]/*' />
    [NativeTypeName("#define DIEDBSFL_VALID 0x00007110")]
    public const int DIEDBSFL_VALID = 0x00007110;
}
