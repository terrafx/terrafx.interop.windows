// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5B87EF6A-7ED8-434F-BA0E-184FAC1628D1")]
    [NativeTypeName("struct IMFNetCredential : IUnknown")]
    public unsafe partial struct IMFNetCredential
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFNetCredential*, Guid*, void**, int>)(lpVtbl[0]))((IMFNetCredential*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFNetCredential*, uint>)(lpVtbl[1]))((IMFNetCredential*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFNetCredential*, uint>)(lpVtbl[2]))((IMFNetCredential*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUser([NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("BOOL")] int fDataIsEncrypted)
        {
            return ((delegate* stdcall<IMFNetCredential*, byte*, uint, int, int>)(lpVtbl[3]))((IMFNetCredential*)Unsafe.AsPointer(ref this), pbData, cbData, fDataIsEncrypted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPassword([NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("BOOL")] int fDataIsEncrypted)
        {
            return ((delegate* stdcall<IMFNetCredential*, byte*, uint, int, int>)(lpVtbl[4]))((IMFNetCredential*)Unsafe.AsPointer(ref this), pbData, cbData, fDataIsEncrypted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUser([NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("BOOL")] int fEncryptData)
        {
            return ((delegate* stdcall<IMFNetCredential*, byte*, uint*, int, int>)(lpVtbl[5]))((IMFNetCredential*)Unsafe.AsPointer(ref this), pbData, pcbData, fEncryptData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPassword([NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("BOOL")] int fEncryptData)
        {
            return ((delegate* stdcall<IMFNetCredential*, byte*, uint*, int, int>)(lpVtbl[6]))((IMFNetCredential*)Unsafe.AsPointer(ref this), pbData, pcbData, fEncryptData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoggedOnUser([NativeTypeName("BOOL *")] int* pfLoggedOnUser)
        {
            return ((delegate* stdcall<IMFNetCredential*, int*, int>)(lpVtbl[7]))((IMFNetCredential*)Unsafe.AsPointer(ref this), pfLoggedOnUser);
        }
    }
}
