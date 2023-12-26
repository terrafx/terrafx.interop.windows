// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageLibraryChangeType.xml' path='doc/member[@name="StorageLibraryChangeType"]/*' />
public enum StorageLibraryChangeType
{
    /// <include file='StorageLibraryChangeType.xml' path='doc/member[@name="StorageLibraryChangeType.StorageLibraryChangeType_Created"]/*' />
    StorageLibraryChangeType_Created = 0,

    /// <include file='StorageLibraryChangeType.xml' path='doc/member[@name="StorageLibraryChangeType.StorageLibraryChangeType_Deleted"]/*' />
    StorageLibraryChangeType_Deleted = 1,

    /// <include file='StorageLibraryChangeType.xml' path='doc/member[@name="StorageLibraryChangeType.StorageLibraryChangeType_MovedOrRenamed"]/*' />
    StorageLibraryChangeType_MovedOrRenamed = 2,

    /// <include file='StorageLibraryChangeType.xml' path='doc/member[@name="StorageLibraryChangeType.StorageLibraryChangeType_ContentsChanged"]/*' />
    StorageLibraryChangeType_ContentsChanged = 3,

    /// <include file='StorageLibraryChangeType.xml' path='doc/member[@name="StorageLibraryChangeType.StorageLibraryChangeType_MovedOutOfLibrary"]/*' />
    StorageLibraryChangeType_MovedOutOfLibrary = 4,

    /// <include file='StorageLibraryChangeType.xml' path='doc/member[@name="StorageLibraryChangeType.StorageLibraryChangeType_MovedIntoLibrary"]/*' />
    StorageLibraryChangeType_MovedIntoLibrary = 5,

    /// <include file='StorageLibraryChangeType.xml' path='doc/member[@name="StorageLibraryChangeType.StorageLibraryChangeType_ContentsReplaced"]/*' />
    StorageLibraryChangeType_ContentsReplaced = 6,

    /// <include file='StorageLibraryChangeType.xml' path='doc/member[@name="StorageLibraryChangeType.StorageLibraryChangeType_IndexingStatusChanged"]/*' />
    StorageLibraryChangeType_IndexingStatusChanged = 7,

    /// <include file='StorageLibraryChangeType.xml' path='doc/member[@name="StorageLibraryChangeType.StorageLibraryChangeType_EncryptionChanged"]/*' />
    StorageLibraryChangeType_EncryptionChanged = 8,

    /// <include file='StorageLibraryChangeType.xml' path='doc/member[@name="StorageLibraryChangeType.StorageLibraryChangeType_ChangeTrackingLost"]/*' />
    StorageLibraryChangeType_ChangeTrackingLost = 9,
}
