// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_CHAIN_FIND_BY_ISSUER_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("LPCSTR")]
        public sbyte* pszUsageIdentifier;

        [NativeTypeName("DWORD")]
        public uint dwKeySpec;

        [NativeTypeName("DWORD")]
        public uint dwAcquirePrivateKeyFlags;

        [NativeTypeName("DWORD")]
        public uint cIssuer;

        [NativeTypeName("CERT_NAME_BLOB *")]
        public CRYPTOAPI_BLOB* rgIssuer;

        [NativeTypeName("PFN_CERT_CHAIN_FIND_BY_ISSUER_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<CERT_CONTEXT*, void*, int> pfnFindCallback;
#else
        public void* _pfnFindCallback;

        public delegate* unmanaged[Stdcall]<CERT_CONTEXT*, void*, int> pfnFindCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<CERT_CONTEXT*, void*, int>)_pfnFindCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnFindCallback = value;
            }
        }
#endif

        [NativeTypeName("void *")]
        public void* pvFindArg;
    }
}
