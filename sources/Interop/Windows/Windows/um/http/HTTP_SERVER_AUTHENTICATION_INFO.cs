// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVER_AUTHENTICATION_INFO.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_INFO"]/*' />
public partial struct HTTP_SERVER_AUTHENTICATION_INFO
{
    /// <include file='HTTP_SERVER_AUTHENTICATION_INFO.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_INFO.Flags"]/*' />
    public HTTP_PROPERTY_FLAGS Flags;

    /// <include file='HTTP_SERVER_AUTHENTICATION_INFO.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_INFO.AuthSchemes"]/*' />
    [NativeTypeName("ULONG")]
    public uint AuthSchemes;

    /// <include file='HTTP_SERVER_AUTHENTICATION_INFO.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_INFO.ReceiveMutualAuth"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte ReceiveMutualAuth;

    /// <include file='HTTP_SERVER_AUTHENTICATION_INFO.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_INFO.ReceiveContextHandle"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte ReceiveContextHandle;

    /// <include file='HTTP_SERVER_AUTHENTICATION_INFO.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_INFO.DisableNTLMCredentialCaching"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte DisableNTLMCredentialCaching;

    /// <include file='HTTP_SERVER_AUTHENTICATION_INFO.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_INFO.ExFlags"]/*' />
    [NativeTypeName("UCHAR")]
    public byte ExFlags;

    /// <include file='HTTP_SERVER_AUTHENTICATION_INFO.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_INFO.DigestParams"]/*' />
    public HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS DigestParams;

    /// <include file='HTTP_SERVER_AUTHENTICATION_INFO.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_INFO.BasicParams"]/*' />
    public HTTP_SERVER_AUTHENTICATION_BASIC_PARAMS BasicParams;
}
