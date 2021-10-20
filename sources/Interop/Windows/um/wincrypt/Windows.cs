// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptAcquireContextA([NativeTypeName("HCRYPTPROV *")] IntPtr* phProv, [NativeTypeName("LPCSTR")] sbyte* szContainer, [NativeTypeName("LPCSTR")] sbyte* szProvider, [NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptAcquireContextW([NativeTypeName("HCRYPTPROV *")] IntPtr* phProv, [NativeTypeName("LPCWSTR")] ushort* szContainer, [NativeTypeName("LPCWSTR")] ushort* szProvider, [NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptReleaseContext([NativeTypeName("HCRYPTPROV")] IntPtr hProv, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGenKey([NativeTypeName("HCRYPTPROV")] IntPtr hProv, [NativeTypeName("ALG_ID")] uint Algid, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HCRYPTKEY *")] IntPtr* phKey);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDeriveKey([NativeTypeName("HCRYPTPROV")] IntPtr hProv, [NativeTypeName("ALG_ID")] uint Algid, [NativeTypeName("HCRYPTHASH")] IntPtr hBaseData, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HCRYPTKEY *")] IntPtr* phKey);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDestroyKey([NativeTypeName("HCRYPTKEY")] IntPtr hKey);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetKeyParam([NativeTypeName("HCRYPTKEY")] IntPtr hKey, [NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetKeyParam([NativeTypeName("HCRYPTKEY")] IntPtr hKey, [NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetHashParam([NativeTypeName("HCRYPTHASH")] IntPtr hHash, [NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetHashParam([NativeTypeName("HCRYPTHASH")] IntPtr hHash, [NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetProvParam([NativeTypeName("HCRYPTPROV")] IntPtr hProv, [NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetProvParam([NativeTypeName("HCRYPTPROV")] IntPtr hProv, [NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGenRandom([NativeTypeName("HCRYPTPROV")] IntPtr hProv, [NativeTypeName("DWORD")] uint dwLen, [NativeTypeName("BYTE *")] byte* pbBuffer);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetUserKey([NativeTypeName("HCRYPTPROV")] IntPtr hProv, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("HCRYPTKEY *")] IntPtr* phUserKey);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptExportKey([NativeTypeName("HCRYPTKEY")] IntPtr hKey, [NativeTypeName("HCRYPTKEY")] IntPtr hExpKey, [NativeTypeName("DWORD")] uint dwBlobType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptImportKey([NativeTypeName("HCRYPTPROV")] IntPtr hProv, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint dwDataLen, [NativeTypeName("HCRYPTKEY")] IntPtr hPubKey, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HCRYPTKEY *")] IntPtr* phKey);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEncrypt([NativeTypeName("HCRYPTKEY")] IntPtr hKey, [NativeTypeName("HCRYPTHASH")] IntPtr hHash, [NativeTypeName("BOOL")] int Final, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen, [NativeTypeName("DWORD")] uint dwBufLen);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDecrypt([NativeTypeName("HCRYPTKEY")] IntPtr hKey, [NativeTypeName("HCRYPTHASH")] IntPtr hHash, [NativeTypeName("BOOL")] int Final, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptCreateHash([NativeTypeName("HCRYPTPROV")] IntPtr hProv, [NativeTypeName("ALG_ID")] uint Algid, [NativeTypeName("HCRYPTKEY")] IntPtr hKey, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HCRYPTHASH *")] IntPtr* phHash);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptHashData([NativeTypeName("HCRYPTHASH")] IntPtr hHash, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint dwDataLen, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptHashSessionKey([NativeTypeName("HCRYPTHASH")] IntPtr hHash, [NativeTypeName("HCRYPTKEY")] IntPtr hKey, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDestroyHash([NativeTypeName("HCRYPTHASH")] IntPtr hHash);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSignHashA([NativeTypeName("HCRYPTHASH")] IntPtr hHash, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("LPCSTR")] sbyte* szDescription, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbSignature, [NativeTypeName("DWORD *")] uint* pdwSigLen);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSignHashW([NativeTypeName("HCRYPTHASH")] IntPtr hHash, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("LPCWSTR")] ushort* szDescription, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbSignature, [NativeTypeName("DWORD *")] uint* pdwSigLen);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifySignatureA([NativeTypeName("HCRYPTHASH")] IntPtr hHash, [NativeTypeName("const BYTE *")] byte* pbSignature, [NativeTypeName("DWORD")] uint dwSigLen, [NativeTypeName("HCRYPTKEY")] IntPtr hPubKey, [NativeTypeName("LPCSTR")] sbyte* szDescription, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifySignatureW([NativeTypeName("HCRYPTHASH")] IntPtr hHash, [NativeTypeName("const BYTE *")] byte* pbSignature, [NativeTypeName("DWORD")] uint dwSigLen, [NativeTypeName("HCRYPTKEY")] IntPtr hPubKey, [NativeTypeName("LPCWSTR")] ushort* szDescription, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetProviderA([NativeTypeName("LPCSTR")] sbyte* pszProvName, [NativeTypeName("DWORD")] uint dwProvType);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetProviderW([NativeTypeName("LPCWSTR")] ushort* pszProvName, [NativeTypeName("DWORD")] uint dwProvType);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetProviderExA([NativeTypeName("LPCSTR")] sbyte* pszProvName, [NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetProviderExW([NativeTypeName("LPCWSTR")] ushort* pszProvName, [NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetDefaultProviderA([NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* pszProvName, [NativeTypeName("DWORD *")] uint* pcbProvName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetDefaultProviderW([NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszProvName, [NativeTypeName("DWORD *")] uint* pcbProvName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEnumProviderTypesA([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwProvType, [NativeTypeName("LPSTR")] sbyte* szTypeName, [NativeTypeName("DWORD *")] uint* pcbTypeName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEnumProviderTypesW([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwProvType, [NativeTypeName("LPWSTR")] ushort* szTypeName, [NativeTypeName("DWORD *")] uint* pcbTypeName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEnumProvidersA([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwProvType, [NativeTypeName("LPSTR")] sbyte* szProvName, [NativeTypeName("DWORD *")] uint* pcbProvName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEnumProvidersW([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwProvType, [NativeTypeName("LPWSTR")] ushort* szProvName, [NativeTypeName("DWORD *")] uint* pcbProvName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptContextAddRef([NativeTypeName("HCRYPTPROV")] IntPtr hProv, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDuplicateKey([NativeTypeName("HCRYPTKEY")] IntPtr hKey, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HCRYPTKEY *")] IntPtr* phKey);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDuplicateHash([NativeTypeName("HCRYPTHASH")] IntPtr hHash, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HCRYPTHASH *")] IntPtr* phHash);

        [DllImport("instrsa5", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetEncSChannel([NativeTypeName("BYTE **")] byte** pData, [NativeTypeName("DWORD *")] uint* dwDecSize);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptFormatObject([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwFormatType, [NativeTypeName("DWORD")] uint dwFormatStrType, void* pFormatStruct, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, void* pbFormat, [NativeTypeName("DWORD *")] uint* pcbFormat);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEncodeObjectEx([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const void *")] void* pvStructInfo, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCRYPT_ENCODE_PARA")] CRYPT_ENCODE_PARA* pEncodePara, void* pvEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEncodeObject([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const void *")] void* pvStructInfo, [NativeTypeName("BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDecodeObjectEx([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCRYPT_DECODE_PARA")] CRYPT_DECODE_PARA* pDecodePara, void* pvStructInfo, [NativeTypeName("DWORD *")] uint* pcbStructInfo);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDecodeObject([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("DWORD")] uint dwFlags, void* pvStructInfo, [NativeTypeName("DWORD *")] uint* pcbStructInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptInstallOIDFunctionAddress([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("DWORD")] uint cFuncEntry, [NativeTypeName("const CRYPT_OID_FUNC_ENTRY []")] CRYPT_OID_FUNC_ENTRY* rgFuncEntry, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("HCRYPTOIDFUNCSET")]
        public static extern IntPtr CryptInitOIDFunctionSet([NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetOIDFunctionAddress([NativeTypeName("HCRYPTOIDFUNCSET")] IntPtr hFuncSet, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("DWORD")] uint dwFlags, void** ppvFuncAddr, [NativeTypeName("HCRYPTOIDFUNCADDR *")] IntPtr* phFuncAddr);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetDefaultOIDDllList([NativeTypeName("HCRYPTOIDFUNCSET")] IntPtr hFuncSet, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("WCHAR *")] ushort* pwszDllList, [NativeTypeName("DWORD *")] uint* pcchDllList);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetDefaultOIDFunctionAddress([NativeTypeName("HCRYPTOIDFUNCSET")] IntPtr hFuncSet, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCWSTR")] ushort* pwszDll, [NativeTypeName("DWORD")] uint dwFlags, void** ppvFuncAddr, [NativeTypeName("HCRYPTOIDFUNCADDR *")] IntPtr* phFuncAddr);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptFreeOIDFunctionAddress([NativeTypeName("HCRYPTOIDFUNCADDR")] IntPtr hFuncAddr, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptRegisterOIDFunction([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("LPCWSTR")] ushort* pwszDll, [NativeTypeName("LPCSTR")] sbyte* pszOverrideFuncName);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptUnregisterOIDFunction([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptRegisterDefaultOIDFunction([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPCWSTR")] ushort* pwszDll);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptUnregisterDefaultOIDFunction([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCWSTR")] ushort* pwszDll);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetOIDFunctionValue([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("LPCWSTR")] ushort* pwszValueName, [NativeTypeName("DWORD")] uint dwValueType, [NativeTypeName("const BYTE *")] byte* pbValueData, [NativeTypeName("DWORD")] uint cbValueData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetOIDFunctionValue([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("LPCWSTR")] ushort* pwszValueName, [NativeTypeName("DWORD *")] uint* pdwValueType, [NativeTypeName("BYTE *")] byte* pbValueData, [NativeTypeName("DWORD *")] uint* pcbValueData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEnumOIDFunction([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("DWORD")] uint dwFlags, void* pvArg, [NativeTypeName("PFN_CRYPT_ENUM_OID_FUNC")] delegate* unmanaged<uint, sbyte*, sbyte*, uint, uint*, ushort**, byte**, uint*, void*, int> pfnEnumOIDFunc);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCCRYPT_OID_INFO")]
        public static extern CRYPT_OID_INFO* CryptFindOIDInfo([NativeTypeName("DWORD")] uint dwKeyType, void* pvKey, [NativeTypeName("DWORD")] uint dwGroupId);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptRegisterOIDInfo([NativeTypeName("PCCRYPT_OID_INFO")] CRYPT_OID_INFO* pInfo, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptUnregisterOIDInfo([NativeTypeName("PCCRYPT_OID_INFO")] CRYPT_OID_INFO* pInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEnumOIDInfo([NativeTypeName("DWORD")] uint dwGroupId, [NativeTypeName("DWORD")] uint dwFlags, void* pvArg, [NativeTypeName("PFN_CRYPT_ENUM_OID_INFO")] delegate* unmanaged<CRYPT_OID_INFO*, void*, int> pfnEnumOIDInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("LPCWSTR")]
        public static extern ushort* CryptFindLocalizedName([NativeTypeName("LPCWSTR")] ushort* pwszCryptName);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HCRYPTMSG")]
        public static extern IntPtr CryptMsgOpenToEncode([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwMsgType, [NativeTypeName("const void *")] void* pvMsgEncodeInfo, [NativeTypeName("LPSTR")] sbyte* pszInnerContentObjID, [NativeTypeName("PCMSG_STREAM_INFO")] CMSG_STREAM_INFO* pStreamInfo);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CryptMsgCalculateEncodedLength([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwMsgType, [NativeTypeName("const void *")] void* pvMsgEncodeInfo, [NativeTypeName("LPSTR")] sbyte* pszInnerContentObjID, [NativeTypeName("DWORD")] uint cbData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HCRYPTMSG")]
        public static extern IntPtr CryptMsgOpenToDecode([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwMsgType, [NativeTypeName("HCRYPTPROV_LEGACY")] IntPtr hCryptProv, [NativeTypeName("PCERT_INFO")] CERT_INFO* pRecipientInfo, [NativeTypeName("PCMSG_STREAM_INFO")] CMSG_STREAM_INFO* pStreamInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("HCRYPTMSG")]
        public static extern IntPtr CryptMsgDuplicate([NativeTypeName("HCRYPTMSG")] IntPtr hCryptMsg);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgClose([NativeTypeName("HCRYPTMSG")] IntPtr hCryptMsg);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgUpdate([NativeTypeName("HCRYPTMSG")] IntPtr hCryptMsg, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("BOOL")] int fFinal);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgGetParam([NativeTypeName("HCRYPTMSG")] IntPtr hCryptMsg, [NativeTypeName("DWORD")] uint dwParamType, [NativeTypeName("DWORD")] uint dwIndex, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgControl([NativeTypeName("HCRYPTMSG")] IntPtr hCryptMsg, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwCtrlType, [NativeTypeName("const void *")] void* pvCtrlPara);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgVerifyCountersignatureEncoded([NativeTypeName("HCRYPTPROV_LEGACY")] IntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("PBYTE")] byte* pbSignerInfo, [NativeTypeName("DWORD")] uint cbSignerInfo, [NativeTypeName("PBYTE")] byte* pbSignerInfoCountersignature, [NativeTypeName("DWORD")] uint cbSignerInfoCountersignature, [NativeTypeName("PCERT_INFO")] CERT_INFO* pciCountersigner);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgVerifyCountersignatureEncodedEx([NativeTypeName("HCRYPTPROV_LEGACY")] IntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("PBYTE")] byte* pbSignerInfo, [NativeTypeName("DWORD")] uint cbSignerInfo, [NativeTypeName("PBYTE")] byte* pbSignerInfoCountersignature, [NativeTypeName("DWORD")] uint cbSignerInfoCountersignature, [NativeTypeName("DWORD")] uint dwSignerType, void* pvSigner, [NativeTypeName("DWORD")] uint dwFlags, void* pvExtra);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgCountersign([NativeTypeName("HCRYPTMSG")] IntPtr hCryptMsg, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint cCountersigners, [NativeTypeName("PCMSG_SIGNER_ENCODE_INFO")] CMSG_SIGNER_ENCODE_INFO* rgCountersigners);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgCountersignEncoded([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("PBYTE")] byte* pbSignerInfo, [NativeTypeName("DWORD")] uint cbSignerInfo, [NativeTypeName("DWORD")] uint cCountersigners, [NativeTypeName("PCMSG_SIGNER_ENCODE_INFO")] CMSG_SIGNER_ENCODE_INFO* rgCountersigners, [NativeTypeName("PBYTE")] byte* pbCountersignature, [NativeTypeName("PDWORD")] uint* pcbCountersignature);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HCERTSTORE")]
        public static extern IntPtr CertOpenStore([NativeTypeName("LPCSTR")] sbyte* lpszStoreProvider, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("HCRYPTPROV_LEGACY")] IntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvPara);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("HCERTSTORE")]
        public static extern IntPtr CertDuplicateStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSaveStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("DWORD")] uint dwSaveAs, [NativeTypeName("DWORD")] uint dwSaveTo, void* pvSaveToPara, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertCloseStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertGetSubjectCertificateFromStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertEnumCertificatesInStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pPrevCertContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertFindCertificateInStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwFindFlags, [NativeTypeName("DWORD")] uint dwFindType, [NativeTypeName("const void *")] void* pvFindPara, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pPrevCertContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertGetIssuerCertificateFromStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pSubjectContext, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pPrevIssuerContext, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertVerifySubjectCertificateContext([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pSubject, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuer, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertDuplicateCertificateContext([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertCreateCertificateContext([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCertEncoded, [NativeTypeName("DWORD")] uint cbCertEncoded);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertFreeCertificateContext([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSetCertificateContextProperty([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetCertificateContextProperty([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwPropId, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertEnumCertificateContextProperties([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwPropId);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertCreateCTLEntryFromCertificateContextProperties([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint cOptAttr, [NativeTypeName("PCRYPT_ATTRIBUTE")] CRYPT_ATTRIBUTE* rgOptAttr, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved, [NativeTypeName("PCTL_ENTRY")] CTL_ENTRY* pCtlEntry, [NativeTypeName("DWORD *")] uint* pcbCtlEntry);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSetCertificateContextPropertiesFromCTLEntry([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("PCTL_ENTRY")] CTL_ENTRY* pCtlEntry, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCRL_CONTEXT")]
        public static extern CRL_CONTEXT* CertGetCRLFromStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuerContext, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pPrevCrlContext, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCRL_CONTEXT")]
        public static extern CRL_CONTEXT* CertEnumCRLsInStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pPrevCrlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCRL_CONTEXT")]
        public static extern CRL_CONTEXT* CertFindCRLInStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwFindFlags, [NativeTypeName("DWORD")] uint dwFindType, [NativeTypeName("const void *")] void* pvFindPara, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pPrevCrlContext);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCCRL_CONTEXT")]
        public static extern CRL_CONTEXT* CertDuplicateCRLContext([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCRL_CONTEXT")]
        public static extern CRL_CONTEXT* CertCreateCRLContext([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCrlEncoded, [NativeTypeName("DWORD")] uint cbCrlEncoded);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertFreeCRLContext([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSetCRLContextProperty([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetCRLContextProperty([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwPropId, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertEnumCRLContextProperties([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwPropId);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertFindCertificateInCRL([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved, [NativeTypeName("PCRL_ENTRY *")] CRL_ENTRY** ppCrlEntry);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertIsValidCRLForCertificate([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrl, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddEncodedCertificateToStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCertEncoded, [NativeTypeName("DWORD")] uint cbCertEncoded, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppCertContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddCertificateContextToStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppStoreContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddSerializedElementToStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("const BYTE *")] byte* pbElement, [NativeTypeName("DWORD")] uint cbElement, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwContextTypeFlags, [NativeTypeName("DWORD *")] uint* pdwContextType, [NativeTypeName("const void **")] void** ppvContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertDeleteCertificateFromStore([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddEncodedCRLToStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCrlEncoded, [NativeTypeName("DWORD")] uint cbCrlEncoded, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCRL_CONTEXT *")] CRL_CONTEXT** ppCrlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddCRLContextToStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCRL_CONTEXT *")] CRL_CONTEXT** ppStoreContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertDeleteCRLFromStore([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSerializeCertificateStoreElement([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbElement, [NativeTypeName("DWORD *")] uint* pcbElement);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSerializeCRLStoreElement([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbElement, [NativeTypeName("DWORD *")] uint* pcbElement);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCCTL_CONTEXT")]
        public static extern CTL_CONTEXT* CertDuplicateCTLContext([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCTL_CONTEXT")]
        public static extern CTL_CONTEXT* CertCreateCTLContext([NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCtlEncoded, [NativeTypeName("DWORD")] uint cbCtlEncoded);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertFreeCTLContext([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSetCTLContextProperty([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetCTLContextProperty([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwPropId, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertEnumCTLContextProperties([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwPropId);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCTL_CONTEXT")]
        public static extern CTL_CONTEXT* CertEnumCTLsInStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pPrevCtlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCTL_ENTRY")]
        public static extern CTL_ENTRY* CertFindSubjectInCTL([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("DWORD")] uint dwSubjectType, void* pvSubject, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCTL_CONTEXT")]
        public static extern CTL_CONTEXT* CertFindCTLInStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType, [NativeTypeName("DWORD")] uint dwFindFlags, [NativeTypeName("DWORD")] uint dwFindType, [NativeTypeName("const void *")] void* pvFindPara, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pPrevCtlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddEncodedCTLToStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCtlEncoded, [NativeTypeName("DWORD")] uint cbCtlEncoded, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCTL_CONTEXT *")] CTL_CONTEXT** ppCtlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddCTLContextToStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCTL_CONTEXT *")] CTL_CONTEXT** ppStoreContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSerializeCTLStoreElement([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbElement, [NativeTypeName("DWORD *")] uint* pcbElement);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertDeleteCTLFromStore([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddCertificateLinkToStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppStoreContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddCRLLinkToStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCRL_CONTEXT *")] CRL_CONTEXT** ppStoreContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddCTLLinkToStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCTL_CONTEXT *")] CTL_CONTEXT** ppStoreContext);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddStoreToCollection([NativeTypeName("HCERTSTORE")] IntPtr hCollectionStore, [NativeTypeName("HCERTSTORE")] IntPtr hSiblingStore, [NativeTypeName("DWORD")] uint dwUpdateFlags, [NativeTypeName("DWORD")] uint dwPriority);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertRemoveStoreFromCollection([NativeTypeName("HCERTSTORE")] IntPtr hCollectionStore, [NativeTypeName("HCERTSTORE")] IntPtr hSiblingStore);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertControlStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwCtrlType, [NativeTypeName("const void *")] void* pvCtrlPara);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSetStoreProperty([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetStoreProperty([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("DWORD")] uint dwPropId, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("const void *")]
        public static extern void* CertCreateContext([NativeTypeName("DWORD")] uint dwContextType, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_CREATE_CONTEXT_PARA")] CERT_CREATE_CONTEXT_PARA* pCreatePara);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertRegisterSystemStore([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_SYSTEM_STORE_INFO")] CERT_SYSTEM_STORE_INFO* pStoreInfo, void* pvReserved);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertRegisterPhysicalStore([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszStoreName, [NativeTypeName("PCERT_PHYSICAL_STORE_INFO")] CERT_PHYSICAL_STORE_INFO* pStoreInfo, void* pvReserved);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertUnregisterSystemStore([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertUnregisterPhysicalStore([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszStoreName);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertEnumSystemStoreLocation([NativeTypeName("DWORD")] uint dwFlags, void* pvArg, [NativeTypeName("PFN_CERT_ENUM_SYSTEM_STORE_LOCATION")] delegate* unmanaged<ushort*, uint, void*, void*, int> pfnEnum);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertEnumSystemStore([NativeTypeName("DWORD")] uint dwFlags, void* pvSystemStoreLocationPara, void* pvArg, [NativeTypeName("PFN_CERT_ENUM_SYSTEM_STORE")] delegate* unmanaged<void*, uint, CERT_SYSTEM_STORE_INFO*, void*, void*, int> pfnEnum);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertEnumPhysicalStore([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags, void* pvArg, [NativeTypeName("PFN_CERT_ENUM_PHYSICAL_STORE")] delegate* unmanaged<void*, uint, ushort*, CERT_PHYSICAL_STORE_INFO*, void*, void*, int> pfnEnum);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetEnhancedKeyUsage([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_ENHKEY_USAGE")] CTL_USAGE* pUsage, [NativeTypeName("DWORD *")] uint* pcbUsage);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSetEnhancedKeyUsage([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("PCERT_ENHKEY_USAGE")] CTL_USAGE* pUsage);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddEnhancedKeyUsageIdentifier([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("LPCSTR")] sbyte* pszUsageIdentifier);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertRemoveEnhancedKeyUsageIdentifier([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("LPCSTR")] sbyte* pszUsageIdentifier);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetValidUsages([NativeTypeName("DWORD")] uint cCerts, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** rghCerts, int* cNumOIDs, [NativeTypeName("LPSTR *")] sbyte** rghOIDs, [NativeTypeName("DWORD *")] uint* pcbOIDs);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgGetAndVerifySigner([NativeTypeName("HCRYPTMSG")] IntPtr hCryptMsg, [NativeTypeName("DWORD")] uint cSignerStore, [NativeTypeName("HCERTSTORE *")] IntPtr* rghSignerStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSigner, [NativeTypeName("DWORD *")] uint* pdwSignerIndex);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgSignCTL([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("BYTE *")] byte* pbCtlContent, [NativeTypeName("DWORD")] uint cbCtlContent, [NativeTypeName("PCMSG_SIGNED_ENCODE_INFO")] CMSG_SIGNED_ENCODE_INFO* pSignInfo, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgEncodeAndSignCTL([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("PCTL_INFO")] CTL_INFO* pCtlInfo, [NativeTypeName("PCMSG_SIGNED_ENCODE_INFO")] CMSG_SIGNED_ENCODE_INFO* pSignInfo, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertFindSubjectInSortedCTL([NativeTypeName("PCRYPT_DATA_BLOB")] CRYPT_DATA_BLOB* pSubjectIdentifier, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved, [NativeTypeName("PCRYPT_DER_BLOB")] CRYPT_DATA_BLOB* pEncodedAttributes);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertEnumSubjectInSortedCTL([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, void** ppvNextSubject, [NativeTypeName("PCRYPT_DER_BLOB")] CRYPT_DATA_BLOB* pSubjectIdentifier, [NativeTypeName("PCRYPT_DER_BLOB")] CRYPT_DATA_BLOB* pEncodedAttributes);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertVerifyCTLUsage([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("DWORD")] uint dwSubjectType, void* pvSubject, [NativeTypeName("PCTL_USAGE")] CTL_USAGE* pSubjectUsage, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCTL_VERIFY_USAGE_PARA")] CTL_VERIFY_USAGE_PARA* pVerifyUsagePara, [NativeTypeName("PCTL_VERIFY_USAGE_STATUS")] CTL_VERIFY_USAGE_STATUS* pVerifyUsageStatus);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertVerifyRevocation([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("DWORD")] uint dwRevType, [NativeTypeName("DWORD")] uint cContext, [NativeTypeName("PVOID []")] void** rgpvContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_REVOCATION_PARA")] CERT_REVOCATION_PARA* pRevPara, [NativeTypeName("PCERT_REVOCATION_STATUS")] CERT_REVOCATION_STATUS* pRevStatus);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertCompareIntegerBlob([NativeTypeName("PCRYPT_INTEGER_BLOB")] CRYPT_DATA_BLOB* pInt1, [NativeTypeName("PCRYPT_INTEGER_BLOB")] CRYPT_DATA_BLOB* pInt2);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertCompareCertificate([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId1, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId2);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertCompareCertificateName([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pCertName1, [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pCertName2);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertIsRDNAttrsInCertificateName([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pCertName, [NativeTypeName("PCERT_RDN")] CERT_RDN* pRDN);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertComparePublicKeyInfo([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey1, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey2);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertGetPublicKeyLength([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyCertificateSignature([NativeTypeName("HCRYPTPROV_LEGACY")] IntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyCertificateSignatureEx([NativeTypeName("HCRYPTPROV_LEGACY")] IntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwSubjectType, void* pvSubject, [NativeTypeName("DWORD")] uint dwIssuerType, void* pvIssuer, [NativeTypeName("DWORD")] uint dwFlags, void* pvExtra);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertIsStrongHashToSign([NativeTypeName("PCCERT_STRONG_SIGN_PARA")] CERT_STRONG_SIGN_PARA* pStrongSignPara, [NativeTypeName("LPCWSTR")] ushort* pwszCNGHashAlgid, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pSigningCert);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptHashToBeSigned([NativeTypeName("HCRYPTPROV_LEGACY")] IntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("BYTE *")] byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptHashCertificate([NativeTypeName("HCRYPTPROV_LEGACY")] IntPtr hCryptProv, [NativeTypeName("ALG_ID")] uint Algid, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("BYTE *")] byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptHashCertificate2([NativeTypeName("LPCWSTR")] ushort* pwszCNGHashAlgid, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("BYTE *")] byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSignCertificate([NativeTypeName("HCRYPTPROV_OR_NCRYPT_KEY_HANDLE")] IntPtr hCryptProvOrNCryptKey, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbEncodedToBeSigned, [NativeTypeName("DWORD")] uint cbEncodedToBeSigned, [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")] CRYPT_ALGORITHM_IDENTIFIER* pSignatureAlgorithm, [NativeTypeName("const void *")] void* pvHashAuxInfo, [NativeTypeName("BYTE *")] byte* pbSignature, [NativeTypeName("DWORD *")] uint* pcbSignature);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSignAndEncodeCertificate([NativeTypeName("HCRYPTPROV_OR_NCRYPT_KEY_HANDLE")] IntPtr hCryptProvOrNCryptKey, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const void *")] void* pvStructInfo, [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")] CRYPT_ALGORITHM_IDENTIFIER* pSignatureAlgorithm, [NativeTypeName("const void *")] void* pvHashAuxInfo, [NativeTypeName("BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int CertVerifyTimeValidity([NativeTypeName("LPFILETIME")] FILETIME* pTimeToVerify, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int CertVerifyCRLTimeValidity([NativeTypeName("LPFILETIME")] FILETIME* pTimeToVerify, [NativeTypeName("PCRL_INFO")] CRL_INFO* pCrlInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertVerifyValidityNesting([NativeTypeName("PCERT_INFO")] CERT_INFO* pSubjectInfo, [NativeTypeName("PCERT_INFO")] CERT_INFO* pIssuerInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertVerifyCRLRevocation([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId, [NativeTypeName("DWORD")] uint cCrlInfo, [NativeTypeName("PCRL_INFO []")] CRL_INFO** rgpCrlInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("LPCSTR")]
        public static extern sbyte* CertAlgIdToOID([NativeTypeName("DWORD")] uint dwAlgId);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertOIDToAlgId([NativeTypeName("LPCSTR")] sbyte* pszObjId);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCERT_EXTENSION")]
        public static extern CERT_EXTENSION* CertFindExtension([NativeTypeName("LPCSTR")] sbyte* pszObjId, [NativeTypeName("DWORD")] uint cExtensions, [NativeTypeName("CERT_EXTENSION []")] CERT_EXTENSION* rgExtensions);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCRYPT_ATTRIBUTE")]
        public static extern CRYPT_ATTRIBUTE* CertFindAttribute([NativeTypeName("LPCSTR")] sbyte* pszObjId, [NativeTypeName("DWORD")] uint cAttr, [NativeTypeName("CRYPT_ATTRIBUTE []")] CRYPT_ATTRIBUTE* rgAttr);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCERT_RDN_ATTR")]
        public static extern CERT_RDN_ATTR* CertFindRDNAttr([NativeTypeName("LPCSTR")] sbyte* pszObjId, [NativeTypeName("PCERT_NAME_INFO")] CERT_NAME_INFO* pName);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetIntendedKeyUsage([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertInfo, [NativeTypeName("BYTE *")] byte* pbKeyUsage, [NativeTypeName("DWORD")] uint cbKeyUsage);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptInstallDefaultContext([NativeTypeName("HCRYPTPROV")] IntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwDefaultType, [NativeTypeName("const void *")] void* pvDefaultPara, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved, [NativeTypeName("HCRYPTDEFAULTCONTEXT *")] IntPtr* phDefaultContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptUninstallDefaultContext([NativeTypeName("HCRYPTDEFAULTCONTEXT")] IntPtr hDefaultContext, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptExportPublicKeyInfo([NativeTypeName("HCRYPTPROV_OR_NCRYPT_KEY_HANDLE")] IntPtr hCryptProvOrNCryptKey, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("DWORD *")] uint* pcbInfo);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptExportPublicKeyInfoEx([NativeTypeName("HCRYPTPROV_OR_NCRYPT_KEY_HANDLE")] IntPtr hCryptProvOrNCryptKey, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPSTR")] sbyte* pszPublicKeyObjId, [NativeTypeName("DWORD")] uint dwFlags, void* pvAuxInfo, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("DWORD *")] uint* pcbInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptExportPublicKeyInfoFromBCryptKeyHandle([NativeTypeName("BCRYPT_KEY_HANDLE")] void* hBCryptKey, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPSTR")] sbyte* pszPublicKeyObjId, [NativeTypeName("DWORD")] uint dwFlags, void* pvAuxInfo, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("DWORD *")] uint* pcbInfo);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptImportPublicKeyInfo([NativeTypeName("HCRYPTPROV")] IntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("HCRYPTKEY *")] IntPtr* phKey);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptImportPublicKeyInfoEx([NativeTypeName("HCRYPTPROV")] IntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("ALG_ID")] uint aiKeyAlg, [NativeTypeName("DWORD")] uint dwFlags, void* pvAuxInfo, [NativeTypeName("HCRYPTKEY *")] IntPtr* phKey);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptImportPublicKeyInfoEx2([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("DWORD")] uint dwFlags, void* pvAuxInfo, [NativeTypeName("BCRYPT_KEY_HANDLE *")] void** phKey);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptAcquireCertificatePrivateKey([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert, [NativeTypeName("DWORD")] uint dwFlags, void* pvParameters, [NativeTypeName("HCRYPTPROV_OR_NCRYPT_KEY_HANDLE *")] IntPtr* phCryptProvOrNCryptKey, [NativeTypeName("DWORD *")] uint* pdwKeySpec, [NativeTypeName("BOOL *")] int* pfCallerFreeProvOrNCryptKey);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptFindCertificateKeyProvInfo([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptImportPKCS8(CRYPT_PKCS8_IMPORT_PARAMS sPrivateKeyAndParams, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HCRYPTPROV *")] IntPtr* phCryptProv, void* pvAuxInfo);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptExportPKCS8([NativeTypeName("HCRYPTPROV")] IntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("LPSTR")] sbyte* pszPrivateKeyObjId, [NativeTypeName("DWORD")] uint dwFlags, void* pvAuxInfo, [NativeTypeName("BYTE *")] byte* pbPrivateKeyBlob, [NativeTypeName("DWORD *")] uint* pcbPrivateKeyBlob);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptExportPKCS8Ex(CRYPT_PKCS8_EXPORT_PARAMS* psExportParams, [NativeTypeName("DWORD")] uint dwFlags, void* pvAuxInfo, [NativeTypeName("BYTE *")] byte* pbPrivateKeyBlob, [NativeTypeName("DWORD *")] uint* pcbPrivateKeyBlob);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptHashPublicKeyInfo([NativeTypeName("HCRYPTPROV_LEGACY")] IntPtr hCryptProv, [NativeTypeName("ALG_ID")] uint Algid, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("BYTE *")] byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertRDNValueToStrA([NativeTypeName("DWORD")] uint dwValueType, [NativeTypeName("PCERT_RDN_VALUE_BLOB")] CRYPT_DATA_BLOB* pValue, [NativeTypeName("LPSTR")] sbyte* psz, [NativeTypeName("DWORD")] uint csz);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertRDNValueToStrW([NativeTypeName("DWORD")] uint dwValueType, [NativeTypeName("PCERT_RDN_VALUE_BLOB")] CRYPT_DATA_BLOB* pValue, [NativeTypeName("LPWSTR")] ushort* psz, [NativeTypeName("DWORD")] uint csz);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertNameToStrA([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pName, [NativeTypeName("DWORD")] uint dwStrType, [NativeTypeName("LPSTR")] sbyte* psz, [NativeTypeName("DWORD")] uint csz);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertNameToStrW([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pName, [NativeTypeName("DWORD")] uint dwStrType, [NativeTypeName("LPWSTR")] ushort* psz, [NativeTypeName("DWORD")] uint csz);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertStrToNameA([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszX500, [NativeTypeName("DWORD")] uint dwStrType, void* pvReserved, [NativeTypeName("BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded, [NativeTypeName("LPCSTR *")] sbyte** ppszError);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertStrToNameW([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCWSTR")] ushort* pszX500, [NativeTypeName("DWORD")] uint dwStrType, void* pvReserved, [NativeTypeName("BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded, [NativeTypeName("LPCWSTR *")] ushort** ppszError);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertGetNameStringA([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("DWORD")] uint dwFlags, void* pvTypePara, [NativeTypeName("LPSTR")] sbyte* pszNameString, [NativeTypeName("DWORD")] uint cchNameString);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertGetNameStringW([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("DWORD")] uint dwFlags, void* pvTypePara, [NativeTypeName("LPWSTR")] ushort* pszNameString, [NativeTypeName("DWORD")] uint cchNameString);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSignMessage([NativeTypeName("PCRYPT_SIGN_MESSAGE_PARA")] CRYPT_SIGN_MESSAGE_PARA* pSignPara, [NativeTypeName("BOOL")] int fDetachedSignature, [NativeTypeName("DWORD")] uint cToBeSigned, [NativeTypeName("const BYTE *[]")] byte** rgpbToBeSigned, [NativeTypeName("DWORD []")] uint* rgcbToBeSigned, [NativeTypeName("BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD *")] uint* pcbSignedBlob);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyMessageSignature([NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara, [NativeTypeName("DWORD")] uint dwSignerIndex, [NativeTypeName("const BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD")] uint cbSignedBlob, [NativeTypeName("BYTE *")] byte* pbDecoded, [NativeTypeName("DWORD *")] uint* pcbDecoded, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LONG")]
        public static extern int CryptGetMessageSignerCount([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("const BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD")] uint cbSignedBlob);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HCERTSTORE")]
        public static extern IntPtr CryptGetMessageCertificates([NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType, [NativeTypeName("HCRYPTPROV_LEGACY")] IntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD")] uint cbSignedBlob);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyDetachedMessageSignature([NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara, [NativeTypeName("DWORD")] uint dwSignerIndex, [NativeTypeName("const BYTE *")] byte* pbDetachedSignBlob, [NativeTypeName("DWORD")] uint cbDetachedSignBlob, [NativeTypeName("DWORD")] uint cToBeSigned, [NativeTypeName("const BYTE *[]")] byte** rgpbToBeSigned, [NativeTypeName("DWORD []")] uint* rgcbToBeSigned, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEncryptMessage([NativeTypeName("PCRYPT_ENCRYPT_MESSAGE_PARA")] CRYPT_ENCRYPT_MESSAGE_PARA* pEncryptPara, [NativeTypeName("DWORD")] uint cRecipientCert, [NativeTypeName("PCCERT_CONTEXT []")] CERT_CONTEXT** rgpRecipientCert, [NativeTypeName("const BYTE *")] byte* pbToBeEncrypted, [NativeTypeName("DWORD")] uint cbToBeEncrypted, [NativeTypeName("BYTE *")] byte* pbEncryptedBlob, [NativeTypeName("DWORD *")] uint* pcbEncryptedBlob);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDecryptMessage([NativeTypeName("PCRYPT_DECRYPT_MESSAGE_PARA")] CRYPT_DECRYPT_MESSAGE_PARA* pDecryptPara, [NativeTypeName("const BYTE *")] byte* pbEncryptedBlob, [NativeTypeName("DWORD")] uint cbEncryptedBlob, [NativeTypeName("BYTE *")] byte* pbDecrypted, [NativeTypeName("DWORD *")] uint* pcbDecrypted, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppXchgCert);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSignAndEncryptMessage([NativeTypeName("PCRYPT_SIGN_MESSAGE_PARA")] CRYPT_SIGN_MESSAGE_PARA* pSignPara, [NativeTypeName("PCRYPT_ENCRYPT_MESSAGE_PARA")] CRYPT_ENCRYPT_MESSAGE_PARA* pEncryptPara, [NativeTypeName("DWORD")] uint cRecipientCert, [NativeTypeName("PCCERT_CONTEXT []")] CERT_CONTEXT** rgpRecipientCert, [NativeTypeName("const BYTE *")] byte* pbToBeSignedAndEncrypted, [NativeTypeName("DWORD")] uint cbToBeSignedAndEncrypted, [NativeTypeName("BYTE *")] byte* pbSignedAndEncryptedBlob, [NativeTypeName("DWORD *")] uint* pcbSignedAndEncryptedBlob);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDecryptAndVerifyMessageSignature([NativeTypeName("PCRYPT_DECRYPT_MESSAGE_PARA")] CRYPT_DECRYPT_MESSAGE_PARA* pDecryptPara, [NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara, [NativeTypeName("DWORD")] uint dwSignerIndex, [NativeTypeName("const BYTE *")] byte* pbEncryptedBlob, [NativeTypeName("DWORD")] uint cbEncryptedBlob, [NativeTypeName("BYTE *")] byte* pbDecrypted, [NativeTypeName("DWORD *")] uint* pcbDecrypted, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppXchgCert, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDecodeMessage([NativeTypeName("DWORD")] uint dwMsgTypeFlags, [NativeTypeName("PCRYPT_DECRYPT_MESSAGE_PARA")] CRYPT_DECRYPT_MESSAGE_PARA* pDecryptPara, [NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara, [NativeTypeName("DWORD")] uint dwSignerIndex, [NativeTypeName("const BYTE *")] byte* pbEncodedBlob, [NativeTypeName("DWORD")] uint cbEncodedBlob, [NativeTypeName("DWORD")] uint dwPrevInnerContentType, [NativeTypeName("DWORD *")] uint* pdwMsgType, [NativeTypeName("DWORD *")] uint* pdwInnerContentType, [NativeTypeName("BYTE *")] byte* pbDecoded, [NativeTypeName("DWORD *")] uint* pcbDecoded, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppXchgCert, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptHashMessage([NativeTypeName("PCRYPT_HASH_MESSAGE_PARA")] CRYPT_HASH_MESSAGE_PARA* pHashPara, [NativeTypeName("BOOL")] int fDetachedHash, [NativeTypeName("DWORD")] uint cToBeHashed, [NativeTypeName("const BYTE *[]")] byte** rgpbToBeHashed, [NativeTypeName("DWORD []")] uint* rgcbToBeHashed, [NativeTypeName("BYTE *")] byte* pbHashedBlob, [NativeTypeName("DWORD *")] uint* pcbHashedBlob, [NativeTypeName("BYTE *")] byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyMessageHash([NativeTypeName("PCRYPT_HASH_MESSAGE_PARA")] CRYPT_HASH_MESSAGE_PARA* pHashPara, [NativeTypeName("BYTE *")] byte* pbHashedBlob, [NativeTypeName("DWORD")] uint cbHashedBlob, [NativeTypeName("BYTE *")] byte* pbToBeHashed, [NativeTypeName("DWORD *")] uint* pcbToBeHashed, [NativeTypeName("BYTE *")] byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyDetachedMessageHash([NativeTypeName("PCRYPT_HASH_MESSAGE_PARA")] CRYPT_HASH_MESSAGE_PARA* pHashPara, [NativeTypeName("BYTE *")] byte* pbDetachedHashBlob, [NativeTypeName("DWORD")] uint cbDetachedHashBlob, [NativeTypeName("DWORD")] uint cToBeHashed, [NativeTypeName("const BYTE *[]")] byte** rgpbToBeHashed, [NativeTypeName("DWORD []")] uint* rgcbToBeHashed, [NativeTypeName("BYTE *")] byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSignMessageWithKey([NativeTypeName("PCRYPT_KEY_SIGN_MESSAGE_PARA")] CRYPT_KEY_SIGN_MESSAGE_PARA* pSignPara, [NativeTypeName("const BYTE *")] byte* pbToBeSigned, [NativeTypeName("DWORD")] uint cbToBeSigned, [NativeTypeName("BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD *")] uint* pcbSignedBlob);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyMessageSignatureWithKey([NativeTypeName("PCRYPT_KEY_VERIFY_MESSAGE_PARA")] CRYPT_KEY_VERIFY_MESSAGE_PARA* pVerifyPara, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKeyInfo, [NativeTypeName("const BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD")] uint cbSignedBlob, [NativeTypeName("BYTE *")] byte* pbDecoded, [NativeTypeName("DWORD *")] uint* pcbDecoded);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HCERTSTORE")]
        public static extern IntPtr CertOpenSystemStoreA([NativeTypeName("HCRYPTPROV_LEGACY")] IntPtr hProv, [NativeTypeName("LPCSTR")] sbyte* szSubsystemProtocol);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HCERTSTORE")]
        public static extern IntPtr CertOpenSystemStoreW([NativeTypeName("HCRYPTPROV_LEGACY")] IntPtr hProv, [NativeTypeName("LPCWSTR")] ushort* szSubsystemProtocol);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddEncodedCertificateToSystemStoreA([NativeTypeName("LPCSTR")] sbyte* szCertStoreName, [NativeTypeName("const BYTE *")] byte* pbCertEncoded, [NativeTypeName("DWORD")] uint cbCertEncoded);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddEncodedCertificateToSystemStoreW([NativeTypeName("LPCWSTR")] ushort* szCertStoreName, [NativeTypeName("const BYTE *")] byte* pbCertEncoded, [NativeTypeName("DWORD")] uint cbCertEncoded);

        [DllImport("wintrust", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int FindCertsByIssuer([NativeTypeName("PCERT_CHAIN")] CERT_CHAIN* pCertChains, [NativeTypeName("DWORD *")] uint* pcbCertChains, [NativeTypeName("DWORD *")] uint* pcCertChains, [NativeTypeName("BYTE *")] byte* pbEncodedIssuerName, [NativeTypeName("DWORD")] uint cbEncodedIssuerName, [NativeTypeName("LPCWSTR")] ushort* pwszPurpose, [NativeTypeName("DWORD")] uint dwKeySpec);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptQueryObject([NativeTypeName("DWORD")] uint dwObjectType, [NativeTypeName("const void *")] void* pvObject, [NativeTypeName("DWORD")] uint dwExpectedContentTypeFlags, [NativeTypeName("DWORD")] uint dwExpectedFormatTypeFlags, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwMsgAndCertEncodingType, [NativeTypeName("DWORD *")] uint* pdwContentType, [NativeTypeName("DWORD *")] uint* pdwFormatType, [NativeTypeName("HCERTSTORE *")] IntPtr* phCertStore, [NativeTypeName("HCRYPTMSG *")] IntPtr* phMsg, [NativeTypeName("const void **")] void** ppvContext);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CryptMemAlloc([NativeTypeName("ULONG")] uint cbSize);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CryptMemRealloc([NativeTypeName("LPVOID")] void* pv, [NativeTypeName("ULONG")] uint cbSize);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CryptMemFree([NativeTypeName("LPVOID")] void* pv);

        [DllImport("secforwarder", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptCreateAsyncHandle([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PHCRYPTASYNC")] IntPtr* phAsync);

        [DllImport("secforwarder", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetAsyncParam([NativeTypeName("HCRYPTASYNC")] IntPtr hAsync, [NativeTypeName("LPSTR")] sbyte* pszParamOid, [NativeTypeName("LPVOID *")] void** ppvParam, [NativeTypeName("PFN_CRYPT_ASYNC_PARAM_FREE_FUNC *")] delegate* unmanaged<sbyte*, void*, void>* ppfnFree);

        [DllImport("secforwarder", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptCloseAsyncHandle([NativeTypeName("HCRYPTASYNC")] IntPtr hAsync);

        [DllImport("cryptnet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptRetrieveObjectByUrlA([NativeTypeName("LPCSTR")] sbyte* pszUrl, [NativeTypeName("LPCSTR")] sbyte* pszObjectOid, [NativeTypeName("DWORD")] uint dwRetrievalFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("LPVOID *")] void** ppvObject, [NativeTypeName("HCRYPTASYNC")] IntPtr hAsyncRetrieve, [NativeTypeName("PCRYPT_CREDENTIALS")] CRYPT_CREDENTIALS* pCredentials, [NativeTypeName("LPVOID")] void* pvVerify, [NativeTypeName("PCRYPT_RETRIEVE_AUX_INFO")] CRYPT_RETRIEVE_AUX_INFO* pAuxInfo);

        [DllImport("cryptnet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptRetrieveObjectByUrlW([NativeTypeName("LPCWSTR")] ushort* pszUrl, [NativeTypeName("LPCSTR")] sbyte* pszObjectOid, [NativeTypeName("DWORD")] uint dwRetrievalFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("LPVOID *")] void** ppvObject, [NativeTypeName("HCRYPTASYNC")] IntPtr hAsyncRetrieve, [NativeTypeName("PCRYPT_CREDENTIALS")] CRYPT_CREDENTIALS* pCredentials, [NativeTypeName("LPVOID")] void* pvVerify, [NativeTypeName("PCRYPT_RETRIEVE_AUX_INFO")] CRYPT_RETRIEVE_AUX_INFO* pAuxInfo);

        [DllImport("cryptnet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptInstallCancelRetrieval([NativeTypeName("PFN_CRYPT_CANCEL_RETRIEVAL")] delegate* unmanaged<uint, void*, int> pfnCancel, [NativeTypeName("const void *")] void* pvArg, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved);

        [DllImport("cryptnet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptUninstallCancelRetrieval([NativeTypeName("DWORD")] uint dwFlags, void* pvReserved);

        [DllImport("cryptnet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptCancelAsyncRetrieval([NativeTypeName("HCRYPTASYNC")] IntPtr hAsyncRetrieval);

        [DllImport("cryptnet", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetObjectUrl([NativeTypeName("LPCSTR")] sbyte* pszUrlOid, [NativeTypeName("LPVOID")] void* pvPara, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCRYPT_URL_ARRAY")] CRYPT_URL_ARRAY* pUrlArray, [NativeTypeName("DWORD *")] uint* pcbUrlArray, [NativeTypeName("PCRYPT_URL_INFO")] CRYPT_URL_INFO* pUrlInfo, [NativeTypeName("DWORD *")] uint* pcbUrlInfo, [NativeTypeName("LPVOID")] void* pvReserved);

        [DllImport("cryptnet", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetTimeValidObject([NativeTypeName("LPCSTR")] sbyte* pszTimeValidOid, [NativeTypeName("LPVOID")] void* pvPara, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuer, [NativeTypeName("LPFILETIME")] FILETIME* pftValidFor, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("LPVOID *")] void** ppvObject, [NativeTypeName("PCRYPT_CREDENTIALS")] CRYPT_CREDENTIALS* pCredentials, [NativeTypeName("PCRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO")] CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO* pExtraInfo);

        [DllImport("cryptnet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptFlushTimeValidObject([NativeTypeName("LPCSTR")] sbyte* pszFlushTimeValidOid, [NativeTypeName("LPVOID")] void* pvPara, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuer, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* pvReserved);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertCreateSelfSignCertificate([NativeTypeName("HCRYPTPROV_OR_NCRYPT_KEY_HANDLE")] IntPtr hCryptProvOrNCryptKey, [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pSubjectIssuerBlob, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCRYPT_KEY_PROV_INFO")] CRYPT_KEY_PROV_INFO* pKeyProvInfo, [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")] CRYPT_ALGORITHM_IDENTIFIER* pSignatureAlgorithm, [NativeTypeName("PSYSTEMTIME")] SYSTEMTIME* pStartTime, [NativeTypeName("PSYSTEMTIME")] SYSTEMTIME* pEndTime, [NativeTypeName("PCERT_EXTENSIONS")] CERT_EXTENSIONS* pExtensions);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetKeyIdentifierProperty([NativeTypeName("const CRYPT_HASH_BLOB *")] CRYPT_DATA_BLOB* pKeyIdentifier, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszComputerName, void* pvReserved, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetKeyIdentifierProperty([NativeTypeName("const CRYPT_HASH_BLOB *")] CRYPT_DATA_BLOB* pKeyIdentifier, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszComputerName, void* pvReserved, [NativeTypeName("const void *")] void* pvData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEnumKeyIdentifierProperties([NativeTypeName("const CRYPT_HASH_BLOB *")] CRYPT_DATA_BLOB* pKeyIdentifier, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszComputerName, void* pvReserved, void* pvArg, [NativeTypeName("PFN_CRYPT_ENUM_KEYID_PROP")] delegate* unmanaged<CRYPT_DATA_BLOB*, uint, void*, void*, uint, uint*, void**, uint*, int> pfnEnum);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptCreateKeyIdentifierFromCSP([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszPubKeyOID, [NativeTypeName("const PUBLICKEYSTRUC *")] PUBLICKEYSTRUC* pPubKeyStruc, [NativeTypeName("DWORD")] uint cbPubKeyStruc, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved, [NativeTypeName("BYTE *")] byte* pbHash, [NativeTypeName("DWORD *")] uint* pcbHash);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertCreateCertificateChainEngine([NativeTypeName("PCERT_CHAIN_ENGINE_CONFIG")] CERT_CHAIN_ENGINE_CONFIG* pConfig, [NativeTypeName("HCERTCHAINENGINE *")] IntPtr* phChainEngine);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertFreeCertificateChainEngine([NativeTypeName("HCERTCHAINENGINE")] IntPtr hChainEngine);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertResyncCertificateChainEngine([NativeTypeName("HCERTCHAINENGINE")] IntPtr hChainEngine);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetCertificateChain([NativeTypeName("HCERTCHAINENGINE")] IntPtr hChainEngine, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("LPFILETIME")] FILETIME* pTime, [NativeTypeName("HCERTSTORE")] IntPtr hAdditionalStore, [NativeTypeName("PCERT_CHAIN_PARA")] CERT_CHAIN_PARA* pChainPara, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("PCCERT_CHAIN_CONTEXT *")] CERT_CHAIN_CONTEXT** ppChainContext);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertFreeCertificateChain([NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_CHAIN_CONTEXT")]
        public static extern CERT_CHAIN_CONTEXT* CertDuplicateCertificateChain([NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_CHAIN_CONTEXT")]
        public static extern CERT_CHAIN_CONTEXT* CertFindChainInStore([NativeTypeName("HCERTSTORE")] IntPtr hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwFindFlags, [NativeTypeName("DWORD")] uint dwFindType, [NativeTypeName("const void *")] void* pvFindPara, [NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pPrevChainContext);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertVerifyCertificateChainPolicy([NativeTypeName("LPCSTR")] sbyte* pszPolicyOID, [NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext, [NativeTypeName("PCERT_CHAIN_POLICY_PARA")] CERT_CHAIN_POLICY_PARA* pPolicyPara, [NativeTypeName("PCERT_CHAIN_POLICY_STATUS")] CERT_CHAIN_POLICY_STATUS* pPolicyStatus);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptStringToBinaryA([NativeTypeName("LPCSTR")] sbyte* pszString, [NativeTypeName("DWORD")] uint cchString, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbBinary, [NativeTypeName("DWORD *")] uint* pcbBinary, [NativeTypeName("DWORD *")] uint* pdwSkip, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptStringToBinaryW([NativeTypeName("LPCWSTR")] ushort* pszString, [NativeTypeName("DWORD")] uint cchString, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbBinary, [NativeTypeName("DWORD *")] uint* pcbBinary, [NativeTypeName("DWORD *")] uint* pdwSkip, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptBinaryToStringA([NativeTypeName("const BYTE *")] byte* pbBinary, [NativeTypeName("DWORD")] uint cbBinary, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* pszString, [NativeTypeName("DWORD *")] uint* pcchString);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptBinaryToStringW([NativeTypeName("const BYTE *")] byte* pbBinary, [NativeTypeName("DWORD")] uint cbBinary, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszString, [NativeTypeName("DWORD *")] uint* pcchString);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HCERTSTORE")]
        public static extern IntPtr PFXImportCertStore(CRYPT_DATA_BLOB* pPFX, [NativeTypeName("LPCWSTR")] ushort* szPassword, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PFXIsPFXBlob(CRYPT_DATA_BLOB* pPFX);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PFXVerifyPassword(CRYPT_DATA_BLOB* pPFX, [NativeTypeName("LPCWSTR")] ushort* szPassword, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PFXExportCertStoreEx([NativeTypeName("HCERTSTORE")] IntPtr hStore, CRYPT_DATA_BLOB* pPFX, [NativeTypeName("LPCWSTR")] ushort* szPassword, void* pvPara, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PFXExportCertStore([NativeTypeName("HCERTSTORE")] IntPtr hStore, CRYPT_DATA_BLOB* pPFX, [NativeTypeName("LPCWSTR")] ushort* szPassword, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HCERT_SERVER_OCSP_RESPONSE")]
        public static extern IntPtr CertOpenServerOcspResponse([NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_SERVER_OCSP_RESPONSE_OPEN_PARA")] CERT_SERVER_OCSP_RESPONSE_OPEN_PARA* pOpenPara);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertAddRefServerOcspResponse([NativeTypeName("HCERT_SERVER_OCSP_RESPONSE")] IntPtr hServerOcspResponse);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertCloseServerOcspResponse([NativeTypeName("HCERT_SERVER_OCSP_RESPONSE")] IntPtr hServerOcspResponse, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_SERVER_OCSP_RESPONSE_CONTEXT")]
        public static extern CERT_SERVER_OCSP_RESPONSE_CONTEXT* CertGetServerOcspResponseContext([NativeTypeName("HCERT_SERVER_OCSP_RESPONSE")] IntPtr hServerOcspResponse, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* pvReserved);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertAddRefServerOcspResponseContext([NativeTypeName("PCCERT_SERVER_OCSP_RESPONSE_CONTEXT")] CERT_SERVER_OCSP_RESPONSE_CONTEXT* pServerOcspResponseContext);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertFreeServerOcspResponseContext([NativeTypeName("PCCERT_SERVER_OCSP_RESPONSE_CONTEXT")] CERT_SERVER_OCSP_RESPONSE_CONTEXT* pServerOcspResponseContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertRetrieveLogoOrBiometricInfo([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("LPCSTR")] sbyte* lpszLogoOrBiometricType, [NativeTypeName("DWORD")] uint dwRetrievalFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved, [NativeTypeName("BYTE **")] byte** ppbData, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("LPWSTR *")] ushort** ppwszMimeType);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSelectCertificateChains([NativeTypeName("LPCGUID")] Guid* pSelectionContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCCERT_SELECT_CHAIN_PARA")] CERT_SELECT_CHAIN_PARA* pChainParameters, [NativeTypeName("DWORD")] uint cCriteria, [NativeTypeName("PCCERT_SELECT_CRITERIA")] CERT_SELECT_CRITERIA* rgpCriteria, [NativeTypeName("HCERTSTORE")] IntPtr hStore, [NativeTypeName("PDWORD")] uint* pcSelection, [NativeTypeName("PCCERT_CHAIN_CONTEXT **")] CERT_CHAIN_CONTEXT*** pprgpSelection);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertFreeCertificateChainList([NativeTypeName("PCCERT_CHAIN_CONTEXT *")] CERT_CHAIN_CONTEXT** prgpSelection);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptRetrieveTimeStamp([NativeTypeName("LPCWSTR")] ushort* wszUrl, [NativeTypeName("DWORD")] uint dwRetrievalFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("LPCSTR")] sbyte* pszHashId, [NativeTypeName("const CRYPT_TIMESTAMP_PARA *")] CRYPT_TIMESTAMP_PARA* pPara, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("PCRYPT_TIMESTAMP_CONTEXT *")] CRYPT_TIMESTAMP_CONTEXT** ppTsContext, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppTsSigner, [NativeTypeName("HCERTSTORE *")] IntPtr* phStore);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyTimeStampSignature([NativeTypeName("const BYTE *")] byte* pbTSContentInfo, [NativeTypeName("DWORD")] uint cbTSContentInfo, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("HCERTSTORE")] IntPtr hAdditionalStore, [NativeTypeName("PCRYPT_TIMESTAMP_CONTEXT *")] CRYPT_TIMESTAMP_CONTEXT** ppTsContext, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppTsSigner, [NativeTypeName("HCERTSTORE *")] IntPtr* phStore);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertIsWeakHash([NativeTypeName("DWORD")] uint dwHashUseType, [NativeTypeName("LPCWSTR")] ushort* pwszCNGHashAlgid, [NativeTypeName("DWORD")] uint dwChainFlags, [NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pSignerChainContext, [NativeTypeName("LPFILETIME")] FILETIME* pTimeStamp, [NativeTypeName("LPCWSTR")] ushort* pwszFileName);

        [NativeTypeName("#define ALG_CLASS_ANY (0)")]
        public const int ALG_CLASS_ANY = (0);

        [NativeTypeName("#define ALG_CLASS_SIGNATURE (1 << 13)")]
        public const int ALG_CLASS_SIGNATURE = (1 << 13);

        [NativeTypeName("#define ALG_CLASS_MSG_ENCRYPT (2 << 13)")]
        public const int ALG_CLASS_MSG_ENCRYPT = (2 << 13);

        [NativeTypeName("#define ALG_CLASS_DATA_ENCRYPT (3 << 13)")]
        public const int ALG_CLASS_DATA_ENCRYPT = (3 << 13);

        [NativeTypeName("#define ALG_CLASS_HASH (4 << 13)")]
        public const int ALG_CLASS_HASH = (4 << 13);

        [NativeTypeName("#define ALG_CLASS_KEY_EXCHANGE (5 << 13)")]
        public const int ALG_CLASS_KEY_EXCHANGE = (5 << 13);

        [NativeTypeName("#define ALG_CLASS_ALL (7 << 13)")]
        public const int ALG_CLASS_ALL = (7 << 13);

        [NativeTypeName("#define ALG_TYPE_ANY (0)")]
        public const int ALG_TYPE_ANY = (0);

        [NativeTypeName("#define ALG_TYPE_DSS (1 << 9)")]
        public const int ALG_TYPE_DSS = (1 << 9);

        [NativeTypeName("#define ALG_TYPE_RSA (2 << 9)")]
        public const int ALG_TYPE_RSA = (2 << 9);

        [NativeTypeName("#define ALG_TYPE_BLOCK (3 << 9)")]
        public const int ALG_TYPE_BLOCK = (3 << 9);

        [NativeTypeName("#define ALG_TYPE_STREAM (4 << 9)")]
        public const int ALG_TYPE_STREAM = (4 << 9);

        [NativeTypeName("#define ALG_TYPE_DH (5 << 9)")]
        public const int ALG_TYPE_DH = (5 << 9);

        [NativeTypeName("#define ALG_TYPE_SECURECHANNEL (6 << 9)")]
        public const int ALG_TYPE_SECURECHANNEL = (6 << 9);

        [NativeTypeName("#define ALG_TYPE_ECDH (7 << 9)")]
        public const int ALG_TYPE_ECDH = (7 << 9);

        [NativeTypeName("#define ALG_TYPE_THIRDPARTY (8 << 9)")]
        public const int ALG_TYPE_THIRDPARTY = (8 << 9);

        [NativeTypeName("#define ALG_SID_ANY (0)")]
        public const int ALG_SID_ANY = (0);

        [NativeTypeName("#define ALG_SID_THIRDPARTY_ANY (0)")]
        public const int ALG_SID_THIRDPARTY_ANY = (0);

        [NativeTypeName("#define ALG_SID_RSA_ANY 0")]
        public const int ALG_SID_RSA_ANY = 0;

        [NativeTypeName("#define ALG_SID_RSA_PKCS 1")]
        public const int ALG_SID_RSA_PKCS = 1;

        [NativeTypeName("#define ALG_SID_RSA_MSATWORK 2")]
        public const int ALG_SID_RSA_MSATWORK = 2;

        [NativeTypeName("#define ALG_SID_RSA_ENTRUST 3")]
        public const int ALG_SID_RSA_ENTRUST = 3;

        [NativeTypeName("#define ALG_SID_RSA_PGP 4")]
        public const int ALG_SID_RSA_PGP = 4;

        [NativeTypeName("#define ALG_SID_DSS_ANY 0")]
        public const int ALG_SID_DSS_ANY = 0;

        [NativeTypeName("#define ALG_SID_DSS_PKCS 1")]
        public const int ALG_SID_DSS_PKCS = 1;

        [NativeTypeName("#define ALG_SID_DSS_DMS 2")]
        public const int ALG_SID_DSS_DMS = 2;

        [NativeTypeName("#define ALG_SID_ECDSA 3")]
        public const int ALG_SID_ECDSA = 3;

        [NativeTypeName("#define ALG_SID_DES 1")]
        public const int ALG_SID_DES = 1;

        [NativeTypeName("#define ALG_SID_3DES 3")]
        public const int ALG_SID_3DES = 3;

        [NativeTypeName("#define ALG_SID_DESX 4")]
        public const int ALG_SID_DESX = 4;

        [NativeTypeName("#define ALG_SID_IDEA 5")]
        public const int ALG_SID_IDEA = 5;

        [NativeTypeName("#define ALG_SID_CAST 6")]
        public const int ALG_SID_CAST = 6;

        [NativeTypeName("#define ALG_SID_SAFERSK64 7")]
        public const int ALG_SID_SAFERSK64 = 7;

        [NativeTypeName("#define ALG_SID_SAFERSK128 8")]
        public const int ALG_SID_SAFERSK128 = 8;

        [NativeTypeName("#define ALG_SID_3DES_112 9")]
        public const int ALG_SID_3DES_112 = 9;

        [NativeTypeName("#define ALG_SID_CYLINK_MEK 12")]
        public const int ALG_SID_CYLINK_MEK = 12;

        [NativeTypeName("#define ALG_SID_RC5 13")]
        public const int ALG_SID_RC5 = 13;

        [NativeTypeName("#define ALG_SID_AES_128 14")]
        public const int ALG_SID_AES_128 = 14;

        [NativeTypeName("#define ALG_SID_AES_192 15")]
        public const int ALG_SID_AES_192 = 15;

        [NativeTypeName("#define ALG_SID_AES_256 16")]
        public const int ALG_SID_AES_256 = 16;

        [NativeTypeName("#define ALG_SID_AES 17")]
        public const int ALG_SID_AES = 17;

        [NativeTypeName("#define ALG_SID_SKIPJACK 10")]
        public const int ALG_SID_SKIPJACK = 10;

        [NativeTypeName("#define ALG_SID_TEK 11")]
        public const int ALG_SID_TEK = 11;

        [NativeTypeName("#define CRYPT_MODE_CBCI 6")]
        public const int CRYPT_MODE_CBCI = 6;

        [NativeTypeName("#define CRYPT_MODE_CFBP 7")]
        public const int CRYPT_MODE_CFBP = 7;

        [NativeTypeName("#define CRYPT_MODE_OFBP 8")]
        public const int CRYPT_MODE_OFBP = 8;

        [NativeTypeName("#define CRYPT_MODE_CBCOFM 9")]
        public const int CRYPT_MODE_CBCOFM = 9;

        [NativeTypeName("#define CRYPT_MODE_CBCOFMI 10")]
        public const int CRYPT_MODE_CBCOFMI = 10;

        [NativeTypeName("#define ALG_SID_RC2 2")]
        public const int ALG_SID_RC2 = 2;

        [NativeTypeName("#define ALG_SID_RC4 1")]
        public const int ALG_SID_RC4 = 1;

        [NativeTypeName("#define ALG_SID_SEAL 2")]
        public const int ALG_SID_SEAL = 2;

        [NativeTypeName("#define ALG_SID_DH_SANDF 1")]
        public const int ALG_SID_DH_SANDF = 1;

        [NativeTypeName("#define ALG_SID_DH_EPHEM 2")]
        public const int ALG_SID_DH_EPHEM = 2;

        [NativeTypeName("#define ALG_SID_AGREED_KEY_ANY 3")]
        public const int ALG_SID_AGREED_KEY_ANY = 3;

        [NativeTypeName("#define ALG_SID_KEA 4")]
        public const int ALG_SID_KEA = 4;

        [NativeTypeName("#define ALG_SID_ECDH 5")]
        public const int ALG_SID_ECDH = 5;

        [NativeTypeName("#define ALG_SID_ECDH_EPHEM 6")]
        public const int ALG_SID_ECDH_EPHEM = 6;

        [NativeTypeName("#define ALG_SID_MD2 1")]
        public const int ALG_SID_MD2 = 1;

        [NativeTypeName("#define ALG_SID_MD4 2")]
        public const int ALG_SID_MD4 = 2;

        [NativeTypeName("#define ALG_SID_MD5 3")]
        public const int ALG_SID_MD5 = 3;

        [NativeTypeName("#define ALG_SID_SHA 4")]
        public const int ALG_SID_SHA = 4;

        [NativeTypeName("#define ALG_SID_SHA1 4")]
        public const int ALG_SID_SHA1 = 4;

        [NativeTypeName("#define ALG_SID_MAC 5")]
        public const int ALG_SID_MAC = 5;

        [NativeTypeName("#define ALG_SID_RIPEMD 6")]
        public const int ALG_SID_RIPEMD = 6;

        [NativeTypeName("#define ALG_SID_RIPEMD160 7")]
        public const int ALG_SID_RIPEMD160 = 7;

        [NativeTypeName("#define ALG_SID_SSL3SHAMD5 8")]
        public const int ALG_SID_SSL3SHAMD5 = 8;

        [NativeTypeName("#define ALG_SID_HMAC 9")]
        public const int ALG_SID_HMAC = 9;

        [NativeTypeName("#define ALG_SID_TLS1PRF 10")]
        public const int ALG_SID_TLS1PRF = 10;

        [NativeTypeName("#define ALG_SID_HASH_REPLACE_OWF 11")]
        public const int ALG_SID_HASH_REPLACE_OWF = 11;

        [NativeTypeName("#define ALG_SID_SHA_256 12")]
        public const int ALG_SID_SHA_256 = 12;

        [NativeTypeName("#define ALG_SID_SHA_384 13")]
        public const int ALG_SID_SHA_384 = 13;

        [NativeTypeName("#define ALG_SID_SHA_512 14")]
        public const int ALG_SID_SHA_512 = 14;

        [NativeTypeName("#define ALG_SID_SSL3_MASTER 1")]
        public const int ALG_SID_SSL3_MASTER = 1;

        [NativeTypeName("#define ALG_SID_SCHANNEL_MASTER_HASH 2")]
        public const int ALG_SID_SCHANNEL_MASTER_HASH = 2;

        [NativeTypeName("#define ALG_SID_SCHANNEL_MAC_KEY 3")]
        public const int ALG_SID_SCHANNEL_MAC_KEY = 3;

        [NativeTypeName("#define ALG_SID_PCT1_MASTER 4")]
        public const int ALG_SID_PCT1_MASTER = 4;

        [NativeTypeName("#define ALG_SID_SSL2_MASTER 5")]
        public const int ALG_SID_SSL2_MASTER = 5;

        [NativeTypeName("#define ALG_SID_TLS1_MASTER 6")]
        public const int ALG_SID_TLS1_MASTER = 6;

        [NativeTypeName("#define ALG_SID_SCHANNEL_ENC_KEY 7")]
        public const int ALG_SID_SCHANNEL_ENC_KEY = 7;

        [NativeTypeName("#define ALG_SID_ECMQV 1")]
        public const int ALG_SID_ECMQV = 1;

        [NativeTypeName("#define ALG_SID_EXAMPLE 80")]
        public const int ALG_SID_EXAMPLE = 80;

        [NativeTypeName("#define CALG_MD2 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MD2)")]
        public const int CALG_MD2 = ((4 << 13) | (0) | 1);

        [NativeTypeName("#define CALG_MD4 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MD4)")]
        public const int CALG_MD4 = ((4 << 13) | (0) | 2);

        [NativeTypeName("#define CALG_MD5 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MD5)")]
        public const int CALG_MD5 = ((4 << 13) | (0) | 3);

        [NativeTypeName("#define CALG_SHA (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA)")]
        public const int CALG_SHA = ((4 << 13) | (0) | 4);

        [NativeTypeName("#define CALG_SHA1 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA1)")]
        public const int CALG_SHA1 = ((4 << 13) | (0) | 4);

        [NativeTypeName("#define CALG_MAC (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MAC)")]
        public const int CALG_MAC = ((4 << 13) | (0) | 5);

        [NativeTypeName("#define CALG_RSA_SIGN (ALG_CLASS_SIGNATURE | ALG_TYPE_RSA | ALG_SID_RSA_ANY)")]
        public const int CALG_RSA_SIGN = ((1 << 13) | (2 << 9) | 0);

        [NativeTypeName("#define CALG_DSS_SIGN (ALG_CLASS_SIGNATURE | ALG_TYPE_DSS | ALG_SID_DSS_ANY)")]
        public const int CALG_DSS_SIGN = ((1 << 13) | (1 << 9) | 0);

        [NativeTypeName("#define CALG_NO_SIGN (ALG_CLASS_SIGNATURE | ALG_TYPE_ANY | ALG_SID_ANY)")]
        public const int CALG_NO_SIGN = ((1 << 13) | (0) | (0));

        [NativeTypeName("#define CALG_RSA_KEYX (ALG_CLASS_KEY_EXCHANGE|ALG_TYPE_RSA|ALG_SID_RSA_ANY)")]
        public const int CALG_RSA_KEYX = ((5 << 13) | (2 << 9) | 0);

        [NativeTypeName("#define CALG_DES (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_DES)")]
        public const int CALG_DES = ((3 << 13) | (3 << 9) | 1);

        [NativeTypeName("#define CALG_3DES_112 (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_3DES_112)")]
        public const int CALG_3DES_112 = ((3 << 13) | (3 << 9) | 9);

        [NativeTypeName("#define CALG_3DES (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_3DES)")]
        public const int CALG_3DES = ((3 << 13) | (3 << 9) | 3);

        [NativeTypeName("#define CALG_DESX (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_DESX)")]
        public const int CALG_DESX = ((3 << 13) | (3 << 9) | 4);

        [NativeTypeName("#define CALG_RC2 (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_RC2)")]
        public const int CALG_RC2 = ((3 << 13) | (3 << 9) | 2);

        [NativeTypeName("#define CALG_RC4 (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_STREAM|ALG_SID_RC4)")]
        public const int CALG_RC4 = ((3 << 13) | (4 << 9) | 1);

        [NativeTypeName("#define CALG_SEAL (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_STREAM|ALG_SID_SEAL)")]
        public const int CALG_SEAL = ((3 << 13) | (4 << 9) | 2);

        [NativeTypeName("#define CALG_DH_SF (ALG_CLASS_KEY_EXCHANGE|ALG_TYPE_DH|ALG_SID_DH_SANDF)")]
        public const int CALG_DH_SF = ((5 << 13) | (5 << 9) | 1);

        [NativeTypeName("#define CALG_DH_EPHEM (ALG_CLASS_KEY_EXCHANGE|ALG_TYPE_DH|ALG_SID_DH_EPHEM)")]
        public const int CALG_DH_EPHEM = ((5 << 13) | (5 << 9) | 2);

        [NativeTypeName("#define CALG_AGREEDKEY_ANY (ALG_CLASS_KEY_EXCHANGE|ALG_TYPE_DH|ALG_SID_AGREED_KEY_ANY)")]
        public const int CALG_AGREEDKEY_ANY = ((5 << 13) | (5 << 9) | 3);

        [NativeTypeName("#define CALG_KEA_KEYX (ALG_CLASS_KEY_EXCHANGE|ALG_TYPE_DH|ALG_SID_KEA)")]
        public const int CALG_KEA_KEYX = ((5 << 13) | (5 << 9) | 4);

        [NativeTypeName("#define CALG_HUGHES_MD5 (ALG_CLASS_KEY_EXCHANGE|ALG_TYPE_ANY|ALG_SID_MD5)")]
        public const int CALG_HUGHES_MD5 = ((5 << 13) | (0) | 3);

        [NativeTypeName("#define CALG_SKIPJACK (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_SKIPJACK)")]
        public const int CALG_SKIPJACK = ((3 << 13) | (3 << 9) | 10);

        [NativeTypeName("#define CALG_TEK (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_TEK)")]
        public const int CALG_TEK = ((3 << 13) | (3 << 9) | 11);

        [NativeTypeName("#define CALG_CYLINK_MEK (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_CYLINK_MEK)")]
        public const int CALG_CYLINK_MEK = ((3 << 13) | (3 << 9) | 12);

        [NativeTypeName("#define CALG_SSL3_SHAMD5 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SSL3SHAMD5)")]
        public const int CALG_SSL3_SHAMD5 = ((4 << 13) | (0) | 8);

        [NativeTypeName("#define CALG_SSL3_MASTER (ALG_CLASS_MSG_ENCRYPT|ALG_TYPE_SECURECHANNEL|ALG_SID_SSL3_MASTER)")]
        public const int CALG_SSL3_MASTER = ((2 << 13) | (6 << 9) | 1);

        [NativeTypeName("#define CALG_SCHANNEL_MASTER_HASH (ALG_CLASS_MSG_ENCRYPT|ALG_TYPE_SECURECHANNEL|ALG_SID_SCHANNEL_MASTER_HASH)")]
        public const int CALG_SCHANNEL_MASTER_HASH = ((2 << 13) | (6 << 9) | 2);

        [NativeTypeName("#define CALG_SCHANNEL_MAC_KEY (ALG_CLASS_MSG_ENCRYPT|ALG_TYPE_SECURECHANNEL|ALG_SID_SCHANNEL_MAC_KEY)")]
        public const int CALG_SCHANNEL_MAC_KEY = ((2 << 13) | (6 << 9) | 3);

        [NativeTypeName("#define CALG_SCHANNEL_ENC_KEY (ALG_CLASS_MSG_ENCRYPT|ALG_TYPE_SECURECHANNEL|ALG_SID_SCHANNEL_ENC_KEY)")]
        public const int CALG_SCHANNEL_ENC_KEY = ((2 << 13) | (6 << 9) | 7);

        [NativeTypeName("#define CALG_PCT1_MASTER (ALG_CLASS_MSG_ENCRYPT|ALG_TYPE_SECURECHANNEL|ALG_SID_PCT1_MASTER)")]
        public const int CALG_PCT1_MASTER = ((2 << 13) | (6 << 9) | 4);

        [NativeTypeName("#define CALG_SSL2_MASTER (ALG_CLASS_MSG_ENCRYPT|ALG_TYPE_SECURECHANNEL|ALG_SID_SSL2_MASTER)")]
        public const int CALG_SSL2_MASTER = ((2 << 13) | (6 << 9) | 5);

        [NativeTypeName("#define CALG_TLS1_MASTER (ALG_CLASS_MSG_ENCRYPT|ALG_TYPE_SECURECHANNEL|ALG_SID_TLS1_MASTER)")]
        public const int CALG_TLS1_MASTER = ((2 << 13) | (6 << 9) | 6);

        [NativeTypeName("#define CALG_RC5 (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_RC5)")]
        public const int CALG_RC5 = ((3 << 13) | (3 << 9) | 13);

        [NativeTypeName("#define CALG_HMAC (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_HMAC)")]
        public const int CALG_HMAC = ((4 << 13) | (0) | 9);

        [NativeTypeName("#define CALG_TLS1PRF (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_TLS1PRF)")]
        public const int CALG_TLS1PRF = ((4 << 13) | (0) | 10);

        [NativeTypeName("#define CALG_HASH_REPLACE_OWF (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_HASH_REPLACE_OWF)")]
        public const int CALG_HASH_REPLACE_OWF = ((4 << 13) | (0) | 11);

        [NativeTypeName("#define CALG_AES_128 (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_AES_128)")]
        public const int CALG_AES_128 = ((3 << 13) | (3 << 9) | 14);

        [NativeTypeName("#define CALG_AES_192 (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_AES_192)")]
        public const int CALG_AES_192 = ((3 << 13) | (3 << 9) | 15);

        [NativeTypeName("#define CALG_AES_256 (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_AES_256)")]
        public const int CALG_AES_256 = ((3 << 13) | (3 << 9) | 16);

        [NativeTypeName("#define CALG_AES (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_AES)")]
        public const int CALG_AES = ((3 << 13) | (3 << 9) | 17);

        [NativeTypeName("#define CALG_SHA_256 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA_256)")]
        public const int CALG_SHA_256 = ((4 << 13) | (0) | 12);

        [NativeTypeName("#define CALG_SHA_384 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA_384)")]
        public const int CALG_SHA_384 = ((4 << 13) | (0) | 13);

        [NativeTypeName("#define CALG_SHA_512 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA_512)")]
        public const int CALG_SHA_512 = ((4 << 13) | (0) | 14);

        [NativeTypeName("#define CALG_ECDH (ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_DH | ALG_SID_ECDH)")]
        public const int CALG_ECDH = ((5 << 13) | (5 << 9) | 5);

        [NativeTypeName("#define CALG_ECDH_EPHEM (ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_ECDH | ALG_SID_ECDH_EPHEM)")]
        public const int CALG_ECDH_EPHEM = ((5 << 13) | (7 << 9) | 6);

        [NativeTypeName("#define CALG_ECMQV (ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_ANY | ALG_SID_ECMQV)")]
        public const int CALG_ECMQV = ((5 << 13) | (0) | 1);

        [NativeTypeName("#define CALG_ECDSA (ALG_CLASS_SIGNATURE | ALG_TYPE_DSS | ALG_SID_ECDSA)")]
        public const int CALG_ECDSA = ((1 << 13) | (1 << 9) | 3);

        [NativeTypeName("#define CALG_NULLCIPHER (ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_ANY | 0)")]
        public const int CALG_NULLCIPHER = ((3 << 13) | (0) | 0);

        [NativeTypeName("#define CALG_THIRDPARTY_KEY_EXCHANGE (ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY)")]
        public const int CALG_THIRDPARTY_KEY_EXCHANGE = ((5 << 13) | (8 << 9) | (0));

        [NativeTypeName("#define CALG_THIRDPARTY_SIGNATURE (ALG_CLASS_SIGNATURE    | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY)")]
        public const int CALG_THIRDPARTY_SIGNATURE = ((1 << 13) | (8 << 9) | (0));

        [NativeTypeName("#define CALG_THIRDPARTY_CIPHER (ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY)")]
        public const int CALG_THIRDPARTY_CIPHER = ((3 << 13) | (8 << 9) | (0));

        [NativeTypeName("#define CALG_THIRDPARTY_HASH (ALG_CLASS_HASH         | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY)")]
        public const int CALG_THIRDPARTY_HASH = ((4 << 13) | (8 << 9) | (0));

        [NativeTypeName("#define CRYPT_VERIFYCONTEXT 0xF0000000")]
        public const uint CRYPT_VERIFYCONTEXT = 0xF0000000;

        [NativeTypeName("#define CRYPT_NEWKEYSET 0x00000008")]
        public const int CRYPT_NEWKEYSET = 0x00000008;

        [NativeTypeName("#define CRYPT_DELETEKEYSET 0x00000010")]
        public const int CRYPT_DELETEKEYSET = 0x00000010;

        [NativeTypeName("#define CRYPT_MACHINE_KEYSET 0x00000020")]
        public const int CRYPT_MACHINE_KEYSET = 0x00000020;

        [NativeTypeName("#define CRYPT_SILENT 0x00000040")]
        public const int CRYPT_SILENT = 0x00000040;

        [NativeTypeName("#define CRYPT_DEFAULT_CONTAINER_OPTIONAL 0x00000080")]
        public const int CRYPT_DEFAULT_CONTAINER_OPTIONAL = 0x00000080;

        [NativeTypeName("#define CRYPT_EXPORTABLE 0x00000001")]
        public const int CRYPT_EXPORTABLE = 0x00000001;

        [NativeTypeName("#define CRYPT_USER_PROTECTED 0x00000002")]
        public const int CRYPT_USER_PROTECTED = 0x00000002;

        [NativeTypeName("#define CRYPT_CREATE_SALT 0x00000004")]
        public const int CRYPT_CREATE_SALT = 0x00000004;

        [NativeTypeName("#define CRYPT_UPDATE_KEY 0x00000008")]
        public const int CRYPT_UPDATE_KEY = 0x00000008;

        [NativeTypeName("#define CRYPT_NO_SALT 0x00000010")]
        public const int CRYPT_NO_SALT = 0x00000010;

        [NativeTypeName("#define CRYPT_PREGEN 0x00000040")]
        public const int CRYPT_PREGEN = 0x00000040;

        [NativeTypeName("#define CRYPT_RECIPIENT 0x00000010")]
        public const int CRYPT_RECIPIENT = 0x00000010;

        [NativeTypeName("#define CRYPT_INITIATOR 0x00000040")]
        public const int CRYPT_INITIATOR = 0x00000040;

        [NativeTypeName("#define CRYPT_ONLINE 0x00000080")]
        public const int CRYPT_ONLINE = 0x00000080;

        [NativeTypeName("#define CRYPT_SF 0x00000100")]
        public const int CRYPT_SF = 0x00000100;

        [NativeTypeName("#define CRYPT_CREATE_IV 0x00000200")]
        public const int CRYPT_CREATE_IV = 0x00000200;

        [NativeTypeName("#define CRYPT_KEK 0x00000400")]
        public const int CRYPT_KEK = 0x00000400;

        [NativeTypeName("#define CRYPT_DATA_KEY 0x00000800")]
        public const int CRYPT_DATA_KEY = 0x00000800;

        [NativeTypeName("#define CRYPT_VOLATILE 0x00001000")]
        public const int CRYPT_VOLATILE = 0x00001000;

        [NativeTypeName("#define CRYPT_SGCKEY 0x00002000")]
        public const int CRYPT_SGCKEY = 0x00002000;

        [NativeTypeName("#define CRYPT_USER_PROTECTED_STRONG 0x00100000")]
        public const int CRYPT_USER_PROTECTED_STRONG = 0x00100000;

        [NativeTypeName("#define CRYPT_ARCHIVABLE 0x00004000")]
        public const int CRYPT_ARCHIVABLE = 0x00004000;

        [NativeTypeName("#define CRYPT_FORCE_KEY_PROTECTION_HIGH 0x00008000")]
        public const int CRYPT_FORCE_KEY_PROTECTION_HIGH = 0x00008000;

        [NativeTypeName("#define RSA1024BIT_KEY 0x04000000")]
        public const int RSA1024BIT_KEY = 0x04000000;

        [NativeTypeName("#define CRYPT_SERVER 0x00000400")]
        public const int CRYPT_SERVER = 0x00000400;

        [NativeTypeName("#define KEY_LENGTH_MASK 0xFFFF0000")]
        public const uint KEY_LENGTH_MASK = 0xFFFF0000;

        [NativeTypeName("#define CRYPT_Y_ONLY 0x00000001")]
        public const int CRYPT_Y_ONLY = 0x00000001;

        [NativeTypeName("#define CRYPT_SSL2_FALLBACK 0x00000002")]
        public const int CRYPT_SSL2_FALLBACK = 0x00000002;

        [NativeTypeName("#define CRYPT_DESTROYKEY 0x00000004")]
        public const int CRYPT_DESTROYKEY = 0x00000004;

        [NativeTypeName("#define CRYPT_OAEP 0x00000040")]
        public const int CRYPT_OAEP = 0x00000040;

        [NativeTypeName("#define CRYPT_BLOB_VER3 0x00000080")]
        public const int CRYPT_BLOB_VER3 = 0x00000080;

        [NativeTypeName("#define CRYPT_IPSEC_HMAC_KEY 0x00000100")]
        public const int CRYPT_IPSEC_HMAC_KEY = 0x00000100;

        [NativeTypeName("#define CRYPT_DECRYPT_RSA_NO_PADDING_CHECK 0x00000020")]
        public const int CRYPT_DECRYPT_RSA_NO_PADDING_CHECK = 0x00000020;

        [NativeTypeName("#define CRYPT_SECRETDIGEST 0x00000001")]
        public const int CRYPT_SECRETDIGEST = 0x00000001;

        [NativeTypeName("#define CRYPT_OWF_REPL_LM_HASH 0x00000001")]
        public const int CRYPT_OWF_REPL_LM_HASH = 0x00000001;

        [NativeTypeName("#define CRYPT_LITTLE_ENDIAN 0x00000001")]
        public const int CRYPT_LITTLE_ENDIAN = 0x00000001;

        [NativeTypeName("#define CRYPT_NOHASHOID 0x00000001")]
        public const int CRYPT_NOHASHOID = 0x00000001;

        [NativeTypeName("#define CRYPT_TYPE2_FORMAT 0x00000002")]
        public const int CRYPT_TYPE2_FORMAT = 0x00000002;

        [NativeTypeName("#define CRYPT_X931_FORMAT 0x00000004")]
        public const int CRYPT_X931_FORMAT = 0x00000004;

        [NativeTypeName("#define CRYPT_MACHINE_DEFAULT 0x00000001")]
        public const int CRYPT_MACHINE_DEFAULT = 0x00000001;

        [NativeTypeName("#define CRYPT_USER_DEFAULT 0x00000002")]
        public const int CRYPT_USER_DEFAULT = 0x00000002;

        [NativeTypeName("#define CRYPT_DELETE_DEFAULT 0x00000004")]
        public const int CRYPT_DELETE_DEFAULT = 0x00000004;

        [NativeTypeName("#define SIMPLEBLOB 0x1")]
        public const int SIMPLEBLOB = 0x1;

        [NativeTypeName("#define PUBLICKEYBLOB 0x6")]
        public const int PUBLICKEYBLOB = 0x6;

        [NativeTypeName("#define PRIVATEKEYBLOB 0x7")]
        public const int PRIVATEKEYBLOB = 0x7;

        [NativeTypeName("#define PLAINTEXTKEYBLOB 0x8")]
        public const int PLAINTEXTKEYBLOB = 0x8;

        [NativeTypeName("#define OPAQUEKEYBLOB 0x9")]
        public const int OPAQUEKEYBLOB = 0x9;

        [NativeTypeName("#define PUBLICKEYBLOBEX 0xA")]
        public const int PUBLICKEYBLOBEX = 0xA;

        [NativeTypeName("#define SYMMETRICWRAPKEYBLOB 0xB")]
        public const int SYMMETRICWRAPKEYBLOB = 0xB;

        [NativeTypeName("#define KEYSTATEBLOB 0xC")]
        public const int KEYSTATEBLOB = 0xC;

        [NativeTypeName("#define AT_KEYEXCHANGE 1")]
        public const int AT_KEYEXCHANGE = 1;

        [NativeTypeName("#define AT_SIGNATURE 2")]
        public const int AT_SIGNATURE = 2;

        [NativeTypeName("#define CRYPT_USERDATA 1")]
        public const int CRYPT_USERDATA = 1;

        [NativeTypeName("#define KP_IV 1")]
        public const int KP_IV = 1;

        [NativeTypeName("#define KP_SALT 2")]
        public const int KP_SALT = 2;

        [NativeTypeName("#define KP_PADDING 3")]
        public const int KP_PADDING = 3;

        [NativeTypeName("#define KP_MODE 4")]
        public const int KP_MODE = 4;

        [NativeTypeName("#define KP_MODE_BITS 5")]
        public const int KP_MODE_BITS = 5;

        [NativeTypeName("#define KP_PERMISSIONS 6")]
        public const int KP_PERMISSIONS = 6;

        [NativeTypeName("#define KP_ALGID 7")]
        public const int KP_ALGID = 7;

        [NativeTypeName("#define KP_BLOCKLEN 8")]
        public const int KP_BLOCKLEN = 8;

        [NativeTypeName("#define KP_KEYLEN 9")]
        public const int KP_KEYLEN = 9;

        [NativeTypeName("#define KP_SALT_EX 10")]
        public const int KP_SALT_EX = 10;

        [NativeTypeName("#define KP_P 11")]
        public const int KP_P = 11;

        [NativeTypeName("#define KP_G 12")]
        public const int KP_G = 12;

        [NativeTypeName("#define KP_Q 13")]
        public const int KP_Q = 13;

        [NativeTypeName("#define KP_X 14")]
        public const int KP_X = 14;

        [NativeTypeName("#define KP_Y 15")]
        public const int KP_Y = 15;

        [NativeTypeName("#define KP_RA 16")]
        public const int KP_RA = 16;

        [NativeTypeName("#define KP_RB 17")]
        public const int KP_RB = 17;

        [NativeTypeName("#define KP_INFO 18")]
        public const int KP_INFO = 18;

        [NativeTypeName("#define KP_EFFECTIVE_KEYLEN 19")]
        public const int KP_EFFECTIVE_KEYLEN = 19;

        [NativeTypeName("#define KP_SCHANNEL_ALG 20")]
        public const int KP_SCHANNEL_ALG = 20;

        [NativeTypeName("#define KP_CLIENT_RANDOM 21")]
        public const int KP_CLIENT_RANDOM = 21;

        [NativeTypeName("#define KP_SERVER_RANDOM 22")]
        public const int KP_SERVER_RANDOM = 22;

        [NativeTypeName("#define KP_RP 23")]
        public const int KP_RP = 23;

        [NativeTypeName("#define KP_PRECOMP_MD5 24")]
        public const int KP_PRECOMP_MD5 = 24;

        [NativeTypeName("#define KP_PRECOMP_SHA 25")]
        public const int KP_PRECOMP_SHA = 25;

        [NativeTypeName("#define KP_CERTIFICATE 26")]
        public const int KP_CERTIFICATE = 26;

        [NativeTypeName("#define KP_CLEAR_KEY 27")]
        public const int KP_CLEAR_KEY = 27;

        [NativeTypeName("#define KP_PUB_EX_LEN 28")]
        public const int KP_PUB_EX_LEN = 28;

        [NativeTypeName("#define KP_PUB_EX_VAL 29")]
        public const int KP_PUB_EX_VAL = 29;

        [NativeTypeName("#define KP_KEYVAL 30")]
        public const int KP_KEYVAL = 30;

        [NativeTypeName("#define KP_ADMIN_PIN 31")]
        public const int KP_ADMIN_PIN = 31;

        [NativeTypeName("#define KP_KEYEXCHANGE_PIN 32")]
        public const int KP_KEYEXCHANGE_PIN = 32;

        [NativeTypeName("#define KP_SIGNATURE_PIN 33")]
        public const int KP_SIGNATURE_PIN = 33;

        [NativeTypeName("#define KP_PREHASH 34")]
        public const int KP_PREHASH = 34;

        [NativeTypeName("#define KP_ROUNDS 35")]
        public const int KP_ROUNDS = 35;

        [NativeTypeName("#define KP_OAEP_PARAMS 36")]
        public const int KP_OAEP_PARAMS = 36;

        [NativeTypeName("#define KP_CMS_KEY_INFO 37")]
        public const int KP_CMS_KEY_INFO = 37;

        [NativeTypeName("#define KP_CMS_DH_KEY_INFO 38")]
        public const int KP_CMS_DH_KEY_INFO = 38;

        [NativeTypeName("#define KP_PUB_PARAMS 39")]
        public const int KP_PUB_PARAMS = 39;

        [NativeTypeName("#define KP_VERIFY_PARAMS 40")]
        public const int KP_VERIFY_PARAMS = 40;

        [NativeTypeName("#define KP_HIGHEST_VERSION 41")]
        public const int KP_HIGHEST_VERSION = 41;

        [NativeTypeName("#define KP_GET_USE_COUNT 42")]
        public const int KP_GET_USE_COUNT = 42;

        [NativeTypeName("#define KP_PIN_ID 43")]
        public const int KP_PIN_ID = 43;

        [NativeTypeName("#define KP_PIN_INFO 44")]
        public const int KP_PIN_INFO = 44;

        [NativeTypeName("#define PKCS5_PADDING 1")]
        public const int PKCS5_PADDING = 1;

        [NativeTypeName("#define RANDOM_PADDING 2")]
        public const int RANDOM_PADDING = 2;

        [NativeTypeName("#define ZERO_PADDING 3")]
        public const int ZERO_PADDING = 3;

        [NativeTypeName("#define CRYPT_MODE_CBC 1")]
        public const int CRYPT_MODE_CBC = 1;

        [NativeTypeName("#define CRYPT_MODE_ECB 2")]
        public const int CRYPT_MODE_ECB = 2;

        [NativeTypeName("#define CRYPT_MODE_OFB 3")]
        public const int CRYPT_MODE_OFB = 3;

        [NativeTypeName("#define CRYPT_MODE_CFB 4")]
        public const int CRYPT_MODE_CFB = 4;

        [NativeTypeName("#define CRYPT_MODE_CTS 5")]
        public const int CRYPT_MODE_CTS = 5;

        [NativeTypeName("#define CRYPT_ENCRYPT 0x0001")]
        public const int CRYPT_ENCRYPT = 0x0001;

        [NativeTypeName("#define CRYPT_DECRYPT 0x0002")]
        public const int CRYPT_DECRYPT = 0x0002;

        [NativeTypeName("#define CRYPT_EXPORT 0x0004")]
        public const int CRYPT_EXPORT = 0x0004;

        [NativeTypeName("#define CRYPT_READ 0x0008")]
        public const int CRYPT_READ = 0x0008;

        [NativeTypeName("#define CRYPT_WRITE 0x0010")]
        public const int CRYPT_WRITE = 0x0010;

        [NativeTypeName("#define CRYPT_MAC 0x0020")]
        public const int CRYPT_MAC = 0x0020;

        [NativeTypeName("#define CRYPT_EXPORT_KEY 0x0040")]
        public const int CRYPT_EXPORT_KEY = 0x0040;

        [NativeTypeName("#define CRYPT_IMPORT_KEY 0x0080")]
        public const int CRYPT_IMPORT_KEY = 0x0080;

        [NativeTypeName("#define CRYPT_ARCHIVE 0x0100")]
        public const int CRYPT_ARCHIVE = 0x0100;

        [NativeTypeName("#define HP_ALGID 0x0001")]
        public const int HP_ALGID = 0x0001;

        [NativeTypeName("#define HP_HASHVAL 0x0002")]
        public const int HP_HASHVAL = 0x0002;

        [NativeTypeName("#define HP_HASHSIZE 0x0004")]
        public const int HP_HASHSIZE = 0x0004;

        [NativeTypeName("#define HP_HMAC_INFO 0x0005")]
        public const int HP_HMAC_INFO = 0x0005;

        [NativeTypeName("#define HP_TLS1PRF_LABEL 0x0006")]
        public const int HP_TLS1PRF_LABEL = 0x0006;

        [NativeTypeName("#define HP_TLS1PRF_SEED 0x0007")]
        public const int HP_TLS1PRF_SEED = 0x0007;

        [NativeTypeName("#define CRYPT_FAILED FALSE")]
        public const int CRYPT_FAILED = 0;

        [NativeTypeName("#define CRYPT_SUCCEED TRUE")]
        public const int CRYPT_SUCCEED = 1;

        [NativeTypeName("#define PP_ENUMALGS 1")]
        public const int PP_ENUMALGS = 1;

        [NativeTypeName("#define PP_ENUMCONTAINERS 2")]
        public const int PP_ENUMCONTAINERS = 2;

        [NativeTypeName("#define PP_IMPTYPE 3")]
        public const int PP_IMPTYPE = 3;

        [NativeTypeName("#define PP_NAME 4")]
        public const int PP_NAME = 4;

        [NativeTypeName("#define PP_VERSION 5")]
        public const int PP_VERSION = 5;

        [NativeTypeName("#define PP_CONTAINER 6")]
        public const int PP_CONTAINER = 6;

        [NativeTypeName("#define PP_CHANGE_PASSWORD 7")]
        public const int PP_CHANGE_PASSWORD = 7;

        [NativeTypeName("#define PP_KEYSET_SEC_DESCR 8")]
        public const int PP_KEYSET_SEC_DESCR = 8;

        [NativeTypeName("#define PP_CERTCHAIN 9")]
        public const int PP_CERTCHAIN = 9;

        [NativeTypeName("#define PP_KEY_TYPE_SUBTYPE 10")]
        public const int PP_KEY_TYPE_SUBTYPE = 10;

        [NativeTypeName("#define PP_PROVTYPE 16")]
        public const int PP_PROVTYPE = 16;

        [NativeTypeName("#define PP_KEYSTORAGE 17")]
        public const int PP_KEYSTORAGE = 17;

        [NativeTypeName("#define PP_APPLI_CERT 18")]
        public const int PP_APPLI_CERT = 18;

        [NativeTypeName("#define PP_SYM_KEYSIZE 19")]
        public const int PP_SYM_KEYSIZE = 19;

        [NativeTypeName("#define PP_SESSION_KEYSIZE 20")]
        public const int PP_SESSION_KEYSIZE = 20;

        [NativeTypeName("#define PP_UI_PROMPT 21")]
        public const int PP_UI_PROMPT = 21;

        [NativeTypeName("#define PP_ENUMALGS_EX 22")]
        public const int PP_ENUMALGS_EX = 22;

        [NativeTypeName("#define PP_ENUMMANDROOTS 25")]
        public const int PP_ENUMMANDROOTS = 25;

        [NativeTypeName("#define PP_ENUMELECTROOTS 26")]
        public const int PP_ENUMELECTROOTS = 26;

        [NativeTypeName("#define PP_KEYSET_TYPE 27")]
        public const int PP_KEYSET_TYPE = 27;

        [NativeTypeName("#define PP_ADMIN_PIN 31")]
        public const int PP_ADMIN_PIN = 31;

        [NativeTypeName("#define PP_KEYEXCHANGE_PIN 32")]
        public const int PP_KEYEXCHANGE_PIN = 32;

        [NativeTypeName("#define PP_SIGNATURE_PIN 33")]
        public const int PP_SIGNATURE_PIN = 33;

        [NativeTypeName("#define PP_SIG_KEYSIZE_INC 34")]
        public const int PP_SIG_KEYSIZE_INC = 34;

        [NativeTypeName("#define PP_KEYX_KEYSIZE_INC 35")]
        public const int PP_KEYX_KEYSIZE_INC = 35;

        [NativeTypeName("#define PP_UNIQUE_CONTAINER 36")]
        public const int PP_UNIQUE_CONTAINER = 36;

        [NativeTypeName("#define PP_SGC_INFO 37")]
        public const int PP_SGC_INFO = 37;

        [NativeTypeName("#define PP_USE_HARDWARE_RNG 38")]
        public const int PP_USE_HARDWARE_RNG = 38;

        [NativeTypeName("#define PP_KEYSPEC 39")]
        public const int PP_KEYSPEC = 39;

        [NativeTypeName("#define PP_ENUMEX_SIGNING_PROT 40")]
        public const int PP_ENUMEX_SIGNING_PROT = 40;

        [NativeTypeName("#define PP_CRYPT_COUNT_KEY_USE 41")]
        public const int PP_CRYPT_COUNT_KEY_USE = 41;

        [NativeTypeName("#define PP_USER_CERTSTORE 42")]
        public const int PP_USER_CERTSTORE = 42;

        [NativeTypeName("#define PP_SMARTCARD_READER 43")]
        public const int PP_SMARTCARD_READER = 43;

        [NativeTypeName("#define PP_SMARTCARD_GUID 45")]
        public const int PP_SMARTCARD_GUID = 45;

        [NativeTypeName("#define PP_ROOT_CERTSTORE 46")]
        public const int PP_ROOT_CERTSTORE = 46;

        [NativeTypeName("#define PP_SMARTCARD_READER_ICON 47")]
        public const int PP_SMARTCARD_READER_ICON = 47;

        [NativeTypeName("#define CRYPT_FIRST 1")]
        public const int CRYPT_FIRST = 1;

        [NativeTypeName("#define CRYPT_NEXT 2")]
        public const int CRYPT_NEXT = 2;

        [NativeTypeName("#define CRYPT_SGC_ENUM 4")]
        public const int CRYPT_SGC_ENUM = 4;

        [NativeTypeName("#define CRYPT_IMPL_HARDWARE 1")]
        public const int CRYPT_IMPL_HARDWARE = 1;

        [NativeTypeName("#define CRYPT_IMPL_SOFTWARE 2")]
        public const int CRYPT_IMPL_SOFTWARE = 2;

        [NativeTypeName("#define CRYPT_IMPL_MIXED 3")]
        public const int CRYPT_IMPL_MIXED = 3;

        [NativeTypeName("#define CRYPT_IMPL_UNKNOWN 4")]
        public const int CRYPT_IMPL_UNKNOWN = 4;

        [NativeTypeName("#define CRYPT_IMPL_REMOVABLE 8")]
        public const int CRYPT_IMPL_REMOVABLE = 8;

        [NativeTypeName("#define CRYPT_SEC_DESCR 0x00000001")]
        public const int CRYPT_SEC_DESCR = 0x00000001;

        [NativeTypeName("#define CRYPT_PSTORE 0x00000002")]
        public const int CRYPT_PSTORE = 0x00000002;

        [NativeTypeName("#define CRYPT_UI_PROMPT 0x00000004")]
        public const int CRYPT_UI_PROMPT = 0x00000004;

        [NativeTypeName("#define CRYPT_FLAG_PCT1 0x0001")]
        public const int CRYPT_FLAG_PCT1 = 0x0001;

        [NativeTypeName("#define CRYPT_FLAG_SSL2 0x0002")]
        public const int CRYPT_FLAG_SSL2 = 0x0002;

        [NativeTypeName("#define CRYPT_FLAG_SSL3 0x0004")]
        public const int CRYPT_FLAG_SSL3 = 0x0004;

        [NativeTypeName("#define CRYPT_FLAG_TLS1 0x0008")]
        public const int CRYPT_FLAG_TLS1 = 0x0008;

        [NativeTypeName("#define CRYPT_FLAG_IPSEC 0x0010")]
        public const int CRYPT_FLAG_IPSEC = 0x0010;

        [NativeTypeName("#define CRYPT_FLAG_SIGNING 0x0020")]
        public const int CRYPT_FLAG_SIGNING = 0x0020;

        [NativeTypeName("#define CRYPT_SGC 0x0001")]
        public const int CRYPT_SGC = 0x0001;

        [NativeTypeName("#define CRYPT_FASTSGC 0x0002")]
        public const int CRYPT_FASTSGC = 0x0002;

        [NativeTypeName("#define PP_CLIENT_HWND 1")]
        public const int PP_CLIENT_HWND = 1;

        [NativeTypeName("#define PP_CONTEXT_INFO 11")]
        public const int PP_CONTEXT_INFO = 11;

        [NativeTypeName("#define PP_KEYEXCHANGE_KEYSIZE 12")]
        public const int PP_KEYEXCHANGE_KEYSIZE = 12;

        [NativeTypeName("#define PP_SIGNATURE_KEYSIZE 13")]
        public const int PP_SIGNATURE_KEYSIZE = 13;

        [NativeTypeName("#define PP_KEYEXCHANGE_ALG 14")]
        public const int PP_KEYEXCHANGE_ALG = 14;

        [NativeTypeName("#define PP_SIGNATURE_ALG 15")]
        public const int PP_SIGNATURE_ALG = 15;

        [NativeTypeName("#define PP_DELETEKEY 24")]
        public const int PP_DELETEKEY = 24;

        [NativeTypeName("#define PP_PIN_PROMPT_STRING 44")]
        public const int PP_PIN_PROMPT_STRING = 44;

        [NativeTypeName("#define PP_SECURE_KEYEXCHANGE_PIN 47")]
        public const int PP_SECURE_KEYEXCHANGE_PIN = 47;

        [NativeTypeName("#define PP_SECURE_SIGNATURE_PIN 48")]
        public const int PP_SECURE_SIGNATURE_PIN = 48;

        [NativeTypeName("#define PP_DISMISS_PIN_UI_SEC 49")]
        public const int PP_DISMISS_PIN_UI_SEC = 49;

        [NativeTypeName("#define PROV_RSA_FULL 1")]
        public const int PROV_RSA_FULL = 1;

        [NativeTypeName("#define PROV_RSA_SIG 2")]
        public const int PROV_RSA_SIG = 2;

        [NativeTypeName("#define PROV_DSS 3")]
        public const int PROV_DSS = 3;

        [NativeTypeName("#define PROV_FORTEZZA 4")]
        public const int PROV_FORTEZZA = 4;

        [NativeTypeName("#define PROV_MS_EXCHANGE 5")]
        public const int PROV_MS_EXCHANGE = 5;

        [NativeTypeName("#define PROV_SSL 6")]
        public const int PROV_SSL = 6;

        [NativeTypeName("#define PROV_RSA_SCHANNEL 12")]
        public const int PROV_RSA_SCHANNEL = 12;

        [NativeTypeName("#define PROV_DSS_DH 13")]
        public const int PROV_DSS_DH = 13;

        [NativeTypeName("#define PROV_EC_ECDSA_SIG 14")]
        public const int PROV_EC_ECDSA_SIG = 14;

        [NativeTypeName("#define PROV_EC_ECNRA_SIG 15")]
        public const int PROV_EC_ECNRA_SIG = 15;

        [NativeTypeName("#define PROV_EC_ECDSA_FULL 16")]
        public const int PROV_EC_ECDSA_FULL = 16;

        [NativeTypeName("#define PROV_EC_ECNRA_FULL 17")]
        public const int PROV_EC_ECNRA_FULL = 17;

        [NativeTypeName("#define PROV_DH_SCHANNEL 18")]
        public const int PROV_DH_SCHANNEL = 18;

        [NativeTypeName("#define PROV_SPYRUS_LYNKS 20")]
        public const int PROV_SPYRUS_LYNKS = 20;

        [NativeTypeName("#define PROV_RNG 21")]
        public const int PROV_RNG = 21;

        [NativeTypeName("#define PROV_INTEL_SEC 22")]
        public const int PROV_INTEL_SEC = 22;

        [NativeTypeName("#define PROV_REPLACE_OWF 23")]
        public const int PROV_REPLACE_OWF = 23;

        [NativeTypeName("#define PROV_RSA_AES 24")]
        public const int PROV_RSA_AES = 24;

        [NativeTypeName("#define MS_DEF_PROV_A \"Microsoft Base Cryptographic Provider v1.0\"")]
        public static ReadOnlySpan<byte> MS_DEF_PROV_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x42, 0x61, 0x73, 0x65, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x20, 0x76, 0x31, 0x2E, 0x30, 0x00 };

        [NativeTypeName("#define MS_DEF_PROV_W L\"Microsoft Base Cryptographic Provider v1.0\"")]
        public const string MS_DEF_PROV_W = "Microsoft Base Cryptographic Provider v1.0";

        [NativeTypeName("#define MS_DEF_PROV MS_DEF_PROV_W")]
        public const string MS_DEF_PROV = "Microsoft Base Cryptographic Provider v1.0";

        [NativeTypeName("#define MS_ENHANCED_PROV_A \"Microsoft Enhanced Cryptographic Provider v1.0\"")]
        public static ReadOnlySpan<byte> MS_ENHANCED_PROV_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x45, 0x6E, 0x68, 0x61, 0x6E, 0x63, 0x65, 0x64, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x20, 0x76, 0x31, 0x2E, 0x30, 0x00 };

        [NativeTypeName("#define MS_ENHANCED_PROV_W L\"Microsoft Enhanced Cryptographic Provider v1.0\"")]
        public const string MS_ENHANCED_PROV_W = "Microsoft Enhanced Cryptographic Provider v1.0";

        [NativeTypeName("#define MS_ENHANCED_PROV MS_ENHANCED_PROV_W")]
        public const string MS_ENHANCED_PROV = "Microsoft Enhanced Cryptographic Provider v1.0";

        [NativeTypeName("#define MS_STRONG_PROV_A \"Microsoft Strong Cryptographic Provider\"")]
        public static ReadOnlySpan<byte> MS_STRONG_PROV_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x53, 0x74, 0x72, 0x6F, 0x6E, 0x67, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define MS_STRONG_PROV_W L\"Microsoft Strong Cryptographic Provider\"")]
        public const string MS_STRONG_PROV_W = "Microsoft Strong Cryptographic Provider";

        [NativeTypeName("#define MS_STRONG_PROV MS_STRONG_PROV_W")]
        public const string MS_STRONG_PROV = "Microsoft Strong Cryptographic Provider";

        [NativeTypeName("#define MS_DEF_RSA_SIG_PROV_A \"Microsoft RSA Signature Cryptographic Provider\"")]
        public static ReadOnlySpan<byte> MS_DEF_RSA_SIG_PROV_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x52, 0x53, 0x41, 0x20, 0x53, 0x69, 0x67, 0x6E, 0x61, 0x74, 0x75, 0x72, 0x65, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define MS_DEF_RSA_SIG_PROV_W L\"Microsoft RSA Signature Cryptographic Provider\"")]
        public const string MS_DEF_RSA_SIG_PROV_W = "Microsoft RSA Signature Cryptographic Provider";

        [NativeTypeName("#define MS_DEF_RSA_SIG_PROV MS_DEF_RSA_SIG_PROV_W")]
        public const string MS_DEF_RSA_SIG_PROV = "Microsoft RSA Signature Cryptographic Provider";

        [NativeTypeName("#define MS_DEF_RSA_SCHANNEL_PROV_A \"Microsoft RSA SChannel Cryptographic Provider\"")]
        public static ReadOnlySpan<byte> MS_DEF_RSA_SCHANNEL_PROV_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x52, 0x53, 0x41, 0x20, 0x53, 0x43, 0x68, 0x61, 0x6E, 0x6E, 0x65, 0x6C, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define MS_DEF_RSA_SCHANNEL_PROV_W L\"Microsoft RSA SChannel Cryptographic Provider\"")]
        public const string MS_DEF_RSA_SCHANNEL_PROV_W = "Microsoft RSA SChannel Cryptographic Provider";

        [NativeTypeName("#define MS_DEF_RSA_SCHANNEL_PROV MS_DEF_RSA_SCHANNEL_PROV_W")]
        public const string MS_DEF_RSA_SCHANNEL_PROV = "Microsoft RSA SChannel Cryptographic Provider";

        [NativeTypeName("#define MS_DEF_DSS_PROV_A \"Microsoft Base DSS Cryptographic Provider\"")]
        public static ReadOnlySpan<byte> MS_DEF_DSS_PROV_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x42, 0x61, 0x73, 0x65, 0x20, 0x44, 0x53, 0x53, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define MS_DEF_DSS_PROV_W L\"Microsoft Base DSS Cryptographic Provider\"")]
        public const string MS_DEF_DSS_PROV_W = "Microsoft Base DSS Cryptographic Provider";

        [NativeTypeName("#define MS_DEF_DSS_PROV MS_DEF_DSS_PROV_W")]
        public const string MS_DEF_DSS_PROV = "Microsoft Base DSS Cryptographic Provider";

        [NativeTypeName("#define MS_DEF_DSS_DH_PROV_A \"Microsoft Base DSS and Diffie-Hellman Cryptographic Provider\"")]
        public static ReadOnlySpan<byte> MS_DEF_DSS_DH_PROV_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x42, 0x61, 0x73, 0x65, 0x20, 0x44, 0x53, 0x53, 0x20, 0x61, 0x6E, 0x64, 0x20, 0x44, 0x69, 0x66, 0x66, 0x69, 0x65, 0x2D, 0x48, 0x65, 0x6C, 0x6C, 0x6D, 0x61, 0x6E, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define MS_DEF_DSS_DH_PROV_W L\"Microsoft Base DSS and Diffie-Hellman Cryptographic Provider\"")]
        public const string MS_DEF_DSS_DH_PROV_W = "Microsoft Base DSS and Diffie-Hellman Cryptographic Provider";

        [NativeTypeName("#define MS_DEF_DSS_DH_PROV MS_DEF_DSS_DH_PROV_W")]
        public const string MS_DEF_DSS_DH_PROV = "Microsoft Base DSS and Diffie-Hellman Cryptographic Provider";

        [NativeTypeName("#define MS_ENH_DSS_DH_PROV_A \"Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider\"")]
        public static ReadOnlySpan<byte> MS_ENH_DSS_DH_PROV_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x45, 0x6E, 0x68, 0x61, 0x6E, 0x63, 0x65, 0x64, 0x20, 0x44, 0x53, 0x53, 0x20, 0x61, 0x6E, 0x64, 0x20, 0x44, 0x69, 0x66, 0x66, 0x69, 0x65, 0x2D, 0x48, 0x65, 0x6C, 0x6C, 0x6D, 0x61, 0x6E, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define MS_ENH_DSS_DH_PROV_W L\"Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider\"")]
        public const string MS_ENH_DSS_DH_PROV_W = "Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider";

        [NativeTypeName("#define MS_ENH_DSS_DH_PROV MS_ENH_DSS_DH_PROV_W")]
        public const string MS_ENH_DSS_DH_PROV = "Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider";

        [NativeTypeName("#define MS_DEF_DH_SCHANNEL_PROV_A \"Microsoft DH SChannel Cryptographic Provider\"")]
        public static ReadOnlySpan<byte> MS_DEF_DH_SCHANNEL_PROV_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x44, 0x48, 0x20, 0x53, 0x43, 0x68, 0x61, 0x6E, 0x6E, 0x65, 0x6C, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define MS_DEF_DH_SCHANNEL_PROV_W L\"Microsoft DH SChannel Cryptographic Provider\"")]
        public const string MS_DEF_DH_SCHANNEL_PROV_W = "Microsoft DH SChannel Cryptographic Provider";

        [NativeTypeName("#define MS_DEF_DH_SCHANNEL_PROV MS_DEF_DH_SCHANNEL_PROV_W")]
        public const string MS_DEF_DH_SCHANNEL_PROV = "Microsoft DH SChannel Cryptographic Provider";

        [NativeTypeName("#define MS_SCARD_PROV_A \"Microsoft Base Smart Card Crypto Provider\"")]
        public static ReadOnlySpan<byte> MS_SCARD_PROV_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x42, 0x61, 0x73, 0x65, 0x20, 0x53, 0x6D, 0x61, 0x72, 0x74, 0x20, 0x43, 0x61, 0x72, 0x64, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define MS_SCARD_PROV_W L\"Microsoft Base Smart Card Crypto Provider\"")]
        public const string MS_SCARD_PROV_W = "Microsoft Base Smart Card Crypto Provider";

        [NativeTypeName("#define MS_SCARD_PROV MS_SCARD_PROV_W")]
        public const string MS_SCARD_PROV = "Microsoft Base Smart Card Crypto Provider";

        [NativeTypeName("#define MS_ENH_RSA_AES_PROV_A \"Microsoft Enhanced RSA and AES Cryptographic Provider\"")]
        public static ReadOnlySpan<byte> MS_ENH_RSA_AES_PROV_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x45, 0x6E, 0x68, 0x61, 0x6E, 0x63, 0x65, 0x64, 0x20, 0x52, 0x53, 0x41, 0x20, 0x61, 0x6E, 0x64, 0x20, 0x41, 0x45, 0x53, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define MS_ENH_RSA_AES_PROV_W L\"Microsoft Enhanced RSA and AES Cryptographic Provider\"")]
        public const string MS_ENH_RSA_AES_PROV_W = "Microsoft Enhanced RSA and AES Cryptographic Provider";

        [NativeTypeName("#define MS_ENH_RSA_AES_PROV_XP_A \"Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)\"")]
        public static ReadOnlySpan<byte> MS_ENH_RSA_AES_PROV_XP_A => new byte[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x45, 0x6E, 0x68, 0x61, 0x6E, 0x63, 0x65, 0x64, 0x20, 0x52, 0x53, 0x41, 0x20, 0x61, 0x6E, 0x64, 0x20, 0x41, 0x45, 0x53, 0x20, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x20, 0x50, 0x72, 0x6F, 0x76, 0x69, 0x64, 0x65, 0x72, 0x20, 0x28, 0x50, 0x72, 0x6F, 0x74, 0x6F, 0x74, 0x79, 0x70, 0x65, 0x29, 0x00 };

        [NativeTypeName("#define MS_ENH_RSA_AES_PROV_XP_W L\"Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)\"")]
        public const string MS_ENH_RSA_AES_PROV_XP_W = "Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)";

        [NativeTypeName("#define MS_ENH_RSA_AES_PROV_XP MS_ENH_RSA_AES_PROV_XP_W")]
        public const string MS_ENH_RSA_AES_PROV_XP = "Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)";

        [NativeTypeName("#define MS_ENH_RSA_AES_PROV MS_ENH_RSA_AES_PROV_W")]
        public const string MS_ENH_RSA_AES_PROV = "Microsoft Enhanced RSA and AES Cryptographic Provider";

        [NativeTypeName("#define MAXUIDLEN 64")]
        public const int MAXUIDLEN = 64;

        [NativeTypeName("#define EXPO_OFFLOAD_REG_VALUE \"ExpoOffload\"")]
        public static ReadOnlySpan<byte> EXPO_OFFLOAD_REG_VALUE => new byte[] { 0x45, 0x78, 0x70, 0x6F, 0x4F, 0x66, 0x66, 0x6C, 0x6F, 0x61, 0x64, 0x00 };

        [NativeTypeName("#define EXPO_OFFLOAD_FUNC_NAME \"OffloadModExpo\"")]
        public static ReadOnlySpan<byte> EXPO_OFFLOAD_FUNC_NAME => new byte[] { 0x4F, 0x66, 0x66, 0x6C, 0x6F, 0x61, 0x64, 0x4D, 0x6F, 0x64, 0x45, 0x78, 0x70, 0x6F, 0x00 };

        [NativeTypeName("#define szKEY_CRYPTOAPI_PRIVATE_KEY_OPTIONS \"Software\\\\Policies\\\\Microsoft\\\\Cryptography\"")]
        public static ReadOnlySpan<byte> szKEY_CRYPTOAPI_PRIVATE_KEY_OPTIONS => new byte[] { 0x53, 0x6F, 0x66, 0x74, 0x77, 0x61, 0x72, 0x65, 0x5C, 0x50, 0x6F, 0x6C, 0x69, 0x63, 0x69, 0x65, 0x73, 0x5C, 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x5C, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x79, 0x00 };

        [NativeTypeName("#define szKEY_CACHE_ENABLED \"CachePrivateKeys\"")]
        public static ReadOnlySpan<byte> szKEY_CACHE_ENABLED => new byte[] { 0x43, 0x61, 0x63, 0x68, 0x65, 0x50, 0x72, 0x69, 0x76, 0x61, 0x74, 0x65, 0x4B, 0x65, 0x79, 0x73, 0x00 };

        [NativeTypeName("#define szKEY_CACHE_SECONDS \"PrivateKeyLifetimeSeconds\"")]
        public static ReadOnlySpan<byte> szKEY_CACHE_SECONDS => new byte[] { 0x50, 0x72, 0x69, 0x76, 0x61, 0x74, 0x65, 0x4B, 0x65, 0x79, 0x4C, 0x69, 0x66, 0x65, 0x74, 0x69, 0x6D, 0x65, 0x53, 0x65, 0x63, 0x6F, 0x6E, 0x64, 0x73, 0x00 };

        [NativeTypeName("#define szPRIV_KEY_CACHE_MAX_ITEMS \"PrivKeyCacheMaxItems\"")]
        public static ReadOnlySpan<byte> szPRIV_KEY_CACHE_MAX_ITEMS => new byte[] { 0x50, 0x72, 0x69, 0x76, 0x4B, 0x65, 0x79, 0x43, 0x61, 0x63, 0x68, 0x65, 0x4D, 0x61, 0x78, 0x49, 0x74, 0x65, 0x6D, 0x73, 0x00 };

        [NativeTypeName("#define cPRIV_KEY_CACHE_MAX_ITEMS_DEFAULT 20")]
        public const int cPRIV_KEY_CACHE_MAX_ITEMS_DEFAULT = 20;

        [NativeTypeName("#define szPRIV_KEY_CACHE_PURGE_INTERVAL_SECONDS \"PrivKeyCachePurgeIntervalSeconds\"")]
        public static ReadOnlySpan<byte> szPRIV_KEY_CACHE_PURGE_INTERVAL_SECONDS => new byte[] { 0x50, 0x72, 0x69, 0x76, 0x4B, 0x65, 0x79, 0x43, 0x61, 0x63, 0x68, 0x65, 0x50, 0x75, 0x72, 0x67, 0x65, 0x49, 0x6E, 0x74, 0x65, 0x72, 0x76, 0x61, 0x6C, 0x53, 0x65, 0x63, 0x6F, 0x6E, 0x64, 0x73, 0x00 };

        [NativeTypeName("#define cPRIV_KEY_CACHE_PURGE_INTERVAL_SECONDS_DEFAULT 86400")]
        public const int cPRIV_KEY_CACHE_PURGE_INTERVAL_SECONDS_DEFAULT = 86400;

        [NativeTypeName("#define CUR_BLOB_VERSION 2")]
        public const int CUR_BLOB_VERSION = 2;

        [NativeTypeName("#define SCHANNEL_MAC_KEY 0x00000000")]
        public const int SCHANNEL_MAC_KEY = 0x00000000;

        [NativeTypeName("#define SCHANNEL_ENC_KEY 0x00000001")]
        public const int SCHANNEL_ENC_KEY = 0x00000001;

        [NativeTypeName("#define INTERNATIONAL_USAGE 0x00000001")]
        public const int INTERNATIONAL_USAGE = 0x00000001;

        [NativeTypeName("#define CryptAcquireContext CryptAcquireContextW")]
        public static delegate*<IntPtr*, ushort*, ushort*, uint, uint, int> CryptAcquireContext => &CryptAcquireContextW;

        [NativeTypeName("#define CryptSignHash CryptSignHashW")]
        public static delegate*<IntPtr, uint, ushort*, uint, byte*, uint*, int> CryptSignHash => &CryptSignHashW;

        [NativeTypeName("#define CryptVerifySignature CryptVerifySignatureW")]
        public static delegate*<IntPtr, byte*, uint, IntPtr, ushort*, uint, int> CryptVerifySignature => &CryptVerifySignatureW;

        [NativeTypeName("#define CryptSetProvider CryptSetProviderW")]
        public static delegate*<ushort*, uint, int> CryptSetProvider => &CryptSetProviderW;

        [NativeTypeName("#define CryptSetProviderEx CryptSetProviderExW")]
        public static delegate*<ushort*, uint, uint*, uint, int> CryptSetProviderEx => &CryptSetProviderExW;

        [NativeTypeName("#define CryptGetDefaultProvider CryptGetDefaultProviderW")]
        public static delegate*<uint, uint*, uint, ushort*, uint*, int> CryptGetDefaultProvider => &CryptGetDefaultProviderW;

        [NativeTypeName("#define CryptEnumProviderTypes CryptEnumProviderTypesW")]
        public static delegate*<uint, uint*, uint, uint*, ushort*, uint*, int> CryptEnumProviderTypes => &CryptEnumProviderTypesW;

        [NativeTypeName("#define CryptEnumProviders CryptEnumProvidersW")]
        public static delegate*<uint, uint*, uint, uint*, ushort*, uint*, int> CryptEnumProviders => &CryptEnumProvidersW;

        [NativeTypeName("#define szOID_RSA \"1.2.840.113549\"")]
        public static ReadOnlySpan<byte> szOID_RSA => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x00 };

        [NativeTypeName("#define szOID_PKCS \"1.2.840.113549.1\"")]
        public static ReadOnlySpan<byte> szOID_PKCS => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_RSA_HASH \"1.2.840.113549.2\"")]
        public static ReadOnlySpan<byte> szOID_RSA_HASH => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_RSA_ENCRYPT \"1.2.840.113549.3\"")]
        public static ReadOnlySpan<byte> szOID_RSA_ENCRYPT => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_PKCS_1 \"1.2.840.113549.1.1\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_1 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_PKCS_2 \"1.2.840.113549.1.2\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_2 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_PKCS_3 \"1.2.840.113549.1.3\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_3 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_PKCS_4 \"1.2.840.113549.1.4\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_4 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_PKCS_5 \"1.2.840.113549.1.5\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_5 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_PKCS_6 \"1.2.840.113549.1.6\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_6 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_PKCS_7 \"1.2.840.113549.1.7\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_7 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_PKCS_8 \"1.2.840.113549.1.8\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_8 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x38, 0x00 };

        [NativeTypeName("#define szOID_PKCS_9 \"1.2.840.113549.1.9\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_9 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_PKCS_10 \"1.2.840.113549.1.10\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_10 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x00 };

        [NativeTypeName("#define szOID_PKCS_12 \"1.2.840.113549.1.12\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_12 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        [NativeTypeName("#define szOID_RSA_RSA \"1.2.840.113549.1.1.1\"")]
        public static ReadOnlySpan<byte> szOID_RSA_RSA => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_RSA_MD2RSA \"1.2.840.113549.1.1.2\"")]
        public static ReadOnlySpan<byte> szOID_RSA_MD2RSA => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_RSA_MD4RSA \"1.2.840.113549.1.1.3\"")]
        public static ReadOnlySpan<byte> szOID_RSA_MD4RSA => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_RSA_MD5RSA \"1.2.840.113549.1.1.4\"")]
        public static ReadOnlySpan<byte> szOID_RSA_MD5RSA => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_RSA_SHA1RSA \"1.2.840.113549.1.1.5\"")]
        public static ReadOnlySpan<byte> szOID_RSA_SHA1RSA => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_RSA_SETOAEP_RSA \"1.2.840.113549.1.1.6\"")]
        public static ReadOnlySpan<byte> szOID_RSA_SETOAEP_RSA => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_RSAES_OAEP \"1.2.840.113549.1.1.7\"")]
        public static ReadOnlySpan<byte> szOID_RSAES_OAEP => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_RSA_MGF1 \"1.2.840.113549.1.1.8\"")]
        public static ReadOnlySpan<byte> szOID_RSA_MGF1 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x38, 0x00 };

        [NativeTypeName("#define szOID_RSA_PSPECIFIED \"1.2.840.113549.1.1.9\"")]
        public static ReadOnlySpan<byte> szOID_RSA_PSPECIFIED => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_RSA_SSA_PSS \"1.2.840.113549.1.1.10\"")]
        public static ReadOnlySpan<byte> szOID_RSA_SSA_PSS => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x00 };

        [NativeTypeName("#define szOID_RSA_SHA256RSA \"1.2.840.113549.1.1.11\"")]
        public static ReadOnlySpan<byte> szOID_RSA_SHA256RSA => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x00 };

        [NativeTypeName("#define szOID_RSA_SHA384RSA \"1.2.840.113549.1.1.12\"")]
        public static ReadOnlySpan<byte> szOID_RSA_SHA384RSA => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        [NativeTypeName("#define szOID_RSA_SHA512RSA \"1.2.840.113549.1.1.13\"")]
        public static ReadOnlySpan<byte> szOID_RSA_SHA512RSA => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x33, 0x00 };

        [NativeTypeName("#define szOID_RSA_DH \"1.2.840.113549.1.3.1\"")]
        public static ReadOnlySpan<byte> szOID_RSA_DH => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_RSA_data \"1.2.840.113549.1.7.1\"")]
        public static ReadOnlySpan<byte> szOID_RSA_data => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_RSA_signedData \"1.2.840.113549.1.7.2\"")]
        public static ReadOnlySpan<byte> szOID_RSA_signedData => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_RSA_envelopedData \"1.2.840.113549.1.7.3\"")]
        public static ReadOnlySpan<byte> szOID_RSA_envelopedData => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_RSA_signEnvData \"1.2.840.113549.1.7.4\"")]
        public static ReadOnlySpan<byte> szOID_RSA_signEnvData => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_RSA_digestedData \"1.2.840.113549.1.7.5\"")]
        public static ReadOnlySpan<byte> szOID_RSA_digestedData => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_RSA_hashedData \"1.2.840.113549.1.7.5\"")]
        public static ReadOnlySpan<byte> szOID_RSA_hashedData => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_RSA_encryptedData \"1.2.840.113549.1.7.6\"")]
        public static ReadOnlySpan<byte> szOID_RSA_encryptedData => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_RSA_emailAddr \"1.2.840.113549.1.9.1\"")]
        public static ReadOnlySpan<byte> szOID_RSA_emailAddr => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_RSA_unstructName \"1.2.840.113549.1.9.2\"")]
        public static ReadOnlySpan<byte> szOID_RSA_unstructName => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_RSA_contentType \"1.2.840.113549.1.9.3\"")]
        public static ReadOnlySpan<byte> szOID_RSA_contentType => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_RSA_messageDigest \"1.2.840.113549.1.9.4\"")]
        public static ReadOnlySpan<byte> szOID_RSA_messageDigest => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_RSA_signingTime \"1.2.840.113549.1.9.5\"")]
        public static ReadOnlySpan<byte> szOID_RSA_signingTime => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_RSA_counterSign \"1.2.840.113549.1.9.6\"")]
        public static ReadOnlySpan<byte> szOID_RSA_counterSign => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_RSA_challengePwd \"1.2.840.113549.1.9.7\"")]
        public static ReadOnlySpan<byte> szOID_RSA_challengePwd => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_RSA_unstructAddr \"1.2.840.113549.1.9.8\"")]
        public static ReadOnlySpan<byte> szOID_RSA_unstructAddr => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x38, 0x00 };

        [NativeTypeName("#define szOID_RSA_extCertAttrs \"1.2.840.113549.1.9.9\"")]
        public static ReadOnlySpan<byte> szOID_RSA_extCertAttrs => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_RSA_certExtensions \"1.2.840.113549.1.9.14\"")]
        public static ReadOnlySpan<byte> szOID_RSA_certExtensions => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x34, 0x00 };

        [NativeTypeName("#define szOID_RSA_SMIMECapabilities \"1.2.840.113549.1.9.15\"")]
        public static ReadOnlySpan<byte> szOID_RSA_SMIMECapabilities => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x35, 0x00 };

        [NativeTypeName("#define szOID_RSA_preferSignedData \"1.2.840.113549.1.9.15.1\"")]
        public static ReadOnlySpan<byte> szOID_RSA_preferSignedData => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x35, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_TIMESTAMP_TOKEN \"1.2.840.113549.1.9.16.1.4\"")]
        public static ReadOnlySpan<byte> szOID_TIMESTAMP_TOKEN => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_RFC3161_counterSign \"1.3.6.1.4.1.311.3.3.1\"")]
        public static ReadOnlySpan<byte> szOID_RFC3161_counterSign => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_RSA_SMIMEalg \"1.2.840.113549.1.9.16.3\"")]
        public static ReadOnlySpan<byte> szOID_RSA_SMIMEalg => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x36, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_RSA_SMIMEalgESDH \"1.2.840.113549.1.9.16.3.5\"")]
        public static ReadOnlySpan<byte> szOID_RSA_SMIMEalgESDH => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x36, 0x2E, 0x33, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_RSA_SMIMEalgCMS3DESwrap \"1.2.840.113549.1.9.16.3.6\"")]
        public static ReadOnlySpan<byte> szOID_RSA_SMIMEalgCMS3DESwrap => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x36, 0x2E, 0x33, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_RSA_SMIMEalgCMSRC2wrap \"1.2.840.113549.1.9.16.3.7\"")]
        public static ReadOnlySpan<byte> szOID_RSA_SMIMEalgCMSRC2wrap => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x31, 0x36, 0x2E, 0x33, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_RSA_MD2 \"1.2.840.113549.2.2\"")]
        public static ReadOnlySpan<byte> szOID_RSA_MD2 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_RSA_MD4 \"1.2.840.113549.2.4\"")]
        public static ReadOnlySpan<byte> szOID_RSA_MD4 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_RSA_MD5 \"1.2.840.113549.2.5\"")]
        public static ReadOnlySpan<byte> szOID_RSA_MD5 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_RSA_RC2CBC \"1.2.840.113549.3.2\"")]
        public static ReadOnlySpan<byte> szOID_RSA_RC2CBC => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x33, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_RSA_RC4 \"1.2.840.113549.3.4\"")]
        public static ReadOnlySpan<byte> szOID_RSA_RC4 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x33, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_RSA_DES_EDE3_CBC \"1.2.840.113549.3.7\"")]
        public static ReadOnlySpan<byte> szOID_RSA_DES_EDE3_CBC => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x33, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_RSA_RC5_CBCPad \"1.2.840.113549.3.9\"")]
        public static ReadOnlySpan<byte> szOID_RSA_RC5_CBCPad => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x33, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_ANSI_X942 \"1.2.840.10046\"")]
        public static ReadOnlySpan<byte> szOID_ANSI_X942 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x36, 0x00 };

        [NativeTypeName("#define szOID_ANSI_X942_DH \"1.2.840.10046.2.1\"")]
        public static ReadOnlySpan<byte> szOID_ANSI_X942_DH => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x36, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_X957 \"1.2.840.10040\"")]
        public static ReadOnlySpan<byte> szOID_X957 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x30, 0x00 };

        [NativeTypeName("#define szOID_X957_DSA \"1.2.840.10040.4.1\"")]
        public static ReadOnlySpan<byte> szOID_X957_DSA => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x30, 0x2E, 0x34, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_X957_SHA1DSA \"1.2.840.10040.4.3\"")]
        public static ReadOnlySpan<byte> szOID_X957_SHA1DSA => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x30, 0x2E, 0x34, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_ECC_PUBLIC_KEY \"1.2.840.10045.2.1\"")]
        public static ReadOnlySpan<byte> szOID_ECC_PUBLIC_KEY => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_P256 \"1.2.840.10045.3.1.7\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_P256 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_P384 \"1.3.132.0.34\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_P384 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x34, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_P521 \"1.3.132.0.35\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_P521 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x35, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP160R1 \"1.3.36.3.3.2.8.1.1.1\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP160R1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP160T1 \"1.3.36.3.3.2.8.1.1.2\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP160T1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP192R1 \"1.3.36.3.3.2.8.1.1.3\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP192R1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP192T1 \"1.3.36.3.3.2.8.1.1.4\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP192T1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP224R1 \"1.3.36.3.3.2.8.1.1.5\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP224R1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP224T1 \"1.3.36.3.3.2.8.1.1.6\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP224T1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP256R1 \"1.3.36.3.3.2.8.1.1.7\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP256R1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP256T1 \"1.3.36.3.3.2.8.1.1.8\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP256T1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x38, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP320R1 \"1.3.36.3.3.2.8.1.1.9\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP320R1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP320T1 \"1.3.36.3.3.2.8.1.1.10\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP320T1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP384R1 \"1.3.36.3.3.2.8.1.1.11\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP384R1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP384T1 \"1.3.36.3.3.2.8.1.1.12\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP384T1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP512R1 \"1.3.36.3.3.2.8.1.1.13\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP512R1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x33, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP512T1 \"1.3.36.3.3.2.8.1.1.14\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP512T1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x33, 0x36, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x34, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_EC192WAPI \"1.2.156.11235.1.1.2.1\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_EC192WAPI => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x35, 0x36, 0x2E, 0x31, 0x31, 0x32, 0x33, 0x35, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_CN_ECDSA_SHA256 \"1.2.156.11235.1.1.1\"")]
        public static ReadOnlySpan<byte> szOID_CN_ECDSA_SHA256 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x35, 0x36, 0x2E, 0x31, 0x31, 0x32, 0x33, 0x35, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_NISTP192 \"1.2.840.10045.3.1.1\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_NISTP192 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_NISTP224 \"1.3.132.0.33\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_NISTP224 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x33, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_NISTP256 szOID_ECC_CURVE_P256")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_NISTP256 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_NISTP384 szOID_ECC_CURVE_P384")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_NISTP384 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x34, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_NISTP521 szOID_ECC_CURVE_P521")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_NISTP521 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x35, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_SECP160K1 \"1.3.132.0.9\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP160K1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_SECP160R1 \"1.3.132.0.8\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP160R1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x38, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_SECP160R2 \"1.3.132.0.30\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP160R2 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x30, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_SECP192K1 \"1.3.132.0.31\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP192K1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_SECP192R1 szOID_ECC_CURVE_NISTP192")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP192R1 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_SECP224K1 \"1.3.132.0.32\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP224K1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_SECP224R1 szOID_ECC_CURVE_NISTP224")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP224R1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x33, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_SECP256K1 \"1.3.132.0.10\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP256K1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x31, 0x30, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_SECP256R1 szOID_ECC_CURVE_P256")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP256R1 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_SECP384R1 szOID_ECC_CURVE_P384")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP384R1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x34, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_SECP521R1 szOID_ECC_CURVE_P521")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP521R1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x35, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_WTLS7 szOID_ECC_CURVE_SECP160R2")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_WTLS7 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x30, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_WTLS9 \"2.23.43.1.4.9\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_WTLS9 => new byte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x34, 0x33, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_WTLS12 szOID_ECC_CURVE_NISTP224")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_WTLS12 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x30, 0x2E, 0x33, 0x33, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_X962P192V1 \"1.2.840.10045.3.1.1\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_X962P192V1 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_X962P192V2 \"1.2.840.10045.3.1.2\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_X962P192V2 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_X962P192V3 \"1.2.840.10045.3.1.3\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_X962P192V3 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_X962P239V1 \"1.2.840.10045.3.1.4\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_X962P239V1 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_X962P239V2 \"1.2.840.10045.3.1.5\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_X962P239V2 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_X962P239V3 \"1.2.840.10045.3.1.6\"")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_X962P239V3 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_ECC_CURVE_X962P256V1 szOID_ECC_CURVE_P256")]
        public static ReadOnlySpan<byte> szOID_ECC_CURVE_X962P256V1 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x33, 0x2E, 0x31, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_ECDSA_SHA1 \"1.2.840.10045.4.1\"")]
        public static ReadOnlySpan<byte> szOID_ECDSA_SHA1 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ECDSA_SPECIFIED \"1.2.840.10045.4.3\"")]
        public static ReadOnlySpan<byte> szOID_ECDSA_SPECIFIED => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_ECDSA_SHA256 \"1.2.840.10045.4.3.2\"")]
        public static ReadOnlySpan<byte> szOID_ECDSA_SHA256 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_ECDSA_SHA384 \"1.2.840.10045.4.3.3\"")]
        public static ReadOnlySpan<byte> szOID_ECDSA_SHA384 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_ECDSA_SHA512 \"1.2.840.10045.4.3.4\"")]
        public static ReadOnlySpan<byte> szOID_ECDSA_SHA512 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x34, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_NIST_AES128_CBC \"2.16.840.1.101.3.4.1.2\"")]
        public static ReadOnlySpan<byte> szOID_NIST_AES128_CBC => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_NIST_AES192_CBC \"2.16.840.1.101.3.4.1.22\"")]
        public static ReadOnlySpan<byte> szOID_NIST_AES192_CBC => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x32, 0x32, 0x00 };

        [NativeTypeName("#define szOID_NIST_AES256_CBC \"2.16.840.1.101.3.4.1.42\"")]
        public static ReadOnlySpan<byte> szOID_NIST_AES256_CBC => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x34, 0x32, 0x00 };

        [NativeTypeName("#define szOID_NIST_AES128_WRAP \"2.16.840.1.101.3.4.1.5\"")]
        public static ReadOnlySpan<byte> szOID_NIST_AES128_WRAP => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_NIST_AES192_WRAP \"2.16.840.1.101.3.4.1.25\"")]
        public static ReadOnlySpan<byte> szOID_NIST_AES192_WRAP => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x32, 0x35, 0x00 };

        [NativeTypeName("#define szOID_NIST_AES256_WRAP \"2.16.840.1.101.3.4.1.45\"")]
        public static ReadOnlySpan<byte> szOID_NIST_AES256_WRAP => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x34, 0x35, 0x00 };

        [NativeTypeName("#define szOID_DH_SINGLE_PASS_STDDH_SHA1_KDF \"1.3.133.16.840.63.0.2\"")]
        public static ReadOnlySpan<byte> szOID_DH_SINGLE_PASS_STDDH_SHA1_KDF => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x36, 0x33, 0x2E, 0x30, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_DH_SINGLE_PASS_STDDH_SHA256_KDF \"1.3.132.1.11.1\"")]
        public static ReadOnlySpan<byte> szOID_DH_SINGLE_PASS_STDDH_SHA256_KDF => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_DH_SINGLE_PASS_STDDH_SHA384_KDF \"1.3.132.1.11.2\"")]
        public static ReadOnlySpan<byte> szOID_DH_SINGLE_PASS_STDDH_SHA384_KDF => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_DS \"2.5\"")]
        public static ReadOnlySpan<byte> szOID_DS => new byte[] { 0x32, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_DSALG \"2.5.8\"")]
        public static ReadOnlySpan<byte> szOID_DSALG => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x38, 0x00 };

        [NativeTypeName("#define szOID_DSALG_CRPT \"2.5.8.1\"")]
        public static ReadOnlySpan<byte> szOID_DSALG_CRPT => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x38, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_DSALG_HASH \"2.5.8.2\"")]
        public static ReadOnlySpan<byte> szOID_DSALG_HASH => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x38, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_DSALG_SIGN \"2.5.8.3\"")]
        public static ReadOnlySpan<byte> szOID_DSALG_SIGN => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x38, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_DSALG_RSA \"2.5.8.1.1\"")]
        public static ReadOnlySpan<byte> szOID_DSALG_RSA => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_OIW \"1.3.14\"")]
        public static ReadOnlySpan<byte> szOID_OIW => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC \"1.3.14.3.2\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_md4RSA \"1.3.14.3.2.2\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_md4RSA => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_md5RSA \"1.3.14.3.2.3\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_md5RSA => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_md4RSA2 \"1.3.14.3.2.4\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_md4RSA2 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_desECB \"1.3.14.3.2.6\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_desECB => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_desCBC \"1.3.14.3.2.7\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_desCBC => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_desOFB \"1.3.14.3.2.8\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_desOFB => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x38, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_desCFB \"1.3.14.3.2.9\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_desCFB => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_desMAC \"1.3.14.3.2.10\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_desMAC => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x30, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_rsaSign \"1.3.14.3.2.11\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_rsaSign => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x31, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_dsa \"1.3.14.3.2.12\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_dsa => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x32, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_shaDSA \"1.3.14.3.2.13\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_shaDSA => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x33, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_mdc2RSA \"1.3.14.3.2.14\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_mdc2RSA => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x34, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_shaRSA \"1.3.14.3.2.15\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_shaRSA => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x35, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_dhCommMod \"1.3.14.3.2.16\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_dhCommMod => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x36, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_desEDE \"1.3.14.3.2.17\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_desEDE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x37, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_sha \"1.3.14.3.2.18\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_sha => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x38, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_mdc2 \"1.3.14.3.2.19\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_mdc2 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x39, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_dsaComm \"1.3.14.3.2.20\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_dsaComm => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x30, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_dsaCommSHA \"1.3.14.3.2.21\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_dsaCommSHA => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x31, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_rsaXchg \"1.3.14.3.2.22\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_rsaXchg => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x32, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_keyHashSeal \"1.3.14.3.2.23\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_keyHashSeal => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x33, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_md2RSASign \"1.3.14.3.2.24\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_md2RSASign => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x34, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_md5RSASign \"1.3.14.3.2.25\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_md5RSASign => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x35, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_sha1 \"1.3.14.3.2.26\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_sha1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x36, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_dsaSHA1 \"1.3.14.3.2.27\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_dsaSHA1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x37, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_dsaCommSHA1 \"1.3.14.3.2.28\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_dsaCommSHA1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x38, 0x00 };

        [NativeTypeName("#define szOID_OIWSEC_sha1RSASign \"1.3.14.3.2.29\"")]
        public static ReadOnlySpan<byte> szOID_OIWSEC_sha1RSASign => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x39, 0x00 };

        [NativeTypeName("#define szOID_OIWDIR \"1.3.14.7.2\"")]
        public static ReadOnlySpan<byte> szOID_OIWDIR => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x37, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_OIWDIR_CRPT \"1.3.14.7.2.1\"")]
        public static ReadOnlySpan<byte> szOID_OIWDIR_CRPT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x37, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_OIWDIR_HASH \"1.3.14.7.2.2\"")]
        public static ReadOnlySpan<byte> szOID_OIWDIR_HASH => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x37, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_OIWDIR_SIGN \"1.3.14.7.2.3\"")]
        public static ReadOnlySpan<byte> szOID_OIWDIR_SIGN => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x37, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_OIWDIR_md2 \"1.3.14.7.2.2.1\"")]
        public static ReadOnlySpan<byte> szOID_OIWDIR_md2 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x37, 0x2E, 0x32, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_OIWDIR_md2RSA \"1.3.14.7.2.3.1\"")]
        public static ReadOnlySpan<byte> szOID_OIWDIR_md2RSA => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x2E, 0x37, 0x2E, 0x32, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC \"2.16.840.1.101.2.1\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_sdnsSignature \"2.16.840.1.101.2.1.1.1\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_sdnsSignature => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_mosaicSignature \"2.16.840.1.101.2.1.1.2\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicSignature => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_sdnsConfidentiality \"2.16.840.1.101.2.1.1.3\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_sdnsConfidentiality => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_mosaicConfidentiality \"2.16.840.1.101.2.1.1.4\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicConfidentiality => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_sdnsIntegrity \"2.16.840.1.101.2.1.1.5\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_sdnsIntegrity => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_mosaicIntegrity \"2.16.840.1.101.2.1.1.6\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicIntegrity => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_sdnsTokenProtection \"2.16.840.1.101.2.1.1.7\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_sdnsTokenProtection => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_mosaicTokenProtection \"2.16.840.1.101.2.1.1.8\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicTokenProtection => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x38, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_sdnsKeyManagement \"2.16.840.1.101.2.1.1.9\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_sdnsKeyManagement => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_mosaicKeyManagement \"2.16.840.1.101.2.1.1.10\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicKeyManagement => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_sdnsKMandSig \"2.16.840.1.101.2.1.1.11\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_sdnsKMandSig => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_mosaicKMandSig \"2.16.840.1.101.2.1.1.12\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicKMandSig => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_SuiteASignature \"2.16.840.1.101.2.1.1.13\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_SuiteASignature => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x33, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_SuiteAConfidentiality \"2.16.840.1.101.2.1.1.14\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_SuiteAConfidentiality => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x34, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_SuiteAIntegrity \"2.16.840.1.101.2.1.1.15\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_SuiteAIntegrity => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x35, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_SuiteATokenProtection \"2.16.840.1.101.2.1.1.16\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_SuiteATokenProtection => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x36, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_SuiteAKeyManagement \"2.16.840.1.101.2.1.1.17\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_SuiteAKeyManagement => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x37, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_SuiteAKMandSig \"2.16.840.1.101.2.1.1.18\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_SuiteAKMandSig => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x38, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_mosaicUpdatedSig \"2.16.840.1.101.2.1.1.19\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicUpdatedSig => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x39, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_mosaicKMandUpdSig \"2.16.840.1.101.2.1.1.20\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicKMandUpdSig => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x32, 0x30, 0x00 };

        [NativeTypeName("#define szOID_INFOSEC_mosaicUpdatedInteg \"2.16.840.1.101.2.1.1.21\"")]
        public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicUpdatedInteg => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x32, 0x31, 0x00 };

        [NativeTypeName("#define szOID_NIST_sha256 \"2.16.840.1.101.3.4.2.1\"")]
        public static ReadOnlySpan<byte> szOID_NIST_sha256 => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_NIST_sha384 \"2.16.840.1.101.3.4.2.2\"")]
        public static ReadOnlySpan<byte> szOID_NIST_sha384 => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_NIST_sha512 \"2.16.840.1.101.3.4.2.3\"")]
        public static ReadOnlySpan<byte> szOID_NIST_sha512 => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x30, 0x31, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_COMMON_NAME \"2.5.4.3\"")]
        public static ReadOnlySpan<byte> szOID_COMMON_NAME => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_SUR_NAME \"2.5.4.4\"")]
        public static ReadOnlySpan<byte> szOID_SUR_NAME => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_DEVICE_SERIAL_NUMBER \"2.5.4.5\"")]
        public static ReadOnlySpan<byte> szOID_DEVICE_SERIAL_NUMBER => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_COUNTRY_NAME \"2.5.4.6\"")]
        public static ReadOnlySpan<byte> szOID_COUNTRY_NAME => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_LOCALITY_NAME \"2.5.4.7\"")]
        public static ReadOnlySpan<byte> szOID_LOCALITY_NAME => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_STATE_OR_PROVINCE_NAME \"2.5.4.8\"")]
        public static ReadOnlySpan<byte> szOID_STATE_OR_PROVINCE_NAME => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x38, 0x00 };

        [NativeTypeName("#define szOID_STREET_ADDRESS \"2.5.4.9\"")]
        public static ReadOnlySpan<byte> szOID_STREET_ADDRESS => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_ORGANIZATION_NAME \"2.5.4.10\"")]
        public static ReadOnlySpan<byte> szOID_ORGANIZATION_NAME => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x30, 0x00 };

        [NativeTypeName("#define szOID_ORGANIZATIONAL_UNIT_NAME \"2.5.4.11\"")]
        public static ReadOnlySpan<byte> szOID_ORGANIZATIONAL_UNIT_NAME => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x31, 0x00 };

        [NativeTypeName("#define szOID_TITLE \"2.5.4.12\"")]
        public static ReadOnlySpan<byte> szOID_TITLE => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x32, 0x00 };

        [NativeTypeName("#define szOID_DESCRIPTION \"2.5.4.13\"")]
        public static ReadOnlySpan<byte> szOID_DESCRIPTION => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x33, 0x00 };

        [NativeTypeName("#define szOID_SEARCH_GUIDE \"2.5.4.14\"")]
        public static ReadOnlySpan<byte> szOID_SEARCH_GUIDE => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x34, 0x00 };

        [NativeTypeName("#define szOID_BUSINESS_CATEGORY \"2.5.4.15\"")]
        public static ReadOnlySpan<byte> szOID_BUSINESS_CATEGORY => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x35, 0x00 };

        [NativeTypeName("#define szOID_POSTAL_ADDRESS \"2.5.4.16\"")]
        public static ReadOnlySpan<byte> szOID_POSTAL_ADDRESS => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x36, 0x00 };

        [NativeTypeName("#define szOID_POSTAL_CODE \"2.5.4.17\"")]
        public static ReadOnlySpan<byte> szOID_POSTAL_CODE => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x37, 0x00 };

        [NativeTypeName("#define szOID_POST_OFFICE_BOX \"2.5.4.18\"")]
        public static ReadOnlySpan<byte> szOID_POST_OFFICE_BOX => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x38, 0x00 };

        [NativeTypeName("#define szOID_PHYSICAL_DELIVERY_OFFICE_NAME \"2.5.4.19\"")]
        public static ReadOnlySpan<byte> szOID_PHYSICAL_DELIVERY_OFFICE_NAME => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x31, 0x39, 0x00 };

        [NativeTypeName("#define szOID_TELEPHONE_NUMBER \"2.5.4.20\"")]
        public static ReadOnlySpan<byte> szOID_TELEPHONE_NUMBER => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x30, 0x00 };

        [NativeTypeName("#define szOID_TELEX_NUMBER \"2.5.4.21\"")]
        public static ReadOnlySpan<byte> szOID_TELEX_NUMBER => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x31, 0x00 };

        [NativeTypeName("#define szOID_TELETEXT_TERMINAL_IDENTIFIER \"2.5.4.22\"")]
        public static ReadOnlySpan<byte> szOID_TELETEXT_TERMINAL_IDENTIFIER => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x32, 0x00 };

        [NativeTypeName("#define szOID_FACSIMILE_TELEPHONE_NUMBER \"2.5.4.23\"")]
        public static ReadOnlySpan<byte> szOID_FACSIMILE_TELEPHONE_NUMBER => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x33, 0x00 };

        [NativeTypeName("#define szOID_X21_ADDRESS \"2.5.4.24\"")]
        public static ReadOnlySpan<byte> szOID_X21_ADDRESS => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x34, 0x00 };

        [NativeTypeName("#define szOID_INTERNATIONAL_ISDN_NUMBER \"2.5.4.25\"")]
        public static ReadOnlySpan<byte> szOID_INTERNATIONAL_ISDN_NUMBER => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x35, 0x00 };

        [NativeTypeName("#define szOID_REGISTERED_ADDRESS \"2.5.4.26\"")]
        public static ReadOnlySpan<byte> szOID_REGISTERED_ADDRESS => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x36, 0x00 };

        [NativeTypeName("#define szOID_DESTINATION_INDICATOR \"2.5.4.27\"")]
        public static ReadOnlySpan<byte> szOID_DESTINATION_INDICATOR => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x37, 0x00 };

        [NativeTypeName("#define szOID_PREFERRED_DELIVERY_METHOD \"2.5.4.28\"")]
        public static ReadOnlySpan<byte> szOID_PREFERRED_DELIVERY_METHOD => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x38, 0x00 };

        [NativeTypeName("#define szOID_PRESENTATION_ADDRESS \"2.5.4.29\"")]
        public static ReadOnlySpan<byte> szOID_PRESENTATION_ADDRESS => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x32, 0x39, 0x00 };

        [NativeTypeName("#define szOID_SUPPORTED_APPLICATION_CONTEXT \"2.5.4.30\"")]
        public static ReadOnlySpan<byte> szOID_SUPPORTED_APPLICATION_CONTEXT => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x30, 0x00 };

        [NativeTypeName("#define szOID_MEMBER \"2.5.4.31\"")]
        public static ReadOnlySpan<byte> szOID_MEMBER => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x31, 0x00 };

        [NativeTypeName("#define szOID_OWNER \"2.5.4.32\"")]
        public static ReadOnlySpan<byte> szOID_OWNER => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define szOID_ROLE_OCCUPANT \"2.5.4.33\"")]
        public static ReadOnlySpan<byte> szOID_ROLE_OCCUPANT => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x33, 0x00 };

        [NativeTypeName("#define szOID_SEE_ALSO \"2.5.4.34\"")]
        public static ReadOnlySpan<byte> szOID_SEE_ALSO => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x34, 0x00 };

        [NativeTypeName("#define szOID_USER_PASSWORD \"2.5.4.35\"")]
        public static ReadOnlySpan<byte> szOID_USER_PASSWORD => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x35, 0x00 };

        [NativeTypeName("#define szOID_USER_CERTIFICATE \"2.5.4.36\"")]
        public static ReadOnlySpan<byte> szOID_USER_CERTIFICATE => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x36, 0x00 };

        [NativeTypeName("#define szOID_CA_CERTIFICATE \"2.5.4.37\"")]
        public static ReadOnlySpan<byte> szOID_CA_CERTIFICATE => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x37, 0x00 };

        [NativeTypeName("#define szOID_AUTHORITY_REVOCATION_LIST \"2.5.4.38\"")]
        public static ReadOnlySpan<byte> szOID_AUTHORITY_REVOCATION_LIST => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x38, 0x00 };

        [NativeTypeName("#define szOID_CERTIFICATE_REVOCATION_LIST \"2.5.4.39\"")]
        public static ReadOnlySpan<byte> szOID_CERTIFICATE_REVOCATION_LIST => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x33, 0x39, 0x00 };

        [NativeTypeName("#define szOID_CROSS_CERTIFICATE_PAIR \"2.5.4.40\"")]
        public static ReadOnlySpan<byte> szOID_CROSS_CERTIFICATE_PAIR => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x34, 0x30, 0x00 };

        [NativeTypeName("#define szOID_GIVEN_NAME \"2.5.4.42\"")]
        public static ReadOnlySpan<byte> szOID_GIVEN_NAME => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x34, 0x32, 0x00 };

        [NativeTypeName("#define szOID_INITIALS \"2.5.4.43\"")]
        public static ReadOnlySpan<byte> szOID_INITIALS => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x34, 0x33, 0x00 };

        [NativeTypeName("#define szOID_DN_QUALIFIER \"2.5.4.46\"")]
        public static ReadOnlySpan<byte> szOID_DN_QUALIFIER => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x34, 0x36, 0x00 };

        [NativeTypeName("#define szOID_DOMAIN_COMPONENT \"0.9.2342.19200300.100.1.25\"")]
        public static ReadOnlySpan<byte> szOID_DOMAIN_COMPONENT => new byte[] { 0x30, 0x2E, 0x39, 0x2E, 0x32, 0x33, 0x34, 0x32, 0x2E, 0x31, 0x39, 0x32, 0x30, 0x30, 0x33, 0x30, 0x30, 0x2E, 0x31, 0x30, 0x30, 0x2E, 0x31, 0x2E, 0x32, 0x35, 0x00 };

        [NativeTypeName("#define szOID_PKCS_12_FRIENDLY_NAME_ATTR \"1.2.840.113549.1.9.20\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_12_FRIENDLY_NAME_ATTR => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x32, 0x30, 0x00 };

        [NativeTypeName("#define szOID_PKCS_12_LOCAL_KEY_ID \"1.2.840.113549.1.9.21\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_12_LOCAL_KEY_ID => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x32, 0x31, 0x00 };

        [NativeTypeName("#define szOID_PKCS_12_KEY_PROVIDER_NAME_ATTR \"1.3.6.1.4.1.311.17.1\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_12_KEY_PROVIDER_NAME_ATTR => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x37, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_LOCAL_MACHINE_KEYSET \"1.3.6.1.4.1.311.17.2\"")]
        public static ReadOnlySpan<byte> szOID_LOCAL_MACHINE_KEYSET => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x37, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_PKCS_12_EXTENDED_ATTRIBUTES \"1.3.6.1.4.1.311.17.3\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_12_EXTENDED_ATTRIBUTES => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x37, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_PKCS_12_PROTECTED_PASSWORD_SECRET_BAG_TYPE_ID \"1.3.6.1.4.1.311.17.4\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_12_PROTECTED_PASSWORD_SECRET_BAG_TYPE_ID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x37, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_KEYID_RDN \"1.3.6.1.4.1.311.10.7.1\"")]
        public static ReadOnlySpan<byte> szOID_KEYID_RDN => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x37, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_EV_RDN_LOCALE \"1.3.6.1.4.1.311.60.2.1.1\"")]
        public static ReadOnlySpan<byte> szOID_EV_RDN_LOCALE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_EV_RDN_STATE_OR_PROVINCE \"1.3.6.1.4.1.311.60.2.1.2\"")]
        public static ReadOnlySpan<byte> szOID_EV_RDN_STATE_OR_PROVINCE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_EV_RDN_COUNTRY \"1.3.6.1.4.1.311.60.2.1.3\"")]
        public static ReadOnlySpan<byte> szOID_EV_RDN_COUNTRY => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define CERT_RDN_ANY_TYPE 0")]
        public const int CERT_RDN_ANY_TYPE = 0;

        [NativeTypeName("#define CERT_RDN_ENCODED_BLOB 1")]
        public const int CERT_RDN_ENCODED_BLOB = 1;

        [NativeTypeName("#define CERT_RDN_OCTET_STRING 2")]
        public const int CERT_RDN_OCTET_STRING = 2;

        [NativeTypeName("#define CERT_RDN_NUMERIC_STRING 3")]
        public const int CERT_RDN_NUMERIC_STRING = 3;

        [NativeTypeName("#define CERT_RDN_PRINTABLE_STRING 4")]
        public const int CERT_RDN_PRINTABLE_STRING = 4;

        [NativeTypeName("#define CERT_RDN_TELETEX_STRING 5")]
        public const int CERT_RDN_TELETEX_STRING = 5;

        [NativeTypeName("#define CERT_RDN_T61_STRING 5")]
        public const int CERT_RDN_T61_STRING = 5;

        [NativeTypeName("#define CERT_RDN_VIDEOTEX_STRING 6")]
        public const int CERT_RDN_VIDEOTEX_STRING = 6;

        [NativeTypeName("#define CERT_RDN_IA5_STRING 7")]
        public const int CERT_RDN_IA5_STRING = 7;

        [NativeTypeName("#define CERT_RDN_GRAPHIC_STRING 8")]
        public const int CERT_RDN_GRAPHIC_STRING = 8;

        [NativeTypeName("#define CERT_RDN_VISIBLE_STRING 9")]
        public const int CERT_RDN_VISIBLE_STRING = 9;

        [NativeTypeName("#define CERT_RDN_ISO646_STRING 9")]
        public const int CERT_RDN_ISO646_STRING = 9;

        [NativeTypeName("#define CERT_RDN_GENERAL_STRING 10")]
        public const int CERT_RDN_GENERAL_STRING = 10;

        [NativeTypeName("#define CERT_RDN_UNIVERSAL_STRING 11")]
        public const int CERT_RDN_UNIVERSAL_STRING = 11;

        [NativeTypeName("#define CERT_RDN_INT4_STRING 11")]
        public const int CERT_RDN_INT4_STRING = 11;

        [NativeTypeName("#define CERT_RDN_BMP_STRING 12")]
        public const int CERT_RDN_BMP_STRING = 12;

        [NativeTypeName("#define CERT_RDN_UNICODE_STRING 12")]
        public const int CERT_RDN_UNICODE_STRING = 12;

        [NativeTypeName("#define CERT_RDN_UTF8_STRING 13")]
        public const int CERT_RDN_UTF8_STRING = 13;

        [NativeTypeName("#define CERT_RDN_TYPE_MASK 0x000000FF")]
        public const int CERT_RDN_TYPE_MASK = 0x000000FF;

        [NativeTypeName("#define CERT_RDN_FLAGS_MASK 0xFF000000")]
        public const uint CERT_RDN_FLAGS_MASK = 0xFF000000;

        [NativeTypeName("#define CERT_RDN_ENABLE_T61_UNICODE_FLAG 0x80000000")]
        public const uint CERT_RDN_ENABLE_T61_UNICODE_FLAG = 0x80000000;

        [NativeTypeName("#define CERT_RDN_ENABLE_UTF8_UNICODE_FLAG 0x20000000")]
        public const int CERT_RDN_ENABLE_UTF8_UNICODE_FLAG = 0x20000000;

        [NativeTypeName("#define CERT_RDN_FORCE_UTF8_UNICODE_FLAG 0x10000000")]
        public const int CERT_RDN_FORCE_UTF8_UNICODE_FLAG = 0x10000000;

        [NativeTypeName("#define CERT_RDN_DISABLE_CHECK_TYPE_FLAG 0x40000000")]
        public const int CERT_RDN_DISABLE_CHECK_TYPE_FLAG = 0x40000000;

        [NativeTypeName("#define CERT_RDN_DISABLE_IE4_UTF8_FLAG 0x01000000")]
        public const int CERT_RDN_DISABLE_IE4_UTF8_FLAG = 0x01000000;

        [NativeTypeName("#define CERT_RDN_ENABLE_PUNYCODE_FLAG 0x02000000")]
        public const int CERT_RDN_ENABLE_PUNYCODE_FLAG = 0x02000000;

        [NativeTypeName("#define CERT_RSA_PUBLIC_KEY_OBJID szOID_RSA_RSA")]
        public static ReadOnlySpan<byte> CERT_RSA_PUBLIC_KEY_OBJID => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define CERT_DEFAULT_OID_PUBLIC_KEY_SIGN szOID_RSA_RSA")]
        public static ReadOnlySpan<byte> CERT_DEFAULT_OID_PUBLIC_KEY_SIGN => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define CERT_DEFAULT_OID_PUBLIC_KEY_XCHG szOID_RSA_RSA")]
        public static ReadOnlySpan<byte> CERT_DEFAULT_OID_PUBLIC_KEY_XCHG => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define CRYPT_ECC_PRIVATE_KEY_INFO_v1 1")]
        public const int CRYPT_ECC_PRIVATE_KEY_INFO_v1 = 1;

        [NativeTypeName("#define CERT_V1 0")]
        public const int CERT_V1 = 0;

        [NativeTypeName("#define CERT_V2 1")]
        public const int CERT_V2 = 1;

        [NativeTypeName("#define CERT_V3 2")]
        public const int CERT_V3 = 2;

        [NativeTypeName("#define CERT_INFO_VERSION_FLAG 1")]
        public const int CERT_INFO_VERSION_FLAG = 1;

        [NativeTypeName("#define CERT_INFO_SERIAL_NUMBER_FLAG 2")]
        public const int CERT_INFO_SERIAL_NUMBER_FLAG = 2;

        [NativeTypeName("#define CERT_INFO_SIGNATURE_ALGORITHM_FLAG 3")]
        public const int CERT_INFO_SIGNATURE_ALGORITHM_FLAG = 3;

        [NativeTypeName("#define CERT_INFO_ISSUER_FLAG 4")]
        public const int CERT_INFO_ISSUER_FLAG = 4;

        [NativeTypeName("#define CERT_INFO_NOT_BEFORE_FLAG 5")]
        public const int CERT_INFO_NOT_BEFORE_FLAG = 5;

        [NativeTypeName("#define CERT_INFO_NOT_AFTER_FLAG 6")]
        public const int CERT_INFO_NOT_AFTER_FLAG = 6;

        [NativeTypeName("#define CERT_INFO_SUBJECT_FLAG 7")]
        public const int CERT_INFO_SUBJECT_FLAG = 7;

        [NativeTypeName("#define CERT_INFO_SUBJECT_PUBLIC_KEY_INFO_FLAG 8")]
        public const int CERT_INFO_SUBJECT_PUBLIC_KEY_INFO_FLAG = 8;

        [NativeTypeName("#define CERT_INFO_ISSUER_UNIQUE_ID_FLAG 9")]
        public const int CERT_INFO_ISSUER_UNIQUE_ID_FLAG = 9;

        [NativeTypeName("#define CERT_INFO_SUBJECT_UNIQUE_ID_FLAG 10")]
        public const int CERT_INFO_SUBJECT_UNIQUE_ID_FLAG = 10;

        [NativeTypeName("#define CERT_INFO_EXTENSION_FLAG 11")]
        public const int CERT_INFO_EXTENSION_FLAG = 11;

        [NativeTypeName("#define CRL_V1 0")]
        public const int CRL_V1 = 0;

        [NativeTypeName("#define CRL_V2 1")]
        public const int CRL_V2 = 1;

        [NativeTypeName("#define CERT_BUNDLE_CERTIFICATE 0")]
        public const int CERT_BUNDLE_CERTIFICATE = 0;

        [NativeTypeName("#define CERT_BUNDLE_CRL 1")]
        public const int CERT_BUNDLE_CRL = 1;

        [NativeTypeName("#define CERT_REQUEST_V1 0")]
        public const int CERT_REQUEST_V1 = 0;

        [NativeTypeName("#define CERT_KEYGEN_REQUEST_V1 0")]
        public const int CERT_KEYGEN_REQUEST_V1 = 0;

        [NativeTypeName("#define CTL_V1 0")]
        public const int CTL_V1 = 0;

        [NativeTypeName("#define CERT_ENCODING_TYPE_MASK 0x0000FFFF")]
        public const int CERT_ENCODING_TYPE_MASK = 0x0000FFFF;

        [NativeTypeName("#define CMSG_ENCODING_TYPE_MASK 0xFFFF0000")]
        public const uint CMSG_ENCODING_TYPE_MASK = 0xFFFF0000;

        [NativeTypeName("#define CRYPT_ASN_ENCODING 0x00000001")]
        public const int CRYPT_ASN_ENCODING = 0x00000001;

        [NativeTypeName("#define CRYPT_NDR_ENCODING 0x00000002")]
        public const int CRYPT_NDR_ENCODING = 0x00000002;

        [NativeTypeName("#define X509_ASN_ENCODING 0x00000001")]
        public const int X509_ASN_ENCODING = 0x00000001;

        [NativeTypeName("#define X509_NDR_ENCODING 0x00000002")]
        public const int X509_NDR_ENCODING = 0x00000002;

        [NativeTypeName("#define PKCS_7_ASN_ENCODING 0x00010000")]
        public const int PKCS_7_ASN_ENCODING = 0x00010000;

        [NativeTypeName("#define PKCS_7_NDR_ENCODING 0x00020000")]
        public const int PKCS_7_NDR_ENCODING = 0x00020000;

        [NativeTypeName("#define CRYPT_FORMAT_STR_MULTI_LINE 0x0001")]
        public const int CRYPT_FORMAT_STR_MULTI_LINE = 0x0001;

        [NativeTypeName("#define CRYPT_FORMAT_STR_NO_HEX 0x0010")]
        public const int CRYPT_FORMAT_STR_NO_HEX = 0x0010;

        [NativeTypeName("#define CRYPT_FORMAT_SIMPLE 0x0001")]
        public const int CRYPT_FORMAT_SIMPLE = 0x0001;

        [NativeTypeName("#define CRYPT_FORMAT_X509 0x0002")]
        public const int CRYPT_FORMAT_X509 = 0x0002;

        [NativeTypeName("#define CRYPT_FORMAT_OID 0x0004")]
        public const int CRYPT_FORMAT_OID = 0x0004;

        [NativeTypeName("#define CRYPT_FORMAT_RDN_SEMICOLON 0x0100")]
        public const int CRYPT_FORMAT_RDN_SEMICOLON = 0x0100;

        [NativeTypeName("#define CRYPT_FORMAT_RDN_CRLF 0x0200")]
        public const int CRYPT_FORMAT_RDN_CRLF = 0x0200;

        [NativeTypeName("#define CRYPT_FORMAT_RDN_UNQUOTE 0x0400")]
        public const int CRYPT_FORMAT_RDN_UNQUOTE = 0x0400;

        [NativeTypeName("#define CRYPT_FORMAT_RDN_REVERSE 0x0800")]
        public const int CRYPT_FORMAT_RDN_REVERSE = 0x0800;

        [NativeTypeName("#define CRYPT_FORMAT_COMMA 0x1000")]
        public const int CRYPT_FORMAT_COMMA = 0x1000;

        [NativeTypeName("#define CRYPT_FORMAT_SEMICOLON CRYPT_FORMAT_RDN_SEMICOLON")]
        public const int CRYPT_FORMAT_SEMICOLON = 0x0100;

        [NativeTypeName("#define CRYPT_FORMAT_CRLF CRYPT_FORMAT_RDN_CRLF")]
        public const int CRYPT_FORMAT_CRLF = 0x0200;

        [NativeTypeName("#define CRYPT_ENCODE_NO_SIGNATURE_BYTE_REVERSAL_FLAG 0x8")]
        public const int CRYPT_ENCODE_NO_SIGNATURE_BYTE_REVERSAL_FLAG = 0x8;

        [NativeTypeName("#define CRYPT_ENCODE_ALLOC_FLAG 0x8000")]
        public const int CRYPT_ENCODE_ALLOC_FLAG = 0x8000;

        [NativeTypeName("#define CRYPT_UNICODE_NAME_ENCODE_ENABLE_T61_UNICODE_FLAG CERT_RDN_ENABLE_T61_UNICODE_FLAG")]
        public const uint CRYPT_UNICODE_NAME_ENCODE_ENABLE_T61_UNICODE_FLAG = 0x80000000;

        [NativeTypeName("#define CRYPT_UNICODE_NAME_ENCODE_ENABLE_UTF8_UNICODE_FLAG CERT_RDN_ENABLE_UTF8_UNICODE_FLAG")]
        public const int CRYPT_UNICODE_NAME_ENCODE_ENABLE_UTF8_UNICODE_FLAG = 0x20000000;

        [NativeTypeName("#define CRYPT_UNICODE_NAME_ENCODE_FORCE_UTF8_UNICODE_FLAG CERT_RDN_FORCE_UTF8_UNICODE_FLAG")]
        public const int CRYPT_UNICODE_NAME_ENCODE_FORCE_UTF8_UNICODE_FLAG = 0x10000000;

        [NativeTypeName("#define CRYPT_UNICODE_NAME_ENCODE_DISABLE_CHECK_TYPE_FLAG CERT_RDN_DISABLE_CHECK_TYPE_FLAG")]
        public const int CRYPT_UNICODE_NAME_ENCODE_DISABLE_CHECK_TYPE_FLAG = 0x40000000;

        [NativeTypeName("#define CRYPT_SORTED_CTL_ENCODE_HASHED_SUBJECT_IDENTIFIER_FLAG 0x10000")]
        public const int CRYPT_SORTED_CTL_ENCODE_HASHED_SUBJECT_IDENTIFIER_FLAG = 0x10000;

        [NativeTypeName("#define CRYPT_ENCODE_ENABLE_PUNYCODE_FLAG 0x20000")]
        public const int CRYPT_ENCODE_ENABLE_PUNYCODE_FLAG = 0x20000;

        [NativeTypeName("#define CRYPT_ENCODE_ENABLE_UTF8PERCENT_FLAG 0x40000")]
        public const int CRYPT_ENCODE_ENABLE_UTF8PERCENT_FLAG = 0x40000;

        [NativeTypeName("#define CRYPT_ENCODE_ENABLE_IA5CONVERSION_FLAG (CRYPT_ENCODE_ENABLE_PUNYCODE_FLAG | CRYPT_ENCODE_ENABLE_UTF8PERCENT_FLAG)")]
        public const int CRYPT_ENCODE_ENABLE_IA5CONVERSION_FLAG = (0x20000 | 0x40000);

        [NativeTypeName("#define CRYPT_DECODE_NOCOPY_FLAG 0x1")]
        public const int CRYPT_DECODE_NOCOPY_FLAG = 0x1;

        [NativeTypeName("#define CRYPT_DECODE_TO_BE_SIGNED_FLAG 0x2")]
        public const int CRYPT_DECODE_TO_BE_SIGNED_FLAG = 0x2;

        [NativeTypeName("#define CRYPT_DECODE_SHARE_OID_STRING_FLAG 0x4")]
        public const int CRYPT_DECODE_SHARE_OID_STRING_FLAG = 0x4;

        [NativeTypeName("#define CRYPT_DECODE_NO_SIGNATURE_BYTE_REVERSAL_FLAG 0x8")]
        public const int CRYPT_DECODE_NO_SIGNATURE_BYTE_REVERSAL_FLAG = 0x8;

        [NativeTypeName("#define CRYPT_DECODE_ALLOC_FLAG 0x8000")]
        public const int CRYPT_DECODE_ALLOC_FLAG = 0x8000;

        [NativeTypeName("#define CRYPT_UNICODE_NAME_DECODE_DISABLE_IE4_UTF8_FLAG CERT_RDN_DISABLE_IE4_UTF8_FLAG")]
        public const int CRYPT_UNICODE_NAME_DECODE_DISABLE_IE4_UTF8_FLAG = 0x01000000;

        [NativeTypeName("#define CRYPT_DECODE_ENABLE_PUNYCODE_FLAG 0x02000000")]
        public const int CRYPT_DECODE_ENABLE_PUNYCODE_FLAG = 0x02000000;

        [NativeTypeName("#define CRYPT_DECODE_ENABLE_UTF8PERCENT_FLAG 0x04000000")]
        public const int CRYPT_DECODE_ENABLE_UTF8PERCENT_FLAG = 0x04000000;

        [NativeTypeName("#define CRYPT_DECODE_ENABLE_IA5CONVERSION_FLAG (CRYPT_DECODE_ENABLE_PUNYCODE_FLAG | CRYPT_DECODE_ENABLE_UTF8PERCENT_FLAG)")]
        public const int CRYPT_DECODE_ENABLE_IA5CONVERSION_FLAG = (0x02000000 | 0x04000000);

        [NativeTypeName("#define CRYPT_ENCODE_DECODE_NONE 0")]
        public const int CRYPT_ENCODE_DECODE_NONE = 0;

        [NativeTypeName("#define X509_CERT ((LPCSTR) 1)")]
        public static sbyte* X509_CERT => ((sbyte*)(1));

        [NativeTypeName("#define X509_CERT_TO_BE_SIGNED ((LPCSTR) 2)")]
        public static sbyte* X509_CERT_TO_BE_SIGNED => ((sbyte*)(2));

        [NativeTypeName("#define X509_CERT_CRL_TO_BE_SIGNED ((LPCSTR) 3)")]
        public static sbyte* X509_CERT_CRL_TO_BE_SIGNED => ((sbyte*)(3));

        [NativeTypeName("#define X509_CERT_REQUEST_TO_BE_SIGNED ((LPCSTR) 4)")]
        public static sbyte* X509_CERT_REQUEST_TO_BE_SIGNED => ((sbyte*)(4));

        [NativeTypeName("#define X509_EXTENSIONS ((LPCSTR) 5)")]
        public static sbyte* X509_EXTENSIONS => ((sbyte*)(5));

        [NativeTypeName("#define X509_NAME_VALUE ((LPCSTR) 6)")]
        public static sbyte* X509_NAME_VALUE => ((sbyte*)(6));

        [NativeTypeName("#define X509_NAME ((LPCSTR) 7)")]
        public static sbyte* X509_NAME => ((sbyte*)(7));

        [NativeTypeName("#define X509_PUBLIC_KEY_INFO ((LPCSTR) 8)")]
        public static sbyte* X509_PUBLIC_KEY_INFO => ((sbyte*)(8));

        [NativeTypeName("#define X509_AUTHORITY_KEY_ID ((LPCSTR) 9)")]
        public static sbyte* X509_AUTHORITY_KEY_ID => ((sbyte*)(9));

        [NativeTypeName("#define X509_KEY_ATTRIBUTES ((LPCSTR) 10)")]
        public static sbyte* X509_KEY_ATTRIBUTES => ((sbyte*)(10));

        [NativeTypeName("#define X509_KEY_USAGE_RESTRICTION ((LPCSTR) 11)")]
        public static sbyte* X509_KEY_USAGE_RESTRICTION => ((sbyte*)(11));

        [NativeTypeName("#define X509_ALTERNATE_NAME ((LPCSTR) 12)")]
        public static sbyte* X509_ALTERNATE_NAME => ((sbyte*)(12));

        [NativeTypeName("#define X509_BASIC_CONSTRAINTS ((LPCSTR) 13)")]
        public static sbyte* X509_BASIC_CONSTRAINTS => ((sbyte*)(13));

        [NativeTypeName("#define X509_KEY_USAGE ((LPCSTR) 14)")]
        public static sbyte* X509_KEY_USAGE => ((sbyte*)(14));

        [NativeTypeName("#define X509_BASIC_CONSTRAINTS2 ((LPCSTR) 15)")]
        public static sbyte* X509_BASIC_CONSTRAINTS2 => ((sbyte*)(15));

        [NativeTypeName("#define X509_CERT_POLICIES ((LPCSTR) 16)")]
        public static sbyte* X509_CERT_POLICIES => ((sbyte*)(16));

        [NativeTypeName("#define PKCS_UTC_TIME ((LPCSTR) 17)")]
        public static sbyte* PKCS_UTC_TIME => ((sbyte*)(17));

        [NativeTypeName("#define PKCS_TIME_REQUEST ((LPCSTR) 18)")]
        public static sbyte* PKCS_TIME_REQUEST => ((sbyte*)(18));

        [NativeTypeName("#define RSA_CSP_PUBLICKEYBLOB ((LPCSTR) 19)")]
        public static sbyte* RSA_CSP_PUBLICKEYBLOB => ((sbyte*)(19));

        [NativeTypeName("#define X509_UNICODE_NAME ((LPCSTR) 20)")]
        public static sbyte* X509_UNICODE_NAME => ((sbyte*)(20));

        [NativeTypeName("#define X509_KEYGEN_REQUEST_TO_BE_SIGNED ((LPCSTR) 21)")]
        public static sbyte* X509_KEYGEN_REQUEST_TO_BE_SIGNED => ((sbyte*)(21));

        [NativeTypeName("#define PKCS_ATTRIBUTE ((LPCSTR) 22)")]
        public static sbyte* PKCS_ATTRIBUTE => ((sbyte*)(22));

        [NativeTypeName("#define PKCS_CONTENT_INFO_SEQUENCE_OF_ANY ((LPCSTR) 23)")]
        public static sbyte* PKCS_CONTENT_INFO_SEQUENCE_OF_ANY => ((sbyte*)(23));

        [NativeTypeName("#define X509_UNICODE_NAME_VALUE ((LPCSTR) 24)")]
        public static sbyte* X509_UNICODE_NAME_VALUE => ((sbyte*)(24));

        [NativeTypeName("#define X509_ANY_STRING X509_NAME_VALUE")]
        public static sbyte* X509_ANY_STRING => ((sbyte*)(6));

        [NativeTypeName("#define X509_UNICODE_ANY_STRING X509_UNICODE_NAME_VALUE")]
        public static sbyte* X509_UNICODE_ANY_STRING => ((sbyte*)(24));

        [NativeTypeName("#define X509_OCTET_STRING ((LPCSTR) 25)")]
        public static sbyte* X509_OCTET_STRING => ((sbyte*)(25));

        [NativeTypeName("#define X509_BITS ((LPCSTR) 26)")]
        public static sbyte* X509_BITS => ((sbyte*)(26));

        [NativeTypeName("#define X509_INTEGER ((LPCSTR) 27)")]
        public static sbyte* X509_INTEGER => ((sbyte*)(27));

        [NativeTypeName("#define X509_MULTI_BYTE_INTEGER ((LPCSTR) 28)")]
        public static sbyte* X509_MULTI_BYTE_INTEGER => ((sbyte*)(28));

        [NativeTypeName("#define X509_ENUMERATED ((LPCSTR) 29)")]
        public static sbyte* X509_ENUMERATED => ((sbyte*)(29));

        [NativeTypeName("#define X509_CHOICE_OF_TIME ((LPCSTR) 30)")]
        public static sbyte* X509_CHOICE_OF_TIME => ((sbyte*)(30));

        [NativeTypeName("#define X509_AUTHORITY_KEY_ID2 ((LPCSTR) 31)")]
        public static sbyte* X509_AUTHORITY_KEY_ID2 => ((sbyte*)(31));

        [NativeTypeName("#define X509_AUTHORITY_INFO_ACCESS ((LPCSTR) 32)")]
        public static sbyte* X509_AUTHORITY_INFO_ACCESS => ((sbyte*)(32));

        [NativeTypeName("#define X509_SUBJECT_INFO_ACCESS X509_AUTHORITY_INFO_ACCESS")]
        public static sbyte* X509_SUBJECT_INFO_ACCESS => ((sbyte*)(32));

        [NativeTypeName("#define X509_CRL_REASON_CODE X509_ENUMERATED")]
        public static sbyte* X509_CRL_REASON_CODE => ((sbyte*)(29));

        [NativeTypeName("#define PKCS_CONTENT_INFO ((LPCSTR) 33)")]
        public static sbyte* PKCS_CONTENT_INFO => ((sbyte*)(33));

        [NativeTypeName("#define X509_SEQUENCE_OF_ANY ((LPCSTR) 34)")]
        public static sbyte* X509_SEQUENCE_OF_ANY => ((sbyte*)(34));

        [NativeTypeName("#define X509_CRL_DIST_POINTS ((LPCSTR) 35)")]
        public static sbyte* X509_CRL_DIST_POINTS => ((sbyte*)(35));

        [NativeTypeName("#define X509_ENHANCED_KEY_USAGE ((LPCSTR) 36)")]
        public static sbyte* X509_ENHANCED_KEY_USAGE => ((sbyte*)(36));

        [NativeTypeName("#define PKCS_CTL ((LPCSTR) 37)")]
        public static sbyte* PKCS_CTL => ((sbyte*)(37));

        [NativeTypeName("#define X509_MULTI_BYTE_UINT ((LPCSTR) 38)")]
        public static sbyte* X509_MULTI_BYTE_UINT => ((sbyte*)(38));

        [NativeTypeName("#define X509_DSS_PUBLICKEY X509_MULTI_BYTE_UINT")]
        public static sbyte* X509_DSS_PUBLICKEY => ((sbyte*)(38));

        [NativeTypeName("#define X509_DSS_PARAMETERS ((LPCSTR) 39)")]
        public static sbyte* X509_DSS_PARAMETERS => ((sbyte*)(39));

        [NativeTypeName("#define X509_DSS_SIGNATURE ((LPCSTR) 40)")]
        public static sbyte* X509_DSS_SIGNATURE => ((sbyte*)(40));

        [NativeTypeName("#define PKCS_RC2_CBC_PARAMETERS ((LPCSTR) 41)")]
        public static sbyte* PKCS_RC2_CBC_PARAMETERS => ((sbyte*)(41));

        [NativeTypeName("#define PKCS_SMIME_CAPABILITIES ((LPCSTR) 42)")]
        public static sbyte* PKCS_SMIME_CAPABILITIES => ((sbyte*)(42));

        [NativeTypeName("#define X509_QC_STATEMENTS_EXT ((LPCSTR) 42)")]
        public static sbyte* X509_QC_STATEMENTS_EXT => ((sbyte*)(42));

        [NativeTypeName("#define PKCS_RSA_PRIVATE_KEY ((LPCSTR) 43)")]
        public static sbyte* PKCS_RSA_PRIVATE_KEY => ((sbyte*)(43));

        [NativeTypeName("#define PKCS_PRIVATE_KEY_INFO ((LPCSTR) 44)")]
        public static sbyte* PKCS_PRIVATE_KEY_INFO => ((sbyte*)(44));

        [NativeTypeName("#define PKCS_ENCRYPTED_PRIVATE_KEY_INFO ((LPCSTR) 45)")]
        public static sbyte* PKCS_ENCRYPTED_PRIVATE_KEY_INFO => ((sbyte*)(45));

        [NativeTypeName("#define X509_PKIX_POLICY_QUALIFIER_USERNOTICE ((LPCSTR) 46)")]
        public static sbyte* X509_PKIX_POLICY_QUALIFIER_USERNOTICE => ((sbyte*)(46));

        [NativeTypeName("#define X509_DH_PUBLICKEY X509_MULTI_BYTE_UINT")]
        public static sbyte* X509_DH_PUBLICKEY => ((sbyte*)(38));

        [NativeTypeName("#define X509_DH_PARAMETERS ((LPCSTR) 47)")]
        public static sbyte* X509_DH_PARAMETERS => ((sbyte*)(47));

        [NativeTypeName("#define PKCS_ATTRIBUTES ((LPCSTR) 48)")]
        public static sbyte* PKCS_ATTRIBUTES => ((sbyte*)(48));

        [NativeTypeName("#define PKCS_SORTED_CTL ((LPCSTR) 49)")]
        public static sbyte* PKCS_SORTED_CTL => ((sbyte*)(49));

        [NativeTypeName("#define X509_ECC_SIGNATURE ((LPCSTR) 47)")]
        public static sbyte* X509_ECC_SIGNATURE => ((sbyte*)(47));

        [NativeTypeName("#define X942_DH_PARAMETERS ((LPCSTR) 50)")]
        public static sbyte* X942_DH_PARAMETERS => ((sbyte*)(50));

        [NativeTypeName("#define X509_BITS_WITHOUT_TRAILING_ZEROES ((LPCSTR) 51)")]
        public static sbyte* X509_BITS_WITHOUT_TRAILING_ZEROES => ((sbyte*)(51));

        [NativeTypeName("#define X942_OTHER_INFO ((LPCSTR) 52)")]
        public static sbyte* X942_OTHER_INFO => ((sbyte*)(52));

        [NativeTypeName("#define X509_CERT_PAIR ((LPCSTR) 53)")]
        public static sbyte* X509_CERT_PAIR => ((sbyte*)(53));

        [NativeTypeName("#define X509_ISSUING_DIST_POINT ((LPCSTR) 54)")]
        public static sbyte* X509_ISSUING_DIST_POINT => ((sbyte*)(54));

        [NativeTypeName("#define X509_NAME_CONSTRAINTS ((LPCSTR) 55)")]
        public static sbyte* X509_NAME_CONSTRAINTS => ((sbyte*)(55));

        [NativeTypeName("#define X509_POLICY_MAPPINGS ((LPCSTR) 56)")]
        public static sbyte* X509_POLICY_MAPPINGS => ((sbyte*)(56));

        [NativeTypeName("#define X509_POLICY_CONSTRAINTS ((LPCSTR) 57)")]
        public static sbyte* X509_POLICY_CONSTRAINTS => ((sbyte*)(57));

        [NativeTypeName("#define X509_CROSS_CERT_DIST_POINTS ((LPCSTR) 58)")]
        public static sbyte* X509_CROSS_CERT_DIST_POINTS => ((sbyte*)(58));

        [NativeTypeName("#define CMC_DATA ((LPCSTR) 59)")]
        public static sbyte* CMC_DATA => ((sbyte*)(59));

        [NativeTypeName("#define CMC_RESPONSE ((LPCSTR) 60)")]
        public static sbyte* CMC_RESPONSE => ((sbyte*)(60));

        [NativeTypeName("#define CMC_STATUS ((LPCSTR) 61)")]
        public static sbyte* CMC_STATUS => ((sbyte*)(61));

        [NativeTypeName("#define CMC_ADD_EXTENSIONS ((LPCSTR) 62)")]
        public static sbyte* CMC_ADD_EXTENSIONS => ((sbyte*)(62));

        [NativeTypeName("#define CMC_ADD_ATTRIBUTES ((LPCSTR) 63)")]
        public static sbyte* CMC_ADD_ATTRIBUTES => ((sbyte*)(63));

        [NativeTypeName("#define X509_CERTIFICATE_TEMPLATE ((LPCSTR) 64)")]
        public static sbyte* X509_CERTIFICATE_TEMPLATE => ((sbyte*)(64));

        [NativeTypeName("#define OCSP_SIGNED_REQUEST ((LPCSTR) 65)")]
        public static sbyte* OCSP_SIGNED_REQUEST => ((sbyte*)(65));

        [NativeTypeName("#define OCSP_REQUEST ((LPCSTR) 66)")]
        public static sbyte* OCSP_REQUEST => ((sbyte*)(66));

        [NativeTypeName("#define OCSP_RESPONSE ((LPCSTR) 67)")]
        public static sbyte* OCSP_RESPONSE => ((sbyte*)(67));

        [NativeTypeName("#define OCSP_BASIC_SIGNED_RESPONSE ((LPCSTR) 68)")]
        public static sbyte* OCSP_BASIC_SIGNED_RESPONSE => ((sbyte*)(68));

        [NativeTypeName("#define OCSP_BASIC_RESPONSE ((LPCSTR) 69)")]
        public static sbyte* OCSP_BASIC_RESPONSE => ((sbyte*)(69));

        [NativeTypeName("#define X509_LOGOTYPE_EXT ((LPCSTR) 70)")]
        public static sbyte* X509_LOGOTYPE_EXT => ((sbyte*)(70));

        [NativeTypeName("#define X509_BIOMETRIC_EXT ((LPCSTR) 71)")]
        public static sbyte* X509_BIOMETRIC_EXT => ((sbyte*)(71));

        [NativeTypeName("#define CNG_RSA_PUBLIC_KEY_BLOB ((LPCSTR) 72)")]
        public static sbyte* CNG_RSA_PUBLIC_KEY_BLOB => ((sbyte*)(72));

        [NativeTypeName("#define X509_OBJECT_IDENTIFIER ((LPCSTR) 73)")]
        public static sbyte* X509_OBJECT_IDENTIFIER => ((sbyte*)(73));

        [NativeTypeName("#define X509_ALGORITHM_IDENTIFIER ((LPCSTR) 74)")]
        public static sbyte* X509_ALGORITHM_IDENTIFIER => ((sbyte*)(74));

        [NativeTypeName("#define PKCS_RSA_SSA_PSS_PARAMETERS ((LPCSTR) 75)")]
        public static sbyte* PKCS_RSA_SSA_PSS_PARAMETERS => ((sbyte*)(75));

        [NativeTypeName("#define PKCS_RSAES_OAEP_PARAMETERS ((LPCSTR) 76)")]
        public static sbyte* PKCS_RSAES_OAEP_PARAMETERS => ((sbyte*)(76));

        [NativeTypeName("#define ECC_CMS_SHARED_INFO ((LPCSTR) 77)")]
        public static sbyte* ECC_CMS_SHARED_INFO => ((sbyte*)(77));

        [NativeTypeName("#define TIMESTAMP_REQUEST ((LPCSTR) 78)")]
        public static sbyte* TIMESTAMP_REQUEST => ((sbyte*)(78));

        [NativeTypeName("#define TIMESTAMP_RESPONSE ((LPCSTR) 79)")]
        public static sbyte* TIMESTAMP_RESPONSE => ((sbyte*)(79));

        [NativeTypeName("#define TIMESTAMP_INFO ((LPCSTR) 80)")]
        public static sbyte* TIMESTAMP_INFO => ((sbyte*)(80));

        [NativeTypeName("#define X509_CERT_BUNDLE ((LPCSTR) 81)")]
        public static sbyte* X509_CERT_BUNDLE => ((sbyte*)(81));

        [NativeTypeName("#define X509_ECC_PRIVATE_KEY ((LPCSTR) 82)")]
        public static sbyte* X509_ECC_PRIVATE_KEY => ((sbyte*)(82));

        [NativeTypeName("#define CNG_RSA_PRIVATE_KEY_BLOB ((LPCSTR) 83)")]
        public static sbyte* CNG_RSA_PRIVATE_KEY_BLOB => ((sbyte*)(83));

        [NativeTypeName("#define X509_SUBJECT_DIR_ATTRS ((LPCSTR) 84)")]
        public static sbyte* X509_SUBJECT_DIR_ATTRS => ((sbyte*)(84));

        [NativeTypeName("#define X509_ECC_PARAMETERS ((LPCSTR) 85)")]
        public static sbyte* X509_ECC_PARAMETERS => ((sbyte*)(85));

        [NativeTypeName("#define PKCS7_SIGNER_INFO ((LPCSTR) 500)")]
        public static sbyte* PKCS7_SIGNER_INFO => ((sbyte*)(500));

        [NativeTypeName("#define CMS_SIGNER_INFO ((LPCSTR) 501)")]
        public static sbyte* CMS_SIGNER_INFO => ((sbyte*)(501));

        [NativeTypeName("#define szOID_AUTHORITY_KEY_IDENTIFIER \"2.5.29.1\"")]
        public static ReadOnlySpan<byte> szOID_AUTHORITY_KEY_IDENTIFIER => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_KEY_ATTRIBUTES \"2.5.29.2\"")]
        public static ReadOnlySpan<byte> szOID_KEY_ATTRIBUTES => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_CERT_POLICIES_95 \"2.5.29.3\"")]
        public static ReadOnlySpan<byte> szOID_CERT_POLICIES_95 => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_KEY_USAGE_RESTRICTION \"2.5.29.4\"")]
        public static ReadOnlySpan<byte> szOID_KEY_USAGE_RESTRICTION => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_SUBJECT_ALT_NAME \"2.5.29.7\"")]
        public static ReadOnlySpan<byte> szOID_SUBJECT_ALT_NAME => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_ISSUER_ALT_NAME \"2.5.29.8\"")]
        public static ReadOnlySpan<byte> szOID_ISSUER_ALT_NAME => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x38, 0x00 };

        [NativeTypeName("#define szOID_BASIC_CONSTRAINTS \"2.5.29.10\"")]
        public static ReadOnlySpan<byte> szOID_BASIC_CONSTRAINTS => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x30, 0x00 };

        [NativeTypeName("#define szOID_KEY_USAGE \"2.5.29.15\"")]
        public static ReadOnlySpan<byte> szOID_KEY_USAGE => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x35, 0x00 };

        [NativeTypeName("#define szOID_PRIVATEKEY_USAGE_PERIOD \"2.5.29.16\"")]
        public static ReadOnlySpan<byte> szOID_PRIVATEKEY_USAGE_PERIOD => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x36, 0x00 };

        [NativeTypeName("#define szOID_BASIC_CONSTRAINTS2 \"2.5.29.19\"")]
        public static ReadOnlySpan<byte> szOID_BASIC_CONSTRAINTS2 => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x39, 0x00 };

        [NativeTypeName("#define szOID_CERT_POLICIES \"2.5.29.32\"")]
        public static ReadOnlySpan<byte> szOID_CERT_POLICIES => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define szOID_ANY_CERT_POLICY \"2.5.29.32.0\"")]
        public static ReadOnlySpan<byte> szOID_ANY_CERT_POLICY => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x32, 0x2E, 0x30, 0x00 };

        [NativeTypeName("#define szOID_INHIBIT_ANY_POLICY \"2.5.29.54\"")]
        public static ReadOnlySpan<byte> szOID_INHIBIT_ANY_POLICY => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x35, 0x34, 0x00 };

        [NativeTypeName("#define szOID_AUTHORITY_KEY_IDENTIFIER2 \"2.5.29.35\"")]
        public static ReadOnlySpan<byte> szOID_AUTHORITY_KEY_IDENTIFIER2 => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x35, 0x00 };

        [NativeTypeName("#define szOID_SUBJECT_KEY_IDENTIFIER \"2.5.29.14\"")]
        public static ReadOnlySpan<byte> szOID_SUBJECT_KEY_IDENTIFIER => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x34, 0x00 };

        [NativeTypeName("#define szOID_SUBJECT_ALT_NAME2 \"2.5.29.17\"")]
        public static ReadOnlySpan<byte> szOID_SUBJECT_ALT_NAME2 => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x37, 0x00 };

        [NativeTypeName("#define szOID_ISSUER_ALT_NAME2 \"2.5.29.18\"")]
        public static ReadOnlySpan<byte> szOID_ISSUER_ALT_NAME2 => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x31, 0x38, 0x00 };

        [NativeTypeName("#define szOID_CRL_REASON_CODE \"2.5.29.21\"")]
        public static ReadOnlySpan<byte> szOID_CRL_REASON_CODE => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x32, 0x31, 0x00 };

        [NativeTypeName("#define szOID_REASON_CODE_HOLD \"2.5.29.23\"")]
        public static ReadOnlySpan<byte> szOID_REASON_CODE_HOLD => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x32, 0x33, 0x00 };

        [NativeTypeName("#define szOID_CRL_DIST_POINTS \"2.5.29.31\"")]
        public static ReadOnlySpan<byte> szOID_CRL_DIST_POINTS => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ENHANCED_KEY_USAGE \"2.5.29.37\"")]
        public static ReadOnlySpan<byte> szOID_ENHANCED_KEY_USAGE => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x37, 0x00 };

        [NativeTypeName("#define szOID_ANY_ENHANCED_KEY_USAGE \"2.5.29.37.0\"")]
        public static ReadOnlySpan<byte> szOID_ANY_ENHANCED_KEY_USAGE => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x37, 0x2E, 0x30, 0x00 };

        [NativeTypeName("#define szOID_CRL_NUMBER \"2.5.29.20\"")]
        public static ReadOnlySpan<byte> szOID_CRL_NUMBER => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x32, 0x30, 0x00 };

        [NativeTypeName("#define szOID_DELTA_CRL_INDICATOR \"2.5.29.27\"")]
        public static ReadOnlySpan<byte> szOID_DELTA_CRL_INDICATOR => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x32, 0x37, 0x00 };

        [NativeTypeName("#define szOID_ISSUING_DIST_POINT \"2.5.29.28\"")]
        public static ReadOnlySpan<byte> szOID_ISSUING_DIST_POINT => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x32, 0x38, 0x00 };

        [NativeTypeName("#define szOID_FRESHEST_CRL \"2.5.29.46\"")]
        public static ReadOnlySpan<byte> szOID_FRESHEST_CRL => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x34, 0x36, 0x00 };

        [NativeTypeName("#define szOID_NAME_CONSTRAINTS \"2.5.29.30\"")]
        public static ReadOnlySpan<byte> szOID_NAME_CONSTRAINTS => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x30, 0x00 };

        [NativeTypeName("#define szOID_POLICY_MAPPINGS \"2.5.29.33\"")]
        public static ReadOnlySpan<byte> szOID_POLICY_MAPPINGS => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x33, 0x00 };

        [NativeTypeName("#define szOID_LEGACY_POLICY_MAPPINGS \"2.5.29.5\"")]
        public static ReadOnlySpan<byte> szOID_LEGACY_POLICY_MAPPINGS => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_POLICY_CONSTRAINTS \"2.5.29.36\"")]
        public static ReadOnlySpan<byte> szOID_POLICY_CONSTRAINTS => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x33, 0x36, 0x00 };

        [NativeTypeName("#define szOID_RENEWAL_CERTIFICATE \"1.3.6.1.4.1.311.13.1\"")]
        public static ReadOnlySpan<byte> szOID_RENEWAL_CERTIFICATE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x33, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ENROLLMENT_NAME_VALUE_PAIR \"1.3.6.1.4.1.311.13.2.1\"")]
        public static ReadOnlySpan<byte> szOID_ENROLLMENT_NAME_VALUE_PAIR => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ENROLLMENT_CSP_PROVIDER \"1.3.6.1.4.1.311.13.2.2\"")]
        public static ReadOnlySpan<byte> szOID_ENROLLMENT_CSP_PROVIDER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_OS_VERSION \"1.3.6.1.4.1.311.13.2.3\"")]
        public static ReadOnlySpan<byte> szOID_OS_VERSION => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x33, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_ENROLLMENT_AGENT \"1.3.6.1.4.1.311.20.2.1\"")]
        public static ReadOnlySpan<byte> szOID_ENROLLMENT_AGENT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_PKIX \"1.3.6.1.5.5.7\"")]
        public static ReadOnlySpan<byte> szOID_PKIX => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_PKIX_PE \"1.3.6.1.5.5.7.1\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_PE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_AUTHORITY_INFO_ACCESS \"1.3.6.1.5.5.7.1.1\"")]
        public static ReadOnlySpan<byte> szOID_AUTHORITY_INFO_ACCESS => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_SUBJECT_INFO_ACCESS \"1.3.6.1.5.5.7.1.11\"")]
        public static ReadOnlySpan<byte> szOID_SUBJECT_INFO_ACCESS => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x00 };

        [NativeTypeName("#define szOID_BIOMETRIC_EXT \"1.3.6.1.5.5.7.1.2\"")]
        public static ReadOnlySpan<byte> szOID_BIOMETRIC_EXT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_QC_STATEMENTS_EXT \"1.3.6.1.5.5.7.1.3\"")]
        public static ReadOnlySpan<byte> szOID_QC_STATEMENTS_EXT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_LOGOTYPE_EXT \"1.3.6.1.5.5.7.1.12\"")]
        public static ReadOnlySpan<byte> szOID_LOGOTYPE_EXT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        [NativeTypeName("#define szOID_TLS_FEATURES_EXT \"1.3.6.1.5.5.7.1.24\"")]
        public static ReadOnlySpan<byte> szOID_TLS_FEATURES_EXT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x2E, 0x32, 0x34, 0x00 };

        [NativeTypeName("#define szOID_CERT_EXTENSIONS \"1.3.6.1.4.1.311.2.1.14\"")]
        public static ReadOnlySpan<byte> szOID_CERT_EXTENSIONS => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x34, 0x00 };

        [NativeTypeName("#define szOID_NEXT_UPDATE_LOCATION \"1.3.6.1.4.1.311.10.2\"")]
        public static ReadOnlySpan<byte> szOID_NEXT_UPDATE_LOCATION => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_REMOVE_CERTIFICATE \"1.3.6.1.4.1.311.10.8.1\"")]
        public static ReadOnlySpan<byte> szOID_REMOVE_CERTIFICATE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x38, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_CROSS_CERT_DIST_POINTS \"1.3.6.1.4.1.311.10.9.1\"")]
        public static ReadOnlySpan<byte> szOID_CROSS_CERT_DIST_POINTS => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x39, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_CTL \"1.3.6.1.4.1.311.10.1\"")]
        public static ReadOnlySpan<byte> szOID_CTL => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_SORTED_CTL \"1.3.6.1.4.1.311.10.1.1\"")]
        public static ReadOnlySpan<byte> szOID_SORTED_CTL => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_SERIALIZED \"1.3.6.1.4.1.311.10.3.3.1\"")]
        public static ReadOnlySpan<byte> szOID_SERIALIZED => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_NT_PRINCIPAL_NAME \"1.3.6.1.4.1.311.20.2.3\"")]
        public static ReadOnlySpan<byte> szOID_NT_PRINCIPAL_NAME => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_INTERNATIONALIZED_EMAIL_ADDRESS \"1.3.6.1.4.1.311.20.2.4\"")]
        public static ReadOnlySpan<byte> szOID_INTERNATIONALIZED_EMAIL_ADDRESS => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x2E, 0x32, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_PRODUCT_UPDATE \"1.3.6.1.4.1.311.31.1\"")]
        public static ReadOnlySpan<byte> szOID_PRODUCT_UPDATE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x33, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ANY_APPLICATION_POLICY \"1.3.6.1.4.1.311.10.12.1\"")]
        public static ReadOnlySpan<byte> szOID_ANY_APPLICATION_POLICY => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_AUTO_ENROLL_CTL_USAGE \"1.3.6.1.4.1.311.20.1\"")]
        public static ReadOnlySpan<byte> szOID_AUTO_ENROLL_CTL_USAGE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_CERTTYPE_EXTENSION \"1.3.6.1.4.1.311.20.2\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_CERTTYPE_EXTENSION => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_CERT_MANIFOLD \"1.3.6.1.4.1.311.20.3\"")]
        public static ReadOnlySpan<byte> szOID_CERT_MANIFOLD => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_CERTSRV_CA_VERSION \"1.3.6.1.4.1.311.21.1\"")]
        public static ReadOnlySpan<byte> szOID_CERTSRV_CA_VERSION => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_CERTSRV_PREVIOUS_CERT_HASH \"1.3.6.1.4.1.311.21.2\"")]
        public static ReadOnlySpan<byte> szOID_CERTSRV_PREVIOUS_CERT_HASH => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_CRL_VIRTUAL_BASE \"1.3.6.1.4.1.311.21.3\"")]
        public static ReadOnlySpan<byte> szOID_CRL_VIRTUAL_BASE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_CRL_NEXT_PUBLISH \"1.3.6.1.4.1.311.21.4\"")]
        public static ReadOnlySpan<byte> szOID_CRL_NEXT_PUBLISH => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_KP_CA_EXCHANGE \"1.3.6.1.4.1.311.21.5\"")]
        public static ReadOnlySpan<byte> szOID_KP_CA_EXCHANGE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_KP_PRIVACY_CA \"1.3.6.1.4.1.311.21.36\"")]
        public static ReadOnlySpan<byte> szOID_KP_PRIVACY_CA => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x36, 0x00 };

        [NativeTypeName("#define szOID_KP_KEY_RECOVERY_AGENT \"1.3.6.1.4.1.311.21.6\"")]
        public static ReadOnlySpan<byte> szOID_KP_KEY_RECOVERY_AGENT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_CERTIFICATE_TEMPLATE \"1.3.6.1.4.1.311.21.7\"")]
        public static ReadOnlySpan<byte> szOID_CERTIFICATE_TEMPLATE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_ENTERPRISE_OID_ROOT \"1.3.6.1.4.1.311.21.8\"")]
        public static ReadOnlySpan<byte> szOID_ENTERPRISE_OID_ROOT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x38, 0x00 };

        [NativeTypeName("#define szOID_RDN_DUMMY_SIGNER \"1.3.6.1.4.1.311.21.9\"")]
        public static ReadOnlySpan<byte> szOID_RDN_DUMMY_SIGNER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_APPLICATION_CERT_POLICIES \"1.3.6.1.4.1.311.21.10\"")]
        public static ReadOnlySpan<byte> szOID_APPLICATION_CERT_POLICIES => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x30, 0x00 };

        [NativeTypeName("#define szOID_APPLICATION_POLICY_MAPPINGS \"1.3.6.1.4.1.311.21.11\"")]
        public static ReadOnlySpan<byte> szOID_APPLICATION_POLICY_MAPPINGS => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x31, 0x00 };

        [NativeTypeName("#define szOID_APPLICATION_POLICY_CONSTRAINTS \"1.3.6.1.4.1.311.21.12\"")]
        public static ReadOnlySpan<byte> szOID_APPLICATION_POLICY_CONSTRAINTS => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        [NativeTypeName("#define szOID_ARCHIVED_KEY_ATTR \"1.3.6.1.4.1.311.21.13\"")]
        public static ReadOnlySpan<byte> szOID_ARCHIVED_KEY_ATTR => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x33, 0x00 };

        [NativeTypeName("#define szOID_CRL_SELF_CDP \"1.3.6.1.4.1.311.21.14\"")]
        public static ReadOnlySpan<byte> szOID_CRL_SELF_CDP => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x34, 0x00 };

        [NativeTypeName("#define szOID_REQUIRE_CERT_CHAIN_POLICY \"1.3.6.1.4.1.311.21.15\"")]
        public static ReadOnlySpan<byte> szOID_REQUIRE_CERT_CHAIN_POLICY => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x35, 0x00 };

        [NativeTypeName("#define szOID_ARCHIVED_KEY_CERT_HASH \"1.3.6.1.4.1.311.21.16\"")]
        public static ReadOnlySpan<byte> szOID_ARCHIVED_KEY_CERT_HASH => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x36, 0x00 };

        [NativeTypeName("#define szOID_ISSUED_CERT_HASH \"1.3.6.1.4.1.311.21.17\"")]
        public static ReadOnlySpan<byte> szOID_ISSUED_CERT_HASH => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x37, 0x00 };

        [NativeTypeName("#define szOID_DS_EMAIL_REPLICATION \"1.3.6.1.4.1.311.21.19\"")]
        public static ReadOnlySpan<byte> szOID_DS_EMAIL_REPLICATION => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x31, 0x39, 0x00 };

        [NativeTypeName("#define szOID_REQUEST_CLIENT_INFO \"1.3.6.1.4.1.311.21.20\"")]
        public static ReadOnlySpan<byte> szOID_REQUEST_CLIENT_INFO => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x30, 0x00 };

        [NativeTypeName("#define szOID_ENCRYPTED_KEY_HASH \"1.3.6.1.4.1.311.21.21\"")]
        public static ReadOnlySpan<byte> szOID_ENCRYPTED_KEY_HASH => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x31, 0x00 };

        [NativeTypeName("#define szOID_CERTSRV_CROSSCA_VERSION \"1.3.6.1.4.1.311.21.22\"")]
        public static ReadOnlySpan<byte> szOID_CERTSRV_CROSSCA_VERSION => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x32, 0x00 };

        [NativeTypeName("#define szOID_NTDS_REPLICATION \"1.3.6.1.4.1.311.25.1\"")]
        public static ReadOnlySpan<byte> szOID_NTDS_REPLICATION => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x35, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_SUBJECT_DIR_ATTRS \"2.5.29.9\"")]
        public static ReadOnlySpan<byte> szOID_SUBJECT_DIR_ATTRS => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x32, 0x39, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_PKIX_KP \"1.3.6.1.5.5.7.3\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_KP => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_PKIX_KP_SERVER_AUTH \"1.3.6.1.5.5.7.3.1\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_KP_SERVER_AUTH => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_PKIX_KP_CLIENT_AUTH \"1.3.6.1.5.5.7.3.2\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_KP_CLIENT_AUTH => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_PKIX_KP_CODE_SIGNING \"1.3.6.1.5.5.7.3.3\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_KP_CODE_SIGNING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_PKIX_KP_EMAIL_PROTECTION \"1.3.6.1.5.5.7.3.4\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_KP_EMAIL_PROTECTION => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_PKIX_KP_IPSEC_END_SYSTEM \"1.3.6.1.5.5.7.3.5\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_KP_IPSEC_END_SYSTEM => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_PKIX_KP_IPSEC_TUNNEL \"1.3.6.1.5.5.7.3.6\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_KP_IPSEC_TUNNEL => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_PKIX_KP_IPSEC_USER \"1.3.6.1.5.5.7.3.7\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_KP_IPSEC_USER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_PKIX_KP_TIMESTAMP_SIGNING \"1.3.6.1.5.5.7.3.8\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_KP_TIMESTAMP_SIGNING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x38, 0x00 };

        [NativeTypeName("#define szOID_PKIX_KP_OCSP_SIGNING \"1.3.6.1.5.5.7.3.9\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_KP_OCSP_SIGNING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_PKIX_OCSP_NOCHECK \"1.3.6.1.5.5.7.48.1.5\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_OCSP_NOCHECK => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_PKIX_OCSP_NONCE \"1.3.6.1.5.5.7.48.1.2\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_OCSP_NONCE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_IPSEC_KP_IKE_INTERMEDIATE \"1.3.6.1.5.5.8.2.2\"")]
        public static ReadOnlySpan<byte> szOID_IPSEC_KP_IKE_INTERMEDIATE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x38, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_PKINIT_KP_KDC \"1.3.6.1.5.2.3.5\"")]
        public static ReadOnlySpan<byte> szOID_PKINIT_KP_KDC => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x32, 0x2E, 0x33, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_KP_CTL_USAGE_SIGNING \"1.3.6.1.4.1.311.10.3.1\"")]
        public static ReadOnlySpan<byte> szOID_KP_CTL_USAGE_SIGNING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_KP_TIME_STAMP_SIGNING \"1.3.6.1.4.1.311.10.3.2\"")]
        public static ReadOnlySpan<byte> szOID_KP_TIME_STAMP_SIGNING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_SERVER_GATED_CRYPTO \"1.3.6.1.4.1.311.10.3.3\"")]
        public static ReadOnlySpan<byte> szOID_SERVER_GATED_CRYPTO => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_SGC_NETSCAPE \"2.16.840.1.113730.4.1\"")]
        public static ReadOnlySpan<byte> szOID_SGC_NETSCAPE => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x34, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_KP_EFS \"1.3.6.1.4.1.311.10.3.4\"")]
        public static ReadOnlySpan<byte> szOID_KP_EFS => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_EFS_RECOVERY \"1.3.6.1.4.1.311.10.3.4.1\"")]
        public static ReadOnlySpan<byte> szOID_EFS_RECOVERY => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x34, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_WHQL_CRYPTO \"1.3.6.1.4.1.311.10.3.5\"")]
        public static ReadOnlySpan<byte> szOID_WHQL_CRYPTO => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_ATTEST_WHQL_CRYPTO \"1.3.6.1.4.1.311.10.3.5.1\"")]
        public static ReadOnlySpan<byte> szOID_ATTEST_WHQL_CRYPTO => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x35, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_NT5_CRYPTO \"1.3.6.1.4.1.311.10.3.6\"")]
        public static ReadOnlySpan<byte> szOID_NT5_CRYPTO => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_OEM_WHQL_CRYPTO \"1.3.6.1.4.1.311.10.3.7\"")]
        public static ReadOnlySpan<byte> szOID_OEM_WHQL_CRYPTO => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_EMBEDDED_NT_CRYPTO \"1.3.6.1.4.1.311.10.3.8\"")]
        public static ReadOnlySpan<byte> szOID_EMBEDDED_NT_CRYPTO => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x38, 0x00 };

        [NativeTypeName("#define szOID_ROOT_LIST_SIGNER \"1.3.6.1.4.1.311.10.3.9\"")]
        public static ReadOnlySpan<byte> szOID_ROOT_LIST_SIGNER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_KP_QUALIFIED_SUBORDINATION \"1.3.6.1.4.1.311.10.3.10\"")]
        public static ReadOnlySpan<byte> szOID_KP_QUALIFIED_SUBORDINATION => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x30, 0x00 };

        [NativeTypeName("#define szOID_KP_KEY_RECOVERY \"1.3.6.1.4.1.311.10.3.11\"")]
        public static ReadOnlySpan<byte> szOID_KP_KEY_RECOVERY => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x31, 0x00 };

        [NativeTypeName("#define szOID_KP_DOCUMENT_SIGNING \"1.3.6.1.4.1.311.10.3.12\"")]
        public static ReadOnlySpan<byte> szOID_KP_DOCUMENT_SIGNING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x32, 0x00 };

        [NativeTypeName("#define szOID_KP_LIFETIME_SIGNING \"1.3.6.1.4.1.311.10.3.13\"")]
        public static ReadOnlySpan<byte> szOID_KP_LIFETIME_SIGNING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x33, 0x00 };

        [NativeTypeName("#define szOID_KP_MOBILE_DEVICE_SOFTWARE \"1.3.6.1.4.1.311.10.3.14\"")]
        public static ReadOnlySpan<byte> szOID_KP_MOBILE_DEVICE_SOFTWARE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x34, 0x00 };

        [NativeTypeName("#define szOID_KP_SMART_DISPLAY \"1.3.6.1.4.1.311.10.3.15\"")]
        public static ReadOnlySpan<byte> szOID_KP_SMART_DISPLAY => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x35, 0x00 };

        [NativeTypeName("#define szOID_KP_CSP_SIGNATURE \"1.3.6.1.4.1.311.10.3.16\"")]
        public static ReadOnlySpan<byte> szOID_KP_CSP_SIGNATURE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x36, 0x00 };

        [NativeTypeName("#define szOID_KP_FLIGHT_SIGNING \"1.3.6.1.4.1.311.10.3.27\"")]
        public static ReadOnlySpan<byte> szOID_KP_FLIGHT_SIGNING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x37, 0x00 };

        [NativeTypeName("#define szOID_PLATFORM_MANIFEST_BINARY_ID \"1.3.6.1.4.1.311.10.3.28\"")]
        public static ReadOnlySpan<byte> szOID_PLATFORM_MANIFEST_BINARY_ID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x38, 0x00 };

        [NativeTypeName("#define szOID_DRM \"1.3.6.1.4.1.311.10.5.1\"")]
        public static ReadOnlySpan<byte> szOID_DRM => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x35, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_DRM_INDIVIDUALIZATION \"1.3.6.1.4.1.311.10.5.2\"")]
        public static ReadOnlySpan<byte> szOID_DRM_INDIVIDUALIZATION => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x35, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_LICENSES \"1.3.6.1.4.1.311.10.6.1\"")]
        public static ReadOnlySpan<byte> szOID_LICENSES => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x36, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_LICENSE_SERVER \"1.3.6.1.4.1.311.10.6.2\"")]
        public static ReadOnlySpan<byte> szOID_LICENSE_SERVER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x36, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_KP_SMARTCARD_LOGON \"1.3.6.1.4.1.311.20.2.2\"")]
        public static ReadOnlySpan<byte> szOID_KP_SMARTCARD_LOGON => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_KP_KERNEL_MODE_CODE_SIGNING \"1.3.6.1.4.1.311.61.1.1\"")]
        public static ReadOnlySpan<byte> szOID_KP_KERNEL_MODE_CODE_SIGNING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x31, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_KP_KERNEL_MODE_TRUSTED_BOOT_SIGNING \"1.3.6.1.4.1.311.61.4.1\"")]
        public static ReadOnlySpan<byte> szOID_KP_KERNEL_MODE_TRUSTED_BOOT_SIGNING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_REVOKED_LIST_SIGNER \"1.3.6.1.4.1.311.10.3.19\"")]
        public static ReadOnlySpan<byte> szOID_REVOKED_LIST_SIGNER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x39, 0x00 };

        [NativeTypeName("#define szOID_WINDOWS_KITS_SIGNER \"1.3.6.1.4.1.311.10.3.20\"")]
        public static ReadOnlySpan<byte> szOID_WINDOWS_KITS_SIGNER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x30, 0x00 };

        [NativeTypeName("#define szOID_WINDOWS_RT_SIGNER \"1.3.6.1.4.1.311.10.3.21\"")]
        public static ReadOnlySpan<byte> szOID_WINDOWS_RT_SIGNER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x31, 0x00 };

        [NativeTypeName("#define szOID_PROTECTED_PROCESS_LIGHT_SIGNER \"1.3.6.1.4.1.311.10.3.22\"")]
        public static ReadOnlySpan<byte> szOID_PROTECTED_PROCESS_LIGHT_SIGNER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x32, 0x00 };

        [NativeTypeName("#define szOID_WINDOWS_TCB_SIGNER \"1.3.6.1.4.1.311.10.3.23\"")]
        public static ReadOnlySpan<byte> szOID_WINDOWS_TCB_SIGNER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x33, 0x00 };

        [NativeTypeName("#define szOID_PROTECTED_PROCESS_SIGNER \"1.3.6.1.4.1.311.10.3.24\"")]
        public static ReadOnlySpan<byte> szOID_PROTECTED_PROCESS_SIGNER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x34, 0x00 };

        [NativeTypeName("#define szOID_WINDOWS_THIRD_PARTY_COMPONENT_SIGNER \"1.3.6.1.4.1.311.10.3.25\"")]
        public static ReadOnlySpan<byte> szOID_WINDOWS_THIRD_PARTY_COMPONENT_SIGNER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x35, 0x00 };

        [NativeTypeName("#define szOID_WINDOWS_SOFTWARE_EXTENSION_SIGNER \"1.3.6.1.4.1.311.10.3.26\"")]
        public static ReadOnlySpan<byte> szOID_WINDOWS_SOFTWARE_EXTENSION_SIGNER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x36, 0x00 };

        [NativeTypeName("#define szOID_DISALLOWED_LIST \"1.3.6.1.4.1.311.10.3.30\"")]
        public static ReadOnlySpan<byte> szOID_DISALLOWED_LIST => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x30, 0x00 };

        [NativeTypeName("#define szOID_PIN_RULES_SIGNER \"1.3.6.1.4.1.311.10.3.31\"")]
        public static ReadOnlySpan<byte> szOID_PIN_RULES_SIGNER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x31, 0x00 };

        [NativeTypeName("#define szOID_PIN_RULES_CTL \"1.3.6.1.4.1.311.10.3.32\"")]
        public static ReadOnlySpan<byte> szOID_PIN_RULES_CTL => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define szOID_PIN_RULES_EXT \"1.3.6.1.4.1.311.10.3.33\"")]
        public static ReadOnlySpan<byte> szOID_PIN_RULES_EXT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x33, 0x00 };

        [NativeTypeName("#define szOID_PIN_RULES_DOMAIN_NAME \"1.3.6.1.4.1.311.10.3.34\"")]
        public static ReadOnlySpan<byte> szOID_PIN_RULES_DOMAIN_NAME => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x34, 0x00 };

        [NativeTypeName("#define szOID_PIN_RULES_LOG_END_DATE_EXT \"1.3.6.1.4.1.311.10.3.35\"")]
        public static ReadOnlySpan<byte> szOID_PIN_RULES_LOG_END_DATE_EXT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x35, 0x00 };

        [NativeTypeName("#define szOID_IUM_SIGNING \"1.3.6.1.4.1.311.10.3.37\"")]
        public static ReadOnlySpan<byte> szOID_IUM_SIGNING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x37, 0x00 };

        [NativeTypeName("#define szOID_EV_WHQL_CRYPTO \"1.3.6.1.4.1.311.10.3.39\"")]
        public static ReadOnlySpan<byte> szOID_EV_WHQL_CRYPTO => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x39, 0x00 };

        [NativeTypeName("#define szOID_BIOMETRIC_SIGNING \"1.3.6.1.4.1.311.10.3.41\"")]
        public static ReadOnlySpan<byte> szOID_BIOMETRIC_SIGNING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x34, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ENCLAVE_SIGNING \"1.3.6.1.4.1.311.10.3.42\"")]
        public static ReadOnlySpan<byte> szOID_ENCLAVE_SIGNING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x34, 0x32, 0x00 };

        [NativeTypeName("#define szOID_SYNC_ROOT_CTL_EXT \"1.3.6.1.4.1.311.10.3.50\"")]
        public static ReadOnlySpan<byte> szOID_SYNC_ROOT_CTL_EXT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x35, 0x30, 0x00 };

        [NativeTypeName("#define szOID_HPKP_DOMAIN_NAME_CTL \"1.3.6.1.4.1.311.10.3.60\"")]
        public static ReadOnlySpan<byte> szOID_HPKP_DOMAIN_NAME_CTL => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x36, 0x30, 0x00 };

        [NativeTypeName("#define szOID_HPKP_HEADER_VALUE_CTL \"1.3.6.1.4.1.311.10.3.61\"")]
        public static ReadOnlySpan<byte> szOID_HPKP_HEADER_VALUE_CTL => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x36, 0x31, 0x00 };

        [NativeTypeName("#define szOID_KP_KERNEL_MODE_HAL_EXTENSION_SIGNING \"1.3.6.1.4.1.311.61.5.1\"")]
        public static ReadOnlySpan<byte> szOID_KP_KERNEL_MODE_HAL_EXTENSION_SIGNING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x31, 0x2E, 0x35, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_WINDOWS_STORE_SIGNER \"1.3.6.1.4.1.311.76.3.1\"")]
        public static ReadOnlySpan<byte> szOID_WINDOWS_STORE_SIGNER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x36, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_DYNAMIC_CODE_GEN_SIGNER \"1.3.6.1.4.1.311.76.5.1\"")]
        public static ReadOnlySpan<byte> szOID_DYNAMIC_CODE_GEN_SIGNER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x36, 0x2E, 0x35, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_MICROSOFT_PUBLISHER_SIGNER \"1.3.6.1.4.1.311.76.8.1\"")]
        public static ReadOnlySpan<byte> szOID_MICROSOFT_PUBLISHER_SIGNER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x36, 0x2E, 0x38, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_YESNO_TRUST_ATTR \"1.3.6.1.4.1.311.10.4.1\"")]
        public static ReadOnlySpan<byte> szOID_YESNO_TRUST_ATTR => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x34, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_SITE_PIN_RULES_INDEX_ATTR \"1.3.6.1.4.1.311.10.4.2\"")]
        public static ReadOnlySpan<byte> szOID_SITE_PIN_RULES_INDEX_ATTR => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x34, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_SITE_PIN_RULES_FLAGS_ATTR \"1.3.6.1.4.1.311.10.4.3\"")]
        public static ReadOnlySpan<byte> szOID_SITE_PIN_RULES_FLAGS_ATTR => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x34, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define SITE_PIN_RULES_ALL_SUBDOMAINS_FLAG 0x1")]
        public const int SITE_PIN_RULES_ALL_SUBDOMAINS_FLAG = 0x1;

        [NativeTypeName("#define szOID_PKIX_POLICY_QUALIFIER_CPS \"1.3.6.1.5.5.7.2.1\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_POLICY_QUALIFIER_CPS => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_PKIX_POLICY_QUALIFIER_USERNOTICE \"1.3.6.1.5.5.7.2.2\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_POLICY_QUALIFIER_USERNOTICE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_ROOT_PROGRAM_FLAGS \"1.3.6.1.4.1.311.60.1.1\"")]
        public static ReadOnlySpan<byte> szOID_ROOT_PROGRAM_FLAGS => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define CERT_ROOT_PROGRAM_FLAG_ORG 0x80")]
        public const int CERT_ROOT_PROGRAM_FLAG_ORG = 0x80;

        [NativeTypeName("#define CERT_ROOT_PROGRAM_FLAG_LSC 0x40")]
        public const int CERT_ROOT_PROGRAM_FLAG_LSC = 0x40;

        [NativeTypeName("#define CERT_ROOT_PROGRAM_FLAG_SUBJECT_LOGO 0x20")]
        public const int CERT_ROOT_PROGRAM_FLAG_SUBJECT_LOGO = 0x20;

        [NativeTypeName("#define CERT_ROOT_PROGRAM_FLAG_OU 0x10")]
        public const int CERT_ROOT_PROGRAM_FLAG_OU = 0x10;

        [NativeTypeName("#define CERT_ROOT_PROGRAM_FLAG_ADDRESS 0x08")]
        public const int CERT_ROOT_PROGRAM_FLAG_ADDRESS = 0x08;

        [NativeTypeName("#define szOID_CERT_POLICIES_95_QUALIFIER1 \"2.16.840.1.113733.1.7.1.1\"")]
        public static ReadOnlySpan<byte> szOID_CERT_POLICIES_95_QUALIFIER1 => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_RDN_TPM_MANUFACTURER \"2.23.133.2.1\"")]
        public static ReadOnlySpan<byte> szOID_RDN_TPM_MANUFACTURER => new byte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_RDN_TPM_MODEL \"2.23.133.2.2\"")]
        public static ReadOnlySpan<byte> szOID_RDN_TPM_MODEL => new byte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_RDN_TPM_VERSION \"2.23.133.2.3\"")]
        public static ReadOnlySpan<byte> szOID_RDN_TPM_VERSION => new byte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_RDN_TCG_PLATFORM_MANUFACTURER \"2.23.133.2.4\"")]
        public static ReadOnlySpan<byte> szOID_RDN_TCG_PLATFORM_MANUFACTURER => new byte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_RDN_TCG_PLATFORM_MODEL \"2.23.133.2.5\"")]
        public static ReadOnlySpan<byte> szOID_RDN_TCG_PLATFORM_MODEL => new byte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_RDN_TCG_PLATFORM_VERSION \"2.23.133.2.6\"")]
        public static ReadOnlySpan<byte> szOID_RDN_TCG_PLATFORM_VERSION => new byte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_CT_CERT_SCTLIST \"1.3.6.1.4.1.11129.2.4.2\"")]
        public static ReadOnlySpan<byte> szOID_CT_CERT_SCTLIST => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x31, 0x32, 0x39, 0x2E, 0x32, 0x2E, 0x34, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_EK_INFO \"1.3.6.1.4.1.311.21.23\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_EK_INFO => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x33, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_AIK_INFO \"1.3.6.1.4.1.311.21.39\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_AIK_INFO => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x39, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_ATTESTATION_STATEMENT \"1.3.6.1.4.1.311.21.24\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_ATTESTATION_STATEMENT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x34, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_KSP_NAME \"1.3.6.1.4.1.311.21.25\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_KSP_NAME => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x35, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_EKPUB_CHALLENGE \"1.3.6.1.4.1.311.21.26\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_EKPUB_CHALLENGE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x36, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_CAXCHGCERT_HASH \"1.3.6.1.4.1.311.21.27\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_CAXCHGCERT_HASH => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x37, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_ATTESTATION_CHALLENGE \"1.3.6.1.4.1.311.21.28\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_ATTESTATION_CHALLENGE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x38, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_ENCRYPTION_ALGORITHM \"1.3.6.1.4.1.311.21.29\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_ENCRYPTION_ALGORITHM => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x32, 0x39, 0x00 };

        [NativeTypeName("#define szOID_KP_TPM_EK_CERTIFICATE \"2.23.133.8.1\"")]
        public static ReadOnlySpan<byte> szOID_KP_TPM_EK_CERTIFICATE => new byte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x38, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_KP_TPM_PLATFORM_CERTIFICATE \"2.23.133.8.2\"")]
        public static ReadOnlySpan<byte> szOID_KP_TPM_PLATFORM_CERTIFICATE => new byte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x38, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_KP_TPM_AIK_CERTIFICATE \"2.23.133.8.3\"")]
        public static ReadOnlySpan<byte> szOID_KP_TPM_AIK_CERTIFICATE => new byte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x38, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_EKVERIFYKEY \"1.3.6.1.4.1.311.21.30\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_EKVERIFYKEY => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x30, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_EKVERIFYCERT \"1.3.6.1.4.1.311.21.31\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_EKVERIFYCERT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_EKVERIFYCREDS \"1.3.6.1.4.1.311.21.32\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_EKVERIFYCREDS => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_SCEP_ERROR \"1.3.6.1.4.1.311.21.33\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_SCEP_ERROR => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x33, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_SCEP_SERVER_STATE \"1.3.6.1.4.1.311.21.34\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_SCEP_SERVER_STATE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x34, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_SCEP_CHALLENGE_ANSWER \"1.3.6.1.4.1.311.21.35\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_SCEP_CHALLENGE_ANSWER => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x35, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_SCEP_CLIENT_REQUEST \"1.3.6.1.4.1.311.21.37\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_SCEP_CLIENT_REQUEST => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x37, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_SCEP_SERVER_MESSAGE \"1.3.6.1.4.1.311.21.38\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_SCEP_SERVER_MESSAGE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x33, 0x38, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_SCEP_SERVER_SECRET \"1.3.6.1.4.1.311.21.40\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_SCEP_SERVER_SECRET => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x34, 0x30, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_KEY_AFFINITY \"1.3.6.1.4.1.311.21.41\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_KEY_AFFINITY => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x34, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_SCEP_SIGNER_HASH \"1.3.6.1.4.1.311.21.42\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_SCEP_SIGNER_HASH => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x34, 0x32, 0x00 };

        [NativeTypeName("#define szOID_ENROLL_EK_CA_KEYID \"1.3.6.1.4.1.311.21.43\"")]
        public static ReadOnlySpan<byte> szOID_ENROLL_EK_CA_KEYID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x32, 0x31, 0x2E, 0x34, 0x33, 0x00 };

        [NativeTypeName("#define szOID_ATTR_SUPPORTED_ALGORITHMS \"2.5.4.52\"")]
        public static ReadOnlySpan<byte> szOID_ATTR_SUPPORTED_ALGORITHMS => new byte[] { 0x32, 0x2E, 0x35, 0x2E, 0x34, 0x2E, 0x35, 0x32, 0x00 };

        [NativeTypeName("#define szOID_ATTR_TPM_SPECIFICATION \"2.23.133.2.16\"")]
        public static ReadOnlySpan<byte> szOID_ATTR_TPM_SPECIFICATION => new byte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x36, 0x00 };

        [NativeTypeName("#define szOID_ATTR_PLATFORM_SPECIFICATION \"2.23.133.2.17\"")]
        public static ReadOnlySpan<byte> szOID_ATTR_PLATFORM_SPECIFICATION => new byte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x37, 0x00 };

        [NativeTypeName("#define szOID_ATTR_TPM_SECURITY_ASSERTIONS \"2.23.133.2.18\"")]
        public static ReadOnlySpan<byte> szOID_ATTR_TPM_SECURITY_ASSERTIONS => new byte[] { 0x32, 0x2E, 0x32, 0x33, 0x2E, 0x31, 0x33, 0x33, 0x2E, 0x32, 0x2E, 0x31, 0x38, 0x00 };

        [NativeTypeName("#define CERT_UNICODE_RDN_ERR_INDEX_MASK 0x3FF")]
        public const int CERT_UNICODE_RDN_ERR_INDEX_MASK = 0x3FF;

        [NativeTypeName("#define CERT_UNICODE_RDN_ERR_INDEX_SHIFT 22")]
        public const int CERT_UNICODE_RDN_ERR_INDEX_SHIFT = 22;

        [NativeTypeName("#define CERT_UNICODE_ATTR_ERR_INDEX_MASK 0x003F")]
        public const int CERT_UNICODE_ATTR_ERR_INDEX_MASK = 0x003F;

        [NativeTypeName("#define CERT_UNICODE_ATTR_ERR_INDEX_SHIFT 16")]
        public const int CERT_UNICODE_ATTR_ERR_INDEX_SHIFT = 16;

        [NativeTypeName("#define CERT_UNICODE_VALUE_ERR_INDEX_MASK 0x0000FFFF")]
        public const int CERT_UNICODE_VALUE_ERR_INDEX_MASK = 0x0000FFFF;

        [NativeTypeName("#define CERT_UNICODE_VALUE_ERR_INDEX_SHIFT 0")]
        public const int CERT_UNICODE_VALUE_ERR_INDEX_SHIFT = 0;

        [NativeTypeName("#define CERT_DIGITAL_SIGNATURE_KEY_USAGE 0x80")]
        public const int CERT_DIGITAL_SIGNATURE_KEY_USAGE = 0x80;

        [NativeTypeName("#define CERT_NON_REPUDIATION_KEY_USAGE 0x40")]
        public const int CERT_NON_REPUDIATION_KEY_USAGE = 0x40;

        [NativeTypeName("#define CERT_KEY_ENCIPHERMENT_KEY_USAGE 0x20")]
        public const int CERT_KEY_ENCIPHERMENT_KEY_USAGE = 0x20;

        [NativeTypeName("#define CERT_DATA_ENCIPHERMENT_KEY_USAGE 0x10")]
        public const int CERT_DATA_ENCIPHERMENT_KEY_USAGE = 0x10;

        [NativeTypeName("#define CERT_KEY_AGREEMENT_KEY_USAGE 0x08")]
        public const int CERT_KEY_AGREEMENT_KEY_USAGE = 0x08;

        [NativeTypeName("#define CERT_KEY_CERT_SIGN_KEY_USAGE 0x04")]
        public const int CERT_KEY_CERT_SIGN_KEY_USAGE = 0x04;

        [NativeTypeName("#define CERT_OFFLINE_CRL_SIGN_KEY_USAGE 0x02")]
        public const int CERT_OFFLINE_CRL_SIGN_KEY_USAGE = 0x02;

        [NativeTypeName("#define CERT_CRL_SIGN_KEY_USAGE 0x02")]
        public const int CERT_CRL_SIGN_KEY_USAGE = 0x02;

        [NativeTypeName("#define CERT_ENCIPHER_ONLY_KEY_USAGE 0x01")]
        public const int CERT_ENCIPHER_ONLY_KEY_USAGE = 0x01;

        [NativeTypeName("#define CERT_DECIPHER_ONLY_KEY_USAGE 0x80")]
        public const int CERT_DECIPHER_ONLY_KEY_USAGE = 0x80;

        [NativeTypeName("#define CERT_ALT_NAME_OTHER_NAME 1")]
        public const int CERT_ALT_NAME_OTHER_NAME = 1;

        [NativeTypeName("#define CERT_ALT_NAME_RFC822_NAME 2")]
        public const int CERT_ALT_NAME_RFC822_NAME = 2;

        [NativeTypeName("#define CERT_ALT_NAME_DNS_NAME 3")]
        public const int CERT_ALT_NAME_DNS_NAME = 3;

        [NativeTypeName("#define CERT_ALT_NAME_X400_ADDRESS 4")]
        public const int CERT_ALT_NAME_X400_ADDRESS = 4;

        [NativeTypeName("#define CERT_ALT_NAME_DIRECTORY_NAME 5")]
        public const int CERT_ALT_NAME_DIRECTORY_NAME = 5;

        [NativeTypeName("#define CERT_ALT_NAME_EDI_PARTY_NAME 6")]
        public const int CERT_ALT_NAME_EDI_PARTY_NAME = 6;

        [NativeTypeName("#define CERT_ALT_NAME_URL 7")]
        public const int CERT_ALT_NAME_URL = 7;

        [NativeTypeName("#define CERT_ALT_NAME_IP_ADDRESS 8")]
        public const int CERT_ALT_NAME_IP_ADDRESS = 8;

        [NativeTypeName("#define CERT_ALT_NAME_REGISTERED_ID 9")]
        public const int CERT_ALT_NAME_REGISTERED_ID = 9;

        [NativeTypeName("#define CERT_ALT_NAME_ENTRY_ERR_INDEX_MASK 0xFF")]
        public const int CERT_ALT_NAME_ENTRY_ERR_INDEX_MASK = 0xFF;

        [NativeTypeName("#define CERT_ALT_NAME_ENTRY_ERR_INDEX_SHIFT 16")]
        public const int CERT_ALT_NAME_ENTRY_ERR_INDEX_SHIFT = 16;

        [NativeTypeName("#define CERT_ALT_NAME_VALUE_ERR_INDEX_MASK 0x0000FFFF")]
        public const int CERT_ALT_NAME_VALUE_ERR_INDEX_MASK = 0x0000FFFF;

        [NativeTypeName("#define CERT_ALT_NAME_VALUE_ERR_INDEX_SHIFT 0")]
        public const int CERT_ALT_NAME_VALUE_ERR_INDEX_SHIFT = 0;

        [NativeTypeName("#define CERT_CA_SUBJECT_FLAG 0x80")]
        public const int CERT_CA_SUBJECT_FLAG = 0x80;

        [NativeTypeName("#define CERT_END_ENTITY_SUBJECT_FLAG 0x40")]
        public const int CERT_END_ENTITY_SUBJECT_FLAG = 0x40;

        [NativeTypeName("#define szOID_PKIX_ACC_DESCR \"1.3.6.1.5.5.7.48\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_ACC_DESCR => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x00 };

        [NativeTypeName("#define szOID_PKIX_OCSP \"1.3.6.1.5.5.7.48.1\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_OCSP => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_PKIX_CA_ISSUERS \"1.3.6.1.5.5.7.48.2\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_CA_ISSUERS => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_PKIX_TIME_STAMPING \"1.3.6.1.5.5.7.48.3\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_TIME_STAMPING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_PKIX_CA_REPOSITORY \"1.3.6.1.5.5.7.48.5\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_CA_REPOSITORY => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define CRL_REASON_UNSPECIFIED 0")]
        public const int CRL_REASON_UNSPECIFIED = 0;

        [NativeTypeName("#define CRL_REASON_KEY_COMPROMISE 1")]
        public const int CRL_REASON_KEY_COMPROMISE = 1;

        [NativeTypeName("#define CRL_REASON_CA_COMPROMISE 2")]
        public const int CRL_REASON_CA_COMPROMISE = 2;

        [NativeTypeName("#define CRL_REASON_AFFILIATION_CHANGED 3")]
        public const int CRL_REASON_AFFILIATION_CHANGED = 3;

        [NativeTypeName("#define CRL_REASON_SUPERSEDED 4")]
        public const int CRL_REASON_SUPERSEDED = 4;

        [NativeTypeName("#define CRL_REASON_CESSATION_OF_OPERATION 5")]
        public const int CRL_REASON_CESSATION_OF_OPERATION = 5;

        [NativeTypeName("#define CRL_REASON_CERTIFICATE_HOLD 6")]
        public const int CRL_REASON_CERTIFICATE_HOLD = 6;

        [NativeTypeName("#define CRL_REASON_REMOVE_FROM_CRL 8")]
        public const int CRL_REASON_REMOVE_FROM_CRL = 8;

        [NativeTypeName("#define CRL_REASON_PRIVILEGE_WITHDRAWN 9")]
        public const int CRL_REASON_PRIVILEGE_WITHDRAWN = 9;

        [NativeTypeName("#define CRL_REASON_AA_COMPROMISE 10")]
        public const int CRL_REASON_AA_COMPROMISE = 10;

        [NativeTypeName("#define CRL_DIST_POINT_NO_NAME 0")]
        public const int CRL_DIST_POINT_NO_NAME = 0;

        [NativeTypeName("#define CRL_DIST_POINT_FULL_NAME 1")]
        public const int CRL_DIST_POINT_FULL_NAME = 1;

        [NativeTypeName("#define CRL_DIST_POINT_ISSUER_RDN_NAME 2")]
        public const int CRL_DIST_POINT_ISSUER_RDN_NAME = 2;

        [NativeTypeName("#define CRL_REASON_UNUSED_FLAG 0x80")]
        public const int CRL_REASON_UNUSED_FLAG = 0x80;

        [NativeTypeName("#define CRL_REASON_KEY_COMPROMISE_FLAG 0x40")]
        public const int CRL_REASON_KEY_COMPROMISE_FLAG = 0x40;

        [NativeTypeName("#define CRL_REASON_CA_COMPROMISE_FLAG 0x20")]
        public const int CRL_REASON_CA_COMPROMISE_FLAG = 0x20;

        [NativeTypeName("#define CRL_REASON_AFFILIATION_CHANGED_FLAG 0x10")]
        public const int CRL_REASON_AFFILIATION_CHANGED_FLAG = 0x10;

        [NativeTypeName("#define CRL_REASON_SUPERSEDED_FLAG 0x08")]
        public const int CRL_REASON_SUPERSEDED_FLAG = 0x08;

        [NativeTypeName("#define CRL_REASON_CESSATION_OF_OPERATION_FLAG 0x04")]
        public const int CRL_REASON_CESSATION_OF_OPERATION_FLAG = 0x04;

        [NativeTypeName("#define CRL_REASON_CERTIFICATE_HOLD_FLAG 0x02")]
        public const int CRL_REASON_CERTIFICATE_HOLD_FLAG = 0x02;

        [NativeTypeName("#define CRL_REASON_PRIVILEGE_WITHDRAWN_FLAG 0x01")]
        public const int CRL_REASON_PRIVILEGE_WITHDRAWN_FLAG = 0x01;

        [NativeTypeName("#define CRL_REASON_AA_COMPROMISE_FLAG 0x80")]
        public const int CRL_REASON_AA_COMPROMISE_FLAG = 0x80;

        [NativeTypeName("#define CRL_DIST_POINT_ERR_INDEX_MASK 0x7F")]
        public const int CRL_DIST_POINT_ERR_INDEX_MASK = 0x7F;

        [NativeTypeName("#define CRL_DIST_POINT_ERR_INDEX_SHIFT 24")]
        public const int CRL_DIST_POINT_ERR_INDEX_SHIFT = 24;

        [NativeTypeName("#define CRL_DIST_POINT_ERR_CRL_ISSUER_BIT 0x80000000L")]
        public const uint CRL_DIST_POINT_ERR_CRL_ISSUER_BIT = 0x80000000;

        [NativeTypeName("#define CROSS_CERT_DIST_POINT_ERR_INDEX_MASK 0xFF")]
        public const int CROSS_CERT_DIST_POINT_ERR_INDEX_MASK = 0xFF;

        [NativeTypeName("#define CROSS_CERT_DIST_POINT_ERR_INDEX_SHIFT 24")]
        public const int CROSS_CERT_DIST_POINT_ERR_INDEX_SHIFT = 24;

        [NativeTypeName("#define CERT_EXCLUDED_SUBTREE_BIT 0x80000000L")]
        public const uint CERT_EXCLUDED_SUBTREE_BIT = 0x80000000;

        [NativeTypeName("#define SORTED_CTL_EXT_FLAGS_OFFSET (0*4)")]
        public const int SORTED_CTL_EXT_FLAGS_OFFSET = (0 * 4);

        [NativeTypeName("#define SORTED_CTL_EXT_COUNT_OFFSET (1*4)")]
        public const int SORTED_CTL_EXT_COUNT_OFFSET = (1 * 4);

        [NativeTypeName("#define SORTED_CTL_EXT_MAX_COLLISION_OFFSET (2*4)")]
        public const int SORTED_CTL_EXT_MAX_COLLISION_OFFSET = (2 * 4);

        [NativeTypeName("#define SORTED_CTL_EXT_HASH_BUCKET_OFFSET (3*4)")]
        public const int SORTED_CTL_EXT_HASH_BUCKET_OFFSET = (3 * 4);

        [NativeTypeName("#define SORTED_CTL_EXT_HASHED_SUBJECT_IDENTIFIER_FLAG 0x1")]
        public const int SORTED_CTL_EXT_HASHED_SUBJECT_IDENTIFIER_FLAG = 0x1;

        [NativeTypeName("#define CERT_DSS_R_LEN 20")]
        public const int CERT_DSS_R_LEN = 20;

        [NativeTypeName("#define CERT_DSS_S_LEN 20")]
        public const int CERT_DSS_S_LEN = 20;

        [NativeTypeName("#define CERT_DSS_SIGNATURE_LEN (CERT_DSS_R_LEN + CERT_DSS_S_LEN)")]
        public const int CERT_DSS_SIGNATURE_LEN = (20 + 20);

        [NativeTypeName("#define CERT_MAX_ASN_ENCODED_DSS_SIGNATURE_LEN (2 + 2*(2 + 20 +1))")]
        public const int CERT_MAX_ASN_ENCODED_DSS_SIGNATURE_LEN = (2 + 2 * (2 + 20 + 1));

        [NativeTypeName("#define CRYPT_X942_COUNTER_BYTE_LENGTH 4")]
        public const int CRYPT_X942_COUNTER_BYTE_LENGTH = 4;

        [NativeTypeName("#define CRYPT_X942_KEY_LENGTH_BYTE_LENGTH 4")]
        public const int CRYPT_X942_KEY_LENGTH_BYTE_LENGTH = 4;

        [NativeTypeName("#define CRYPT_X942_PUB_INFO_BYTE_LENGTH (512/8)")]
        public const int CRYPT_X942_PUB_INFO_BYTE_LENGTH = (512 / 8);

        [NativeTypeName("#define CRYPT_ECC_CMS_SHARED_INFO_SUPPPUBINFO_BYTE_LENGTH 4")]
        public const int CRYPT_ECC_CMS_SHARED_INFO_SUPPPUBINFO_BYTE_LENGTH = 4;

        [NativeTypeName("#define CRYPT_RC2_40BIT_VERSION 160")]
        public const int CRYPT_RC2_40BIT_VERSION = 160;

        [NativeTypeName("#define CRYPT_RC2_56BIT_VERSION 52")]
        public const int CRYPT_RC2_56BIT_VERSION = 52;

        [NativeTypeName("#define CRYPT_RC2_64BIT_VERSION 120")]
        public const int CRYPT_RC2_64BIT_VERSION = 120;

        [NativeTypeName("#define CRYPT_RC2_128BIT_VERSION 58")]
        public const int CRYPT_RC2_128BIT_VERSION = 58;

        [NativeTypeName("#define szOID_QC_EU_COMPLIANCE \"0.4.0.1862.1.1\"")]
        public static ReadOnlySpan<byte> szOID_QC_EU_COMPLIANCE => new byte[] { 0x30, 0x2E, 0x34, 0x2E, 0x30, 0x2E, 0x31, 0x38, 0x36, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_QC_SSCD \"0.4.0.1862.1.4\"")]
        public static ReadOnlySpan<byte> szOID_QC_SSCD => new byte[] { 0x30, 0x2E, 0x34, 0x2E, 0x30, 0x2E, 0x31, 0x38, 0x36, 0x32, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define PKCS_RSA_SSA_PSS_TRAILER_FIELD_BC 1")]
        public const int PKCS_RSA_SSA_PSS_TRAILER_FIELD_BC = 1;

        [NativeTypeName("#define szOID_VERISIGN_PRIVATE_6_9 \"2.16.840.1.113733.1.6.9\"")]
        public static ReadOnlySpan<byte> szOID_VERISIGN_PRIVATE_6_9 => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x36, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_VERISIGN_ONSITE_JURISDICTION_HASH \"2.16.840.1.113733.1.6.11\"")]
        public static ReadOnlySpan<byte> szOID_VERISIGN_ONSITE_JURISDICTION_HASH => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x36, 0x2E, 0x31, 0x31, 0x00 };

        [NativeTypeName("#define szOID_VERISIGN_BITSTRING_6_13 \"2.16.840.1.113733.1.6.13\"")]
        public static ReadOnlySpan<byte> szOID_VERISIGN_BITSTRING_6_13 => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x36, 0x2E, 0x31, 0x33, 0x00 };

        [NativeTypeName("#define szOID_VERISIGN_ISS_STRONG_CRYPTO \"2.16.840.1.113733.1.8.1\"")]
        public static ReadOnlySpan<byte> szOID_VERISIGN_ISS_STRONG_CRYPTO => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x38, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOIDVerisign_MessageType \"2.16.840.1.113733.1.9.2\"")]
        public static ReadOnlySpan<byte> szOIDVerisign_MessageType => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOIDVerisign_PkiStatus \"2.16.840.1.113733.1.9.3\"")]
        public static ReadOnlySpan<byte> szOIDVerisign_PkiStatus => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOIDVerisign_FailInfo \"2.16.840.1.113733.1.9.4\"")]
        public static ReadOnlySpan<byte> szOIDVerisign_FailInfo => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOIDVerisign_SenderNonce \"2.16.840.1.113733.1.9.5\"")]
        public static ReadOnlySpan<byte> szOIDVerisign_SenderNonce => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOIDVerisign_RecipientNonce \"2.16.840.1.113733.1.9.6\"")]
        public static ReadOnlySpan<byte> szOIDVerisign_RecipientNonce => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOIDVerisign_TransactionID \"2.16.840.1.113733.1.9.7\"")]
        public static ReadOnlySpan<byte> szOIDVerisign_TransactionID => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x33, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_NETSCAPE \"2.16.840.1.113730\"")]
        public static ReadOnlySpan<byte> szOID_NETSCAPE => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x00 };

        [NativeTypeName("#define szOID_NETSCAPE_CERT_EXTENSION \"2.16.840.1.113730.1\"")]
        public static ReadOnlySpan<byte> szOID_NETSCAPE_CERT_EXTENSION => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_NETSCAPE_CERT_TYPE \"2.16.840.1.113730.1.1\"")]
        public static ReadOnlySpan<byte> szOID_NETSCAPE_CERT_TYPE => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_NETSCAPE_BASE_URL \"2.16.840.1.113730.1.2\"")]
        public static ReadOnlySpan<byte> szOID_NETSCAPE_BASE_URL => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_NETSCAPE_REVOCATION_URL \"2.16.840.1.113730.1.3\"")]
        public static ReadOnlySpan<byte> szOID_NETSCAPE_REVOCATION_URL => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_NETSCAPE_CA_REVOCATION_URL \"2.16.840.1.113730.1.4\"")]
        public static ReadOnlySpan<byte> szOID_NETSCAPE_CA_REVOCATION_URL => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_NETSCAPE_CERT_RENEWAL_URL \"2.16.840.1.113730.1.7\"")]
        public static ReadOnlySpan<byte> szOID_NETSCAPE_CERT_RENEWAL_URL => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_NETSCAPE_CA_POLICY_URL \"2.16.840.1.113730.1.8\"")]
        public static ReadOnlySpan<byte> szOID_NETSCAPE_CA_POLICY_URL => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x38, 0x00 };

        [NativeTypeName("#define szOID_NETSCAPE_SSL_SERVER_NAME \"2.16.840.1.113730.1.12\"")]
        public static ReadOnlySpan<byte> szOID_NETSCAPE_SSL_SERVER_NAME => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x00 };

        [NativeTypeName("#define szOID_NETSCAPE_COMMENT \"2.16.840.1.113730.1.13\"")]
        public static ReadOnlySpan<byte> szOID_NETSCAPE_COMMENT => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x33, 0x00 };

        [NativeTypeName("#define szOID_NETSCAPE_DATA_TYPE \"2.16.840.1.113730.2\"")]
        public static ReadOnlySpan<byte> szOID_NETSCAPE_DATA_TYPE => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_NETSCAPE_CERT_SEQUENCE \"2.16.840.1.113730.2.5\"")]
        public static ReadOnlySpan<byte> szOID_NETSCAPE_CERT_SEQUENCE => new byte[] { 0x32, 0x2E, 0x31, 0x36, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x2E, 0x31, 0x31, 0x33, 0x37, 0x33, 0x30, 0x2E, 0x32, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define NETSCAPE_SSL_CLIENT_AUTH_CERT_TYPE 0x80")]
        public const int NETSCAPE_SSL_CLIENT_AUTH_CERT_TYPE = 0x80;

        [NativeTypeName("#define NETSCAPE_SSL_SERVER_AUTH_CERT_TYPE 0x40")]
        public const int NETSCAPE_SSL_SERVER_AUTH_CERT_TYPE = 0x40;

        [NativeTypeName("#define NETSCAPE_SMIME_CERT_TYPE 0x20")]
        public const int NETSCAPE_SMIME_CERT_TYPE = 0x20;

        [NativeTypeName("#define NETSCAPE_SIGN_CERT_TYPE 0x10")]
        public const int NETSCAPE_SIGN_CERT_TYPE = 0x10;

        [NativeTypeName("#define NETSCAPE_SSL_CA_CERT_TYPE 0x04")]
        public const int NETSCAPE_SSL_CA_CERT_TYPE = 0x04;

        [NativeTypeName("#define NETSCAPE_SMIME_CA_CERT_TYPE 0x02")]
        public const int NETSCAPE_SMIME_CA_CERT_TYPE = 0x02;

        [NativeTypeName("#define NETSCAPE_SIGN_CA_CERT_TYPE 0x01")]
        public const int NETSCAPE_SIGN_CA_CERT_TYPE = 0x01;

        [NativeTypeName("#define szOID_CT_PKI_DATA \"1.3.6.1.5.5.7.12.2\"")]
        public static ReadOnlySpan<byte> szOID_CT_PKI_DATA => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x32, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_CT_PKI_RESPONSE \"1.3.6.1.5.5.7.12.3\"")]
        public static ReadOnlySpan<byte> szOID_CT_PKI_RESPONSE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x31, 0x32, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_PKIX_NO_SIGNATURE \"1.3.6.1.5.5.7.6.2\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_NO_SIGNATURE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x36, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_CMC \"1.3.6.1.5.5.7.7\"")]
        public static ReadOnlySpan<byte> szOID_CMC => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_CMC_STATUS_INFO \"1.3.6.1.5.5.7.7.1\"")]
        public static ReadOnlySpan<byte> szOID_CMC_STATUS_INFO => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_CMC_IDENTIFICATION \"1.3.6.1.5.5.7.7.2\"")]
        public static ReadOnlySpan<byte> szOID_CMC_IDENTIFICATION => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_CMC_IDENTITY_PROOF \"1.3.6.1.5.5.7.7.3\"")]
        public static ReadOnlySpan<byte> szOID_CMC_IDENTITY_PROOF => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_CMC_DATA_RETURN \"1.3.6.1.5.5.7.7.4\"")]
        public static ReadOnlySpan<byte> szOID_CMC_DATA_RETURN => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_CMC_TRANSACTION_ID \"1.3.6.1.5.5.7.7.5\"")]
        public static ReadOnlySpan<byte> szOID_CMC_TRANSACTION_ID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_CMC_SENDER_NONCE \"1.3.6.1.5.5.7.7.6\"")]
        public static ReadOnlySpan<byte> szOID_CMC_SENDER_NONCE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_CMC_RECIPIENT_NONCE \"1.3.6.1.5.5.7.7.7\"")]
        public static ReadOnlySpan<byte> szOID_CMC_RECIPIENT_NONCE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define szOID_CMC_ADD_EXTENSIONS \"1.3.6.1.5.5.7.7.8\"")]
        public static ReadOnlySpan<byte> szOID_CMC_ADD_EXTENSIONS => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x38, 0x00 };

        [NativeTypeName("#define szOID_CMC_ENCRYPTED_POP \"1.3.6.1.5.5.7.7.9\"")]
        public static ReadOnlySpan<byte> szOID_CMC_ENCRYPTED_POP => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define szOID_CMC_DECRYPTED_POP \"1.3.6.1.5.5.7.7.10\"")]
        public static ReadOnlySpan<byte> szOID_CMC_DECRYPTED_POP => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x30, 0x00 };

        [NativeTypeName("#define szOID_CMC_LRA_POP_WITNESS \"1.3.6.1.5.5.7.7.11\"")]
        public static ReadOnlySpan<byte> szOID_CMC_LRA_POP_WITNESS => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x31, 0x00 };

        [NativeTypeName("#define szOID_CMC_GET_CERT \"1.3.6.1.5.5.7.7.15\"")]
        public static ReadOnlySpan<byte> szOID_CMC_GET_CERT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x35, 0x00 };

        [NativeTypeName("#define szOID_CMC_GET_CRL \"1.3.6.1.5.5.7.7.16\"")]
        public static ReadOnlySpan<byte> szOID_CMC_GET_CRL => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x36, 0x00 };

        [NativeTypeName("#define szOID_CMC_REVOKE_REQUEST \"1.3.6.1.5.5.7.7.17\"")]
        public static ReadOnlySpan<byte> szOID_CMC_REVOKE_REQUEST => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x37, 0x00 };

        [NativeTypeName("#define szOID_CMC_REG_INFO \"1.3.6.1.5.5.7.7.18\"")]
        public static ReadOnlySpan<byte> szOID_CMC_REG_INFO => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x38, 0x00 };

        [NativeTypeName("#define szOID_CMC_RESPONSE_INFO \"1.3.6.1.5.5.7.7.19\"")]
        public static ReadOnlySpan<byte> szOID_CMC_RESPONSE_INFO => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x31, 0x39, 0x00 };

        [NativeTypeName("#define szOID_CMC_QUERY_PENDING \"1.3.6.1.5.5.7.7.21\"")]
        public static ReadOnlySpan<byte> szOID_CMC_QUERY_PENDING => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x32, 0x31, 0x00 };

        [NativeTypeName("#define szOID_CMC_ID_POP_LINK_RANDOM \"1.3.6.1.5.5.7.7.22\"")]
        public static ReadOnlySpan<byte> szOID_CMC_ID_POP_LINK_RANDOM => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x32, 0x32, 0x00 };

        [NativeTypeName("#define szOID_CMC_ID_POP_LINK_WITNESS \"1.3.6.1.5.5.7.7.23\"")]
        public static ReadOnlySpan<byte> szOID_CMC_ID_POP_LINK_WITNESS => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x32, 0x33, 0x00 };

        [NativeTypeName("#define szOID_CMC_ID_CONFIRM_CERT_ACCEPTANCE \"1.3.6.1.5.5.7.7.24\"")]
        public static ReadOnlySpan<byte> szOID_CMC_ID_CONFIRM_CERT_ACCEPTANCE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x37, 0x2E, 0x32, 0x34, 0x00 };

        [NativeTypeName("#define szOID_CMC_ADD_ATTRIBUTES \"1.3.6.1.4.1.311.10.10.1\"")]
        public static ReadOnlySpan<byte> szOID_CMC_ADD_ATTRIBUTES => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define CMC_TAGGED_CERT_REQUEST_CHOICE 1")]
        public const int CMC_TAGGED_CERT_REQUEST_CHOICE = 1;

        [NativeTypeName("#define CMC_OTHER_INFO_NO_CHOICE 0")]
        public const int CMC_OTHER_INFO_NO_CHOICE = 0;

        [NativeTypeName("#define CMC_OTHER_INFO_FAIL_CHOICE 1")]
        public const int CMC_OTHER_INFO_FAIL_CHOICE = 1;

        [NativeTypeName("#define CMC_OTHER_INFO_PEND_CHOICE 2")]
        public const int CMC_OTHER_INFO_PEND_CHOICE = 2;

        [NativeTypeName("#define CMC_STATUS_SUCCESS 0")]
        public const int CMC_STATUS_SUCCESS = 0;

        [NativeTypeName("#define CMC_STATUS_FAILED 2")]
        public const int CMC_STATUS_FAILED = 2;

        [NativeTypeName("#define CMC_STATUS_PENDING 3")]
        public const int CMC_STATUS_PENDING = 3;

        [NativeTypeName("#define CMC_STATUS_NO_SUPPORT 4")]
        public const int CMC_STATUS_NO_SUPPORT = 4;

        [NativeTypeName("#define CMC_STATUS_CONFIRM_REQUIRED 5")]
        public const int CMC_STATUS_CONFIRM_REQUIRED = 5;

        [NativeTypeName("#define CMC_FAIL_BAD_ALG 0")]
        public const int CMC_FAIL_BAD_ALG = 0;

        [NativeTypeName("#define CMC_FAIL_BAD_MESSAGE_CHECK 1")]
        public const int CMC_FAIL_BAD_MESSAGE_CHECK = 1;

        [NativeTypeName("#define CMC_FAIL_BAD_REQUEST 2")]
        public const int CMC_FAIL_BAD_REQUEST = 2;

        [NativeTypeName("#define CMC_FAIL_BAD_TIME 3")]
        public const int CMC_FAIL_BAD_TIME = 3;

        [NativeTypeName("#define CMC_FAIL_BAD_CERT_ID 4")]
        public const int CMC_FAIL_BAD_CERT_ID = 4;

        [NativeTypeName("#define CMC_FAIL_UNSUPORTED_EXT 5")]
        public const int CMC_FAIL_UNSUPORTED_EXT = 5;

        [NativeTypeName("#define CMC_FAIL_MUST_ARCHIVE_KEYS 6")]
        public const int CMC_FAIL_MUST_ARCHIVE_KEYS = 6;

        [NativeTypeName("#define CMC_FAIL_BAD_IDENTITY 7")]
        public const int CMC_FAIL_BAD_IDENTITY = 7;

        [NativeTypeName("#define CMC_FAIL_POP_REQUIRED 8")]
        public const int CMC_FAIL_POP_REQUIRED = 8;

        [NativeTypeName("#define CMC_FAIL_POP_FAILED 9")]
        public const int CMC_FAIL_POP_FAILED = 9;

        [NativeTypeName("#define CMC_FAIL_NO_KEY_REUSE 10")]
        public const int CMC_FAIL_NO_KEY_REUSE = 10;

        [NativeTypeName("#define CMC_FAIL_INTERNAL_CA_ERROR 11")]
        public const int CMC_FAIL_INTERNAL_CA_ERROR = 11;

        [NativeTypeName("#define CMC_FAIL_TRY_LATER 12")]
        public const int CMC_FAIL_TRY_LATER = 12;

        [NativeTypeName("#define CERT_LOGOTYPE_GRAY_SCALE_IMAGE_INFO_CHOICE 1")]
        public const int CERT_LOGOTYPE_GRAY_SCALE_IMAGE_INFO_CHOICE = 1;

        [NativeTypeName("#define CERT_LOGOTYPE_COLOR_IMAGE_INFO_CHOICE 2")]
        public const int CERT_LOGOTYPE_COLOR_IMAGE_INFO_CHOICE = 2;

        [NativeTypeName("#define CERT_LOGOTYPE_NO_IMAGE_RESOLUTION_CHOICE 0")]
        public const int CERT_LOGOTYPE_NO_IMAGE_RESOLUTION_CHOICE = 0;

        [NativeTypeName("#define CERT_LOGOTYPE_BITS_IMAGE_RESOLUTION_CHOICE 1")]
        public const int CERT_LOGOTYPE_BITS_IMAGE_RESOLUTION_CHOICE = 1;

        [NativeTypeName("#define CERT_LOGOTYPE_TABLE_SIZE_IMAGE_RESOLUTION_CHOICE 2")]
        public const int CERT_LOGOTYPE_TABLE_SIZE_IMAGE_RESOLUTION_CHOICE = 2;

        [NativeTypeName("#define CERT_LOGOTYPE_DIRECT_INFO_CHOICE 1")]
        public const int CERT_LOGOTYPE_DIRECT_INFO_CHOICE = 1;

        [NativeTypeName("#define CERT_LOGOTYPE_INDIRECT_INFO_CHOICE 2")]
        public const int CERT_LOGOTYPE_INDIRECT_INFO_CHOICE = 2;

        [NativeTypeName("#define szOID_LOYALTY_OTHER_LOGOTYPE \"1.3.6.1.5.5.7.20.1\"")]
        public static ReadOnlySpan<byte> szOID_LOYALTY_OTHER_LOGOTYPE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x32, 0x30, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_BACKGROUND_OTHER_LOGOTYPE \"1.3.6.1.5.5.7.20.2\"")]
        public static ReadOnlySpan<byte> szOID_BACKGROUND_OTHER_LOGOTYPE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x32, 0x30, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define CERT_BIOMETRIC_PREDEFINED_DATA_CHOICE 1")]
        public const int CERT_BIOMETRIC_PREDEFINED_DATA_CHOICE = 1;

        [NativeTypeName("#define CERT_BIOMETRIC_OID_DATA_CHOICE 2")]
        public const int CERT_BIOMETRIC_OID_DATA_CHOICE = 2;

        [NativeTypeName("#define CERT_BIOMETRIC_PICTURE_TYPE 0")]
        public const int CERT_BIOMETRIC_PICTURE_TYPE = 0;

        [NativeTypeName("#define CERT_BIOMETRIC_SIGNATURE_TYPE 1")]
        public const int CERT_BIOMETRIC_SIGNATURE_TYPE = 1;

        [NativeTypeName("#define OCSP_REQUEST_V1 0")]
        public const int OCSP_REQUEST_V1 = 0;

        [NativeTypeName("#define OCSP_SUCCESSFUL_RESPONSE 0")]
        public const int OCSP_SUCCESSFUL_RESPONSE = 0;

        [NativeTypeName("#define OCSP_MALFORMED_REQUEST_RESPONSE 1")]
        public const int OCSP_MALFORMED_REQUEST_RESPONSE = 1;

        [NativeTypeName("#define OCSP_INTERNAL_ERROR_RESPONSE 2")]
        public const int OCSP_INTERNAL_ERROR_RESPONSE = 2;

        [NativeTypeName("#define OCSP_TRY_LATER_RESPONSE 3")]
        public const int OCSP_TRY_LATER_RESPONSE = 3;

        [NativeTypeName("#define OCSP_SIG_REQUIRED_RESPONSE 5")]
        public const int OCSP_SIG_REQUIRED_RESPONSE = 5;

        [NativeTypeName("#define OCSP_UNAUTHORIZED_RESPONSE 6")]
        public const int OCSP_UNAUTHORIZED_RESPONSE = 6;

        [NativeTypeName("#define szOID_PKIX_OCSP_BASIC_SIGNED_RESPONSE \"1.3.6.1.5.5.7.48.1.1\"")]
        public static ReadOnlySpan<byte> szOID_PKIX_OCSP_BASIC_SIGNED_RESPONSE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x34, 0x38, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define OCSP_BASIC_GOOD_CERT_STATUS 0")]
        public const int OCSP_BASIC_GOOD_CERT_STATUS = 0;

        [NativeTypeName("#define OCSP_BASIC_REVOKED_CERT_STATUS 1")]
        public const int OCSP_BASIC_REVOKED_CERT_STATUS = 1;

        [NativeTypeName("#define OCSP_BASIC_UNKNOWN_CERT_STATUS 2")]
        public const int OCSP_BASIC_UNKNOWN_CERT_STATUS = 2;

        [NativeTypeName("#define OCSP_BASIC_RESPONSE_V1 0")]
        public const int OCSP_BASIC_RESPONSE_V1 = 0;

        [NativeTypeName("#define OCSP_BASIC_BY_NAME_RESPONDER_ID 1")]
        public const int OCSP_BASIC_BY_NAME_RESPONDER_ID = 1;

        [NativeTypeName("#define OCSP_BASIC_BY_KEY_RESPONDER_ID 2")]
        public const int OCSP_BASIC_BY_KEY_RESPONDER_ID = 2;

        [NativeTypeName("#define CRYPT_OID_ENCODE_OBJECT_FUNC \"CryptDllEncodeObject\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_ENCODE_OBJECT_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        [NativeTypeName("#define CRYPT_OID_DECODE_OBJECT_FUNC \"CryptDllDecodeObject\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_DECODE_OBJECT_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x44, 0x65, 0x63, 0x6F, 0x64, 0x65, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        [NativeTypeName("#define CRYPT_OID_ENCODE_OBJECT_EX_FUNC \"CryptDllEncodeObjectEx\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_ENCODE_OBJECT_EX_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x45, 0x78, 0x00 };

        [NativeTypeName("#define CRYPT_OID_DECODE_OBJECT_EX_FUNC \"CryptDllDecodeObjectEx\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_DECODE_OBJECT_EX_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x44, 0x65, 0x63, 0x6F, 0x64, 0x65, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x45, 0x78, 0x00 };

        [NativeTypeName("#define CRYPT_OID_CREATE_COM_OBJECT_FUNC \"CryptDllCreateCOMObject\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_CREATE_COM_OBJECT_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x43, 0x72, 0x65, 0x61, 0x74, 0x65, 0x43, 0x4F, 0x4D, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        [NativeTypeName("#define CRYPT_OID_VERIFY_REVOCATION_FUNC \"CertDllVerifyRevocation\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_VERIFY_REVOCATION_FUNC => new byte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x56, 0x65, 0x72, 0x69, 0x66, 0x79, 0x52, 0x65, 0x76, 0x6F, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define CRYPT_OID_VERIFY_CTL_USAGE_FUNC \"CertDllVerifyCTLUsage\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_VERIFY_CTL_USAGE_FUNC => new byte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x56, 0x65, 0x72, 0x69, 0x66, 0x79, 0x43, 0x54, 0x4C, 0x55, 0x73, 0x61, 0x67, 0x65, 0x00 };

        [NativeTypeName("#define CRYPT_OID_FORMAT_OBJECT_FUNC \"CryptDllFormatObject\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_FORMAT_OBJECT_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x46, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        [NativeTypeName("#define CRYPT_OID_FIND_OID_INFO_FUNC \"CryptDllFindOIDInfo\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_FIND_OID_INFO_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x46, 0x69, 0x6E, 0x64, 0x4F, 0x49, 0x44, 0x49, 0x6E, 0x66, 0x6F, 0x00 };

        [NativeTypeName("#define CRYPT_OID_FIND_LOCALIZED_NAME_FUNC \"CryptDllFindLocalizedName\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_FIND_LOCALIZED_NAME_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x46, 0x69, 0x6E, 0x64, 0x4C, 0x6F, 0x63, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x64, 0x4E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define CRYPT_OID_REGPATH \"Software\\\\Microsoft\\\\Cryptography\\\\OID\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_REGPATH => new byte[] { 0x53, 0x6F, 0x66, 0x74, 0x77, 0x61, 0x72, 0x65, 0x5C, 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x5C, 0x43, 0x72, 0x79, 0x70, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x79, 0x5C, 0x4F, 0x49, 0x44, 0x00 };

        [NativeTypeName("#define CRYPT_OID_REG_ENCODING_TYPE_PREFIX \"EncodingType \"")]
        public static ReadOnlySpan<byte> CRYPT_OID_REG_ENCODING_TYPE_PREFIX => new byte[] { 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x69, 0x6E, 0x67, 0x54, 0x79, 0x70, 0x65, 0x20, 0x00 };

        [NativeTypeName("#define CRYPT_OID_REG_DLL_VALUE_NAME L\"Dll\"")]
        public const string CRYPT_OID_REG_DLL_VALUE_NAME = "Dll";

        [NativeTypeName("#define CRYPT_OID_REG_FUNC_NAME_VALUE_NAME L\"FuncName\"")]
        public const string CRYPT_OID_REG_FUNC_NAME_VALUE_NAME = "FuncName";

        [NativeTypeName("#define CRYPT_OID_REG_FUNC_NAME_VALUE_NAME_A \"FuncName\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_REG_FUNC_NAME_VALUE_NAME_A => new byte[] { 0x46, 0x75, 0x6E, 0x63, 0x4E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define CRYPT_OID_REG_FLAGS_VALUE_NAME L\"CryptFlags\"")]
        public const string CRYPT_OID_REG_FLAGS_VALUE_NAME = "CryptFlags";

        [NativeTypeName("#define CRYPT_DEFAULT_OID \"DEFAULT\"")]
        public static ReadOnlySpan<byte> CRYPT_DEFAULT_OID => new byte[] { 0x44, 0x45, 0x46, 0x41, 0x55, 0x4C, 0x54, 0x00 };

        [NativeTypeName("#define CRYPT_INSTALL_OID_FUNC_BEFORE_FLAG 1")]
        public const int CRYPT_INSTALL_OID_FUNC_BEFORE_FLAG = 1;

        [NativeTypeName("#define CRYPT_GET_INSTALLED_OID_FUNC_FLAG 0x1")]
        public const int CRYPT_GET_INSTALLED_OID_FUNC_FLAG = 0x1;

        [NativeTypeName("#define CRYPT_REGISTER_FIRST_INDEX 0")]
        public const int CRYPT_REGISTER_FIRST_INDEX = 0;

        [NativeTypeName("#define CRYPT_REGISTER_LAST_INDEX 0xFFFFFFFF")]
        public const uint CRYPT_REGISTER_LAST_INDEX = 0xFFFFFFFF;

        [NativeTypeName("#define CRYPT_MATCH_ANY_ENCODING_TYPE 0xFFFFFFFF")]
        public const uint CRYPT_MATCH_ANY_ENCODING_TYPE = 0xFFFFFFFF;

        [NativeTypeName("#define CALG_OID_INFO_CNG_ONLY 0xFFFFFFFF")]
        public const uint CALG_OID_INFO_CNG_ONLY = 0xFFFFFFFF;

        [NativeTypeName("#define CALG_OID_INFO_PARAMETERS 0xFFFFFFFE")]
        public const uint CALG_OID_INFO_PARAMETERS = 0xFFFFFFFE;

        [NativeTypeName("#define CRYPT_OID_INFO_HASH_PARAMETERS_ALGORITHM L\"CryptOIDInfoHashParameters\"")]
        public const string CRYPT_OID_INFO_HASH_PARAMETERS_ALGORITHM = "CryptOIDInfoHashParameters";

        [NativeTypeName("#define CRYPT_OID_INFO_ECC_PARAMETERS_ALGORITHM L\"CryptOIDInfoECCParameters\"")]
        public const string CRYPT_OID_INFO_ECC_PARAMETERS_ALGORITHM = "CryptOIDInfoECCParameters";

        [NativeTypeName("#define CRYPT_OID_INFO_MGF1_PARAMETERS_ALGORITHM L\"CryptOIDInfoMgf1Parameters\"")]
        public const string CRYPT_OID_INFO_MGF1_PARAMETERS_ALGORITHM = "CryptOIDInfoMgf1Parameters";

        [NativeTypeName("#define CRYPT_OID_INFO_NO_SIGN_ALGORITHM L\"CryptOIDInfoNoSign\"")]
        public const string CRYPT_OID_INFO_NO_SIGN_ALGORITHM = "CryptOIDInfoNoSign";

        [NativeTypeName("#define CRYPT_OID_INFO_OAEP_PARAMETERS_ALGORITHM L\"CryptOIDInfoOAEPParameters\"")]
        public const string CRYPT_OID_INFO_OAEP_PARAMETERS_ALGORITHM = "CryptOIDInfoOAEPParameters";

        [NativeTypeName("#define CRYPT_OID_INFO_ECC_WRAP_PARAMETERS_ALGORITHM L\"CryptOIDInfoECCWrapParameters\"")]
        public const string CRYPT_OID_INFO_ECC_WRAP_PARAMETERS_ALGORITHM = "CryptOIDInfoECCWrapParameters";

        [NativeTypeName("#define CRYPT_OID_INFO_NO_PARAMETERS_ALGORITHM L\"CryptOIDInfoNoParameters\"")]
        public const string CRYPT_OID_INFO_NO_PARAMETERS_ALGORITHM = "CryptOIDInfoNoParameters";

        [NativeTypeName("#define CRYPT_HASH_ALG_OID_GROUP_ID 1")]
        public const int CRYPT_HASH_ALG_OID_GROUP_ID = 1;

        [NativeTypeName("#define CRYPT_ENCRYPT_ALG_OID_GROUP_ID 2")]
        public const int CRYPT_ENCRYPT_ALG_OID_GROUP_ID = 2;

        [NativeTypeName("#define CRYPT_PUBKEY_ALG_OID_GROUP_ID 3")]
        public const int CRYPT_PUBKEY_ALG_OID_GROUP_ID = 3;

        [NativeTypeName("#define CRYPT_SIGN_ALG_OID_GROUP_ID 4")]
        public const int CRYPT_SIGN_ALG_OID_GROUP_ID = 4;

        [NativeTypeName("#define CRYPT_RDN_ATTR_OID_GROUP_ID 5")]
        public const int CRYPT_RDN_ATTR_OID_GROUP_ID = 5;

        [NativeTypeName("#define CRYPT_EXT_OR_ATTR_OID_GROUP_ID 6")]
        public const int CRYPT_EXT_OR_ATTR_OID_GROUP_ID = 6;

        [NativeTypeName("#define CRYPT_ENHKEY_USAGE_OID_GROUP_ID 7")]
        public const int CRYPT_ENHKEY_USAGE_OID_GROUP_ID = 7;

        [NativeTypeName("#define CRYPT_POLICY_OID_GROUP_ID 8")]
        public const int CRYPT_POLICY_OID_GROUP_ID = 8;

        [NativeTypeName("#define CRYPT_TEMPLATE_OID_GROUP_ID 9")]
        public const int CRYPT_TEMPLATE_OID_GROUP_ID = 9;

        [NativeTypeName("#define CRYPT_KDF_OID_GROUP_ID 10")]
        public const int CRYPT_KDF_OID_GROUP_ID = 10;

        [NativeTypeName("#define CRYPT_LAST_OID_GROUP_ID 10")]
        public const int CRYPT_LAST_OID_GROUP_ID = 10;

        [NativeTypeName("#define CRYPT_FIRST_ALG_OID_GROUP_ID CRYPT_HASH_ALG_OID_GROUP_ID")]
        public const int CRYPT_FIRST_ALG_OID_GROUP_ID = 1;

        [NativeTypeName("#define CRYPT_LAST_ALG_OID_GROUP_ID CRYPT_SIGN_ALG_OID_GROUP_ID")]
        public const int CRYPT_LAST_ALG_OID_GROUP_ID = 4;

        [NativeTypeName("#define CRYPT_OID_INHIBIT_SIGNATURE_FORMAT_FLAG 0x00000001")]
        public const int CRYPT_OID_INHIBIT_SIGNATURE_FORMAT_FLAG = 0x00000001;

        [NativeTypeName("#define CRYPT_OID_USE_PUBKEY_PARA_FOR_PKCS7_FLAG 0x00000002")]
        public const int CRYPT_OID_USE_PUBKEY_PARA_FOR_PKCS7_FLAG = 0x00000002;

        [NativeTypeName("#define CRYPT_OID_NO_NULL_ALGORITHM_PARA_FLAG 0x00000004")]
        public const int CRYPT_OID_NO_NULL_ALGORITHM_PARA_FLAG = 0x00000004;

        [NativeTypeName("#define CRYPT_OID_PUBKEY_SIGN_ONLY_FLAG 0x80000000")]
        public const uint CRYPT_OID_PUBKEY_SIGN_ONLY_FLAG = 0x80000000;

        [NativeTypeName("#define CRYPT_OID_PUBKEY_ENCRYPT_ONLY_FLAG 0x40000000")]
        public const int CRYPT_OID_PUBKEY_ENCRYPT_ONLY_FLAG = 0x40000000;

        [NativeTypeName("#define CRYPT_OID_USE_CURVE_NAME_FOR_ENCODE_FLAG 0x20000000")]
        public const int CRYPT_OID_USE_CURVE_NAME_FOR_ENCODE_FLAG = 0x20000000;

        [NativeTypeName("#define CRYPT_OID_USE_CURVE_PARAMETERS_FOR_ENCODE_FLAG 0x10000000")]
        public const int CRYPT_OID_USE_CURVE_PARAMETERS_FOR_ENCODE_FLAG = 0x10000000;

        [NativeTypeName("#define CRYPT_OID_INFO_OID_KEY 1")]
        public const int CRYPT_OID_INFO_OID_KEY = 1;

        [NativeTypeName("#define CRYPT_OID_INFO_NAME_KEY 2")]
        public const int CRYPT_OID_INFO_NAME_KEY = 2;

        [NativeTypeName("#define CRYPT_OID_INFO_ALGID_KEY 3")]
        public const int CRYPT_OID_INFO_ALGID_KEY = 3;

        [NativeTypeName("#define CRYPT_OID_INFO_SIGN_KEY 4")]
        public const int CRYPT_OID_INFO_SIGN_KEY = 4;

        [NativeTypeName("#define CRYPT_OID_INFO_CNG_ALGID_KEY 5")]
        public const int CRYPT_OID_INFO_CNG_ALGID_KEY = 5;

        [NativeTypeName("#define CRYPT_OID_INFO_CNG_SIGN_KEY 6")]
        public const int CRYPT_OID_INFO_CNG_SIGN_KEY = 6;

        [NativeTypeName("#define CRYPT_OID_INFO_OID_KEY_FLAGS_MASK 0xFFFF0000")]
        public const uint CRYPT_OID_INFO_OID_KEY_FLAGS_MASK = 0xFFFF0000;

        [NativeTypeName("#define CRYPT_OID_INFO_PUBKEY_SIGN_KEY_FLAG 0x80000000")]
        public const uint CRYPT_OID_INFO_PUBKEY_SIGN_KEY_FLAG = 0x80000000;

        [NativeTypeName("#define CRYPT_OID_INFO_PUBKEY_ENCRYPT_KEY_FLAG 0x40000000")]
        public const int CRYPT_OID_INFO_PUBKEY_ENCRYPT_KEY_FLAG = 0x40000000;

        [NativeTypeName("#define CRYPT_OID_DISABLE_SEARCH_DS_FLAG 0x80000000")]
        public const uint CRYPT_OID_DISABLE_SEARCH_DS_FLAG = 0x80000000;

        [NativeTypeName("#define CRYPT_OID_INFO_OID_GROUP_BIT_LEN_MASK 0x0FFF0000")]
        public const int CRYPT_OID_INFO_OID_GROUP_BIT_LEN_MASK = 0x0FFF0000;

        [NativeTypeName("#define CRYPT_OID_INFO_OID_GROUP_BIT_LEN_SHIFT 16")]
        public const int CRYPT_OID_INFO_OID_GROUP_BIT_LEN_SHIFT = 16;

        [NativeTypeName("#define CRYPT_INSTALL_OID_INFO_BEFORE_FLAG 1")]
        public const int CRYPT_INSTALL_OID_INFO_BEFORE_FLAG = 1;

        [NativeTypeName("#define CRYPT_LOCALIZED_NAME_ENCODING_TYPE 0")]
        public const int CRYPT_LOCALIZED_NAME_ENCODING_TYPE = 0;

        [NativeTypeName("#define CRYPT_LOCALIZED_NAME_OID \"LocalizedNames\"")]
        public static ReadOnlySpan<byte> CRYPT_LOCALIZED_NAME_OID => new byte[] { 0x4C, 0x6F, 0x63, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x64, 0x4E, 0x61, 0x6D, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define CERT_STRONG_SIGN_ECDSA_ALGORITHM L\"ECDSA\"")]
        public const string CERT_STRONG_SIGN_ECDSA_ALGORITHM = "ECDSA";

        [NativeTypeName("#define CERT_STRONG_SIGN_SERIALIZED_INFO_CHOICE 1")]
        public const int CERT_STRONG_SIGN_SERIALIZED_INFO_CHOICE = 1;

        [NativeTypeName("#define CERT_STRONG_SIGN_OID_INFO_CHOICE 2")]
        public const int CERT_STRONG_SIGN_OID_INFO_CHOICE = 2;

        [NativeTypeName("#define CERT_STRONG_SIGN_ENABLE_CRL_CHECK 0x1")]
        public const int CERT_STRONG_SIGN_ENABLE_CRL_CHECK = 0x1;

        [NativeTypeName("#define CERT_STRONG_SIGN_ENABLE_OCSP_CHECK 0x2")]
        public const int CERT_STRONG_SIGN_ENABLE_OCSP_CHECK = 0x2;

        [NativeTypeName("#define szOID_CERT_STRONG_SIGN_OS_PREFIX \"1.3.6.1.4.1.311.72.1.\"")]
        public static ReadOnlySpan<byte> szOID_CERT_STRONG_SIGN_OS_PREFIX => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x32, 0x2E, 0x31, 0x2E, 0x00 };

        [NativeTypeName("#define szOID_CERT_STRONG_SIGN_OS_1 \"1.3.6.1.4.1.311.72.1.1\"")]
        public static ReadOnlySpan<byte> szOID_CERT_STRONG_SIGN_OS_1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_CERT_STRONG_SIGN_OS_CURRENT szOID_CERT_STRONG_SIGN_OS_1")]
        public static ReadOnlySpan<byte> szOID_CERT_STRONG_SIGN_OS_CURRENT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_CERT_STRONG_KEY_OS_PREFIX \"1.3.6.1.4.1.311.72.2.\"")]
        public static ReadOnlySpan<byte> szOID_CERT_STRONG_KEY_OS_PREFIX => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x32, 0x2E, 0x32, 0x2E, 0x00 };

        [NativeTypeName("#define szOID_CERT_STRONG_KEY_OS_1 \"1.3.6.1.4.1.311.72.2.1\"")]
        public static ReadOnlySpan<byte> szOID_CERT_STRONG_KEY_OS_1 => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x32, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_CERT_STRONG_KEY_OS_CURRENT szOID_CERT_STRONG_KEY_OS_1")]
        public static ReadOnlySpan<byte> szOID_CERT_STRONG_KEY_OS_CURRENT => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x37, 0x32, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_PKCS_7_DATA \"1.2.840.113549.1.7.1\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_7_DATA => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_PKCS_7_SIGNED \"1.2.840.113549.1.7.2\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_7_SIGNED => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_PKCS_7_ENVELOPED \"1.2.840.113549.1.7.3\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_7_ENVELOPED => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_PKCS_7_SIGNEDANDENVELOPED \"1.2.840.113549.1.7.4\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_7_SIGNEDANDENVELOPED => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_PKCS_7_DIGESTED \"1.2.840.113549.1.7.5\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_7_DIGESTED => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_PKCS_7_ENCRYPTED \"1.2.840.113549.1.7.6\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_7_ENCRYPTED => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x37, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_PKCS_9_CONTENT_TYPE \"1.2.840.113549.1.9.3\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_9_CONTENT_TYPE => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_PKCS_9_MESSAGE_DIGEST \"1.2.840.113549.1.9.4\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_9_MESSAGE_DIGEST => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x39, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define CMSG_DATA 1")]
        public const int CMSG_DATA = 1;

        [NativeTypeName("#define CMSG_SIGNED 2")]
        public const int CMSG_SIGNED = 2;

        [NativeTypeName("#define CMSG_ENVELOPED 3")]
        public const int CMSG_ENVELOPED = 3;

        [NativeTypeName("#define CMSG_SIGNED_AND_ENVELOPED 4")]
        public const int CMSG_SIGNED_AND_ENVELOPED = 4;

        [NativeTypeName("#define CMSG_HASHED 5")]
        public const int CMSG_HASHED = 5;

        [NativeTypeName("#define CMSG_ENCRYPTED 6")]
        public const int CMSG_ENCRYPTED = 6;

        [NativeTypeName("#define CMSG_ALL_FLAGS (~0UL)")]
        public const uint CMSG_ALL_FLAGS = (~0U);

        [NativeTypeName("#define CMSG_DATA_FLAG (1 << CMSG_DATA)")]
        public const int CMSG_DATA_FLAG = (1 << 1);

        [NativeTypeName("#define CMSG_SIGNED_FLAG (1 << CMSG_SIGNED)")]
        public const int CMSG_SIGNED_FLAG = (1 << 2);

        [NativeTypeName("#define CMSG_ENVELOPED_FLAG (1 << CMSG_ENVELOPED)")]
        public const int CMSG_ENVELOPED_FLAG = (1 << 3);

        [NativeTypeName("#define CMSG_SIGNED_AND_ENVELOPED_FLAG (1 << CMSG_SIGNED_AND_ENVELOPED)")]
        public const int CMSG_SIGNED_AND_ENVELOPED_FLAG = (1 << 4);

        [NativeTypeName("#define CMSG_HASHED_FLAG (1 << CMSG_HASHED)")]
        public const int CMSG_HASHED_FLAG = (1 << 5);

        [NativeTypeName("#define CMSG_ENCRYPTED_FLAG (1 << CMSG_ENCRYPTED)")]
        public const int CMSG_ENCRYPTED_FLAG = (1 << 6);

        [NativeTypeName("#define CERT_ID_ISSUER_SERIAL_NUMBER 1")]
        public const int CERT_ID_ISSUER_SERIAL_NUMBER = 1;

        [NativeTypeName("#define CERT_ID_KEY_IDENTIFIER 2")]
        public const int CERT_ID_KEY_IDENTIFIER = 2;

        [NativeTypeName("#define CERT_ID_SHA1_HASH 3")]
        public const int CERT_ID_SHA1_HASH = 3;

        [NativeTypeName("#define CMSG_KEY_AGREE_EPHEMERAL_KEY_CHOICE 1")]
        public const int CMSG_KEY_AGREE_EPHEMERAL_KEY_CHOICE = 1;

        [NativeTypeName("#define CMSG_KEY_AGREE_STATIC_KEY_CHOICE 2")]
        public const int CMSG_KEY_AGREE_STATIC_KEY_CHOICE = 2;

        [NativeTypeName("#define CMSG_MAIL_LIST_HANDLE_KEY_CHOICE 1")]
        public const int CMSG_MAIL_LIST_HANDLE_KEY_CHOICE = 1;

        [NativeTypeName("#define CMSG_KEY_TRANS_RECIPIENT 1")]
        public const int CMSG_KEY_TRANS_RECIPIENT = 1;

        [NativeTypeName("#define CMSG_KEY_AGREE_RECIPIENT 2")]
        public const int CMSG_KEY_AGREE_RECIPIENT = 2;

        [NativeTypeName("#define CMSG_MAIL_LIST_RECIPIENT 3")]
        public const int CMSG_MAIL_LIST_RECIPIENT = 3;

        [NativeTypeName("#define CMSG_SP3_COMPATIBLE_ENCRYPT_FLAG 0x80000000")]
        public const uint CMSG_SP3_COMPATIBLE_ENCRYPT_FLAG = 0x80000000;

        [NativeTypeName("#define CMSG_RC4_NO_SALT_FLAG 0x40000000")]
        public const int CMSG_RC4_NO_SALT_FLAG = 0x40000000;

        [NativeTypeName("#define CMSG_INDEFINITE_LENGTH (0xFFFFFFFF)")]
        public const uint CMSG_INDEFINITE_LENGTH = (0xFFFFFFFF);

        [NativeTypeName("#define CMSG_BARE_CONTENT_FLAG 0x00000001")]
        public const int CMSG_BARE_CONTENT_FLAG = 0x00000001;

        [NativeTypeName("#define CMSG_LENGTH_ONLY_FLAG 0x00000002")]
        public const int CMSG_LENGTH_ONLY_FLAG = 0x00000002;

        [NativeTypeName("#define CMSG_DETACHED_FLAG 0x00000004")]
        public const int CMSG_DETACHED_FLAG = 0x00000004;

        [NativeTypeName("#define CMSG_AUTHENTICATED_ATTRIBUTES_FLAG 0x00000008")]
        public const int CMSG_AUTHENTICATED_ATTRIBUTES_FLAG = 0x00000008;

        [NativeTypeName("#define CMSG_CONTENTS_OCTETS_FLAG 0x00000010")]
        public const int CMSG_CONTENTS_OCTETS_FLAG = 0x00000010;

        [NativeTypeName("#define CMSG_MAX_LENGTH_FLAG 0x00000020")]
        public const int CMSG_MAX_LENGTH_FLAG = 0x00000020;

        [NativeTypeName("#define CMSG_CMS_ENCAPSULATED_CONTENT_FLAG 0x00000040")]
        public const int CMSG_CMS_ENCAPSULATED_CONTENT_FLAG = 0x00000040;

        [NativeTypeName("#define CMSG_SIGNED_DATA_NO_SIGN_FLAG 0x00000080")]
        public const int CMSG_SIGNED_DATA_NO_SIGN_FLAG = 0x00000080;

        [NativeTypeName("#define CMSG_CRYPT_RELEASE_CONTEXT_FLAG 0x00008000")]
        public const int CMSG_CRYPT_RELEASE_CONTEXT_FLAG = 0x00008000;

        [NativeTypeName("#define CMSG_TYPE_PARAM 1")]
        public const int CMSG_TYPE_PARAM = 1;

        [NativeTypeName("#define CMSG_CONTENT_PARAM 2")]
        public const int CMSG_CONTENT_PARAM = 2;

        [NativeTypeName("#define CMSG_BARE_CONTENT_PARAM 3")]
        public const int CMSG_BARE_CONTENT_PARAM = 3;

        [NativeTypeName("#define CMSG_INNER_CONTENT_TYPE_PARAM 4")]
        public const int CMSG_INNER_CONTENT_TYPE_PARAM = 4;

        [NativeTypeName("#define CMSG_SIGNER_COUNT_PARAM 5")]
        public const int CMSG_SIGNER_COUNT_PARAM = 5;

        [NativeTypeName("#define CMSG_SIGNER_INFO_PARAM 6")]
        public const int CMSG_SIGNER_INFO_PARAM = 6;

        [NativeTypeName("#define CMSG_SIGNER_CERT_INFO_PARAM 7")]
        public const int CMSG_SIGNER_CERT_INFO_PARAM = 7;

        [NativeTypeName("#define CMSG_SIGNER_HASH_ALGORITHM_PARAM 8")]
        public const int CMSG_SIGNER_HASH_ALGORITHM_PARAM = 8;

        [NativeTypeName("#define CMSG_SIGNER_AUTH_ATTR_PARAM 9")]
        public const int CMSG_SIGNER_AUTH_ATTR_PARAM = 9;

        [NativeTypeName("#define CMSG_SIGNER_UNAUTH_ATTR_PARAM 10")]
        public const int CMSG_SIGNER_UNAUTH_ATTR_PARAM = 10;

        [NativeTypeName("#define CMSG_CERT_COUNT_PARAM 11")]
        public const int CMSG_CERT_COUNT_PARAM = 11;

        [NativeTypeName("#define CMSG_CERT_PARAM 12")]
        public const int CMSG_CERT_PARAM = 12;

        [NativeTypeName("#define CMSG_CRL_COUNT_PARAM 13")]
        public const int CMSG_CRL_COUNT_PARAM = 13;

        [NativeTypeName("#define CMSG_CRL_PARAM 14")]
        public const int CMSG_CRL_PARAM = 14;

        [NativeTypeName("#define CMSG_ENVELOPE_ALGORITHM_PARAM 15")]
        public const int CMSG_ENVELOPE_ALGORITHM_PARAM = 15;

        [NativeTypeName("#define CMSG_RECIPIENT_COUNT_PARAM 17")]
        public const int CMSG_RECIPIENT_COUNT_PARAM = 17;

        [NativeTypeName("#define CMSG_RECIPIENT_INDEX_PARAM 18")]
        public const int CMSG_RECIPIENT_INDEX_PARAM = 18;

        [NativeTypeName("#define CMSG_RECIPIENT_INFO_PARAM 19")]
        public const int CMSG_RECIPIENT_INFO_PARAM = 19;

        [NativeTypeName("#define CMSG_HASH_ALGORITHM_PARAM 20")]
        public const int CMSG_HASH_ALGORITHM_PARAM = 20;

        [NativeTypeName("#define CMSG_HASH_DATA_PARAM 21")]
        public const int CMSG_HASH_DATA_PARAM = 21;

        [NativeTypeName("#define CMSG_COMPUTED_HASH_PARAM 22")]
        public const int CMSG_COMPUTED_HASH_PARAM = 22;

        [NativeTypeName("#define CMSG_ENCRYPT_PARAM 26")]
        public const int CMSG_ENCRYPT_PARAM = 26;

        [NativeTypeName("#define CMSG_ENCRYPTED_DIGEST 27")]
        public const int CMSG_ENCRYPTED_DIGEST = 27;

        [NativeTypeName("#define CMSG_ENCODED_SIGNER 28")]
        public const int CMSG_ENCODED_SIGNER = 28;

        [NativeTypeName("#define CMSG_ENCODED_MESSAGE 29")]
        public const int CMSG_ENCODED_MESSAGE = 29;

        [NativeTypeName("#define CMSG_VERSION_PARAM 30")]
        public const int CMSG_VERSION_PARAM = 30;

        [NativeTypeName("#define CMSG_ATTR_CERT_COUNT_PARAM 31")]
        public const int CMSG_ATTR_CERT_COUNT_PARAM = 31;

        [NativeTypeName("#define CMSG_ATTR_CERT_PARAM 32")]
        public const int CMSG_ATTR_CERT_PARAM = 32;

        [NativeTypeName("#define CMSG_CMS_RECIPIENT_COUNT_PARAM 33")]
        public const int CMSG_CMS_RECIPIENT_COUNT_PARAM = 33;

        [NativeTypeName("#define CMSG_CMS_RECIPIENT_INDEX_PARAM 34")]
        public const int CMSG_CMS_RECIPIENT_INDEX_PARAM = 34;

        [NativeTypeName("#define CMSG_CMS_RECIPIENT_ENCRYPTED_KEY_INDEX_PARAM 35")]
        public const int CMSG_CMS_RECIPIENT_ENCRYPTED_KEY_INDEX_PARAM = 35;

        [NativeTypeName("#define CMSG_CMS_RECIPIENT_INFO_PARAM 36")]
        public const int CMSG_CMS_RECIPIENT_INFO_PARAM = 36;

        [NativeTypeName("#define CMSG_UNPROTECTED_ATTR_PARAM 37")]
        public const int CMSG_UNPROTECTED_ATTR_PARAM = 37;

        [NativeTypeName("#define CMSG_SIGNER_CERT_ID_PARAM 38")]
        public const int CMSG_SIGNER_CERT_ID_PARAM = 38;

        [NativeTypeName("#define CMSG_CMS_SIGNER_INFO_PARAM 39")]
        public const int CMSG_CMS_SIGNER_INFO_PARAM = 39;

        [NativeTypeName("#define CMSG_SIGNED_DATA_V1 1")]
        public const int CMSG_SIGNED_DATA_V1 = 1;

        [NativeTypeName("#define CMSG_SIGNED_DATA_V3 3")]
        public const int CMSG_SIGNED_DATA_V3 = 3;

        [NativeTypeName("#define CMSG_SIGNED_DATA_PKCS_1_5_VERSION CMSG_SIGNED_DATA_V1")]
        public const int CMSG_SIGNED_DATA_PKCS_1_5_VERSION = 1;

        [NativeTypeName("#define CMSG_SIGNED_DATA_CMS_VERSION CMSG_SIGNED_DATA_V3")]
        public const int CMSG_SIGNED_DATA_CMS_VERSION = 3;

        [NativeTypeName("#define CMSG_SIGNER_INFO_V1 1")]
        public const int CMSG_SIGNER_INFO_V1 = 1;

        [NativeTypeName("#define CMSG_SIGNER_INFO_V3 3")]
        public const int CMSG_SIGNER_INFO_V3 = 3;

        [NativeTypeName("#define CMSG_SIGNER_INFO_PKCS_1_5_VERSION CMSG_SIGNER_INFO_V1")]
        public const int CMSG_SIGNER_INFO_PKCS_1_5_VERSION = 1;

        [NativeTypeName("#define CMSG_SIGNER_INFO_CMS_VERSION CMSG_SIGNER_INFO_V3")]
        public const int CMSG_SIGNER_INFO_CMS_VERSION = 3;

        [NativeTypeName("#define CMSG_HASHED_DATA_V0 0")]
        public const int CMSG_HASHED_DATA_V0 = 0;

        [NativeTypeName("#define CMSG_HASHED_DATA_V2 2")]
        public const int CMSG_HASHED_DATA_V2 = 2;

        [NativeTypeName("#define CMSG_HASHED_DATA_PKCS_1_5_VERSION CMSG_HASHED_DATA_V0")]
        public const int CMSG_HASHED_DATA_PKCS_1_5_VERSION = 0;

        [NativeTypeName("#define CMSG_HASHED_DATA_CMS_VERSION CMSG_HASHED_DATA_V2")]
        public const int CMSG_HASHED_DATA_CMS_VERSION = 2;

        [NativeTypeName("#define CMSG_ENVELOPED_DATA_V0 0")]
        public const int CMSG_ENVELOPED_DATA_V0 = 0;

        [NativeTypeName("#define CMSG_ENVELOPED_DATA_V2 2")]
        public const int CMSG_ENVELOPED_DATA_V2 = 2;

        [NativeTypeName("#define CMSG_ENVELOPED_DATA_PKCS_1_5_VERSION CMSG_ENVELOPED_DATA_V0")]
        public const int CMSG_ENVELOPED_DATA_PKCS_1_5_VERSION = 0;

        [NativeTypeName("#define CMSG_ENVELOPED_DATA_CMS_VERSION CMSG_ENVELOPED_DATA_V2")]
        public const int CMSG_ENVELOPED_DATA_CMS_VERSION = 2;

        [NativeTypeName("#define CMSG_KEY_AGREE_ORIGINATOR_CERT 1")]
        public const int CMSG_KEY_AGREE_ORIGINATOR_CERT = 1;

        [NativeTypeName("#define CMSG_KEY_AGREE_ORIGINATOR_PUBLIC_KEY 2")]
        public const int CMSG_KEY_AGREE_ORIGINATOR_PUBLIC_KEY = 2;

        [NativeTypeName("#define CMSG_ENVELOPED_RECIPIENT_V0 0")]
        public const int CMSG_ENVELOPED_RECIPIENT_V0 = 0;

        [NativeTypeName("#define CMSG_ENVELOPED_RECIPIENT_V2 2")]
        public const int CMSG_ENVELOPED_RECIPIENT_V2 = 2;

        [NativeTypeName("#define CMSG_ENVELOPED_RECIPIENT_V3 3")]
        public const int CMSG_ENVELOPED_RECIPIENT_V3 = 3;

        [NativeTypeName("#define CMSG_ENVELOPED_RECIPIENT_V4 4")]
        public const int CMSG_ENVELOPED_RECIPIENT_V4 = 4;

        [NativeTypeName("#define CMSG_KEY_TRANS_PKCS_1_5_VERSION CMSG_ENVELOPED_RECIPIENT_V0")]
        public const int CMSG_KEY_TRANS_PKCS_1_5_VERSION = 0;

        [NativeTypeName("#define CMSG_KEY_TRANS_CMS_VERSION CMSG_ENVELOPED_RECIPIENT_V2")]
        public const int CMSG_KEY_TRANS_CMS_VERSION = 2;

        [NativeTypeName("#define CMSG_KEY_AGREE_VERSION CMSG_ENVELOPED_RECIPIENT_V3")]
        public const int CMSG_KEY_AGREE_VERSION = 3;

        [NativeTypeName("#define CMSG_MAIL_LIST_VERSION CMSG_ENVELOPED_RECIPIENT_V4")]
        public const int CMSG_MAIL_LIST_VERSION = 4;

        [NativeTypeName("#define CMSG_CTRL_VERIFY_SIGNATURE 1")]
        public const int CMSG_CTRL_VERIFY_SIGNATURE = 1;

        [NativeTypeName("#define CMSG_CTRL_DECRYPT 2")]
        public const int CMSG_CTRL_DECRYPT = 2;

        [NativeTypeName("#define CMSG_CTRL_VERIFY_HASH 5")]
        public const int CMSG_CTRL_VERIFY_HASH = 5;

        [NativeTypeName("#define CMSG_CTRL_ADD_SIGNER 6")]
        public const int CMSG_CTRL_ADD_SIGNER = 6;

        [NativeTypeName("#define CMSG_CTRL_DEL_SIGNER 7")]
        public const int CMSG_CTRL_DEL_SIGNER = 7;

        [NativeTypeName("#define CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR 8")]
        public const int CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR = 8;

        [NativeTypeName("#define CMSG_CTRL_DEL_SIGNER_UNAUTH_ATTR 9")]
        public const int CMSG_CTRL_DEL_SIGNER_UNAUTH_ATTR = 9;

        [NativeTypeName("#define CMSG_CTRL_ADD_CERT 10")]
        public const int CMSG_CTRL_ADD_CERT = 10;

        [NativeTypeName("#define CMSG_CTRL_DEL_CERT 11")]
        public const int CMSG_CTRL_DEL_CERT = 11;

        [NativeTypeName("#define CMSG_CTRL_ADD_CRL 12")]
        public const int CMSG_CTRL_ADD_CRL = 12;

        [NativeTypeName("#define CMSG_CTRL_DEL_CRL 13")]
        public const int CMSG_CTRL_DEL_CRL = 13;

        [NativeTypeName("#define CMSG_CTRL_ADD_ATTR_CERT 14")]
        public const int CMSG_CTRL_ADD_ATTR_CERT = 14;

        [NativeTypeName("#define CMSG_CTRL_DEL_ATTR_CERT 15")]
        public const int CMSG_CTRL_DEL_ATTR_CERT = 15;

        [NativeTypeName("#define CMSG_CTRL_KEY_TRANS_DECRYPT 16")]
        public const int CMSG_CTRL_KEY_TRANS_DECRYPT = 16;

        [NativeTypeName("#define CMSG_CTRL_KEY_AGREE_DECRYPT 17")]
        public const int CMSG_CTRL_KEY_AGREE_DECRYPT = 17;

        [NativeTypeName("#define CMSG_CTRL_MAIL_LIST_DECRYPT 18")]
        public const int CMSG_CTRL_MAIL_LIST_DECRYPT = 18;

        [NativeTypeName("#define CMSG_CTRL_VERIFY_SIGNATURE_EX 19")]
        public const int CMSG_CTRL_VERIFY_SIGNATURE_EX = 19;

        [NativeTypeName("#define CMSG_CTRL_ADD_CMS_SIGNER_INFO 20")]
        public const int CMSG_CTRL_ADD_CMS_SIGNER_INFO = 20;

        [NativeTypeName("#define CMSG_CTRL_ENABLE_STRONG_SIGNATURE 21")]
        public const int CMSG_CTRL_ENABLE_STRONG_SIGNATURE = 21;

        [NativeTypeName("#define CMSG_VERIFY_SIGNER_PUBKEY 1")]
        public const int CMSG_VERIFY_SIGNER_PUBKEY = 1;

        [NativeTypeName("#define CMSG_VERIFY_SIGNER_CERT 2")]
        public const int CMSG_VERIFY_SIGNER_CERT = 2;

        [NativeTypeName("#define CMSG_VERIFY_SIGNER_CHAIN 3")]
        public const int CMSG_VERIFY_SIGNER_CHAIN = 3;

        [NativeTypeName("#define CMSG_VERIFY_SIGNER_NULL 4")]
        public const int CMSG_VERIFY_SIGNER_NULL = 4;

        [NativeTypeName("#define CMSG_VERIFY_COUNTER_SIGN_ENABLE_STRONG_FLAG 0x00000001")]
        public const int CMSG_VERIFY_COUNTER_SIGN_ENABLE_STRONG_FLAG = 0x00000001;

        [NativeTypeName("#define CMSG_OID_GEN_ENCRYPT_KEY_FUNC \"CryptMsgDllGenEncryptKey\"")]
        public static ReadOnlySpan<byte> CMSG_OID_GEN_ENCRYPT_KEY_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x47, 0x65, 0x6E, 0x45, 0x6E, 0x63, 0x72, 0x79, 0x70, 0x74, 0x4B, 0x65, 0x79, 0x00 };

        [NativeTypeName("#define CMSG_OID_EXPORT_ENCRYPT_KEY_FUNC \"CryptMsgDllExportEncryptKey\"")]
        public static ReadOnlySpan<byte> CMSG_OID_EXPORT_ENCRYPT_KEY_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x45, 0x6E, 0x63, 0x72, 0x79, 0x70, 0x74, 0x4B, 0x65, 0x79, 0x00 };

        [NativeTypeName("#define CMSG_OID_IMPORT_ENCRYPT_KEY_FUNC \"CryptMsgDllImportEncryptKey\"")]
        public static ReadOnlySpan<byte> CMSG_OID_IMPORT_ENCRYPT_KEY_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x45, 0x6E, 0x63, 0x72, 0x79, 0x70, 0x74, 0x4B, 0x65, 0x79, 0x00 };

        [NativeTypeName("#define CMSG_DEFAULT_INSTALLABLE_FUNC_OID ((LPCSTR) 1)")]
        public static sbyte* CMSG_DEFAULT_INSTALLABLE_FUNC_OID => ((sbyte*)(1));

        [NativeTypeName("#define CMSG_CONTENT_ENCRYPT_PAD_ENCODED_LEN_FLAG 0x00000001")]
        public const int CMSG_CONTENT_ENCRYPT_PAD_ENCODED_LEN_FLAG = 0x00000001;

        [NativeTypeName("#define CMSG_CONTENT_ENCRYPT_FREE_PARA_FLAG 0x00000001")]
        public const int CMSG_CONTENT_ENCRYPT_FREE_PARA_FLAG = 0x00000001;

        [NativeTypeName("#define CMSG_CONTENT_ENCRYPT_FREE_OBJID_FLAG 0x00000002")]
        public const int CMSG_CONTENT_ENCRYPT_FREE_OBJID_FLAG = 0x00000002;

        [NativeTypeName("#define CMSG_CONTENT_ENCRYPT_RELEASE_CONTEXT_FLAG 0x00008000")]
        public const int CMSG_CONTENT_ENCRYPT_RELEASE_CONTEXT_FLAG = 0x00008000;

        [NativeTypeName("#define CMSG_OID_GEN_CONTENT_ENCRYPT_KEY_FUNC \"CryptMsgDllGenContentEncryptKey\"")]
        public static ReadOnlySpan<byte> CMSG_OID_GEN_CONTENT_ENCRYPT_KEY_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x47, 0x65, 0x6E, 0x43, 0x6F, 0x6E, 0x74, 0x65, 0x6E, 0x74, 0x45, 0x6E, 0x63, 0x72, 0x79, 0x70, 0x74, 0x4B, 0x65, 0x79, 0x00 };

        [NativeTypeName("#define CMSG_OID_CAPI1_GEN_CONTENT_ENCRYPT_KEY_FUNC CMSG_OID_GEN_CONTENT_ENCRYPT_KEY_FUNC")]
        public static ReadOnlySpan<byte> CMSG_OID_CAPI1_GEN_CONTENT_ENCRYPT_KEY_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x47, 0x65, 0x6E, 0x43, 0x6F, 0x6E, 0x74, 0x65, 0x6E, 0x74, 0x45, 0x6E, 0x63, 0x72, 0x79, 0x70, 0x74, 0x4B, 0x65, 0x79, 0x00 };

        [NativeTypeName("#define CMSG_OID_CNG_GEN_CONTENT_ENCRYPT_KEY_FUNC \"CryptMsgDllCNGGenContentEncryptKey\"")]
        public static ReadOnlySpan<byte> CMSG_OID_CNG_GEN_CONTENT_ENCRYPT_KEY_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x43, 0x4E, 0x47, 0x47, 0x65, 0x6E, 0x43, 0x6F, 0x6E, 0x74, 0x65, 0x6E, 0x74, 0x45, 0x6E, 0x63, 0x72, 0x79, 0x70, 0x74, 0x4B, 0x65, 0x79, 0x00 };

        [NativeTypeName("#define CMSG_KEY_TRANS_ENCRYPT_FREE_PARA_FLAG 0x00000001")]
        public const int CMSG_KEY_TRANS_ENCRYPT_FREE_PARA_FLAG = 0x00000001;

        [NativeTypeName("#define CMSG_KEY_TRANS_ENCRYPT_FREE_OBJID_FLAG 0x00000002")]
        public const int CMSG_KEY_TRANS_ENCRYPT_FREE_OBJID_FLAG = 0x00000002;

        [NativeTypeName("#define CMSG_OID_EXPORT_KEY_TRANS_FUNC \"CryptMsgDllExportKeyTrans\"")]
        public static ReadOnlySpan<byte> CMSG_OID_EXPORT_KEY_TRANS_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x54, 0x72, 0x61, 0x6E, 0x73, 0x00 };

        [NativeTypeName("#define CMSG_OID_CAPI1_EXPORT_KEY_TRANS_FUNC CMSG_OID_EXPORT_KEY_TRANS_FUNC")]
        public static ReadOnlySpan<byte> CMSG_OID_CAPI1_EXPORT_KEY_TRANS_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x54, 0x72, 0x61, 0x6E, 0x73, 0x00 };

        [NativeTypeName("#define CMSG_OID_CNG_EXPORT_KEY_TRANS_FUNC \"CryptMsgDllCNGExportKeyTrans\"")]
        public static ReadOnlySpan<byte> CMSG_OID_CNG_EXPORT_KEY_TRANS_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x43, 0x4E, 0x47, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x54, 0x72, 0x61, 0x6E, 0x73, 0x00 };

        [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_PARA_FLAG 0x00000001")]
        public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PARA_FLAG = 0x00000001;

        [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_MATERIAL_FLAG 0x00000002")]
        public const int CMSG_KEY_AGREE_ENCRYPT_FREE_MATERIAL_FLAG = 0x00000002;

        [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_ALG_FLAG 0x00000004")]
        public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_ALG_FLAG = 0x00000004;

        [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_PARA_FLAG 0x00000008")]
        public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_PARA_FLAG = 0x00000008;

        [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_BITS_FLAG 0x00000010")]
        public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_BITS_FLAG = 0x00000010;

        [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_OBJID_FLAG 0x00000020")]
        public const int CMSG_KEY_AGREE_ENCRYPT_FREE_OBJID_FLAG = 0x00000020;

        [NativeTypeName("#define CMSG_OID_EXPORT_KEY_AGREE_FUNC \"CryptMsgDllExportKeyAgree\"")]
        public static ReadOnlySpan<byte> CMSG_OID_EXPORT_KEY_AGREE_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x41, 0x67, 0x72, 0x65, 0x65, 0x00 };

        [NativeTypeName("#define CMSG_OID_CAPI1_EXPORT_KEY_AGREE_FUNC CMSG_OID_EXPORT_KEY_AGREE_FUNC")]
        public static ReadOnlySpan<byte> CMSG_OID_CAPI1_EXPORT_KEY_AGREE_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x41, 0x67, 0x72, 0x65, 0x65, 0x00 };

        [NativeTypeName("#define CMSG_OID_CNG_EXPORT_KEY_AGREE_FUNC \"CryptMsgDllCNGExportKeyAgree\"")]
        public static ReadOnlySpan<byte> CMSG_OID_CNG_EXPORT_KEY_AGREE_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x43, 0x4E, 0x47, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x41, 0x67, 0x72, 0x65, 0x65, 0x00 };

        [NativeTypeName("#define CMSG_MAIL_LIST_ENCRYPT_FREE_PARA_FLAG 0x00000001")]
        public const int CMSG_MAIL_LIST_ENCRYPT_FREE_PARA_FLAG = 0x00000001;

        [NativeTypeName("#define CMSG_MAIL_LIST_ENCRYPT_FREE_OBJID_FLAG 0x00000002")]
        public const int CMSG_MAIL_LIST_ENCRYPT_FREE_OBJID_FLAG = 0x00000002;

        [NativeTypeName("#define CMSG_OID_EXPORT_MAIL_LIST_FUNC \"CryptMsgDllExportMailList\"")]
        public static ReadOnlySpan<byte> CMSG_OID_EXPORT_MAIL_LIST_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x4D, 0x61, 0x69, 0x6C, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        [NativeTypeName("#define CMSG_OID_CAPI1_EXPORT_MAIL_LIST_FUNC CMSG_OID_EXPORT_MAIL_LIST_FUNC")]
        public static ReadOnlySpan<byte> CMSG_OID_CAPI1_EXPORT_MAIL_LIST_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x4D, 0x61, 0x69, 0x6C, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        [NativeTypeName("#define CMSG_OID_IMPORT_KEY_TRANS_FUNC \"CryptMsgDllImportKeyTrans\"")]
        public static ReadOnlySpan<byte> CMSG_OID_IMPORT_KEY_TRANS_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x54, 0x72, 0x61, 0x6E, 0x73, 0x00 };

        [NativeTypeName("#define CMSG_OID_CAPI1_IMPORT_KEY_TRANS_FUNC CMSG_OID_IMPORT_KEY_TRANS_FUNC")]
        public static ReadOnlySpan<byte> CMSG_OID_CAPI1_IMPORT_KEY_TRANS_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x54, 0x72, 0x61, 0x6E, 0x73, 0x00 };

        [NativeTypeName("#define CMSG_OID_IMPORT_KEY_AGREE_FUNC \"CryptMsgDllImportKeyAgree\"")]
        public static ReadOnlySpan<byte> CMSG_OID_IMPORT_KEY_AGREE_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x41, 0x67, 0x72, 0x65, 0x65, 0x00 };

        [NativeTypeName("#define CMSG_OID_CAPI1_IMPORT_KEY_AGREE_FUNC CMSG_OID_IMPORT_KEY_AGREE_FUNC")]
        public static ReadOnlySpan<byte> CMSG_OID_CAPI1_IMPORT_KEY_AGREE_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x41, 0x67, 0x72, 0x65, 0x65, 0x00 };

        [NativeTypeName("#define CMSG_OID_IMPORT_MAIL_LIST_FUNC \"CryptMsgDllImportMailList\"")]
        public static ReadOnlySpan<byte> CMSG_OID_IMPORT_MAIL_LIST_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x4D, 0x61, 0x69, 0x6C, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        [NativeTypeName("#define CMSG_OID_CAPI1_IMPORT_MAIL_LIST_FUNC CMSG_OID_IMPORT_MAIL_LIST_FUNC")]
        public static ReadOnlySpan<byte> CMSG_OID_CAPI1_IMPORT_MAIL_LIST_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x4D, 0x61, 0x69, 0x6C, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        [NativeTypeName("#define CMSG_OID_CNG_IMPORT_KEY_TRANS_FUNC \"CryptMsgDllCNGImportKeyTrans\"")]
        public static ReadOnlySpan<byte> CMSG_OID_CNG_IMPORT_KEY_TRANS_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x43, 0x4E, 0x47, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x54, 0x72, 0x61, 0x6E, 0x73, 0x00 };

        [NativeTypeName("#define CMSG_OID_CNG_IMPORT_KEY_AGREE_FUNC \"CryptMsgDllCNGImportKeyAgree\"")]
        public static ReadOnlySpan<byte> CMSG_OID_CNG_IMPORT_KEY_AGREE_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x43, 0x4E, 0x47, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x4B, 0x65, 0x79, 0x41, 0x67, 0x72, 0x65, 0x65, 0x00 };

        [NativeTypeName("#define CMSG_OID_CNG_IMPORT_CONTENT_ENCRYPT_KEY_FUNC \"CryptMsgDllCNGImportContentEncryptKey\"")]
        public static ReadOnlySpan<byte> CMSG_OID_CNG_IMPORT_CONTENT_ENCRYPT_KEY_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x4D, 0x73, 0x67, 0x44, 0x6C, 0x6C, 0x43, 0x4E, 0x47, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x43, 0x6F, 0x6E, 0x74, 0x65, 0x6E, 0x74, 0x45, 0x6E, 0x63, 0x72, 0x79, 0x70, 0x74, 0x4B, 0x65, 0x79, 0x00 };

        [NativeTypeName("#define CERT_KEY_PROV_HANDLE_PROP_ID 1")]
        public const int CERT_KEY_PROV_HANDLE_PROP_ID = 1;

        [NativeTypeName("#define CERT_KEY_PROV_INFO_PROP_ID 2")]
        public const int CERT_KEY_PROV_INFO_PROP_ID = 2;

        [NativeTypeName("#define CERT_SHA1_HASH_PROP_ID 3")]
        public const int CERT_SHA1_HASH_PROP_ID = 3;

        [NativeTypeName("#define CERT_MD5_HASH_PROP_ID 4")]
        public const int CERT_MD5_HASH_PROP_ID = 4;

        [NativeTypeName("#define CERT_HASH_PROP_ID CERT_SHA1_HASH_PROP_ID")]
        public const int CERT_HASH_PROP_ID = 3;

        [NativeTypeName("#define CERT_KEY_CONTEXT_PROP_ID 5")]
        public const int CERT_KEY_CONTEXT_PROP_ID = 5;

        [NativeTypeName("#define CERT_KEY_SPEC_PROP_ID 6")]
        public const int CERT_KEY_SPEC_PROP_ID = 6;

        [NativeTypeName("#define CERT_IE30_RESERVED_PROP_ID 7")]
        public const int CERT_IE30_RESERVED_PROP_ID = 7;

        [NativeTypeName("#define CERT_PUBKEY_HASH_RESERVED_PROP_ID 8")]
        public const int CERT_PUBKEY_HASH_RESERVED_PROP_ID = 8;

        [NativeTypeName("#define CERT_ENHKEY_USAGE_PROP_ID 9")]
        public const int CERT_ENHKEY_USAGE_PROP_ID = 9;

        [NativeTypeName("#define CERT_CTL_USAGE_PROP_ID CERT_ENHKEY_USAGE_PROP_ID")]
        public const int CERT_CTL_USAGE_PROP_ID = 9;

        [NativeTypeName("#define CERT_NEXT_UPDATE_LOCATION_PROP_ID 10")]
        public const int CERT_NEXT_UPDATE_LOCATION_PROP_ID = 10;

        [NativeTypeName("#define CERT_FRIENDLY_NAME_PROP_ID 11")]
        public const int CERT_FRIENDLY_NAME_PROP_ID = 11;

        [NativeTypeName("#define CERT_PVK_FILE_PROP_ID 12")]
        public const int CERT_PVK_FILE_PROP_ID = 12;

        [NativeTypeName("#define CERT_DESCRIPTION_PROP_ID 13")]
        public const int CERT_DESCRIPTION_PROP_ID = 13;

        [NativeTypeName("#define CERT_ACCESS_STATE_PROP_ID 14")]
        public const int CERT_ACCESS_STATE_PROP_ID = 14;

        [NativeTypeName("#define CERT_SIGNATURE_HASH_PROP_ID 15")]
        public const int CERT_SIGNATURE_HASH_PROP_ID = 15;

        [NativeTypeName("#define CERT_SMART_CARD_DATA_PROP_ID 16")]
        public const int CERT_SMART_CARD_DATA_PROP_ID = 16;

        [NativeTypeName("#define CERT_EFS_PROP_ID 17")]
        public const int CERT_EFS_PROP_ID = 17;

        [NativeTypeName("#define CERT_FORTEZZA_DATA_PROP_ID 18")]
        public const int CERT_FORTEZZA_DATA_PROP_ID = 18;

        [NativeTypeName("#define CERT_ARCHIVED_PROP_ID 19")]
        public const int CERT_ARCHIVED_PROP_ID = 19;

        [NativeTypeName("#define CERT_KEY_IDENTIFIER_PROP_ID 20")]
        public const int CERT_KEY_IDENTIFIER_PROP_ID = 20;

        [NativeTypeName("#define CERT_AUTO_ENROLL_PROP_ID 21")]
        public const int CERT_AUTO_ENROLL_PROP_ID = 21;

        [NativeTypeName("#define CERT_PUBKEY_ALG_PARA_PROP_ID 22")]
        public const int CERT_PUBKEY_ALG_PARA_PROP_ID = 22;

        [NativeTypeName("#define CERT_CROSS_CERT_DIST_POINTS_PROP_ID 23")]
        public const int CERT_CROSS_CERT_DIST_POINTS_PROP_ID = 23;

        [NativeTypeName("#define CERT_ISSUER_PUBLIC_KEY_MD5_HASH_PROP_ID 24")]
        public const int CERT_ISSUER_PUBLIC_KEY_MD5_HASH_PROP_ID = 24;

        [NativeTypeName("#define CERT_SUBJECT_PUBLIC_KEY_MD5_HASH_PROP_ID 25")]
        public const int CERT_SUBJECT_PUBLIC_KEY_MD5_HASH_PROP_ID = 25;

        [NativeTypeName("#define CERT_ENROLLMENT_PROP_ID 26")]
        public const int CERT_ENROLLMENT_PROP_ID = 26;

        [NativeTypeName("#define CERT_DATE_STAMP_PROP_ID 27")]
        public const int CERT_DATE_STAMP_PROP_ID = 27;

        [NativeTypeName("#define CERT_ISSUER_SERIAL_NUMBER_MD5_HASH_PROP_ID 28")]
        public const int CERT_ISSUER_SERIAL_NUMBER_MD5_HASH_PROP_ID = 28;

        [NativeTypeName("#define CERT_SUBJECT_NAME_MD5_HASH_PROP_ID 29")]
        public const int CERT_SUBJECT_NAME_MD5_HASH_PROP_ID = 29;

        [NativeTypeName("#define CERT_EXTENDED_ERROR_INFO_PROP_ID 30")]
        public const int CERT_EXTENDED_ERROR_INFO_PROP_ID = 30;

        [NativeTypeName("#define CERT_RENEWAL_PROP_ID 64")]
        public const int CERT_RENEWAL_PROP_ID = 64;

        [NativeTypeName("#define CERT_ARCHIVED_KEY_HASH_PROP_ID 65")]
        public const int CERT_ARCHIVED_KEY_HASH_PROP_ID = 65;

        [NativeTypeName("#define CERT_AUTO_ENROLL_RETRY_PROP_ID 66")]
        public const int CERT_AUTO_ENROLL_RETRY_PROP_ID = 66;

        [NativeTypeName("#define CERT_AIA_URL_RETRIEVED_PROP_ID 67")]
        public const int CERT_AIA_URL_RETRIEVED_PROP_ID = 67;

        [NativeTypeName("#define CERT_AUTHORITY_INFO_ACCESS_PROP_ID 68")]
        public const int CERT_AUTHORITY_INFO_ACCESS_PROP_ID = 68;

        [NativeTypeName("#define CERT_BACKED_UP_PROP_ID 69")]
        public const int CERT_BACKED_UP_PROP_ID = 69;

        [NativeTypeName("#define CERT_OCSP_RESPONSE_PROP_ID 70")]
        public const int CERT_OCSP_RESPONSE_PROP_ID = 70;

        [NativeTypeName("#define CERT_REQUEST_ORIGINATOR_PROP_ID 71")]
        public const int CERT_REQUEST_ORIGINATOR_PROP_ID = 71;

        [NativeTypeName("#define CERT_SOURCE_LOCATION_PROP_ID 72")]
        public const int CERT_SOURCE_LOCATION_PROP_ID = 72;

        [NativeTypeName("#define CERT_SOURCE_URL_PROP_ID 73")]
        public const int CERT_SOURCE_URL_PROP_ID = 73;

        [NativeTypeName("#define CERT_NEW_KEY_PROP_ID 74")]
        public const int CERT_NEW_KEY_PROP_ID = 74;

        [NativeTypeName("#define CERT_OCSP_CACHE_PREFIX_PROP_ID 75")]
        public const int CERT_OCSP_CACHE_PREFIX_PROP_ID = 75;

        [NativeTypeName("#define CERT_SMART_CARD_ROOT_INFO_PROP_ID 76")]
        public const int CERT_SMART_CARD_ROOT_INFO_PROP_ID = 76;

        [NativeTypeName("#define CERT_NO_AUTO_EXPIRE_CHECK_PROP_ID 77")]
        public const int CERT_NO_AUTO_EXPIRE_CHECK_PROP_ID = 77;

        [NativeTypeName("#define CERT_NCRYPT_KEY_HANDLE_PROP_ID 78")]
        public const int CERT_NCRYPT_KEY_HANDLE_PROP_ID = 78;

        [NativeTypeName("#define CERT_HCRYPTPROV_OR_NCRYPT_KEY_HANDLE_PROP_ID 79")]
        public const int CERT_HCRYPTPROV_OR_NCRYPT_KEY_HANDLE_PROP_ID = 79;

        [NativeTypeName("#define CERT_SUBJECT_INFO_ACCESS_PROP_ID 80")]
        public const int CERT_SUBJECT_INFO_ACCESS_PROP_ID = 80;

        [NativeTypeName("#define CERT_CA_OCSP_AUTHORITY_INFO_ACCESS_PROP_ID 81")]
        public const int CERT_CA_OCSP_AUTHORITY_INFO_ACCESS_PROP_ID = 81;

        [NativeTypeName("#define CERT_CA_DISABLE_CRL_PROP_ID 82")]
        public const int CERT_CA_DISABLE_CRL_PROP_ID = 82;

        [NativeTypeName("#define CERT_ROOT_PROGRAM_CERT_POLICIES_PROP_ID 83")]
        public const int CERT_ROOT_PROGRAM_CERT_POLICIES_PROP_ID = 83;

        [NativeTypeName("#define CERT_ROOT_PROGRAM_NAME_CONSTRAINTS_PROP_ID 84")]
        public const int CERT_ROOT_PROGRAM_NAME_CONSTRAINTS_PROP_ID = 84;

        [NativeTypeName("#define CERT_SUBJECT_OCSP_AUTHORITY_INFO_ACCESS_PROP_ID 85")]
        public const int CERT_SUBJECT_OCSP_AUTHORITY_INFO_ACCESS_PROP_ID = 85;

        [NativeTypeName("#define CERT_SUBJECT_DISABLE_CRL_PROP_ID 86")]
        public const int CERT_SUBJECT_DISABLE_CRL_PROP_ID = 86;

        [NativeTypeName("#define CERT_CEP_PROP_ID 87")]
        public const int CERT_CEP_PROP_ID = 87;

        [NativeTypeName("#define CERT_SIGN_HASH_CNG_ALG_PROP_ID 89")]
        public const int CERT_SIGN_HASH_CNG_ALG_PROP_ID = 89;

        [NativeTypeName("#define CERT_SCARD_PIN_ID_PROP_ID 90")]
        public const int CERT_SCARD_PIN_ID_PROP_ID = 90;

        [NativeTypeName("#define CERT_SCARD_PIN_INFO_PROP_ID 91")]
        public const int CERT_SCARD_PIN_INFO_PROP_ID = 91;

        [NativeTypeName("#define CERT_SUBJECT_PUB_KEY_BIT_LENGTH_PROP_ID 92")]
        public const int CERT_SUBJECT_PUB_KEY_BIT_LENGTH_PROP_ID = 92;

        [NativeTypeName("#define CERT_PUB_KEY_CNG_ALG_BIT_LENGTH_PROP_ID 93")]
        public const int CERT_PUB_KEY_CNG_ALG_BIT_LENGTH_PROP_ID = 93;

        [NativeTypeName("#define CERT_ISSUER_PUB_KEY_BIT_LENGTH_PROP_ID 94")]
        public const int CERT_ISSUER_PUB_KEY_BIT_LENGTH_PROP_ID = 94;

        [NativeTypeName("#define CERT_ISSUER_CHAIN_SIGN_HASH_CNG_ALG_PROP_ID 95")]
        public const int CERT_ISSUER_CHAIN_SIGN_HASH_CNG_ALG_PROP_ID = 95;

        [NativeTypeName("#define CERT_ISSUER_CHAIN_PUB_KEY_CNG_ALG_BIT_LENGTH_PROP_ID 96")]
        public const int CERT_ISSUER_CHAIN_PUB_KEY_CNG_ALG_BIT_LENGTH_PROP_ID = 96;

        [NativeTypeName("#define CERT_NO_EXPIRE_NOTIFICATION_PROP_ID 97")]
        public const int CERT_NO_EXPIRE_NOTIFICATION_PROP_ID = 97;

        [NativeTypeName("#define CERT_AUTH_ROOT_SHA256_HASH_PROP_ID 98")]
        public const int CERT_AUTH_ROOT_SHA256_HASH_PROP_ID = 98;

        [NativeTypeName("#define CERT_NCRYPT_KEY_HANDLE_TRANSFER_PROP_ID 99")]
        public const int CERT_NCRYPT_KEY_HANDLE_TRANSFER_PROP_ID = 99;

        [NativeTypeName("#define CERT_HCRYPTPROV_TRANSFER_PROP_ID 100")]
        public const int CERT_HCRYPTPROV_TRANSFER_PROP_ID = 100;

        [NativeTypeName("#define CERT_SMART_CARD_READER_PROP_ID 101")]
        public const int CERT_SMART_CARD_READER_PROP_ID = 101;

        [NativeTypeName("#define CERT_SEND_AS_TRUSTED_ISSUER_PROP_ID 102")]
        public const int CERT_SEND_AS_TRUSTED_ISSUER_PROP_ID = 102;

        [NativeTypeName("#define CERT_KEY_REPAIR_ATTEMPTED_PROP_ID 103")]
        public const int CERT_KEY_REPAIR_ATTEMPTED_PROP_ID = 103;

        [NativeTypeName("#define CERT_DISALLOWED_FILETIME_PROP_ID 104")]
        public const int CERT_DISALLOWED_FILETIME_PROP_ID = 104;

        [NativeTypeName("#define CERT_ROOT_PROGRAM_CHAIN_POLICIES_PROP_ID 105")]
        public const int CERT_ROOT_PROGRAM_CHAIN_POLICIES_PROP_ID = 105;

        [NativeTypeName("#define CERT_SMART_CARD_READER_NON_REMOVABLE_PROP_ID 106")]
        public const int CERT_SMART_CARD_READER_NON_REMOVABLE_PROP_ID = 106;

        [NativeTypeName("#define CERT_SHA256_HASH_PROP_ID 107")]
        public const int CERT_SHA256_HASH_PROP_ID = 107;

        [NativeTypeName("#define CERT_SCEP_SERVER_CERTS_PROP_ID 108")]
        public const int CERT_SCEP_SERVER_CERTS_PROP_ID = 108;

        [NativeTypeName("#define CERT_SCEP_RA_SIGNATURE_CERT_PROP_ID 109")]
        public const int CERT_SCEP_RA_SIGNATURE_CERT_PROP_ID = 109;

        [NativeTypeName("#define CERT_SCEP_RA_ENCRYPTION_CERT_PROP_ID 110")]
        public const int CERT_SCEP_RA_ENCRYPTION_CERT_PROP_ID = 110;

        [NativeTypeName("#define CERT_SCEP_CA_CERT_PROP_ID 111")]
        public const int CERT_SCEP_CA_CERT_PROP_ID = 111;

        [NativeTypeName("#define CERT_SCEP_SIGNER_CERT_PROP_ID 112")]
        public const int CERT_SCEP_SIGNER_CERT_PROP_ID = 112;

        [NativeTypeName("#define CERT_SCEP_NONCE_PROP_ID 113")]
        public const int CERT_SCEP_NONCE_PROP_ID = 113;

        [NativeTypeName("#define CERT_SCEP_ENCRYPT_HASH_CNG_ALG_PROP_ID 114")]
        public const int CERT_SCEP_ENCRYPT_HASH_CNG_ALG_PROP_ID = 114;

        [NativeTypeName("#define CERT_SCEP_FLAGS_PROP_ID 115")]
        public const int CERT_SCEP_FLAGS_PROP_ID = 115;

        [NativeTypeName("#define CERT_SCEP_GUID_PROP_ID 116")]
        public const int CERT_SCEP_GUID_PROP_ID = 116;

        [NativeTypeName("#define CERT_SERIALIZABLE_KEY_CONTEXT_PROP_ID 117")]
        public const int CERT_SERIALIZABLE_KEY_CONTEXT_PROP_ID = 117;

        [NativeTypeName("#define CERT_ISOLATED_KEY_PROP_ID 118")]
        public const int CERT_ISOLATED_KEY_PROP_ID = 118;

        [NativeTypeName("#define CERT_SERIAL_CHAIN_PROP_ID 119")]
        public const int CERT_SERIAL_CHAIN_PROP_ID = 119;

        [NativeTypeName("#define CERT_KEY_CLASSIFICATION_PROP_ID 120")]
        public const int CERT_KEY_CLASSIFICATION_PROP_ID = 120;

        [NativeTypeName("#define CERT_OCSP_MUST_STAPLE_PROP_ID 121")]
        public const int CERT_OCSP_MUST_STAPLE_PROP_ID = 121;

        [NativeTypeName("#define CERT_DISALLOWED_ENHKEY_USAGE_PROP_ID 122")]
        public const int CERT_DISALLOWED_ENHKEY_USAGE_PROP_ID = 122;

        [NativeTypeName("#define CERT_NONCOMPLIANT_ROOT_URL_PROP_ID 123")]
        public const int CERT_NONCOMPLIANT_ROOT_URL_PROP_ID = 123;

        [NativeTypeName("#define CERT_PIN_SHA256_HASH_PROP_ID 124")]
        public const int CERT_PIN_SHA256_HASH_PROP_ID = 124;

        [NativeTypeName("#define CERT_CLR_DELETE_KEY_PROP_ID 125")]
        public const int CERT_CLR_DELETE_KEY_PROP_ID = 125;

        [NativeTypeName("#define CERT_NOT_BEFORE_FILETIME_PROP_ID 126")]
        public const int CERT_NOT_BEFORE_FILETIME_PROP_ID = 126;

        [NativeTypeName("#define CERT_NOT_BEFORE_ENHKEY_USAGE_PROP_ID 127")]
        public const int CERT_NOT_BEFORE_ENHKEY_USAGE_PROP_ID = 127;

        [NativeTypeName("#define CERT_FIRST_RESERVED_PROP_ID 128")]
        public const int CERT_FIRST_RESERVED_PROP_ID = 128;

        [NativeTypeName("#define CERT_LAST_RESERVED_PROP_ID 0x00007FFF")]
        public const int CERT_LAST_RESERVED_PROP_ID = 0x00007FFF;

        [NativeTypeName("#define CERT_FIRST_USER_PROP_ID 0x00008000")]
        public const int CERT_FIRST_USER_PROP_ID = 0x00008000;

        [NativeTypeName("#define CERT_LAST_USER_PROP_ID 0x0000FFFF")]
        public const int CERT_LAST_USER_PROP_ID = 0x0000FFFF;

        [NativeTypeName("#define szOID_CERT_PROP_ID_PREFIX \"1.3.6.1.4.1.311.10.11.\"")]
        public static ReadOnlySpan<byte> szOID_CERT_PROP_ID_PREFIX => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x31, 0x2E, 0x00 };

        [NativeTypeName("#define szOID_CERT_KEY_IDENTIFIER_PROP_ID \"1.3.6.1.4.1.311.10.11.20\"")]
        public static ReadOnlySpan<byte> szOID_CERT_KEY_IDENTIFIER_PROP_ID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x31, 0x2E, 0x32, 0x30, 0x00 };

        [NativeTypeName("#define szOID_CERT_ISSUER_SERIAL_NUMBER_MD5_HASH_PROP_ID \"1.3.6.1.4.1.311.10.11.28\"")]
        public static ReadOnlySpan<byte> szOID_CERT_ISSUER_SERIAL_NUMBER_MD5_HASH_PROP_ID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x31, 0x2E, 0x32, 0x38, 0x00 };

        [NativeTypeName("#define szOID_CERT_SUBJECT_NAME_MD5_HASH_PROP_ID \"1.3.6.1.4.1.311.10.11.29\"")]
        public static ReadOnlySpan<byte> szOID_CERT_SUBJECT_NAME_MD5_HASH_PROP_ID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x31, 0x2E, 0x32, 0x39, 0x00 };

        [NativeTypeName("#define szOID_CERT_MD5_HASH_PROP_ID \"1.3.6.1.4.1.311.10.11.4\"")]
        public static ReadOnlySpan<byte> szOID_CERT_MD5_HASH_PROP_ID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x31, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_CERT_SIGNATURE_HASH_PROP_ID \"1.3.6.1.4.1.311.10.11.15\"")]
        public static ReadOnlySpan<byte> szOID_CERT_SIGNATURE_HASH_PROP_ID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x31, 0x2E, 0x31, 0x35, 0x00 };

        [NativeTypeName("#define szOID_DISALLOWED_HASH szOID_CERT_SIGNATURE_HASH_PROP_ID")]
        public static ReadOnlySpan<byte> szOID_DISALLOWED_HASH => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x31, 0x2E, 0x31, 0x35, 0x00 };

        [NativeTypeName("#define szOID_CERT_DISALLOWED_FILETIME_PROP_ID \"1.3.6.1.4.1.311.10.11.104\"")]
        public static ReadOnlySpan<byte> szOID_CERT_DISALLOWED_FILETIME_PROP_ID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x34, 0x00 };

        [NativeTypeName("#define CERT_ACCESS_STATE_WRITE_PERSIST_FLAG 0x1")]
        public const int CERT_ACCESS_STATE_WRITE_PERSIST_FLAG = 0x1;

        [NativeTypeName("#define CERT_ACCESS_STATE_SYSTEM_STORE_FLAG 0x2")]
        public const int CERT_ACCESS_STATE_SYSTEM_STORE_FLAG = 0x2;

        [NativeTypeName("#define CERT_ACCESS_STATE_LM_SYSTEM_STORE_FLAG 0x4")]
        public const int CERT_ACCESS_STATE_LM_SYSTEM_STORE_FLAG = 0x4;

        [NativeTypeName("#define CERT_ACCESS_STATE_GP_SYSTEM_STORE_FLAG 0x8")]
        public const int CERT_ACCESS_STATE_GP_SYSTEM_STORE_FLAG = 0x8;

        [NativeTypeName("#define CERT_ACCESS_STATE_SHARED_USER_FLAG 0x10")]
        public const int CERT_ACCESS_STATE_SHARED_USER_FLAG = 0x10;

        [NativeTypeName("#define szOID_ROOT_PROGRAM_AUTO_UPDATE_CA_REVOCATION \"1.3.6.1.4.1.311.60.3.1\"")]
        public static ReadOnlySpan<byte> szOID_ROOT_PROGRAM_AUTO_UPDATE_CA_REVOCATION => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ROOT_PROGRAM_AUTO_UPDATE_END_REVOCATION \"1.3.6.1.4.1.311.60.3.2\"")]
        public static ReadOnlySpan<byte> szOID_ROOT_PROGRAM_AUTO_UPDATE_END_REVOCATION => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_ROOT_PROGRAM_NO_OCSP_FAILOVER_TO_CRL \"1.3.6.1.4.1.311.60.3.3\"")]
        public static ReadOnlySpan<byte> szOID_ROOT_PROGRAM_NO_OCSP_FAILOVER_TO_CRL => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define CERT_SET_KEY_PROV_HANDLE_PROP_ID 0x00000001")]
        public const int CERT_SET_KEY_PROV_HANDLE_PROP_ID = 0x00000001;

        [NativeTypeName("#define CERT_SET_KEY_CONTEXT_PROP_ID 0x00000001")]
        public const int CERT_SET_KEY_CONTEXT_PROP_ID = 0x00000001;

        [NativeTypeName("#define CERT_NCRYPT_KEY_SPEC 0xFFFFFFFF")]
        public const uint CERT_NCRYPT_KEY_SPEC = 0xFFFFFFFF;

        [NativeTypeName("#define CERT_STORE_PROV_MSG ((LPCSTR) 1)")]
        public static sbyte* CERT_STORE_PROV_MSG => ((sbyte*)(1));

        [NativeTypeName("#define CERT_STORE_PROV_MEMORY ((LPCSTR) 2)")]
        public static sbyte* CERT_STORE_PROV_MEMORY => ((sbyte*)(2));

        [NativeTypeName("#define CERT_STORE_PROV_FILE ((LPCSTR) 3)")]
        public static sbyte* CERT_STORE_PROV_FILE => ((sbyte*)(3));

        [NativeTypeName("#define CERT_STORE_PROV_REG ((LPCSTR) 4)")]
        public static sbyte* CERT_STORE_PROV_REG => ((sbyte*)(4));

        [NativeTypeName("#define CERT_STORE_PROV_PKCS7 ((LPCSTR) 5)")]
        public static sbyte* CERT_STORE_PROV_PKCS7 => ((sbyte*)(5));

        [NativeTypeName("#define CERT_STORE_PROV_SERIALIZED ((LPCSTR) 6)")]
        public static sbyte* CERT_STORE_PROV_SERIALIZED => ((sbyte*)(6));

        [NativeTypeName("#define CERT_STORE_PROV_FILENAME_A ((LPCSTR) 7)")]
        public static sbyte* CERT_STORE_PROV_FILENAME_A => ((sbyte*)(7));

        [NativeTypeName("#define CERT_STORE_PROV_FILENAME_W ((LPCSTR) 8)")]
        public static sbyte* CERT_STORE_PROV_FILENAME_W => ((sbyte*)(8));

        [NativeTypeName("#define CERT_STORE_PROV_FILENAME CERT_STORE_PROV_FILENAME_W")]
        public static sbyte* CERT_STORE_PROV_FILENAME => ((sbyte*)(8));

        [NativeTypeName("#define CERT_STORE_PROV_SYSTEM_A ((LPCSTR) 9)")]
        public static sbyte* CERT_STORE_PROV_SYSTEM_A => ((sbyte*)(9));

        [NativeTypeName("#define CERT_STORE_PROV_SYSTEM_W ((LPCSTR) 10)")]
        public static sbyte* CERT_STORE_PROV_SYSTEM_W => ((sbyte*)(10));

        [NativeTypeName("#define CERT_STORE_PROV_SYSTEM CERT_STORE_PROV_SYSTEM_W")]
        public static sbyte* CERT_STORE_PROV_SYSTEM => ((sbyte*)(10));

        [NativeTypeName("#define CERT_STORE_PROV_COLLECTION ((LPCSTR) 11)")]
        public static sbyte* CERT_STORE_PROV_COLLECTION => ((sbyte*)(11));

        [NativeTypeName("#define CERT_STORE_PROV_SYSTEM_REGISTRY_A ((LPCSTR) 12)")]
        public static sbyte* CERT_STORE_PROV_SYSTEM_REGISTRY_A => ((sbyte*)(12));

        [NativeTypeName("#define CERT_STORE_PROV_SYSTEM_REGISTRY_W ((LPCSTR) 13)")]
        public static sbyte* CERT_STORE_PROV_SYSTEM_REGISTRY_W => ((sbyte*)(13));

        [NativeTypeName("#define CERT_STORE_PROV_SYSTEM_REGISTRY CERT_STORE_PROV_SYSTEM_REGISTRY_W")]
        public static sbyte* CERT_STORE_PROV_SYSTEM_REGISTRY => ((sbyte*)(13));

        [NativeTypeName("#define CERT_STORE_PROV_PHYSICAL_W ((LPCSTR) 14)")]
        public static sbyte* CERT_STORE_PROV_PHYSICAL_W => ((sbyte*)(14));

        [NativeTypeName("#define CERT_STORE_PROV_PHYSICAL CERT_STORE_PROV_PHYSICAL_W")]
        public static sbyte* CERT_STORE_PROV_PHYSICAL => ((sbyte*)(14));

        [NativeTypeName("#define CERT_STORE_PROV_SMART_CARD_W ((LPCSTR) 15)")]
        public static sbyte* CERT_STORE_PROV_SMART_CARD_W => ((sbyte*)(15));

        [NativeTypeName("#define CERT_STORE_PROV_SMART_CARD CERT_STORE_PROV_SMART_CARD_W")]
        public static sbyte* CERT_STORE_PROV_SMART_CARD => ((sbyte*)(15));

        [NativeTypeName("#define CERT_STORE_PROV_LDAP_W ((LPCSTR) 16)")]
        public static sbyte* CERT_STORE_PROV_LDAP_W => ((sbyte*)(16));

        [NativeTypeName("#define CERT_STORE_PROV_LDAP CERT_STORE_PROV_LDAP_W")]
        public static sbyte* CERT_STORE_PROV_LDAP => ((sbyte*)(16));

        [NativeTypeName("#define CERT_STORE_PROV_PKCS12 ((LPCSTR) 17)")]
        public static sbyte* CERT_STORE_PROV_PKCS12 => ((sbyte*)(17));

        [NativeTypeName("#define sz_CERT_STORE_PROV_MEMORY \"Memory\"")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_MEMORY => new byte[] { 0x4D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_FILENAME_W \"File\"")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_FILENAME_W => new byte[] { 0x46, 0x69, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_FILENAME sz_CERT_STORE_PROV_FILENAME_W")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_FILENAME => new byte[] { 0x46, 0x69, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_SYSTEM_W \"System\"")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM_W => new byte[] { 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_SYSTEM sz_CERT_STORE_PROV_SYSTEM_W")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM => new byte[] { 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_PKCS7 \"PKCS7\"")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PKCS7 => new byte[] { 0x50, 0x4B, 0x43, 0x53, 0x37, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_PKCS12 \"PKCS12\"")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PKCS12 => new byte[] { 0x50, 0x4B, 0x43, 0x53, 0x31, 0x32, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_SERIALIZED \"Serialized\"")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SERIALIZED => new byte[] { 0x53, 0x65, 0x72, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_COLLECTION \"Collection\"")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_COLLECTION => new byte[] { 0x43, 0x6F, 0x6C, 0x6C, 0x65, 0x63, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W \"SystemRegistry\"")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W => new byte[] { 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x52, 0x65, 0x67, 0x69, 0x73, 0x74, 0x72, 0x79, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_SYSTEM_REGISTRY sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM_REGISTRY => new byte[] { 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x52, 0x65, 0x67, 0x69, 0x73, 0x74, 0x72, 0x79, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_PHYSICAL_W \"Physical\"")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PHYSICAL_W => new byte[] { 0x50, 0x68, 0x79, 0x73, 0x69, 0x63, 0x61, 0x6C, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_PHYSICAL sz_CERT_STORE_PROV_PHYSICAL_W")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PHYSICAL => new byte[] { 0x50, 0x68, 0x79, 0x73, 0x69, 0x63, 0x61, 0x6C, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_SMART_CARD_W \"SmartCard\"")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SMART_CARD_W => new byte[] { 0x53, 0x6D, 0x61, 0x72, 0x74, 0x43, 0x61, 0x72, 0x64, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_SMART_CARD sz_CERT_STORE_PROV_SMART_CARD_W")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SMART_CARD => new byte[] { 0x53, 0x6D, 0x61, 0x72, 0x74, 0x43, 0x61, 0x72, 0x64, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_LDAP_W \"Ldap\"")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_LDAP_W => new byte[] { 0x4C, 0x64, 0x61, 0x70, 0x00 };

        [NativeTypeName("#define sz_CERT_STORE_PROV_LDAP sz_CERT_STORE_PROV_LDAP_W")]
        public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_LDAP => new byte[] { 0x4C, 0x64, 0x61, 0x70, 0x00 };

        [NativeTypeName("#define CERT_STORE_SIGNATURE_FLAG 0x00000001")]
        public const int CERT_STORE_SIGNATURE_FLAG = 0x00000001;

        [NativeTypeName("#define CERT_STORE_TIME_VALIDITY_FLAG 0x00000002")]
        public const int CERT_STORE_TIME_VALIDITY_FLAG = 0x00000002;

        [NativeTypeName("#define CERT_STORE_REVOCATION_FLAG 0x00000004")]
        public const int CERT_STORE_REVOCATION_FLAG = 0x00000004;

        [NativeTypeName("#define CERT_STORE_NO_CRL_FLAG 0x00010000")]
        public const int CERT_STORE_NO_CRL_FLAG = 0x00010000;

        [NativeTypeName("#define CERT_STORE_NO_ISSUER_FLAG 0x00020000")]
        public const int CERT_STORE_NO_ISSUER_FLAG = 0x00020000;

        [NativeTypeName("#define CERT_STORE_BASE_CRL_FLAG 0x00000100")]
        public const int CERT_STORE_BASE_CRL_FLAG = 0x00000100;

        [NativeTypeName("#define CERT_STORE_DELTA_CRL_FLAG 0x00000200")]
        public const int CERT_STORE_DELTA_CRL_FLAG = 0x00000200;

        [NativeTypeName("#define CERT_STORE_NO_CRYPT_RELEASE_FLAG 0x00000001")]
        public const int CERT_STORE_NO_CRYPT_RELEASE_FLAG = 0x00000001;

        [NativeTypeName("#define CERT_STORE_SET_LOCALIZED_NAME_FLAG 0x00000002")]
        public const int CERT_STORE_SET_LOCALIZED_NAME_FLAG = 0x00000002;

        [NativeTypeName("#define CERT_STORE_DEFER_CLOSE_UNTIL_LAST_FREE_FLAG 0x00000004")]
        public const int CERT_STORE_DEFER_CLOSE_UNTIL_LAST_FREE_FLAG = 0x00000004;

        [NativeTypeName("#define CERT_STORE_DELETE_FLAG 0x00000010")]
        public const int CERT_STORE_DELETE_FLAG = 0x00000010;

        [NativeTypeName("#define CERT_STORE_UNSAFE_PHYSICAL_FLAG 0x00000020")]
        public const int CERT_STORE_UNSAFE_PHYSICAL_FLAG = 0x00000020;

        [NativeTypeName("#define CERT_STORE_SHARE_STORE_FLAG 0x00000040")]
        public const int CERT_STORE_SHARE_STORE_FLAG = 0x00000040;

        [NativeTypeName("#define CERT_STORE_SHARE_CONTEXT_FLAG 0x00000080")]
        public const int CERT_STORE_SHARE_CONTEXT_FLAG = 0x00000080;

        [NativeTypeName("#define CERT_STORE_MANIFOLD_FLAG 0x00000100")]
        public const int CERT_STORE_MANIFOLD_FLAG = 0x00000100;

        [NativeTypeName("#define CERT_STORE_ENUM_ARCHIVED_FLAG 0x00000200")]
        public const int CERT_STORE_ENUM_ARCHIVED_FLAG = 0x00000200;

        [NativeTypeName("#define CERT_STORE_UPDATE_KEYID_FLAG 0x00000400")]
        public const int CERT_STORE_UPDATE_KEYID_FLAG = 0x00000400;

        [NativeTypeName("#define CERT_STORE_BACKUP_RESTORE_FLAG 0x00000800")]
        public const int CERT_STORE_BACKUP_RESTORE_FLAG = 0x00000800;

        [NativeTypeName("#define CERT_STORE_READONLY_FLAG 0x00008000")]
        public const int CERT_STORE_READONLY_FLAG = 0x00008000;

        [NativeTypeName("#define CERT_STORE_OPEN_EXISTING_FLAG 0x00004000")]
        public const int CERT_STORE_OPEN_EXISTING_FLAG = 0x00004000;

        [NativeTypeName("#define CERT_STORE_CREATE_NEW_FLAG 0x00002000")]
        public const int CERT_STORE_CREATE_NEW_FLAG = 0x00002000;

        [NativeTypeName("#define CERT_STORE_MAXIMUM_ALLOWED_FLAG 0x00001000")]
        public const int CERT_STORE_MAXIMUM_ALLOWED_FLAG = 0x00001000;

        [NativeTypeName("#define CERT_SYSTEM_STORE_MASK 0xFFFF0000")]
        public const uint CERT_SYSTEM_STORE_MASK = 0xFFFF0000;

        [NativeTypeName("#define CERT_SYSTEM_STORE_RELOCATE_FLAG 0x80000000")]
        public const uint CERT_SYSTEM_STORE_RELOCATE_FLAG = 0x80000000;

        [NativeTypeName("#define CERT_SYSTEM_STORE_UNPROTECTED_FLAG 0x40000000")]
        public const int CERT_SYSTEM_STORE_UNPROTECTED_FLAG = 0x40000000;

        [NativeTypeName("#define CERT_SYSTEM_STORE_DEFER_READ_FLAG 0x20000000")]
        public const int CERT_SYSTEM_STORE_DEFER_READ_FLAG = 0x20000000;

        [NativeTypeName("#define CERT_SYSTEM_STORE_LOCATION_MASK 0x00FF0000")]
        public const int CERT_SYSTEM_STORE_LOCATION_MASK = 0x00FF0000;

        [NativeTypeName("#define CERT_SYSTEM_STORE_LOCATION_SHIFT 16")]
        public const int CERT_SYSTEM_STORE_LOCATION_SHIFT = 16;

        [NativeTypeName("#define CERT_SYSTEM_STORE_CURRENT_USER_ID 1")]
        public const int CERT_SYSTEM_STORE_CURRENT_USER_ID = 1;

        [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE_ID 2")]
        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_ID = 2;

        [NativeTypeName("#define CERT_SYSTEM_STORE_CURRENT_SERVICE_ID 4")]
        public const int CERT_SYSTEM_STORE_CURRENT_SERVICE_ID = 4;

        [NativeTypeName("#define CERT_SYSTEM_STORE_SERVICES_ID 5")]
        public const int CERT_SYSTEM_STORE_SERVICES_ID = 5;

        [NativeTypeName("#define CERT_SYSTEM_STORE_USERS_ID 6")]
        public const int CERT_SYSTEM_STORE_USERS_ID = 6;

        [NativeTypeName("#define CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY_ID 7")]
        public const int CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY_ID = 7;

        [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY_ID 8")]
        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY_ID = 8;

        [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE_ID 9")]
        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE_ID = 9;

        [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE_WCOS_ID 10")]
        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_WCOS_ID = 10;

        [NativeTypeName("#define CERT_SYSTEM_STORE_CURRENT_USER (CERT_SYSTEM_STORE_CURRENT_USER_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
        public const int CERT_SYSTEM_STORE_CURRENT_USER = (1 << 16);

        [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE (CERT_SYSTEM_STORE_LOCAL_MACHINE_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE = (2 << 16);

        [NativeTypeName("#define CERT_SYSTEM_STORE_CURRENT_SERVICE (CERT_SYSTEM_STORE_CURRENT_SERVICE_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
        public const int CERT_SYSTEM_STORE_CURRENT_SERVICE = (4 << 16);

        [NativeTypeName("#define CERT_SYSTEM_STORE_SERVICES (CERT_SYSTEM_STORE_SERVICES_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
        public const int CERT_SYSTEM_STORE_SERVICES = (5 << 16);

        [NativeTypeName("#define CERT_SYSTEM_STORE_USERS (CERT_SYSTEM_STORE_USERS_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
        public const int CERT_SYSTEM_STORE_USERS = (6 << 16);

        [NativeTypeName("#define CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY (CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY_ID << \\\r\n        CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
        public const int CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY = (7 << 16);

        [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY (CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY_ID << \\\r\n        CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY = (8 << 16);

        [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE (CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE_ID << \\\r\n        CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE = (9 << 16);

        [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE_WCOS (CERT_SYSTEM_STORE_LOCAL_MACHINE_WCOS_ID << \\\r\n        CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
        public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_WCOS = (10 << 16);

        [NativeTypeName("#define CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH L\"Software\\\\Policies\\\\Microsoft\\\\SystemCertificates\"")]
        public const string CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH = "Software\\Policies\\Microsoft\\SystemCertificates";

        [NativeTypeName("#define CERT_EFSBLOB_REGPATH CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH L\"\\\\EFS\"")]
        public const string CERT_EFSBLOB_REGPATH = "Software\\Policies\\Microsoft\\SystemCertificates\\EFS";

        [NativeTypeName("#define CERT_EFSBLOB_VALUE_NAME L\"EFSBlob\"")]
        public const string CERT_EFSBLOB_VALUE_NAME = "EFSBlob";

        [NativeTypeName("#define CERT_PROT_ROOT_FLAGS_REGPATH CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH L\"\\\\Root\\\\ProtectedRoots\"")]
        public const string CERT_PROT_ROOT_FLAGS_REGPATH = "Software\\Policies\\Microsoft\\SystemCertificates\\Root\\ProtectedRoots";

        [NativeTypeName("#define CERT_PROT_ROOT_FLAGS_VALUE_NAME L\"Flags\"")]
        public const string CERT_PROT_ROOT_FLAGS_VALUE_NAME = "Flags";

        [NativeTypeName("#define CERT_PROT_ROOT_DISABLE_CURRENT_USER_FLAG 0x1")]
        public const int CERT_PROT_ROOT_DISABLE_CURRENT_USER_FLAG = 0x1;

        [NativeTypeName("#define CERT_PROT_ROOT_INHIBIT_ADD_AT_INIT_FLAG 0x2")]
        public const int CERT_PROT_ROOT_INHIBIT_ADD_AT_INIT_FLAG = 0x2;

        [NativeTypeName("#define CERT_PROT_ROOT_INHIBIT_PURGE_LM_FLAG 0x4")]
        public const int CERT_PROT_ROOT_INHIBIT_PURGE_LM_FLAG = 0x4;

        [NativeTypeName("#define CERT_PROT_ROOT_DISABLE_LM_AUTH_FLAG 0x8")]
        public const int CERT_PROT_ROOT_DISABLE_LM_AUTH_FLAG = 0x8;

        [NativeTypeName("#define CERT_PROT_ROOT_ONLY_LM_GPT_FLAG 0x8")]
        public const int CERT_PROT_ROOT_ONLY_LM_GPT_FLAG = 0x8;

        [NativeTypeName("#define CERT_PROT_ROOT_DISABLE_NT_AUTH_REQUIRED_FLAG 0x10")]
        public const int CERT_PROT_ROOT_DISABLE_NT_AUTH_REQUIRED_FLAG = 0x10;

        [NativeTypeName("#define CERT_PROT_ROOT_DISABLE_NOT_DEFINED_NAME_CONSTRAINT_FLAG 0x20")]
        public const int CERT_PROT_ROOT_DISABLE_NOT_DEFINED_NAME_CONSTRAINT_FLAG = 0x20;

        [NativeTypeName("#define CERT_PROT_ROOT_DISABLE_PEER_TRUST 0x10000")]
        public const int CERT_PROT_ROOT_DISABLE_PEER_TRUST = 0x10000;

        [NativeTypeName("#define CERT_PROT_ROOT_PEER_USAGES_VALUE_NAME L\"PeerUsages\"")]
        public const string CERT_PROT_ROOT_PEER_USAGES_VALUE_NAME = "PeerUsages";

        [NativeTypeName("#define CERT_PROT_ROOT_PEER_USAGES_VALUE_NAME_A \"PeerUsages\"")]
        public static ReadOnlySpan<byte> CERT_PROT_ROOT_PEER_USAGES_VALUE_NAME_A => new byte[] { 0x50, 0x65, 0x65, 0x72, 0x55, 0x73, 0x61, 0x67, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define CERT_PROT_ROOT_PEER_USAGES_DEFAULT_A szOID_PKIX_KP_CLIENT_AUTH \"\\0\"                  \\\r\n    szOID_PKIX_KP_EMAIL_PROTECTION \"\\0\"             \\\r\n    szOID_KP_EFS \"\\0\"")]
        public static ReadOnlySpan<byte> CERT_PROT_ROOT_PEER_USAGES_DEFAULT_A => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x32, 0x00, 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x33, 0x2E, 0x34, 0x00, 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x30, 0x2E, 0x33, 0x2E, 0x34, 0x00, 0x00 };

        [NativeTypeName("#define CERT_TRUST_PUB_SAFER_GROUP_POLICY_REGPATH CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH L\"\\\\TrustedPublisher\\\\Safer\"")]
        public const string CERT_TRUST_PUB_SAFER_GROUP_POLICY_REGPATH = "Software\\Policies\\Microsoft\\SystemCertificates\\TrustedPublisher\\Safer";

        [NativeTypeName("#define CERT_LOCAL_MACHINE_SYSTEM_STORE_REGPATH L\"Software\\\\Microsoft\\\\SystemCertificates\"")]
        public const string CERT_LOCAL_MACHINE_SYSTEM_STORE_REGPATH = "Software\\Microsoft\\SystemCertificates";

        [NativeTypeName("#define CERT_TRUST_PUB_SAFER_LOCAL_MACHINE_REGPATH CERT_LOCAL_MACHINE_SYSTEM_STORE_REGPATH L\"\\\\TrustedPublisher\\\\Safer\"")]
        public const string CERT_TRUST_PUB_SAFER_LOCAL_MACHINE_REGPATH = "Software\\Microsoft\\SystemCertificates\\TrustedPublisher\\Safer";

        [NativeTypeName("#define CERT_TRUST_PUB_AUTHENTICODE_FLAGS_VALUE_NAME L\"AuthenticodeFlags\"")]
        public const string CERT_TRUST_PUB_AUTHENTICODE_FLAGS_VALUE_NAME = "AuthenticodeFlags";

        [NativeTypeName("#define CERT_TRUST_PUB_ALLOW_TRUST_MASK 0x00000003")]
        public const int CERT_TRUST_PUB_ALLOW_TRUST_MASK = 0x00000003;

        [NativeTypeName("#define CERT_TRUST_PUB_ALLOW_END_USER_TRUST 0x00000000")]
        public const int CERT_TRUST_PUB_ALLOW_END_USER_TRUST = 0x00000000;

        [NativeTypeName("#define CERT_TRUST_PUB_ALLOW_MACHINE_ADMIN_TRUST 0x00000001")]
        public const int CERT_TRUST_PUB_ALLOW_MACHINE_ADMIN_TRUST = 0x00000001;

        [NativeTypeName("#define CERT_TRUST_PUB_ALLOW_ENTERPRISE_ADMIN_TRUST 0x00000002")]
        public const int CERT_TRUST_PUB_ALLOW_ENTERPRISE_ADMIN_TRUST = 0x00000002;

        [NativeTypeName("#define CERT_TRUST_PUB_CHECK_PUBLISHER_REV_FLAG 0x00000100")]
        public const int CERT_TRUST_PUB_CHECK_PUBLISHER_REV_FLAG = 0x00000100;

        [NativeTypeName("#define CERT_TRUST_PUB_CHECK_TIMESTAMP_REV_FLAG 0x00000200")]
        public const int CERT_TRUST_PUB_CHECK_TIMESTAMP_REV_FLAG = 0x00000200;

        [NativeTypeName("#define CERT_OCM_SUBCOMPONENTS_LOCAL_MACHINE_REGPATH L\"SOFTWARE\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Setup\\\\OC Manager\\\\Subcomponents\"")]
        public const string CERT_OCM_SUBCOMPONENTS_LOCAL_MACHINE_REGPATH = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Setup\\OC Manager\\Subcomponents";

        [NativeTypeName("#define CERT_OCM_SUBCOMPONENTS_ROOT_AUTO_UPDATE_VALUE_NAME L\"RootAutoUpdate\"")]
        public const string CERT_OCM_SUBCOMPONENTS_ROOT_AUTO_UPDATE_VALUE_NAME = "RootAutoUpdate";

        [NativeTypeName("#define CERT_DISABLE_ROOT_AUTO_UPDATE_REGPATH CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH L\"\\\\AuthRoot\"")]
        public const string CERT_DISABLE_ROOT_AUTO_UPDATE_REGPATH = "Software\\Policies\\Microsoft\\SystemCertificates\\AuthRoot";

        [NativeTypeName("#define CERT_DISABLE_ROOT_AUTO_UPDATE_VALUE_NAME L\"DisableRootAutoUpdate\"")]
        public const string CERT_DISABLE_ROOT_AUTO_UPDATE_VALUE_NAME = "DisableRootAutoUpdate";

        [NativeTypeName("#define CERT_ENABLE_DISALLOWED_CERT_AUTO_UPDATE_VALUE_NAME L\"EnableDisallowedCertAutoUpdate\"")]
        public const string CERT_ENABLE_DISALLOWED_CERT_AUTO_UPDATE_VALUE_NAME = "EnableDisallowedCertAutoUpdate";

        [NativeTypeName("#define CERT_DISABLE_PIN_RULES_AUTO_UPDATE_VALUE_NAME L\"DisablePinRulesAutoUpdate\"")]
        public const string CERT_DISABLE_PIN_RULES_AUTO_UPDATE_VALUE_NAME = "DisablePinRulesAutoUpdate";

        [NativeTypeName("#define CERT_AUTO_UPDATE_LOCAL_MACHINE_REGPATH CERT_LOCAL_MACHINE_SYSTEM_STORE_REGPATH L\"\\\\AuthRoot\\\\AutoUpdate\"")]
        public const string CERT_AUTO_UPDATE_LOCAL_MACHINE_REGPATH = "Software\\Microsoft\\SystemCertificates\\AuthRoot\\AutoUpdate";

        [NativeTypeName("#define CERT_AUTO_UPDATE_ROOT_DIR_URL_VALUE_NAME L\"RootDirUrl\"")]
        public const string CERT_AUTO_UPDATE_ROOT_DIR_URL_VALUE_NAME = "RootDirUrl";

        [NativeTypeName("#define CERT_AUTO_UPDATE_SYNC_FROM_DIR_URL_VALUE_NAME L\"SyncFromDirUrl\"")]
        public const string CERT_AUTO_UPDATE_SYNC_FROM_DIR_URL_VALUE_NAME = "SyncFromDirUrl";

        [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_LOCAL_MACHINE_REGPATH CERT_AUTO_UPDATE_LOCAL_MACHINE_REGPATH")]
        public const string CERT_AUTH_ROOT_AUTO_UPDATE_LOCAL_MACHINE_REGPATH = "Software\\Microsoft\\SystemCertificates\\AuthRoot\\AutoUpdate";

        [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_ROOT_DIR_URL_VALUE_NAME CERT_AUTO_UPDATE_ROOT_DIR_URL_VALUE_NAME")]
        public const string CERT_AUTH_ROOT_AUTO_UPDATE_ROOT_DIR_URL_VALUE_NAME = "RootDirUrl";

        [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_SYNC_DELTA_TIME_VALUE_NAME L\"SyncDeltaTime\"")]
        public const string CERT_AUTH_ROOT_AUTO_UPDATE_SYNC_DELTA_TIME_VALUE_NAME = "SyncDeltaTime";

        [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_FLAGS_VALUE_NAME L\"Flags\"")]
        public const string CERT_AUTH_ROOT_AUTO_UPDATE_FLAGS_VALUE_NAME = "Flags";

        [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_DISABLE_UNTRUSTED_ROOT_LOGGING_FLAG 0x1")]
        public const int CERT_AUTH_ROOT_AUTO_UPDATE_DISABLE_UNTRUSTED_ROOT_LOGGING_FLAG = 0x1;

        [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_DISABLE_PARTIAL_CHAIN_LOGGING_FLAG 0x2")]
        public const int CERT_AUTH_ROOT_AUTO_UPDATE_DISABLE_PARTIAL_CHAIN_LOGGING_FLAG = 0x2;

        [NativeTypeName("#define CERT_AUTO_UPDATE_DISABLE_RANDOM_QUERY_STRING_FLAG 0x4")]
        public const int CERT_AUTO_UPDATE_DISABLE_RANDOM_QUERY_STRING_FLAG = 0x4;

        [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_LAST_SYNC_TIME_VALUE_NAME L\"LastSyncTime\"")]
        public const string CERT_AUTH_ROOT_AUTO_UPDATE_LAST_SYNC_TIME_VALUE_NAME = "LastSyncTime";

        [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_ENCODED_CTL_VALUE_NAME L\"EncodedCtl\"")]
        public const string CERT_AUTH_ROOT_AUTO_UPDATE_ENCODED_CTL_VALUE_NAME = "EncodedCtl";

        [NativeTypeName("#define CERT_AUTH_ROOT_CTL_FILENAME L\"authroot.stl\"")]
        public const string CERT_AUTH_ROOT_CTL_FILENAME = "authroot.stl";

        [NativeTypeName("#define CERT_AUTH_ROOT_CTL_FILENAME_A \"authroot.stl\"")]
        public static ReadOnlySpan<byte> CERT_AUTH_ROOT_CTL_FILENAME_A => new byte[] { 0x61, 0x75, 0x74, 0x68, 0x72, 0x6F, 0x6F, 0x74, 0x2E, 0x73, 0x74, 0x6C, 0x00 };

        [NativeTypeName("#define CERT_AUTH_ROOT_CAB_FILENAME L\"authrootstl.cab\"")]
        public const string CERT_AUTH_ROOT_CAB_FILENAME = "authrootstl.cab";

        [NativeTypeName("#define CERT_AUTH_ROOT_SEQ_FILENAME L\"authrootseq.txt\"")]
        public const string CERT_AUTH_ROOT_SEQ_FILENAME = "authrootseq.txt";

        [NativeTypeName("#define CERT_AUTH_ROOT_CERT_EXT L\".crt\"")]
        public const string CERT_AUTH_ROOT_CERT_EXT = ".crt";

        [NativeTypeName("#define CERT_DISALLOWED_CERT_AUTO_UPDATE_SYNC_DELTA_TIME_VALUE_NAME L\"DisallowedCertSyncDeltaTime\"")]
        public const string CERT_DISALLOWED_CERT_AUTO_UPDATE_SYNC_DELTA_TIME_VALUE_NAME = "DisallowedCertSyncDeltaTime";

        [NativeTypeName("#define CERT_DISALLOWED_CERT_AUTO_UPDATE_LAST_SYNC_TIME_VALUE_NAME L\"DisallowedCertLastSyncTime\"")]
        public const string CERT_DISALLOWED_CERT_AUTO_UPDATE_LAST_SYNC_TIME_VALUE_NAME = "DisallowedCertLastSyncTime";

        [NativeTypeName("#define CERT_DISALLOWED_CERT_AUTO_UPDATE_ENCODED_CTL_VALUE_NAME L\"DisallowedCertEncodedCtl\"")]
        public const string CERT_DISALLOWED_CERT_AUTO_UPDATE_ENCODED_CTL_VALUE_NAME = "DisallowedCertEncodedCtl";

        [NativeTypeName("#define CERT_DISALLOWED_CERT_CTL_FILENAME L\"disallowedcert.stl\"")]
        public const string CERT_DISALLOWED_CERT_CTL_FILENAME = "disallowedcert.stl";

        [NativeTypeName("#define CERT_DISALLOWED_CERT_CTL_FILENAME_A \"disallowedcert.stl\"")]
        public static ReadOnlySpan<byte> CERT_DISALLOWED_CERT_CTL_FILENAME_A => new byte[] { 0x64, 0x69, 0x73, 0x61, 0x6C, 0x6C, 0x6F, 0x77, 0x65, 0x64, 0x63, 0x65, 0x72, 0x74, 0x2E, 0x73, 0x74, 0x6C, 0x00 };

        [NativeTypeName("#define CERT_DISALLOWED_CERT_CAB_FILENAME L\"disallowedcertstl.cab\"")]
        public const string CERT_DISALLOWED_CERT_CAB_FILENAME = "disallowedcertstl.cab";

        [NativeTypeName("#define CERT_DISALLOWED_CERT_AUTO_UPDATE_LIST_IDENTIFIER L\"DisallowedCert_AutoUpdate_1\"")]
        public const string CERT_DISALLOWED_CERT_AUTO_UPDATE_LIST_IDENTIFIER = "DisallowedCert_AutoUpdate_1";

        [NativeTypeName("#define CERT_PIN_RULES_AUTO_UPDATE_SYNC_DELTA_TIME_VALUE_NAME L\"PinRulesSyncDeltaTime\"")]
        public const string CERT_PIN_RULES_AUTO_UPDATE_SYNC_DELTA_TIME_VALUE_NAME = "PinRulesSyncDeltaTime";

        [NativeTypeName("#define CERT_PIN_RULES_AUTO_UPDATE_LAST_SYNC_TIME_VALUE_NAME L\"PinRulesLastSyncTime\"")]
        public const string CERT_PIN_RULES_AUTO_UPDATE_LAST_SYNC_TIME_VALUE_NAME = "PinRulesLastSyncTime";

        [NativeTypeName("#define CERT_PIN_RULES_AUTO_UPDATE_ENCODED_CTL_VALUE_NAME L\"PinRulesEncodedCtl\"")]
        public const string CERT_PIN_RULES_AUTO_UPDATE_ENCODED_CTL_VALUE_NAME = "PinRulesEncodedCtl";

        [NativeTypeName("#define CERT_PIN_RULES_CTL_FILENAME L\"pinrules.stl\"")]
        public const string CERT_PIN_RULES_CTL_FILENAME = "pinrules.stl";

        [NativeTypeName("#define CERT_PIN_RULES_CTL_FILENAME_A \"pinrules.stl\"")]
        public static ReadOnlySpan<byte> CERT_PIN_RULES_CTL_FILENAME_A => new byte[] { 0x70, 0x69, 0x6E, 0x72, 0x75, 0x6C, 0x65, 0x73, 0x2E, 0x73, 0x74, 0x6C, 0x00 };

        [NativeTypeName("#define CERT_PIN_RULES_CAB_FILENAME L\"pinrulesstl.cab\"")]
        public const string CERT_PIN_RULES_CAB_FILENAME = "pinrulesstl.cab";

        [NativeTypeName("#define CERT_PIN_RULES_AUTO_UPDATE_LIST_IDENTIFIER L\"PinRules_AutoUpdate_1\"")]
        public const string CERT_PIN_RULES_AUTO_UPDATE_LIST_IDENTIFIER = "PinRules_AutoUpdate_1";

        [NativeTypeName("#define CERT_REGISTRY_STORE_REMOTE_FLAG 0x10000")]
        public const int CERT_REGISTRY_STORE_REMOTE_FLAG = 0x10000;

        [NativeTypeName("#define CERT_REGISTRY_STORE_SERIALIZED_FLAG 0x20000")]
        public const int CERT_REGISTRY_STORE_SERIALIZED_FLAG = 0x20000;

        [NativeTypeName("#define CERT_REGISTRY_STORE_CLIENT_GPT_FLAG 0x80000000")]
        public const uint CERT_REGISTRY_STORE_CLIENT_GPT_FLAG = 0x80000000;

        [NativeTypeName("#define CERT_REGISTRY_STORE_LM_GPT_FLAG 0x01000000")]
        public const int CERT_REGISTRY_STORE_LM_GPT_FLAG = 0x01000000;

        [NativeTypeName("#define CERT_REGISTRY_STORE_ROAMING_FLAG 0x40000")]
        public const int CERT_REGISTRY_STORE_ROAMING_FLAG = 0x40000;

        [NativeTypeName("#define CERT_REGISTRY_STORE_MY_IE_DIRTY_FLAG 0x80000")]
        public const int CERT_REGISTRY_STORE_MY_IE_DIRTY_FLAG = 0x80000;

        [NativeTypeName("#define CERT_REGISTRY_STORE_EXTERNAL_FLAG 0x100000")]
        public const int CERT_REGISTRY_STORE_EXTERNAL_FLAG = 0x100000;

        [NativeTypeName("#define CERT_IE_DIRTY_FLAGS_REGPATH L\"Software\\\\Microsoft\\\\Cryptography\\\\IEDirtyFlags\"")]
        public const string CERT_IE_DIRTY_FLAGS_REGPATH = "Software\\Microsoft\\Cryptography\\IEDirtyFlags";

        [NativeTypeName("#define CERT_FILE_STORE_COMMIT_ENABLE_FLAG 0x10000")]
        public const int CERT_FILE_STORE_COMMIT_ENABLE_FLAG = 0x10000;

        [NativeTypeName("#define CERT_LDAP_STORE_SIGN_FLAG 0x10000")]
        public const int CERT_LDAP_STORE_SIGN_FLAG = 0x10000;

        [NativeTypeName("#define CERT_LDAP_STORE_AREC_EXCLUSIVE_FLAG 0x20000")]
        public const int CERT_LDAP_STORE_AREC_EXCLUSIVE_FLAG = 0x20000;

        [NativeTypeName("#define CERT_LDAP_STORE_OPENED_FLAG 0x40000")]
        public const int CERT_LDAP_STORE_OPENED_FLAG = 0x40000;

        [NativeTypeName("#define CERT_LDAP_STORE_UNBIND_FLAG 0x80000")]
        public const int CERT_LDAP_STORE_UNBIND_FLAG = 0x80000;

        [NativeTypeName("#define CRYPT_OID_OPEN_STORE_PROV_FUNC \"CertDllOpenStoreProv\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_OPEN_STORE_PROV_FUNC => new byte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x4F, 0x70, 0x65, 0x6E, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x50, 0x72, 0x6F, 0x76, 0x00 };

        [NativeTypeName("#define CERT_STORE_PROV_EXTERNAL_FLAG 0x1")]
        public const int CERT_STORE_PROV_EXTERNAL_FLAG = 0x1;

        [NativeTypeName("#define CERT_STORE_PROV_DELETED_FLAG 0x2")]
        public const int CERT_STORE_PROV_DELETED_FLAG = 0x2;

        [NativeTypeName("#define CERT_STORE_PROV_NO_PERSIST_FLAG 0x4")]
        public const int CERT_STORE_PROV_NO_PERSIST_FLAG = 0x4;

        [NativeTypeName("#define CERT_STORE_PROV_SYSTEM_STORE_FLAG 0x8")]
        public const int CERT_STORE_PROV_SYSTEM_STORE_FLAG = 0x8;

        [NativeTypeName("#define CERT_STORE_PROV_LM_SYSTEM_STORE_FLAG 0x10")]
        public const int CERT_STORE_PROV_LM_SYSTEM_STORE_FLAG = 0x10;

        [NativeTypeName("#define CERT_STORE_PROV_GP_SYSTEM_STORE_FLAG 0x20")]
        public const int CERT_STORE_PROV_GP_SYSTEM_STORE_FLAG = 0x20;

        [NativeTypeName("#define CERT_STORE_PROV_SHARED_USER_FLAG 0x40")]
        public const int CERT_STORE_PROV_SHARED_USER_FLAG = 0x40;

        [NativeTypeName("#define CERT_STORE_PROV_CLOSE_FUNC 0")]
        public const int CERT_STORE_PROV_CLOSE_FUNC = 0;

        [NativeTypeName("#define CERT_STORE_PROV_READ_CERT_FUNC 1")]
        public const int CERT_STORE_PROV_READ_CERT_FUNC = 1;

        [NativeTypeName("#define CERT_STORE_PROV_WRITE_CERT_FUNC 2")]
        public const int CERT_STORE_PROV_WRITE_CERT_FUNC = 2;

        [NativeTypeName("#define CERT_STORE_PROV_DELETE_CERT_FUNC 3")]
        public const int CERT_STORE_PROV_DELETE_CERT_FUNC = 3;

        [NativeTypeName("#define CERT_STORE_PROV_SET_CERT_PROPERTY_FUNC 4")]
        public const int CERT_STORE_PROV_SET_CERT_PROPERTY_FUNC = 4;

        [NativeTypeName("#define CERT_STORE_PROV_READ_CRL_FUNC 5")]
        public const int CERT_STORE_PROV_READ_CRL_FUNC = 5;

        [NativeTypeName("#define CERT_STORE_PROV_WRITE_CRL_FUNC 6")]
        public const int CERT_STORE_PROV_WRITE_CRL_FUNC = 6;

        [NativeTypeName("#define CERT_STORE_PROV_DELETE_CRL_FUNC 7")]
        public const int CERT_STORE_PROV_DELETE_CRL_FUNC = 7;

        [NativeTypeName("#define CERT_STORE_PROV_SET_CRL_PROPERTY_FUNC 8")]
        public const int CERT_STORE_PROV_SET_CRL_PROPERTY_FUNC = 8;

        [NativeTypeName("#define CERT_STORE_PROV_READ_CTL_FUNC 9")]
        public const int CERT_STORE_PROV_READ_CTL_FUNC = 9;

        [NativeTypeName("#define CERT_STORE_PROV_WRITE_CTL_FUNC 10")]
        public const int CERT_STORE_PROV_WRITE_CTL_FUNC = 10;

        [NativeTypeName("#define CERT_STORE_PROV_DELETE_CTL_FUNC 11")]
        public const int CERT_STORE_PROV_DELETE_CTL_FUNC = 11;

        [NativeTypeName("#define CERT_STORE_PROV_SET_CTL_PROPERTY_FUNC 12")]
        public const int CERT_STORE_PROV_SET_CTL_PROPERTY_FUNC = 12;

        [NativeTypeName("#define CERT_STORE_PROV_CONTROL_FUNC 13")]
        public const int CERT_STORE_PROV_CONTROL_FUNC = 13;

        [NativeTypeName("#define CERT_STORE_PROV_FIND_CERT_FUNC 14")]
        public const int CERT_STORE_PROV_FIND_CERT_FUNC = 14;

        [NativeTypeName("#define CERT_STORE_PROV_FREE_FIND_CERT_FUNC 15")]
        public const int CERT_STORE_PROV_FREE_FIND_CERT_FUNC = 15;

        [NativeTypeName("#define CERT_STORE_PROV_GET_CERT_PROPERTY_FUNC 16")]
        public const int CERT_STORE_PROV_GET_CERT_PROPERTY_FUNC = 16;

        [NativeTypeName("#define CERT_STORE_PROV_FIND_CRL_FUNC 17")]
        public const int CERT_STORE_PROV_FIND_CRL_FUNC = 17;

        [NativeTypeName("#define CERT_STORE_PROV_FREE_FIND_CRL_FUNC 18")]
        public const int CERT_STORE_PROV_FREE_FIND_CRL_FUNC = 18;

        [NativeTypeName("#define CERT_STORE_PROV_GET_CRL_PROPERTY_FUNC 19")]
        public const int CERT_STORE_PROV_GET_CRL_PROPERTY_FUNC = 19;

        [NativeTypeName("#define CERT_STORE_PROV_FIND_CTL_FUNC 20")]
        public const int CERT_STORE_PROV_FIND_CTL_FUNC = 20;

        [NativeTypeName("#define CERT_STORE_PROV_FREE_FIND_CTL_FUNC 21")]
        public const int CERT_STORE_PROV_FREE_FIND_CTL_FUNC = 21;

        [NativeTypeName("#define CERT_STORE_PROV_GET_CTL_PROPERTY_FUNC 22")]
        public const int CERT_STORE_PROV_GET_CTL_PROPERTY_FUNC = 22;

        [NativeTypeName("#define CERT_STORE_PROV_WRITE_ADD_FLAG 0x1")]
        public const int CERT_STORE_PROV_WRITE_ADD_FLAG = 0x1;

        [NativeTypeName("#define CERT_STORE_SAVE_AS_STORE 1")]
        public const int CERT_STORE_SAVE_AS_STORE = 1;

        [NativeTypeName("#define CERT_STORE_SAVE_AS_PKCS7 2")]
        public const int CERT_STORE_SAVE_AS_PKCS7 = 2;

        [NativeTypeName("#define CERT_STORE_SAVE_AS_PKCS12 3")]
        public const int CERT_STORE_SAVE_AS_PKCS12 = 3;

        [NativeTypeName("#define CERT_STORE_SAVE_TO_FILE 1")]
        public const int CERT_STORE_SAVE_TO_FILE = 1;

        [NativeTypeName("#define CERT_STORE_SAVE_TO_MEMORY 2")]
        public const int CERT_STORE_SAVE_TO_MEMORY = 2;

        [NativeTypeName("#define CERT_STORE_SAVE_TO_FILENAME_A 3")]
        public const int CERT_STORE_SAVE_TO_FILENAME_A = 3;

        [NativeTypeName("#define CERT_STORE_SAVE_TO_FILENAME_W 4")]
        public const int CERT_STORE_SAVE_TO_FILENAME_W = 4;

        [NativeTypeName("#define CERT_STORE_SAVE_TO_FILENAME CERT_STORE_SAVE_TO_FILENAME_W")]
        public const int CERT_STORE_SAVE_TO_FILENAME = 4;

        [NativeTypeName("#define CERT_CLOSE_STORE_FORCE_FLAG 0x00000001")]
        public const int CERT_CLOSE_STORE_FORCE_FLAG = 0x00000001;

        [NativeTypeName("#define CERT_CLOSE_STORE_CHECK_FLAG 0x00000002")]
        public const int CERT_CLOSE_STORE_CHECK_FLAG = 0x00000002;

        [NativeTypeName("#define CERT_COMPARE_MASK 0xFFFF")]
        public const int CERT_COMPARE_MASK = 0xFFFF;

        [NativeTypeName("#define CERT_COMPARE_SHIFT 16")]
        public const int CERT_COMPARE_SHIFT = 16;

        [NativeTypeName("#define CERT_COMPARE_ANY 0")]
        public const int CERT_COMPARE_ANY = 0;

        [NativeTypeName("#define CERT_COMPARE_SHA1_HASH 1")]
        public const int CERT_COMPARE_SHA1_HASH = 1;

        [NativeTypeName("#define CERT_COMPARE_NAME 2")]
        public const int CERT_COMPARE_NAME = 2;

        [NativeTypeName("#define CERT_COMPARE_ATTR 3")]
        public const int CERT_COMPARE_ATTR = 3;

        [NativeTypeName("#define CERT_COMPARE_MD5_HASH 4")]
        public const int CERT_COMPARE_MD5_HASH = 4;

        [NativeTypeName("#define CERT_COMPARE_PROPERTY 5")]
        public const int CERT_COMPARE_PROPERTY = 5;

        [NativeTypeName("#define CERT_COMPARE_PUBLIC_KEY 6")]
        public const int CERT_COMPARE_PUBLIC_KEY = 6;

        [NativeTypeName("#define CERT_COMPARE_HASH CERT_COMPARE_SHA1_HASH")]
        public const int CERT_COMPARE_HASH = 1;

        [NativeTypeName("#define CERT_COMPARE_NAME_STR_A 7")]
        public const int CERT_COMPARE_NAME_STR_A = 7;

        [NativeTypeName("#define CERT_COMPARE_NAME_STR_W 8")]
        public const int CERT_COMPARE_NAME_STR_W = 8;

        [NativeTypeName("#define CERT_COMPARE_KEY_SPEC 9")]
        public const int CERT_COMPARE_KEY_SPEC = 9;

        [NativeTypeName("#define CERT_COMPARE_ENHKEY_USAGE 10")]
        public const int CERT_COMPARE_ENHKEY_USAGE = 10;

        [NativeTypeName("#define CERT_COMPARE_CTL_USAGE CERT_COMPARE_ENHKEY_USAGE")]
        public const int CERT_COMPARE_CTL_USAGE = 10;

        [NativeTypeName("#define CERT_COMPARE_SUBJECT_CERT 11")]
        public const int CERT_COMPARE_SUBJECT_CERT = 11;

        [NativeTypeName("#define CERT_COMPARE_ISSUER_OF 12")]
        public const int CERT_COMPARE_ISSUER_OF = 12;

        [NativeTypeName("#define CERT_COMPARE_EXISTING 13")]
        public const int CERT_COMPARE_EXISTING = 13;

        [NativeTypeName("#define CERT_COMPARE_SIGNATURE_HASH 14")]
        public const int CERT_COMPARE_SIGNATURE_HASH = 14;

        [NativeTypeName("#define CERT_COMPARE_KEY_IDENTIFIER 15")]
        public const int CERT_COMPARE_KEY_IDENTIFIER = 15;

        [NativeTypeName("#define CERT_COMPARE_CERT_ID 16")]
        public const int CERT_COMPARE_CERT_ID = 16;

        [NativeTypeName("#define CERT_COMPARE_CROSS_CERT_DIST_POINTS 17")]
        public const int CERT_COMPARE_CROSS_CERT_DIST_POINTS = 17;

        [NativeTypeName("#define CERT_COMPARE_PUBKEY_MD5_HASH 18")]
        public const int CERT_COMPARE_PUBKEY_MD5_HASH = 18;

        [NativeTypeName("#define CERT_COMPARE_SUBJECT_INFO_ACCESS 19")]
        public const int CERT_COMPARE_SUBJECT_INFO_ACCESS = 19;

        [NativeTypeName("#define CERT_COMPARE_HASH_STR 20")]
        public const int CERT_COMPARE_HASH_STR = 20;

        [NativeTypeName("#define CERT_COMPARE_HAS_PRIVATE_KEY 21")]
        public const int CERT_COMPARE_HAS_PRIVATE_KEY = 21;

        [NativeTypeName("#define CERT_FIND_ANY (CERT_COMPARE_ANY << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_ANY = (0 << 16);

        [NativeTypeName("#define CERT_FIND_SHA1_HASH (CERT_COMPARE_SHA1_HASH << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_SHA1_HASH = (1 << 16);

        [NativeTypeName("#define CERT_FIND_MD5_HASH (CERT_COMPARE_MD5_HASH << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_MD5_HASH = (4 << 16);

        [NativeTypeName("#define CERT_FIND_SIGNATURE_HASH (CERT_COMPARE_SIGNATURE_HASH << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_SIGNATURE_HASH = (14 << 16);

        [NativeTypeName("#define CERT_FIND_KEY_IDENTIFIER (CERT_COMPARE_KEY_IDENTIFIER << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_KEY_IDENTIFIER = (15 << 16);

        [NativeTypeName("#define CERT_FIND_HASH CERT_FIND_SHA1_HASH")]
        public const int CERT_FIND_HASH = (1 << 16);

        [NativeTypeName("#define CERT_FIND_PROPERTY (CERT_COMPARE_PROPERTY << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_PROPERTY = (5 << 16);

        [NativeTypeName("#define CERT_FIND_PUBLIC_KEY (CERT_COMPARE_PUBLIC_KEY << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_PUBLIC_KEY = (6 << 16);

        [NativeTypeName("#define CERT_FIND_SUBJECT_NAME (CERT_COMPARE_NAME << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_SUBJECT_FLAG)")]
        public const int CERT_FIND_SUBJECT_NAME = (2 << 16 | 7);

        [NativeTypeName("#define CERT_FIND_SUBJECT_ATTR (CERT_COMPARE_ATTR << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_SUBJECT_FLAG)")]
        public const int CERT_FIND_SUBJECT_ATTR = (3 << 16 | 7);

        [NativeTypeName("#define CERT_FIND_ISSUER_NAME (CERT_COMPARE_NAME << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_ISSUER_FLAG)")]
        public const int CERT_FIND_ISSUER_NAME = (2 << 16 | 4);

        [NativeTypeName("#define CERT_FIND_ISSUER_ATTR (CERT_COMPARE_ATTR << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_ISSUER_FLAG)")]
        public const int CERT_FIND_ISSUER_ATTR = (3 << 16 | 4);

        [NativeTypeName("#define CERT_FIND_SUBJECT_STR_A (CERT_COMPARE_NAME_STR_A << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_SUBJECT_FLAG)")]
        public const int CERT_FIND_SUBJECT_STR_A = (7 << 16 | 7);

        [NativeTypeName("#define CERT_FIND_SUBJECT_STR_W (CERT_COMPARE_NAME_STR_W << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_SUBJECT_FLAG)")]
        public const int CERT_FIND_SUBJECT_STR_W = (8 << 16 | 7);

        [NativeTypeName("#define CERT_FIND_SUBJECT_STR CERT_FIND_SUBJECT_STR_W")]
        public const int CERT_FIND_SUBJECT_STR = (8 << 16 | 7);

        [NativeTypeName("#define CERT_FIND_ISSUER_STR_A (CERT_COMPARE_NAME_STR_A << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_ISSUER_FLAG)")]
        public const int CERT_FIND_ISSUER_STR_A = (7 << 16 | 4);

        [NativeTypeName("#define CERT_FIND_ISSUER_STR_W (CERT_COMPARE_NAME_STR_W << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_ISSUER_FLAG)")]
        public const int CERT_FIND_ISSUER_STR_W = (8 << 16 | 4);

        [NativeTypeName("#define CERT_FIND_ISSUER_STR CERT_FIND_ISSUER_STR_W")]
        public const int CERT_FIND_ISSUER_STR = (8 << 16 | 4);

        [NativeTypeName("#define CERT_FIND_KEY_SPEC (CERT_COMPARE_KEY_SPEC << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_KEY_SPEC = (9 << 16);

        [NativeTypeName("#define CERT_FIND_ENHKEY_USAGE (CERT_COMPARE_ENHKEY_USAGE << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_ENHKEY_USAGE = (10 << 16);

        [NativeTypeName("#define CERT_FIND_CTL_USAGE CERT_FIND_ENHKEY_USAGE")]
        public const int CERT_FIND_CTL_USAGE = (10 << 16);

        [NativeTypeName("#define CERT_FIND_SUBJECT_CERT (CERT_COMPARE_SUBJECT_CERT << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_SUBJECT_CERT = (11 << 16);

        [NativeTypeName("#define CERT_FIND_ISSUER_OF (CERT_COMPARE_ISSUER_OF << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_ISSUER_OF = (12 << 16);

        [NativeTypeName("#define CERT_FIND_EXISTING (CERT_COMPARE_EXISTING << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_EXISTING = (13 << 16);

        [NativeTypeName("#define CERT_FIND_CERT_ID (CERT_COMPARE_CERT_ID << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_CERT_ID = (16 << 16);

        [NativeTypeName("#define CERT_FIND_CROSS_CERT_DIST_POINTS (CERT_COMPARE_CROSS_CERT_DIST_POINTS << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_CROSS_CERT_DIST_POINTS = (17 << 16);

        [NativeTypeName("#define CERT_FIND_PUBKEY_MD5_HASH (CERT_COMPARE_PUBKEY_MD5_HASH << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_PUBKEY_MD5_HASH = (18 << 16);

        [NativeTypeName("#define CERT_FIND_SUBJECT_INFO_ACCESS (CERT_COMPARE_SUBJECT_INFO_ACCESS << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_SUBJECT_INFO_ACCESS = (19 << 16);

        [NativeTypeName("#define CERT_FIND_HASH_STR (CERT_COMPARE_HASH_STR << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_HASH_STR = (20 << 16);

        [NativeTypeName("#define CERT_FIND_HAS_PRIVATE_KEY (CERT_COMPARE_HAS_PRIVATE_KEY << CERT_COMPARE_SHIFT)")]
        public const int CERT_FIND_HAS_PRIVATE_KEY = (21 << 16);

        [NativeTypeName("#define CERT_FIND_OPTIONAL_ENHKEY_USAGE_FLAG 0x1")]
        public const int CERT_FIND_OPTIONAL_ENHKEY_USAGE_FLAG = 0x1;

        [NativeTypeName("#define CERT_FIND_EXT_ONLY_ENHKEY_USAGE_FLAG 0x2")]
        public const int CERT_FIND_EXT_ONLY_ENHKEY_USAGE_FLAG = 0x2;

        [NativeTypeName("#define CERT_FIND_PROP_ONLY_ENHKEY_USAGE_FLAG 0x4")]
        public const int CERT_FIND_PROP_ONLY_ENHKEY_USAGE_FLAG = 0x4;

        [NativeTypeName("#define CERT_FIND_NO_ENHKEY_USAGE_FLAG 0x8")]
        public const int CERT_FIND_NO_ENHKEY_USAGE_FLAG = 0x8;

        [NativeTypeName("#define CERT_FIND_OR_ENHKEY_USAGE_FLAG 0x10")]
        public const int CERT_FIND_OR_ENHKEY_USAGE_FLAG = 0x10;

        [NativeTypeName("#define CERT_FIND_VALID_ENHKEY_USAGE_FLAG 0x20")]
        public const int CERT_FIND_VALID_ENHKEY_USAGE_FLAG = 0x20;

        [NativeTypeName("#define CERT_FIND_OPTIONAL_CTL_USAGE_FLAG CERT_FIND_OPTIONAL_ENHKEY_USAGE_FLAG")]
        public const int CERT_FIND_OPTIONAL_CTL_USAGE_FLAG = 0x1;

        [NativeTypeName("#define CERT_FIND_EXT_ONLY_CTL_USAGE_FLAG CERT_FIND_EXT_ONLY_ENHKEY_USAGE_FLAG")]
        public const int CERT_FIND_EXT_ONLY_CTL_USAGE_FLAG = 0x2;

        [NativeTypeName("#define CERT_FIND_PROP_ONLY_CTL_USAGE_FLAG CERT_FIND_PROP_ONLY_ENHKEY_USAGE_FLAG")]
        public const int CERT_FIND_PROP_ONLY_CTL_USAGE_FLAG = 0x4;

        [NativeTypeName("#define CERT_FIND_NO_CTL_USAGE_FLAG CERT_FIND_NO_ENHKEY_USAGE_FLAG")]
        public const int CERT_FIND_NO_CTL_USAGE_FLAG = 0x8;

        [NativeTypeName("#define CERT_FIND_OR_CTL_USAGE_FLAG CERT_FIND_OR_ENHKEY_USAGE_FLAG")]
        public const int CERT_FIND_OR_CTL_USAGE_FLAG = 0x10;

        [NativeTypeName("#define CERT_FIND_VALID_CTL_USAGE_FLAG CERT_FIND_VALID_ENHKEY_USAGE_FLAG")]
        public const int CERT_FIND_VALID_CTL_USAGE_FLAG = 0x20;

        [NativeTypeName("#define CERT_SET_PROPERTY_IGNORE_PERSIST_ERROR_FLAG 0x80000000")]
        public const uint CERT_SET_PROPERTY_IGNORE_PERSIST_ERROR_FLAG = 0x80000000;

        [NativeTypeName("#define CERT_SET_PROPERTY_INHIBIT_PERSIST_FLAG 0x40000000")]
        public const int CERT_SET_PROPERTY_INHIBIT_PERSIST_FLAG = 0x40000000;

        [NativeTypeName("#define CTL_ENTRY_FROM_PROP_CHAIN_FLAG 0x1")]
        public const int CTL_ENTRY_FROM_PROP_CHAIN_FLAG = 0x1;

        [NativeTypeName("#define CRL_FIND_ANY 0")]
        public const int CRL_FIND_ANY = 0;

        [NativeTypeName("#define CRL_FIND_ISSUED_BY 1")]
        public const int CRL_FIND_ISSUED_BY = 1;

        [NativeTypeName("#define CRL_FIND_EXISTING 2")]
        public const int CRL_FIND_EXISTING = 2;

        [NativeTypeName("#define CRL_FIND_ISSUED_FOR 3")]
        public const int CRL_FIND_ISSUED_FOR = 3;

        [NativeTypeName("#define CRL_FIND_ISSUED_BY_AKI_FLAG 0x1")]
        public const int CRL_FIND_ISSUED_BY_AKI_FLAG = 0x1;

        [NativeTypeName("#define CRL_FIND_ISSUED_BY_SIGNATURE_FLAG 0x2")]
        public const int CRL_FIND_ISSUED_BY_SIGNATURE_FLAG = 0x2;

        [NativeTypeName("#define CRL_FIND_ISSUED_BY_DELTA_FLAG 0x4")]
        public const int CRL_FIND_ISSUED_BY_DELTA_FLAG = 0x4;

        [NativeTypeName("#define CRL_FIND_ISSUED_BY_BASE_FLAG 0x8")]
        public const int CRL_FIND_ISSUED_BY_BASE_FLAG = 0x8;

        [NativeTypeName("#define CRL_FIND_ISSUED_FOR_SET_STRONG_PROPERTIES_FLAG 0x10")]
        public const int CRL_FIND_ISSUED_FOR_SET_STRONG_PROPERTIES_FLAG = 0x10;

        [NativeTypeName("#define CERT_STORE_ADD_NEW 1")]
        public const int CERT_STORE_ADD_NEW = 1;

        [NativeTypeName("#define CERT_STORE_ADD_USE_EXISTING 2")]
        public const int CERT_STORE_ADD_USE_EXISTING = 2;

        [NativeTypeName("#define CERT_STORE_ADD_REPLACE_EXISTING 3")]
        public const int CERT_STORE_ADD_REPLACE_EXISTING = 3;

        [NativeTypeName("#define CERT_STORE_ADD_ALWAYS 4")]
        public const int CERT_STORE_ADD_ALWAYS = 4;

        [NativeTypeName("#define CERT_STORE_ADD_REPLACE_EXISTING_INHERIT_PROPERTIES 5")]
        public const int CERT_STORE_ADD_REPLACE_EXISTING_INHERIT_PROPERTIES = 5;

        [NativeTypeName("#define CERT_STORE_ADD_NEWER 6")]
        public const int CERT_STORE_ADD_NEWER = 6;

        [NativeTypeName("#define CERT_STORE_ADD_NEWER_INHERIT_PROPERTIES 7")]
        public const int CERT_STORE_ADD_NEWER_INHERIT_PROPERTIES = 7;

        [NativeTypeName("#define CERT_STORE_CERTIFICATE_CONTEXT 1")]
        public const int CERT_STORE_CERTIFICATE_CONTEXT = 1;

        [NativeTypeName("#define CERT_STORE_CRL_CONTEXT 2")]
        public const int CERT_STORE_CRL_CONTEXT = 2;

        [NativeTypeName("#define CERT_STORE_CTL_CONTEXT 3")]
        public const int CERT_STORE_CTL_CONTEXT = 3;

        [NativeTypeName("#define CERT_STORE_ALL_CONTEXT_FLAG (~0UL)")]
        public const uint CERT_STORE_ALL_CONTEXT_FLAG = (~0U);

        [NativeTypeName("#define CERT_STORE_CERTIFICATE_CONTEXT_FLAG (1 << CERT_STORE_CERTIFICATE_CONTEXT)")]
        public const int CERT_STORE_CERTIFICATE_CONTEXT_FLAG = (1 << 1);

        [NativeTypeName("#define CERT_STORE_CRL_CONTEXT_FLAG (1 << CERT_STORE_CRL_CONTEXT)")]
        public const int CERT_STORE_CRL_CONTEXT_FLAG = (1 << 2);

        [NativeTypeName("#define CERT_STORE_CTL_CONTEXT_FLAG (1 << CERT_STORE_CTL_CONTEXT)")]
        public const int CERT_STORE_CTL_CONTEXT_FLAG = (1 << 3);

        [NativeTypeName("#define CTL_ANY_SUBJECT_TYPE 1")]
        public const int CTL_ANY_SUBJECT_TYPE = 1;

        [NativeTypeName("#define CTL_CERT_SUBJECT_TYPE 2")]
        public const int CTL_CERT_SUBJECT_TYPE = 2;

        [NativeTypeName("#define CTL_FIND_ANY 0")]
        public const int CTL_FIND_ANY = 0;

        [NativeTypeName("#define CTL_FIND_SHA1_HASH 1")]
        public const int CTL_FIND_SHA1_HASH = 1;

        [NativeTypeName("#define CTL_FIND_MD5_HASH 2")]
        public const int CTL_FIND_MD5_HASH = 2;

        [NativeTypeName("#define CTL_FIND_USAGE 3")]
        public const int CTL_FIND_USAGE = 3;

        [NativeTypeName("#define CTL_FIND_SUBJECT 4")]
        public const int CTL_FIND_SUBJECT = 4;

        [NativeTypeName("#define CTL_FIND_EXISTING 5")]
        public const int CTL_FIND_EXISTING = 5;

        [NativeTypeName("#define CTL_FIND_NO_LIST_ID_CBDATA 0xFFFFFFFF")]
        public const uint CTL_FIND_NO_LIST_ID_CBDATA = 0xFFFFFFFF;

        [NativeTypeName("#define CTL_FIND_NO_SIGNER_PTR ((PCERT_INFO) -1)")]
        public static CERT_INFO* CTL_FIND_NO_SIGNER_PTR => unchecked((CERT_INFO*)(-1));

        [NativeTypeName("#define CTL_FIND_SAME_USAGE_FLAG 0x1")]
        public const int CTL_FIND_SAME_USAGE_FLAG = 0x1;

        [NativeTypeName("#define CERT_STORE_CTRL_RESYNC 1")]
        public const int CERT_STORE_CTRL_RESYNC = 1;

        [NativeTypeName("#define CERT_STORE_CTRL_NOTIFY_CHANGE 2")]
        public const int CERT_STORE_CTRL_NOTIFY_CHANGE = 2;

        [NativeTypeName("#define CERT_STORE_CTRL_COMMIT 3")]
        public const int CERT_STORE_CTRL_COMMIT = 3;

        [NativeTypeName("#define CERT_STORE_CTRL_AUTO_RESYNC 4")]
        public const int CERT_STORE_CTRL_AUTO_RESYNC = 4;

        [NativeTypeName("#define CERT_STORE_CTRL_CANCEL_NOTIFY 5")]
        public const int CERT_STORE_CTRL_CANCEL_NOTIFY = 5;

        [NativeTypeName("#define CERT_STORE_CTRL_INHIBIT_DUPLICATE_HANDLE_FLAG 0x1")]
        public const int CERT_STORE_CTRL_INHIBIT_DUPLICATE_HANDLE_FLAG = 0x1;

        [NativeTypeName("#define CERT_STORE_CTRL_COMMIT_FORCE_FLAG 0x1")]
        public const int CERT_STORE_CTRL_COMMIT_FORCE_FLAG = 0x1;

        [NativeTypeName("#define CERT_STORE_CTRL_COMMIT_CLEAR_FLAG 0x2")]
        public const int CERT_STORE_CTRL_COMMIT_CLEAR_FLAG = 0x2;

        [NativeTypeName("#define CERT_STORE_LOCALIZED_NAME_PROP_ID 0x1000")]
        public const int CERT_STORE_LOCALIZED_NAME_PROP_ID = 0x1000;

        [NativeTypeName("#define CERT_CREATE_CONTEXT_NOCOPY_FLAG 0x1")]
        public const int CERT_CREATE_CONTEXT_NOCOPY_FLAG = 0x1;

        [NativeTypeName("#define CERT_CREATE_CONTEXT_SORTED_FLAG 0x2")]
        public const int CERT_CREATE_CONTEXT_SORTED_FLAG = 0x2;

        [NativeTypeName("#define CERT_CREATE_CONTEXT_NO_HCRYPTMSG_FLAG 0x4")]
        public const int CERT_CREATE_CONTEXT_NO_HCRYPTMSG_FLAG = 0x4;

        [NativeTypeName("#define CERT_CREATE_CONTEXT_NO_ENTRY_FLAG 0x8")]
        public const int CERT_CREATE_CONTEXT_NO_ENTRY_FLAG = 0x8;

        [NativeTypeName("#define CERT_PHYSICAL_STORE_ADD_ENABLE_FLAG 0x1")]
        public const int CERT_PHYSICAL_STORE_ADD_ENABLE_FLAG = 0x1;

        [NativeTypeName("#define CERT_PHYSICAL_STORE_OPEN_DISABLE_FLAG 0x2")]
        public const int CERT_PHYSICAL_STORE_OPEN_DISABLE_FLAG = 0x2;

        [NativeTypeName("#define CERT_PHYSICAL_STORE_REMOTE_OPEN_DISABLE_FLAG 0x4")]
        public const int CERT_PHYSICAL_STORE_REMOTE_OPEN_DISABLE_FLAG = 0x4;

        [NativeTypeName("#define CERT_PHYSICAL_STORE_INSERT_COMPUTER_NAME_ENABLE_FLAG 0x8")]
        public const int CERT_PHYSICAL_STORE_INSERT_COMPUTER_NAME_ENABLE_FLAG = 0x8;

        [NativeTypeName("#define CERT_PHYSICAL_STORE_PREDEFINED_ENUM_FLAG 0x1")]
        public const int CERT_PHYSICAL_STORE_PREDEFINED_ENUM_FLAG = 0x1;

        [NativeTypeName("#define CERT_PHYSICAL_STORE_DEFAULT_NAME L\".Default\"")]
        public const string CERT_PHYSICAL_STORE_DEFAULT_NAME = ".Default";

        [NativeTypeName("#define CERT_PHYSICAL_STORE_GROUP_POLICY_NAME L\".GroupPolicy\"")]
        public const string CERT_PHYSICAL_STORE_GROUP_POLICY_NAME = ".GroupPolicy";

        [NativeTypeName("#define CERT_PHYSICAL_STORE_LOCAL_MACHINE_NAME L\".LocalMachine\"")]
        public const string CERT_PHYSICAL_STORE_LOCAL_MACHINE_NAME = ".LocalMachine";

        [NativeTypeName("#define CERT_PHYSICAL_STORE_DS_USER_CERTIFICATE_NAME L\".UserCertificate\"")]
        public const string CERT_PHYSICAL_STORE_DS_USER_CERTIFICATE_NAME = ".UserCertificate";

        [NativeTypeName("#define CERT_PHYSICAL_STORE_LOCAL_MACHINE_GROUP_POLICY_NAME L\".LocalMachineGroupPolicy\"")]
        public const string CERT_PHYSICAL_STORE_LOCAL_MACHINE_GROUP_POLICY_NAME = ".LocalMachineGroupPolicy";

        [NativeTypeName("#define CERT_PHYSICAL_STORE_ENTERPRISE_NAME L\".Enterprise\"")]
        public const string CERT_PHYSICAL_STORE_ENTERPRISE_NAME = ".Enterprise";

        [NativeTypeName("#define CERT_PHYSICAL_STORE_AUTH_ROOT_NAME L\".AuthRoot\"")]
        public const string CERT_PHYSICAL_STORE_AUTH_ROOT_NAME = ".AuthRoot";

        [NativeTypeName("#define CERT_PHYSICAL_STORE_SMART_CARD_NAME L\".SmartCard\"")]
        public const string CERT_PHYSICAL_STORE_SMART_CARD_NAME = ".SmartCard";

        [NativeTypeName("#define CRYPT_OID_OPEN_SYSTEM_STORE_PROV_FUNC \"CertDllOpenSystemStoreProv\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_OPEN_SYSTEM_STORE_PROV_FUNC => new byte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x4F, 0x70, 0x65, 0x6E, 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x50, 0x72, 0x6F, 0x76, 0x00 };

        [NativeTypeName("#define CRYPT_OID_REGISTER_SYSTEM_STORE_FUNC \"CertDllRegisterSystemStore\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_REGISTER_SYSTEM_STORE_FUNC => new byte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x52, 0x65, 0x67, 0x69, 0x73, 0x74, 0x65, 0x72, 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define CRYPT_OID_UNREGISTER_SYSTEM_STORE_FUNC \"CertDllUnregisterSystemStore\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_UNREGISTER_SYSTEM_STORE_FUNC => new byte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x55, 0x6E, 0x72, 0x65, 0x67, 0x69, 0x73, 0x74, 0x65, 0x72, 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define CRYPT_OID_ENUM_SYSTEM_STORE_FUNC \"CertDllEnumSystemStore\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_ENUM_SYSTEM_STORE_FUNC => new byte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x6E, 0x75, 0x6D, 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define CRYPT_OID_REGISTER_PHYSICAL_STORE_FUNC \"CertDllRegisterPhysicalStore\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_REGISTER_PHYSICAL_STORE_FUNC => new byte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x52, 0x65, 0x67, 0x69, 0x73, 0x74, 0x65, 0x72, 0x50, 0x68, 0x79, 0x73, 0x69, 0x63, 0x61, 0x6C, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define CRYPT_OID_UNREGISTER_PHYSICAL_STORE_FUNC \"CertDllUnregisterPhysicalStore\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_UNREGISTER_PHYSICAL_STORE_FUNC => new byte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x55, 0x6E, 0x72, 0x65, 0x67, 0x69, 0x73, 0x74, 0x65, 0x72, 0x50, 0x68, 0x79, 0x73, 0x69, 0x63, 0x61, 0x6C, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define CRYPT_OID_ENUM_PHYSICAL_STORE_FUNC \"CertDllEnumPhysicalStore\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_ENUM_PHYSICAL_STORE_FUNC => new byte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x6E, 0x75, 0x6D, 0x50, 0x68, 0x79, 0x73, 0x69, 0x63, 0x61, 0x6C, 0x53, 0x74, 0x6F, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define CRYPT_OID_SYSTEM_STORE_LOCATION_VALUE_NAME L\"SystemStoreLocation\"")]
        public const string CRYPT_OID_SYSTEM_STORE_LOCATION_VALUE_NAME = "SystemStoreLocation";

        [NativeTypeName("#define CMSG_TRUSTED_SIGNER_FLAG 0x1")]
        public const int CMSG_TRUSTED_SIGNER_FLAG = 0x1;

        [NativeTypeName("#define CMSG_SIGNER_ONLY_FLAG 0x2")]
        public const int CMSG_SIGNER_ONLY_FLAG = 0x2;

        [NativeTypeName("#define CMSG_USE_SIGNER_INDEX_FLAG 0x4")]
        public const int CMSG_USE_SIGNER_INDEX_FLAG = 0x4;

        [NativeTypeName("#define CMSG_CMS_ENCAPSULATED_CTL_FLAG 0x00008000")]
        public const int CMSG_CMS_ENCAPSULATED_CTL_FLAG = 0x00008000;

        [NativeTypeName("#define CMSG_ENCODE_SORTED_CTL_FLAG 0x1")]
        public const int CMSG_ENCODE_SORTED_CTL_FLAG = 0x1;

        [NativeTypeName("#define CMSG_ENCODE_HASHED_SUBJECT_IDENTIFIER_FLAG 0x2")]
        public const int CMSG_ENCODE_HASHED_SUBJECT_IDENTIFIER_FLAG = 0x2;

        [NativeTypeName("#define CERT_VERIFY_INHIBIT_CTL_UPDATE_FLAG 0x1")]
        public const int CERT_VERIFY_INHIBIT_CTL_UPDATE_FLAG = 0x1;

        [NativeTypeName("#define CERT_VERIFY_TRUSTED_SIGNERS_FLAG 0x2")]
        public const int CERT_VERIFY_TRUSTED_SIGNERS_FLAG = 0x2;

        [NativeTypeName("#define CERT_VERIFY_NO_TIME_CHECK_FLAG 0x4")]
        public const int CERT_VERIFY_NO_TIME_CHECK_FLAG = 0x4;

        [NativeTypeName("#define CERT_VERIFY_ALLOW_MORE_USAGE_FLAG 0x8")]
        public const int CERT_VERIFY_ALLOW_MORE_USAGE_FLAG = 0x8;

        [NativeTypeName("#define CERT_VERIFY_UPDATED_CTL_FLAG 0x1")]
        public const int CERT_VERIFY_UPDATED_CTL_FLAG = 0x1;

        [NativeTypeName("#define CERT_CONTEXT_REVOCATION_TYPE 1")]
        public const int CERT_CONTEXT_REVOCATION_TYPE = 1;

        [NativeTypeName("#define CERT_VERIFY_REV_CHAIN_FLAG 0x00000001")]
        public const int CERT_VERIFY_REV_CHAIN_FLAG = 0x00000001;

        [NativeTypeName("#define CERT_VERIFY_CACHE_ONLY_BASED_REVOCATION 0x00000002")]
        public const int CERT_VERIFY_CACHE_ONLY_BASED_REVOCATION = 0x00000002;

        [NativeTypeName("#define CERT_VERIFY_REV_ACCUMULATIVE_TIMEOUT_FLAG 0x00000004")]
        public const int CERT_VERIFY_REV_ACCUMULATIVE_TIMEOUT_FLAG = 0x00000004;

        [NativeTypeName("#define CERT_VERIFY_REV_SERVER_OCSP_FLAG 0x00000008")]
        public const int CERT_VERIFY_REV_SERVER_OCSP_FLAG = 0x00000008;

        [NativeTypeName("#define CERT_VERIFY_REV_NO_OCSP_FAILOVER_TO_CRL_FLAG 0x00000010")]
        public const int CERT_VERIFY_REV_NO_OCSP_FAILOVER_TO_CRL_FLAG = 0x00000010;

        [NativeTypeName("#define CERT_VERIFY_REV_SERVER_OCSP_WIRE_ONLY_FLAG 0x00000020")]
        public const int CERT_VERIFY_REV_SERVER_OCSP_WIRE_ONLY_FLAG = 0x00000020;

        [NativeTypeName("#define CERT_UNICODE_IS_RDN_ATTRS_FLAG 0x1")]
        public const int CERT_UNICODE_IS_RDN_ATTRS_FLAG = 0x1;

        [NativeTypeName("#define CERT_CASE_INSENSITIVE_IS_RDN_ATTRS_FLAG 0x2")]
        public const int CERT_CASE_INSENSITIVE_IS_RDN_ATTRS_FLAG = 0x2;

        [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_SUBJECT_BLOB 1")]
        public const int CRYPT_VERIFY_CERT_SIGN_SUBJECT_BLOB = 1;

        [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_SUBJECT_CERT 2")]
        public const int CRYPT_VERIFY_CERT_SIGN_SUBJECT_CERT = 2;

        [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_SUBJECT_CRL 3")]
        public const int CRYPT_VERIFY_CERT_SIGN_SUBJECT_CRL = 3;

        [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_SUBJECT_OCSP_BASIC_SIGNED_RESPONSE 4")]
        public const int CRYPT_VERIFY_CERT_SIGN_SUBJECT_OCSP_BASIC_SIGNED_RESPONSE = 4;

        [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_ISSUER_PUBKEY 1")]
        public const int CRYPT_VERIFY_CERT_SIGN_ISSUER_PUBKEY = 1;

        [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_ISSUER_CERT 2")]
        public const int CRYPT_VERIFY_CERT_SIGN_ISSUER_CERT = 2;

        [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_ISSUER_CHAIN 3")]
        public const int CRYPT_VERIFY_CERT_SIGN_ISSUER_CHAIN = 3;

        [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_ISSUER_NULL 4")]
        public const int CRYPT_VERIFY_CERT_SIGN_ISSUER_NULL = 4;

        [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_DISABLE_MD2_MD4_FLAG 0x00000001")]
        public const int CRYPT_VERIFY_CERT_SIGN_DISABLE_MD2_MD4_FLAG = 0x00000001;

        [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_SET_STRONG_PROPERTIES_FLAG 0x00000002")]
        public const int CRYPT_VERIFY_CERT_SIGN_SET_STRONG_PROPERTIES_FLAG = 0x00000002;

        [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_RETURN_STRONG_PROPERTIES_FLAG 0x00000004")]
        public const int CRYPT_VERIFY_CERT_SIGN_RETURN_STRONG_PROPERTIES_FLAG = 0x00000004;

        [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_CHECK_WEAK_HASH_FLAG 0x00000008")]
        public const int CRYPT_VERIFY_CERT_SIGN_CHECK_WEAK_HASH_FLAG = 0x00000008;

        [NativeTypeName("#define CRYPT_OID_EXTRACT_ENCODED_SIGNATURE_PARAMETERS_FUNC \"CryptDllExtractEncodedSignatureParameters\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_EXTRACT_ENCODED_SIGNATURE_PARAMETERS_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x74, 0x72, 0x61, 0x63, 0x74, 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x64, 0x53, 0x69, 0x67, 0x6E, 0x61, 0x74, 0x75, 0x72, 0x65, 0x50, 0x61, 0x72, 0x61, 0x6D, 0x65, 0x74, 0x65, 0x72, 0x73, 0x00 };

        [NativeTypeName("#define CRYPT_OID_SIGN_AND_ENCODE_HASH_FUNC \"CryptDllSignAndEncodeHash\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_SIGN_AND_ENCODE_HASH_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x53, 0x69, 0x67, 0x6E, 0x41, 0x6E, 0x64, 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x48, 0x61, 0x73, 0x68, 0x00 };

        [NativeTypeName("#define CRYPT_OID_VERIFY_ENCODED_SIGNATURE_FUNC \"CryptDllVerifyEncodedSignature\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_VERIFY_ENCODED_SIGNATURE_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x56, 0x65, 0x72, 0x69, 0x66, 0x79, 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x64, 0x53, 0x69, 0x67, 0x6E, 0x61, 0x74, 0x75, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define CRYPT_DEFAULT_CONTEXT_AUTO_RELEASE_FLAG 0x00000001")]
        public const int CRYPT_DEFAULT_CONTEXT_AUTO_RELEASE_FLAG = 0x00000001;

        [NativeTypeName("#define CRYPT_DEFAULT_CONTEXT_PROCESS_FLAG 0x00000002")]
        public const int CRYPT_DEFAULT_CONTEXT_PROCESS_FLAG = 0x00000002;

        [NativeTypeName("#define CRYPT_DEFAULT_CONTEXT_CERT_SIGN_OID 1")]
        public const int CRYPT_DEFAULT_CONTEXT_CERT_SIGN_OID = 1;

        [NativeTypeName("#define CRYPT_DEFAULT_CONTEXT_MULTI_CERT_SIGN_OID 2")]
        public const int CRYPT_DEFAULT_CONTEXT_MULTI_CERT_SIGN_OID = 2;

        [NativeTypeName("#define CRYPT_OID_EXPORT_PUBLIC_KEY_INFO_FUNC \"CryptDllExportPublicKeyInfoEx\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_EXPORT_PUBLIC_KEY_INFO_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x50, 0x75, 0x62, 0x6C, 0x69, 0x63, 0x4B, 0x65, 0x79, 0x49, 0x6E, 0x66, 0x6F, 0x45, 0x78, 0x00 };

        [NativeTypeName("#define CRYPT_OID_EXPORT_PUBLIC_KEY_INFO_EX2_FUNC \"CryptDllExportPublicKeyInfoEx2\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_EXPORT_PUBLIC_KEY_INFO_EX2_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x50, 0x75, 0x62, 0x6C, 0x69, 0x63, 0x4B, 0x65, 0x79, 0x49, 0x6E, 0x66, 0x6F, 0x45, 0x78, 0x32, 0x00 };

        [NativeTypeName("#define CRYPT_OID_EXPORT_PUBLIC_KEY_INFO_FROM_BCRYPT_HANDLE_FUNC \"CryptDllExportPublicKeyInfoFromBCryptKeyHandle\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_EXPORT_PUBLIC_KEY_INFO_FROM_BCRYPT_HANDLE_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x50, 0x75, 0x62, 0x6C, 0x69, 0x63, 0x4B, 0x65, 0x79, 0x49, 0x6E, 0x66, 0x6F, 0x46, 0x72, 0x6F, 0x6D, 0x42, 0x43, 0x72, 0x79, 0x70, 0x74, 0x4B, 0x65, 0x79, 0x48, 0x61, 0x6E, 0x64, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define CRYPT_OID_IMPORT_PUBLIC_KEY_INFO_FUNC \"CryptDllImportPublicKeyInfoEx\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_IMPORT_PUBLIC_KEY_INFO_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x50, 0x75, 0x62, 0x6C, 0x69, 0x63, 0x4B, 0x65, 0x79, 0x49, 0x6E, 0x66, 0x6F, 0x45, 0x78, 0x00 };

        [NativeTypeName("#define CRYPT_OID_IMPORT_PUBLIC_KEY_INFO_EX2_FUNC \"CryptDllImportPublicKeyInfoEx2\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_IMPORT_PUBLIC_KEY_INFO_EX2_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x50, 0x75, 0x62, 0x6C, 0x69, 0x63, 0x4B, 0x65, 0x79, 0x49, 0x6E, 0x66, 0x6F, 0x45, 0x78, 0x32, 0x00 };

        [NativeTypeName("#define CRYPT_ACQUIRE_CACHE_FLAG 0x00000001")]
        public const int CRYPT_ACQUIRE_CACHE_FLAG = 0x00000001;

        [NativeTypeName("#define CRYPT_ACQUIRE_USE_PROV_INFO_FLAG 0x00000002")]
        public const int CRYPT_ACQUIRE_USE_PROV_INFO_FLAG = 0x00000002;

        [NativeTypeName("#define CRYPT_ACQUIRE_COMPARE_KEY_FLAG 0x00000004")]
        public const int CRYPT_ACQUIRE_COMPARE_KEY_FLAG = 0x00000004;

        [NativeTypeName("#define CRYPT_ACQUIRE_NO_HEALING 0x00000008")]
        public const int CRYPT_ACQUIRE_NO_HEALING = 0x00000008;

        [NativeTypeName("#define CRYPT_ACQUIRE_SILENT_FLAG 0x00000040")]
        public const int CRYPT_ACQUIRE_SILENT_FLAG = 0x00000040;

        [NativeTypeName("#define CRYPT_ACQUIRE_WINDOW_HANDLE_FLAG 0x00000080")]
        public const int CRYPT_ACQUIRE_WINDOW_HANDLE_FLAG = 0x00000080;

        [NativeTypeName("#define CRYPT_ACQUIRE_NCRYPT_KEY_FLAGS_MASK 0x00070000")]
        public const int CRYPT_ACQUIRE_NCRYPT_KEY_FLAGS_MASK = 0x00070000;

        [NativeTypeName("#define CRYPT_ACQUIRE_ALLOW_NCRYPT_KEY_FLAG 0x00010000")]
        public const int CRYPT_ACQUIRE_ALLOW_NCRYPT_KEY_FLAG = 0x00010000;

        [NativeTypeName("#define CRYPT_ACQUIRE_PREFER_NCRYPT_KEY_FLAG 0x00020000")]
        public const int CRYPT_ACQUIRE_PREFER_NCRYPT_KEY_FLAG = 0x00020000;

        [NativeTypeName("#define CRYPT_ACQUIRE_ONLY_NCRYPT_KEY_FLAG 0x00040000")]
        public const int CRYPT_ACQUIRE_ONLY_NCRYPT_KEY_FLAG = 0x00040000;

        [NativeTypeName("#define CRYPT_FIND_USER_KEYSET_FLAG 0x00000001")]
        public const int CRYPT_FIND_USER_KEYSET_FLAG = 0x00000001;

        [NativeTypeName("#define CRYPT_FIND_MACHINE_KEYSET_FLAG 0x00000002")]
        public const int CRYPT_FIND_MACHINE_KEYSET_FLAG = 0x00000002;

        [NativeTypeName("#define CRYPT_FIND_SILENT_KEYSET_FLAG 0x00000040")]
        public const int CRYPT_FIND_SILENT_KEYSET_FLAG = 0x00000040;

        [NativeTypeName("#define CRYPT_OID_IMPORT_PRIVATE_KEY_INFO_FUNC \"CryptDllImportPrivateKeyInfoEx\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_IMPORT_PRIVATE_KEY_INFO_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x49, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x50, 0x72, 0x69, 0x76, 0x61, 0x74, 0x65, 0x4B, 0x65, 0x79, 0x49, 0x6E, 0x66, 0x6F, 0x45, 0x78, 0x00 };

        [NativeTypeName("#define CRYPT_OID_EXPORT_PRIVATE_KEY_INFO_FUNC \"CryptDllExportPrivateKeyInfoEx\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_EXPORT_PRIVATE_KEY_INFO_FUNC => new byte[] { 0x43, 0x72, 0x79, 0x70, 0x74, 0x44, 0x6C, 0x6C, 0x45, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x50, 0x72, 0x69, 0x76, 0x61, 0x74, 0x65, 0x4B, 0x65, 0x79, 0x49, 0x6E, 0x66, 0x6F, 0x45, 0x78, 0x00 };

        [NativeTypeName("#define CRYPT_DELETE_KEYSET CRYPT_DELETEKEYSET")]
        public const int CRYPT_DELETE_KEYSET = 0x00000010;

        [NativeTypeName("#define CertRDNValueToStr CertRDNValueToStrW")]
        public static delegate*<uint, CRYPT_DATA_BLOB*, ushort*, uint, uint> CertRDNValueToStr => &CertRDNValueToStrW;

        [NativeTypeName("#define CertNameToStr CertNameToStrW")]
        public static delegate*<uint, CRYPT_DATA_BLOB*, uint, ushort*, uint, uint> CertNameToStr => &CertNameToStrW;

        [NativeTypeName("#define CERT_SIMPLE_NAME_STR 1")]
        public const int CERT_SIMPLE_NAME_STR = 1;

        [NativeTypeName("#define CERT_OID_NAME_STR 2")]
        public const int CERT_OID_NAME_STR = 2;

        [NativeTypeName("#define CERT_X500_NAME_STR 3")]
        public const int CERT_X500_NAME_STR = 3;

        [NativeTypeName("#define CERT_XML_NAME_STR 4")]
        public const int CERT_XML_NAME_STR = 4;

        [NativeTypeName("#define CERT_NAME_STR_SEMICOLON_FLAG 0x40000000")]
        public const int CERT_NAME_STR_SEMICOLON_FLAG = 0x40000000;

        [NativeTypeName("#define CERT_NAME_STR_NO_PLUS_FLAG 0x20000000")]
        public const int CERT_NAME_STR_NO_PLUS_FLAG = 0x20000000;

        [NativeTypeName("#define CERT_NAME_STR_NO_QUOTING_FLAG 0x10000000")]
        public const int CERT_NAME_STR_NO_QUOTING_FLAG = 0x10000000;

        [NativeTypeName("#define CERT_NAME_STR_CRLF_FLAG 0x08000000")]
        public const int CERT_NAME_STR_CRLF_FLAG = 0x08000000;

        [NativeTypeName("#define CERT_NAME_STR_COMMA_FLAG 0x04000000")]
        public const int CERT_NAME_STR_COMMA_FLAG = 0x04000000;

        [NativeTypeName("#define CERT_NAME_STR_REVERSE_FLAG 0x02000000")]
        public const int CERT_NAME_STR_REVERSE_FLAG = 0x02000000;

        [NativeTypeName("#define CERT_NAME_STR_FORWARD_FLAG 0x01000000")]
        public const int CERT_NAME_STR_FORWARD_FLAG = 0x01000000;

        [NativeTypeName("#define CERT_NAME_STR_DISABLE_IE4_UTF8_FLAG 0x00010000")]
        public const int CERT_NAME_STR_DISABLE_IE4_UTF8_FLAG = 0x00010000;

        [NativeTypeName("#define CERT_NAME_STR_ENABLE_T61_UNICODE_FLAG 0x00020000")]
        public const int CERT_NAME_STR_ENABLE_T61_UNICODE_FLAG = 0x00020000;

        [NativeTypeName("#define CERT_NAME_STR_ENABLE_UTF8_UNICODE_FLAG 0x00040000")]
        public const int CERT_NAME_STR_ENABLE_UTF8_UNICODE_FLAG = 0x00040000;

        [NativeTypeName("#define CERT_NAME_STR_FORCE_UTF8_DIR_STR_FLAG 0x00080000")]
        public const int CERT_NAME_STR_FORCE_UTF8_DIR_STR_FLAG = 0x00080000;

        [NativeTypeName("#define CERT_NAME_STR_DISABLE_UTF8_DIR_STR_FLAG 0x00100000")]
        public const int CERT_NAME_STR_DISABLE_UTF8_DIR_STR_FLAG = 0x00100000;

        [NativeTypeName("#define CERT_NAME_STR_ENABLE_PUNYCODE_FLAG 0x00200000")]
        public const int CERT_NAME_STR_ENABLE_PUNYCODE_FLAG = 0x00200000;

        [NativeTypeName("#define CertStrToName CertStrToNameW")]
        public static delegate*<uint, ushort*, uint, void*, byte*, uint*, ushort**, int> CertStrToName => &CertStrToNameW;

        [NativeTypeName("#define CertGetNameString CertGetNameStringW")]
        public static delegate*<CERT_CONTEXT*, uint, uint, void*, ushort*, uint, uint> CertGetNameString => &CertGetNameStringW;

        [NativeTypeName("#define CERT_NAME_EMAIL_TYPE 1")]
        public const int CERT_NAME_EMAIL_TYPE = 1;

        [NativeTypeName("#define CERT_NAME_RDN_TYPE 2")]
        public const int CERT_NAME_RDN_TYPE = 2;

        [NativeTypeName("#define CERT_NAME_ATTR_TYPE 3")]
        public const int CERT_NAME_ATTR_TYPE = 3;

        [NativeTypeName("#define CERT_NAME_SIMPLE_DISPLAY_TYPE 4")]
        public const int CERT_NAME_SIMPLE_DISPLAY_TYPE = 4;

        [NativeTypeName("#define CERT_NAME_FRIENDLY_DISPLAY_TYPE 5")]
        public const int CERT_NAME_FRIENDLY_DISPLAY_TYPE = 5;

        [NativeTypeName("#define CERT_NAME_DNS_TYPE 6")]
        public const int CERT_NAME_DNS_TYPE = 6;

        [NativeTypeName("#define CERT_NAME_URL_TYPE 7")]
        public const int CERT_NAME_URL_TYPE = 7;

        [NativeTypeName("#define CERT_NAME_UPN_TYPE 8")]
        public const int CERT_NAME_UPN_TYPE = 8;

        [NativeTypeName("#define CERT_NAME_ISSUER_FLAG 0x1")]
        public const int CERT_NAME_ISSUER_FLAG = 0x1;

        [NativeTypeName("#define CERT_NAME_DISABLE_IE4_UTF8_FLAG 0x00010000")]
        public const int CERT_NAME_DISABLE_IE4_UTF8_FLAG = 0x00010000;

        [NativeTypeName("#define CERT_NAME_SEARCH_ALL_NAMES_FLAG 0x2")]
        public const int CERT_NAME_SEARCH_ALL_NAMES_FLAG = 0x2;

        [NativeTypeName("#define CRYPT_MESSAGE_BARE_CONTENT_OUT_FLAG 0x00000001")]
        public const int CRYPT_MESSAGE_BARE_CONTENT_OUT_FLAG = 0x00000001;

        [NativeTypeName("#define CRYPT_MESSAGE_ENCAPSULATED_CONTENT_OUT_FLAG 0x00000002")]
        public const int CRYPT_MESSAGE_ENCAPSULATED_CONTENT_OUT_FLAG = 0x00000002;

        [NativeTypeName("#define CRYPT_MESSAGE_KEYID_SIGNER_FLAG 0x00000004")]
        public const int CRYPT_MESSAGE_KEYID_SIGNER_FLAG = 0x00000004;

        [NativeTypeName("#define CRYPT_MESSAGE_SILENT_KEYSET_FLAG 0x00000040")]
        public const int CRYPT_MESSAGE_SILENT_KEYSET_FLAG = 0x00000040;

        [NativeTypeName("#define CRYPT_MESSAGE_KEYID_RECIPIENT_FLAG 0x4")]
        public const int CRYPT_MESSAGE_KEYID_RECIPIENT_FLAG = 0x4;

        [NativeTypeName("#define CertOpenSystemStore CertOpenSystemStoreW")]
        public static delegate*<IntPtr, ushort*, IntPtr> CertOpenSystemStore => &CertOpenSystemStoreW;

        [NativeTypeName("#define CertAddEncodedCertificateToSystemStore CertAddEncodedCertificateToSystemStoreW")]
        public static delegate*<ushort*, byte*, uint, int> CertAddEncodedCertificateToSystemStore => &CertAddEncodedCertificateToSystemStoreW;

        [NativeTypeName("#define CERT_QUERY_OBJECT_FILE 0x00000001")]
        public const int CERT_QUERY_OBJECT_FILE = 0x00000001;

        [NativeTypeName("#define CERT_QUERY_OBJECT_BLOB 0x00000002")]
        public const int CERT_QUERY_OBJECT_BLOB = 0x00000002;

        [NativeTypeName("#define CERT_QUERY_CONTENT_CERT 1")]
        public const int CERT_QUERY_CONTENT_CERT = 1;

        [NativeTypeName("#define CERT_QUERY_CONTENT_CTL 2")]
        public const int CERT_QUERY_CONTENT_CTL = 2;

        [NativeTypeName("#define CERT_QUERY_CONTENT_CRL 3")]
        public const int CERT_QUERY_CONTENT_CRL = 3;

        [NativeTypeName("#define CERT_QUERY_CONTENT_SERIALIZED_STORE 4")]
        public const int CERT_QUERY_CONTENT_SERIALIZED_STORE = 4;

        [NativeTypeName("#define CERT_QUERY_CONTENT_SERIALIZED_CERT 5")]
        public const int CERT_QUERY_CONTENT_SERIALIZED_CERT = 5;

        [NativeTypeName("#define CERT_QUERY_CONTENT_SERIALIZED_CTL 6")]
        public const int CERT_QUERY_CONTENT_SERIALIZED_CTL = 6;

        [NativeTypeName("#define CERT_QUERY_CONTENT_SERIALIZED_CRL 7")]
        public const int CERT_QUERY_CONTENT_SERIALIZED_CRL = 7;

        [NativeTypeName("#define CERT_QUERY_CONTENT_PKCS7_SIGNED 8")]
        public const int CERT_QUERY_CONTENT_PKCS7_SIGNED = 8;

        [NativeTypeName("#define CERT_QUERY_CONTENT_PKCS7_UNSIGNED 9")]
        public const int CERT_QUERY_CONTENT_PKCS7_UNSIGNED = 9;

        [NativeTypeName("#define CERT_QUERY_CONTENT_PKCS7_SIGNED_EMBED 10")]
        public const int CERT_QUERY_CONTENT_PKCS7_SIGNED_EMBED = 10;

        [NativeTypeName("#define CERT_QUERY_CONTENT_PKCS10 11")]
        public const int CERT_QUERY_CONTENT_PKCS10 = 11;

        [NativeTypeName("#define CERT_QUERY_CONTENT_PFX 12")]
        public const int CERT_QUERY_CONTENT_PFX = 12;

        [NativeTypeName("#define CERT_QUERY_CONTENT_CERT_PAIR 13")]
        public const int CERT_QUERY_CONTENT_CERT_PAIR = 13;

        [NativeTypeName("#define CERT_QUERY_CONTENT_PFX_AND_LOAD 14")]
        public const int CERT_QUERY_CONTENT_PFX_AND_LOAD = 14;

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_CERT ( 1 << CERT_QUERY_CONTENT_CERT)")]
        public const int CERT_QUERY_CONTENT_FLAG_CERT = (1 << 1);

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_CTL ( 1 << CERT_QUERY_CONTENT_CTL)")]
        public const int CERT_QUERY_CONTENT_FLAG_CTL = (1 << 2);

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_CRL ( 1 << CERT_QUERY_CONTENT_CRL)")]
        public const int CERT_QUERY_CONTENT_FLAG_CRL = (1 << 3);

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE ( 1 << CERT_QUERY_CONTENT_SERIALIZED_STORE)")]
        public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE = (1 << 4);

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT ( 1 << CERT_QUERY_CONTENT_SERIALIZED_CERT)")]
        public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT = (1 << 5);

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_SERIALIZED_CTL ( 1 << CERT_QUERY_CONTENT_SERIALIZED_CTL)")]
        public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_CTL = (1 << 6);

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_SERIALIZED_CRL ( 1 << CERT_QUERY_CONTENT_SERIALIZED_CRL)")]
        public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_CRL = (1 << 7);

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED ( 1 << CERT_QUERY_CONTENT_PKCS7_SIGNED)")]
        public const int CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED = (1 << 8);

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED ( 1 << CERT_QUERY_CONTENT_PKCS7_UNSIGNED)")]
        public const int CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED = (1 << 9);

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED_EMBED ( 1 << CERT_QUERY_CONTENT_PKCS7_SIGNED_EMBED)")]
        public const int CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED_EMBED = (1 << 10);

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_PKCS10 ( 1 << CERT_QUERY_CONTENT_PKCS10)")]
        public const int CERT_QUERY_CONTENT_FLAG_PKCS10 = (1 << 11);

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_PFX ( 1 << CERT_QUERY_CONTENT_PFX)")]
        public const int CERT_QUERY_CONTENT_FLAG_PFX = (1 << 12);

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_CERT_PAIR ( 1 << CERT_QUERY_CONTENT_CERT_PAIR)")]
        public const int CERT_QUERY_CONTENT_FLAG_CERT_PAIR = (1 << 13);

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_PFX_AND_LOAD ( 1 << CERT_QUERY_CONTENT_PFX_AND_LOAD)")]
        public const int CERT_QUERY_CONTENT_FLAG_PFX_AND_LOAD = (1 << 14);

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_ALL ( CERT_QUERY_CONTENT_FLAG_CERT |                  \\\r\n                CERT_QUERY_CONTENT_FLAG_CTL  |                  \\\r\n                CERT_QUERY_CONTENT_FLAG_CRL  |                  \\\r\n                CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE |      \\\r\n                CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT  |      \\\r\n                CERT_QUERY_CONTENT_FLAG_SERIALIZED_CTL   |      \\\r\n                CERT_QUERY_CONTENT_FLAG_SERIALIZED_CRL   |      \\\r\n                CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED     |      \\\r\n                CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED   |      \\\r\n                CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED_EMBED |    \\\r\n                CERT_QUERY_CONTENT_FLAG_PKCS10                     |    \\\r\n                CERT_QUERY_CONTENT_FLAG_PFX                |    \\\r\n                CERT_QUERY_CONTENT_FLAG_CERT_PAIR )")]
        public const int CERT_QUERY_CONTENT_FLAG_ALL = ((1 << 1) | (1 << 2) | (1 << 3) | (1 << 4) | (1 << 5) | (1 << 6) | (1 << 7) | (1 << 8) | (1 << 9) | (1 << 10) | (1 << 11) | (1 << 12) | (1 << 13));

        [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_ALL_ISSUER_CERT ( CERT_QUERY_CONTENT_FLAG_CERT             |      \\\r\n                CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE |      \\\r\n                CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT  |      \\\r\n                CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED     |      \\\r\n                CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED   )")]
        public const int CERT_QUERY_CONTENT_FLAG_ALL_ISSUER_CERT = ((1 << 1) | (1 << 4) | (1 << 5) | (1 << 8) | (1 << 9));

        [NativeTypeName("#define CERT_QUERY_FORMAT_BINARY 1")]
        public const int CERT_QUERY_FORMAT_BINARY = 1;

        [NativeTypeName("#define CERT_QUERY_FORMAT_BASE64_ENCODED 2")]
        public const int CERT_QUERY_FORMAT_BASE64_ENCODED = 2;

        [NativeTypeName("#define CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED 3")]
        public const int CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED = 3;

        [NativeTypeName("#define CERT_QUERY_FORMAT_FLAG_BINARY ( 1 << CERT_QUERY_FORMAT_BINARY)")]
        public const int CERT_QUERY_FORMAT_FLAG_BINARY = (1 << 1);

        [NativeTypeName("#define CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED ( 1 << CERT_QUERY_FORMAT_BASE64_ENCODED)")]
        public const int CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED = (1 << 2);

        [NativeTypeName("#define CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED ( 1 << CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED)")]
        public const int CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED = (1 << 3);

        [NativeTypeName("#define CERT_QUERY_FORMAT_FLAG_ALL ( CERT_QUERY_FORMAT_FLAG_BINARY   |       \\\r\n            CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED | \\\r\n            CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED )")]
        public const int CERT_QUERY_FORMAT_FLAG_ALL = ((1 << 1) | (1 << 2) | (1 << 3));

        [NativeTypeName("#define CREDENTIAL_OID_PASSWORD_CREDENTIALS_A ((LPCSTR)1)")]
        public static sbyte* CREDENTIAL_OID_PASSWORD_CREDENTIALS_A => ((sbyte*)(1));

        [NativeTypeName("#define CREDENTIAL_OID_PASSWORD_CREDENTIALS_W ((LPCSTR)2)")]
        public static sbyte* CREDENTIAL_OID_PASSWORD_CREDENTIALS_W => ((sbyte*)(2));

        [NativeTypeName("#define CREDENTIAL_OID_PASSWORD_CREDENTIALS CREDENTIAL_OID_PASSWORD_CREDENTIALS_W")]
        public static sbyte* CREDENTIAL_OID_PASSWORD_CREDENTIALS => ((sbyte*)(2));

        [NativeTypeName("#define SCHEME_OID_RETRIEVE_ENCODED_OBJECT_FUNC \"SchemeDllRetrieveEncodedObject\"")]
        public static ReadOnlySpan<byte> SCHEME_OID_RETRIEVE_ENCODED_OBJECT_FUNC => new byte[] { 0x53, 0x63, 0x68, 0x65, 0x6D, 0x65, 0x44, 0x6C, 0x6C, 0x52, 0x65, 0x74, 0x72, 0x69, 0x65, 0x76, 0x65, 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x64, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        [NativeTypeName("#define SCHEME_OID_RETRIEVE_ENCODED_OBJECTW_FUNC \"SchemeDllRetrieveEncodedObjectW\"")]
        public static ReadOnlySpan<byte> SCHEME_OID_RETRIEVE_ENCODED_OBJECTW_FUNC => new byte[] { 0x53, 0x63, 0x68, 0x65, 0x6D, 0x65, 0x44, 0x6C, 0x6C, 0x52, 0x65, 0x74, 0x72, 0x69, 0x65, 0x76, 0x65, 0x45, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x64, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x57, 0x00 };

        [NativeTypeName("#define CONTEXT_OID_CREATE_OBJECT_CONTEXT_FUNC \"ContextDllCreateObjectContext\"")]
        public static ReadOnlySpan<byte> CONTEXT_OID_CREATE_OBJECT_CONTEXT_FUNC => new byte[] { 0x43, 0x6F, 0x6E, 0x74, 0x65, 0x78, 0x74, 0x44, 0x6C, 0x6C, 0x43, 0x72, 0x65, 0x61, 0x74, 0x65, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x43, 0x6F, 0x6E, 0x74, 0x65, 0x78, 0x74, 0x00 };

        [NativeTypeName("#define CONTEXT_OID_CERTIFICATE ((LPCSTR)1)")]
        public static sbyte* CONTEXT_OID_CERTIFICATE => ((sbyte*)(1));

        [NativeTypeName("#define CONTEXT_OID_CRL ((LPCSTR)2)")]
        public static sbyte* CONTEXT_OID_CRL => ((sbyte*)(2));

        [NativeTypeName("#define CONTEXT_OID_CTL ((LPCSTR)3)")]
        public static sbyte* CONTEXT_OID_CTL => ((sbyte*)(3));

        [NativeTypeName("#define CONTEXT_OID_PKCS7 ((LPCSTR)4)")]
        public static sbyte* CONTEXT_OID_PKCS7 => ((sbyte*)(4));

        [NativeTypeName("#define CONTEXT_OID_CAPI2_ANY ((LPCSTR)5)")]
        public static sbyte* CONTEXT_OID_CAPI2_ANY => ((sbyte*)(5));

        [NativeTypeName("#define CONTEXT_OID_OCSP_RESP ((LPCSTR)6)")]
        public static sbyte* CONTEXT_OID_OCSP_RESP => ((sbyte*)(6));

        [NativeTypeName("#define CRYPT_RETRIEVE_MULTIPLE_OBJECTS 0x00000001")]
        public const int CRYPT_RETRIEVE_MULTIPLE_OBJECTS = 0x00000001;

        [NativeTypeName("#define CRYPT_CACHE_ONLY_RETRIEVAL 0x00000002")]
        public const int CRYPT_CACHE_ONLY_RETRIEVAL = 0x00000002;

        [NativeTypeName("#define CRYPT_WIRE_ONLY_RETRIEVAL 0x00000004")]
        public const int CRYPT_WIRE_ONLY_RETRIEVAL = 0x00000004;

        [NativeTypeName("#define CRYPT_DONT_CACHE_RESULT 0x00000008")]
        public const int CRYPT_DONT_CACHE_RESULT = 0x00000008;

        [NativeTypeName("#define CRYPT_ASYNC_RETRIEVAL 0x00000010")]
        public const int CRYPT_ASYNC_RETRIEVAL = 0x00000010;

        [NativeTypeName("#define CRYPT_STICKY_CACHE_RETRIEVAL 0x00001000")]
        public const int CRYPT_STICKY_CACHE_RETRIEVAL = 0x00001000;

        [NativeTypeName("#define CRYPT_LDAP_SCOPE_BASE_ONLY_RETRIEVAL 0x00002000")]
        public const int CRYPT_LDAP_SCOPE_BASE_ONLY_RETRIEVAL = 0x00002000;

        [NativeTypeName("#define CRYPT_OFFLINE_CHECK_RETRIEVAL 0x00004000")]
        public const int CRYPT_OFFLINE_CHECK_RETRIEVAL = 0x00004000;

        [NativeTypeName("#define CRYPT_LDAP_INSERT_ENTRY_ATTRIBUTE 0x00008000")]
        public const int CRYPT_LDAP_INSERT_ENTRY_ATTRIBUTE = 0x00008000;

        [NativeTypeName("#define CRYPT_LDAP_SIGN_RETRIEVAL 0x00010000")]
        public const int CRYPT_LDAP_SIGN_RETRIEVAL = 0x00010000;

        [NativeTypeName("#define CRYPT_NO_AUTH_RETRIEVAL 0x00020000")]
        public const int CRYPT_NO_AUTH_RETRIEVAL = 0x00020000;

        [NativeTypeName("#define CRYPT_LDAP_AREC_EXCLUSIVE_RETRIEVAL 0x00040000")]
        public const int CRYPT_LDAP_AREC_EXCLUSIVE_RETRIEVAL = 0x00040000;

        [NativeTypeName("#define CRYPT_AIA_RETRIEVAL 0x00080000")]
        public const int CRYPT_AIA_RETRIEVAL = 0x00080000;

        [NativeTypeName("#define CRYPT_HTTP_POST_RETRIEVAL 0x00100000")]
        public const int CRYPT_HTTP_POST_RETRIEVAL = 0x00100000;

        [NativeTypeName("#define CRYPT_PROXY_CACHE_RETRIEVAL 0x00200000")]
        public const int CRYPT_PROXY_CACHE_RETRIEVAL = 0x00200000;

        [NativeTypeName("#define CRYPT_NOT_MODIFIED_RETRIEVAL 0x00400000")]
        public const int CRYPT_NOT_MODIFIED_RETRIEVAL = 0x00400000;

        [NativeTypeName("#define CRYPT_ENABLE_SSL_REVOCATION_RETRIEVAL 0x00800000")]
        public const int CRYPT_ENABLE_SSL_REVOCATION_RETRIEVAL = 0x00800000;

        [NativeTypeName("#define CRYPT_RANDOM_QUERY_STRING_RETRIEVAL 0x04000000")]
        public const int CRYPT_RANDOM_QUERY_STRING_RETRIEVAL = 0x04000000;

        [NativeTypeName("#define CRYPT_ENABLE_FILE_RETRIEVAL 0x08000000")]
        public const int CRYPT_ENABLE_FILE_RETRIEVAL = 0x08000000;

        [NativeTypeName("#define CRYPT_CREATE_NEW_FLUSH_ENTRY 0x10000000")]
        public const int CRYPT_CREATE_NEW_FLUSH_ENTRY = 0x10000000;

        [NativeTypeName("#define CRYPT_VERIFY_CONTEXT_SIGNATURE 0x00000020")]
        public const int CRYPT_VERIFY_CONTEXT_SIGNATURE = 0x00000020;

        [NativeTypeName("#define CRYPT_VERIFY_DATA_HASH 0x00000040")]
        public const int CRYPT_VERIFY_DATA_HASH = 0x00000040;

        [NativeTypeName("#define CRYPT_KEEP_TIME_VALID 0x00000080")]
        public const int CRYPT_KEEP_TIME_VALID = 0x00000080;

        [NativeTypeName("#define CRYPT_DONT_VERIFY_SIGNATURE 0x00000100")]
        public const int CRYPT_DONT_VERIFY_SIGNATURE = 0x00000100;

        [NativeTypeName("#define CRYPT_DONT_CHECK_TIME_VALIDITY 0x00000200")]
        public const int CRYPT_DONT_CHECK_TIME_VALIDITY = 0x00000200;

        [NativeTypeName("#define CRYPT_CHECK_FRESHNESS_TIME_VALIDITY 0x00000400")]
        public const int CRYPT_CHECK_FRESHNESS_TIME_VALIDITY = 0x00000400;

        [NativeTypeName("#define CRYPT_ACCUMULATIVE_TIMEOUT 0x00000800")]
        public const int CRYPT_ACCUMULATIVE_TIMEOUT = 0x00000800;

        [NativeTypeName("#define CRYPT_OCSP_ONLY_RETRIEVAL 0x01000000")]
        public const int CRYPT_OCSP_ONLY_RETRIEVAL = 0x01000000;

        [NativeTypeName("#define CRYPT_NO_OCSP_FAILOVER_TO_CRL_RETRIEVAL 0x02000000")]
        public const int CRYPT_NO_OCSP_FAILOVER_TO_CRL_RETRIEVAL = 0x02000000;

        [NativeTypeName("#define CRYPTNET_URL_CACHE_PRE_FETCH_NONE 0")]
        public const int CRYPTNET_URL_CACHE_PRE_FETCH_NONE = 0;

        [NativeTypeName("#define CRYPTNET_URL_CACHE_PRE_FETCH_BLOB 1")]
        public const int CRYPTNET_URL_CACHE_PRE_FETCH_BLOB = 1;

        [NativeTypeName("#define CRYPTNET_URL_CACHE_PRE_FETCH_CRL 2")]
        public const int CRYPTNET_URL_CACHE_PRE_FETCH_CRL = 2;

        [NativeTypeName("#define CRYPTNET_URL_CACHE_PRE_FETCH_OCSP 3")]
        public const int CRYPTNET_URL_CACHE_PRE_FETCH_OCSP = 3;

        [NativeTypeName("#define CRYPTNET_URL_CACHE_PRE_FETCH_AUTOROOT_CAB 5")]
        public const int CRYPTNET_URL_CACHE_PRE_FETCH_AUTOROOT_CAB = 5;

        [NativeTypeName("#define CRYPTNET_URL_CACHE_PRE_FETCH_DISALLOWED_CERT_CAB 6")]
        public const int CRYPTNET_URL_CACHE_PRE_FETCH_DISALLOWED_CERT_CAB = 6;

        [NativeTypeName("#define CRYPTNET_URL_CACHE_PRE_FETCH_PIN_RULES_CAB 7")]
        public const int CRYPTNET_URL_CACHE_PRE_FETCH_PIN_RULES_CAB = 7;

        [NativeTypeName("#define CRYPTNET_URL_CACHE_DEFAULT_FLUSH 0")]
        public const int CRYPTNET_URL_CACHE_DEFAULT_FLUSH = 0;

        [NativeTypeName("#define CRYPTNET_URL_CACHE_DISABLE_FLUSH 0xFFFFFFFF")]
        public const uint CRYPTNET_URL_CACHE_DISABLE_FLUSH = 0xFFFFFFFF;

        [NativeTypeName("#define CRYPTNET_URL_CACHE_RESPONSE_NONE 0")]
        public const int CRYPTNET_URL_CACHE_RESPONSE_NONE = 0;

        [NativeTypeName("#define CRYPTNET_URL_CACHE_RESPONSE_HTTP 1")]
        public const int CRYPTNET_URL_CACHE_RESPONSE_HTTP = 1;

        [NativeTypeName("#define CRYPTNET_URL_CACHE_RESPONSE_VALIDATED 0x8000")]
        public const int CRYPTNET_URL_CACHE_RESPONSE_VALIDATED = 0x8000;

        [NativeTypeName("#define CRYPT_RETRIEVE_MAX_ERROR_CONTENT_LENGTH 0x1000")]
        public const int CRYPT_RETRIEVE_MAX_ERROR_CONTENT_LENGTH = 0x1000;

        [NativeTypeName("#define CryptRetrieveObjectByUrl CryptRetrieveObjectByUrlW")]
        public static delegate*<ushort*, sbyte*, uint, uint, void**, IntPtr, CRYPT_CREDENTIALS*, void*, CRYPT_RETRIEVE_AUX_INFO*, int> CryptRetrieveObjectByUrl => &CryptRetrieveObjectByUrlW;

        [NativeTypeName("#define CRYPT_PARAM_ASYNC_RETRIEVAL_COMPLETION ((LPCSTR)1)")]
        public static sbyte* CRYPT_PARAM_ASYNC_RETRIEVAL_COMPLETION => ((sbyte*)(1));

        [NativeTypeName("#define CRYPT_PARAM_CANCEL_ASYNC_RETRIEVAL ((LPCSTR)2)")]
        public static sbyte* CRYPT_PARAM_CANCEL_ASYNC_RETRIEVAL => ((sbyte*)(2));

        [NativeTypeName("#define CRYPT_GET_URL_FROM_PROPERTY 0x00000001")]
        public const int CRYPT_GET_URL_FROM_PROPERTY = 0x00000001;

        [NativeTypeName("#define CRYPT_GET_URL_FROM_EXTENSION 0x00000002")]
        public const int CRYPT_GET_URL_FROM_EXTENSION = 0x00000002;

        [NativeTypeName("#define CRYPT_GET_URL_FROM_UNAUTH_ATTRIBUTE 0x00000004")]
        public const int CRYPT_GET_URL_FROM_UNAUTH_ATTRIBUTE = 0x00000004;

        [NativeTypeName("#define CRYPT_GET_URL_FROM_AUTH_ATTRIBUTE 0x00000008")]
        public const int CRYPT_GET_URL_FROM_AUTH_ATTRIBUTE = 0x00000008;

        [NativeTypeName("#define URL_OID_GET_OBJECT_URL_FUNC \"UrlDllGetObjectUrl\"")]
        public static ReadOnlySpan<byte> URL_OID_GET_OBJECT_URL_FUNC => new byte[] { 0x55, 0x72, 0x6C, 0x44, 0x6C, 0x6C, 0x47, 0x65, 0x74, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x55, 0x72, 0x6C, 0x00 };

        [NativeTypeName("#define URL_OID_CERTIFICATE_ISSUER ((LPCSTR)1)")]
        public static sbyte* URL_OID_CERTIFICATE_ISSUER => ((sbyte*)(1));

        [NativeTypeName("#define URL_OID_CERTIFICATE_CRL_DIST_POINT ((LPCSTR)2)")]
        public static sbyte* URL_OID_CERTIFICATE_CRL_DIST_POINT => ((sbyte*)(2));

        [NativeTypeName("#define URL_OID_CTL_ISSUER ((LPCSTR)3)")]
        public static sbyte* URL_OID_CTL_ISSUER => ((sbyte*)(3));

        [NativeTypeName("#define URL_OID_CTL_NEXT_UPDATE ((LPCSTR)4)")]
        public static sbyte* URL_OID_CTL_NEXT_UPDATE => ((sbyte*)(4));

        [NativeTypeName("#define URL_OID_CRL_ISSUER ((LPCSTR)5)")]
        public static sbyte* URL_OID_CRL_ISSUER => ((sbyte*)(5));

        [NativeTypeName("#define URL_OID_CERTIFICATE_FRESHEST_CRL ((LPCSTR)6)")]
        public static sbyte* URL_OID_CERTIFICATE_FRESHEST_CRL => ((sbyte*)(6));

        [NativeTypeName("#define URL_OID_CRL_FRESHEST_CRL ((LPCSTR)7)")]
        public static sbyte* URL_OID_CRL_FRESHEST_CRL => ((sbyte*)(7));

        [NativeTypeName("#define URL_OID_CROSS_CERT_DIST_POINT ((LPCSTR)8)")]
        public static sbyte* URL_OID_CROSS_CERT_DIST_POINT => ((sbyte*)(8));

        [NativeTypeName("#define URL_OID_CERTIFICATE_OCSP ((LPCSTR)9)")]
        public static sbyte* URL_OID_CERTIFICATE_OCSP => ((sbyte*)(9));

        [NativeTypeName("#define URL_OID_CERTIFICATE_OCSP_AND_CRL_DIST_POINT ((LPCSTR)10)")]
        public static sbyte* URL_OID_CERTIFICATE_OCSP_AND_CRL_DIST_POINT => ((sbyte*)(10));

        [NativeTypeName("#define URL_OID_CERTIFICATE_CRL_DIST_POINT_AND_OCSP ((LPCSTR)11)")]
        public static sbyte* URL_OID_CERTIFICATE_CRL_DIST_POINT_AND_OCSP => ((sbyte*)(11));

        [NativeTypeName("#define URL_OID_CROSS_CERT_SUBJECT_INFO_ACCESS ((LPCSTR)12)")]
        public static sbyte* URL_OID_CROSS_CERT_SUBJECT_INFO_ACCESS => ((sbyte*)(12));

        [NativeTypeName("#define URL_OID_CERTIFICATE_ONLY_OCSP ((LPCSTR)13)")]
        public static sbyte* URL_OID_CERTIFICATE_ONLY_OCSP => ((sbyte*)(13));

        [NativeTypeName("#define TIME_VALID_OID_GET_OBJECT_FUNC \"TimeValidDllGetObject\"")]
        public static ReadOnlySpan<byte> TIME_VALID_OID_GET_OBJECT_FUNC => new byte[] { 0x54, 0x69, 0x6D, 0x65, 0x56, 0x61, 0x6C, 0x69, 0x64, 0x44, 0x6C, 0x6C, 0x47, 0x65, 0x74, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        [NativeTypeName("#define TIME_VALID_OID_GET_CTL ((LPCSTR)1)")]
        public static sbyte* TIME_VALID_OID_GET_CTL => ((sbyte*)(1));

        [NativeTypeName("#define TIME_VALID_OID_GET_CRL ((LPCSTR)2)")]
        public static sbyte* TIME_VALID_OID_GET_CRL => ((sbyte*)(2));

        [NativeTypeName("#define TIME_VALID_OID_GET_CRL_FROM_CERT ((LPCSTR)3)")]
        public static sbyte* TIME_VALID_OID_GET_CRL_FROM_CERT => ((sbyte*)(3));

        [NativeTypeName("#define TIME_VALID_OID_GET_FRESHEST_CRL_FROM_CERT ((LPCSTR)4)")]
        public static sbyte* TIME_VALID_OID_GET_FRESHEST_CRL_FROM_CERT => ((sbyte*)(4));

        [NativeTypeName("#define TIME_VALID_OID_GET_FRESHEST_CRL_FROM_CRL ((LPCSTR)5)")]
        public static sbyte* TIME_VALID_OID_GET_FRESHEST_CRL_FROM_CRL => ((sbyte*)(5));

        [NativeTypeName("#define TIME_VALID_OID_FLUSH_OBJECT_FUNC \"TimeValidDllFlushObject\"")]
        public static ReadOnlySpan<byte> TIME_VALID_OID_FLUSH_OBJECT_FUNC => new byte[] { 0x54, 0x69, 0x6D, 0x65, 0x56, 0x61, 0x6C, 0x69, 0x64, 0x44, 0x6C, 0x6C, 0x46, 0x6C, 0x75, 0x73, 0x68, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        [NativeTypeName("#define TIME_VALID_OID_FLUSH_CTL ((LPCSTR)1)")]
        public static sbyte* TIME_VALID_OID_FLUSH_CTL => ((sbyte*)(1));

        [NativeTypeName("#define TIME_VALID_OID_FLUSH_CRL ((LPCSTR)2)")]
        public static sbyte* TIME_VALID_OID_FLUSH_CRL => ((sbyte*)(2));

        [NativeTypeName("#define TIME_VALID_OID_FLUSH_CRL_FROM_CERT ((LPCSTR)3)")]
        public static sbyte* TIME_VALID_OID_FLUSH_CRL_FROM_CERT => ((sbyte*)(3));

        [NativeTypeName("#define TIME_VALID_OID_FLUSH_FRESHEST_CRL_FROM_CERT ((LPCSTR)4)")]
        public static sbyte* TIME_VALID_OID_FLUSH_FRESHEST_CRL_FROM_CERT => ((sbyte*)(4));

        [NativeTypeName("#define TIME_VALID_OID_FLUSH_FRESHEST_CRL_FROM_CRL ((LPCSTR)5)")]
        public static sbyte* TIME_VALID_OID_FLUSH_FRESHEST_CRL_FROM_CRL => ((sbyte*)(5));

        [NativeTypeName("#define CERT_CREATE_SELFSIGN_NO_SIGN 1")]
        public const int CERT_CREATE_SELFSIGN_NO_SIGN = 1;

        [NativeTypeName("#define CERT_CREATE_SELFSIGN_NO_KEY_INFO 2")]
        public const int CERT_CREATE_SELFSIGN_NO_KEY_INFO = 2;

        [NativeTypeName("#define CRYPT_KEYID_MACHINE_FLAG 0x00000020")]
        public const int CRYPT_KEYID_MACHINE_FLAG = 0x00000020;

        [NativeTypeName("#define CRYPT_KEYID_ALLOC_FLAG 0x00008000")]
        public const int CRYPT_KEYID_ALLOC_FLAG = 0x00008000;

        [NativeTypeName("#define CRYPT_KEYID_DELETE_FLAG 0x00000010")]
        public const int CRYPT_KEYID_DELETE_FLAG = 0x00000010;

        [NativeTypeName("#define CRYPT_KEYID_SET_NEW_FLAG 0x00002000")]
        public const int CRYPT_KEYID_SET_NEW_FLAG = 0x00002000;

        [NativeTypeName("#define CERT_CHAIN_CONFIG_REGPATH L\"Software\\\\Microsoft\\\\Cryptography\\\\OID\\\\EncodingType 0\\\\CertDllCreateCertificateChainEngine\\\\Config\"")]
        public const string CERT_CHAIN_CONFIG_REGPATH = "Software\\Microsoft\\Cryptography\\OID\\EncodingType 0\\CertDllCreateCertificateChainEngine\\Config";

        [NativeTypeName("#define CERT_CHAIN_MAX_URL_RETRIEVAL_BYTE_COUNT_VALUE_NAME L\"MaxUrlRetrievalByteCount\"")]
        public const string CERT_CHAIN_MAX_URL_RETRIEVAL_BYTE_COUNT_VALUE_NAME = "MaxUrlRetrievalByteCount";

        [NativeTypeName("#define CERT_CHAIN_MAX_URL_RETRIEVAL_BYTE_COUNT_DEFAULT (100*1024*1024)")]
        public const int CERT_CHAIN_MAX_URL_RETRIEVAL_BYTE_COUNT_DEFAULT = (100 * 1024 * 1024);

        [NativeTypeName("#define CERT_CHAIN_CACHE_RESYNC_FILETIME_VALUE_NAME L\"ChainCacheResyncFiletime\"")]
        public const string CERT_CHAIN_CACHE_RESYNC_FILETIME_VALUE_NAME = "ChainCacheResyncFiletime";

        [NativeTypeName("#define CERT_CHAIN_DISABLE_MANDATORY_BASIC_CONSTRAINTS_VALUE_NAME L\"DisableMandatoryBasicConstraints\"")]
        public const string CERT_CHAIN_DISABLE_MANDATORY_BASIC_CONSTRAINTS_VALUE_NAME = "DisableMandatoryBasicConstraints";

        [NativeTypeName("#define CERT_CHAIN_DISABLE_CA_NAME_CONSTRAINTS_VALUE_NAME L\"DisableCANameConstraints\"")]
        public const string CERT_CHAIN_DISABLE_CA_NAME_CONSTRAINTS_VALUE_NAME = "DisableCANameConstraints";

        [NativeTypeName("#define CERT_CHAIN_DISABLE_UNSUPPORTED_CRITICAL_EXTENSIONS_VALUE_NAME L\"DisableUnsupportedCriticalExtensions\"")]
        public const string CERT_CHAIN_DISABLE_UNSUPPORTED_CRITICAL_EXTENSIONS_VALUE_NAME = "DisableUnsupportedCriticalExtensions";

        [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_COUNT_IN_CERT_VALUE_NAME L\"MaxAIAUrlCountInCert\"")]
        public const string CERT_CHAIN_MAX_AIA_URL_COUNT_IN_CERT_VALUE_NAME = "MaxAIAUrlCountInCert";

        [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_COUNT_IN_CERT_DEFAULT 5")]
        public const int CERT_CHAIN_MAX_AIA_URL_COUNT_IN_CERT_DEFAULT = 5;

        [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_COUNT_PER_CHAIN_VALUE_NAME L\"MaxAIAUrlRetrievalCountPerChain\"")]
        public const string CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_COUNT_PER_CHAIN_VALUE_NAME = "MaxAIAUrlRetrievalCountPerChain";

        [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_COUNT_PER_CHAIN_DEFAULT 3")]
        public const int CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_COUNT_PER_CHAIN_DEFAULT = 3;

        [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_BYTE_COUNT_VALUE_NAME L\"MaxAIAUrlRetrievalByteCount\"")]
        public const string CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_BYTE_COUNT_VALUE_NAME = "MaxAIAUrlRetrievalByteCount";

        [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_BYTE_COUNT_DEFAULT 100000")]
        public const int CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_BYTE_COUNT_DEFAULT = 100000;

        [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_CERT_COUNT_VALUE_NAME L\"MaxAIAUrlRetrievalCertCount\"")]
        public const string CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_CERT_COUNT_VALUE_NAME = "MaxAIAUrlRetrievalCertCount";

        [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_CERT_COUNT_DEFAULT 10")]
        public const int CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_CERT_COUNT_DEFAULT = 10;

        [NativeTypeName("#define CERT_CHAIN_OCSP_VALIDITY_SECONDS_VALUE_NAME L\"OcspValiditySeconds\"")]
        public const string CERT_CHAIN_OCSP_VALIDITY_SECONDS_VALUE_NAME = "OcspValiditySeconds";

        [NativeTypeName("#define CERT_CHAIN_OCSP_VALIDITY_SECONDS_DEFAULT (12 * 60 * 60)")]
        public const int CERT_CHAIN_OCSP_VALIDITY_SECONDS_DEFAULT = (12 * 60 * 60);

        [NativeTypeName("#define CERT_CHAIN_DISABLE_SERIAL_CHAIN_VALUE_NAME L\"DisableSerialChain\"")]
        public const string CERT_CHAIN_DISABLE_SERIAL_CHAIN_VALUE_NAME = "DisableSerialChain";

        [NativeTypeName("#define CERT_CHAIN_SERIAL_CHAIN_LOG_FILE_NAME_VALUE_NAME L\"SerialChainLogFileName\"")]
        public const string CERT_CHAIN_SERIAL_CHAIN_LOG_FILE_NAME_VALUE_NAME = "SerialChainLogFileName";

        [NativeTypeName("#define CERT_CHAIN_DISABLE_SYNC_WITH_SSL_TIME_VALUE_NAME L\"DisableSyncWithSslTime\"")]
        public const string CERT_CHAIN_DISABLE_SYNC_WITH_SSL_TIME_VALUE_NAME = "DisableSyncWithSslTime";

        [NativeTypeName("#define CERT_CHAIN_MAX_SSL_TIME_UPDATED_EVENT_COUNT_VALUE_NAME L\"MaxSslTimeUpdatedEventCount\"")]
        public const string CERT_CHAIN_MAX_SSL_TIME_UPDATED_EVENT_COUNT_VALUE_NAME = "MaxSslTimeUpdatedEventCount";

        [NativeTypeName("#define CERT_CHAIN_MAX_SSL_TIME_UPDATED_EVENT_COUNT_DEFAULT 5")]
        public const int CERT_CHAIN_MAX_SSL_TIME_UPDATED_EVENT_COUNT_DEFAULT = 5;

        [NativeTypeName("#define CERT_CHAIN_MAX_SSL_TIME_UPDATED_EVENT_COUNT_DISABLE 0xFFFFFFFF")]
        public const uint CERT_CHAIN_MAX_SSL_TIME_UPDATED_EVENT_COUNT_DISABLE = 0xFFFFFFFF;

        [NativeTypeName("#define CERT_CHAIN_SSL_HANDSHAKE_LOG_FILE_NAME_VALUE_NAME L\"SslHandshakeLogFileName\"")]
        public const string CERT_CHAIN_SSL_HANDSHAKE_LOG_FILE_NAME_VALUE_NAME = "SslHandshakeLogFileName";

        [NativeTypeName("#define CERT_CHAIN_ENABLE_WEAK_SIGNATURE_FLAGS_VALUE_NAME L\"EnableWeakSignatureFlags\"")]
        public const string CERT_CHAIN_ENABLE_WEAK_SIGNATURE_FLAGS_VALUE_NAME = "EnableWeakSignatureFlags";

        [NativeTypeName("#define CERT_CHAIN_ENABLE_MD2_MD4_FLAG 0x00000001")]
        public const int CERT_CHAIN_ENABLE_MD2_MD4_FLAG = 0x00000001;

        [NativeTypeName("#define CERT_CHAIN_ENABLE_WEAK_RSA_ROOT_FLAG 0x00000002")]
        public const int CERT_CHAIN_ENABLE_WEAK_RSA_ROOT_FLAG = 0x00000002;

        [NativeTypeName("#define CERT_CHAIN_ENABLE_WEAK_LOGGING_FLAG 0x00000004")]
        public const int CERT_CHAIN_ENABLE_WEAK_LOGGING_FLAG = 0x00000004;

        [NativeTypeName("#define CERT_CHAIN_ENABLE_ONLY_WEAK_LOGGING_FLAG 0x00000008")]
        public const int CERT_CHAIN_ENABLE_ONLY_WEAK_LOGGING_FLAG = 0x00000008;

        [NativeTypeName("#define CERT_CHAIN_MIN_RSA_PUB_KEY_BIT_LENGTH_VALUE_NAME L\"MinRsaPubKeyBitLength\"")]
        public const string CERT_CHAIN_MIN_RSA_PUB_KEY_BIT_LENGTH_VALUE_NAME = "MinRsaPubKeyBitLength";

        [NativeTypeName("#define CERT_CHAIN_MIN_RSA_PUB_KEY_BIT_LENGTH_DEFAULT 1023")]
        public const int CERT_CHAIN_MIN_RSA_PUB_KEY_BIT_LENGTH_DEFAULT = 1023;

        [NativeTypeName("#define CERT_CHAIN_MIN_RSA_PUB_KEY_BIT_LENGTH_DISABLE 0xFFFFFFFF")]
        public const uint CERT_CHAIN_MIN_RSA_PUB_KEY_BIT_LENGTH_DISABLE = 0xFFFFFFFF;

        [NativeTypeName("#define CERT_CHAIN_WEAK_RSA_PUB_KEY_TIME_VALUE_NAME L\"WeakRsaPubKeyTime\"")]
        public const string CERT_CHAIN_WEAK_RSA_PUB_KEY_TIME_VALUE_NAME = "WeakRsaPubKeyTime";

        [NativeTypeName("#define CERT_CHAIN_WEAK_RSA_PUB_KEY_TIME_DEFAULT 0x01CA8A755C6E0000ui64")]
        public const ulong CERT_CHAIN_WEAK_RSA_PUB_KEY_TIME_DEFAULT = 0x01CA8A755C6E0000UL;

        [NativeTypeName("#define CERT_CHAIN_WEAK_SIGNATURE_LOG_DIR_VALUE_NAME L\"WeakSignatureLogDir\"")]
        public const string CERT_CHAIN_WEAK_SIGNATURE_LOG_DIR_VALUE_NAME = "WeakSignatureLogDir";

        [NativeTypeName("#define CERT_CHAIN_DEFAULT_CONFIG_SUBDIR L\"Default\"")]
        public const string CERT_CHAIN_DEFAULT_CONFIG_SUBDIR = "Default";

        [NativeTypeName("#define CERT_CHAIN_WEAK_PREFIX_NAME L\"Weak\"")]
        public const string CERT_CHAIN_WEAK_PREFIX_NAME = "Weak";

        [NativeTypeName("#define CERT_CHAIN_WEAK_THIRD_PARTY_CONFIG_NAME L\"ThirdParty\"")]
        public const string CERT_CHAIN_WEAK_THIRD_PARTY_CONFIG_NAME = "ThirdParty";

        [NativeTypeName("#define CERT_CHAIN_WEAK_ALL_CONFIG_NAME L\"All\"")]
        public const string CERT_CHAIN_WEAK_ALL_CONFIG_NAME = "All";

        [NativeTypeName("#define CERT_CHAIN_WEAK_FLAGS_NAME L\"Flags\"")]
        public const string CERT_CHAIN_WEAK_FLAGS_NAME = "Flags";

        [NativeTypeName("#define CERT_CHAIN_WEAK_HYGIENE_NAME L\"Hygiene\"")]
        public const string CERT_CHAIN_WEAK_HYGIENE_NAME = "Hygiene";

        [NativeTypeName("#define CERT_CHAIN_WEAK_AFTER_TIME_NAME L\"AfterTime\"")]
        public const string CERT_CHAIN_WEAK_AFTER_TIME_NAME = "AfterTime";

        [NativeTypeName("#define CERT_CHAIN_WEAK_FILE_HASH_AFTER_TIME_NAME L\"FileHashAfterTime\"")]
        public const string CERT_CHAIN_WEAK_FILE_HASH_AFTER_TIME_NAME = "FileHashAfterTime";

        [NativeTypeName("#define CERT_CHAIN_WEAK_TIMESTAMP_HASH_AFTER_TIME_NAME L\"TimestampHashAfterTime\"")]
        public const string CERT_CHAIN_WEAK_TIMESTAMP_HASH_AFTER_TIME_NAME = "TimestampHashAfterTime";

        [NativeTypeName("#define CERT_CHAIN_WEAK_MIN_BIT_LENGTH_NAME L\"MinBitLength\"")]
        public const string CERT_CHAIN_WEAK_MIN_BIT_LENGTH_NAME = "MinBitLength";

        [NativeTypeName("#define CERT_CHAIN_WEAK_SHA256_ALLOW_NAME L\"Sha256Allow\"")]
        public const string CERT_CHAIN_WEAK_SHA256_ALLOW_NAME = "Sha256Allow";

        [NativeTypeName("#define CERT_CHAIN_MIN_PUB_KEY_BIT_LENGTH_DISABLE 0xFFFFFFFF")]
        public const uint CERT_CHAIN_MIN_PUB_KEY_BIT_LENGTH_DISABLE = 0xFFFFFFFF;

        [NativeTypeName("#define CERT_CHAIN_ENABLE_WEAK_SETTINGS_FLAG 0x80000000")]
        public const uint CERT_CHAIN_ENABLE_WEAK_SETTINGS_FLAG = 0x80000000;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_ECC_PARA_FLAG 0x00000010")]
        public const int CERT_CHAIN_DISABLE_ECC_PARA_FLAG = 0x00000010;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_ALL_EKU_WEAK_FLAG 0x00010000")]
        public const int CERT_CHAIN_DISABLE_ALL_EKU_WEAK_FLAG = 0x00010000;

        [NativeTypeName("#define CERT_CHAIN_ENABLE_ALL_EKU_HYGIENE_FLAG 0x00020000")]
        public const int CERT_CHAIN_ENABLE_ALL_EKU_HYGIENE_FLAG = 0x00020000;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_OPT_IN_SERVER_AUTH_WEAK_FLAG 0x00040000")]
        public const int CERT_CHAIN_DISABLE_OPT_IN_SERVER_AUTH_WEAK_FLAG = 0x00040000;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_SERVER_AUTH_WEAK_FLAG 0x00100000")]
        public const int CERT_CHAIN_DISABLE_SERVER_AUTH_WEAK_FLAG = 0x00100000;

        [NativeTypeName("#define CERT_CHAIN_ENABLE_SERVER_AUTH_HYGIENE_FLAG 0x00200000")]
        public const int CERT_CHAIN_ENABLE_SERVER_AUTH_HYGIENE_FLAG = 0x00200000;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_CODE_SIGNING_WEAK_FLAG 0x00400000")]
        public const int CERT_CHAIN_DISABLE_CODE_SIGNING_WEAK_FLAG = 0x00400000;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_MOTW_CODE_SIGNING_WEAK_FLAG 0x00800000")]
        public const int CERT_CHAIN_DISABLE_MOTW_CODE_SIGNING_WEAK_FLAG = 0x00800000;

        [NativeTypeName("#define CERT_CHAIN_ENABLE_CODE_SIGNING_HYGIENE_FLAG 0x01000000")]
        public const int CERT_CHAIN_ENABLE_CODE_SIGNING_HYGIENE_FLAG = 0x01000000;

        [NativeTypeName("#define CERT_CHAIN_ENABLE_MOTW_CODE_SIGNING_HYGIENE_FLAG 0x02000000")]
        public const int CERT_CHAIN_ENABLE_MOTW_CODE_SIGNING_HYGIENE_FLAG = 0x02000000;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_TIMESTAMP_WEAK_FLAG 0x04000000")]
        public const int CERT_CHAIN_DISABLE_TIMESTAMP_WEAK_FLAG = 0x04000000;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_WEAK_FLAG 0x08000000")]
        public const int CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_WEAK_FLAG = 0x08000000;

        [NativeTypeName("#define CERT_CHAIN_ENABLE_TIMESTAMP_HYGIENE_FLAG 0x10000000")]
        public const int CERT_CHAIN_ENABLE_TIMESTAMP_HYGIENE_FLAG = 0x10000000;

        [NativeTypeName("#define CERT_CHAIN_ENABLE_MOTW_TIMESTAMP_HYGIENE_FLAG 0x20000000")]
        public const int CERT_CHAIN_ENABLE_MOTW_TIMESTAMP_HYGIENE_FLAG = 0x20000000;

        [NativeTypeName("#define CERT_CHAIN_MOTW_IGNORE_AFTER_TIME_WEAK_FLAG 0x40000000")]
        public const int CERT_CHAIN_MOTW_IGNORE_AFTER_TIME_WEAK_FLAG = 0x40000000;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_FILE_HASH_WEAK_FLAG 0x00001000")]
        public const int CERT_CHAIN_DISABLE_FILE_HASH_WEAK_FLAG = 0x00001000;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_MOTW_FILE_HASH_WEAK_FLAG 0x00002000")]
        public const int CERT_CHAIN_DISABLE_MOTW_FILE_HASH_WEAK_FLAG = 0x00002000;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_TIMESTAMP_HASH_WEAK_FLAG 0x00004000")]
        public const int CERT_CHAIN_DISABLE_TIMESTAMP_HASH_WEAK_FLAG = 0x00004000;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_HASH_WEAK_FLAG 0x00008000")]
        public const int CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_HASH_WEAK_FLAG = 0x00008000;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_WEAK_FLAGS (                 \\\r\n    CERT_CHAIN_DISABLE_ECC_PARA_FLAG |                  \\\r\n    CERT_CHAIN_DISABLE_ALL_EKU_WEAK_FLAG |              \\\r\n    CERT_CHAIN_DISABLE_SERVER_AUTH_WEAK_FLAG |          \\\r\n    CERT_CHAIN_DISABLE_OPT_IN_SERVER_AUTH_WEAK_FLAG |   \\\r\n    CERT_CHAIN_DISABLE_CODE_SIGNING_WEAK_FLAG |         \\\r\n    CERT_CHAIN_DISABLE_MOTW_CODE_SIGNING_WEAK_FLAG |    \\\r\n    CERT_CHAIN_DISABLE_TIMESTAMP_WEAK_FLAG |            \\\r\n    CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_WEAK_FLAG )")]
        public const int CERT_CHAIN_DISABLE_WEAK_FLAGS = (0x00000010 | 0x00010000 | 0x00100000 | 0x00040000 | 0x00400000 | 0x00800000 | 0x04000000 | 0x08000000);

        [NativeTypeName("#define CERT_CHAIN_DISABLE_FILE_HASH_WEAK_FLAGS (       \\\r\n    CERT_CHAIN_DISABLE_FILE_HASH_WEAK_FLAG |            \\\r\n    CERT_CHAIN_DISABLE_MOTW_FILE_HASH_WEAK_FLAG )")]
        public const int CERT_CHAIN_DISABLE_FILE_HASH_WEAK_FLAGS = (0x00001000 | 0x00002000);

        [NativeTypeName("#define CERT_CHAIN_DISABLE_TIMESTAMP_HASH_WEAK_FLAGS (  \\\r\n    CERT_CHAIN_DISABLE_TIMESTAMP_HASH_WEAK_FLAG |       \\\r\n    CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_HASH_WEAK_FLAG )")]
        public const int CERT_CHAIN_DISABLE_TIMESTAMP_HASH_WEAK_FLAGS = (0x00004000 | 0x00008000);

        [NativeTypeName("#define CERT_CHAIN_ENABLE_HYGIENE_FLAGS (               \\\r\n    CERT_CHAIN_ENABLE_ALL_EKU_HYGIENE_FLAG |            \\\r\n    CERT_CHAIN_ENABLE_SERVER_AUTH_HYGIENE_FLAG |        \\\r\n    CERT_CHAIN_ENABLE_CODE_SIGNING_HYGIENE_FLAG |       \\\r\n    CERT_CHAIN_ENABLE_MOTW_CODE_SIGNING_HYGIENE_FLAG |  \\\r\n    CERT_CHAIN_ENABLE_TIMESTAMP_HYGIENE_FLAG |          \\\r\n    CERT_CHAIN_ENABLE_MOTW_TIMESTAMP_HYGIENE_FLAG )")]
        public const int CERT_CHAIN_ENABLE_HYGIENE_FLAGS = (0x00020000 | 0x00200000 | 0x01000000 | 0x02000000 | 0x10000000 | 0x20000000);

        [NativeTypeName("#define CERT_CHAIN_MOTW_WEAK_FLAGS (                    \\\r\n    CERT_CHAIN_DISABLE_MOTW_CODE_SIGNING_WEAK_FLAG |    \\\r\n    CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_WEAK_FLAG |       \\\r\n    CERT_CHAIN_ENABLE_MOTW_CODE_SIGNING_HYGIENE_FLAG |  \\\r\n    CERT_CHAIN_ENABLE_MOTW_TIMESTAMP_HYGIENE_FLAG |     \\\r\n    CERT_CHAIN_MOTW_IGNORE_AFTER_TIME_WEAK_FLAG)")]
        public const int CERT_CHAIN_MOTW_WEAK_FLAGS = (0x00800000 | 0x08000000 | 0x02000000 | 0x20000000 | 0x40000000);

        [NativeTypeName("#define CERT_CHAIN_OPT_IN_WEAK_FLAGS (                  \\\r\n    CERT_CHAIN_DISABLE_OPT_IN_SERVER_AUTH_WEAK_FLAG)")]
        public const int CERT_CHAIN_OPT_IN_WEAK_FLAGS = (0x00040000);

        [NativeTypeName("#define CERT_CHAIN_AUTO_CURRENT_USER 1")]
        public const int CERT_CHAIN_AUTO_CURRENT_USER = 1;

        [NativeTypeName("#define CERT_CHAIN_AUTO_LOCAL_MACHINE 2")]
        public const int CERT_CHAIN_AUTO_LOCAL_MACHINE = 2;

        [NativeTypeName("#define CERT_CHAIN_AUTO_IMPERSONATED 3")]
        public const int CERT_CHAIN_AUTO_IMPERSONATED = 3;

        [NativeTypeName("#define CERT_CHAIN_AUTO_PROCESS_INFO 4")]
        public const int CERT_CHAIN_AUTO_PROCESS_INFO = 4;

        [NativeTypeName("#define CERT_CHAIN_AUTO_PINRULE_INFO 5")]
        public const int CERT_CHAIN_AUTO_PINRULE_INFO = 5;

        [NativeTypeName("#define CERT_CHAIN_AUTO_NETWORK_INFO 6")]
        public const int CERT_CHAIN_AUTO_NETWORK_INFO = 6;

        [NativeTypeName("#define CERT_CHAIN_AUTO_SERIAL_LOCAL_MACHINE 7")]
        public const int CERT_CHAIN_AUTO_SERIAL_LOCAL_MACHINE = 7;

        [NativeTypeName("#define CERT_CHAIN_AUTO_HPKP_RULE_INFO 8")]
        public const int CERT_CHAIN_AUTO_HPKP_RULE_INFO = 8;

        [NativeTypeName("#define CERT_CHAIN_AUTO_FLAGS_VALUE_NAME L\"AutoFlags\"")]
        public const string CERT_CHAIN_AUTO_FLAGS_VALUE_NAME = "AutoFlags";

        [NativeTypeName("#define CERT_CHAIN_AUTO_FLUSH_DISABLE_FLAG 0x00000001")]
        public const int CERT_CHAIN_AUTO_FLUSH_DISABLE_FLAG = 0x00000001;

        [NativeTypeName("#define CERT_CHAIN_AUTO_LOG_CREATE_FLAG 0x00000002")]
        public const int CERT_CHAIN_AUTO_LOG_CREATE_FLAG = 0x00000002;

        [NativeTypeName("#define CERT_CHAIN_AUTO_LOG_FREE_FLAG 0x00000004")]
        public const int CERT_CHAIN_AUTO_LOG_FREE_FLAG = 0x00000004;

        [NativeTypeName("#define CERT_CHAIN_AUTO_LOG_FLUSH_FLAG 0x00000008")]
        public const int CERT_CHAIN_AUTO_LOG_FLUSH_FLAG = 0x00000008;

        [NativeTypeName("#define CERT_CHAIN_AUTO_LOG_FLAGS (         \\\r\n    CERT_CHAIN_AUTO_LOG_CREATE_FLAG |       \\\r\n    CERT_CHAIN_AUTO_LOG_FREE_FLAG |         \\\r\n    CERT_CHAIN_AUTO_LOG_FLUSH_FLAG )")]
        public const int CERT_CHAIN_AUTO_LOG_FLAGS = (0x00000002 | 0x00000004 | 0x00000008);

        [NativeTypeName("#define CERT_CHAIN_AUTO_FLUSH_FIRST_DELTA_SECONDS_VALUE_NAME L\"AutoFlushFirstDeltaSeconds\"")]
        public const string CERT_CHAIN_AUTO_FLUSH_FIRST_DELTA_SECONDS_VALUE_NAME = "AutoFlushFirstDeltaSeconds";

        [NativeTypeName("#define CERT_CHAIN_AUTO_FLUSH_FIRST_DELTA_SECONDS_DEFAULT (5 * 60)")]
        public const int CERT_CHAIN_AUTO_FLUSH_FIRST_DELTA_SECONDS_DEFAULT = (5 * 60);

        [NativeTypeName("#define CERT_CHAIN_AUTO_FLUSH_NEXT_DELTA_SECONDS_VALUE_NAME L\"AutoFlushNextDeltaSeconds\"")]
        public const string CERT_CHAIN_AUTO_FLUSH_NEXT_DELTA_SECONDS_VALUE_NAME = "AutoFlushNextDeltaSeconds";

        [NativeTypeName("#define CERT_CHAIN_AUTO_FLUSH_NEXT_DELTA_SECONDS_DEFAULT (30 * 60)")]
        public const int CERT_CHAIN_AUTO_FLUSH_NEXT_DELTA_SECONDS_DEFAULT = (30 * 60);

        [NativeTypeName("#define CERT_CHAIN_AUTO_LOG_FILE_NAME_VALUE_NAME L\"AutoLogFileName\"")]
        public const string CERT_CHAIN_AUTO_LOG_FILE_NAME_VALUE_NAME = "AutoLogFileName";

        [NativeTypeName("#define CERT_CHAIN_DISABLE_AUTO_FLUSH_PROCESS_NAME_LIST_VALUE_NAME L\"DisableAutoFlushProcessNameList\"")]
        public const string CERT_CHAIN_DISABLE_AUTO_FLUSH_PROCESS_NAME_LIST_VALUE_NAME = "DisableAutoFlushProcessNameList";

        [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_VALIDITY_SECONDS_VALUE_NAME L\"SrvOcspRespMinValiditySeconds\"")]
        public const string CERT_SRV_OCSP_RESP_MIN_VALIDITY_SECONDS_VALUE_NAME = "SrvOcspRespMinValiditySeconds";

        [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_VALIDITY_SECONDS_DEFAULT (10 * 60)")]
        public const int CERT_SRV_OCSP_RESP_MIN_VALIDITY_SECONDS_DEFAULT = (10 * 60);

        [NativeTypeName("#define CERT_SRV_OCSP_RESP_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_VALUE_NAME L\"SrvOcspRespUrlRetrievalTimeoutMilliseconds\"")]
        public const string CERT_SRV_OCSP_RESP_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_VALUE_NAME = "SrvOcspRespUrlRetrievalTimeoutMilliseconds";

        [NativeTypeName("#define CERT_SRV_OCSP_RESP_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_DEFAULT (15 * 1000)")]
        public const int CERT_SRV_OCSP_RESP_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_DEFAULT = (15 * 1000);

        [NativeTypeName("#define CERT_SRV_OCSP_RESP_MAX_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME L\"SrvOcspRespMaxBeforeNextUpdateSeconds\"")]
        public const string CERT_SRV_OCSP_RESP_MAX_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME = "SrvOcspRespMaxBeforeNextUpdateSeconds";

        [NativeTypeName("#define CERT_SRV_OCSP_RESP_MAX_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT (4 * 60 * 60)")]
        public const int CERT_SRV_OCSP_RESP_MAX_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT = (4 * 60 * 60);

        [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME L\"SrvOcspRespMinBeforeNextUpdateSeconds\"")]
        public const string CERT_SRV_OCSP_RESP_MIN_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME = "SrvOcspRespMinBeforeNextUpdateSeconds";

        [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT (2 * 60)")]
        public const int CERT_SRV_OCSP_RESP_MIN_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT = (2 * 60);

        [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_AFTER_NEXT_UPDATE_SECONDS_VALUE_NAME L\"SrvOcspRespMinAfterNextUpdateSeconds\"")]
        public const string CERT_SRV_OCSP_RESP_MIN_AFTER_NEXT_UPDATE_SECONDS_VALUE_NAME = "SrvOcspRespMinAfterNextUpdateSeconds";

        [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_AFTER_NEXT_UPDATE_SECONDS_DEFAULT (1 * 60)")]
        public const int CERT_SRV_OCSP_RESP_MIN_AFTER_NEXT_UPDATE_SECONDS_DEFAULT = (1 * 60);

        [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_SYNC_CERT_FILE_SECONDS_VALUE_NAME L\"SrvOcspRespMinSyncCertFileSeconds\"")]
        public const string CERT_SRV_OCSP_RESP_MIN_SYNC_CERT_FILE_SECONDS_VALUE_NAME = "SrvOcspRespMinSyncCertFileSeconds";

        [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_SYNC_CERT_FILE_SECONDS_DEFAULT 5")]
        public const int CERT_SRV_OCSP_RESP_MIN_SYNC_CERT_FILE_SECONDS_DEFAULT = 5;

        [NativeTypeName("#define CERT_SRV_OCSP_RESP_MAX_SYNC_CERT_FILE_SECONDS_VALUE_NAME L\"SrvOcspRespMaxSyncCertFileSeconds\"")]
        public const string CERT_SRV_OCSP_RESP_MAX_SYNC_CERT_FILE_SECONDS_VALUE_NAME = "SrvOcspRespMaxSyncCertFileSeconds";

        [NativeTypeName("#define CERT_SRV_OCSP_RESP_MAX_SYNC_CERT_FILE_SECONDS_DEFAULT (1 * 60 * 60)")]
        public const int CERT_SRV_OCSP_RESP_MAX_SYNC_CERT_FILE_SECONDS_DEFAULT = (1 * 60 * 60);

        [NativeTypeName("#define CRYPTNET_MAX_CACHED_OCSP_PER_CRL_COUNT_VALUE_NAME L\"CryptnetMaxCachedOcspPerCrlCount\"")]
        public const string CRYPTNET_MAX_CACHED_OCSP_PER_CRL_COUNT_VALUE_NAME = "CryptnetMaxCachedOcspPerCrlCount";

        [NativeTypeName("#define CRYPTNET_MAX_CACHED_OCSP_PER_CRL_COUNT_DEFAULT 500")]
        public const int CRYPTNET_MAX_CACHED_OCSP_PER_CRL_COUNT_DEFAULT = 500;

        [NativeTypeName("#define CRYPTNET_OCSP_AFTER_CRL_DISABLE 0xFFFFFFFF")]
        public const uint CRYPTNET_OCSP_AFTER_CRL_DISABLE = 0xFFFFFFFF;

        [NativeTypeName("#define CRYPTNET_URL_CACHE_DEFAULT_FLUSH_EXEMPT_SECONDS_VALUE_NAME L\"CryptnetDefaultFlushExemptSeconds\"")]
        public const string CRYPTNET_URL_CACHE_DEFAULT_FLUSH_EXEMPT_SECONDS_VALUE_NAME = "CryptnetDefaultFlushExemptSeconds";

        [NativeTypeName("#define CRYPTNET_URL_CACHE_DEFAULT_FLUSH_EXEMPT_SECONDS_DEFAULT (28 * 24 * 60 * 60)")]
        public const int CRYPTNET_URL_CACHE_DEFAULT_FLUSH_EXEMPT_SECONDS_DEFAULT = (28 * 24 * 60 * 60);

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_MAX_AGE_SECONDS_VALUE_NAME L\"CryptnetPreFetchMinMaxAgeSeconds\"")]
        public const string CRYPTNET_PRE_FETCH_MIN_MAX_AGE_SECONDS_VALUE_NAME = "CryptnetPreFetchMinMaxAgeSeconds";

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_MAX_AGE_SECONDS_DEFAULT (1 * 60 * 60)")]
        public const int CRYPTNET_PRE_FETCH_MIN_MAX_AGE_SECONDS_DEFAULT = (1 * 60 * 60);

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_MAX_MAX_AGE_SECONDS_VALUE_NAME L\"CryptnetPreFetchMaxMaxAgeSeconds\"")]
        public const string CRYPTNET_PRE_FETCH_MAX_MAX_AGE_SECONDS_VALUE_NAME = "CryptnetPreFetchMaxMaxAgeSeconds";

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_MAX_MAX_AGE_SECONDS_DEFAULT (14 * 24 * 60 * 60)")]
        public const int CRYPTNET_PRE_FETCH_MAX_MAX_AGE_SECONDS_DEFAULT = (14 * 24 * 60 * 60);

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_OCSP_VALIDITY_PERIOD_SECONDS_VALUE_NAME L\"CryptnetPreFetchMinOcspValidityPeriodSeconds\"")]
        public const string CRYPTNET_PRE_FETCH_MIN_OCSP_VALIDITY_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchMinOcspValidityPeriodSeconds";

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_OCSP_VALIDITY_PERIOD_SECONDS_DEFAULT (14 * 24 * 60 * 60)")]
        public const int CRYPTNET_PRE_FETCH_MIN_OCSP_VALIDITY_PERIOD_SECONDS_DEFAULT = (14 * 24 * 60 * 60);

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_AFTER_PUBLISH_PRE_FETCH_DIVISOR_VALUE_NAME L\"CryptnetPreFetchAfterPublishPreFetchDivisor\"")]
        public const string CRYPTNET_PRE_FETCH_AFTER_PUBLISH_PRE_FETCH_DIVISOR_VALUE_NAME = "CryptnetPreFetchAfterPublishPreFetchDivisor";

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_AFTER_PUBLISH_PRE_FETCH_DIVISOR_DEFAULT 10")]
        public const int CRYPTNET_PRE_FETCH_AFTER_PUBLISH_PRE_FETCH_DIVISOR_DEFAULT = 10;

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_BEFORE_NEXT_UPDATE_PRE_FETCH_DIVISOR_VALUE_NAME L\"CryptnetPreFetchBeforeNextUpdatePreFetchDivisor\"")]
        public const string CRYPTNET_PRE_FETCH_BEFORE_NEXT_UPDATE_PRE_FETCH_DIVISOR_VALUE_NAME = "CryptnetPreFetchBeforeNextUpdatePreFetchDivisor";

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_BEFORE_NEXT_UPDATE_PRE_FETCH_DIVISOR_DEFAULT 20")]
        public const int CRYPTNET_PRE_FETCH_BEFORE_NEXT_UPDATE_PRE_FETCH_DIVISOR_DEFAULT = 20;

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME L\"CryptnetPreFetchMinBeforeNextUpdatePreFetchSeconds\"")]
        public const string CRYPTNET_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchMinBeforeNextUpdatePreFetchSeconds";

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT (1 * 60 * 60)")]
        public const int CRYPTNET_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT = (1 * 60 * 60);

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_VALIDITY_PERIOD_AFTER_NEXT_UPDATE_PRE_FETCH_DIVISOR_VALUE_NAME L\"CryptnetPreFetchValidityPeriodAfterNextUpdatePreFetchDivisor\"")]
        public const string CRYPTNET_PRE_FETCH_VALIDITY_PERIOD_AFTER_NEXT_UPDATE_PRE_FETCH_DIVISOR_VALUE_NAME = "CryptnetPreFetchValidityPeriodAfterNextUpdatePreFetchDivisor";

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_VALIDITY_PERIOD_AFTER_NEXT_UPDATE_PRE_FETCH_DIVISOR_DEFAULT 10")]
        public const int CRYPTNET_PRE_FETCH_VALIDITY_PERIOD_AFTER_NEXT_UPDATE_PRE_FETCH_DIVISOR_DEFAULT = 10;

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_MAX_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME L\"CryptnetPreFetchMaxAfterNextUpdatePreFetchPeriodSeconds\"")]
        public const string CRYPTNET_PRE_FETCH_MAX_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchMaxAfterNextUpdatePreFetchPeriodSeconds";

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_MAX_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT (4 * 60 * 60)")]
        public const int CRYPTNET_PRE_FETCH_MAX_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT = (4 * 60 * 60);

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME L\"CryptnetPreFetchMinAfterNextUpdatePreFetchPeriodSeconds\"")]
        public const string CRYPTNET_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchMinAfterNextUpdatePreFetchPeriodSeconds";

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT (30 * 60)")]
        public const int CRYPTNET_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT = (30 * 60);

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_AFTER_CURRENT_TIME_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME L\"CryptnetPreFetchAfterCurrentTimePreFetchPeriodSeconds\"")]
        public const string CRYPTNET_PRE_FETCH_AFTER_CURRENT_TIME_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchAfterCurrentTimePreFetchPeriodSeconds";

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_AFTER_CURRENT_TIME_PRE_FETCH_PERIOD_SECONDS_DEFAULT (30 * 60)")]
        public const int CRYPTNET_PRE_FETCH_AFTER_CURRENT_TIME_PRE_FETCH_PERIOD_SECONDS_DEFAULT = (30 * 60);

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_TRIGGER_PERIOD_SECONDS_VALUE_NAME L\"CryptnetPreFetchTriggerPeriodSeconds\"")]
        public const string CRYPTNET_PRE_FETCH_TRIGGER_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchTriggerPeriodSeconds";

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_TRIGGER_PERIOD_SECONDS_DEFAULT (10 * 60)")]
        public const int CRYPTNET_PRE_FETCH_TRIGGER_PERIOD_SECONDS_DEFAULT = (10 * 60);

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_TRIGGER_DISABLE 0xFFFFFFFF")]
        public const uint CRYPTNET_PRE_FETCH_TRIGGER_DISABLE = 0xFFFFFFFF;

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_SCAN_AFTER_TRIGGER_DELAY_SECONDS_VALUE_NAME L\"CryptnetPreFetchScanAfterTriggerDelaySeconds\"")]
        public const string CRYPTNET_PRE_FETCH_SCAN_AFTER_TRIGGER_DELAY_SECONDS_VALUE_NAME = "CryptnetPreFetchScanAfterTriggerDelaySeconds";

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_SCAN_AFTER_TRIGGER_DELAY_SECONDS_DEFAULT 60")]
        public const int CRYPTNET_PRE_FETCH_SCAN_AFTER_TRIGGER_DELAY_SECONDS_DEFAULT = 60;

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_RETRIEVAL_TIMEOUT_SECONDS_VALUE_NAME L\"CryptnetPreFetchRetrievalTimeoutSeconds\"")]
        public const string CRYPTNET_PRE_FETCH_RETRIEVAL_TIMEOUT_SECONDS_VALUE_NAME = "CryptnetPreFetchRetrievalTimeoutSeconds";

        [NativeTypeName("#define CRYPTNET_PRE_FETCH_RETRIEVAL_TIMEOUT_SECONDS_DEFAULT (5 * 60)")]
        public const int CRYPTNET_PRE_FETCH_RETRIEVAL_TIMEOUT_SECONDS_DEFAULT = (5 * 60);

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_CONFIG_REGPATH CERT_CHAIN_CONFIG_REGPATH L\"\\\\CrlPreFetch\"")]
        public const string CRYPTNET_CRL_PRE_FETCH_CONFIG_REGPATH = "Software\\Microsoft\\Cryptography\\OID\\EncodingType 0\\CertDllCreateCertificateChainEngine\\Config\\CrlPreFetch";

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_PROCESS_NAME_LIST_VALUE_NAME L\"ProcessNameList\"")]
        public const string CRYPTNET_CRL_PRE_FETCH_PROCESS_NAME_LIST_VALUE_NAME = "ProcessNameList";

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_URL_LIST_VALUE_NAME L\"PreFetchUrlList\"")]
        public const string CRYPTNET_CRL_PRE_FETCH_URL_LIST_VALUE_NAME = "PreFetchUrlList";

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_DISABLE_INFORMATION_EVENTS_VALUE_NAME L\"DisableInformationEvents\"")]
        public const string CRYPTNET_CRL_PRE_FETCH_DISABLE_INFORMATION_EVENTS_VALUE_NAME = "DisableInformationEvents";

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_LOG_FILE_NAME_VALUE_NAME L\"LogFileName\"")]
        public const string CRYPTNET_CRL_PRE_FETCH_LOG_FILE_NAME_VALUE_NAME = "LogFileName";

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_TIMEOUT_SECONDS_VALUE_NAME L\"TimeoutSeconds\"")]
        public const string CRYPTNET_CRL_PRE_FETCH_TIMEOUT_SECONDS_VALUE_NAME = "TimeoutSeconds";

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_TIMEOUT_SECONDS_DEFAULT (5 * 60)")]
        public const int CRYPTNET_CRL_PRE_FETCH_TIMEOUT_SECONDS_DEFAULT = (5 * 60);

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_VALUE_NAME L\"MaxAgeSeconds\"")]
        public const string CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_VALUE_NAME = "MaxAgeSeconds";

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_DEFAULT (2 * 60 * 60)")]
        public const int CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_DEFAULT = (2 * 60 * 60);

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_MIN (5 * 60)")]
        public const int CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_MIN = (5 * 60);

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_PUBLISH_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME L\"PublishBeforeNextUpdateSeconds\"")]
        public const string CRYPTNET_CRL_PRE_FETCH_PUBLISH_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME = "PublishBeforeNextUpdateSeconds";

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_PUBLISH_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT (1 * 60 * 60)")]
        public const int CRYPTNET_CRL_PRE_FETCH_PUBLISH_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT = (1 * 60 * 60);

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_PUBLISH_RANDOM_INTERVAL_SECONDS_VALUE_NAME L\"PublishRandomIntervalSeconds\"")]
        public const string CRYPTNET_CRL_PRE_FETCH_PUBLISH_RANDOM_INTERVAL_SECONDS_VALUE_NAME = "PublishRandomIntervalSeconds";

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_PUBLISH_RANDOM_INTERVAL_SECONDS_DEFAULT (5 * 60)")]
        public const int CRYPTNET_CRL_PRE_FETCH_PUBLISH_RANDOM_INTERVAL_SECONDS_DEFAULT = (5 * 60);

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME L\"MinBeforeNextUpdateSeconds\"")]
        public const string CRYPTNET_CRL_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME = "MinBeforeNextUpdateSeconds";

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT (5 * 60)")]
        public const int CRYPTNET_CRL_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT = (5 * 60);

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_SECONDS_VALUE_NAME L\"MinAfterNextUpdateSeconds\"")]
        public const string CRYPTNET_CRL_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_SECONDS_VALUE_NAME = "MinAfterNextUpdateSeconds";

        [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_SECONDS_DEFAULT (5 * 60)")]
        public const int CRYPTNET_CRL_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_SECONDS_DEFAULT = (5 * 60);

        [NativeTypeName("#define CERT_GROUP_POLICY_CHAIN_CONFIG_REGPATH CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH L\"\\\\ChainEngine\\\\Config\"")]
        public const string CERT_GROUP_POLICY_CHAIN_CONFIG_REGPATH = "Software\\Policies\\Microsoft\\SystemCertificates\\ChainEngine\\Config";

        [NativeTypeName("#define CERT_CHAIN_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_VALUE_NAME L\"ChainUrlRetrievalTimeoutMilliseconds\"")]
        public const string CERT_CHAIN_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_VALUE_NAME = "ChainUrlRetrievalTimeoutMilliseconds";

        [NativeTypeName("#define CERT_CHAIN_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_DEFAULT (15 * 1000)")]
        public const int CERT_CHAIN_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_DEFAULT = (15 * 1000);

        [NativeTypeName("#define CERT_CHAIN_REV_ACCUMULATIVE_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_VALUE_NAME L\"ChainRevAccumulativeUrlRetrievalTimeoutMilliseconds\"")]
        public const string CERT_CHAIN_REV_ACCUMULATIVE_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_VALUE_NAME = "ChainRevAccumulativeUrlRetrievalTimeoutMilliseconds";

        [NativeTypeName("#define CERT_CHAIN_REV_ACCUMULATIVE_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_DEFAULT (20 * 1000)")]
        public const int CERT_CHAIN_REV_ACCUMULATIVE_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_DEFAULT = (20 * 1000);

        [NativeTypeName("#define CERT_RETR_BEHAVIOR_INET_AUTH_VALUE_NAME L\"EnableInetUnknownAuth\"")]
        public const string CERT_RETR_BEHAVIOR_INET_AUTH_VALUE_NAME = "EnableInetUnknownAuth";

        [NativeTypeName("#define CERT_RETR_BEHAVIOR_INET_STATUS_VALUE_NAME L\"EnableInetLocal\"")]
        public const string CERT_RETR_BEHAVIOR_INET_STATUS_VALUE_NAME = "EnableInetLocal";

        [NativeTypeName("#define CERT_RETR_BEHAVIOR_FILE_VALUE_NAME L\"AllowFileUrlScheme\"")]
        public const string CERT_RETR_BEHAVIOR_FILE_VALUE_NAME = "AllowFileUrlScheme";

        [NativeTypeName("#define CERT_RETR_BEHAVIOR_LDAP_VALUE_NAME L\"DisableLDAPSignAndEncrypt\"")]
        public const string CERT_RETR_BEHAVIOR_LDAP_VALUE_NAME = "DisableLDAPSignAndEncrypt";

        [NativeTypeName("#define CRYPTNET_CACHED_OCSP_SWITCH_TO_CRL_COUNT_VALUE_NAME L\"CryptnetCachedOcspSwitchToCrlCount\"")]
        public const string CRYPTNET_CACHED_OCSP_SWITCH_TO_CRL_COUNT_VALUE_NAME = "CryptnetCachedOcspSwitchToCrlCount";

        [NativeTypeName("#define CRYPTNET_CACHED_OCSP_SWITCH_TO_CRL_COUNT_DEFAULT 50")]
        public const int CRYPTNET_CACHED_OCSP_SWITCH_TO_CRL_COUNT_DEFAULT = 50;

        [NativeTypeName("#define CRYPTNET_CRL_BEFORE_OCSP_ENABLE 0xFFFFFFFF")]
        public const uint CRYPTNET_CRL_BEFORE_OCSP_ENABLE = 0xFFFFFFFF;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_AIA_URL_RETRIEVAL_VALUE_NAME L\"DisableAIAUrlRetrieval\"")]
        public const string CERT_CHAIN_DISABLE_AIA_URL_RETRIEVAL_VALUE_NAME = "DisableAIAUrlRetrieval";

        [NativeTypeName("#define CERT_CHAIN_OPTIONS_VALUE_NAME L\"Options\"")]
        public const string CERT_CHAIN_OPTIONS_VALUE_NAME = "Options";

        [NativeTypeName("#define CERT_CHAIN_OPTION_DISABLE_AIA_URL_RETRIEVAL 0x2")]
        public const int CERT_CHAIN_OPTION_DISABLE_AIA_URL_RETRIEVAL = 0x2;

        [NativeTypeName("#define CERT_CHAIN_OPTION_ENABLE_SIA_URL_RETRIEVAL 0x4")]
        public const int CERT_CHAIN_OPTION_ENABLE_SIA_URL_RETRIEVAL = 0x4;

        [NativeTypeName("#define CERT_CHAIN_CROSS_CERT_DOWNLOAD_INTERVAL_HOURS_VALUE_NAME L\"CrossCertDownloadIntervalHours\"")]
        public const string CERT_CHAIN_CROSS_CERT_DOWNLOAD_INTERVAL_HOURS_VALUE_NAME = "CrossCertDownloadIntervalHours";

        [NativeTypeName("#define CERT_CHAIN_CROSS_CERT_DOWNLOAD_INTERVAL_HOURS_DEFAULT (24 * 7)")]
        public const int CERT_CHAIN_CROSS_CERT_DOWNLOAD_INTERVAL_HOURS_DEFAULT = (24 * 7);

        [NativeTypeName("#define CERT_CHAIN_CRL_VALIDITY_EXT_PERIOD_HOURS_VALUE_NAME L\"CRLValidityExtensionPeriod\"")]
        public const string CERT_CHAIN_CRL_VALIDITY_EXT_PERIOD_HOURS_VALUE_NAME = "CRLValidityExtensionPeriod";

        [NativeTypeName("#define CERT_CHAIN_CRL_VALIDITY_EXT_PERIOD_HOURS_DEFAULT 12")]
        public const int CERT_CHAIN_CRL_VALIDITY_EXT_PERIOD_HOURS_DEFAULT = 12;

        [NativeTypeName("#define HCCE_CURRENT_USER ((HCERTCHAINENGINE)NULL)")]
        public static IntPtr HCCE_CURRENT_USER => ((nint)(0));

        [NativeTypeName("#define HCCE_LOCAL_MACHINE ((HCERTCHAINENGINE)0x1)")]
        public static IntPtr HCCE_LOCAL_MACHINE => ((nint)(0x1));

        [NativeTypeName("#define HCCE_SERIAL_LOCAL_MACHINE ((HCERTCHAINENGINE)0x2)")]
        public static IntPtr HCCE_SERIAL_LOCAL_MACHINE => ((nint)(0x2));

        [NativeTypeName("#define CERT_CHAIN_CACHE_END_CERT 0x00000001")]
        public const int CERT_CHAIN_CACHE_END_CERT = 0x00000001;

        [NativeTypeName("#define CERT_CHAIN_THREAD_STORE_SYNC 0x00000002")]
        public const int CERT_CHAIN_THREAD_STORE_SYNC = 0x00000002;

        [NativeTypeName("#define CERT_CHAIN_CACHE_ONLY_URL_RETRIEVAL 0x00000004")]
        public const int CERT_CHAIN_CACHE_ONLY_URL_RETRIEVAL = 0x00000004;

        [NativeTypeName("#define CERT_CHAIN_USE_LOCAL_MACHINE_STORE 0x00000008")]
        public const int CERT_CHAIN_USE_LOCAL_MACHINE_STORE = 0x00000008;

        [NativeTypeName("#define CERT_CHAIN_ENABLE_CACHE_AUTO_UPDATE 0x00000010")]
        public const int CERT_CHAIN_ENABLE_CACHE_AUTO_UPDATE = 0x00000010;

        [NativeTypeName("#define CERT_CHAIN_ENABLE_SHARE_STORE 0x00000020")]
        public const int CERT_CHAIN_ENABLE_SHARE_STORE = 0x00000020;

        [NativeTypeName("#define CERT_CHAIN_EXCLUSIVE_ENABLE_CA_FLAG 0x00000001")]
        public const int CERT_CHAIN_EXCLUSIVE_ENABLE_CA_FLAG = 0x00000001;

        [NativeTypeName("#define CERT_TRUST_NO_ERROR 0x00000000")]
        public const int CERT_TRUST_NO_ERROR = 0x00000000;

        [NativeTypeName("#define CERT_TRUST_IS_NOT_TIME_VALID 0x00000001")]
        public const int CERT_TRUST_IS_NOT_TIME_VALID = 0x00000001;

        [NativeTypeName("#define CERT_TRUST_IS_NOT_TIME_NESTED 0x00000002")]
        public const int CERT_TRUST_IS_NOT_TIME_NESTED = 0x00000002;

        [NativeTypeName("#define CERT_TRUST_IS_REVOKED 0x00000004")]
        public const int CERT_TRUST_IS_REVOKED = 0x00000004;

        [NativeTypeName("#define CERT_TRUST_IS_NOT_SIGNATURE_VALID 0x00000008")]
        public const int CERT_TRUST_IS_NOT_SIGNATURE_VALID = 0x00000008;

        [NativeTypeName("#define CERT_TRUST_IS_NOT_VALID_FOR_USAGE 0x00000010")]
        public const int CERT_TRUST_IS_NOT_VALID_FOR_USAGE = 0x00000010;

        [NativeTypeName("#define CERT_TRUST_IS_UNTRUSTED_ROOT 0x00000020")]
        public const int CERT_TRUST_IS_UNTRUSTED_ROOT = 0x00000020;

        [NativeTypeName("#define CERT_TRUST_REVOCATION_STATUS_UNKNOWN 0x00000040")]
        public const int CERT_TRUST_REVOCATION_STATUS_UNKNOWN = 0x00000040;

        [NativeTypeName("#define CERT_TRUST_IS_CYCLIC 0x00000080")]
        public const int CERT_TRUST_IS_CYCLIC = 0x00000080;

        [NativeTypeName("#define CERT_TRUST_INVALID_EXTENSION 0x00000100")]
        public const int CERT_TRUST_INVALID_EXTENSION = 0x00000100;

        [NativeTypeName("#define CERT_TRUST_INVALID_POLICY_CONSTRAINTS 0x00000200")]
        public const int CERT_TRUST_INVALID_POLICY_CONSTRAINTS = 0x00000200;

        [NativeTypeName("#define CERT_TRUST_INVALID_BASIC_CONSTRAINTS 0x00000400")]
        public const int CERT_TRUST_INVALID_BASIC_CONSTRAINTS = 0x00000400;

        [NativeTypeName("#define CERT_TRUST_INVALID_NAME_CONSTRAINTS 0x00000800")]
        public const int CERT_TRUST_INVALID_NAME_CONSTRAINTS = 0x00000800;

        [NativeTypeName("#define CERT_TRUST_HAS_NOT_SUPPORTED_NAME_CONSTRAINT 0x00001000")]
        public const int CERT_TRUST_HAS_NOT_SUPPORTED_NAME_CONSTRAINT = 0x00001000;

        [NativeTypeName("#define CERT_TRUST_HAS_NOT_DEFINED_NAME_CONSTRAINT 0x00002000")]
        public const int CERT_TRUST_HAS_NOT_DEFINED_NAME_CONSTRAINT = 0x00002000;

        [NativeTypeName("#define CERT_TRUST_HAS_NOT_PERMITTED_NAME_CONSTRAINT 0x00004000")]
        public const int CERT_TRUST_HAS_NOT_PERMITTED_NAME_CONSTRAINT = 0x00004000;

        [NativeTypeName("#define CERT_TRUST_HAS_EXCLUDED_NAME_CONSTRAINT 0x00008000")]
        public const int CERT_TRUST_HAS_EXCLUDED_NAME_CONSTRAINT = 0x00008000;

        [NativeTypeName("#define CERT_TRUST_IS_OFFLINE_REVOCATION 0x01000000")]
        public const int CERT_TRUST_IS_OFFLINE_REVOCATION = 0x01000000;

        [NativeTypeName("#define CERT_TRUST_NO_ISSUANCE_CHAIN_POLICY 0x02000000")]
        public const int CERT_TRUST_NO_ISSUANCE_CHAIN_POLICY = 0x02000000;

        [NativeTypeName("#define CERT_TRUST_IS_EXPLICIT_DISTRUST 0x04000000")]
        public const int CERT_TRUST_IS_EXPLICIT_DISTRUST = 0x04000000;

        [NativeTypeName("#define CERT_TRUST_HAS_NOT_SUPPORTED_CRITICAL_EXT 0x08000000")]
        public const int CERT_TRUST_HAS_NOT_SUPPORTED_CRITICAL_EXT = 0x08000000;

        [NativeTypeName("#define CERT_TRUST_HAS_WEAK_SIGNATURE 0x00100000")]
        public const int CERT_TRUST_HAS_WEAK_SIGNATURE = 0x00100000;

        [NativeTypeName("#define CERT_TRUST_HAS_WEAK_HYGIENE 0x00200000")]
        public const int CERT_TRUST_HAS_WEAK_HYGIENE = 0x00200000;

        [NativeTypeName("#define CERT_TRUST_IS_PARTIAL_CHAIN 0x00010000")]
        public const int CERT_TRUST_IS_PARTIAL_CHAIN = 0x00010000;

        [NativeTypeName("#define CERT_TRUST_CTL_IS_NOT_TIME_VALID 0x00020000")]
        public const int CERT_TRUST_CTL_IS_NOT_TIME_VALID = 0x00020000;

        [NativeTypeName("#define CERT_TRUST_CTL_IS_NOT_SIGNATURE_VALID 0x00040000")]
        public const int CERT_TRUST_CTL_IS_NOT_SIGNATURE_VALID = 0x00040000;

        [NativeTypeName("#define CERT_TRUST_CTL_IS_NOT_VALID_FOR_USAGE 0x00080000")]
        public const int CERT_TRUST_CTL_IS_NOT_VALID_FOR_USAGE = 0x00080000;

        [NativeTypeName("#define CERT_TRUST_HAS_EXACT_MATCH_ISSUER 0x00000001")]
        public const int CERT_TRUST_HAS_EXACT_MATCH_ISSUER = 0x00000001;

        [NativeTypeName("#define CERT_TRUST_HAS_KEY_MATCH_ISSUER 0x00000002")]
        public const int CERT_TRUST_HAS_KEY_MATCH_ISSUER = 0x00000002;

        [NativeTypeName("#define CERT_TRUST_HAS_NAME_MATCH_ISSUER 0x00000004")]
        public const int CERT_TRUST_HAS_NAME_MATCH_ISSUER = 0x00000004;

        [NativeTypeName("#define CERT_TRUST_IS_SELF_SIGNED 0x00000008")]
        public const int CERT_TRUST_IS_SELF_SIGNED = 0x00000008;

        [NativeTypeName("#define CERT_TRUST_AUTO_UPDATE_CA_REVOCATION 0x00000010")]
        public const int CERT_TRUST_AUTO_UPDATE_CA_REVOCATION = 0x00000010;

        [NativeTypeName("#define CERT_TRUST_AUTO_UPDATE_END_REVOCATION 0x00000020")]
        public const int CERT_TRUST_AUTO_UPDATE_END_REVOCATION = 0x00000020;

        [NativeTypeName("#define CERT_TRUST_NO_OCSP_FAILOVER_TO_CRL 0x00000040")]
        public const int CERT_TRUST_NO_OCSP_FAILOVER_TO_CRL = 0x00000040;

        [NativeTypeName("#define CERT_TRUST_IS_KEY_ROLLOVER 0x00000080")]
        public const int CERT_TRUST_IS_KEY_ROLLOVER = 0x00000080;

        [NativeTypeName("#define CERT_TRUST_SSL_HANDSHAKE_OCSP 0x00040000")]
        public const int CERT_TRUST_SSL_HANDSHAKE_OCSP = 0x00040000;

        [NativeTypeName("#define CERT_TRUST_SSL_TIME_VALID_OCSP 0x00080000")]
        public const int CERT_TRUST_SSL_TIME_VALID_OCSP = 0x00080000;

        [NativeTypeName("#define CERT_TRUST_SSL_RECONNECT_OCSP 0x00100000")]
        public const int CERT_TRUST_SSL_RECONNECT_OCSP = 0x00100000;

        [NativeTypeName("#define CERT_TRUST_HAS_PREFERRED_ISSUER 0x00000100")]
        public const int CERT_TRUST_HAS_PREFERRED_ISSUER = 0x00000100;

        [NativeTypeName("#define CERT_TRUST_HAS_ISSUANCE_CHAIN_POLICY 0x00000200")]
        public const int CERT_TRUST_HAS_ISSUANCE_CHAIN_POLICY = 0x00000200;

        [NativeTypeName("#define CERT_TRUST_HAS_VALID_NAME_CONSTRAINTS 0x00000400")]
        public const int CERT_TRUST_HAS_VALID_NAME_CONSTRAINTS = 0x00000400;

        [NativeTypeName("#define CERT_TRUST_IS_PEER_TRUSTED 0x00000800")]
        public const int CERT_TRUST_IS_PEER_TRUSTED = 0x00000800;

        [NativeTypeName("#define CERT_TRUST_HAS_CRL_VALIDITY_EXTENDED 0x00001000")]
        public const int CERT_TRUST_HAS_CRL_VALIDITY_EXTENDED = 0x00001000;

        [NativeTypeName("#define CERT_TRUST_IS_FROM_EXCLUSIVE_TRUST_STORE 0x00002000")]
        public const int CERT_TRUST_IS_FROM_EXCLUSIVE_TRUST_STORE = 0x00002000;

        [NativeTypeName("#define CERT_TRUST_IS_CA_TRUSTED 0x00004000")]
        public const int CERT_TRUST_IS_CA_TRUSTED = 0x00004000;

        [NativeTypeName("#define CERT_TRUST_HAS_AUTO_UPDATE_WEAK_SIGNATURE 0x00008000")]
        public const int CERT_TRUST_HAS_AUTO_UPDATE_WEAK_SIGNATURE = 0x00008000;

        [NativeTypeName("#define CERT_TRUST_HAS_ALLOW_WEAK_SIGNATURE 0x00020000")]
        public const int CERT_TRUST_HAS_ALLOW_WEAK_SIGNATURE = 0x00020000;

        [NativeTypeName("#define CERT_TRUST_IS_COMPLEX_CHAIN 0x00010000")]
        public const int CERT_TRUST_IS_COMPLEX_CHAIN = 0x00010000;

        [NativeTypeName("#define CERT_TRUST_SSL_TIME_VALID 0x01000000")]
        public const int CERT_TRUST_SSL_TIME_VALID = 0x01000000;

        [NativeTypeName("#define CERT_TRUST_NO_TIME_CHECK 0x02000000")]
        public const int CERT_TRUST_NO_TIME_CHECK = 0x02000000;

        [NativeTypeName("#define USAGE_MATCH_TYPE_AND 0x00000000")]
        public const int USAGE_MATCH_TYPE_AND = 0x00000000;

        [NativeTypeName("#define USAGE_MATCH_TYPE_OR 0x00000001")]
        public const int USAGE_MATCH_TYPE_OR = 0x00000001;

        [NativeTypeName("#define CERT_CHAIN_STRONG_SIGN_DISABLE_END_CHECK_FLAG 0x00000001")]
        public const int CERT_CHAIN_STRONG_SIGN_DISABLE_END_CHECK_FLAG = 0x00000001;

        [NativeTypeName("#define CERT_CHAIN_REVOCATION_CHECK_END_CERT 0x10000000")]
        public const int CERT_CHAIN_REVOCATION_CHECK_END_CERT = 0x10000000;

        [NativeTypeName("#define CERT_CHAIN_REVOCATION_CHECK_CHAIN 0x20000000")]
        public const int CERT_CHAIN_REVOCATION_CHECK_CHAIN = 0x20000000;

        [NativeTypeName("#define CERT_CHAIN_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT 0x40000000")]
        public const int CERT_CHAIN_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x40000000;

        [NativeTypeName("#define CERT_CHAIN_REVOCATION_CHECK_CACHE_ONLY 0x80000000")]
        public const uint CERT_CHAIN_REVOCATION_CHECK_CACHE_ONLY = 0x80000000;

        [NativeTypeName("#define CERT_CHAIN_REVOCATION_ACCUMULATIVE_TIMEOUT 0x08000000")]
        public const int CERT_CHAIN_REVOCATION_ACCUMULATIVE_TIMEOUT = 0x08000000;

        [NativeTypeName("#define CERT_CHAIN_REVOCATION_CHECK_OCSP_CERT 0x04000000")]
        public const int CERT_CHAIN_REVOCATION_CHECK_OCSP_CERT = 0x04000000;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_PASS1_QUALITY_FILTERING 0x00000040")]
        public const int CERT_CHAIN_DISABLE_PASS1_QUALITY_FILTERING = 0x00000040;

        [NativeTypeName("#define CERT_CHAIN_RETURN_LOWER_QUALITY_CONTEXTS 0x00000080")]
        public const int CERT_CHAIN_RETURN_LOWER_QUALITY_CONTEXTS = 0x00000080;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_AUTH_ROOT_AUTO_UPDATE 0x00000100")]
        public const int CERT_CHAIN_DISABLE_AUTH_ROOT_AUTO_UPDATE = 0x00000100;

        [NativeTypeName("#define CERT_CHAIN_TIMESTAMP_TIME 0x00000200")]
        public const int CERT_CHAIN_TIMESTAMP_TIME = 0x00000200;

        [NativeTypeName("#define CERT_CHAIN_ENABLE_PEER_TRUST 0x00000400")]
        public const int CERT_CHAIN_ENABLE_PEER_TRUST = 0x00000400;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_MY_PEER_TRUST 0x00000800")]
        public const int CERT_CHAIN_DISABLE_MY_PEER_TRUST = 0x00000800;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_MD2_MD4 0x00001000")]
        public const int CERT_CHAIN_DISABLE_MD2_MD4 = 0x00001000;

        [NativeTypeName("#define CERT_CHAIN_DISABLE_AIA 0x00002000")]
        public const int CERT_CHAIN_DISABLE_AIA = 0x00002000;

        [NativeTypeName("#define CERT_CHAIN_HAS_MOTW 0x00004000")]
        public const int CERT_CHAIN_HAS_MOTW = 0x00004000;

        [NativeTypeName("#define CERT_CHAIN_ONLY_ADDITIONAL_AND_AUTH_ROOT 0x00008000")]
        public const int CERT_CHAIN_ONLY_ADDITIONAL_AND_AUTH_ROOT = 0x00008000;

        [NativeTypeName("#define CERT_CHAIN_OPT_IN_WEAK_SIGNATURE 0x00010000")]
        public const int CERT_CHAIN_OPT_IN_WEAK_SIGNATURE = 0x00010000;

        [NativeTypeName("#define REVOCATION_OID_CRL_REVOCATION ((LPCSTR)1)")]
        public static sbyte* REVOCATION_OID_CRL_REVOCATION => ((sbyte*)(1));

        [NativeTypeName("#define CERT_CHAIN_FIND_BY_ISSUER 1")]
        public const int CERT_CHAIN_FIND_BY_ISSUER = 1;

        [NativeTypeName("#define CERT_CHAIN_FIND_BY_ISSUER_COMPARE_KEY_FLAG 0x0001")]
        public const int CERT_CHAIN_FIND_BY_ISSUER_COMPARE_KEY_FLAG = 0x0001;

        [NativeTypeName("#define CERT_CHAIN_FIND_BY_ISSUER_COMPLEX_CHAIN_FLAG 0x0002")]
        public const int CERT_CHAIN_FIND_BY_ISSUER_COMPLEX_CHAIN_FLAG = 0x0002;

        [NativeTypeName("#define CERT_CHAIN_FIND_BY_ISSUER_CACHE_ONLY_URL_FLAG 0x0004")]
        public const int CERT_CHAIN_FIND_BY_ISSUER_CACHE_ONLY_URL_FLAG = 0x0004;

        [NativeTypeName("#define CERT_CHAIN_FIND_BY_ISSUER_LOCAL_MACHINE_FLAG 0x0008")]
        public const int CERT_CHAIN_FIND_BY_ISSUER_LOCAL_MACHINE_FLAG = 0x0008;

        [NativeTypeName("#define CERT_CHAIN_FIND_BY_ISSUER_NO_KEY_FLAG 0x4000")]
        public const int CERT_CHAIN_FIND_BY_ISSUER_NO_KEY_FLAG = 0x4000;

        [NativeTypeName("#define CERT_CHAIN_FIND_BY_ISSUER_CACHE_ONLY_FLAG 0x8000")]
        public const int CERT_CHAIN_FIND_BY_ISSUER_CACHE_ONLY_FLAG = 0x8000;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_NOT_TIME_VALID_FLAG 0x00000001")]
        public const int CERT_CHAIN_POLICY_IGNORE_NOT_TIME_VALID_FLAG = 0x00000001;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_CTL_NOT_TIME_VALID_FLAG 0x00000002")]
        public const int CERT_CHAIN_POLICY_IGNORE_CTL_NOT_TIME_VALID_FLAG = 0x00000002;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_NOT_TIME_NESTED_FLAG 0x00000004")]
        public const int CERT_CHAIN_POLICY_IGNORE_NOT_TIME_NESTED_FLAG = 0x00000004;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_INVALID_BASIC_CONSTRAINTS_FLAG 0x00000008")]
        public const int CERT_CHAIN_POLICY_IGNORE_INVALID_BASIC_CONSTRAINTS_FLAG = 0x00000008;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_ALL_NOT_TIME_VALID_FLAGS ( \\\r\n    CERT_CHAIN_POLICY_IGNORE_NOT_TIME_VALID_FLAG                | \\\r\n    CERT_CHAIN_POLICY_IGNORE_CTL_NOT_TIME_VALID_FLAG            | \\\r\n    CERT_CHAIN_POLICY_IGNORE_NOT_TIME_NESTED_FLAG                 \\\r\n    )")]
        public const int CERT_CHAIN_POLICY_IGNORE_ALL_NOT_TIME_VALID_FLAGS = (0x00000001 | 0x00000002 | 0x00000004);

        [NativeTypeName("#define CERT_CHAIN_POLICY_ALLOW_UNKNOWN_CA_FLAG 0x00000010")]
        public const int CERT_CHAIN_POLICY_ALLOW_UNKNOWN_CA_FLAG = 0x00000010;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_WRONG_USAGE_FLAG 0x00000020")]
        public const int CERT_CHAIN_POLICY_IGNORE_WRONG_USAGE_FLAG = 0x00000020;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_INVALID_NAME_FLAG 0x00000040")]
        public const int CERT_CHAIN_POLICY_IGNORE_INVALID_NAME_FLAG = 0x00000040;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_INVALID_POLICY_FLAG 0x00000080")]
        public const int CERT_CHAIN_POLICY_IGNORE_INVALID_POLICY_FLAG = 0x00000080;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_END_REV_UNKNOWN_FLAG 0x00000100")]
        public const int CERT_CHAIN_POLICY_IGNORE_END_REV_UNKNOWN_FLAG = 0x00000100;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_CTL_SIGNER_REV_UNKNOWN_FLAG 0x00000200")]
        public const int CERT_CHAIN_POLICY_IGNORE_CTL_SIGNER_REV_UNKNOWN_FLAG = 0x00000200;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_CA_REV_UNKNOWN_FLAG 0x00000400")]
        public const int CERT_CHAIN_POLICY_IGNORE_CA_REV_UNKNOWN_FLAG = 0x00000400;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_ROOT_REV_UNKNOWN_FLAG 0x00000800")]
        public const int CERT_CHAIN_POLICY_IGNORE_ROOT_REV_UNKNOWN_FLAG = 0x00000800;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_ALL_REV_UNKNOWN_FLAGS ( \\\r\n    CERT_CHAIN_POLICY_IGNORE_END_REV_UNKNOWN_FLAG         | \\\r\n    CERT_CHAIN_POLICY_IGNORE_CTL_SIGNER_REV_UNKNOWN_FLAG  | \\\r\n    CERT_CHAIN_POLICY_IGNORE_CA_REV_UNKNOWN_FLAG          | \\\r\n    CERT_CHAIN_POLICY_IGNORE_ROOT_REV_UNKNOWN_FLAG          \\\r\n    )")]
        public const int CERT_CHAIN_POLICY_IGNORE_ALL_REV_UNKNOWN_FLAGS = (0x00000100 | 0x00000200 | 0x00000400 | 0x00000800);

        [NativeTypeName("#define CERT_CHAIN_POLICY_ALLOW_TESTROOT_FLAG 0x00008000")]
        public const int CERT_CHAIN_POLICY_ALLOW_TESTROOT_FLAG = 0x00008000;

        [NativeTypeName("#define CERT_CHAIN_POLICY_TRUST_TESTROOT_FLAG 0x00004000")]
        public const int CERT_CHAIN_POLICY_TRUST_TESTROOT_FLAG = 0x00004000;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_NOT_SUPPORTED_CRITICAL_EXT_FLAG 0x00002000")]
        public const int CERT_CHAIN_POLICY_IGNORE_NOT_SUPPORTED_CRITICAL_EXT_FLAG = 0x00002000;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_PEER_TRUST_FLAG 0x00001000")]
        public const int CERT_CHAIN_POLICY_IGNORE_PEER_TRUST_FLAG = 0x00001000;

        [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_WEAK_SIGNATURE_FLAG 0x08000000")]
        public const int CERT_CHAIN_POLICY_IGNORE_WEAK_SIGNATURE_FLAG = 0x08000000;

        [NativeTypeName("#define CRYPT_OID_VERIFY_CERTIFICATE_CHAIN_POLICY_FUNC \"CertDllVerifyCertificateChainPolicy\"")]
        public static ReadOnlySpan<byte> CRYPT_OID_VERIFY_CERTIFICATE_CHAIN_POLICY_FUNC => new byte[] { 0x43, 0x65, 0x72, 0x74, 0x44, 0x6C, 0x6C, 0x56, 0x65, 0x72, 0x69, 0x66, 0x79, 0x43, 0x65, 0x72, 0x74, 0x69, 0x66, 0x69, 0x63, 0x61, 0x74, 0x65, 0x43, 0x68, 0x61, 0x69, 0x6E, 0x50, 0x6F, 0x6C, 0x69, 0x63, 0x79, 0x00 };

        [NativeTypeName("#define CERT_CHAIN_POLICY_BASE ((LPCSTR) 1)")]
        public static sbyte* CERT_CHAIN_POLICY_BASE => ((sbyte*)(1));

        [NativeTypeName("#define CERT_CHAIN_POLICY_AUTHENTICODE ((LPCSTR) 2)")]
        public static sbyte* CERT_CHAIN_POLICY_AUTHENTICODE => ((sbyte*)(2));

        [NativeTypeName("#define CERT_CHAIN_POLICY_AUTHENTICODE_TS ((LPCSTR) 3)")]
        public static sbyte* CERT_CHAIN_POLICY_AUTHENTICODE_TS => ((sbyte*)(3));

        [NativeTypeName("#define CERT_CHAIN_POLICY_SSL ((LPCSTR) 4)")]
        public static sbyte* CERT_CHAIN_POLICY_SSL => ((sbyte*)(4));

        [NativeTypeName("#define CERT_CHAIN_POLICY_BASIC_CONSTRAINTS ((LPCSTR) 5)")]
        public static sbyte* CERT_CHAIN_POLICY_BASIC_CONSTRAINTS => ((sbyte*)(5));

        [NativeTypeName("#define CERT_CHAIN_POLICY_NT_AUTH ((LPCSTR) 6)")]
        public static sbyte* CERT_CHAIN_POLICY_NT_AUTH => ((sbyte*)(6));

        [NativeTypeName("#define CERT_CHAIN_POLICY_MICROSOFT_ROOT ((LPCSTR) 7)")]
        public static sbyte* CERT_CHAIN_POLICY_MICROSOFT_ROOT => ((sbyte*)(7));

        [NativeTypeName("#define CERT_CHAIN_POLICY_EV ((LPCSTR) 8)")]
        public static sbyte* CERT_CHAIN_POLICY_EV => ((sbyte*)(8));

        [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_F12 ((LPCSTR) 9)")]
        public static sbyte* CERT_CHAIN_POLICY_SSL_F12 => ((sbyte*)(9));

        [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_HPKP_HEADER ((LPCSTR) 10)")]
        public static sbyte* CERT_CHAIN_POLICY_SSL_HPKP_HEADER => ((sbyte*)(10));

        [NativeTypeName("#define CERT_CHAIN_POLICY_THIRD_PARTY_ROOT ((LPCSTR) 11)")]
        public static sbyte* CERT_CHAIN_POLICY_THIRD_PARTY_ROOT => ((sbyte*)(11));

        [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_KEY_PIN ((LPCSTR) 12)")]
        public static sbyte* CERT_CHAIN_POLICY_SSL_KEY_PIN => ((sbyte*)(12));

        [NativeTypeName("#define AUTHTYPE_CLIENT 1")]
        public const int AUTHTYPE_CLIENT = 1;

        [NativeTypeName("#define AUTHTYPE_SERVER 2")]
        public const int AUTHTYPE_SERVER = 2;

        [NativeTypeName("#define BASIC_CONSTRAINTS_CERT_CHAIN_POLICY_CA_FLAG 0x80000000")]
        public const uint BASIC_CONSTRAINTS_CERT_CHAIN_POLICY_CA_FLAG = 0x80000000;

        [NativeTypeName("#define BASIC_CONSTRAINTS_CERT_CHAIN_POLICY_END_ENTITY_FLAG 0x40000000")]
        public const int BASIC_CONSTRAINTS_CERT_CHAIN_POLICY_END_ENTITY_FLAG = 0x40000000;

        [NativeTypeName("#define MICROSOFT_ROOT_CERT_CHAIN_POLICY_ENABLE_TEST_ROOT_FLAG 0x00010000")]
        public const int MICROSOFT_ROOT_CERT_CHAIN_POLICY_ENABLE_TEST_ROOT_FLAG = 0x00010000;

        [NativeTypeName("#define MICROSOFT_ROOT_CERT_CHAIN_POLICY_CHECK_APPLICATION_ROOT_FLAG 0x00020000")]
        public const int MICROSOFT_ROOT_CERT_CHAIN_POLICY_CHECK_APPLICATION_ROOT_FLAG = 0x00020000;

        [NativeTypeName("#define MICROSOFT_ROOT_CERT_CHAIN_POLICY_DISABLE_FLIGHT_ROOT_FLAG 0x00040000")]
        public const int MICROSOFT_ROOT_CERT_CHAIN_POLICY_DISABLE_FLIGHT_ROOT_FLAG = 0x00040000;

        [NativeTypeName("#define SSL_F12_ERROR_TEXT_LENGTH 256")]
        public const int SSL_F12_ERROR_TEXT_LENGTH = 256;

        [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_F12_SUCCESS_LEVEL 0")]
        public const int CERT_CHAIN_POLICY_SSL_F12_SUCCESS_LEVEL = 0;

        [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_F12_WARNING_LEVEL 1")]
        public const int CERT_CHAIN_POLICY_SSL_F12_WARNING_LEVEL = 1;

        [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_F12_ERROR_LEVEL 2")]
        public const int CERT_CHAIN_POLICY_SSL_F12_ERROR_LEVEL = 2;

        [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_F12_NONE_CATEGORY 0")]
        public const int CERT_CHAIN_POLICY_SSL_F12_NONE_CATEGORY = 0;

        [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_F12_WEAK_CRYPTO_CATEGORY 1")]
        public const int CERT_CHAIN_POLICY_SSL_F12_WEAK_CRYPTO_CATEGORY = 1;

        [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_F12_ROOT_PROGRAM_CATEGORY 2")]
        public const int CERT_CHAIN_POLICY_SSL_F12_ROOT_PROGRAM_CATEGORY = 2;

        [NativeTypeName("#define SSL_HPKP_PKP_HEADER_INDEX 0")]
        public const int SSL_HPKP_PKP_HEADER_INDEX = 0;

        [NativeTypeName("#define SSL_HPKP_PKP_RO_HEADER_INDEX 1")]
        public const int SSL_HPKP_PKP_RO_HEADER_INDEX = 1;

        [NativeTypeName("#define SSL_HPKP_HEADER_COUNT 2")]
        public const int SSL_HPKP_HEADER_COUNT = 2;

        [NativeTypeName("#define SSL_KEY_PIN_ERROR_TEXT_LENGTH 512")]
        public const int SSL_KEY_PIN_ERROR_TEXT_LENGTH = 512;

        [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_KEY_PIN_MISMATCH_ERROR -2")]
        public const int CERT_CHAIN_POLICY_SSL_KEY_PIN_MISMATCH_ERROR = -2;

        [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_KEY_PIN_MITM_ERROR -1")]
        public const int CERT_CHAIN_POLICY_SSL_KEY_PIN_MITM_ERROR = -1;

        [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_KEY_PIN_SUCCESS 0")]
        public const int CERT_CHAIN_POLICY_SSL_KEY_PIN_SUCCESS = 0;

        [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_KEY_PIN_MITM_WARNING 1")]
        public const int CERT_CHAIN_POLICY_SSL_KEY_PIN_MITM_WARNING = 1;

        [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_KEY_PIN_MISMATCH_WARNING 2")]
        public const int CERT_CHAIN_POLICY_SSL_KEY_PIN_MISMATCH_WARNING = 2;

        [NativeTypeName("#define CryptStringToBinary CryptStringToBinaryW")]
        public static delegate*<ushort*, uint, uint, byte*, uint*, uint*, uint*, int> CryptStringToBinary => &CryptStringToBinaryW;

        [NativeTypeName("#define CryptBinaryToString CryptBinaryToStringW")]
        public static delegate*<byte*, uint, uint, ushort*, uint*, int> CryptBinaryToString => &CryptBinaryToStringW;

        [NativeTypeName("#define CRYPT_STRING_BASE64HEADER 0x00000000")]
        public const int CRYPT_STRING_BASE64HEADER = 0x00000000;

        [NativeTypeName("#define CRYPT_STRING_BASE64 0x00000001")]
        public const int CRYPT_STRING_BASE64 = 0x00000001;

        [NativeTypeName("#define CRYPT_STRING_BINARY 0x00000002")]
        public const int CRYPT_STRING_BINARY = 0x00000002;

        [NativeTypeName("#define CRYPT_STRING_BASE64REQUESTHEADER 0x00000003")]
        public const int CRYPT_STRING_BASE64REQUESTHEADER = 0x00000003;

        [NativeTypeName("#define CRYPT_STRING_HEX 0x00000004")]
        public const int CRYPT_STRING_HEX = 0x00000004;

        [NativeTypeName("#define CRYPT_STRING_HEXASCII 0x00000005")]
        public const int CRYPT_STRING_HEXASCII = 0x00000005;

        [NativeTypeName("#define CRYPT_STRING_BASE64_ANY 0x00000006")]
        public const int CRYPT_STRING_BASE64_ANY = 0x00000006;

        [NativeTypeName("#define CRYPT_STRING_ANY 0x00000007")]
        public const int CRYPT_STRING_ANY = 0x00000007;

        [NativeTypeName("#define CRYPT_STRING_HEX_ANY 0x00000008")]
        public const int CRYPT_STRING_HEX_ANY = 0x00000008;

        [NativeTypeName("#define CRYPT_STRING_BASE64X509CRLHEADER 0x00000009")]
        public const int CRYPT_STRING_BASE64X509CRLHEADER = 0x00000009;

        [NativeTypeName("#define CRYPT_STRING_HEXADDR 0x0000000a")]
        public const int CRYPT_STRING_HEXADDR = 0x0000000a;

        [NativeTypeName("#define CRYPT_STRING_HEXASCIIADDR 0x0000000b")]
        public const int CRYPT_STRING_HEXASCIIADDR = 0x0000000b;

        [NativeTypeName("#define CRYPT_STRING_HEXRAW 0x0000000c")]
        public const int CRYPT_STRING_HEXRAW = 0x0000000c;

        [NativeTypeName("#define CRYPT_STRING_BASE64URI 0x0000000d")]
        public const int CRYPT_STRING_BASE64URI = 0x0000000d;

        [NativeTypeName("#define CRYPT_STRING_ENCODEMASK 0x000000ff")]
        public const int CRYPT_STRING_ENCODEMASK = 0x000000ff;

        [NativeTypeName("#define CRYPT_STRING_RESERVED100 0x00000100")]
        public const int CRYPT_STRING_RESERVED100 = 0x00000100;

        [NativeTypeName("#define CRYPT_STRING_RESERVED200 0x00000200")]
        public const int CRYPT_STRING_RESERVED200 = 0x00000200;

        [NativeTypeName("#define CRYPT_STRING_PERCENTESCAPE 0x08000000")]
        public const int CRYPT_STRING_PERCENTESCAPE = 0x08000000;

        [NativeTypeName("#define CRYPT_STRING_HASHDATA 0x10000000")]
        public const int CRYPT_STRING_HASHDATA = 0x10000000;

        [NativeTypeName("#define CRYPT_STRING_STRICT 0x20000000")]
        public const int CRYPT_STRING_STRICT = 0x20000000;

        [NativeTypeName("#define CRYPT_STRING_NOCRLF 0x40000000")]
        public const int CRYPT_STRING_NOCRLF = 0x40000000;

        [NativeTypeName("#define CRYPT_STRING_NOCR 0x80000000")]
        public const uint CRYPT_STRING_NOCR = 0x80000000;

        [NativeTypeName("#define szOID_PKCS_12_PbeIds \"1.2.840.113549.1.12.1\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_12_PbeIds => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_PKCS_12_pbeWithSHA1And128BitRC4 \"1.2.840.113549.1.12.1.1\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_12_pbeWithSHA1And128BitRC4 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_PKCS_12_pbeWithSHA1And40BitRC4 \"1.2.840.113549.1.12.1.2\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_12_pbeWithSHA1And40BitRC4 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_PKCS_12_pbeWithSHA1And3KeyTripleDES \"1.2.840.113549.1.12.1.3\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_12_pbeWithSHA1And3KeyTripleDES => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x2E, 0x33, 0x00 };

        [NativeTypeName("#define szOID_PKCS_12_pbeWithSHA1And2KeyTripleDES \"1.2.840.113549.1.12.1.4\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_12_pbeWithSHA1And2KeyTripleDES => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x2E, 0x34, 0x00 };

        [NativeTypeName("#define szOID_PKCS_12_pbeWithSHA1And128BitRC2 \"1.2.840.113549.1.12.1.5\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_12_pbeWithSHA1And128BitRC2 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x2E, 0x35, 0x00 };

        [NativeTypeName("#define szOID_PKCS_12_pbeWithSHA1And40BitRC2 \"1.2.840.113549.1.12.1.6\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_12_pbeWithSHA1And40BitRC2 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x31, 0x2E, 0x36, 0x00 };

        [NativeTypeName("#define szOID_PKCS_5_PBKDF2 \"1.2.840.113549.1.5.12\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_5_PBKDF2 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x31, 0x32, 0x00 };

        [NativeTypeName("#define szOID_PKCS_5_PBES2 \"1.2.840.113549.1.5.13\"")]
        public static ReadOnlySpan<byte> szOID_PKCS_5_PBES2 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x31, 0x33, 0x00 };

        [NativeTypeName("#define PKCS12_IMPORT_SILENT 0x00000040")]
        public const int PKCS12_IMPORT_SILENT = 0x00000040;

        [NativeTypeName("#define CRYPT_USER_KEYSET 0x00001000")]
        public const int CRYPT_USER_KEYSET = 0x00001000;

        [NativeTypeName("#define PKCS12_PREFER_CNG_KSP 0x00000100")]
        public const int PKCS12_PREFER_CNG_KSP = 0x00000100;

        [NativeTypeName("#define PKCS12_ALWAYS_CNG_KSP 0x00000200")]
        public const int PKCS12_ALWAYS_CNG_KSP = 0x00000200;

        [NativeTypeName("#define PKCS12_ONLY_CERTIFICATES 0x00000400")]
        public const int PKCS12_ONLY_CERTIFICATES = 0x00000400;

        [NativeTypeName("#define PKCS12_ONLY_NOT_ENCRYPTED_CERTIFICATES 0x00000800")]
        public const int PKCS12_ONLY_NOT_ENCRYPTED_CERTIFICATES = 0x00000800;

        [NativeTypeName("#define PKCS12_ALLOW_OVERWRITE_KEY 0x00004000")]
        public const int PKCS12_ALLOW_OVERWRITE_KEY = 0x00004000;

        [NativeTypeName("#define PKCS12_NO_PERSIST_KEY 0x00008000")]
        public const int PKCS12_NO_PERSIST_KEY = 0x00008000;

        [NativeTypeName("#define PKCS12_VIRTUAL_ISOLATION_KEY 0x00010000")]
        public const int PKCS12_VIRTUAL_ISOLATION_KEY = 0x00010000;

        [NativeTypeName("#define PKCS12_IMPORT_RESERVED_MASK 0xffff0000")]
        public const uint PKCS12_IMPORT_RESERVED_MASK = 0xffff0000;

        [NativeTypeName("#define PKCS12_OBJECT_LOCATOR_ALL_IMPORT_FLAGS ( PKCS12_ALWAYS_CNG_KSP               |   \\\r\n                PKCS12_NO_PERSIST_KEY               |   \\\r\n                PKCS12_IMPORT_SILENT                |   \\\r\n                PKCS12_INCLUDE_EXTENDED_PROPERTIES  )")]
        public const int PKCS12_OBJECT_LOCATOR_ALL_IMPORT_FLAGS = (0x00000200 | 0x00008000 | 0x00000040 | 0x0010);

        [NativeTypeName("#define PKCS12_ONLY_CERTIFICATES_PROVIDER_TYPE 0")]
        public const int PKCS12_ONLY_CERTIFICATES_PROVIDER_TYPE = 0;

        [NativeTypeName("#define PKCS12_ONLY_CERTIFICATES_PROVIDER_NAME L\"PfxProvider\"")]
        public const string PKCS12_ONLY_CERTIFICATES_PROVIDER_NAME = "PfxProvider";

        [NativeTypeName("#define PKCS12_ONLY_CERTIFICATES_CONTAINER_NAME L\"PfxContainer\"")]
        public const string PKCS12_ONLY_CERTIFICATES_CONTAINER_NAME = "PfxContainer";

        [NativeTypeName("#define REPORT_NO_PRIVATE_KEY 0x0001")]
        public const int REPORT_NO_PRIVATE_KEY = 0x0001;

        [NativeTypeName("#define REPORT_NOT_ABLE_TO_EXPORT_PRIVATE_KEY 0x0002")]
        public const int REPORT_NOT_ABLE_TO_EXPORT_PRIVATE_KEY = 0x0002;

        [NativeTypeName("#define EXPORT_PRIVATE_KEYS 0x0004")]
        public const int EXPORT_PRIVATE_KEYS = 0x0004;

        [NativeTypeName("#define PKCS12_INCLUDE_EXTENDED_PROPERTIES 0x0010")]
        public const int PKCS12_INCLUDE_EXTENDED_PROPERTIES = 0x0010;

        [NativeTypeName("#define PKCS12_PROTECT_TO_DOMAIN_SIDS 0x0020")]
        public const int PKCS12_PROTECT_TO_DOMAIN_SIDS = 0x0020;

        [NativeTypeName("#define PKCS12_EXPORT_SILENT 0x0040")]
        public const int PKCS12_EXPORT_SILENT = 0x0040;

        [NativeTypeName("#define PKCS12_EXPORT_PBES2_PARAMS 0x0080")]
        public const int PKCS12_EXPORT_PBES2_PARAMS = 0x0080;

        [NativeTypeName("#define PKCS12_DISABLE_ENCRYPT_CERTIFICATES 0x0100")]
        public const int PKCS12_DISABLE_ENCRYPT_CERTIFICATES = 0x0100;

        [NativeTypeName("#define PKCS12_ENCRYPT_CERTIFICATES 0x0200")]
        public const int PKCS12_ENCRYPT_CERTIFICATES = 0x0200;

        [NativeTypeName("#define PKCS12_EXPORT_ECC_CURVE_PARAMETERS 0x1000")]
        public const int PKCS12_EXPORT_ECC_CURVE_PARAMETERS = 0x1000;

        [NativeTypeName("#define PKCS12_EXPORT_ECC_CURVE_OID 0x2000")]
        public const int PKCS12_EXPORT_ECC_CURVE_OID = 0x2000;

        [NativeTypeName("#define PKCS12_EXPORT_RESERVED_MASK 0xffff0000")]
        public const uint PKCS12_EXPORT_RESERVED_MASK = 0xffff0000;

        [NativeTypeName("#define PKCS12_PBKDF2_ID_HMAC_SHA1 \"1.2.840.113549.2.7\"")]
        public static ReadOnlySpan<byte> PKCS12_PBKDF2_ID_HMAC_SHA1 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x2E, 0x37, 0x00 };

        [NativeTypeName("#define PKCS12_PBKDF2_ID_HMAC_SHA256 \"1.2.840.113549.2.9\"")]
        public static ReadOnlySpan<byte> PKCS12_PBKDF2_ID_HMAC_SHA256 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x2E, 0x39, 0x00 };

        [NativeTypeName("#define PKCS12_PBKDF2_ID_HMAC_SHA384 \"1.2.840.113549.2.10\"")]
        public static ReadOnlySpan<byte> PKCS12_PBKDF2_ID_HMAC_SHA384 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x2E, 0x31, 0x30, 0x00 };

        [NativeTypeName("#define PKCS12_PBKDF2_ID_HMAC_SHA512 \"1.2.840.113549.2.11\"")]
        public static ReadOnlySpan<byte> PKCS12_PBKDF2_ID_HMAC_SHA512 => new byte[] { 0x31, 0x2E, 0x32, 0x2E, 0x38, 0x34, 0x30, 0x2E, 0x31, 0x31, 0x33, 0x35, 0x34, 0x39, 0x2E, 0x32, 0x2E, 0x31, 0x31, 0x00 };

        [NativeTypeName("#define PKCS12_PBES2_ALG_AES256_SHA256 L\"AES256-SHA256\"")]
        public const string PKCS12_PBES2_ALG_AES256_SHA256 = "AES256-SHA256";

        [NativeTypeName("#define PKCS12_CONFIG_REGPATH L\"Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\PFX\"")]
        public const string PKCS12_CONFIG_REGPATH = "Software\\Microsoft\\Windows\\CurrentVersion\\PFX";

        [NativeTypeName("#define PKCS12_ENCRYPT_CERTIFICATES_VALUE_NAME L\"EncryptCertificates\"")]
        public const string PKCS12_ENCRYPT_CERTIFICATES_VALUE_NAME = "EncryptCertificates";

        [NativeTypeName("#define CERT_SERVER_OCSP_RESPONSE_OPEN_PARA_READ_FLAG 0x00000001")]
        public const int CERT_SERVER_OCSP_RESPONSE_OPEN_PARA_READ_FLAG = 0x00000001;

        [NativeTypeName("#define CERT_SERVER_OCSP_RESPONSE_OPEN_PARA_WRITE_FLAG 0x00000002")]
        public const int CERT_SERVER_OCSP_RESPONSE_OPEN_PARA_WRITE_FLAG = 0x00000002;

        [NativeTypeName("#define CERT_SERVER_OCSP_RESPONSE_ASYNC_FLAG 0x00000001")]
        public const int CERT_SERVER_OCSP_RESPONSE_ASYNC_FLAG = 0x00000001;

        [NativeTypeName("#define CERT_RETRIEVE_ISSUER_LOGO ((LPCSTR) 1)")]
        public static sbyte* CERT_RETRIEVE_ISSUER_LOGO => ((sbyte*)(1));

        [NativeTypeName("#define CERT_RETRIEVE_SUBJECT_LOGO ((LPCSTR) 2)")]
        public static sbyte* CERT_RETRIEVE_SUBJECT_LOGO => ((sbyte*)(2));

        [NativeTypeName("#define CERT_RETRIEVE_COMMUNITY_LOGO ((LPCSTR) 3)")]
        public static sbyte* CERT_RETRIEVE_COMMUNITY_LOGO => ((sbyte*)(3));

        [NativeTypeName("#define CERT_RETRIEVE_BIOMETRIC_PREDEFINED_BASE_TYPE ((LPCSTR) 1000)")]
        public static sbyte* CERT_RETRIEVE_BIOMETRIC_PREDEFINED_BASE_TYPE => ((sbyte*)(1000));

        [NativeTypeName("#define CERT_RETRIEVE_BIOMETRIC_PICTURE_TYPE (CERT_RETRIEVE_BIOMETRIC_PREDEFINED_BASE_TYPE + CERT_BIOMETRIC_PICTURE_TYPE)")]
        public static sbyte* CERT_RETRIEVE_BIOMETRIC_PICTURE_TYPE => (((sbyte*)(1000)) + 0);

        [NativeTypeName("#define CERT_RETRIEVE_BIOMETRIC_SIGNATURE_TYPE (CERT_RETRIEVE_BIOMETRIC_PREDEFINED_BASE_TYPE + CERT_BIOMETRIC_SIGNATURE_TYPE)")]
        public static sbyte* CERT_RETRIEVE_BIOMETRIC_SIGNATURE_TYPE => (((sbyte*)(1000)) + 1);

        [NativeTypeName("#define CERT_SELECT_MAX_PARA 500")]
        public const int CERT_SELECT_MAX_PARA = 500;

        [NativeTypeName("#define CERT_SELECT_BY_ENHKEY_USAGE 1")]
        public const int CERT_SELECT_BY_ENHKEY_USAGE = 1;

        [NativeTypeName("#define CERT_SELECT_BY_KEY_USAGE 2")]
        public const int CERT_SELECT_BY_KEY_USAGE = 2;

        [NativeTypeName("#define CERT_SELECT_BY_POLICY_OID 3")]
        public const int CERT_SELECT_BY_POLICY_OID = 3;

        [NativeTypeName("#define CERT_SELECT_BY_PROV_NAME 4")]
        public const int CERT_SELECT_BY_PROV_NAME = 4;

        [NativeTypeName("#define CERT_SELECT_BY_EXTENSION 5")]
        public const int CERT_SELECT_BY_EXTENSION = 5;

        [NativeTypeName("#define CERT_SELECT_BY_SUBJECT_HOST_NAME 6")]
        public const int CERT_SELECT_BY_SUBJECT_HOST_NAME = 6;

        [NativeTypeName("#define CERT_SELECT_BY_ISSUER_ATTR 7")]
        public const int CERT_SELECT_BY_ISSUER_ATTR = 7;

        [NativeTypeName("#define CERT_SELECT_BY_SUBJECT_ATTR 8")]
        public const int CERT_SELECT_BY_SUBJECT_ATTR = 8;

        [NativeTypeName("#define CERT_SELECT_BY_ISSUER_NAME 9")]
        public const int CERT_SELECT_BY_ISSUER_NAME = 9;

        [NativeTypeName("#define CERT_SELECT_BY_PUBLIC_KEY 10")]
        public const int CERT_SELECT_BY_PUBLIC_KEY = 10;

        [NativeTypeName("#define CERT_SELECT_BY_TLS_SIGNATURES 11")]
        public const int CERT_SELECT_BY_TLS_SIGNATURES = 11;

        [NativeTypeName("#define CERT_SELECT_BY_ISSUER_DISPLAYNAME 12")]
        public const int CERT_SELECT_BY_ISSUER_DISPLAYNAME = 12;

        [NativeTypeName("#define CERT_SELECT_BY_FRIENDLYNAME 13")]
        public const int CERT_SELECT_BY_FRIENDLYNAME = 13;

        [NativeTypeName("#define CERT_SELECT_BY_THUMBPRINT 14")]
        public const int CERT_SELECT_BY_THUMBPRINT = 14;

        [NativeTypeName("#define CERT_SELECT_LAST CERT_SELECT_BY_TLS_SIGNATURES")]
        public const int CERT_SELECT_LAST = 11;

        [NativeTypeName("#define CERT_SELECT_MAX (CERT_SELECT_LAST * 3)")]
        public const int CERT_SELECT_MAX = (11 * 3);

        [NativeTypeName("#define CERT_SELECT_ALLOW_EXPIRED 0x00000001")]
        public const int CERT_SELECT_ALLOW_EXPIRED = 0x00000001;

        [NativeTypeName("#define CERT_SELECT_TRUSTED_ROOT 0x00000002")]
        public const int CERT_SELECT_TRUSTED_ROOT = 0x00000002;

        [NativeTypeName("#define CERT_SELECT_DISALLOW_SELFSIGNED 0x00000004")]
        public const int CERT_SELECT_DISALLOW_SELFSIGNED = 0x00000004;

        [NativeTypeName("#define CERT_SELECT_HAS_PRIVATE_KEY 0x00000008")]
        public const int CERT_SELECT_HAS_PRIVATE_KEY = 0x00000008;

        [NativeTypeName("#define CERT_SELECT_HAS_KEY_FOR_SIGNATURE 0x00000010")]
        public const int CERT_SELECT_HAS_KEY_FOR_SIGNATURE = 0x00000010;

        [NativeTypeName("#define CERT_SELECT_HAS_KEY_FOR_KEY_EXCHANGE 0x00000020")]
        public const int CERT_SELECT_HAS_KEY_FOR_KEY_EXCHANGE = 0x00000020;

        [NativeTypeName("#define CERT_SELECT_HARDWARE_ONLY 0x00000040")]
        public const int CERT_SELECT_HARDWARE_ONLY = 0x00000040;

        [NativeTypeName("#define CERT_SELECT_ALLOW_DUPLICATES 0x00000080")]
        public const int CERT_SELECT_ALLOW_DUPLICATES = 0x00000080;

        [NativeTypeName("#define CERT_SELECT_IGNORE_AUTOSELECT 0x00000100")]
        public const int CERT_SELECT_IGNORE_AUTOSELECT = 0x00000100;

        [NativeTypeName("#define TIMESTAMP_VERSION 1")]
        public const int TIMESTAMP_VERSION = 1;

        [NativeTypeName("#define TIMESTAMP_STATUS_GRANTED 0")]
        public const int TIMESTAMP_STATUS_GRANTED = 0;

        [NativeTypeName("#define TIMESTAMP_STATUS_GRANTED_WITH_MODS 1")]
        public const int TIMESTAMP_STATUS_GRANTED_WITH_MODS = 1;

        [NativeTypeName("#define TIMESTAMP_STATUS_REJECTED 2")]
        public const int TIMESTAMP_STATUS_REJECTED = 2;

        [NativeTypeName("#define TIMESTAMP_STATUS_WAITING 3")]
        public const int TIMESTAMP_STATUS_WAITING = 3;

        [NativeTypeName("#define TIMESTAMP_STATUS_REVOCATION_WARNING 4")]
        public const int TIMESTAMP_STATUS_REVOCATION_WARNING = 4;

        [NativeTypeName("#define TIMESTAMP_STATUS_REVOKED 5")]
        public const int TIMESTAMP_STATUS_REVOKED = 5;

        [NativeTypeName("#define TIMESTAMP_FAILURE_BAD_ALG 0")]
        public const int TIMESTAMP_FAILURE_BAD_ALG = 0;

        [NativeTypeName("#define TIMESTAMP_FAILURE_BAD_REQUEST 2")]
        public const int TIMESTAMP_FAILURE_BAD_REQUEST = 2;

        [NativeTypeName("#define TIMESTAMP_FAILURE_BAD_FORMAT 5")]
        public const int TIMESTAMP_FAILURE_BAD_FORMAT = 5;

        [NativeTypeName("#define TIMESTAMP_FAILURE_TIME_NOT_AVAILABLE 14")]
        public const int TIMESTAMP_FAILURE_TIME_NOT_AVAILABLE = 14;

        [NativeTypeName("#define TIMESTAMP_FAILURE_POLICY_NOT_SUPPORTED 15")]
        public const int TIMESTAMP_FAILURE_POLICY_NOT_SUPPORTED = 15;

        [NativeTypeName("#define TIMESTAMP_FAILURE_EXTENSION_NOT_SUPPORTED 16")]
        public const int TIMESTAMP_FAILURE_EXTENSION_NOT_SUPPORTED = 16;

        [NativeTypeName("#define TIMESTAMP_FAILURE_INFO_NOT_AVAILABLE 17")]
        public const int TIMESTAMP_FAILURE_INFO_NOT_AVAILABLE = 17;

        [NativeTypeName("#define TIMESTAMP_FAILURE_SYSTEM_FAILURE 25")]
        public const int TIMESTAMP_FAILURE_SYSTEM_FAILURE = 25;

        [NativeTypeName("#define TIMESTAMP_DONT_HASH_DATA 0x00000001")]
        public const int TIMESTAMP_DONT_HASH_DATA = 0x00000001;

        [NativeTypeName("#define TIMESTAMP_VERIFY_CONTEXT_SIGNATURE 0x00000020")]
        public const int TIMESTAMP_VERIFY_CONTEXT_SIGNATURE = 0x00000020;

        [NativeTypeName("#define TIMESTAMP_NO_AUTH_RETRIEVAL 0x00020000")]
        public const int TIMESTAMP_NO_AUTH_RETRIEVAL = 0x00020000;

        [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_SPN_NAME_TYPE 1")]
        public const int CRYPT_OBJECT_LOCATOR_SPN_NAME_TYPE = 1;

        [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_LAST_RESERVED_NAME_TYPE 32")]
        public const int CRYPT_OBJECT_LOCATOR_LAST_RESERVED_NAME_TYPE = 32;

        [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_FIRST_RESERVED_USER_NAME_TYPE 33")]
        public const int CRYPT_OBJECT_LOCATOR_FIRST_RESERVED_USER_NAME_TYPE = 33;

        [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_LAST_RESERVED_USER_NAME_TYPE 0x0000FFFF")]
        public const int CRYPT_OBJECT_LOCATOR_LAST_RESERVED_USER_NAME_TYPE = 0x0000FFFF;

        [NativeTypeName("#define SSL_OBJECT_LOCATOR_PFX_FUNC \"SslObjectLocatorInitializePfx\"")]
        public static ReadOnlySpan<byte> SSL_OBJECT_LOCATOR_PFX_FUNC => new byte[] { 0x53, 0x73, 0x6C, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x4C, 0x6F, 0x63, 0x61, 0x74, 0x6F, 0x72, 0x49, 0x6E, 0x69, 0x74, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x50, 0x66, 0x78, 0x00 };

        [NativeTypeName("#define SSL_OBJECT_LOCATOR_ISSUER_LIST_FUNC \"SslObjectLocatorInitializeIssuerList\"")]
        public static ReadOnlySpan<byte> SSL_OBJECT_LOCATOR_ISSUER_LIST_FUNC => new byte[] { 0x53, 0x73, 0x6C, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x4C, 0x6F, 0x63, 0x61, 0x74, 0x6F, 0x72, 0x49, 0x6E, 0x69, 0x74, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x49, 0x73, 0x73, 0x75, 0x65, 0x72, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        [NativeTypeName("#define SSL_OBJECT_LOCATOR_CERT_VALIDATION_CONFIG_FUNC \"SslObjectLocatorInitializeCertValidationConfig\"")]
        public static ReadOnlySpan<byte> SSL_OBJECT_LOCATOR_CERT_VALIDATION_CONFIG_FUNC => new byte[] { 0x53, 0x73, 0x6C, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x4C, 0x6F, 0x63, 0x61, 0x74, 0x6F, 0x72, 0x49, 0x6E, 0x69, 0x74, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x43, 0x65, 0x72, 0x74, 0x56, 0x61, 0x6C, 0x69, 0x64, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x43, 0x6F, 0x6E, 0x66, 0x69, 0x67, 0x00 };

        [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_RELEASE_SYSTEM_SHUTDOWN 1")]
        public const int CRYPT_OBJECT_LOCATOR_RELEASE_SYSTEM_SHUTDOWN = 1;

        [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_RELEASE_SERVICE_STOP 2")]
        public const int CRYPT_OBJECT_LOCATOR_RELEASE_SERVICE_STOP = 2;

        [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_RELEASE_PROCESS_EXIT 3")]
        public const int CRYPT_OBJECT_LOCATOR_RELEASE_PROCESS_EXIT = 3;

        [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_RELEASE_DLL_UNLOAD 4")]
        public const int CRYPT_OBJECT_LOCATOR_RELEASE_DLL_UNLOAD = 4;

        [NativeTypeName("#define CERT_FILE_HASH_USE_TYPE 1")]
        public const int CERT_FILE_HASH_USE_TYPE = 1;

        [NativeTypeName("#define CERT_TIMESTAMP_HASH_USE_TYPE 2")]
        public const int CERT_TIMESTAMP_HASH_USE_TYPE = 2;
    }
}
