// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageProviderHydrationPolicyModifier.xml' path='doc/member[@name="StorageProviderHydrationPolicyModifier"]/*' />
[NativeTypeName("unsigned int")]
public enum StorageProviderHydrationPolicyModifier : uint
{
    /// <include file='StorageProviderHydrationPolicyModifier.xml' path='doc/member[@name="StorageProviderHydrationPolicyModifier.StorageProviderHydrationPolicyModifier_None"]/*' />
    StorageProviderHydrationPolicyModifier_None = 0,

    /// <include file='StorageProviderHydrationPolicyModifier.xml' path='doc/member[@name="StorageProviderHydrationPolicyModifier.StorageProviderHydrationPolicyModifier_ValidationRequired"]/*' />
    StorageProviderHydrationPolicyModifier_ValidationRequired = 0x1,

    /// <include file='StorageProviderHydrationPolicyModifier.xml' path='doc/member[@name="StorageProviderHydrationPolicyModifier.StorageProviderHydrationPolicyModifier_StreamingAllowed"]/*' />
    StorageProviderHydrationPolicyModifier_StreamingAllowed = 0x2,

    /// <include file='StorageProviderHydrationPolicyModifier.xml' path='doc/member[@name="StorageProviderHydrationPolicyModifier.StorageProviderHydrationPolicyModifier_AutoDehydrationAllowed"]/*' />
    StorageProviderHydrationPolicyModifier_AutoDehydrationAllowed = 0x4,

    /// <include file='StorageProviderHydrationPolicyModifier.xml' path='doc/member[@name="StorageProviderHydrationPolicyModifier.StorageProviderHydrationPolicyModifier_AllowFullRestartHydration"]/*' />
    StorageProviderHydrationPolicyModifier_AllowFullRestartHydration = 0x8,
}
