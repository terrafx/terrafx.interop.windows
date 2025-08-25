// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderSearchResult.xml' path='doc/member[@name="IStorageProviderSearchResult"]/*' />
[Guid("FC161049-0995-535F-99B7-FE292CBABAF5")]
[NativeTypeName("struct IStorageProviderSearchResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderSearchResult : IStorageProviderSearchResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageProviderSearchResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchResult*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderSearchResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchResult*, uint>)(lpVtbl[1]))((IStorageProviderSearchResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchResult*, uint>)(lpVtbl[2]))((IStorageProviderSearchResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchResult*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderSearchResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchResult*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderSearchResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchResult*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderSearchResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderSearchResult.xml' path='doc/member[@name="IStorageProviderSearchResult.get_MatchScore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MatchScore(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchResult*, double*, int>)(lpVtbl[6]))((IStorageProviderSearchResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSearchResult.xml' path='doc/member[@name="IStorageProviderSearchResult.put_MatchScore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_MatchScore(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchResult*, double, int>)(lpVtbl[7]))((IStorageProviderSearchResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSearchResult.xml' path='doc/member[@name="IStorageProviderSearchResult.get_MatchKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MatchKind([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderSearchMatchKind *")] StorageProviderSearchMatchKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchResult*, StorageProviderSearchMatchKind*, int>)(lpVtbl[8]))((IStorageProviderSearchResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSearchResult.xml' path='doc/member[@name="IStorageProviderSearchResult.put_MatchKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MatchKind([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderSearchMatchKind")] StorageProviderSearchMatchKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchResult*, StorageProviderSearchMatchKind, int>)(lpVtbl[9]))((IStorageProviderSearchResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSearchResult.xml' path='doc/member[@name="IStorageProviderSearchResult.get_MatchedPropertyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MatchedPropertyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchResult*, HSTRING*, int>)(lpVtbl[10]))((IStorageProviderSearchResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSearchResult.xml' path='doc/member[@name="IStorageProviderSearchResult.put_MatchedPropertyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_MatchedPropertyName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchResult*, HSTRING, int>)(lpVtbl[11]))((IStorageProviderSearchResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MatchScore(double* value);

        [VtblIndex(7)]
        HRESULT put_MatchScore(double value);

        [VtblIndex(8)]
        HRESULT get_MatchKind([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderSearchMatchKind *")] StorageProviderSearchMatchKind* value);

        [VtblIndex(9)]
        HRESULT put_MatchKind([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderSearchMatchKind")] StorageProviderSearchMatchKind value);

        [VtblIndex(10)]
        HRESULT get_MatchedPropertyName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_MatchedPropertyName(HSTRING value);
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

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MatchScore;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_MatchScore;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderSearchMatchKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderSearchMatchKind*, int> get_MatchKind;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderSearchMatchKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderSearchMatchKind, int> put_MatchKind;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MatchedPropertyName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_MatchedPropertyName;
    }
}
