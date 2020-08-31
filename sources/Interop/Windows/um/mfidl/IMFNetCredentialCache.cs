// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5B87EF6C-7ED8-434F-BA0E-184FAC1628D1")]
    [NativeTypeName("struct IMFNetCredentialCache : IUnknown")]
    public unsafe partial struct IMFNetCredentialCache
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFNetCredentialCache*, Guid*, void**, int>)(lpVtbl[0]))((IMFNetCredentialCache*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFNetCredentialCache*, uint>)(lpVtbl[1]))((IMFNetCredentialCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFNetCredentialCache*, uint>)(lpVtbl[2]))((IMFNetCredentialCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCredential([NativeTypeName("LPCWSTR")] ushort* pszUrl, [NativeTypeName("LPCWSTR")] ushort* pszRealm, [NativeTypeName("DWORD")] uint dwAuthenticationFlags, [NativeTypeName("IMFNetCredential **")] IMFNetCredential** ppCred, [NativeTypeName("DWORD *")] uint* pdwRequirementsFlags)
        {
            return ((delegate* stdcall<IMFNetCredentialCache*, ushort*, ushort*, uint, IMFNetCredential**, uint*, int>)(lpVtbl[3]))((IMFNetCredentialCache*)Unsafe.AsPointer(ref this), pszUrl, pszRealm, dwAuthenticationFlags, ppCred, pdwRequirementsFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGood([NativeTypeName("IMFNetCredential *")] IMFNetCredential* pCred, [NativeTypeName("BOOL")] int fGood)
        {
            return ((delegate* stdcall<IMFNetCredentialCache*, IMFNetCredential*, int, int>)(lpVtbl[4]))((IMFNetCredentialCache*)Unsafe.AsPointer(ref this), pCred, fGood);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUserOptions([NativeTypeName("IMFNetCredential *")] IMFNetCredential* pCred, [NativeTypeName("DWORD")] uint dwOptionsFlags)
        {
            return ((delegate* stdcall<IMFNetCredentialCache*, IMFNetCredential*, uint, int>)(lpVtbl[5]))((IMFNetCredentialCache*)Unsafe.AsPointer(ref this), pCred, dwOptionsFlags);
        }
    }
}
