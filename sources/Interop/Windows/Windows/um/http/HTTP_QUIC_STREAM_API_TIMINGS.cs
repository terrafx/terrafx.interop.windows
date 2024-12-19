// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS"]/*' />
public partial struct HTTP_QUIC_STREAM_API_TIMINGS
{
    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.OpenCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong OpenCount;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.OpenSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong OpenSum;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.CloseCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong CloseCount;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.CloseSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong CloseSum;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.StartCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong StartCount;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.StartSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong StartSum;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.ShutdownCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ShutdownCount;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.ShutdownSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ShutdownSum;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.SendCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SendCount;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.SendSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SendSum;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.ReceiveSetEnabledCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ReceiveSetEnabledCount;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.ReceiveSetEnabledSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ReceiveSetEnabledSum;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.GetParamCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GetParamCount;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.GetParamSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GetParamSum;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.SetParamCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SetParamCount;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.SetParamSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SetParamSum;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.SetCallbackHandlerCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SetCallbackHandlerCount;

    /// <include file='HTTP_QUIC_STREAM_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_STREAM_API_TIMINGS.SetCallbackHandlerSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SetCallbackHandlerSum;
}
