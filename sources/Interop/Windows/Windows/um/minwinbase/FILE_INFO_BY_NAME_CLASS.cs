// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='FILE_INFO_BY_NAME_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_NAME_CLASS"]/*' />
public enum FILE_INFO_BY_NAME_CLASS
{
    /// <include file='FILE_INFO_BY_NAME_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_NAME_CLASS.FileStatByNameInfo"]/*' />
    FileStatByNameInfo,

    /// <include file='FILE_INFO_BY_NAME_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_NAME_CLASS.FileStatLxByNameInfo"]/*' />
    FileStatLxByNameInfo,

    /// <include file='FILE_INFO_BY_NAME_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_NAME_CLASS.FileCaseSensitiveByNameInfo"]/*' />
    FileCaseSensitiveByNameInfo,

    /// <include file='FILE_INFO_BY_NAME_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_NAME_CLASS.FileStatBasicByNameInfo"]/*' />
    FileStatBasicByNameInfo,

    /// <include file='FILE_INFO_BY_NAME_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_NAME_CLASS.MaximumFileInfoByNameClass"]/*' />
    MaximumFileInfoByNameClass,
}
