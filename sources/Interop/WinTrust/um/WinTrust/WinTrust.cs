// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class WinTrust
    {
        private const string LibraryPath = "wintrust";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WinVerifyTrust", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int WinVerifyTrust([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("GUID *")] Guid* pgActionID, [NativeTypeName("LPVOID")] void* pWVTData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WinVerifyTrustEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WinVerifyTrustEx([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("GUID *")] Guid* pgActionID, [NativeTypeName("WINTRUST_DATA *")] WINTRUST_DATA* pWinTrustData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WintrustGetRegPolicyFlags", ExactSpelling = true)]
        public static extern void WintrustGetRegPolicyFlags([NativeTypeName("DWORD *")] uint* pdwPolicyFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WintrustSetRegPolicyFlags", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WintrustSetRegPolicyFlags([NativeTypeName("DWORD")] uint dwPolicyFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WintrustAddActionID", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WintrustAddActionID([NativeTypeName("GUID *")] Guid* pgActionID, [NativeTypeName("DWORD")] uint fdwFlags, [NativeTypeName("CRYPT_REGISTER_ACTIONID *")] CRYPT_REGISTER_ACTIONID* psProvInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WintrustRemoveActionID", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WintrustRemoveActionID([NativeTypeName("GUID *")] Guid* pgActionID);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WintrustLoadFunctionPointers", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WintrustLoadFunctionPointers([NativeTypeName("GUID *")] Guid* pgActionID, [NativeTypeName("CRYPT_PROVIDER_FUNCTIONS *")] CRYPT_PROVIDER_FUNCTIONS* pPfns);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WintrustAddDefaultForUsage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WintrustAddDefaultForUsage([NativeTypeName("const char *")] sbyte* pszUsageOID, [NativeTypeName("CRYPT_PROVIDER_REGDEFUSAGE *")] CRYPT_PROVIDER_REGDEFUSAGE* psDefUsage);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WintrustGetDefaultForUsage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WintrustGetDefaultForUsage([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("const char *")] sbyte* pszUsageOID, [NativeTypeName("CRYPT_PROVIDER_DEFUSAGE *")] CRYPT_PROVIDER_DEFUSAGE* psUsage);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WTHelperGetProvSignerFromChain", ExactSpelling = true)]
        [return: NativeTypeName("CRYPT_PROVIDER_SGNR *")]
        public static extern CRYPT_PROVIDER_SGNR* WTHelperGetProvSignerFromChain([NativeTypeName("CRYPT_PROVIDER_DATA *")] CRYPT_PROVIDER_DATA* pProvData, [NativeTypeName("DWORD")] uint idxSigner, [NativeTypeName("BOOL")] int fCounterSigner, [NativeTypeName("DWORD")] uint idxCounterSigner);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WTHelperGetProvCertFromChain", ExactSpelling = true)]
        [return: NativeTypeName("CRYPT_PROVIDER_CERT *")]
        public static extern CRYPT_PROVIDER_CERT* WTHelperGetProvCertFromChain([NativeTypeName("CRYPT_PROVIDER_SGNR *")] CRYPT_PROVIDER_SGNR* pSgnr, [NativeTypeName("DWORD")] uint idxCert);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WTHelperProvDataFromStateData", ExactSpelling = true)]
        [return: NativeTypeName("CRYPT_PROVIDER_DATA *")]
        public static extern CRYPT_PROVIDER_DATA* WTHelperProvDataFromStateData([NativeTypeName("HANDLE")] IntPtr hStateData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WTHelperGetProvPrivateDataFromChain", ExactSpelling = true)]
        [return: NativeTypeName("CRYPT_PROVIDER_PRIVDATA *")]
        public static extern CRYPT_PROVIDER_PRIVDATA* WTHelperGetProvPrivateDataFromChain([NativeTypeName("CRYPT_PROVIDER_DATA *")] CRYPT_PROVIDER_DATA* pProvData, [NativeTypeName("GUID *")] Guid* pgProviderID);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WTHelperCertIsSelfSigned", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WTHelperCertIsSelfSigned([NativeTypeName("DWORD")] uint dwEncoding, [NativeTypeName("CERT_INFO *")] CERT_INFO* pCert);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WTHelperCertCheckValidSignature", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WTHelperCertCheckValidSignature([NativeTypeName("CRYPT_PROVIDER_DATA *")] CRYPT_PROVIDER_DATA* pProvData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OpenPersonalTrustDBDialogEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenPersonalTrustDBDialogEx([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PVOID *")] void** pvReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OpenPersonalTrustDBDialog", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenPersonalTrustDBDialog([NativeTypeName("HWND")] IntPtr hwndParent);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WintrustSetDefaultIncludePEPageHashes", ExactSpelling = true)]
        public static extern void WintrustSetDefaultIncludePEPageHashes([NativeTypeName("BOOL")] int fIncludePEPageHashes);
    }
}
