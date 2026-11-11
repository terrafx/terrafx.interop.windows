// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PA
{
    /// <include file='PA.xml' path='doc/member[@name="PA.PA_ACTIVATE"]/*' />
    [NativeTypeName("#define PA_ACTIVATE MA_ACTIVATE")]
    public const int PA_ACTIVATE = 1;

    /// <include file='PA.xml' path='doc/member[@name="PA.PA_NOACTIVATE"]/*' />
    [NativeTypeName("#define PA_NOACTIVATE MA_NOACTIVATE")]
    public const int PA_NOACTIVATE = 3;
}
