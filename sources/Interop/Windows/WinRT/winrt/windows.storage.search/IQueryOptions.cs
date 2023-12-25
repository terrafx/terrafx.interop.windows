// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions"]/*' />
[Guid("1E5E46EE-0F45-4838-A8E9-D0479D446C30")]
[NativeTypeName("struct IQueryOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IQueryOptions : IQueryOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQueryOptions));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, Guid*, void**, int>)(lpVtbl[0]))((IQueryOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, uint>)(lpVtbl[1]))((IQueryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, uint>)(lpVtbl[2]))((IQueryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IQueryOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, HSTRING*, int>)(lpVtbl[4]))((IQueryOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, TrustLevel*, int>)(lpVtbl[5]))((IQueryOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.get_FileTypeFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FileTypeFilter([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, IVector<HSTRING>**, int>)(lpVtbl[6]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.get_FolderDepth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_FolderDepth([NativeTypeName("ABI::Windows::Storage::Search::FolderDepth *")] FolderDepth* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, FolderDepth*, int>)(lpVtbl[7]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.put_FolderDepth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_FolderDepth([NativeTypeName("ABI::Windows::Storage::Search::FolderDepth")] FolderDepth value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, FolderDepth, int>)(lpVtbl[8]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.get_ApplicationSearchFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ApplicationSearchFilter(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, HSTRING*, int>)(lpVtbl[9]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.put_ApplicationSearchFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ApplicationSearchFilter(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, HSTRING, int>)(lpVtbl[10]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.get_UserSearchFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_UserSearchFilter(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, HSTRING*, int>)(lpVtbl[11]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.put_UserSearchFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_UserSearchFilter(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, HSTRING, int>)(lpVtbl[12]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.get_Language"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Language(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, HSTRING*, int>)(lpVtbl[13]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.put_Language"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Language(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, HSTRING, int>)(lpVtbl[14]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.get_IndexerOption"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IndexerOption([NativeTypeName("ABI::Windows::Storage::Search::IndexerOption *")] IndexerOption* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, IndexerOption*, int>)(lpVtbl[15]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.put_IndexerOption"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_IndexerOption([NativeTypeName("ABI::Windows::Storage::Search::IndexerOption")] IndexerOption value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, IndexerOption, int>)(lpVtbl[16]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.get_SortOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SortOrder([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CSearch__CSortEntry_t **")] IVector<SortEntry>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, IVector<SortEntry>**, int>)(lpVtbl[17]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.get_GroupPropertyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_GroupPropertyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, HSTRING*, int>)(lpVtbl[18]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.get_DateStackOption"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_DateStackOption([NativeTypeName("ABI::Windows::Storage::Search::DateStackOption *")] DateStackOption* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, DateStackOption*, int>)(lpVtbl[19]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.SaveToString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SaveToString(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, HSTRING*, int>)(lpVtbl[20]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.LoadFromString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT LoadFromString(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, HSTRING, int>)(lpVtbl[21]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.SetThumbnailPrefetch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetThumbnailPrefetch([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("UINT32")] uint requestedSize, [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailOptions")] ThumbnailOptions options)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, ThumbnailMode, uint, ThumbnailOptions, int>)(lpVtbl[22]))((IQueryOptions*)Unsafe.AsPointer(ref this), mode, requestedSize, options);
    }

    /// <include file='IQueryOptions.xml' path='doc/member[@name="IQueryOptions.SetPropertyPrefetch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetPropertyPrefetch([NativeTypeName("ABI::Windows::Storage::FileProperties::PropertyPrefetchOptions")] PropertyPrefetchOptions options, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* propertiesToRetrieve)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptions*, PropertyPrefetchOptions, IIterable<HSTRING>*, int>)(lpVtbl[23]))((IQueryOptions*)Unsafe.AsPointer(ref this), options, propertiesToRetrieve);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FileTypeFilter([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(7)]
        HRESULT get_FolderDepth([NativeTypeName("ABI::Windows::Storage::Search::FolderDepth *")] FolderDepth* value);

        [VtblIndex(8)]
        HRESULT put_FolderDepth([NativeTypeName("ABI::Windows::Storage::Search::FolderDepth")] FolderDepth value);

        [VtblIndex(9)]
        HRESULT get_ApplicationSearchFilter(HSTRING* value);

        [VtblIndex(10)]
        HRESULT put_ApplicationSearchFilter(HSTRING value);

        [VtblIndex(11)]
        HRESULT get_UserSearchFilter(HSTRING* value);

        [VtblIndex(12)]
        HRESULT put_UserSearchFilter(HSTRING value);

        [VtblIndex(13)]
        HRESULT get_Language(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_Language(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_IndexerOption([NativeTypeName("ABI::Windows::Storage::Search::IndexerOption *")] IndexerOption* value);

        [VtblIndex(16)]
        HRESULT put_IndexerOption([NativeTypeName("ABI::Windows::Storage::Search::IndexerOption")] IndexerOption value);

        [VtblIndex(17)]
        HRESULT get_SortOrder([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CSearch__CSortEntry_t **")] IVector<SortEntry>** value);

        [VtblIndex(18)]
        HRESULT get_GroupPropertyName(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_DateStackOption([NativeTypeName("ABI::Windows::Storage::Search::DateStackOption *")] DateStackOption* value);

        [VtblIndex(20)]
        HRESULT SaveToString(HSTRING* value);

        [VtblIndex(21)]
        HRESULT LoadFromString(HSTRING value);

        [VtblIndex(22)]
        HRESULT SetThumbnailPrefetch([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("UINT32")] uint requestedSize, [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailOptions")] ThumbnailOptions options);

        [VtblIndex(23)]
        HRESULT SetPropertyPrefetch([NativeTypeName("ABI::Windows::Storage::FileProperties::PropertyPrefetchOptions")] PropertyPrefetchOptions options, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* propertiesToRetrieve);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_FileTypeFilter;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::FolderDepth *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FolderDepth*, int> get_FolderDepth;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::FolderDepth) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FolderDepth, int> put_FolderDepth;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ApplicationSearchFilter;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ApplicationSearchFilter;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserSearchFilter;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_UserSearchFilter;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Language;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Language;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IndexerOption *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IndexerOption*, int> get_IndexerOption;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IndexerOption) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IndexerOption, int> put_IndexerOption;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CSearch__CSortEntry_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<SortEntry>**, int> get_SortOrder;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_GroupPropertyName;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::DateStackOption *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DateStackOption*, int> get_DateStackOption;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> SaveToString;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> LoadFromString;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::FileProperties::ThumbnailMode, UINT32, ABI::Windows::Storage::FileProperties::ThumbnailOptions) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ThumbnailMode, uint, ThumbnailOptions, int> SetThumbnailPrefetch;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::FileProperties::PropertyPrefetchOptions, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PropertyPrefetchOptions, IIterable<HSTRING>*, int> SetPropertyPrefetch;
    }
}
