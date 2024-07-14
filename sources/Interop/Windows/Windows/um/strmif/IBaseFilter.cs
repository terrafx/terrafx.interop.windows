// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IBaseFilter.xml' path='doc/member[@name="IBaseFilter"]/*' />
[Guid("56A86895-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IBaseFilter : IMediaFilter")]
[NativeInheritance("IMediaFilter")]
public unsafe partial struct IBaseFilter : IBaseFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBaseFilter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBaseFilter*, Guid*, void**, int>)(lpVtbl[0]))((IBaseFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBaseFilter*, uint>)(lpVtbl[1]))((IBaseFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBaseFilter*, uint>)(lpVtbl[2]))((IBaseFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPersist.GetClassID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged[MemberFunction]<IBaseFilter*, Guid*, int>)(lpVtbl[3]))((IBaseFilter*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <inheritdoc cref="IMediaFilter.Stop" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IBaseFilter*, int>)(lpVtbl[4]))((IBaseFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMediaFilter.Pause" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged[MemberFunction]<IBaseFilter*, int>)(lpVtbl[5]))((IBaseFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMediaFilter.Run" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Run([NativeTypeName("REFERENCE_TIME")] long tStart)
    {
        return ((delegate* unmanaged[MemberFunction]<IBaseFilter*, long, int>)(lpVtbl[6]))((IBaseFilter*)Unsafe.AsPointer(ref this), tStart);
    }

    /// <inheritdoc cref="IMediaFilter.GetState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetState([NativeTypeName("DWORD")] uint dwMilliSecsTimeout, FILTER_STATE* State)
    {
        return ((delegate* unmanaged[MemberFunction]<IBaseFilter*, uint, FILTER_STATE*, int>)(lpVtbl[7]))((IBaseFilter*)Unsafe.AsPointer(ref this), dwMilliSecsTimeout, State);
    }

    /// <inheritdoc cref="IMediaFilter.SetSyncSource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSyncSource(IReferenceClock* pClock)
    {
        return ((delegate* unmanaged[MemberFunction]<IBaseFilter*, IReferenceClock*, int>)(lpVtbl[8]))((IBaseFilter*)Unsafe.AsPointer(ref this), pClock);
    }

    /// <inheritdoc cref="IMediaFilter.GetSyncSource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSyncSource(IReferenceClock** pClock)
    {
        return ((delegate* unmanaged[MemberFunction]<IBaseFilter*, IReferenceClock**, int>)(lpVtbl[9]))((IBaseFilter*)Unsafe.AsPointer(ref this), pClock);
    }

    /// <include file='IBaseFilter.xml' path='doc/member[@name="IBaseFilter.EnumPins"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EnumPins(IEnumPins** ppEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<IBaseFilter*, IEnumPins**, int>)(lpVtbl[10]))((IBaseFilter*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IBaseFilter.xml' path='doc/member[@name="IBaseFilter.FindPin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT FindPin([NativeTypeName("LPCWSTR")] char* Id, IPin** ppPin)
    {
        return ((delegate* unmanaged[MemberFunction]<IBaseFilter*, char*, IPin**, int>)(lpVtbl[11]))((IBaseFilter*)Unsafe.AsPointer(ref this), Id, ppPin);
    }

    /// <include file='IBaseFilter.xml' path='doc/member[@name="IBaseFilter.QueryFilterInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT QueryFilterInfo(FILTER_INFO* pInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBaseFilter*, FILTER_INFO*, int>)(lpVtbl[12]))((IBaseFilter*)Unsafe.AsPointer(ref this), pInfo);
    }

    /// <include file='IBaseFilter.xml' path='doc/member[@name="IBaseFilter.JoinFilterGraph"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT JoinFilterGraph(IFilterGraph* pGraph, [NativeTypeName("LPCWSTR")] char* pName)
    {
        return ((delegate* unmanaged[MemberFunction]<IBaseFilter*, IFilterGraph*, char*, int>)(lpVtbl[13]))((IBaseFilter*)Unsafe.AsPointer(ref this), pGraph, pName);
    }

    /// <include file='IBaseFilter.xml' path='doc/member[@name="IBaseFilter.QueryVendorInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT QueryVendorInfo([NativeTypeName("LPWSTR *")] char** pVendorInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBaseFilter*, char**, int>)(lpVtbl[14]))((IBaseFilter*)Unsafe.AsPointer(ref this), pVendorInfo);
    }

    public interface Interface : IMediaFilter.Interface
    {
        [VtblIndex(10)]
        HRESULT EnumPins(IEnumPins** ppEnum);

        [VtblIndex(11)]
        HRESULT FindPin([NativeTypeName("LPCWSTR")] char* Id, IPin** ppPin);

        [VtblIndex(12)]
        HRESULT QueryFilterInfo(FILTER_INFO* pInfo);

        [VtblIndex(13)]
        HRESULT JoinFilterGraph(IFilterGraph* pGraph, [NativeTypeName("LPCWSTR")] char* pName);

        [VtblIndex(14)]
        HRESULT QueryVendorInfo([NativeTypeName("LPWSTR *")] char** pVendorInfo);
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

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetClassID;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Pause;

        [NativeTypeName("HRESULT (REFERENCE_TIME) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, long, int> Run;

        [NativeTypeName("HRESULT (DWORD, FILTER_STATE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, FILTER_STATE*, int> GetState;

        [NativeTypeName("HRESULT (IReferenceClock *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReferenceClock*, int> SetSyncSource;

        [NativeTypeName("HRESULT (IReferenceClock **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReferenceClock**, int> GetSyncSource;

        [NativeTypeName("HRESULT (IEnumPins **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnumPins**, int> EnumPins;

        [NativeTypeName("HRESULT (LPCWSTR, IPin **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IPin**, int> FindPin;

        [NativeTypeName("HRESULT (FILTER_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FILTER_INFO*, int> QueryFilterInfo;

        [NativeTypeName("HRESULT (IFilterGraph *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFilterGraph*, char*, int> JoinFilterGraph;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> QueryVendorInfo;
    }
}
