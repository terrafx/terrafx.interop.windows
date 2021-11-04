// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6A2E0670-28E4-11D0-A18C-00A0C9118956")]
    [NativeTypeName("struct IAMVideoControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMVideoControl : IAMVideoControl.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMVideoControl*, Guid*, void**, int>)(lpVtbl[0]))((IAMVideoControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMVideoControl*, uint>)(lpVtbl[1]))((IAMVideoControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMVideoControl*, uint>)(lpVtbl[2]))((IAMVideoControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCaps(IPin* pPin, [NativeTypeName("long *")] int* pCapsFlags)
        {
            return ((delegate* unmanaged<IAMVideoControl*, IPin*, int*, int>)(lpVtbl[3]))((IAMVideoControl*)Unsafe.AsPointer(ref this), pPin, pCapsFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetMode(IPin* pPin, [NativeTypeName("long")] int Mode)
        {
            return ((delegate* unmanaged<IAMVideoControl*, IPin*, int, int>)(lpVtbl[4]))((IAMVideoControl*)Unsafe.AsPointer(ref this), pPin, Mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetMode(IPin* pPin, [NativeTypeName("long *")] int* Mode)
        {
            return ((delegate* unmanaged<IAMVideoControl*, IPin*, int*, int>)(lpVtbl[5]))((IAMVideoControl*)Unsafe.AsPointer(ref this), pPin, Mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetCurrentActualFrameRate(IPin* pPin, [NativeTypeName("LONGLONG *")] long* ActualFrameRate)
        {
            return ((delegate* unmanaged<IAMVideoControl*, IPin*, long*, int>)(lpVtbl[6]))((IAMVideoControl*)Unsafe.AsPointer(ref this), pPin, ActualFrameRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetMaxAvailableFrameRate(IPin* pPin, [NativeTypeName("long")] int iIndex, SIZE Dimensions, [NativeTypeName("LONGLONG *")] long* MaxAvailableFrameRate)
        {
            return ((delegate* unmanaged<IAMVideoControl*, IPin*, int, SIZE, long*, int>)(lpVtbl[7]))((IAMVideoControl*)Unsafe.AsPointer(ref this), pPin, iIndex, Dimensions, MaxAvailableFrameRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetFrameRateList(IPin* pPin, [NativeTypeName("long")] int iIndex, SIZE Dimensions, [NativeTypeName("long *")] int* ListSize, [NativeTypeName("LONGLONG **")] long** FrameRates)
        {
            return ((delegate* unmanaged<IAMVideoControl*, IPin*, int, SIZE, int*, long**, int>)(lpVtbl[8]))((IAMVideoControl*)Unsafe.AsPointer(ref this), pPin, iIndex, Dimensions, ListSize, FrameRates);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetCaps(IPin* pPin, [NativeTypeName("long *")] int* pCapsFlags);

            [VtblIndex(4)]
            HRESULT SetMode(IPin* pPin, [NativeTypeName("long")] int Mode);

            [VtblIndex(5)]
            HRESULT GetMode(IPin* pPin, [NativeTypeName("long *")] int* Mode);

            [VtblIndex(6)]
            HRESULT GetCurrentActualFrameRate(IPin* pPin, [NativeTypeName("LONGLONG *")] long* ActualFrameRate);

            [VtblIndex(7)]
            HRESULT GetMaxAvailableFrameRate(IPin* pPin, [NativeTypeName("long")] int iIndex, SIZE Dimensions, [NativeTypeName("LONGLONG *")] long* MaxAvailableFrameRate);

            [VtblIndex(8)]
            HRESULT GetFrameRateList(IPin* pPin, [NativeTypeName("long")] int iIndex, SIZE Dimensions, [NativeTypeName("long *")] int* ListSize, [NativeTypeName("LONGLONG **")] long** FrameRates);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMVideoControl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMVideoControl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMVideoControl*, uint> Release;

            [NativeTypeName("HRESULT (IPin *, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMVideoControl*, IPin*, int*, int> GetCaps;

            [NativeTypeName("HRESULT (IPin *, long) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMVideoControl*, IPin*, int, int> SetMode;

            [NativeTypeName("HRESULT (IPin *, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMVideoControl*, IPin*, int*, int> GetMode;

            [NativeTypeName("HRESULT (IPin *, LONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMVideoControl*, IPin*, long*, int> GetCurrentActualFrameRate;

            [NativeTypeName("HRESULT (IPin *, long, SIZE, LONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMVideoControl*, IPin*, int, SIZE, long*, int> GetMaxAvailableFrameRate;

            [NativeTypeName("HRESULT (IPin *, long, SIZE, long *, LONGLONG **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMVideoControl*, IPin*, int, SIZE, int*, long**, int> GetFrameRateList;
        }
    }
}
