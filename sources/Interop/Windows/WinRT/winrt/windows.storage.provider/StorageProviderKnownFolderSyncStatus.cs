// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageProviderKnownFolderSyncStatus.xml' path='doc/member[@name="StorageProviderKnownFolderSyncStatus"]/*' />
public enum StorageProviderKnownFolderSyncStatus
{
    /// <include file='StorageProviderKnownFolderSyncStatus.xml' path='doc/member[@name="StorageProviderKnownFolderSyncStatus.StorageProviderKnownFolderSyncStatus_Available"]/*' />
    StorageProviderKnownFolderSyncStatus_Available = 0,

    /// <include file='StorageProviderKnownFolderSyncStatus.xml' path='doc/member[@name="StorageProviderKnownFolderSyncStatus.StorageProviderKnownFolderSyncStatus_Enrolling"]/*' />
    StorageProviderKnownFolderSyncStatus_Enrolling = 1,

    /// <include file='StorageProviderKnownFolderSyncStatus.xml' path='doc/member[@name="StorageProviderKnownFolderSyncStatus.StorageProviderKnownFolderSyncStatus_Enrolled"]/*' />
    StorageProviderKnownFolderSyncStatus_Enrolled = 2,
}
