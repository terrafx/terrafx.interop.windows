// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageProviderPopulationPolicy.xml' path='doc/member[@name="StorageProviderPopulationPolicy"]/*' />
public enum StorageProviderPopulationPolicy
{
    /// <include file='StorageProviderPopulationPolicy.xml' path='doc/member[@name="StorageProviderPopulationPolicy.StorageProviderPopulationPolicy_Full"]/*' />
    StorageProviderPopulationPolicy_Full = 1,

    /// <include file='StorageProviderPopulationPolicy.xml' path='doc/member[@name="StorageProviderPopulationPolicy.StorageProviderPopulationPolicy_AlwaysFull"]/*' />
    StorageProviderPopulationPolicy_AlwaysFull = 2,
}
