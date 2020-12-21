// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_PKCS8_IMPORT_PARAMS
    {
        [NativeTypeName("CRYPT_DIGEST_BLOB")]
        public CRYPTOAPI_BLOB PrivateKey;

        [NativeTypeName("PCRYPT_RESOLVE_HCRYPTPROV_FUNC")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<CRYPT_PRIVATE_KEY_INFO*, nuint*, void*, int> pResolvehCryptProvFunc;
#else
        public void* _pResolvehCryptProvFunc;

        public delegate* unmanaged[Stdcall]<CRYPT_PRIVATE_KEY_INFO*, nuint*, void*, int> pResolvehCryptProvFunc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<CRYPT_PRIVATE_KEY_INFO*, nuint*, void*, int>)_pResolvehCryptProvFunc;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pResolvehCryptProvFunc = value;
            }
        }
#endif

        [NativeTypeName("LPVOID")]
        public void* pVoidResolveFunc;

        [NativeTypeName("PCRYPT_DECRYPT_PRIVATE_KEY_FUNC")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<CRYPT_ALGORITHM_IDENTIFIER, CRYPTOAPI_BLOB, byte*, uint*, void*, int> pDecryptPrivateKeyFunc;
#else
        public void* _pDecryptPrivateKeyFunc;

        public delegate* unmanaged[Stdcall]<CRYPT_ALGORITHM_IDENTIFIER, CRYPTOAPI_BLOB, byte*, uint*, void*, int> pDecryptPrivateKeyFunc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<CRYPT_ALGORITHM_IDENTIFIER, CRYPTOAPI_BLOB, byte*, uint*, void*, int>)_pDecryptPrivateKeyFunc;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pDecryptPrivateKeyFunc = value;
            }
        }
#endif

        [NativeTypeName("LPVOID")]
        public void* pVoidDecryptFunc;
    }
}
