// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_DECODE_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("PFN_CRYPT_ALLOC")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<nuint, void*> pfnAlloc;
#else
        public void* _pfnAlloc;

        public delegate* unmanaged[Stdcall]<nuint, void*> pfnAlloc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<nuint, void*>)_pfnAlloc;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnAlloc = value;
            }
        }
#endif

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
    }
}
