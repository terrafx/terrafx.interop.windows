// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IGraphBuilder.xml' path='doc/member[@name="IGraphBuilder"]/*' />
[Guid("56A868A9-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IGraphBuilder : IFilterGraph")]
[NativeInheritance("IFilterGraph")]
public unsafe partial struct IGraphBuilder : IGraphBuilder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGraphBuilder));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IGraphBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, uint>)(lpVtbl[1]))((IGraphBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, uint>)(lpVtbl[2]))((IGraphBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IFilterGraph.AddFilter" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddFilter(IBaseFilter* pFilter, [NativeTypeName("LPCWSTR")] char* pName)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, IBaseFilter*, char*, int>)(lpVtbl[3]))((IGraphBuilder*)Unsafe.AsPointer(ref this), pFilter, pName);
    }

    /// <inheritdoc cref="IFilterGraph.RemoveFilter" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveFilter(IBaseFilter* pFilter)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, IBaseFilter*, int>)(lpVtbl[4]))((IGraphBuilder*)Unsafe.AsPointer(ref this), pFilter);
    }

    /// <inheritdoc cref="IFilterGraph.EnumFilters" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumFilters(IEnumFilters** ppEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, IEnumFilters**, int>)(lpVtbl[5]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <inheritdoc cref="IFilterGraph.FindFilterByName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindFilterByName([NativeTypeName("LPCWSTR")] char* pName, IBaseFilter** ppFilter)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, char*, IBaseFilter**, int>)(lpVtbl[6]))((IGraphBuilder*)Unsafe.AsPointer(ref this), pName, ppFilter);
    }

    /// <inheritdoc cref="IFilterGraph.ConnectDirect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ConnectDirect(IPin* ppinOut, IPin* ppinIn, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, IPin*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[7]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppinOut, ppinIn, pmt);
    }

    /// <inheritdoc cref="IFilterGraph.Reconnect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Reconnect(IPin* ppin)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, IPin*, int>)(lpVtbl[8]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppin);
    }

    /// <inheritdoc cref="IFilterGraph.Disconnect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Disconnect(IPin* ppin)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, IPin*, int>)(lpVtbl[9]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppin);
    }

    /// <inheritdoc cref="IFilterGraph.SetDefaultSyncSource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetDefaultSyncSource()
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, int>)(lpVtbl[10]))((IGraphBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGraphBuilder.xml' path='doc/member[@name="IGraphBuilder.Connect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Connect(IPin* ppinOut, IPin* ppinIn)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, IPin*, IPin*, int>)(lpVtbl[11]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppinOut, ppinIn);
    }

    /// <include file='IGraphBuilder.xml' path='doc/member[@name="IGraphBuilder.Render"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Render(IPin* ppinOut)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, IPin*, int>)(lpVtbl[12]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppinOut);
    }

    /// <include file='IGraphBuilder.xml' path='doc/member[@name="IGraphBuilder.RenderFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RenderFile([NativeTypeName("LPCWSTR")] char* lpcwstrFile, [NativeTypeName("LPCWSTR")] char* lpcwstrPlayList)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, char*, char*, int>)(lpVtbl[13]))((IGraphBuilder*)Unsafe.AsPointer(ref this), lpcwstrFile, lpcwstrPlayList);
    }

    /// <include file='IGraphBuilder.xml' path='doc/member[@name="IGraphBuilder.AddSourceFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT AddSourceFilter([NativeTypeName("LPCWSTR")] char* lpcwstrFileName, [NativeTypeName("LPCWSTR")] char* lpcwstrFilterName, IBaseFilter** ppFilter)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, char*, char*, IBaseFilter**, int>)(lpVtbl[14]))((IGraphBuilder*)Unsafe.AsPointer(ref this), lpcwstrFileName, lpcwstrFilterName, ppFilter);
    }

    /// <include file='IGraphBuilder.xml' path='doc/member[@name="IGraphBuilder.SetLogFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetLogFile([NativeTypeName("DWORD_PTR")] nuint hFile)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, nuint, int>)(lpVtbl[15]))((IGraphBuilder*)Unsafe.AsPointer(ref this), hFile);
    }

    /// <include file='IGraphBuilder.xml' path='doc/member[@name="IGraphBuilder.Abort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Abort()
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, int>)(lpVtbl[16]))((IGraphBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGraphBuilder.xml' path='doc/member[@name="IGraphBuilder.ShouldOperationContinue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ShouldOperationContinue()
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphBuilder*, int>)(lpVtbl[17]))((IGraphBuilder*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IFilterGraph.Interface
    {
        [VtblIndex(11)]
        HRESULT Connect(IPin* ppinOut, IPin* ppinIn);

        [VtblIndex(12)]
        HRESULT Render(IPin* ppinOut);

        [VtblIndex(13)]
        HRESULT RenderFile([NativeTypeName("LPCWSTR")] char* lpcwstrFile, [NativeTypeName("LPCWSTR")] char* lpcwstrPlayList);

        [VtblIndex(14)]
        HRESULT AddSourceFilter([NativeTypeName("LPCWSTR")] char* lpcwstrFileName, [NativeTypeName("LPCWSTR")] char* lpcwstrFilterName, IBaseFilter** ppFilter);

        [VtblIndex(15)]
        HRESULT SetLogFile([NativeTypeName("DWORD_PTR")] nuint hFile);

        [VtblIndex(16)]
        HRESULT Abort();

        [VtblIndex(17)]
        HRESULT ShouldOperationContinue();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (IBaseFilter *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBaseFilter*, char*, int> AddFilter;

        [NativeTypeName("HRESULT (IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBaseFilter*, int> RemoveFilter;

        [NativeTypeName("HRESULT (IEnumFilters **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnumFilters**, int> EnumFilters;

        [NativeTypeName("HRESULT (LPCWSTR, IBaseFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IBaseFilter**, int> FindFilterByName;

        [NativeTypeName("HRESULT (IPin *, IPin *, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPin*, IPin*, AM_MEDIA_TYPE*, int> ConnectDirect;

        [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPin*, int> Reconnect;

        [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPin*, int> Disconnect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> SetDefaultSyncSource;

        [NativeTypeName("HRESULT (IPin *, IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPin*, IPin*, int> Connect;

        [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPin*, int> Render;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, int> RenderFile;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IBaseFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, IBaseFilter**, int> AddSourceFilter;

        [NativeTypeName("HRESULT (DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, int> SetLogFile;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Abort;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ShouldOperationContinue;
    }
}
