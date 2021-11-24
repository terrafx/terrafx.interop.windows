// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("56A868A9-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IGraphBuilder : IFilterGraph")]
[NativeInheritance("IFilterGraph")]
public unsafe partial struct IGraphBuilder : IGraphBuilder.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGraphBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IGraphBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGraphBuilder*, uint>)(lpVtbl[1]))((IGraphBuilder*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGraphBuilder*, uint>)(lpVtbl[2]))((IGraphBuilder*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddFilter(IBaseFilter* pFilter, [NativeTypeName("LPCWSTR")] ushort* pName)
    {
        return ((delegate* unmanaged<IGraphBuilder*, IBaseFilter*, ushort*, int>)(lpVtbl[3]))((IGraphBuilder*)Unsafe.AsPointer(ref this), pFilter, pName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveFilter(IBaseFilter* pFilter)
    {
        return ((delegate* unmanaged<IGraphBuilder*, IBaseFilter*, int>)(lpVtbl[4]))((IGraphBuilder*)Unsafe.AsPointer(ref this), pFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumFilters(IEnumFilters** ppEnum)
    {
        return ((delegate* unmanaged<IGraphBuilder*, IEnumFilters**, int>)(lpVtbl[5]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindFilterByName([NativeTypeName("LPCWSTR")] ushort* pName, IBaseFilter** ppFilter)
    {
        return ((delegate* unmanaged<IGraphBuilder*, ushort*, IBaseFilter**, int>)(lpVtbl[6]))((IGraphBuilder*)Unsafe.AsPointer(ref this), pName, ppFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ConnectDirect(IPin* ppinOut, IPin* ppinIn, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged<IGraphBuilder*, IPin*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[7]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppinOut, ppinIn, pmt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Reconnect(IPin* ppin)
    {
        return ((delegate* unmanaged<IGraphBuilder*, IPin*, int>)(lpVtbl[8]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Disconnect(IPin* ppin)
    {
        return ((delegate* unmanaged<IGraphBuilder*, IPin*, int>)(lpVtbl[9]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetDefaultSyncSource()
    {
        return ((delegate* unmanaged<IGraphBuilder*, int>)(lpVtbl[10]))((IGraphBuilder*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Connect(IPin* ppinOut, IPin* ppinIn)
    {
        return ((delegate* unmanaged<IGraphBuilder*, IPin*, IPin*, int>)(lpVtbl[11]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppinOut, ppinIn);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Render(IPin* ppinOut)
    {
        return ((delegate* unmanaged<IGraphBuilder*, IPin*, int>)(lpVtbl[12]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppinOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RenderFile([NativeTypeName("LPCWSTR")] ushort* lpcwstrFile, [NativeTypeName("LPCWSTR")] ushort* lpcwstrPlayList)
    {
        return ((delegate* unmanaged<IGraphBuilder*, ushort*, ushort*, int>)(lpVtbl[13]))((IGraphBuilder*)Unsafe.AsPointer(ref this), lpcwstrFile, lpcwstrPlayList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT AddSourceFilter([NativeTypeName("LPCWSTR")] ushort* lpcwstrFileName, [NativeTypeName("LPCWSTR")] ushort* lpcwstrFilterName, IBaseFilter** ppFilter)
    {
        return ((delegate* unmanaged<IGraphBuilder*, ushort*, ushort*, IBaseFilter**, int>)(lpVtbl[14]))((IGraphBuilder*)Unsafe.AsPointer(ref this), lpcwstrFileName, lpcwstrFilterName, ppFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetLogFile([NativeTypeName("DWORD_PTR")] nuint hFile)
    {
        return ((delegate* unmanaged<IGraphBuilder*, nuint, int>)(lpVtbl[15]))((IGraphBuilder*)Unsafe.AsPointer(ref this), hFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Abort()
    {
        return ((delegate* unmanaged<IGraphBuilder*, int>)(lpVtbl[16]))((IGraphBuilder*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ShouldOperationContinue()
    {
        return ((delegate* unmanaged<IGraphBuilder*, int>)(lpVtbl[17]))((IGraphBuilder*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IFilterGraph.Interface
    {
        [VtblIndex(11)]
        HRESULT Connect(IPin* ppinOut, IPin* ppinIn);

        [VtblIndex(12)]
        HRESULT Render(IPin* ppinOut);

        [VtblIndex(13)]
        HRESULT RenderFile([NativeTypeName("LPCWSTR")] ushort* lpcwstrFile, [NativeTypeName("LPCWSTR")] ushort* lpcwstrPlayList);

        [VtblIndex(14)]
        HRESULT AddSourceFilter([NativeTypeName("LPCWSTR")] ushort* lpcwstrFileName, [NativeTypeName("LPCWSTR")] ushort* lpcwstrFilterName, IBaseFilter** ppFilter);

        [VtblIndex(15)]
        HRESULT SetLogFile([NativeTypeName("DWORD_PTR")] nuint hFile);

        [VtblIndex(16)]
        HRESULT Abort();

        [VtblIndex(17)]
        HRESULT ShouldOperationContinue();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, uint> Release;

        [NativeTypeName("HRESULT (IBaseFilter *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, IBaseFilter*, ushort*, int> AddFilter;

        [NativeTypeName("HRESULT (IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, IBaseFilter*, int> RemoveFilter;

        [NativeTypeName("HRESULT (IEnumFilters **) __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, IEnumFilters**, int> EnumFilters;

        [NativeTypeName("HRESULT (LPCWSTR, IBaseFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, ushort*, IBaseFilter**, int> FindFilterByName;

        [NativeTypeName("HRESULT (IPin *, IPin *, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, IPin*, IPin*, AM_MEDIA_TYPE*, int> ConnectDirect;

        [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, IPin*, int> Reconnect;

        [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, IPin*, int> Disconnect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, int> SetDefaultSyncSource;

        [NativeTypeName("HRESULT (IPin *, IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, IPin*, IPin*, int> Connect;

        [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, IPin*, int> Render;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, ushort*, ushort*, int> RenderFile;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IBaseFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, ushort*, ushort*, IBaseFilter**, int> AddSourceFilter;

        [NativeTypeName("HRESULT (DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, nuint, int> SetLogFile;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, int> Abort;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IGraphBuilder*, int> ShouldOperationContinue;
    }
}
