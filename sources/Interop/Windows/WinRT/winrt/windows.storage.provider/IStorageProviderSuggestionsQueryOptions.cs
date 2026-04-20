// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderSuggestionsQueryOptions.xml' path='doc/member[@name="IStorageProviderSuggestionsQueryOptions"]/*' />
[Guid("EFB8B74D-0D84-579C-B137-EA730635D9BB")]
[NativeTypeName("struct IStorageProviderSuggestionsQueryOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderSuggestionsQueryOptions : IStorageProviderSuggestionsQueryOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageProviderSuggestionsQueryOptions);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsQueryOptions*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderSuggestionsQueryOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsQueryOptions*, uint>)(lpVtbl[1]))((IStorageProviderSuggestionsQueryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsQueryOptions*, uint>)(lpVtbl[2]))((IStorageProviderSuggestionsQueryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsQueryOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderSuggestionsQueryOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsQueryOptions*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderSuggestionsQueryOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsQueryOptions*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderSuggestionsQueryOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderSuggestionsQueryOptions.xml' path='doc/member[@name="IStorageProviderSuggestionsQueryOptions.get_SuggestionsKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SuggestionsKind([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderResultKind *")] StorageProviderResultKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsQueryOptions*, StorageProviderResultKind*, int>)(lpVtbl[6]))((IStorageProviderSuggestionsQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSuggestionsQueryOptions.xml' path='doc/member[@name="IStorageProviderSuggestionsQueryOptions.get_RemoteFileId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RemoteFileId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsQueryOptions*, HSTRING*, int>)(lpVtbl[7]))((IStorageProviderSuggestionsQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSuggestionsQueryOptions.xml' path='doc/member[@name="IStorageProviderSuggestionsQueryOptions.get_MaxResults"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxResults([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsQueryOptions*, uint*, int>)(lpVtbl[8]))((IStorageProviderSuggestionsQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSuggestionsQueryOptions.xml' path='doc/member[@name="IStorageProviderSuggestionsQueryOptions.get_QueryId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_QueryId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsQueryOptions*, HSTRING*, int>)(lpVtbl[9]))((IStorageProviderSuggestionsQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSuggestionsQueryOptions.xml' path='doc/member[@name="IStorageProviderSuggestionsQueryOptions.get_PropertiesToFetch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PropertiesToFetch([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsQueryOptions*, IVectorView<HSTRING>**, int>)(lpVtbl[10]))((IStorageProviderSuggestionsQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SuggestionsKind([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderResultKind *")] StorageProviderResultKind* value);

        [VtblIndex(7)]
        HRESULT get_RemoteFileId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_MaxResults([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT get_QueryId(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_PropertiesToFetch([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderResultKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderResultKind*, int> get_SuggestionsKind;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemoteFileId;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MaxResults;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_QueryId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_PropertiesToFetch;
    }
}
