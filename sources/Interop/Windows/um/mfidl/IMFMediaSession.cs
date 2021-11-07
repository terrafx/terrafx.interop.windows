// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("90377834-21D0-4DEE-8214-BA2E3E6C1127")]
    [NativeTypeName("struct IMFMediaSession : IMFMediaEventGenerator")]
    [NativeInheritance("IMFMediaEventGenerator")]
    public unsafe partial struct IMFMediaSession : IMFMediaSession.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaSession*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaSession*, uint>)(lpVtbl[1]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaSession*, uint>)(lpVtbl[2]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent** ppEvent)
        {
            return ((delegate* unmanaged<IMFMediaSession*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFMediaSession*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT BeginGetEvent(IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFMediaSession*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaSession*)Unsafe.AsPointer(ref this), pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT EndGetEvent(IMFAsyncResult* pResult, IMFMediaEvent** ppEvent)
        {
            return ((delegate* unmanaged<IMFMediaSession*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFMediaSession*)Unsafe.AsPointer(ref this), pResult, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, HRESULT hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
        {
            return ((delegate* unmanaged<IMFMediaSession*, uint, Guid*, HRESULT, PROPVARIANT*, int>)(lpVtbl[6]))((IMFMediaSession*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetTopology([NativeTypeName("DWORD")] uint dwSetTopologyFlags, IMFTopology* pTopology)
        {
            return ((delegate* unmanaged<IMFMediaSession*, uint, IMFTopology*, int>)(lpVtbl[7]))((IMFMediaSession*)Unsafe.AsPointer(ref this), dwSetTopologyFlags, pTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT ClearTopologies()
        {
            return ((delegate* unmanaged<IMFMediaSession*, int>)(lpVtbl[8]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Start([NativeTypeName("const GUID *")] Guid* pguidTimeFormat, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition)
        {
            return ((delegate* unmanaged<IMFMediaSession*, Guid*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFMediaSession*)Unsafe.AsPointer(ref this), pguidTimeFormat, pvarStartPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Pause()
        {
            return ((delegate* unmanaged<IMFMediaSession*, int>)(lpVtbl[10]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Stop()
        {
            return ((delegate* unmanaged<IMFMediaSession*, int>)(lpVtbl[11]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Close()
        {
            return ((delegate* unmanaged<IMFMediaSession*, int>)(lpVtbl[12]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Shutdown()
        {
            return ((delegate* unmanaged<IMFMediaSession*, int>)(lpVtbl[13]))((IMFMediaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetClock(IMFClock** ppClock)
        {
            return ((delegate* unmanaged<IMFMediaSession*, IMFClock**, int>)(lpVtbl[14]))((IMFMediaSession*)Unsafe.AsPointer(ref this), ppClock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetSessionCapabilities([NativeTypeName("DWORD *")] uint* pdwCaps)
        {
            return ((delegate* unmanaged<IMFMediaSession*, uint*, int>)(lpVtbl[15]))((IMFMediaSession*)Unsafe.AsPointer(ref this), pdwCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetFullTopology([NativeTypeName("DWORD")] uint dwGetFullTopologyFlags, [NativeTypeName("TOPOID")] ulong TopoId, IMFTopology** ppFullTopology)
        {
            return ((delegate* unmanaged<IMFMediaSession*, uint, ulong, IMFTopology**, int>)(lpVtbl[16]))((IMFMediaSession*)Unsafe.AsPointer(ref this), dwGetFullTopologyFlags, TopoId, ppFullTopology);
        }

        public interface Interface : IMFMediaEventGenerator.Interface
        {
            [VtblIndex(7)]
            HRESULT SetTopology([NativeTypeName("DWORD")] uint dwSetTopologyFlags, IMFTopology* pTopology);

            [VtblIndex(8)]
            HRESULT ClearTopologies();

            [VtblIndex(9)]
            HRESULT Start([NativeTypeName("const GUID *")] Guid* pguidTimeFormat, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition);

            [VtblIndex(10)]
            HRESULT Pause();

            [VtblIndex(11)]
            HRESULT Stop();

            [VtblIndex(12)]
            HRESULT Close();

            [VtblIndex(13)]
            HRESULT Shutdown();

            [VtblIndex(14)]
            HRESULT GetClock(IMFClock** ppClock);

            [VtblIndex(15)]
            HRESULT GetSessionCapabilities([NativeTypeName("DWORD *")] uint* pdwCaps);

            [VtblIndex(16)]
            HRESULT GetFullTopology([NativeTypeName("DWORD")] uint dwGetFullTopologyFlags, [NativeTypeName("TOPOID")] ulong TopoId, IMFTopology** ppFullTopology);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, IMFMediaEvent **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, uint, IMFMediaEvent**, int> GetEvent;

            [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, IMFAsyncCallback*, IUnknown*, int> BeginGetEvent;

            [NativeTypeName("HRESULT (IMFAsyncResult *, IMFMediaEvent **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, IMFAsyncResult*, IMFMediaEvent**, int> EndGetEvent;

            [NativeTypeName("HRESULT (MediaEventType, const GUID &, HRESULT, const PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, uint, Guid*, HRESULT, PROPVARIANT*, int> QueueEvent;

            [NativeTypeName("HRESULT (DWORD, IMFTopology *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, uint, IMFTopology*, int> SetTopology;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, int> ClearTopologies;

            [NativeTypeName("HRESULT (const GUID *, const PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, Guid*, PROPVARIANT*, int> Start;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, int> Pause;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, int> Stop;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, int> Close;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, int> Shutdown;

            [NativeTypeName("HRESULT (IMFClock **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, IMFClock**, int> GetClock;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, uint*, int> GetSessionCapabilities;

            [NativeTypeName("HRESULT (DWORD, TOPOID, IMFTopology **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSession*, uint, ulong, IMFTopology**, int> GetFullTopology;
        }
    }
}
