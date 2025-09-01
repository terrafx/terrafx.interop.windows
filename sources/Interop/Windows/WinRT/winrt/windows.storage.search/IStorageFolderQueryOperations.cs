// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations"]/*' />
[Guid("CB43CCC9-446B-4A4F-BE97-757771BE5203")]
[NativeTypeName("struct IStorageFolderQueryOperations : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageFolderQueryOperations : IStorageFolderQueryOperations.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageFolderQueryOperations);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, Guid*, void**, int>)(lpVtbl[0]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, uint>)(lpVtbl[1]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, uint>)(lpVtbl[2]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, HSTRING*, int>)(lpVtbl[4]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, TrustLevel*, int>)(lpVtbl[5]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.GetIndexedStateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetIndexedStateAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CSearch__CIndexedState_t **")] IAsyncOperation<IndexedState>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, IAsyncOperation<IndexedState>**, int>)(lpVtbl[6]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.CreateFileQueryOverloadDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFileQueryOverloadDefault([NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")] IStorageFileQueryResult** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, IStorageFileQueryResult**, int>)(lpVtbl[7]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.CreateFileQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFileQuery([NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query, [NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")] IStorageFileQueryResult** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, CommonFileQuery, IStorageFileQueryResult**, int>)(lpVtbl[8]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, value);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.CreateFileQueryWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFileQueryWithOptions([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")] IQueryOptions* queryOptions, [NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")] IStorageFileQueryResult** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, IQueryOptions*, IStorageFileQueryResult**, int>)(lpVtbl[9]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), queryOptions, value);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.CreateFolderQueryOverloadDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateFolderQueryOverloadDefault([NativeTypeName("ABI::Windows::Storage::Search::IStorageFolderQueryResult **")] IStorageFolderQueryResult** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, IStorageFolderQueryResult**, int>)(lpVtbl[10]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.CreateFolderQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateFolderQuery([NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")] CommonFolderQuery query, [NativeTypeName("ABI::Windows::Storage::Search::IStorageFolderQueryResult **")] IStorageFolderQueryResult** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, CommonFolderQuery, IStorageFolderQueryResult**, int>)(lpVtbl[11]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, value);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.CreateFolderQueryWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateFolderQueryWithOptions([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")] IQueryOptions* queryOptions, [NativeTypeName("ABI::Windows::Storage::Search::IStorageFolderQueryResult **")] IStorageFolderQueryResult** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, IQueryOptions*, IStorageFolderQueryResult**, int>)(lpVtbl[12]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), queryOptions, value);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.CreateItemQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateItemQuery([NativeTypeName("ABI::Windows::Storage::Search::IStorageItemQueryResult **")] IStorageItemQueryResult** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, IStorageItemQueryResult**, int>)(lpVtbl[13]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.CreateItemQueryWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateItemQueryWithOptions([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")] IQueryOptions* queryOptions, [NativeTypeName("ABI::Windows::Storage::Search::IStorageItemQueryResult **")] IStorageItemQueryResult** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, IQueryOptions*, IStorageItemQueryResult**, int>)(lpVtbl[14]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), queryOptions, value);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.GetFilesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetFilesAsync([NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxItemsToRetrieve, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFile>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, CommonFileQuery, uint, uint, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFile>>>>**, int>)(lpVtbl[15]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, startIndex, maxItemsToRetrieve, operation);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.GetFilesAsyncOverloadDefaultStartAndCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetFilesAsyncOverloadDefaultStartAndCount([NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFile>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, CommonFileQuery, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFile>>>>**, int>)(lpVtbl[16]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, operation);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.GetFoldersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetFoldersAsync([NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")] CommonFolderQuery query, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxItemsToRetrieve, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, CommonFolderQuery, uint, uint, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>**, int>)(lpVtbl[17]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, startIndex, maxItemsToRetrieve, operation);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.GetFoldersAsyncOverloadDefaultStartAndCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetFoldersAsyncOverloadDefaultStartAndCount([NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")] CommonFolderQuery query, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, CommonFolderQuery, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>**, int>)(lpVtbl[18]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, operation);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.GetItemsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetItemsAsync([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxItemsToRetrieve, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageItem>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, uint, uint, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageItem>>>>**, int>)(lpVtbl[19]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), startIndex, maxItemsToRetrieve, operation);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.AreQueryOptionsSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AreQueryOptionsSupported([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")] IQueryOptions* queryOptions, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, IQueryOptions*, byte*, int>)(lpVtbl[20]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), queryOptions, value);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.IsCommonFolderQuerySupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT IsCommonFolderQuerySupported([NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")] CommonFolderQuery query, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, CommonFolderQuery, byte*, int>)(lpVtbl[21]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, value);
    }

    /// <include file='IStorageFolderQueryOperations.xml' path='doc/member[@name="IStorageFolderQueryOperations.IsCommonFileQuerySupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT IsCommonFileQuerySupported([NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryOperations*, CommonFileQuery, byte*, int>)(lpVtbl[22]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetIndexedStateAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CSearch__CIndexedState_t **")] IAsyncOperation<IndexedState>** operation);

        [VtblIndex(7)]
        HRESULT CreateFileQueryOverloadDefault([NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")] IStorageFileQueryResult** value);

        [VtblIndex(8)]
        HRESULT CreateFileQuery([NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query, [NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")] IStorageFileQueryResult** value);

        [VtblIndex(9)]
        HRESULT CreateFileQueryWithOptions([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")] IQueryOptions* queryOptions, [NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")] IStorageFileQueryResult** value);

        [VtblIndex(10)]
        HRESULT CreateFolderQueryOverloadDefault([NativeTypeName("ABI::Windows::Storage::Search::IStorageFolderQueryResult **")] IStorageFolderQueryResult** value);

        [VtblIndex(11)]
        HRESULT CreateFolderQuery([NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")] CommonFolderQuery query, [NativeTypeName("ABI::Windows::Storage::Search::IStorageFolderQueryResult **")] IStorageFolderQueryResult** value);

        [VtblIndex(12)]
        HRESULT CreateFolderQueryWithOptions([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")] IQueryOptions* queryOptions, [NativeTypeName("ABI::Windows::Storage::Search::IStorageFolderQueryResult **")] IStorageFolderQueryResult** value);

        [VtblIndex(13)]
        HRESULT CreateItemQuery([NativeTypeName("ABI::Windows::Storage::Search::IStorageItemQueryResult **")] IStorageItemQueryResult** value);

        [VtblIndex(14)]
        HRESULT CreateItemQueryWithOptions([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")] IQueryOptions* queryOptions, [NativeTypeName("ABI::Windows::Storage::Search::IStorageItemQueryResult **")] IStorageItemQueryResult** value);

        [VtblIndex(15)]
        HRESULT GetFilesAsync([NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxItemsToRetrieve, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFile>>>>** operation);

        [VtblIndex(16)]
        HRESULT GetFilesAsyncOverloadDefaultStartAndCount([NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFile>>>>** operation);

        [VtblIndex(17)]
        HRESULT GetFoldersAsync([NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")] CommonFolderQuery query, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxItemsToRetrieve, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>** operation);

        [VtblIndex(18)]
        HRESULT GetFoldersAsyncOverloadDefaultStartAndCount([NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")] CommonFolderQuery query, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>** operation);

        [VtblIndex(19)]
        HRESULT GetItemsAsync([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxItemsToRetrieve, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageItem>>>>** operation);

        [VtblIndex(20)]
        HRESULT AreQueryOptionsSupported([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")] IQueryOptions* queryOptions, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(21)]
        HRESULT IsCommonFolderQuerySupported([NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")] CommonFolderQuery query, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(22)]
        HRESULT IsCommonFileQuerySupported([NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query, [NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CSearch__CIndexedState_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IndexedState>**, int> GetIndexedStateAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IStorageFileQueryResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFileQueryResult**, int> CreateFileQueryOverloadDefault;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::CommonFileQuery, ABI::Windows::Storage::Search::IStorageFileQueryResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CommonFileQuery, IStorageFileQueryResult**, int> CreateFileQuery;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IQueryOptions *, ABI::Windows::Storage::Search::IStorageFileQueryResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IQueryOptions*, IStorageFileQueryResult**, int> CreateFileQueryWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IStorageFolderQueryResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolderQueryResult**, int> CreateFolderQueryOverloadDefault;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::CommonFolderQuery, ABI::Windows::Storage::Search::IStorageFolderQueryResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CommonFolderQuery, IStorageFolderQueryResult**, int> CreateFolderQuery;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IQueryOptions *, ABI::Windows::Storage::Search::IStorageFolderQueryResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IQueryOptions*, IStorageFolderQueryResult**, int> CreateFolderQueryWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IStorageItemQueryResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageItemQueryResult**, int> CreateItemQuery;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IQueryOptions *, ABI::Windows::Storage::Search::IStorageItemQueryResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IQueryOptions*, IStorageItemQueryResult**, int> CreateItemQueryWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::CommonFileQuery, UINT32, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CommonFileQuery, uint, uint, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFile>>>>**, int> GetFilesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::CommonFileQuery, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CommonFileQuery, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFile>>>>**, int> GetFilesAsyncOverloadDefaultStartAndCount;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::CommonFolderQuery, UINT32, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CommonFolderQuery, uint, uint, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>**, int> GetFoldersAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::CommonFolderQuery, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CommonFolderQuery, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>**, int> GetFoldersAsyncOverloadDefaultStartAndCount;

        [NativeTypeName("HRESULT (UINT32, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageItem>>>>**, int> GetItemsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IQueryOptions *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IQueryOptions*, byte*, int> AreQueryOptionsSupported;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::CommonFolderQuery, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CommonFolderQuery, byte*, int> IsCommonFolderQuerySupported;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::CommonFileQuery, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CommonFileQuery, byte*, int> IsCommonFileQuerySupported;
    }
}
