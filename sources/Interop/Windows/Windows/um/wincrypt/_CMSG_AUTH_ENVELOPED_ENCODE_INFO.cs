// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='_CMSG_AUTH_ENVELOPED_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_AUTH_ENVELOPED_ENCODE_INFO"]/*' />
public unsafe partial struct _CMSG_AUTH_ENVELOPED_ENCODE_INFO
{
    /// <include file='_CMSG_AUTH_ENVELOPED_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_AUTH_ENVELOPED_ENCODE_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='_CMSG_AUTH_ENVELOPED_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_AUTH_ENVELOPED_ENCODE_INFO.ContentEncryptionAlgorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER ContentEncryptionAlgorithm;

    /// <include file='_CMSG_AUTH_ENVELOPED_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_AUTH_ENVELOPED_ENCODE_INFO.cRecipients"]/*' />
    [NativeTypeName("DWORD")]
    public uint cRecipients;

    /// <include file='_CMSG_AUTH_ENVELOPED_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_AUTH_ENVELOPED_ENCODE_INFO.rgCmsRecipients"]/*' />
    [NativeTypeName("PCMSG_RECIPIENT_ENCODE_INFO")]
    public CMSG_RECIPIENT_ENCODE_INFO* rgCmsRecipients;

    /// <include file='_CMSG_AUTH_ENVELOPED_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_AUTH_ENVELOPED_ENCODE_INFO.cCertEncoded"]/*' />
    [NativeTypeName("DWORD")]
    public uint cCertEncoded;

    /// <include file='_CMSG_AUTH_ENVELOPED_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_AUTH_ENVELOPED_ENCODE_INFO.rgCertEncoded"]/*' />
    [NativeTypeName("PCERT_BLOB")]
    public CRYPT_DATA_BLOB* rgCertEncoded;

    /// <include file='_CMSG_AUTH_ENVELOPED_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_AUTH_ENVELOPED_ENCODE_INFO.cCrlEncoded"]/*' />
    [NativeTypeName("DWORD")]
    public uint cCrlEncoded;

    /// <include file='_CMSG_AUTH_ENVELOPED_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_AUTH_ENVELOPED_ENCODE_INFO.rgCrlEncoded"]/*' />
    [NativeTypeName("PCRL_BLOB")]
    public CRYPT_DATA_BLOB* rgCrlEncoded;

    /// <include file='_CMSG_AUTH_ENVELOPED_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_AUTH_ENVELOPED_ENCODE_INFO.cAuthAttr"]/*' />
    [NativeTypeName("DWORD")]
    public uint cAuthAttr;

    /// <include file='_CMSG_AUTH_ENVELOPED_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_AUTH_ENVELOPED_ENCODE_INFO.rgAuthAttr"]/*' />
    [NativeTypeName("PCRYPT_ATTRIBUTE")]
    public CRYPT_ATTRIBUTE* rgAuthAttr;

    /// <include file='_CMSG_AUTH_ENVELOPED_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_AUTH_ENVELOPED_ENCODE_INFO.cUnauthAttr"]/*' />
    [NativeTypeName("DWORD")]
    public uint cUnauthAttr;

    /// <include file='_CMSG_AUTH_ENVELOPED_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_AUTH_ENVELOPED_ENCODE_INFO.rgUnauthAttr"]/*' />
    [NativeTypeName("PCRYPT_ATTRIBUTE")]
    public CRYPT_ATTRIBUTE* rgUnauthAttr;
}
