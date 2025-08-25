// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageProviderResultKind.xml' path='doc/member[@name="StorageProviderResultKind"]/*' />
public enum StorageProviderResultKind
{
    /// <include file='StorageProviderResultKind.xml' path='doc/member[@name="StorageProviderResultKind.StorageProviderResultKind_Search"]/*' />
    StorageProviderResultKind_Search = 0,

    /// <include file='StorageProviderResultKind.xml' path='doc/member[@name="StorageProviderResultKind.StorageProviderResultKind_Recommended"]/*' />
    StorageProviderResultKind_Recommended = 1,

    /// <include file='StorageProviderResultKind.xml' path='doc/member[@name="StorageProviderResultKind.StorageProviderResultKind_Favorites"]/*' />
    StorageProviderResultKind_Favorites = 2,

    /// <include file='StorageProviderResultKind.xml' path='doc/member[@name="StorageProviderResultKind.StorageProviderResultKind_Recent"]/*' />
    StorageProviderResultKind_Recent = 3,

    /// <include file='StorageProviderResultKind.xml' path='doc/member[@name="StorageProviderResultKind.StorageProviderResultKind_Shared"]/*' />
    StorageProviderResultKind_Shared = 4,

    /// <include file='StorageProviderResultKind.xml' path='doc/member[@name="StorageProviderResultKind.StorageProviderResultKind_RelatedFiles"]/*' />
    StorageProviderResultKind_RelatedFiles = 5,

    /// <include file='StorageProviderResultKind.xml' path='doc/member[@name="StorageProviderResultKind.StorageProviderResultKind_RelatedConversations"]/*' />
    StorageProviderResultKind_RelatedConversations = 6,
}
