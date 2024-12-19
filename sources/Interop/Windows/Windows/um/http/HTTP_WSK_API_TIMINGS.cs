// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_WSK_API_TIMINGS.xml' path='doc/member[@name="HTTP_WSK_API_TIMINGS"]/*' />
public partial struct HTTP_WSK_API_TIMINGS
{
    /// <include file='HTTP_WSK_API_TIMINGS.xml' path='doc/member[@name="HTTP_WSK_API_TIMINGS.ConnectCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ConnectCount;

    /// <include file='HTTP_WSK_API_TIMINGS.xml' path='doc/member[@name="HTTP_WSK_API_TIMINGS.ConnectSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ConnectSum;

    /// <include file='HTTP_WSK_API_TIMINGS.xml' path='doc/member[@name="HTTP_WSK_API_TIMINGS.DisconnectCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong DisconnectCount;

    /// <include file='HTTP_WSK_API_TIMINGS.xml' path='doc/member[@name="HTTP_WSK_API_TIMINGS.DisconnectSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong DisconnectSum;

    /// <include file='HTTP_WSK_API_TIMINGS.xml' path='doc/member[@name="HTTP_WSK_API_TIMINGS.SendCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SendCount;

    /// <include file='HTTP_WSK_API_TIMINGS.xml' path='doc/member[@name="HTTP_WSK_API_TIMINGS.SendSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SendSum;

    /// <include file='HTTP_WSK_API_TIMINGS.xml' path='doc/member[@name="HTTP_WSK_API_TIMINGS.ReceiveCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ReceiveCount;

    /// <include file='HTTP_WSK_API_TIMINGS.xml' path='doc/member[@name="HTTP_WSK_API_TIMINGS.ReceiveSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ReceiveSum;

    /// <include file='HTTP_WSK_API_TIMINGS.xml' path='doc/member[@name="HTTP_WSK_API_TIMINGS.ReleaseCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ReleaseCount;

    /// <include file='HTTP_WSK_API_TIMINGS.xml' path='doc/member[@name="HTTP_WSK_API_TIMINGS.ReleaseSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ReleaseSum;

    /// <include file='HTTP_WSK_API_TIMINGS.xml' path='doc/member[@name="HTTP_WSK_API_TIMINGS.ControlSocketCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ControlSocketCount;

    /// <include file='HTTP_WSK_API_TIMINGS.xml' path='doc/member[@name="HTTP_WSK_API_TIMINGS.ControlSocketSum"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ControlSocketSum;
}
