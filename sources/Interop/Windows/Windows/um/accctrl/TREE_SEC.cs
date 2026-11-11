// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TREE_SEC
{
    /// <include file='TREE_SEC.xml' path='doc/member[@name="TREE_SEC.TREE_SEC_INFO_SET"]/*' />
    [NativeTypeName("#define TREE_SEC_INFO_SET 0x00000001")]
    public const int TREE_SEC_INFO_SET = 0x00000001;

    /// <include file='TREE_SEC.xml' path='doc/member[@name="TREE_SEC.TREE_SEC_INFO_RESET"]/*' />
    [NativeTypeName("#define TREE_SEC_INFO_RESET 0x00000002")]
    public const int TREE_SEC_INFO_RESET = 0x00000002;

    /// <include file='TREE_SEC.xml' path='doc/member[@name="TREE_SEC.TREE_SEC_INFO_RESET_KEEP_EXPLICIT"]/*' />
    [NativeTypeName("#define TREE_SEC_INFO_RESET_KEEP_EXPLICIT 0x00000003")]
    public const int TREE_SEC_INFO_RESET_KEEP_EXPLICIT = 0x00000003;
}
