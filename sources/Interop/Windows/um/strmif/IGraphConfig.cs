// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("03A1EB8E-32BF-4245-8502-114D08A9CB88")]
    [NativeTypeName("struct IGraphConfig : IUnknown")]
    public unsafe partial struct IGraphConfig
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IGraphConfig*, Guid*, void**, int>)(lpVtbl[0]))((IGraphConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IGraphConfig*, uint>)(lpVtbl[1]))((IGraphConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IGraphConfig*, uint>)(lpVtbl[2]))((IGraphConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reconnect([NativeTypeName("IPin *")] IPin* pOutputPin, [NativeTypeName("IPin *")] IPin* pInputPin, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmtFirstConnection, [NativeTypeName("IBaseFilter *")] IBaseFilter* pUsingFilter, [NativeTypeName("HANDLE")] IntPtr hAbortEvent, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IGraphConfig*, IPin*, IPin*, AM_MEDIA_TYPE*, IBaseFilter*, IntPtr, uint, int>)(lpVtbl[3]))((IGraphConfig*)Unsafe.AsPointer(ref this), pOutputPin, pInputPin, pmtFirstConnection, pUsingFilter, hAbortEvent, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reconfigure([NativeTypeName("IGraphConfigCallback *")] IGraphConfigCallback* pCallback, [NativeTypeName("PVOID")] void* pvContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hAbortEvent)
        {
            return ((delegate* unmanaged[Stdcall]<IGraphConfig*, IGraphConfigCallback*, void*, uint, IntPtr, int>)(lpVtbl[4]))((IGraphConfig*)Unsafe.AsPointer(ref this), pCallback, pvContext, dwFlags, hAbortEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddFilterToCache([NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter)
        {
            return ((delegate* unmanaged[Stdcall]<IGraphConfig*, IBaseFilter*, int>)(lpVtbl[5]))((IGraphConfig*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumCacheFilter([NativeTypeName("IEnumFilters **")] IEnumFilters** pEnum)
        {
            return ((delegate* unmanaged[Stdcall]<IGraphConfig*, IEnumFilters**, int>)(lpVtbl[6]))((IGraphConfig*)Unsafe.AsPointer(ref this), pEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveFilterFromCache([NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter)
        {
            return ((delegate* unmanaged[Stdcall]<IGraphConfig*, IBaseFilter*, int>)(lpVtbl[7]))((IGraphConfig*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStartTime([NativeTypeName("REFERENCE_TIME *")] long* prtStart)
        {
            return ((delegate* unmanaged[Stdcall]<IGraphConfig*, long*, int>)(lpVtbl[8]))((IGraphConfig*)Unsafe.AsPointer(ref this), prtStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PushThroughData([NativeTypeName("IPin *")] IPin* pOutputPin, [NativeTypeName("IPinConnection *")] IPinConnection* pConnection, [NativeTypeName("HANDLE")] IntPtr hEventAbort)
        {
            return ((delegate* unmanaged[Stdcall]<IGraphConfig*, IPin*, IPinConnection*, IntPtr, int>)(lpVtbl[9]))((IGraphConfig*)Unsafe.AsPointer(ref this), pOutputPin, pConnection, hEventAbort);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFilterFlags([NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IGraphConfig*, IBaseFilter*, uint, int>)(lpVtbl[10]))((IGraphConfig*)Unsafe.AsPointer(ref this), pFilter, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFilterFlags([NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IGraphConfig*, IBaseFilter*, uint*, int>)(lpVtbl[11]))((IGraphConfig*)Unsafe.AsPointer(ref this), pFilter, pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveFilterEx([NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged[Stdcall]<IGraphConfig*, IBaseFilter*, uint, int>)(lpVtbl[12]))((IGraphConfig*)Unsafe.AsPointer(ref this), pFilter, Flags);
        }
    }
}
