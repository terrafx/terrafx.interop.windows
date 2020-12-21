// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6A2E0670-28E4-11D0-A18C-00A0C9118956")]
    [NativeTypeName("struct IAMVideoControl : IUnknown")]
    public unsafe partial struct IAMVideoControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoControl*, Guid*, void**, int>)(lpVtbl[0]))((IAMVideoControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoControl*, uint>)(lpVtbl[1]))((IAMVideoControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoControl*, uint>)(lpVtbl[2]))((IAMVideoControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCaps([NativeTypeName("IPin *")] IPin* pPin, [NativeTypeName("long *")] int* pCapsFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoControl*, IPin*, int*, int>)(lpVtbl[3]))((IAMVideoControl*)Unsafe.AsPointer(ref this), pPin, pCapsFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMode([NativeTypeName("IPin *")] IPin* pPin, [NativeTypeName("long")] int Mode)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoControl*, IPin*, int, int>)(lpVtbl[4]))((IAMVideoControl*)Unsafe.AsPointer(ref this), pPin, Mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMode([NativeTypeName("IPin *")] IPin* pPin, [NativeTypeName("long *")] int* Mode)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoControl*, IPin*, int*, int>)(lpVtbl[5]))((IAMVideoControl*)Unsafe.AsPointer(ref this), pPin, Mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentActualFrameRate([NativeTypeName("IPin *")] IPin* pPin, [NativeTypeName("LONGLONG *")] long* ActualFrameRate)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoControl*, IPin*, long*, int>)(lpVtbl[6]))((IAMVideoControl*)Unsafe.AsPointer(ref this), pPin, ActualFrameRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaxAvailableFrameRate([NativeTypeName("IPin *")] IPin* pPin, [NativeTypeName("long")] int iIndex, SIZE Dimensions, [NativeTypeName("LONGLONG *")] long* MaxAvailableFrameRate)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoControl*, IPin*, int, SIZE, long*, int>)(lpVtbl[7]))((IAMVideoControl*)Unsafe.AsPointer(ref this), pPin, iIndex, Dimensions, MaxAvailableFrameRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameRateList([NativeTypeName("IPin *")] IPin* pPin, [NativeTypeName("long")] int iIndex, SIZE Dimensions, [NativeTypeName("long *")] int* ListSize, [NativeTypeName("LONGLONG **")] long** FrameRates)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoControl*, IPin*, int, SIZE, int*, long**, int>)(lpVtbl[8]))((IAMVideoControl*)Unsafe.AsPointer(ref this), pPin, iIndex, Dimensions, ListSize, FrameRates);
        }
    }
}
