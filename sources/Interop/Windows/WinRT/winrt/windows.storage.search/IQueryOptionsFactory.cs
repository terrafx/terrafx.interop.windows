// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IQueryOptionsFactory.xml' path='doc/member[@name="IQueryOptionsFactory"]/*' />
[Guid("032E1F8C-A9C1-4E71-8011-0DEE9D4811A3")]
[NativeTypeName("struct IQueryOptionsFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IQueryOptionsFactory : IQueryOptionsFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQueryOptionsFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptionsFactory*, Guid*, void**, int>)(lpVtbl[0]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptionsFactory*, uint>)(lpVtbl[1]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptionsFactory*, uint>)(lpVtbl[2]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptionsFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptionsFactory*, HSTRING*, int>)(lpVtbl[4]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptionsFactory*, TrustLevel*, int>)(lpVtbl[5]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IQueryOptionsFactory.xml' path='doc/member[@name="IQueryOptionsFactory.CreateCommonFileQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateCommonFileQuery([NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* fileTypeFilter, [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions **")] IQueryOptions** queryOptions)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptionsFactory*, CommonFileQuery, IIterable<HSTRING>*, IQueryOptions**, int>)(lpVtbl[6]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this), query, fileTypeFilter, queryOptions);
    }

    /// <include file='IQueryOptionsFactory.xml' path='doc/member[@name="IQueryOptionsFactory.CreateCommonFolderQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateCommonFolderQuery([NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")] CommonFolderQuery query, [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions **")] IQueryOptions** queryOptions)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryOptionsFactory*, CommonFolderQuery, IQueryOptions**, int>)(lpVtbl[7]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this), query, queryOptions);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateCommonFileQuery([NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* fileTypeFilter, [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions **")] IQueryOptions** queryOptions);

        [VtblIndex(7)]
        HRESULT CreateCommonFolderQuery([NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")] CommonFolderQuery query, [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions **")] IQueryOptions** queryOptions);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::CommonFileQuery, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Storage::Search::IQueryOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CommonFileQuery, IIterable<HSTRING>*, IQueryOptions**, int> CreateCommonFileQuery;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::CommonFolderQuery, ABI::Windows::Storage::Search::IQueryOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CommonFolderQuery, IQueryOptions**, int> CreateCommonFolderQuery;
    }
}
