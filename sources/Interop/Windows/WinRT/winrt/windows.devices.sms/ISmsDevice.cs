// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsDevice.xml' path='doc/member[@name="ISmsDevice"]/*' />
[Guid("091791ED-872B-4EEC-9C72-AB11627B34EC")]
[NativeTypeName("struct ISmsDevice : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
public unsafe partial struct ISmsDevice : ISmsDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmsDevice);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, Guid*, void**, int>)(lpVtbl[0]))((ISmsDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, uint>)(lpVtbl[1]))((ISmsDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, uint>)(lpVtbl[2]))((ISmsDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsDevice*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, HSTRING*, int>)(lpVtbl[4]))((ISmsDevice*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, TrustLevel*, int>)(lpVtbl[5]))((ISmsDevice*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsDevice.xml' path='doc/member[@name="ISmsDevice.SendMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
    public HRESULT SendMessageAsync([NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessage *")] ISmsMessage* message, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, ISmsMessage*, IAsyncAction**, int>)(lpVtbl[6]))((ISmsDevice*)Unsafe.AsPointer(ref this), message, asyncInfo);
    }

    /// <include file='ISmsDevice.xml' path='doc/member[@name="ISmsDevice.CalculateLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
    public HRESULT CalculateLength([NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage *")] ISmsTextMessage* message, [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncodedLength *")] SmsEncodedLength* encodedLength)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, ISmsTextMessage*, SmsEncodedLength*, int>)(lpVtbl[7]))((ISmsDevice*)Unsafe.AsPointer(ref this), message, encodedLength);
    }

    /// <include file='ISmsDevice.xml' path='doc/member[@name="ISmsDevice.get_AccountPhoneNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
    public HRESULT get_AccountPhoneNumber(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, HSTRING*, int>)(lpVtbl[8]))((ISmsDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsDevice.xml' path='doc/member[@name="ISmsDevice.get_CellularClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
    public HRESULT get_CellularClass([NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, CellularClass*, int>)(lpVtbl[9]))((ISmsDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsDevice.xml' path='doc/member[@name="ISmsDevice.get_MessageStore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
    public HRESULT get_MessageStore([NativeTypeName("ABI::Windows::Devices::Sms::ISmsDeviceMessageStore **")] ISmsDeviceMessageStore** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, ISmsDeviceMessageStore**, int>)(lpVtbl[10]))((ISmsDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsDevice.xml' path='doc/member[@name="ISmsDevice.get_DeviceStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
    public HRESULT get_DeviceStatus([NativeTypeName("ABI::Windows::Devices::Sms::SmsDeviceStatus *")] SmsDeviceStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, SmsDeviceStatus*, int>)(lpVtbl[11]))((ISmsDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsDevice.xml' path='doc/member[@name="ISmsDevice.add_SmsMessageReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
    public HRESULT add_SmsMessageReceived([NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageReceivedEventHandler *")] ISmsMessageReceivedEventHandler* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, ISmsMessageReceivedEventHandler*, EventRegistrationToken*, int>)(lpVtbl[12]))((ISmsDevice*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='ISmsDevice.xml' path='doc/member[@name="ISmsDevice.remove_SmsMessageReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
    public HRESULT remove_SmsMessageReceived(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, EventRegistrationToken, int>)(lpVtbl[13]))((ISmsDevice*)Unsafe.AsPointer(ref this), eventCookie);
    }

    /// <include file='ISmsDevice.xml' path='doc/member[@name="ISmsDevice.add_SmsDeviceStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
    public HRESULT add_SmsDeviceStatusChanged([NativeTypeName("ABI::Windows::Devices::Sms::ISmsDeviceStatusChangedEventHandler *")] ISmsDeviceStatusChangedEventHandler* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, ISmsDeviceStatusChangedEventHandler*, EventRegistrationToken*, int>)(lpVtbl[14]))((ISmsDevice*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='ISmsDevice.xml' path='doc/member[@name="ISmsDevice.remove_SmsDeviceStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
    public HRESULT remove_SmsDeviceStatusChanged(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice*, EventRegistrationToken, int>)(lpVtbl[15]))((ISmsDevice*)Unsafe.AsPointer(ref this), eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        HRESULT SendMessageAsync([NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessage *")] ISmsMessage* message, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(7)]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        HRESULT CalculateLength([NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage *")] ISmsTextMessage* message, [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncodedLength *")] SmsEncodedLength* encodedLength);

        [VtblIndex(8)]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        HRESULT get_AccountPhoneNumber(HSTRING* value);

        [VtblIndex(9)]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        HRESULT get_CellularClass([NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value);

        [VtblIndex(10)]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        HRESULT get_MessageStore([NativeTypeName("ABI::Windows::Devices::Sms::ISmsDeviceMessageStore **")] ISmsDeviceMessageStore** value);

        [VtblIndex(11)]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        HRESULT get_DeviceStatus([NativeTypeName("ABI::Windows::Devices::Sms::SmsDeviceStatus *")] SmsDeviceStatus* value);

        [VtblIndex(12)]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        HRESULT add_SmsMessageReceived([NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageReceivedEventHandler *")] ISmsMessageReceivedEventHandler* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(13)]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        HRESULT remove_SmsMessageReceived(EventRegistrationToken eventCookie);

        [VtblIndex(14)]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        HRESULT add_SmsDeviceStatusChanged([NativeTypeName("ABI::Windows::Devices::Sms::ISmsDeviceStatusChangedEventHandler *")] ISmsDeviceStatusChangedEventHandler* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(15)]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        HRESULT remove_SmsDeviceStatusChanged(EventRegistrationToken eventCookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsMessage *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsMessage*, IAsyncAction**, int> SendMessageAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsTextMessage *, ABI::Windows::Devices::Sms::SmsEncodedLength *) __attribute__((stdcall))")]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsTextMessage*, SmsEncodedLength*, int> CalculateLength;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AccountPhoneNumber;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::CellularClass *) __attribute__((stdcall))")]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CellularClass*, int> get_CellularClass;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsDeviceMessageStore **) __attribute__((stdcall))")]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsDeviceMessageStore**, int> get_MessageStore;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsDeviceStatus *) __attribute__((stdcall))")]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsDeviceStatus*, int> get_DeviceStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsMessageReceivedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsMessageReceivedEventHandler*, EventRegistrationToken*, int> add_SmsMessageReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SmsMessageReceived;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsDeviceStatusChangedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsDeviceStatusChangedEventHandler*, EventRegistrationToken*, int> add_SmsDeviceStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SmsDeviceStatusChanged;
    }
}
