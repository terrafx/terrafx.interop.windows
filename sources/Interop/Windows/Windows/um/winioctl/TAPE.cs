// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TAPE
{
    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_RETURN_STATISTICS"]/*' />
    [NativeTypeName("#define TAPE_RETURN_STATISTICS 0L")]
    public const int TAPE_RETURN_STATISTICS = 0;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_RETURN_ENV_INFO"]/*' />
    [NativeTypeName("#define TAPE_RETURN_ENV_INFO 1L")]
    public const int TAPE_RETURN_ENV_INFO = 1;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_RESET_STATISTICS"]/*' />
    [NativeTypeName("#define TAPE_RESET_STATISTICS 2L")]
    public const int TAPE_RESET_STATISTICS = 2;
}
