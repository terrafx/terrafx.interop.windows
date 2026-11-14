// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FR
{
    /// <include file='FR.xml' path='doc/member[@name="FR.FR_PRIVATE"]/*' />
    [NativeTypeName("#define FR_PRIVATE 0x10")]
    public const int FR_PRIVATE = 0x10;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_NOT_ENUM"]/*' />
    [NativeTypeName("#define FR_NOT_ENUM 0x20")]
    public const int FR_NOT_ENUM = 0x20;
}
