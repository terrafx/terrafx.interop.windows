// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct tagMFASYNCRESULT : IMFAsyncResult")]
    public unsafe partial struct MFASYNCRESULT
    {
        public void** lpVtbl;

        public OVERLAPPED overlapped;

        [NativeTypeName("IMFAsyncCallback *")]
        public IMFAsyncCallback* pCallback;

        [NativeTypeName("HRESULT")]
        public int hrStatusResult;

        [NativeTypeName("DWORD")]
        public uint dwBytesTransferred;

        [NativeTypeName("HANDLE")]
        public IntPtr hEvent;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<MFASYNCRESULT*, Guid*, void**, int>)(lpVtbl[0]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<MFASYNCRESULT*, uint>)(lpVtbl[1]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<MFASYNCRESULT*, uint>)(lpVtbl[2]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("IUnknown **")] IUnknown** ppunkState)
        {
            return ((delegate* stdcall<MFASYNCRESULT*, IUnknown**, int>)(lpVtbl[3]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this), ppunkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus()
        {
            return ((delegate* stdcall<MFASYNCRESULT*, int>)(lpVtbl[4]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStatus([NativeTypeName("HRESULT")] int hrStatus)
        {
            return ((delegate* stdcall<MFASYNCRESULT*, int, int>)(lpVtbl[5]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this), hrStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetObject([NativeTypeName("IUnknown **")] IUnknown** ppObject)
        {
            return ((delegate* stdcall<MFASYNCRESULT*, IUnknown**, int>)(lpVtbl[6]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this), ppObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("IUnknown *")]
        public IUnknown* GetStateNoAddRef()
        {
            return ((delegate* stdcall<MFASYNCRESULT*, IUnknown*>)(lpVtbl[7]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this));
        }
    }
}
