// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='IndexerOption.xml' path='doc/member[@name="IndexerOption"]/*' />
public enum IndexerOption
{
    /// <include file='IndexerOption.xml' path='doc/member[@name="IndexerOption.IndexerOption_UseIndexerWhenAvailable"]/*' />
    IndexerOption_UseIndexerWhenAvailable = 0,

    /// <include file='IndexerOption.xml' path='doc/member[@name="IndexerOption.IndexerOption_OnlyUseIndexer"]/*' />
    IndexerOption_OnlyUseIndexer = 1,

    /// <include file='IndexerOption.xml' path='doc/member[@name="IndexerOption.IndexerOption_DoNotUseIndexer"]/*' />
    IndexerOption_DoNotUseIndexer = 2,

    /// <include file='IndexerOption.xml' path='doc/member[@name="IndexerOption.IndexerOption_OnlyUseIndexerAndOptimizeForIndexedProperties"]/*' />
    IndexerOption_OnlyUseIndexerAndOptimizeForIndexedProperties = 3,
}
