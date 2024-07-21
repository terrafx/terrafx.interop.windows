// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneLineTransportDevice2.xml' path='doc/member[@name="IPhoneLineTransportDevice2"]/*' />
[Guid("64C885F2-ECF4-5761-8C04-3C248CE61690")]
[NativeTypeName("struct IPhoneLineTransportDevice2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneLineTransportDevice2 : IPhoneLineTransportDevice2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneLineTransportDevice2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice2*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneLineTransportDevice2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice2*, uint>)(lpVtbl[1]))((IPhoneLineTransportDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice2*, uint>)(lpVtbl[2]))((IPhoneLineTransportDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice2*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneLineTransportDevice2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice2*, HSTRING*, int>)(lpVtbl[4]))((IPhoneLineTransportDevice2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice2*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneLineTransportDevice2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneLineTransportDevice2.xml' path='doc/member[@name="IPhoneLineTransportDevice2.get_AudioRoutingStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AudioRoutingStatus([NativeTypeName("ABI::Windows::ApplicationModel::Calls::TransportDeviceAudioRoutingStatus *")] TransportDeviceAudioRoutingStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice2*, TransportDeviceAudioRoutingStatus*, int>)(lpVtbl[6]))((IPhoneLineTransportDevice2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLineTransportDevice2.xml' path='doc/member[@name="IPhoneLineTransportDevice2.add_AudioRoutingStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_AudioRoutingStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineTransportDevice_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneLineTransportDevice>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice2*, ITypedEventHandler<Pointer<IPhoneLineTransportDevice>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IPhoneLineTransportDevice2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhoneLineTransportDevice2.xml' path='doc/member[@name="IPhoneLineTransportDevice2.remove_AudioRoutingStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_AudioRoutingStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice2*, EventRegistrationToken, int>)(lpVtbl[8]))((IPhoneLineTransportDevice2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPhoneLineTransportDevice2.xml' path='doc/member[@name="IPhoneLineTransportDevice2.get_InBandRingingEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_InBandRingingEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice2*, byte*, int>)(lpVtbl[9]))((IPhoneLineTransportDevice2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLineTransportDevice2.xml' path='doc/member[@name="IPhoneLineTransportDevice2.add_InBandRingingEnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_InBandRingingEnabledChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineTransportDevice_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneLineTransportDevice>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice2*, ITypedEventHandler<Pointer<IPhoneLineTransportDevice>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IPhoneLineTransportDevice2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhoneLineTransportDevice2.xml' path='doc/member[@name="IPhoneLineTransportDevice2.remove_InBandRingingEnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_InBandRingingEnabledChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice2*, EventRegistrationToken, int>)(lpVtbl[11]))((IPhoneLineTransportDevice2*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AudioRoutingStatus([NativeTypeName("ABI::Windows::ApplicationModel::Calls::TransportDeviceAudioRoutingStatus *")] TransportDeviceAudioRoutingStatus* value);

        [VtblIndex(7)]
        HRESULT add_AudioRoutingStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineTransportDevice_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneLineTransportDevice>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_AudioRoutingStatusChanged(EventRegistrationToken token);

        [VtblIndex(9)]
        HRESULT get_InBandRingingEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT add_InBandRingingEnabledChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineTransportDevice_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneLineTransportDevice>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_InBandRingingEnabledChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::TransportDeviceAudioRoutingStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TransportDeviceAudioRoutingStatus*, int> get_AudioRoutingStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineTransportDevice_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhoneLineTransportDevice>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_AudioRoutingStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AudioRoutingStatusChanged;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_InBandRingingEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineTransportDevice_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhoneLineTransportDevice>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_InBandRingingEnabledChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_InBandRingingEnabledChanged;
    }
}
