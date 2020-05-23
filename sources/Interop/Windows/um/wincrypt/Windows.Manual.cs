// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const int ALG_SID_RSA_ANY = 0;

        public const int ALG_SID_RSA_PKCS = 1;

        public const int ALG_SID_RSA_MSATWORK = 2;

        public const int ALG_SID_RSA_ENTRUST = 3;

        public const int ALG_SID_RSA_PGP = 4;

        public const int ALG_SID_DSS_ANY = 0;

        public const int ALG_SID_DSS_PKCS = 1;

        public const int ALG_SID_DSS_DMS = 2;

        public const int ALG_SID_ECDSA = 3;

        public const int ALG_SID_DES = 1;

        public const int ALG_SID_3DES = 3;

        public const int ALG_SID_DESX = 4;

        public const int ALG_SID_IDEA = 5;

        public const int ALG_SID_CAST = 6;

        public const int ALG_SID_SAFERSK64 = 7;

        public const int ALG_SID_SAFERSK128 = 8;

        public const int ALG_SID_3DES_112 = 9;

        public const int ALG_SID_CYLINK_MEK = 12;

        public const int ALG_SID_RC5 = 13;

        public const int ALG_SID_AES_128 = 14;

        public const int ALG_SID_AES_192 = 15;

        public const int ALG_SID_AES_256 = 16;

        public const int ALG_SID_AES = 17;

        public const int ALG_SID_SKIPJACK = 10;

        public const int ALG_SID_TEK = 11;

        public const int CRYPT_MODE_CBCI = 6;

        public const int CRYPT_MODE_CFBP = 7;

        public const int CRYPT_MODE_OFBP = 8;

        public const int CRYPT_MODE_CBCOFM = 9;

        public const int CRYPT_MODE_CBCOFMI = 10;

        public const int ALG_SID_RC2 = 2;

        public const int ALG_SID_RC4 = 1;

        public const int ALG_SID_SEAL = 2;

        public const int ALG_SID_DH_SANDF = 1;

        public const int ALG_SID_DH_EPHEM = 2;

        public const int ALG_SID_AGREED_KEY_ANY = 3;

        public const int ALG_SID_KEA = 4;

        public const int ALG_SID_ECDH = 5;

        public const int ALG_SID_ECDH_EPHEM = 6;

        public const int ALG_SID_MD2 = 1;

        public const int ALG_SID_MD4 = 2;

        public const int ALG_SID_MD5 = 3;

        public const int ALG_SID_SHA = 4;

        public const int ALG_SID_SHA1 = 4;

        public const int ALG_SID_MAC = 5;

        public const int ALG_SID_RIPEMD = 6;

        public const int ALG_SID_RIPEMD160 = 7;

        public const int ALG_SID_SSL3SHAMD5 = 8;

        public const int ALG_SID_HMAC = 9;

        public const int ALG_SID_TLS1PRF = 10;

        public const int ALG_SID_HASH_REPLACE_OWF = 11;

        public const int ALG_SID_SHA_256 = 12;

        public const int ALG_SID_SHA_384 = 13;

        public const int ALG_SID_SHA_512 = 14;

        public const int ALG_SID_SSL3_MASTER = 1;

        public const int ALG_SID_SCHANNEL_MASTER_HASH = 2;

        public const int ALG_SID_SCHANNEL_MAC_KEY = 3;

        public const int ALG_SID_PCT1_MASTER = 4;

        public const int ALG_SID_SSL2_MASTER = 5;

        public const int ALG_SID_TLS1_MASTER = 6;

        public const int ALG_SID_SCHANNEL_ENC_KEY = 7;

        public const int ALG_SID_ECMQV = 1;

        public const int ALG_SID_EXAMPLE = 80;

        public const int SIGNATURE_RESOURCE_NUMBER = 0x29A;

        public const uint CRYPT_VERIFYCONTEXT = 0xF0000000;

        public const int CRYPT_NEWKEYSET = 0x00000008;

        public const int CRYPT_DELETEKEYSET = 0x00000010;

        public const int CRYPT_MACHINE_KEYSET = 0x00000020;

        public const int CRYPT_SILENT = 0x00000040;

        public const int CRYPT_DEFAULT_CONTAINER_OPTIONAL = 0x00000080;

        public const int CRYPT_EXPORTABLE = 0x00000001;

        public const int CRYPT_USER_PROTECTED = 0x00000002;

        public const int CRYPT_CREATE_SALT = 0x00000004;

        public const int CRYPT_UPDATE_KEY = 0x00000008;

        public const int CRYPT_NO_SALT = 0x00000010;

        public const int CRYPT_PREGEN = 0x00000040;

        public const int CRYPT_RECIPIENT = 0x00000010;

        public const int CRYPT_INITIATOR = 0x00000040;

        public const int CRYPT_ONLINE = 0x00000080;

        public const int CRYPT_SF = 0x00000100;

        public const int CRYPT_CREATE_IV = 0x00000200;

        public const int CRYPT_KEK = 0x00000400;

        public const int CRYPT_DATA_KEY = 0x00000800;

        public const int CRYPT_VOLATILE = 0x00001000;

        public const int CRYPT_SGCKEY = 0x00002000;

        public const int CRYPT_USER_PROTECTED_STRONG = 0x00100000;

        public const int CRYPT_ARCHIVABLE = 0x00004000;

        public const int CRYPT_FORCE_KEY_PROTECTION_HIGH = 0x00008000;

        public const int RSA1024BIT_KEY = 0x04000000;

        public const int CRYPT_SERVER = 0x00000400;

        public const uint KEY_LENGTH_MASK = 0xFFFF0000;

        public const int CRYPT_Y_ONLY = 0x00000001;

        public const int CRYPT_SSL2_FALLBACK = 0x00000002;

        public const int CRYPT_DESTROYKEY = 0x00000004;

        public const int CRYPT_OAEP = 0x00000040;

        public const int CRYPT_BLOB_VER3 = 0x00000080;

        public const int CRYPT_IPSEC_HMAC_KEY = 0x00000100;

        public const int CRYPT_DECRYPT_RSA_NO_PADDING_CHECK = 0x00000020;

        public const int CRYPT_SECRETDIGEST = 0x00000001;

        public const int CRYPT_OWF_REPL_LM_HASH = 0x00000001;

        public const int CRYPT_LITTLE_ENDIAN = 0x00000001;

        public const int CRYPT_NOHASHOID = 0x00000001;

        public const int CRYPT_TYPE2_FORMAT = 0x00000002;

        public const int CRYPT_X931_FORMAT = 0x00000004;

        public const int CRYPT_MACHINE_DEFAULT = 0x00000001;

        public const int CRYPT_USER_DEFAULT = 0x00000002;

        public const int CRYPT_DELETE_DEFAULT = 0x00000004;

        public const int SIMPLEBLOB = 0x1;

        public const int PUBLICKEYBLOB = 0x6;

        public const int PRIVATEKEYBLOB = 0x7;

        public const int PLAINTEXTKEYBLOB = 0x8;

        public const int OPAQUEKEYBLOB = 0x9;

        public const int PUBLICKEYBLOBEX = 0xA;

        public const int SYMMETRICWRAPKEYBLOB = 0xB;

        public const int KEYSTATEBLOB = 0xC;

        public const int AT_KEYEXCHANGE = 1;

        public const int AT_SIGNATURE = 2;

        public const int CRYPT_USERDATA = 1;

        public const int KP_IV = 1;

        public const int KP_SALT = 2;

        public const int KP_PADDING = 3;

        public const int KP_MODE = 4;

        public const int KP_MODE_BITS = 5;

        public const int KP_PERMISSIONS = 6;

        public const int KP_ALGID = 7;

        public const int KP_BLOCKLEN = 8;

        public const int KP_KEYLEN = 9;

        public const int KP_SALT_EX = 10;

        public const int KP_P = 11;

        public const int KP_G = 12;

        public const int KP_Q = 13;

        public const int KP_X = 14;

        public const int KP_Y = 15;

        public const int KP_RA = 16;

        public const int KP_RB = 17;

        public const int KP_INFO = 18;

        public const int KP_EFFECTIVE_KEYLEN = 19;

        public const int KP_SCHANNEL_ALG = 20;

        public const int KP_CLIENT_RANDOM = 21;

        public const int KP_SERVER_RANDOM = 22;

        public const int KP_RP = 23;

        public const int KP_PRECOMP_MD5 = 24;

        public const int KP_PRECOMP_SHA = 25;

        public const int KP_CERTIFICATE = 26;

        public const int KP_CLEAR_KEY = 27;

        public const int KP_PUB_EX_LEN = 28;

        public const int KP_PUB_EX_VAL = 29;

        public const int KP_KEYVAL = 30;

        public const int KP_ADMIN_PIN = 31;

        public const int KP_KEYEXCHANGE_PIN = 32;

        public const int KP_SIGNATURE_PIN = 33;

        public const int KP_PREHASH = 34;

        public const int KP_ROUNDS = 35;

        public const int KP_OAEP_PARAMS = 36;

        public const int KP_CMS_KEY_INFO = 37;

        public const int KP_CMS_DH_KEY_INFO = 38;

        public const int KP_PUB_PARAMS = 39;

        public const int KP_VERIFY_PARAMS = 40;

        public const int KP_HIGHEST_VERSION = 41;

        public const int KP_GET_USE_COUNT = 42;

        public const int KP_PIN_ID = 43;

        public const int KP_PIN_INFO = 44;

        public const int PKCS5_PADDING = 1;

        public const int RANDOM_PADDING = 2;

        public const int ZERO_PADDING = 3;

        public const int CRYPT_MODE_CBC = 1;

        public const int CRYPT_MODE_ECB = 2;

        public const int CRYPT_MODE_OFB = 3;

        public const int CRYPT_MODE_CFB = 4;

        public const int CRYPT_MODE_CTS = 5;

        public const int CRYPT_ENCRYPT = 0x0001;

        public const int CRYPT_DECRYPT = 0x0002;

        public const int CRYPT_EXPORT = 0x0004;

        public const int CRYPT_READ = 0x0008;

        public const int CRYPT_WRITE = 0x0010;

        public const int CRYPT_MAC = 0x0020;

        public const int CRYPT_EXPORT_KEY = 0x0040;

        public const int CRYPT_IMPORT_KEY = 0x0080;

        public const int CRYPT_ARCHIVE = 0x0100;

        public const int HP_ALGID = 0x0001;

        public const int HP_HASHVAL = 0x0002;

        public const int HP_HASHSIZE = 0x0004;

        public const int HP_HMAC_INFO = 0x0005;

        public const int HP_TLS1PRF_LABEL = 0x0006;

        public const int HP_TLS1PRF_SEED = 0x0007;

        public const int PP_ENUMALGS = 1;

        public const int PP_ENUMCONTAINERS = 2;

        public const int PP_IMPTYPE = 3;

        public const int PP_NAME = 4;

        public const int PP_VERSION = 5;

        public const int PP_CONTAINER = 6;

        public const int PP_CHANGE_PASSWORD = 7;

        public const int PP_KEYSET_SEC_DESCR = 8;

        public const int PP_CERTCHAIN = 9;

        public const int PP_KEY_TYPE_SUBTYPE = 10;

        public const int PP_PROVTYPE = 16;

        public const int PP_KEYSTORAGE = 17;

        public const int PP_APPLI_CERT = 18;

        public const int PP_SYM_KEYSIZE = 19;

        public const int PP_SESSION_KEYSIZE = 20;

        public const int PP_UI_PROMPT = 21;

        public const int PP_ENUMALGS_EX = 22;

        public const int PP_ENUMMANDROOTS = 25;

        public const int PP_ENUMELECTROOTS = 26;

        public const int PP_KEYSET_TYPE = 27;

        public const int PP_ADMIN_PIN = 31;

        public const int PP_KEYEXCHANGE_PIN = 32;

        public const int PP_SIGNATURE_PIN = 33;

        public const int PP_SIG_KEYSIZE_INC = 34;

        public const int PP_KEYX_KEYSIZE_INC = 35;

        public const int PP_UNIQUE_CONTAINER = 36;

        public const int PP_SGC_INFO = 37;

        public const int PP_USE_HARDWARE_RNG = 38;

        public const int PP_KEYSPEC = 39;

        public const int PP_ENUMEX_SIGNING_PROT = 40;

        public const int PP_CRYPT_COUNT_KEY_USE = 41;

        public const int PP_USER_CERTSTORE = 42;

        public const int PP_SMARTCARD_READER = 43;

        public const int PP_SMARTCARD_GUID = 45;

        public const int PP_ROOT_CERTSTORE = 46;

        public const int PP_SMARTCARD_READER_ICON = 47;

        public const int CRYPT_FIRST = 1;

        public const int CRYPT_NEXT = 2;

        public const int CRYPT_SGC_ENUM = 4;

        public const int CRYPT_IMPL_HARDWARE = 1;

        public const int CRYPT_IMPL_SOFTWARE = 2;

        public const int CRYPT_IMPL_MIXED = 3;

        public const int CRYPT_IMPL_UNKNOWN = 4;

        public const int CRYPT_IMPL_REMOVABLE = 8;

        public const int CRYPT_SEC_DESCR = 0x00000001;

        public const int CRYPT_PSTORE = 0x00000002;

        public const int CRYPT_UI_PROMPT = 0x00000004;

        public const int CRYPT_FLAG_PCT1 = 0x0001;

        public const int CRYPT_FLAG_SSL2 = 0x0002;

        public const int CRYPT_FLAG_SSL3 = 0x0004;

        public const int CRYPT_FLAG_TLS1 = 0x0008;

        public const int CRYPT_FLAG_IPSEC = 0x0010;

        public const int CRYPT_FLAG_SIGNING = 0x0020;

        public const int CRYPT_SGC = 0x0001;

        public const int CRYPT_FASTSGC = 0x0002;

        public const int PP_CLIENT_HWND = 1;

        public const int PP_CONTEXT_INFO = 11;

        public const int PP_KEYEXCHANGE_KEYSIZE = 12;

        public const int PP_SIGNATURE_KEYSIZE = 13;

        public const int PP_KEYEXCHANGE_ALG = 14;

        public const int PP_SIGNATURE_ALG = 15;

        public const int PP_DELETEKEY = 24;

        public const int PP_PIN_PROMPT_STRING = 44;

        public const int PP_SECURE_KEYEXCHANGE_PIN = 47;

        public const int PP_SECURE_SIGNATURE_PIN = 48;

        public const int PP_DISMISS_PIN_UI_SEC = 49;

        public const int PROV_RSA_FULL = 1;

        public const int PROV_RSA_SIG = 2;

        public const int PROV_DSS = 3;

        public const int PROV_FORTEZZA = 4;

        public const int PROV_MS_EXCHANGE = 5;

        public const int PROV_SSL = 6;

        public const int PROV_RSA_SCHANNEL = 12;

        public const int PROV_DSS_DH = 13;

        public const int PROV_EC_ECDSA_SIG = 14;

        public const int PROV_EC_ECNRA_SIG = 15;

        public const int PROV_EC_ECDSA_FULL = 16;

        public const int PROV_EC_ECNRA_FULL = 17;

        public const int PROV_DH_SCHANNEL = 18;

        public const int PROV_SPYRUS_LYNKS = 20;

        public const int PROV_RNG = 21;

        public const int PROV_INTEL_SEC = 22;

        public const int PROV_REPLACE_OWF = 23;

        public const int PROV_RSA_AES = 24;

        public const int PROV_STT_MER = 7;

        public const int PROV_STT_ACQ = 8;

        public const int PROV_STT_BRND = 9;

        public const int PROV_STT_ROOT = 10;

        public const int PROV_STT_ISS = 11;

        // Microsoft Base Cryptographic Provider v1.0
        public static ReadOnlySpan<sbyte> MS_DEF_PROV_A => new sbyte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x42, 0x61, 0x73, 0x65, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x20, 0x76, 0x31, 0x2E, 0x30, 0x00 };

        public const string MS_DEF_PROV_W = "Microsoft Base Cryptographic Provider v1.0";

        // Microsoft Enhanced Cryptographic Provider v1.0
        public static ReadOnlySpan<sbyte> MS_ENHANCED_PROV_A => new sbyte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x45, 0x6E, 0x68, 0x61, 0x6E, 0x63, 0x65, 0x64, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x20, 0x76, 0x31, 0x2E, 0x30, 0x00 };

        public const string MS_ENHANCED_PROV_W = "Microsoft Enhanced Cryptographic Provider v1.0";

        // Microsoft Strong Cryptographic Provider
        public static ReadOnlySpan<sbyte> MS_STRONG_PROV_A => new sbyte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x53, 0x74, 0x72, 0x6F, 0x6E, 0x67, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        public const string MS_STRONG_PROV_W = "Microsoft Strong Cryptographic Provider";

        // Microsoft RSA Signature Cryptographic Provider
        public static ReadOnlySpan<sbyte> MS_DEF_RSA_SIG_PROV_A => new sbyte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x52, 0x53, 0x41, 0x20, 0x53, 0x69, 0x67, 0x6E, 0x61, 0x74, 0x75, 0x72, 0x65, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        public const string MS_DEF_RSA_SIG_PROV_W = "Microsoft RSA Signature Cryptographic Provider";

        // Microsoft RSA SChannel Cryptographic Provider
        public static ReadOnlySpan<sbyte> MS_DEF_RSA_SCHANNEL_PROV_A => new sbyte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x52, 0x53, 0x41, 0x20, 0x53, 0x43, 0x68, 0x61, 0x6E, 0x6E, 0x65, 0x6C, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        public const string MS_DEF_RSA_SCHANNEL_PROV_W = "Microsoft RSA SChannel Cryptographic Provider";

        // Microsoft Base DSS Cryptographic Provider
        public static ReadOnlySpan<sbyte> MS_DEF_DSS_PROV_A => new sbyte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x42, 0x61, 0x73, 0x65, 0x20, 0x44, 0x53, 0x53, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        public const string MS_DEF_DSS_PROV_W = "Microsoft Base DSS Cryptographic Provider";

        // Microsoft Base DSS and Diffie-Hellman Cryptographic Provider
        public static ReadOnlySpan<sbyte> MS_DEF_DSS_DH_PROV_A => new sbyte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x42, 0x61, 0x73, 0x65, 0x20, 0x44, 0x53, 0x53, 0x20, 0x61, 0x6E, 0x64, 0x20, 0x44, 0x69, 0x66, 0x66, 0x69, 0x65, 0x2D, 0x48, 0x65, 0x6C, 0x6C, 0x6D, 0x61, 0x6E, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        public const string MS_DEF_DSS_DH_PROV_W = "Microsoft Base DSS and Diffie-Hellman Cryptographic Provider";

        // Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider
        public static ReadOnlySpan<sbyte> MS_ENH_DSS_DH_PROV_A => new sbyte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x45, 0x6E, 0x68, 0x61, 0x6E, 0x63, 0x65, 0x64, 0x20, 0x44, 0x53, 0x53, 0x20, 0x61, 0x6E, 0x64, 0x20, 0x44, 0x69, 0x66, 0x66, 0x69, 0x65, 0x2D, 0x48, 0x65, 0x6C, 0x6C, 0x6D, 0x61, 0x6E, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        public const string MS_ENH_DSS_DH_PROV_W = "Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider";

        // Microsoft DH SChannel Cryptographic Provider
        public static ReadOnlySpan<sbyte> MS_DEF_DH_SCHANNEL_PROV_A => new sbyte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x44, 0x48, 0x20, 0x53, 0x43, 0x68, 0x61, 0x6E, 0x6E, 0x65, 0x6C, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        public const string MS_DEF_DH_SCHANNEL_PROV_W = "Microsoft DH SChannel Cryptographic Provider";

        // Microsoft Base Smart Card Crypto Provider
        public static ReadOnlySpan<sbyte> MS_SCARD_PROV_A => new sbyte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x42, 0x61, 0x73, 0x65, 0x20, 0x53, 0x6D, 0x61, 0x72, 0x74, 0x20, 0x43, 0x61, 0x72, 0x64, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        public const string MS_SCARD_PROV_W = "Microsoft Base Smart Card Crypto Provider";

        // Microsoft Enhanced RSA and AES Cryptographic Provider
        public static ReadOnlySpan<sbyte> MS_ENH_RSA_AES_PROV_A => new sbyte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x45, 0x6E, 0x68, 0x61, 0x6E, 0x63, 0x65, 0x64, 0x20, 0x52, 0x53, 0x41, 0x20, 0x61, 0x6E, 0x64, 0x20, 0x41, 0x45, 0x53, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        public const string MS_ENH_RSA_AES_PROV_W = "Microsoft Enhanced RSA and AES Cryptographic Provider";

        // Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)
        public static ReadOnlySpan<sbyte> MS_ENH_RSA_AES_PROV_XP_A => new sbyte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x45, 0x6E, 0x68, 0x61, 0x6E, 0x63, 0x65, 0x64, 0x20, 0x52, 0x53, 0x41, 0x20, 0x61, 0x6E, 0x64, 0x20, 0x41, 0x45, 0x53, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x20, 0x28, 0x50, 0x72, 0x6F, 0x74, 0x6F, 0x74, 0x79, 0x70, 0x65, 0x29, 0x00 };

        public const string MS_ENH_RSA_AES_PROV_XP_W = "Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)";

        public const int MAXUIDLEN = 64;

        // ExpoOffload
        public static ReadOnlySpan<sbyte> EXPO_OFFLOAD_REG_VALUE => new sbyte[] { 0x45, 0x78, 0x70, 0x6F, 0x4F, 0x66, 0x66, 0x6C, 0x6F, 0x61, 0x64, 0x00 };

        // OffloadModExpo
        public static ReadOnlySpan<sbyte> EXPO_OFFLOAD_FUNC_NAME => new sbyte[] { 0x4F, 0x66, 0x66, 0x6C, 0x6F, 0x61, 0x64, 0x4D, 0x6F, 0x64, 0x45, 0x78, 0x70, 0x6F, 0x00 };

        // CachePrivateKeys
        public static ReadOnlySpan<sbyte> szKEY_CACHE_ENABLED => new sbyte[] { 0x43, 0x61, 0x63, 0x68, 0x65, 0x50, 0x72, 0x69, 0x76, 0x61, 0x74, 0x65, 0x4B, 0x65, 0x79, 0x73, 0x00 };

        // PrivateKeyLifetimeSeconds
        public static ReadOnlySpan<sbyte> szKEY_CACHE_SECONDS => new sbyte[] { 0x50, 0x72, 0x69, 0x76, 0x61, 0x74, 0x65, 0x4B, 0x65, 0x79, 0x4C, 0x69, 0x66, 0x65, 0x74, 0x69, 0x6D, 0x65, 0x53, 0x65, 0x63, 0x6F, 0x6E, 0x64, 0x73, 0x00 };

        // PrivKeyCacheMaxItems
        public static ReadOnlySpan<sbyte> szPRIV_KEY_CACHE_MAX_ITEMS => new sbyte[] { 0x50, 0x72, 0x69, 0x76, 0x4B, 0x65, 0x79, 0x43, 0x61, 0x63, 0x68, 0x65, 0x4D, 0x61, 0x78, 0x49, 0x74, 0x65, 0x6D, 0x73, 0x00 };

        public const int cPRIV_KEY_CACHE_MAX_ITEMS_DEFAULT = 20;

        // PrivKeyCachePurgeIntervalSeconds
        public static ReadOnlySpan<sbyte> szPRIV_KEY_CACHE_PURGE_INTERVAL_SECONDS => new sbyte[] { 0x50, 0x72, 0x69, 0x76, 0x4B, 0x65, 0x79, 0x43, 0x61, 0x63, 0x68, 0x65, 0x50, 0x75, 0x72, 0x67, 0x65, 0x49, 0x6E, 0x74, 0x65, 0x72, 0x76, 0x61, 0x6C, 0x53, 0x65, 0x63, 0x6F, 0x6E, 0x64, 0x73, 0x00 };

        public const int cPRIV_KEY_CACHE_PURGE_INTERVAL_SECONDS_DEFAULT = 86400;

        public const int CUR_BLOB_VERSION = 2;

        public const int SCHANNEL_MAC_KEY = 0x00000000;

        public const int SCHANNEL_ENC_KEY = 0x00000001;

        public const int INTERNATIONAL_USAGE = 0x00000001;

        // 1.2.840.113549
        public static ReadOnlySpan<sbyte> szOID_RSA => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x00 };

        // 1.2.840.113549.1
        public static ReadOnlySpan<sbyte> szOID_PKCS => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x00 };

        // 1.2.840.113549.2
        public static ReadOnlySpan<sbyte> szOID_RSA_HASH => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x00 };

        // 1.2.840.113549.3
        public static ReadOnlySpan<sbyte> szOID_RSA_ENCRYPT => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x33, 0x00 };

        // 1.2.840.113549.1.1
        public static ReadOnlySpan<sbyte> szOID_PKCS_1 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 1.2.840.113549.1.2
        public static ReadOnlySpan<sbyte> szOID_PKCS_2 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        // 1.2.840.113549.1.3
        public static ReadOnlySpan<sbyte> szOID_PKCS_3 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        // 1.2.840.113549.1.4
        public static ReadOnlySpan<sbyte> szOID_PKCS_4 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        // 1.2.840.113549.1.5
        public static ReadOnlySpan<sbyte> szOID_PKCS_5 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        // 1.2.840.113549.1.6
        public static ReadOnlySpan<sbyte> szOID_PKCS_6 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x36, 0x00 };

        // 1.2.840.113549.1.7
        public static ReadOnlySpan<sbyte> szOID_PKCS_7 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x00 };

        // 1.2.840.113549.1.8
        public static ReadOnlySpan<sbyte> szOID_PKCS_8 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x38, 0x00 };

        // 1.2.840.113549.1.9
        public static ReadOnlySpan<sbyte> szOID_PKCS_9 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x00 };

        // 1.2.840.113549.1.10
        public static ReadOnlySpan<sbyte> szOID_PKCS_10 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x00 };

        // 1.2.840.113549.1.12
        public static ReadOnlySpan<sbyte> szOID_PKCS_12 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        // 1.2.840.113549.1.1.1
        public static ReadOnlySpan<sbyte> szOID_RSA_RSA => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 1.2.840.113549.1.1.2
        public static ReadOnlySpan<sbyte> szOID_RSA_MD2RSA => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        // 1.2.840.113549.1.1.3
        public static ReadOnlySpan<sbyte> szOID_RSA_MD4RSA => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        // 1.2.840.113549.1.1.4
        public static ReadOnlySpan<sbyte> szOID_RSA_MD5RSA => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        // 1.2.840.113549.1.1.5
        public static ReadOnlySpan<sbyte> szOID_RSA_SHA1RSA => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        // 1.2.840.113549.1.1.6
        public static ReadOnlySpan<sbyte> szOID_RSA_SETOAEP_RSA => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x36, 0x00 };

        // 1.2.840.113549.1.1.7
        public static ReadOnlySpan<sbyte> szOID_RSAES_OAEP => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x37, 0x00 };

        // 1.2.840.113549.1.1.8
        public static ReadOnlySpan<sbyte> szOID_RSA_MGF1 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x38, 0x00 };

        // 1.2.840.113549.1.1.9
        public static ReadOnlySpan<sbyte> szOID_RSA_PSPECIFIED => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x39, 0x00 };

        // 1.2.840.113549.1.1.10
        public static ReadOnlySpan<sbyte> szOID_RSA_SSA_PSS => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x00 };

        // 1.2.840.113549.1.1.11
        public static ReadOnlySpan<sbyte> szOID_RSA_SHA256RSA => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x00 };

        // 1.2.840.113549.1.1.12
        public static ReadOnlySpan<sbyte> szOID_RSA_SHA384RSA => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        // 1.2.840.113549.1.1.13
        public static ReadOnlySpan<sbyte> szOID_RSA_SHA512RSA => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x33, 0x00 };

        // 1.2.840.113549.1.3.1
        public static ReadOnlySpan<sbyte> szOID_RSA_DH => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        // 1.2.840.113549.1.7.1
        public static ReadOnlySpan<sbyte> szOID_RSA_data => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x31, 0x00 };

        // 1.2.840.113549.1.7.2
        public static ReadOnlySpan<sbyte> szOID_RSA_signedData => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x32, 0x00 };

        // 1.2.840.113549.1.7.3
        public static ReadOnlySpan<sbyte> szOID_RSA_envelopedData => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x33, 0x00 };

        // 1.2.840.113549.1.7.4
        public static ReadOnlySpan<sbyte> szOID_RSA_signEnvData => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x34, 0x00 };

        // 1.2.840.113549.1.7.5
        public static ReadOnlySpan<sbyte> szOID_RSA_digestedData => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x35, 0x00 };

        // 1.2.840.113549.1.7.5
        public static ReadOnlySpan<sbyte> szOID_RSA_hashedData => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x35, 0x00 };

        // 1.2.840.113549.1.7.6
        public static ReadOnlySpan<sbyte> szOID_RSA_encryptedData => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x36, 0x00 };

        // 1.2.840.113549.1.9.1
        public static ReadOnlySpan<sbyte> szOID_RSA_emailAddr => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x00 };

        // 1.2.840.113549.1.9.2
        public static ReadOnlySpan<sbyte> szOID_RSA_unstructName => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x32, 0x00 };

        // 1.2.840.113549.1.9.3
        public static ReadOnlySpan<sbyte> szOID_RSA_contentType => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x33, 0x00 };

        // 1.2.840.113549.1.9.4
        public static ReadOnlySpan<sbyte> szOID_RSA_messageDigest => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x34, 0x00 };

        // 1.2.840.113549.1.9.5
        public static ReadOnlySpan<sbyte> szOID_RSA_signingTime => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x35, 0x00 };

        // 1.2.840.113549.1.9.6
        public static ReadOnlySpan<sbyte> szOID_RSA_counterSign => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x36, 0x00 };

        // 1.2.840.113549.1.9.7
        public static ReadOnlySpan<sbyte> szOID_RSA_challengePwd => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x37, 0x00 };

        // 1.2.840.113549.1.9.8
        public static ReadOnlySpan<sbyte> szOID_RSA_unstructAddr => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x38, 0x00 };

        // 1.2.840.113549.1.9.9
        public static ReadOnlySpan<sbyte> szOID_RSA_extCertAttrs => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x39, 0x00 };

        // 1.2.840.113549.1.9.14
        public static ReadOnlySpan<sbyte> szOID_RSA_certExtensions => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x34, 0x00 };

        // 1.2.840.113549.1.9.15
        public static ReadOnlySpan<sbyte> szOID_RSA_SMIMECapabilities => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x35, 0x00 };

        // 1.2.840.113549.1.9.15.1
        public static ReadOnlySpan<sbyte> szOID_RSA_preferSignedData => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x35, 0x2E, 0x31, 0x00 };

        // 1.2.840.113549.1.9.16.1.4
        public static ReadOnlySpan<sbyte> szOID_TIMESTAMP_TOKEN => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.3.3.1
        public static ReadOnlySpan<sbyte> szOID_RFC3161_counterSign => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        // 1.2.840.113549.1.9.16.3
        public static ReadOnlySpan<sbyte> szOID_RSA_SMIMEalg => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x36, 0x2E, 0x33, 0x00 };

        // 1.2.840.113549.1.9.16.3.5
        public static ReadOnlySpan<sbyte> szOID_RSA_SMIMEalgESDH => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x36, 0x2E, 0x33, 0x2E, 0x35, 0x00 };

        // 1.2.840.113549.1.9.16.3.6
        public static ReadOnlySpan<sbyte> szOID_RSA_SMIMEalgCMS3DESwrap => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x36, 0x2E, 0x33, 0x2E, 0x36, 0x00 };

        // 1.2.840.113549.1.9.16.3.7
        public static ReadOnlySpan<sbyte> szOID_RSA_SMIMEalgCMSRC2wrap => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x36, 0x2E, 0x33, 0x2E, 0x37, 0x00 };

        // 1.2.840.113549.2.2
        public static ReadOnlySpan<sbyte> szOID_RSA_MD2 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        // 1.2.840.113549.2.4
        public static ReadOnlySpan<sbyte> szOID_RSA_MD4 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x2E, 0x34, 0x00 };

        // 1.2.840.113549.2.5
        public static ReadOnlySpan<sbyte> szOID_RSA_MD5 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x2E, 0x35, 0x00 };

        // 1.2.840.113549.3.2
        public static ReadOnlySpan<sbyte> szOID_RSA_RC2CBC => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x33, 0x2E, 0x32, 0x00 };

        // 1.2.840.113549.3.4
        public static ReadOnlySpan<sbyte> szOID_RSA_RC4 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x33, 0x2E, 0x34, 0x00 };

        // 1.2.840.113549.3.7
        public static ReadOnlySpan<sbyte> szOID_RSA_DES_EDE3_CBC => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x33, 0x2E, 0x37, 0x00 };

        // 1.2.840.113549.3.9
        public static ReadOnlySpan<sbyte> szOID_RSA_RC5_CBCPad => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x33, 0x2E, 0x39, 0x00 };

        // 1.2.840.10046
        public static ReadOnlySpan<sbyte> szOID_ANSI_X942 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x36, 0x00 };

        // 1.2.840.10046.2.1
        public static ReadOnlySpan<sbyte> szOID_ANSI_X942_DH => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x36, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        // 1.2.840.10040
        public static ReadOnlySpan<sbyte> szOID_X957 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x30, 0x00 };

        // 1.2.840.10040.4.1
        public static ReadOnlySpan<sbyte> szOID_X957_DSA => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x30, 0x2E, 0x34, 0x2E, 0x31, 0x00 };

        // 1.2.840.10040.4.3
        public static ReadOnlySpan<sbyte> szOID_X957_SHA1DSA => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x30, 0x2E, 0x34, 0x2E, 0x33, 0x00 };

        // 1.2.840.10045.2.1
        public static ReadOnlySpan<sbyte> szOID_ECC_PUBLIC_KEY => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        // 1.2.840.10045.3.1.7
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_P256 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x37, 0x00 };

        // 1.3.132.0.34
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_P384 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x34, 0x00 };

        // 1.3.132.0.35
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_P521 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x35, 0x00 };

        // 1.3.36.3.3.2.8.1.1.1
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_BRAINPOOLP160R1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 1.3.36.3.3.2.8.1.1.2
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_BRAINPOOLP160T1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        // 1.3.36.3.3.2.8.1.1.3
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_BRAINPOOLP192R1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        // 1.3.36.3.3.2.8.1.1.4
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_BRAINPOOLP192T1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        // 1.3.36.3.3.2.8.1.1.5
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_BRAINPOOLP224R1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        // 1.3.36.3.3.2.8.1.1.6
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_BRAINPOOLP224T1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x36, 0x00 };

        // 1.3.36.3.3.2.8.1.1.7
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_BRAINPOOLP256R1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x37, 0x00 };

        // 1.3.36.3.3.2.8.1.1.8
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_BRAINPOOLP256T1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x38, 0x00 };

        // 1.3.36.3.3.2.8.1.1.9
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_BRAINPOOLP320R1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x39, 0x00 };

        // 1.3.36.3.3.2.8.1.1.10
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_BRAINPOOLP320T1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x00 };

        // 1.3.36.3.3.2.8.1.1.11
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_BRAINPOOLP384R1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x00 };

        // 1.3.36.3.3.2.8.1.1.12
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_BRAINPOOLP384T1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        // 1.3.36.3.3.2.8.1.1.13
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_BRAINPOOLP512R1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x33, 0x00 };

        // 1.3.36.3.3.2.8.1.1.14
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_BRAINPOOLP512T1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x34, 0x00 };

        // 1.2.156.11235.1.1.2.1
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_EC192WAPI => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x35, 0x36, 0x2E, 0x31, 0x31, 0x32, 0x33, 0x35, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        // 1.2.156.11235.1.1.1
        public static ReadOnlySpan<sbyte> szOID_CN_ECDSA_SHA256 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x35, 0x36, 0x2E, 0x31, 0x31, 0x32, 0x33, 0x35, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 1.2.840.10045.3.1.1
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_NISTP192 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 1.3.132.0.33
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_NISTP224 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x33, 0x00 };

        // 1.3.132.0.9
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_SECP160K1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x39, 0x00 };

        // 1.3.132.0.8
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_SECP160R1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x38, 0x00 };

        // 1.3.132.0.30
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_SECP160R2 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x30, 0x00 };

        // 1.3.132.0.31
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_SECP192K1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x31, 0x00 };

        // 1.3.132.0.32
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_SECP224K1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x32, 0x00 };

        // 1.3.132.0.10
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_SECP256K1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x31, 0x30, 0x00 };

        // 2.23.43.1.4.9
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_WTLS9 => new sbyte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x34, 0x33, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x39, 0x00 };

        // 1.2.840.10045.3.1.1
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_X962P192V1 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 1.2.840.10045.3.1.2
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_X962P192V2 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        // 1.2.840.10045.3.1.3
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_X962P192V3 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        // 1.2.840.10045.3.1.4
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_X962P239V1 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        // 1.2.840.10045.3.1.5
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_X962P239V2 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        // 1.2.840.10045.3.1.6
        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_X962P239V3 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x36, 0x00 };

        // 1.2.840.10045.4.1
        public static ReadOnlySpan<sbyte> szOID_ECDSA_SHA1 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x00 };

        // 1.2.840.10045.4.3
        public static ReadOnlySpan<sbyte> szOID_ECDSA_SPECIFIED => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x00 };

        // 1.2.840.10045.4.3.2
        public static ReadOnlySpan<sbyte> szOID_ECDSA_SHA256 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x00 };

        // 1.2.840.10045.4.3.3
        public static ReadOnlySpan<sbyte> szOID_ECDSA_SHA384 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x2E, 0x33, 0x00 };

        // 1.2.840.10045.4.3.4
        public static ReadOnlySpan<sbyte> szOID_ECDSA_SHA512 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x2E, 0x34, 0x00 };

        // 2.16.840.1.101.3.4.1.2
        public static ReadOnlySpan<sbyte> szOID_NIST_AES128_CBC => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        // 2.16.840.1.101.3.4.1.22
        public static ReadOnlySpan<sbyte> szOID_NIST_AES192_CBC => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x32, 0x32, 0x00 };

        // 2.16.840.1.101.3.4.1.42
        public static ReadOnlySpan<sbyte> szOID_NIST_AES256_CBC => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x34, 0x32, 0x00 };

        // 2.16.840.1.101.3.4.1.5
        public static ReadOnlySpan<sbyte> szOID_NIST_AES128_WRAP => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        // 2.16.840.1.101.3.4.1.25
        public static ReadOnlySpan<sbyte> szOID_NIST_AES192_WRAP => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x32, 0x35, 0x00 };

        // 2.16.840.1.101.3.4.1.45
        public static ReadOnlySpan<sbyte> szOID_NIST_AES256_WRAP => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x34, 0x35, 0x00 };

        // 1.3.133.16.840.63.0.2
        public static ReadOnlySpan<sbyte> szOID_DH_SINGLE_PASS_STDDH_SHA1_KDF => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x36, 0x33, 0x2E, 0x30, 0x2E, 0x32, 0x00 };

        // 1.3.132.1.11.1
        public static ReadOnlySpan<sbyte> szOID_DH_SINGLE_PASS_STDDH_SHA256_KDF => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x2E, 0x31, 0x00 };

        // 1.3.132.1.11.2
        public static ReadOnlySpan<sbyte> szOID_DH_SINGLE_PASS_STDDH_SHA384_KDF => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x2E, 0x32, 0x00 };

        // 2.5
        public static ReadOnlySpan<sbyte> szOID_DS => new sbyte[] { 0x32, 0x2E, 0x35, 0x00 };

        // 2.5.8
        public static ReadOnlySpan<sbyte> szOID_DSALG => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x38, 0x00 };

        // 2.5.8.1
        public static ReadOnlySpan<sbyte> szOID_DSALG_CRPT => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x38, 0x2E, 0x31, 0x00 };

        // 2.5.8.2
        public static ReadOnlySpan<sbyte> szOID_DSALG_HASH => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x38, 0x2E, 0x32, 0x00 };

        // 2.5.8.3
        public static ReadOnlySpan<sbyte> szOID_DSALG_SIGN => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x38, 0x2E, 0x33, 0x00 };

        // 2.5.8.1.1
        public static ReadOnlySpan<sbyte> szOID_DSALG_RSA => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 1.3.14
        public static ReadOnlySpan<sbyte> szOID_OIW => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x00 };

        // 1.3.14.3.2
        public static ReadOnlySpan<sbyte> szOID_OIWSEC => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x00 };

        // 1.3.14.3.2.2
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_md4RSA => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        // 1.3.14.3.2.3
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_md5RSA => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        // 1.3.14.3.2.4
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_md4RSA2 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x34, 0x00 };

        // 1.3.14.3.2.6
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_desECB => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x36, 0x00 };

        // 1.3.14.3.2.7
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_desCBC => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x37, 0x00 };

        // 1.3.14.3.2.8
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_desOFB => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x00 };

        // 1.3.14.3.2.9
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_desCFB => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x39, 0x00 };

        // 1.3.14.3.2.10
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_desMAC => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x30, 0x00 };

        // 1.3.14.3.2.11
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_rsaSign => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x31, 0x00 };

        // 1.3.14.3.2.12
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_dsa => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x32, 0x00 };

        // 1.3.14.3.2.13
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_shaDSA => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x33, 0x00 };

        // 1.3.14.3.2.14
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_mdc2RSA => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x34, 0x00 };

        // 1.3.14.3.2.15
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_shaRSA => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x35, 0x00 };

        // 1.3.14.3.2.16
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_dhCommMod => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x36, 0x00 };

        // 1.3.14.3.2.17
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_desEDE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x37, 0x00 };

        // 1.3.14.3.2.18
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_sha => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x38, 0x00 };

        // 1.3.14.3.2.19
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_mdc2 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x39, 0x00 };

        // 1.3.14.3.2.20
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_dsaComm => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x30, 0x00 };

        // 1.3.14.3.2.21
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_dsaCommSHA => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x31, 0x00 };

        // 1.3.14.3.2.22
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_rsaXchg => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x32, 0x00 };

        // 1.3.14.3.2.23
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_keyHashSeal => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x33, 0x00 };

        // 1.3.14.3.2.24
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_md2RSASign => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x34, 0x00 };

        // 1.3.14.3.2.25
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_md5RSASign => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x35, 0x00 };

        // 1.3.14.3.2.26
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_sha1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x36, 0x00 };

        // 1.3.14.3.2.27
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_dsaSHA1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x37, 0x00 };

        // 1.3.14.3.2.28
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_dsaCommSHA1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x38, 0x00 };

        // 1.3.14.3.2.29
        public static ReadOnlySpan<sbyte> szOID_OIWSEC_sha1RSASign => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x39, 0x00 };

        // 1.3.14.7.2
        public static ReadOnlySpan<sbyte> szOID_OIWDIR => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x37, 0x2E, 0x32, 0x00 };

        // 1.3.14.7.2.1
        public static ReadOnlySpan<sbyte> szOID_OIWDIR_CRPT => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x37, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        // 1.3.14.7.2.2
        public static ReadOnlySpan<sbyte> szOID_OIWDIR_HASH => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x37, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        // 1.3.14.7.2.3
        public static ReadOnlySpan<sbyte> szOID_OIWDIR_SIGN => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x37, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        // 1.3.14.7.2.2.1
        public static ReadOnlySpan<sbyte> szOID_OIWDIR_md2 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x37, 0x2E, 0x32, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        // 1.3.14.7.2.3.1
        public static ReadOnlySpan<sbyte> szOID_OIWDIR_md2RSA => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x37, 0x2E, 0x32, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        // 2.16.840.1.101.2.1
        public static ReadOnlySpan<sbyte> szOID_INFOSEC => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        // 2.16.840.1.101.2.1.1.1
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_sdnsSignature => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 2.16.840.1.101.2.1.1.2
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_mosaicSignature => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        // 2.16.840.1.101.2.1.1.3
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_sdnsConfidentiality => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        // 2.16.840.1.101.2.1.1.4
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_mosaicConfidentiality => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        // 2.16.840.1.101.2.1.1.5
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_sdnsIntegrity => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        // 2.16.840.1.101.2.1.1.6
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_mosaicIntegrity => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x36, 0x00 };

        // 2.16.840.1.101.2.1.1.7
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_sdnsTokenProtection => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x37, 0x00 };

        // 2.16.840.1.101.2.1.1.8
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_mosaicTokenProtection => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x38, 0x00 };

        // 2.16.840.1.101.2.1.1.9
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_sdnsKeyManagement => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x39, 0x00 };

        // 2.16.840.1.101.2.1.1.10
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_mosaicKeyManagement => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x00 };

        // 2.16.840.1.101.2.1.1.11
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_sdnsKMandSig => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x00 };

        // 2.16.840.1.101.2.1.1.12
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_mosaicKMandSig => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        // 2.16.840.1.101.2.1.1.13
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_SuiteASignature => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x33, 0x00 };

        // 2.16.840.1.101.2.1.1.14
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_SuiteAConfidentiality => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x34, 0x00 };

        // 2.16.840.1.101.2.1.1.15
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_SuiteAIntegrity => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x35, 0x00 };

        // 2.16.840.1.101.2.1.1.16
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_SuiteATokenProtection => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x36, 0x00 };

        // 2.16.840.1.101.2.1.1.17
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_SuiteAKeyManagement => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x37, 0x00 };

        // 2.16.840.1.101.2.1.1.18
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_SuiteAKMandSig => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x38, 0x00 };

        // 2.16.840.1.101.2.1.1.19
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_mosaicUpdatedSig => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x39, 0x00 };

        // 2.16.840.1.101.2.1.1.20
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_mosaicKMandUpdSig => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x32, 0x30, 0x00 };

        // 2.16.840.1.101.2.1.1.21
        public static ReadOnlySpan<sbyte> szOID_INFOSEC_mosaicUpdatedInteg => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x32, 0x31, 0x00 };

        // 2.16.840.1.101.3.4.2.1
        public static ReadOnlySpan<sbyte> szOID_NIST_sha256 => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        // 2.16.840.1.101.3.4.2.2
        public static ReadOnlySpan<sbyte> szOID_NIST_sha384 => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        // 2.16.840.1.101.3.4.2.3
        public static ReadOnlySpan<sbyte> szOID_NIST_sha512 => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        // 2.5.4.3
        public static ReadOnlySpan<sbyte> szOID_COMMON_NAME => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x00 };

        // 2.5.4.4
        public static ReadOnlySpan<sbyte> szOID_SUR_NAME => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x34, 0x00 };

        // 2.5.4.5
        public static ReadOnlySpan<sbyte> szOID_DEVICE_SERIAL_NUMBER => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x35, 0x00 };

        // 2.5.4.6
        public static ReadOnlySpan<sbyte> szOID_COUNTRY_NAME => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x36, 0x00 };

        // 2.5.4.7
        public static ReadOnlySpan<sbyte> szOID_LOCALITY_NAME => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x37, 0x00 };

        // 2.5.4.8
        public static ReadOnlySpan<sbyte> szOID_STATE_OR_PROVINCE_NAME => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x38, 0x00 };

        // 2.5.4.9
        public static ReadOnlySpan<sbyte> szOID_STREET_ADDRESS => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x39, 0x00 };

        // 2.5.4.10
        public static ReadOnlySpan<sbyte> szOID_ORGANIZATION_NAME => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x30, 0x00 };

        // 2.5.4.11
        public static ReadOnlySpan<sbyte> szOID_ORGANIZATIONAL_UNIT_NAME => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x31, 0x00 };

        // 2.5.4.12
        public static ReadOnlySpan<sbyte> szOID_TITLE => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x32, 0x00 };

        // 2.5.4.13
        public static ReadOnlySpan<sbyte> szOID_DESCRIPTION => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x33, 0x00 };

        // 2.5.4.14
        public static ReadOnlySpan<sbyte> szOID_SEARCH_GUIDE => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x34, 0x00 };

        // 2.5.4.15
        public static ReadOnlySpan<sbyte> szOID_BUSINESS_CATEGORY => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x35, 0x00 };

        // 2.5.4.16
        public static ReadOnlySpan<sbyte> szOID_POSTAL_ADDRESS => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x36, 0x00 };

        // 2.5.4.17
        public static ReadOnlySpan<sbyte> szOID_POSTAL_CODE => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x37, 0x00 };

        // 2.5.4.18
        public static ReadOnlySpan<sbyte> szOID_POST_OFFICE_BOX => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x38, 0x00 };

        // 2.5.4.19
        public static ReadOnlySpan<sbyte> szOID_PHYSICAL_DELIVERY_OFFICE_NAME => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x39, 0x00 };

        // 2.5.4.20
        public static ReadOnlySpan<sbyte> szOID_TELEPHONE_NUMBER => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x30, 0x00 };

        // 2.5.4.21
        public static ReadOnlySpan<sbyte> szOID_TELEX_NUMBER => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x31, 0x00 };

        // 2.5.4.22
        public static ReadOnlySpan<sbyte> szOID_TELETEXT_TERMINAL_IDENTIFIER => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x32, 0x00 };

        // 2.5.4.23
        public static ReadOnlySpan<sbyte> szOID_FACSIMILE_TELEPHONE_NUMBER => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x33, 0x00 };

        // 2.5.4.24
        public static ReadOnlySpan<sbyte> szOID_X21_ADDRESS => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x34, 0x00 };

        // 2.5.4.25
        public static ReadOnlySpan<sbyte> szOID_INTERNATIONAL_ISDN_NUMBER => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x35, 0x00 };

        // 2.5.4.26
        public static ReadOnlySpan<sbyte> szOID_REGISTERED_ADDRESS => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x36, 0x00 };

        // 2.5.4.27
        public static ReadOnlySpan<sbyte> szOID_DESTINATION_INDICATOR => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x37, 0x00 };

        // 2.5.4.28
        public static ReadOnlySpan<sbyte> szOID_PREFERRED_DELIVERY_METHOD => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x38, 0x00 };

        // 2.5.4.29
        public static ReadOnlySpan<sbyte> szOID_PRESENTATION_ADDRESS => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x39, 0x00 };

        // 2.5.4.30
        public static ReadOnlySpan<sbyte> szOID_SUPPORTED_APPLICATION_CONTEXT => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x30, 0x00 };

        // 2.5.4.31
        public static ReadOnlySpan<sbyte> szOID_MEMBER => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x31, 0x00 };

        // 2.5.4.32
        public static ReadOnlySpan<sbyte> szOID_OWNER => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x32, 0x00 };

        // 2.5.4.33
        public static ReadOnlySpan<sbyte> szOID_ROLE_OCCUPANT => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x33, 0x00 };

        // 2.5.4.34
        public static ReadOnlySpan<sbyte> szOID_SEE_ALSO => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x34, 0x00 };

        // 2.5.4.35
        public static ReadOnlySpan<sbyte> szOID_USER_PASSWORD => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x35, 0x00 };

        // 2.5.4.36
        public static ReadOnlySpan<sbyte> szOID_USER_CERTIFICATE => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x36, 0x00 };

        // 2.5.4.37
        public static ReadOnlySpan<sbyte> szOID_CA_CERTIFICATE => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x37, 0x00 };

        // 2.5.4.38
        public static ReadOnlySpan<sbyte> szOID_AUTHORITY_REVOCATION_LIST => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x38, 0x00 };

        // 2.5.4.39
        public static ReadOnlySpan<sbyte> szOID_CERTIFICATE_REVOCATION_LIST => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x39, 0x00 };

        // 2.5.4.40
        public static ReadOnlySpan<sbyte> szOID_CROSS_CERTIFICATE_PAIR => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x34, 0x30, 0x00 };

        // 2.5.4.42
        public static ReadOnlySpan<sbyte> szOID_GIVEN_NAME => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x34, 0x32, 0x00 };

        // 2.5.4.43
        public static ReadOnlySpan<sbyte> szOID_INITIALS => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x34, 0x33, 0x00 };

        // 2.5.4.46
        public static ReadOnlySpan<sbyte> szOID_DN_QUALIFIER => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x34, 0x36, 0x00 };

        // 0.9.2342.19200300.100.1.25
        public static ReadOnlySpan<sbyte> szOID_DOMAIN_COMPONENT => new sbyte[] { 0x30, 0x2E, 0x39, 0x2E, 0x32, 0x33, 0x34, 0x32, 0x2E, 0x31, 0x39, 0x32, 0x30, 0x30, 0x33, 0x30, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x2E, 0x31, 0x2E, 0x32, 0x35, 0x00 };

        // 1.2.840.113549.1.9.20
        public static ReadOnlySpan<sbyte> szOID_PKCS_12_FRIENDLY_NAME_ATTR => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x32, 0x30, 0x00 };

        // 1.2.840.113549.1.9.21
        public static ReadOnlySpan<sbyte> szOID_PKCS_12_LOCAL_KEY_ID => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x32, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.17.1
        public static ReadOnlySpan<sbyte> szOID_PKCS_12_KEY_PROVIDER_NAME_ATTR => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x37, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.17.2
        public static ReadOnlySpan<sbyte> szOID_LOCAL_MACHINE_KEYSET => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x37, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.17.3
        public static ReadOnlySpan<sbyte> szOID_PKCS_12_EXTENDED_ATTRIBUTES => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x37, 0x2E, 0x33, 0x00 };

        // 1.3.6.1.4.1.311.17.4
        public static ReadOnlySpan<sbyte> szOID_PKCS_12_PROTECTED_PASSWORD_SECRET_BAG_TYPE_ID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x37, 0x2E, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.10.7.1
        public static ReadOnlySpan<sbyte> szOID_KEYID_RDN => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x37, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.60.2.1.1
        public static ReadOnlySpan<sbyte> szOID_EV_RDN_LOCALE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.60.2.1.2
        public static ReadOnlySpan<sbyte> szOID_EV_RDN_STATE_OR_PROVINCE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.60.2.1.3
        public static ReadOnlySpan<sbyte> szOID_EV_RDN_COUNTRY => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        public const int CERT_RDN_ANY_TYPE = 0;

        public const int CERT_RDN_ENCODED_BLOB = 1;

        public const int CERT_RDN_OCTET_STRING = 2;

        public const int CERT_RDN_NUMERIC_STRING = 3;

        public const int CERT_RDN_PRINTABLE_STRING = 4;

        public const int CERT_RDN_TELETEX_STRING = 5;

        public const int CERT_RDN_T61_STRING = 5;

        public const int CERT_RDN_VIDEOTEX_STRING = 6;

        public const int CERT_RDN_IA5_STRING = 7;

        public const int CERT_RDN_GRAPHIC_STRING = 8;

        public const int CERT_RDN_VISIBLE_STRING = 9;

        public const int CERT_RDN_ISO646_STRING = 9;

        public const int CERT_RDN_GENERAL_STRING = 10;

        public const int CERT_RDN_UNIVERSAL_STRING = 11;

        public const int CERT_RDN_INT4_STRING = 11;

        public const int CERT_RDN_BMP_STRING = 12;

        public const int CERT_RDN_UNICODE_STRING = 12;

        public const int CERT_RDN_UTF8_STRING = 13;

        public const int CERT_RDN_TYPE_MASK = 0x000000FF;

        public const uint CERT_RDN_FLAGS_MASK = 0xFF000000;

        public const uint CERT_RDN_ENABLE_T61_UNICODE_FLAG = 0x80000000;

        public const int CERT_RDN_ENABLE_UTF8_UNICODE_FLAG = 0x20000000;

        public const int CERT_RDN_FORCE_UTF8_UNICODE_FLAG = 0x10000000;

        public const int CERT_RDN_DISABLE_CHECK_TYPE_FLAG = 0x40000000;

        public const int CERT_RDN_DISABLE_IE4_UTF8_FLAG = 0x01000000;

        public const int CERT_RDN_ENABLE_PUNYCODE_FLAG = 0x02000000;

        public const int CRYPT_ECC_PRIVATE_KEY_INFO_v1 = 1;

        public const int CERT_V1 = 0;

        public const int CERT_V2 = 1;

        public const int CERT_V3 = 2;

        public const int CERT_INFO_VERSION_FLAG = 1;

        public const int CERT_INFO_SERIAL_NUMBER_FLAG = 2;

        public const int CERT_INFO_SIGNATURE_ALGORITHM_FLAG = 3;

        public const int CERT_INFO_ISSUER_FLAG = 4;

        public const int CERT_INFO_NOT_BEFORE_FLAG = 5;

        public const int CERT_INFO_NOT_AFTER_FLAG = 6;

        public const int CERT_INFO_SUBJECT_FLAG = 7;

        public const int CERT_INFO_SUBJECT_PUBLIC_KEY_INFO_FLAG = 8;

        public const int CERT_INFO_ISSUER_UNIQUE_ID_FLAG = 9;

        public const int CERT_INFO_SUBJECT_UNIQUE_ID_FLAG = 10;

        public const int CERT_INFO_EXTENSION_FLAG = 11;

        public const int CRL_V1 = 0;

        public const int CRL_V2 = 1;

        public const int CERT_BUNDLE_CERTIFICATE = 0;

        public const int CERT_BUNDLE_CRL = 1;

        public const int CERT_REQUEST_V1 = 0;

        public const int CERT_KEYGEN_REQUEST_V1 = 0;

        public const int CTL_V1 = 0;

        public const int CERT_ENCODING_TYPE_MASK = 0x0000FFFF;

        public const uint CMSG_ENCODING_TYPE_MASK = 0xFFFF0000;

        public const int CRYPT_ASN_ENCODING = 0x00000001;

        public const int CRYPT_NDR_ENCODING = 0x00000002;

        public const int X509_ASN_ENCODING = 0x00000001;

        public const int X509_NDR_ENCODING = 0x00000002;

        public const int PKCS_7_ASN_ENCODING = 0x00010000;

        public const int PKCS_7_NDR_ENCODING = 0x00020000;

        public const int CRYPT_FORMAT_STR_MULTI_LINE = 0x0001;

        public const int CRYPT_FORMAT_STR_NO_HEX = 0x0010;

        public const int CRYPT_FORMAT_SIMPLE = 0x0001;

        public const int CRYPT_FORMAT_X509 = 0x0002;

        public const int CRYPT_FORMAT_OID = 0x0004;

        public const int CRYPT_FORMAT_RDN_SEMICOLON = 0x0100;

        public const int CRYPT_FORMAT_RDN_CRLF = 0x0200;

        public const int CRYPT_FORMAT_RDN_UNQUOTE = 0x0400;

        public const int CRYPT_FORMAT_RDN_REVERSE = 0x0800;

        public const int CRYPT_FORMAT_COMMA = 0x1000;

        public const int CRYPT_ENCODE_NO_SIGNATURE_BYTE_REVERSAL_FLAG = 0x8;

        public const int CRYPT_ENCODE_ALLOC_FLAG = 0x8000;

        public const int CRYPT_SORTED_CTL_ENCODE_HASHED_SUBJECT_IDENTIFIER_FLAG = 0x10000;

        public const int CRYPT_ENCODE_ENABLE_PUNYCODE_FLAG = 0x20000;

        public const int CRYPT_ENCODE_ENABLE_UTF8PERCENT_FLAG = 0x40000;

        public const int CRYPT_DECODE_NOCOPY_FLAG = 0x1;

        public const int CRYPT_DECODE_TO_BE_SIGNED_FLAG = 0x2;

        public const int CRYPT_DECODE_SHARE_OID_STRING_FLAG = 0x4;

        public const int CRYPT_DECODE_NO_SIGNATURE_BYTE_REVERSAL_FLAG = 0x8;

        public const int CRYPT_DECODE_ALLOC_FLAG = 0x8000;

        public const int CRYPT_DECODE_ENABLE_PUNYCODE_FLAG = 0x02000000;

        public const int CRYPT_DECODE_ENABLE_UTF8PERCENT_FLAG = 0x04000000;

        public const int CRYPT_ENCODE_DECODE_NONE = 0;

        // 2.5.29.1
        public static ReadOnlySpan<sbyte> szOID_AUTHORITY_KEY_IDENTIFIER => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x00 };

        // 2.5.29.2
        public static ReadOnlySpan<sbyte> szOID_KEY_ATTRIBUTES => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x32, 0x00 };

        // 2.5.29.3
        public static ReadOnlySpan<sbyte> szOID_CERT_POLICIES_95 => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x00 };

        // 2.5.29.4
        public static ReadOnlySpan<sbyte> szOID_KEY_USAGE_RESTRICTION => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x34, 0x00 };

        // 2.5.29.7
        public static ReadOnlySpan<sbyte> szOID_SUBJECT_ALT_NAME => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x37, 0x00 };

        // 2.5.29.8
        public static ReadOnlySpan<sbyte> szOID_ISSUER_ALT_NAME => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x38, 0x00 };

        // 2.5.29.10
        public static ReadOnlySpan<sbyte> szOID_BASIC_CONSTRAINTS => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x30, 0x00 };

        // 2.5.29.15
        public static ReadOnlySpan<sbyte> szOID_KEY_USAGE => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x35, 0x00 };

        // 2.5.29.16
        public static ReadOnlySpan<sbyte> szOID_PRIVATEKEY_USAGE_PERIOD => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x36, 0x00 };

        // 2.5.29.19
        public static ReadOnlySpan<sbyte> szOID_BASIC_CONSTRAINTS2 => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x39, 0x00 };

        // 2.5.29.32
        public static ReadOnlySpan<sbyte> szOID_CERT_POLICIES => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x32, 0x00 };

        // 2.5.29.32.0
        public static ReadOnlySpan<sbyte> szOID_ANY_CERT_POLICY => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x32, 0x2E, 0x30, 0x00 };

        // 2.5.29.54
        public static ReadOnlySpan<sbyte> szOID_INHIBIT_ANY_POLICY => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x35, 0x34, 0x00 };

        // 2.5.29.35
        public static ReadOnlySpan<sbyte> szOID_AUTHORITY_KEY_IDENTIFIER2 => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x35, 0x00 };

        // 2.5.29.14
        public static ReadOnlySpan<sbyte> szOID_SUBJECT_KEY_IDENTIFIER => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x34, 0x00 };

        // 2.5.29.17
        public static ReadOnlySpan<sbyte> szOID_SUBJECT_ALT_NAME2 => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x37, 0x00 };

        // 2.5.29.18
        public static ReadOnlySpan<sbyte> szOID_ISSUER_ALT_NAME2 => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x38, 0x00 };

        // 2.5.29.21
        public static ReadOnlySpan<sbyte> szOID_CRL_REASON_CODE => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x32, 0x31, 0x00 };

        // 2.5.29.23
        public static ReadOnlySpan<sbyte> szOID_REASON_CODE_HOLD => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x32, 0x33, 0x00 };

        // 2.5.29.31
        public static ReadOnlySpan<sbyte> szOID_CRL_DIST_POINTS => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x31, 0x00 };

        // 2.5.29.37
        public static ReadOnlySpan<sbyte> szOID_ENHANCED_KEY_USAGE => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x37, 0x00 };

        // 2.5.29.37.0
        public static ReadOnlySpan<sbyte> szOID_ANY_ENHANCED_KEY_USAGE => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x37, 0x2E, 0x30, 0x00 };

        // 2.5.29.20
        public static ReadOnlySpan<sbyte> szOID_CRL_NUMBER => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x32, 0x30, 0x00 };

        // 2.5.29.27
        public static ReadOnlySpan<sbyte> szOID_DELTA_CRL_INDICATOR => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x32, 0x37, 0x00 };

        // 2.5.29.28
        public static ReadOnlySpan<sbyte> szOID_ISSUING_DIST_POINT => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x32, 0x38, 0x00 };

        // 2.5.29.46
        public static ReadOnlySpan<sbyte> szOID_FRESHEST_CRL => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x34, 0x36, 0x00 };

        // 2.5.29.30
        public static ReadOnlySpan<sbyte> szOID_NAME_CONSTRAINTS => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x30, 0x00 };

        // 2.5.29.33
        public static ReadOnlySpan<sbyte> szOID_POLICY_MAPPINGS => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x33, 0x00 };

        // 2.5.29.5
        public static ReadOnlySpan<sbyte> szOID_LEGACY_POLICY_MAPPINGS => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x35, 0x00 };

        // 2.5.29.36
        public static ReadOnlySpan<sbyte> szOID_POLICY_CONSTRAINTS => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x36, 0x00 };

        // 1.3.6.1.4.1.311.13.1
        public static ReadOnlySpan<sbyte> szOID_RENEWAL_CERTIFICATE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x33, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.13.2.1
        public static ReadOnlySpan<sbyte> szOID_ENROLLMENT_NAME_VALUE_PAIR => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.13.2.2
        public static ReadOnlySpan<sbyte> szOID_ENROLLMENT_CSP_PROVIDER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.13.2.3
        public static ReadOnlySpan<sbyte> szOID_OS_VERSION => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x33, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        // 1.3.6.1.4.1.311.20.2.1
        public static ReadOnlySpan<sbyte> szOID_ENROLLMENT_AGENT => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.5.5.7
        public static ReadOnlySpan<sbyte> szOID_PKIX => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x00 };

        // 1.3.6.1.5.5.7.1
        public static ReadOnlySpan<sbyte> szOID_PKIX_PE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.5.5.7.1.1
        public static ReadOnlySpan<sbyte> szOID_AUTHORITY_INFO_ACCESS => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.5.5.7.1.11
        public static ReadOnlySpan<sbyte> szOID_SUBJECT_INFO_ACCESS => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x00 };

        // 1.3.6.1.5.5.7.1.2
        public static ReadOnlySpan<sbyte> szOID_BIOMETRIC_EXT => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.5.5.7.1.3
        public static ReadOnlySpan<sbyte> szOID_QC_STATEMENTS_EXT => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        // 1.3.6.1.5.5.7.1.12
        public static ReadOnlySpan<sbyte> szOID_LOGOTYPE_EXT => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        // 1.3.6.1.5.5.7.1.24
        public static ReadOnlySpan<sbyte> szOID_TLS_FEATURES_EXT => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x2E, 0x32, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.2.1.14
        public static ReadOnlySpan<sbyte> szOID_CERT_EXTENSIONS => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.10.2
        public static ReadOnlySpan<sbyte> szOID_NEXT_UPDATE_LOCATION => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.10.8.1
        public static ReadOnlySpan<sbyte> szOID_REMOVE_CERTIFICATE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x38, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.9.1
        public static ReadOnlySpan<sbyte> szOID_CROSS_CERT_DIST_POINTS => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x39, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.1
        public static ReadOnlySpan<sbyte> szOID_CTL => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.1.1
        public static ReadOnlySpan<sbyte> szOID_SORTED_CTL => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.3.3.1
        public static ReadOnlySpan<sbyte> szOID_SERIALIZED => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.20.2.3
        public static ReadOnlySpan<sbyte> szOID_NT_PRINCIPAL_NAME => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        // 1.3.6.1.4.1.311.20.2.4
        public static ReadOnlySpan<sbyte> szOID_INTERNATIONALIZED_EMAIL_ADDRESS => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x2E, 0x32, 0x2E, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.31.1
        public static ReadOnlySpan<sbyte> szOID_PRODUCT_UPDATE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x33, 0x31, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.12.1
        public static ReadOnlySpan<sbyte> szOID_ANY_APPLICATION_POLICY => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.20.1
        public static ReadOnlySpan<sbyte> szOID_AUTO_ENROLL_CTL_USAGE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.20.2
        public static ReadOnlySpan<sbyte> szOID_ENROLL_CERTTYPE_EXTENSION => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.20.3
        public static ReadOnlySpan<sbyte> szOID_CERT_MANIFOLD => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x2E, 0x33, 0x00 };

        // 1.3.6.1.4.1.311.21.1
        public static ReadOnlySpan<sbyte> szOID_CERTSRV_CA_VERSION => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.21.2
        public static ReadOnlySpan<sbyte> szOID_CERTSRV_PREVIOUS_CERT_HASH => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.21.3
        public static ReadOnlySpan<sbyte> szOID_CRL_VIRTUAL_BASE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x00 };

        // 1.3.6.1.4.1.311.21.4
        public static ReadOnlySpan<sbyte> szOID_CRL_NEXT_PUBLISH => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.21.5
        public static ReadOnlySpan<sbyte> szOID_KP_CA_EXCHANGE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x35, 0x00 };

        // 1.3.6.1.4.1.311.21.36
        public static ReadOnlySpan<sbyte> szOID_KP_PRIVACY_CA => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x36, 0x00 };

        // 1.3.6.1.4.1.311.21.6
        public static ReadOnlySpan<sbyte> szOID_KP_KEY_RECOVERY_AGENT => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x36, 0x00 };

        // 1.3.6.1.4.1.311.21.7
        public static ReadOnlySpan<sbyte> szOID_CERTIFICATE_TEMPLATE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x37, 0x00 };

        // 1.3.6.1.4.1.311.21.8
        public static ReadOnlySpan<sbyte> szOID_ENTERPRISE_OID_ROOT => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x38, 0x00 };

        // 1.3.6.1.4.1.311.21.9
        public static ReadOnlySpan<sbyte> szOID_RDN_DUMMY_SIGNER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x39, 0x00 };

        // 1.3.6.1.4.1.311.21.10
        public static ReadOnlySpan<sbyte> szOID_APPLICATION_CERT_POLICIES => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x30, 0x00 };

        // 1.3.6.1.4.1.311.21.11
        public static ReadOnlySpan<sbyte> szOID_APPLICATION_POLICY_MAPPINGS => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.21.12
        public static ReadOnlySpan<sbyte> szOID_APPLICATION_POLICY_CONSTRAINTS => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.21.13
        public static ReadOnlySpan<sbyte> szOID_ARCHIVED_KEY_ATTR => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x33, 0x00 };

        // 1.3.6.1.4.1.311.21.14
        public static ReadOnlySpan<sbyte> szOID_CRL_SELF_CDP => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.21.15
        public static ReadOnlySpan<sbyte> szOID_REQUIRE_CERT_CHAIN_POLICY => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x35, 0x00 };

        // 1.3.6.1.4.1.311.21.16
        public static ReadOnlySpan<sbyte> szOID_ARCHIVED_KEY_CERT_HASH => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x36, 0x00 };

        // 1.3.6.1.4.1.311.21.17
        public static ReadOnlySpan<sbyte> szOID_ISSUED_CERT_HASH => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x37, 0x00 };

        // 1.3.6.1.4.1.311.21.19
        public static ReadOnlySpan<sbyte> szOID_DS_EMAIL_REPLICATION => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x39, 0x00 };

        // 1.3.6.1.4.1.311.21.20
        public static ReadOnlySpan<sbyte> szOID_REQUEST_CLIENT_INFO => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x30, 0x00 };

        // 1.3.6.1.4.1.311.21.21
        public static ReadOnlySpan<sbyte> szOID_ENCRYPTED_KEY_HASH => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.21.22
        public static ReadOnlySpan<sbyte> szOID_CERTSRV_CROSSCA_VERSION => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.25.1
        public static ReadOnlySpan<sbyte> szOID_NTDS_REPLICATION => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x35, 0x2E, 0x31, 0x00 };

        // 2.5.29.9
        public static ReadOnlySpan<sbyte> szOID_SUBJECT_DIR_ATTRS => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x39, 0x00 };

        // 1.3.6.1.5.5.7.3
        public static ReadOnlySpan<sbyte> szOID_PKIX_KP => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x00 };

        // 1.3.6.1.5.5.7.3.1
        public static ReadOnlySpan<sbyte> szOID_PKIX_KP_SERVER_AUTH => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.5.5.7.3.2
        public static ReadOnlySpan<sbyte> szOID_PKIX_KP_CLIENT_AUTH => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.5.5.7.3.3
        public static ReadOnlySpan<sbyte> szOID_PKIX_KP_CODE_SIGNING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x33, 0x00 };

        // 1.3.6.1.5.5.7.3.4
        public static ReadOnlySpan<sbyte> szOID_PKIX_KP_EMAIL_PROTECTION => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x34, 0x00 };

        // 1.3.6.1.5.5.7.3.5
        public static ReadOnlySpan<sbyte> szOID_PKIX_KP_IPSEC_END_SYSTEM => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x35, 0x00 };

        // 1.3.6.1.5.5.7.3.6
        public static ReadOnlySpan<sbyte> szOID_PKIX_KP_IPSEC_TUNNEL => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x36, 0x00 };

        // 1.3.6.1.5.5.7.3.7
        public static ReadOnlySpan<sbyte> szOID_PKIX_KP_IPSEC_USER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x37, 0x00 };

        // 1.3.6.1.5.5.7.3.8
        public static ReadOnlySpan<sbyte> szOID_PKIX_KP_TIMESTAMP_SIGNING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x38, 0x00 };

        // 1.3.6.1.5.5.7.3.9
        public static ReadOnlySpan<sbyte> szOID_PKIX_KP_OCSP_SIGNING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x39, 0x00 };

        // 1.3.6.1.5.5.7.48.1.5
        public static ReadOnlySpan<sbyte> szOID_PKIX_OCSP_NOCHECK => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        // 1.3.6.1.5.5.7.48.1.2
        public static ReadOnlySpan<sbyte> szOID_PKIX_OCSP_NONCE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.5.5.8.2.2
        public static ReadOnlySpan<sbyte> szOID_IPSEC_KP_IKE_INTERMEDIATE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x38, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.5.2.3.5
        public static ReadOnlySpan<sbyte> szOID_PKINIT_KP_KDC => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x32, 0x2E, 0x33, 0x2E, 0x35, 0x00 };

        // 1.3.6.1.4.1.311.10.3.1
        public static ReadOnlySpan<sbyte> szOID_KP_CTL_USAGE_SIGNING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.3.2
        public static ReadOnlySpan<sbyte> szOID_KP_TIME_STAMP_SIGNING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.10.3.3
        public static ReadOnlySpan<sbyte> szOID_SERVER_GATED_CRYPTO => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x00 };

        // 2.16.840.1.113730.4.1
        public static ReadOnlySpan<sbyte> szOID_SGC_NETSCAPE => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x34, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.3.4
        public static ReadOnlySpan<sbyte> szOID_KP_EFS => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.10.3.4.1
        public static ReadOnlySpan<sbyte> szOID_EFS_RECOVERY => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.3.5
        public static ReadOnlySpan<sbyte> szOID_WHQL_CRYPTO => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x35, 0x00 };

        // 1.3.6.1.4.1.311.10.3.5.1
        public static ReadOnlySpan<sbyte> szOID_ATTEST_WHQL_CRYPTO => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x35, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.3.6
        public static ReadOnlySpan<sbyte> szOID_NT5_CRYPTO => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x36, 0x00 };

        // 1.3.6.1.4.1.311.10.3.7
        public static ReadOnlySpan<sbyte> szOID_OEM_WHQL_CRYPTO => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x37, 0x00 };

        // 1.3.6.1.4.1.311.10.3.8
        public static ReadOnlySpan<sbyte> szOID_EMBEDDED_NT_CRYPTO => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x38, 0x00 };

        // 1.3.6.1.4.1.311.10.3.9
        public static ReadOnlySpan<sbyte> szOID_ROOT_LIST_SIGNER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x39, 0x00 };

        // 1.3.6.1.4.1.311.10.3.10
        public static ReadOnlySpan<sbyte> szOID_KP_QUALIFIED_SUBORDINATION => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x30, 0x00 };

        // 1.3.6.1.4.1.311.10.3.11
        public static ReadOnlySpan<sbyte> szOID_KP_KEY_RECOVERY => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.3.12
        public static ReadOnlySpan<sbyte> szOID_KP_DOCUMENT_SIGNING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.10.3.13
        public static ReadOnlySpan<sbyte> szOID_KP_LIFETIME_SIGNING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x00 };

        // 1.3.6.1.4.1.311.10.3.14
        public static ReadOnlySpan<sbyte> szOID_KP_MOBILE_DEVICE_SOFTWARE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.10.3.15
        public static ReadOnlySpan<sbyte> szOID_KP_SMART_DISPLAY => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x35, 0x00 };

        // 1.3.6.1.4.1.311.10.3.16
        public static ReadOnlySpan<sbyte> szOID_KP_CSP_SIGNATURE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x36, 0x00 };

        // 1.3.6.1.4.1.311.10.3.27
        public static ReadOnlySpan<sbyte> szOID_KP_FLIGHT_SIGNING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x37, 0x00 };

        // 1.3.6.1.4.1.311.10.3.28
        public static ReadOnlySpan<sbyte> szOID_PLATFORM_MANIFEST_BINARY_ID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x38, 0x00 };

        // 1.3.6.1.4.1.311.10.5.1
        public static ReadOnlySpan<sbyte> szOID_DRM => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x35, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.5.2
        public static ReadOnlySpan<sbyte> szOID_DRM_INDIVIDUALIZATION => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x35, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.10.6.1
        public static ReadOnlySpan<sbyte> szOID_LICENSES => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x36, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.6.2
        public static ReadOnlySpan<sbyte> szOID_LICENSE_SERVER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x36, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.20.2.2
        public static ReadOnlySpan<sbyte> szOID_KP_SMARTCARD_LOGON => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.61.1.1
        public static ReadOnlySpan<sbyte> szOID_KP_KERNEL_MODE_CODE_SIGNING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.61.4.1
        public static ReadOnlySpan<sbyte> szOID_KP_KERNEL_MODE_TRUSTED_BOOT_SIGNING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.3.19
        public static ReadOnlySpan<sbyte> szOID_REVOKED_LIST_SIGNER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x39, 0x00 };

        // 1.3.6.1.4.1.311.10.3.20
        public static ReadOnlySpan<sbyte> szOID_WINDOWS_KITS_SIGNER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x30, 0x00 };

        // 1.3.6.1.4.1.311.10.3.21
        public static ReadOnlySpan<sbyte> szOID_WINDOWS_RT_SIGNER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.3.22
        public static ReadOnlySpan<sbyte> szOID_PROTECTED_PROCESS_LIGHT_SIGNER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.10.3.23
        public static ReadOnlySpan<sbyte> szOID_WINDOWS_TCB_SIGNER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x33, 0x00 };

        // 1.3.6.1.4.1.311.10.3.24
        public static ReadOnlySpan<sbyte> szOID_PROTECTED_PROCESS_SIGNER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.10.3.25
        public static ReadOnlySpan<sbyte> szOID_WINDOWS_THIRD_PARTY_COMPONENT_SIGNER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x35, 0x00 };

        // 1.3.6.1.4.1.311.10.3.26
        public static ReadOnlySpan<sbyte> szOID_WINDOWS_SOFTWARE_EXTENSION_SIGNER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x36, 0x00 };

        // 1.3.6.1.4.1.311.10.3.30
        public static ReadOnlySpan<sbyte> szOID_DISALLOWED_LIST => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x30, 0x00 };

        // 1.3.6.1.4.1.311.10.3.31
        public static ReadOnlySpan<sbyte> szOID_PIN_RULES_SIGNER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.3.32
        public static ReadOnlySpan<sbyte> szOID_PIN_RULES_CTL => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.10.3.33
        public static ReadOnlySpan<sbyte> szOID_PIN_RULES_EXT => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x33, 0x00 };

        // 1.3.6.1.4.1.311.10.3.34
        public static ReadOnlySpan<sbyte> szOID_PIN_RULES_DOMAIN_NAME => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.10.3.35
        public static ReadOnlySpan<sbyte> szOID_PIN_RULES_LOG_END_DATE_EXT => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x35, 0x00 };

        // 1.3.6.1.4.1.311.10.3.37
        public static ReadOnlySpan<sbyte> szOID_IUM_SIGNING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x37, 0x00 };

        // 1.3.6.1.4.1.311.10.3.39
        public static ReadOnlySpan<sbyte> szOID_EV_WHQL_CRYPTO => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x39, 0x00 };

        // 1.3.6.1.4.1.311.10.3.41
        public static ReadOnlySpan<sbyte> szOID_BIOMETRIC_SIGNING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x34, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.3.42
        public static ReadOnlySpan<sbyte> szOID_ENCLAVE_SIGNING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x34, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.10.3.50
        public static ReadOnlySpan<sbyte> szOID_SYNC_ROOT_CTL_EXT => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x35, 0x30, 0x00 };

        // 1.3.6.1.4.1.311.10.3.60
        public static ReadOnlySpan<sbyte> szOID_HPKP_DOMAIN_NAME_CTL => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x36, 0x30, 0x00 };

        // 1.3.6.1.4.1.311.10.3.61
        public static ReadOnlySpan<sbyte> szOID_HPKP_HEADER_VALUE_CTL => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x36, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.61.5.1
        public static ReadOnlySpan<sbyte> szOID_KP_KERNEL_MODE_HAL_EXTENSION_SIGNING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x31, 0x2E, 0x35, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.76.3.1
        public static ReadOnlySpan<sbyte> szOID_WINDOWS_STORE_SIGNER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x36, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.76.5.1
        public static ReadOnlySpan<sbyte> szOID_DYNAMIC_CODE_GEN_SIGNER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x36, 0x2E, 0x35, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.76.8.1
        public static ReadOnlySpan<sbyte> szOID_MICROSOFT_PUBLISHER_SIGNER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x36, 0x2E, 0x38, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.4.1
        public static ReadOnlySpan<sbyte> szOID_YESNO_TRUST_ATTR => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x34, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.10.4.2
        public static ReadOnlySpan<sbyte> szOID_SITE_PIN_RULES_INDEX_ATTR => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x34, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.10.4.3
        public static ReadOnlySpan<sbyte> szOID_SITE_PIN_RULES_FLAGS_ATTR => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x34, 0x2E, 0x33, 0x00 };

        public const int SITE_PIN_RULES_ALL_SUBDOMAINS_FLAG = 0x1;

        // 1.3.6.1.5.5.7.2.1
        public static ReadOnlySpan<sbyte> szOID_PKIX_POLICY_QUALIFIER_CPS => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.5.5.7.2.2
        public static ReadOnlySpan<sbyte> szOID_PKIX_POLICY_QUALIFIER_USERNOTICE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.60.1.1
        public static ReadOnlySpan<sbyte> szOID_ROOT_PROGRAM_FLAGS => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        public const int CERT_ROOT_PROGRAM_FLAG_ORG = 0x80;

        public const int CERT_ROOT_PROGRAM_FLAG_LSC = 0x40;

        public const int CERT_ROOT_PROGRAM_FLAG_SUBJECT_LOGO = 0x20;

        public const int CERT_ROOT_PROGRAM_FLAG_OU = 0x10;

        public const int CERT_ROOT_PROGRAM_FLAG_ADDRESS = 0x08;

        // 2.16.840.1.113733.1.7.1.1
        public static ReadOnlySpan<sbyte> szOID_CERT_POLICIES_95_QUALIFIER1 => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 2.23.133.2.1
        public static ReadOnlySpan<sbyte> szOID_RDN_TPM_MANUFACTURER => new sbyte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        // 2.23.133.2.2
        public static ReadOnlySpan<sbyte> szOID_RDN_TPM_MODEL => new sbyte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        // 2.23.133.2.3
        public static ReadOnlySpan<sbyte> szOID_RDN_TPM_VERSION => new sbyte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        // 2.23.133.2.4
        public static ReadOnlySpan<sbyte> szOID_RDN_TCG_PLATFORM_MANUFACTURER => new sbyte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x34, 0x00 };

        // 2.23.133.2.5
        public static ReadOnlySpan<sbyte> szOID_RDN_TCG_PLATFORM_MODEL => new sbyte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x35, 0x00 };

        // 2.23.133.2.6
        public static ReadOnlySpan<sbyte> szOID_RDN_TCG_PLATFORM_VERSION => new sbyte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x36, 0x00 };

        // 1.3.6.1.4.1.11129.2.4.2
        public static ReadOnlySpan<sbyte> szOID_CT_CERT_SCTLIST => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x31, 0x32, 0x39, 0x2E, 0x32, 0x2E, 0x34, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.21.23
        public static ReadOnlySpan<sbyte> szOID_ENROLL_EK_INFO => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x33, 0x00 };

        // 1.3.6.1.4.1.311.21.39
        public static ReadOnlySpan<sbyte> szOID_ENROLL_AIK_INFO => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x39, 0x00 };

        // 1.3.6.1.4.1.311.21.24
        public static ReadOnlySpan<sbyte> szOID_ENROLL_ATTESTATION_STATEMENT => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.21.25
        public static ReadOnlySpan<sbyte> szOID_ENROLL_KSP_NAME => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x35, 0x00 };

        // 1.3.6.1.4.1.311.21.26
        public static ReadOnlySpan<sbyte> szOID_ENROLL_EKPUB_CHALLENGE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x36, 0x00 };

        // 1.3.6.1.4.1.311.21.27
        public static ReadOnlySpan<sbyte> szOID_ENROLL_CAXCHGCERT_HASH => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x37, 0x00 };

        // 1.3.6.1.4.1.311.21.28
        public static ReadOnlySpan<sbyte> szOID_ENROLL_ATTESTATION_CHALLENGE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x38, 0x00 };

        // 1.3.6.1.4.1.311.21.29
        public static ReadOnlySpan<sbyte> szOID_ENROLL_ENCRYPTION_ALGORITHM => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x39, 0x00 };

        // 2.23.133.8.1
        public static ReadOnlySpan<sbyte> szOID_KP_TPM_EK_CERTIFICATE => new sbyte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x38, 0x2E, 0x31, 0x00 };

        // 2.23.133.8.2
        public static ReadOnlySpan<sbyte> szOID_KP_TPM_PLATFORM_CERTIFICATE => new sbyte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x38, 0x2E, 0x32, 0x00 };

        // 2.23.133.8.3
        public static ReadOnlySpan<sbyte> szOID_KP_TPM_AIK_CERTIFICATE => new sbyte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x38, 0x2E, 0x33, 0x00 };

        // 1.3.6.1.4.1.311.21.30
        public static ReadOnlySpan<sbyte> szOID_ENROLL_EKVERIFYKEY => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x30, 0x00 };

        // 1.3.6.1.4.1.311.21.31
        public static ReadOnlySpan<sbyte> szOID_ENROLL_EKVERIFYCERT => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.21.32
        public static ReadOnlySpan<sbyte> szOID_ENROLL_EKVERIFYCREDS => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.21.33
        public static ReadOnlySpan<sbyte> szOID_ENROLL_SCEP_ERROR => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x33, 0x00 };

        // 1.3.6.1.4.1.311.21.34
        public static ReadOnlySpan<sbyte> szOID_ENROLL_SCEP_SERVER_STATE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.21.35
        public static ReadOnlySpan<sbyte> szOID_ENROLL_SCEP_CHALLENGE_ANSWER => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x35, 0x00 };

        // 1.3.6.1.4.1.311.21.37
        public static ReadOnlySpan<sbyte> szOID_ENROLL_SCEP_CLIENT_REQUEST => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x37, 0x00 };

        // 1.3.6.1.4.1.311.21.38
        public static ReadOnlySpan<sbyte> szOID_ENROLL_SCEP_SERVER_MESSAGE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x38, 0x00 };

        // 1.3.6.1.4.1.311.21.40
        public static ReadOnlySpan<sbyte> szOID_ENROLL_SCEP_SERVER_SECRET => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x34, 0x30, 0x00 };

        // 1.3.6.1.4.1.311.21.41
        public static ReadOnlySpan<sbyte> szOID_ENROLL_KEY_AFFINITY => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x34, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.21.42
        public static ReadOnlySpan<sbyte> szOID_ENROLL_SCEP_SIGNER_HASH => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x34, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.21.43
        public static ReadOnlySpan<sbyte> szOID_ENROLL_EK_CA_KEYID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x34, 0x33, 0x00 };

        // 2.5.4.52
        public static ReadOnlySpan<sbyte> szOID_ATTR_SUPPORTED_ALGORITHMS => new sbyte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x35, 0x32, 0x00 };

        // 2.23.133.2.16
        public static ReadOnlySpan<sbyte> szOID_ATTR_TPM_SPECIFICATION => new sbyte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x36, 0x00 };

        // 2.23.133.2.17
        public static ReadOnlySpan<sbyte> szOID_ATTR_PLATFORM_SPECIFICATION => new sbyte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x37, 0x00 };

        // 2.23.133.2.18
        public static ReadOnlySpan<sbyte> szOID_ATTR_TPM_SECURITY_ASSERTIONS => new sbyte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x38, 0x00 };

        public const int CERT_UNICODE_RDN_ERR_INDEX_MASK = 0x3FF;

        public const int CERT_UNICODE_RDN_ERR_INDEX_SHIFT = 22;

        public const int CERT_UNICODE_ATTR_ERR_INDEX_MASK = 0x003F;

        public const int CERT_UNICODE_ATTR_ERR_INDEX_SHIFT = 16;

        public const int CERT_UNICODE_VALUE_ERR_INDEX_MASK = 0x0000FFFF;

        public const int CERT_UNICODE_VALUE_ERR_INDEX_SHIFT = 0;

        public const int CERT_DIGITAL_SIGNATURE_KEY_USAGE = 0x80;

        public const int CERT_NON_REPUDIATION_KEY_USAGE = 0x40;

        public const int CERT_KEY_ENCIPHERMENT_KEY_USAGE = 0x20;

        public const int CERT_DATA_ENCIPHERMENT_KEY_USAGE = 0x10;

        public const int CERT_KEY_AGREEMENT_KEY_USAGE = 0x08;

        public const int CERT_KEY_CERT_SIGN_KEY_USAGE = 0x04;

        public const int CERT_OFFLINE_CRL_SIGN_KEY_USAGE = 0x02;

        public const int CERT_CRL_SIGN_KEY_USAGE = 0x02;

        public const int CERT_ENCIPHER_ONLY_KEY_USAGE = 0x01;

        public const int CERT_DECIPHER_ONLY_KEY_USAGE = 0x80;

        public const int CERT_ALT_NAME_OTHER_NAME = 1;

        public const int CERT_ALT_NAME_RFC822_NAME = 2;

        public const int CERT_ALT_NAME_DNS_NAME = 3;

        public const int CERT_ALT_NAME_X400_ADDRESS = 4;

        public const int CERT_ALT_NAME_DIRECTORY_NAME = 5;

        public const int CERT_ALT_NAME_EDI_PARTY_NAME = 6;

        public const int CERT_ALT_NAME_URL = 7;

        public const int CERT_ALT_NAME_IP_ADDRESS = 8;

        public const int CERT_ALT_NAME_REGISTERED_ID = 9;

        public const int CERT_ALT_NAME_ENTRY_ERR_INDEX_MASK = 0xFF;

        public const int CERT_ALT_NAME_ENTRY_ERR_INDEX_SHIFT = 16;

        public const int CERT_ALT_NAME_VALUE_ERR_INDEX_MASK = 0x0000FFFF;

        public const int CERT_ALT_NAME_VALUE_ERR_INDEX_SHIFT = 0;

        public const int CERT_CA_SUBJECT_FLAG = 0x80;

        public const int CERT_END_ENTITY_SUBJECT_FLAG = 0x40;

        // 1.3.6.1.5.5.7.48
        public static ReadOnlySpan<sbyte> szOID_PKIX_ACC_DESCR => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x00 };

        // 1.3.6.1.5.5.7.48.1
        public static ReadOnlySpan<sbyte> szOID_PKIX_OCSP => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.5.5.7.48.2
        public static ReadOnlySpan<sbyte> szOID_PKIX_CA_ISSUERS => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.5.5.7.48.3
        public static ReadOnlySpan<sbyte> szOID_PKIX_TIME_STAMPING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x2E, 0x33, 0x00 };

        // 1.3.6.1.5.5.7.48.5
        public static ReadOnlySpan<sbyte> szOID_PKIX_CA_REPOSITORY => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x2E, 0x35, 0x00 };

        public const int CRL_REASON_UNSPECIFIED = 0;

        public const int CRL_REASON_KEY_COMPROMISE = 1;

        public const int CRL_REASON_CA_COMPROMISE = 2;

        public const int CRL_REASON_AFFILIATION_CHANGED = 3;

        public const int CRL_REASON_SUPERSEDED = 4;

        public const int CRL_REASON_CESSATION_OF_OPERATION = 5;

        public const int CRL_REASON_CERTIFICATE_HOLD = 6;

        public const int CRL_REASON_REMOVE_FROM_CRL = 8;

        public const int CRL_REASON_PRIVILEGE_WITHDRAWN = 9;

        public const int CRL_REASON_AA_COMPROMISE = 10;

        public const int CRL_DIST_POINT_NO_NAME = 0;

        public const int CRL_DIST_POINT_FULL_NAME = 1;

        public const int CRL_DIST_POINT_ISSUER_RDN_NAME = 2;

        public const int CRL_REASON_UNUSED_FLAG = 0x80;

        public const int CRL_REASON_KEY_COMPROMISE_FLAG = 0x40;

        public const int CRL_REASON_CA_COMPROMISE_FLAG = 0x20;

        public const int CRL_REASON_AFFILIATION_CHANGED_FLAG = 0x10;

        public const int CRL_REASON_SUPERSEDED_FLAG = 0x08;

        public const int CRL_REASON_CESSATION_OF_OPERATION_FLAG = 0x04;

        public const int CRL_REASON_CERTIFICATE_HOLD_FLAG = 0x02;

        public const int CRL_REASON_PRIVILEGE_WITHDRAWN_FLAG = 0x01;

        public const int CRL_REASON_AA_COMPROMISE_FLAG = 0x80;

        public const int CRL_DIST_POINT_ERR_INDEX_MASK = 0x7F;

        public const int CRL_DIST_POINT_ERR_INDEX_SHIFT = 24;

        public const int CRL_DIST_POINT_ERR_CRL_ISSUER_BIT = unchecked((int)0x80000000);

        public const int CROSS_CERT_DIST_POINT_ERR_INDEX_MASK = 0xFF;

        public const int CROSS_CERT_DIST_POINT_ERR_INDEX_SHIFT = 24;

        public const int CERT_EXCLUDED_SUBTREE_BIT = unchecked((int)0x80000000);

        public const int SORTED_CTL_EXT_HASHED_SUBJECT_IDENTIFIER_FLAG = 0x1;

        public const int CERT_DSS_R_LEN = 20;

        public const int CERT_DSS_S_LEN = 20;

        public const int CRYPT_X942_COUNTER_BYTE_LENGTH = 4;

        public const int CRYPT_X942_KEY_LENGTH_BYTE_LENGTH = 4;

        public const int CRYPT_ECC_CMS_SHARED_INFO_SUPPPUBINFO_BYTE_LENGTH = 4;

        public const int CRYPT_RC2_40BIT_VERSION = 160;

        public const int CRYPT_RC2_56BIT_VERSION = 52;

        public const int CRYPT_RC2_64BIT_VERSION = 120;

        public const int CRYPT_RC2_128BIT_VERSION = 58;

        // 0.4.0.1862.1.1
        public static ReadOnlySpan<sbyte> szOID_QC_EU_COMPLIANCE => new sbyte[] { 0x30, 0x2E, 0x34, 0x2E, 0x30, 0x2E, 0x31, 0x38, 0x36, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 0.4.0.1862.1.4
        public static ReadOnlySpan<sbyte> szOID_QC_SSCD => new sbyte[] { 0x30, 0x2E, 0x34, 0x2E, 0x30, 0x2E, 0x31, 0x38, 0x36, 0x32, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        public const int PKCS_RSA_SSA_PSS_TRAILER_FIELD_BC = 1;

        // 2.16.840.1.113733.1.6.9
        public static ReadOnlySpan<sbyte> szOID_VERISIGN_PRIVATE_6_9 => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x36, 0x2E, 0x39, 0x00 };

        // 2.16.840.1.113733.1.6.11
        public static ReadOnlySpan<sbyte> szOID_VERISIGN_ONSITE_JURISDICTION_HASH => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x36, 0x2E, 0x31, 0x31, 0x00 };

        // 2.16.840.1.113733.1.6.13
        public static ReadOnlySpan<sbyte> szOID_VERISIGN_BITSTRING_6_13 => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x36, 0x2E, 0x31, 0x33, 0x00 };

        // 2.16.840.1.113733.1.8.1
        public static ReadOnlySpan<sbyte> szOID_VERISIGN_ISS_STRONG_CRYPTO => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x38, 0x2E, 0x31, 0x00 };

        // 2.16.840.1.113733.1.9.2
        public static ReadOnlySpan<sbyte> szOIDVerisign_MessageType => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x32, 0x00 };

        // 2.16.840.1.113733.1.9.3
        public static ReadOnlySpan<sbyte> szOIDVerisign_PkiStatus => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x33, 0x00 };

        // 2.16.840.1.113733.1.9.4
        public static ReadOnlySpan<sbyte> szOIDVerisign_FailInfo => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x34, 0x00 };

        // 2.16.840.1.113733.1.9.5
        public static ReadOnlySpan<sbyte> szOIDVerisign_SenderNonce => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x35, 0x00 };

        // 2.16.840.1.113733.1.9.6
        public static ReadOnlySpan<sbyte> szOIDVerisign_RecipientNonce => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x36, 0x00 };

        // 2.16.840.1.113733.1.9.7
        public static ReadOnlySpan<sbyte> szOIDVerisign_TransactionID => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x37, 0x00 };

        // 2.16.840.1.113730
        public static ReadOnlySpan<sbyte> szOID_NETSCAPE => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x00 };

        // 2.16.840.1.113730.1
        public static ReadOnlySpan<sbyte> szOID_NETSCAPE_CERT_EXTENSION => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x00 };

        // 2.16.840.1.113730.1.1
        public static ReadOnlySpan<sbyte> szOID_NETSCAPE_CERT_TYPE => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 2.16.840.1.113730.1.2
        public static ReadOnlySpan<sbyte> szOID_NETSCAPE_BASE_URL => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        // 2.16.840.1.113730.1.3
        public static ReadOnlySpan<sbyte> szOID_NETSCAPE_REVOCATION_URL => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        // 2.16.840.1.113730.1.4
        public static ReadOnlySpan<sbyte> szOID_NETSCAPE_CA_REVOCATION_URL => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        // 2.16.840.1.113730.1.7
        public static ReadOnlySpan<sbyte> szOID_NETSCAPE_CERT_RENEWAL_URL => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x37, 0x00 };

        // 2.16.840.1.113730.1.8
        public static ReadOnlySpan<sbyte> szOID_NETSCAPE_CA_POLICY_URL => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x38, 0x00 };

        // 2.16.840.1.113730.1.12
        public static ReadOnlySpan<sbyte> szOID_NETSCAPE_SSL_SERVER_NAME => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        // 2.16.840.1.113730.1.13
        public static ReadOnlySpan<sbyte> szOID_NETSCAPE_COMMENT => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x33, 0x00 };

        // 2.16.840.1.113730.2
        public static ReadOnlySpan<sbyte> szOID_NETSCAPE_DATA_TYPE => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x32, 0x00 };

        // 2.16.840.1.113730.2.5
        public static ReadOnlySpan<sbyte> szOID_NETSCAPE_CERT_SEQUENCE => new sbyte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x32, 0x2E, 0x35, 0x00 };

        public const int NETSCAPE_SSL_CLIENT_AUTH_CERT_TYPE = 0x80;

        public const int NETSCAPE_SSL_SERVER_AUTH_CERT_TYPE = 0x40;

        public const int NETSCAPE_SMIME_CERT_TYPE = 0x20;

        public const int NETSCAPE_SIGN_CERT_TYPE = 0x10;

        public const int NETSCAPE_SSL_CA_CERT_TYPE = 0x04;

        public const int NETSCAPE_SMIME_CA_CERT_TYPE = 0x02;

        public const int NETSCAPE_SIGN_CA_CERT_TYPE = 0x01;

        // 1.3.6.1.5.5.7.12.2
        public static ReadOnlySpan<sbyte> szOID_CT_PKI_DATA => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x32, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.5.5.7.12.3
        public static ReadOnlySpan<sbyte> szOID_CT_PKI_RESPONSE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x32, 0x2E, 0x33, 0x00 };

        // 1.3.6.1.5.5.7.6.2
        public static ReadOnlySpan<sbyte> szOID_PKIX_NO_SIGNATURE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x36, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.5.5.7.7
        public static ReadOnlySpan<sbyte> szOID_CMC => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x00 };

        // 1.3.6.1.5.5.7.7.1
        public static ReadOnlySpan<sbyte> szOID_CMC_STATUS_INFO => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.5.5.7.7.2
        public static ReadOnlySpan<sbyte> szOID_CMC_IDENTIFICATION => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.5.5.7.7.3
        public static ReadOnlySpan<sbyte> szOID_CMC_IDENTITY_PROOF => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x33, 0x00 };

        // 1.3.6.1.5.5.7.7.4
        public static ReadOnlySpan<sbyte> szOID_CMC_DATA_RETURN => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x34, 0x00 };

        // 1.3.6.1.5.5.7.7.5
        public static ReadOnlySpan<sbyte> szOID_CMC_TRANSACTION_ID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x35, 0x00 };

        // 1.3.6.1.5.5.7.7.6
        public static ReadOnlySpan<sbyte> szOID_CMC_SENDER_NONCE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x36, 0x00 };

        // 1.3.6.1.5.5.7.7.7
        public static ReadOnlySpan<sbyte> szOID_CMC_RECIPIENT_NONCE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x37, 0x00 };

        // 1.3.6.1.5.5.7.7.8
        public static ReadOnlySpan<sbyte> szOID_CMC_ADD_EXTENSIONS => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x38, 0x00 };

        // 1.3.6.1.5.5.7.7.9
        public static ReadOnlySpan<sbyte> szOID_CMC_ENCRYPTED_POP => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x39, 0x00 };

        // 1.3.6.1.5.5.7.7.10
        public static ReadOnlySpan<sbyte> szOID_CMC_DECRYPTED_POP => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x30, 0x00 };

        // 1.3.6.1.5.5.7.7.11
        public static ReadOnlySpan<sbyte> szOID_CMC_LRA_POP_WITNESS => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x31, 0x00 };

        // 1.3.6.1.5.5.7.7.15
        public static ReadOnlySpan<sbyte> szOID_CMC_GET_CERT => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x35, 0x00 };

        // 1.3.6.1.5.5.7.7.16
        public static ReadOnlySpan<sbyte> szOID_CMC_GET_CRL => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x36, 0x00 };

        // 1.3.6.1.5.5.7.7.17
        public static ReadOnlySpan<sbyte> szOID_CMC_REVOKE_REQUEST => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x37, 0x00 };

        // 1.3.6.1.5.5.7.7.18
        public static ReadOnlySpan<sbyte> szOID_CMC_REG_INFO => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x38, 0x00 };

        // 1.3.6.1.5.5.7.7.19
        public static ReadOnlySpan<sbyte> szOID_CMC_RESPONSE_INFO => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x39, 0x00 };

        // 1.3.6.1.5.5.7.7.21
        public static ReadOnlySpan<sbyte> szOID_CMC_QUERY_PENDING => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x32, 0x31, 0x00 };

        // 1.3.6.1.5.5.7.7.22
        public static ReadOnlySpan<sbyte> szOID_CMC_ID_POP_LINK_RANDOM => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x32, 0x32, 0x00 };

        // 1.3.6.1.5.5.7.7.23
        public static ReadOnlySpan<sbyte> szOID_CMC_ID_POP_LINK_WITNESS => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x32, 0x33, 0x00 };

        // 1.3.6.1.5.5.7.7.24
        public static ReadOnlySpan<sbyte> szOID_CMC_ID_CONFIRM_CERT_ACCEPTANCE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x32, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.10.10.1
        public static ReadOnlySpan<sbyte> szOID_CMC_ADD_ATTRIBUTES => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x00 };

        public const int CMC_TAGGED_CERT_REQUEST_CHOICE = 1;

        public const int CMC_OTHER_INFO_NO_CHOICE = 0;

        public const int CMC_OTHER_INFO_FAIL_CHOICE = 1;

        public const int CMC_OTHER_INFO_PEND_CHOICE = 2;

        public const int CMC_STATUS_SUCCESS = 0;

        public const int CMC_STATUS_FAILED = 2;

        public const int CMC_STATUS_PENDING = 3;

        public const int CMC_STATUS_NO_SUPPORT = 4;

        public const int CMC_STATUS_CONFIRM_REQUIRED = 5;

        public const int CMC_FAIL_BAD_ALG = 0;

        public const int CMC_FAIL_BAD_MESSAGE_CHECK = 1;

        public const int CMC_FAIL_BAD_REQUEST = 2;

        public const int CMC_FAIL_BAD_TIME = 3;

        public const int CMC_FAIL_BAD_CERT_ID = 4;

        public const int CMC_FAIL_UNSUPORTED_EXT = 5;

        public const int CMC_FAIL_MUST_ARCHIVE_KEYS = 6;

        public const int CMC_FAIL_BAD_IDENTITY = 7;

        public const int CMC_FAIL_POP_REQUIRED = 8;

        public const int CMC_FAIL_POP_FAILED = 9;

        public const int CMC_FAIL_NO_KEY_REUSE = 10;

        public const int CMC_FAIL_INTERNAL_CA_ERROR = 11;

        public const int CMC_FAIL_TRY_LATER = 12;

        public const int CERT_LOGOTYPE_GRAY_SCALE_IMAGE_INFO_CHOICE = 1;

        public const int CERT_LOGOTYPE_COLOR_IMAGE_INFO_CHOICE = 2;

        public const int CERT_LOGOTYPE_NO_IMAGE_RESOLUTION_CHOICE = 0;

        public const int CERT_LOGOTYPE_BITS_IMAGE_RESOLUTION_CHOICE = 1;

        public const int CERT_LOGOTYPE_TABLE_SIZE_IMAGE_RESOLUTION_CHOICE = 2;

        public const int CERT_LOGOTYPE_DIRECT_INFO_CHOICE = 1;

        public const int CERT_LOGOTYPE_INDIRECT_INFO_CHOICE = 2;

        // 1.3.6.1.5.5.7.20.1
        public static ReadOnlySpan<sbyte> szOID_LOYALTY_OTHER_LOGOTYPE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x32, 0x30, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.5.5.7.20.2
        public static ReadOnlySpan<sbyte> szOID_BACKGROUND_OTHER_LOGOTYPE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x32, 0x30, 0x2E, 0x32, 0x00 };

        public const int CERT_BIOMETRIC_PREDEFINED_DATA_CHOICE = 1;

        public const int CERT_BIOMETRIC_OID_DATA_CHOICE = 2;

        public const int CERT_BIOMETRIC_PICTURE_TYPE = 0;

        public const int CERT_BIOMETRIC_SIGNATURE_TYPE = 1;

        public const int OCSP_REQUEST_V1 = 0;

        public const int OCSP_SUCCESSFUL_RESPONSE = 0;

        public const int OCSP_MALFORMED_REQUEST_RESPONSE = 1;

        public const int OCSP_INTERNAL_ERROR_RESPONSE = 2;

        public const int OCSP_TRY_LATER_RESPONSE = 3;

        public const int OCSP_SIG_REQUIRED_RESPONSE = 5;

        public const int OCSP_UNAUTHORIZED_RESPONSE = 6;

        // 1.3.6.1.5.5.7.48.1.1
        public static ReadOnlySpan<sbyte> szOID_PKIX_OCSP_BASIC_SIGNED_RESPONSE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        public const int OCSP_BASIC_GOOD_CERT_STATUS = 0;

        public const int OCSP_BASIC_REVOKED_CERT_STATUS = 1;

        public const int OCSP_BASIC_UNKNOWN_CERT_STATUS = 2;

        public const int OCSP_BASIC_RESPONSE_V1 = 0;

        public const int OCSP_BASIC_BY_NAME_RESPONDER_ID = 1;

        public const int OCSP_BASIC_BY_KEY_RESPONDER_ID = 2;

        // CryptDllEncodeObject
        public static ReadOnlySpan<sbyte> CRYPT_OID_ENCODE_OBJECT_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        // CryptDllDecodeObject
        public static ReadOnlySpan<sbyte> CRYPT_OID_DECODE_OBJECT_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x44, 0x65, 0x63, 0x6F, 0x64, 0x65, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        // CryptDllEncodeObjectEx
        public static ReadOnlySpan<sbyte> CRYPT_OID_ENCODE_OBJECT_EX_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x45, 0x78, 0x00 };

        // CryptDllDecodeObjectEx
        public static ReadOnlySpan<sbyte> CRYPT_OID_DECODE_OBJECT_EX_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x44, 0x65, 0x63, 0x6F, 0x64, 0x65, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x45, 0x78, 0x00 };

        // CryptDllCreateCOMObject
        public static ReadOnlySpan<sbyte> CRYPT_OID_CREATE_COM_OBJECT_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x43, 0x72, 0x65, 0x61, 0x74, 0x65, 0x43, 0x4F, 0x4D, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        // CertDllVerifyRevocation
        public static ReadOnlySpan<sbyte> CRYPT_OID_VERIFY_REVOCATION_FUNC => new sbyte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x56, 0x65, 0x72, 0x69, 0x66, 0x79, 0x52, 0x65, 0x76, 0x6F, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        // CertDllVerifyCTLUsage
        public static ReadOnlySpan<sbyte> CRYPT_OID_VERIFY_CTL_USAGE_FUNC => new sbyte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x56, 0x65, 0x72, 0x69, 0x66, 0x79, 0x43, 0x54, 0x4C, 0x55, 0x73, 0x61, 0x67, 0x65, 0x00 };

        // CryptDllFormatObject
        public static ReadOnlySpan<sbyte> CRYPT_OID_FORMAT_OBJECT_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x46, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        // CryptDllFindOIDInfo
        public static ReadOnlySpan<sbyte> CRYPT_OID_FIND_OID_INFO_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x46, 0x69, 0x6E, 0x64, 0x4F, 0x49, 0x44, 0x49, 0x6E, 0x66, 0x6F, 0x00 };

        // CryptDllFindLocalizedName
        public static ReadOnlySpan<sbyte> CRYPT_OID_FIND_LOCALIZED_NAME_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x46, 0x69, 0x6E, 0x64, 0x4C, 0x6F, 0x63, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x64, 0x4E, 0x61, 0x6D, 0x65, 0x00 };

        // Software\Microsoft\Cryptography\OID
        public static ReadOnlySpan<sbyte> CRYPT_OID_REGPATH => new sbyte[] { 0x53, 0x6F, 0x66, 0x74, 0x77, 0x61, 0x72, 0x65, 0x5C, 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x5C, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x79, 0x5C, 0x4F, 0x49, 0x44, 0x00 };

        // EncodingType 
        public static ReadOnlySpan<sbyte> CRYPT_OID_REG_ENCODING_TYPE_PREFIX => new sbyte[] { 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x69, 0x6E, 0x67, 0x54, 0x79, 0x70, 0x65, 0x20, 0x00 };

        public const string CRYPT_OID_REG_DLL_VALUE_NAME = "Dll";

        public const string CRYPT_OID_REG_FUNC_NAME_VALUE_NAME = "FuncName";

        // FuncName
        public static ReadOnlySpan<sbyte> CRYPT_OID_REG_FUNC_NAME_VALUE_NAME_A => new sbyte[] { 0x46, 0x75, 0x6E, 0x63, 0x4E, 0x61, 0x6D, 0x65, 0x00 };

        public const string CRYPT_OID_REG_FLAGS_VALUE_NAME = "CryptFlags";

        // DEFAULT
        public static ReadOnlySpan<sbyte> CRYPT_DEFAULT_OID => new sbyte[] { 0x44, 0x45, 0x46, 0x41, 0x55, 0x4C, 0x54, 0x00 };

        public const int CRYPT_INSTALL_OID_FUNC_BEFORE_FLAG = 1;

        public const int CRYPT_GET_INSTALLED_OID_FUNC_FLAG = 0x1;

        public const int CRYPT_REGISTER_FIRST_INDEX = 0;

        public const uint CRYPT_REGISTER_LAST_INDEX = 0xFFFFFFFF;

        public const uint CRYPT_MATCH_ANY_ENCODING_TYPE = 0xFFFFFFFF;

        public const uint CALG_OID_INFO_CNG_ONLY = 0xFFFFFFFF;

        public const uint CALG_OID_INFO_PARAMETERS = 0xFFFFFFFE;

        public const string CRYPT_OID_INFO_HASH_PARAMETERS_ALGORITHM = "CryptOIDInfoHashParameters";

        public const string CRYPT_OID_INFO_ECC_PARAMETERS_ALGORITHM = "CryptOIDInfoECCParameters";

        public const string CRYPT_OID_INFO_MGF1_PARAMETERS_ALGORITHM = "CryptOIDInfoMgf1Parameters";

        public const string CRYPT_OID_INFO_NO_SIGN_ALGORITHM = "CryptOIDInfoNoSign";

        public const string CRYPT_OID_INFO_OAEP_PARAMETERS_ALGORITHM = "CryptOIDInfoOAEPParameters";

        public const string CRYPT_OID_INFO_ECC_WRAP_PARAMETERS_ALGORITHM = "CryptOIDInfoECCWrapParameters";

        public const string CRYPT_OID_INFO_NO_PARAMETERS_ALGORITHM = "CryptOIDInfoNoParameters";

        public const int CRYPT_HASH_ALG_OID_GROUP_ID = 1;

        public const int CRYPT_ENCRYPT_ALG_OID_GROUP_ID = 2;

        public const int CRYPT_PUBKEY_ALG_OID_GROUP_ID = 3;

        public const int CRYPT_SIGN_ALG_OID_GROUP_ID = 4;

        public const int CRYPT_RDN_ATTR_OID_GROUP_ID = 5;

        public const int CRYPT_EXT_OR_ATTR_OID_GROUP_ID = 6;

        public const int CRYPT_ENHKEY_USAGE_OID_GROUP_ID = 7;

        public const int CRYPT_POLICY_OID_GROUP_ID = 8;

        public const int CRYPT_TEMPLATE_OID_GROUP_ID = 9;

        public const int CRYPT_KDF_OID_GROUP_ID = 10;

        public const int CRYPT_LAST_OID_GROUP_ID = 10;

        public const int CRYPT_OID_INHIBIT_SIGNATURE_FORMAT_FLAG = 0x00000001;

        public const int CRYPT_OID_USE_PUBKEY_PARA_FOR_PKCS7_FLAG = 0x00000002;

        public const int CRYPT_OID_NO_NULL_ALGORITHM_PARA_FLAG = 0x00000004;

        public const uint CRYPT_OID_PUBKEY_SIGN_ONLY_FLAG = 0x80000000;

        public const int CRYPT_OID_PUBKEY_ENCRYPT_ONLY_FLAG = 0x40000000;

        public const int CRYPT_OID_USE_CURVE_NAME_FOR_ENCODE_FLAG = 0x20000000;

        public const int CRYPT_OID_USE_CURVE_PARAMETERS_FOR_ENCODE_FLAG = 0x10000000;

        public const int CRYPT_OID_INFO_OID_KEY = 1;

        public const int CRYPT_OID_INFO_NAME_KEY = 2;

        public const int CRYPT_OID_INFO_ALGID_KEY = 3;

        public const int CRYPT_OID_INFO_SIGN_KEY = 4;

        public const int CRYPT_OID_INFO_CNG_ALGID_KEY = 5;

        public const int CRYPT_OID_INFO_CNG_SIGN_KEY = 6;

        public const uint CRYPT_OID_INFO_OID_KEY_FLAGS_MASK = 0xFFFF0000;

        public const uint CRYPT_OID_INFO_PUBKEY_SIGN_KEY_FLAG = 0x80000000;

        public const int CRYPT_OID_INFO_PUBKEY_ENCRYPT_KEY_FLAG = 0x40000000;

        public const uint CRYPT_OID_DISABLE_SEARCH_DS_FLAG = 0x80000000;

        public const int CRYPT_OID_PREFER_CNG_ALGID_FLAG = 0x40000000;

        public const int CRYPT_OID_INFO_OID_GROUP_BIT_LEN_MASK = 0x0FFF0000;

        public const int CRYPT_OID_INFO_OID_GROUP_BIT_LEN_SHIFT = 16;

        public const int CRYPT_INSTALL_OID_INFO_BEFORE_FLAG = 1;

        public const int CRYPT_LOCALIZED_NAME_ENCODING_TYPE = 0;

        // LocalizedNames
        public static ReadOnlySpan<sbyte> CRYPT_LOCALIZED_NAME_OID => new sbyte[] { 0x4C, 0x6F, 0x63, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x64, 0x4E, 0x61, 0x6D, 0x65, 0x73, 0x00 };

        public const string CERT_STRONG_SIGN_ECDSA_ALGORITHM = "ECDSA";

        public const int CERT_STRONG_SIGN_SERIALIZED_INFO_CHOICE = 1;

        public const int CERT_STRONG_SIGN_OID_INFO_CHOICE = 2;

        public const int CERT_STRONG_SIGN_ENABLE_CRL_CHECK = 0x1;

        public const int CERT_STRONG_SIGN_ENABLE_OCSP_CHECK = 0x2;

        // 1.3.6.1.4.1.311.72.1.
        public static ReadOnlySpan<sbyte> szOID_CERT_STRONG_SIGN_OS_PREFIX => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x32, 0x2E, 0x31, 0x2E, 0x00 };

        // 1.3.6.1.4.1.311.72.1.1
        public static ReadOnlySpan<sbyte> szOID_CERT_STRONG_SIGN_OS_1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.72.2.
        public static ReadOnlySpan<sbyte> szOID_CERT_STRONG_KEY_OS_PREFIX => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x32, 0x2E, 0x32, 0x2E, 0x00 };

        // 1.3.6.1.4.1.311.72.2.1
        public static ReadOnlySpan<sbyte> szOID_CERT_STRONG_KEY_OS_1 => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x32, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        // 1.2.840.113549.1.7.1
        public static ReadOnlySpan<sbyte> szOID_PKCS_7_DATA => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x31, 0x00 };

        // 1.2.840.113549.1.7.2
        public static ReadOnlySpan<sbyte> szOID_PKCS_7_SIGNED => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x32, 0x00 };

        // 1.2.840.113549.1.7.3
        public static ReadOnlySpan<sbyte> szOID_PKCS_7_ENVELOPED => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x33, 0x00 };

        // 1.2.840.113549.1.7.4
        public static ReadOnlySpan<sbyte> szOID_PKCS_7_SIGNEDANDENVELOPED => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x34, 0x00 };

        // 1.2.840.113549.1.7.5
        public static ReadOnlySpan<sbyte> szOID_PKCS_7_DIGESTED => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x35, 0x00 };

        // 1.2.840.113549.1.7.6
        public static ReadOnlySpan<sbyte> szOID_PKCS_7_ENCRYPTED => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x36, 0x00 };

        // 1.2.840.113549.1.9.3
        public static ReadOnlySpan<sbyte> szOID_PKCS_9_CONTENT_TYPE => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x33, 0x00 };

        // 1.2.840.113549.1.9.4
        public static ReadOnlySpan<sbyte> szOID_PKCS_9_MESSAGE_DIGEST => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x34, 0x00 };

        public const int CMSG_DATA = 1;

        public const int CMSG_SIGNED = 2;

        public const int CMSG_ENVELOPED = 3;

        public const int CMSG_SIGNED_AND_ENVELOPED = 4;

        public const int CMSG_HASHED = 5;

        public const int CMSG_ENCRYPTED = 6;

        public const int CERT_ID_ISSUER_SERIAL_NUMBER = 1;

        public const int CERT_ID_KEY_IDENTIFIER = 2;

        public const int CERT_ID_SHA1_HASH = 3;

        public const int CMSG_KEY_AGREE_EPHEMERAL_KEY_CHOICE = 1;

        public const int CMSG_KEY_AGREE_STATIC_KEY_CHOICE = 2;

        public const int CMSG_MAIL_LIST_HANDLE_KEY_CHOICE = 1;

        public const int CMSG_KEY_TRANS_RECIPIENT = 1;

        public const int CMSG_KEY_AGREE_RECIPIENT = 2;

        public const int CMSG_MAIL_LIST_RECIPIENT = 3;

        public const uint CMSG_SP3_COMPATIBLE_ENCRYPT_FLAG = 0x80000000;

        public const int CMSG_RC4_NO_SALT_FLAG = 0x40000000;

        public const int CMSG_BARE_CONTENT_FLAG = 0x00000001;

        public const int CMSG_LENGTH_ONLY_FLAG = 0x00000002;

        public const int CMSG_DETACHED_FLAG = 0x00000004;

        public const int CMSG_AUTHENTICATED_ATTRIBUTES_FLAG = 0x00000008;

        public const int CMSG_CONTENTS_OCTETS_FLAG = 0x00000010;

        public const int CMSG_MAX_LENGTH_FLAG = 0x00000020;

        public const int CMSG_CMS_ENCAPSULATED_CONTENT_FLAG = 0x00000040;

        public const int CMSG_SIGNED_DATA_NO_SIGN_FLAG = 0x00000080;

        public const int CMSG_CRYPT_RELEASE_CONTEXT_FLAG = 0x00008000;

        public const int CMSG_TYPE_PARAM = 1;

        public const int CMSG_CONTENT_PARAM = 2;

        public const int CMSG_BARE_CONTENT_PARAM = 3;

        public const int CMSG_INNER_CONTENT_TYPE_PARAM = 4;

        public const int CMSG_SIGNER_COUNT_PARAM = 5;

        public const int CMSG_SIGNER_INFO_PARAM = 6;

        public const int CMSG_SIGNER_CERT_INFO_PARAM = 7;

        public const int CMSG_SIGNER_HASH_ALGORITHM_PARAM = 8;

        public const int CMSG_SIGNER_AUTH_ATTR_PARAM = 9;

        public const int CMSG_SIGNER_UNAUTH_ATTR_PARAM = 10;

        public const int CMSG_CERT_COUNT_PARAM = 11;

        public const int CMSG_CERT_PARAM = 12;

        public const int CMSG_CRL_COUNT_PARAM = 13;

        public const int CMSG_CRL_PARAM = 14;

        public const int CMSG_ENVELOPE_ALGORITHM_PARAM = 15;

        public const int CMSG_RECIPIENT_COUNT_PARAM = 17;

        public const int CMSG_RECIPIENT_INDEX_PARAM = 18;

        public const int CMSG_RECIPIENT_INFO_PARAM = 19;

        public const int CMSG_HASH_ALGORITHM_PARAM = 20;

        public const int CMSG_HASH_DATA_PARAM = 21;

        public const int CMSG_COMPUTED_HASH_PARAM = 22;

        public const int CMSG_ENCRYPT_PARAM = 26;

        public const int CMSG_ENCRYPTED_DIGEST = 27;

        public const int CMSG_ENCODED_SIGNER = 28;

        public const int CMSG_ENCODED_MESSAGE = 29;

        public const int CMSG_VERSION_PARAM = 30;

        public const int CMSG_ATTR_CERT_COUNT_PARAM = 31;

        public const int CMSG_ATTR_CERT_PARAM = 32;

        public const int CMSG_CMS_RECIPIENT_COUNT_PARAM = 33;

        public const int CMSG_CMS_RECIPIENT_INDEX_PARAM = 34;

        public const int CMSG_CMS_RECIPIENT_ENCRYPTED_KEY_INDEX_PARAM = 35;

        public const int CMSG_CMS_RECIPIENT_INFO_PARAM = 36;

        public const int CMSG_UNPROTECTED_ATTR_PARAM = 37;

        public const int CMSG_SIGNER_CERT_ID_PARAM = 38;

        public const int CMSG_CMS_SIGNER_INFO_PARAM = 39;

        public const int CMSG_SIGNED_DATA_V1 = 1;

        public const int CMSG_SIGNED_DATA_V3 = 3;

        public const int CMSG_SIGNER_INFO_V1 = 1;

        public const int CMSG_SIGNER_INFO_V3 = 3;

        public const int CMSG_HASHED_DATA_V0 = 0;

        public const int CMSG_HASHED_DATA_V2 = 2;

        public const int CMSG_ENVELOPED_DATA_V0 = 0;

        public const int CMSG_ENVELOPED_DATA_V2 = 2;

        public const int CMSG_KEY_AGREE_ORIGINATOR_CERT = 1;

        public const int CMSG_KEY_AGREE_ORIGINATOR_PUBLIC_KEY = 2;

        public const int CMSG_ENVELOPED_RECIPIENT_V0 = 0;

        public const int CMSG_ENVELOPED_RECIPIENT_V2 = 2;

        public const int CMSG_ENVELOPED_RECIPIENT_V3 = 3;

        public const int CMSG_ENVELOPED_RECIPIENT_V4 = 4;

        public const int CMSG_CTRL_VERIFY_SIGNATURE = 1;

        public const int CMSG_CTRL_DECRYPT = 2;

        public const int CMSG_CTRL_VERIFY_HASH = 5;

        public const int CMSG_CTRL_ADD_SIGNER = 6;

        public const int CMSG_CTRL_DEL_SIGNER = 7;

        public const int CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR = 8;

        public const int CMSG_CTRL_DEL_SIGNER_UNAUTH_ATTR = 9;

        public const int CMSG_CTRL_ADD_CERT = 10;

        public const int CMSG_CTRL_DEL_CERT = 11;

        public const int CMSG_CTRL_ADD_CRL = 12;

        public const int CMSG_CTRL_DEL_CRL = 13;

        public const int CMSG_CTRL_ADD_ATTR_CERT = 14;

        public const int CMSG_CTRL_DEL_ATTR_CERT = 15;

        public const int CMSG_CTRL_KEY_TRANS_DECRYPT = 16;

        public const int CMSG_CTRL_KEY_AGREE_DECRYPT = 17;

        public const int CMSG_CTRL_MAIL_LIST_DECRYPT = 18;

        public const int CMSG_CTRL_VERIFY_SIGNATURE_EX = 19;

        public const int CMSG_CTRL_ADD_CMS_SIGNER_INFO = 20;

        public const int CMSG_CTRL_ENABLE_STRONG_SIGNATURE = 21;

        public const int CMSG_VERIFY_SIGNER_PUBKEY = 1;

        public const int CMSG_VERIFY_SIGNER_CERT = 2;

        public const int CMSG_VERIFY_SIGNER_CHAIN = 3;

        public const int CMSG_VERIFY_SIGNER_NULL = 4;

        public const int CMSG_VERIFY_COUNTER_SIGN_ENABLE_STRONG_FLAG = 0x00000001;

        // CryptMsgDllGenEncryptKey
        public static ReadOnlySpan<sbyte> CMSG_OID_GEN_ENCRYPT_KEY_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x47, 0x65, 0x6E, 0x45, 0x6E, 0x63, 0x72, 0x79, 0x70, 0x74, 0x4B, 0x65, 0x79, 0x00 };

        // CryptMsgDllExportEncryptKey
        public static ReadOnlySpan<sbyte> CMSG_OID_EXPORT_ENCRYPT_KEY_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x45, 0x6E, 0x63, 0x72, 0x79, 0x70, 0x74, 0x4B, 0x65, 0x79, 0x00 };

        // CryptMsgDllImportEncryptKey
        public static ReadOnlySpan<sbyte> CMSG_OID_IMPORT_ENCRYPT_KEY_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x45, 0x6E, 0x63, 0x72, 0x79, 0x70, 0x74, 0x4B, 0x65, 0x79, 0x00 };

        public const int CMSG_CONTENT_ENCRYPT_PAD_ENCODED_LEN_FLAG = 0x00000001;

        public const int CMSG_CONTENT_ENCRYPT_FREE_PARA_FLAG = 0x00000001;

        public const int CMSG_CONTENT_ENCRYPT_FREE_OBJID_FLAG = 0x00000002;

        public const int CMSG_CONTENT_ENCRYPT_RELEASE_CONTEXT_FLAG = 0x00008000;

        // CryptMsgDllGenContentEncryptKey
        public static ReadOnlySpan<sbyte> CMSG_OID_GEN_CONTENT_ENCRYPT_KEY_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x47, 0x65, 0x6E, 0x43, 0x6F, 0x6E, 0x74, 0x65, 0x6E, 0x74, 0x45, 0x6E, 0x63, 0x72, 0x79, 0x70, 0x74, 0x4B, 0x65, 0x79, 0x00 };

        // CryptMsgDllCNGGenContentEncryptKey
        public static ReadOnlySpan<sbyte> CMSG_OID_CNG_GEN_CONTENT_ENCRYPT_KEY_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x43, 0x4E, 0x47, 0x47, 0x65, 0x6E, 0x43, 0x6F, 0x6E, 0x74, 0x65, 0x6E, 0x74, 0x45, 0x6E, 0x63, 0x72, 0x79, 0x70, 0x74, 0x4B, 0x65, 0x79, 0x00 };

        public const int CMSG_KEY_TRANS_ENCRYPT_FREE_PARA_FLAG = 0x00000001;

        public const int CMSG_KEY_TRANS_ENCRYPT_FREE_OBJID_FLAG = 0x00000002;

        // CryptMsgDllExportKeyTrans
        public static ReadOnlySpan<sbyte> CMSG_OID_EXPORT_KEY_TRANS_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x54, 0x72, 0x61, 0x6E, 0x73, 0x00 };

        // CryptMsgDllCNGExportKeyTrans
        public static ReadOnlySpan<sbyte> CMSG_OID_CNG_EXPORT_KEY_TRANS_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x43, 0x4E, 0x47, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x54, 0x72, 0x61, 0x6E, 0x73, 0x00 };

        public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PARA_FLAG = 0x00000001;

        public const int CMSG_KEY_AGREE_ENCRYPT_FREE_MATERIAL_FLAG = 0x00000002;

        public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_ALG_FLAG = 0x00000004;

        public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_PARA_FLAG = 0x00000008;

        public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_BITS_FLAG = 0x00000010;

        public const int CMSG_KEY_AGREE_ENCRYPT_FREE_OBJID_FLAG = 0x00000020;

        // CryptMsgDllExportKeyAgree
        public static ReadOnlySpan<sbyte> CMSG_OID_EXPORT_KEY_AGREE_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x41, 0x67, 0x72, 0x65, 0x65, 0x00 };

        // CryptMsgDllCNGExportKeyAgree
        public static ReadOnlySpan<sbyte> CMSG_OID_CNG_EXPORT_KEY_AGREE_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x43, 0x4E, 0x47, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x41, 0x67, 0x72, 0x65, 0x65, 0x00 };

        public const int CMSG_MAIL_LIST_ENCRYPT_FREE_PARA_FLAG = 0x00000001;

        public const int CMSG_MAIL_LIST_ENCRYPT_FREE_OBJID_FLAG = 0x00000002;

        // CryptMsgDllExportMailList
        public static ReadOnlySpan<sbyte> CMSG_OID_EXPORT_MAIL_LIST_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x4D, 0x61, 0x69, 0x6C, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        // CryptMsgDllImportKeyTrans
        public static ReadOnlySpan<sbyte> CMSG_OID_IMPORT_KEY_TRANS_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x54, 0x72, 0x61, 0x6E, 0x73, 0x00 };

        // CryptMsgDllImportKeyAgree
        public static ReadOnlySpan<sbyte> CMSG_OID_IMPORT_KEY_AGREE_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x41, 0x67, 0x72, 0x65, 0x65, 0x00 };

        // CryptMsgDllImportMailList
        public static ReadOnlySpan<sbyte> CMSG_OID_IMPORT_MAIL_LIST_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x4D, 0x61, 0x69, 0x6C, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        // CryptMsgDllCNGImportKeyTrans
        public static ReadOnlySpan<sbyte> CMSG_OID_CNG_IMPORT_KEY_TRANS_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x43, 0x4E, 0x47, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x54, 0x72, 0x61, 0x6E, 0x73, 0x00 };

        // CryptMsgDllCNGImportKeyAgree
        public static ReadOnlySpan<sbyte> CMSG_OID_CNG_IMPORT_KEY_AGREE_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x43, 0x4E, 0x47, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x41, 0x67, 0x72, 0x65, 0x65, 0x00 };

        // CryptMsgDllCNGImportContentEncryptKey
        public static ReadOnlySpan<sbyte> CMSG_OID_CNG_IMPORT_CONTENT_ENCRYPT_KEY_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x43, 0x4E, 0x47, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x43, 0x6F, 0x6E, 0x74, 0x65, 0x6E, 0x74, 0x45, 0x6E, 0x63, 0x72, 0x79, 0x70, 0x74, 0x4B, 0x65, 0x79, 0x00 };

        public const int CERT_KEY_PROV_HANDLE_PROP_ID = 1;

        public const int CERT_KEY_PROV_INFO_PROP_ID = 2;

        public const int CERT_SHA1_HASH_PROP_ID = 3;

        public const int CERT_MD5_HASH_PROP_ID = 4;

        public const int CERT_KEY_CONTEXT_PROP_ID = 5;

        public const int CERT_KEY_SPEC_PROP_ID = 6;

        public const int CERT_IE30_RESERVED_PROP_ID = 7;

        public const int CERT_PUBKEY_HASH_RESERVED_PROP_ID = 8;

        public const int CERT_ENHKEY_USAGE_PROP_ID = 9;

        public const int CERT_NEXT_UPDATE_LOCATION_PROP_ID = 10;

        public const int CERT_FRIENDLY_NAME_PROP_ID = 11;

        public const int CERT_PVK_FILE_PROP_ID = 12;

        public const int CERT_DESCRIPTION_PROP_ID = 13;

        public const int CERT_ACCESS_STATE_PROP_ID = 14;

        public const int CERT_SIGNATURE_HASH_PROP_ID = 15;

        public const int CERT_SMART_CARD_DATA_PROP_ID = 16;

        public const int CERT_EFS_PROP_ID = 17;

        public const int CERT_FORTEZZA_DATA_PROP_ID = 18;

        public const int CERT_ARCHIVED_PROP_ID = 19;

        public const int CERT_KEY_IDENTIFIER_PROP_ID = 20;

        public const int CERT_AUTO_ENROLL_PROP_ID = 21;

        public const int CERT_PUBKEY_ALG_PARA_PROP_ID = 22;

        public const int CERT_CROSS_CERT_DIST_POINTS_PROP_ID = 23;

        public const int CERT_ISSUER_PUBLIC_KEY_MD5_HASH_PROP_ID = 24;

        public const int CERT_SUBJECT_PUBLIC_KEY_MD5_HASH_PROP_ID = 25;

        public const int CERT_ENROLLMENT_PROP_ID = 26;

        public const int CERT_DATE_STAMP_PROP_ID = 27;

        public const int CERT_ISSUER_SERIAL_NUMBER_MD5_HASH_PROP_ID = 28;

        public const int CERT_SUBJECT_NAME_MD5_HASH_PROP_ID = 29;

        public const int CERT_EXTENDED_ERROR_INFO_PROP_ID = 30;

        public const int CERT_RENEWAL_PROP_ID = 64;

        public const int CERT_ARCHIVED_KEY_HASH_PROP_ID = 65;

        public const int CERT_AUTO_ENROLL_RETRY_PROP_ID = 66;

        public const int CERT_AIA_URL_RETRIEVED_PROP_ID = 67;

        public const int CERT_AUTHORITY_INFO_ACCESS_PROP_ID = 68;

        public const int CERT_BACKED_UP_PROP_ID = 69;

        public const int CERT_OCSP_RESPONSE_PROP_ID = 70;

        public const int CERT_REQUEST_ORIGINATOR_PROP_ID = 71;

        public const int CERT_SOURCE_LOCATION_PROP_ID = 72;

        public const int CERT_SOURCE_URL_PROP_ID = 73;

        public const int CERT_NEW_KEY_PROP_ID = 74;

        public const int CERT_OCSP_CACHE_PREFIX_PROP_ID = 75;

        public const int CERT_SMART_CARD_ROOT_INFO_PROP_ID = 76;

        public const int CERT_NO_AUTO_EXPIRE_CHECK_PROP_ID = 77;

        public const int CERT_NCRYPT_KEY_HANDLE_PROP_ID = 78;

        public const int CERT_HCRYPTPROV_OR_NCRYPT_KEY_HANDLE_PROP_ID = 79;

        public const int CERT_SUBJECT_INFO_ACCESS_PROP_ID = 80;

        public const int CERT_CA_OCSP_AUTHORITY_INFO_ACCESS_PROP_ID = 81;

        public const int CERT_CA_DISABLE_CRL_PROP_ID = 82;

        public const int CERT_ROOT_PROGRAM_CERT_POLICIES_PROP_ID = 83;

        public const int CERT_ROOT_PROGRAM_NAME_CONSTRAINTS_PROP_ID = 84;

        public const int CERT_SUBJECT_OCSP_AUTHORITY_INFO_ACCESS_PROP_ID = 85;

        public const int CERT_SUBJECT_DISABLE_CRL_PROP_ID = 86;

        public const int CERT_CEP_PROP_ID = 87;

        public const int CERT_SIGN_HASH_CNG_ALG_PROP_ID = 89;

        public const int CERT_SCARD_PIN_ID_PROP_ID = 90;

        public const int CERT_SCARD_PIN_INFO_PROP_ID = 91;

        public const int CERT_SUBJECT_PUB_KEY_BIT_LENGTH_PROP_ID = 92;

        public const int CERT_PUB_KEY_CNG_ALG_BIT_LENGTH_PROP_ID = 93;

        public const int CERT_ISSUER_PUB_KEY_BIT_LENGTH_PROP_ID = 94;

        public const int CERT_ISSUER_CHAIN_SIGN_HASH_CNG_ALG_PROP_ID = 95;

        public const int CERT_ISSUER_CHAIN_PUB_KEY_CNG_ALG_BIT_LENGTH_PROP_ID = 96;

        public const int CERT_NO_EXPIRE_NOTIFICATION_PROP_ID = 97;

        public const int CERT_AUTH_ROOT_SHA256_HASH_PROP_ID = 98;

        public const int CERT_NCRYPT_KEY_HANDLE_TRANSFER_PROP_ID = 99;

        public const int CERT_HCRYPTPROV_TRANSFER_PROP_ID = 100;

        public const int CERT_SMART_CARD_READER_PROP_ID = 101;

        public const int CERT_SEND_AS_TRUSTED_ISSUER_PROP_ID = 102;

        public const int CERT_KEY_REPAIR_ATTEMPTED_PROP_ID = 103;

        public const int CERT_DISALLOWED_FILETIME_PROP_ID = 104;

        public const int CERT_ROOT_PROGRAM_CHAIN_POLICIES_PROP_ID = 105;

        public const int CERT_SMART_CARD_READER_NON_REMOVABLE_PROP_ID = 106;

        public const int CERT_SHA256_HASH_PROP_ID = 107;

        public const int CERT_SCEP_SERVER_CERTS_PROP_ID = 108;

        public const int CERT_SCEP_RA_SIGNATURE_CERT_PROP_ID = 109;

        public const int CERT_SCEP_RA_ENCRYPTION_CERT_PROP_ID = 110;

        public const int CERT_SCEP_CA_CERT_PROP_ID = 111;

        public const int CERT_SCEP_SIGNER_CERT_PROP_ID = 112;

        public const int CERT_SCEP_NONCE_PROP_ID = 113;

        public const int CERT_SCEP_ENCRYPT_HASH_CNG_ALG_PROP_ID = 114;

        public const int CERT_SCEP_FLAGS_PROP_ID = 115;

        public const int CERT_SCEP_GUID_PROP_ID = 116;

        public const int CERT_SERIALIZABLE_KEY_CONTEXT_PROP_ID = 117;

        public const int CERT_ISOLATED_KEY_PROP_ID = 118;

        public const int CERT_SERIAL_CHAIN_PROP_ID = 119;

        public const int CERT_KEY_CLASSIFICATION_PROP_ID = 120;

        public const int CERT_OCSP_MUST_STAPLE_PROP_ID = 121;

        public const int CERT_DISALLOWED_ENHKEY_USAGE_PROP_ID = 122;

        public const int CERT_NONCOMPLIANT_ROOT_URL_PROP_ID = 123;

        public const int CERT_PIN_SHA256_HASH_PROP_ID = 124;

        public const int CERT_CLR_DELETE_KEY_PROP_ID = 125;

        public const int CERT_NOT_BEFORE_FILETIME_PROP_ID = 126;

        public const int CERT_NOT_BEFORE_ENHKEY_USAGE_PROP_ID = 127;

        public const int CERT_FIRST_RESERVED_PROP_ID = 128;

        public const int CERT_LAST_RESERVED_PROP_ID = 0x00007FFF;

        public const int CERT_FIRST_USER_PROP_ID = 0x00008000;

        public const int CERT_LAST_USER_PROP_ID = 0x0000FFFF;

        // 1.3.6.1.4.1.311.10.11.
        public static ReadOnlySpan<sbyte> szOID_CERT_PROP_ID_PREFIX => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x31, 0x2E, 0x00 };

        // 1.3.6.1.4.1.311.10.11.20
        public static ReadOnlySpan<sbyte> szOID_CERT_KEY_IDENTIFIER_PROP_ID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x00 };

        // 1.3.6.1.4.1.311.10.11.4
        public static ReadOnlySpan<sbyte> szOID_CERT_MD5_HASH_PROP_ID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x31, 0x2E, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.10.11.15
        public static ReadOnlySpan<sbyte> szOID_CERT_SIGNATURE_HASH_PROP_ID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x31, 0x2E, 0x31, 0x35, 0x00 };

        public const int CERT_ACCESS_STATE_WRITE_PERSIST_FLAG = 0x1;

        public const int CERT_ACCESS_STATE_SYSTEM_STORE_FLAG = 0x2;

        public const int CERT_ACCESS_STATE_LM_SYSTEM_STORE_FLAG = 0x4;

        public const int CERT_ACCESS_STATE_GP_SYSTEM_STORE_FLAG = 0x8;

        public const int CERT_ACCESS_STATE_SHARED_USER_FLAG = 0x10;

        // 1.3.6.1.4.1.311.60.3.1
        public static ReadOnlySpan<sbyte> szOID_ROOT_PROGRAM_AUTO_UPDATE_CA_REVOCATION => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.60.3.2
        public static ReadOnlySpan<sbyte> szOID_ROOT_PROGRAM_AUTO_UPDATE_END_REVOCATION => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.60.3.3
        public static ReadOnlySpan<sbyte> szOID_ROOT_PROGRAM_NO_OCSP_FAILOVER_TO_CRL => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x00 };

        public const int CERT_SET_KEY_PROV_HANDLE_PROP_ID = 0x00000001;

        public const int CERT_SET_KEY_CONTEXT_PROP_ID = 0x00000001;

        public const uint CERT_NCRYPT_KEY_SPEC = 0xFFFFFFFF;

        // Memory
        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_MEMORY => new sbyte[] { 0x4D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x00 };

        // File
        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_FILENAME_W => new sbyte[] { 0x46, 0x69, 0x6C, 0x65, 0x00 };

        // System
        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_SYSTEM_W => new sbyte[] { 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x00 };

        // PKCS7
        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_PKCS7 => new sbyte[] { 0x50, 0x4B, 0x43, 0x53, 0x37, 0x00 };

        // PKCS12
        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_PKCS12 => new sbyte[] { 0x50, 0x4B, 0x43, 0x53, 0x31, 0x32, 0x00 };

        // Serialized
        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_SERIALIZED => new sbyte[] { 0x53, 0x65, 0x72, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x64, 0x00 };

        // Collection
        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_COLLECTION => new sbyte[] { 0x43, 0x6F, 0x6C, 0x6C, 0x65, 0x63, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        // SystemRegistry
        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W => new sbyte[] { 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x52, 0x65, 0x67, 0x69, 0x73, 0x74, 0x72, 0x79, 0x00 };

        // Physical
        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_PHYSICAL_W => new sbyte[] { 0x50, 0x68, 0x79, 0x73, 0x69, 0x63, 0x61, 0x6C, 0x00 };

        // SmartCard
        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_SMART_CARD_W => new sbyte[] { 0x53, 0x6D, 0x61, 0x72, 0x74, 0x43, 0x61, 0x72, 0x64, 0x00 };

        // Ldap
        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_LDAP_W => new sbyte[] { 0x4C, 0x64, 0x61, 0x70, 0x00 };

        public const int CERT_STORE_SIGNATURE_FLAG = 0x00000001;

        public const int CERT_STORE_TIME_VALIDITY_FLAG = 0x00000002;

        public const int CERT_STORE_REVOCATION_FLAG = 0x00000004;

        public const int CERT_STORE_NO_CRL_FLAG = 0x00010000;

        public const int CERT_STORE_NO_ISSUER_FLAG = 0x00020000;

        public const int CERT_STORE_BASE_CRL_FLAG = 0x00000100;

        public const int CERT_STORE_DELTA_CRL_FLAG = 0x00000200;

        public const int CERT_STORE_NO_CRYPT_RELEASE_FLAG = 0x00000001;

        public const int CERT_STORE_SET_LOCALIZED_NAME_FLAG = 0x00000002;

        public const int CERT_STORE_DEFER_CLOSE_UNTIL_LAST_FREE_FLAG = 0x00000004;

        public const int CERT_STORE_DELETE_FLAG = 0x00000010;

        public const int CERT_STORE_UNSAFE_PHYSICAL_FLAG = 0x00000020;

        public const int CERT_STORE_SHARE_STORE_FLAG = 0x00000040;

        public const int CERT_STORE_SHARE_CONTEXT_FLAG = 0x00000080;

        public const int CERT_STORE_MANIFOLD_FLAG = 0x00000100;

        public const int CERT_STORE_ENUM_ARCHIVED_FLAG = 0x00000200;

        public const int CERT_STORE_UPDATE_KEYID_FLAG = 0x00000400;

        public const int CERT_STORE_BACKUP_RESTORE_FLAG = 0x00000800;

        public const int CERT_STORE_READONLY_FLAG = 0x00008000;

        public const int CERT_STORE_OPEN_EXISTING_FLAG = 0x00004000;

        public const int CERT_STORE_CREATE_NEW_FLAG = 0x00002000;

        public const int CERT_STORE_MAXIMUM_ALLOWED_FLAG = 0x00001000;

        public const uint CERT_SYSTEM_STORE_MASK = 0xFFFF0000;

        public const uint CERT_SYSTEM_STORE_RELOCATE_FLAG = 0x80000000;

        public const int CERT_SYSTEM_STORE_UNPROTECTED_FLAG = 0x40000000;

        public const int CERT_SYSTEM_STORE_DEFER_READ_FLAG = 0x20000000;

        public const int CERT_SYSTEM_STORE_LOCATION_MASK = 0x00FF0000;

        public const int CERT_SYSTEM_STORE_LOCATION_SHIFT = 16;

        public const int CERT_SYSTEM_STORE_CURRENT_USER_ID = 1;

        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_ID = 2;

        public const int CERT_SYSTEM_STORE_CURRENT_SERVICE_ID = 4;

        public const int CERT_SYSTEM_STORE_SERVICES_ID = 5;

        public const int CERT_SYSTEM_STORE_USERS_ID = 6;

        public const int CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY_ID = 7;

        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY_ID = 8;

        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE_ID = 9;

        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_WCOS_ID = 10;

        public const string CERT_EFSBLOB_VALUE_NAME = "EFSBlob";

        public const string CERT_PROT_ROOT_FLAGS_VALUE_NAME = "Flags";

        public const int CERT_PROT_ROOT_DISABLE_CURRENT_USER_FLAG = 0x1;

        public const int CERT_PROT_ROOT_INHIBIT_ADD_AT_INIT_FLAG = 0x2;

        public const int CERT_PROT_ROOT_INHIBIT_PURGE_LM_FLAG = 0x4;

        public const int CERT_PROT_ROOT_DISABLE_LM_AUTH_FLAG = 0x8;

        public const int CERT_PROT_ROOT_ONLY_LM_GPT_FLAG = 0x8;

        public const int CERT_PROT_ROOT_DISABLE_NT_AUTH_REQUIRED_FLAG = 0x10;

        public const int CERT_PROT_ROOT_DISABLE_NOT_DEFINED_NAME_CONSTRAINT_FLAG = 0x20;

        public const int CERT_PROT_ROOT_DISABLE_PEER_TRUST = 0x10000;

        public const string CERT_PROT_ROOT_PEER_USAGES_VALUE_NAME = "PeerUsages";

        // PeerUsages
        public static ReadOnlySpan<sbyte> CERT_PROT_ROOT_PEER_USAGES_VALUE_NAME_A => new sbyte[] { 0x50, 0x65, 0x65, 0x72, 0x55, 0x73, 0x61, 0x67, 0x65, 0x73, 0x00 };

        public const string CERT_TRUST_PUB_AUTHENTICODE_FLAGS_VALUE_NAME = "AuthenticodeFlags";

        public const int CERT_TRUST_PUB_ALLOW_TRUST_MASK = 0x00000003;

        public const int CERT_TRUST_PUB_ALLOW_END_USER_TRUST = 0x00000000;

        public const int CERT_TRUST_PUB_ALLOW_MACHINE_ADMIN_TRUST = 0x00000001;

        public const int CERT_TRUST_PUB_ALLOW_ENTERPRISE_ADMIN_TRUST = 0x00000002;

        public const int CERT_TRUST_PUB_CHECK_PUBLISHER_REV_FLAG = 0x00000100;

        public const int CERT_TRUST_PUB_CHECK_TIMESTAMP_REV_FLAG = 0x00000200;

        public const string CERT_OCM_SUBCOMPONENTS_ROOT_AUTO_UPDATE_VALUE_NAME = "RootAutoUpdate";

        public const string CERT_DISABLE_ROOT_AUTO_UPDATE_VALUE_NAME = "DisableRootAutoUpdate";

        public const string CERT_ENABLE_DISALLOWED_CERT_AUTO_UPDATE_VALUE_NAME = "EnableDisallowedCertAutoUpdate";

        public const string CERT_DISABLE_PIN_RULES_AUTO_UPDATE_VALUE_NAME = "DisablePinRulesAutoUpdate";

        public const string CERT_AUTO_UPDATE_ROOT_DIR_URL_VALUE_NAME = "RootDirUrl";

        public const string CERT_AUTO_UPDATE_SYNC_FROM_DIR_URL_VALUE_NAME = "SyncFromDirUrl";

        public const string CERT_AUTH_ROOT_AUTO_UPDATE_SYNC_DELTA_TIME_VALUE_NAME = "SyncDeltaTime";

        public const string CERT_AUTH_ROOT_AUTO_UPDATE_FLAGS_VALUE_NAME = "Flags";

        public const int CERT_AUTH_ROOT_AUTO_UPDATE_DISABLE_UNTRUSTED_ROOT_LOGGING_FLAG = 0x1;

        public const int CERT_AUTH_ROOT_AUTO_UPDATE_DISABLE_PARTIAL_CHAIN_LOGGING_FLAG = 0x2;

        public const int CERT_AUTO_UPDATE_DISABLE_RANDOM_QUERY_STRING_FLAG = 0x4;

        public const string CERT_AUTH_ROOT_AUTO_UPDATE_LAST_SYNC_TIME_VALUE_NAME = "LastSyncTime";

        public const string CERT_AUTH_ROOT_AUTO_UPDATE_ENCODED_CTL_VALUE_NAME = "EncodedCtl";

        public const string CERT_AUTH_ROOT_CTL_FILENAME = "authroot.stl";

        // authroot.stl
        public static ReadOnlySpan<sbyte> CERT_AUTH_ROOT_CTL_FILENAME_A => new sbyte[] { 0x61, 0x75, 0x74, 0x68, 0x72, 0x6F, 0x6F, 0x74, 0x2E, 0x73, 0x74, 0x6C, 0x00 };

        public const string CERT_AUTH_ROOT_CAB_FILENAME = "authrootstl.cab";

        public const string CERT_AUTH_ROOT_SEQ_FILENAME = "authrootseq.txt";

        public const string CERT_AUTH_ROOT_CERT_EXT = ".crt";

        public const string CERT_DISALLOWED_CERT_CTL_FILENAME = "disallowedcert.stl";

        // disallowedcert.stl
        public static ReadOnlySpan<sbyte> CERT_DISALLOWED_CERT_CTL_FILENAME_A => new sbyte[] { 0x64, 0x69, 0x73, 0x61, 0x6C, 0x6C, 0x6F, 0x77, 0x65, 0x64, 0x63, 0x65, 0x72, 0x74, 0x2E, 0x73, 0x74, 0x6C, 0x00 };

        public const string CERT_DISALLOWED_CERT_CAB_FILENAME = "disallowedcertstl.cab";

        public const string CERT_PIN_RULES_CTL_FILENAME = "pinrules.stl";

        // pinrules.stl
        public static ReadOnlySpan<sbyte> CERT_PIN_RULES_CTL_FILENAME_A => new sbyte[] { 0x70, 0x69, 0x6E, 0x72, 0x75, 0x6C, 0x65, 0x73, 0x2E, 0x73, 0x74, 0x6C, 0x00 };

        public const string CERT_PIN_RULES_CAB_FILENAME = "pinrulesstl.cab";

        public const int CERT_REGISTRY_STORE_REMOTE_FLAG = 0x10000;

        public const int CERT_REGISTRY_STORE_SERIALIZED_FLAG = 0x20000;

        public const uint CERT_REGISTRY_STORE_CLIENT_GPT_FLAG = 0x80000000;

        public const int CERT_REGISTRY_STORE_LM_GPT_FLAG = 0x01000000;

        public const int CERT_REGISTRY_STORE_ROAMING_FLAG = 0x40000;

        public const int CERT_REGISTRY_STORE_MY_IE_DIRTY_FLAG = 0x80000;

        public const int CERT_REGISTRY_STORE_EXTERNAL_FLAG = 0x100000;

        public const int CERT_FILE_STORE_COMMIT_ENABLE_FLAG = 0x10000;

        public const int CERT_LDAP_STORE_SIGN_FLAG = 0x10000;

        public const int CERT_LDAP_STORE_AREC_EXCLUSIVE_FLAG = 0x20000;

        public const int CERT_LDAP_STORE_OPENED_FLAG = 0x40000;

        public const int CERT_LDAP_STORE_UNBIND_FLAG = 0x80000;

        // CertDllOpenStoreProv
        public static ReadOnlySpan<sbyte> CRYPT_OID_OPEN_STORE_PROV_FUNC => new sbyte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x4F, 0x70, 0x65, 0x6E, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x50, 0x72, 0x6F, 0x76, 0x00 };

        public const int CERT_STORE_PROV_EXTERNAL_FLAG = 0x1;

        public const int CERT_STORE_PROV_DELETED_FLAG = 0x2;

        public const int CERT_STORE_PROV_NO_PERSIST_FLAG = 0x4;

        public const int CERT_STORE_PROV_SYSTEM_STORE_FLAG = 0x8;

        public const int CERT_STORE_PROV_LM_SYSTEM_STORE_FLAG = 0x10;

        public const int CERT_STORE_PROV_GP_SYSTEM_STORE_FLAG = 0x20;

        public const int CERT_STORE_PROV_SHARED_USER_FLAG = 0x40;

        public const int CERT_STORE_PROV_CLOSE_FUNC = 0;

        public const int CERT_STORE_PROV_READ_CERT_FUNC = 1;

        public const int CERT_STORE_PROV_WRITE_CERT_FUNC = 2;

        public const int CERT_STORE_PROV_DELETE_CERT_FUNC = 3;

        public const int CERT_STORE_PROV_SET_CERT_PROPERTY_FUNC = 4;

        public const int CERT_STORE_PROV_READ_CRL_FUNC = 5;

        public const int CERT_STORE_PROV_WRITE_CRL_FUNC = 6;

        public const int CERT_STORE_PROV_DELETE_CRL_FUNC = 7;

        public const int CERT_STORE_PROV_SET_CRL_PROPERTY_FUNC = 8;

        public const int CERT_STORE_PROV_READ_CTL_FUNC = 9;

        public const int CERT_STORE_PROV_WRITE_CTL_FUNC = 10;

        public const int CERT_STORE_PROV_DELETE_CTL_FUNC = 11;

        public const int CERT_STORE_PROV_SET_CTL_PROPERTY_FUNC = 12;

        public const int CERT_STORE_PROV_CONTROL_FUNC = 13;

        public const int CERT_STORE_PROV_FIND_CERT_FUNC = 14;

        public const int CERT_STORE_PROV_FREE_FIND_CERT_FUNC = 15;

        public const int CERT_STORE_PROV_GET_CERT_PROPERTY_FUNC = 16;

        public const int CERT_STORE_PROV_FIND_CRL_FUNC = 17;

        public const int CERT_STORE_PROV_FREE_FIND_CRL_FUNC = 18;

        public const int CERT_STORE_PROV_GET_CRL_PROPERTY_FUNC = 19;

        public const int CERT_STORE_PROV_FIND_CTL_FUNC = 20;

        public const int CERT_STORE_PROV_FREE_FIND_CTL_FUNC = 21;

        public const int CERT_STORE_PROV_GET_CTL_PROPERTY_FUNC = 22;

        public const int CERT_STORE_PROV_WRITE_ADD_FLAG = 0x1;

        public const int CERT_STORE_SAVE_AS_STORE = 1;

        public const int CERT_STORE_SAVE_AS_PKCS7 = 2;

        public const int CERT_STORE_SAVE_AS_PKCS12 = 3;

        public const int CERT_STORE_SAVE_TO_FILE = 1;

        public const int CERT_STORE_SAVE_TO_MEMORY = 2;

        public const int CERT_STORE_SAVE_TO_FILENAME_A = 3;

        public const int CERT_STORE_SAVE_TO_FILENAME_W = 4;

        public const int CERT_CLOSE_STORE_FORCE_FLAG = 0x00000001;

        public const int CERT_CLOSE_STORE_CHECK_FLAG = 0x00000002;

        public const int CERT_COMPARE_MASK = 0xFFFF;

        public const int CERT_COMPARE_SHIFT = 16;

        public const int CERT_COMPARE_ANY = 0;

        public const int CERT_COMPARE_SHA1_HASH = 1;

        public const int CERT_COMPARE_NAME = 2;

        public const int CERT_COMPARE_ATTR = 3;

        public const int CERT_COMPARE_MD5_HASH = 4;

        public const int CERT_COMPARE_PROPERTY = 5;

        public const int CERT_COMPARE_PUBLIC_KEY = 6;

        public const int CERT_COMPARE_NAME_STR_A = 7;

        public const int CERT_COMPARE_NAME_STR_W = 8;

        public const int CERT_COMPARE_KEY_SPEC = 9;

        public const int CERT_COMPARE_ENHKEY_USAGE = 10;

        public const int CERT_COMPARE_SUBJECT_CERT = 11;

        public const int CERT_COMPARE_ISSUER_OF = 12;

        public const int CERT_COMPARE_EXISTING = 13;

        public const int CERT_COMPARE_SIGNATURE_HASH = 14;

        public const int CERT_COMPARE_KEY_IDENTIFIER = 15;

        public const int CERT_COMPARE_CERT_ID = 16;

        public const int CERT_COMPARE_CROSS_CERT_DIST_POINTS = 17;

        public const int CERT_COMPARE_PUBKEY_MD5_HASH = 18;

        public const int CERT_COMPARE_SUBJECT_INFO_ACCESS = 19;

        public const int CERT_COMPARE_HASH_STR = 20;

        public const int CERT_COMPARE_HAS_PRIVATE_KEY = 21;

        public const int CERT_FIND_OPTIONAL_ENHKEY_USAGE_FLAG = 0x1;

        public const int CERT_FIND_EXT_ONLY_ENHKEY_USAGE_FLAG = 0x2;

        public const int CERT_FIND_PROP_ONLY_ENHKEY_USAGE_FLAG = 0x4;

        public const int CERT_FIND_NO_ENHKEY_USAGE_FLAG = 0x8;

        public const int CERT_FIND_OR_ENHKEY_USAGE_FLAG = 0x10;

        public const int CERT_FIND_VALID_ENHKEY_USAGE_FLAG = 0x20;

        public const uint CERT_SET_PROPERTY_IGNORE_PERSIST_ERROR_FLAG = 0x80000000;

        public const int CERT_SET_PROPERTY_INHIBIT_PERSIST_FLAG = 0x40000000;

        public const int CTL_ENTRY_FROM_PROP_CHAIN_FLAG = 0x1;

        public const int CRL_FIND_ANY = 0;

        public const int CRL_FIND_ISSUED_BY = 1;

        public const int CRL_FIND_EXISTING = 2;

        public const int CRL_FIND_ISSUED_FOR = 3;

        public const int CRL_FIND_ISSUED_BY_AKI_FLAG = 0x1;

        public const int CRL_FIND_ISSUED_BY_SIGNATURE_FLAG = 0x2;

        public const int CRL_FIND_ISSUED_BY_DELTA_FLAG = 0x4;

        public const int CRL_FIND_ISSUED_BY_BASE_FLAG = 0x8;

        public const int CRL_FIND_ISSUED_FOR_SET_STRONG_PROPERTIES_FLAG = 0x10;

        public const int CERT_STORE_ADD_NEW = 1;

        public const int CERT_STORE_ADD_USE_EXISTING = 2;

        public const int CERT_STORE_ADD_REPLACE_EXISTING = 3;

        public const int CERT_STORE_ADD_ALWAYS = 4;

        public const int CERT_STORE_ADD_REPLACE_EXISTING_INHERIT_PROPERTIES = 5;

        public const int CERT_STORE_ADD_NEWER = 6;

        public const int CERT_STORE_ADD_NEWER_INHERIT_PROPERTIES = 7;

        public const int CERT_STORE_CERTIFICATE_CONTEXT = 1;

        public const int CERT_STORE_CRL_CONTEXT = 2;

        public const int CERT_STORE_CTL_CONTEXT = 3;

        public const int CTL_ANY_SUBJECT_TYPE = 1;

        public const int CTL_CERT_SUBJECT_TYPE = 2;

        public const int CTL_FIND_ANY = 0;

        public const int CTL_FIND_SHA1_HASH = 1;

        public const int CTL_FIND_MD5_HASH = 2;

        public const int CTL_FIND_USAGE = 3;

        public const int CTL_FIND_SUBJECT = 4;

        public const int CTL_FIND_EXISTING = 5;

        public const uint CTL_FIND_NO_LIST_ID_CBDATA = 0xFFFFFFFF;

        public const int CTL_FIND_SAME_USAGE_FLAG = 0x1;

        public const int CERT_STORE_CTRL_RESYNC = 1;

        public const int CERT_STORE_CTRL_NOTIFY_CHANGE = 2;

        public const int CERT_STORE_CTRL_COMMIT = 3;

        public const int CERT_STORE_CTRL_AUTO_RESYNC = 4;

        public const int CERT_STORE_CTRL_CANCEL_NOTIFY = 5;

        public const int CERT_STORE_CTRL_INHIBIT_DUPLICATE_HANDLE_FLAG = 0x1;

        public const int CERT_STORE_CTRL_COMMIT_FORCE_FLAG = 0x1;

        public const int CERT_STORE_CTRL_COMMIT_CLEAR_FLAG = 0x2;

        public const int CERT_STORE_LOCALIZED_NAME_PROP_ID = 0x1000;

        public const int CERT_CREATE_CONTEXT_NOCOPY_FLAG = 0x1;

        public const int CERT_CREATE_CONTEXT_SORTED_FLAG = 0x2;

        public const int CERT_CREATE_CONTEXT_NO_HCRYPTMSG_FLAG = 0x4;

        public const int CERT_CREATE_CONTEXT_NO_ENTRY_FLAG = 0x8;

        public const int CERT_PHYSICAL_STORE_ADD_ENABLE_FLAG = 0x1;

        public const int CERT_PHYSICAL_STORE_OPEN_DISABLE_FLAG = 0x2;

        public const int CERT_PHYSICAL_STORE_REMOTE_OPEN_DISABLE_FLAG = 0x4;

        public const int CERT_PHYSICAL_STORE_INSERT_COMPUTER_NAME_ENABLE_FLAG = 0x8;

        public const int CERT_PHYSICAL_STORE_PREDEFINED_ENUM_FLAG = 0x1;

        public const string CERT_PHYSICAL_STORE_DEFAULT_NAME = ".Default";

        public const string CERT_PHYSICAL_STORE_GROUP_POLICY_NAME = ".GroupPolicy";

        public const string CERT_PHYSICAL_STORE_LOCAL_MACHINE_NAME = ".LocalMachine";

        public const string CERT_PHYSICAL_STORE_DS_USER_CERTIFICATE_NAME = ".UserCertificate";

        public const string CERT_PHYSICAL_STORE_ENTERPRISE_NAME = ".Enterprise";

        public const string CERT_PHYSICAL_STORE_AUTH_ROOT_NAME = ".AuthRoot";

        public const string CERT_PHYSICAL_STORE_SMART_CARD_NAME = ".SmartCard";

        // CertDllOpenSystemStoreProv
        public static ReadOnlySpan<sbyte> CRYPT_OID_OPEN_SYSTEM_STORE_PROV_FUNC => new sbyte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x4F, 0x70, 0x65, 0x6E, 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x50, 0x72, 0x6F, 0x76, 0x00 };

        // CertDllRegisterSystemStore
        public static ReadOnlySpan<sbyte> CRYPT_OID_REGISTER_SYSTEM_STORE_FUNC => new sbyte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x52, 0x65, 0x67, 0x69, 0x73, 0x74, 0x65, 0x72, 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x00 };

        // CertDllUnregisterSystemStore
        public static ReadOnlySpan<sbyte> CRYPT_OID_UNREGISTER_SYSTEM_STORE_FUNC => new sbyte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x55, 0x6E, 0x72, 0x65, 0x67, 0x69, 0x73, 0x74, 0x65, 0x72, 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x00 };

        // CertDllEnumSystemStore
        public static ReadOnlySpan<sbyte> CRYPT_OID_ENUM_SYSTEM_STORE_FUNC => new sbyte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x6E, 0x75, 0x6D, 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x00 };

        // CertDllRegisterPhysicalStore
        public static ReadOnlySpan<sbyte> CRYPT_OID_REGISTER_PHYSICAL_STORE_FUNC => new sbyte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x52, 0x65, 0x67, 0x69, 0x73, 0x74, 0x65, 0x72, 0x50, 0x68, 0x79, 0x73, 0x69, 0x63, 0x61, 0x6C, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x00 };

        // CertDllUnregisterPhysicalStore
        public static ReadOnlySpan<sbyte> CRYPT_OID_UNREGISTER_PHYSICAL_STORE_FUNC => new sbyte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x55, 0x6E, 0x72, 0x65, 0x67, 0x69, 0x73, 0x74, 0x65, 0x72, 0x50, 0x68, 0x79, 0x73, 0x69, 0x63, 0x61, 0x6C, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x00 };

        // CertDllEnumPhysicalStore
        public static ReadOnlySpan<sbyte> CRYPT_OID_ENUM_PHYSICAL_STORE_FUNC => new sbyte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x6E, 0x75, 0x6D, 0x50, 0x68, 0x79, 0x73, 0x69, 0x63, 0x61, 0x6C, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x00 };

        public const string CRYPT_OID_SYSTEM_STORE_LOCATION_VALUE_NAME = "SystemStoreLocation";

        public const int CMSG_TRUSTED_SIGNER_FLAG = 0x1;

        public const int CMSG_SIGNER_ONLY_FLAG = 0x2;

        public const int CMSG_USE_SIGNER_INDEX_FLAG = 0x4;

        public const int CMSG_CMS_ENCAPSULATED_CTL_FLAG = 0x00008000;

        public const int CMSG_ENCODE_SORTED_CTL_FLAG = 0x1;

        public const int CMSG_ENCODE_HASHED_SUBJECT_IDENTIFIER_FLAG = 0x2;

        public const int CERT_VERIFY_INHIBIT_CTL_UPDATE_FLAG = 0x1;

        public const int CERT_VERIFY_TRUSTED_SIGNERS_FLAG = 0x2;

        public const int CERT_VERIFY_NO_TIME_CHECK_FLAG = 0x4;

        public const int CERT_VERIFY_ALLOW_MORE_USAGE_FLAG = 0x8;

        public const int CERT_VERIFY_UPDATED_CTL_FLAG = 0x1;

        public const int CERT_CONTEXT_REVOCATION_TYPE = 1;

        public const int CERT_VERIFY_REV_CHAIN_FLAG = 0x00000001;

        public const int CERT_VERIFY_CACHE_ONLY_BASED_REVOCATION = 0x00000002;

        public const int CERT_VERIFY_REV_ACCUMULATIVE_TIMEOUT_FLAG = 0x00000004;

        public const int CERT_VERIFY_REV_SERVER_OCSP_FLAG = 0x00000008;

        public const int CERT_VERIFY_REV_NO_OCSP_FAILOVER_TO_CRL_FLAG = 0x00000010;

        public const int CERT_VERIFY_REV_SERVER_OCSP_WIRE_ONLY_FLAG = 0x00000020;

        public const int CERT_UNICODE_IS_RDN_ATTRS_FLAG = 0x1;

        public const int CERT_CASE_INSENSITIVE_IS_RDN_ATTRS_FLAG = 0x2;

        public const int CRYPT_VERIFY_CERT_SIGN_SUBJECT_BLOB = 1;

        public const int CRYPT_VERIFY_CERT_SIGN_SUBJECT_CERT = 2;

        public const int CRYPT_VERIFY_CERT_SIGN_SUBJECT_CRL = 3;

        public const int CRYPT_VERIFY_CERT_SIGN_SUBJECT_OCSP_BASIC_SIGNED_RESPONSE = 4;

        public const int CRYPT_VERIFY_CERT_SIGN_ISSUER_PUBKEY = 1;

        public const int CRYPT_VERIFY_CERT_SIGN_ISSUER_CERT = 2;

        public const int CRYPT_VERIFY_CERT_SIGN_ISSUER_CHAIN = 3;

        public const int CRYPT_VERIFY_CERT_SIGN_ISSUER_NULL = 4;

        public const int CRYPT_VERIFY_CERT_SIGN_DISABLE_MD2_MD4_FLAG = 0x00000001;

        public const int CRYPT_VERIFY_CERT_SIGN_SET_STRONG_PROPERTIES_FLAG = 0x00000002;

        public const int CRYPT_VERIFY_CERT_SIGN_RETURN_STRONG_PROPERTIES_FLAG = 0x00000004;

        public const int CRYPT_VERIFY_CERT_SIGN_CHECK_WEAK_HASH_FLAG = 0x00000008;

        public const int CRYPT_DEFAULT_CONTEXT_AUTO_RELEASE_FLAG = 0x00000001;

        public const int CRYPT_DEFAULT_CONTEXT_PROCESS_FLAG = 0x00000002;

        public const int CRYPT_DEFAULT_CONTEXT_CERT_SIGN_OID = 1;

        public const int CRYPT_DEFAULT_CONTEXT_MULTI_CERT_SIGN_OID = 2;

        // CryptDllExportPublicKeyInfoEx
        public static ReadOnlySpan<sbyte> CRYPT_OID_EXPORT_PUBLIC_KEY_INFO_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x50, 0x75, 0x62, 0x6C, 0x69, 0x63, 0x4B, 0x65, 0x79, 0x49, 0x6E, 0x66, 0x6F, 0x45, 0x78, 0x00 };

        // CryptDllImportPublicKeyInfoEx
        public static ReadOnlySpan<sbyte> CRYPT_OID_IMPORT_PUBLIC_KEY_INFO_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x50, 0x75, 0x62, 0x6C, 0x69, 0x63, 0x4B, 0x65, 0x79, 0x49, 0x6E, 0x66, 0x6F, 0x45, 0x78, 0x00 };

        public const int CRYPT_ACQUIRE_CACHE_FLAG = 0x00000001;

        public const int CRYPT_ACQUIRE_USE_PROV_INFO_FLAG = 0x00000002;

        public const int CRYPT_ACQUIRE_COMPARE_KEY_FLAG = 0x00000004;

        public const int CRYPT_ACQUIRE_NO_HEALING = 0x00000008;

        public const int CRYPT_ACQUIRE_SILENT_FLAG = 0x00000040;

        public const int CRYPT_ACQUIRE_WINDOW_HANDLE_FLAG = 0x00000080;

        public const int CRYPT_ACQUIRE_NCRYPT_KEY_FLAGS_MASK = 0x00070000;

        public const int CRYPT_ACQUIRE_ALLOW_NCRYPT_KEY_FLAG = 0x00010000;

        public const int CRYPT_ACQUIRE_PREFER_NCRYPT_KEY_FLAG = 0x00020000;

        public const int CRYPT_ACQUIRE_ONLY_NCRYPT_KEY_FLAG = 0x00040000;

        public const int CRYPT_FIND_USER_KEYSET_FLAG = 0x00000001;

        public const int CRYPT_FIND_MACHINE_KEYSET_FLAG = 0x00000002;

        public const int CRYPT_FIND_SILENT_KEYSET_FLAG = 0x00000040;

        // CryptDllImportPrivateKeyInfoEx
        public static ReadOnlySpan<sbyte> CRYPT_OID_IMPORT_PRIVATE_KEY_INFO_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x50, 0x72, 0x69, 0x76, 0x61, 0x74, 0x65, 0x4B, 0x65, 0x79, 0x49, 0x6E, 0x66, 0x6F, 0x45, 0x78, 0x00 };

        // CryptDllExportPrivateKeyInfoEx
        public static ReadOnlySpan<sbyte> CRYPT_OID_EXPORT_PRIVATE_KEY_INFO_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x50, 0x72, 0x69, 0x76, 0x61, 0x74, 0x65, 0x4B, 0x65, 0x79, 0x49, 0x6E, 0x66, 0x6F, 0x45, 0x78, 0x00 };

        public const int CERT_SIMPLE_NAME_STR = 1;

        public const int CERT_OID_NAME_STR = 2;

        public const int CERT_X500_NAME_STR = 3;

        public const int CERT_XML_NAME_STR = 4;

        public const int CERT_NAME_STR_SEMICOLON_FLAG = 0x40000000;

        public const int CERT_NAME_STR_NO_PLUS_FLAG = 0x20000000;

        public const int CERT_NAME_STR_NO_QUOTING_FLAG = 0x10000000;

        public const int CERT_NAME_STR_CRLF_FLAG = 0x08000000;

        public const int CERT_NAME_STR_COMMA_FLAG = 0x04000000;

        public const int CERT_NAME_STR_REVERSE_FLAG = 0x02000000;

        public const int CERT_NAME_STR_FORWARD_FLAG = 0x01000000;

        public const int CERT_NAME_STR_DISABLE_IE4_UTF8_FLAG = 0x00010000;

        public const int CERT_NAME_STR_ENABLE_T61_UNICODE_FLAG = 0x00020000;

        public const int CERT_NAME_STR_ENABLE_UTF8_UNICODE_FLAG = 0x00040000;

        public const int CERT_NAME_STR_FORCE_UTF8_DIR_STR_FLAG = 0x00080000;

        public const int CERT_NAME_STR_DISABLE_UTF8_DIR_STR_FLAG = 0x00100000;

        public const int CERT_NAME_STR_ENABLE_PUNYCODE_FLAG = 0x00200000;

        public const int CERT_NAME_EMAIL_TYPE = 1;

        public const int CERT_NAME_RDN_TYPE = 2;

        public const int CERT_NAME_ATTR_TYPE = 3;

        public const int CERT_NAME_SIMPLE_DISPLAY_TYPE = 4;

        public const int CERT_NAME_FRIENDLY_DISPLAY_TYPE = 5;

        public const int CERT_NAME_DNS_TYPE = 6;

        public const int CERT_NAME_URL_TYPE = 7;

        public const int CERT_NAME_UPN_TYPE = 8;

        public const int CERT_NAME_ISSUER_FLAG = 0x1;

        public const int CERT_NAME_DISABLE_IE4_UTF8_FLAG = 0x00010000;

        public const int CERT_NAME_SEARCH_ALL_NAMES_FLAG = 0x2;

        public const int CRYPT_MESSAGE_BARE_CONTENT_OUT_FLAG = 0x00000001;

        public const int CRYPT_MESSAGE_ENCAPSULATED_CONTENT_OUT_FLAG = 0x00000002;

        public const int CRYPT_MESSAGE_KEYID_SIGNER_FLAG = 0x00000004;

        public const int CRYPT_MESSAGE_SILENT_KEYSET_FLAG = 0x00000040;

        public const int CRYPT_MESSAGE_KEYID_RECIPIENT_FLAG = 0x4;

        public const int CERT_QUERY_OBJECT_FILE = 0x00000001;

        public const int CERT_QUERY_OBJECT_BLOB = 0x00000002;

        public const int CERT_QUERY_CONTENT_CERT = 1;

        public const int CERT_QUERY_CONTENT_CTL = 2;

        public const int CERT_QUERY_CONTENT_CRL = 3;

        public const int CERT_QUERY_CONTENT_SERIALIZED_STORE = 4;

        public const int CERT_QUERY_CONTENT_SERIALIZED_CERT = 5;

        public const int CERT_QUERY_CONTENT_SERIALIZED_CTL = 6;

        public const int CERT_QUERY_CONTENT_SERIALIZED_CRL = 7;

        public const int CERT_QUERY_CONTENT_PKCS7_SIGNED = 8;

        public const int CERT_QUERY_CONTENT_PKCS7_UNSIGNED = 9;

        public const int CERT_QUERY_CONTENT_PKCS7_SIGNED_EMBED = 10;

        public const int CERT_QUERY_CONTENT_PKCS10 = 11;

        public const int CERT_QUERY_CONTENT_PFX = 12;

        public const int CERT_QUERY_CONTENT_CERT_PAIR = 13;

        public const int CERT_QUERY_CONTENT_PFX_AND_LOAD = 14;

        public const int CERT_QUERY_FORMAT_BINARY = 1;

        public const int CERT_QUERY_FORMAT_BASE64_ENCODED = 2;

        public const int CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED = 3;

        // SchemeDllRetrieveEncodedObject
        public static ReadOnlySpan<sbyte> SCHEME_OID_RETRIEVE_ENCODED_OBJECT_FUNC => new sbyte[] { 0x53, 0x63, 0x68, 0x65, 0x6D, 0x65, 0x44, 0x6C, 0x6C, 0x52, 0x65, 0x74, 0x72, 0x69, 0x65, 0x76, 0x65, 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x64, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        // SchemeDllRetrieveEncodedObjectW
        public static ReadOnlySpan<sbyte> SCHEME_OID_RETRIEVE_ENCODED_OBJECTW_FUNC => new sbyte[] { 0x53, 0x63, 0x68, 0x65, 0x6D, 0x65, 0x44, 0x6C, 0x6C, 0x52, 0x65, 0x74, 0x72, 0x69, 0x65, 0x76, 0x65, 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x64, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x57, 0x00 };

        // ContextDllCreateObjectContext
        public static ReadOnlySpan<sbyte> CONTEXT_OID_CREATE_OBJECT_CONTEXT_FUNC => new sbyte[] { 0x43, 0x6F, 0x6E, 0x74, 0x65, 0x78, 0x74, 0x44, 0x6C, 0x6C, 0x43, 0x72, 0x65, 0x61, 0x74, 0x65, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x43, 0x6F, 0x6E, 0x74, 0x65, 0x78, 0x74, 0x00 };

        public const int CRYPT_RETRIEVE_MULTIPLE_OBJECTS = 0x00000001;

        public const int CRYPT_CACHE_ONLY_RETRIEVAL = 0x00000002;

        public const int CRYPT_WIRE_ONLY_RETRIEVAL = 0x00000004;

        public const int CRYPT_DONT_CACHE_RESULT = 0x00000008;

        public const int CRYPT_ASYNC_RETRIEVAL = 0x00000010;

        public const int CRYPT_STICKY_CACHE_RETRIEVAL = 0x00001000;

        public const int CRYPT_LDAP_SCOPE_BASE_ONLY_RETRIEVAL = 0x00002000;

        public const int CRYPT_OFFLINE_CHECK_RETRIEVAL = 0x00004000;

        public const int CRYPT_LDAP_INSERT_ENTRY_ATTRIBUTE = 0x00008000;

        public const int CRYPT_LDAP_SIGN_RETRIEVAL = 0x00010000;

        public const int CRYPT_NO_AUTH_RETRIEVAL = 0x00020000;

        public const int CRYPT_LDAP_AREC_EXCLUSIVE_RETRIEVAL = 0x00040000;

        public const int CRYPT_AIA_RETRIEVAL = 0x00080000;

        public const int CRYPT_HTTP_POST_RETRIEVAL = 0x00100000;

        public const int CRYPT_PROXY_CACHE_RETRIEVAL = 0x00200000;

        public const int CRYPT_NOT_MODIFIED_RETRIEVAL = 0x00400000;

        public const int CRYPT_ENABLE_SSL_REVOCATION_RETRIEVAL = 0x00800000;

        public const int CRYPT_RANDOM_QUERY_STRING_RETRIEVAL = 0x04000000;

        public const int CRYPT_ENABLE_FILE_RETRIEVAL = 0x08000000;

        public const int CRYPT_CREATE_NEW_FLUSH_ENTRY = 0x10000000;

        public const int CRYPT_VERIFY_CONTEXT_SIGNATURE = 0x00000020;

        public const int CRYPT_VERIFY_DATA_HASH = 0x00000040;

        public const int CRYPT_KEEP_TIME_VALID = 0x00000080;

        public const int CRYPT_DONT_VERIFY_SIGNATURE = 0x00000100;

        public const int CRYPT_DONT_CHECK_TIME_VALIDITY = 0x00000200;

        public const int CRYPT_CHECK_FRESHNESS_TIME_VALIDITY = 0x00000400;

        public const int CRYPT_ACCUMULATIVE_TIMEOUT = 0x00000800;

        public const int CRYPT_OCSP_ONLY_RETRIEVAL = 0x01000000;

        public const int CRYPT_NO_OCSP_FAILOVER_TO_CRL_RETRIEVAL = 0x02000000;

        public const int CRYPTNET_URL_CACHE_PRE_FETCH_NONE = 0;

        public const int CRYPTNET_URL_CACHE_PRE_FETCH_BLOB = 1;

        public const int CRYPTNET_URL_CACHE_PRE_FETCH_CRL = 2;

        public const int CRYPTNET_URL_CACHE_PRE_FETCH_OCSP = 3;

        public const int CRYPTNET_URL_CACHE_PRE_FETCH_AUTOROOT_CAB = 5;

        public const int CRYPTNET_URL_CACHE_PRE_FETCH_DISALLOWED_CERT_CAB = 6;

        public const int CRYPTNET_URL_CACHE_PRE_FETCH_PIN_RULES_CAB = 7;

        public const int CRYPTNET_URL_CACHE_DEFAULT_FLUSH = 0;

        public const uint CRYPTNET_URL_CACHE_DISABLE_FLUSH = 0xFFFFFFFF;

        public const int CRYPTNET_URL_CACHE_RESPONSE_NONE = 0;

        public const int CRYPTNET_URL_CACHE_RESPONSE_HTTP = 1;

        public const int CRYPTNET_URL_CACHE_RESPONSE_VALIDATED = 0x8000;

        public const int CRYPT_RETRIEVE_MAX_ERROR_CONTENT_LENGTH = 0x1000;

        public const int CRYPT_GET_URL_FROM_PROPERTY = 0x00000001;

        public const int CRYPT_GET_URL_FROM_EXTENSION = 0x00000002;

        public const int CRYPT_GET_URL_FROM_UNAUTH_ATTRIBUTE = 0x00000004;

        public const int CRYPT_GET_URL_FROM_AUTH_ATTRIBUTE = 0x00000008;

        // UrlDllGetObjectUrl
        public static ReadOnlySpan<sbyte> URL_OID_GET_OBJECT_URL_FUNC => new sbyte[] { 0x55, 0x72, 0x6C, 0x44, 0x6C, 0x6C, 0x47, 0x65, 0x74, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x55, 0x72, 0x6C, 0x00 };

        // TimeValidDllGetObject
        public static ReadOnlySpan<sbyte> TIME_VALID_OID_GET_OBJECT_FUNC => new sbyte[] { 0x54, 0x69, 0x6D, 0x65, 0x56, 0x61, 0x6C, 0x69, 0x64, 0x44, 0x6C, 0x6C, 0x47, 0x65, 0x74, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        // TimeValidDllFlushObject
        public static ReadOnlySpan<sbyte> TIME_VALID_OID_FLUSH_OBJECT_FUNC => new sbyte[] { 0x54, 0x69, 0x6D, 0x65, 0x56, 0x61, 0x6C, 0x69, 0x64, 0x44, 0x6C, 0x6C, 0x46, 0x6C, 0x75, 0x73, 0x68, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        public const int CERT_CREATE_SELFSIGN_NO_SIGN = 1;

        public const int CERT_CREATE_SELFSIGN_NO_KEY_INFO = 2;

        public const int CRYPT_KEYID_MACHINE_FLAG = 0x00000020;

        public const int CRYPT_KEYID_ALLOC_FLAG = 0x00008000;

        public const int CRYPT_KEYID_DELETE_FLAG = 0x00000010;

        public const int CRYPT_KEYID_SET_NEW_FLAG = 0x00002000;

        public const int CERT_CHAIN_MAX_AIA_URL_COUNT_IN_CERT_DEFAULT = 5;

        public const int CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_COUNT_PER_CHAIN_DEFAULT = 3;

        public const int CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_BYTE_COUNT_DEFAULT = 100000;

        public const int CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_CERT_COUNT_DEFAULT = 10;

        public const int CERT_CHAIN_MAX_SSL_TIME_UPDATED_EVENT_COUNT_DEFAULT = 5;

        public const uint CERT_CHAIN_MAX_SSL_TIME_UPDATED_EVENT_COUNT_DISABLE = 0xFFFFFFFF;

        public const int CERT_CHAIN_ENABLE_MD2_MD4_FLAG = 0x00000001;

        public const int CERT_CHAIN_ENABLE_WEAK_RSA_ROOT_FLAG = 0x00000002;

        public const int CERT_CHAIN_ENABLE_WEAK_LOGGING_FLAG = 0x00000004;

        public const int CERT_CHAIN_ENABLE_ONLY_WEAK_LOGGING_FLAG = 0x00000008;

        public const int CERT_CHAIN_MIN_RSA_PUB_KEY_BIT_LENGTH_DEFAULT = 1023;

        public const string CERT_CHAIN_DEFAULT_CONFIG_SUBDIR = "Default";

        public const string CERT_CHAIN_WEAK_PREFIX_NAME = "Weak";

        public const string CERT_CHAIN_WEAK_THIRD_PARTY_CONFIG_NAME = "ThirdParty";

        public const string CERT_CHAIN_WEAK_ALL_CONFIG_NAME = "All";

        public const string CERT_CHAIN_WEAK_FLAGS_NAME = "Flags";

        public const string CERT_CHAIN_WEAK_HYGIENE_NAME = "Hygiene";

        public const string CERT_CHAIN_WEAK_AFTER_TIME_NAME = "AfterTime";

        public const string CERT_CHAIN_WEAK_FILE_HASH_AFTER_TIME_NAME = "FileHashAfterTime";

        public const string CERT_CHAIN_WEAK_TIMESTAMP_HASH_AFTER_TIME_NAME = "TimestampHashAfterTime";

        public const string CERT_CHAIN_WEAK_MIN_BIT_LENGTH_NAME = "MinBitLength";

        public const string CERT_CHAIN_WEAK_SHA256_ALLOW_NAME = "Sha256Allow";

        public const uint CERT_CHAIN_ENABLE_WEAK_SETTINGS_FLAG = 0x80000000;

        public const int CERT_CHAIN_DISABLE_ALL_EKU_WEAK_FLAG = 0x00010000;

        public const int CERT_CHAIN_ENABLE_ALL_EKU_HYGIENE_FLAG = 0x00020000;

        public const int CERT_CHAIN_DISABLE_OPT_IN_SERVER_AUTH_WEAK_FLAG = 0x00040000;

        public const int CERT_CHAIN_DISABLE_SERVER_AUTH_WEAK_FLAG = 0x00100000;

        public const int CERT_CHAIN_ENABLE_SERVER_AUTH_HYGIENE_FLAG = 0x00200000;

        public const int CERT_CHAIN_DISABLE_CODE_SIGNING_WEAK_FLAG = 0x00400000;

        public const int CERT_CHAIN_DISABLE_MOTW_CODE_SIGNING_WEAK_FLAG = 0x00800000;

        public const int CERT_CHAIN_ENABLE_CODE_SIGNING_HYGIENE_FLAG = 0x01000000;

        public const int CERT_CHAIN_ENABLE_MOTW_CODE_SIGNING_HYGIENE_FLAG = 0x02000000;

        public const int CERT_CHAIN_DISABLE_TIMESTAMP_WEAK_FLAG = 0x04000000;

        public const int CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_WEAK_FLAG = 0x08000000;

        public const int CERT_CHAIN_ENABLE_TIMESTAMP_HYGIENE_FLAG = 0x10000000;

        public const int CERT_CHAIN_ENABLE_MOTW_TIMESTAMP_HYGIENE_FLAG = 0x20000000;

        public const int CERT_CHAIN_MOTW_IGNORE_AFTER_TIME_WEAK_FLAG = 0x40000000;

        public const int CERT_CHAIN_DISABLE_FILE_HASH_WEAK_FLAG = 0x00001000;

        public const int CERT_CHAIN_DISABLE_MOTW_FILE_HASH_WEAK_FLAG = 0x00002000;

        public const int CERT_CHAIN_DISABLE_TIMESTAMP_HASH_WEAK_FLAG = 0x00004000;

        public const int CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_HASH_WEAK_FLAG = 0x00008000;

        public const int CERT_CHAIN_AUTO_CURRENT_USER = 1;

        public const int CERT_CHAIN_AUTO_LOCAL_MACHINE = 2;

        public const int CERT_CHAIN_AUTO_IMPERSONATED = 3;

        public const int CERT_CHAIN_AUTO_PROCESS_INFO = 4;

        public const int CERT_CHAIN_AUTO_PINRULE_INFO = 5;

        public const int CERT_CHAIN_AUTO_NETWORK_INFO = 6;

        public const int CERT_CHAIN_AUTO_SERIAL_LOCAL_MACHINE = 7;

        public const int CERT_CHAIN_AUTO_HPKP_RULE_INFO = 8;

        public const int CERT_CHAIN_AUTO_FLUSH_DISABLE_FLAG = 0x00000001;

        public const int CERT_CHAIN_AUTO_LOG_CREATE_FLAG = 0x00000002;

        public const int CERT_CHAIN_AUTO_LOG_FREE_FLAG = 0x00000004;

        public const int CERT_CHAIN_AUTO_LOG_FLUSH_FLAG = 0x00000008;

        public const string CERT_RETR_BEHAVIOR_INET_AUTH_VALUE_NAME = "EnableInetUnknownAuth";

        public const string CERT_RETR_BEHAVIOR_INET_STATUS_VALUE_NAME = "EnableInetLocal";

        public const string CERT_RETR_BEHAVIOR_FILE_VALUE_NAME = "AllowFileUrlScheme";

        public const string CERT_RETR_BEHAVIOR_LDAP_VALUE_NAME = "DisableLDAPSignAndEncrypt";

        public const int CERT_CHAIN_OPTION_DISABLE_AIA_URL_RETRIEVAL = 0x2;

        public const int CERT_CHAIN_OPTION_ENABLE_SIA_URL_RETRIEVAL = 0x4;

        public const int CERT_CHAIN_CRL_VALIDITY_EXT_PERIOD_HOURS_DEFAULT = 12;

        public const int CERT_CHAIN_CACHE_END_CERT = 0x00000001;

        public const int CERT_CHAIN_THREAD_STORE_SYNC = 0x00000002;

        public const int CERT_CHAIN_CACHE_ONLY_URL_RETRIEVAL = 0x00000004;

        public const int CERT_CHAIN_USE_LOCAL_MACHINE_STORE = 0x00000008;

        public const int CERT_CHAIN_ENABLE_CACHE_AUTO_UPDATE = 0x00000010;

        public const int CERT_CHAIN_ENABLE_SHARE_STORE = 0x00000020;

        public const int CERT_CHAIN_EXCLUSIVE_ENABLE_CA_FLAG = 0x00000001;

        public const int CERT_TRUST_NO_ERROR = 0x00000000;

        public const int CERT_TRUST_IS_NOT_TIME_VALID = 0x00000001;

        public const int CERT_TRUST_IS_NOT_TIME_NESTED = 0x00000002;

        public const int CERT_TRUST_IS_REVOKED = 0x00000004;

        public const int CERT_TRUST_IS_NOT_SIGNATURE_VALID = 0x00000008;

        public const int CERT_TRUST_IS_NOT_VALID_FOR_USAGE = 0x00000010;

        public const int CERT_TRUST_IS_UNTRUSTED_ROOT = 0x00000020;

        public const int CERT_TRUST_REVOCATION_STATUS_UNKNOWN = 0x00000040;

        public const int CERT_TRUST_IS_CYCLIC = 0x00000080;

        public const int CERT_TRUST_INVALID_EXTENSION = 0x00000100;

        public const int CERT_TRUST_INVALID_POLICY_CONSTRAINTS = 0x00000200;

        public const int CERT_TRUST_INVALID_BASIC_CONSTRAINTS = 0x00000400;

        public const int CERT_TRUST_INVALID_NAME_CONSTRAINTS = 0x00000800;

        public const int CERT_TRUST_HAS_NOT_SUPPORTED_NAME_CONSTRAINT = 0x00001000;

        public const int CERT_TRUST_HAS_NOT_DEFINED_NAME_CONSTRAINT = 0x00002000;

        public const int CERT_TRUST_HAS_NOT_PERMITTED_NAME_CONSTRAINT = 0x00004000;

        public const int CERT_TRUST_HAS_EXCLUDED_NAME_CONSTRAINT = 0x00008000;

        public const int CERT_TRUST_IS_OFFLINE_REVOCATION = 0x01000000;

        public const int CERT_TRUST_NO_ISSUANCE_CHAIN_POLICY = 0x02000000;

        public const int CERT_TRUST_IS_EXPLICIT_DISTRUST = 0x04000000;

        public const int CERT_TRUST_HAS_NOT_SUPPORTED_CRITICAL_EXT = 0x08000000;

        public const int CERT_TRUST_HAS_WEAK_SIGNATURE = 0x00100000;

        public const int CERT_TRUST_HAS_WEAK_HYGIENE = 0x00200000;

        public const int CERT_TRUST_IS_PARTIAL_CHAIN = 0x00010000;

        public const int CERT_TRUST_CTL_IS_NOT_TIME_VALID = 0x00020000;

        public const int CERT_TRUST_CTL_IS_NOT_SIGNATURE_VALID = 0x00040000;

        public const int CERT_TRUST_CTL_IS_NOT_VALID_FOR_USAGE = 0x00080000;

        public const int CERT_TRUST_HAS_EXACT_MATCH_ISSUER = 0x00000001;

        public const int CERT_TRUST_HAS_KEY_MATCH_ISSUER = 0x00000002;

        public const int CERT_TRUST_HAS_NAME_MATCH_ISSUER = 0x00000004;

        public const int CERT_TRUST_IS_SELF_SIGNED = 0x00000008;

        public const int CERT_TRUST_AUTO_UPDATE_CA_REVOCATION = 0x00000010;

        public const int CERT_TRUST_AUTO_UPDATE_END_REVOCATION = 0x00000020;

        public const int CERT_TRUST_NO_OCSP_FAILOVER_TO_CRL = 0x00000040;

        public const int CERT_TRUST_IS_KEY_ROLLOVER = 0x00000080;

        public const int CERT_TRUST_SSL_HANDSHAKE_OCSP = 0x00040000;

        public const int CERT_TRUST_SSL_TIME_VALID_OCSP = 0x00080000;

        public const int CERT_TRUST_SSL_RECONNECT_OCSP = 0x00100000;

        public const int CERT_TRUST_HAS_PREFERRED_ISSUER = 0x00000100;

        public const int CERT_TRUST_HAS_ISSUANCE_CHAIN_POLICY = 0x00000200;

        public const int CERT_TRUST_HAS_VALID_NAME_CONSTRAINTS = 0x00000400;

        public const int CERT_TRUST_IS_PEER_TRUSTED = 0x00000800;

        public const int CERT_TRUST_HAS_CRL_VALIDITY_EXTENDED = 0x00001000;

        public const int CERT_TRUST_IS_FROM_EXCLUSIVE_TRUST_STORE = 0x00002000;

        public const int CERT_TRUST_IS_CA_TRUSTED = 0x00004000;

        public const int CERT_TRUST_HAS_AUTO_UPDATE_WEAK_SIGNATURE = 0x00008000;

        public const int CERT_TRUST_HAS_ALLOW_WEAK_SIGNATURE = 0x00020000;

        public const int CERT_TRUST_IS_COMPLEX_CHAIN = 0x00010000;

        public const int CERT_TRUST_SSL_TIME_VALID = 0x01000000;

        public const int CERT_TRUST_NO_TIME_CHECK = 0x02000000;

        public const int USAGE_MATCH_TYPE_AND = 0x00000000;

        public const int USAGE_MATCH_TYPE_OR = 0x00000001;

        public const int CERT_CHAIN_STRONG_SIGN_DISABLE_END_CHECK_FLAG = 0x00000001;

        public const int CERT_CHAIN_REVOCATION_CHECK_END_CERT = 0x10000000;

        public const int CERT_CHAIN_REVOCATION_CHECK_CHAIN = 0x20000000;

        public const int CERT_CHAIN_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x40000000;

        public const uint CERT_CHAIN_REVOCATION_CHECK_CACHE_ONLY = 0x80000000;

        public const int CERT_CHAIN_REVOCATION_ACCUMULATIVE_TIMEOUT = 0x08000000;

        public const int CERT_CHAIN_REVOCATION_CHECK_OCSP_CERT = 0x04000000;

        public const int CERT_CHAIN_DISABLE_PASS1_QUALITY_FILTERING = 0x00000040;

        public const int CERT_CHAIN_RETURN_LOWER_QUALITY_CONTEXTS = 0x00000080;

        public const int CERT_CHAIN_DISABLE_AUTH_ROOT_AUTO_UPDATE = 0x00000100;

        public const int CERT_CHAIN_TIMESTAMP_TIME = 0x00000200;

        public const int CERT_CHAIN_ENABLE_PEER_TRUST = 0x00000400;

        public const int CERT_CHAIN_DISABLE_MY_PEER_TRUST = 0x00000800;

        public const int CERT_CHAIN_DISABLE_MD2_MD4 = 0x00001000;

        public const int CERT_CHAIN_DISABLE_AIA = 0x00002000;

        public const int CERT_CHAIN_HAS_MOTW = 0x00004000;

        public const int CERT_CHAIN_ONLY_ADDITIONAL_AND_AUTH_ROOT = 0x00008000;

        public const int CERT_CHAIN_OPT_IN_WEAK_SIGNATURE = 0x00010000;

        public const int CERT_CHAIN_FIND_BY_ISSUER = 1;

        public const int CERT_CHAIN_FIND_BY_ISSUER_COMPARE_KEY_FLAG = 0x0001;

        public const int CERT_CHAIN_FIND_BY_ISSUER_COMPLEX_CHAIN_FLAG = 0x0002;

        public const int CERT_CHAIN_FIND_BY_ISSUER_CACHE_ONLY_URL_FLAG = 0x0004;

        public const int CERT_CHAIN_FIND_BY_ISSUER_LOCAL_MACHINE_FLAG = 0x0008;

        public const int CERT_CHAIN_FIND_BY_ISSUER_NO_KEY_FLAG = 0x4000;

        public const int CERT_CHAIN_FIND_BY_ISSUER_CACHE_ONLY_FLAG = 0x8000;

        public const int CERT_CHAIN_POLICY_IGNORE_NOT_TIME_VALID_FLAG = 0x00000001;

        public const int CERT_CHAIN_POLICY_IGNORE_CTL_NOT_TIME_VALID_FLAG = 0x00000002;

        public const int CERT_CHAIN_POLICY_IGNORE_NOT_TIME_NESTED_FLAG = 0x00000004;

        public const int CERT_CHAIN_POLICY_IGNORE_INVALID_BASIC_CONSTRAINTS_FLAG = 0x00000008;

        public const int CERT_CHAIN_POLICY_ALLOW_UNKNOWN_CA_FLAG = 0x00000010;

        public const int CERT_CHAIN_POLICY_IGNORE_WRONG_USAGE_FLAG = 0x00000020;

        public const int CERT_CHAIN_POLICY_IGNORE_INVALID_NAME_FLAG = 0x00000040;

        public const int CERT_CHAIN_POLICY_IGNORE_INVALID_POLICY_FLAG = 0x00000080;

        public const int CERT_CHAIN_POLICY_IGNORE_END_REV_UNKNOWN_FLAG = 0x00000100;

        public const int CERT_CHAIN_POLICY_IGNORE_CTL_SIGNER_REV_UNKNOWN_FLAG = 0x00000200;

        public const int CERT_CHAIN_POLICY_IGNORE_CA_REV_UNKNOWN_FLAG = 0x00000400;

        public const int CERT_CHAIN_POLICY_IGNORE_ROOT_REV_UNKNOWN_FLAG = 0x00000800;

        public const int CERT_CHAIN_POLICY_ALLOW_TESTROOT_FLAG = 0x00008000;

        public const int CERT_CHAIN_POLICY_TRUST_TESTROOT_FLAG = 0x00004000;

        public const int CERT_CHAIN_POLICY_IGNORE_NOT_SUPPORTED_CRITICAL_EXT_FLAG = 0x00002000;

        public const int CERT_CHAIN_POLICY_IGNORE_PEER_TRUST_FLAG = 0x00001000;

        public const int CERT_CHAIN_POLICY_IGNORE_WEAK_SIGNATURE_FLAG = 0x08000000;

        public const int AUTHTYPE_CLIENT = 1;

        public const int AUTHTYPE_SERVER = 2;

        public const uint BASIC_CONSTRAINTS_CERT_CHAIN_POLICY_CA_FLAG = 0x80000000;

        public const int BASIC_CONSTRAINTS_CERT_CHAIN_POLICY_END_ENTITY_FLAG = 0x40000000;

        public const int MICROSOFT_ROOT_CERT_CHAIN_POLICY_ENABLE_TEST_ROOT_FLAG = 0x00010000;

        public const int MICROSOFT_ROOT_CERT_CHAIN_POLICY_CHECK_APPLICATION_ROOT_FLAG = 0x00020000;

        public const int MICROSOFT_ROOT_CERT_CHAIN_POLICY_DISABLE_FLIGHT_ROOT_FLAG = 0x00040000;

        public const int SSL_F12_ERROR_TEXT_LENGTH = 256;

        public const int CERT_CHAIN_POLICY_SSL_F12_SUCCESS_LEVEL = 0;

        public const int CERT_CHAIN_POLICY_SSL_F12_WARNING_LEVEL = 1;

        public const int CERT_CHAIN_POLICY_SSL_F12_ERROR_LEVEL = 2;

        public const int CERT_CHAIN_POLICY_SSL_F12_NONE_CATEGORY = 0;

        public const int CERT_CHAIN_POLICY_SSL_F12_WEAK_CRYPTO_CATEGORY = 1;

        public const int CERT_CHAIN_POLICY_SSL_F12_ROOT_PROGRAM_CATEGORY = 2;

        public const int SSL_HPKP_PKP_HEADER_INDEX = 0;

        public const int SSL_HPKP_PKP_RO_HEADER_INDEX = 1;

        public const int SSL_HPKP_HEADER_COUNT = 2;

        public const int SSL_KEY_PIN_ERROR_TEXT_LENGTH = 512;

        public const int CERT_CHAIN_POLICY_SSL_KEY_PIN_MISMATCH_ERROR = -2;

        public const int CERT_CHAIN_POLICY_SSL_KEY_PIN_MITM_ERROR = -1;

        public const int CERT_CHAIN_POLICY_SSL_KEY_PIN_SUCCESS = 0;

        public const int CERT_CHAIN_POLICY_SSL_KEY_PIN_MITM_WARNING = 1;

        public const int CERT_CHAIN_POLICY_SSL_KEY_PIN_MISMATCH_WARNING = 2;

        public const int CRYPT_STRING_BASE64HEADER = 0x00000000;

        public const int CRYPT_STRING_BASE64 = 0x00000001;

        public const int CRYPT_STRING_BINARY = 0x00000002;

        public const int CRYPT_STRING_BASE64REQUESTHEADER = 0x00000003;

        public const int CRYPT_STRING_HEX = 0x00000004;

        public const int CRYPT_STRING_HEXASCII = 0x00000005;

        public const int CRYPT_STRING_BASE64_ANY = 0x00000006;

        public const int CRYPT_STRING_ANY = 0x00000007;

        public const int CRYPT_STRING_HEX_ANY = 0x00000008;

        public const int CRYPT_STRING_BASE64X509CRLHEADER = 0x00000009;

        public const int CRYPT_STRING_HEXADDR = 0x0000000A;

        public const int CRYPT_STRING_HEXASCIIADDR = 0x0000000B;

        public const int CRYPT_STRING_HEXRAW = 0x0000000C;

        public const int CRYPT_STRING_BASE64URI = 0x0000000D;

        public const int CRYPT_STRING_ENCODEMASK = 0x000000FF;

        public const int CRYPT_STRING_RESERVED100 = 0x00000100;

        public const int CRYPT_STRING_RESERVED200 = 0x00000200;

        public const int CRYPT_STRING_PERCENTESCAPE = 0x08000000;

        public const int CRYPT_STRING_HASHDATA = 0x10000000;

        public const int CRYPT_STRING_STRICT = 0x20000000;

        public const int CRYPT_STRING_NOCRLF = 0x40000000;

        public const uint CRYPT_STRING_NOCR = 0x80000000;

        // 1.2.840.113549.1.12.1
        public static ReadOnlySpan<sbyte> szOID_PKCS_12_PbeIds => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x00 };

        // 1.2.840.113549.1.12.1.1
        public static ReadOnlySpan<sbyte> szOID_PKCS_12_pbeWithSHA1And128BitRC4 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        // 1.2.840.113549.1.12.1.2
        public static ReadOnlySpan<sbyte> szOID_PKCS_12_pbeWithSHA1And40BitRC4 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        // 1.2.840.113549.1.12.1.3
        public static ReadOnlySpan<sbyte> szOID_PKCS_12_pbeWithSHA1And3KeyTripleDES => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        // 1.2.840.113549.1.12.1.4
        public static ReadOnlySpan<sbyte> szOID_PKCS_12_pbeWithSHA1And2KeyTripleDES => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        // 1.2.840.113549.1.12.1.5
        public static ReadOnlySpan<sbyte> szOID_PKCS_12_pbeWithSHA1And128BitRC2 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        // 1.2.840.113549.1.12.1.6
        public static ReadOnlySpan<sbyte> szOID_PKCS_12_pbeWithSHA1And40BitRC2 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x2E, 0x36, 0x00 };

        // 1.2.840.113549.1.5.12
        public static ReadOnlySpan<sbyte> szOID_PKCS_5_PBKDF2 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x31, 0x32, 0x00 };

        // 1.2.840.113549.1.5.13
        public static ReadOnlySpan<sbyte> szOID_PKCS_5_PBES2 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x31, 0x33, 0x00 };

        public const int PKCS12_IMPORT_SILENT = 0x00000040;

        public const int CRYPT_USER_KEYSET = 0x00001000;

        public const int PKCS12_PREFER_CNG_KSP = 0x00000100;

        public const int PKCS12_ALWAYS_CNG_KSP = 0x00000200;

        public const int PKCS12_ONLY_CERTIFICATES = 0x00000400;

        public const int PKCS12_ONLY_NOT_ENCRYPTED_CERTIFICATES = 0x00000800;

        public const int PKCS12_ALLOW_OVERWRITE_KEY = 0x00004000;

        public const int PKCS12_NO_PERSIST_KEY = 0x00008000;

        public const int PKCS12_VIRTUAL_ISOLATION_KEY = 0x00010000;

        public const uint PKCS12_IMPORT_RESERVED_MASK = 0xFFFF0000;

        public const int PKCS12_ONLY_CERTIFICATES_PROVIDER_TYPE = 0;

        public const string PKCS12_ONLY_CERTIFICATES_PROVIDER_NAME = "PfxProvider";

        public const string PKCS12_ONLY_CERTIFICATES_CONTAINER_NAME = "PfxContainer";

        public const int REPORT_NO_PRIVATE_KEY = 0x0001;

        public const int REPORT_NOT_ABLE_TO_EXPORT_PRIVATE_KEY = 0x0002;

        public const int EXPORT_PRIVATE_KEYS = 0x0004;

        public const int PKCS12_INCLUDE_EXTENDED_PROPERTIES = 0x0010;

        public const int PKCS12_PROTECT_TO_DOMAIN_SIDS = 0x0020;

        public const int PKCS12_EXPORT_SILENT = 0x0040;

        public const int PKCS12_EXPORT_PBES2_PARAMS = 0x0080;

        public const int PKCS12_DISABLE_ENCRYPT_CERTIFICATES = 0x0100;

        public const int PKCS12_ENCRYPT_CERTIFICATES = 0x0200;

        public const int PKCS12_EXPORT_ECC_CURVE_PARAMETERS = 0x1000;

        public const int PKCS12_EXPORT_ECC_CURVE_OID = 0x2000;

        public const uint PKCS12_EXPORT_RESERVED_MASK = 0xFFFF0000;

        // 1.2.840.113549.2.7
        public static ReadOnlySpan<sbyte> PKCS12_PBKDF2_ID_HMAC_SHA1 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x2E, 0x37, 0x00 };

        // 1.2.840.113549.2.9
        public static ReadOnlySpan<sbyte> PKCS12_PBKDF2_ID_HMAC_SHA256 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x2E, 0x39, 0x00 };

        // 1.2.840.113549.2.10
        public static ReadOnlySpan<sbyte> PKCS12_PBKDF2_ID_HMAC_SHA384 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x2E, 0x31, 0x30, 0x00 };

        // 1.2.840.113549.2.11
        public static ReadOnlySpan<sbyte> PKCS12_PBKDF2_ID_HMAC_SHA512 => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x2E, 0x31, 0x31, 0x00 };

        public const string PKCS12_PBES2_ALG_AES256_SHA256 = "AES256-SHA256";

        public const int CERT_SERVER_OCSP_RESPONSE_OPEN_PARA_READ_FLAG = 0x00000001;

        public const int CERT_SERVER_OCSP_RESPONSE_OPEN_PARA_WRITE_FLAG = 0x00000002;

        public const int CERT_SERVER_OCSP_RESPONSE_ASYNC_FLAG = 0x00000001;

        public const int CERT_SELECT_MAX_PARA = 500;

        public const int CERT_SELECT_BY_ENHKEY_USAGE = 1;

        public const int CERT_SELECT_BY_KEY_USAGE = 2;

        public const int CERT_SELECT_BY_POLICY_OID = 3;

        public const int CERT_SELECT_BY_PROV_NAME = 4;

        public const int CERT_SELECT_BY_EXTENSION = 5;

        public const int CERT_SELECT_BY_SUBJECT_HOST_NAME = 6;

        public const int CERT_SELECT_BY_ISSUER_ATTR = 7;

        public const int CERT_SELECT_BY_SUBJECT_ATTR = 8;

        public const int CERT_SELECT_BY_ISSUER_NAME = 9;

        public const int CERT_SELECT_BY_PUBLIC_KEY = 10;

        public const int CERT_SELECT_BY_TLS_SIGNATURES = 11;

        public const int CERT_SELECT_BY_ISSUER_DISPLAYNAME = 12;

        public const int CERT_SELECT_BY_FRIENDLYNAME = 13;

        public const int CERT_SELECT_BY_THUMBPRINT = 14;

        public const int CERT_SELECT_ALLOW_EXPIRED = 0x00000001;

        public const int CERT_SELECT_TRUSTED_ROOT = 0x00000002;

        public const int CERT_SELECT_DISALLOW_SELFSIGNED = 0x00000004;

        public const int CERT_SELECT_HAS_PRIVATE_KEY = 0x00000008;

        public const int CERT_SELECT_HAS_KEY_FOR_SIGNATURE = 0x00000010;

        public const int CERT_SELECT_HAS_KEY_FOR_KEY_EXCHANGE = 0x00000020;

        public const int CERT_SELECT_HARDWARE_ONLY = 0x00000040;

        public const int CERT_SELECT_ALLOW_DUPLICATES = 0x00000080;

        public const int CERT_SELECT_IGNORE_AUTOSELECT = 0x00000100;

        public const int TIMESTAMP_VERSION = 1;

        public const int TIMESTAMP_STATUS_GRANTED = 0;

        public const int TIMESTAMP_STATUS_GRANTED_WITH_MODS = 1;

        public const int TIMESTAMP_STATUS_REJECTED = 2;

        public const int TIMESTAMP_STATUS_WAITING = 3;

        public const int TIMESTAMP_STATUS_REVOCATION_WARNING = 4;

        public const int TIMESTAMP_STATUS_REVOKED = 5;

        public const int TIMESTAMP_FAILURE_BAD_ALG = 0;

        public const int TIMESTAMP_FAILURE_BAD_REQUEST = 2;

        public const int TIMESTAMP_FAILURE_BAD_FORMAT = 5;

        public const int TIMESTAMP_FAILURE_TIME_NOT_AVAILABLE = 14;

        public const int TIMESTAMP_FAILURE_POLICY_NOT_SUPPORTED = 15;

        public const int TIMESTAMP_FAILURE_EXTENSION_NOT_SUPPORTED = 16;

        public const int TIMESTAMP_FAILURE_INFO_NOT_AVAILABLE = 17;

        public const int TIMESTAMP_FAILURE_SYSTEM_FAILURE = 25;

        public const int TIMESTAMP_DONT_HASH_DATA = 0x00000001;

        public const int TIMESTAMP_VERIFY_CONTEXT_SIGNATURE = 0x00000020;

        public const int TIMESTAMP_NO_AUTH_RETRIEVAL = 0x00020000;

        public const int CRYPT_OBJECT_LOCATOR_SPN_NAME_TYPE = 1;

        public const int CRYPT_OBJECT_LOCATOR_LAST_RESERVED_NAME_TYPE = 32;

        public const int CRYPT_OBJECT_LOCATOR_FIRST_RESERVED_USER_NAME_TYPE = 33;

        public const int CRYPT_OBJECT_LOCATOR_LAST_RESERVED_USER_NAME_TYPE = 0x0000FFFF;

        // SslObjectLocatorInitializePfx
        public static ReadOnlySpan<sbyte> SSL_OBJECT_LOCATOR_PFX_FUNC => new sbyte[] { 0x53, 0x73, 0x6C, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x4C, 0x6F, 0x63, 0x61, 0x74, 0x6F, 0x72, 0x49, 0x6E, 0x69, 0x74, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x50, 0x66, 0x78, 0x00 };

        // SslObjectLocatorInitializeIssuerList
        public static ReadOnlySpan<sbyte> SSL_OBJECT_LOCATOR_ISSUER_LIST_FUNC => new sbyte[] { 0x53, 0x73, 0x6C, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x4C, 0x6F, 0x63, 0x61, 0x74, 0x6F, 0x72, 0x49, 0x6E, 0x69, 0x74, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x49, 0x73, 0x73, 0x75, 0x65, 0x72, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        // SslObjectLocatorInitializeCertValidationConfig
        public static ReadOnlySpan<sbyte> SSL_OBJECT_LOCATOR_CERT_VALIDATION_CONFIG_FUNC => new sbyte[] { 0x53, 0x73, 0x6C, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x4C, 0x6F, 0x63, 0x61, 0x74, 0x6F, 0x72, 0x49, 0x6E, 0x69, 0x74, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x43, 0x65, 0x72, 0x74, 0x56, 0x61, 0x6C, 0x69, 0x64, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x43, 0x6F, 0x6E, 0x66, 0x69, 0x67, 0x00 };

        public const int CRYPT_OBJECT_LOCATOR_RELEASE_SYSTEM_SHUTDOWN = 1;

        public const int CRYPT_OBJECT_LOCATOR_RELEASE_SERVICE_STOP = 2;

        public const int CRYPT_OBJECT_LOCATOR_RELEASE_PROCESS_EXIT = 3;

        public const int CRYPT_OBJECT_LOCATOR_RELEASE_DLL_UNLOAD = 4;

        public const int CERT_FILE_HASH_USE_TYPE = 1;

        public const int CERT_TIMESTAMP_HASH_USE_TYPE = 2;

        public const int ALG_CLASS_ANY = 0;

        public const int ALG_CLASS_SIGNATURE = 1 << 13;

        public const int ALG_CLASS_MSG_ENCRYPT = 2 << 13;

        public const int ALG_CLASS_DATA_ENCRYPT = 3 << 13;

        public const int ALG_CLASS_HASH = 4 << 13;

        public const int ALG_CLASS_KEY_EXCHANGE = 5 << 13;

        public const int ALG_CLASS_ALL = 7 << 13;

        public const int ALG_TYPE_ANY = 0;

        public const int ALG_TYPE_DSS = 1 << 9;

        public const int ALG_TYPE_RSA = 2 << 9;

        public const int ALG_TYPE_BLOCK = 3 << 9;

        public const int ALG_TYPE_STREAM = 4 << 9;

        public const int ALG_TYPE_DH = 5 << 9;

        public const int ALG_TYPE_SECURECHANNEL = 6 << 9;

        public const int ALG_TYPE_ECDH = 7 << 9;

        public const int ALG_TYPE_THIRDPARTY = 8 << 9;

        public const int ALG_SID_ANY = 0;

        public const int ALG_SID_THIRDPARTY_ANY = 0;

        public const int CALG_MD2 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MD2;

        public const int CALG_MD4 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MD4;

        public const int CALG_MD5 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MD5;

        public const int CALG_SHA = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA;

        public const int CALG_SHA1 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA1;

        public const int CALG_MAC = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MAC;

        public const int CALG_RSA_SIGN = ALG_CLASS_SIGNATURE | ALG_TYPE_RSA | ALG_SID_RSA_ANY;

        public const int CALG_DSS_SIGN = ALG_CLASS_SIGNATURE | ALG_TYPE_DSS | ALG_SID_DSS_ANY;

        public const int CALG_NO_SIGN = ALG_CLASS_SIGNATURE | ALG_TYPE_ANY | ALG_SID_ANY;

        public const int CALG_RSA_KEYX = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_RSA | ALG_SID_RSA_ANY;

        public const int CALG_DES = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_DES;

        public const int CALG_3DES_112 = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_3DES_112;

        public const int CALG_3DES = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_3DES;

        public const int CALG_DESX = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_DESX;

        public const int CALG_RC2 = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_RC2;

        public const int CALG_RC4 = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_STREAM | ALG_SID_RC4;

        public const int CALG_SEAL = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_STREAM | ALG_SID_SEAL;

        public const int CALG_DH_SF = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_DH | ALG_SID_DH_SANDF;

        public const int CALG_DH_EPHEM = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_DH | ALG_SID_DH_EPHEM;

        public const int CALG_AGREEDKEY_ANY = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_DH | ALG_SID_AGREED_KEY_ANY;

        public const int CALG_KEA_KEYX = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_DH | ALG_SID_KEA;

        public const int CALG_HUGHES_MD5 = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_ANY | ALG_SID_MD5;

        public const int CALG_SKIPJACK = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_SKIPJACK;

        public const int CALG_TEK = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_TEK;

        public const int CALG_CYLINK_MEK = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_CYLINK_MEK;

        public const int CALG_SSL3_SHAMD5 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SSL3SHAMD5;

        public const int CALG_SSL3_MASTER = ALG_CLASS_MSG_ENCRYPT | ALG_TYPE_SECURECHANNEL | ALG_SID_SSL3_MASTER;

        public const int CALG_SCHANNEL_MASTER_HASH = ALG_CLASS_MSG_ENCRYPT | ALG_TYPE_SECURECHANNEL | ALG_SID_SCHANNEL_MASTER_HASH;

        public const int CALG_SCHANNEL_MAC_KEY = ALG_CLASS_MSG_ENCRYPT | ALG_TYPE_SECURECHANNEL | ALG_SID_SCHANNEL_MAC_KEY;

        public const int CALG_SCHANNEL_ENC_KEY = ALG_CLASS_MSG_ENCRYPT | ALG_TYPE_SECURECHANNEL | ALG_SID_SCHANNEL_ENC_KEY;

        public const int CALG_PCT1_MASTER = ALG_CLASS_MSG_ENCRYPT | ALG_TYPE_SECURECHANNEL | ALG_SID_PCT1_MASTER;

        public const int CALG_SSL2_MASTER = ALG_CLASS_MSG_ENCRYPT | ALG_TYPE_SECURECHANNEL | ALG_SID_SSL2_MASTER;

        public const int CALG_TLS1_MASTER = ALG_CLASS_MSG_ENCRYPT | ALG_TYPE_SECURECHANNEL | ALG_SID_TLS1_MASTER;

        public const int CALG_RC5 = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_RC5;

        public const int CALG_HMAC = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_HMAC;

        public const int CALG_TLS1PRF = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_TLS1PRF;

        public const int CALG_HASH_REPLACE_OWF = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_HASH_REPLACE_OWF;

        public const int CALG_AES_128 = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_AES_128;

        public const int CALG_AES_192 = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_AES_192;

        public const int CALG_AES_256 = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_AES_256;

        public const int CALG_AES = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_AES;

        public const int CALG_SHA_256 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA_256;

        public const int CALG_SHA_384 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA_384;

        public const int CALG_SHA_512 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA_512;

        public const int CALG_ECDH = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_DH | ALG_SID_ECDH;

        public const int CALG_ECDH_EPHEM = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_ECDH | ALG_SID_ECDH_EPHEM;

        public const int CALG_ECMQV = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_ANY | ALG_SID_ECMQV;

        public const int CALG_ECDSA = ALG_CLASS_SIGNATURE | ALG_TYPE_DSS | ALG_SID_ECDSA;

        public const int CALG_NULLCIPHER = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_ANY | 0;

        public const int CALG_THIRDPARTY_KEY_EXCHANGE = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY;

        public const int CALG_THIRDPARTY_SIGNATURE = ALG_CLASS_SIGNATURE | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY;

        public const int CALG_THIRDPARTY_CIPHER = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY;

        public const int CALG_THIRDPARTY_HASH = ALG_CLASS_HASH | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY;

        public const int CRYPT_FAILED = FALSE;

        public const int CRYPT_SUCCEED = TRUE;

        // Software\Policies\Microsoft\Cryptography
        public static ReadOnlySpan<sbyte> szKEY_CRYPTOAPI_PRIVATE_KEY_OPTIONS => new sbyte[] { 0x53, 0x6F, 0x66, 0x74, 0x77, 0x61, 0x72, 0x65, 0x5C, 0x50, 0x6F, 0x6C, 0x69, 0x63, 0x69, 0x65, 0x73, 0x5C, 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x5C, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x79, 0x00 };

        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_NISTP256 => szOID_ECC_CURVE_P256;

        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_NISTP384 => szOID_ECC_CURVE_P384;

        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_NISTP521 => szOID_ECC_CURVE_P521;

        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_SECP192R1 => szOID_ECC_CURVE_NISTP192;

        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_SECP224R1 => szOID_ECC_CURVE_NISTP224;

        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_SECP256R1 => szOID_ECC_CURVE_P256;

        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_SECP384R1 => szOID_ECC_CURVE_P384;

        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_SECP521R1 => szOID_ECC_CURVE_P521;

        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_WTLS7 => szOID_ECC_CURVE_SECP160R2;

        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_WTLS12 => szOID_ECC_CURVE_NISTP224;

        public static ReadOnlySpan<sbyte> szOID_ECC_CURVE_X962P256V1 => szOID_ECC_CURVE_P256;

        public static ReadOnlySpan<sbyte> CERT_RSA_PUBLIC_KEY_OBJID => szOID_RSA_RSA;

        public static ReadOnlySpan<sbyte> CERT_DEFAULT_OID_PUBLIC_KEY_SIGN => szOID_RSA_RSA;

        public static ReadOnlySpan<sbyte> CERT_DEFAULT_OID_PUBLIC_KEY_XCHG => szOID_RSA_RSA;

        public const int CRYPT_FORMAT_SEMICOLON = CRYPT_FORMAT_RDN_SEMICOLON;

        public const int CRYPT_FORMAT_CRLF = CRYPT_FORMAT_RDN_CRLF;

        public const uint CRYPT_UNICODE_NAME_ENCODE_ENABLE_T61_UNICODE_FLAG = CERT_RDN_ENABLE_T61_UNICODE_FLAG;

        public const int CRYPT_UNICODE_NAME_ENCODE_ENABLE_UTF8_UNICODE_FLAG = CERT_RDN_ENABLE_UTF8_UNICODE_FLAG;

        public const int CRYPT_UNICODE_NAME_ENCODE_FORCE_UTF8_UNICODE_FLAG = CERT_RDN_FORCE_UTF8_UNICODE_FLAG;

        public const int CRYPT_UNICODE_NAME_ENCODE_DISABLE_CHECK_TYPE_FLAG = CERT_RDN_DISABLE_CHECK_TYPE_FLAG;

        public const int CRYPT_UNICODE_NAME_DECODE_DISABLE_IE4_UTF8_FLAG = CERT_RDN_DISABLE_IE4_UTF8_FLAG;

        public const int CRYPT_ENCODE_ENABLE_IA5CONVERSION_FLAG = CRYPT_ENCODE_ENABLE_PUNYCODE_FLAG | CRYPT_ENCODE_ENABLE_UTF8PERCENT_FLAG;

        public const int CRYPT_DECODE_ENABLE_IA5CONVERSION_FLAG = CRYPT_DECODE_ENABLE_PUNYCODE_FLAG | CRYPT_DECODE_ENABLE_UTF8PERCENT_FLAG;

        // ((LPCSTR) 1)
        public const int X509_CERT = 1;

        // ((LPCSTR) 2)
        public const int X509_CERT_TO_BE_SIGNED = 2;

        // ((LPCSTR) 3)
        public const int X509_CERT_CRL_TO_BE_SIGNED = 3;

        // ((LPCSTR) 4)
        public const int X509_CERT_REQUEST_TO_BE_SIGNED = 4;

        // ((LPCSTR) 5)
        public const int X509_EXTENSIONS = 5;

        // ((LPCSTR) 6)
        public const int X509_NAME_VALUE = 6;

        // ((LPCSTR) 7)
        public const int X509_NAME = 7;

        // ((LPCSTR) 8)
        public const int X509_PUBLIC_KEY_INFO = 8;

        // ((LPCSTR) 9)
        public const int X509_AUTHORITY_KEY_ID = 9;

        // ((LPCSTR) 10)
        public const int X509_KEY_ATTRIBUTES = 10;

        // ((LPCSTR) 11)
        public const int X509_KEY_USAGE_RESTRICTION = 11;

        // ((LPCSTR) 12)
        public const int X509_ALTERNATE_NAME = 12;

        // ((LPCSTR) 13)
        public const int X509_BASIC_CONSTRAINTS = 13;

        // ((LPCSTR) 14)
        public const int X509_KEY_USAGE = 14;

        // ((LPCSTR) 15)
        public const int X509_BASIC_CONSTRAINTS2 = 15;

        // ((LPCSTR) 16)
        public const int X509_CERT_POLICIES = 16;

        // ((LPCSTR) 17)
        public const int PKCS_UTC_TIME = 17;

        // ((LPCSTR) 18)
        public const int PKCS_TIME_REQUEST = 18;

        // ((LPCSTR) 19)
        public const int RSA_CSP_PUBLICKEYBLOB = 19;

        // ((LPCSTR) 20)
        public const int X509_UNICODE_NAME = 20;

        // ((LPCSTR) 21)
        public const int X509_KEYGEN_REQUEST_TO_BE_SIGNED = 21;

        // ((LPCSTR) 22)
        public const int PKCS_ATTRIBUTE = 22;

        // ((LPCSTR) 23)
        public const int PKCS_CONTENT_INFO_SEQUENCE_OF_ANY = 23;

        // ((LPCSTR) 24)
        public const int X509_UNICODE_NAME_VALUE = 24;

        public const int X509_ANY_STRING = X509_NAME_VALUE;

        public const int X509_UNICODE_ANY_STRING = X509_UNICODE_NAME_VALUE;

        // ((LPCSTR) 25)
        public const int X509_OCTET_STRING = 25;

        // ((LPCSTR) 26)
        public const int X509_BITS = 26;

        // ((LPCSTR) 27)
        public const int X509_INTEGER = 27;

        // ((LPCSTR) 28)
        public const int X509_MULTI_BYTE_INTEGER = 28;

        // ((LPCSTR) 29)
        public const int X509_ENUMERATED = 29;

        // ((LPCSTR) 30)
        public const int X509_CHOICE_OF_TIME = 30;

        // ((LPCSTR) 31)
        public const int X509_AUTHORITY_KEY_ID2 = 31;

        // ((LPCSTR) 32)
        public const int X509_AUTHORITY_INFO_ACCESS = 32;

        public const int X509_SUBJECT_INFO_ACCESS = X509_AUTHORITY_INFO_ACCESS;

        public const int X509_CRL_REASON_CODE = X509_ENUMERATED;

        // ((LPCSTR) 33)
        public const int PKCS_CONTENT_INFO = 33;

        // ((LPCSTR) 34)
        public const int X509_SEQUENCE_OF_ANY = 34;

        // ((LPCSTR) 35)
        public const int X509_CRL_DIST_POINTS = 35;

        // ((LPCSTR) 36)
        public const int X509_ENHANCED_KEY_USAGE = 36;

        // ((LPCSTR) 37)
        public const int PKCS_CTL = 37;

        // ((LPCSTR) 38)
        public const int X509_MULTI_BYTE_UINT = 38;

        public const int X509_DSS_PUBLICKEY = X509_MULTI_BYTE_UINT;

        // ((LPCSTR) 39)
        public const int X509_DSS_PARAMETERS = 39;

        // ((LPCSTR) 40)
        public const int X509_DSS_SIGNATURE = 40;

        // ((LPCSTR) 41)
        public const int PKCS_RC2_CBC_PARAMETERS = 41;

        // ((LPCSTR) 42)
        public const int PKCS_SMIME_CAPABILITIES = 42;

        // ((LPCSTR) 42)
        public const int X509_QC_STATEMENTS_EXT = 42;

        // ((LPCSTR) 43)
        public const int PKCS_RSA_PRIVATE_KEY = 43;

        // ((LPCSTR) 44)
        public const int PKCS_PRIVATE_KEY_INFO = 44;

        // ((LPCSTR) 45)
        public const int PKCS_ENCRYPTED_PRIVATE_KEY_INFO = 45;

        // ((LPCSTR) 46)
        public const int X509_PKIX_POLICY_QUALIFIER_USERNOTICE = 46;

        public const int X509_DH_PUBLICKEY = X509_MULTI_BYTE_UINT;

        // ((LPCSTR) 47)
        public const int X509_DH_PARAMETERS = 47;

        // ((LPCSTR) 48)
        public const int PKCS_ATTRIBUTES = 48;

        // ((LPCSTR) 49)
        public const int PKCS_SORTED_CTL = 49;

        // ((LPCSTR) 47)
        public const int X509_ECC_SIGNATURE = 47;

        // ((LPCSTR) 50)
        public const int X942_DH_PARAMETERS = 50;

        // ((LPCSTR) 51)
        public const int X509_BITS_WITHOUT_TRAILING_ZEROES = 51;

        // ((LPCSTR) 52)
        public const int X942_OTHER_INFO = 52;

        // ((LPCSTR) 53)
        public const int X509_CERT_PAIR = 53;

        // ((LPCSTR) 54)
        public const int X509_ISSUING_DIST_POINT = 54;

        // ((LPCSTR) 55)
        public const int X509_NAME_CONSTRAINTS = 55;

        // ((LPCSTR) 56)
        public const int X509_POLICY_MAPPINGS = 56;

        // ((LPCSTR) 57)
        public const int X509_POLICY_CONSTRAINTS = 57;

        // ((LPCSTR) 58)
        public const int X509_CROSS_CERT_DIST_POINTS = 58;

        // ((LPCSTR) 59)
        public const int CMC_DATA = 59;

        // ((LPCSTR) 60)
        public const int CMC_RESPONSE = 60;

        // ((LPCSTR) 61)
        public const int CMC_STATUS = 61;

        // ((LPCSTR) 62)
        public const int CMC_ADD_EXTENSIONS = 62;

        // ((LPCSTR) 63)
        public const int CMC_ADD_ATTRIBUTES = 63;

        // ((LPCSTR) 64)
        public const int X509_CERTIFICATE_TEMPLATE = 64;

        // ((LPCSTR) 65)
        public const int OCSP_SIGNED_REQUEST = 65;

        // ((LPCSTR) 66)
        public const int OCSP_REQUEST = 66;

        // ((LPCSTR) 67)
        public const int OCSP_RESPONSE = 67;

        // ((LPCSTR) 68)
        public const int OCSP_BASIC_SIGNED_RESPONSE = 68;

        // ((LPCSTR) 69)
        public const int OCSP_BASIC_RESPONSE = 69;

        // ((LPCSTR) 70)
        public const int X509_LOGOTYPE_EXT = 70;

        // ((LPCSTR) 71)
        public const int X509_BIOMETRIC_EXT = 71;

        // ((LPCSTR) 72)
        public const int CNG_RSA_PUBLIC_KEY_BLOB = 72;

        // ((LPCSTR) 73)
        public const int X509_OBJECT_IDENTIFIER = 73;

        // ((LPCSTR) 74)
        public const int X509_ALGORITHM_IDENTIFIER = 74;

        // ((LPCSTR) 75)
        public const int PKCS_RSA_SSA_PSS_PARAMETERS = 75;

        // ((LPCSTR) 76)
        public const int PKCS_RSAES_OAEP_PARAMETERS = 76;

        // ((LPCSTR) 77)
        public const int ECC_CMS_SHARED_INFO = 77;

        // ((LPCSTR) 78)
        public const int TIMESTAMP_REQUEST = 78;

        // ((LPCSTR) 79)
        public const int TIMESTAMP_RESPONSE = 79;

        // ((LPCSTR) 80)
        public const int TIMESTAMP_INFO = 80;

        // ((LPCSTR) 81)
        public const int X509_CERT_BUNDLE = 81;

        // ((LPCSTR) 82)
        public const int X509_ECC_PRIVATE_KEY = 82;

        // ((LPCSTR) 83)
        public const int CNG_RSA_PRIVATE_KEY_BLOB = 83;

        // ((LPCSTR) 84)
        public const int X509_SUBJECT_DIR_ATTRS = 84;

        // ((LPCSTR) 85)
        public const int X509_ECC_PARAMETERS = 85;

        // ((LPCSTR) 500)
        public const int PKCS7_SIGNER_INFO = 500;

        // ((LPCSTR) 501)
        public const int CMS_SIGNER_INFO = 501;

        public const int SORTED_CTL_EXT_FLAGS_OFFSET = 0 * 4;

        public const int SORTED_CTL_EXT_COUNT_OFFSET = 1 * 4;

        public const int SORTED_CTL_EXT_MAX_COLLISION_OFFSET = 2 * 4;

        public const int SORTED_CTL_EXT_HASH_BUCKET_OFFSET = 3 * 4;

        public const int CERT_DSS_SIGNATURE_LEN = CERT_DSS_R_LEN + CERT_DSS_S_LEN;

        public const int CERT_MAX_ASN_ENCODED_DSS_SIGNATURE_LEN = 2 + (2 * (2 + 20 + 1));

        public const int CRYPT_X942_PUB_INFO_BYTE_LENGTH = 512 / 8;

        public const int CRYPT_FIRST_ALG_OID_GROUP_ID = CRYPT_HASH_ALG_OID_GROUP_ID;

        public const int CRYPT_LAST_ALG_OID_GROUP_ID = CRYPT_SIGN_ALG_OID_GROUP_ID;

        public static ReadOnlySpan<sbyte> szOID_CERT_STRONG_SIGN_OS_CURRENT => szOID_CERT_STRONG_SIGN_OS_1;

        public static ReadOnlySpan<sbyte> szOID_CERT_STRONG_KEY_OS_CURRENT => szOID_CERT_STRONG_KEY_OS_1;

        public const uint CMSG_ALL_FLAGS = ~0U;

        public const int CMSG_DATA_FLAG = 1 << CMSG_DATA;

        public const int CMSG_SIGNED_FLAG = 1 << CMSG_SIGNED;

        public const int CMSG_ENVELOPED_FLAG = 1 << CMSG_ENVELOPED;

        public const int CMSG_SIGNED_AND_ENVELOPED_FLAG = 1 << CMSG_SIGNED_AND_ENVELOPED;

        public const int CMSG_HASHED_FLAG = 1 << CMSG_HASHED;

        public const int CMSG_ENCRYPTED_FLAG = 1 << CMSG_ENCRYPTED;

        public const uint CMSG_INDEFINITE_LENGTH = 0xFFFFFFFF;

        public const int CMSG_SIGNED_DATA_PKCS_1_5_VERSION = CMSG_SIGNED_DATA_V1;

        public const int CMSG_SIGNED_DATA_CMS_VERSION = CMSG_SIGNED_DATA_V3;

        public const int CMSG_SIGNER_INFO_PKCS_1_5_VERSION = CMSG_SIGNER_INFO_V1;

        public const int CMSG_SIGNER_INFO_CMS_VERSION = CMSG_SIGNER_INFO_V3;

        public const int CMSG_HASHED_DATA_PKCS_1_5_VERSION = CMSG_HASHED_DATA_V0;

        public const int CMSG_HASHED_DATA_CMS_VERSION = CMSG_HASHED_DATA_V2;

        public const int CMSG_ENVELOPED_DATA_PKCS_1_5_VERSION = CMSG_ENVELOPED_DATA_V0;

        public const int CMSG_ENVELOPED_DATA_CMS_VERSION = CMSG_ENVELOPED_DATA_V2;

        public const int CMSG_KEY_TRANS_PKCS_1_5_VERSION = CMSG_ENVELOPED_RECIPIENT_V0;

        public const int CMSG_KEY_TRANS_CMS_VERSION = CMSG_ENVELOPED_RECIPIENT_V2;

        public const int CMSG_KEY_AGREE_VERSION = CMSG_ENVELOPED_RECIPIENT_V3;

        public const int CMSG_MAIL_LIST_VERSION = CMSG_ENVELOPED_RECIPIENT_V4;

        // ((LPCSTR) 1)
        public const int CMSG_DEFAULT_INSTALLABLE_FUNC_OID = 1;

        public static ReadOnlySpan<sbyte> CMSG_OID_CAPI1_GEN_CONTENT_ENCRYPT_KEY_FUNC => CMSG_OID_GEN_CONTENT_ENCRYPT_KEY_FUNC;

        public static ReadOnlySpan<sbyte> CMSG_OID_CAPI1_EXPORT_KEY_TRANS_FUNC => CMSG_OID_EXPORT_KEY_TRANS_FUNC;

        public static ReadOnlySpan<sbyte> CMSG_OID_CAPI1_EXPORT_KEY_AGREE_FUNC => CMSG_OID_EXPORT_KEY_AGREE_FUNC;

        public static ReadOnlySpan<sbyte> CMSG_OID_CAPI1_EXPORT_MAIL_LIST_FUNC => CMSG_OID_EXPORT_MAIL_LIST_FUNC;

        public static ReadOnlySpan<sbyte> CMSG_OID_CAPI1_IMPORT_KEY_TRANS_FUNC => CMSG_OID_IMPORT_KEY_TRANS_FUNC;

        public static ReadOnlySpan<sbyte> CMSG_OID_CAPI1_IMPORT_KEY_AGREE_FUNC => CMSG_OID_IMPORT_KEY_AGREE_FUNC;

        public static ReadOnlySpan<sbyte> CMSG_OID_CAPI1_IMPORT_MAIL_LIST_FUNC => CMSG_OID_IMPORT_MAIL_LIST_FUNC;

        public const int CERT_HASH_PROP_ID = CERT_SHA1_HASH_PROP_ID;

        public const int CERT_CTL_USAGE_PROP_ID = CERT_ENHKEY_USAGE_PROP_ID;

        // 1.3.6.1.4.1.311.10.11.28
        public static ReadOnlySpan<sbyte> szOID_CERT_ISSUER_SERIAL_NUMBER_MD5_HASH_PROP_ID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x31, 0x2E, 0x32, 0x38, 0x00 };

        // 1.3.6.1.4.1.311.10.11.29
        public static ReadOnlySpan<sbyte> szOID_CERT_SUBJECT_NAME_MD5_HASH_PROP_ID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x31, 0x2E, 0x32, 0x39, 0x00 };

        public static ReadOnlySpan<sbyte> szOID_DISALLOWED_HASH => szOID_CERT_SIGNATURE_HASH_PROP_ID;

        // 1.3.6.1.4.1.311.10.11.104
        public static ReadOnlySpan<sbyte> szOID_CERT_DISALLOWED_FILETIME_PROP_ID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x34, 0x00 };

        // ((LPCSTR) 1)
        public const int CERT_STORE_PROV_MSG = 1;

        // ((LPCSTR) 2)
        public const int CERT_STORE_PROV_MEMORY = 2;

        // ((LPCSTR) 3)
        public const int CERT_STORE_PROV_FILE = 3;

        // ((LPCSTR) 4)
        public const int CERT_STORE_PROV_REG = 4;

        // ((LPCSTR) 5)
        public const int CERT_STORE_PROV_PKCS7 = 5;

        // ((LPCSTR) 6)
        public const int CERT_STORE_PROV_SERIALIZED = 6;

        // ((LPCSTR) 7)
        public const int CERT_STORE_PROV_FILENAME_A = 7;

        // ((LPCSTR) 8)
        public const int CERT_STORE_PROV_FILENAME_W = 8;

        public const int CERT_STORE_PROV_FILENAME = CERT_STORE_PROV_FILENAME_W;

        // ((LPCSTR) 9)
        public const int CERT_STORE_PROV_SYSTEM_A = 9;

        // ((LPCSTR) 10)
        public const int CERT_STORE_PROV_SYSTEM_W = 10;

        public const int CERT_STORE_PROV_SYSTEM = CERT_STORE_PROV_SYSTEM_W;

        // ((LPCSTR) 11)
        public const int CERT_STORE_PROV_COLLECTION = 11;

        // ((LPCSTR) 12)
        public const int CERT_STORE_PROV_SYSTEM_REGISTRY_A = 12;

        // ((LPCSTR) 13)
        public const int CERT_STORE_PROV_SYSTEM_REGISTRY_W = 13;

        public const int CERT_STORE_PROV_SYSTEM_REGISTRY = CERT_STORE_PROV_SYSTEM_REGISTRY_W;

        // ((LPCSTR) 14)
        public const int CERT_STORE_PROV_PHYSICAL_W = 14;

        public const int CERT_STORE_PROV_PHYSICAL = CERT_STORE_PROV_PHYSICAL_W;

        // ((LPCSTR) 15)
        public const int CERT_STORE_PROV_SMART_CARD_W = 15;

        public const int CERT_STORE_PROV_SMART_CARD = CERT_STORE_PROV_SMART_CARD_W;

        // ((LPCSTR) 16)
        public const int CERT_STORE_PROV_LDAP_W = 16;

        public const int CERT_STORE_PROV_LDAP = CERT_STORE_PROV_LDAP_W;

        // ((LPCSTR) 17)
        public const int CERT_STORE_PROV_PKCS12 = 17;

        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_FILENAME => sz_CERT_STORE_PROV_FILENAME_W;

        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_SYSTEM => sz_CERT_STORE_PROV_SYSTEM_W;

        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_SYSTEM_REGISTRY => sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W;

        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_PHYSICAL => sz_CERT_STORE_PROV_PHYSICAL_W;

        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_SMART_CARD => sz_CERT_STORE_PROV_SMART_CARD_W;

        public static ReadOnlySpan<sbyte> sz_CERT_STORE_PROV_LDAP => sz_CERT_STORE_PROV_LDAP_W;

        public const int CERT_SYSTEM_STORE_CURRENT_USER = CERT_SYSTEM_STORE_CURRENT_USER_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT;

        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE = CERT_SYSTEM_STORE_LOCAL_MACHINE_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT;

        public const int CERT_SYSTEM_STORE_CURRENT_SERVICE = CERT_SYSTEM_STORE_CURRENT_SERVICE_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT;

        public const int CERT_SYSTEM_STORE_SERVICES = CERT_SYSTEM_STORE_SERVICES_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT;

        public const int CERT_SYSTEM_STORE_USERS = CERT_SYSTEM_STORE_USERS_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT;

        public const int CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY = CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT;

        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY = CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT;

        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE = CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT;

        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_WCOS = CERT_SYSTEM_STORE_LOCAL_MACHINE_WCOS_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT;

        public const string CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH = "Software\\Policies\\Microsoft\\SystemCertificates";

        public const string CERT_EFSBLOB_REGPATH = CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH + "\\EFS";

        public const string CERT_PROT_ROOT_FLAGS_REGPATH = CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH + "\\Root\\ProtectedRoots";

        public static ReadOnlySpan<sbyte> CERT_PROT_ROOT_PEER_USAGES_DEFAULT_A => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x32, 0x00, 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x34, 0x00, 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x34, 0x00, 0x00 };

        public const string CERT_TRUST_PUB_SAFER_GROUP_POLICY_REGPATH = CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH + "\\TrustedPublisher\\Safer";

        public const string CERT_LOCAL_MACHINE_SYSTEM_STORE_REGPATH = "Software\\Microsoft\\SystemCertificates";

        public const string CERT_TRUST_PUB_SAFER_LOCAL_MACHINE_REGPATH = CERT_LOCAL_MACHINE_SYSTEM_STORE_REGPATH + "\\TrustedPublisher\\Safer";

        public const string CERT_OCM_SUBCOMPONENTS_LOCAL_MACHINE_REGPATH = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Setup\\OC Manager\\Subcomponents";

        public const string CERT_DISABLE_ROOT_AUTO_UPDATE_REGPATH = CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH + "\\AuthRoot";

        public const string CERT_AUTO_UPDATE_LOCAL_MACHINE_REGPATH = CERT_LOCAL_MACHINE_SYSTEM_STORE_REGPATH + "\\AuthRoot\\AutoUpdate";

        public const string CERT_AUTH_ROOT_AUTO_UPDATE_LOCAL_MACHINE_REGPATH = CERT_AUTO_UPDATE_LOCAL_MACHINE_REGPATH;

        public const string CERT_AUTH_ROOT_AUTO_UPDATE_ROOT_DIR_URL_VALUE_NAME = CERT_AUTO_UPDATE_ROOT_DIR_URL_VALUE_NAME;

        public const string CERT_DISALLOWED_CERT_AUTO_UPDATE_SYNC_DELTA_TIME_VALUE_NAME = "DisallowedCertSyncDeltaTime";

        public const string CERT_DISALLOWED_CERT_AUTO_UPDATE_LAST_SYNC_TIME_VALUE_NAME = "DisallowedCertLastSyncTime";

        public const string CERT_DISALLOWED_CERT_AUTO_UPDATE_ENCODED_CTL_VALUE_NAME = "DisallowedCertEncodedCtl";

        public const string CERT_DISALLOWED_CERT_AUTO_UPDATE_LIST_IDENTIFIER = "DisallowedCert_AutoUpdate_1";

        public const string CERT_PIN_RULES_AUTO_UPDATE_SYNC_DELTA_TIME_VALUE_NAME = "PinRulesSyncDeltaTime";

        public const string CERT_PIN_RULES_AUTO_UPDATE_LAST_SYNC_TIME_VALUE_NAME = "PinRulesLastSyncTime";

        public const string CERT_PIN_RULES_AUTO_UPDATE_ENCODED_CTL_VALUE_NAME = "PinRulesEncodedCtl";

        public const string CERT_PIN_RULES_AUTO_UPDATE_LIST_IDENTIFIER = "PinRules_AutoUpdate_1";

        public const string CERT_IE_DIRTY_FLAGS_REGPATH = "Software\\Microsoft\\Cryptography\\IEDirtyFlags";

        public const int CERT_STORE_SAVE_TO_FILENAME = CERT_STORE_SAVE_TO_FILENAME_W;

        public const int CERT_COMPARE_HASH = CERT_COMPARE_SHA1_HASH;

        public const int CERT_COMPARE_CTL_USAGE = CERT_COMPARE_ENHKEY_USAGE;

        public const int CERT_FIND_ANY = CERT_COMPARE_ANY << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_SHA1_HASH = CERT_COMPARE_SHA1_HASH << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_MD5_HASH = CERT_COMPARE_MD5_HASH << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_SIGNATURE_HASH = CERT_COMPARE_SIGNATURE_HASH << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_KEY_IDENTIFIER = CERT_COMPARE_KEY_IDENTIFIER << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_HASH = CERT_FIND_SHA1_HASH;

        public const int CERT_FIND_PROPERTY = CERT_COMPARE_PROPERTY << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_PUBLIC_KEY = CERT_COMPARE_PUBLIC_KEY << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_SUBJECT_NAME = (CERT_COMPARE_NAME << CERT_COMPARE_SHIFT) | CERT_INFO_SUBJECT_FLAG;

        public const int CERT_FIND_SUBJECT_ATTR = (CERT_COMPARE_ATTR << CERT_COMPARE_SHIFT) | CERT_INFO_SUBJECT_FLAG;

        public const int CERT_FIND_ISSUER_NAME = (CERT_COMPARE_NAME << CERT_COMPARE_SHIFT) | CERT_INFO_ISSUER_FLAG;

        public const int CERT_FIND_ISSUER_ATTR = (CERT_COMPARE_ATTR << CERT_COMPARE_SHIFT) | CERT_INFO_ISSUER_FLAG;

        public const int CERT_FIND_SUBJECT_STR_A = (CERT_COMPARE_NAME_STR_A << CERT_COMPARE_SHIFT) | CERT_INFO_SUBJECT_FLAG;

        public const int CERT_FIND_SUBJECT_STR_W = (CERT_COMPARE_NAME_STR_W << CERT_COMPARE_SHIFT) | CERT_INFO_SUBJECT_FLAG;

        public const int CERT_FIND_SUBJECT_STR = CERT_FIND_SUBJECT_STR_W;

        public const int CERT_FIND_ISSUER_STR_A = (CERT_COMPARE_NAME_STR_A << CERT_COMPARE_SHIFT) | CERT_INFO_ISSUER_FLAG;

        public const int CERT_FIND_ISSUER_STR_W = (CERT_COMPARE_NAME_STR_W << CERT_COMPARE_SHIFT) | CERT_INFO_ISSUER_FLAG;

        public const int CERT_FIND_ISSUER_STR = CERT_FIND_ISSUER_STR_W;

        public const int CERT_FIND_KEY_SPEC = CERT_COMPARE_KEY_SPEC << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_ENHKEY_USAGE = CERT_COMPARE_ENHKEY_USAGE << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_CTL_USAGE = CERT_FIND_ENHKEY_USAGE;

        public const int CERT_FIND_SUBJECT_CERT = CERT_COMPARE_SUBJECT_CERT << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_ISSUER_OF = CERT_COMPARE_ISSUER_OF << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_EXISTING = CERT_COMPARE_EXISTING << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_CERT_ID = CERT_COMPARE_CERT_ID << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_CROSS_CERT_DIST_POINTS = CERT_COMPARE_CROSS_CERT_DIST_POINTS << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_PUBKEY_MD5_HASH = CERT_COMPARE_PUBKEY_MD5_HASH << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_SUBJECT_INFO_ACCESS = CERT_COMPARE_SUBJECT_INFO_ACCESS << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_HASH_STR = CERT_COMPARE_HASH_STR << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_HAS_PRIVATE_KEY = CERT_COMPARE_HAS_PRIVATE_KEY << CERT_COMPARE_SHIFT;

        public const int CERT_FIND_OPTIONAL_CTL_USAGE_FLAG = CERT_FIND_OPTIONAL_ENHKEY_USAGE_FLAG;

        public const int CERT_FIND_EXT_ONLY_CTL_USAGE_FLAG = CERT_FIND_EXT_ONLY_ENHKEY_USAGE_FLAG;

        public const int CERT_FIND_PROP_ONLY_CTL_USAGE_FLAG = CERT_FIND_PROP_ONLY_ENHKEY_USAGE_FLAG;

        public const int CERT_FIND_NO_CTL_USAGE_FLAG = CERT_FIND_NO_ENHKEY_USAGE_FLAG;

        public const int CERT_FIND_OR_CTL_USAGE_FLAG = CERT_FIND_OR_ENHKEY_USAGE_FLAG;

        public const int CERT_FIND_VALID_CTL_USAGE_FLAG = CERT_FIND_VALID_ENHKEY_USAGE_FLAG;

        public const uint CERT_STORE_ALL_CONTEXT_FLAG = ~0U;

        public const int CERT_STORE_CERTIFICATE_CONTEXT_FLAG = 1 << CERT_STORE_CERTIFICATE_CONTEXT;

        public const int CERT_STORE_CRL_CONTEXT_FLAG = 1 << CERT_STORE_CRL_CONTEXT;

        public const int CERT_STORE_CTL_CONTEXT_FLAG = 1 << CERT_STORE_CTL_CONTEXT;

        // ((PCERT_INFO) -1)
        public const int CTL_FIND_NO_SIGNER_PTR = -1;

        public const string CERT_PHYSICAL_STORE_LOCAL_MACHINE_GROUP_POLICY_NAME = ".LocalMachineGroupPolicy";

        // CryptDllExtractEncodedSignatureParameters
        public static ReadOnlySpan<sbyte> CRYPT_OID_EXTRACT_ENCODED_SIGNATURE_PARAMETERS_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x74, 0x72, 0x61, 0x63, 0x74, 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x64, 0x53, 0x69, 0x67, 0x6E, 0x61, 0x74, 0x75, 0x72, 0x65, 0x50, 0x61, 0x72, 0x61, 0x6D, 0x65, 0x74, 0x65, 0x72, 0x73, 0x00 };

        // CryptDllSignAndEncodeHash
        public static ReadOnlySpan<sbyte> CRYPT_OID_SIGN_AND_ENCODE_HASH_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x53, 0x69, 0x67, 0x6E, 0x41, 0x6E, 0x64, 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x48, 0x61, 0x73, 0x68, 0x00 };

        // CryptDllVerifyEncodedSignature
        public static ReadOnlySpan<sbyte> CRYPT_OID_VERIFY_ENCODED_SIGNATURE_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x56, 0x65, 0x72, 0x69, 0x66, 0x79, 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x64, 0x53, 0x69, 0x67, 0x6E, 0x61, 0x74, 0x75, 0x72, 0x65, 0x00 };

        // CryptDllExportPublicKeyInfoEx2
        public static ReadOnlySpan<sbyte> CRYPT_OID_EXPORT_PUBLIC_KEY_INFO_EX2_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x50, 0x75, 0x62, 0x6C, 0x69, 0x63, 0x4B, 0x65, 0x79, 0x49, 0x6E, 0x66, 0x6F, 0x45, 0x78, 0x32, 0x00 };

        // CryptDllExportPublicKeyInfoFromBCryptKeyHandle
        public static ReadOnlySpan<sbyte> CRYPT_OID_EXPORT_PUBLIC_KEY_INFO_FROM_BCRYPT_HANDLE_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x50, 0x75, 0x62, 0x6C, 0x69, 0x63, 0x4B, 0x65, 0x79, 0x49, 0x6E, 0x66, 0x6F, 0x46, 0x72, 0x6F, 0x6D, 0x42, 0x43, 0x72, 0x79, 0x70, 0x74, 0x4B, 0x65, 0x79, 0x48, 0x61, 0x6E, 0x64, 0x6C, 0x65, 0x00 };

        // CryptDllImportPublicKeyInfoEx2
        public static ReadOnlySpan<sbyte> CRYPT_OID_IMPORT_PUBLIC_KEY_INFO_EX2_FUNC => new sbyte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x50, 0x75, 0x62, 0x6C, 0x69, 0x63, 0x4B, 0x65, 0x79, 0x49, 0x6E, 0x66, 0x6F, 0x45, 0x78, 0x32, 0x00 };

        public const int CRYPT_DELETE_KEYSET = CRYPT_DELETEKEYSET;

        public const int CERT_QUERY_CONTENT_FLAG_CERT = 1 << CERT_QUERY_CONTENT_CERT;

        public const int CERT_QUERY_CONTENT_FLAG_CTL = 1 << CERT_QUERY_CONTENT_CTL;

        public const int CERT_QUERY_CONTENT_FLAG_CRL = 1 << CERT_QUERY_CONTENT_CRL;

        public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE = 1 << CERT_QUERY_CONTENT_SERIALIZED_STORE;

        public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT = 1 << CERT_QUERY_CONTENT_SERIALIZED_CERT;

        public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_CTL = 1 << CERT_QUERY_CONTENT_SERIALIZED_CTL;

        public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_CRL = 1 << CERT_QUERY_CONTENT_SERIALIZED_CRL;

        public const int CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED = 1 << CERT_QUERY_CONTENT_PKCS7_SIGNED;

        public const int CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED = 1 << CERT_QUERY_CONTENT_PKCS7_UNSIGNED;

        public const int CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED_EMBED = 1 << CERT_QUERY_CONTENT_PKCS7_SIGNED_EMBED;

        public const int CERT_QUERY_CONTENT_FLAG_PKCS10 = 1 << CERT_QUERY_CONTENT_PKCS10;

        public const int CERT_QUERY_CONTENT_FLAG_PFX = 1 << CERT_QUERY_CONTENT_PFX;

        public const int CERT_QUERY_CONTENT_FLAG_CERT_PAIR = 1 << CERT_QUERY_CONTENT_CERT_PAIR;

        public const int CERT_QUERY_CONTENT_FLAG_PFX_AND_LOAD = 1 << CERT_QUERY_CONTENT_PFX_AND_LOAD;

        public const int CERT_QUERY_CONTENT_FLAG_ALL = CERT_QUERY_CONTENT_FLAG_CERT | CERT_QUERY_CONTENT_FLAG_CTL | CERT_QUERY_CONTENT_FLAG_CRL | CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE | CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT | CERT_QUERY_CONTENT_FLAG_SERIALIZED_CTL | CERT_QUERY_CONTENT_FLAG_SERIALIZED_CRL | CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED | CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED | CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED_EMBED | CERT_QUERY_CONTENT_FLAG_PKCS10 | CERT_QUERY_CONTENT_FLAG_PFX | CERT_QUERY_CONTENT_FLAG_CERT_PAIR;

        public const int CERT_QUERY_CONTENT_FLAG_ALL_ISSUER_CERT = CERT_QUERY_CONTENT_FLAG_CERT | CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE | CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT | CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED | CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED;

        public const int CERT_QUERY_FORMAT_FLAG_BINARY = 1 << CERT_QUERY_FORMAT_BINARY;

        public const int CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED = 1 << CERT_QUERY_FORMAT_BASE64_ENCODED;

        public const int CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED = 1 << CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED;

        public const int CERT_QUERY_FORMAT_FLAG_ALL = CERT_QUERY_FORMAT_FLAG_BINARY | CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED | CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED;

        // ((LPCSTR)1)
        public const int CREDENTIAL_OID_PASSWORD_CREDENTIALS_A = 1;

        // ((LPCSTR)2)
        public const int CREDENTIAL_OID_PASSWORD_CREDENTIALS_W = 2;

        public const int CREDENTIAL_OID_PASSWORD_CREDENTIALS = CREDENTIAL_OID_PASSWORD_CREDENTIALS_W;

        // ((LPCSTR)1)
        public const int CONTEXT_OID_CERTIFICATE = 1;

        // ((LPCSTR)2)
        public const int CONTEXT_OID_CRL = 2;

        // ((LPCSTR)3)
        public const int CONTEXT_OID_CTL = 3;

        // ((LPCSTR)4)
        public const int CONTEXT_OID_PKCS7 = 4;

        // ((LPCSTR)5)
        public const int CONTEXT_OID_CAPI2_ANY = 5;

        // ((LPCSTR)6)
        public const int CONTEXT_OID_OCSP_RESP = 6;

        // ((LPCSTR)1)
        public const int CRYPT_PARAM_ASYNC_RETRIEVAL_COMPLETION = 1;

        // ((LPCSTR)2)
        public const int CRYPT_PARAM_CANCEL_ASYNC_RETRIEVAL = 2;

        // ((LPCSTR)1)
        public const int URL_OID_CERTIFICATE_ISSUER = 1;

        // ((LPCSTR)2)
        public const int URL_OID_CERTIFICATE_CRL_DIST_POINT = 2;

        // ((LPCSTR)3)
        public const int URL_OID_CTL_ISSUER = 3;

        // ((LPCSTR)4)
        public const int URL_OID_CTL_NEXT_UPDATE = 4;

        // ((LPCSTR)5)
        public const int URL_OID_CRL_ISSUER = 5;

        // ((LPCSTR)6)
        public const int URL_OID_CERTIFICATE_FRESHEST_CRL = 6;

        // ((LPCSTR)7)
        public const int URL_OID_CRL_FRESHEST_CRL = 7;

        // ((LPCSTR)8)
        public const int URL_OID_CROSS_CERT_DIST_POINT = 8;

        // ((LPCSTR)9)
        public const int URL_OID_CERTIFICATE_OCSP = 9;

        // ((LPCSTR)10)
        public const int URL_OID_CERTIFICATE_OCSP_AND_CRL_DIST_POINT = 10;

        // ((LPCSTR)11)
        public const int URL_OID_CERTIFICATE_CRL_DIST_POINT_AND_OCSP = 11;

        // ((LPCSTR)12)
        public const int URL_OID_CROSS_CERT_SUBJECT_INFO_ACCESS = 12;

        // ((LPCSTR)13)
        public const int URL_OID_CERTIFICATE_ONLY_OCSP = 13;

        // ((LPCSTR)1)
        public const int TIME_VALID_OID_GET_CTL = 1;

        // ((LPCSTR)2)
        public const int TIME_VALID_OID_GET_CRL = 2;

        // ((LPCSTR)3)
        public const int TIME_VALID_OID_GET_CRL_FROM_CERT = 3;

        // ((LPCSTR)4)
        public const int TIME_VALID_OID_GET_FRESHEST_CRL_FROM_CERT = 4;

        // ((LPCSTR)5)
        public const int TIME_VALID_OID_GET_FRESHEST_CRL_FROM_CRL = 5;

        // ((LPCSTR)1)
        public const int TIME_VALID_OID_FLUSH_CTL = 1;

        // ((LPCSTR)2)
        public const int TIME_VALID_OID_FLUSH_CRL = 2;

        // ((LPCSTR)3)
        public const int TIME_VALID_OID_FLUSH_CRL_FROM_CERT = 3;

        // ((LPCSTR)4)
        public const int TIME_VALID_OID_FLUSH_FRESHEST_CRL_FROM_CERT = 4;

        // ((LPCSTR)5)
        public const int TIME_VALID_OID_FLUSH_FRESHEST_CRL_FROM_CRL = 5;

        public const string CERT_CHAIN_CONFIG_REGPATH = "Software\\Microsoft\\Cryptography\\OID\\EncodingType 0\\CertDllCreateCertificateChainEngine\\Config";

        public const string CERT_CHAIN_MAX_URL_RETRIEVAL_BYTE_COUNT_VALUE_NAME = "MaxUrlRetrievalByteCount";

        public const int CERT_CHAIN_MAX_URL_RETRIEVAL_BYTE_COUNT_DEFAULT = 100 * 1024 * 1024;

        public const string CERT_CHAIN_CACHE_RESYNC_FILETIME_VALUE_NAME = "ChainCacheResyncFiletime";

        public const string CERT_CHAIN_DISABLE_MANDATORY_BASIC_CONSTRAINTS_VALUE_NAME = "DisableMandatoryBasicConstraints";

        public const string CERT_CHAIN_DISABLE_CA_NAME_CONSTRAINTS_VALUE_NAME = "DisableCANameConstraints";

        public const string CERT_CHAIN_DISABLE_UNSUPPORTED_CRITICAL_EXTENSIONS_VALUE_NAME = "DisableUnsupportedCriticalExtensions";

        public const string CERT_CHAIN_MAX_AIA_URL_COUNT_IN_CERT_VALUE_NAME = "MaxAIAUrlCountInCert";

        public const string CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_COUNT_PER_CHAIN_VALUE_NAME = "MaxAIAUrlRetrievalCountPerChain";

        public const string CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_BYTE_COUNT_VALUE_NAME = "MaxAIAUrlRetrievalByteCount";

        public const string CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_CERT_COUNT_VALUE_NAME = "MaxAIAUrlRetrievalCertCount";

        public const string CERT_CHAIN_OCSP_VALIDITY_SECONDS_VALUE_NAME = "OcspValiditySeconds";

        public const int CERT_CHAIN_OCSP_VALIDITY_SECONDS_DEFAULT = 16 * 60 * 60;

        public const string CERT_CHAIN_DISABLE_SERIAL_CHAIN_VALUE_NAME = "DisableSerialChain";

        public const string CERT_CHAIN_SERIAL_CHAIN_LOG_FILE_NAME_VALUE_NAME = "SerialChainLogFileName";

        public const string CERT_CHAIN_DISABLE_SYNC_WITH_SSL_TIME_VALUE_NAME = "DisableSyncWithSslTime";

        public const string CERT_CHAIN_MAX_SSL_TIME_UPDATED_EVENT_COUNT_VALUE_NAME = "MaxSslTimeUpdatedEventCount";

        public const string CERT_CHAIN_SSL_HANDSHAKE_LOG_FILE_NAME_VALUE_NAME = "SslHandshakeLogFileName";

        public const string CERT_CHAIN_ENABLE_WEAK_SIGNATURE_FLAGS_VALUE_NAME = "EnableWeakSignatureFlags";

        public const string CERT_CHAIN_MIN_RSA_PUB_KEY_BIT_LENGTH_VALUE_NAME = "MinRsaPubKeyBitLength";

        public const uint CERT_CHAIN_MIN_RSA_PUB_KEY_BIT_LENGTH_DISABLE = 0xFFFFFFFF;

        public const string CERT_CHAIN_WEAK_RSA_PUB_KEY_TIME_VALUE_NAME = "WeakRsaPubKeyTime";

        public const ulong CERT_CHAIN_WEAK_RSA_PUB_KEY_TIME_DEFAULT = 0x01CA8A755C6E0000;

        public const string CERT_CHAIN_WEAK_SIGNATURE_LOG_DIR_VALUE_NAME = "WeakSignatureLogDir";

        public const uint CERT_CHAIN_MIN_PUB_KEY_BIT_LENGTH_DISABLE = 0xFFFFFFFF;

        public const int CERT_CHAIN_DISABLE_WEAK_FLAGS = CERT_CHAIN_DISABLE_ALL_EKU_WEAK_FLAG | CERT_CHAIN_DISABLE_SERVER_AUTH_WEAK_FLAG | CERT_CHAIN_DISABLE_OPT_IN_SERVER_AUTH_WEAK_FLAG | CERT_CHAIN_DISABLE_CODE_SIGNING_WEAK_FLAG | CERT_CHAIN_DISABLE_MOTW_CODE_SIGNING_WEAK_FLAG | CERT_CHAIN_DISABLE_TIMESTAMP_WEAK_FLAG | CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_WEAK_FLAG;

        public const int CERT_CHAIN_DISABLE_FILE_HASH_WEAK_FLAGS = CERT_CHAIN_DISABLE_FILE_HASH_WEAK_FLAG | CERT_CHAIN_DISABLE_MOTW_FILE_HASH_WEAK_FLAG;

        public const int CERT_CHAIN_DISABLE_TIMESTAMP_HASH_WEAK_FLAGS = CERT_CHAIN_DISABLE_TIMESTAMP_HASH_WEAK_FLAG | CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_HASH_WEAK_FLAG;

        public const int CERT_CHAIN_ENABLE_HYGIENE_FLAGS = CERT_CHAIN_ENABLE_ALL_EKU_HYGIENE_FLAG | CERT_CHAIN_ENABLE_SERVER_AUTH_HYGIENE_FLAG | CERT_CHAIN_ENABLE_CODE_SIGNING_HYGIENE_FLAG | CERT_CHAIN_ENABLE_MOTW_CODE_SIGNING_HYGIENE_FLAG | CERT_CHAIN_ENABLE_TIMESTAMP_HYGIENE_FLAG | CERT_CHAIN_ENABLE_MOTW_TIMESTAMP_HYGIENE_FLAG;

        public const int CERT_CHAIN_MOTW_WEAK_FLAGS = CERT_CHAIN_DISABLE_MOTW_CODE_SIGNING_WEAK_FLAG | CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_WEAK_FLAG | CERT_CHAIN_ENABLE_MOTW_CODE_SIGNING_HYGIENE_FLAG | CERT_CHAIN_ENABLE_MOTW_TIMESTAMP_HYGIENE_FLAG | CERT_CHAIN_MOTW_IGNORE_AFTER_TIME_WEAK_FLAG;

        public const int CERT_CHAIN_OPT_IN_WEAK_FLAGS = CERT_CHAIN_DISABLE_OPT_IN_SERVER_AUTH_WEAK_FLAG;

        public const string CERT_CHAIN_AUTO_FLAGS_VALUE_NAME = "AutoFlags";

        public const int CERT_CHAIN_AUTO_LOG_FLAGS = CERT_CHAIN_AUTO_LOG_CREATE_FLAG | CERT_CHAIN_AUTO_LOG_FREE_FLAG | CERT_CHAIN_AUTO_LOG_FLUSH_FLAG;

        public const string CERT_CHAIN_AUTO_FLUSH_FIRST_DELTA_SECONDS_VALUE_NAME = "AutoFlushFirstDeltaSeconds";

        public const int CERT_CHAIN_AUTO_FLUSH_FIRST_DELTA_SECONDS_DEFAULT = 5 * 60;

        public const string CERT_CHAIN_AUTO_FLUSH_NEXT_DELTA_SECONDS_VALUE_NAME = "AutoFlushNextDeltaSeconds";

        public const int CERT_CHAIN_AUTO_FLUSH_NEXT_DELTA_SECONDS_DEFAULT = 30 * 60;

        public const string CERT_CHAIN_AUTO_LOG_FILE_NAME_VALUE_NAME = "AutoLogFileName";

        public const string CERT_CHAIN_DISABLE_AUTO_FLUSH_PROCESS_NAME_LIST_VALUE_NAME = "DisableAutoFlushProcessNameList";

        public const string CERT_SRV_OCSP_RESP_MIN_VALIDITY_SECONDS_VALUE_NAME = "SrvOcspRespMinValiditySeconds";

        public const int CERT_SRV_OCSP_RESP_MIN_VALIDITY_SECONDS_DEFAULT = 10 * 60;

        public const string CERT_SRV_OCSP_RESP_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_VALUE_NAME = "SrvOcspRespUrlRetrievalTimeoutMilliseconds";

        public const int CERT_SRV_OCSP_RESP_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_DEFAULT = 15 * 1000;

        public const string CERT_SRV_OCSP_RESP_MAX_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME = "SrvOcspRespMaxBeforeNextUpdateSeconds";

        public const int CERT_SRV_OCSP_RESP_MAX_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT = 4 * 60 * 60;

        public const string CERT_SRV_OCSP_RESP_MIN_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME = "SrvOcspRespMinBeforeNextUpdateSeconds";

        public const int CERT_SRV_OCSP_RESP_MIN_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT = 2 * 60;

        public const string CERT_SRV_OCSP_RESP_MIN_AFTER_NEXT_UPDATE_SECONDS_VALUE_NAME = "SrvOcspRespMinAfterNextUpdateSeconds";

        public const int CERT_SRV_OCSP_RESP_MIN_AFTER_NEXT_UPDATE_SECONDS_DEFAULT = 1 * 60;

        public const string CERT_SRV_OCSP_RESP_MIN_SYNC_CERT_FILE_SECONDS_VALUE_NAME = "SrvOcspRespMinSyncCertFileSeconds";

        public const int CERT_SRV_OCSP_RESP_MIN_SYNC_CERT_FILE_SECONDS_DEFAULT = 5;

        public const string CERT_SRV_OCSP_RESP_MAX_SYNC_CERT_FILE_SECONDS_VALUE_NAME = "SrvOcspRespMaxSyncCertFileSeconds";

        public const int CERT_SRV_OCSP_RESP_MAX_SYNC_CERT_FILE_SECONDS_DEFAULT = 1 * 60 * 60;

        public const string CRYPTNET_MAX_CACHED_OCSP_PER_CRL_COUNT_VALUE_NAME = "CryptnetMaxCachedOcspPerCrlCount";

        public const int CRYPTNET_MAX_CACHED_OCSP_PER_CRL_COUNT_DEFAULT = 500;

        public const uint CRYPTNET_OCSP_AFTER_CRL_DISABLE = 0xFFFFFFFF;

        public const string CRYPTNET_URL_CACHE_DEFAULT_FLUSH_EXEMPT_SECONDS_VALUE_NAME = "CryptnetDefaultFlushExemptSeconds";

        public const int CRYPTNET_URL_CACHE_DEFAULT_FLUSH_EXEMPT_SECONDS_DEFAULT = 28 * 24 * 60 * 60;

        public const string CRYPTNET_PRE_FETCH_MIN_MAX_AGE_SECONDS_VALUE_NAME = "CryptnetPreFetchMinMaxAgeSeconds";

        public const int CRYPTNET_PRE_FETCH_MIN_MAX_AGE_SECONDS_DEFAULT = 1 * 60 * 60;

        public const string CRYPTNET_PRE_FETCH_MAX_MAX_AGE_SECONDS_VALUE_NAME = "CryptnetPreFetchMaxMaxAgeSeconds";

        public const int CRYPTNET_PRE_FETCH_MAX_MAX_AGE_SECONDS_DEFAULT = 14 * 24 * 60 * 60;

        public const string CRYPTNET_PRE_FETCH_MIN_OCSP_VALIDITY_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchMinOcspValidityPeriodSeconds";

        public const int CRYPTNET_PRE_FETCH_MIN_OCSP_VALIDITY_PERIOD_SECONDS_DEFAULT = 14 * 24 * 60 * 60;

        public const string CRYPTNET_PRE_FETCH_AFTER_PUBLISH_PRE_FETCH_DIVISOR_VALUE_NAME = "CryptnetPreFetchAfterPublishPreFetchDivisor";

        public const int CRYPTNET_PRE_FETCH_AFTER_PUBLISH_PRE_FETCH_DIVISOR_DEFAULT = 10;

        public const string CRYPTNET_PRE_FETCH_BEFORE_NEXT_UPDATE_PRE_FETCH_DIVISOR_VALUE_NAME = "CryptnetPreFetchBeforeNextUpdatePreFetchDivisor";

        public const int CRYPTNET_PRE_FETCH_BEFORE_NEXT_UPDATE_PRE_FETCH_DIVISOR_DEFAULT = 20;

        public const string CRYPTNET_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchMinBeforeNextUpdatePreFetchSeconds";

        public const int CRYPTNET_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT = 1 * 60 * 60;

        public const string CRYPTNET_PRE_FETCH_VALIDITY_PERIOD_AFTER_NEXT_UPDATE_PRE_FETCH_DIVISOR_VALUE_NAME = "CryptnetPreFetchValidityPeriodAfterNextUpdatePreFetchDivisor";

        public const int CRYPTNET_PRE_FETCH_VALIDITY_PERIOD_AFTER_NEXT_UPDATE_PRE_FETCH_DIVISOR_DEFAULT = 10;

        public const string CRYPTNET_PRE_FETCH_MAX_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchMaxAfterNextUpdatePreFetchPeriodSeconds";

        public const int CRYPTNET_PRE_FETCH_MAX_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT = 4 * 60 * 60;

        public const string CRYPTNET_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchMinAfterNextUpdatePreFetchPeriodSeconds";

        public const int CRYPTNET_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT = 30 * 60;

        public const string CRYPTNET_PRE_FETCH_AFTER_CURRENT_TIME_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchAfterCurrentTimePreFetchPeriodSeconds";

        public const int CRYPTNET_PRE_FETCH_AFTER_CURRENT_TIME_PRE_FETCH_PERIOD_SECONDS_DEFAULT = 30 * 60;

        public const string CRYPTNET_PRE_FETCH_TRIGGER_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchTriggerPeriodSeconds";

        public const int CRYPTNET_PRE_FETCH_TRIGGER_PERIOD_SECONDS_DEFAULT = 10 * 60;

        public const uint CRYPTNET_PRE_FETCH_TRIGGER_DISABLE = 0xFFFFFFFF;

        public const string CRYPTNET_PRE_FETCH_SCAN_AFTER_TRIGGER_DELAY_SECONDS_VALUE_NAME = "CryptnetPreFetchScanAfterTriggerDelaySeconds";

        public const int CRYPTNET_PRE_FETCH_SCAN_AFTER_TRIGGER_DELAY_SECONDS_DEFAULT = 60;

        public const string CRYPTNET_PRE_FETCH_RETRIEVAL_TIMEOUT_SECONDS_VALUE_NAME = "CryptnetPreFetchRetrievalTimeoutSeconds";

        public const int CRYPTNET_PRE_FETCH_RETRIEVAL_TIMEOUT_SECONDS_DEFAULT = 5 * 60;

        public const string CRYPTNET_CRL_PRE_FETCH_CONFIG_REGPATH = CERT_CHAIN_CONFIG_REGPATH + "\\CrlPreFetch";

        public const string CRYPTNET_CRL_PRE_FETCH_PROCESS_NAME_LIST_VALUE_NAME = "ProcessNameList";

        public const string CRYPTNET_CRL_PRE_FETCH_URL_LIST_VALUE_NAME = "PreFetchUrlList";

        public const string CRYPTNET_CRL_PRE_FETCH_DISABLE_INFORMATION_EVENTS_VALUE_NAME = "DisableInformationEvents";

        public const string CRYPTNET_CRL_PRE_FETCH_LOG_FILE_NAME_VALUE_NAME = "LogFileName";

        public const string CRYPTNET_CRL_PRE_FETCH_TIMEOUT_SECONDS_VALUE_NAME = "TimeoutSeconds";

        public const int CRYPTNET_CRL_PRE_FETCH_TIMEOUT_SECONDS_DEFAULT = 5 * 60;

        public const string CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_VALUE_NAME = "MaxAgeSeconds";

        public const int CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_DEFAULT = 2 * 60 * 60;

        public const int CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_MIN = 5 * 60;

        public const string CRYPTNET_CRL_PRE_FETCH_PUBLISH_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME = "PublishBeforeNextUpdateSeconds";

        public const int CRYPTNET_CRL_PRE_FETCH_PUBLISH_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT = 1 * 60 * 60;

        public const string CRYPTNET_CRL_PRE_FETCH_PUBLISH_RANDOM_INTERVAL_SECONDS_VALUE_NAME = "PublishRandomIntervalSeconds";

        public const int CRYPTNET_CRL_PRE_FETCH_PUBLISH_RANDOM_INTERVAL_SECONDS_DEFAULT = 5 * 60;

        public const string CRYPTNET_CRL_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME = "MinBeforeNextUpdateSeconds";

        public const int CRYPTNET_CRL_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT = 5 * 60;

        public const string CRYPTNET_CRL_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_SECONDS_VALUE_NAME = "MinAfterNextUpdateSeconds";

        public const int CRYPTNET_CRL_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_SECONDS_DEFAULT = 5 * 60;

        public const string CERT_GROUP_POLICY_CHAIN_CONFIG_REGPATH = CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH + "\\ChainEngine\\Config";

        public const string CERT_CHAIN_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_VALUE_NAME = "ChainUrlRetrievalTimeoutMilliseconds";

        public const int CERT_CHAIN_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_DEFAULT = 15 * 1000;

        public const string CERT_CHAIN_REV_ACCUMULATIVE_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_VALUE_NAME = "ChainRevAccumulativeUrlRetrievalTimeoutMilliseconds";

        public const int CERT_CHAIN_REV_ACCUMULATIVE_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_DEFAULT = 20 * 1000;

        public const string CRYPTNET_CACHED_OCSP_SWITCH_TO_CRL_COUNT_VALUE_NAME = "CryptnetCachedOcspSwitchToCrlCount";

        public const int CRYPTNET_CACHED_OCSP_SWITCH_TO_CRL_COUNT_DEFAULT = 50;

        public const uint CRYPTNET_CRL_BEFORE_OCSP_ENABLE = 0xFFFFFFFF;

        public const string CERT_CHAIN_DISABLE_AIA_URL_RETRIEVAL_VALUE_NAME = "DisableAIAUrlRetrieval";

        public const string CERT_CHAIN_OPTIONS_VALUE_NAME = "Options";

        public const string CERT_CHAIN_CROSS_CERT_DOWNLOAD_INTERVAL_HOURS_VALUE_NAME = "CrossCertDownloadIntervalHours";

        public const int CERT_CHAIN_CROSS_CERT_DOWNLOAD_INTERVAL_HOURS_DEFAULT = 24 * 7;

        public const string CERT_CHAIN_CRL_VALIDITY_EXT_PERIOD_HOURS_VALUE_NAME = "CRLValidityExtensionPeriod";

        // ((HCERTCHAINENGINE)NULL)
        public const int HCCE_CURRENT_USER = 0;

        // ((HCERTCHAINENGINE)0x1)
        public const int HCCE_LOCAL_MACHINE = 0x1;

        // ((HCERTCHAINENGINE)0x2)
        public const int HCCE_SERIAL_LOCAL_MACHINE = 0x2;

        // ((LPCSTR)1)
        public const int REVOCATION_OID_CRL_REVOCATION = 1;

        public const int CERT_CHAIN_POLICY_IGNORE_ALL_NOT_TIME_VALID_FLAGS = CERT_CHAIN_POLICY_IGNORE_NOT_TIME_VALID_FLAG | CERT_CHAIN_POLICY_IGNORE_CTL_NOT_TIME_VALID_FLAG | CERT_CHAIN_POLICY_IGNORE_NOT_TIME_NESTED_FLAG;

        public const int CERT_CHAIN_POLICY_IGNORE_ALL_REV_UNKNOWN_FLAGS = CERT_CHAIN_POLICY_IGNORE_END_REV_UNKNOWN_FLAG | CERT_CHAIN_POLICY_IGNORE_CTL_SIGNER_REV_UNKNOWN_FLAG | CERT_CHAIN_POLICY_IGNORE_CA_REV_UNKNOWN_FLAG | CERT_CHAIN_POLICY_IGNORE_ROOT_REV_UNKNOWN_FLAG;

        // CertDllVerifyCertificateChainPolicy
        public static ReadOnlySpan<sbyte> CRYPT_OID_VERIFY_CERTIFICATE_CHAIN_POLICY_FUNC => new sbyte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x56, 0x65, 0x72, 0x69, 0x66, 0x79, 0x43, 0x65, 0x72, 0x74, 0x69, 0x66, 0x69, 0x63, 0x61, 0x74, 0x65, 0x43, 0x68, 0x61, 0x69, 0x6E, 0x50, 0x6F, 0x6C, 0x69, 0x63, 0x79, 0x00 };

        // ((LPCSTR) 1)
        public const int CERT_CHAIN_POLICY_BASE = 1;

        // ((LPCSTR) 2)
        public const int CERT_CHAIN_POLICY_AUTHENTICODE = 2;

        // ((LPCSTR) 3)
        public const int CERT_CHAIN_POLICY_AUTHENTICODE_TS = 3;

        // ((LPCSTR) 4)
        public const int CERT_CHAIN_POLICY_SSL = 4;

        // ((LPCSTR) 5)
        public const int CERT_CHAIN_POLICY_BASIC_CONSTRAINTS = 5;

        // ((LPCSTR) 6)
        public const int CERT_CHAIN_POLICY_NT_AUTH = 6;

        // ((LPCSTR) 7)
        public const int CERT_CHAIN_POLICY_MICROSOFT_ROOT = 7;

        // ((LPCSTR) 8)
        public const int CERT_CHAIN_POLICY_EV = 8;

        // ((LPCSTR) 9)
        public const int CERT_CHAIN_POLICY_SSL_F12 = 9;

        // ((LPCSTR) 10)
        public const int CERT_CHAIN_POLICY_SSL_HPKP_HEADER = 10;

        // ((LPCSTR) 11)
        public const int CERT_CHAIN_POLICY_THIRD_PARTY_ROOT = 11;

        // ((LPCSTR) 12)
        public const int CERT_CHAIN_POLICY_SSL_KEY_PIN = 12;

        public const int PKCS12_OBJECT_LOCATOR_ALL_IMPORT_FLAGS = PKCS12_ALWAYS_CNG_KSP | PKCS12_NO_PERSIST_KEY | PKCS12_IMPORT_SILENT | PKCS12_INCLUDE_EXTENDED_PROPERTIES;

        public const string PKCS12_CONFIG_REGPATH = "Software\\Microsoft\\Windows\\CurrentVersion\\PFX";

        public const string PKCS12_ENCRYPT_CERTIFICATES_VALUE_NAME = "EncryptCertificates";

        // ((LPCSTR) 1)
        public const int CERT_RETRIEVE_ISSUER_LOGO = 1;

        // ((LPCSTR) 2)
        public const int CERT_RETRIEVE_SUBJECT_LOGO = 2;

        // ((LPCSTR) 3)
        public const int CERT_RETRIEVE_COMMUNITY_LOGO = 3;

        // ((LPCSTR) 1000)
        public const int CERT_RETRIEVE_BIOMETRIC_PREDEFINED_BASE_TYPE = 1000;

        public const int CERT_RETRIEVE_BIOMETRIC_PICTURE_TYPE = CERT_RETRIEVE_BIOMETRIC_PREDEFINED_BASE_TYPE + CERT_BIOMETRIC_PICTURE_TYPE;

        public const int CERT_RETRIEVE_BIOMETRIC_SIGNATURE_TYPE = CERT_RETRIEVE_BIOMETRIC_PREDEFINED_BASE_TYPE + CERT_BIOMETRIC_SIGNATURE_TYPE;

        public const int CERT_SELECT_LAST = CERT_SELECT_BY_TLS_SIGNATURES;

        public const int CERT_SELECT_MAX = CERT_SELECT_LAST * 3;

        // Line 149:   #define GET_ALG_CLASS(x)                (x & (7 << 13))
        // Line 150:   #define GET_ALG_TYPE(x)                 (x & (15 << 9))
        // Line 151:   #define GET_ALG_SID(x)                  (x & (511))
        // Line 577:   #define RCRYPT_SUCCEEDED(rt)     ((rt) == CRYPT_SUCCEED)
        // Line 578:   #define RCRYPT_FAILED(rt)        ((rt) == CRYPT_FAILED)
        // Line 2139:  #define IS_CERT_RDN_CHAR_STRING(X)      \
        // Line 2559:  #define GET_CERT_ENCODING_TYPE(X)   (X & CERT_ENCODING_TYPE_MASK)
        // Line 2560:  #define GET_CMSG_ENCODING_TYPE(X)   (X & CMSG_ENCODING_TYPE_MASK)
        // Line 3862:  #define GET_CERT_UNICODE_RDN_ERR_INDEX(X)   \
        // Line 3864:  #define GET_CERT_UNICODE_ATTR_ERR_INDEX(X)  \
        // Line 3866:  #define GET_CERT_UNICODE_VALUE_ERR_INDEX(X) \
        // Line 4006:  #define GET_CERT_ALT_NAME_ENTRY_ERR_INDEX(X)   \
        // Line 4009:  #define GET_CERT_ALT_NAME_VALUE_ERR_INDEX(X) \
        // Line 4464:  #define GET_CRL_DIST_POINT_ERR_INDEX(X)   \
        // Line 4468:  #define IS_CRL_DIST_POINT_ERR_CRL_ISSUER(X)   \
        // Line 4498:  #define GET_CROSS_CERT_DIST_POINT_ERR_INDEX(X)   \
        // Line 4595:  #define IS_CERT_EXCLUDED_SUBTREE(X)     \
        // Line 6184:  #define IS_SPECIAL_OID_INFO_ALGID(Algid)        (Algid >= CALG_OID_INFO_PARAMETERS)
        // Line 6573:  #define CERT_STRONG_SIGN_PARA_OS_1 \
        // Line 6580:  #define CERT_STRONG_SIGN_PARA_OS_CURRENT \
        // Line 6599:  #define CERT_STRONG_KEY_PARA_OS_1 \
        // Line 6606:  #define CERT_STRONG_KEY_PARA_OS_CURRENT \
        // Line 9209:  #define IS_CERT_HASH_PROP_ID(X)     (CERT_SHA1_HASH_PROP_ID == (X) || \
        // Line 9214:  #define IS_PUBKEY_HASH_PROP_ID(X)     (CERT_ISSUER_PUBLIC_KEY_MD5_HASH_PROP_ID == (X) || \
        // Line 9218:  #define IS_CHAIN_HASH_PROP_ID(X)     (CERT_ISSUER_PUBLIC_KEY_MD5_HASH_PROP_ID == (X) || \
        // Line 9224:  #define IS_STRONG_SIGN_PROP_ID(X)     (CERT_SIGN_HASH_CNG_ALG_PROP_ID == (X) || \
        // Line 9235:  #define _szPROP_ID(PropId)       #PropId
        // Line 9238:  #define szOID_CERT_PROP_ID(PropId) szOID_CERT_PROP_ID_PREFIX _szPROP_ID(PropId)
        // Line 9241:  #define __CRYPT32WTEXT(quote)           L##quote
        // Line 9242:  #define _CRYPT32WTEXT(quote)            __CRYPT32WTEXT(quote)
        // Line 9243:  #define wszOID_CERT_PROP_ID(PropId) \
    }
}
