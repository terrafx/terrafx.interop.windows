// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_VERIFY_MESSAGE_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwMsgAndCertEncodingType;

        [NativeTypeName("HCRYPTPROV_LEGACY")]
        public nuint hCryptProv;

        [NativeTypeName("PFN_CRYPT_GET_SIGNER_CERTIFICATE")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, uint, CERT_INFO*, void*, CERT_CONTEXT*> pfnGetSignerCertificate;
#else
        public void* _pfnGetSignerCertificate;

        public delegate* unmanaged[Stdcall]<void*, uint, CERT_INFO*, void*, CERT_CONTEXT*> pfnGetSignerCertificate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, uint, CERT_INFO*, void*, CERT_CONTEXT*>)_pfnGetSignerCertificate;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnGetSignerCertificate = value;
            }
        }
#endif

        [NativeTypeName("void *")]
        public void* pvGetArg;
    }
}
