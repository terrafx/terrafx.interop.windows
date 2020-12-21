// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_PROVIDER_FUNCTIONS
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("PFN_CPD_MEM_ALLOC")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<uint, void*> pfnAlloc;
#else
        public void* _pfnAlloc;

        public delegate* unmanaged[Cdecl]<uint, void*> pfnAlloc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<uint, void*>)_pfnAlloc;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnAlloc = value;
            }
        }
#endif

        [NativeTypeName("PFN_CPD_MEM_FREE")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<void*, void> pfnFree;
#else
        public void* _pfnFree;

        public delegate* unmanaged[Cdecl]<void*, void> pfnFree
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<void*, void>)_pfnFree;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnFree = value;
            }
        }
#endif

        [NativeTypeName("PFN_CPD_ADD_STORE")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, void*, int> pfnAddStore2Chain;
#else
        public void* _pfnAddStore2Chain;

        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, void*, int> pfnAddStore2Chain
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, void*, int>)_pfnAddStore2Chain;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnAddStore2Chain = value;
            }
        }
#endif

        [NativeTypeName("PFN_CPD_ADD_SGNR")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int, uint, CRYPT_PROVIDER_SGNR*, int> pfnAddSgnr2Chain;
#else
        public void* _pfnAddSgnr2Chain;

        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int, uint, CRYPT_PROVIDER_SGNR*, int> pfnAddSgnr2Chain
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int, uint, CRYPT_PROVIDER_SGNR*, int>)_pfnAddSgnr2Chain;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnAddSgnr2Chain = value;
            }
        }
#endif

        [NativeTypeName("PFN_CPD_ADD_CERT")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, uint, int, uint, CERT_CONTEXT*, int> pfnAddCert2Chain;
#else
        public void* _pfnAddCert2Chain;

        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, uint, int, uint, CERT_CONTEXT*, int> pfnAddCert2Chain
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, uint, int, uint, CERT_CONTEXT*, int>)_pfnAddCert2Chain;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnAddCert2Chain = value;
            }
        }
#endif

        [NativeTypeName("PFN_CPD_ADD_PRIVDATA")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, CRYPT_PROVIDER_PRIVDATA*, int> pfnAddPrivData2Chain;
#else
        public void* _pfnAddPrivData2Chain;

        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, CRYPT_PROVIDER_PRIVDATA*, int> pfnAddPrivData2Chain
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, CRYPT_PROVIDER_PRIVDATA*, int>)_pfnAddPrivData2Chain;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnAddPrivData2Chain = value;
            }
        }
#endif

        [NativeTypeName("PFN_PROVIDER_INIT_CALL")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int> pfnInitialize;
#else
        public void* _pfnInitialize;

        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int> pfnInitialize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int>)_pfnInitialize;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnInitialize = value;
            }
        }
#endif

        [NativeTypeName("PFN_PROVIDER_OBJTRUST_CALL")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int> pfnObjectTrust;
#else
        public void* _pfnObjectTrust;

        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int> pfnObjectTrust
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int>)_pfnObjectTrust;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnObjectTrust = value;
            }
        }
#endif

        [NativeTypeName("PFN_PROVIDER_SIGTRUST_CALL")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int> pfnSignatureTrust;
#else
        public void* _pfnSignatureTrust;

        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int> pfnSignatureTrust
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int>)_pfnSignatureTrust;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnSignatureTrust = value;
            }
        }
#endif

        [NativeTypeName("PFN_PROVIDER_CERTTRUST_CALL")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int> pfnCertificateTrust;
#else
        public void* _pfnCertificateTrust;

        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int> pfnCertificateTrust
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int>)_pfnCertificateTrust;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnCertificateTrust = value;
            }
        }
#endif

        [NativeTypeName("PFN_PROVIDER_FINALPOLICY_CALL")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int> pfnFinalPolicy;
#else
        public void* _pfnFinalPolicy;

        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int> pfnFinalPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int>)_pfnFinalPolicy;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnFinalPolicy = value;
            }
        }
#endif

        [NativeTypeName("PFN_PROVIDER_CERTCHKPOLICY_CALL")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, uint, int, uint, int> pfnCertCheckPolicy;
#else
        public void* _pfnCertCheckPolicy;

        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, uint, int, uint, int> pfnCertCheckPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, uint, int, uint, int>)_pfnCertCheckPolicy;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnCertCheckPolicy = value;
            }
        }
#endif

        [NativeTypeName("PFN_PROVIDER_TESTFINALPOLICY_CALL")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int> pfnTestFinalPolicy;
#else
        public void* _pfnTestFinalPolicy;

        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int> pfnTestFinalPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int>)_pfnTestFinalPolicy;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnTestFinalPolicy = value;
            }
        }
#endif

        [NativeTypeName("struct _CRYPT_PROVUI_FUNCS *")]
        public CRYPT_PROVUI_FUNCS* psUIpfns;

        [NativeTypeName("PFN_PROVIDER_CLEANUP_CALL")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int> pfnCleanupPolicy;
#else
        public void* _pfnCleanupPolicy;

        public delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int> pfnCleanupPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<CRYPT_PROVIDER_DATA*, int>)_pfnCleanupPolicy;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnCleanupPolicy = value;
            }
        }
#endif
    }
}
