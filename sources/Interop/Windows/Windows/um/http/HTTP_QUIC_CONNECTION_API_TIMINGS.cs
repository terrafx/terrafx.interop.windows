// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_QUIC_CONNECTION_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_CONNECTION_API_TIMINGS"]/*' />
public partial struct HTTP_QUIC_CONNECTION_API_TIMINGS
{
    /// <include file='HTTP_QUIC_CONNECTION_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_CONNECTION_API_TIMINGS.OpenTime"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong OpenTime;

    /// <include file='HTTP_QUIC_CONNECTION_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_CONNECTION_API_TIMINGS.CloseTime"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong CloseTime;

    /// <include file='HTTP_QUIC_CONNECTION_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_CONNECTION_API_TIMINGS.StartTime"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong StartTime;

    /// <include file='HTTP_QUIC_CONNECTION_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_CONNECTION_API_TIMINGS.ShutdownTime"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ShutdownTime;

    /// <include file='HTTP_QUIC_CONNECTION_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_CONNECTION_API_TIMINGS.SecConfigCreateTime"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SecConfigCreateTime;

    /// <include file='HTTP_QUIC_CONNECTION_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_CONNECTION_API_TIMINGS.SecConfigDeleteTime"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SecConfigDeleteTime;

    /// <include file='HTTP_QUIC_CONNECTION_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_CONNECTION_API_TIMINGS.GetParamCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GetParamCount;

    /// <include file='HTTP_QUIC_CONNECTION_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_CONNECTION_API_TIMINGS.GetParamSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GetParamSum;

    /// <include file='HTTP_QUIC_CONNECTION_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_CONNECTION_API_TIMINGS.SetParamCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SetParamCount;

    /// <include file='HTTP_QUIC_CONNECTION_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_CONNECTION_API_TIMINGS.SetParamSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SetParamSum;

    /// <include file='HTTP_QUIC_CONNECTION_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_CONNECTION_API_TIMINGS.SetCallbackHandlerCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SetCallbackHandlerCount;

    /// <include file='HTTP_QUIC_CONNECTION_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_CONNECTION_API_TIMINGS.SetCallbackHandlerSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SetCallbackHandlerSum;

    /// <include file='HTTP_QUIC_CONNECTION_API_TIMINGS.xml' path='doc/member[@name="HTTP_QUIC_CONNECTION_API_TIMINGS.ControlStreamTimings"]/*' />
    public HTTP_QUIC_STREAM_API_TIMINGS ControlStreamTimings;
}
