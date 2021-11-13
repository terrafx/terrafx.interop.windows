// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("AAF38154-B80B-422F-91E6-B66467509A07")]
    [NativeTypeName("struct IFilterGraph3 : IFilterGraph2")]
    [NativeInheritance("IFilterGraph2")]
    public unsafe partial struct IFilterGraph3 : IFilterGraph3.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFilterGraph3*, Guid*, void**, int>)(lpVtbl[0]))((IFilterGraph3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFilterGraph3*, uint>)(lpVtbl[1]))((IFilterGraph3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFilterGraph3*, uint>)(lpVtbl[2]))((IFilterGraph3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddFilter(IBaseFilter* pFilter, [NativeTypeName("LPCWSTR")] ushort* pName)
        {
            return ((delegate* unmanaged<IFilterGraph3*, IBaseFilter*, ushort*, int>)(lpVtbl[3]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pFilter, pName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT RemoveFilter(IBaseFilter* pFilter)
        {
            return ((delegate* unmanaged<IFilterGraph3*, IBaseFilter*, int>)(lpVtbl[4]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT EnumFilters(IEnumFilters** ppEnum)
        {
            return ((delegate* unmanaged<IFilterGraph3*, IEnumFilters**, int>)(lpVtbl[5]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT FindFilterByName([NativeTypeName("LPCWSTR")] ushort* pName, IBaseFilter** ppFilter)
        {
            return ((delegate* unmanaged<IFilterGraph3*, ushort*, IBaseFilter**, int>)(lpVtbl[6]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pName, ppFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ConnectDirect(IPin* ppinOut, IPin* ppinIn, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* unmanaged<IFilterGraph3*, IPin*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[7]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppinOut, ppinIn, pmt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Reconnect(IPin* ppin)
        {
            return ((delegate* unmanaged<IFilterGraph3*, IPin*, int>)(lpVtbl[8]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Disconnect(IPin* ppin)
        {
            return ((delegate* unmanaged<IFilterGraph3*, IPin*, int>)(lpVtbl[9]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetDefaultSyncSource()
        {
            return ((delegate* unmanaged<IFilterGraph3*, int>)(lpVtbl[10]))((IFilterGraph3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Connect(IPin* ppinOut, IPin* ppinIn)
        {
            return ((delegate* unmanaged<IFilterGraph3*, IPin*, IPin*, int>)(lpVtbl[11]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppinOut, ppinIn);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Render(IPin* ppinOut)
        {
            return ((delegate* unmanaged<IFilterGraph3*, IPin*, int>)(lpVtbl[12]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppinOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT RenderFile([NativeTypeName("LPCWSTR")] ushort* lpcwstrFile, [NativeTypeName("LPCWSTR")] ushort* lpcwstrPlayList)
        {
            return ((delegate* unmanaged<IFilterGraph3*, ushort*, ushort*, int>)(lpVtbl[13]))((IFilterGraph3*)Unsafe.AsPointer(ref this), lpcwstrFile, lpcwstrPlayList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT AddSourceFilter([NativeTypeName("LPCWSTR")] ushort* lpcwstrFileName, [NativeTypeName("LPCWSTR")] ushort* lpcwstrFilterName, IBaseFilter** ppFilter)
        {
            return ((delegate* unmanaged<IFilterGraph3*, ushort*, ushort*, IBaseFilter**, int>)(lpVtbl[14]))((IFilterGraph3*)Unsafe.AsPointer(ref this), lpcwstrFileName, lpcwstrFilterName, ppFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetLogFile([NativeTypeName("DWORD_PTR")] nuint hFile)
        {
            return ((delegate* unmanaged<IFilterGraph3*, nuint, int>)(lpVtbl[15]))((IFilterGraph3*)Unsafe.AsPointer(ref this), hFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT Abort()
        {
            return ((delegate* unmanaged<IFilterGraph3*, int>)(lpVtbl[16]))((IFilterGraph3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT ShouldOperationContinue()
        {
            return ((delegate* unmanaged<IFilterGraph3*, int>)(lpVtbl[17]))((IFilterGraph3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT AddSourceFilterForMoniker(IMoniker* pMoniker, IBindCtx* pCtx, [NativeTypeName("LPCWSTR")] ushort* lpcwstrFilterName, IBaseFilter** ppFilter)
        {
            return ((delegate* unmanaged<IFilterGraph3*, IMoniker*, IBindCtx*, ushort*, IBaseFilter**, int>)(lpVtbl[18]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pMoniker, pCtx, lpcwstrFilterName, ppFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT ReconnectEx(IPin* ppin, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* unmanaged<IFilterGraph3*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[19]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppin, pmt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT RenderEx(IPin* pPinOut, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pvContext)
        {
            return ((delegate* unmanaged<IFilterGraph3*, IPin*, uint, uint*, int>)(lpVtbl[20]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pPinOut, dwFlags, pvContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetSyncSourceEx(IReferenceClock* pClockForMostOfFilterGraph, IReferenceClock* pClockForFilter, IBaseFilter* pFilter)
        {
            return ((delegate* unmanaged<IFilterGraph3*, IReferenceClock*, IReferenceClock*, IBaseFilter*, int>)(lpVtbl[21]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pClockForMostOfFilterGraph, pClockForFilter, pFilter);
        }

        public interface Interface : IFilterGraph2.Interface
        {
            [VtblIndex(21)]
            HRESULT SetSyncSourceEx(IReferenceClock* pClockForMostOfFilterGraph, IReferenceClock* pClockForFilter, IBaseFilter* pFilter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, uint> Release;

            [NativeTypeName("HRESULT (IBaseFilter *, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, IBaseFilter*, ushort*, int> AddFilter;

            [NativeTypeName("HRESULT (IBaseFilter *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, IBaseFilter*, int> RemoveFilter;

            [NativeTypeName("HRESULT (IEnumFilters **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, IEnumFilters**, int> EnumFilters;

            [NativeTypeName("HRESULT (LPCWSTR, IBaseFilter **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, ushort*, IBaseFilter**, int> FindFilterByName;

            [NativeTypeName("HRESULT (IPin *, IPin *, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, IPin*, IPin*, AM_MEDIA_TYPE*, int> ConnectDirect;

            [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, IPin*, int> Reconnect;

            [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, IPin*, int> Disconnect;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, int> SetDefaultSyncSource;

            [NativeTypeName("HRESULT (IPin *, IPin *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, IPin*, IPin*, int> Connect;

            [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, IPin*, int> Render;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, ushort*, ushort*, int> RenderFile;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IBaseFilter **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, ushort*, ushort*, IBaseFilter**, int> AddSourceFilter;

            [NativeTypeName("HRESULT (DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, nuint, int> SetLogFile;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, int> Abort;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, int> ShouldOperationContinue;

            [NativeTypeName("HRESULT (IMoniker *, IBindCtx *, LPCWSTR, IBaseFilter **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, IMoniker*, IBindCtx*, ushort*, IBaseFilter**, int> AddSourceFilterForMoniker;

            [NativeTypeName("HRESULT (IPin *, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, IPin*, AM_MEDIA_TYPE*, int> ReconnectEx;

            [NativeTypeName("HRESULT (IPin *, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, IPin*, uint, uint*, int> RenderEx;

            [NativeTypeName("HRESULT (IReferenceClock *, IReferenceClock *, IBaseFilter *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterGraph3*, IReferenceClock*, IReferenceClock*, IBaseFilter*, int> SetSyncSourceEx;
        }
    }
}
