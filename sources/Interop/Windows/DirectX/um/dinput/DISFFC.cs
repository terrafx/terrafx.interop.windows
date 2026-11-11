// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DISFFC
{
    /// <include file='DISFFC.xml' path='doc/member[@name="DISFFC.DISFFC_RESET"]/*' />
    [NativeTypeName("#define DISFFC_RESET 0x00000001")]
    public const int DISFFC_RESET = 0x00000001;

    /// <include file='DISFFC.xml' path='doc/member[@name="DISFFC.DISFFC_STOPALL"]/*' />
    [NativeTypeName("#define DISFFC_STOPALL 0x00000002")]
    public const int DISFFC_STOPALL = 0x00000002;

    /// <include file='DISFFC.xml' path='doc/member[@name="DISFFC.DISFFC_PAUSE"]/*' />
    [NativeTypeName("#define DISFFC_PAUSE 0x00000004")]
    public const int DISFFC_PAUSE = 0x00000004;

    /// <include file='DISFFC.xml' path='doc/member[@name="DISFFC.DISFFC_CONTINUE"]/*' />
    [NativeTypeName("#define DISFFC_CONTINUE 0x00000008")]
    public const int DISFFC_CONTINUE = 0x00000008;

    /// <include file='DISFFC.xml' path='doc/member[@name="DISFFC.DISFFC_SETACTUATORSON"]/*' />
    [NativeTypeName("#define DISFFC_SETACTUATORSON 0x00000010")]
    public const int DISFFC_SETACTUATORSON = 0x00000010;

    /// <include file='DISFFC.xml' path='doc/member[@name="DISFFC.DISFFC_SETACTUATORSOFF"]/*' />
    [NativeTypeName("#define DISFFC_SETACTUATORSOFF 0x00000020")]
    public const int DISFFC_SETACTUATORSOFF = 0x00000020;
}
