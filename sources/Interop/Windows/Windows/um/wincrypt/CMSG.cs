// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static unsafe partial class CMSG
{
    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENCODING_TYPE_MASK"]/*' />
    [NativeTypeName("#define CMSG_ENCODING_TYPE_MASK 0xFFFF0000")]
    public const uint CMSG_ENCODING_TYPE_MASK = 0xFFFF0000;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_DATA"]/*' />
    [NativeTypeName("#define CMSG_DATA 1")]
    public const int CMSG_DATA = 1;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNED"]/*' />
    [NativeTypeName("#define CMSG_SIGNED 2")]
    public const int CMSG_SIGNED = 2;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENVELOPED"]/*' />
    [NativeTypeName("#define CMSG_ENVELOPED 3")]
    public const int CMSG_ENVELOPED = 3;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNED_AND_ENVELOPED"]/*' />
    [NativeTypeName("#define CMSG_SIGNED_AND_ENVELOPED 4")]
    public const int CMSG_SIGNED_AND_ENVELOPED = 4;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_HASHED"]/*' />
    [NativeTypeName("#define CMSG_HASHED 5")]
    public const int CMSG_HASHED = 5;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENCRYPTED"]/*' />
    [NativeTypeName("#define CMSG_ENCRYPTED 6")]
    public const int CMSG_ENCRYPTED = 6;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_AUTH_ENVELOPED"]/*' />
    [NativeTypeName("#define CMSG_AUTH_ENVELOPED 7")]
    public const int CMSG_AUTH_ENVELOPED = 7;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ALL_FLAGS"]/*' />
    [NativeTypeName("#define CMSG_ALL_FLAGS (~0UL)")]
    public const uint CMSG_ALL_FLAGS = (~0U);

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_DATA_FLAG"]/*' />
    [NativeTypeName("#define CMSG_DATA_FLAG (1 << CMSG_DATA)")]
    public const int CMSG_DATA_FLAG = (1 << 1);

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNED_FLAG"]/*' />
    [NativeTypeName("#define CMSG_SIGNED_FLAG (1 << CMSG_SIGNED)")]
    public const int CMSG_SIGNED_FLAG = (1 << 2);

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENVELOPED_FLAG"]/*' />
    [NativeTypeName("#define CMSG_ENVELOPED_FLAG (1 << CMSG_ENVELOPED)")]
    public const int CMSG_ENVELOPED_FLAG = (1 << 3);

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNED_AND_ENVELOPED_FLAG"]/*' />
    [NativeTypeName("#define CMSG_SIGNED_AND_ENVELOPED_FLAG (1 << CMSG_SIGNED_AND_ENVELOPED)")]
    public const int CMSG_SIGNED_AND_ENVELOPED_FLAG = (1 << 4);

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_HASHED_FLAG"]/*' />
    [NativeTypeName("#define CMSG_HASHED_FLAG (1 << CMSG_HASHED)")]
    public const int CMSG_HASHED_FLAG = (1 << 5);

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENCRYPTED_FLAG"]/*' />
    [NativeTypeName("#define CMSG_ENCRYPTED_FLAG (1 << CMSG_ENCRYPTED)")]
    public const int CMSG_ENCRYPTED_FLAG = (1 << 6);

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_AUTH_ENVELOPED_FLAG"]/*' />
    [NativeTypeName("#define CMSG_AUTH_ENVELOPED_FLAG (1 << CMSG_AUTH_ENVELOPED)")]
    public const int CMSG_AUTH_ENVELOPED_FLAG = (1 << 7);

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_AGREE_EPHEMERAL_KEY_CHOICE"]/*' />
    [NativeTypeName("#define CMSG_KEY_AGREE_EPHEMERAL_KEY_CHOICE 1")]
    public const int CMSG_KEY_AGREE_EPHEMERAL_KEY_CHOICE = 1;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_AGREE_STATIC_KEY_CHOICE"]/*' />
    [NativeTypeName("#define CMSG_KEY_AGREE_STATIC_KEY_CHOICE 2")]
    public const int CMSG_KEY_AGREE_STATIC_KEY_CHOICE = 2;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_MAIL_LIST_HANDLE_KEY_CHOICE"]/*' />
    [NativeTypeName("#define CMSG_MAIL_LIST_HANDLE_KEY_CHOICE 1")]
    public const int CMSG_MAIL_LIST_HANDLE_KEY_CHOICE = 1;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_TRANS_RECIPIENT"]/*' />
    [NativeTypeName("#define CMSG_KEY_TRANS_RECIPIENT 1")]
    public const int CMSG_KEY_TRANS_RECIPIENT = 1;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_AGREE_RECIPIENT"]/*' />
    [NativeTypeName("#define CMSG_KEY_AGREE_RECIPIENT 2")]
    public const int CMSG_KEY_AGREE_RECIPIENT = 2;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_MAIL_LIST_RECIPIENT"]/*' />
    [NativeTypeName("#define CMSG_MAIL_LIST_RECIPIENT 3")]
    public const int CMSG_MAIL_LIST_RECIPIENT = 3;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEM_RECIPIENT"]/*' />
    [NativeTypeName("#define CMSG_KEM_RECIPIENT 4")]
    public const int CMSG_KEM_RECIPIENT = 4;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SP3_COMPATIBLE_ENCRYPT_FLAG"]/*' />
    [NativeTypeName("#define CMSG_SP3_COMPATIBLE_ENCRYPT_FLAG 0x80000000")]
    public const uint CMSG_SP3_COMPATIBLE_ENCRYPT_FLAG = 0x80000000;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_RC4_NO_SALT_FLAG"]/*' />
    [NativeTypeName("#define CMSG_RC4_NO_SALT_FLAG 0x40000000")]
    public const int CMSG_RC4_NO_SALT_FLAG = 0x40000000;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_INDEFINITE_LENGTH"]/*' />
    [NativeTypeName("#define CMSG_INDEFINITE_LENGTH (0xFFFFFFFF)")]
    public const uint CMSG_INDEFINITE_LENGTH = (0xFFFFFFFF);

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_BARE_CONTENT_FLAG"]/*' />
    [NativeTypeName("#define CMSG_BARE_CONTENT_FLAG 0x00000001")]
    public const int CMSG_BARE_CONTENT_FLAG = 0x00000001;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_LENGTH_ONLY_FLAG"]/*' />
    [NativeTypeName("#define CMSG_LENGTH_ONLY_FLAG 0x00000002")]
    public const int CMSG_LENGTH_ONLY_FLAG = 0x00000002;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_DETACHED_FLAG"]/*' />
    [NativeTypeName("#define CMSG_DETACHED_FLAG 0x00000004")]
    public const int CMSG_DETACHED_FLAG = 0x00000004;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_AUTHENTICATED_ATTRIBUTES_FLAG"]/*' />
    [NativeTypeName("#define CMSG_AUTHENTICATED_ATTRIBUTES_FLAG 0x00000008")]
    public const int CMSG_AUTHENTICATED_ATTRIBUTES_FLAG = 0x00000008;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CONTENTS_OCTETS_FLAG"]/*' />
    [NativeTypeName("#define CMSG_CONTENTS_OCTETS_FLAG 0x00000010")]
    public const int CMSG_CONTENTS_OCTETS_FLAG = 0x00000010;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_MAX_LENGTH_FLAG"]/*' />
    [NativeTypeName("#define CMSG_MAX_LENGTH_FLAG 0x00000020")]
    public const int CMSG_MAX_LENGTH_FLAG = 0x00000020;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CMS_ENCAPSULATED_CONTENT_FLAG"]/*' />
    [NativeTypeName("#define CMSG_CMS_ENCAPSULATED_CONTENT_FLAG 0x00000040")]
    public const int CMSG_CMS_ENCAPSULATED_CONTENT_FLAG = 0x00000040;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNED_DATA_NO_SIGN_FLAG"]/*' />
    [NativeTypeName("#define CMSG_SIGNED_DATA_NO_SIGN_FLAG 0x00000080")]
    public const int CMSG_SIGNED_DATA_NO_SIGN_FLAG = 0x00000080;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CRYPT_RELEASE_CONTEXT_FLAG"]/*' />
    [NativeTypeName("#define CMSG_CRYPT_RELEASE_CONTEXT_FLAG 0x00008000")]
    public const int CMSG_CRYPT_RELEASE_CONTEXT_FLAG = 0x00008000;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_TYPE_PARAM"]/*' />
    [NativeTypeName("#define CMSG_TYPE_PARAM 1")]
    public const int CMSG_TYPE_PARAM = 1;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CONTENT_PARAM"]/*' />
    [NativeTypeName("#define CMSG_CONTENT_PARAM 2")]
    public const int CMSG_CONTENT_PARAM = 2;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_BARE_CONTENT_PARAM"]/*' />
    [NativeTypeName("#define CMSG_BARE_CONTENT_PARAM 3")]
    public const int CMSG_BARE_CONTENT_PARAM = 3;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_INNER_CONTENT_TYPE_PARAM"]/*' />
    [NativeTypeName("#define CMSG_INNER_CONTENT_TYPE_PARAM 4")]
    public const int CMSG_INNER_CONTENT_TYPE_PARAM = 4;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNER_COUNT_PARAM"]/*' />
    [NativeTypeName("#define CMSG_SIGNER_COUNT_PARAM 5")]
    public const int CMSG_SIGNER_COUNT_PARAM = 5;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNER_INFO_PARAM"]/*' />
    [NativeTypeName("#define CMSG_SIGNER_INFO_PARAM 6")]
    public const int CMSG_SIGNER_INFO_PARAM = 6;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNER_CERT_INFO_PARAM"]/*' />
    [NativeTypeName("#define CMSG_SIGNER_CERT_INFO_PARAM 7")]
    public const int CMSG_SIGNER_CERT_INFO_PARAM = 7;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNER_HASH_ALGORITHM_PARAM"]/*' />
    [NativeTypeName("#define CMSG_SIGNER_HASH_ALGORITHM_PARAM 8")]
    public const int CMSG_SIGNER_HASH_ALGORITHM_PARAM = 8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNER_AUTH_ATTR_PARAM"]/*' />
    [NativeTypeName("#define CMSG_SIGNER_AUTH_ATTR_PARAM 9")]
    public const int CMSG_SIGNER_AUTH_ATTR_PARAM = 9;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNER_UNAUTH_ATTR_PARAM"]/*' />
    [NativeTypeName("#define CMSG_SIGNER_UNAUTH_ATTR_PARAM 10")]
    public const int CMSG_SIGNER_UNAUTH_ATTR_PARAM = 10;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CERT_COUNT_PARAM"]/*' />
    [NativeTypeName("#define CMSG_CERT_COUNT_PARAM 11")]
    public const int CMSG_CERT_COUNT_PARAM = 11;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CERT_PARAM"]/*' />
    [NativeTypeName("#define CMSG_CERT_PARAM 12")]
    public const int CMSG_CERT_PARAM = 12;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CRL_COUNT_PARAM"]/*' />
    [NativeTypeName("#define CMSG_CRL_COUNT_PARAM 13")]
    public const int CMSG_CRL_COUNT_PARAM = 13;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CRL_PARAM"]/*' />
    [NativeTypeName("#define CMSG_CRL_PARAM 14")]
    public const int CMSG_CRL_PARAM = 14;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENVELOPE_ALGORITHM_PARAM"]/*' />
    [NativeTypeName("#define CMSG_ENVELOPE_ALGORITHM_PARAM 15")]
    public const int CMSG_ENVELOPE_ALGORITHM_PARAM = 15;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_RECIPIENT_COUNT_PARAM"]/*' />
    [NativeTypeName("#define CMSG_RECIPIENT_COUNT_PARAM 17")]
    public const int CMSG_RECIPIENT_COUNT_PARAM = 17;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_RECIPIENT_INDEX_PARAM"]/*' />
    [NativeTypeName("#define CMSG_RECIPIENT_INDEX_PARAM 18")]
    public const int CMSG_RECIPIENT_INDEX_PARAM = 18;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_RECIPIENT_INFO_PARAM"]/*' />
    [NativeTypeName("#define CMSG_RECIPIENT_INFO_PARAM 19")]
    public const int CMSG_RECIPIENT_INFO_PARAM = 19;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_HASH_ALGORITHM_PARAM"]/*' />
    [NativeTypeName("#define CMSG_HASH_ALGORITHM_PARAM 20")]
    public const int CMSG_HASH_ALGORITHM_PARAM = 20;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_HASH_DATA_PARAM"]/*' />
    [NativeTypeName("#define CMSG_HASH_DATA_PARAM 21")]
    public const int CMSG_HASH_DATA_PARAM = 21;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_COMPUTED_HASH_PARAM"]/*' />
    [NativeTypeName("#define CMSG_COMPUTED_HASH_PARAM 22")]
    public const int CMSG_COMPUTED_HASH_PARAM = 22;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENCRYPT_PARAM"]/*' />
    [NativeTypeName("#define CMSG_ENCRYPT_PARAM 26")]
    public const int CMSG_ENCRYPT_PARAM = 26;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENCRYPTED_DIGEST"]/*' />
    [NativeTypeName("#define CMSG_ENCRYPTED_DIGEST 27")]
    public const int CMSG_ENCRYPTED_DIGEST = 27;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENCODED_SIGNER"]/*' />
    [NativeTypeName("#define CMSG_ENCODED_SIGNER 28")]
    public const int CMSG_ENCODED_SIGNER = 28;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENCODED_MESSAGE"]/*' />
    [NativeTypeName("#define CMSG_ENCODED_MESSAGE 29")]
    public const int CMSG_ENCODED_MESSAGE = 29;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_VERSION_PARAM"]/*' />
    [NativeTypeName("#define CMSG_VERSION_PARAM 30")]
    public const int CMSG_VERSION_PARAM = 30;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ATTR_CERT_COUNT_PARAM"]/*' />
    [NativeTypeName("#define CMSG_ATTR_CERT_COUNT_PARAM 31")]
    public const int CMSG_ATTR_CERT_COUNT_PARAM = 31;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ATTR_CERT_PARAM"]/*' />
    [NativeTypeName("#define CMSG_ATTR_CERT_PARAM 32")]
    public const int CMSG_ATTR_CERT_PARAM = 32;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CMS_RECIPIENT_COUNT_PARAM"]/*' />
    [NativeTypeName("#define CMSG_CMS_RECIPIENT_COUNT_PARAM 33")]
    public const int CMSG_CMS_RECIPIENT_COUNT_PARAM = 33;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CMS_RECIPIENT_INDEX_PARAM"]/*' />
    [NativeTypeName("#define CMSG_CMS_RECIPIENT_INDEX_PARAM 34")]
    public const int CMSG_CMS_RECIPIENT_INDEX_PARAM = 34;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CMS_RECIPIENT_ENCRYPTED_KEY_INDEX_PARAM"]/*' />
    [NativeTypeName("#define CMSG_CMS_RECIPIENT_ENCRYPTED_KEY_INDEX_PARAM 35")]
    public const int CMSG_CMS_RECIPIENT_ENCRYPTED_KEY_INDEX_PARAM = 35;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CMS_RECIPIENT_INFO_PARAM"]/*' />
    [NativeTypeName("#define CMSG_CMS_RECIPIENT_INFO_PARAM 36")]
    public const int CMSG_CMS_RECIPIENT_INFO_PARAM = 36;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_UNPROTECTED_ATTR_PARAM"]/*' />
    [NativeTypeName("#define CMSG_UNPROTECTED_ATTR_PARAM 37")]
    public const int CMSG_UNPROTECTED_ATTR_PARAM = 37;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNER_CERT_ID_PARAM"]/*' />
    [NativeTypeName("#define CMSG_SIGNER_CERT_ID_PARAM 38")]
    public const int CMSG_SIGNER_CERT_ID_PARAM = 38;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CMS_SIGNER_INFO_PARAM"]/*' />
    [NativeTypeName("#define CMSG_CMS_SIGNER_INFO_PARAM 39")]
    public const int CMSG_CMS_SIGNER_INFO_PARAM = 39;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNED_DATA_V1"]/*' />
    [NativeTypeName("#define CMSG_SIGNED_DATA_V1 1")]
    public const int CMSG_SIGNED_DATA_V1 = 1;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNED_DATA_V3"]/*' />
    [NativeTypeName("#define CMSG_SIGNED_DATA_V3 3")]
    public const int CMSG_SIGNED_DATA_V3 = 3;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNED_DATA_PKCS_1_5_VERSION"]/*' />
    [NativeTypeName("#define CMSG_SIGNED_DATA_PKCS_1_5_VERSION CMSG_SIGNED_DATA_V1")]
    public const int CMSG_SIGNED_DATA_PKCS_1_5_VERSION = 1;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNED_DATA_CMS_VERSION"]/*' />
    [NativeTypeName("#define CMSG_SIGNED_DATA_CMS_VERSION CMSG_SIGNED_DATA_V3")]
    public const int CMSG_SIGNED_DATA_CMS_VERSION = 3;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNER_INFO_V1"]/*' />
    [NativeTypeName("#define CMSG_SIGNER_INFO_V1 1")]
    public const int CMSG_SIGNER_INFO_V1 = 1;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNER_INFO_V3"]/*' />
    [NativeTypeName("#define CMSG_SIGNER_INFO_V3 3")]
    public const int CMSG_SIGNER_INFO_V3 = 3;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNER_INFO_PKCS_1_5_VERSION"]/*' />
    [NativeTypeName("#define CMSG_SIGNER_INFO_PKCS_1_5_VERSION CMSG_SIGNER_INFO_V1")]
    public const int CMSG_SIGNER_INFO_PKCS_1_5_VERSION = 1;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNER_INFO_CMS_VERSION"]/*' />
    [NativeTypeName("#define CMSG_SIGNER_INFO_CMS_VERSION CMSG_SIGNER_INFO_V3")]
    public const int CMSG_SIGNER_INFO_CMS_VERSION = 3;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_HASHED_DATA_V0"]/*' />
    [NativeTypeName("#define CMSG_HASHED_DATA_V0 0")]
    public const int CMSG_HASHED_DATA_V0 = 0;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_HASHED_DATA_V2"]/*' />
    [NativeTypeName("#define CMSG_HASHED_DATA_V2 2")]
    public const int CMSG_HASHED_DATA_V2 = 2;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_HASHED_DATA_PKCS_1_5_VERSION"]/*' />
    [NativeTypeName("#define CMSG_HASHED_DATA_PKCS_1_5_VERSION CMSG_HASHED_DATA_V0")]
    public const int CMSG_HASHED_DATA_PKCS_1_5_VERSION = 0;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_HASHED_DATA_CMS_VERSION"]/*' />
    [NativeTypeName("#define CMSG_HASHED_DATA_CMS_VERSION CMSG_HASHED_DATA_V2")]
    public const int CMSG_HASHED_DATA_CMS_VERSION = 2;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENVELOPED_DATA_V0"]/*' />
    [NativeTypeName("#define CMSG_ENVELOPED_DATA_V0 0")]
    public const int CMSG_ENVELOPED_DATA_V0 = 0;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENVELOPED_DATA_V2"]/*' />
    [NativeTypeName("#define CMSG_ENVELOPED_DATA_V2 2")]
    public const int CMSG_ENVELOPED_DATA_V2 = 2;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENVELOPED_DATA_V3"]/*' />
    [NativeTypeName("#define CMSG_ENVELOPED_DATA_V3 3")]
    public const int CMSG_ENVELOPED_DATA_V3 = 3;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENVELOPED_DATA_PKCS_1_5_VERSION"]/*' />
    [NativeTypeName("#define CMSG_ENVELOPED_DATA_PKCS_1_5_VERSION CMSG_ENVELOPED_DATA_V0")]
    public const int CMSG_ENVELOPED_DATA_PKCS_1_5_VERSION = 0;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENVELOPED_DATA_CMS_VERSION"]/*' />
    [NativeTypeName("#define CMSG_ENVELOPED_DATA_CMS_VERSION CMSG_ENVELOPED_DATA_V2")]
    public const int CMSG_ENVELOPED_DATA_CMS_VERSION = 2;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENVELOPED_DATA_ORI_VERSION"]/*' />
    [NativeTypeName("#define CMSG_ENVELOPED_DATA_ORI_VERSION CMSG_ENVELOPED_DATA_V3")]
    public const int CMSG_ENVELOPED_DATA_ORI_VERSION = 3;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_AUTH_ENVELOPED_DATA_V0"]/*' />
    [NativeTypeName("#define CMSG_AUTH_ENVELOPED_DATA_V0 0")]
    public const int CMSG_AUTH_ENVELOPED_DATA_V0 = 0;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_AGREE_ORIGINATOR_CERT"]/*' />
    [NativeTypeName("#define CMSG_KEY_AGREE_ORIGINATOR_CERT 1")]
    public const int CMSG_KEY_AGREE_ORIGINATOR_CERT = 1;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_AGREE_ORIGINATOR_PUBLIC_KEY"]/*' />
    [NativeTypeName("#define CMSG_KEY_AGREE_ORIGINATOR_PUBLIC_KEY 2")]
    public const int CMSG_KEY_AGREE_ORIGINATOR_PUBLIC_KEY = 2;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENVELOPED_RECIPIENT_V0"]/*' />
    [NativeTypeName("#define CMSG_ENVELOPED_RECIPIENT_V0 0")]
    public const int CMSG_ENVELOPED_RECIPIENT_V0 = 0;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENVELOPED_RECIPIENT_V2"]/*' />
    [NativeTypeName("#define CMSG_ENVELOPED_RECIPIENT_V2 2")]
    public const int CMSG_ENVELOPED_RECIPIENT_V2 = 2;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENVELOPED_RECIPIENT_V3"]/*' />
    [NativeTypeName("#define CMSG_ENVELOPED_RECIPIENT_V3 3")]
    public const int CMSG_ENVELOPED_RECIPIENT_V3 = 3;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENVELOPED_RECIPIENT_V4"]/*' />
    [NativeTypeName("#define CMSG_ENVELOPED_RECIPIENT_V4 4")]
    public const int CMSG_ENVELOPED_RECIPIENT_V4 = 4;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_TRANS_PKCS_1_5_VERSION"]/*' />
    [NativeTypeName("#define CMSG_KEY_TRANS_PKCS_1_5_VERSION CMSG_ENVELOPED_RECIPIENT_V0")]
    public const int CMSG_KEY_TRANS_PKCS_1_5_VERSION = 0;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_TRANS_CMS_VERSION"]/*' />
    [NativeTypeName("#define CMSG_KEY_TRANS_CMS_VERSION CMSG_ENVELOPED_RECIPIENT_V2")]
    public const int CMSG_KEY_TRANS_CMS_VERSION = 2;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_AGREE_VERSION"]/*' />
    [NativeTypeName("#define CMSG_KEY_AGREE_VERSION CMSG_ENVELOPED_RECIPIENT_V3")]
    public const int CMSG_KEY_AGREE_VERSION = 3;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_MAIL_LIST_VERSION"]/*' />
    [NativeTypeName("#define CMSG_MAIL_LIST_VERSION CMSG_ENVELOPED_RECIPIENT_V4")]
    public const int CMSG_MAIL_LIST_VERSION = 4;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEM_VERSION"]/*' />
    [NativeTypeName("#define CMSG_KEM_VERSION CMSG_ENVELOPED_RECIPIENT_V0")]
    public const int CMSG_KEM_VERSION = 0;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_VERIFY_SIGNATURE"]/*' />
    [NativeTypeName("#define CMSG_CTRL_VERIFY_SIGNATURE 1")]
    public const int CMSG_CTRL_VERIFY_SIGNATURE = 1;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_DECRYPT"]/*' />
    [NativeTypeName("#define CMSG_CTRL_DECRYPT 2")]
    public const int CMSG_CTRL_DECRYPT = 2;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_VERIFY_HASH"]/*' />
    [NativeTypeName("#define CMSG_CTRL_VERIFY_HASH 5")]
    public const int CMSG_CTRL_VERIFY_HASH = 5;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_ADD_SIGNER"]/*' />
    [NativeTypeName("#define CMSG_CTRL_ADD_SIGNER 6")]
    public const int CMSG_CTRL_ADD_SIGNER = 6;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_DEL_SIGNER"]/*' />
    [NativeTypeName("#define CMSG_CTRL_DEL_SIGNER 7")]
    public const int CMSG_CTRL_DEL_SIGNER = 7;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR"]/*' />
    [NativeTypeName("#define CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR 8")]
    public const int CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR = 8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_DEL_SIGNER_UNAUTH_ATTR"]/*' />
    [NativeTypeName("#define CMSG_CTRL_DEL_SIGNER_UNAUTH_ATTR 9")]
    public const int CMSG_CTRL_DEL_SIGNER_UNAUTH_ATTR = 9;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_ADD_CERT"]/*' />
    [NativeTypeName("#define CMSG_CTRL_ADD_CERT 10")]
    public const int CMSG_CTRL_ADD_CERT = 10;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_DEL_CERT"]/*' />
    [NativeTypeName("#define CMSG_CTRL_DEL_CERT 11")]
    public const int CMSG_CTRL_DEL_CERT = 11;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_ADD_CRL"]/*' />
    [NativeTypeName("#define CMSG_CTRL_ADD_CRL 12")]
    public const int CMSG_CTRL_ADD_CRL = 12;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_DEL_CRL"]/*' />
    [NativeTypeName("#define CMSG_CTRL_DEL_CRL 13")]
    public const int CMSG_CTRL_DEL_CRL = 13;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_ADD_ATTR_CERT"]/*' />
    [NativeTypeName("#define CMSG_CTRL_ADD_ATTR_CERT 14")]
    public const int CMSG_CTRL_ADD_ATTR_CERT = 14;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_DEL_ATTR_CERT"]/*' />
    [NativeTypeName("#define CMSG_CTRL_DEL_ATTR_CERT 15")]
    public const int CMSG_CTRL_DEL_ATTR_CERT = 15;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_KEY_TRANS_DECRYPT"]/*' />
    [NativeTypeName("#define CMSG_CTRL_KEY_TRANS_DECRYPT 16")]
    public const int CMSG_CTRL_KEY_TRANS_DECRYPT = 16;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_KEY_AGREE_DECRYPT"]/*' />
    [NativeTypeName("#define CMSG_CTRL_KEY_AGREE_DECRYPT 17")]
    public const int CMSG_CTRL_KEY_AGREE_DECRYPT = 17;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_MAIL_LIST_DECRYPT"]/*' />
    [NativeTypeName("#define CMSG_CTRL_MAIL_LIST_DECRYPT 18")]
    public const int CMSG_CTRL_MAIL_LIST_DECRYPT = 18;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_VERIFY_SIGNATURE_EX"]/*' />
    [NativeTypeName("#define CMSG_CTRL_VERIFY_SIGNATURE_EX 19")]
    public const int CMSG_CTRL_VERIFY_SIGNATURE_EX = 19;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_ADD_CMS_SIGNER_INFO"]/*' />
    [NativeTypeName("#define CMSG_CTRL_ADD_CMS_SIGNER_INFO 20")]
    public const int CMSG_CTRL_ADD_CMS_SIGNER_INFO = 20;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_ENABLE_STRONG_SIGNATURE"]/*' />
    [NativeTypeName("#define CMSG_CTRL_ENABLE_STRONG_SIGNATURE 21")]
    public const int CMSG_CTRL_ENABLE_STRONG_SIGNATURE = 21;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CTRL_KEM_DECRYPT"]/*' />
    [NativeTypeName("#define CMSG_CTRL_KEM_DECRYPT 22")]
    public const int CMSG_CTRL_KEM_DECRYPT = 22;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_VERIFY_SIGNER_PUBKEY"]/*' />
    [NativeTypeName("#define CMSG_VERIFY_SIGNER_PUBKEY 1")]
    public const int CMSG_VERIFY_SIGNER_PUBKEY = 1;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_VERIFY_SIGNER_CERT"]/*' />
    [NativeTypeName("#define CMSG_VERIFY_SIGNER_CERT 2")]
    public const int CMSG_VERIFY_SIGNER_CERT = 2;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_VERIFY_SIGNER_CHAIN"]/*' />
    [NativeTypeName("#define CMSG_VERIFY_SIGNER_CHAIN 3")]
    public const int CMSG_VERIFY_SIGNER_CHAIN = 3;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_VERIFY_SIGNER_NULL"]/*' />
    [NativeTypeName("#define CMSG_VERIFY_SIGNER_NULL 4")]
    public const int CMSG_VERIFY_SIGNER_NULL = 4;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_VERIFY_COUNTER_SIGN_ENABLE_STRONG_FLAG"]/*' />
    [NativeTypeName("#define CMSG_VERIFY_COUNTER_SIGN_ENABLE_STRONG_FLAG 0x00000001")]
    public const int CMSG_VERIFY_COUNTER_SIGN_ENABLE_STRONG_FLAG = 0x00000001;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_GEN_ENCRYPT_KEY_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_GEN_ENCRYPT_KEY_FUNC \"CryptMsgDllGenEncryptKey\"")]
    public static ReadOnlySpan<byte> CMSG_OID_GEN_ENCRYPT_KEY_FUNC => "CryptMsgDllGenEncryptKey"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_EXPORT_ENCRYPT_KEY_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_EXPORT_ENCRYPT_KEY_FUNC \"CryptMsgDllExportEncryptKey\"")]
    public static ReadOnlySpan<byte> CMSG_OID_EXPORT_ENCRYPT_KEY_FUNC => "CryptMsgDllExportEncryptKey"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_IMPORT_ENCRYPT_KEY_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_IMPORT_ENCRYPT_KEY_FUNC \"CryptMsgDllImportEncryptKey\"")]
    public static ReadOnlySpan<byte> CMSG_OID_IMPORT_ENCRYPT_KEY_FUNC => "CryptMsgDllImportEncryptKey"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_DEFAULT_INSTALLABLE_FUNC_OID"]/*' />
    [NativeTypeName("#define CMSG_DEFAULT_INSTALLABLE_FUNC_OID ((LPCSTR) 1)")]
    public static sbyte* CMSG_DEFAULT_INSTALLABLE_FUNC_OID => ((sbyte*)(1));

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CONTENT_ENCRYPT_PAD_ENCODED_LEN_FLAG"]/*' />
    [NativeTypeName("#define CMSG_CONTENT_ENCRYPT_PAD_ENCODED_LEN_FLAG 0x00000001")]
    public const int CMSG_CONTENT_ENCRYPT_PAD_ENCODED_LEN_FLAG = 0x00000001;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CONTENT_ENCRYPT_FREE_PARA_FLAG"]/*' />
    [NativeTypeName("#define CMSG_CONTENT_ENCRYPT_FREE_PARA_FLAG 0x00000001")]
    public const int CMSG_CONTENT_ENCRYPT_FREE_PARA_FLAG = 0x00000001;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CONTENT_ENCRYPT_FREE_OBJID_FLAG"]/*' />
    [NativeTypeName("#define CMSG_CONTENT_ENCRYPT_FREE_OBJID_FLAG 0x00000002")]
    public const int CMSG_CONTENT_ENCRYPT_FREE_OBJID_FLAG = 0x00000002;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CONTENT_ENCRYPT_FREE_ASN1_ENCODE_PARA_FLAG"]/*' />
    [NativeTypeName("#define CMSG_CONTENT_ENCRYPT_FREE_ASN1_ENCODE_PARA_FLAG 0x00000004")]
    public const int CMSG_CONTENT_ENCRYPT_FREE_ASN1_ENCODE_PARA_FLAG = 0x00000004;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CONTENT_ENCRYPT_RELEASE_CONTEXT_FLAG"]/*' />
    [NativeTypeName("#define CMSG_CONTENT_ENCRYPT_RELEASE_CONTEXT_FLAG 0x00008000")]
    public const int CMSG_CONTENT_ENCRYPT_RELEASE_CONTEXT_FLAG = 0x00008000;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_GEN_CONTENT_ENCRYPT_KEY_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_GEN_CONTENT_ENCRYPT_KEY_FUNC \"CryptMsgDllGenContentEncryptKey\"")]
    public static ReadOnlySpan<byte> CMSG_OID_GEN_CONTENT_ENCRYPT_KEY_FUNC => "CryptMsgDllGenContentEncryptKey"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_CAPI1_GEN_CONTENT_ENCRYPT_KEY_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_CAPI1_GEN_CONTENT_ENCRYPT_KEY_FUNC CMSG_OID_GEN_CONTENT_ENCRYPT_KEY_FUNC")]
    public static ReadOnlySpan<byte> CMSG_OID_CAPI1_GEN_CONTENT_ENCRYPT_KEY_FUNC => "CryptMsgDllGenContentEncryptKey"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_CNG_GEN_CONTENT_ENCRYPT_KEY_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_CNG_GEN_CONTENT_ENCRYPT_KEY_FUNC \"CryptMsgDllCNGGenContentEncryptKey\"")]
    public static ReadOnlySpan<byte> CMSG_OID_CNG_GEN_CONTENT_ENCRYPT_KEY_FUNC => "CryptMsgDllCNGGenContentEncryptKey"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_TRANS_ENCRYPT_FREE_PARA_FLAG"]/*' />
    [NativeTypeName("#define CMSG_KEY_TRANS_ENCRYPT_FREE_PARA_FLAG 0x00000001")]
    public const int CMSG_KEY_TRANS_ENCRYPT_FREE_PARA_FLAG = 0x00000001;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_TRANS_ENCRYPT_FREE_OBJID_FLAG"]/*' />
    [NativeTypeName("#define CMSG_KEY_TRANS_ENCRYPT_FREE_OBJID_FLAG 0x00000002")]
    public const int CMSG_KEY_TRANS_ENCRYPT_FREE_OBJID_FLAG = 0x00000002;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_EXPORT_KEY_TRANS_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_EXPORT_KEY_TRANS_FUNC \"CryptMsgDllExportKeyTrans\"")]
    public static ReadOnlySpan<byte> CMSG_OID_EXPORT_KEY_TRANS_FUNC => "CryptMsgDllExportKeyTrans"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_CAPI1_EXPORT_KEY_TRANS_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_CAPI1_EXPORT_KEY_TRANS_FUNC CMSG_OID_EXPORT_KEY_TRANS_FUNC")]
    public static ReadOnlySpan<byte> CMSG_OID_CAPI1_EXPORT_KEY_TRANS_FUNC => "CryptMsgDllExportKeyTrans"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_CNG_EXPORT_KEY_TRANS_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_CNG_EXPORT_KEY_TRANS_FUNC \"CryptMsgDllCNGExportKeyTrans\"")]
    public static ReadOnlySpan<byte> CMSG_OID_CNG_EXPORT_KEY_TRANS_FUNC => "CryptMsgDllCNGExportKeyTrans"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_AGREE_ENCRYPT_FREE_PARA_FLAG"]/*' />
    [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_PARA_FLAG 0x00000001")]
    public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PARA_FLAG = 0x00000001;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_AGREE_ENCRYPT_FREE_MATERIAL_FLAG"]/*' />
    [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_MATERIAL_FLAG 0x00000002")]
    public const int CMSG_KEY_AGREE_ENCRYPT_FREE_MATERIAL_FLAG = 0x00000002;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_ALG_FLAG"]/*' />
    [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_ALG_FLAG 0x00000004")]
    public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_ALG_FLAG = 0x00000004;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_PARA_FLAG"]/*' />
    [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_PARA_FLAG 0x00000008")]
    public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_PARA_FLAG = 0x00000008;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_BITS_FLAG"]/*' />
    [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_BITS_FLAG 0x00000010")]
    public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_BITS_FLAG = 0x00000010;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_KEY_AGREE_ENCRYPT_FREE_OBJID_FLAG"]/*' />
    [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_OBJID_FLAG 0x00000020")]
    public const int CMSG_KEY_AGREE_ENCRYPT_FREE_OBJID_FLAG = 0x00000020;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_EXPORT_KEY_AGREE_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_EXPORT_KEY_AGREE_FUNC \"CryptMsgDllExportKeyAgree\"")]
    public static ReadOnlySpan<byte> CMSG_OID_EXPORT_KEY_AGREE_FUNC => "CryptMsgDllExportKeyAgree"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_CAPI1_EXPORT_KEY_AGREE_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_CAPI1_EXPORT_KEY_AGREE_FUNC CMSG_OID_EXPORT_KEY_AGREE_FUNC")]
    public static ReadOnlySpan<byte> CMSG_OID_CAPI1_EXPORT_KEY_AGREE_FUNC => "CryptMsgDllExportKeyAgree"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_CNG_EXPORT_KEY_AGREE_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_CNG_EXPORT_KEY_AGREE_FUNC \"CryptMsgDllCNGExportKeyAgree\"")]
    public static ReadOnlySpan<byte> CMSG_OID_CNG_EXPORT_KEY_AGREE_FUNC => "CryptMsgDllCNGExportKeyAgree"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_MAIL_LIST_ENCRYPT_FREE_PARA_FLAG"]/*' />
    [NativeTypeName("#define CMSG_MAIL_LIST_ENCRYPT_FREE_PARA_FLAG 0x00000001")]
    public const int CMSG_MAIL_LIST_ENCRYPT_FREE_PARA_FLAG = 0x00000001;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_MAIL_LIST_ENCRYPT_FREE_OBJID_FLAG"]/*' />
    [NativeTypeName("#define CMSG_MAIL_LIST_ENCRYPT_FREE_OBJID_FLAG 0x00000002")]
    public const int CMSG_MAIL_LIST_ENCRYPT_FREE_OBJID_FLAG = 0x00000002;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_EXPORT_MAIL_LIST_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_EXPORT_MAIL_LIST_FUNC \"CryptMsgDllExportMailList\"")]
    public static ReadOnlySpan<byte> CMSG_OID_EXPORT_MAIL_LIST_FUNC => "CryptMsgDllExportMailList"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_CAPI1_EXPORT_MAIL_LIST_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_CAPI1_EXPORT_MAIL_LIST_FUNC CMSG_OID_EXPORT_MAIL_LIST_FUNC")]
    public static ReadOnlySpan<byte> CMSG_OID_CAPI1_EXPORT_MAIL_LIST_FUNC => "CryptMsgDllExportMailList"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_IMPORT_KEY_TRANS_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_IMPORT_KEY_TRANS_FUNC \"CryptMsgDllImportKeyTrans\"")]
    public static ReadOnlySpan<byte> CMSG_OID_IMPORT_KEY_TRANS_FUNC => "CryptMsgDllImportKeyTrans"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_CAPI1_IMPORT_KEY_TRANS_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_CAPI1_IMPORT_KEY_TRANS_FUNC CMSG_OID_IMPORT_KEY_TRANS_FUNC")]
    public static ReadOnlySpan<byte> CMSG_OID_CAPI1_IMPORT_KEY_TRANS_FUNC => "CryptMsgDllImportKeyTrans"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_IMPORT_KEY_AGREE_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_IMPORT_KEY_AGREE_FUNC \"CryptMsgDllImportKeyAgree\"")]
    public static ReadOnlySpan<byte> CMSG_OID_IMPORT_KEY_AGREE_FUNC => "CryptMsgDllImportKeyAgree"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_CAPI1_IMPORT_KEY_AGREE_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_CAPI1_IMPORT_KEY_AGREE_FUNC CMSG_OID_IMPORT_KEY_AGREE_FUNC")]
    public static ReadOnlySpan<byte> CMSG_OID_CAPI1_IMPORT_KEY_AGREE_FUNC => "CryptMsgDllImportKeyAgree"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_IMPORT_MAIL_LIST_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_IMPORT_MAIL_LIST_FUNC \"CryptMsgDllImportMailList\"")]
    public static ReadOnlySpan<byte> CMSG_OID_IMPORT_MAIL_LIST_FUNC => "CryptMsgDllImportMailList"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_CAPI1_IMPORT_MAIL_LIST_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_CAPI1_IMPORT_MAIL_LIST_FUNC CMSG_OID_IMPORT_MAIL_LIST_FUNC")]
    public static ReadOnlySpan<byte> CMSG_OID_CAPI1_IMPORT_MAIL_LIST_FUNC => "CryptMsgDllImportMailList"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_CNG_IMPORT_KEY_TRANS_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_CNG_IMPORT_KEY_TRANS_FUNC \"CryptMsgDllCNGImportKeyTrans\"")]
    public static ReadOnlySpan<byte> CMSG_OID_CNG_IMPORT_KEY_TRANS_FUNC => "CryptMsgDllCNGImportKeyTrans"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_CNG_IMPORT_KEY_AGREE_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_CNG_IMPORT_KEY_AGREE_FUNC \"CryptMsgDllCNGImportKeyAgree\"")]
    public static ReadOnlySpan<byte> CMSG_OID_CNG_IMPORT_KEY_AGREE_FUNC => "CryptMsgDllCNGImportKeyAgree"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_OID_CNG_IMPORT_CONTENT_ENCRYPT_KEY_FUNC"]/*' />
    [NativeTypeName("#define CMSG_OID_CNG_IMPORT_CONTENT_ENCRYPT_KEY_FUNC \"CryptMsgDllCNGImportContentEncryptKey\"")]
    public static ReadOnlySpan<byte> CMSG_OID_CNG_IMPORT_CONTENT_ENCRYPT_KEY_FUNC => "CryptMsgDllCNGImportContentEncryptKey"u8;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_TRUSTED_SIGNER_FLAG"]/*' />
    [NativeTypeName("#define CMSG_TRUSTED_SIGNER_FLAG 0x1")]
    public const int CMSG_TRUSTED_SIGNER_FLAG = 0x1;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_SIGNER_ONLY_FLAG"]/*' />
    [NativeTypeName("#define CMSG_SIGNER_ONLY_FLAG 0x2")]
    public const int CMSG_SIGNER_ONLY_FLAG = 0x2;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_USE_SIGNER_INDEX_FLAG"]/*' />
    [NativeTypeName("#define CMSG_USE_SIGNER_INDEX_FLAG 0x4")]
    public const int CMSG_USE_SIGNER_INDEX_FLAG = 0x4;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_CMS_ENCAPSULATED_CTL_FLAG"]/*' />
    [NativeTypeName("#define CMSG_CMS_ENCAPSULATED_CTL_FLAG 0x00008000")]
    public const int CMSG_CMS_ENCAPSULATED_CTL_FLAG = 0x00008000;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENCODE_SORTED_CTL_FLAG"]/*' />
    [NativeTypeName("#define CMSG_ENCODE_SORTED_CTL_FLAG 0x1")]
    public const int CMSG_ENCODE_SORTED_CTL_FLAG = 0x1;

    /// <include file='CMSG.xml' path='doc/member[@name="CMSG.CMSG_ENCODE_HASHED_SUBJECT_IDENTIFIER_FLAG"]/*' />
    [NativeTypeName("#define CMSG_ENCODE_HASHED_SUBJECT_IDENTIFIER_FLAG 0x2")]
    public const int CMSG_ENCODE_HASHED_SUBJECT_IDENTIFIER_FLAG = 0x2;
}
