// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MOD
{
    /// <include file='MOD.xml' path='doc/member[@name="MOD.MOD_LEFT"]/*' />
    [NativeTypeName("#define MOD_LEFT 0x8000")]
    public const int MOD_LEFT = 0x8000;

    /// <include file='MOD.xml' path='doc/member[@name="MOD.MOD_RIGHT"]/*' />
    [NativeTypeName("#define MOD_RIGHT 0x4000")]
    public const int MOD_RIGHT = 0x4000;

    /// <include file='MOD.xml' path='doc/member[@name="MOD.MOD_ON_KEYUP"]/*' />
    [NativeTypeName("#define MOD_ON_KEYUP 0x0800")]
    public const int MOD_ON_KEYUP = 0x0800;

    /// <include file='MOD.xml' path='doc/member[@name="MOD.MOD_IGNORE_ALL_MODIFIER"]/*' />
    [NativeTypeName("#define MOD_IGNORE_ALL_MODIFIER 0x0400")]
    public const int MOD_IGNORE_ALL_MODIFIER = 0x0400;
}
