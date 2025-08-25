// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContentIndexerQuery.xml' path='doc/member[@name="IContentIndexerQuery"]/*' />
[Guid("70E3B0F8-4BFC-428A-8889-CC51DA9A7B9D")]
[NativeTypeName("struct IContentIndexerQuery : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContentIndexerQuery : IContentIndexerQuery.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IContentIndexerQuery);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQuery*, Guid*, void**, int>)(lpVtbl[0]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQuery*, uint>)(lpVtbl[1]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQuery*, uint>)(lpVtbl[2]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQuery*, uint*, Guid**, int>)(lpVtbl[3]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQuery*, HSTRING*, int>)(lpVtbl[4]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQuery*, TrustLevel*, int>)(lpVtbl[5]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContentIndexerQuery.xml' path='doc/member[@name="IContentIndexerQuery.GetCountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCountAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQuery*, IAsyncOperation<uint>**, int>)(lpVtbl[6]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IContentIndexerQuery.xml' path='doc/member[@name="IContentIndexerQuery.GetPropertiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___FIMapView_2_HSTRING_IInspectable_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IMapView<HSTRING, Pointer<IInspectable>>>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQuery*, IAsyncOperation<Pointer<IVectorView<Pointer<IMapView<HSTRING, Pointer<IInspectable>>>>>>**, int>)(lpVtbl[7]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IContentIndexerQuery.xml' path='doc/member[@name="IContentIndexerQuery.GetPropertiesRangeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPropertiesRangeAsync([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxItems, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___FIMapView_2_HSTRING_IInspectable_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IMapView<HSTRING, Pointer<IInspectable>>>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQuery*, uint, uint, IAsyncOperation<Pointer<IVectorView<Pointer<IMapView<HSTRING, Pointer<IInspectable>>>>>>**, int>)(lpVtbl[8]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), startIndex, maxItems, operation);
    }

    /// <include file='IContentIndexerQuery.xml' path='doc/member[@name="IContentIndexerQuery.GetAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CSearch__CIIndexableContent_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IIndexableContent>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQuery*, IAsyncOperation<Pointer<IVectorView<Pointer<IIndexableContent>>>>**, int>)(lpVtbl[9]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IContentIndexerQuery.xml' path='doc/member[@name="IContentIndexerQuery.GetRangeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetRangeAsync([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxItems, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CSearch__CIIndexableContent_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IIndexableContent>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQuery*, uint, uint, IAsyncOperation<Pointer<IVectorView<Pointer<IIndexableContent>>>>**, int>)(lpVtbl[10]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), startIndex, maxItems, operation);
    }

    /// <include file='IContentIndexerQuery.xml' path='doc/member[@name="IContentIndexerQuery.get_QueryFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_QueryFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQuery*, IStorageFolder**, int>)(lpVtbl[11]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCountAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** operation);

        [VtblIndex(7)]
        HRESULT GetPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___FIMapView_2_HSTRING_IInspectable_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IMapView<HSTRING, Pointer<IInspectable>>>>>>** operation);

        [VtblIndex(8)]
        HRESULT GetPropertiesRangeAsync([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxItems, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___FIMapView_2_HSTRING_IInspectable_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IMapView<HSTRING, Pointer<IInspectable>>>>>>** operation);

        [VtblIndex(9)]
        HRESULT GetAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CSearch__CIIndexableContent_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IIndexableContent>>>>** operation);

        [VtblIndex(10)]
        HRESULT GetRangeAsync([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxItems, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CSearch__CIIndexableContent_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IIndexableContent>>>>** operation);

        [VtblIndex(11)]
        HRESULT get_QueryFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<uint>**, int> GetCountAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___FIMapView_2_HSTRING_IInspectable_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IMapView<HSTRING, Pointer<IInspectable>>>>>>**, int> GetPropertiesAsync;

        [NativeTypeName("HRESULT (UINT32, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___FIMapView_2_HSTRING_IInspectable_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IAsyncOperation<Pointer<IVectorView<Pointer<IMapView<HSTRING, Pointer<IInspectable>>>>>>**, int> GetPropertiesRangeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CSearch__CIIndexableContent_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IIndexableContent>>>>**, int> GetAsync;

        [NativeTypeName("HRESULT (UINT32, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CSearch__CIIndexableContent_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IAsyncOperation<Pointer<IVectorView<Pointer<IIndexableContent>>>>**, int> GetRangeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_QueryFolder;
    }
}
