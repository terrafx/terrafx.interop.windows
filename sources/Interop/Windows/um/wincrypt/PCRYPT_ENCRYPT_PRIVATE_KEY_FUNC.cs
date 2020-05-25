// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PCRYPT_ENCRYPT_PRIVATE_KEY_FUNC([NativeTypeName("CRYPT_ALGORITHM_IDENTIFIER *")] CRYPT_ALGORITHM_IDENTIFIER* pAlgorithm, [NativeTypeName("CRYPT_DATA_BLOB *")] CRYPTOAPI_BLOB* pClearTextPrivateKey, [NativeTypeName("BYTE *")] byte* pbEncryptedKey, [NativeTypeName("DWORD *")] uint* pcbEncryptedKey, [NativeTypeName("LPVOID")] void* pVoidEncryptFunc);
}
