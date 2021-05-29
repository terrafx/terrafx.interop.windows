// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2EB1E945-18B8-4139-9B1A-D5D584818530")]
    [NativeTypeName("struct IMFClock : IUnknown")]
    public unsafe partial struct IMFClock
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFClock*, Guid*, void**, int>)(lpVtbl[0]))((IMFClock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFClock*, uint>)(lpVtbl[1]))((IMFClock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFClock*, uint>)(lpVtbl[2]))((IMFClock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClockCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
        {
            return ((delegate* unmanaged<IMFClock*, uint*, int>)(lpVtbl[3]))((IMFClock*)Unsafe.AsPointer(ref this), pdwCharacteristics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCorrelatedTime([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LONGLONG *")] long* pllClockTime, [NativeTypeName("MFTIME *")] long* phnsSystemTime)
        {
            return ((delegate* unmanaged<IMFClock*, uint, long*, long*, int>)(lpVtbl[4]))((IMFClock*)Unsafe.AsPointer(ref this), dwReserved, pllClockTime, phnsSystemTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContinuityKey([NativeTypeName("DWORD *")] uint* pdwContinuityKey)
        {
            return ((delegate* unmanaged<IMFClock*, uint*, int>)(lpVtbl[5]))((IMFClock*)Unsafe.AsPointer(ref this), pdwContinuityKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("DWORD")] uint dwReserved, MFCLOCK_STATE* peClockState)
        {
            return ((delegate* unmanaged<IMFClock*, uint, MFCLOCK_STATE*, int>)(lpVtbl[6]))((IMFClock*)Unsafe.AsPointer(ref this), dwReserved, peClockState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperties(MFCLOCK_PROPERTIES* pClockProperties)
        {
            return ((delegate* unmanaged<IMFClock*, MFCLOCK_PROPERTIES*, int>)(lpVtbl[7]))((IMFClock*)Unsafe.AsPointer(ref this), pClockProperties);
        }
    }
}
