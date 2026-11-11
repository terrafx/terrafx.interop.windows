// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SYSTEM
{
    /// <include file='SYSTEM.xml' path='doc/member[@name="SYSTEM.SYSTEM_FONT"]/*' />
    [NativeTypeName("#define SYSTEM_FONT 13")]
    public const int SYSTEM_FONT = 13;

    /// <include file='SYSTEM.xml' path='doc/member[@name="SYSTEM.SYSTEM_FIXED_FONT"]/*' />
    [NativeTypeName("#define SYSTEM_FIXED_FONT 16")]
    public const int SYSTEM_FIXED_FONT = 16;
}
