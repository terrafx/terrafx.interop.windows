// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderSearchQueryOptions.xml' path='doc/member[@name="IStorageProviderSearchQueryOptions"]/*' />
[Guid("93D854EB-1007-563C-B213-CC44BD88FEF2")]
[NativeTypeName("struct IStorageProviderSearchQueryOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderSearchQueryOptions : IStorageProviderSearchQueryOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageProviderSearchQueryOptions);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchQueryOptions*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderSearchQueryOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchQueryOptions*, uint>)(lpVtbl[1]))((IStorageProviderSearchQueryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchQueryOptions*, uint>)(lpVtbl[2]))((IStorageProviderSearchQueryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchQueryOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderSearchQueryOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchQueryOptions*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderSearchQueryOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchQueryOptions*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderSearchQueryOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderSearchQueryOptions.xml' path='doc/member[@name="IStorageProviderSearchQueryOptions.get_UserQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_UserQuery(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchQueryOptions*, HSTRING*, int>)(lpVtbl[6]))((IStorageProviderSearchQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSearchQueryOptions.xml' path='doc/member[@name="IStorageProviderSearchQueryOptions.get_Language"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Language(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchQueryOptions*, HSTRING*, int>)(lpVtbl[7]))((IStorageProviderSearchQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSearchQueryOptions.xml' path='doc/member[@name="IStorageProviderSearchQueryOptions.get_SortOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SortOrder([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CStorage__CSearch__CSortEntry_t **")] IVectorView<SortEntry>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchQueryOptions*, IVectorView<SortEntry>**, int>)(lpVtbl[8]))((IStorageProviderSearchQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSearchQueryOptions.xml' path='doc/member[@name="IStorageProviderSearchQueryOptions.get_ProgrammaticQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ProgrammaticQuery(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchQueryOptions*, HSTRING*, int>)(lpVtbl[9]))((IStorageProviderSearchQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSearchQueryOptions.xml' path='doc/member[@name="IStorageProviderSearchQueryOptions.get_MaxResults"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MaxResults([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchQueryOptions*, uint*, int>)(lpVtbl[10]))((IStorageProviderSearchQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSearchQueryOptions.xml' path='doc/member[@name="IStorageProviderSearchQueryOptions.get_FolderScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_FolderScope(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchQueryOptions*, HSTRING*, int>)(lpVtbl[11]))((IStorageProviderSearchQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSearchQueryOptions.xml' path='doc/member[@name="IStorageProviderSearchQueryOptions.get_QueryId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_QueryId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchQueryOptions*, HSTRING*, int>)(lpVtbl[12]))((IStorageProviderSearchQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSearchQueryOptions.xml' path='doc/member[@name="IStorageProviderSearchQueryOptions.get_PropertiesToFetch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PropertiesToFetch([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSearchQueryOptions*, IVectorView<HSTRING>**, int>)(lpVtbl[13]))((IStorageProviderSearchQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_UserQuery(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Language(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_SortOrder([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CStorage__CSearch__CSortEntry_t **")] IVectorView<SortEntry>** value);

        [VtblIndex(9)]
        HRESULT get_ProgrammaticQuery(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_MaxResults([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT get_FolderScope(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_QueryId(HSTRING* value);

        [VtblIndex(13)]
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserQuery;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Language;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CStorage__CSearch__CSortEntry_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<SortEntry>**, int> get_SortOrder;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ProgrammaticQuery;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MaxResults;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FolderScope;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_QueryId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_PropertiesToFetch;
    }
}
