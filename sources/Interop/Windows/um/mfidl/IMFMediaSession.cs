// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("90377834-21D0-4DEE-8214-BA2E3E6C1127")]
    public unsafe partial struct IMFMediaSession
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaSession*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaSession*, uint>)(lpVtbl[1]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaSession*, uint>)(lpVtbl[2]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEvent([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("IMFMediaEvent **")] IMFMediaEvent** ppEvent)
        {
            return ((delegate* stdcall<IMFMediaSession*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFMediaSession*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginGetEvent([NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* stdcall<IMFMediaSession*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaSession*)Unsafe.AsPointer(ref this), pCallback, punkState);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndGetEvent([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("IMFMediaEvent **")] IMFMediaEvent** ppEvent)
        {
            return ((delegate* stdcall<IMFMediaSession*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFMediaSession*)Unsafe.AsPointer(ref this), pResult, ppEvent);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, [NativeTypeName("HRESULT")] int hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
        {
            return ((delegate* stdcall<IMFMediaSession*, uint, Guid*, int, PROPVARIANT*, int>)(lpVtbl[6]))((IMFMediaSession*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopology([NativeTypeName("DWORD")] uint dwSetTopologyFlags, [NativeTypeName("IMFTopology *")] IMFTopology* pTopology)
        {
            return ((delegate* stdcall<IMFMediaSession*, uint, IMFTopology*, int>)(lpVtbl[7]))((IMFMediaSession*)Unsafe.AsPointer(ref this), dwSetTopologyFlags, pTopology);
        }

        [return: NativeTypeName("HRESULT")]
        public int ClearTopologies()
        {
            return ((delegate* stdcall<IMFMediaSession*, int>)(lpVtbl[8]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("const GUID *")] Guid* pguidTimeFormat, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition)
        {
            return ((delegate* stdcall<IMFMediaSession*, Guid*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFMediaSession*)Unsafe.AsPointer(ref this), pguidTimeFormat, pvarStartPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* stdcall<IMFMediaSession*, int>)(lpVtbl[10]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* stdcall<IMFMediaSession*, int>)(lpVtbl[11]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* stdcall<IMFMediaSession*, int>)(lpVtbl[12]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* stdcall<IMFMediaSession*, int>)(lpVtbl[13]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClock([NativeTypeName("IMFClock **")] IMFClock** ppClock)
        {
            return ((delegate* stdcall<IMFMediaSession*, IMFClock**, int>)(lpVtbl[14]))((IMFMediaSession*)Unsafe.AsPointer(ref this), ppClock);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSessionCapabilities([NativeTypeName("DWORD *")] uint* pdwCaps)
        {
            return ((delegate* stdcall<IMFMediaSession*, uint*, int>)(lpVtbl[15]))((IMFMediaSession*)Unsafe.AsPointer(ref this), pdwCaps);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFullTopology([NativeTypeName("DWORD")] uint dwGetFullTopologyFlags, [NativeTypeName("TOPOID")] ulong TopoId, [NativeTypeName("IMFTopology **")] IMFTopology** ppFullTopology)
        {
            return ((delegate* stdcall<IMFMediaSession*, uint, ulong, IMFTopology**, int>)(lpVtbl[16]))((IMFMediaSession*)Unsafe.AsPointer(ref this), dwGetFullTopologyFlags, TopoId, ppFullTopology);
        }
    }
}
