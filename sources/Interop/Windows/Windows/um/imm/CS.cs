// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CS
{
    /// <include file='CS.xml' path='doc/member[@name="CS.CS_INSERTCHAR"]/*' />
    [NativeTypeName("#define CS_INSERTCHAR 0x2000")]
    public const int CS_INSERTCHAR = 0x2000;

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_NOMOVECARET"]/*' />
    [NativeTypeName("#define CS_NOMOVECARET 0x4000")]
    public const int CS_NOMOVECARET = 0x4000;
}
