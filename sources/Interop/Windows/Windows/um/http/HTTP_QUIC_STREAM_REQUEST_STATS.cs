// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_QUIC_STREAM_REQUEST_STATS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_REQUEST_STATS"]/*' />
public partial struct HTTP_QUIC_STREAM_REQUEST_STATS
{
    /// <include file='HTTP_QUIC_STREAM_REQUEST_STATS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_REQUEST_STATS.StreamWaitStart"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong StreamWaitStart;

    /// <include file='HTTP_QUIC_STREAM_REQUEST_STATS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_REQUEST_STATS.StreamWaitEnd"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong StreamWaitEnd;

    /// <include file='HTTP_QUIC_STREAM_REQUEST_STATS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_REQUEST_STATS.RequestHeadersCompressionStart"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong RequestHeadersCompressionStart;

    /// <include file='HTTP_QUIC_STREAM_REQUEST_STATS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_REQUEST_STATS.RequestHeadersCompressionEnd"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong RequestHeadersCompressionEnd;

    /// <include file='HTTP_QUIC_STREAM_REQUEST_STATS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_REQUEST_STATS.ResponseHeadersDecompressionStart"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ResponseHeadersDecompressionStart;

    /// <include file='HTTP_QUIC_STREAM_REQUEST_STATS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_REQUEST_STATS.ResponseHeadersDecompressionEnd"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ResponseHeadersDecompressionEnd;

    /// <include file='HTTP_QUIC_STREAM_REQUEST_STATS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_REQUEST_STATS.RequestHeadersCompressedSize"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong RequestHeadersCompressedSize;

    /// <include file='HTTP_QUIC_STREAM_REQUEST_STATS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_REQUEST_STATS.ResponseHeadersCompressedSize"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ResponseHeadersCompressedSize;
}
