// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_CREATE_CONTEXT_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("PFN_CRYPT_FREE")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, void> pfnFree;
#else
        public void* _pfnFree;

        public delegate* unmanaged[Stdcall]<void*, void> pfnFree
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, void>)_pfnFree;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnFree = value;
            }
        }
#endif

        [NativeTypeName("void *")]
        public void* pvFree;

        [NativeTypeName("PFN_CERT_CREATE_CONTEXT_SORT_FUNC")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<uint, uint, uint, void*, int> pfnSort;
#else
        public void* _pfnSort;

        public delegate* unmanaged[Stdcall]<uint, uint, uint, void*, int> pfnSort
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<uint, uint, uint, void*, int>)_pfnSort;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnSort = value;
            }
        }
#endif

        [NativeTypeName("void *")]
        public void* pvSort;
    }
}
