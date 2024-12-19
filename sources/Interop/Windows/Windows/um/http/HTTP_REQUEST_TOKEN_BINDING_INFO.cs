// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_REQUEST_TOKEN_BINDING_INFO.xml' path='doc/member[@name="HTTP_REQUEST_TOKEN_BINDING_INFO"]/*' />
public unsafe partial struct HTTP_REQUEST_TOKEN_BINDING_INFO
{
    /// <include file='HTTP_REQUEST_TOKEN_BINDING_INFO.xml' path='doc/member[@name="HTTP_REQUEST_TOKEN_BINDING_INFO.TokenBinding"]/*' />
    [NativeTypeName("PUCHAR")]
    public byte* TokenBinding;

    /// <include file='HTTP_REQUEST_TOKEN_BINDING_INFO.xml' path='doc/member[@name="HTTP_REQUEST_TOKEN_BINDING_INFO.TokenBindingSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint TokenBindingSize;

    /// <include file='HTTP_REQUEST_TOKEN_BINDING_INFO.xml' path='doc/member[@name="HTTP_REQUEST_TOKEN_BINDING_INFO.EKM"]/*' />
    [NativeTypeName("PUCHAR")]
    public byte* EKM;

    /// <include file='HTTP_REQUEST_TOKEN_BINDING_INFO.xml' path='doc/member[@name="HTTP_REQUEST_TOKEN_BINDING_INFO.EKMSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint EKMSize;

    /// <include file='HTTP_REQUEST_TOKEN_BINDING_INFO.xml' path='doc/member[@name="HTTP_REQUEST_TOKEN_BINDING_INFO.KeyType"]/*' />
    [NativeTypeName("UCHAR")]
    public byte KeyType;
}
