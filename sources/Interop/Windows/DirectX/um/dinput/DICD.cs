// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DICD
{
    /// <include file='DICD.xml' path='doc/member[@name="DICD.DICD_DEFAULT"]/*' />
    [NativeTypeName("#define DICD_DEFAULT 0x00000000")]
    public const int DICD_DEFAULT = 0x00000000;

    /// <include file='DICD.xml' path='doc/member[@name="DICD.DICD_EDIT"]/*' />
    [NativeTypeName("#define DICD_EDIT 0x00000001")]
    public const int DICD_EDIT = 0x00000001;
}
