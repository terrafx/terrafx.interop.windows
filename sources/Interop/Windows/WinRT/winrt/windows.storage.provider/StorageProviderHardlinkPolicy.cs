// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageProviderHardlinkPolicy.xml' path='doc/member[@name="StorageProviderHardlinkPolicy"]/*' />
[NativeTypeName("unsigned int")]
public enum StorageProviderHardlinkPolicy : uint
{
    /// <include file='StorageProviderHardlinkPolicy.xml' path='doc/member[@name="StorageProviderHardlinkPolicy.StorageProviderHardlinkPolicy_None"]/*' />
    StorageProviderHardlinkPolicy_None = 0,

    /// <include file='StorageProviderHardlinkPolicy.xml' path='doc/member[@name="StorageProviderHardlinkPolicy.StorageProviderHardlinkPolicy_Allowed"]/*' />
    StorageProviderHardlinkPolicy_Allowed = 0x1,
}
