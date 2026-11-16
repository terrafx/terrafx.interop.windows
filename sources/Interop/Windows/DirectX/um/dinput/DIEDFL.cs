// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIEDFL
{
    /// <include file='DIEDFL.xml' path='doc/member[@name="DIEDFL.DIEDFL_ALLDEVICES"]/*' />
    [NativeTypeName("#define DIEDFL_ALLDEVICES 0x00000000")]
    public const int DIEDFL_ALLDEVICES = 0x00000000;

    /// <include file='DIEDFL.xml' path='doc/member[@name="DIEDFL.DIEDFL_ATTACHEDONLY"]/*' />
    [NativeTypeName("#define DIEDFL_ATTACHEDONLY 0x00000001")]
    public const int DIEDFL_ATTACHEDONLY = 0x00000001;

    /// <include file='DIEDFL.xml' path='doc/member[@name="DIEDFL.DIEDFL_FORCEFEEDBACK"]/*' />
    [NativeTypeName("#define DIEDFL_FORCEFEEDBACK 0x00000100")]
    public const int DIEDFL_FORCEFEEDBACK = 0x00000100;

    /// <include file='DIEDFL.xml' path='doc/member[@name="DIEDFL.DIEDFL_INCLUDEALIASES"]/*' />
    [NativeTypeName("#define DIEDFL_INCLUDEALIASES 0x00010000")]
    public const int DIEDFL_INCLUDEALIASES = 0x00010000;

    /// <include file='DIEDFL.xml' path='doc/member[@name="DIEDFL.DIEDFL_INCLUDEPHANTOMS"]/*' />
    [NativeTypeName("#define DIEDFL_INCLUDEPHANTOMS 0x00020000")]
    public const int DIEDFL_INCLUDEPHANTOMS = 0x00020000;

    /// <include file='DIEDFL.xml' path='doc/member[@name="DIEDFL.DIEDFL_INCLUDEHIDDEN"]/*' />
    [NativeTypeName("#define DIEDFL_INCLUDEHIDDEN 0x00040000")]
    public const int DIEDFL_INCLUDEHIDDEN = 0x00040000;
}
