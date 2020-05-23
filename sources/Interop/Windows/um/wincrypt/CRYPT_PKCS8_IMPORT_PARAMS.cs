// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_PKCS8_IMPORT_PARAMS
    {
        [NativeTypeName("CRYPT_DIGEST_BLOB")]
        public CRYPTOAPI_BLOB PrivateKey;

        [NativeTypeName("PCRYPT_RESOLVE_HCRYPTPROV_FUNC")]
        public IntPtr pResolvehCryptProvFunc;

        [NativeTypeName("LPVOID")]
        public void* pVoidResolveFunc;

        [NativeTypeName("PCRYPT_DECRYPT_PRIVATE_KEY_FUNC")]
        public IntPtr pDecryptPrivateKeyFunc;

        [NativeTypeName("LPVOID")]
        public void* pVoidDecryptFunc;
    }
}
