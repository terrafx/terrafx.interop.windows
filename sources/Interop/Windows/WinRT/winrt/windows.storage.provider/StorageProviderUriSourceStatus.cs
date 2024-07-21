// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageProviderUriSourceStatus.xml' path='doc/member[@name="StorageProviderUriSourceStatus"]/*' />
public enum StorageProviderUriSourceStatus
{
    /// <include file='StorageProviderUriSourceStatus.xml' path='doc/member[@name="StorageProviderUriSourceStatus.StorageProviderUriSourceStatus_Success"]/*' />
    StorageProviderUriSourceStatus_Success = 0,

    /// <include file='StorageProviderUriSourceStatus.xml' path='doc/member[@name="StorageProviderUriSourceStatus.StorageProviderUriSourceStatus_NoSyncRoot"]/*' />
    StorageProviderUriSourceStatus_NoSyncRoot = 1,

    /// <include file='StorageProviderUriSourceStatus.xml' path='doc/member[@name="StorageProviderUriSourceStatus.StorageProviderUriSourceStatus_FileNotFound"]/*' />
    StorageProviderUriSourceStatus_FileNotFound = 2,
}
