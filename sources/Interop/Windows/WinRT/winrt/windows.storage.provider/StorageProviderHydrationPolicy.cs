// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageProviderHydrationPolicy.xml' path='doc/member[@name="StorageProviderHydrationPolicy"]/*' />
public enum StorageProviderHydrationPolicy
{
    /// <include file='StorageProviderHydrationPolicy.xml' path='doc/member[@name="StorageProviderHydrationPolicy.StorageProviderHydrationPolicy_Partial"]/*' />
    StorageProviderHydrationPolicy_Partial = 0,

    /// <include file='StorageProviderHydrationPolicy.xml' path='doc/member[@name="StorageProviderHydrationPolicy.StorageProviderHydrationPolicy_Progressive"]/*' />
    StorageProviderHydrationPolicy_Progressive = 1,

    /// <include file='StorageProviderHydrationPolicy.xml' path='doc/member[@name="StorageProviderHydrationPolicy.StorageProviderHydrationPolicy_Full"]/*' />
    StorageProviderHydrationPolicy_Full = 2,

    /// <include file='StorageProviderHydrationPolicy.xml' path='doc/member[@name="StorageProviderHydrationPolicy.StorageProviderHydrationPolicy_AlwaysFull"]/*' />
    StorageProviderHydrationPolicy_AlwaysFull = 3,
}
