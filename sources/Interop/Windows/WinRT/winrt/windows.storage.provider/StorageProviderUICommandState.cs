// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageProviderUICommandState.xml' path='doc/member[@name="StorageProviderUICommandState"]/*' />
public enum StorageProviderUICommandState
{
    /// <include file='StorageProviderUICommandState.xml' path='doc/member[@name="StorageProviderUICommandState.StorageProviderUICommandState_Enabled"]/*' />
    StorageProviderUICommandState_Enabled = 0,

    /// <include file='StorageProviderUICommandState.xml' path='doc/member[@name="StorageProviderUICommandState.StorageProviderUICommandState_Disabled"]/*' />
    StorageProviderUICommandState_Disabled = 1,

    /// <include file='StorageProviderUICommandState.xml' path='doc/member[@name="StorageProviderUICommandState.StorageProviderUICommandState_Hidden"]/*' />
    StorageProviderUICommandState_Hidden = 2,
}
