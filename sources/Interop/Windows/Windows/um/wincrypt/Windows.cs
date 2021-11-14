// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptAcquireContextA(HCRYPTPROV* phProv, [NativeTypeName("LPCSTR")] sbyte* szContainer, [NativeTypeName("LPCSTR")] sbyte* szProvider, [NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptAcquireContextW(HCRYPTPROV* phProv, [NativeTypeName("LPCWSTR")] ushort* szContainer, [NativeTypeName("LPCWSTR")] ushort* szProvider, [NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptReleaseContext(HCRYPTPROV hProv, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptGenKey(HCRYPTPROV hProv, [NativeTypeName("ALG_ID")] uint Algid, [NativeTypeName("DWORD")] uint dwFlags, HCRYPTKEY* phKey);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptDeriveKey(HCRYPTPROV hProv, [NativeTypeName("ALG_ID")] uint Algid, HCRYPTHASH hBaseData, [NativeTypeName("DWORD")] uint dwFlags, HCRYPTKEY* phKey);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptDestroyKey(HCRYPTKEY hKey);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSetKeyParam(HCRYPTKEY hKey, [NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptGetKeyParam(HCRYPTKEY hKey, [NativeTypeName("DWORD")] uint dwParam, byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSetHashParam(HCRYPTHASH hHash, [NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptGetHashParam(HCRYPTHASH hHash, [NativeTypeName("DWORD")] uint dwParam, byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSetProvParam(HCRYPTPROV hProv, [NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptGetProvParam(HCRYPTPROV hProv, [NativeTypeName("DWORD")] uint dwParam, byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptGenRandom(HCRYPTPROV hProv, [NativeTypeName("DWORD")] uint dwLen, byte* pbBuffer);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptGetUserKey(HCRYPTPROV hProv, [NativeTypeName("DWORD")] uint dwKeySpec, HCRYPTKEY* phUserKey);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptExportKey(HCRYPTKEY hKey, HCRYPTKEY hExpKey, [NativeTypeName("DWORD")] uint dwBlobType, [NativeTypeName("DWORD")] uint dwFlags, byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptImportKey(HCRYPTPROV hProv, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint dwDataLen, HCRYPTKEY hPubKey, [NativeTypeName("DWORD")] uint dwFlags, HCRYPTKEY* phKey);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptEncrypt(HCRYPTKEY hKey, HCRYPTHASH hHash, BOOL Final, [NativeTypeName("DWORD")] uint dwFlags, byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen, [NativeTypeName("DWORD")] uint dwBufLen);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptDecrypt(HCRYPTKEY hKey, HCRYPTHASH hHash, BOOL Final, [NativeTypeName("DWORD")] uint dwFlags, byte* pbData, [NativeTypeName("DWORD *")] uint* pdwDataLen);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptCreateHash(HCRYPTPROV hProv, [NativeTypeName("ALG_ID")] uint Algid, HCRYPTKEY hKey, [NativeTypeName("DWORD")] uint dwFlags, HCRYPTHASH* phHash);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptHashData(HCRYPTHASH hHash, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint dwDataLen, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptHashSessionKey(HCRYPTHASH hHash, HCRYPTKEY hKey, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptDestroyHash(HCRYPTHASH hHash);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSignHashA(HCRYPTHASH hHash, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("LPCSTR")] sbyte* szDescription, [NativeTypeName("DWORD")] uint dwFlags, byte* pbSignature, [NativeTypeName("DWORD *")] uint* pdwSigLen);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSignHashW(HCRYPTHASH hHash, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("LPCWSTR")] ushort* szDescription, [NativeTypeName("DWORD")] uint dwFlags, byte* pbSignature, [NativeTypeName("DWORD *")] uint* pdwSigLen);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptVerifySignatureA(HCRYPTHASH hHash, [NativeTypeName("const BYTE *")] byte* pbSignature, [NativeTypeName("DWORD")] uint dwSigLen, HCRYPTKEY hPubKey, [NativeTypeName("LPCSTR")] sbyte* szDescription, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptVerifySignatureW(HCRYPTHASH hHash, [NativeTypeName("const BYTE *")] byte* pbSignature, [NativeTypeName("DWORD")] uint dwSigLen, HCRYPTKEY hPubKey, [NativeTypeName("LPCWSTR")] ushort* szDescription, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSetProviderA([NativeTypeName("LPCSTR")] sbyte* pszProvName, [NativeTypeName("DWORD")] uint dwProvType);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSetProviderW([NativeTypeName("LPCWSTR")] ushort* pszProvName, [NativeTypeName("DWORD")] uint dwProvType);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSetProviderExA([NativeTypeName("LPCSTR")] sbyte* pszProvName, [NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSetProviderExW([NativeTypeName("LPCWSTR")] ushort* pszProvName, [NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptGetDefaultProviderA([NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* pszProvName, [NativeTypeName("DWORD *")] uint* pcbProvName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptGetDefaultProviderW([NativeTypeName("DWORD")] uint dwProvType, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszProvName, [NativeTypeName("DWORD *")] uint* pcbProvName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptEnumProviderTypesA([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwProvType, [NativeTypeName("LPSTR")] sbyte* szTypeName, [NativeTypeName("DWORD *")] uint* pcbTypeName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptEnumProviderTypesW([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwProvType, [NativeTypeName("LPWSTR")] ushort* szTypeName, [NativeTypeName("DWORD *")] uint* pcbTypeName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptEnumProvidersA([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwProvType, [NativeTypeName("LPSTR")] sbyte* szProvName, [NativeTypeName("DWORD *")] uint* pcbProvName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptEnumProvidersW([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwProvType, [NativeTypeName("LPWSTR")] ushort* szProvName, [NativeTypeName("DWORD *")] uint* pcbProvName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptContextAddRef(HCRYPTPROV hProv, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptDuplicateKey(HCRYPTKEY hKey, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, HCRYPTKEY* phKey);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptDuplicateHash(HCRYPTHASH hHash, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD")] uint dwFlags, HCRYPTHASH* phHash);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptFormatObject([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwFormatType, [NativeTypeName("DWORD")] uint dwFormatStrType, void* pFormatStruct, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, void* pbFormat, [NativeTypeName("DWORD *")] uint* pcbFormat);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptEncodeObjectEx([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const void *")] void* pvStructInfo, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCRYPT_ENCODE_PARA")] CRYPT_ENCODE_PARA* pEncodePara, void* pvEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptEncodeObject([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const void *")] void* pvStructInfo, byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptDecodeObjectEx([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCRYPT_DECODE_PARA")] CRYPT_DECODE_PARA* pDecodePara, void* pvStructInfo, [NativeTypeName("DWORD *")] uint* pcbStructInfo);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptDecodeObject([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("DWORD")] uint dwFlags, void* pvStructInfo, [NativeTypeName("DWORD *")] uint* pcbStructInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptInstallOIDFunctionAddress(HMODULE hModule, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("DWORD")] uint cFuncEntry, [NativeTypeName("const CRYPT_OID_FUNC_ENTRY []")] CRYPT_OID_FUNC_ENTRY* rgFuncEntry, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern HCRYPTOIDFUNCSET CryptInitOIDFunctionSet([NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptGetOIDFunctionAddress(HCRYPTOIDFUNCSET hFuncSet, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("DWORD")] uint dwFlags, void** ppvFuncAddr, HCRYPTOIDFUNCADDR* phFuncAddr);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptGetDefaultOIDDllList(HCRYPTOIDFUNCSET hFuncSet, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("WCHAR *")] ushort* pwszDllList, [NativeTypeName("DWORD *")] uint* pcchDllList);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptGetDefaultOIDFunctionAddress(HCRYPTOIDFUNCSET hFuncSet, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCWSTR")] ushort* pwszDll, [NativeTypeName("DWORD")] uint dwFlags, void** ppvFuncAddr, HCRYPTOIDFUNCADDR* phFuncAddr);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptFreeOIDFunctionAddress(HCRYPTOIDFUNCADDR hFuncAddr, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptRegisterOIDFunction([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("LPCWSTR")] ushort* pwszDll, [NativeTypeName("LPCSTR")] sbyte* pszOverrideFuncName);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptUnregisterOIDFunction([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptRegisterDefaultOIDFunction([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPCWSTR")] ushort* pwszDll);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptUnregisterDefaultOIDFunction([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCWSTR")] ushort* pwszDll);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptSetOIDFunctionValue([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("LPCWSTR")] ushort* pwszValueName, [NativeTypeName("DWORD")] uint dwValueType, [NativeTypeName("const BYTE *")] byte* pbValueData, [NativeTypeName("DWORD")] uint cbValueData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptGetOIDFunctionValue([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("LPCWSTR")] ushort* pwszValueName, [NativeTypeName("DWORD *")] uint* pdwValueType, byte* pbValueData, [NativeTypeName("DWORD *")] uint* pcbValueData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptEnumOIDFunction([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("DWORD")] uint dwFlags, void* pvArg, [NativeTypeName("PFN_CRYPT_ENUM_OID_FUNC")] delegate* unmanaged<uint, sbyte*, sbyte*, uint, uint*, ushort**, byte**, uint*, void*, BOOL> pfnEnumOIDFunc);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCCRYPT_OID_INFO")]
        public static extern CRYPT_OID_INFO* CryptFindOIDInfo([NativeTypeName("DWORD")] uint dwKeyType, void* pvKey, [NativeTypeName("DWORD")] uint dwGroupId);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptRegisterOIDInfo([NativeTypeName("PCCRYPT_OID_INFO")] CRYPT_OID_INFO* pInfo, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptUnregisterOIDInfo([NativeTypeName("PCCRYPT_OID_INFO")] CRYPT_OID_INFO* pInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptEnumOIDInfo([NativeTypeName("DWORD")] uint dwGroupId, [NativeTypeName("DWORD")] uint dwFlags, void* pvArg, [NativeTypeName("PFN_CRYPT_ENUM_OID_INFO")] delegate* unmanaged<CRYPT_OID_INFO*, void*, BOOL> pfnEnumOIDInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("LPCWSTR")]
        public static extern ushort* CryptFindLocalizedName([NativeTypeName("LPCWSTR")] ushort* pwszCryptName);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern HCRYPTMSG CryptMsgOpenToEncode([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwMsgType, [NativeTypeName("const void *")] void* pvMsgEncodeInfo, [NativeTypeName("LPSTR")] sbyte* pszInnerContentObjID, [NativeTypeName("PCMSG_STREAM_INFO")] CMSG_STREAM_INFO* pStreamInfo);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CryptMsgCalculateEncodedLength([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwMsgType, [NativeTypeName("const void *")] void* pvMsgEncodeInfo, [NativeTypeName("LPSTR")] sbyte* pszInnerContentObjID, [NativeTypeName("DWORD")] uint cbData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern HCRYPTMSG CryptMsgOpenToDecode([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwMsgType, HCRYPTPROV_LEGACY hCryptProv, [NativeTypeName("PCERT_INFO")] CERT_INFO* pRecipientInfo, [NativeTypeName("PCMSG_STREAM_INFO")] CMSG_STREAM_INFO* pStreamInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern HCRYPTMSG CryptMsgDuplicate(HCRYPTMSG hCryptMsg);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptMsgClose(HCRYPTMSG hCryptMsg);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptMsgUpdate(HCRYPTMSG hCryptMsg, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint cbData, BOOL fFinal);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptMsgGetParam(HCRYPTMSG hCryptMsg, [NativeTypeName("DWORD")] uint dwParamType, [NativeTypeName("DWORD")] uint dwIndex, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptMsgControl(HCRYPTMSG hCryptMsg, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwCtrlType, [NativeTypeName("const void *")] void* pvCtrlPara);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptMsgVerifyCountersignatureEncoded(HCRYPTPROV_LEGACY hCryptProv, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("PBYTE")] byte* pbSignerInfo, [NativeTypeName("DWORD")] uint cbSignerInfo, [NativeTypeName("PBYTE")] byte* pbSignerInfoCountersignature, [NativeTypeName("DWORD")] uint cbSignerInfoCountersignature, [NativeTypeName("PCERT_INFO")] CERT_INFO* pciCountersigner);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptMsgVerifyCountersignatureEncodedEx(HCRYPTPROV_LEGACY hCryptProv, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("PBYTE")] byte* pbSignerInfo, [NativeTypeName("DWORD")] uint cbSignerInfo, [NativeTypeName("PBYTE")] byte* pbSignerInfoCountersignature, [NativeTypeName("DWORD")] uint cbSignerInfoCountersignature, [NativeTypeName("DWORD")] uint dwSignerType, void* pvSigner, [NativeTypeName("DWORD")] uint dwFlags, void* pvExtra);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptMsgCountersign(HCRYPTMSG hCryptMsg, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint cCountersigners, [NativeTypeName("PCMSG_SIGNER_ENCODE_INFO")] CMSG_SIGNER_ENCODE_INFO* rgCountersigners);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptMsgCountersignEncoded([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("PBYTE")] byte* pbSignerInfo, [NativeTypeName("DWORD")] uint cbSignerInfo, [NativeTypeName("DWORD")] uint cCountersigners, [NativeTypeName("PCMSG_SIGNER_ENCODE_INFO")] CMSG_SIGNER_ENCODE_INFO* rgCountersigners, [NativeTypeName("PBYTE")] byte* pbCountersignature, [NativeTypeName("PDWORD")] uint* pcbCountersignature);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern HCERTSTORE CertOpenStore([NativeTypeName("LPCSTR")] sbyte* lpszStoreProvider, [NativeTypeName("DWORD")] uint dwEncodingType, HCRYPTPROV_LEGACY hCryptProv, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvPara);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern HCERTSTORE CertDuplicateStore(HCERTSTORE hCertStore);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertSaveStore(HCERTSTORE hCertStore, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("DWORD")] uint dwSaveAs, [NativeTypeName("DWORD")] uint dwSaveTo, void* pvSaveToPara, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertCloseStore(HCERTSTORE hCertStore, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertGetSubjectCertificateFromStore(HCERTSTORE hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertEnumCertificatesInStore(HCERTSTORE hCertStore, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pPrevCertContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertFindCertificateInStore(HCERTSTORE hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwFindFlags, [NativeTypeName("DWORD")] uint dwFindType, [NativeTypeName("const void *")] void* pvFindPara, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pPrevCertContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertGetIssuerCertificateFromStore(HCERTSTORE hCertStore, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pSubjectContext, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pPrevIssuerContext, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertVerifySubjectCertificateContext([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pSubject, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuer, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertDuplicateCertificateContext([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertCreateCertificateContext([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCertEncoded, [NativeTypeName("DWORD")] uint cbCertEncoded);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertFreeCertificateContext([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertSetCertificateContextProperty([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertGetCertificateContextProperty([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwPropId, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertEnumCertificateContextProperties([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwPropId);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertCreateCTLEntryFromCertificateContextProperties([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint cOptAttr, [NativeTypeName("PCRYPT_ATTRIBUTE")] CRYPT_ATTRIBUTE* rgOptAttr, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved, [NativeTypeName("PCTL_ENTRY")] CTL_ENTRY* pCtlEntry, [NativeTypeName("DWORD *")] uint* pcbCtlEntry);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertSetCertificateContextPropertiesFromCTLEntry([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("PCTL_ENTRY")] CTL_ENTRY* pCtlEntry, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCRL_CONTEXT")]
        public static extern CRL_CONTEXT* CertGetCRLFromStore(HCERTSTORE hCertStore, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuerContext, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pPrevCrlContext, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCRL_CONTEXT")]
        public static extern CRL_CONTEXT* CertEnumCRLsInStore(HCERTSTORE hCertStore, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pPrevCrlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCRL_CONTEXT")]
        public static extern CRL_CONTEXT* CertFindCRLInStore(HCERTSTORE hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwFindFlags, [NativeTypeName("DWORD")] uint dwFindType, [NativeTypeName("const void *")] void* pvFindPara, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pPrevCrlContext);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCCRL_CONTEXT")]
        public static extern CRL_CONTEXT* CertDuplicateCRLContext([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCRL_CONTEXT")]
        public static extern CRL_CONTEXT* CertCreateCRLContext([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCrlEncoded, [NativeTypeName("DWORD")] uint cbCrlEncoded);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertFreeCRLContext([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertSetCRLContextProperty([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertGetCRLContextProperty([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwPropId, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertEnumCRLContextProperties([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwPropId);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertFindCertificateInCRL([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved, [NativeTypeName("PCRL_ENTRY *")] CRL_ENTRY** ppCrlEntry);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertIsValidCRLForCertificate([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrl, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertAddEncodedCertificateToStore(HCERTSTORE hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCertEncoded, [NativeTypeName("DWORD")] uint cbCertEncoded, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppCertContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertAddCertificateContextToStore(HCERTSTORE hCertStore, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppStoreContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertAddSerializedElementToStore(HCERTSTORE hCertStore, [NativeTypeName("const BYTE *")] byte* pbElement, [NativeTypeName("DWORD")] uint cbElement, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwContextTypeFlags, [NativeTypeName("DWORD *")] uint* pdwContextType, [NativeTypeName("const void **")] void** ppvContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertDeleteCertificateFromStore([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertAddEncodedCRLToStore(HCERTSTORE hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCrlEncoded, [NativeTypeName("DWORD")] uint cbCrlEncoded, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCRL_CONTEXT *")] CRL_CONTEXT** ppCrlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertAddCRLContextToStore(HCERTSTORE hCertStore, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCRL_CONTEXT *")] CRL_CONTEXT** ppStoreContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertDeleteCRLFromStore([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertSerializeCertificateStoreElement([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwFlags, byte* pbElement, [NativeTypeName("DWORD *")] uint* pcbElement);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertSerializeCRLStoreElement([NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwFlags, byte* pbElement, [NativeTypeName("DWORD *")] uint* pcbElement);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCCTL_CONTEXT")]
        public static extern CTL_CONTEXT* CertDuplicateCTLContext([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCTL_CONTEXT")]
        public static extern CTL_CONTEXT* CertCreateCTLContext([NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCtlEncoded, [NativeTypeName("DWORD")] uint cbCtlEncoded);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertFreeCTLContext([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertSetCTLContextProperty([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertGetCTLContextProperty([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwPropId, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertEnumCTLContextProperties([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwPropId);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCTL_CONTEXT")]
        public static extern CTL_CONTEXT* CertEnumCTLsInStore(HCERTSTORE hCertStore, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pPrevCtlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCTL_ENTRY")]
        public static extern CTL_ENTRY* CertFindSubjectInCTL([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("DWORD")] uint dwSubjectType, void* pvSubject, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCTL_CONTEXT")]
        public static extern CTL_CONTEXT* CertFindCTLInStore(HCERTSTORE hCertStore, [NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType, [NativeTypeName("DWORD")] uint dwFindFlags, [NativeTypeName("DWORD")] uint dwFindType, [NativeTypeName("const void *")] void* pvFindPara, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pPrevCtlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertAddEncodedCTLToStore(HCERTSTORE hCertStore, [NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbCtlEncoded, [NativeTypeName("DWORD")] uint cbCtlEncoded, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCTL_CONTEXT *")] CTL_CONTEXT** ppCtlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertAddCTLContextToStore(HCERTSTORE hCertStore, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCTL_CONTEXT *")] CTL_CONTEXT** ppStoreContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertSerializeCTLStoreElement([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwFlags, byte* pbElement, [NativeTypeName("DWORD *")] uint* pcbElement);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertDeleteCTLFromStore([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertAddCertificateLinkToStore(HCERTSTORE hCertStore, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppStoreContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertAddCRLLinkToStore(HCERTSTORE hCertStore, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCRL_CONTEXT *")] CRL_CONTEXT** ppStoreContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertAddCTLLinkToStore(HCERTSTORE hCertStore, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwAddDisposition, [NativeTypeName("PCCTL_CONTEXT *")] CTL_CONTEXT** ppStoreContext);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertAddStoreToCollection(HCERTSTORE hCollectionStore, HCERTSTORE hSiblingStore, [NativeTypeName("DWORD")] uint dwUpdateFlags, [NativeTypeName("DWORD")] uint dwPriority);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertRemoveStoreFromCollection(HCERTSTORE hCollectionStore, HCERTSTORE hSiblingStore);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertControlStore(HCERTSTORE hCertStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwCtrlType, [NativeTypeName("const void *")] void* pvCtrlPara);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertSetStoreProperty(HCERTSTORE hCertStore, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertGetStoreProperty(HCERTSTORE hCertStore, [NativeTypeName("DWORD")] uint dwPropId, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("const void *")]
        public static extern void* CertCreateContext([NativeTypeName("DWORD")] uint dwContextType, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_CREATE_CONTEXT_PARA")] CERT_CREATE_CONTEXT_PARA* pCreatePara);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertRegisterSystemStore([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_SYSTEM_STORE_INFO")] CERT_SYSTEM_STORE_INFO* pStoreInfo, void* pvReserved);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertRegisterPhysicalStore([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszStoreName, [NativeTypeName("PCERT_PHYSICAL_STORE_INFO")] CERT_PHYSICAL_STORE_INFO* pStoreInfo, void* pvReserved);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertUnregisterSystemStore([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertUnregisterPhysicalStore([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszStoreName);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertEnumSystemStoreLocation([NativeTypeName("DWORD")] uint dwFlags, void* pvArg, [NativeTypeName("PFN_CERT_ENUM_SYSTEM_STORE_LOCATION")] delegate* unmanaged<ushort*, uint, void*, void*, BOOL> pfnEnum);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertEnumSystemStore([NativeTypeName("DWORD")] uint dwFlags, void* pvSystemStoreLocationPara, void* pvArg, [NativeTypeName("PFN_CERT_ENUM_SYSTEM_STORE")] delegate* unmanaged<void*, uint, CERT_SYSTEM_STORE_INFO*, void*, void*, BOOL> pfnEnum);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertEnumPhysicalStore([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags, void* pvArg, [NativeTypeName("PFN_CERT_ENUM_PHYSICAL_STORE")] delegate* unmanaged<void*, uint, ushort*, CERT_PHYSICAL_STORE_INFO*, void*, void*, BOOL> pfnEnum);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertGetEnhancedKeyUsage([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_ENHKEY_USAGE")] CTL_USAGE* pUsage, [NativeTypeName("DWORD *")] uint* pcbUsage);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertSetEnhancedKeyUsage([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("PCERT_ENHKEY_USAGE")] CTL_USAGE* pUsage);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertAddEnhancedKeyUsageIdentifier([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("LPCSTR")] sbyte* pszUsageIdentifier);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertRemoveEnhancedKeyUsageIdentifier([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("LPCSTR")] sbyte* pszUsageIdentifier);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertGetValidUsages([NativeTypeName("DWORD")] uint cCerts, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** rghCerts, int* cNumOIDs, [NativeTypeName("LPSTR *")] sbyte** rghOIDs, [NativeTypeName("DWORD *")] uint* pcbOIDs);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptMsgGetAndVerifySigner(HCRYPTMSG hCryptMsg, [NativeTypeName("DWORD")] uint cSignerStore, HCERTSTORE* rghSignerStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSigner, [NativeTypeName("DWORD *")] uint* pdwSignerIndex);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptMsgSignCTL([NativeTypeName("DWORD")] uint dwMsgEncodingType, byte* pbCtlContent, [NativeTypeName("DWORD")] uint cbCtlContent, [NativeTypeName("PCMSG_SIGNED_ENCODE_INFO")] CMSG_SIGNED_ENCODE_INFO* pSignInfo, [NativeTypeName("DWORD")] uint dwFlags, byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptMsgEncodeAndSignCTL([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("PCTL_INFO")] CTL_INFO* pCtlInfo, [NativeTypeName("PCMSG_SIGNED_ENCODE_INFO")] CMSG_SIGNED_ENCODE_INFO* pSignInfo, [NativeTypeName("DWORD")] uint dwFlags, byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertFindSubjectInSortedCTL([NativeTypeName("PCRYPT_DATA_BLOB")] CRYPT_DATA_BLOB* pSubjectIdentifier, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved, [NativeTypeName("PCRYPT_DER_BLOB")] CRYPT_DATA_BLOB* pEncodedAttributes);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertEnumSubjectInSortedCTL([NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext, void** ppvNextSubject, [NativeTypeName("PCRYPT_DER_BLOB")] CRYPT_DATA_BLOB* pSubjectIdentifier, [NativeTypeName("PCRYPT_DER_BLOB")] CRYPT_DATA_BLOB* pEncodedAttributes);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertVerifyCTLUsage([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("DWORD")] uint dwSubjectType, void* pvSubject, [NativeTypeName("PCTL_USAGE")] CTL_USAGE* pSubjectUsage, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCTL_VERIFY_USAGE_PARA")] CTL_VERIFY_USAGE_PARA* pVerifyUsagePara, [NativeTypeName("PCTL_VERIFY_USAGE_STATUS")] CTL_VERIFY_USAGE_STATUS* pVerifyUsageStatus);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertVerifyRevocation([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("DWORD")] uint dwRevType, [NativeTypeName("DWORD")] uint cContext, [NativeTypeName("PVOID []")] void** rgpvContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_REVOCATION_PARA")] CERT_REVOCATION_PARA* pRevPara, [NativeTypeName("PCERT_REVOCATION_STATUS")] CERT_REVOCATION_STATUS* pRevStatus);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertCompareIntegerBlob([NativeTypeName("PCRYPT_INTEGER_BLOB")] CRYPT_DATA_BLOB* pInt1, [NativeTypeName("PCRYPT_INTEGER_BLOB")] CRYPT_DATA_BLOB* pInt2);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertCompareCertificate([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId1, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId2);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertCompareCertificateName([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pCertName1, [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pCertName2);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertIsRDNAttrsInCertificateName([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pCertName, [NativeTypeName("PCERT_RDN")] CERT_RDN* pRDN);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertComparePublicKeyInfo([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey1, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey2);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertGetPublicKeyLength([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptVerifyCertificateSignature(HCRYPTPROV_LEGACY hCryptProv, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptVerifyCertificateSignatureEx(HCRYPTPROV_LEGACY hCryptProv, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwSubjectType, void* pvSubject, [NativeTypeName("DWORD")] uint dwIssuerType, void* pvIssuer, [NativeTypeName("DWORD")] uint dwFlags, void* pvExtra);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertIsStrongHashToSign([NativeTypeName("PCCERT_STRONG_SIGN_PARA")] CERT_STRONG_SIGN_PARA* pStrongSignPara, [NativeTypeName("LPCWSTR")] ushort* pwszCNGHashAlgid, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pSigningCert);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptHashToBeSigned(HCRYPTPROV_LEGACY hCryptProv, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptHashCertificate(HCRYPTPROV_LEGACY hCryptProv, [NativeTypeName("ALG_ID")] uint Algid, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptHashCertificate2([NativeTypeName("LPCWSTR")] ushort* pwszCNGHashAlgid, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved, [NativeTypeName("const BYTE *")] byte* pbEncoded, [NativeTypeName("DWORD")] uint cbEncoded, byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSignCertificate(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE hCryptProvOrNCryptKey, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("const BYTE *")] byte* pbEncodedToBeSigned, [NativeTypeName("DWORD")] uint cbEncodedToBeSigned, [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")] CRYPT_ALGORITHM_IDENTIFIER* pSignatureAlgorithm, [NativeTypeName("const void *")] void* pvHashAuxInfo, byte* pbSignature, [NativeTypeName("DWORD *")] uint* pcbSignature);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSignAndEncodeCertificate(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE hCryptProvOrNCryptKey, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* lpszStructType, [NativeTypeName("const void *")] void* pvStructInfo, [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")] CRYPT_ALGORITHM_IDENTIFIER* pSignatureAlgorithm, [NativeTypeName("const void *")] void* pvHashAuxInfo, byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int CertVerifyTimeValidity([NativeTypeName("LPFILETIME")] FILETIME* pTimeToVerify, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int CertVerifyCRLTimeValidity([NativeTypeName("LPFILETIME")] FILETIME* pTimeToVerify, [NativeTypeName("PCRL_INFO")] CRL_INFO* pCrlInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertVerifyValidityNesting([NativeTypeName("PCERT_INFO")] CERT_INFO* pSubjectInfo, [NativeTypeName("PCERT_INFO")] CERT_INFO* pIssuerInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertVerifyCRLRevocation([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId, [NativeTypeName("DWORD")] uint cCrlInfo, [NativeTypeName("PCRL_INFO []")] CRL_INFO** rgpCrlInfo);

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
        public static extern BOOL CertGetIntendedKeyUsage([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertInfo, byte* pbKeyUsage, [NativeTypeName("DWORD")] uint cbKeyUsage);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptInstallDefaultContext(HCRYPTPROV hCryptProv, [NativeTypeName("DWORD")] uint dwDefaultType, [NativeTypeName("const void *")] void* pvDefaultPara, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved, HCRYPTDEFAULTCONTEXT* phDefaultContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptUninstallDefaultContext(HCRYPTDEFAULTCONTEXT hDefaultContext, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptExportPublicKeyInfo(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE hCryptProvOrNCryptKey, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("DWORD *")] uint* pcbInfo);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptExportPublicKeyInfoEx(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE hCryptProvOrNCryptKey, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPSTR")] sbyte* pszPublicKeyObjId, [NativeTypeName("DWORD")] uint dwFlags, void* pvAuxInfo, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("DWORD *")] uint* pcbInfo);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptExportPublicKeyInfoFromBCryptKeyHandle([NativeTypeName("BCRYPT_KEY_HANDLE")] void* hBCryptKey, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPSTR")] sbyte* pszPublicKeyObjId, [NativeTypeName("DWORD")] uint dwFlags, void* pvAuxInfo, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("DWORD *")] uint* pcbInfo);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptImportPublicKeyInfo(HCRYPTPROV hCryptProv, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, HCRYPTKEY* phKey);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptImportPublicKeyInfoEx(HCRYPTPROV hCryptProv, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("ALG_ID")] uint aiKeyAlg, [NativeTypeName("DWORD")] uint dwFlags, void* pvAuxInfo, HCRYPTKEY* phKey);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptImportPublicKeyInfoEx2([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("DWORD")] uint dwFlags, void* pvAuxInfo, [NativeTypeName("BCRYPT_KEY_HANDLE *")] void** phKey);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptAcquireCertificatePrivateKey([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert, [NativeTypeName("DWORD")] uint dwFlags, void* pvParameters, HCRYPTPROV_OR_NCRYPT_KEY_HANDLE* phCryptProvOrNCryptKey, [NativeTypeName("DWORD *")] uint* pdwKeySpec, BOOL* pfCallerFreeProvOrNCryptKey);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptFindCertificateKeyProvInfo([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptImportPKCS8(CRYPT_PKCS8_IMPORT_PARAMS sPrivateKeyAndParams, [NativeTypeName("DWORD")] uint dwFlags, HCRYPTPROV* phCryptProv, void* pvAuxInfo);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptExportPKCS8(HCRYPTPROV hCryptProv, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("LPSTR")] sbyte* pszPrivateKeyObjId, [NativeTypeName("DWORD")] uint dwFlags, void* pvAuxInfo, byte* pbPrivateKeyBlob, [NativeTypeName("DWORD *")] uint* pcbPrivateKeyBlob);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptHashPublicKeyInfo(HCRYPTPROV_LEGACY hCryptProv, [NativeTypeName("ALG_ID")] uint Algid, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

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
        public static extern BOOL CertStrToNameA([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszX500, [NativeTypeName("DWORD")] uint dwStrType, void* pvReserved, byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded, [NativeTypeName("LPCSTR *")] sbyte** ppszError);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertStrToNameW([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCWSTR")] ushort* pszX500, [NativeTypeName("DWORD")] uint dwStrType, void* pvReserved, byte* pbEncoded, [NativeTypeName("DWORD *")] uint* pcbEncoded, [NativeTypeName("LPCWSTR *")] ushort** ppszError);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertGetNameStringA([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("DWORD")] uint dwFlags, void* pvTypePara, [NativeTypeName("LPSTR")] sbyte* pszNameString, [NativeTypeName("DWORD")] uint cchNameString);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CertGetNameStringW([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("DWORD")] uint dwFlags, void* pvTypePara, [NativeTypeName("LPWSTR")] ushort* pszNameString, [NativeTypeName("DWORD")] uint cchNameString);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSignMessage([NativeTypeName("PCRYPT_SIGN_MESSAGE_PARA")] CRYPT_SIGN_MESSAGE_PARA* pSignPara, BOOL fDetachedSignature, [NativeTypeName("DWORD")] uint cToBeSigned, [NativeTypeName("const BYTE *[]")] byte** rgpbToBeSigned, [NativeTypeName("DWORD []")] uint* rgcbToBeSigned, byte* pbSignedBlob, [NativeTypeName("DWORD *")] uint* pcbSignedBlob);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptVerifyMessageSignature([NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara, [NativeTypeName("DWORD")] uint dwSignerIndex, [NativeTypeName("const BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD")] uint cbSignedBlob, byte* pbDecoded, [NativeTypeName("DWORD *")] uint* pcbDecoded, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LONG")]
        public static extern int CryptGetMessageSignerCount([NativeTypeName("DWORD")] uint dwMsgEncodingType, [NativeTypeName("const BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD")] uint cbSignedBlob);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern HCERTSTORE CryptGetMessageCertificates([NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType, HCRYPTPROV_LEGACY hCryptProv, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD")] uint cbSignedBlob);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptVerifyDetachedMessageSignature([NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara, [NativeTypeName("DWORD")] uint dwSignerIndex, [NativeTypeName("const BYTE *")] byte* pbDetachedSignBlob, [NativeTypeName("DWORD")] uint cbDetachedSignBlob, [NativeTypeName("DWORD")] uint cToBeSigned, [NativeTypeName("const BYTE *[]")] byte** rgpbToBeSigned, [NativeTypeName("DWORD []")] uint* rgcbToBeSigned, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptEncryptMessage([NativeTypeName("PCRYPT_ENCRYPT_MESSAGE_PARA")] CRYPT_ENCRYPT_MESSAGE_PARA* pEncryptPara, [NativeTypeName("DWORD")] uint cRecipientCert, [NativeTypeName("PCCERT_CONTEXT []")] CERT_CONTEXT** rgpRecipientCert, [NativeTypeName("const BYTE *")] byte* pbToBeEncrypted, [NativeTypeName("DWORD")] uint cbToBeEncrypted, byte* pbEncryptedBlob, [NativeTypeName("DWORD *")] uint* pcbEncryptedBlob);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptDecryptMessage([NativeTypeName("PCRYPT_DECRYPT_MESSAGE_PARA")] CRYPT_DECRYPT_MESSAGE_PARA* pDecryptPara, [NativeTypeName("const BYTE *")] byte* pbEncryptedBlob, [NativeTypeName("DWORD")] uint cbEncryptedBlob, byte* pbDecrypted, [NativeTypeName("DWORD *")] uint* pcbDecrypted, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppXchgCert);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSignAndEncryptMessage([NativeTypeName("PCRYPT_SIGN_MESSAGE_PARA")] CRYPT_SIGN_MESSAGE_PARA* pSignPara, [NativeTypeName("PCRYPT_ENCRYPT_MESSAGE_PARA")] CRYPT_ENCRYPT_MESSAGE_PARA* pEncryptPara, [NativeTypeName("DWORD")] uint cRecipientCert, [NativeTypeName("PCCERT_CONTEXT []")] CERT_CONTEXT** rgpRecipientCert, [NativeTypeName("const BYTE *")] byte* pbToBeSignedAndEncrypted, [NativeTypeName("DWORD")] uint cbToBeSignedAndEncrypted, byte* pbSignedAndEncryptedBlob, [NativeTypeName("DWORD *")] uint* pcbSignedAndEncryptedBlob);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptDecryptAndVerifyMessageSignature([NativeTypeName("PCRYPT_DECRYPT_MESSAGE_PARA")] CRYPT_DECRYPT_MESSAGE_PARA* pDecryptPara, [NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara, [NativeTypeName("DWORD")] uint dwSignerIndex, [NativeTypeName("const BYTE *")] byte* pbEncryptedBlob, [NativeTypeName("DWORD")] uint cbEncryptedBlob, byte* pbDecrypted, [NativeTypeName("DWORD *")] uint* pcbDecrypted, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppXchgCert, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptDecodeMessage([NativeTypeName("DWORD")] uint dwMsgTypeFlags, [NativeTypeName("PCRYPT_DECRYPT_MESSAGE_PARA")] CRYPT_DECRYPT_MESSAGE_PARA* pDecryptPara, [NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara, [NativeTypeName("DWORD")] uint dwSignerIndex, [NativeTypeName("const BYTE *")] byte* pbEncodedBlob, [NativeTypeName("DWORD")] uint cbEncodedBlob, [NativeTypeName("DWORD")] uint dwPrevInnerContentType, [NativeTypeName("DWORD *")] uint* pdwMsgType, [NativeTypeName("DWORD *")] uint* pdwInnerContentType, byte* pbDecoded, [NativeTypeName("DWORD *")] uint* pcbDecoded, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppXchgCert, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptHashMessage([NativeTypeName("PCRYPT_HASH_MESSAGE_PARA")] CRYPT_HASH_MESSAGE_PARA* pHashPara, BOOL fDetachedHash, [NativeTypeName("DWORD")] uint cToBeHashed, [NativeTypeName("const BYTE *[]")] byte** rgpbToBeHashed, [NativeTypeName("DWORD []")] uint* rgcbToBeHashed, byte* pbHashedBlob, [NativeTypeName("DWORD *")] uint* pcbHashedBlob, byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptVerifyMessageHash([NativeTypeName("PCRYPT_HASH_MESSAGE_PARA")] CRYPT_HASH_MESSAGE_PARA* pHashPara, byte* pbHashedBlob, [NativeTypeName("DWORD")] uint cbHashedBlob, byte* pbToBeHashed, [NativeTypeName("DWORD *")] uint* pcbToBeHashed, byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptVerifyDetachedMessageHash([NativeTypeName("PCRYPT_HASH_MESSAGE_PARA")] CRYPT_HASH_MESSAGE_PARA* pHashPara, byte* pbDetachedHashBlob, [NativeTypeName("DWORD")] uint cbDetachedHashBlob, [NativeTypeName("DWORD")] uint cToBeHashed, [NativeTypeName("const BYTE *[]")] byte** rgpbToBeHashed, [NativeTypeName("DWORD []")] uint* rgcbToBeHashed, byte* pbComputedHash, [NativeTypeName("DWORD *")] uint* pcbComputedHash);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSignMessageWithKey([NativeTypeName("PCRYPT_KEY_SIGN_MESSAGE_PARA")] CRYPT_KEY_SIGN_MESSAGE_PARA* pSignPara, [NativeTypeName("const BYTE *")] byte* pbToBeSigned, [NativeTypeName("DWORD")] uint cbToBeSigned, byte* pbSignedBlob, [NativeTypeName("DWORD *")] uint* pcbSignedBlob);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptVerifyMessageSignatureWithKey([NativeTypeName("PCRYPT_KEY_VERIFY_MESSAGE_PARA")] CRYPT_KEY_VERIFY_MESSAGE_PARA* pVerifyPara, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKeyInfo, [NativeTypeName("const BYTE *")] byte* pbSignedBlob, [NativeTypeName("DWORD")] uint cbSignedBlob, byte* pbDecoded, [NativeTypeName("DWORD *")] uint* pcbDecoded);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern HCERTSTORE CertOpenSystemStoreA(HCRYPTPROV_LEGACY hProv, [NativeTypeName("LPCSTR")] sbyte* szSubsystemProtocol);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern HCERTSTORE CertOpenSystemStoreW(HCRYPTPROV_LEGACY hProv, [NativeTypeName("LPCWSTR")] ushort* szSubsystemProtocol);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertAddEncodedCertificateToSystemStoreA([NativeTypeName("LPCSTR")] sbyte* szCertStoreName, [NativeTypeName("const BYTE *")] byte* pbCertEncoded, [NativeTypeName("DWORD")] uint cbCertEncoded);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertAddEncodedCertificateToSystemStoreW([NativeTypeName("LPCWSTR")] ushort* szCertStoreName, [NativeTypeName("const BYTE *")] byte* pbCertEncoded, [NativeTypeName("DWORD")] uint cbCertEncoded);

        [DllImport("wintrust", ExactSpelling = true)]
        public static extern HRESULT FindCertsByIssuer([NativeTypeName("PCERT_CHAIN")] CERT_CHAIN* pCertChains, [NativeTypeName("DWORD *")] uint* pcbCertChains, [NativeTypeName("DWORD *")] uint* pcCertChains, byte* pbEncodedIssuerName, [NativeTypeName("DWORD")] uint cbEncodedIssuerName, [NativeTypeName("LPCWSTR")] ushort* pwszPurpose, [NativeTypeName("DWORD")] uint dwKeySpec);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptQueryObject([NativeTypeName("DWORD")] uint dwObjectType, [NativeTypeName("const void *")] void* pvObject, [NativeTypeName("DWORD")] uint dwExpectedContentTypeFlags, [NativeTypeName("DWORD")] uint dwExpectedFormatTypeFlags, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwMsgAndCertEncodingType, [NativeTypeName("DWORD *")] uint* pdwContentType, [NativeTypeName("DWORD *")] uint* pdwFormatType, HCERTSTORE* phCertStore, HCRYPTMSG* phMsg, [NativeTypeName("const void **")] void** ppvContext);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CryptMemAlloc([NativeTypeName("ULONG")] uint cbSize);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CryptMemRealloc([NativeTypeName("LPVOID")] void* pv, [NativeTypeName("ULONG")] uint cbSize);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CryptMemFree([NativeTypeName("LPVOID")] void* pv);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptCreateAsyncHandle([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PHCRYPTASYNC")] HANDLE* phAsync);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptGetAsyncParam(HCRYPTASYNC hAsync, [NativeTypeName("LPSTR")] sbyte* pszParamOid, [NativeTypeName("LPVOID *")] void** ppvParam, [NativeTypeName("PFN_CRYPT_ASYNC_PARAM_FREE_FUNC *")] delegate* unmanaged<sbyte*, void*, void>* ppfnFree);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptCloseAsyncHandle(HCRYPTASYNC hAsync);

        [DllImport("cryptnet", ExactSpelling = true)]
        public static extern BOOL CryptRetrieveObjectByUrlA([NativeTypeName("LPCSTR")] sbyte* pszUrl, [NativeTypeName("LPCSTR")] sbyte* pszObjectOid, [NativeTypeName("DWORD")] uint dwRetrievalFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("LPVOID *")] void** ppvObject, HCRYPTASYNC hAsyncRetrieve, [NativeTypeName("PCRYPT_CREDENTIALS")] CRYPT_CREDENTIALS* pCredentials, [NativeTypeName("LPVOID")] void* pvVerify, [NativeTypeName("PCRYPT_RETRIEVE_AUX_INFO")] CRYPT_RETRIEVE_AUX_INFO* pAuxInfo);

        [DllImport("cryptnet", ExactSpelling = true)]
        public static extern BOOL CryptRetrieveObjectByUrlW([NativeTypeName("LPCWSTR")] ushort* pszUrl, [NativeTypeName("LPCSTR")] sbyte* pszObjectOid, [NativeTypeName("DWORD")] uint dwRetrievalFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("LPVOID *")] void** ppvObject, HCRYPTASYNC hAsyncRetrieve, [NativeTypeName("PCRYPT_CREDENTIALS")] CRYPT_CREDENTIALS* pCredentials, [NativeTypeName("LPVOID")] void* pvVerify, [NativeTypeName("PCRYPT_RETRIEVE_AUX_INFO")] CRYPT_RETRIEVE_AUX_INFO* pAuxInfo);

        [DllImport("cryptnet", ExactSpelling = true)]
        public static extern BOOL CryptInstallCancelRetrieval([NativeTypeName("PFN_CRYPT_CANCEL_RETRIEVAL")] delegate* unmanaged<uint, void*, BOOL> pfnCancel, [NativeTypeName("const void *")] void* pvArg, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved);

        [DllImport("cryptnet", ExactSpelling = true)]
        public static extern BOOL CryptUninstallCancelRetrieval([NativeTypeName("DWORD")] uint dwFlags, void* pvReserved);

        [DllImport("cryptnet", ExactSpelling = true)]
        public static extern BOOL CryptCancelAsyncRetrieval(HCRYPTASYNC hAsyncRetrieval);

        [DllImport("cryptnet", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptGetObjectUrl([NativeTypeName("LPCSTR")] sbyte* pszUrlOid, [NativeTypeName("LPVOID")] void* pvPara, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCRYPT_URL_ARRAY")] CRYPT_URL_ARRAY* pUrlArray, [NativeTypeName("DWORD *")] uint* pcbUrlArray, [NativeTypeName("PCRYPT_URL_INFO")] CRYPT_URL_INFO* pUrlInfo, [NativeTypeName("DWORD *")] uint* pcbUrlInfo, [NativeTypeName("LPVOID")] void* pvReserved);

        [DllImport("cryptnet", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptGetTimeValidObject([NativeTypeName("LPCSTR")] sbyte* pszTimeValidOid, [NativeTypeName("LPVOID")] void* pvPara, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuer, [NativeTypeName("LPFILETIME")] FILETIME* pftValidFor, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("LPVOID *")] void** ppvObject, [NativeTypeName("PCRYPT_CREDENTIALS")] CRYPT_CREDENTIALS* pCredentials, [NativeTypeName("PCRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO")] CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO* pExtraInfo);

        [DllImport("cryptnet", ExactSpelling = true)]
        public static extern BOOL CryptFlushTimeValidObject([NativeTypeName("LPCSTR")] sbyte* pszFlushTimeValidOid, [NativeTypeName("LPVOID")] void* pvPara, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuer, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* pvReserved);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PCCERT_CONTEXT")]
        public static extern CERT_CONTEXT* CertCreateSelfSignCertificate(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE hCryptProvOrNCryptKey, [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pSubjectIssuerBlob, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCRYPT_KEY_PROV_INFO")] CRYPT_KEY_PROV_INFO* pKeyProvInfo, [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")] CRYPT_ALGORITHM_IDENTIFIER* pSignatureAlgorithm, [NativeTypeName("PSYSTEMTIME")] SYSTEMTIME* pStartTime, [NativeTypeName("PSYSTEMTIME")] SYSTEMTIME* pEndTime, [NativeTypeName("PCERT_EXTENSIONS")] CERT_EXTENSIONS* pExtensions);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptGetKeyIdentifierProperty([NativeTypeName("const CRYPT_HASH_BLOB *")] CRYPT_DATA_BLOB* pKeyIdentifier, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszComputerName, void* pvReserved, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSetKeyIdentifierProperty([NativeTypeName("const CRYPT_HASH_BLOB *")] CRYPT_DATA_BLOB* pKeyIdentifier, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszComputerName, void* pvReserved, [NativeTypeName("const void *")] void* pvData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptEnumKeyIdentifierProperties([NativeTypeName("const CRYPT_HASH_BLOB *")] CRYPT_DATA_BLOB* pKeyIdentifier, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszComputerName, void* pvReserved, void* pvArg, [NativeTypeName("PFN_CRYPT_ENUM_KEYID_PROP")] delegate* unmanaged<CRYPT_DATA_BLOB*, uint, void*, void*, uint, uint*, void**, uint*, BOOL> pfnEnum);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptCreateKeyIdentifierFromCSP([NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszPubKeyOID, [NativeTypeName("const PUBLICKEYSTRUC *")] PUBLICKEYSTRUC* pPubKeyStruc, [NativeTypeName("DWORD")] uint cbPubKeyStruc, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved, byte* pbHash, [NativeTypeName("DWORD *")] uint* pcbHash);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertCreateCertificateChainEngine([NativeTypeName("PCERT_CHAIN_ENGINE_CONFIG")] CERT_CHAIN_ENGINE_CONFIG* pConfig, HCERTCHAINENGINE* phChainEngine);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertFreeCertificateChainEngine(HCERTCHAINENGINE hChainEngine);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertResyncCertificateChainEngine(HCERTCHAINENGINE hChainEngine);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertGetCertificateChain(HCERTCHAINENGINE hChainEngine, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("LPFILETIME")] FILETIME* pTime, HCERTSTORE hAdditionalStore, [NativeTypeName("PCERT_CHAIN_PARA")] CERT_CHAIN_PARA* pChainPara, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("PCCERT_CHAIN_CONTEXT *")] CERT_CHAIN_CONTEXT** ppChainContext);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertFreeCertificateChain([NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_CHAIN_CONTEXT")]
        public static extern CERT_CHAIN_CONTEXT* CertDuplicateCertificateChain([NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_CHAIN_CONTEXT")]
        public static extern CERT_CHAIN_CONTEXT* CertFindChainInStore(HCERTSTORE hCertStore, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("DWORD")] uint dwFindFlags, [NativeTypeName("DWORD")] uint dwFindType, [NativeTypeName("const void *")] void* pvFindPara, [NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pPrevChainContext);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertVerifyCertificateChainPolicy([NativeTypeName("LPCSTR")] sbyte* pszPolicyOID, [NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext, [NativeTypeName("PCERT_CHAIN_POLICY_PARA")] CERT_CHAIN_POLICY_PARA* pPolicyPara, [NativeTypeName("PCERT_CHAIN_POLICY_STATUS")] CERT_CHAIN_POLICY_STATUS* pPolicyStatus);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptStringToBinaryA([NativeTypeName("LPCSTR")] sbyte* pszString, [NativeTypeName("DWORD")] uint cchString, [NativeTypeName("DWORD")] uint dwFlags, byte* pbBinary, [NativeTypeName("DWORD *")] uint* pcbBinary, [NativeTypeName("DWORD *")] uint* pdwSkip, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptStringToBinaryW([NativeTypeName("LPCWSTR")] ushort* pszString, [NativeTypeName("DWORD")] uint cchString, [NativeTypeName("DWORD")] uint dwFlags, byte* pbBinary, [NativeTypeName("DWORD *")] uint* pcbBinary, [NativeTypeName("DWORD *")] uint* pdwSkip, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptBinaryToStringA([NativeTypeName("const BYTE *")] byte* pbBinary, [NativeTypeName("DWORD")] uint cbBinary, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* pszString, [NativeTypeName("DWORD *")] uint* pcchString);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptBinaryToStringW([NativeTypeName("const BYTE *")] byte* pbBinary, [NativeTypeName("DWORD")] uint cbBinary, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszString, [NativeTypeName("DWORD *")] uint* pcchString);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern HCERTSTORE PFXImportCertStore(CRYPT_DATA_BLOB* pPFX, [NativeTypeName("LPCWSTR")] ushort* szPassword, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL PFXIsPFXBlob(CRYPT_DATA_BLOB* pPFX);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL PFXVerifyPassword(CRYPT_DATA_BLOB* pPFX, [NativeTypeName("LPCWSTR")] ushort* szPassword, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL PFXExportCertStoreEx(HCERTSTORE hStore, CRYPT_DATA_BLOB* pPFX, [NativeTypeName("LPCWSTR")] ushort* szPassword, void* pvPara, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL PFXExportCertStore(HCERTSTORE hStore, CRYPT_DATA_BLOB* pPFX, [NativeTypeName("LPCWSTR")] ushort* szPassword, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern HCERT_SERVER_OCSP_RESPONSE CertOpenServerOcspResponse([NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCERT_SERVER_OCSP_RESPONSE_OPEN_PARA")] CERT_SERVER_OCSP_RESPONSE_OPEN_PARA* pOpenPara);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertAddRefServerOcspResponse(HCERT_SERVER_OCSP_RESPONSE hServerOcspResponse);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertCloseServerOcspResponse(HCERT_SERVER_OCSP_RESPONSE hServerOcspResponse, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("crypt32", ExactSpelling = true)]
        [return: NativeTypeName("PCCERT_SERVER_OCSP_RESPONSE_CONTEXT")]
        public static extern CERT_SERVER_OCSP_RESPONSE_CONTEXT* CertGetServerOcspResponseContext(HCERT_SERVER_OCSP_RESPONSE hServerOcspResponse, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* pvReserved);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertAddRefServerOcspResponseContext([NativeTypeName("PCCERT_SERVER_OCSP_RESPONSE_CONTEXT")] CERT_SERVER_OCSP_RESPONSE_CONTEXT* pServerOcspResponseContext);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertFreeServerOcspResponseContext([NativeTypeName("PCCERT_SERVER_OCSP_RESPONSE_CONTEXT")] CERT_SERVER_OCSP_RESPONSE_CONTEXT* pServerOcspResponseContext);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertRetrieveLogoOrBiometricInfo([NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext, [NativeTypeName("LPCSTR")] sbyte* lpszLogoOrBiometricType, [NativeTypeName("DWORD")] uint dwRetrievalFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("DWORD")] uint dwFlags, void* pvReserved, byte** ppbData, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("LPWSTR *")] ushort** ppwszMimeType);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CertSelectCertificateChains([NativeTypeName("LPCGUID")] Guid* pSelectionContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCCERT_SELECT_CHAIN_PARA")] CERT_SELECT_CHAIN_PARA* pChainParameters, [NativeTypeName("DWORD")] uint cCriteria, [NativeTypeName("PCCERT_SELECT_CRITERIA")] CERT_SELECT_CRITERIA* rgpCriteria, HCERTSTORE hStore, [NativeTypeName("PDWORD")] uint* pcSelection, [NativeTypeName("PCCERT_CHAIN_CONTEXT **")] CERT_CHAIN_CONTEXT*** pprgpSelection);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern void CertFreeCertificateChainList([NativeTypeName("PCCERT_CHAIN_CONTEXT *")] CERT_CHAIN_CONTEXT** prgpSelection);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptRetrieveTimeStamp([NativeTypeName("LPCWSTR")] ushort* wszUrl, [NativeTypeName("DWORD")] uint dwRetrievalFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("LPCSTR")] sbyte* pszHashId, [NativeTypeName("const CRYPT_TIMESTAMP_PARA *")] CRYPT_TIMESTAMP_PARA* pPara, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("PCRYPT_TIMESTAMP_CONTEXT *")] CRYPT_TIMESTAMP_CONTEXT** ppTsContext, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppTsSigner, HCERTSTORE* phStore);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptVerifyTimeStampSignature([NativeTypeName("const BYTE *")] byte* pbTSContentInfo, [NativeTypeName("DWORD")] uint cbTSContentInfo, [NativeTypeName("const BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint cbData, HCERTSTORE hAdditionalStore, [NativeTypeName("PCRYPT_TIMESTAMP_CONTEXT *")] CRYPT_TIMESTAMP_CONTEXT** ppTsContext, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppTsSigner, HCERTSTORE* phStore);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CertIsWeakHash([NativeTypeName("DWORD")] uint dwHashUseType, [NativeTypeName("LPCWSTR")] ushort* pwszCNGHashAlgid, [NativeTypeName("DWORD")] uint dwChainFlags, [NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pSignerChainContext, [NativeTypeName("LPFILETIME")] FILETIME* pTimeStamp, [NativeTypeName("LPCWSTR")] ushort* pwszFileName);

        [NativeTypeName("#define RSA1024BIT_KEY 0x04000000")]
        public const int RSA1024BIT_KEY = 0x04000000;

        [NativeTypeName("#define KEY_LENGTH_MASK 0xFFFF0000")]
        public const uint KEY_LENGTH_MASK = 0xFFFF0000;

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
        public static delegate*<HCRYPTPROV*, ushort*, ushort*, uint, uint, BOOL> CryptAcquireContext => &CryptAcquireContextW;

        [NativeTypeName("#define CryptSignHash CryptSignHashW")]
        public static delegate*<HCRYPTHASH, uint, ushort*, uint, byte*, uint*, BOOL> CryptSignHash => &CryptSignHashW;

        [NativeTypeName("#define CryptVerifySignature CryptVerifySignatureW")]
        public static delegate*<HCRYPTHASH, byte*, uint, HCRYPTKEY, ushort*, uint, BOOL> CryptVerifySignature => &CryptVerifySignatureW;

        [NativeTypeName("#define CryptSetProvider CryptSetProviderW")]
        public static delegate*<ushort*, uint, BOOL> CryptSetProvider => &CryptSetProviderW;

        [NativeTypeName("#define CryptSetProviderEx CryptSetProviderExW")]
        public static delegate*<ushort*, uint, uint*, uint, BOOL> CryptSetProviderEx => &CryptSetProviderExW;

        [NativeTypeName("#define CryptGetDefaultProvider CryptGetDefaultProviderW")]
        public static delegate*<uint, uint*, uint, ushort*, uint*, BOOL> CryptGetDefaultProvider => &CryptGetDefaultProviderW;

        [NativeTypeName("#define CryptEnumProviderTypes CryptEnumProviderTypesW")]
        public static delegate*<uint, uint*, uint, uint*, ushort*, uint*, BOOL> CryptEnumProviderTypes => &CryptEnumProviderTypesW;

        [NativeTypeName("#define CryptEnumProviders CryptEnumProvidersW")]
        public static delegate*<uint, uint*, uint, uint*, ushort*, uint*, BOOL> CryptEnumProviders => &CryptEnumProvidersW;

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

        [NativeTypeName("#define CRL_V1 0")]
        public const int CRL_V1 = 0;

        [NativeTypeName("#define CRL_V2 1")]
        public const int CRL_V2 = 1;

        [NativeTypeName("#define CTL_V1 0")]
        public const int CTL_V1 = 0;

        [NativeTypeName("#define X509_ASN_ENCODING 0x00000001")]
        public const int X509_ASN_ENCODING = 0x00000001;

        [NativeTypeName("#define X509_NDR_ENCODING 0x00000002")]
        public const int X509_NDR_ENCODING = 0x00000002;

        [NativeTypeName("#define PKCS_7_ASN_ENCODING 0x00010000")]
        public const int PKCS_7_ASN_ENCODING = 0x00010000;

        [NativeTypeName("#define PKCS_7_NDR_ENCODING 0x00020000")]
        public const int PKCS_7_NDR_ENCODING = 0x00020000;

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

        [NativeTypeName("#define szOID_LOYALTY_OTHER_LOGOTYPE \"1.3.6.1.5.5.7.20.1\"")]
        public static ReadOnlySpan<byte> szOID_LOYALTY_OTHER_LOGOTYPE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x32, 0x30, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_BACKGROUND_OTHER_LOGOTYPE \"1.3.6.1.5.5.7.20.2\"")]
        public static ReadOnlySpan<byte> szOID_BACKGROUND_OTHER_LOGOTYPE => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x35, 0x2E, 0x35, 0x2E, 0x37, 0x2E, 0x32, 0x30, 0x2E, 0x32, 0x00 };

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

        [NativeTypeName("#define szOID_ROOT_PROGRAM_AUTO_UPDATE_CA_REVOCATION \"1.3.6.1.4.1.311.60.3.1\"")]
        public static ReadOnlySpan<byte> szOID_ROOT_PROGRAM_AUTO_UPDATE_CA_REVOCATION => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x33, 0x2E, 0x31, 0x00 };

        [NativeTypeName("#define szOID_ROOT_PROGRAM_AUTO_UPDATE_END_REVOCATION \"1.3.6.1.4.1.311.60.3.2\"")]
        public static ReadOnlySpan<byte> szOID_ROOT_PROGRAM_AUTO_UPDATE_END_REVOCATION => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x33, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define szOID_ROOT_PROGRAM_NO_OCSP_FAILOVER_TO_CRL \"1.3.6.1.4.1.311.60.3.3\"")]
        public static ReadOnlySpan<byte> szOID_ROOT_PROGRAM_NO_OCSP_FAILOVER_TO_CRL => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x36, 0x30, 0x2E, 0x33, 0x2E, 0x33, 0x00 };

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

        [NativeTypeName("#define CertRDNValueToStr CertRDNValueToStrW")]
        public static delegate*<uint, CRYPT_DATA_BLOB*, ushort*, uint, uint> CertRDNValueToStr => &CertRDNValueToStrW;

        [NativeTypeName("#define CertNameToStr CertNameToStrW")]
        public static delegate*<uint, CRYPT_DATA_BLOB*, uint, ushort*, uint, uint> CertNameToStr => &CertNameToStrW;

        [NativeTypeName("#define CertStrToName CertStrToNameW")]
        public static delegate*<uint, ushort*, uint, void*, byte*, uint*, ushort**, BOOL> CertStrToName => &CertStrToNameW;

        [NativeTypeName("#define CertGetNameString CertGetNameStringW")]
        public static delegate*<CERT_CONTEXT*, uint, uint, void*, ushort*, uint, uint> CertGetNameString => &CertGetNameStringW;

        [NativeTypeName("#define CertOpenSystemStore CertOpenSystemStoreW")]
        public static delegate*<HCRYPTPROV_LEGACY, ushort*, HCERTSTORE> CertOpenSystemStore => &CertOpenSystemStoreW;

        [NativeTypeName("#define CertAddEncodedCertificateToSystemStore CertAddEncodedCertificateToSystemStoreW")]
        public static delegate*<ushort*, byte*, uint, BOOL> CertAddEncodedCertificateToSystemStore => &CertAddEncodedCertificateToSystemStoreW;

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

        [NativeTypeName("#define CryptRetrieveObjectByUrl CryptRetrieveObjectByUrlW")]
        public static delegate*<ushort*, sbyte*, uint, uint, void**, HCRYPTASYNC, CRYPT_CREDENTIALS*, void*, CRYPT_RETRIEVE_AUX_INFO*, BOOL> CryptRetrieveObjectByUrl => &CryptRetrieveObjectByUrlW;

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

        [NativeTypeName("#define USAGE_MATCH_TYPE_AND 0x00000000")]
        public const int USAGE_MATCH_TYPE_AND = 0x00000000;

        [NativeTypeName("#define USAGE_MATCH_TYPE_OR 0x00000001")]
        public const int USAGE_MATCH_TYPE_OR = 0x00000001;

        [NativeTypeName("#define REVOCATION_OID_CRL_REVOCATION ((LPCSTR)1)")]
        public static sbyte* REVOCATION_OID_CRL_REVOCATION => ((sbyte*)(1));

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

        [NativeTypeName("#define SSL_HPKP_PKP_HEADER_INDEX 0")]
        public const int SSL_HPKP_PKP_HEADER_INDEX = 0;

        [NativeTypeName("#define SSL_HPKP_PKP_RO_HEADER_INDEX 1")]
        public const int SSL_HPKP_PKP_RO_HEADER_INDEX = 1;

        [NativeTypeName("#define SSL_HPKP_HEADER_COUNT 2")]
        public const int SSL_HPKP_HEADER_COUNT = 2;

        [NativeTypeName("#define SSL_KEY_PIN_ERROR_TEXT_LENGTH 512")]
        public const int SSL_KEY_PIN_ERROR_TEXT_LENGTH = 512;

        [NativeTypeName("#define CryptStringToBinary CryptStringToBinaryW")]
        public static delegate*<ushort*, uint, uint, byte*, uint*, uint*, uint*, BOOL> CryptStringToBinary => &CryptStringToBinaryW;

        [NativeTypeName("#define CryptBinaryToString CryptBinaryToStringW")]
        public static delegate*<byte*, uint, uint, ushort*, uint*, BOOL> CryptBinaryToString => &CryptBinaryToStringW;

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

        [NativeTypeName("#define SSL_OBJECT_LOCATOR_PFX_FUNC \"SslObjectLocatorInitializePfx\"")]
        public static ReadOnlySpan<byte> SSL_OBJECT_LOCATOR_PFX_FUNC => new byte[] { 0x53, 0x73, 0x6C, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x4C, 0x6F, 0x63, 0x61, 0x74, 0x6F, 0x72, 0x49, 0x6E, 0x69, 0x74, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x50, 0x66, 0x78, 0x00 };

        [NativeTypeName("#define SSL_OBJECT_LOCATOR_ISSUER_LIST_FUNC \"SslObjectLocatorInitializeIssuerList\"")]
        public static ReadOnlySpan<byte> SSL_OBJECT_LOCATOR_ISSUER_LIST_FUNC => new byte[] { 0x53, 0x73, 0x6C, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x4C, 0x6F, 0x63, 0x61, 0x74, 0x6F, 0x72, 0x49, 0x6E, 0x69, 0x74, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x49, 0x73, 0x73, 0x75, 0x65, 0x72, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        [NativeTypeName("#define SSL_OBJECT_LOCATOR_CERT_VALIDATION_CONFIG_FUNC \"SslObjectLocatorInitializeCertValidationConfig\"")]
        public static ReadOnlySpan<byte> SSL_OBJECT_LOCATOR_CERT_VALIDATION_CONFIG_FUNC => new byte[] { 0x53, 0x73, 0x6C, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x4C, 0x6F, 0x63, 0x61, 0x74, 0x6F, 0x72, 0x49, 0x6E, 0x69, 0x74, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x43, 0x65, 0x72, 0x74, 0x56, 0x61, 0x6C, 0x69, 0x64, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x43, 0x6F, 0x6E, 0x66, 0x69, 0x67, 0x00 };
    }
}
