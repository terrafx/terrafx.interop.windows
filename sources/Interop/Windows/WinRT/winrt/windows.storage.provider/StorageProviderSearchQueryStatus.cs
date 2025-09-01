// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageProviderSearchQueryStatus.xml' path='doc/member[@name="StorageProviderSearchQueryStatus"]/*' />
public enum StorageProviderSearchQueryStatus
{
    /// <include file='StorageProviderSearchQueryStatus.xml' path='doc/member[@name="StorageProviderSearchQueryStatus.StorageProviderSearchQueryStatus_Success"]/*' />
    StorageProviderSearchQueryStatus_Success = 0,

    /// <include file='StorageProviderSearchQueryStatus.xml' path='doc/member[@name="StorageProviderSearchQueryStatus.StorageProviderSearchQueryStatus_Error"]/*' />
    StorageProviderSearchQueryStatus_Error = 1,

    /// <include file='StorageProviderSearchQueryStatus.xml' path='doc/member[@name="StorageProviderSearchQueryStatus.StorageProviderSearchQueryStatus_Timeout"]/*' />
    StorageProviderSearchQueryStatus_Timeout = 2,

    /// <include file='StorageProviderSearchQueryStatus.xml' path='doc/member[@name="StorageProviderSearchQueryStatus.StorageProviderSearchQueryStatus_NoNetwork"]/*' />
    StorageProviderSearchQueryStatus_NoNetwork = 3,

    /// <include file='StorageProviderSearchQueryStatus.xml' path='doc/member[@name="StorageProviderSearchQueryStatus.StorageProviderSearchQueryStatus_NetworkError"]/*' />
    StorageProviderSearchQueryStatus_NetworkError = 4,

    /// <include file='StorageProviderSearchQueryStatus.xml' path='doc/member[@name="StorageProviderSearchQueryStatus.StorageProviderSearchQueryStatus_NotSignedIn"]/*' />
    StorageProviderSearchQueryStatus_NotSignedIn = 5,

    /// <include file='StorageProviderSearchQueryStatus.xml' path='doc/member[@name="StorageProviderSearchQueryStatus.StorageProviderSearchQueryStatus_QueryNotSupported"]/*' />
    StorageProviderSearchQueryStatus_QueryNotSupported = 6,

    /// <include file='StorageProviderSearchQueryStatus.xml' path='doc/member[@name="StorageProviderSearchQueryStatus.StorageProviderSearchQueryStatus_SortOrderNotSupported"]/*' />
    StorageProviderSearchQueryStatus_SortOrderNotSupported = 7,
}
