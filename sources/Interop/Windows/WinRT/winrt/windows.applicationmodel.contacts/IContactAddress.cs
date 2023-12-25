// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactAddress.xml' path='doc/member[@name="IContactAddress"]/*' />
[Guid("9739D39A-42CE-4872-8D70-3063AA584B70")]
[NativeTypeName("struct IContactAddress : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactAddress : IContactAddress.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactAddress));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, Guid*, void**, int>)(lpVtbl[0]))((IContactAddress*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, uint>)(lpVtbl[1]))((IContactAddress*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, uint>)(lpVtbl[2]))((IContactAddress*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, uint*, Guid**, int>)(lpVtbl[3]))((IContactAddress*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, HSTRING*, int>)(lpVtbl[4]))((IContactAddress*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, TrustLevel*, int>)(lpVtbl[5]))((IContactAddress*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactAddress.xml' path='doc/member[@name="IContactAddress.get_StreetAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_StreetAddress(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, HSTRING*, int>)(lpVtbl[6]))((IContactAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAddress.xml' path='doc/member[@name="IContactAddress.put_StreetAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_StreetAddress(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, HSTRING, int>)(lpVtbl[7]))((IContactAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAddress.xml' path='doc/member[@name="IContactAddress.get_Locality"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Locality(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, HSTRING*, int>)(lpVtbl[8]))((IContactAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAddress.xml' path='doc/member[@name="IContactAddress.put_Locality"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Locality(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, HSTRING, int>)(lpVtbl[9]))((IContactAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAddress.xml' path='doc/member[@name="IContactAddress.get_Region"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Region(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, HSTRING*, int>)(lpVtbl[10]))((IContactAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAddress.xml' path='doc/member[@name="IContactAddress.put_Region"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Region(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, HSTRING, int>)(lpVtbl[11]))((IContactAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAddress.xml' path='doc/member[@name="IContactAddress.get_Country"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Country(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, HSTRING*, int>)(lpVtbl[12]))((IContactAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAddress.xml' path='doc/member[@name="IContactAddress.put_Country"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Country(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, HSTRING, int>)(lpVtbl[13]))((IContactAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAddress.xml' path='doc/member[@name="IContactAddress.get_PostalCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PostalCode(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, HSTRING*, int>)(lpVtbl[14]))((IContactAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAddress.xml' path='doc/member[@name="IContactAddress.put_PostalCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_PostalCode(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, HSTRING, int>)(lpVtbl[15]))((IContactAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAddress.xml' path='doc/member[@name="IContactAddress.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAddressKind *")] ContactAddressKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, ContactAddressKind*, int>)(lpVtbl[16]))((IContactAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAddress.xml' path='doc/member[@name="IContactAddress.put_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAddressKind")] ContactAddressKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, ContactAddressKind, int>)(lpVtbl[17]))((IContactAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAddress.xml' path='doc/member[@name="IContactAddress.get_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Description(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, HSTRING*, int>)(lpVtbl[18]))((IContactAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAddress.xml' path='doc/member[@name="IContactAddress.put_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_Description(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAddress*, HSTRING, int>)(lpVtbl[19]))((IContactAddress*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_StreetAddress(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_StreetAddress(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Locality(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Locality(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Region(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_Region(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_Country(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_Country(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_PostalCode(HSTRING* value);

        [VtblIndex(15)]
        HRESULT put_PostalCode(HSTRING value);

        [VtblIndex(16)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAddressKind *")] ContactAddressKind* value);

        [VtblIndex(17)]
        HRESULT put_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAddressKind")] ContactAddressKind value);

        [VtblIndex(18)]
        HRESULT get_Description(HSTRING* value);

        [VtblIndex(19)]
        HRESULT put_Description(HSTRING value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_StreetAddress;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_StreetAddress;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Locality;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Locality;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Region;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Region;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Country;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Country;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PostalCode;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_PostalCode;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactAddressKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactAddressKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactAddressKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactAddressKind, int> put_Kind;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Description;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Description;
    }
}
