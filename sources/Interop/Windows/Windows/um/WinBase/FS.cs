// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FS
{
    /// <include file='FS.xml' path='doc/member[@name="FS.FS_CASE_IS_PRESERVED"]/*' />
    [NativeTypeName("#define FS_CASE_IS_PRESERVED FILE_CASE_PRESERVED_NAMES")]
    public const int FS_CASE_IS_PRESERVED = 0x00000002;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_CASE_SENSITIVE"]/*' />
    [NativeTypeName("#define FS_CASE_SENSITIVE FILE_CASE_SENSITIVE_SEARCH")]
    public const int FS_CASE_SENSITIVE = 0x00000001;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_UNICODE_STORED_ON_DISK"]/*' />
    [NativeTypeName("#define FS_UNICODE_STORED_ON_DISK FILE_UNICODE_ON_DISK")]
    public const int FS_UNICODE_STORED_ON_DISK = 0x00000004;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_PERSISTENT_ACLS"]/*' />
    [NativeTypeName("#define FS_PERSISTENT_ACLS FILE_PERSISTENT_ACLS")]
    public const int FS_PERSISTENT_ACLS = 0x00000008;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_VOL_IS_COMPRESSED"]/*' />
    [NativeTypeName("#define FS_VOL_IS_COMPRESSED FILE_VOLUME_IS_COMPRESSED")]
    public const int FS_VOL_IS_COMPRESSED = 0x00008000;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_FILE_COMPRESSION"]/*' />
    [NativeTypeName("#define FS_FILE_COMPRESSION FILE_FILE_COMPRESSION")]
    public const int FS_FILE_COMPRESSION = 0x00000010;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_FILE_ENCRYPTION"]/*' />
    [NativeTypeName("#define FS_FILE_ENCRYPTION FILE_SUPPORTS_ENCRYPTION")]
    public const int FS_FILE_ENCRYPTION = 0x00020000;
}
