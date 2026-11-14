// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PROTECTION
{
    /// <include file='PROTECTION.xml' path='doc/member[@name="PROTECTION.PROTECTION_LEVEL_WINTCB_LIGHT"]/*' />
    [NativeTypeName("#define PROTECTION_LEVEL_WINTCB_LIGHT 0x00000000")]
    public const int PROTECTION_LEVEL_WINTCB_LIGHT = 0x00000000;

    /// <include file='PROTECTION.xml' path='doc/member[@name="PROTECTION.PROTECTION_LEVEL_WINDOWS"]/*' />
    [NativeTypeName("#define PROTECTION_LEVEL_WINDOWS 0x00000001")]
    public const int PROTECTION_LEVEL_WINDOWS = 0x00000001;

    /// <include file='PROTECTION.xml' path='doc/member[@name="PROTECTION.PROTECTION_LEVEL_WINDOWS_LIGHT"]/*' />
    [NativeTypeName("#define PROTECTION_LEVEL_WINDOWS_LIGHT 0x00000002")]
    public const int PROTECTION_LEVEL_WINDOWS_LIGHT = 0x00000002;

    /// <include file='PROTECTION.xml' path='doc/member[@name="PROTECTION.PROTECTION_LEVEL_ANTIMALWARE_LIGHT"]/*' />
    [NativeTypeName("#define PROTECTION_LEVEL_ANTIMALWARE_LIGHT 0x00000003")]
    public const int PROTECTION_LEVEL_ANTIMALWARE_LIGHT = 0x00000003;

    /// <include file='PROTECTION.xml' path='doc/member[@name="PROTECTION.PROTECTION_LEVEL_LSA_LIGHT"]/*' />
    [NativeTypeName("#define PROTECTION_LEVEL_LSA_LIGHT 0x00000004")]
    public const int PROTECTION_LEVEL_LSA_LIGHT = 0x00000004;

    /// <include file='PROTECTION.xml' path='doc/member[@name="PROTECTION.PROTECTION_LEVEL_WINTCB"]/*' />
    [NativeTypeName("#define PROTECTION_LEVEL_WINTCB 0x00000005")]
    public const int PROTECTION_LEVEL_WINTCB = 0x00000005;

    /// <include file='PROTECTION.xml' path='doc/member[@name="PROTECTION.PROTECTION_LEVEL_CODEGEN_LIGHT"]/*' />
    [NativeTypeName("#define PROTECTION_LEVEL_CODEGEN_LIGHT 0x00000006")]
    public const int PROTECTION_LEVEL_CODEGEN_LIGHT = 0x00000006;

    /// <include file='PROTECTION.xml' path='doc/member[@name="PROTECTION.PROTECTION_LEVEL_AUTHENTICODE"]/*' />
    [NativeTypeName("#define PROTECTION_LEVEL_AUTHENTICODE 0x00000007")]
    public const int PROTECTION_LEVEL_AUTHENTICODE = 0x00000007;

    /// <include file='PROTECTION.xml' path='doc/member[@name="PROTECTION.PROTECTION_LEVEL_PPL_APP"]/*' />
    [NativeTypeName("#define PROTECTION_LEVEL_PPL_APP 0x00000008")]
    public const int PROTECTION_LEVEL_PPL_APP = 0x00000008;

    /// <include file='PROTECTION.xml' path='doc/member[@name="PROTECTION.PROTECTION_LEVEL_SAME"]/*' />
    [NativeTypeName("#define PROTECTION_LEVEL_SAME 0xFFFFFFFF")]
    public const uint PROTECTION_LEVEL_SAME = 0xFFFFFFFF;

    /// <include file='PROTECTION.xml' path='doc/member[@name="PROTECTION.PROTECTION_LEVEL_NONE"]/*' />
    [NativeTypeName("#define PROTECTION_LEVEL_NONE 0xFFFFFFFE")]
    public const uint PROTECTION_LEVEL_NONE = 0xFFFFFFFE;
}
