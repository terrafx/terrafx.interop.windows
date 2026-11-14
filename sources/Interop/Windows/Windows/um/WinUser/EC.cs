// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class EC
{
    /// <include file='EC.xml' path='doc/member[@name="EC.EC_LEFTMARGIN"]/*' />
    [NativeTypeName("#define EC_LEFTMARGIN 0x0001")]
    public const int EC_LEFTMARGIN = 0x0001;

    /// <include file='EC.xml' path='doc/member[@name="EC.EC_RIGHTMARGIN"]/*' />
    [NativeTypeName("#define EC_RIGHTMARGIN 0x0002")]
    public const int EC_RIGHTMARGIN = 0x0002;

    /// <include file='EC.xml' path='doc/member[@name="EC.EC_USEFONTINFO"]/*' />
    [NativeTypeName("#define EC_USEFONTINFO 0xffff")]
    public const int EC_USEFONTINFO = 0xffff;
}
