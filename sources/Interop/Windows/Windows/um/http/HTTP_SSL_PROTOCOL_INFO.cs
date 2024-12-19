// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SSL_PROTOCOL_INFO.xml' path='doc/member[@name="HTTP_SSL_PROTOCOL_INFO"]/*' />
public partial struct HTTP_SSL_PROTOCOL_INFO
{
    /// <include file='HTTP_SSL_PROTOCOL_INFO.xml' path='doc/member[@name="HTTP_SSL_PROTOCOL_INFO.Protocol"]/*' />
    [NativeTypeName("ULONG")]
    public uint Protocol;

    /// <include file='HTTP_SSL_PROTOCOL_INFO.xml' path='doc/member[@name="HTTP_SSL_PROTOCOL_INFO.CipherType"]/*' />
    [NativeTypeName("ULONG")]
    public uint CipherType;

    /// <include file='HTTP_SSL_PROTOCOL_INFO.xml' path='doc/member[@name="HTTP_SSL_PROTOCOL_INFO.CipherStrength"]/*' />
    [NativeTypeName("ULONG")]
    public uint CipherStrength;

    /// <include file='HTTP_SSL_PROTOCOL_INFO.xml' path='doc/member[@name="HTTP_SSL_PROTOCOL_INFO.HashType"]/*' />
    [NativeTypeName("ULONG")]
    public uint HashType;

    /// <include file='HTTP_SSL_PROTOCOL_INFO.xml' path='doc/member[@name="HTTP_SSL_PROTOCOL_INFO.HashStrength"]/*' />
    [NativeTypeName("ULONG")]
    public uint HashStrength;

    /// <include file='HTTP_SSL_PROTOCOL_INFO.xml' path='doc/member[@name="HTTP_SSL_PROTOCOL_INFO.KeyExchangeType"]/*' />
    [NativeTypeName("ULONG")]
    public uint KeyExchangeType;

    /// <include file='HTTP_SSL_PROTOCOL_INFO.xml' path='doc/member[@name="HTTP_SSL_PROTOCOL_INFO.KeyExchangeStrength"]/*' />
    [NativeTypeName("ULONG")]
    public uint KeyExchangeStrength;
}
