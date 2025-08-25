// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageProviderResultUsageKind.xml' path='doc/member[@name="StorageProviderResultUsageKind"]/*' />
public enum StorageProviderResultUsageKind
{
    /// <include file='StorageProviderResultUsageKind.xml' path='doc/member[@name="StorageProviderResultUsageKind.StorageProviderResultUsageKind_Rendered"]/*' />
    StorageProviderResultUsageKind_Rendered = 0,

    /// <include file='StorageProviderResultUsageKind.xml' path='doc/member[@name="StorageProviderResultUsageKind.StorageProviderResultUsageKind_Opened"]/*' />
    StorageProviderResultUsageKind_Opened = 1,

    /// <include file='StorageProviderResultUsageKind.xml' path='doc/member[@name="StorageProviderResultUsageKind.StorageProviderResultUsageKind_SuggestionResponseReceived"]/*' />
    StorageProviderResultUsageKind_SuggestionResponseReceived = 2,
}
