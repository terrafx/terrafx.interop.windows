// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("wintrust", EntryPoint = "WinVerifyTrust", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int WinVerifyTrust([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("GUID *")] Guid* pgActionID, [NativeTypeName("LPVOID")] void* pWVTData);

        [DllImport("wintrust", EntryPoint = "WinVerifyTrustEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WinVerifyTrustEx([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("GUID *")] Guid* pgActionID, [NativeTypeName("WINTRUST_DATA *")] WINTRUST_DATA* pWinTrustData);

        [DllImport("wintrust", EntryPoint = "WintrustGetRegPolicyFlags", ExactSpelling = true)]
        public static extern void WintrustGetRegPolicyFlags([NativeTypeName("DWORD *")] uint* pdwPolicyFlags);

        [DllImport("wintrust", EntryPoint = "WintrustSetRegPolicyFlags", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WintrustSetRegPolicyFlags([NativeTypeName("DWORD")] uint dwPolicyFlags);

        [DllImport("wintrust", EntryPoint = "WintrustAddActionID", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WintrustAddActionID([NativeTypeName("GUID *")] Guid* pgActionID, [NativeTypeName("DWORD")] uint fdwFlags, [NativeTypeName("CRYPT_REGISTER_ACTIONID *")] CRYPT_REGISTER_ACTIONID* psProvInfo);

        [DllImport("wintrust", EntryPoint = "WintrustRemoveActionID", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WintrustRemoveActionID([NativeTypeName("GUID *")] Guid* pgActionID);

        [DllImport("wintrust", EntryPoint = "WintrustLoadFunctionPointers", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WintrustLoadFunctionPointers([NativeTypeName("GUID *")] Guid* pgActionID, [NativeTypeName("CRYPT_PROVIDER_FUNCTIONS *")] CRYPT_PROVIDER_FUNCTIONS* pPfns);

        [DllImport("wintrust", EntryPoint = "WintrustAddDefaultForUsage", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WintrustAddDefaultForUsage([NativeTypeName("const char *")] sbyte* pszUsageOID, [NativeTypeName("CRYPT_PROVIDER_REGDEFUSAGE *")] CRYPT_PROVIDER_REGDEFUSAGE* psDefUsage);

        [DllImport("wintrust", EntryPoint = "WintrustGetDefaultForUsage", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WintrustGetDefaultForUsage([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("const char *")] sbyte* pszUsageOID, [NativeTypeName("CRYPT_PROVIDER_DEFUSAGE *")] CRYPT_PROVIDER_DEFUSAGE* psUsage);

        [DllImport("wintrust", EntryPoint = "WTHelperGetProvSignerFromChain", ExactSpelling = true)]
        [return: NativeTypeName("CRYPT_PROVIDER_SGNR *")]
        public static extern CRYPT_PROVIDER_SGNR* WTHelperGetProvSignerFromChain([NativeTypeName("CRYPT_PROVIDER_DATA *")] CRYPT_PROVIDER_DATA* pProvData, [NativeTypeName("DWORD")] uint idxSigner, [NativeTypeName("BOOL")] int fCounterSigner, [NativeTypeName("DWORD")] uint idxCounterSigner);

        [DllImport("wintrust", EntryPoint = "WTHelperGetProvCertFromChain", ExactSpelling = true)]
        [return: NativeTypeName("CRYPT_PROVIDER_CERT *")]
        public static extern CRYPT_PROVIDER_CERT* WTHelperGetProvCertFromChain([NativeTypeName("CRYPT_PROVIDER_SGNR *")] CRYPT_PROVIDER_SGNR* pSgnr, [NativeTypeName("DWORD")] uint idxCert);

        [DllImport("wintrust", EntryPoint = "WTHelperProvDataFromStateData", ExactSpelling = true)]
        [return: NativeTypeName("CRYPT_PROVIDER_DATA *")]
        public static extern CRYPT_PROVIDER_DATA* WTHelperProvDataFromStateData([NativeTypeName("HANDLE")] IntPtr hStateData);

        [DllImport("wintrust", EntryPoint = "WTHelperGetProvPrivateDataFromChain", ExactSpelling = true)]
        [return: NativeTypeName("CRYPT_PROVIDER_PRIVDATA *")]
        public static extern CRYPT_PROVIDER_PRIVDATA* WTHelperGetProvPrivateDataFromChain([NativeTypeName("CRYPT_PROVIDER_DATA *")] CRYPT_PROVIDER_DATA* pProvData, [NativeTypeName("GUID *")] Guid* pgProviderID);

        [DllImport("wintrust", EntryPoint = "WTHelperCertIsSelfSigned", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WTHelperCertIsSelfSigned([NativeTypeName("DWORD")] uint dwEncoding, [NativeTypeName("CERT_INFO *")] CERT_INFO* pCert);

        [DllImport("wintrust", EntryPoint = "WTHelperCertCheckValidSignature", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WTHelperCertCheckValidSignature([NativeTypeName("CRYPT_PROVIDER_DATA *")] CRYPT_PROVIDER_DATA* pProvData);

        [DllImport("wintrust", EntryPoint = "OpenPersonalTrustDBDialogEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenPersonalTrustDBDialogEx([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PVOID *")] void** pvReserved);

        [DllImport("wintrust", EntryPoint = "OpenPersonalTrustDBDialog", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenPersonalTrustDBDialog([NativeTypeName("HWND")] IntPtr hwndParent);

        [DllImport("wintrust", EntryPoint = "WintrustSetDefaultIncludePEPageHashes", ExactSpelling = true)]
        public static extern void WintrustSetDefaultIncludePEPageHashes([NativeTypeName("BOOL")] int fIncludePEPageHashes);
    }
}
