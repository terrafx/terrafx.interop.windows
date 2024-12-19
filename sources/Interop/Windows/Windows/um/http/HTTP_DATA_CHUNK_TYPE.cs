// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_DATA_CHUNK_TYPE.xml' path='doc/member[@name="HTTP_DATA_CHUNK_TYPE"]/*' />
public enum HTTP_DATA_CHUNK_TYPE
{
    /// <include file='HTTP_DATA_CHUNK_TYPE.xml' path='doc/member[@name="HTTP_DATA_CHUNK_TYPE.HttpDataChunkFromMemory"]/*' />
    HttpDataChunkFromMemory,

    /// <include file='HTTP_DATA_CHUNK_TYPE.xml' path='doc/member[@name="HTTP_DATA_CHUNK_TYPE.HttpDataChunkFromFileHandle"]/*' />
    HttpDataChunkFromFileHandle,

    /// <include file='HTTP_DATA_CHUNK_TYPE.xml' path='doc/member[@name="HTTP_DATA_CHUNK_TYPE.HttpDataChunkFromFragmentCache"]/*' />
    HttpDataChunkFromFragmentCache,

    /// <include file='HTTP_DATA_CHUNK_TYPE.xml' path='doc/member[@name="HTTP_DATA_CHUNK_TYPE.HttpDataChunkFromFragmentCacheEx"]/*' />
    HttpDataChunkFromFragmentCacheEx,

    /// <include file='HTTP_DATA_CHUNK_TYPE.xml' path='doc/member[@name="HTTP_DATA_CHUNK_TYPE.HttpDataChunkTrailers"]/*' />
    HttpDataChunkTrailers,

    /// <include file='HTTP_DATA_CHUNK_TYPE.xml' path='doc/member[@name="HTTP_DATA_CHUNK_TYPE.HttpDataChunkFromWinHttpFastForwarding"]/*' />
    HttpDataChunkFromWinHttpFastForwarding,

    /// <include file='HTTP_DATA_CHUNK_TYPE.xml' path='doc/member[@name="HTTP_DATA_CHUNK_TYPE.HttpDataChunkMaximum"]/*' />
    HttpDataChunkMaximum,
}
