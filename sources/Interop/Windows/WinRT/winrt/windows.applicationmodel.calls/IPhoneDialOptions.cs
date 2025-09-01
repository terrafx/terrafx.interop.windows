// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneDialOptions.xml' path='doc/member[@name="IPhoneDialOptions"]/*' />
[Guid("B639C4B8-F06F-36CB-A863-823742B5F2D4")]
[NativeTypeName("struct IPhoneDialOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneDialOptions : IPhoneDialOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPhoneDialOptions);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, uint>)(lpVtbl[1]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, uint>)(lpVtbl[2]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, HSTRING*, int>)(lpVtbl[4]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneDialOptions.xml' path='doc/member[@name="IPhoneDialOptions.get_Number"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Number(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, HSTRING*, int>)(lpVtbl[6]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneDialOptions.xml' path='doc/member[@name="IPhoneDialOptions.put_Number"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Number(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, HSTRING, int>)(lpVtbl[7]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneDialOptions.xml' path='doc/member[@name="IPhoneDialOptions.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, HSTRING*, int>)(lpVtbl[8]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneDialOptions.xml' path='doc/member[@name="IPhoneDialOptions.put_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, HSTRING, int>)(lpVtbl[9]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneDialOptions.xml' path='doc/member[@name="IPhoneDialOptions.get_Contact"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Contact([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact **")] IContact** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, IContact**, int>)(lpVtbl[10]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneDialOptions.xml' path='doc/member[@name="IPhoneDialOptions.put_Contact"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Contact([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, IContact*, int>)(lpVtbl[11]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneDialOptions.xml' path='doc/member[@name="IPhoneDialOptions.get_ContactPhone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ContactPhone([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactPhone **")] IContactPhone** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, IContactPhone**, int>)(lpVtbl[12]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneDialOptions.xml' path='doc/member[@name="IPhoneDialOptions.put_ContactPhone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_ContactPhone([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactPhone *")] IContactPhone* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, IContactPhone*, int>)(lpVtbl[13]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneDialOptions.xml' path='doc/member[@name="IPhoneDialOptions.get_Media"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallMedia *")] PhoneCallMedia* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, PhoneCallMedia*, int>)(lpVtbl[14]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneDialOptions.xml' path='doc/member[@name="IPhoneDialOptions.put_Media"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallMedia")] PhoneCallMedia value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, PhoneCallMedia, int>)(lpVtbl[15]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneDialOptions.xml' path='doc/member[@name="IPhoneDialOptions.get_AudioEndpoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_AudioEndpoint([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneAudioRoutingEndpoint *")] PhoneAudioRoutingEndpoint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, PhoneAudioRoutingEndpoint*, int>)(lpVtbl[16]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneDialOptions.xml' path='doc/member[@name="IPhoneDialOptions.put_AudioEndpoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_AudioEndpoint([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneAudioRoutingEndpoint")] PhoneAudioRoutingEndpoint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneDialOptions*, PhoneAudioRoutingEndpoint, int>)(lpVtbl[17]))((IPhoneDialOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Number(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Number(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Contact([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact **")] IContact** value);

        [VtblIndex(11)]
        HRESULT put_Contact([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* value);

        [VtblIndex(12)]
        HRESULT get_ContactPhone([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactPhone **")] IContactPhone** value);

        [VtblIndex(13)]
        HRESULT put_ContactPhone([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactPhone *")] IContactPhone* value);

        [VtblIndex(14)]
        HRESULT get_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallMedia *")] PhoneCallMedia* value);

        [VtblIndex(15)]
        HRESULT put_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallMedia")] PhoneCallMedia value);

        [VtblIndex(16)]
        HRESULT get_AudioEndpoint([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneAudioRoutingEndpoint *")] PhoneAudioRoutingEndpoint* value);

        [VtblIndex(17)]
        HRESULT put_AudioEndpoint([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneAudioRoutingEndpoint")] PhoneAudioRoutingEndpoint value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Number;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Number;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact**, int> get_Contact;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, int> put_Contact;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactPhone **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContactPhone**, int> get_ContactPhone;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactPhone *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContactPhone*, int> put_ContactPhone;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallMedia *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallMedia*, int> get_Media;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallMedia) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallMedia, int> put_Media;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneAudioRoutingEndpoint *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneAudioRoutingEndpoint*, int> get_AudioEndpoint;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneAudioRoutingEndpoint) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneAudioRoutingEndpoint, int> put_AudioEndpoint;
    }
}
