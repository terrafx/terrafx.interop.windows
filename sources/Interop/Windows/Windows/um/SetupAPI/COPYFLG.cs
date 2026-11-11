// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class COPYFLG
{
    /// <include file='COPYFLG.xml' path='doc/member[@name="COPYFLG.COPYFLG_WARN_IF_SKIP"]/*' />
    [NativeTypeName("#define COPYFLG_WARN_IF_SKIP 0x00000001")]
    public const int COPYFLG_WARN_IF_SKIP = 0x00000001;

    /// <include file='COPYFLG.xml' path='doc/member[@name="COPYFLG.COPYFLG_NOSKIP"]/*' />
    [NativeTypeName("#define COPYFLG_NOSKIP 0x00000002")]
    public const int COPYFLG_NOSKIP = 0x00000002;

    /// <include file='COPYFLG.xml' path='doc/member[@name="COPYFLG.COPYFLG_NOVERSIONCHECK"]/*' />
    [NativeTypeName("#define COPYFLG_NOVERSIONCHECK 0x00000004")]
    public const int COPYFLG_NOVERSIONCHECK = 0x00000004;

    /// <include file='COPYFLG.xml' path='doc/member[@name="COPYFLG.COPYFLG_FORCE_FILE_IN_USE"]/*' />
    [NativeTypeName("#define COPYFLG_FORCE_FILE_IN_USE 0x00000008")]
    public const int COPYFLG_FORCE_FILE_IN_USE = 0x00000008;

    /// <include file='COPYFLG.xml' path='doc/member[@name="COPYFLG.COPYFLG_NO_OVERWRITE"]/*' />
    [NativeTypeName("#define COPYFLG_NO_OVERWRITE 0x00000010")]
    public const int COPYFLG_NO_OVERWRITE = 0x00000010;

    /// <include file='COPYFLG.xml' path='doc/member[@name="COPYFLG.COPYFLG_NO_VERSION_DIALOG"]/*' />
    [NativeTypeName("#define COPYFLG_NO_VERSION_DIALOG 0x00000020")]
    public const int COPYFLG_NO_VERSION_DIALOG = 0x00000020;

    /// <include file='COPYFLG.xml' path='doc/member[@name="COPYFLG.COPYFLG_OVERWRITE_OLDER_ONLY"]/*' />
    [NativeTypeName("#define COPYFLG_OVERWRITE_OLDER_ONLY 0x00000040")]
    public const int COPYFLG_OVERWRITE_OLDER_ONLY = 0x00000040;

    /// <include file='COPYFLG.xml' path='doc/member[@name="COPYFLG.COPYFLG_PROTECTED_WINDOWS_DRIVER_FILE"]/*' />
    [NativeTypeName("#define COPYFLG_PROTECTED_WINDOWS_DRIVER_FILE 0x00000100")]
    public const int COPYFLG_PROTECTED_WINDOWS_DRIVER_FILE = 0x00000100;

    /// <include file='COPYFLG.xml' path='doc/member[@name="COPYFLG.COPYFLG_REPLACEONLY"]/*' />
    [NativeTypeName("#define COPYFLG_REPLACEONLY 0x00000400")]
    public const int COPYFLG_REPLACEONLY = 0x00000400;

    /// <include file='COPYFLG.xml' path='doc/member[@name="COPYFLG.COPYFLG_NODECOMP"]/*' />
    [NativeTypeName("#define COPYFLG_NODECOMP 0x00000800")]
    public const int COPYFLG_NODECOMP = 0x00000800;

    /// <include file='COPYFLG.xml' path='doc/member[@name="COPYFLG.COPYFLG_REPLACE_BOOT_FILE"]/*' />
    [NativeTypeName("#define COPYFLG_REPLACE_BOOT_FILE 0x00001000")]
    public const int COPYFLG_REPLACE_BOOT_FILE = 0x00001000;

    /// <include file='COPYFLG.xml' path='doc/member[@name="COPYFLG.COPYFLG_NOPRUNE"]/*' />
    [NativeTypeName("#define COPYFLG_NOPRUNE 0x00002000")]
    public const int COPYFLG_NOPRUNE = 0x00002000;

    /// <include file='COPYFLG.xml' path='doc/member[@name="COPYFLG.COPYFLG_IN_USE_TRY_RENAME"]/*' />
    [NativeTypeName("#define COPYFLG_IN_USE_TRY_RENAME 0x00004000")]
    public const int COPYFLG_IN_USE_TRY_RENAME = 0x00004000;
}
