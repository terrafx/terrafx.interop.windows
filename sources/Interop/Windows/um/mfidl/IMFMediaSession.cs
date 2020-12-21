// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("90377834-21D0-4DEE-8214-BA2E3E6C1127")]
    [NativeTypeName("struct IMFMediaSession : IMFMediaEventGenerator")]
    public unsafe partial struct IMFMediaSession
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, uint>)(lpVtbl[1]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, uint>)(lpVtbl[2]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEvent([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("IMFMediaEvent **")] IMFMediaEvent** ppEvent)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFMediaSession*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginGetEvent([NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaSession*)Unsafe.AsPointer(ref this), pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndGetEvent([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("IMFMediaEvent **")] IMFMediaEvent** ppEvent)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFMediaSession*)Unsafe.AsPointer(ref this), pResult, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, [NativeTypeName("HRESULT")] int hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, uint, Guid*, int, PROPVARIANT*, int>)(lpVtbl[6]))((IMFMediaSession*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTopology([NativeTypeName("DWORD")] uint dwSetTopologyFlags, [NativeTypeName("IMFTopology *")] IMFTopology* pTopology)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, uint, IMFTopology*, int>)(lpVtbl[7]))((IMFMediaSession*)Unsafe.AsPointer(ref this), dwSetTopologyFlags, pTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearTopologies()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, int>)(lpVtbl[8]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("const GUID *")] Guid* pguidTimeFormat, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, Guid*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFMediaSession*)Unsafe.AsPointer(ref this), pguidTimeFormat, pvarStartPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, int>)(lpVtbl[10]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, int>)(lpVtbl[11]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, int>)(lpVtbl[12]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, int>)(lpVtbl[13]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClock([NativeTypeName("IMFClock **")] IMFClock** ppClock)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, IMFClock**, int>)(lpVtbl[14]))((IMFMediaSession*)Unsafe.AsPointer(ref this), ppClock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSessionCapabilities([NativeTypeName("DWORD *")] uint* pdwCaps)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, uint*, int>)(lpVtbl[15]))((IMFMediaSession*)Unsafe.AsPointer(ref this), pdwCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFullTopology([NativeTypeName("DWORD")] uint dwGetFullTopologyFlags, [NativeTypeName("TOPOID")] ulong TopoId, [NativeTypeName("IMFTopology **")] IMFTopology** ppFullTopology)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSession*, uint, ulong, IMFTopology**, int>)(lpVtbl[16]))((IMFMediaSession*)Unsafe.AsPointer(ref this), dwGetFullTopologyFlags, TopoId, ppFullTopology);
        }
    }
}
