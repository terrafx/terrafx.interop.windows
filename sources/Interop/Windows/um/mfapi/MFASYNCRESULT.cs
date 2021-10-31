// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct tagMFASYNCRESULT : IMFAsyncResult")]
    [NativeInheritance("IMFAsyncResult")]
    public unsafe partial struct MFASYNCRESULT
    {
        public void** lpVtbl;

        public OVERLAPPED overlapped;

        public IMFAsyncCallback* pCallback;

        public HRESULT hrStatusResult;

        [NativeTypeName("DWORD")]
        public uint dwBytesTransferred;

        [NativeTypeName("HANDLE")]
        public IntPtr hEvent;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<MFASYNCRESULT*, Guid*, void**, int>)(lpVtbl[0]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<MFASYNCRESULT*, uint>)(lpVtbl[1]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<MFASYNCRESULT*, uint>)(lpVtbl[2]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetState(IUnknown** ppunkState)
        {
            return ((delegate* unmanaged<MFASYNCRESULT*, IUnknown**, int>)(lpVtbl[3]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this), ppunkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetStatus()
        {
            return ((delegate* unmanaged<MFASYNCRESULT*, int>)(lpVtbl[4]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetStatus(HRESULT hrStatus)
        {
            return ((delegate* unmanaged<MFASYNCRESULT*, HRESULT, int>)(lpVtbl[5]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this), hrStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetObject(IUnknown** ppObject)
        {
            return ((delegate* unmanaged<MFASYNCRESULT*, IUnknown**, int>)(lpVtbl[6]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this), ppObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public IUnknown* GetStateNoAddRef()
        {
            return ((delegate* unmanaged<MFASYNCRESULT*, IUnknown*>)(lpVtbl[7]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this));
        }
    }
}
