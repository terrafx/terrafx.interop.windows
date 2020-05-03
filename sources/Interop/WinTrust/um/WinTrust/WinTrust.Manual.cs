// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class WinTrust
    {
        public const string WINTRUST_CONFIG_REGPATH = "Software\\Microsoft\\Cryptography\\Wintrust\\Config";

        public const string WINTRUST_MAX_HEADER_BYTES_TO_MAP_VALUE_NAME = "MaxHeaderBytesToMap";

        public const int WINTRUST_MAX_HEADER_BYTES_TO_MAP_DEFAULT = 0x00A00000;

        public const string WINTRUST_MAX_HASH_BYTES_TO_MAP_VALUE_NAME = "MaxHashBytesToMap";

        public const int WINTRUST_MAX_HASH_BYTES_TO_MAP_DEFAULT = 0x00100000;

        public const int WTD_UI_ALL = 1;

        public const int WTD_UI_NONE = 2;

        public const int WTD_UI_NOBAD = 3;

        public const int WTD_UI_NOGOOD = 4;

        public const int WTD_REVOKE_NONE = 0x00000000;

        public const int WTD_REVOKE_WHOLECHAIN = 0x00000001;

        public const int WTD_CHOICE_FILE = 1;

        public const int WTD_CHOICE_CATALOG = 2;

        public const int WTD_CHOICE_BLOB = 3;

        public const int WTD_CHOICE_SIGNER = 4;

        public const int WTD_CHOICE_CERT = 5;

        public const int WTD_STATEACTION_IGNORE = 0x00000000;

        public const int WTD_STATEACTION_VERIFY = 0x00000001;

        public const int WTD_STATEACTION_CLOSE = 0x00000002;

        public const int WTD_STATEACTION_AUTO_CACHE = 0x00000003;

        public const int WTD_STATEACTION_AUTO_CACHE_FLUSH = 0x00000004;

        public const int WTD_PROV_FLAGS_MASK = 0x0000FFFF;

        public const int WTD_USE_IE4_TRUST_FLAG = 0x00000001;

        public const int WTD_NO_IE4_CHAIN_FLAG = 0x00000002;

        public const int WTD_NO_POLICY_USAGE_FLAG = 0x00000004;

        public const int WTD_REVOCATION_CHECK_NONE = 0x00000010;

        public const int WTD_REVOCATION_CHECK_END_CERT = 0x00000020;

        public const int WTD_REVOCATION_CHECK_CHAIN = 0x00000040;

        public const int WTD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x00000080;

        public const int WTD_SAFER_FLAG = 0x00000100;

        public const int WTD_HASH_ONLY_FLAG = 0x00000200;

        public const int WTD_USE_DEFAULT_OSVER_CHECK = 0x00000400;

        public const int WTD_LIFETIME_SIGNING_FLAG = 0x00000800;

        public const int WTD_CACHE_ONLY_URL_RETRIEVAL = 0x00001000;

        public const int WTD_DISABLE_MD2_MD4 = 0x00002000;

        public const int WTD_MOTW = 0x00004000;

        public const int WTD_CODE_INTEGRITY_DRIVER_MODE = 0x00008000;

        public const int WTD_UICONTEXT_EXECUTE = 0;

        public const int WTD_UICONTEXT_INSTALL = 1;

        public const int WSS_VERIFY_SPECIFIC = 0x00000001;

        public const int WSS_GET_SECONDARY_SIG_COUNT = 0x00000002;

        public const int WSS_VERIFY_SEALING = 0x00000004;

        public const int WSS_INPUT_FLAG_MASK = 0x00000007;

        public const uint WSS_OUT_SEALING_STATUS_VERIFIED = 0x80000000;

        public const int WSS_OUT_HAS_SEALING_INTENT = 0x40000000;

        public const int WSS_OUT_FILE_SUPPORTS_SEAL = 0x20000000;

        public const uint WSS_OUTPUT_FLAG_MASK = 0xE0000000;

        public const int WTCI_DONT_OPEN_STORES = 0x00000001;

        public const int WTCI_OPEN_ONLY_ROOT = 0x00000002;

        public const int WTCI_USE_LOCAL_MACHINE = 0x00000004;

        public const int WTPF_TRUSTTEST = 0x00000020;

        public const int WTPF_TESTCANBEVALID = 0x00000080;

        public const int WTPF_IGNOREEXPIRATION = 0x00000100;

        public const int WTPF_IGNOREREVOKATION = 0x00000200;

        public const int WTPF_OFFLINEOK_IND = 0x00000400;

        public const int WTPF_OFFLINEOK_COM = 0x00000800;

        public const int WTPF_OFFLINEOKNBU_IND = 0x00001000;

        public const int WTPF_OFFLINEOKNBU_COM = 0x00002000;

        public const int WTPF_VERIFY_V1_OFF = 0x00010000;

        public const int WTPF_IGNOREREVOCATIONONTS = 0x00020000;

        public const int WTPF_ALLOWONLYPERTRUST = 0x00040000;

        public const int TRUSTERROR_STEP_WVTPARAMS = 0;

        public const int TRUSTERROR_STEP_FILEIO = 2;

        public const int TRUSTERROR_STEP_SIP = 3;

        public const int TRUSTERROR_STEP_SIPSUBJINFO = 5;

        public const int TRUSTERROR_STEP_CATALOGFILE = 6;

        public const int TRUSTERROR_STEP_CERTSTORE = 7;

        public const int TRUSTERROR_STEP_MESSAGE = 8;

        public const int TRUSTERROR_STEP_MSG_SIGNERCOUNT = 9;

        public const int TRUSTERROR_STEP_MSG_INNERCNTTYPE = 10;

        public const int TRUSTERROR_STEP_MSG_INNERCNT = 11;

        public const int TRUSTERROR_STEP_MSG_STORE = 12;

        public const int TRUSTERROR_STEP_MSG_SIGNERINFO = 13;

        public const int TRUSTERROR_STEP_MSG_SIGNERCERT = 14;

        public const int TRUSTERROR_STEP_MSG_CERTCHAIN = 15;

        public const int TRUSTERROR_STEP_MSG_COUNTERSIGINFO = 16;

        public const int TRUSTERROR_STEP_MSG_COUNTERSIGCERT = 17;

        public const int TRUSTERROR_STEP_VERIFY_MSGHASH = 18;

        public const int TRUSTERROR_STEP_VERIFY_MSGINDIRECTDATA = 19;

        public const int TRUSTERROR_STEP_FINAL_WVTINIT = 30;

        public const int TRUSTERROR_STEP_FINAL_INITPROV = 31;

        public const int TRUSTERROR_STEP_FINAL_OBJPROV = 32;

        public const int TRUSTERROR_STEP_FINAL_SIGPROV = 33;

        public const int TRUSTERROR_STEP_FINAL_CERTPROV = 34;

        public const int TRUSTERROR_STEP_FINAL_CERTCHKPROV = 35;

        public const int TRUSTERROR_STEP_FINAL_POLICYPROV = 36;

        public const int TRUSTERROR_STEP_FINAL_UIPROV = 37;

        public const int TRUSTERROR_MAX_STEPS = 38;

        public const int CPD_CHOICE_SIP = 1;

        public const uint CPD_USE_NT5_CHAIN_FLAG = 0x80000000;

        public const int CPD_REVOCATION_CHECK_NONE = 0x00010000;

        public const int CPD_REVOCATION_CHECK_END_CERT = 0x00020000;

        public const int CPD_REVOCATION_CHECK_CHAIN = 0x00040000;

        public const int CPD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x00080000;

        public const int CPD_RETURN_LOWER_QUALITY_CHAINS = 0x00100000;

        public const int CPD_UISTATE_MODE_PROMPT = 0x00000000;

        public const int CPD_UISTATE_MODE_BLOCK = 0x00000001;

        public const int CPD_UISTATE_MODE_ALLOW = 0x00000002;

        public const int CPD_UISTATE_MODE_MASK = 0x00000003;

        public const int WSS_OBJTRUST_SUPPORT = 0x00000001;

        public const int WSS_SIGTRUST_SUPPORT = 0x00000002;

        public const int WSS_CERTTRUST_SUPPORT = 0x00000004;

        public const int SGNR_TYPE_TIMESTAMP = 0x00000010;

        public const int CERT_CONFIDENCE_SIG = 0x10000000;

        public const int CERT_CONFIDENCE_TIME = 0x01000000;

        public const int CERT_CONFIDENCE_TIMENEST = 0x00100000;

        public const int CERT_CONFIDENCE_AUTHIDEXT = 0x00010000;

        public const int CERT_CONFIDENCE_HYGIENE = 0x00001000;

        public const int CERT_CONFIDENCE_HIGHEST = 0x11111000;

        public const int WT_CURRENT_VERSION = 0x00000200;

        public const string WT_PROVIDER_DLL_NAME = "WINTRUST.DLL";

        public const string WT_PROVIDER_CERTTRUST_FUNCTION = "WintrustCertificateTrust";

        public const int WT_ADD_ACTION_ID_RET_RESULT_FLAG = 0x1;

        public const int DWACTION_ALLOCANDFILL = 1;

        public const int DWACTION_FREE = 2;

        // 1.3.6.1.4.1.311.2.2.1
        public static ReadOnlySpan<sbyte> szOID_TRUSTED_CODESIGNING_CA_LIST => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.2.2.2
        public static ReadOnlySpan<sbyte> szOID_TRUSTED_CLIENT_AUTH_CA_LIST => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.2.2.3
        public static ReadOnlySpan<sbyte> szOID_TRUSTED_SERVER_AUTH_CA_LIST => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        // 1.3.6.1.4.1.311.3.2.1
        public static ReadOnlySpan<sbyte> SPC_TIME_STAMP_REQUEST_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.2.1.4
        public static ReadOnlySpan<sbyte> SPC_INDIRECT_DATA_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.2.1.10
        public static ReadOnlySpan<sbyte> SPC_SP_AGENCY_INFO_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x00 };

        // 1.3.6.1.4.1.311.2.1.11
        public static ReadOnlySpan<sbyte> SPC_STATEMENT_TYPE_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.2.1.12
        public static ReadOnlySpan<sbyte> SPC_SP_OPUS_INFO_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.2.1.14
        public static ReadOnlySpan<sbyte> SPC_CERT_EXTENSIONS_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.2.1.15
        public static ReadOnlySpan<sbyte> SPC_PE_IMAGE_DATA_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x35, 0x00 };

        // 1.3.6.1.4.1.311.2.1.18
        public static ReadOnlySpan<sbyte> SPC_RAW_FILE_DATA_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x38, 0x00 };

        // 1.3.6.1.4.1.311.2.1.19
        public static ReadOnlySpan<sbyte> SPC_STRUCTURED_STORAGE_DATA_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x39, 0x00 };

        // 1.3.6.1.4.1.311.2.1.20
        public static ReadOnlySpan<sbyte> SPC_JAVA_CLASS_DATA_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x30, 0x00 };

        // 1.3.6.1.4.1.311.2.1.21
        public static ReadOnlySpan<sbyte> SPC_INDIVIDUAL_SP_KEY_PURPOSE_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.2.1.22
        public static ReadOnlySpan<sbyte> SPC_COMMERCIAL_SP_KEY_PURPOSE_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.2.1.25
        public static ReadOnlySpan<sbyte> SPC_CAB_DATA_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x35, 0x00 };

        // 1.3.6.1.4.1.311.2.1.25
        public static ReadOnlySpan<sbyte> SPC_GLUE_RDN_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x35, 0x00 };

        // 1.3.6.1.4.1.311.2.1.26
        public static ReadOnlySpan<sbyte> SPC_MINIMAL_CRITERIA_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x36, 0x00 };

        // 1.3.6.1.4.1.311.2.1.27
        public static ReadOnlySpan<sbyte> SPC_FINANCIAL_CRITERIA_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x37, 0x00 };

        // 1.3.6.1.4.1.311.2.1.28
        public static ReadOnlySpan<sbyte> SPC_LINK_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x38, 0x00 };

        // 1.3.6.1.4.1.311.2.1.30
        public static ReadOnlySpan<sbyte> SPC_SIGINFO_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x33, 0x30, 0x00 };

        // 1.3.6.1.4.1.311.2.3.1
        public static ReadOnlySpan<sbyte> SPC_PE_IMAGE_PAGE_HASHES_V1_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.2.3.2
        public static ReadOnlySpan<sbyte> SPC_PE_IMAGE_PAGE_HASHES_V2_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x33, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.2.4.1
        public static ReadOnlySpan<sbyte> szOID_NESTED_SIGNATURE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x34, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.2.4.2
        public static ReadOnlySpan<sbyte> szOID_INTENT_TO_SEAL => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x34, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.2.4.3
        public static ReadOnlySpan<sbyte> szOID_SEALING_SIGNATURE => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x34, 0x2E, 0x33, 0x00 };

        // 1.3.6.1.4.1.311.2.4.4
        public static ReadOnlySpan<sbyte> szOID_SEALING_TIMESTAMP => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x34, 0x2E, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.2.5.1
        public static ReadOnlySpan<sbyte> szOID_ENHANCED_HASH => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x35, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.2.6.1
        public static ReadOnlySpan<sbyte> SPC_RELAXED_PE_MARKER_CHECK_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x36, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.2.6.2
        public static ReadOnlySpan<sbyte> SPC_ENCRYPTED_DIGEST_RETRY_COUNT_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x36, 0x2E, 0x32, 0x00 };

        // 1.2.840.113549.1.9.25.4
        public static ReadOnlySpan<sbyte> szOID_PKCS_9_SEQUENCE_NUMBER => new sbyte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x32, 0x35, 0x2E, 0x34, 0x00 };

        // 1.3.6.1.4.1.311.12.2.1
        public static ReadOnlySpan<sbyte> CAT_NAMEVALUE_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.12.2.2
        public static ReadOnlySpan<sbyte> CAT_MEMBERINFO_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        // 1.3.6.1.4.1.311.12.2.3
        public static ReadOnlySpan<sbyte> CAT_MEMBERINFO2_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        // 1.3.6.1.4.1.311.10.41.1
        public static ReadOnlySpan<sbyte> SPC_WINDOWS_HELLO_COMPATIBILITY_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x34, 0x31, 0x2E, 0x31, 0x00 };

        // 1.3.6.1.4.1.311.96.1.1
        public static ReadOnlySpan<sbyte> SPC_NATURAL_AUTH_PLUGIN_OBJID => new sbyte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x39, 0x36, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        public const int SPC_UUID_LENGTH = 16;

        public const int SPC_URL_LINK_CHOICE = 1;

        public const int SPC_MONIKER_LINK_CHOICE = 2;

        public const int SPC_FILE_LINK_CHOICE = 3;

        public const int WT_TRUSTDBDIALOG_NO_UI_FLAG = 0x00000001;

        public const int WT_TRUSTDBDIALOG_ONLY_PUB_TAB_FLAG = 0x00000002;

        public const int WT_TRUSTDBDIALOG_WRITE_LEGACY_REG_FLAG = 0x00000100;

        public const int WT_TRUSTDBDIALOG_WRITE_IEAK_STORE_FLAG = 0x00000200;

        public static ReadOnlySpan<sbyte> SPC_COMMON_NAME_OBJID => Advapi32.szOID_COMMON_NAME;

        // ((LPCSTR) 2000)
        public const int SPC_SP_AGENCY_INFO_STRUCT = 2000;

        // ((LPCSTR) 2001)
        public const int SPC_MINIMAL_CRITERIA_STRUCT = 2001;

        // ((LPCSTR) 2002)
        public const int SPC_FINANCIAL_CRITERIA_STRUCT = 2002;

        // ((LPCSTR) 2003)
        public const int SPC_INDIRECT_DATA_CONTENT_STRUCT = 2003;

        // ((LPCSTR) 2004)
        public const int SPC_PE_IMAGE_DATA_STRUCT = 2004;

        // ((LPCSTR) 2005)
        public const int SPC_LINK_STRUCT = 2005;

        // ((LPCSTR) 2006)
        public const int SPC_STATEMENT_TYPE_STRUCT = 2006;

        // ((LPCSTR) 2007)
        public const int SPC_SP_OPUS_INFO_STRUCT = 2007;

        // ((LPCSTR) 2008)
        public const int SPC_CAB_DATA_STRUCT = 2008;

        // ((LPCSTR) 2009)
        public const int SPC_JAVA_CLASS_DATA_STRUCT = 2009;

        // ((LPCSTR) 2010)
        public const int INTENT_TO_SEAL_ATTRIBUTE_STRUCT = 2010;

        // ((LPCSTR) 2011)
        public const int SEALING_SIGNATURE_ATTRIBUTE_STRUCT = 2011;

        // ((LPCSTR) 2012)
        public const int SEALING_TIMESTAMP_ATTRIBUTE_STRUCT = 2012;

        // ((LPCSTR) 2130)
        public const int SPC_SIGINFO_STRUCT = 2130;

        // ((LPCSTR) 2221)
        public const int CAT_NAMEVALUE_STRUCT = 2221;

        // ((LPCSTR) 2222)
        public const int CAT_MEMBERINFO_STRUCT = 2222;

        // ((LPCSTR) 2223)
        public const int CAT_MEMBERINFO2_STRUCT = 2223;

        public static ReadOnlySpan<byte> SpcSerializedObjectAttributesClassId => new byte[] { 0xA6, 0xB5, 0x86, 0xD5, 0xB4, 0xA1, 0x24, 0x66, 0xAE, 0x05, 0xA2, 0x17, 0xDA, 0x8E, 0x60, 0xD6 };

        public const int WIN_CERT_REVISION_1_0 = 0x0100;

        public const int WIN_CERT_REVISION_2_0 = 0x0200;

        public const int WIN_CERT_TYPE_X509 = 0x0001;

        public const int WIN_CERT_TYPE_PKCS_SIGNED_DATA = 0x0002;

        public const int WIN_CERT_TYPE_RESERVED_1 = 0x0003;

        public const int WIN_CERT_TYPE_TS_STACK_SIGNED = 0x0004;

        public static readonly Guid WIN_TRUST_SUBJTYPE_RAW_FILE = new Guid(0x959DC450, 0x8D9E, 0x11CF, 0x87, 0x36, 0x00, 0xAA, 0x00, 0xA4, 0x85, 0xEB);

        public static readonly Guid WIN_TRUST_SUBJTYPE_PE_IMAGE = new Guid(0x43C9A1E0, 0x8DA0, 0x11CF, 0x87, 0x36, 0x00, 0xAA, 0x00, 0xA4, 0x85, 0xEB);

        public static readonly Guid WIN_TRUST_SUBJTYPE_JAVA_CLASS = new Guid(0x08AD3990, 0x8DA1, 0x11CF, 0x87, 0x36, 0x00, 0xAA, 0x00, 0xA4, 0x85, 0xEB);

        public static readonly Guid WIN_TRUST_SUBJTYPE_CABINET = new Guid(0xD17C5374, 0xA392, 0x11CF, 0x9D, 0xF5, 0x0, 0xAA, 0x0, 0xC1, 0x84, 0xE0);

        public static readonly Guid WIN_TRUST_SUBJTYPE_RAW_FILEEX = new Guid(0x6F458110, 0xC2F1, 0x11CF, 0x8A, 0x69, 0x0, 0xAA, 0x0, 0x6C, 0x37, 0x6);

        public static readonly Guid WIN_TRUST_SUBJTYPE_PE_IMAGEEX = new Guid(0x6F458111, 0xC2F1, 0x11CF, 0x8A, 0x69, 0x0, 0xAA, 0x0, 0x6C, 0x37, 0x6);

        public static readonly Guid WIN_TRUST_SUBJTYPE_JAVA_CLASSEX = new Guid(0x6F458113, 0xC2F1, 0x11CF, 0x8A, 0x69, 0x0, 0xAA, 0x0, 0x6C, 0x37, 0x6);

        public static readonly Guid WIN_TRUST_SUBJTYPE_CABINETEX = new Guid(0x6F458114, 0xC2F1, 0x11CF, 0x8A, 0x69, 0x0, 0xAA, 0x0, 0x6C, 0x37, 0x6);

        public static readonly Guid WIN_TRUST_SUBJTYPE_OLE_STORAGE = new Guid(0xC257E740, 0x8DA0, 0x11CF, 0x87, 0x36, 0x00, 0xAA, 0x00, 0xA4, 0x85, 0xEB);

        public static readonly Guid WIN_SPUB_ACTION_TRUSTED_PUBLISHER = new Guid(0x66426730, 0x8DA1, 0x11CF, 0x87, 0x36, 0x00, 0xAA, 0x00, 0xA4, 0x85, 0xEB);

        public static readonly Guid WIN_SPUB_ACTION_NT_ACTIVATE_IMAGE = new Guid(0x8BC96B00, 0x8DA1, 0x11CF, 0x87, 0x36, 0x00, 0xAA, 0x00, 0xA4, 0x85, 0xEB);

        public static readonly Guid WIN_SPUB_ACTION_PUBLISHED_SOFTWARE = new Guid(0x64B9D180, 0x8DA2, 0x11CF, 0x87, 0x36, 0x00, 0xAA, 0x00, 0xA4, 0x85, 0xEB);

        // Line 629:  #define WVT_OFFSETOF(t,f)   ((ULONG)((ULONG_PTR)(&((t*)0)->f)))
        // Line 633:  #define WVT_ISINSTRUCT(structtypedef, structpassedsize, member) \
        // Line 637:  #define WVT_IS_CBSTRUCT_GT_MEMBEROFFSET(structtypedef, structpassedsize, member) \
    }
}
