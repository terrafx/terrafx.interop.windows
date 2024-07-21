// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageItemTypes.xml' path='doc/member[@name="StorageItemTypes"]/*' />
[NativeTypeName("unsigned int")]
public enum StorageItemTypes : uint
{
    /// <include file='StorageItemTypes.xml' path='doc/member[@name="StorageItemTypes.StorageItemTypes_None"]/*' />
    StorageItemTypes_None = 0,

    /// <include file='StorageItemTypes.xml' path='doc/member[@name="StorageItemTypes.StorageItemTypes_File"]/*' />
    StorageItemTypes_File = 0x1,

    /// <include file='StorageItemTypes.xml' path='doc/member[@name="StorageItemTypes.StorageItemTypes_Folder"]/*' />
    StorageItemTypes_Folder = 0x2,
}
