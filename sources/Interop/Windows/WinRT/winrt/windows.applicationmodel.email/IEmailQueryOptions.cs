// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailQueryOptions.xml' path='doc/member[@name="IEmailQueryOptions"]/*' />
[Guid("45504B9B-3E7F-4D52-B6DD-D6FD4E1FBD9A")]
[NativeTypeName("struct IEmailQueryOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailQueryOptions : IEmailQueryOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailQueryOptions));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptions*, Guid*, void**, int>)(lpVtbl[0]))((IEmailQueryOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptions*, uint>)(lpVtbl[1]))((IEmailQueryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptions*, uint>)(lpVtbl[2]))((IEmailQueryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailQueryOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptions*, HSTRING*, int>)(lpVtbl[4]))((IEmailQueryOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptions*, TrustLevel*, int>)(lpVtbl[5]))((IEmailQueryOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailQueryOptions.xml' path='doc/member[@name="IEmailQueryOptions.get_TextSearch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TextSearch([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryTextSearch **")] IEmailQueryTextSearch** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptions*, IEmailQueryTextSearch**, int>)(lpVtbl[6]))((IEmailQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailQueryOptions.xml' path='doc/member[@name="IEmailQueryOptions.get_SortDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SortDirection([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortDirection *")] EmailQuerySortDirection* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptions*, EmailQuerySortDirection*, int>)(lpVtbl[7]))((IEmailQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailQueryOptions.xml' path='doc/member[@name="IEmailQueryOptions.put_SortDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_SortDirection([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortDirection")] EmailQuerySortDirection value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptions*, EmailQuerySortDirection, int>)(lpVtbl[8]))((IEmailQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailQueryOptions.xml' path='doc/member[@name="IEmailQueryOptions.get_SortProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SortProperty([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortProperty *")] EmailQuerySortProperty* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptions*, EmailQuerySortProperty*, int>)(lpVtbl[9]))((IEmailQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailQueryOptions.xml' path='doc/member[@name="IEmailQueryOptions.put_SortProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_SortProperty([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortProperty")] EmailQuerySortProperty value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptions*, EmailQuerySortProperty, int>)(lpVtbl[10]))((IEmailQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailQueryOptions.xml' path='doc/member[@name="IEmailQueryOptions.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQueryKind *")] EmailQueryKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptions*, EmailQueryKind*, int>)(lpVtbl[11]))((IEmailQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailQueryOptions.xml' path='doc/member[@name="IEmailQueryOptions.put_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQueryKind")] EmailQueryKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptions*, EmailQueryKind, int>)(lpVtbl[12]))((IEmailQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailQueryOptions.xml' path='doc/member[@name="IEmailQueryOptions.get_FolderIds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_FolderIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptions*, IVector<HSTRING>**, int>)(lpVtbl[13]))((IEmailQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TextSearch([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryTextSearch **")] IEmailQueryTextSearch** value);

        [VtblIndex(7)]
        HRESULT get_SortDirection([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortDirection *")] EmailQuerySortDirection* value);

        [VtblIndex(8)]
        HRESULT put_SortDirection([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortDirection")] EmailQuerySortDirection value);

        [VtblIndex(9)]
        HRESULT get_SortProperty([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortProperty *")] EmailQuerySortProperty* value);

        [VtblIndex(10)]
        HRESULT put_SortProperty([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortProperty")] EmailQuerySortProperty value);

        [VtblIndex(11)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQueryKind *")] EmailQueryKind* value);

        [VtblIndex(12)]
        HRESULT put_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQueryKind")] EmailQueryKind value);

        [VtblIndex(13)]
        HRESULT get_FolderIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailQueryTextSearch **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailQueryTextSearch**, int> get_TextSearch;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailQuerySortDirection *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailQuerySortDirection*, int> get_SortDirection;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailQuerySortDirection) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailQuerySortDirection, int> put_SortDirection;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailQuerySortProperty *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailQuerySortProperty*, int> get_SortProperty;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailQuerySortProperty) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailQuerySortProperty, int> put_SortProperty;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailQueryKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailQueryKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailQueryKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailQueryKind, int> put_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_FolderIds;
    }
}
