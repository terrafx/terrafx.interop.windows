// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SP
{
    /// <include file='SP.xml' path='doc/member[@name="SP.SP_MAX_MACHINENAME_LENGTH"]/*' />
    [NativeTypeName("#define SP_MAX_MACHINENAME_LENGTH (MAX_PATH + 3)")]
    public const int SP_MAX_MACHINENAME_LENGTH = (260 + 3);

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_ALTPLATFORM_FLAGS_VERSION_RANGE"]/*' />
    [NativeTypeName("#define SP_ALTPLATFORM_FLAGS_VERSION_RANGE (0x0001)")]
    public const int SP_ALTPLATFORM_FLAGS_VERSION_RANGE = (0x0001);

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_ALTPLATFORM_FLAGS_SUITE_MASK"]/*' />
    [NativeTypeName("#define SP_ALTPLATFORM_FLAGS_SUITE_MASK (0x0002)")]
    public const int SP_ALTPLATFORM_FLAGS_SUITE_MASK = (0x0002);

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_DELETESOURCE"]/*' />
    [NativeTypeName("#define SP_COPY_DELETESOURCE 0x0000001")]
    public const int SP_COPY_DELETESOURCE = 0x0000001;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_REPLACEONLY"]/*' />
    [NativeTypeName("#define SP_COPY_REPLACEONLY 0x0000002")]
    public const int SP_COPY_REPLACEONLY = 0x0000002;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_NEWER"]/*' />
    [NativeTypeName("#define SP_COPY_NEWER 0x0000004")]
    public const int SP_COPY_NEWER = 0x0000004;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_NEWER_OR_SAME"]/*' />
    [NativeTypeName("#define SP_COPY_NEWER_OR_SAME SP_COPY_NEWER")]
    public const int SP_COPY_NEWER_OR_SAME = 0x0000004;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_NOOVERWRITE"]/*' />
    [NativeTypeName("#define SP_COPY_NOOVERWRITE 0x0000008")]
    public const int SP_COPY_NOOVERWRITE = 0x0000008;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_NODECOMP"]/*' />
    [NativeTypeName("#define SP_COPY_NODECOMP 0x0000010")]
    public const int SP_COPY_NODECOMP = 0x0000010;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_LANGUAGEAWARE"]/*' />
    [NativeTypeName("#define SP_COPY_LANGUAGEAWARE 0x0000020")]
    public const int SP_COPY_LANGUAGEAWARE = 0x0000020;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_SOURCE_ABSOLUTE"]/*' />
    [NativeTypeName("#define SP_COPY_SOURCE_ABSOLUTE 0x0000040")]
    public const int SP_COPY_SOURCE_ABSOLUTE = 0x0000040;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_SOURCEPATH_ABSOLUTE"]/*' />
    [NativeTypeName("#define SP_COPY_SOURCEPATH_ABSOLUTE 0x0000080")]
    public const int SP_COPY_SOURCEPATH_ABSOLUTE = 0x0000080;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_IN_USE_NEEDS_REBOOT"]/*' />
    [NativeTypeName("#define SP_COPY_IN_USE_NEEDS_REBOOT 0x0000100")]
    public const int SP_COPY_IN_USE_NEEDS_REBOOT = 0x0000100;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_FORCE_IN_USE"]/*' />
    [NativeTypeName("#define SP_COPY_FORCE_IN_USE 0x0000200")]
    public const int SP_COPY_FORCE_IN_USE = 0x0000200;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_NOSKIP"]/*' />
    [NativeTypeName("#define SP_COPY_NOSKIP 0x0000400")]
    public const int SP_COPY_NOSKIP = 0x0000400;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_FLAG_CABINETCONTINUATION"]/*' />
    [NativeTypeName("#define SP_FLAG_CABINETCONTINUATION 0x0000800")]
    public const int SP_FLAG_CABINETCONTINUATION = 0x0000800;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_FORCE_NOOVERWRITE"]/*' />
    [NativeTypeName("#define SP_COPY_FORCE_NOOVERWRITE 0x0001000")]
    public const int SP_COPY_FORCE_NOOVERWRITE = 0x0001000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_FORCE_NEWER"]/*' />
    [NativeTypeName("#define SP_COPY_FORCE_NEWER 0x0002000")]
    public const int SP_COPY_FORCE_NEWER = 0x0002000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_WARNIFSKIP"]/*' />
    [NativeTypeName("#define SP_COPY_WARNIFSKIP 0x0004000")]
    public const int SP_COPY_WARNIFSKIP = 0x0004000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_NOBROWSE"]/*' />
    [NativeTypeName("#define SP_COPY_NOBROWSE 0x0008000")]
    public const int SP_COPY_NOBROWSE = 0x0008000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_NEWER_ONLY"]/*' />
    [NativeTypeName("#define SP_COPY_NEWER_ONLY 0x0010000")]
    public const int SP_COPY_NEWER_ONLY = 0x0010000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_RESERVED"]/*' />
    [NativeTypeName("#define SP_COPY_RESERVED 0x0020000")]
    public const int SP_COPY_RESERVED = 0x0020000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_OEMINF_CATALOG_ONLY"]/*' />
    [NativeTypeName("#define SP_COPY_OEMINF_CATALOG_ONLY 0x0040000")]
    public const int SP_COPY_OEMINF_CATALOG_ONLY = 0x0040000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_REPLACE_BOOT_FILE"]/*' />
    [NativeTypeName("#define SP_COPY_REPLACE_BOOT_FILE 0x0080000")]
    public const int SP_COPY_REPLACE_BOOT_FILE = 0x0080000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_NOPRUNE"]/*' />
    [NativeTypeName("#define SP_COPY_NOPRUNE 0x0100000")]
    public const int SP_COPY_NOPRUNE = 0x0100000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_OEM_F6_INF"]/*' />
    [NativeTypeName("#define SP_COPY_OEM_F6_INF 0x0200000")]
    public const int SP_COPY_OEM_F6_INF = 0x0200000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_ALREADYDECOMP"]/*' />
    [NativeTypeName("#define SP_COPY_ALREADYDECOMP 0x0400000")]
    public const int SP_COPY_ALREADYDECOMP = 0x0400000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_WINDOWS_SIGNED"]/*' />
    [NativeTypeName("#define SP_COPY_WINDOWS_SIGNED 0x1000000")]
    public const int SP_COPY_WINDOWS_SIGNED = 0x1000000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_PNPLOCKED"]/*' />
    [NativeTypeName("#define SP_COPY_PNPLOCKED 0x2000000")]
    public const int SP_COPY_PNPLOCKED = 0x2000000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_IN_USE_TRY_RENAME"]/*' />
    [NativeTypeName("#define SP_COPY_IN_USE_TRY_RENAME 0x4000000")]
    public const int SP_COPY_IN_USE_TRY_RENAME = 0x4000000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_INBOX_INF"]/*' />
    [NativeTypeName("#define SP_COPY_INBOX_INF 0x8000000")]
    public const int SP_COPY_INBOX_INF = 0x8000000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_COPY_HARDLINK"]/*' />
    [NativeTypeName("#define SP_COPY_HARDLINK 0x10000000")]
    public const int SP_COPY_HARDLINK = 0x10000000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_BACKUP_BACKUPPASS"]/*' />
    [NativeTypeName("#define SP_BACKUP_BACKUPPASS 0x00000001")]
    public const int SP_BACKUP_BACKUPPASS = 0x00000001;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_BACKUP_DEMANDPASS"]/*' />
    [NativeTypeName("#define SP_BACKUP_DEMANDPASS 0x00000002")]
    public const int SP_BACKUP_DEMANDPASS = 0x00000002;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_BACKUP_SPECIAL"]/*' />
    [NativeTypeName("#define SP_BACKUP_SPECIAL 0x00000004")]
    public const int SP_BACKUP_SPECIAL = 0x00000004;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_BACKUP_BOOTFILE"]/*' />
    [NativeTypeName("#define SP_BACKUP_BOOTFILE 0x00000008")]
    public const int SP_BACKUP_BOOTFILE = 0x00000008;
}
