// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageProviderState.xml' path='doc/member[@name="StorageProviderState"]/*' />
public enum StorageProviderState
{
    /// <include file='StorageProviderState.xml' path='doc/member[@name="StorageProviderState.StorageProviderState_InSync"]/*' />
    StorageProviderState_InSync = 0,

    /// <include file='StorageProviderState.xml' path='doc/member[@name="StorageProviderState.StorageProviderState_Syncing"]/*' />
    StorageProviderState_Syncing = 1,

    /// <include file='StorageProviderState.xml' path='doc/member[@name="StorageProviderState.StorageProviderState_Paused"]/*' />
    StorageProviderState_Paused = 2,

    /// <include file='StorageProviderState.xml' path='doc/member[@name="StorageProviderState.StorageProviderState_Error"]/*' />
    StorageProviderState_Error = 3,

    /// <include file='StorageProviderState.xml' path='doc/member[@name="StorageProviderState.StorageProviderState_Warning"]/*' />
    StorageProviderState_Warning = 4,

    /// <include file='StorageProviderState.xml' path='doc/member[@name="StorageProviderState.StorageProviderState_Offline"]/*' />
    StorageProviderState_Offline = 5,
}
