// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Advapi32
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptAcquireContextA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptAcquireContextA([NativeTypeName("HCRYPTPROV *")] UIntPtr* phProv, [NativeTypeName("LPCSTR")] sbyte* szContainer, [NativeTypeName("LPCSTR")] sbyte* szProvider, [NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptAcquireContextW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptAcquireContextW([NativeTypeName("HCRYPTPROV *")] UIntPtr* phProv, [NativeTypeName("LPCWSTR")] ushort* szContainer, [NativeTypeName("LPCWSTR")] ushort* szProvider, [NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptReleaseContext", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptReleaseContext([NativeTypeName("HCRYPTPROV")] UIntPtr hProv, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGenKey", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGenKey([NativeTypeName("HCRYPTPROV")] UIntPtr hProv, [NativeTypeName("ALG_ID")] uint Algid, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HCRYPTKEY *")] UIntPtr* phKey);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptDeriveKey", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDeriveKey([NativeTypeName("HCRYPTPROV")] UIntPtr hProv, [NativeTypeName("ALG_ID")] uint Algid, [NativeTypeName("HCRYPTHASH")] UIntPtr hBaseData, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HCRYPTKEY *")] UIntPtr* phKey);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptDestroyKey", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDestroyKey([NativeTypeName("HCRYPTKEY")] UIntPtr hKey);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSetKeyParam", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetKeyParam([NativeTypeName("HCRYPTKEY")] UIntPtr hKey, [NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetKeyParam", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetKeyParam([NativeTypeName("HCRYPTKEY")] UIntPtr hKey, [NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSetHashParam", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetHashParam([NativeTypeName("HCRYPTHASH")] UIntPtr hHash, [NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetHashParam", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetHashParam([NativeTypeName("HCRYPTHASH")] UIntPtr hHash, [NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSetProvParam", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetProvParam([NativeTypeName("HCRYPTPROV")] UIntPtr hProv, [NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetProvParam", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetProvParam([NativeTypeName("HCRYPTPROV")] UIntPtr hProv, [NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGenRandom", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGenRandom([NativeTypeName("HCRYPTPROV")] UIntPtr hProv, [NativeTypeName("DWORD")] uint dwLen, [NativeTypeName("BYTE *")] byte* pbBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetUserKey", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetUserKey([NativeTypeName("HCRYPTPROV")] UIntPtr hProv, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("HCRYPTKEY *")] UIntPtr* phUserKey);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptExportKey", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptExportKey([NativeTypeName("HCRYPTKEY")] UIntPtr hKey, [NativeTypeName("HCRYPTKEY")] UIntPtr hExpKey, [NativeTypeName("DWORD")] uint dwBlobType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptImportKey", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptImportKey([NativeTypeName("HCRYPTPROV")] UIntPtr hProv, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint dwDataLen, [NativeTypeName("HCRYPTKEY")] UIntPtr hPubKey, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HCRYPTKEY *")] UIntPtr* phKey);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptEncrypt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEncrypt([NativeTypeName("HCRYPTKEY")] UIntPtr hKey, [NativeTypeName("HCRYPTHASH")] UIntPtr hHash, [NativeTypeName("BOOL")] int Final, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen, [NativeTypeName("DWORD")] uint dwBufLen);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptDecrypt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDecrypt([NativeTypeName("HCRYPTKEY")] UIntPtr hKey, [NativeTypeName("HCRYPTHASH")] UIntPtr hHash, [NativeTypeName("BOOL")] int Final, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptCreateHash", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptCreateHash([NativeTypeName("HCRYPTPROV")] UIntPtr hProv, [NativeTypeName("ALG_ID")] uint Algid, [NativeTypeName("HCRYPTKEY")] UIntPtr hKey, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HCRYPTHASH *")] UIntPtr* phHash);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptHashData", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptHashData([NativeTypeName("HCRYPTHASH")] UIntPtr hHash, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint dwDataLen, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptHashSessionKey", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptHashSessionKey([NativeTypeName("HCRYPTHASH")] UIntPtr hHash, [NativeTypeName("HCRYPTKEY")] UIntPtr hKey, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptDestroyHash", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDestroyHash([NativeTypeName("HCRYPTHASH")] UIntPtr hHash);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSignHashA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSignHashA([NativeTypeName("HCRYPTHASH")] UIntPtr hHash, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("LPCSTR")] sbyte* szDescription, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbSignature, [NativeTypeName("DWORD *")] uint* pdwSigLen);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSignHashW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSignHashW([NativeTypeName("HCRYPTHASH")] UIntPtr hHash, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("LPCWSTR")] ushort* szDescription, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbSignature, [NativeTypeName("DWORD *")] uint* pdwSigLen);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptVerifySignatureA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifySignatureA([NativeTypeName("HCRYPTHASH")] UIntPtr hHash, [NativeTypeName("const BYTE *")] byte* pbSignature, [NativeTypeName("DWORD")] uint dwSigLen, [NativeTypeName("HCRYPTKEY")] UIntPtr hPubKey, [NativeTypeName("LPCSTR")] sbyte* szDescription, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptVerifySignatureW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifySignatureW([NativeTypeName("HCRYPTHASH")] UIntPtr hHash, [NativeTypeName("const BYTE *")] byte* pbSignature, [NativeTypeName("DWORD")] uint dwSigLen, [NativeTypeName("HCRYPTKEY")] UIntPtr hPubKey, [NativeTypeName("LPCWSTR")] ushort* szDescription, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSetProviderA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetProviderA([NativeTypeName("LPCSTR")] sbyte* pszProvName, [NativeTypeName("DWORD")] uint dwProvType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSetProviderW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetProviderW([NativeTypeName("LPCWSTR")] ushort* pszProvName, [NativeTypeName("DWORD")] uint dwProvType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSetProviderExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetProviderExA([NativeTypeName("LPCSTR")] sbyte* pszProvName, [NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSetProviderExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetProviderExW([NativeTypeName("LPCWSTR")] ushort* pszProvName, [NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetDefaultProviderA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetDefaultProviderA([NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* pszProvName, [NativeTypeName("DWORD *")] uint* pcbProvName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetDefaultProviderW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetDefaultProviderW([NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszProvName, [NativeTypeName("DWORD *")] uint* pcbProvName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptEnumProviderTypesA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEnumProviderTypesA([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwProvType, [NativeTypeName("LPSTR")] sbyte* szTypeName, [NativeTypeName("DWORD *")] uint* pcbTypeName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptEnumProviderTypesW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEnumProviderTypesW([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwProvType, [NativeTypeName("LPWSTR")] ushort* szTypeName, [NativeTypeName("DWORD *")] uint* pcbTypeName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptEnumProvidersA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEnumProvidersA([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwProvType, [NativeTypeName("LPSTR")] sbyte* szProvName, [NativeTypeName("DWORD *")] uint* pcbProvName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptEnumProvidersW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEnumProvidersW([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwProvType, [NativeTypeName("LPWSTR")] ushort* szProvName, [NativeTypeName("DWORD *")] uint* pcbProvName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptContextAddRef", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptContextAddRef([NativeTypeName("HCRYPTPROV")] UIntPtr hProv, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptDuplicateKey", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDuplicateKey([NativeTypeName("HCRYPTKEY")] UIntPtr hKey, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HCRYPTKEY *")] UIntPtr* phKey);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptDuplicateHash", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDuplicateHash([NativeTypeName("HCRYPTHASH")] UIntPtr hHash, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HCRYPTHASH *")] UIntPtr* phHash);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetEncSChannel", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetEncSChannel([NativeTypeName("BYTE **")] byte** pData, [NativeTypeName("DWORD *")] uint* dwDecSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptFormatObject", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptFormatObject([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwFormatType, [NativeTypeName("DWORD")] uint dwFormatStrType, [NativeTypeName("void *")] void* pFormatStruct, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("void *")] void* pbFormat, [NativeTypeName("DWORD *")] uint* pcbFormat);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptEncodeObjectEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEncodeObjectEx([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const void *")] void* pvStructInfo, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCRYPT_ENCODE_PARA")] CRYPT_ENCODE_PARA* pEncodePara, [NativeTypeName("void *")] void* pvEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptEncodeObject", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEncodeObject([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const void *")] void* pvStructInfo, [NativeTypeName("BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptDecodeObjectEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDecodeObjectEx([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCRYPT_DECODE_PARA")] CRYPT_DECODE_PARA* pDecodePara, [NativeTypeName("void *")] void* pvStructInfo, [NativeTypeName("DWORD *")] uint* pcbStructInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptDecodeObject", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDecodeObject([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvStructInfo, [NativeTypeName("DWORD *")] uint* pcbStructInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptInstallOIDFunctionAddress", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptInstallOIDFunctionAddress([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("DWORD")] uint cFuncEntry, [NativeTypeName("const CRYPT_OID_FUNC_ENTRY []")] CRYPT_OID_FUNC_ENTRY* rgFuncEntry, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptInitOIDFunctionSet", ExactSpelling = true)]
        [return: NativeTypeName("HCRYPTOIDFUNCSET")]
        public static extern void* CryptInitOIDFunctionSet([NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetOIDFunctionAddress", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetOIDFunctionAddress([NativeTypeName("HCRYPTOIDFUNCSET")] void* hFuncSet, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void **")] void** ppvFuncAddr, [NativeTypeName("HCRYPTOIDFUNCADDR *")] void** phFuncAddr);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetDefaultOIDDllList", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetDefaultOIDDllList([NativeTypeName("HCRYPTOIDFUNCSET")] void* hFuncSet, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("WCHAR *")] ushort* pwszDllList, [NativeTypeName("DWORD *")] uint* pcchDllList);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetDefaultOIDFunctionAddress", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetDefaultOIDFunctionAddress([NativeTypeName("HCRYPTOIDFUNCSET")] void* hFuncSet, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCWSTR")] ushort* pwszDll, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void **")] void** ppvFuncAddr, [NativeTypeName("HCRYPTOIDFUNCADDR *")] void** phFuncAddr);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptFreeOIDFunctionAddress", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptFreeOIDFunctionAddress([NativeTypeName("HCRYPTOIDFUNCADDR")] void* hFuncAddr, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptRegisterOIDFunction", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptRegisterOIDFunction([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("LPCWSTR")] ushort* pwszDll, [NativeTypeName("LPCSTR")] sbyte* pszOverrideFuncName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptUnregisterOIDFunction", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptUnregisterOIDFunction([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptRegisterDefaultOIDFunction", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptRegisterDefaultOIDFunction([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPCWSTR")] ushort* pwszDll);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptUnregisterDefaultOIDFunction", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptUnregisterDefaultOIDFunction([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCWSTR")] ushort* pwszDll);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSetOIDFunctionValue", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetOIDFunctionValue([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("LPCWSTR")] ushort* pwszValueName, [NativeTypeName("DWORD")] uint dwValueType, [NativeTypeName("const BYTE *")] byte* pbValueData, [NativeTypeName("DWORD")] uint cbValueData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetOIDFunctionValue", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetOIDFunctionValue([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("LPCWSTR")] ushort* pwszValueName, [NativeTypeName("DWORD *")] uint* pdwValueType, [NativeTypeName("BYTE *")] byte* pbValueData, [NativeTypeName("DWORD *")] uint* pcbValueData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptEnumOIDFunction", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEnumOIDFunction([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvArg, [NativeTypeName("PFN_CRYPT_ENUM_OID_FUNC")] IntPtr* pfnEnumOIDFunc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptFindOIDInfo", ExactSpelling = true)]
        [return: NativeTypeName("PCCRYPT_OID_INFO")]
        public static extern CRYPT_OID_INFO* CryptFindOIDInfo([NativeTypeName("DWORD")] uint dwKeyType, [NativeTypeName("void *")] void* pvKey, [NativeTypeName("DWORD")] uint dwGroupId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptRegisterOIDInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptRegisterOIDInfo([NativeTypeName("PCCRYPT_OID_INFO")] CRYPT_OID_INFO* pInfo, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptUnregisterOIDInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptUnregisterOIDInfo([NativeTypeName("PCCRYPT_OID_INFO")] CRYPT_OID_INFO* pInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptEnumOIDInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEnumOIDInfo([NativeTypeName("DWORD")] uint dwGroupId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvArg, [NativeTypeName("PFN_CRYPT_ENUM_OID_INFO")] IntPtr* pfnEnumOIDInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptFindLocalizedName", ExactSpelling = true)]
        [return: NativeTypeName("LPCWSTR")]
        public static extern ushort* CryptFindLocalizedName([NativeTypeName("LPCWSTR")] ushort* pwszCryptName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMsgOpenToEncode", ExactSpelling = true)]
        [return: NativeTypeName("HCRYPTMSG")]
        public static extern void* CryptMsgOpenToEncode([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwMsgType, [NativeTypeName("const void *")] void* pvMsgEncodeInfo, [NativeTypeName("LPSTR")] sbyte* pszInnerContentObjID, [NativeTypeName("PCMSG_STREAM_INFO")] CMSG_STREAM_INFO* pStreamInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMsgCalculateEncodedLength", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CryptMsgCalculateEncodedLength([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwMsgType, [NativeTypeName("const void *")] void* pvMsgEncodeInfo, [NativeTypeName("LPSTR")] sbyte* pszInnerContentObjID, [NativeTypeName("DWORD")] uint cbData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMsgOpenToDecode", ExactSpelling = true)]
        [return: NativeTypeName("HCRYPTMSG")]
        public static extern void* CryptMsgOpenToDecode([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwMsgType, [NativeTypeName("HCRYPTPROV_LEGACY")] UIntPtr hCryptProv, [NativeTypeName("PCERT_INFO")] CERT_INFO* pRecipientInfo, [NativeTypeName("PCMSG_STREAM_INFO")] CMSG_STREAM_INFO* pStreamInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMsgDuplicate", ExactSpelling = true)]
        [return: NativeTypeName("HCRYPTMSG")]
        public static extern void* CryptMsgDuplicate([NativeTypeName("HCRYPTMSG")] void* hCryptMsg);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMsgClose", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgClose([NativeTypeName("HCRYPTMSG")] void* hCryptMsg);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMsgUpdate", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgUpdate([NativeTypeName("HCRYPTMSG")] void* hCryptMsg, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("BOOL")] int fFinal);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMsgGetParam", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgGetParam([NativeTypeName("HCRYPTMSG")] void* hCryptMsg, [NativeTypeName("DWORD")] uint dwParamType, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("void *")] void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMsgControl", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgControl([NativeTypeName("HCRYPTMSG")] void* hCryptMsg, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwCtrlType, [NativeTypeName("const void *")] void* pvCtrlPara);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMsgVerifyCountersignatureEncoded", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgVerifyCountersignatureEncoded([NativeTypeName("HCRYPTPROV_LEGACY")] UIntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("PBYTE")] byte* pbSignerInfo, [NativeTypeName("DWORD")] uint cbSignerInfo, [NativeTypeName("PBYTE")] byte* pbSignerInfoCountersignature, [NativeTypeName("DWORD")] uint cbSignerInfoCountersignature, [NativeTypeName("PCERT_INFO")] CERT_INFO* pciCountersigner);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMsgVerifyCountersignatureEncodedEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgVerifyCountersignatureEncodedEx([NativeTypeName("HCRYPTPROV_LEGACY")] UIntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("PBYTE")] byte* pbSignerInfo, [NativeTypeName("DWORD")] uint cbSignerInfo, [NativeTypeName("PBYTE")] byte* pbSignerInfoCountersignature, [NativeTypeName("DWORD")] uint cbSignerInfoCountersignature, [NativeTypeName("DWORD")] uint dwSignerType, [NativeTypeName("void *")] void* pvSigner, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvExtra);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMsgCountersign", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgCountersign([NativeTypeName("HCRYPTMSG")] void* hCryptMsg, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint cCountersigners, [NativeTypeName("PCMSG_SIGNER_ENCODE_INFO")] CMSG_SIGNER_ENCODE_INFO* rgCountersigners);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMsgCountersignEncoded", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgCountersignEncoded([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("PBYTE")] byte* pbSignerInfo, [NativeTypeName("DWORD")] uint cbSignerInfo, [NativeTypeName("DWORD")] uint cCountersigners, [NativeTypeName("PCMSG_SIGNER_ENCODE_INFO")] CMSG_SIGNER_ENCODE_INFO* rgCountersigners, [NativeTypeName("PBYTE")] byte* pbCountersignature, [NativeTypeName("PDWORD")] uint* pcbCountersignature);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertOpenStore", ExactSpelling = true)]
        [return: NativeTypeName("HCERTSTORE")]
        public static extern void* CertOpenStore([NativeTypeName("LPCSTR")] sbyte* lpszStoreProvider, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("HCRYPTPROV_LEGACY")] UIntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvPara);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertDuplicateStore", ExactSpelling = true)]
        [return: NativeTypeName("HCERTSTORE")]
        public static extern void* CertDuplicateStore([NativeTypeName("HCERTSTORE")] void* hCertStore);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertSaveStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSaveStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("DWORD")] uint dwSaveAs, [NativeTypeName("DWORD")] uint dwSaveTo, [NativeTypeName("void *")] void* pvSaveToPara, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertCloseStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertCloseStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertGetSubjectCertificateFromStore", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertGetSubjectCertificateFromStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertEnumCertificatesInStore", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertEnumCertificatesInStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pPrevCertContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFindCertificateInStore", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertFindCertificateInStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwFindFlags, [NativeTypeName("DWORD")] uint dwFindType, [NativeTypeName("const void *")] void* pvFindPara, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pPrevCertContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertGetIssuerCertificateFromStore", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertGetIssuerCertificateFromStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pSubjectContext, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pPrevIssuerContext, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertVerifySubjectCertificateContext", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertVerifySubjectCertificateContext([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pSubject, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuer, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertDuplicateCertificateContext", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertDuplicateCertificateContext([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertCreateCertificateContext", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertCreateCertificateContext([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCertEncoded, [NativeTypeName("DWORD")] uint cbCertEncoded);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFreeCertificateContext", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertFreeCertificateContext([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertSetCertificateContextProperty", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSetCertificateContextProperty([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertGetCertificateContextProperty", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetCertificateContextProperty([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("void *")] void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertEnumCertificateContextProperties", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertEnumCertificateContextProperties([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwPropId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertCreateCTLEntryFromCertificateContextProperties", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertCreateCTLEntryFromCertificateContextProperties([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint cOptAttr, [NativeTypeName("PCRYPT_ATTRIBUTE")] CRYPT_ATTRIBUTE* rgOptAttr, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved, [NativeTypeName("PCTL_ENTRY")] CTL_ENTRY* pCtlEntry, [NativeTypeName("DWORD *")] uint* pcbCtlEntry);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertSetCertificateContextPropertiesFromCTLEntry", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSetCertificateContextPropertiesFromCTLEntry([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("PCTL_ENTRY")] CTL_ENTRY* pCtlEntry, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertGetCRLFromStore", ExactSpelling = true)]
        [return: NativeTypeName("PCCRL_CONTEXT")]
        public static extern CRL_CONTEXT* CertGetCRLFromStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuerContext, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pPrevCrlContext, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertEnumCRLsInStore", ExactSpelling = true)]
        [return: NativeTypeName("PCCRL_CONTEXT")]
        public static extern CRL_CONTEXT* CertEnumCRLsInStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pPrevCrlContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFindCRLInStore", ExactSpelling = true)]
        [return: NativeTypeName("PCCRL_CONTEXT")]
        public static extern CRL_CONTEXT* CertFindCRLInStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwFindFlags, [NativeTypeName("DWORD")] uint dwFindType, [NativeTypeName("const void *")] void* pvFindPara, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pPrevCrlContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertDuplicateCRLContext", ExactSpelling = true)]
        [return: NativeTypeName("PCCRL_CONTEXT")]
        public static extern CRL_CONTEXT* CertDuplicateCRLContext([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertCreateCRLContext", ExactSpelling = true)]
        [return: NativeTypeName("PCCRL_CONTEXT")]
        public static extern CRL_CONTEXT* CertCreateCRLContext([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCrlEncoded, [NativeTypeName("DWORD")] uint cbCrlEncoded);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFreeCRLContext", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertFreeCRLContext([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertSetCRLContextProperty", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSetCRLContextProperty([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertGetCRLContextProperty", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetCRLContextProperty([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("void *")] void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertEnumCRLContextProperties", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertEnumCRLContextProperties([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwPropId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFindCertificateInCRL", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertFindCertificateInCRL([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved, [NativeTypeName("PCRL_ENTRY *")] CRL_ENTRY** ppCrlEntry);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertIsValidCRLForCertificate", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertIsValidCRLForCertificate([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrl, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddEncodedCertificateToStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddEncodedCertificateToStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCertEncoded, [NativeTypeName("DWORD")] uint cbCertEncoded, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppCertContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddCertificateContextToStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddCertificateContextToStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppStoreContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddSerializedElementToStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddSerializedElementToStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("const BYTE *")] byte* pbElement, [NativeTypeName("DWORD")] uint cbElement, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwContextTypeFlags, [NativeTypeName("DWORD *")] uint* pdwContextType, [NativeTypeName("const void **")] void** ppvContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertDeleteCertificateFromStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertDeleteCertificateFromStore([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddEncodedCRLToStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddEncodedCRLToStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCrlEncoded, [NativeTypeName("DWORD")] uint cbCrlEncoded, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCRL_CONTEXT *")] CRL_CONTEXT** ppCrlContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddCRLContextToStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddCRLContextToStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCRL_CONTEXT *")] CRL_CONTEXT** ppStoreContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertDeleteCRLFromStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertDeleteCRLFromStore([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertSerializeCertificateStoreElement", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSerializeCertificateStoreElement([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbElement, [NativeTypeName("DWORD *")] uint* pcbElement);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertSerializeCRLStoreElement", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSerializeCRLStoreElement([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbElement, [NativeTypeName("DWORD *")] uint* pcbElement);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertDuplicateCTLContext", ExactSpelling = true)]
        [return: NativeTypeName("PCCTL_CONTEXT")]
        public static extern CTL_CONTEXT* CertDuplicateCTLContext([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertCreateCTLContext", ExactSpelling = true)]
        [return: NativeTypeName("PCCTL_CONTEXT")]
        public static extern CTL_CONTEXT* CertCreateCTLContext([NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCtlEncoded, [NativeTypeName("DWORD")] uint cbCtlEncoded);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFreeCTLContext", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertFreeCTLContext([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertSetCTLContextProperty", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSetCTLContextProperty([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertGetCTLContextProperty", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetCTLContextProperty([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("void *")] void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertEnumCTLContextProperties", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertEnumCTLContextProperties([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwPropId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertEnumCTLsInStore", ExactSpelling = true)]
        [return: NativeTypeName("PCCTL_CONTEXT")]
        public static extern CTL_CONTEXT* CertEnumCTLsInStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pPrevCtlContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFindSubjectInCTL", ExactSpelling = true)]
        [return: NativeTypeName("PCTL_ENTRY")]
        public static extern CTL_ENTRY* CertFindSubjectInCTL([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("DWORD")] uint dwSubjectType, [NativeTypeName("void *")] void* pvSubject, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFindCTLInStore", ExactSpelling = true)]
        [return: NativeTypeName("PCCTL_CONTEXT")]
        public static extern CTL_CONTEXT* CertFindCTLInStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType, [NativeTypeName("DWORD")] uint dwFindFlags, [NativeTypeName("DWORD")] uint dwFindType, [NativeTypeName("const void *")] void* pvFindPara, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pPrevCtlContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddEncodedCTLToStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddEncodedCTLToStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCtlEncoded, [NativeTypeName("DWORD")] uint cbCtlEncoded, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCTL_CONTEXT *")] CTL_CONTEXT** ppCtlContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddCTLContextToStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddCTLContextToStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCTL_CONTEXT *")] CTL_CONTEXT** ppStoreContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertSerializeCTLStoreElement", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSerializeCTLStoreElement([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbElement, [NativeTypeName("DWORD *")] uint* pcbElement);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertDeleteCTLFromStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertDeleteCTLFromStore([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddCertificateLinkToStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddCertificateLinkToStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppStoreContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddCRLLinkToStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddCRLLinkToStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCRL_CONTEXT *")] CRL_CONTEXT** ppStoreContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddCTLLinkToStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddCTLLinkToStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCTL_CONTEXT *")] CTL_CONTEXT** ppStoreContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddStoreToCollection", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddStoreToCollection([NativeTypeName("HCERTSTORE")] void* hCollectionStore, [NativeTypeName("HCERTSTORE")] void* hSiblingStore, [NativeTypeName("DWORD")] uint dwUpdateFlags, [NativeTypeName("DWORD")] uint dwPriority);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertRemoveStoreFromCollection", ExactSpelling = true)]
        public static extern void CertRemoveStoreFromCollection([NativeTypeName("HCERTSTORE")] void* hCollectionStore, [NativeTypeName("HCERTSTORE")] void* hSiblingStore);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertControlStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertControlStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwCtrlType, [NativeTypeName("const void *")] void* pvCtrlPara);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertSetStoreProperty", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSetStoreProperty([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertGetStoreProperty", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetStoreProperty([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("void *")] void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertCreateContext", ExactSpelling = true)]
        [return: NativeTypeName("const void *")]
        public static extern void* CertCreateContext([NativeTypeName("DWORD")] uint dwContextType, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_CREATE_CONTEXT_PARA")] CERT_CREATE_CONTEXT_PARA* pCreatePara);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertRegisterSystemStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertRegisterSystemStore([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_SYSTEM_STORE_INFO")] CERT_SYSTEM_STORE_INFO* pStoreInfo, [NativeTypeName("void *")] void* pvReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertRegisterPhysicalStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertRegisterPhysicalStore([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszStoreName, [NativeTypeName("PCERT_PHYSICAL_STORE_INFO")] CERT_PHYSICAL_STORE_INFO* pStoreInfo, [NativeTypeName("void *")] void* pvReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertUnregisterSystemStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertUnregisterSystemStore([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertUnregisterPhysicalStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertUnregisterPhysicalStore([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszStoreName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertEnumSystemStoreLocation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertEnumSystemStoreLocation([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvArg, [NativeTypeName("PFN_CERT_ENUM_SYSTEM_STORE_LOCATION")] IntPtr* pfnEnum);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertEnumSystemStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertEnumSystemStore([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvSystemStoreLocationPara, [NativeTypeName("void *")] void* pvArg, [NativeTypeName("PFN_CERT_ENUM_SYSTEM_STORE")] IntPtr* pfnEnum);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertEnumPhysicalStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertEnumPhysicalStore([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvArg, [NativeTypeName("PFN_CERT_ENUM_PHYSICAL_STORE")] IntPtr* pfnEnum);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertGetEnhancedKeyUsage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetEnhancedKeyUsage([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_ENHKEY_USAGE")] CTL_USAGE* pUsage, [NativeTypeName("DWORD *")] uint* pcbUsage);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertSetEnhancedKeyUsage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSetEnhancedKeyUsage([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("PCERT_ENHKEY_USAGE")] CTL_USAGE* pUsage);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddEnhancedKeyUsageIdentifier", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddEnhancedKeyUsageIdentifier([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("LPCSTR")] sbyte* pszUsageIdentifier);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertRemoveEnhancedKeyUsageIdentifier", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertRemoveEnhancedKeyUsageIdentifier([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("LPCSTR")] sbyte* pszUsageIdentifier);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertGetValidUsages", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetValidUsages([NativeTypeName("DWORD")] uint cCerts, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** rghCerts, [NativeTypeName("int *")] int* cNumOIDs, [NativeTypeName("LPSTR *")] sbyte** rghOIDs, [NativeTypeName("DWORD *")] uint* pcbOIDs);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMsgGetAndVerifySigner", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgGetAndVerifySigner([NativeTypeName("HCRYPTMSG")] void* hCryptMsg, [NativeTypeName("DWORD")] uint cSignerStore, [NativeTypeName("HCERTSTORE *")] void** rghSignerStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSigner, [NativeTypeName("DWORD *")] uint* pdwSignerIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMsgSignCTL", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgSignCTL([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("BYTE *")] byte* pbCtlContent, [NativeTypeName("DWORD")] uint cbCtlContent, [NativeTypeName("PCMSG_SIGNED_ENCODE_INFO")] CMSG_SIGNED_ENCODE_INFO* pSignInfo, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMsgEncodeAndSignCTL", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptMsgEncodeAndSignCTL([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("PCTL_INFO")] CTL_INFO* pCtlInfo, [NativeTypeName("PCMSG_SIGNED_ENCODE_INFO")] CMSG_SIGNED_ENCODE_INFO* pSignInfo, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFindSubjectInSortedCTL", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertFindSubjectInSortedCTL([NativeTypeName("PCRYPT_DATA_BLOB")] CRYPTOAPI_BLOB* pSubjectIdentifier, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved, [NativeTypeName("PCRYPT_DER_BLOB")] CRYPTOAPI_BLOB* pEncodedAttributes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertEnumSubjectInSortedCTL", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertEnumSubjectInSortedCTL([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("void **")] void** ppvNextSubject, [NativeTypeName("PCRYPT_DER_BLOB")] CRYPTOAPI_BLOB* pSubjectIdentifier, [NativeTypeName("PCRYPT_DER_BLOB")] CRYPTOAPI_BLOB* pEncodedAttributes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertVerifyCTLUsage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertVerifyCTLUsage([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("DWORD")] uint dwSubjectType, [NativeTypeName("void *")] void* pvSubject, [NativeTypeName("PCTL_USAGE")] CTL_USAGE* pSubjectUsage, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCTL_VERIFY_USAGE_PARA")] CTL_VERIFY_USAGE_PARA* pVerifyUsagePara, [NativeTypeName("PCTL_VERIFY_USAGE_STATUS")] CTL_VERIFY_USAGE_STATUS* pVerifyUsageStatus);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertVerifyRevocation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertVerifyRevocation([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("DWORD")] uint dwRevType, [NativeTypeName("DWORD")] uint cContext, [NativeTypeName("PVOID []")] void** rgpvContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_REVOCATION_PARA")] CERT_REVOCATION_PARA* pRevPara, [NativeTypeName("PCERT_REVOCATION_STATUS")] CERT_REVOCATION_STATUS* pRevStatus);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertCompareIntegerBlob", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertCompareIntegerBlob([NativeTypeName("PCRYPT_INTEGER_BLOB")] CRYPTOAPI_BLOB* pInt1, [NativeTypeName("PCRYPT_INTEGER_BLOB")] CRYPTOAPI_BLOB* pInt2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertCompareCertificate", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertCompareCertificate([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId1, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertCompareCertificateName", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertCompareCertificateName([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_NAME_BLOB")] CRYPTOAPI_BLOB* pCertName1, [NativeTypeName("PCERT_NAME_BLOB")] CRYPTOAPI_BLOB* pCertName2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertIsRDNAttrsInCertificateName", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertIsRDNAttrsInCertificateName([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_NAME_BLOB")] CRYPTOAPI_BLOB* pCertName, [NativeTypeName("PCERT_RDN")] CERT_RDN* pRDN);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertComparePublicKeyInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertComparePublicKeyInfo([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey1, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertGetPublicKeyLength", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertGetPublicKeyLength([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptVerifyCertificateSignature", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyCertificateSignature([NativeTypeName("HCRYPTPROV_LEGACY")] UIntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptVerifyCertificateSignatureEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyCertificateSignatureEx([NativeTypeName("HCRYPTPROV_LEGACY")] UIntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwSubjectType, [NativeTypeName("void *")] void* pvSubject, [NativeTypeName("DWORD")] uint dwIssuerType, [NativeTypeName("void *")] void* pvIssuer, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvExtra);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertIsStrongHashToSign", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertIsStrongHashToSign([NativeTypeName("PCCERT_STRONG_SIGN_PARA")] CERT_STRONG_SIGN_PARA* pStrongSignPara, [NativeTypeName("LPCWSTR")] ushort* pwszCNGHashAlgid, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pSigningCert);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptHashToBeSigned", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptHashToBeSigned([NativeTypeName("HCRYPTPROV_LEGACY")] UIntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("BYTE *")] byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptHashCertificate", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptHashCertificate([NativeTypeName("HCRYPTPROV_LEGACY")] UIntPtr hCryptProv, [NativeTypeName("ALG_ID")] uint Algid, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("BYTE *")] byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptHashCertificate2", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptHashCertificate2([NativeTypeName("LPCWSTR")] ushort* pwszCNGHashAlgid, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("BYTE *")] byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSignCertificate", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSignCertificate([NativeTypeName("HCRYPTPROV_OR_NCRYPT_KEY_HANDLE")] UIntPtr hCryptProvOrNCryptKey, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbEncodedToBeSigned, [NativeTypeName("DWORD")] uint cbEncodedToBeSigned, [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")] CRYPT_ALGORITHM_IDENTIFIER* pSignatureAlgorithm, [NativeTypeName("const void *")] void* pvHashAuxInfo, [NativeTypeName("BYTE *")] byte* pbSignature, [NativeTypeName("DWORD *")] uint* pcbSignature);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSignAndEncodeCertificate", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSignAndEncodeCertificate([NativeTypeName("HCRYPTPROV_OR_NCRYPT_KEY_HANDLE")] UIntPtr hCryptProvOrNCryptKey, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const void *")] void* pvStructInfo, [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")] CRYPT_ALGORITHM_IDENTIFIER* pSignatureAlgorithm, [NativeTypeName("const void *")] void* pvHashAuxInfo, [NativeTypeName("BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertVerifyTimeValidity", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int CertVerifyTimeValidity([NativeTypeName("LPFILETIME")] FILETIME* pTimeToVerify, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertVerifyCRLTimeValidity", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int CertVerifyCRLTimeValidity([NativeTypeName("LPFILETIME")] FILETIME* pTimeToVerify, [NativeTypeName("PCRL_INFO")] CRL_INFO* pCrlInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertVerifyValidityNesting", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertVerifyValidityNesting([NativeTypeName("PCERT_INFO")] CERT_INFO* pSubjectInfo, [NativeTypeName("PCERT_INFO")] CERT_INFO* pIssuerInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertVerifyCRLRevocation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertVerifyCRLRevocation([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId, [NativeTypeName("DWORD")] uint cCrlInfo, [NativeTypeName("PCRL_INFO []")] CRL_INFO** rgpCrlInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAlgIdToOID", ExactSpelling = true)]
        [return: NativeTypeName("LPCSTR")]
        public static extern sbyte* CertAlgIdToOID([NativeTypeName("DWORD")] uint dwAlgId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertOIDToAlgId", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertOIDToAlgId([NativeTypeName("LPCSTR")] sbyte* pszObjId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFindExtension", ExactSpelling = true)]
        [return: NativeTypeName("PCERT_EXTENSION")]
        public static extern CERT_EXTENSION* CertFindExtension([NativeTypeName("LPCSTR")] sbyte* pszObjId, [NativeTypeName("DWORD")] uint cExtensions, [NativeTypeName("CERT_EXTENSION []")] CERT_EXTENSION* rgExtensions);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFindAttribute", ExactSpelling = true)]
        [return: NativeTypeName("PCRYPT_ATTRIBUTE")]
        public static extern CRYPT_ATTRIBUTE* CertFindAttribute([NativeTypeName("LPCSTR")] sbyte* pszObjId, [NativeTypeName("DWORD")] uint cAttr, [NativeTypeName("CRYPT_ATTRIBUTE []")] CRYPT_ATTRIBUTE* rgAttr);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFindRDNAttr", ExactSpelling = true)]
        [return: NativeTypeName("PCERT_RDN_ATTR")]
        public static extern CERT_RDN_ATTR* CertFindRDNAttr([NativeTypeName("LPCSTR")] sbyte* pszObjId, [NativeTypeName("PCERT_NAME_INFO")] CERT_NAME_INFO* pName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertGetIntendedKeyUsage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetIntendedKeyUsage([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertInfo, [NativeTypeName("BYTE *")] byte* pbKeyUsage, [NativeTypeName("DWORD")] uint cbKeyUsage);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptInstallDefaultContext", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptInstallDefaultContext([NativeTypeName("HCRYPTPROV")] UIntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwDefaultType, [NativeTypeName("const void *")] void* pvDefaultPara, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved, [NativeTypeName("HCRYPTDEFAULTCONTEXT *")] void** phDefaultContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptUninstallDefaultContext", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptUninstallDefaultContext([NativeTypeName("HCRYPTDEFAULTCONTEXT")] void* hDefaultContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptExportPublicKeyInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptExportPublicKeyInfo([NativeTypeName("HCRYPTPROV_OR_NCRYPT_KEY_HANDLE")] UIntPtr hCryptProvOrNCryptKey, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("DWORD *")] uint* pcbInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptExportPublicKeyInfoEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptExportPublicKeyInfoEx([NativeTypeName("HCRYPTPROV_OR_NCRYPT_KEY_HANDLE")] UIntPtr hCryptProvOrNCryptKey, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPSTR")] sbyte* pszPublicKeyObjId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvAuxInfo, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("DWORD *")] uint* pcbInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptExportPublicKeyInfoFromBCryptKeyHandle", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptExportPublicKeyInfoFromBCryptKeyHandle([NativeTypeName("BCRYPT_KEY_HANDLE")] void* hBCryptKey, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPSTR")] sbyte* pszPublicKeyObjId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvAuxInfo, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("DWORD *")] uint* pcbInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptImportPublicKeyInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptImportPublicKeyInfo([NativeTypeName("HCRYPTPROV")] UIntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("HCRYPTKEY *")] UIntPtr* phKey);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptImportPublicKeyInfoEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptImportPublicKeyInfoEx([NativeTypeName("HCRYPTPROV")] UIntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("ALG_ID")] uint aiKeyAlg, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvAuxInfo, [NativeTypeName("HCRYPTKEY *")] UIntPtr* phKey);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptImportPublicKeyInfoEx2", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptImportPublicKeyInfoEx2([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvAuxInfo, [NativeTypeName("BCRYPT_KEY_HANDLE *")] void** phKey);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptAcquireCertificatePrivateKey", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptAcquireCertificatePrivateKey([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvParameters, [NativeTypeName("HCRYPTPROV_OR_NCRYPT_KEY_HANDLE *")] UIntPtr* phCryptProvOrNCryptKey, [NativeTypeName("DWORD *")] uint* pdwKeySpec, [NativeTypeName("BOOL *")] int* pfCallerFreeProvOrNCryptKey);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptFindCertificateKeyProvInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptFindCertificateKeyProvInfo([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptImportPKCS8", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptImportPKCS8(CRYPT_PKCS8_IMPORT_PARAMS sPrivateKeyAndParams, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HCRYPTPROV *")] UIntPtr* phCryptProv, [NativeTypeName("void *")] void* pvAuxInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptExportPKCS8", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptExportPKCS8([NativeTypeName("HCRYPTPROV")] UIntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("LPSTR")] sbyte* pszPrivateKeyObjId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvAuxInfo, [NativeTypeName("BYTE *")] byte* pbPrivateKeyBlob, [NativeTypeName("DWORD *")] uint* pcbPrivateKeyBlob);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptExportPKCS8Ex", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptExportPKCS8Ex([NativeTypeName("CRYPT_PKCS8_EXPORT_PARAMS *")] CRYPT_PKCS8_EXPORT_PARAMS* psExportParams, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvAuxInfo, [NativeTypeName("BYTE *")] byte* pbPrivateKeyBlob, [NativeTypeName("DWORD *")] uint* pcbPrivateKeyBlob);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptHashPublicKeyInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptHashPublicKeyInfo([NativeTypeName("HCRYPTPROV_LEGACY")] UIntPtr hCryptProv, [NativeTypeName("ALG_ID")] uint Algid, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("BYTE *")] byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertRDNValueToStrA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertRDNValueToStrA([NativeTypeName("DWORD")] uint dwValueType, [NativeTypeName("PCERT_RDN_VALUE_BLOB")] CRYPTOAPI_BLOB* pValue, [NativeTypeName("LPSTR")] sbyte* psz, [NativeTypeName("DWORD")] uint csz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertRDNValueToStrW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertRDNValueToStrW([NativeTypeName("DWORD")] uint dwValueType, [NativeTypeName("PCERT_RDN_VALUE_BLOB")] CRYPTOAPI_BLOB* pValue, [NativeTypeName("LPWSTR")] ushort* psz, [NativeTypeName("DWORD")] uint csz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertNameToStrA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertNameToStrA([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_NAME_BLOB")] CRYPTOAPI_BLOB* pName, [NativeTypeName("DWORD")] uint dwStrType, [NativeTypeName("LPSTR")] sbyte* psz, [NativeTypeName("DWORD")] uint csz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertNameToStrW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertNameToStrW([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_NAME_BLOB")] CRYPTOAPI_BLOB* pName, [NativeTypeName("DWORD")] uint dwStrType, [NativeTypeName("LPWSTR")] ushort* psz, [NativeTypeName("DWORD")] uint csz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertStrToNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertStrToNameA([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszX500, [NativeTypeName("DWORD")] uint dwStrType, [NativeTypeName("void *")] void* pvReserved, [NativeTypeName("BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded, [NativeTypeName("LPCSTR *")] sbyte** ppszError);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertStrToNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertStrToNameW([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCWSTR")] ushort* pszX500, [NativeTypeName("DWORD")] uint dwStrType, [NativeTypeName("void *")] void* pvReserved, [NativeTypeName("BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded, [NativeTypeName("LPCWSTR *")] ushort** ppszError);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertGetNameStringA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertGetNameStringA([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvTypePara, [NativeTypeName("LPSTR")] sbyte* pszNameString, [NativeTypeName("DWORD")] uint cchNameString);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertGetNameStringW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertGetNameStringW([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvTypePara, [NativeTypeName("LPWSTR")] ushort* pszNameString, [NativeTypeName("DWORD")] uint cchNameString);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSignMessage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSignMessage([NativeTypeName("PCRYPT_SIGN_MESSAGE_PARA")] CRYPT_SIGN_MESSAGE_PARA* pSignPara, [NativeTypeName("BOOL")] int fDetachedSignature, [NativeTypeName("DWORD")] uint cToBeSigned, [NativeTypeName("const BYTE *[]")] byte** rgpbToBeSigned, [NativeTypeName("DWORD []")] uint* rgcbToBeSigned, [NativeTypeName("BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD *")] uint* pcbSignedBlob);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptVerifyMessageSignature", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyMessageSignature([NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara, [NativeTypeName("DWORD")] uint dwSignerIndex, [NativeTypeName("const BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD")] uint cbSignedBlob, [NativeTypeName("BYTE *")] byte* pbDecoded, [NativeTypeName("DWORD *")] uint* pcbDecoded, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetMessageSignerCount", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int CryptGetMessageSignerCount([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("const BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD")] uint cbSignedBlob);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetMessageCertificates", ExactSpelling = true)]
        [return: NativeTypeName("HCERTSTORE")]
        public static extern void* CryptGetMessageCertificates([NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType, [NativeTypeName("HCRYPTPROV_LEGACY")] UIntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD")] uint cbSignedBlob);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptVerifyDetachedMessageSignature", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyDetachedMessageSignature([NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara, [NativeTypeName("DWORD")] uint dwSignerIndex, [NativeTypeName("const BYTE *")] byte* pbDetachedSignBlob, [NativeTypeName("DWORD")] uint cbDetachedSignBlob, [NativeTypeName("DWORD")] uint cToBeSigned, [NativeTypeName("const BYTE *[]")] byte** rgpbToBeSigned, [NativeTypeName("DWORD []")] uint* rgcbToBeSigned, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptEncryptMessage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEncryptMessage([NativeTypeName("PCRYPT_ENCRYPT_MESSAGE_PARA")] CRYPT_ENCRYPT_MESSAGE_PARA* pEncryptPara, [NativeTypeName("DWORD")] uint cRecipientCert, [NativeTypeName("PCCERT_CONTEXT []")] CERT_CONTEXT** rgpRecipientCert, [NativeTypeName("const BYTE *")] byte* pbToBeEncrypted, [NativeTypeName("DWORD")] uint cbToBeEncrypted, [NativeTypeName("BYTE *")] byte* pbEncryptedBlob, [NativeTypeName("DWORD *")] uint* pcbEncryptedBlob);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptDecryptMessage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDecryptMessage([NativeTypeName("PCRYPT_DECRYPT_MESSAGE_PARA")] CRYPT_DECRYPT_MESSAGE_PARA* pDecryptPara, [NativeTypeName("const BYTE *")] byte* pbEncryptedBlob, [NativeTypeName("DWORD")] uint cbEncryptedBlob, [NativeTypeName("BYTE *")] byte* pbDecrypted, [NativeTypeName("DWORD *")] uint* pcbDecrypted, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppXchgCert);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSignAndEncryptMessage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSignAndEncryptMessage([NativeTypeName("PCRYPT_SIGN_MESSAGE_PARA")] CRYPT_SIGN_MESSAGE_PARA* pSignPara, [NativeTypeName("PCRYPT_ENCRYPT_MESSAGE_PARA")] CRYPT_ENCRYPT_MESSAGE_PARA* pEncryptPara, [NativeTypeName("DWORD")] uint cRecipientCert, [NativeTypeName("PCCERT_CONTEXT []")] CERT_CONTEXT** rgpRecipientCert, [NativeTypeName("const BYTE *")] byte* pbToBeSignedAndEncrypted, [NativeTypeName("DWORD")] uint cbToBeSignedAndEncrypted, [NativeTypeName("BYTE *")] byte* pbSignedAndEncryptedBlob, [NativeTypeName("DWORD *")] uint* pcbSignedAndEncryptedBlob);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptDecryptAndVerifyMessageSignature", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDecryptAndVerifyMessageSignature([NativeTypeName("PCRYPT_DECRYPT_MESSAGE_PARA")] CRYPT_DECRYPT_MESSAGE_PARA* pDecryptPara, [NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara, [NativeTypeName("DWORD")] uint dwSignerIndex, [NativeTypeName("const BYTE *")] byte* pbEncryptedBlob, [NativeTypeName("DWORD")] uint cbEncryptedBlob, [NativeTypeName("BYTE *")] byte* pbDecrypted, [NativeTypeName("DWORD *")] uint* pcbDecrypted, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppXchgCert, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptDecodeMessage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptDecodeMessage([NativeTypeName("DWORD")] uint dwMsgTypeFlags, [NativeTypeName("PCRYPT_DECRYPT_MESSAGE_PARA")] CRYPT_DECRYPT_MESSAGE_PARA* pDecryptPara, [NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara, [NativeTypeName("DWORD")] uint dwSignerIndex, [NativeTypeName("const BYTE *")] byte* pbEncodedBlob, [NativeTypeName("DWORD")] uint cbEncodedBlob, [NativeTypeName("DWORD")] uint dwPrevInnerContentType, [NativeTypeName("DWORD *")] uint* pdwMsgType, [NativeTypeName("DWORD *")] uint* pdwInnerContentType, [NativeTypeName("BYTE *")] byte* pbDecoded, [NativeTypeName("DWORD *")] uint* pcbDecoded, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppXchgCert, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptHashMessage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptHashMessage([NativeTypeName("PCRYPT_HASH_MESSAGE_PARA")] CRYPT_HASH_MESSAGE_PARA* pHashPara, [NativeTypeName("BOOL")] int fDetachedHash, [NativeTypeName("DWORD")] uint cToBeHashed, [NativeTypeName("const BYTE *[]")] byte** rgpbToBeHashed, [NativeTypeName("DWORD []")] uint* rgcbToBeHashed, [NativeTypeName("BYTE *")] byte* pbHashedBlob, [NativeTypeName("DWORD *")] uint* pcbHashedBlob, [NativeTypeName("BYTE *")] byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptVerifyMessageHash", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyMessageHash([NativeTypeName("PCRYPT_HASH_MESSAGE_PARA")] CRYPT_HASH_MESSAGE_PARA* pHashPara, [NativeTypeName("BYTE *")] byte* pbHashedBlob, [NativeTypeName("DWORD")] uint cbHashedBlob, [NativeTypeName("BYTE *")] byte* pbToBeHashed, [NativeTypeName("DWORD *")] uint* pcbToBeHashed, [NativeTypeName("BYTE *")] byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptVerifyDetachedMessageHash", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyDetachedMessageHash([NativeTypeName("PCRYPT_HASH_MESSAGE_PARA")] CRYPT_HASH_MESSAGE_PARA* pHashPara, [NativeTypeName("BYTE *")] byte* pbDetachedHashBlob, [NativeTypeName("DWORD")] uint cbDetachedHashBlob, [NativeTypeName("DWORD")] uint cToBeHashed, [NativeTypeName("const BYTE *[]")] byte** rgpbToBeHashed, [NativeTypeName("DWORD []")] uint* rgcbToBeHashed, [NativeTypeName("BYTE *")] byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSignMessageWithKey", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSignMessageWithKey([NativeTypeName("PCRYPT_KEY_SIGN_MESSAGE_PARA")] CRYPT_KEY_SIGN_MESSAGE_PARA* pSignPara, [NativeTypeName("const BYTE *")] byte* pbToBeSigned, [NativeTypeName("DWORD")] uint cbToBeSigned, [NativeTypeName("BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD *")] uint* pcbSignedBlob);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptVerifyMessageSignatureWithKey", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyMessageSignatureWithKey([NativeTypeName("PCRYPT_KEY_VERIFY_MESSAGE_PARA")] CRYPT_KEY_VERIFY_MESSAGE_PARA* pVerifyPara, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKeyInfo, [NativeTypeName("const BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD")] uint cbSignedBlob, [NativeTypeName("BYTE *")] byte* pbDecoded, [NativeTypeName("DWORD *")] uint* pcbDecoded);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertOpenSystemStoreA", ExactSpelling = true)]
        [return: NativeTypeName("HCERTSTORE")]
        public static extern void* CertOpenSystemStoreA([NativeTypeName("HCRYPTPROV_LEGACY")] UIntPtr hProv, [NativeTypeName("LPCSTR")] sbyte* szSubsystemProtocol);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertOpenSystemStoreW", ExactSpelling = true)]
        [return: NativeTypeName("HCERTSTORE")]
        public static extern void* CertOpenSystemStoreW([NativeTypeName("HCRYPTPROV_LEGACY")] UIntPtr hProv, [NativeTypeName("LPCWSTR")] ushort* szSubsystemProtocol);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddEncodedCertificateToSystemStoreA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddEncodedCertificateToSystemStoreA([NativeTypeName("LPCSTR")] sbyte* szCertStoreName, [NativeTypeName("const BYTE *")] byte* pbCertEncoded, [NativeTypeName("DWORD")] uint cbCertEncoded);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddEncodedCertificateToSystemStoreW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertAddEncodedCertificateToSystemStoreW([NativeTypeName("LPCWSTR")] ushort* szCertStoreName, [NativeTypeName("const BYTE *")] byte* pbCertEncoded, [NativeTypeName("DWORD")] uint cbCertEncoded);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindCertsByIssuer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int FindCertsByIssuer([NativeTypeName("PCERT_CHAIN")] CERT_CHAIN* pCertChains, [NativeTypeName("DWORD *")] uint* pcbCertChains, [NativeTypeName("DWORD *")] uint* pcCertChains, [NativeTypeName("BYTE *")] byte* pbEncodedIssuerName, [NativeTypeName("DWORD")] uint cbEncodedIssuerName, [NativeTypeName("LPCWSTR")] ushort* pwszPurpose, [NativeTypeName("DWORD")] uint dwKeySpec);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptQueryObject", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptQueryObject([NativeTypeName("DWORD")] uint dwObjectType, [NativeTypeName("const void *")] void* pvObject, [NativeTypeName("DWORD")] uint dwExpectedContentTypeFlags, [NativeTypeName("DWORD")] uint dwExpectedFormatTypeFlags, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwMsgAndCertEncodingType, [NativeTypeName("DWORD *")] uint* pdwContentType, [NativeTypeName("DWORD *")] uint* pdwFormatType, [NativeTypeName("HCERTSTORE *")] void** phCertStore, [NativeTypeName("HCRYPTMSG *")] void** phMsg, [NativeTypeName("const void **")] void** ppvContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMemAlloc", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CryptMemAlloc([NativeTypeName("ULONG")] uint cbSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMemRealloc", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CryptMemRealloc([NativeTypeName("LPVOID")] void* pv, [NativeTypeName("ULONG")] uint cbSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptMemFree", ExactSpelling = true)]
        public static extern void CryptMemFree([NativeTypeName("LPVOID")] void* pv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptCreateAsyncHandle", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptCreateAsyncHandle([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PHCRYPTASYNC")] IntPtr* phAsync);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSetAsyncParam", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetAsyncParam([NativeTypeName("HCRYPTASYNC")] IntPtr hAsync, [NativeTypeName("LPSTR")] sbyte* pszParamOid, [NativeTypeName("LPVOID")] void* pvParam, [NativeTypeName("PFN_CRYPT_ASYNC_PARAM_FREE_FUNC")] IntPtr* pfnFree);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetAsyncParam", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetAsyncParam([NativeTypeName("HCRYPTASYNC")] IntPtr hAsync, [NativeTypeName("LPSTR")] sbyte* pszParamOid, [NativeTypeName("LPVOID *")] void** ppvParam, [NativeTypeName("PFN_CRYPT_ASYNC_PARAM_FREE_FUNC *")] IntPtr** ppfnFree);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptCloseAsyncHandle", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptCloseAsyncHandle([NativeTypeName("HCRYPTASYNC")] IntPtr hAsync);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptRetrieveObjectByUrlA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptRetrieveObjectByUrlA([NativeTypeName("LPCSTR")] sbyte* pszUrl, [NativeTypeName("LPCSTR")] sbyte* pszObjectOid, [NativeTypeName("DWORD")] uint dwRetrievalFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("LPVOID *")] void** ppvObject, [NativeTypeName("HCRYPTASYNC")] IntPtr hAsyncRetrieve, [NativeTypeName("PCRYPT_CREDENTIALS")] CRYPT_CREDENTIALS* pCredentials, [NativeTypeName("LPVOID")] void* pvVerify, [NativeTypeName("PCRYPT_RETRIEVE_AUX_INFO")] CRYPT_RETRIEVE_AUX_INFO* pAuxInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptRetrieveObjectByUrlW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptRetrieveObjectByUrlW([NativeTypeName("LPCWSTR")] ushort* pszUrl, [NativeTypeName("LPCSTR")] sbyte* pszObjectOid, [NativeTypeName("DWORD")] uint dwRetrievalFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("LPVOID *")] void** ppvObject, [NativeTypeName("HCRYPTASYNC")] IntPtr hAsyncRetrieve, [NativeTypeName("PCRYPT_CREDENTIALS")] CRYPT_CREDENTIALS* pCredentials, [NativeTypeName("LPVOID")] void* pvVerify, [NativeTypeName("PCRYPT_RETRIEVE_AUX_INFO")] CRYPT_RETRIEVE_AUX_INFO* pAuxInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptInstallCancelRetrieval", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptInstallCancelRetrieval([NativeTypeName("PFN_CRYPT_CANCEL_RETRIEVAL")] IntPtr* pfnCancel, [NativeTypeName("const void *")] void* pvArg, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptUninstallCancelRetrieval", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptUninstallCancelRetrieval([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptCancelAsyncRetrieval", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptCancelAsyncRetrieval([NativeTypeName("HCRYPTASYNC")] IntPtr hAsyncRetrieval);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetObjectUrl", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetObjectUrl([NativeTypeName("LPCSTR")] sbyte* pszUrlOid, [NativeTypeName("LPVOID")] void* pvPara, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCRYPT_URL_ARRAY")] CRYPT_URL_ARRAY* pUrlArray, [NativeTypeName("DWORD *")] uint* pcbUrlArray, [NativeTypeName("PCRYPT_URL_INFO")] CRYPT_URL_INFO* pUrlInfo, [NativeTypeName("DWORD *")] uint* pcbUrlInfo, [NativeTypeName("LPVOID")] void* pvReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetTimeValidObject", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetTimeValidObject([NativeTypeName("LPCSTR")] sbyte* pszTimeValidOid, [NativeTypeName("LPVOID")] void* pvPara, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuer, [NativeTypeName("LPFILETIME")] FILETIME* pftValidFor, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("LPVOID *")] void** ppvObject, [NativeTypeName("PCRYPT_CREDENTIALS")] CRYPT_CREDENTIALS* pCredentials, [NativeTypeName("PCRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO")] CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO* pExtraInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptFlushTimeValidObject", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptFlushTimeValidObject([NativeTypeName("LPCSTR")] sbyte* pszFlushTimeValidOid, [NativeTypeName("LPVOID")] void* pvPara, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuer, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* pvReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertCreateSelfSignCertificate", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertCreateSelfSignCertificate([NativeTypeName("HCRYPTPROV_OR_NCRYPT_KEY_HANDLE")] UIntPtr hCryptProvOrNCryptKey, [NativeTypeName("PCERT_NAME_BLOB")] CRYPTOAPI_BLOB* pSubjectIssuerBlob, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCRYPT_KEY_PROV_INFO")] CRYPT_KEY_PROV_INFO* pKeyProvInfo, [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")] CRYPT_ALGORITHM_IDENTIFIER* pSignatureAlgorithm, [NativeTypeName("PSYSTEMTIME")] SYSTEMTIME* pStartTime, [NativeTypeName("PSYSTEMTIME")] SYSTEMTIME* pEndTime, [NativeTypeName("PCERT_EXTENSIONS")] CERT_EXTENSIONS* pExtensions);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptGetKeyIdentifierProperty", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptGetKeyIdentifierProperty([NativeTypeName("const CRYPT_HASH_BLOB *")] CRYPTOAPI_BLOB* pKeyIdentifier, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszComputerName, [NativeTypeName("void *")] void* pvReserved, [NativeTypeName("void *")] void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSetKeyIdentifierProperty", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSetKeyIdentifierProperty([NativeTypeName("const CRYPT_HASH_BLOB *")] CRYPTOAPI_BLOB* pKeyIdentifier, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszComputerName, [NativeTypeName("void *")] void* pvReserved, [NativeTypeName("const void *")] void* pvData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptEnumKeyIdentifierProperties", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptEnumKeyIdentifierProperties([NativeTypeName("const CRYPT_HASH_BLOB *")] CRYPTOAPI_BLOB* pKeyIdentifier, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszComputerName, [NativeTypeName("void *")] void* pvReserved, [NativeTypeName("void *")] void* pvArg, [NativeTypeName("PFN_CRYPT_ENUM_KEYID_PROP")] IntPtr* pfnEnum);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptCreateKeyIdentifierFromCSP", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptCreateKeyIdentifierFromCSP([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszPubKeyOID, [NativeTypeName("const PUBLICKEYSTRUC *")] PUBLICKEYSTRUC* pPubKeyStruc, [NativeTypeName("DWORD")] uint cbPubKeyStruc, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved, [NativeTypeName("BYTE *")] byte* pbHash, [NativeTypeName("DWORD *")] uint* pcbHash);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertCreateCertificateChainEngine", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertCreateCertificateChainEngine([NativeTypeName("PCERT_CHAIN_ENGINE_CONFIG")] CERT_CHAIN_ENGINE_CONFIG* pConfig, [NativeTypeName("HCERTCHAINENGINE *")] IntPtr* phChainEngine);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFreeCertificateChainEngine", ExactSpelling = true)]
        public static extern void CertFreeCertificateChainEngine([NativeTypeName("HCERTCHAINENGINE")] IntPtr hChainEngine);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertResyncCertificateChainEngine", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertResyncCertificateChainEngine([NativeTypeName("HCERTCHAINENGINE")] IntPtr hChainEngine);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertGetCertificateChain", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertGetCertificateChain([NativeTypeName("HCERTCHAINENGINE")] IntPtr hChainEngine, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("LPFILETIME")] FILETIME* pTime, [NativeTypeName("HCERTSTORE")] void* hAdditionalStore, [NativeTypeName("PCERT_CHAIN_PARA")] CERT_CHAIN_PARA* pChainPara, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("PCCERT_CHAIN_CONTEXT *")] CERT_CHAIN_CONTEXT** ppChainContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFreeCertificateChain", ExactSpelling = true)]
        public static extern void CertFreeCertificateChain([NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertDuplicateCertificateChain", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_CHAIN_CONTEXT")]
        public static extern CERT_CHAIN_CONTEXT* CertDuplicateCertificateChain([NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFindChainInStore", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_CHAIN_CONTEXT")]
        public static extern CERT_CHAIN_CONTEXT* CertFindChainInStore([NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwFindFlags, [NativeTypeName("DWORD")] uint dwFindType, [NativeTypeName("const void *")] void* pvFindPara, [NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pPrevChainContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertVerifyCertificateChainPolicy", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertVerifyCertificateChainPolicy([NativeTypeName("LPCSTR")] sbyte* pszPolicyOID, [NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext, [NativeTypeName("PCERT_CHAIN_POLICY_PARA")] CERT_CHAIN_POLICY_PARA* pPolicyPara, [NativeTypeName("PCERT_CHAIN_POLICY_STATUS")] CERT_CHAIN_POLICY_STATUS* pPolicyStatus);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptStringToBinaryA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptStringToBinaryA([NativeTypeName("LPCSTR")] sbyte* pszString, [NativeTypeName("DWORD")] uint cchString, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbBinary, [NativeTypeName("DWORD *")] uint* pcbBinary, [NativeTypeName("DWORD *")] uint* pdwSkip, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptStringToBinaryW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptStringToBinaryW([NativeTypeName("LPCWSTR")] ushort* pszString, [NativeTypeName("DWORD")] uint cchString, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BYTE *")] byte* pbBinary, [NativeTypeName("DWORD *")] uint* pcbBinary, [NativeTypeName("DWORD *")] uint* pdwSkip, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptBinaryToStringA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptBinaryToStringA([NativeTypeName("const BYTE *")] byte* pbBinary, [NativeTypeName("DWORD")] uint cbBinary, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* pszString, [NativeTypeName("DWORD *")] uint* pcchString);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptBinaryToStringW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptBinaryToStringW([NativeTypeName("const BYTE *")] byte* pbBinary, [NativeTypeName("DWORD")] uint cbBinary, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszString, [NativeTypeName("DWORD *")] uint* pcchString);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PFXImportCertStore", ExactSpelling = true)]
        [return: NativeTypeName("HCERTSTORE")]
        public static extern void* PFXImportCertStore([NativeTypeName("CRYPT_DATA_BLOB *")] CRYPTOAPI_BLOB* pPFX, [NativeTypeName("LPCWSTR")] ushort* szPassword, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PFXIsPFXBlob", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PFXIsPFXBlob([NativeTypeName("CRYPT_DATA_BLOB *")] CRYPTOAPI_BLOB* pPFX);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PFXVerifyPassword", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PFXVerifyPassword([NativeTypeName("CRYPT_DATA_BLOB *")] CRYPTOAPI_BLOB* pPFX, [NativeTypeName("LPCWSTR")] ushort* szPassword, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PFXExportCertStoreEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PFXExportCertStoreEx([NativeTypeName("HCERTSTORE")] void* hStore, [NativeTypeName("CRYPT_DATA_BLOB *")] CRYPTOAPI_BLOB* pPFX, [NativeTypeName("LPCWSTR")] ushort* szPassword, [NativeTypeName("void *")] void* pvPara, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PFXExportCertStore", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PFXExportCertStore([NativeTypeName("HCERTSTORE")] void* hStore, [NativeTypeName("CRYPT_DATA_BLOB *")] CRYPTOAPI_BLOB* pPFX, [NativeTypeName("LPCWSTR")] ushort* szPassword, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertOpenServerOcspResponse", ExactSpelling = true)]
        [return: NativeTypeName("HCERT_SERVER_OCSP_RESPONSE")]
        public static extern void* CertOpenServerOcspResponse([NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_SERVER_OCSP_RESPONSE_OPEN_PARA")] CERT_SERVER_OCSP_RESPONSE_OPEN_PARA* pOpenPara);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddRefServerOcspResponse", ExactSpelling = true)]
        public static extern void CertAddRefServerOcspResponse([NativeTypeName("HCERT_SERVER_OCSP_RESPONSE")] void* hServerOcspResponse);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertCloseServerOcspResponse", ExactSpelling = true)]
        public static extern void CertCloseServerOcspResponse([NativeTypeName("HCERT_SERVER_OCSP_RESPONSE")] void* hServerOcspResponse, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertGetServerOcspResponseContext", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_SERVER_OCSP_RESPONSE_CONTEXT")]
        public static extern CERT_SERVER_OCSP_RESPONSE_CONTEXT* CertGetServerOcspResponseContext([NativeTypeName("HCERT_SERVER_OCSP_RESPONSE")] void* hServerOcspResponse, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* pvReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertAddRefServerOcspResponseContext", ExactSpelling = true)]
        public static extern void CertAddRefServerOcspResponseContext([NativeTypeName("PCCERT_SERVER_OCSP_RESPONSE_CONTEXT")] CERT_SERVER_OCSP_RESPONSE_CONTEXT* pServerOcspResponseContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFreeServerOcspResponseContext", ExactSpelling = true)]
        public static extern void CertFreeServerOcspResponseContext([NativeTypeName("PCCERT_SERVER_OCSP_RESPONSE_CONTEXT")] CERT_SERVER_OCSP_RESPONSE_CONTEXT* pServerOcspResponseContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertRetrieveLogoOrBiometricInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertRetrieveLogoOrBiometricInfo([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("LPCSTR")] sbyte* lpszLogoOrBiometricType, [NativeTypeName("DWORD")] uint dwRetrievalFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved, [NativeTypeName("BYTE **")] byte** ppbData, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("LPWSTR *")] ushort** ppwszMimeType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertSelectCertificateChains", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertSelectCertificateChains([NativeTypeName("LPCGUID")] Guid* pSelectionContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCCERT_SELECT_CHAIN_PARA")] CERT_SELECT_CHAIN_PARA* pChainParameters, [NativeTypeName("DWORD")] uint cCriteria, [NativeTypeName("PCCERT_SELECT_CRITERIA")] CERT_SELECT_CRITERIA* rgpCriteria, [NativeTypeName("HCERTSTORE")] void* hStore, [NativeTypeName("PDWORD")] uint* pcSelection, [NativeTypeName("PCCERT_CHAIN_CONTEXT **")] CERT_CHAIN_CONTEXT*** pprgpSelection);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertFreeCertificateChainList", ExactSpelling = true)]
        public static extern void CertFreeCertificateChainList([NativeTypeName("PCCERT_CHAIN_CONTEXT *")] CERT_CHAIN_CONTEXT** prgpSelection);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptRetrieveTimeStamp", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptRetrieveTimeStamp([NativeTypeName("LPCWSTR")] ushort* wszUrl, [NativeTypeName("DWORD")] uint dwRetrievalFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("LPCSTR")] sbyte* pszHashId, [NativeTypeName("const CRYPT_TIMESTAMP_PARA *")] CRYPT_TIMESTAMP_PARA* pPara, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("PCRYPT_TIMESTAMP_CONTEXT *")] CRYPT_TIMESTAMP_CONTEXT** ppTsContext, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppTsSigner, [NativeTypeName("HCERTSTORE *")] void** phStore);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptVerifyTimeStampSignature", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptVerifyTimeStampSignature([NativeTypeName("const BYTE *")] byte* pbTSContentInfo, [NativeTypeName("DWORD")] uint cbTSContentInfo, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("HCERTSTORE")] void* hAdditionalStore, [NativeTypeName("PCRYPT_TIMESTAMP_CONTEXT *")] CRYPT_TIMESTAMP_CONTEXT** ppTsContext, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppTsSigner, [NativeTypeName("HCERTSTORE *")] void** phStore);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CertIsWeakHash", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CertIsWeakHash([NativeTypeName("DWORD")] uint dwHashUseType, [NativeTypeName("LPCWSTR")] ushort* pwszCNGHashAlgid, [NativeTypeName("DWORD")] uint dwChainFlags, [NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pSignerChainContext, [NativeTypeName("LPFILETIME")] FILETIME* pTimeStamp, [NativeTypeName("LPCWSTR")] ushort* pwszFileName);
    }
}
