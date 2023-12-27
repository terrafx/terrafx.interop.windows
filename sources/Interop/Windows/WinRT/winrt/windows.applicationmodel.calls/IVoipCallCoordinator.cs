// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVoipCallCoordinator.xml' path='doc/member[@name="IVoipCallCoordinator"]/*' />
[Guid("4F118BCF-E8EF-4434-9C5F-A8D893FAFE79")]
[NativeTypeName("struct IVoipCallCoordinator : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVoipCallCoordinator : IVoipCallCoordinator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVoipCallCoordinator));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, Guid*, void**, int>)(lpVtbl[0]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, uint>)(lpVtbl[1]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, uint>)(lpVtbl[2]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, uint*, Guid**, int>)(lpVtbl[3]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, HSTRING*, int>)(lpVtbl[4]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, TrustLevel*, int>)(lpVtbl[5]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVoipCallCoordinator.xml' path='doc/member[@name="IVoipCallCoordinator.ReserveCallResourcesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReserveCallResourcesAsync(HSTRING taskEntryPoint, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CVoipPhoneCallResourceReservationStatus_t **")] IAsyncOperation<VoipPhoneCallResourceReservationStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, HSTRING, IAsyncOperation<VoipPhoneCallResourceReservationStatus>**, int>)(lpVtbl[6]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this), taskEntryPoint, operation);
    }

    /// <include file='IVoipCallCoordinator.xml' path='doc/member[@name="IVoipCallCoordinator.add_MuteStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_MuteStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipCallCoordinator_Windows__CApplicationModel__CCalls__CMuteChangeEventArgs_t *")] ITypedEventHandler<Pointer<IVoipCallCoordinator>, Pointer<IMuteChangeEventArgs>>* muteChangeHandler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, ITypedEventHandler<Pointer<IVoipCallCoordinator>, Pointer<IMuteChangeEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this), muteChangeHandler, token);
    }

    /// <include file='IVoipCallCoordinator.xml' path='doc/member[@name="IVoipCallCoordinator.remove_MuteStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_MuteStateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, EventRegistrationToken, int>)(lpVtbl[8]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IVoipCallCoordinator.xml' path='doc/member[@name="IVoipCallCoordinator.RequestNewIncomingCall"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestNewIncomingCall(HSTRING context, HSTRING contactName, HSTRING contactNumber, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* contactImage, HSTRING serviceName, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* brandingImage, HSTRING callDetails, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* ringtone, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia media, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan ringTimeout, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** call)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, HSTRING, HSTRING, HSTRING, IUriRuntimeClass*, HSTRING, IUriRuntimeClass*, HSTRING, IUriRuntimeClass*, VoipPhoneCallMedia, TimeSpan, IVoipPhoneCall**, int>)(lpVtbl[9]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this), context, contactName, contactNumber, contactImage, serviceName, brandingImage, callDetails, ringtone, media, ringTimeout, call);
    }

    /// <include file='IVoipCallCoordinator.xml' path='doc/member[@name="IVoipCallCoordinator.RequestNewOutgoingCall"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestNewOutgoingCall(HSTRING context, HSTRING contactName, HSTRING serviceName, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia media, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** call)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, HSTRING, HSTRING, HSTRING, VoipPhoneCallMedia, IVoipPhoneCall**, int>)(lpVtbl[10]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this), context, contactName, serviceName, media, call);
    }

    /// <include file='IVoipCallCoordinator.xml' path='doc/member[@name="IVoipCallCoordinator.NotifyMuted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT NotifyMuted()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, int>)(lpVtbl[11]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVoipCallCoordinator.xml' path='doc/member[@name="IVoipCallCoordinator.NotifyUnmuted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT NotifyUnmuted()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, int>)(lpVtbl[12]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVoipCallCoordinator.xml' path='doc/member[@name="IVoipCallCoordinator.RequestOutgoingUpgradeToVideoCall"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RequestOutgoingUpgradeToVideoCall(Guid callUpgradeGuid, HSTRING context, HSTRING contactName, HSTRING serviceName, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** call)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, Guid, HSTRING, HSTRING, HSTRING, IVoipPhoneCall**, int>)(lpVtbl[13]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this), callUpgradeGuid, context, contactName, serviceName, call);
    }

    /// <include file='IVoipCallCoordinator.xml' path='doc/member[@name="IVoipCallCoordinator.RequestIncomingUpgradeToVideoCall"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT RequestIncomingUpgradeToVideoCall(HSTRING context, HSTRING contactName, HSTRING contactNumber, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* contactImage, HSTRING serviceName, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* brandingImage, HSTRING callDetails, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* ringtone, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan ringTimeout, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** call)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, HSTRING, HSTRING, HSTRING, IUriRuntimeClass*, HSTRING, IUriRuntimeClass*, HSTRING, IUriRuntimeClass*, TimeSpan, IVoipPhoneCall**, int>)(lpVtbl[14]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this), context, contactName, contactNumber, contactImage, serviceName, brandingImage, callDetails, ringtone, ringTimeout, call);
    }

    /// <include file='IVoipCallCoordinator.xml' path='doc/member[@name="IVoipCallCoordinator.TerminateCellularCall"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT TerminateCellularCall(Guid callUpgradeGuid)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, Guid, int>)(lpVtbl[15]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this), callUpgradeGuid);
    }

    /// <include file='IVoipCallCoordinator.xml' path='doc/member[@name="IVoipCallCoordinator.CancelUpgrade"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CancelUpgrade(Guid callUpgradeGuid)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator*, Guid, int>)(lpVtbl[16]))((IVoipCallCoordinator*)Unsafe.AsPointer(ref this), callUpgradeGuid);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ReserveCallResourcesAsync(HSTRING taskEntryPoint, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CVoipPhoneCallResourceReservationStatus_t **")] IAsyncOperation<VoipPhoneCallResourceReservationStatus>** operation);

        [VtblIndex(7)]
        HRESULT add_MuteStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipCallCoordinator_Windows__CApplicationModel__CCalls__CMuteChangeEventArgs_t *")] ITypedEventHandler<Pointer<IVoipCallCoordinator>, Pointer<IMuteChangeEventArgs>>* muteChangeHandler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_MuteStateChanged(EventRegistrationToken token);

        [VtblIndex(9)]
        HRESULT RequestNewIncomingCall(HSTRING context, HSTRING contactName, HSTRING contactNumber, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* contactImage, HSTRING serviceName, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* brandingImage, HSTRING callDetails, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* ringtone, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia media, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan ringTimeout, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** call);

        [VtblIndex(10)]
        HRESULT RequestNewOutgoingCall(HSTRING context, HSTRING contactName, HSTRING serviceName, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia media, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** call);

        [VtblIndex(11)]
        HRESULT NotifyMuted();

        [VtblIndex(12)]
        HRESULT NotifyUnmuted();

        [VtblIndex(13)]
        HRESULT RequestOutgoingUpgradeToVideoCall(Guid callUpgradeGuid, HSTRING context, HSTRING contactName, HSTRING serviceName, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** call);

        [VtblIndex(14)]
        HRESULT RequestIncomingUpgradeToVideoCall(HSTRING context, HSTRING contactName, HSTRING contactNumber, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* contactImage, HSTRING serviceName, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* brandingImage, HSTRING callDetails, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* ringtone, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan ringTimeout, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** call);

        [VtblIndex(15)]
        HRESULT TerminateCellularCall(Guid callUpgradeGuid);

        [VtblIndex(16)]
        HRESULT CancelUpgrade(Guid callUpgradeGuid);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CVoipPhoneCallResourceReservationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<VoipPhoneCallResourceReservationStatus>**, int> ReserveCallResourcesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipCallCoordinator_Windows__CApplicationModel__CCalls__CMuteChangeEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IVoipCallCoordinator>, Pointer<IMuteChangeEventArgs>>*, EventRegistrationToken*, int> add_MuteStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MuteStateChanged;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia, ABI::Windows::Foundation::TimeSpan, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, IUriRuntimeClass*, HSTRING, IUriRuntimeClass*, HSTRING, IUriRuntimeClass*, VoipPhoneCallMedia, TimeSpan, IVoipPhoneCall**, int> RequestNewIncomingCall;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, VoipPhoneCallMedia, IVoipPhoneCall**, int> RequestNewOutgoingCall;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> NotifyMuted;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> NotifyUnmuted;

        [NativeTypeName("HRESULT (GUID, HSTRING, HSTRING, HSTRING, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, HSTRING, HSTRING, HSTRING, IVoipPhoneCall**, int> RequestOutgoingUpgradeToVideoCall;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::TimeSpan, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, IUriRuntimeClass*, HSTRING, IUriRuntimeClass*, HSTRING, IUriRuntimeClass*, TimeSpan, IVoipPhoneCall**, int> RequestIncomingUpgradeToVideoCall;

        [NativeTypeName("HRESULT (GUID) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, int> TerminateCellularCall;

        [NativeTypeName("HRESULT (GUID) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, int> CancelUpgrade;
    }
}
