// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("7FF12CCE-F76F-41C2-863B-1666C8E5E139")]
    [NativeTypeName("struct IMFPresentationTimeSource : IMFClock")]
    [NativeInheritance("IMFClock")]
    public unsafe partial struct IMFPresentationTimeSource : IMFPresentationTimeSource.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFPresentationTimeSource*, Guid*, void**, int>)(lpVtbl[0]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFPresentationTimeSource*, uint>)(lpVtbl[1]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFPresentationTimeSource*, uint>)(lpVtbl[2]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetClockCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
        {
            return ((delegate* unmanaged<IMFPresentationTimeSource*, uint*, int>)(lpVtbl[3]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this), pdwCharacteristics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCorrelatedTime([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LONGLONG *")] long* pllClockTime, [NativeTypeName("MFTIME *")] long* phnsSystemTime)
        {
            return ((delegate* unmanaged<IMFPresentationTimeSource*, uint, long*, long*, int>)(lpVtbl[4]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this), dwReserved, pllClockTime, phnsSystemTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetContinuityKey([NativeTypeName("DWORD *")] uint* pdwContinuityKey)
        {
            return ((delegate* unmanaged<IMFPresentationTimeSource*, uint*, int>)(lpVtbl[5]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this), pdwContinuityKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetState([NativeTypeName("DWORD")] uint dwReserved, MFCLOCK_STATE* peClockState)
        {
            return ((delegate* unmanaged<IMFPresentationTimeSource*, uint, MFCLOCK_STATE*, int>)(lpVtbl[6]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this), dwReserved, peClockState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetProperties(MFCLOCK_PROPERTIES* pClockProperties)
        {
            return ((delegate* unmanaged<IMFPresentationTimeSource*, MFCLOCK_PROPERTIES*, int>)(lpVtbl[7]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this), pClockProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetUnderlyingClock(IMFClock** ppClock)
        {
            return ((delegate* unmanaged<IMFPresentationTimeSource*, IMFClock**, int>)(lpVtbl[8]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this), ppClock);
        }

        public interface Interface : IMFClock.Interface
        {
            [VtblIndex(8)]
            HRESULT GetUnderlyingClock(IMFClock** ppClock);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationTimeSource*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationTimeSource*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationTimeSource*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationTimeSource*, uint*, int> GetClockCharacteristics;

            [NativeTypeName("HRESULT (DWORD, LONGLONG *, MFTIME *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationTimeSource*, uint, long*, long*, int> GetCorrelatedTime;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationTimeSource*, uint*, int> GetContinuityKey;

            [NativeTypeName("HRESULT (DWORD, MFCLOCK_STATE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationTimeSource*, uint, MFCLOCK_STATE*, int> GetState;

            [NativeTypeName("HRESULT (MFCLOCK_PROPERTIES *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationTimeSource*, MFCLOCK_PROPERTIES*, int> GetProperties;

            [NativeTypeName("HRESULT (IMFClock **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationTimeSource*, IMFClock**, int> GetUnderlyingClock;
        }
    }
}
