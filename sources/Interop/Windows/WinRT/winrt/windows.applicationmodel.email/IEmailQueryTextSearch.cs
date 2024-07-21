// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailQueryTextSearch.xml' path='doc/member[@name="IEmailQueryTextSearch"]/*' />
[Guid("9FA0A288-3C5D-46A5-A6E2-31D6FD17E540")]
[NativeTypeName("struct IEmailQueryTextSearch : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailQueryTextSearch : IEmailQueryTextSearch.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailQueryTextSearch));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryTextSearch*, Guid*, void**, int>)(lpVtbl[0]))((IEmailQueryTextSearch*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryTextSearch*, uint>)(lpVtbl[1]))((IEmailQueryTextSearch*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryTextSearch*, uint>)(lpVtbl[2]))((IEmailQueryTextSearch*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryTextSearch*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailQueryTextSearch*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryTextSearch*, HSTRING*, int>)(lpVtbl[4]))((IEmailQueryTextSearch*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryTextSearch*, TrustLevel*, int>)(lpVtbl[5]))((IEmailQueryTextSearch*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailQueryTextSearch.xml' path='doc/member[@name="IEmailQueryTextSearch.get_Fields"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Fields([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySearchFields *")] EmailQuerySearchFields* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryTextSearch*, EmailQuerySearchFields*, int>)(lpVtbl[6]))((IEmailQueryTextSearch*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailQueryTextSearch.xml' path='doc/member[@name="IEmailQueryTextSearch.put_Fields"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Fields([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySearchFields")] EmailQuerySearchFields value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryTextSearch*, EmailQuerySearchFields, int>)(lpVtbl[7]))((IEmailQueryTextSearch*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailQueryTextSearch.xml' path='doc/member[@name="IEmailQueryTextSearch.get_SearchScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SearchScope([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySearchScope *")] EmailQuerySearchScope* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryTextSearch*, EmailQuerySearchScope*, int>)(lpVtbl[8]))((IEmailQueryTextSearch*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailQueryTextSearch.xml' path='doc/member[@name="IEmailQueryTextSearch.put_SearchScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SearchScope([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySearchScope")] EmailQuerySearchScope value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryTextSearch*, EmailQuerySearchScope, int>)(lpVtbl[9]))((IEmailQueryTextSearch*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailQueryTextSearch.xml' path='doc/member[@name="IEmailQueryTextSearch.get_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Text(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryTextSearch*, HSTRING*, int>)(lpVtbl[10]))((IEmailQueryTextSearch*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailQueryTextSearch.xml' path='doc/member[@name="IEmailQueryTextSearch.put_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Text(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryTextSearch*, HSTRING, int>)(lpVtbl[11]))((IEmailQueryTextSearch*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Fields([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySearchFields *")] EmailQuerySearchFields* value);

        [VtblIndex(7)]
        HRESULT put_Fields([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySearchFields")] EmailQuerySearchFields value);

        [VtblIndex(8)]
        HRESULT get_SearchScope([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySearchScope *")] EmailQuerySearchScope* value);

        [VtblIndex(9)]
        HRESULT put_SearchScope([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySearchScope")] EmailQuerySearchScope value);

        [VtblIndex(10)]
        HRESULT get_Text(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_Text(HSTRING value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailQuerySearchFields *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailQuerySearchFields*, int> get_Fields;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailQuerySearchFields) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailQuerySearchFields, int> put_Fields;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailQuerySearchScope *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailQuerySearchScope*, int> get_SearchScope;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailQuerySearchScope) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailQuerySearchScope, int> put_SearchScope;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Text;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Text;
    }
}
