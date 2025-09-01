// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactQueryTextSearch.xml' path='doc/member[@name="IContactQueryTextSearch"]/*' />
[Guid("F7E3F9CB-A957-439B-A0B7-1C02A1963FF0")]
[NativeTypeName("struct IContactQueryTextSearch : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactQueryTextSearch : IContactQueryTextSearch.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IContactQueryTextSearch);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryTextSearch*, Guid*, void**, int>)(lpVtbl[0]))((IContactQueryTextSearch*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryTextSearch*, uint>)(lpVtbl[1]))((IContactQueryTextSearch*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryTextSearch*, uint>)(lpVtbl[2]))((IContactQueryTextSearch*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryTextSearch*, uint*, Guid**, int>)(lpVtbl[3]))((IContactQueryTextSearch*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryTextSearch*, HSTRING*, int>)(lpVtbl[4]))((IContactQueryTextSearch*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryTextSearch*, TrustLevel*, int>)(lpVtbl[5]))((IContactQueryTextSearch*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactQueryTextSearch.xml' path='doc/member[@name="IContactQueryTextSearch.get_Fields"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Fields([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchFields *")] ContactQuerySearchFields* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryTextSearch*, ContactQuerySearchFields*, int>)(lpVtbl[6]))((IContactQueryTextSearch*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactQueryTextSearch.xml' path='doc/member[@name="IContactQueryTextSearch.put_Fields"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Fields([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchFields")] ContactQuerySearchFields value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryTextSearch*, ContactQuerySearchFields, int>)(lpVtbl[7]))((IContactQueryTextSearch*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactQueryTextSearch.xml' path='doc/member[@name="IContactQueryTextSearch.get_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Text(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryTextSearch*, HSTRING*, int>)(lpVtbl[8]))((IContactQueryTextSearch*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactQueryTextSearch.xml' path='doc/member[@name="IContactQueryTextSearch.put_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Text(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryTextSearch*, HSTRING, int>)(lpVtbl[9]))((IContactQueryTextSearch*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactQueryTextSearch.xml' path='doc/member[@name="IContactQueryTextSearch.get_SearchScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SearchScope([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchScope *")] ContactQuerySearchScope* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryTextSearch*, ContactQuerySearchScope*, int>)(lpVtbl[10]))((IContactQueryTextSearch*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactQueryTextSearch.xml' path='doc/member[@name="IContactQueryTextSearch.put_SearchScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_SearchScope([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchScope")] ContactQuerySearchScope value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryTextSearch*, ContactQuerySearchScope, int>)(lpVtbl[11]))((IContactQueryTextSearch*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Fields([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchFields *")] ContactQuerySearchFields* value);

        [VtblIndex(7)]
        HRESULT put_Fields([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchFields")] ContactQuerySearchFields value);

        [VtblIndex(8)]
        HRESULT get_Text(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Text(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_SearchScope([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchScope *")] ContactQuerySearchScope* value);

        [VtblIndex(11)]
        HRESULT put_SearchScope([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchScope")] ContactQuerySearchScope value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchFields *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactQuerySearchFields*, int> get_Fields;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchFields) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactQuerySearchFields, int> put_Fields;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Text;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Text;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchScope *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactQuerySearchScope*, int> get_SearchScope;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchScope) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactQuerySearchScope, int> put_SearchScope;
    }
}
