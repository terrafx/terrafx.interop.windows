// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("schannel", ExactSpelling = true)]
        public static extern BOOL SslEmptyCacheA([NativeTypeName("LPSTR")] sbyte* pszTargetName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("schannel", ExactSpelling = true)]
        public static extern BOOL SslEmptyCacheW([NativeTypeName("LPWSTR")] ushort* pszTargetName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("schannel", ExactSpelling = true)]
        public static extern BOOL SslCrackCertificate([NativeTypeName("PUCHAR")] byte* pbCertificate, [NativeTypeName("DWORD")] uint cbCertificate, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PX509Certificate *")] X509Certificate** ppCertificate);

        [DllImport("schannel", ExactSpelling = true)]
        public static extern void SslFreeCertificate([NativeTypeName("PX509Certificate")] X509Certificate* pCertificate);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("schannel", ExactSpelling = true)]
        [return: NativeTypeName("SECURITY_STATUS")]
        public static extern int SslGetServerIdentity([NativeTypeName("PBYTE")] byte* ClientHello, [NativeTypeName("DWORD")] uint ClientHelloSize, [NativeTypeName("PBYTE *")] byte** ServerIdentity, [NativeTypeName("PDWORD")] uint* ServerIdentitySize, [NativeTypeName("DWORD")] uint Flags);

        [NativeTypeName("#define UNISP_NAME_A \"Microsoft Unified Security Protocol Provider\"")]
        public static ReadOnlySpan<byte> UNISP_NAME_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x55, 0x6E, 0x69, 0x66, 0x69, 0x65, 0x64, 0x20, 0x53, 0x65, 0x63, 0x75, 0x72, 0x69, 0x74, 0x79, 0x20, 0x50, 0x72, 0x6F, 0x74, 0x6F, 0x63, 0x6F, 0x6C, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define UNISP_NAME_W L\"Microsoft Unified Security Protocol Provider\"")]
        public const string UNISP_NAME_W = "Microsoft Unified Security Protocol Provider";

        [NativeTypeName("#define SSL2SP_NAME_A \"Microsoft SSL 2.0\"")]
        public static ReadOnlySpan<byte> SSL2SP_NAME_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x53, 0x53, 0x4C, 0x20, 0x32, 0x2E, 0x30, 0x00 };

        [NativeTypeName("#define SSL2SP_NAME_W L\"Microsoft SSL 2.0\"")]
        public const string SSL2SP_NAME_W = "Microsoft SSL 2.0";

        [NativeTypeName("#define SSL3SP_NAME_A \"Microsoft SSL 3.0\"")]
        public static ReadOnlySpan<byte> SSL3SP_NAME_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x53, 0x53, 0x4C, 0x20, 0x33, 0x2E, 0x30, 0x00 };

        [NativeTypeName("#define SSL3SP_NAME_W L\"Microsoft SSL 3.0\"")]
        public const string SSL3SP_NAME_W = "Microsoft SSL 3.0";

        [NativeTypeName("#define TLS1SP_NAME_A \"Microsoft TLS 1.0\"")]
        public static ReadOnlySpan<byte> TLS1SP_NAME_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x54, 0x4C, 0x53, 0x20, 0x31, 0x2E, 0x30, 0x00 };

        [NativeTypeName("#define TLS1SP_NAME_W L\"Microsoft TLS 1.0\"")]
        public const string TLS1SP_NAME_W = "Microsoft TLS 1.0";

        [NativeTypeName("#define PCT1SP_NAME_A \"Microsoft PCT 1.0\"")]
        public static ReadOnlySpan<byte> PCT1SP_NAME_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x50, 0x43, 0x54, 0x20, 0x31, 0x2E, 0x30, 0x00 };

        [NativeTypeName("#define PCT1SP_NAME_W L\"Microsoft PCT 1.0\"")]
        public const string PCT1SP_NAME_W = "Microsoft PCT 1.0";

        [NativeTypeName("#define SCHANNEL_NAME_A \"Schannel\"")]
        public static ReadOnlySpan<byte> SCHANNEL_NAME_A => new byte[] { 0x53, 0x63, 0x68, 0x61, 0x6E, 0x6E, 0x65, 0x6C, 0x00 };

        [NativeTypeName("#define SCHANNEL_NAME_W L\"Schannel\"")]
        public const string SCHANNEL_NAME_W = "Schannel";

        [NativeTypeName("#define DEFAULT_TLS_SSP_NAME_A \"Default TLS SSP\"")]
        public static ReadOnlySpan<byte> DEFAULT_TLS_SSP_NAME_A => new byte[] { 0x44, 0x65, 0x66, 0x61, 0x75, 0x6C, 0x74, 0x20, 0x54, 0x4C, 0x53, 0x20, 0x53, 0x53, 0x50, 0x00 };

        [NativeTypeName("#define DEFAULT_TLS_SSP_NAME_W L\"Default TLS SSP\"")]
        public const string DEFAULT_TLS_SSP_NAME_W = "Default TLS SSP";

        [NativeTypeName("#define UNISP_NAME UNISP_NAME_W")]
        public const string UNISP_NAME = "Microsoft Unified Security Protocol Provider";

        [NativeTypeName("#define PCT1SP_NAME PCT1SP_NAME_W")]
        public const string PCT1SP_NAME = "Microsoft PCT 1.0";

        [NativeTypeName("#define SSL2SP_NAME SSL2SP_NAME_W")]
        public const string SSL2SP_NAME = "Microsoft SSL 2.0";

        [NativeTypeName("#define SSL3SP_NAME SSL3SP_NAME_W")]
        public const string SSL3SP_NAME = "Microsoft SSL 3.0";

        [NativeTypeName("#define TLS1SP_NAME TLS1SP_NAME_W")]
        public const string TLS1SP_NAME = "Microsoft TLS 1.0";

        [NativeTypeName("#define SCHANNEL_NAME SCHANNEL_NAME_W")]
        public const string SCHANNEL_NAME = "Schannel";

        [NativeTypeName("#define DEFAULT_TLS_SSP_NAME DEFAULT_TLS_SSP_NAME_W")]
        public const string DEFAULT_TLS_SSP_NAME = "Default TLS SSP";

        [NativeTypeName("#define UNISP_RPC_ID 14")]
        public const int UNISP_RPC_ID = 14;

        [NativeTypeName("#define RCRED_STATUS_NOCRED 0x00000000")]
        public const int RCRED_STATUS_NOCRED = 0x00000000;

        [NativeTypeName("#define RCRED_CRED_EXISTS 0x00000001")]
        public const int RCRED_CRED_EXISTS = 0x00000001;

        [NativeTypeName("#define RCRED_STATUS_UNKNOWN_ISSUER 0x00000002")]
        public const int RCRED_STATUS_UNKNOWN_ISSUER = 0x00000002;

        [NativeTypeName("#define LCRED_STATUS_NOCRED 0x00000000")]
        public const int LCRED_STATUS_NOCRED = 0x00000000;

        [NativeTypeName("#define LCRED_CRED_EXISTS 0x00000001")]
        public const int LCRED_CRED_EXISTS = 0x00000001;

        [NativeTypeName("#define LCRED_STATUS_UNKNOWN_ISSUER 0x00000002")]
        public const int LCRED_STATUS_UNKNOWN_ISSUER = 0x00000002;

        [NativeTypeName("#define SZ_ALG_MAX_SIZE 64")]
        public const int SZ_ALG_MAX_SIZE = 64;

        [NativeTypeName("#define SECPKGCONTEXT_CONNECTION_INFO_EX_V1 1")]
        public const int SECPKGCONTEXT_CONNECTION_INFO_EX_V1 = 1;

        [NativeTypeName("#define SECPKGCONTEXT_CIPHERINFO_V1 1")]
        public const int SECPKGCONTEXT_CIPHERINFO_V1 = 1;

        [NativeTypeName("#define SSL_SESSION_RECONNECT 1")]
        public const int SSL_SESSION_RECONNECT = 1;

        [NativeTypeName("#define KERN_CONTEXT_CERT_INFO_V1 0x00000000")]
        public const int KERN_CONTEXT_CERT_INFO_V1 = 0x00000000;

        [NativeTypeName("#define ENABLE_TLS_CLIENT_EARLY_START 0x00000001")]
        public const int ENABLE_TLS_CLIENT_EARLY_START = 0x00000001;

        [NativeTypeName("#define SCH_CRED_V1 0x00000001")]
        public const int SCH_CRED_V1 = 0x00000001;

        [NativeTypeName("#define SCH_CRED_V2 0x00000002")]
        public const int SCH_CRED_V2 = 0x00000002;

        [NativeTypeName("#define SCH_CRED_VERSION 0x00000002")]
        public const int SCH_CRED_VERSION = 0x00000002;

        [NativeTypeName("#define SCH_CRED_V3 0x00000003")]
        public const int SCH_CRED_V3 = 0x00000003;

        [NativeTypeName("#define SCHANNEL_CRED_VERSION 0x00000004")]
        public const int SCHANNEL_CRED_VERSION = 0x00000004;

        [NativeTypeName("#define SCH_CREDENTIALS_VERSION 0x00000005")]
        public const int SCH_CREDENTIALS_VERSION = 0x00000005;

        [NativeTypeName("#define SCH_MAX_EXT_SUBSCRIPTIONS 2")]
        public const int SCH_MAX_EXT_SUBSCRIPTIONS = 2;

        [NativeTypeName("#define SCH_CRED_FORMAT_CERT_CONTEXT 0x00000000")]
        public const int SCH_CRED_FORMAT_CERT_CONTEXT = 0x00000000;

        [NativeTypeName("#define SCH_CRED_FORMAT_CERT_HASH 0x00000001")]
        public const int SCH_CRED_FORMAT_CERT_HASH = 0x00000001;

        [NativeTypeName("#define SCH_CRED_FORMAT_CERT_HASH_STORE 0x00000002")]
        public const int SCH_CRED_FORMAT_CERT_HASH_STORE = 0x00000002;

        [NativeTypeName("#define SCH_CRED_MAX_STORE_NAME_SIZE 128")]
        public const int SCH_CRED_MAX_STORE_NAME_SIZE = 128;

        [NativeTypeName("#define SCH_CRED_MAX_SUPPORTED_ALGS 256")]
        public const int SCH_CRED_MAX_SUPPORTED_ALGS = 256;

        [NativeTypeName("#define SCH_CRED_MAX_SUPPORTED_CERTS 100")]
        public const int SCH_CRED_MAX_SUPPORTED_CERTS = 100;

        [NativeTypeName("#define SCH_MACHINE_CERT_HASH 0x00000001")]
        public const int SCH_MACHINE_CERT_HASH = 0x00000001;

        [NativeTypeName("#define SCH_CRED_NO_SYSTEM_MAPPER 0x00000002")]
        public const int SCH_CRED_NO_SYSTEM_MAPPER = 0x00000002;

        [NativeTypeName("#define SCH_CRED_NO_SERVERNAME_CHECK 0x00000004")]
        public const int SCH_CRED_NO_SERVERNAME_CHECK = 0x00000004;

        [NativeTypeName("#define SCH_CRED_MANUAL_CRED_VALIDATION 0x00000008")]
        public const int SCH_CRED_MANUAL_CRED_VALIDATION = 0x00000008;

        [NativeTypeName("#define SCH_CRED_NO_DEFAULT_CREDS 0x00000010")]
        public const int SCH_CRED_NO_DEFAULT_CREDS = 0x00000010;

        [NativeTypeName("#define SCH_CRED_AUTO_CRED_VALIDATION 0x00000020")]
        public const int SCH_CRED_AUTO_CRED_VALIDATION = 0x00000020;

        [NativeTypeName("#define SCH_CRED_USE_DEFAULT_CREDS 0x00000040")]
        public const int SCH_CRED_USE_DEFAULT_CREDS = 0x00000040;

        [NativeTypeName("#define SCH_CRED_DISABLE_RECONNECTS 0x00000080")]
        public const int SCH_CRED_DISABLE_RECONNECTS = 0x00000080;

        [NativeTypeName("#define SCH_CRED_REVOCATION_CHECK_END_CERT 0x00000100")]
        public const int SCH_CRED_REVOCATION_CHECK_END_CERT = 0x00000100;

        [NativeTypeName("#define SCH_CRED_REVOCATION_CHECK_CHAIN 0x00000200")]
        public const int SCH_CRED_REVOCATION_CHECK_CHAIN = 0x00000200;

        [NativeTypeName("#define SCH_CRED_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT 0x00000400")]
        public const int SCH_CRED_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x00000400;

        [NativeTypeName("#define SCH_CRED_IGNORE_NO_REVOCATION_CHECK 0x00000800")]
        public const int SCH_CRED_IGNORE_NO_REVOCATION_CHECK = 0x00000800;

        [NativeTypeName("#define SCH_CRED_IGNORE_REVOCATION_OFFLINE 0x00001000")]
        public const int SCH_CRED_IGNORE_REVOCATION_OFFLINE = 0x00001000;

        [NativeTypeName("#define SCH_CRED_RESTRICTED_ROOTS 0x00002000")]
        public const int SCH_CRED_RESTRICTED_ROOTS = 0x00002000;

        [NativeTypeName("#define SCH_CRED_REVOCATION_CHECK_CACHE_ONLY 0x00004000")]
        public const int SCH_CRED_REVOCATION_CHECK_CACHE_ONLY = 0x00004000;

        [NativeTypeName("#define SCH_CRED_CACHE_ONLY_URL_RETRIEVAL 0x00008000")]
        public const int SCH_CRED_CACHE_ONLY_URL_RETRIEVAL = 0x00008000;

        [NativeTypeName("#define SCH_CRED_MEMORY_STORE_CERT 0x00010000")]
        public const int SCH_CRED_MEMORY_STORE_CERT = 0x00010000;

        [NativeTypeName("#define SCH_CRED_CACHE_ONLY_URL_RETRIEVAL_ON_CREATE 0x00020000")]
        public const int SCH_CRED_CACHE_ONLY_URL_RETRIEVAL_ON_CREATE = 0x00020000;

        [NativeTypeName("#define SCH_SEND_ROOT_CERT 0x00040000")]
        public const int SCH_SEND_ROOT_CERT = 0x00040000;

        [NativeTypeName("#define SCH_CRED_SNI_CREDENTIAL 0x00080000")]
        public const int SCH_CRED_SNI_CREDENTIAL = 0x00080000;

        [NativeTypeName("#define SCH_CRED_SNI_ENABLE_OCSP 0x00100000")]
        public const int SCH_CRED_SNI_ENABLE_OCSP = 0x00100000;

        [NativeTypeName("#define SCH_SEND_AUX_RECORD 0x00200000")]
        public const int SCH_SEND_AUX_RECORD = 0x00200000;

        [NativeTypeName("#define SCH_USE_STRONG_CRYPTO 0x00400000")]
        public const int SCH_USE_STRONG_CRYPTO = 0x00400000;

        [NativeTypeName("#define SCH_USE_PRESHAREDKEY_ONLY 0x00800000")]
        public const int SCH_USE_PRESHAREDKEY_ONLY = 0x00800000;

        [NativeTypeName("#define SCH_USE_DTLS_ONLY 0x01000000")]
        public const int SCH_USE_DTLS_ONLY = 0x01000000;

        [NativeTypeName("#define SCH_ALLOW_NULL_ENCRYPTION 0x02000000")]
        public const int SCH_ALLOW_NULL_ENCRYPTION = 0x02000000;

        [NativeTypeName("#define SCH_CRED_DEFERRED_CRED_VALIDATION 0x04000000")]
        public const int SCH_CRED_DEFERRED_CRED_VALIDATION = 0x04000000;

        [NativeTypeName("#define SCHANNEL_RENEGOTIATE 0")]
        public const int SCHANNEL_RENEGOTIATE = 0;

        [NativeTypeName("#define SCHANNEL_SHUTDOWN 1")]
        public const int SCHANNEL_SHUTDOWN = 1;

        [NativeTypeName("#define SCHANNEL_ALERT 2")]
        public const int SCHANNEL_ALERT = 2;

        [NativeTypeName("#define SCHANNEL_SESSION 3")]
        public const int SCHANNEL_SESSION = 3;

        [NativeTypeName("#define TLS1_ALERT_WARNING 1")]
        public const int TLS1_ALERT_WARNING = 1;

        [NativeTypeName("#define TLS1_ALERT_FATAL 2")]
        public const int TLS1_ALERT_FATAL = 2;

        [NativeTypeName("#define TLS1_ALERT_CLOSE_NOTIFY 0")]
        public const int TLS1_ALERT_CLOSE_NOTIFY = 0;

        [NativeTypeName("#define TLS1_ALERT_UNEXPECTED_MESSAGE 10")]
        public const int TLS1_ALERT_UNEXPECTED_MESSAGE = 10;

        [NativeTypeName("#define TLS1_ALERT_BAD_RECORD_MAC 20")]
        public const int TLS1_ALERT_BAD_RECORD_MAC = 20;

        [NativeTypeName("#define TLS1_ALERT_DECRYPTION_FAILED 21")]
        public const int TLS1_ALERT_DECRYPTION_FAILED = 21;

        [NativeTypeName("#define TLS1_ALERT_RECORD_OVERFLOW 22")]
        public const int TLS1_ALERT_RECORD_OVERFLOW = 22;

        [NativeTypeName("#define TLS1_ALERT_DECOMPRESSION_FAIL 30")]
        public const int TLS1_ALERT_DECOMPRESSION_FAIL = 30;

        [NativeTypeName("#define TLS1_ALERT_HANDSHAKE_FAILURE 40")]
        public const int TLS1_ALERT_HANDSHAKE_FAILURE = 40;

        [NativeTypeName("#define TLS1_ALERT_BAD_CERTIFICATE 42")]
        public const int TLS1_ALERT_BAD_CERTIFICATE = 42;

        [NativeTypeName("#define TLS1_ALERT_UNSUPPORTED_CERT 43")]
        public const int TLS1_ALERT_UNSUPPORTED_CERT = 43;

        [NativeTypeName("#define TLS1_ALERT_CERTIFICATE_REVOKED 44")]
        public const int TLS1_ALERT_CERTIFICATE_REVOKED = 44;

        [NativeTypeName("#define TLS1_ALERT_CERTIFICATE_EXPIRED 45")]
        public const int TLS1_ALERT_CERTIFICATE_EXPIRED = 45;

        [NativeTypeName("#define TLS1_ALERT_CERTIFICATE_UNKNOWN 46")]
        public const int TLS1_ALERT_CERTIFICATE_UNKNOWN = 46;

        [NativeTypeName("#define TLS1_ALERT_ILLEGAL_PARAMETER 47")]
        public const int TLS1_ALERT_ILLEGAL_PARAMETER = 47;

        [NativeTypeName("#define TLS1_ALERT_UNKNOWN_CA 48")]
        public const int TLS1_ALERT_UNKNOWN_CA = 48;

        [NativeTypeName("#define TLS1_ALERT_ACCESS_DENIED 49")]
        public const int TLS1_ALERT_ACCESS_DENIED = 49;

        [NativeTypeName("#define TLS1_ALERT_DECODE_ERROR 50")]
        public const int TLS1_ALERT_DECODE_ERROR = 50;

        [NativeTypeName("#define TLS1_ALERT_DECRYPT_ERROR 51")]
        public const int TLS1_ALERT_DECRYPT_ERROR = 51;

        [NativeTypeName("#define TLS1_ALERT_EXPORT_RESTRICTION 60")]
        public const int TLS1_ALERT_EXPORT_RESTRICTION = 60;

        [NativeTypeName("#define TLS1_ALERT_PROTOCOL_VERSION 70")]
        public const int TLS1_ALERT_PROTOCOL_VERSION = 70;

        [NativeTypeName("#define TLS1_ALERT_INSUFFIENT_SECURITY 71")]
        public const int TLS1_ALERT_INSUFFIENT_SECURITY = 71;

        [NativeTypeName("#define TLS1_ALERT_INTERNAL_ERROR 80")]
        public const int TLS1_ALERT_INTERNAL_ERROR = 80;

        [NativeTypeName("#define TLS1_ALERT_USER_CANCELED 90")]
        public const int TLS1_ALERT_USER_CANCELED = 90;

        [NativeTypeName("#define TLS1_ALERT_NO_RENEGOTIATION 100")]
        public const int TLS1_ALERT_NO_RENEGOTIATION = 100;

        [NativeTypeName("#define TLS1_ALERT_UNSUPPORTED_EXT 110")]
        public const int TLS1_ALERT_UNSUPPORTED_EXT = 110;

        [NativeTypeName("#define TLS1_ALERT_UNKNOWN_PSK_IDENTITY 115")]
        public const int TLS1_ALERT_UNKNOWN_PSK_IDENTITY = 115;

        [NativeTypeName("#define TLS1_ALERT_NO_APP_PROTOCOL 120")]
        public const int TLS1_ALERT_NO_APP_PROTOCOL = 120;

        [NativeTypeName("#define SSL_SESSION_ENABLE_RECONNECTS 1")]
        public const int SSL_SESSION_ENABLE_RECONNECTS = 1;

        [NativeTypeName("#define SSL_SESSION_DISABLE_RECONNECTS 2")]
        public const int SSL_SESSION_DISABLE_RECONNECTS = 2;

        [NativeTypeName("#define SP_PROT_PCT1_SERVER 0x00000001")]
        public const int SP_PROT_PCT1_SERVER = 0x00000001;

        [NativeTypeName("#define SP_PROT_PCT1_CLIENT 0x00000002")]
        public const int SP_PROT_PCT1_CLIENT = 0x00000002;

        [NativeTypeName("#define SP_PROT_PCT1 (SP_PROT_PCT1_SERVER | SP_PROT_PCT1_CLIENT)")]
        public const int SP_PROT_PCT1 = (0x00000001 | 0x00000002);

        [NativeTypeName("#define SP_PROT_SSL2_SERVER 0x00000004")]
        public const int SP_PROT_SSL2_SERVER = 0x00000004;

        [NativeTypeName("#define SP_PROT_SSL2_CLIENT 0x00000008")]
        public const int SP_PROT_SSL2_CLIENT = 0x00000008;

        [NativeTypeName("#define SP_PROT_SSL2 (SP_PROT_SSL2_SERVER | SP_PROT_SSL2_CLIENT)")]
        public const int SP_PROT_SSL2 = (0x00000004 | 0x00000008);

        [NativeTypeName("#define SP_PROT_SSL3_SERVER 0x00000010")]
        public const int SP_PROT_SSL3_SERVER = 0x00000010;

        [NativeTypeName("#define SP_PROT_SSL3_CLIENT 0x00000020")]
        public const int SP_PROT_SSL3_CLIENT = 0x00000020;

        [NativeTypeName("#define SP_PROT_SSL3 (SP_PROT_SSL3_SERVER | SP_PROT_SSL3_CLIENT)")]
        public const int SP_PROT_SSL3 = (0x00000010 | 0x00000020);

        [NativeTypeName("#define SP_PROT_TLS1_SERVER 0x00000040")]
        public const int SP_PROT_TLS1_SERVER = 0x00000040;

        [NativeTypeName("#define SP_PROT_TLS1_CLIENT 0x00000080")]
        public const int SP_PROT_TLS1_CLIENT = 0x00000080;

        [NativeTypeName("#define SP_PROT_TLS1 (SP_PROT_TLS1_SERVER | SP_PROT_TLS1_CLIENT)")]
        public const int SP_PROT_TLS1 = (0x00000040 | 0x00000080);

        [NativeTypeName("#define SP_PROT_SSL3TLS1_CLIENTS (SP_PROT_TLS1_CLIENT | SP_PROT_SSL3_CLIENT)")]
        public const int SP_PROT_SSL3TLS1_CLIENTS = (0x00000080 | 0x00000020);

        [NativeTypeName("#define SP_PROT_SSL3TLS1_SERVERS (SP_PROT_TLS1_SERVER | SP_PROT_SSL3_SERVER)")]
        public const int SP_PROT_SSL3TLS1_SERVERS = (0x00000040 | 0x00000010);

        [NativeTypeName("#define SP_PROT_SSL3TLS1 (SP_PROT_SSL3 | SP_PROT_TLS1)")]
        public const int SP_PROT_SSL3TLS1 = ((0x00000010 | 0x00000020) | (0x00000040 | 0x00000080));

        [NativeTypeName("#define SP_PROT_UNI_SERVER 0x40000000")]
        public const int SP_PROT_UNI_SERVER = 0x40000000;

        [NativeTypeName("#define SP_PROT_UNI_CLIENT 0x80000000")]
        public const uint SP_PROT_UNI_CLIENT = 0x80000000;

        [NativeTypeName("#define SP_PROT_UNI (SP_PROT_UNI_SERVER | SP_PROT_UNI_CLIENT)")]
        public const uint SP_PROT_UNI = (0x40000000 | 0x80000000);

        [NativeTypeName("#define SP_PROT_ALL 0xffffffff")]
        public const uint SP_PROT_ALL = 0xffffffff;

        [NativeTypeName("#define SP_PROT_NONE 0")]
        public const int SP_PROT_NONE = 0;

        [NativeTypeName("#define SP_PROT_CLIENTS (SP_PROT_PCT1_CLIENT | SP_PROT_SSL2_CLIENT | SP_PROT_SSL3_CLIENT | SP_PROT_UNI_CLIENT | SP_PROT_TLS1_CLIENT)")]
        public const uint SP_PROT_CLIENTS = (0x00000002 | 0x00000008 | 0x00000020 | 0x80000000 | 0x00000080);

        [NativeTypeName("#define SP_PROT_SERVERS (SP_PROT_PCT1_SERVER | SP_PROT_SSL2_SERVER | SP_PROT_SSL3_SERVER | SP_PROT_UNI_SERVER | SP_PROT_TLS1_SERVER)")]
        public const int SP_PROT_SERVERS = (0x00000001 | 0x00000004 | 0x00000010 | 0x40000000 | 0x00000040);

        [NativeTypeName("#define SP_PROT_TLS1_0_SERVER SP_PROT_TLS1_SERVER")]
        public const int SP_PROT_TLS1_0_SERVER = 0x00000040;

        [NativeTypeName("#define SP_PROT_TLS1_0_CLIENT SP_PROT_TLS1_CLIENT")]
        public const int SP_PROT_TLS1_0_CLIENT = 0x00000080;

        [NativeTypeName("#define SP_PROT_TLS1_0 (SP_PROT_TLS1_0_SERVER | \\\r\n                                         SP_PROT_TLS1_0_CLIENT)")]
        public const int SP_PROT_TLS1_0 = (0x00000040 | 0x00000080);

        [NativeTypeName("#define SP_PROT_TLS1_1_SERVER 0x00000100")]
        public const int SP_PROT_TLS1_1_SERVER = 0x00000100;

        [NativeTypeName("#define SP_PROT_TLS1_1_CLIENT 0x00000200")]
        public const int SP_PROT_TLS1_1_CLIENT = 0x00000200;

        [NativeTypeName("#define SP_PROT_TLS1_1 (SP_PROT_TLS1_1_SERVER | \\\r\n                                         SP_PROT_TLS1_1_CLIENT)")]
        public const int SP_PROT_TLS1_1 = (0x00000100 | 0x00000200);

        [NativeTypeName("#define SP_PROT_TLS1_2_SERVER 0x00000400")]
        public const int SP_PROT_TLS1_2_SERVER = 0x00000400;

        [NativeTypeName("#define SP_PROT_TLS1_2_CLIENT 0x00000800")]
        public const int SP_PROT_TLS1_2_CLIENT = 0x00000800;

        [NativeTypeName("#define SP_PROT_TLS1_2 (SP_PROT_TLS1_2_SERVER | \\\r\n                                         SP_PROT_TLS1_2_CLIENT)")]
        public const int SP_PROT_TLS1_2 = (0x00000400 | 0x00000800);

        [NativeTypeName("#define SP_PROT_TLS1_3_SERVER 0x00001000")]
        public const int SP_PROT_TLS1_3_SERVER = 0x00001000;

        [NativeTypeName("#define SP_PROT_TLS1_3_CLIENT 0x00002000")]
        public const int SP_PROT_TLS1_3_CLIENT = 0x00002000;

        [NativeTypeName("#define SP_PROT_TLS1_3 (SP_PROT_TLS1_3_SERVER | \\\r\n                                         SP_PROT_TLS1_3_CLIENT)")]
        public const int SP_PROT_TLS1_3 = (0x00001000 | 0x00002000);

        [NativeTypeName("#define SP_PROT_DTLS_SERVER 0x00010000")]
        public const int SP_PROT_DTLS_SERVER = 0x00010000;

        [NativeTypeName("#define SP_PROT_DTLS_CLIENT 0x00020000")]
        public const int SP_PROT_DTLS_CLIENT = 0x00020000;

        [NativeTypeName("#define SP_PROT_DTLS (SP_PROT_DTLS_SERVER | \\\r\n                                         SP_PROT_DTLS_CLIENT )")]
        public const int SP_PROT_DTLS = (0x00010000 | 0x00020000);

        [NativeTypeName("#define SP_PROT_DTLS1_0_SERVER SP_PROT_DTLS_SERVER")]
        public const int SP_PROT_DTLS1_0_SERVER = 0x00010000;

        [NativeTypeName("#define SP_PROT_DTLS1_0_CLIENT SP_PROT_DTLS_CLIENT")]
        public const int SP_PROT_DTLS1_0_CLIENT = 0x00020000;

        [NativeTypeName("#define SP_PROT_DTLS1_0 (SP_PROT_DTLS1_0_SERVER | SP_PROT_DTLS1_0_CLIENT)")]
        public const int SP_PROT_DTLS1_0 = (0x00010000 | 0x00020000);

        [NativeTypeName("#define SP_PROT_DTLS1_2_SERVER 0x00040000")]
        public const int SP_PROT_DTLS1_2_SERVER = 0x00040000;

        [NativeTypeName("#define SP_PROT_DTLS1_2_CLIENT 0x00080000")]
        public const int SP_PROT_DTLS1_2_CLIENT = 0x00080000;

        [NativeTypeName("#define SP_PROT_DTLS1_2 (SP_PROT_DTLS1_2_SERVER | SP_PROT_DTLS1_2_CLIENT)")]
        public const int SP_PROT_DTLS1_2 = (0x00040000 | 0x00080000);

        [NativeTypeName("#define SP_PROT_DTLS1_X_SERVER (SP_PROT_DTLS1_0_SERVER | \\\r\n                                         SP_PROT_DTLS1_2_SERVER)")]
        public const int SP_PROT_DTLS1_X_SERVER = (0x00010000 | 0x00040000);

        [NativeTypeName("#define SP_PROT_DTLS1_X_CLIENT (SP_PROT_DTLS1_0_CLIENT | \\\r\n                                         SP_PROT_DTLS1_2_CLIENT)")]
        public const int SP_PROT_DTLS1_X_CLIENT = (0x00020000 | 0x00080000);

        [NativeTypeName("#define SP_PROT_DTLS1_X (SP_PROT_DTLS1_X_SERVER | \\\r\n                                         SP_PROT_DTLS1_X_CLIENT)")]
        public const int SP_PROT_DTLS1_X = ((0x00010000 | 0x00040000) | (0x00020000 | 0x00080000));

        [NativeTypeName("#define SP_PROT_TLS1_1PLUS_SERVER (SP_PROT_TLS1_1_SERVER | \\\r\n                                         SP_PROT_TLS1_2_SERVER | \\\r\n                                         SP_PROT_TLS1_3_SERVER)")]
        public const int SP_PROT_TLS1_1PLUS_SERVER = (0x00000100 | 0x00000400 | 0x00001000);

        [NativeTypeName("#define SP_PROT_TLS1_1PLUS_CLIENT (SP_PROT_TLS1_1_CLIENT | \\\r\n                                         SP_PROT_TLS1_2_CLIENT | \\\r\n                                         SP_PROT_TLS1_3_CLIENT)")]
        public const int SP_PROT_TLS1_1PLUS_CLIENT = (0x00000200 | 0x00000800 | 0x00002000);

        [NativeTypeName("#define SP_PROT_TLS1_1PLUS (SP_PROT_TLS1_1PLUS_SERVER | \\\r\n                                         SP_PROT_TLS1_1PLUS_CLIENT)")]
        public const int SP_PROT_TLS1_1PLUS = ((0x00000100 | 0x00000400 | 0x00001000) | (0x00000200 | 0x00000800 | 0x00002000));

        [NativeTypeName("#define SP_PROT_TLS1_3PLUS_SERVER SP_PROT_TLS1_3_SERVER")]
        public const int SP_PROT_TLS1_3PLUS_SERVER = 0x00001000;

        [NativeTypeName("#define SP_PROT_TLS1_3PLUS_CLIENT SP_PROT_TLS1_3_CLIENT")]
        public const int SP_PROT_TLS1_3PLUS_CLIENT = 0x00002000;

        [NativeTypeName("#define SP_PROT_TLS1_3PLUS (SP_PROT_TLS1_3PLUS_SERVER | \\\r\n                                         SP_PROT_TLS1_3PLUS_CLIENT)")]
        public const int SP_PROT_TLS1_3PLUS = (0x00001000 | 0x00002000);

        [NativeTypeName("#define SP_PROT_TLS1_X_SERVER (SP_PROT_TLS1_0_SERVER | \\\r\n                                         SP_PROT_TLS1_1_SERVER | \\\r\n                                         SP_PROT_TLS1_2_SERVER | \\\r\n                                         SP_PROT_TLS1_3_SERVER)")]
        public const int SP_PROT_TLS1_X_SERVER = (0x00000040 | 0x00000100 | 0x00000400 | 0x00001000);

        [NativeTypeName("#define SP_PROT_TLS1_X_CLIENT (SP_PROT_TLS1_0_CLIENT | \\\r\n                                         SP_PROT_TLS1_1_CLIENT | \\\r\n                                         SP_PROT_TLS1_2_CLIENT | \\\r\n                                         SP_PROT_TLS1_3_CLIENT)")]
        public const int SP_PROT_TLS1_X_CLIENT = (0x00000080 | 0x00000200 | 0x00000800 | 0x00002000);

        [NativeTypeName("#define SP_PROT_TLS1_X (SP_PROT_TLS1_X_SERVER | \\\r\n                                         SP_PROT_TLS1_X_CLIENT)")]
        public const int SP_PROT_TLS1_X = ((0x00000040 | 0x00000100 | 0x00000400 | 0x00001000) | (0x00000080 | 0x00000200 | 0x00000800 | 0x00002000));

        [NativeTypeName("#define SP_PROT_SSL3TLS1_X_CLIENTS (SP_PROT_TLS1_X_CLIENT | \\\r\n                                         SP_PROT_SSL3_CLIENT)")]
        public const int SP_PROT_SSL3TLS1_X_CLIENTS = ((0x00000080 | 0x00000200 | 0x00000800 | 0x00002000) | 0x00000020);

        [NativeTypeName("#define SP_PROT_SSL3TLS1_X_SERVERS (SP_PROT_TLS1_X_SERVER | \\\r\n                                         SP_PROT_SSL3_SERVER)")]
        public const int SP_PROT_SSL3TLS1_X_SERVERS = ((0x00000040 | 0x00000100 | 0x00000400 | 0x00001000) | 0x00000010);

        [NativeTypeName("#define SP_PROT_SSL3TLS1_X (SP_PROT_SSL3 | SP_PROT_TLS1_X)")]
        public const int SP_PROT_SSL3TLS1_X = ((0x00000010 | 0x00000020) | ((0x00000040 | 0x00000100 | 0x00000400 | 0x00001000) | (0x00000080 | 0x00000200 | 0x00000800 | 0x00002000)));

        [NativeTypeName("#define SP_PROT_X_CLIENTS (SP_PROT_CLIENTS | \\\r\n                                         SP_PROT_TLS1_X_CLIENT | \\\r\n                                         SP_PROT_DTLS1_X_CLIENT )")]
        public const uint SP_PROT_X_CLIENTS = ((0x00000002 | 0x00000008 | 0x00000020 | 0x80000000 | 0x00000080) | (0x00000080 | 0x00000200 | 0x00000800 | 0x00002000) | (0x00020000 | 0x00080000));

        [NativeTypeName("#define SP_PROT_X_SERVERS (SP_PROT_SERVERS | \\\r\n                                         SP_PROT_TLS1_X_SERVER | \\\r\n                                         SP_PROT_DTLS1_X_SERVER )")]
        public const int SP_PROT_X_SERVERS = ((0x00000001 | 0x00000004 | 0x00000010 | 0x40000000 | 0x00000040) | (0x00000040 | 0x00000100 | 0x00000400 | 0x00001000) | (0x00010000 | 0x00040000));

        [NativeTypeName("#define SslEmptyCache SslEmptyCacheW")]
        public static delegate*<ushort*, uint, BOOL> SslEmptyCache => &SslEmptyCacheW;

        [NativeTypeName("#define SCHANNEL_SECRET_TYPE_CAPI 0x00000001")]
        public const int SCHANNEL_SECRET_TYPE_CAPI = 0x00000001;

        [NativeTypeName("#define SCHANNEL_SECRET_PRIVKEY 0x00000002")]
        public const int SCHANNEL_SECRET_PRIVKEY = 0x00000002;

        [NativeTypeName("#define SCH_CRED_X509_CERTCHAIN 0x00000001")]
        public const int SCH_CRED_X509_CERTCHAIN = 0x00000001;

        [NativeTypeName("#define SCH_CRED_X509_CAPI 0x00000002")]
        public const int SCH_CRED_X509_CAPI = 0x00000002;

        [NativeTypeName("#define SCH_CRED_CERT_CONTEXT 0x00000003")]
        public const int SCH_CRED_CERT_CONTEXT = 0x00000003;

        [NativeTypeName("#define SSL_CRACK_CERTIFICATE_NAME TEXT(\"SslCrackCertificate\")")]
        public const string SSL_CRACK_CERTIFICATE_NAME = "SslCrackCertificate";

        [NativeTypeName("#define SSL_FREE_CERTIFICATE_NAME TEXT(\"SslFreeCertificate\")")]
        public const string SSL_FREE_CERTIFICATE_NAME = "SslFreeCertificate";
    }
}
