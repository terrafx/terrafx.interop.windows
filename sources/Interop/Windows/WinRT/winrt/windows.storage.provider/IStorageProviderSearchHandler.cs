// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderSearchHandler.xml' path='doc/member[@name="IStorageProviderSearchHandler"]/*' />
[Guid("69CC977D-ADAD-59C9-8FD1-F30B6FAE0FD9")]
[NativeTypeName("struct IStorageProviderSearchHandler : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderSearchHandler : IStorageProviderSearchHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageProviderSearchHandler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchHandler*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderSearchHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchHandler*, uint>)(lpVtbl[1]))((IStorageProviderSearchHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchHandler*, uint>)(lpVtbl[2]))((IStorageProviderSearchHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchHandler*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderSearchHandler*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchHandler*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderSearchHandler*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchHandler*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderSearchHandler*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderSearchHandler.xml' path='doc/member[@name="IStorageProviderSearchHandler.Find"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Find([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderSearchQueryOptions *")] IStorageProviderSearchQueryOptions* options, [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderQueryResultSet **")] IStorageProviderQueryResultSet** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchHandler*, IStorageProviderSearchQueryOptions*, IStorageProviderQueryResultSet**, int>)(lpVtbl[6]))((IStorageProviderSearchHandler*)Unsafe.AsPointer(ref this), options, result);
    }

    /// <include file='IStorageProviderSearchHandler.xml' path='doc/member[@name="IStorageProviderSearchHandler.ReportUsage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReportUsage([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderResultUsageKind")] StorageProviderResultUsageKind resultUsageKind, HSTRING remoteFileId, HSTRING resultId, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan latency)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchHandler*, StorageProviderResultUsageKind, HSTRING, HSTRING, TimeSpan, int>)(lpVtbl[7]))((IStorageProviderSearchHandler*)Unsafe.AsPointer(ref this), resultUsageKind, remoteFileId, resultId, latency);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Find([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderSearchQueryOptions *")] IStorageProviderSearchQueryOptions* options, [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderQueryResultSet **")] IStorageProviderQueryResultSet** result);

        [VtblIndex(7)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderSearchQueryOptions *, ABI::Windows::Storage::Provider::IStorageProviderQueryResultSet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderSearchQueryOptions*, IStorageProviderQueryResultSet**, int> Find;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderResultUsageKind, HSTRING, HSTRING, ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderResultUsageKind, HSTRING, HSTRING, TimeSpan, int> ReportUsage;
    }
}
