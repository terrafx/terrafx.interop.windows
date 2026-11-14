// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MA
{
    /// <include file='MA.xml' path='doc/member[@name="MA.MA_ACTIVATE"]/*' />
    [NativeTypeName("#define MA_ACTIVATE 1")]
    public const int MA_ACTIVATE = 1;

    /// <include file='MA.xml' path='doc/member[@name="MA.MA_ACTIVATEANDEAT"]/*' />
    [NativeTypeName("#define MA_ACTIVATEANDEAT 2")]
    public const int MA_ACTIVATEANDEAT = 2;

    /// <include file='MA.xml' path='doc/member[@name="MA.MA_NOACTIVATE"]/*' />
    [NativeTypeName("#define MA_NOACTIVATE 3")]
    public const int MA_NOACTIVATE = 3;

    /// <include file='MA.xml' path='doc/member[@name="MA.MA_NOACTIVATEANDEAT"]/*' />
    [NativeTypeName("#define MA_NOACTIVATEANDEAT 4")]
    public const int MA_NOACTIVATEANDEAT = 4;
}
