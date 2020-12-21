// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_GET")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, CRYPTOAPI_BLOB*, uint, CRYPTOAPI_BLOB*, byte**, uint*, ushort**, CRYPTOAPI_BLOB**, int> pfnGet;
#else
        public void* _pfnGet;

        public delegate* unmanaged[Stdcall]<void*, CRYPTOAPI_BLOB*, uint, CRYPTOAPI_BLOB*, byte**, uint*, ushort**, CRYPTOAPI_BLOB**, int> pfnGet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, CRYPTOAPI_BLOB*, uint, CRYPTOAPI_BLOB*, byte**, uint*, ushort**, CRYPTOAPI_BLOB**, int>)_pfnGet;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnGet = value;
            }
        }
#endif

        [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_RELEASE")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<uint, void*, void> pfnRelease;
#else
        public void* _pfnRelease;

        public delegate* unmanaged[Stdcall]<uint, void*, void> pfnRelease
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<uint, void*, void>)_pfnRelease;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnRelease = value;
            }
        }
#endif

        [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_FREE_PASSWORD")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, ushort*, void> pfnFreePassword;
#else
        public void* _pfnFreePassword;

        public delegate* unmanaged[Stdcall]<void*, ushort*, void> pfnFreePassword
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, ushort*, void>)_pfnFreePassword;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnFreePassword = value;
            }
        }
#endif

        [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_FREE")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, byte*, void> pfnFree;
#else
        public void* _pfnFree;

        public delegate* unmanaged[Stdcall]<void*, byte*, void> pfnFree
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, byte*, void>)_pfnFree;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnFree = value;
            }
        }
#endif

        [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_FREE_IDENTIFIER")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, CRYPTOAPI_BLOB*, void> pfnFreeIdentifier;
#else
        public void* _pfnFreeIdentifier;

        public delegate* unmanaged[Stdcall]<void*, CRYPTOAPI_BLOB*, void> pfnFreeIdentifier
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, CRYPTOAPI_BLOB*, void>)_pfnFreeIdentifier;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnFreeIdentifier = value;
            }
        }
#endif
    }
}
