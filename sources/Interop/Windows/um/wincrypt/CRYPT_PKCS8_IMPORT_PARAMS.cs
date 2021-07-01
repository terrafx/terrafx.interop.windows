// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_PKCS8_IMPORT_PARAMS
    {
        [NativeTypeName("CRYPT_DIGEST_BLOB")]
        public CRYPTOAPI_BLOB PrivateKey;

        [NativeTypeName("PCRYPT_RESOLVE_HCRYPTPROV_FUNC")]
        public delegate* unmanaged<CRYPT_PRIVATE_KEY_INFO*, nuint*, void*, int> pResolvehCryptProvFunc;

        [NativeTypeName("LPVOID")]
        public void* pVoidResolveFunc;

        [NativeTypeName("PCRYPT_DECRYPT_PRIVATE_KEY_FUNC")]
        public delegate* unmanaged<CRYPT_ALGORITHM_IDENTIFIER, CRYPTOAPI_BLOB, byte*, uint*, void*, int> pDecryptPrivateKeyFunc;

        [NativeTypeName("LPVOID")]
        public void* pVoidDecryptFunc;
    }
}
