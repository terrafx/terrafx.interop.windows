// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContentIndexerQueryOperations.xml' path='doc/member[@name="IContentIndexerQueryOperations"]/*' />
[Guid("28823E10-4786-42F1-9730-792B3566B150")]
[NativeTypeName("struct IContentIndexerQueryOperations : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContentIndexerQueryOperations : IContentIndexerQueryOperations.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContentIndexerQueryOperations));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQueryOperations*, Guid*, void**, int>)(lpVtbl[0]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQueryOperations*, uint>)(lpVtbl[1]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQueryOperations*, uint>)(lpVtbl[2]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQueryOperations*, uint*, Guid**, int>)(lpVtbl[3]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQueryOperations*, HSTRING*, int>)(lpVtbl[4]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQueryOperations*, TrustLevel*, int>)(lpVtbl[5]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContentIndexerQueryOperations.xml' path='doc/member[@name="IContentIndexerQueryOperations.CreateQueryWithSortOrderAndLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateQueryWithSortOrderAndLanguage(HSTRING searchFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* propertiesToRetrieve, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CSearch__CSortEntry_t *")] IIterable<SortEntry>* sortOrder, HSTRING searchFilterLanguage, [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexerQuery **")] IContentIndexerQuery** query)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQueryOperations*, HSTRING, IIterable<HSTRING>*, IIterable<SortEntry>*, HSTRING, IContentIndexerQuery**, int>)(lpVtbl[6]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this), searchFilter, propertiesToRetrieve, sortOrder, searchFilterLanguage, query);
    }

    /// <include file='IContentIndexerQueryOperations.xml' path='doc/member[@name="IContentIndexerQueryOperations.CreateQueryWithSortOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateQueryWithSortOrder(HSTRING searchFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* propertiesToRetrieve, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CSearch__CSortEntry_t *")] IIterable<SortEntry>* sortOrder, [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexerQuery **")] IContentIndexerQuery** query)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQueryOperations*, HSTRING, IIterable<HSTRING>*, IIterable<SortEntry>*, IContentIndexerQuery**, int>)(lpVtbl[7]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this), searchFilter, propertiesToRetrieve, sortOrder, query);
    }

    /// <include file='IContentIndexerQueryOperations.xml' path='doc/member[@name="IContentIndexerQueryOperations.CreateQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateQuery(HSTRING searchFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* propertiesToRetrieve, [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexerQuery **")] IContentIndexerQuery** query)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerQueryOperations*, HSTRING, IIterable<HSTRING>*, IContentIndexerQuery**, int>)(lpVtbl[8]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this), searchFilter, propertiesToRetrieve, query);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateQueryWithSortOrderAndLanguage(HSTRING searchFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* propertiesToRetrieve, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CSearch__CSortEntry_t *")] IIterable<SortEntry>* sortOrder, HSTRING searchFilterLanguage, [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexerQuery **")] IContentIndexerQuery** query);

        [VtblIndex(7)]
        HRESULT CreateQueryWithSortOrder(HSTRING searchFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* propertiesToRetrieve, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CSearch__CSortEntry_t *")] IIterable<SortEntry>* sortOrder, [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexerQuery **")] IContentIndexerQuery** query);

        [VtblIndex(8)]
        HRESULT CreateQuery(HSTRING searchFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* propertiesToRetrieve, [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexerQuery **")] IContentIndexerQuery** query);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CSearch__CSortEntry_t *, HSTRING, ABI::Windows::Storage::Search::IContentIndexerQuery **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, IIterable<SortEntry>*, HSTRING, IContentIndexerQuery**, int> CreateQueryWithSortOrderAndLanguage;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CSearch__CSortEntry_t *, ABI::Windows::Storage::Search::IContentIndexerQuery **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, IIterable<SortEntry>*, IContentIndexerQuery**, int> CreateQueryWithSortOrder;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Storage::Search::IContentIndexerQuery **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, IContentIndexerQuery**, int> CreateQuery;
    }
}
