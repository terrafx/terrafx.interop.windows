// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("wintrust", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int WinVerifyTrust(HWND hwnd, Guid* pgActionID, [NativeTypeName("LPVOID")] void* pWVTData);

        [DllImport("wintrust", ExactSpelling = true)]
        public static extern HRESULT WinVerifyTrustEx(HWND hwnd, Guid* pgActionID, WINTRUST_DATA* pWinTrustData);

        [DllImport("wintrust", ExactSpelling = true)]
        public static extern void WintrustGetRegPolicyFlags([NativeTypeName("DWORD *")] uint* pdwPolicyFlags);

        [DllImport("wintrust", ExactSpelling = true)]
        public static extern BOOL WintrustSetRegPolicyFlags([NativeTypeName("DWORD")] uint dwPolicyFlags);

        [DllImport("wintrust", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WintrustAddActionID(Guid* pgActionID, [NativeTypeName("DWORD")] uint fdwFlags, CRYPT_REGISTER_ACTIONID* psProvInfo);

        [DllImport("wintrust", ExactSpelling = true)]
        public static extern BOOL WintrustRemoveActionID(Guid* pgActionID);

        [DllImport("wintrust", ExactSpelling = true)]
        public static extern BOOL WintrustLoadFunctionPointers(Guid* pgActionID, CRYPT_PROVIDER_FUNCTIONS* pPfns);

        [DllImport("wintrust", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WintrustAddDefaultForUsage([NativeTypeName("const char *")] sbyte* pszUsageOID, CRYPT_PROVIDER_REGDEFUSAGE* psDefUsage);

        [DllImport("wintrust", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WintrustGetDefaultForUsage([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("const char *")] sbyte* pszUsageOID, CRYPT_PROVIDER_DEFUSAGE* psUsage);

        [DllImport("wintrust", ExactSpelling = true)]
        public static extern CRYPT_PROVIDER_SGNR* WTHelperGetProvSignerFromChain(CRYPT_PROVIDER_DATA* pProvData, [NativeTypeName("DWORD")] uint idxSigner, BOOL fCounterSigner, [NativeTypeName("DWORD")] uint idxCounterSigner);

        [DllImport("wintrust", ExactSpelling = true)]
        public static extern CRYPT_PROVIDER_CERT* WTHelperGetProvCertFromChain(CRYPT_PROVIDER_SGNR* pSgnr, [NativeTypeName("DWORD")] uint idxCert);

        [DllImport("wintrust", ExactSpelling = true)]
        public static extern CRYPT_PROVIDER_DATA* WTHelperProvDataFromStateData(HANDLE hStateData);

        [DllImport("wintrust", ExactSpelling = true)]
        public static extern CRYPT_PROVIDER_PRIVDATA* WTHelperGetProvPrivateDataFromChain(CRYPT_PROVIDER_DATA* pProvData, Guid* pgProviderID);

        [DllImport("wintrust", ExactSpelling = true)]
        public static extern BOOL WTHelperCertIsSelfSigned([NativeTypeName("DWORD")] uint dwEncoding, CERT_INFO* pCert);

        [DllImport("wintrust", ExactSpelling = true)]
        public static extern HRESULT WTHelperCertCheckValidSignature(CRYPT_PROVIDER_DATA* pProvData);

        [DllImport("wintrust", ExactSpelling = true)]
        public static extern BOOL OpenPersonalTrustDBDialogEx(HWND hwndParent, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PVOID *")] void** pvReserved);

        [DllImport("wintrust", ExactSpelling = true)]
        public static extern BOOL OpenPersonalTrustDBDialog(HWND hwndParent);

        [DllImport("wintrust", ExactSpelling = true)]
        public static extern void WintrustSetDefaultIncludePEPageHashes(BOOL fIncludePEPageHashes);

        [NativeTypeName("#define WINTRUST_CONFIG_REGPATH L\"Software\\\\Microsoft\\\\Cryptography\\\\Wintrust\\\\Config\"")]
        public const string WINTRUST_CONFIG_REGPATH = "Software\\Microsoft\\Cryptography\\Wintrust\\Config";

        [NativeTypeName("#define WINTRUST_MAX_HEADER_BYTES_TO_MAP_VALUE_NAME L\"MaxHeaderBytesToMap\"")]
        public const string WINTRUST_MAX_HEADER_BYTES_TO_MAP_VALUE_NAME = "MaxHeaderBytesToMap";

        [NativeTypeName("#define WINTRUST_MAX_HEADER_BYTES_TO_MAP_DEFAULT 0x00A00000")]
        public const int WINTRUST_MAX_HEADER_BYTES_TO_MAP_DEFAULT = 0x00A00000;

        [NativeTypeName("#define WINTRUST_MAX_HASH_BYTES_TO_MAP_VALUE_NAME L\"MaxHashBytesToMap\"")]
        public const string WINTRUST_MAX_HASH_BYTES_TO_MAP_VALUE_NAME = "MaxHashBytesToMap";

        [NativeTypeName("#define WINTRUST_MAX_HASH_BYTES_TO_MAP_DEFAULT 0x00100000")]
        public const int WINTRUST_MAX_HASH_BYTES_TO_MAP_DEFAULT = 0x00100000;

        [NativeTypeName("#define WTD_UI_ALL 1")]
        public const int WTD_UI_ALL = 1;

        [NativeTypeName("#define WTD_UI_NONE 2")]
        public const int WTD_UI_NONE = 2;

        [NativeTypeName("#define WTD_UI_NOBAD 3")]
        public const int WTD_UI_NOBAD = 3;

        [NativeTypeName("#define WTD_UI_NOGOOD 4")]
        public const int WTD_UI_NOGOOD = 4;

        [NativeTypeName("#define WTD_REVOKE_NONE 0x00000000")]
        public const int WTD_REVOKE_NONE = 0x00000000;

        [NativeTypeName("#define WTD_REVOKE_WHOLECHAIN 0x00000001")]
        public const int WTD_REVOKE_WHOLECHAIN = 0x00000001;

        [NativeTypeName("#define WTD_CHOICE_FILE 1")]
        public const int WTD_CHOICE_FILE = 1;

        [NativeTypeName("#define WTD_CHOICE_CATALOG 2")]
        public const int WTD_CHOICE_CATALOG = 2;

        [NativeTypeName("#define WTD_CHOICE_BLOB 3")]
        public const int WTD_CHOICE_BLOB = 3;

        [NativeTypeName("#define WTD_CHOICE_SIGNER 4")]
        public const int WTD_CHOICE_SIGNER = 4;

        [NativeTypeName("#define WTD_CHOICE_CERT 5")]
        public const int WTD_CHOICE_CERT = 5;

        [NativeTypeName("#define WTD_STATEACTION_IGNORE 0x00000000")]
        public const int WTD_STATEACTION_IGNORE = 0x00000000;

        [NativeTypeName("#define WTD_STATEACTION_VERIFY 0x00000001")]
        public const int WTD_STATEACTION_VERIFY = 0x00000001;

        [NativeTypeName("#define WTD_STATEACTION_CLOSE 0x00000002")]
        public const int WTD_STATEACTION_CLOSE = 0x00000002;

        [NativeTypeName("#define WTD_STATEACTION_AUTO_CACHE 0x00000003")]
        public const int WTD_STATEACTION_AUTO_CACHE = 0x00000003;

        [NativeTypeName("#define WTD_STATEACTION_AUTO_CACHE_FLUSH 0x00000004")]
        public const int WTD_STATEACTION_AUTO_CACHE_FLUSH = 0x00000004;

        [NativeTypeName("#define WTD_PROV_FLAGS_MASK 0x0000FFFF")]
        public const int WTD_PROV_FLAGS_MASK = 0x0000FFFF;

        [NativeTypeName("#define WTD_USE_IE4_TRUST_FLAG 0x00000001")]
        public const int WTD_USE_IE4_TRUST_FLAG = 0x00000001;

        [NativeTypeName("#define WTD_NO_IE4_CHAIN_FLAG 0x00000002")]
        public const int WTD_NO_IE4_CHAIN_FLAG = 0x00000002;

        [NativeTypeName("#define WTD_NO_POLICY_USAGE_FLAG 0x00000004")]
        public const int WTD_NO_POLICY_USAGE_FLAG = 0x00000004;

        [NativeTypeName("#define WTD_REVOCATION_CHECK_NONE 0x00000010")]
        public const int WTD_REVOCATION_CHECK_NONE = 0x00000010;

        [NativeTypeName("#define WTD_REVOCATION_CHECK_END_CERT 0x00000020")]
        public const int WTD_REVOCATION_CHECK_END_CERT = 0x00000020;

        [NativeTypeName("#define WTD_REVOCATION_CHECK_CHAIN 0x00000040")]
        public const int WTD_REVOCATION_CHECK_CHAIN = 0x00000040;

        [NativeTypeName("#define WTD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT 0x00000080")]
        public const int WTD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x00000080;

        [NativeTypeName("#define WTD_SAFER_FLAG 0x00000100")]
        public const int WTD_SAFER_FLAG = 0x00000100;

        [NativeTypeName("#define WTD_HASH_ONLY_FLAG 0x00000200")]
        public const int WTD_HASH_ONLY_FLAG = 0x00000200;

        [NativeTypeName("#define WTD_USE_DEFAULT_OSVER_CHECK 0x00000400")]
        public const int WTD_USE_DEFAULT_OSVER_CHECK = 0x00000400;

        [NativeTypeName("#define WTD_LIFETIME_SIGNING_FLAG 0x00000800")]
        public const int WTD_LIFETIME_SIGNING_FLAG = 0x00000800;

        [NativeTypeName("#define WTD_CACHE_ONLY_URL_RETRIEVAL 0x00001000")]
        public const int WTD_CACHE_ONLY_URL_RETRIEVAL = 0x00001000;

        [NativeTypeName("#define WTD_DISABLE_MD2_MD4 0x00002000")]
        public const int WTD_DISABLE_MD2_MD4 = 0x00002000;

        [NativeTypeName("#define WTD_MOTW 0x00004000")]
        public const int WTD_MOTW = 0x00004000;

        [NativeTypeName("#define WTD_CODE_INTEGRITY_DRIVER_MODE 0x00008000")]
        public const int WTD_CODE_INTEGRITY_DRIVER_MODE = 0x00008000;

        [NativeTypeName("#define WTD_UICONTEXT_EXECUTE 0")]
        public const int WTD_UICONTEXT_EXECUTE = 0;

        [NativeTypeName("#define WTD_UICONTEXT_INSTALL 1")]
        public const int WTD_UICONTEXT_INSTALL = 1;

        [NativeTypeName("#define WSS_VERIFY_SPECIFIC 0x00000001")]
        public const int WSS_VERIFY_SPECIFIC = 0x00000001;

        [NativeTypeName("#define WSS_GET_SECONDARY_SIG_COUNT 0x00000002")]
        public const int WSS_GET_SECONDARY_SIG_COUNT = 0x00000002;

        [NativeTypeName("#define WSS_VERIFY_SEALING 0x00000004")]
        public const int WSS_VERIFY_SEALING = 0x00000004;

        [NativeTypeName("#define WSS_INPUT_FLAG_MASK 0x00000007")]
        public const int WSS_INPUT_FLAG_MASK = 0x00000007;

        [NativeTypeName("#define WSS_OUT_SEALING_STATUS_VERIFIED 0x80000000")]
        public const uint WSS_OUT_SEALING_STATUS_VERIFIED = 0x80000000;

        [NativeTypeName("#define WSS_OUT_HAS_SEALING_INTENT 0x40000000")]
        public const int WSS_OUT_HAS_SEALING_INTENT = 0x40000000;

        [NativeTypeName("#define WSS_OUT_FILE_SUPPORTS_SEAL 0x20000000")]
        public const int WSS_OUT_FILE_SUPPORTS_SEAL = 0x20000000;

        [NativeTypeName("#define WSS_OUTPUT_FLAG_MASK 0xe0000000")]
        public const uint WSS_OUTPUT_FLAG_MASK = 0xe0000000;

        [NativeTypeName("#define WTCI_DONT_OPEN_STORES 0x00000001")]
        public const int WTCI_DONT_OPEN_STORES = 0x00000001;

        [NativeTypeName("#define WTCI_OPEN_ONLY_ROOT 0x00000002")]
        public const int WTCI_OPEN_ONLY_ROOT = 0x00000002;

        [NativeTypeName("#define WTCI_USE_LOCAL_MACHINE 0x00000004")]
        public const int WTCI_USE_LOCAL_MACHINE = 0x00000004;

        [NativeTypeName("#define WTPF_TRUSTTEST 0x00000020")]
        public const int WTPF_TRUSTTEST = 0x00000020;

        [NativeTypeName("#define WTPF_TESTCANBEVALID 0x00000080")]
        public const int WTPF_TESTCANBEVALID = 0x00000080;

        [NativeTypeName("#define WTPF_IGNOREEXPIRATION 0x00000100")]
        public const int WTPF_IGNOREEXPIRATION = 0x00000100;

        [NativeTypeName("#define WTPF_IGNOREREVOKATION 0x00000200")]
        public const int WTPF_IGNOREREVOKATION = 0x00000200;

        [NativeTypeName("#define WTPF_OFFLINEOK_IND 0x00000400")]
        public const int WTPF_OFFLINEOK_IND = 0x00000400;

        [NativeTypeName("#define WTPF_OFFLINEOK_COM 0x00000800")]
        public const int WTPF_OFFLINEOK_COM = 0x00000800;

        [NativeTypeName("#define WTPF_OFFLINEOKNBU_IND 0x00001000")]
        public const int WTPF_OFFLINEOKNBU_IND = 0x00001000;

        [NativeTypeName("#define WTPF_OFFLINEOKNBU_COM 0x00002000")]
        public const int WTPF_OFFLINEOKNBU_COM = 0x00002000;

        [NativeTypeName("#define WTPF_VERIFY_V1_OFF 0x00010000")]
        public const int WTPF_VERIFY_V1_OFF = 0x00010000;

        [NativeTypeName("#define WTPF_IGNOREREVOCATIONONTS 0x00020000")]
        public const int WTPF_IGNOREREVOCATIONONTS = 0x00020000;

        [NativeTypeName("#define WTPF_ALLOWONLYPERTRUST 0x00040000")]
        public const int WTPF_ALLOWONLYPERTRUST = 0x00040000;

        [NativeTypeName("#define TRUSTERROR_STEP_WVTPARAMS 0")]
        public const int TRUSTERROR_STEP_WVTPARAMS = 0;

        [NativeTypeName("#define TRUSTERROR_STEP_FILEIO 2")]
        public const int TRUSTERROR_STEP_FILEIO = 2;

        [NativeTypeName("#define TRUSTERROR_STEP_SIP 3")]
        public const int TRUSTERROR_STEP_SIP = 3;

        [NativeTypeName("#define TRUSTERROR_STEP_SIPSUBJINFO 5")]
        public const int TRUSTERROR_STEP_SIPSUBJINFO = 5;

        [NativeTypeName("#define TRUSTERROR_STEP_CATALOGFILE 6")]
        public const int TRUSTERROR_STEP_CATALOGFILE = 6;

        [NativeTypeName("#define TRUSTERROR_STEP_CERTSTORE 7")]
        public const int TRUSTERROR_STEP_CERTSTORE = 7;

        [NativeTypeName("#define TRUSTERROR_STEP_MESSAGE 8")]
        public const int TRUSTERROR_STEP_MESSAGE = 8;

        [NativeTypeName("#define TRUSTERROR_STEP_MSG_SIGNERCOUNT 9")]
        public const int TRUSTERROR_STEP_MSG_SIGNERCOUNT = 9;

        [NativeTypeName("#define TRUSTERROR_STEP_MSG_INNERCNTTYPE 10")]
        public const int TRUSTERROR_STEP_MSG_INNERCNTTYPE = 10;

        [NativeTypeName("#define TRUSTERROR_STEP_MSG_INNERCNT 11")]
        public const int TRUSTERROR_STEP_MSG_INNERCNT = 11;

        [NativeTypeName("#define TRUSTERROR_STEP_MSG_STORE 12")]
        public const int TRUSTERROR_STEP_MSG_STORE = 12;

        [NativeTypeName("#define TRUSTERROR_STEP_MSG_SIGNERINFO 13")]
        public const int TRUSTERROR_STEP_MSG_SIGNERINFO = 13;

        [NativeTypeName("#define TRUSTERROR_STEP_MSG_SIGNERCERT 14")]
        public const int TRUSTERROR_STEP_MSG_SIGNERCERT = 14;

        [NativeTypeName("#define TRUSTERROR_STEP_MSG_CERTCHAIN 15")]
        public const int TRUSTERROR_STEP_MSG_CERTCHAIN = 15;

        [NativeTypeName("#define TRUSTERROR_STEP_MSG_COUNTERSIGINFO 16")]
        public const int TRUSTERROR_STEP_MSG_COUNTERSIGINFO = 16;

        [NativeTypeName("#define TRUSTERROR_STEP_MSG_COUNTERSIGCERT 17")]
        public const int TRUSTERROR_STEP_MSG_COUNTERSIGCERT = 17;

        [NativeTypeName("#define TRUSTERROR_STEP_VERIFY_MSGHASH 18")]
        public const int TRUSTERROR_STEP_VERIFY_MSGHASH = 18;

        [NativeTypeName("#define TRUSTERROR_STEP_VERIFY_MSGINDIRECTDATA 19")]
        public const int TRUSTERROR_STEP_VERIFY_MSGINDIRECTDATA = 19;

        [NativeTypeName("#define TRUSTERROR_STEP_FINAL_WVTINIT 30")]
        public const int TRUSTERROR_STEP_FINAL_WVTINIT = 30;

        [NativeTypeName("#define TRUSTERROR_STEP_FINAL_INITPROV 31")]
        public const int TRUSTERROR_STEP_FINAL_INITPROV = 31;

        [NativeTypeName("#define TRUSTERROR_STEP_FINAL_OBJPROV 32")]
        public const int TRUSTERROR_STEP_FINAL_OBJPROV = 32;

        [NativeTypeName("#define TRUSTERROR_STEP_FINAL_SIGPROV 33")]
        public const int TRUSTERROR_STEP_FINAL_SIGPROV = 33;

        [NativeTypeName("#define TRUSTERROR_STEP_FINAL_CERTPROV 34")]
        public const int TRUSTERROR_STEP_FINAL_CERTPROV = 34;

        [NativeTypeName("#define TRUSTERROR_STEP_FINAL_CERTCHKPROV 35")]
        public const int TRUSTERROR_STEP_FINAL_CERTCHKPROV = 35;

        [NativeTypeName("#define TRUSTERROR_STEP_FINAL_POLICYPROV 36")]
        public const int TRUSTERROR_STEP_FINAL_POLICYPROV = 36;

        [NativeTypeName("#define TRUSTERROR_STEP_FINAL_UIPROV 37")]
        public const int TRUSTERROR_STEP_FINAL_UIPROV = 37;

        [NativeTypeName("#define TRUSTERROR_MAX_STEPS 38")]
        public const int TRUSTERROR_MAX_STEPS = 38;

        [NativeTypeName("#define CPD_CHOICE_SIP 1")]
        public const int CPD_CHOICE_SIP = 1;

        [NativeTypeName("#define CPD_USE_NT5_CHAIN_FLAG 0x80000000")]
        public const uint CPD_USE_NT5_CHAIN_FLAG = 0x80000000;

        [NativeTypeName("#define CPD_REVOCATION_CHECK_NONE 0x00010000")]
        public const int CPD_REVOCATION_CHECK_NONE = 0x00010000;

        [NativeTypeName("#define CPD_REVOCATION_CHECK_END_CERT 0x00020000")]
        public const int CPD_REVOCATION_CHECK_END_CERT = 0x00020000;

        [NativeTypeName("#define CPD_REVOCATION_CHECK_CHAIN 0x00040000")]
        public const int CPD_REVOCATION_CHECK_CHAIN = 0x00040000;

        [NativeTypeName("#define CPD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT 0x00080000")]
        public const int CPD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x00080000;

        [NativeTypeName("#define CPD_RETURN_LOWER_QUALITY_CHAINS 0x00100000")]
        public const int CPD_RETURN_LOWER_QUALITY_CHAINS = 0x00100000;

        [NativeTypeName("#define CPD_UISTATE_MODE_PROMPT 0x00000000")]
        public const int CPD_UISTATE_MODE_PROMPT = 0x00000000;

        [NativeTypeName("#define CPD_UISTATE_MODE_BLOCK 0x00000001")]
        public const int CPD_UISTATE_MODE_BLOCK = 0x00000001;

        [NativeTypeName("#define CPD_UISTATE_MODE_ALLOW 0x00000002")]
        public const int CPD_UISTATE_MODE_ALLOW = 0x00000002;

        [NativeTypeName("#define CPD_UISTATE_MODE_MASK 0x00000003")]
        public const int CPD_UISTATE_MODE_MASK = 0x00000003;

        [NativeTypeName("#define WSS_OBJTRUST_SUPPORT 0x00000001")]
        public const int WSS_OBJTRUST_SUPPORT = 0x00000001;

        [NativeTypeName("#define WSS_SIGTRUST_SUPPORT 0x00000002")]
        public const int WSS_SIGTRUST_SUPPORT = 0x00000002;

        [NativeTypeName("#define WSS_CERTTRUST_SUPPORT 0x00000004")]
        public const int WSS_CERTTRUST_SUPPORT = 0x00000004;

        [NativeTypeName("#define SGNR_TYPE_TIMESTAMP 0x00000010")]
        public const int SGNR_TYPE_TIMESTAMP = 0x00000010;

        [NativeTypeName("#define CERT_CONFIDENCE_SIG 0x10000000")]
        public const int CERT_CONFIDENCE_SIG = 0x10000000;

        [NativeTypeName("#define CERT_CONFIDENCE_TIME 0x01000000")]
        public const int CERT_CONFIDENCE_TIME = 0x01000000;

        [NativeTypeName("#define CERT_CONFIDENCE_TIMENEST 0x00100000")]
        public const int CERT_CONFIDENCE_TIMENEST = 0x00100000;

        [NativeTypeName("#define CERT_CONFIDENCE_AUTHIDEXT 0x00010000")]
        public const int CERT_CONFIDENCE_AUTHIDEXT = 0x00010000;

        [NativeTypeName("#define CERT_CONFIDENCE_HYGIENE 0x00001000")]
        public const int CERT_CONFIDENCE_HYGIENE = 0x00001000;

        [NativeTypeName("#define CERT_CONFIDENCE_HIGHEST 0x11111000")]
        public const int CERT_CONFIDENCE_HIGHEST = 0x11111000;

        [NativeTypeName("#define WT_CURRENT_VERSION 0x00000200")]
        public const int WT_CURRENT_VERSION = 0x00000200;

        [NativeTypeName("#define WT_PROVIDER_DLL_NAME L\"WINTRUST.DLL\"")]
        public const string WT_PROVIDER_DLL_NAME = "WINTRUST.DLL";

        [NativeTypeName("#define WT_PROVIDER_CERTTRUST_FUNCTION L\"WintrustCertificateTrust\"")]
        public const string WT_PROVIDER_CERTTRUST_FUNCTION = "WintrustCertificateTrust";

        [NativeTypeName("#define WT_ADD_ACTION_ID_RET_RESULT_FLAG 0x1")]
        public const int WT_ADD_ACTION_ID_RET_RESULT_FLAG = 0x1;

        [NativeTypeName("#define DWACTION_ALLOCANDFILL 1")]
        public const int DWACTION_ALLOCANDFILL = 1;

        [NativeTypeName("#define DWACTION_FREE 2")]
        public const int DWACTION_FREE = 2;

        [NativeTypeName("#define szOID_TRUSTED_CODESIGNING_CA_LIST \"1.3.6.1.4.1.311.2.2.1\"")]
        public static ReadOnlySpan<byte> szOID_TRUSTED_CODESIGNING_CA_LIST => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_TRUSTED_CLIENT_AUTH_CA_LIST \"1.3.6.1.4.1.311.2.2.2\"")]
        public static ReadOnlySpan<byte> szOID_TRUSTED_CLIENT_AUTH_CA_LIST => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_TRUSTED_SERVER_AUTH_CA_LIST \"1.3.6.1.4.1.311.2.2.3\"")]
        public static ReadOnlySpan<byte> szOID_TRUSTED_SERVER_AUTH_CA_LIST => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define SPC_COMMON_NAME_OBJID szOID_COMMON_NAME")]
        public static ReadOnlySpan<byte> SPC_COMMON_NAME_OBJID => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define SPC_TIME_STAMP_REQUEST_OBJID \"1.3.6.1.4.1.311.3.2.1\"")]
        public static ReadOnlySpan<byte> SPC_TIME_STAMP_REQUEST_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define SPC_INDIRECT_DATA_OBJID \"1.3.6.1.4.1.311.2.1.4\"")]
        public static ReadOnlySpan<byte> SPC_INDIRECT_DATA_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define SPC_SP_AGENCY_INFO_OBJID \"1.3.6.1.4.1.311.2.1.10\"")]
        public static ReadOnlySpan<byte> SPC_SP_AGENCY_INFO_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x00 };

        [NativeTypeName("#define SPC_STATEMENT_TYPE_OBJID \"1.3.6.1.4.1.311.2.1.11\"")]
        public static ReadOnlySpan<byte> SPC_STATEMENT_TYPE_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x00 };

        [NativeTypeName("#define SPC_SP_OPUS_INFO_OBJID \"1.3.6.1.4.1.311.2.1.12\"")]
        public static ReadOnlySpan<byte> SPC_SP_OPUS_INFO_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        [NativeTypeName("#define SPC_CERT_EXTENSIONS_OBJID \"1.3.6.1.4.1.311.2.1.14\"")]
        public static ReadOnlySpan<byte> SPC_CERT_EXTENSIONS_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x34, 0x00 };

        [NativeTypeName("#define SPC_PE_IMAGE_DATA_OBJID \"1.3.6.1.4.1.311.2.1.15\"")]
        public static ReadOnlySpan<byte> SPC_PE_IMAGE_DATA_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x35, 0x00 };

        [NativeTypeName("#define SPC_RAW_FILE_DATA_OBJID \"1.3.6.1.4.1.311.2.1.18\"")]
        public static ReadOnlySpan<byte> SPC_RAW_FILE_DATA_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x38, 0x00 };

        [NativeTypeName("#define SPC_STRUCTURED_STORAGE_DATA_OBJID \"1.3.6.1.4.1.311.2.1.19\"")]
        public static ReadOnlySpan<byte> SPC_STRUCTURED_STORAGE_DATA_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x39, 0x00 };

        [NativeTypeName("#define SPC_JAVA_CLASS_DATA_OBJID \"1.3.6.1.4.1.311.2.1.20\"")]
        public static ReadOnlySpan<byte> SPC_JAVA_CLASS_DATA_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x30, 0x00 };

        [NativeTypeName("#define SPC_INDIVIDUAL_SP_KEY_PURPOSE_OBJID \"1.3.6.1.4.1.311.2.1.21\"")]
        public static ReadOnlySpan<byte> SPC_INDIVIDUAL_SP_KEY_PURPOSE_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x31, 0x00 };

        [NativeTypeName("#define SPC_COMMERCIAL_SP_KEY_PURPOSE_OBJID \"1.3.6.1.4.1.311.2.1.22\"")]
        public static ReadOnlySpan<byte> SPC_COMMERCIAL_SP_KEY_PURPOSE_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x32, 0x00 };

        [NativeTypeName("#define SPC_CAB_DATA_OBJID \"1.3.6.1.4.1.311.2.1.25\"")]
        public static ReadOnlySpan<byte> SPC_CAB_DATA_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x35, 0x00 };

        [NativeTypeName("#define SPC_GLUE_RDN_OBJID \"1.3.6.1.4.1.311.2.1.25\"")]
        public static ReadOnlySpan<byte> SPC_GLUE_RDN_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x35, 0x00 };

        [NativeTypeName("#define SPC_MINIMAL_CRITERIA_OBJID \"1.3.6.1.4.1.311.2.1.26\"")]
        public static ReadOnlySpan<byte> SPC_MINIMAL_CRITERIA_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x36, 0x00 };

        [NativeTypeName("#define SPC_FINANCIAL_CRITERIA_OBJID \"1.3.6.1.4.1.311.2.1.27\"")]
        public static ReadOnlySpan<byte> SPC_FINANCIAL_CRITERIA_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x37, 0x00 };

        [NativeTypeName("#define SPC_LINK_OBJID \"1.3.6.1.4.1.311.2.1.28\"")]
        public static ReadOnlySpan<byte> SPC_LINK_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x38, 0x00 };

        [NativeTypeName("#define SPC_SIGINFO_OBJID \"1.3.6.1.4.1.311.2.1.30\"")]
        public static ReadOnlySpan<byte> SPC_SIGINFO_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x33, 0x30, 0x00 };

        [NativeTypeName("#define SPC_PE_IMAGE_PAGE_HASHES_V1_OBJID \"1.3.6.1.4.1.311.2.3.1\"")]
        public static ReadOnlySpan<byte> SPC_PE_IMAGE_PAGE_HASHES_V1_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define SPC_PE_IMAGE_PAGE_HASHES_V2_OBJID \"1.3.6.1.4.1.311.2.3.2\"")]
        public static ReadOnlySpan<byte> SPC_PE_IMAGE_PAGE_HASHES_V2_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x33, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_NESTED_SIGNATURE \"1.3.6.1.4.1.311.2.4.1\"")]
        public static ReadOnlySpan<byte> szOID_NESTED_SIGNATURE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x34, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_INTENT_TO_SEAL \"1.3.6.1.4.1.311.2.4.2\"")]
        public static ReadOnlySpan<byte> szOID_INTENT_TO_SEAL => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x34, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_SEALING_SIGNATURE \"1.3.6.1.4.1.311.2.4.3\"")]
        public static ReadOnlySpan<byte> szOID_SEALING_SIGNATURE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x34, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_SEALING_TIMESTAMP \"1.3.6.1.4.1.311.2.4.4\"")]
        public static ReadOnlySpan<byte> szOID_SEALING_TIMESTAMP => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x34, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_ENHANCED_HASH \"1.3.6.1.4.1.311.2.5.1\"")]
        public static ReadOnlySpan<byte> szOID_ENHANCED_HASH => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x35, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define SPC_RELAXED_PE_MARKER_CHECK_OBJID \"1.3.6.1.4.1.311.2.6.1\"")]
        public static ReadOnlySpan<byte> SPC_RELAXED_PE_MARKER_CHECK_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x36, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define SPC_ENCRYPTED_DIGEST_RETRY_COUNT_OBJID \"1.3.6.1.4.1.311.2.6.2\"")]
        public static ReadOnlySpan<byte> SPC_ENCRYPTED_DIGEST_RETRY_COUNT_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x36, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_PKCS_9_SEQUENCE_NUMBER \"1.2.840.113549.1.9.25.4\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_9_SEQUENCE_NUMBER => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x32, 0x35, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define CAT_NAMEVALUE_OBJID \"1.3.6.1.4.1.311.12.2.1\"")]
        public static ReadOnlySpan<byte> CAT_NAMEVALUE_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define CAT_MEMBERINFO_OBJID \"1.3.6.1.4.1.311.12.2.2\"")]
        public static ReadOnlySpan<byte> CAT_MEMBERINFO_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define CAT_MEMBERINFO2_OBJID \"1.3.6.1.4.1.311.12.2.3\"")]
        public static ReadOnlySpan<byte> CAT_MEMBERINFO2_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define SPC_WINDOWS_HELLO_COMPATIBILITY_OBJID \"1.3.6.1.4.1.311.10.41.1\"")]
        public static ReadOnlySpan<byte> SPC_WINDOWS_HELLO_COMPATIBILITY_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x34, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define SPC_NATURAL_AUTH_PLUGIN_OBJID \"1.3.6.1.4.1.311.96.1.1\"")]
        public static ReadOnlySpan<byte> SPC_NATURAL_AUTH_PLUGIN_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x39, 0x36, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define SPC_SP_AGENCY_INFO_STRUCT ((LPCSTR) 2000)")]
        public static sbyte* SPC_SP_AGENCY_INFO_STRUCT => ((sbyte*)(2000));

        [NativeTypeName("#define SPC_MINIMAL_CRITERIA_STRUCT ((LPCSTR) 2001)")]
        public static sbyte* SPC_MINIMAL_CRITERIA_STRUCT => ((sbyte*)(2001));

        [NativeTypeName("#define SPC_FINANCIAL_CRITERIA_STRUCT ((LPCSTR) 2002)")]
        public static sbyte* SPC_FINANCIAL_CRITERIA_STRUCT => ((sbyte*)(2002));

        [NativeTypeName("#define SPC_INDIRECT_DATA_CONTENT_STRUCT ((LPCSTR) 2003)")]
        public static sbyte* SPC_INDIRECT_DATA_CONTENT_STRUCT => ((sbyte*)(2003));

        [NativeTypeName("#define SPC_PE_IMAGE_DATA_STRUCT ((LPCSTR) 2004)")]
        public static sbyte* SPC_PE_IMAGE_DATA_STRUCT => ((sbyte*)(2004));

        [NativeTypeName("#define SPC_LINK_STRUCT ((LPCSTR) 2005)")]
        public static sbyte* SPC_LINK_STRUCT => ((sbyte*)(2005));

        [NativeTypeName("#define SPC_STATEMENT_TYPE_STRUCT ((LPCSTR) 2006)")]
        public static sbyte* SPC_STATEMENT_TYPE_STRUCT => ((sbyte*)(2006));

        [NativeTypeName("#define SPC_SP_OPUS_INFO_STRUCT ((LPCSTR) 2007)")]
        public static sbyte* SPC_SP_OPUS_INFO_STRUCT => ((sbyte*)(2007));

        [NativeTypeName("#define SPC_CAB_DATA_STRUCT ((LPCSTR) 2008)")]
        public static sbyte* SPC_CAB_DATA_STRUCT => ((sbyte*)(2008));

        [NativeTypeName("#define SPC_JAVA_CLASS_DATA_STRUCT ((LPCSTR) 2009)")]
        public static sbyte* SPC_JAVA_CLASS_DATA_STRUCT => ((sbyte*)(2009));

        [NativeTypeName("#define INTENT_TO_SEAL_ATTRIBUTE_STRUCT ((LPCSTR) 2010)")]
        public static sbyte* INTENT_TO_SEAL_ATTRIBUTE_STRUCT => ((sbyte*)(2010));

        [NativeTypeName("#define SEALING_SIGNATURE_ATTRIBUTE_STRUCT ((LPCSTR) 2011)")]
        public static sbyte* SEALING_SIGNATURE_ATTRIBUTE_STRUCT => ((sbyte*)(2011));

        [NativeTypeName("#define SEALING_TIMESTAMP_ATTRIBUTE_STRUCT ((LPCSTR) 2012)")]
        public static sbyte* SEALING_TIMESTAMP_ATTRIBUTE_STRUCT => ((sbyte*)(2012));

        [NativeTypeName("#define SPC_SIGINFO_STRUCT ((LPCSTR) 2130)")]
        public static sbyte* SPC_SIGINFO_STRUCT => ((sbyte*)(2130));

        [NativeTypeName("#define CAT_NAMEVALUE_STRUCT ((LPCSTR) 2221)")]
        public static sbyte* CAT_NAMEVALUE_STRUCT => ((sbyte*)(2221));

        [NativeTypeName("#define CAT_MEMBERINFO_STRUCT ((LPCSTR) 2222)")]
        public static sbyte* CAT_MEMBERINFO_STRUCT => ((sbyte*)(2222));

        [NativeTypeName("#define CAT_MEMBERINFO2_STRUCT ((LPCSTR) 2223)")]
        public static sbyte* CAT_MEMBERINFO2_STRUCT => ((sbyte*)(2223));

        [NativeTypeName("#define SPC_UUID_LENGTH 16")]
        public const int SPC_UUID_LENGTH = 16;

        [NativeTypeName("#define SPC_URL_LINK_CHOICE 1")]
        public const int SPC_URL_LINK_CHOICE = 1;

        [NativeTypeName("#define SPC_MONIKER_LINK_CHOICE 2")]
        public const int SPC_MONIKER_LINK_CHOICE = 2;

        [NativeTypeName("#define SPC_FILE_LINK_CHOICE 3")]
        public const int SPC_FILE_LINK_CHOICE = 3;

        [NativeTypeName("#define WIN_CERT_REVISION_1_0 (0x0100)")]
        public const int WIN_CERT_REVISION_1_0 = (0x0100);

        [NativeTypeName("#define WIN_CERT_REVISION_2_0 (0x0200)")]
        public const int WIN_CERT_REVISION_2_0 = (0x0200);

        [NativeTypeName("#define WIN_CERT_TYPE_X509 (0x0001)")]
        public const int WIN_CERT_TYPE_X509 = (0x0001);

        [NativeTypeName("#define WIN_CERT_TYPE_PKCS_SIGNED_DATA (0x0002)")]
        public const int WIN_CERT_TYPE_PKCS_SIGNED_DATA = (0x0002);

        [NativeTypeName("#define WIN_CERT_TYPE_RESERVED_1 (0x0003)")]
        public const int WIN_CERT_TYPE_RESERVED_1 = (0x0003);

        [NativeTypeName("#define WIN_CERT_TYPE_TS_STACK_SIGNED (0x0004)")]
        public const int WIN_CERT_TYPE_TS_STACK_SIGNED = (0x0004);

        [NativeTypeName("#define WT_TRUSTDBDIALOG_NO_UI_FLAG 0x00000001")]
        public const int WT_TRUSTDBDIALOG_NO_UI_FLAG = 0x00000001;

        [NativeTypeName("#define WT_TRUSTDBDIALOG_ONLY_PUB_TAB_FLAG 0x00000002")]
        public const int WT_TRUSTDBDIALOG_ONLY_PUB_TAB_FLAG = 0x00000002;

        [NativeTypeName("#define WT_TRUSTDBDIALOG_WRITE_LEGACY_REG_FLAG 0x00000100")]
        public const int WT_TRUSTDBDIALOG_WRITE_LEGACY_REG_FLAG = 0x00000100;

        [NativeTypeName("#define WT_TRUSTDBDIALOG_WRITE_IEAK_STORE_FLAG 0x00000200")]
        public const int WT_TRUSTDBDIALOG_WRITE_IEAK_STORE_FLAG = 0x00000200;
    }
}
