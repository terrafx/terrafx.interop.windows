// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5B87EF6C-7ED8-434F-BA0E-184FAC1628D1")]
    [NativeTypeName("struct IMFNetCredentialCache : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFNetCredentialCache
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFNetCredentialCache*, Guid*, void**, int>)(lpVtbl[0]))((IMFNetCredentialCache*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFNetCredentialCache*, uint>)(lpVtbl[1]))((IMFNetCredentialCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFNetCredentialCache*, uint>)(lpVtbl[2]))((IMFNetCredentialCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCredential([NativeTypeName("LPCWSTR")] ushort* pszUrl, [NativeTypeName("LPCWSTR")] ushort* pszRealm, [NativeTypeName("DWORD")] uint dwAuthenticationFlags, IMFNetCredential** ppCred, [NativeTypeName("DWORD *")] uint* pdwRequirementsFlags)
        {
            return ((delegate* unmanaged<IMFNetCredentialCache*, ushort*, ushort*, uint, IMFNetCredential**, uint*, int>)(lpVtbl[3]))((IMFNetCredentialCache*)Unsafe.AsPointer(ref this), pszUrl, pszRealm, dwAuthenticationFlags, ppCred, pdwRequirementsFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetGood(IMFNetCredential* pCred, BOOL fGood)
        {
            return ((delegate* unmanaged<IMFNetCredentialCache*, IMFNetCredential*, BOOL, int>)(lpVtbl[4]))((IMFNetCredentialCache*)Unsafe.AsPointer(ref this), pCred, fGood);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetUserOptions(IMFNetCredential* pCred, [NativeTypeName("DWORD")] uint dwOptionsFlags)
        {
            return ((delegate* unmanaged<IMFNetCredentialCache*, IMFNetCredential*, uint, int>)(lpVtbl[5]))((IMFNetCredentialCache*)Unsafe.AsPointer(ref this), pCred, dwOptionsFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCredentialCache*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCredentialCache*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCredentialCache*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DWORD, IMFNetCredential **, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCredentialCache*, ushort*, ushort*, uint, IMFNetCredential**, uint*, int> GetCredential;

            [NativeTypeName("HRESULT (IMFNetCredential *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCredentialCache*, IMFNetCredential*, BOOL, int> SetGood;

            [NativeTypeName("HRESULT (IMFNetCredential *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCredentialCache*, IMFNetCredential*, uint, int> SetUserOptions;
        }
    }
}
