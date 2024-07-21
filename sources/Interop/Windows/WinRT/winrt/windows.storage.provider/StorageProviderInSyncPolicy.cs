// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageProviderInSyncPolicy.xml' path='doc/member[@name="StorageProviderInSyncPolicy"]/*' />
[NativeTypeName("unsigned int")]
public enum StorageProviderInSyncPolicy : uint
{
    /// <include file='StorageProviderInSyncPolicy.xml' path='doc/member[@name="StorageProviderInSyncPolicy.StorageProviderInSyncPolicy_Default"]/*' />
    StorageProviderInSyncPolicy_Default = 0,

    /// <include file='StorageProviderInSyncPolicy.xml' path='doc/member[@name="StorageProviderInSyncPolicy.StorageProviderInSyncPolicy_FileCreationTime"]/*' />
    StorageProviderInSyncPolicy_FileCreationTime = 0x1,

    /// <include file='StorageProviderInSyncPolicy.xml' path='doc/member[@name="StorageProviderInSyncPolicy.StorageProviderInSyncPolicy_FileReadOnlyAttribute"]/*' />
    StorageProviderInSyncPolicy_FileReadOnlyAttribute = 0x2,

    /// <include file='StorageProviderInSyncPolicy.xml' path='doc/member[@name="StorageProviderInSyncPolicy.StorageProviderInSyncPolicy_FileHiddenAttribute"]/*' />
    StorageProviderInSyncPolicy_FileHiddenAttribute = 0x4,

    /// <include file='StorageProviderInSyncPolicy.xml' path='doc/member[@name="StorageProviderInSyncPolicy.StorageProviderInSyncPolicy_FileSystemAttribute"]/*' />
    StorageProviderInSyncPolicy_FileSystemAttribute = 0x8,

    /// <include file='StorageProviderInSyncPolicy.xml' path='doc/member[@name="StorageProviderInSyncPolicy.StorageProviderInSyncPolicy_DirectoryCreationTime"]/*' />
    StorageProviderInSyncPolicy_DirectoryCreationTime = 0x10,

    /// <include file='StorageProviderInSyncPolicy.xml' path='doc/member[@name="StorageProviderInSyncPolicy.StorageProviderInSyncPolicy_DirectoryReadOnlyAttribute"]/*' />
    StorageProviderInSyncPolicy_DirectoryReadOnlyAttribute = 0x20,

    /// <include file='StorageProviderInSyncPolicy.xml' path='doc/member[@name="StorageProviderInSyncPolicy.StorageProviderInSyncPolicy_DirectoryHiddenAttribute"]/*' />
    StorageProviderInSyncPolicy_DirectoryHiddenAttribute = 0x40,

    /// <include file='StorageProviderInSyncPolicy.xml' path='doc/member[@name="StorageProviderInSyncPolicy.StorageProviderInSyncPolicy_DirectorySystemAttribute"]/*' />
    StorageProviderInSyncPolicy_DirectorySystemAttribute = 0x80,

    /// <include file='StorageProviderInSyncPolicy.xml' path='doc/member[@name="StorageProviderInSyncPolicy.StorageProviderInSyncPolicy_FileLastWriteTime"]/*' />
    StorageProviderInSyncPolicy_FileLastWriteTime = 0x100,

    /// <include file='StorageProviderInSyncPolicy.xml' path='doc/member[@name="StorageProviderInSyncPolicy.StorageProviderInSyncPolicy_DirectoryLastWriteTime"]/*' />
    StorageProviderInSyncPolicy_DirectoryLastWriteTime = 0x200,

    /// <include file='StorageProviderInSyncPolicy.xml' path='doc/member[@name="StorageProviderInSyncPolicy.StorageProviderInSyncPolicy_PreserveInsyncForSyncEngine"]/*' />
    StorageProviderInSyncPolicy_PreserveInsyncForSyncEngine = 0x80000000,
}
