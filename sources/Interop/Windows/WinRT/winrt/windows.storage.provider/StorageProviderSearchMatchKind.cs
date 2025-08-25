// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageProviderSearchMatchKind.xml' path='doc/member[@name="StorageProviderSearchMatchKind"]/*' />
public enum StorageProviderSearchMatchKind
{
    /// <include file='StorageProviderSearchMatchKind.xml' path='doc/member[@name="StorageProviderSearchMatchKind.StorageProviderSearchMatchKind_Lexical"]/*' />
    StorageProviderSearchMatchKind_Lexical = 0,

    /// <include file='StorageProviderSearchMatchKind.xml' path='doc/member[@name="StorageProviderSearchMatchKind.StorageProviderSearchMatchKind_Semantic"]/*' />
    StorageProviderSearchMatchKind_Semantic = 1,
}
