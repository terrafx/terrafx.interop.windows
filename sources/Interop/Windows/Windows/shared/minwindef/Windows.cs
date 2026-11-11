// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/minwindef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.STRICT"]/*' />
    [NativeTypeName("#define STRICT 1")]
    public const int STRICT = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FALSE"]/*' />
    [NativeTypeName("#define FALSE 0")]
    public const int FALSE = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TRUE"]/*' />
    [NativeTypeName("#define TRUE 1")]
    public const int TRUE = 1;
}
