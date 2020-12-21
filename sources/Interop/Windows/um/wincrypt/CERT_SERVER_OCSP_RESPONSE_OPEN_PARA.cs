// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_SERVER_OCSP_RESPONSE_OPEN_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD *")]
        public uint* pcbUsedSize;

        [NativeTypeName("PWSTR")]
        public ushort* pwszOcspDirectory;

        [NativeTypeName("PFN_CERT_SERVER_OCSP_RESPONSE_UPDATE_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<CERT_CHAIN_CONTEXT*, CERT_SERVER_OCSP_RESPONSE_CONTEXT*, CRL_CONTEXT*, CRL_CONTEXT*, void*, uint, void> pfnUpdateCallback;
#else
        public void* _pfnUpdateCallback;

        public delegate* unmanaged[Stdcall]<CERT_CHAIN_CONTEXT*, CERT_SERVER_OCSP_RESPONSE_CONTEXT*, CRL_CONTEXT*, CRL_CONTEXT*, void*, uint, void> pfnUpdateCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<CERT_CHAIN_CONTEXT*, CERT_SERVER_OCSP_RESPONSE_CONTEXT*, CRL_CONTEXT*, CRL_CONTEXT*, void*, uint, void>)_pfnUpdateCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnUpdateCallback = value;
            }
        }
#endif

        [NativeTypeName("PVOID")]
        public void* pvUpdateCallbackArg;
    }
}
