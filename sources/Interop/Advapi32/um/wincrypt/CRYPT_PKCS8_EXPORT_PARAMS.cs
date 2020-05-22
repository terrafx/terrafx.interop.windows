// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_PKCS8_EXPORT_PARAMS
    {
        [NativeTypeName("HCRYPTPROV")]
        public nuint hCryptProv;

        [NativeTypeName("DWORD")]
        public uint dwKeySpec;

        [NativeTypeName("LPSTR")]
        public sbyte* pszPrivateKeyObjId;

        [NativeTypeName("PCRYPT_ENCRYPT_PRIVATE_KEY_FUNC")]
        public IntPtr pEncryptPrivateKeyFunc;

        [NativeTypeName("LPVOID")]
        public void* pVoidEncryptFunc;
    }
}
