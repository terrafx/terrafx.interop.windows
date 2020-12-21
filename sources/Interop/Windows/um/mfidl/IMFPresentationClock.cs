// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("868CE85C-8EA9-4F55-AB82-B009A910A805")]
    [NativeTypeName("struct IMFPresentationClock : IMFClock")]
    public unsafe partial struct IMFPresentationClock
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFPresentationClock*, Guid*, void**, int>)(lpVtbl[0]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFPresentationClock*, uint>)(lpVtbl[1]))((IMFPresentationClock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFPresentationClock*, uint>)(lpVtbl[2]))((IMFPresentationClock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClockCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
        {
            return ((delegate* unmanaged<IMFPresentationClock*, uint*, int>)(lpVtbl[3]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), pdwCharacteristics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCorrelatedTime([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LONGLONG *")] long* pllClockTime, [NativeTypeName("MFTIME *")] long* phnsSystemTime)
        {
            return ((delegate* unmanaged<IMFPresentationClock*, uint, long*, long*, int>)(lpVtbl[4]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), dwReserved, pllClockTime, phnsSystemTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContinuityKey([NativeTypeName("DWORD *")] uint* pdwContinuityKey)
        {
            return ((delegate* unmanaged<IMFPresentationClock*, uint*, int>)(lpVtbl[5]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), pdwContinuityKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("MFCLOCK_STATE *")] MFCLOCK_STATE* peClockState)
        {
            return ((delegate* unmanaged<IMFPresentationClock*, uint, MFCLOCK_STATE*, int>)(lpVtbl[6]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), dwReserved, peClockState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperties([NativeTypeName("MFCLOCK_PROPERTIES *")] MFCLOCK_PROPERTIES* pClockProperties)
        {
            return ((delegate* unmanaged<IMFPresentationClock*, MFCLOCK_PROPERTIES*, int>)(lpVtbl[7]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), pClockProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTimeSource([NativeTypeName("IMFPresentationTimeSource *")] IMFPresentationTimeSource* pTimeSource)
        {
            return ((delegate* unmanaged<IMFPresentationClock*, IMFPresentationTimeSource*, int>)(lpVtbl[8]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), pTimeSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTimeSource([NativeTypeName("IMFPresentationTimeSource **")] IMFPresentationTimeSource** ppTimeSource)
        {
            return ((delegate* unmanaged<IMFPresentationClock*, IMFPresentationTimeSource**, int>)(lpVtbl[9]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), ppTimeSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTime([NativeTypeName("MFTIME *")] long* phnsClockTime)
        {
            return ((delegate* unmanaged<IMFPresentationClock*, long*, int>)(lpVtbl[10]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), phnsClockTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddClockStateSink([NativeTypeName("IMFClockStateSink *")] IMFClockStateSink* pStateSink)
        {
            return ((delegate* unmanaged<IMFPresentationClock*, IMFClockStateSink*, int>)(lpVtbl[11]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), pStateSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveClockStateSink([NativeTypeName("IMFClockStateSink *")] IMFClockStateSink* pStateSink)
        {
            return ((delegate* unmanaged<IMFPresentationClock*, IMFClockStateSink*, int>)(lpVtbl[12]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), pStateSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("LONGLONG")] long llClockStartOffset)
        {
            return ((delegate* unmanaged<IMFPresentationClock*, long, int>)(lpVtbl[13]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), llClockStartOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<IMFPresentationClock*, int>)(lpVtbl[14]))((IMFPresentationClock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* unmanaged<IMFPresentationClock*, int>)(lpVtbl[15]))((IMFPresentationClock*)Unsafe.AsPointer(ref this));
        }
    }
}
