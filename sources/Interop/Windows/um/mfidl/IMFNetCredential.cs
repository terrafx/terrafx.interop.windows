// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5B87EF6A-7ED8-434F-BA0E-184FAC1628D1")]
    [NativeTypeName("struct IMFNetCredential : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFNetCredential
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFNetCredential*, Guid*, void**, int>)(lpVtbl[0]))((IMFNetCredential*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFNetCredential*, uint>)(lpVtbl[1]))((IMFNetCredential*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFNetCredential*, uint>)(lpVtbl[2]))((IMFNetCredential*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetUser([NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint cbData, BOOL fDataIsEncrypted)
        {
            return ((delegate* unmanaged<IMFNetCredential*, byte*, uint, BOOL, int>)(lpVtbl[3]))((IMFNetCredential*)Unsafe.AsPointer(ref this), pbData, cbData, fDataIsEncrypted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPassword([NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint cbData, BOOL fDataIsEncrypted)
        {
            return ((delegate* unmanaged<IMFNetCredential*, byte*, uint, BOOL, int>)(lpVtbl[4]))((IMFNetCredential*)Unsafe.AsPointer(ref this), pbData, cbData, fDataIsEncrypted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetUser([NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pcbData, BOOL fEncryptData)
        {
            return ((delegate* unmanaged<IMFNetCredential*, byte*, uint*, BOOL, int>)(lpVtbl[5]))((IMFNetCredential*)Unsafe.AsPointer(ref this), pbData, pcbData, fEncryptData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetPassword([NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pcbData, BOOL fEncryptData)
        {
            return ((delegate* unmanaged<IMFNetCredential*, byte*, uint*, BOOL, int>)(lpVtbl[6]))((IMFNetCredential*)Unsafe.AsPointer(ref this), pbData, pcbData, fEncryptData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int LoggedOnUser(BOOL* pfLoggedOnUser)
        {
            return ((delegate* unmanaged<IMFNetCredential*, BOOL*, int>)(lpVtbl[7]))((IMFNetCredential*)Unsafe.AsPointer(ref this), pfLoggedOnUser);
        }
    }
}
