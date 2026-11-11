// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='_CMSG_KEM_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_KEM_RECIPIENT_ENCODE_INFO"]/*' />
public partial struct _CMSG_KEM_RECIPIENT_ENCODE_INFO
{
    /// <include file='_CMSG_KEM_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_KEM_RECIPIENT_ENCODE_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='_CMSG_KEM_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_KEM_RECIPIENT_ENCODE_INFO.RecipientId"]/*' />
    public CERT_ID RecipientId;

    /// <include file='_CMSG_KEM_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_KEM_RECIPIENT_ENCODE_INFO.RecipientPublicKey"]/*' />
    public CRYPT_BIT_BLOB RecipientPublicKey;

    /// <include file='_CMSG_KEM_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_KEM_RECIPIENT_ENCODE_INFO.KemAlgorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER KemAlgorithm;

    /// <include file='_CMSG_KEM_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_KEM_RECIPIENT_ENCODE_INFO.KdfAlgorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER KdfAlgorithm;

    /// <include file='_CMSG_KEM_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_KEM_RECIPIENT_ENCODE_INFO.WrapAlgorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER WrapAlgorithm;

    /// <include file='_CMSG_KEM_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="_CMSG_KEM_RECIPIENT_ENCODE_INFO.UserKeyingMaterial"]/*' />
    public CRYPT_DATA_BLOB UserKeyingMaterial;
}
