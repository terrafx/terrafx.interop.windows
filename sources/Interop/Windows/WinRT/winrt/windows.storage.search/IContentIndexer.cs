// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContentIndexer.xml' path='doc/member[@name="IContentIndexer"]/*' />
[Guid("B1767F8D-F698-4982-B05F-3A6E8CAB01A2")]
[NativeTypeName("struct IContentIndexer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContentIndexer : IContentIndexer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContentIndexer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexer*, Guid*, void**, int>)(lpVtbl[0]))((IContentIndexer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexer*, uint>)(lpVtbl[1]))((IContentIndexer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexer*, uint>)(lpVtbl[2]))((IContentIndexer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexer*, uint*, Guid**, int>)(lpVtbl[3]))((IContentIndexer*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexer*, HSTRING*, int>)(lpVtbl[4]))((IContentIndexer*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexer*, TrustLevel*, int>)(lpVtbl[5]))((IContentIndexer*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContentIndexer.xml' path='doc/member[@name="IContentIndexer.AddAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddAsync([NativeTypeName("ABI::Windows::Storage::Search::IIndexableContent *")] IIndexableContent* indexableContent, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexer*, IIndexableContent*, IAsyncAction**, int>)(lpVtbl[6]))((IContentIndexer*)Unsafe.AsPointer(ref this), indexableContent, operation);
    }

    /// <include file='IContentIndexer.xml' path='doc/member[@name="IContentIndexer.UpdateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UpdateAsync([NativeTypeName("ABI::Windows::Storage::Search::IIndexableContent *")] IIndexableContent* indexableContent, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexer*, IIndexableContent*, IAsyncAction**, int>)(lpVtbl[7]))((IContentIndexer*)Unsafe.AsPointer(ref this), indexableContent, operation);
    }

    /// <include file='IContentIndexer.xml' path='doc/member[@name="IContentIndexer.DeleteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeleteAsync(HSTRING contentId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexer*, HSTRING, IAsyncAction**, int>)(lpVtbl[8]))((IContentIndexer*)Unsafe.AsPointer(ref this), contentId, operation);
    }

    /// <include file='IContentIndexer.xml' path='doc/member[@name="IContentIndexer.DeleteMultipleAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DeleteMultipleAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* contentIds, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexer*, IIterable<HSTRING>*, IAsyncAction**, int>)(lpVtbl[9]))((IContentIndexer*)Unsafe.AsPointer(ref this), contentIds, operation);
    }

    /// <include file='IContentIndexer.xml' path='doc/member[@name="IContentIndexer.DeleteAllAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DeleteAllAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexer*, IAsyncAction**, int>)(lpVtbl[10]))((IContentIndexer*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IContentIndexer.xml' path='doc/member[@name="IContentIndexer.RetrievePropertiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RetrievePropertiesAsync(HSTRING contentId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* propertiesToRetrieve, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_IInspectable_t **")] IAsyncOperation<Pointer<IMapView<HSTRING, Pointer<IInspectable>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexer*, HSTRING, IIterable<HSTRING>*, IAsyncOperation<Pointer<IMapView<HSTRING, Pointer<IInspectable>>>>**, int>)(lpVtbl[11]))((IContentIndexer*)Unsafe.AsPointer(ref this), contentId, propertiesToRetrieve, operation);
    }

    /// <include file='IContentIndexer.xml' path='doc/member[@name="IContentIndexer.get_Revision"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Revision([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexer*, ulong*, int>)(lpVtbl[12]))((IContentIndexer*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddAsync([NativeTypeName("ABI::Windows::Storage::Search::IIndexableContent *")] IIndexableContent* indexableContent, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(7)]
        HRESULT UpdateAsync([NativeTypeName("ABI::Windows::Storage::Search::IIndexableContent *")] IIndexableContent* indexableContent, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(8)]
        HRESULT DeleteAsync(HSTRING contentId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(9)]
        HRESULT DeleteMultipleAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* contentIds, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(10)]
        HRESULT DeleteAllAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(11)]
        HRESULT RetrievePropertiesAsync(HSTRING contentId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* propertiesToRetrieve, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_IInspectable_t **")] IAsyncOperation<Pointer<IMapView<HSTRING, Pointer<IInspectable>>>>** operation);

        [VtblIndex(12)]
        HRESULT get_Revision([NativeTypeName("UINT64 *")] ulong* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IIndexableContent *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIndexableContent*, IAsyncAction**, int> AddAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IIndexableContent *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIndexableContent*, IAsyncAction**, int> UpdateAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> DeleteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IAsyncAction**, int> DeleteMultipleAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> DeleteAllAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_IInspectable_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, IAsyncOperation<Pointer<IMapView<HSTRING, Pointer<IInspectable>>>>**, int> RetrievePropertiesAsync;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_Revision;
    }
}
