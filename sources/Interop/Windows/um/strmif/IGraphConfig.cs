// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("03A1EB8E-32BF-4245-8502-114D08A9CB88")]
    [NativeTypeName("struct IGraphConfig : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IGraphConfig
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IGraphConfig*, Guid*, void**, int>)(lpVtbl[0]))((IGraphConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGraphConfig*, uint>)(lpVtbl[1]))((IGraphConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGraphConfig*, uint>)(lpVtbl[2]))((IGraphConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Reconnect(IPin* pOutputPin, IPin* pInputPin, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmtFirstConnection, IBaseFilter* pUsingFilter, HANDLE hAbortEvent, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IGraphConfig*, IPin*, IPin*, AM_MEDIA_TYPE*, IBaseFilter*, HANDLE, uint, int>)(lpVtbl[3]))((IGraphConfig*)Unsafe.AsPointer(ref this), pOutputPin, pInputPin, pmtFirstConnection, pUsingFilter, hAbortEvent, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Reconfigure(IGraphConfigCallback* pCallback, [NativeTypeName("PVOID")] void* pvContext, [NativeTypeName("DWORD")] uint dwFlags, HANDLE hAbortEvent)
        {
            return ((delegate* unmanaged<IGraphConfig*, IGraphConfigCallback*, void*, uint, HANDLE, int>)(lpVtbl[4]))((IGraphConfig*)Unsafe.AsPointer(ref this), pCallback, pvContext, dwFlags, hAbortEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddFilterToCache(IBaseFilter* pFilter)
        {
            return ((delegate* unmanaged<IGraphConfig*, IBaseFilter*, int>)(lpVtbl[5]))((IGraphConfig*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT EnumCacheFilter(IEnumFilters** pEnum)
        {
            return ((delegate* unmanaged<IGraphConfig*, IEnumFilters**, int>)(lpVtbl[6]))((IGraphConfig*)Unsafe.AsPointer(ref this), pEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT RemoveFilterFromCache(IBaseFilter* pFilter)
        {
            return ((delegate* unmanaged<IGraphConfig*, IBaseFilter*, int>)(lpVtbl[7]))((IGraphConfig*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetStartTime([NativeTypeName("REFERENCE_TIME *")] long* prtStart)
        {
            return ((delegate* unmanaged<IGraphConfig*, long*, int>)(lpVtbl[8]))((IGraphConfig*)Unsafe.AsPointer(ref this), prtStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT PushThroughData(IPin* pOutputPin, IPinConnection* pConnection, HANDLE hEventAbort)
        {
            return ((delegate* unmanaged<IGraphConfig*, IPin*, IPinConnection*, HANDLE, int>)(lpVtbl[9]))((IGraphConfig*)Unsafe.AsPointer(ref this), pOutputPin, pConnection, hEventAbort);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetFilterFlags(IBaseFilter* pFilter, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IGraphConfig*, IBaseFilter*, uint, int>)(lpVtbl[10]))((IGraphConfig*)Unsafe.AsPointer(ref this), pFilter, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetFilterFlags(IBaseFilter* pFilter, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IGraphConfig*, IBaseFilter*, uint*, int>)(lpVtbl[11]))((IGraphConfig*)Unsafe.AsPointer(ref this), pFilter, pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT RemoveFilterEx(IBaseFilter* pFilter, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IGraphConfig*, IBaseFilter*, uint, int>)(lpVtbl[12]))((IGraphConfig*)Unsafe.AsPointer(ref this), pFilter, Flags);
        }
    }
}
