// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsDevice2.xml' path='doc/member[@name="ISmsDevice2"]/*' />
[Guid("BD8A5C13-E522-46CB-B8D5-9EAD30FB6C47")]
[NativeTypeName("struct ISmsDevice2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsDevice2 : ISmsDevice2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmsDevice2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, Guid*, void**, int>)(lpVtbl[0]))((ISmsDevice2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, uint>)(lpVtbl[1]))((ISmsDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, uint>)(lpVtbl[2]))((ISmsDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsDevice2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, HSTRING*, int>)(lpVtbl[4]))((ISmsDevice2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, TrustLevel*, int>)(lpVtbl[5]))((ISmsDevice2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsDevice2.xml' path='doc/member[@name="ISmsDevice2.get_SmscAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SmscAddress(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, HSTRING*, int>)(lpVtbl[6]))((ISmsDevice2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsDevice2.xml' path='doc/member[@name="ISmsDevice2.put_SmscAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SmscAddress(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, HSTRING, int>)(lpVtbl[7]))((ISmsDevice2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsDevice2.xml' path='doc/member[@name="ISmsDevice2.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, HSTRING*, int>)(lpVtbl[8]))((ISmsDevice2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsDevice2.xml' path='doc/member[@name="ISmsDevice2.get_ParentDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ParentDeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, HSTRING*, int>)(lpVtbl[9]))((ISmsDevice2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsDevice2.xml' path='doc/member[@name="ISmsDevice2.get_AccountPhoneNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AccountPhoneNumber(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, HSTRING*, int>)(lpVtbl[10]))((ISmsDevice2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsDevice2.xml' path='doc/member[@name="ISmsDevice2.get_CellularClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CellularClass([NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, CellularClass*, int>)(lpVtbl[11]))((ISmsDevice2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsDevice2.xml' path='doc/member[@name="ISmsDevice2.get_DeviceStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DeviceStatus([NativeTypeName("ABI::Windows::Devices::Sms::SmsDeviceStatus *")] SmsDeviceStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, SmsDeviceStatus*, int>)(lpVtbl[12]))((ISmsDevice2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsDevice2.xml' path='doc/member[@name="ISmsDevice2.CalculateLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CalculateLength([NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageBase *")] ISmsMessageBase* message, [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncodedLength *")] SmsEncodedLength* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, ISmsMessageBase*, SmsEncodedLength*, int>)(lpVtbl[13]))((ISmsDevice2*)Unsafe.AsPointer(ref this), message, value);
    }

    /// <include file='ISmsDevice2.xml' path='doc/member[@name="ISmsDevice2.SendMessageAndGetResultAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SendMessageAndGetResultAsync([NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageBase *")] ISmsMessageBase* message, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsSendMessageResult_t **")] IAsyncOperation<Pointer<ISmsSendMessageResult>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, ISmsMessageBase*, IAsyncOperation<Pointer<ISmsSendMessageResult>>**, int>)(lpVtbl[14]))((ISmsDevice2*)Unsafe.AsPointer(ref this), message, asyncInfo);
    }

    /// <include file='ISmsDevice2.xml' path='doc/member[@name="ISmsDevice2.add_DeviceStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_DeviceStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSms__CSmsDevice2_IInspectable_t *")] ITypedEventHandler<Pointer<ISmsDevice2>, Pointer<IInspectable>>* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, ITypedEventHandler<Pointer<ISmsDevice2>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[15]))((ISmsDevice2*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='ISmsDevice2.xml' path='doc/member[@name="ISmsDevice2.remove_DeviceStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_DeviceStatusChanged(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2*, EventRegistrationToken, int>)(lpVtbl[16]))((ISmsDevice2*)Unsafe.AsPointer(ref this), eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SmscAddress(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_SmscAddress(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_ParentDeviceId(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_AccountPhoneNumber(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_CellularClass([NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value);

        [VtblIndex(12)]
        HRESULT get_DeviceStatus([NativeTypeName("ABI::Windows::Devices::Sms::SmsDeviceStatus *")] SmsDeviceStatus* value);

        [VtblIndex(13)]
        HRESULT CalculateLength([NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageBase *")] ISmsMessageBase* message, [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncodedLength *")] SmsEncodedLength* value);

        [VtblIndex(14)]
        HRESULT SendMessageAndGetResultAsync([NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageBase *")] ISmsMessageBase* message, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsSendMessageResult_t **")] IAsyncOperation<Pointer<ISmsSendMessageResult>>** asyncInfo);

        [VtblIndex(15)]
        HRESULT add_DeviceStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSms__CSmsDevice2_IInspectable_t *")] ITypedEventHandler<Pointer<ISmsDevice2>, Pointer<IInspectable>>* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(16)]
        HRESULT remove_DeviceStatusChanged(EventRegistrationToken eventCookie);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SmscAddress;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_SmscAddress;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ParentDeviceId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AccountPhoneNumber;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::CellularClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CellularClass*, int> get_CellularClass;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsDeviceStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsDeviceStatus*, int> get_DeviceStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsMessageBase *, ABI::Windows::Devices::Sms::SmsEncodedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsMessageBase*, SmsEncodedLength*, int> CalculateLength;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsMessageBase *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsSendMessageResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsMessageBase*, IAsyncOperation<Pointer<ISmsSendMessageResult>>**, int> SendMessageAndGetResultAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSms__CSmsDevice2_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISmsDevice2>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_DeviceStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DeviceStatusChanged;
    }
}
