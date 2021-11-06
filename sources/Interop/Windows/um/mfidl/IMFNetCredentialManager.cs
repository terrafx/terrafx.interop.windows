// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5B87EF6B-7ED8-434F-BA0E-184FAC1628D1")]
    [NativeTypeName("struct IMFNetCredentialManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFNetCredentialManager : IMFNetCredentialManager.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFNetCredentialManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFNetCredentialManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFNetCredentialManager*, uint>)(lpVtbl[1]))((IMFNetCredentialManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFNetCredentialManager*, uint>)(lpVtbl[2]))((IMFNetCredentialManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT BeginGetCredentials(MFNetCredentialManagerGetParam* pParam, IMFAsyncCallback* pCallback, IUnknown* pState)
        {
            return ((delegate* unmanaged<IMFNetCredentialManager*, MFNetCredentialManagerGetParam*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFNetCredentialManager*)Unsafe.AsPointer(ref this), pParam, pCallback, pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT EndGetCredentials(IMFAsyncResult* pResult, IMFNetCredential** ppCred)
        {
            return ((delegate* unmanaged<IMFNetCredentialManager*, IMFAsyncResult*, IMFNetCredential**, int>)(lpVtbl[4]))((IMFNetCredentialManager*)Unsafe.AsPointer(ref this), pResult, ppCred);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetGood(IMFNetCredential* pCred, BOOL fGood)
        {
            return ((delegate* unmanaged<IMFNetCredentialManager*, IMFNetCredential*, BOOL, int>)(lpVtbl[5]))((IMFNetCredentialManager*)Unsafe.AsPointer(ref this), pCred, fGood);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT BeginGetCredentials(MFNetCredentialManagerGetParam* pParam, IMFAsyncCallback* pCallback, IUnknown* pState);

            [VtblIndex(4)]
            HRESULT EndGetCredentials(IMFAsyncResult* pResult, IMFNetCredential** ppCred);

            [VtblIndex(5)]
            HRESULT SetGood(IMFNetCredential* pCred, BOOL fGood);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCredentialManager*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCredentialManager*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCredentialManager*, uint> Release;

            [NativeTypeName("HRESULT (MFNetCredentialManagerGetParam *, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCredentialManager*, MFNetCredentialManagerGetParam*, IMFAsyncCallback*, IUnknown*, int> BeginGetCredentials;

            [NativeTypeName("HRESULT (IMFAsyncResult *, IMFNetCredential **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCredentialManager*, IMFAsyncResult*, IMFNetCredential**, int> EndGetCredentials;

            [NativeTypeName("HRESULT (IMFNetCredential *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCredentialManager*, IMFNetCredential*, BOOL, int> SetGood;
        }
    }
}
