// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_REQUEST_CHANNEL_BIND_STATUS.xml' path='doc/member[@name="HTTP_REQUEST_CHANNEL_BIND_STATUS"]/*' />
public unsafe partial struct HTTP_REQUEST_CHANNEL_BIND_STATUS
{
    /// <include file='HTTP_REQUEST_CHANNEL_BIND_STATUS.xml' path='doc/member[@name="HTTP_REQUEST_CHANNEL_BIND_STATUS.ServiceName"]/*' />
    [NativeTypeName("PHTTP_SERVICE_BINDING_BASE")]
    public HTTP_SERVICE_BINDING_BASE* ServiceName;

    /// <include file='HTTP_REQUEST_CHANNEL_BIND_STATUS.xml' path='doc/member[@name="HTTP_REQUEST_CHANNEL_BIND_STATUS.ChannelToken"]/*' />
    [NativeTypeName("PUCHAR")]
    public byte* ChannelToken;

    /// <include file='HTTP_REQUEST_CHANNEL_BIND_STATUS.xml' path='doc/member[@name="HTTP_REQUEST_CHANNEL_BIND_STATUS.ChannelTokenSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint ChannelTokenSize;

    /// <include file='HTTP_REQUEST_CHANNEL_BIND_STATUS.xml' path='doc/member[@name="HTTP_REQUEST_CHANNEL_BIND_STATUS.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;
}
