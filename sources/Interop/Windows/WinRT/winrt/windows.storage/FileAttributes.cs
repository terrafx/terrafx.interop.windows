// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FileAttributes.xml' path='doc/member[@name="FileAttributes"]/*' />
[NativeTypeName("unsigned int")]
public enum FileAttributes : uint
{
    /// <include file='FileAttributes.xml' path='doc/member[@name="FileAttributes.FileAttributes_Normal"]/*' />
    FileAttributes_Normal = 0,

    /// <include file='FileAttributes.xml' path='doc/member[@name="FileAttributes.FileAttributes_ReadOnly"]/*' />
    FileAttributes_ReadOnly = 0x1,

    /// <include file='FileAttributes.xml' path='doc/member[@name="FileAttributes.FileAttributes_Directory"]/*' />
    FileAttributes_Directory = 0x10,

    /// <include file='FileAttributes.xml' path='doc/member[@name="FileAttributes.FileAttributes_Archive"]/*' />
    FileAttributes_Archive = 0x20,

    /// <include file='FileAttributes.xml' path='doc/member[@name="FileAttributes.FileAttributes_Temporary"]/*' />
    FileAttributes_Temporary = 0x100,

    /// <include file='FileAttributes.xml' path='doc/member[@name="FileAttributes.FileAttributes_LocallyIncomplete"]/*' />
    FileAttributes_LocallyIncomplete = 0x200,
}
