// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CRYPT_SIGN_AND_ENCODE_HASH_FUNC([NativeTypeName("NCRYPT_KEY_HANDLE")] UIntPtr hKey, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")] CRYPT_ALGORITHM_IDENTIFIER* pSignatureAlgorithm, [NativeTypeName("void *")] void* pvDecodedSignPara, [NativeTypeName("LPCWSTR")] ushort* pwszCNGPubKeyAlgid, [NativeTypeName("LPCWSTR")] ushort* pwszCNGHashAlgid, [NativeTypeName("BYTE *")] byte* pbComputedHash, [NativeTypeName("DWORD")] uint cbComputedHash, [NativeTypeName("BYTE *")] byte* pbSignature, [NativeTypeName("DWORD *")] uint* pcbSignature);
}
