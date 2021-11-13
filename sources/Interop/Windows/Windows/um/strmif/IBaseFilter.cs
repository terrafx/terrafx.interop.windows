// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("56A86895-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IBaseFilter : IMediaFilter")]
    [NativeInheritance("IMediaFilter")]
    public unsafe partial struct IBaseFilter : IBaseFilter.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBaseFilter*, Guid*, void**, int>)(lpVtbl[0]))((IBaseFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBaseFilter*, uint>)(lpVtbl[1]))((IBaseFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBaseFilter*, uint>)(lpVtbl[2]))((IBaseFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IBaseFilter*, Guid*, int>)(lpVtbl[3]))((IBaseFilter*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Stop()
        {
            return ((delegate* unmanaged<IBaseFilter*, int>)(lpVtbl[4]))((IBaseFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Pause()
        {
            return ((delegate* unmanaged<IBaseFilter*, int>)(lpVtbl[5]))((IBaseFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Run([NativeTypeName("REFERENCE_TIME")] long tStart)
        {
            return ((delegate* unmanaged<IBaseFilter*, long, int>)(lpVtbl[6]))((IBaseFilter*)Unsafe.AsPointer(ref this), tStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetState([NativeTypeName("DWORD")] uint dwMilliSecsTimeout, FILTER_STATE* State)
        {
            return ((delegate* unmanaged<IBaseFilter*, uint, FILTER_STATE*, int>)(lpVtbl[7]))((IBaseFilter*)Unsafe.AsPointer(ref this), dwMilliSecsTimeout, State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetSyncSource(IReferenceClock* pClock)
        {
            return ((delegate* unmanaged<IBaseFilter*, IReferenceClock*, int>)(lpVtbl[8]))((IBaseFilter*)Unsafe.AsPointer(ref this), pClock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetSyncSource(IReferenceClock** pClock)
        {
            return ((delegate* unmanaged<IBaseFilter*, IReferenceClock**, int>)(lpVtbl[9]))((IBaseFilter*)Unsafe.AsPointer(ref this), pClock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT EnumPins(IEnumPins** ppEnum)
        {
            return ((delegate* unmanaged<IBaseFilter*, IEnumPins**, int>)(lpVtbl[10]))((IBaseFilter*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT FindPin([NativeTypeName("LPCWSTR")] ushort* Id, IPin** ppPin)
        {
            return ((delegate* unmanaged<IBaseFilter*, ushort*, IPin**, int>)(lpVtbl[11]))((IBaseFilter*)Unsafe.AsPointer(ref this), Id, ppPin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT QueryFilterInfo(FILTER_INFO* pInfo)
        {
            return ((delegate* unmanaged<IBaseFilter*, FILTER_INFO*, int>)(lpVtbl[12]))((IBaseFilter*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT JoinFilterGraph(IFilterGraph* pGraph, [NativeTypeName("LPCWSTR")] ushort* pName)
        {
            return ((delegate* unmanaged<IBaseFilter*, IFilterGraph*, ushort*, int>)(lpVtbl[13]))((IBaseFilter*)Unsafe.AsPointer(ref this), pGraph, pName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT QueryVendorInfo([NativeTypeName("LPWSTR *")] ushort** pVendorInfo)
        {
            return ((delegate* unmanaged<IBaseFilter*, ushort**, int>)(lpVtbl[14]))((IBaseFilter*)Unsafe.AsPointer(ref this), pVendorInfo);
        }

        public interface Interface : IMediaFilter.Interface
        {
            [VtblIndex(10)]
            HRESULT EnumPins(IEnumPins** ppEnum);

            [VtblIndex(11)]
            HRESULT FindPin([NativeTypeName("LPCWSTR")] ushort* Id, IPin** ppPin);

            [VtblIndex(12)]
            HRESULT QueryFilterInfo(FILTER_INFO* pInfo);

            [VtblIndex(13)]
            HRESULT JoinFilterGraph(IFilterGraph* pGraph, [NativeTypeName("LPCWSTR")] ushort* pName);

            [VtblIndex(14)]
            HRESULT QueryVendorInfo([NativeTypeName("LPWSTR *")] ushort** pVendorInfo);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseFilter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseFilter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseFilter*, uint> Release;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseFilter*, Guid*, int> GetClassID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseFilter*, int> Stop;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseFilter*, int> Pause;

            [NativeTypeName("HRESULT (REFERENCE_TIME) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseFilter*, long, int> Run;

            [NativeTypeName("HRESULT (DWORD, FILTER_STATE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseFilter*, uint, FILTER_STATE*, int> GetState;

            [NativeTypeName("HRESULT (IReferenceClock *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseFilter*, IReferenceClock*, int> SetSyncSource;

            [NativeTypeName("HRESULT (IReferenceClock **) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseFilter*, IReferenceClock**, int> GetSyncSource;

            [NativeTypeName("HRESULT (IEnumPins **) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseFilter*, IEnumPins**, int> EnumPins;

            [NativeTypeName("HRESULT (LPCWSTR, IPin **) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseFilter*, ushort*, IPin**, int> FindPin;

            [NativeTypeName("HRESULT (FILTER_INFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseFilter*, FILTER_INFO*, int> QueryFilterInfo;

            [NativeTypeName("HRESULT (IFilterGraph *, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseFilter*, IFilterGraph*, ushort*, int> JoinFilterGraph;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseFilter*, ushort**, int> QueryVendorInfo;
        }
    }
}
