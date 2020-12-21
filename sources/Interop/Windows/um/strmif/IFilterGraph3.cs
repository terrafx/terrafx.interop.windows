// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AAF38154-B80B-422F-91E6-B66467509A07")]
    [NativeTypeName("struct IFilterGraph3 : IFilterGraph2")]
    public unsafe partial struct IFilterGraph3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, Guid*, void**, int>)(lpVtbl[0]))((IFilterGraph3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, uint>)(lpVtbl[1]))((IFilterGraph3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, uint>)(lpVtbl[2]))((IFilterGraph3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddFilter([NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter, [NativeTypeName("LPCWSTR")] ushort* pName)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, IBaseFilter*, ushort*, int>)(lpVtbl[3]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pFilter, pName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveFilter([NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, IBaseFilter*, int>)(lpVtbl[4]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumFilters([NativeTypeName("IEnumFilters **")] IEnumFilters** ppEnum)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, IEnumFilters**, int>)(lpVtbl[5]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindFilterByName([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("IBaseFilter **")] IBaseFilter** ppFilter)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, ushort*, IBaseFilter**, int>)(lpVtbl[6]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pName, ppFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ConnectDirect([NativeTypeName("IPin *")] IPin* ppinOut, [NativeTypeName("IPin *")] IPin* ppinIn, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, IPin*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[7]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppinOut, ppinIn, pmt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reconnect([NativeTypeName("IPin *")] IPin* ppin)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, IPin*, int>)(lpVtbl[8]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Disconnect([NativeTypeName("IPin *")] IPin* ppin)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, IPin*, int>)(lpVtbl[9]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultSyncSource()
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, int>)(lpVtbl[10]))((IFilterGraph3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Connect([NativeTypeName("IPin *")] IPin* ppinOut, [NativeTypeName("IPin *")] IPin* ppinIn)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, IPin*, IPin*, int>)(lpVtbl[11]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppinOut, ppinIn);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Render([NativeTypeName("IPin *")] IPin* ppinOut)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, IPin*, int>)(lpVtbl[12]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppinOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RenderFile([NativeTypeName("LPCWSTR")] ushort* lpcwstrFile, [NativeTypeName("LPCWSTR")] ushort* lpcwstrPlayList)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, ushort*, ushort*, int>)(lpVtbl[13]))((IFilterGraph3*)Unsafe.AsPointer(ref this), lpcwstrFile, lpcwstrPlayList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddSourceFilter([NativeTypeName("LPCWSTR")] ushort* lpcwstrFileName, [NativeTypeName("LPCWSTR")] ushort* lpcwstrFilterName, [NativeTypeName("IBaseFilter **")] IBaseFilter** ppFilter)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, ushort*, ushort*, IBaseFilter**, int>)(lpVtbl[14]))((IFilterGraph3*)Unsafe.AsPointer(ref this), lpcwstrFileName, lpcwstrFilterName, ppFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLogFile([NativeTypeName("DWORD_PTR")] nuint hFile)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, nuint, int>)(lpVtbl[15]))((IFilterGraph3*)Unsafe.AsPointer(ref this), hFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Abort()
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, int>)(lpVtbl[16]))((IFilterGraph3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShouldOperationContinue()
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, int>)(lpVtbl[17]))((IFilterGraph3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddSourceFilterForMoniker([NativeTypeName("IMoniker *")] IMoniker* pMoniker, [NativeTypeName("IBindCtx *")] IBindCtx* pCtx, [NativeTypeName("LPCWSTR")] ushort* lpcwstrFilterName, [NativeTypeName("IBaseFilter **")] IBaseFilter** ppFilter)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, IMoniker*, IBindCtx*, ushort*, IBaseFilter**, int>)(lpVtbl[18]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pMoniker, pCtx, lpcwstrFilterName, ppFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReconnectEx([NativeTypeName("IPin *")] IPin* ppin, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[19]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppin, pmt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RenderEx([NativeTypeName("IPin *")] IPin* pPinOut, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pvContext)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, IPin*, uint, uint*, int>)(lpVtbl[20]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pPinOut, dwFlags, pvContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSyncSourceEx([NativeTypeName("IReferenceClock *")] IReferenceClock* pClockForMostOfFilterGraph, [NativeTypeName("IReferenceClock *")] IReferenceClock* pClockForFilter, [NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterGraph3*, IReferenceClock*, IReferenceClock*, IBaseFilter*, int>)(lpVtbl[21]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pClockForMostOfFilterGraph, pClockForFilter, pFilter);
        }
    }
}
