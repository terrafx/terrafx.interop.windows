// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class INIT
{
    /// <include file='INIT.xml' path='doc/member[@name="INIT.INIT_STATUSWNDPOS"]/*' />
    [NativeTypeName("#define INIT_STATUSWNDPOS 0x00000001")]
    public const int INIT_STATUSWNDPOS = 0x00000001;

    /// <include file='INIT.xml' path='doc/member[@name="INIT.INIT_CONVERSION"]/*' />
    [NativeTypeName("#define INIT_CONVERSION 0x00000002")]
    public const int INIT_CONVERSION = 0x00000002;

    /// <include file='INIT.xml' path='doc/member[@name="INIT.INIT_SENTENCE"]/*' />
    [NativeTypeName("#define INIT_SENTENCE 0x00000004")]
    public const int INIT_SENTENCE = 0x00000004;

    /// <include file='INIT.xml' path='doc/member[@name="INIT.INIT_LOGFONT"]/*' />
    [NativeTypeName("#define INIT_LOGFONT 0x00000008")]
    public const int INIT_LOGFONT = 0x00000008;

    /// <include file='INIT.xml' path='doc/member[@name="INIT.INIT_COMPFORM"]/*' />
    [NativeTypeName("#define INIT_COMPFORM 0x00000010")]
    public const int INIT_COMPFORM = 0x00000010;

    /// <include file='INIT.xml' path='doc/member[@name="INIT.INIT_SOFTKBDPOS"]/*' />
    [NativeTypeName("#define INIT_SOFTKBDPOS 0x00000020")]
    public const int INIT_SOFTKBDPOS = 0x00000020;
}
