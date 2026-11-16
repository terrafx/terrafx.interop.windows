// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CS
{
    /// <include file='CS.xml' path='doc/member[@name="CS.CS_ENABLE"]/*' />
    [NativeTypeName("#define CS_ENABLE 0x00000001L")]
    public const int CS_ENABLE = 0x00000001;

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_DISABLE"]/*' />
    [NativeTypeName("#define CS_DISABLE 0x00000002L")]
    public const int CS_DISABLE = 0x00000002;

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_DELETE_TRANSFORM"]/*' />
    [NativeTypeName("#define CS_DELETE_TRANSFORM 0x00000003L")]
    public const int CS_DELETE_TRANSFORM = 0x00000003;
}
