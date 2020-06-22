// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7FF12CCE-F76F-41C2-863B-1666C8E5E139")]
    public unsafe partial struct IMFPresentationTimeSource
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFPresentationTimeSource*, Guid*, void**, int>)(lpVtbl[0]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFPresentationTimeSource*, uint>)(lpVtbl[1]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFPresentationTimeSource*, uint>)(lpVtbl[2]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClockCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
        {
            return ((delegate* stdcall<IMFPresentationTimeSource*, uint*, int>)(lpVtbl[3]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this), pdwCharacteristics);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCorrelatedTime([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LONGLONG *")] long* pllClockTime, [NativeTypeName("MFTIME *")] long* phnsSystemTime)
        {
            return ((delegate* stdcall<IMFPresentationTimeSource*, uint, long*, long*, int>)(lpVtbl[4]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this), dwReserved, pllClockTime, phnsSystemTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContinuityKey([NativeTypeName("DWORD *")] uint* pdwContinuityKey)
        {
            return ((delegate* stdcall<IMFPresentationTimeSource*, uint*, int>)(lpVtbl[5]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this), pdwContinuityKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("MFCLOCK_STATE *")] MFCLOCK_STATE* peClockState)
        {
            return ((delegate* stdcall<IMFPresentationTimeSource*, uint, MFCLOCK_STATE*, int>)(lpVtbl[6]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this), dwReserved, peClockState);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProperties([NativeTypeName("MFCLOCK_PROPERTIES *")] MFCLOCK_PROPERTIES* pClockProperties)
        {
            return ((delegate* stdcall<IMFPresentationTimeSource*, MFCLOCK_PROPERTIES*, int>)(lpVtbl[7]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this), pClockProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnderlyingClock([NativeTypeName("IMFClock **")] IMFClock** ppClock)
        {
            return ((delegate* stdcall<IMFPresentationTimeSource*, IMFClock**, int>)(lpVtbl[8]))((IMFPresentationTimeSource*)Unsafe.AsPointer(ref this), ppClock);
        }
    }
}
