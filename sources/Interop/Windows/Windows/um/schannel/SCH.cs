// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SCH
{
    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_V1"]/*' />
    [NativeTypeName("#define SCH_CRED_V1 0x00000001")]
    public const int SCH_CRED_V1 = 0x00000001;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_V2"]/*' />
    [NativeTypeName("#define SCH_CRED_V2 0x00000002")]
    public const int SCH_CRED_V2 = 0x00000002;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_VERSION"]/*' />
    [NativeTypeName("#define SCH_CRED_VERSION 0x00000002")]
    public const int SCH_CRED_VERSION = 0x00000002;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_V3"]/*' />
    [NativeTypeName("#define SCH_CRED_V3 0x00000003")]
    public const int SCH_CRED_V3 = 0x00000003;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CREDENTIALS_VERSION"]/*' />
    [NativeTypeName("#define SCH_CREDENTIALS_VERSION 0x00000005")]
    public const int SCH_CREDENTIALS_VERSION = 0x00000005;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_MAX_EXT_SUBSCRIPTIONS"]/*' />
    [NativeTypeName("#define SCH_MAX_EXT_SUBSCRIPTIONS 2")]
    public const int SCH_MAX_EXT_SUBSCRIPTIONS = 2;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_FORMAT_CERT_CONTEXT"]/*' />
    [NativeTypeName("#define SCH_CRED_FORMAT_CERT_CONTEXT 0x00000000")]
    public const int SCH_CRED_FORMAT_CERT_CONTEXT = 0x00000000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_FORMAT_CERT_HASH"]/*' />
    [NativeTypeName("#define SCH_CRED_FORMAT_CERT_HASH 0x00000001")]
    public const int SCH_CRED_FORMAT_CERT_HASH = 0x00000001;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_FORMAT_CERT_HASH_STORE"]/*' />
    [NativeTypeName("#define SCH_CRED_FORMAT_CERT_HASH_STORE 0x00000002")]
    public const int SCH_CRED_FORMAT_CERT_HASH_STORE = 0x00000002;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_MAX_STORE_NAME_SIZE"]/*' />
    [NativeTypeName("#define SCH_CRED_MAX_STORE_NAME_SIZE 128")]
    public const int SCH_CRED_MAX_STORE_NAME_SIZE = 128;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_MAX_SUPPORTED_ALGS"]/*' />
    [NativeTypeName("#define SCH_CRED_MAX_SUPPORTED_ALGS 256")]
    public const int SCH_CRED_MAX_SUPPORTED_ALGS = 256;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_MAX_SUPPORTED_CERTS"]/*' />
    [NativeTypeName("#define SCH_CRED_MAX_SUPPORTED_CERTS 100")]
    public const int SCH_CRED_MAX_SUPPORTED_CERTS = 100;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_MACHINE_CERT_HASH"]/*' />
    [NativeTypeName("#define SCH_MACHINE_CERT_HASH 0x00000001")]
    public const int SCH_MACHINE_CERT_HASH = 0x00000001;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_NO_SYSTEM_MAPPER"]/*' />
    [NativeTypeName("#define SCH_CRED_NO_SYSTEM_MAPPER 0x00000002")]
    public const int SCH_CRED_NO_SYSTEM_MAPPER = 0x00000002;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_NO_SERVERNAME_CHECK"]/*' />
    [NativeTypeName("#define SCH_CRED_NO_SERVERNAME_CHECK 0x00000004")]
    public const int SCH_CRED_NO_SERVERNAME_CHECK = 0x00000004;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_MANUAL_CRED_VALIDATION"]/*' />
    [NativeTypeName("#define SCH_CRED_MANUAL_CRED_VALIDATION 0x00000008")]
    public const int SCH_CRED_MANUAL_CRED_VALIDATION = 0x00000008;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_NO_DEFAULT_CREDS"]/*' />
    [NativeTypeName("#define SCH_CRED_NO_DEFAULT_CREDS 0x00000010")]
    public const int SCH_CRED_NO_DEFAULT_CREDS = 0x00000010;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_AUTO_CRED_VALIDATION"]/*' />
    [NativeTypeName("#define SCH_CRED_AUTO_CRED_VALIDATION 0x00000020")]
    public const int SCH_CRED_AUTO_CRED_VALIDATION = 0x00000020;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_USE_DEFAULT_CREDS"]/*' />
    [NativeTypeName("#define SCH_CRED_USE_DEFAULT_CREDS 0x00000040")]
    public const int SCH_CRED_USE_DEFAULT_CREDS = 0x00000040;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_DISABLE_RECONNECTS"]/*' />
    [NativeTypeName("#define SCH_CRED_DISABLE_RECONNECTS 0x00000080")]
    public const int SCH_CRED_DISABLE_RECONNECTS = 0x00000080;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_REVOCATION_CHECK_END_CERT"]/*' />
    [NativeTypeName("#define SCH_CRED_REVOCATION_CHECK_END_CERT 0x00000100")]
    public const int SCH_CRED_REVOCATION_CHECK_END_CERT = 0x00000100;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_REVOCATION_CHECK_CHAIN"]/*' />
    [NativeTypeName("#define SCH_CRED_REVOCATION_CHECK_CHAIN 0x00000200")]
    public const int SCH_CRED_REVOCATION_CHECK_CHAIN = 0x00000200;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT"]/*' />
    [NativeTypeName("#define SCH_CRED_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT 0x00000400")]
    public const int SCH_CRED_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x00000400;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_IGNORE_NO_REVOCATION_CHECK"]/*' />
    [NativeTypeName("#define SCH_CRED_IGNORE_NO_REVOCATION_CHECK 0x00000800")]
    public const int SCH_CRED_IGNORE_NO_REVOCATION_CHECK = 0x00000800;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_IGNORE_REVOCATION_OFFLINE"]/*' />
    [NativeTypeName("#define SCH_CRED_IGNORE_REVOCATION_OFFLINE 0x00001000")]
    public const int SCH_CRED_IGNORE_REVOCATION_OFFLINE = 0x00001000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_RESTRICTED_ROOTS"]/*' />
    [NativeTypeName("#define SCH_CRED_RESTRICTED_ROOTS 0x00002000")]
    public const int SCH_CRED_RESTRICTED_ROOTS = 0x00002000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_REVOCATION_CHECK_CACHE_ONLY"]/*' />
    [NativeTypeName("#define SCH_CRED_REVOCATION_CHECK_CACHE_ONLY 0x00004000")]
    public const int SCH_CRED_REVOCATION_CHECK_CACHE_ONLY = 0x00004000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_CACHE_ONLY_URL_RETRIEVAL"]/*' />
    [NativeTypeName("#define SCH_CRED_CACHE_ONLY_URL_RETRIEVAL 0x00008000")]
    public const int SCH_CRED_CACHE_ONLY_URL_RETRIEVAL = 0x00008000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_MEMORY_STORE_CERT"]/*' />
    [NativeTypeName("#define SCH_CRED_MEMORY_STORE_CERT 0x00010000")]
    public const int SCH_CRED_MEMORY_STORE_CERT = 0x00010000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_CACHE_ONLY_URL_RETRIEVAL_ON_CREATE"]/*' />
    [NativeTypeName("#define SCH_CRED_CACHE_ONLY_URL_RETRIEVAL_ON_CREATE 0x00020000")]
    public const int SCH_CRED_CACHE_ONLY_URL_RETRIEVAL_ON_CREATE = 0x00020000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_SEND_ROOT_CERT"]/*' />
    [NativeTypeName("#define SCH_SEND_ROOT_CERT 0x00040000")]
    public const int SCH_SEND_ROOT_CERT = 0x00040000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_SNI_CREDENTIAL"]/*' />
    [NativeTypeName("#define SCH_CRED_SNI_CREDENTIAL 0x00080000")]
    public const int SCH_CRED_SNI_CREDENTIAL = 0x00080000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_SNI_ENABLE_OCSP"]/*' />
    [NativeTypeName("#define SCH_CRED_SNI_ENABLE_OCSP 0x00100000")]
    public const int SCH_CRED_SNI_ENABLE_OCSP = 0x00100000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_SEND_AUX_RECORD"]/*' />
    [NativeTypeName("#define SCH_SEND_AUX_RECORD 0x00200000")]
    public const int SCH_SEND_AUX_RECORD = 0x00200000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_USE_STRONG_CRYPTO"]/*' />
    [NativeTypeName("#define SCH_USE_STRONG_CRYPTO 0x00400000")]
    public const int SCH_USE_STRONG_CRYPTO = 0x00400000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_USE_PRESHAREDKEY_ONLY"]/*' />
    [NativeTypeName("#define SCH_USE_PRESHAREDKEY_ONLY 0x00800000")]
    public const int SCH_USE_PRESHAREDKEY_ONLY = 0x00800000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_USE_DTLS_ONLY"]/*' />
    [NativeTypeName("#define SCH_USE_DTLS_ONLY 0x01000000")]
    public const int SCH_USE_DTLS_ONLY = 0x01000000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_ALLOW_NULL_ENCRYPTION"]/*' />
    [NativeTypeName("#define SCH_ALLOW_NULL_ENCRYPTION 0x02000000")]
    public const int SCH_ALLOW_NULL_ENCRYPTION = 0x02000000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_DEFERRED_CRED_VALIDATION"]/*' />
    [NativeTypeName("#define SCH_CRED_DEFERRED_CRED_VALIDATION 0x04000000")]
    public const int SCH_CRED_DEFERRED_CRED_VALIDATION = 0x04000000;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_X509_CERTCHAIN"]/*' />
    [NativeTypeName("#define SCH_CRED_X509_CERTCHAIN 0x00000001")]
    public const int SCH_CRED_X509_CERTCHAIN = 0x00000001;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_X509_CAPI"]/*' />
    [NativeTypeName("#define SCH_CRED_X509_CAPI 0x00000002")]
    public const int SCH_CRED_X509_CAPI = 0x00000002;

    /// <include file='SCH.xml' path='doc/member[@name="SCH.SCH_CRED_CERT_CONTEXT"]/*' />
    [NativeTypeName("#define SCH_CRED_CERT_CONTEXT 0x00000003")]
    public const int SCH_CRED_CERT_CONTEXT = 0x00000003;
}
