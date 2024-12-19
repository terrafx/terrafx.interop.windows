// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1"]/*' />
public unsafe partial struct HTTP_REQUEST_V1
{
    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.ConnectionId"]/*' />
    [NativeTypeName("HTTP_CONNECTION_ID")]
    public ulong ConnectionId;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.RequestId"]/*' />
    [NativeTypeName("HTTP_REQUEST_ID")]
    public ulong RequestId;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.UrlContext"]/*' />
    [NativeTypeName("HTTP_URL_CONTEXT")]
    public ulong UrlContext;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.Version"]/*' />
    public HTTP_VERSION Version;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.Verb"]/*' />
    public HTTP_VERB Verb;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.UnknownVerbLength"]/*' />
    public ushort UnknownVerbLength;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.RawUrlLength"]/*' />
    public ushort RawUrlLength;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.pUnknownVerb"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* pUnknownVerb;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.pRawUrl"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* pRawUrl;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.CookedUrl"]/*' />
    public HTTP_COOKED_URL CookedUrl;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.Address"]/*' />
    public HTTP_TRANSPORT_ADDRESS Address;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.Headers"]/*' />
    public HTTP_REQUEST_HEADERS Headers;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.BytesReceived"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong BytesReceived;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.EntityChunkCount"]/*' />
    public ushort EntityChunkCount;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.pEntityChunks"]/*' />
    [NativeTypeName("PHTTP_DATA_CHUNK")]
    public HTTP_DATA_CHUNK* pEntityChunks;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.RawConnectionId"]/*' />
    [NativeTypeName("HTTP_RAW_CONNECTION_ID")]
    public ulong RawConnectionId;

    /// <include file='HTTP_REQUEST_V1.xml' path='doc/member[@name="HTTP_REQUEST_V1.pSslInfo"]/*' />
    [NativeTypeName("PHTTP_SSL_INFO")]
    public HTTP_SSL_INFO* pSslInfo;
}
