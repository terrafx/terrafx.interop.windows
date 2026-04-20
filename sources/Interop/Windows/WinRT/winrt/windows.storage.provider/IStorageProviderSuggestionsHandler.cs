// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderSuggestionsHandler.xml' path='doc/member[@name="IStorageProviderSuggestionsHandler"]/*' />
[Guid("AFF493F6-E1FD-5D03-B480-F1849C83EF4A")]
[NativeTypeName("struct IStorageProviderSuggestionsHandler : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderSuggestionsHandler : IStorageProviderSuggestionsHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageProviderSuggestionsHandler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsHandler*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderSuggestionsHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsHandler*, uint>)(lpVtbl[1]))((IStorageProviderSuggestionsHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsHandler*, uint>)(lpVtbl[2]))((IStorageProviderSuggestionsHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsHandler*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderSuggestionsHandler*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsHandler*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderSuggestionsHandler*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsHandler*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderSuggestionsHandler*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderSuggestionsHandler.xml' path='doc/member[@name="IStorageProviderSuggestionsHandler.GetSuggestions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSuggestions([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderSuggestionsQueryOptions *")] IStorageProviderSuggestionsQueryOptions* options, [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderQueryResultSet **")] IStorageProviderQueryResultSet** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsHandler*, IStorageProviderSuggestionsQueryOptions*, IStorageProviderQueryResultSet**, int>)(lpVtbl[6]))((IStorageProviderSuggestionsHandler*)Unsafe.AsPointer(ref this), options, result);
    }

    /// <include file='IStorageProviderSuggestionsHandler.xml' path='doc/member[@name="IStorageProviderSuggestionsHandler.Add"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Add([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderResultKind")] StorageProviderResultKind kind, HSTRING remoteFileId)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsHandler*, StorageProviderResultKind, HSTRING, int>)(lpVtbl[7]))((IStorageProviderSuggestionsHandler*)Unsafe.AsPointer(ref this), kind, remoteFileId);
    }

    /// <include file='IStorageProviderSuggestionsHandler.xml' path='doc/member[@name="IStorageProviderSuggestionsHandler.Remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Remove([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderResultKind")] StorageProviderResultKind kind, HSTRING remoteFileId)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsHandler*, StorageProviderResultKind, HSTRING, int>)(lpVtbl[8]))((IStorageProviderSuggestionsHandler*)Unsafe.AsPointer(ref this), kind, remoteFileId);
    }

    /// <include file='IStorageProviderSuggestionsHandler.xml' path='doc/member[@name="IStorageProviderSuggestionsHandler.GetDetails"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDetails(HSTRING remoteFileId, [NativeTypeName("UINT32")] uint propertiesToFetchLength, HSTRING* propertiesToFetch, HSTRING queryId, [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderQueryResult **")] IStorageProviderQueryResult** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsHandler*, HSTRING, uint, HSTRING*, HSTRING, IStorageProviderQueryResult**, int>)(lpVtbl[9]))((IStorageProviderSuggestionsHandler*)Unsafe.AsPointer(ref this), remoteFileId, propertiesToFetchLength, propertiesToFetch, queryId, result);
    }

    /// <include file='IStorageProviderSuggestionsHandler.xml' path='doc/member[@name="IStorageProviderSuggestionsHandler.ReportUsage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReportUsage([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderResultUsageKind")] StorageProviderResultUsageKind resultUsageKind, HSTRING remoteFileId, HSTRING resultId, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan latency)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSuggestionsHandler*, StorageProviderResultUsageKind, HSTRING, HSTRING, TimeSpan, int>)(lpVtbl[10]))((IStorageProviderSuggestionsHandler*)Unsafe.AsPointer(ref this), resultUsageKind, remoteFileId, resultId, latency);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetSuggestions([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderSuggestionsQueryOptions *")] IStorageProviderSuggestionsQueryOptions* options, [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderQueryResultSet **")] IStorageProviderQueryResultSet** result);

        [VtblIndex(7)]
        HRESULT Add([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderResultKind")] StorageProviderResultKind kind, HSTRING remoteFileId);

        [VtblIndex(8)]
        HRESULT Remove([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderResultKind")] StorageProviderResultKind kind, HSTRING remoteFileId);

        [VtblIndex(9)]
        HRESULT GetDetails(HSTRING remoteFileId, [NativeTypeName("UINT32")] uint propertiesToFetchLength, HSTRING* propertiesToFetch, HSTRING queryId, [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderQueryResult **")] IStorageProviderQueryResult** result);

        [VtblIndex(10)]
        HRESULT ReportUsage([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderResultUsageKind")] StorageProviderResultUsageKind resultUsageKind, HSTRING remoteFileId, HSTRING resultId, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan latency);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderSuggestionsQueryOptions *, ABI::Windows::Storage::Provider::IStorageProviderQueryResultSet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderSuggestionsQueryOptions*, IStorageProviderQueryResultSet**, int> GetSuggestions;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderResultKind, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderResultKind, HSTRING, int> Add;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderResultKind, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderResultKind, HSTRING, int> Remove;

        [NativeTypeName("HRESULT (HSTRING, UINT32, HSTRING *, HSTRING, ABI::Windows::Storage::Provider::IStorageProviderQueryResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, uint, HSTRING*, HSTRING, IStorageProviderQueryResult**, int> GetDetails;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderResultUsageKind, HSTRING, HSTRING, ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderResultUsageKind, HSTRING, HSTRING, TimeSpan, int> ReportUsage;
    }
}
