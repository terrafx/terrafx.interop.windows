// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic"]/*' />
[Guid("AEDE376D-5412-4D74-92A8-8DEB8526829C")]
[NativeTypeName("struct IGattLocalCharacteristic : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattLocalCharacteristic : IGattLocalCharacteristic.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGattLocalCharacteristic);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, Guid*, void**, int>)(lpVtbl[0]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, uint>)(lpVtbl[1]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, uint>)(lpVtbl[2]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, uint*, Guid**, int>)(lpVtbl[3]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, HSTRING*, int>)(lpVtbl[4]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, TrustLevel*, int>)(lpVtbl[5]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.get_Uuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Uuid(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, Guid*, int>)(lpVtbl[6]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.get_StaticValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_StaticValue([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, IBuffer**, int>)(lpVtbl[7]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.get_CharacteristicProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CharacteristicProperties([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties *")] GattCharacteristicProperties* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, GattCharacteristicProperties*, int>)(lpVtbl[8]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.get_ReadProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ReadProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, GattProtectionLevel*, int>)(lpVtbl[9]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.get_WriteProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_WriteProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, GattProtectionLevel*, int>)(lpVtbl[10]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.CreateDescriptorAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateDescriptorAsync(Guid descriptorUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalDescriptorParameters *")] IGattLocalDescriptorParameters* parameters, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptorResult_t **")] IAsyncOperation<Pointer<IGattLocalDescriptorResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, Guid, IGattLocalDescriptorParameters*, IAsyncOperation<Pointer<IGattLocalDescriptorResult>>**, int>)(lpVtbl[11]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), descriptorUuid, parameters, operation);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.get_Descriptors"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Descriptors([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptor_t **")] IVectorView<Pointer<IGattLocalDescriptor>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, IVectorView<Pointer<IGattLocalDescriptor>>**, int>)(lpVtbl[12]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.get_UserDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_UserDescription(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, HSTRING*, int>)(lpVtbl[13]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.get_PresentationFormats"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PresentationFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattPresentationFormat_t **")] IVectorView<Pointer<IGattPresentationFormat>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, IVectorView<Pointer<IGattPresentationFormat>>**, int>)(lpVtbl[14]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.get_SubscribedClients"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_SubscribedClients([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattSubscribedClient_t **")] IVectorView<Pointer<IGattSubscribedClient>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, IVectorView<Pointer<IGattSubscribedClient>>**, int>)(lpVtbl[15]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.add_SubscribedClientsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_SubscribedClientsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalCharacteristic_IInspectable_t *")] ITypedEventHandler<Pointer<IGattLocalCharacteristic>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, ITypedEventHandler<Pointer<IGattLocalCharacteristic>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[16]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.remove_SubscribedClientsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_SubscribedClientsChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, EventRegistrationToken, int>)(lpVtbl[17]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.add_ReadRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT add_ReadRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalCharacteristic_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IGattLocalCharacteristic>, Pointer<IGattReadRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, ITypedEventHandler<Pointer<IGattLocalCharacteristic>, Pointer<IGattReadRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[18]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.remove_ReadRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT remove_ReadRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, EventRegistrationToken, int>)(lpVtbl[19]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.add_WriteRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT add_WriteRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalCharacteristic_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IGattLocalCharacteristic>, Pointer<IGattWriteRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, ITypedEventHandler<Pointer<IGattLocalCharacteristic>, Pointer<IGattWriteRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[20]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.remove_WriteRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT remove_WriteRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, EventRegistrationToken, int>)(lpVtbl[21]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.NotifyValueAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT NotifyValueAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattClientNotificationResult_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IGattClientNotificationResult>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, IBuffer*, IAsyncOperation<Pointer<IVectorView<Pointer<IGattClientNotificationResult>>>>**, int>)(lpVtbl[22]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), value, operation);
    }

    /// <include file='IGattLocalCharacteristic.xml' path='doc/member[@name="IGattLocalCharacteristic.NotifyValueForSubscribedClientAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT NotifyValueForSubscribedClientAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattSubscribedClient *")] IGattSubscribedClient* subscribedClient, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattClientNotificationResult_t **")] IAsyncOperation<Pointer<IGattClientNotificationResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristic*, IBuffer*, IGattSubscribedClient*, IAsyncOperation<Pointer<IGattClientNotificationResult>>**, int>)(lpVtbl[23]))((IGattLocalCharacteristic*)Unsafe.AsPointer(ref this), value, subscribedClient, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Uuid(Guid* value);

        [VtblIndex(7)]
        HRESULT get_StaticValue([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(8)]
        HRESULT get_CharacteristicProperties([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties *")] GattCharacteristicProperties* value);

        [VtblIndex(9)]
        HRESULT get_ReadProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value);

        [VtblIndex(10)]
        HRESULT get_WriteProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value);

        [VtblIndex(11)]
        HRESULT CreateDescriptorAsync(Guid descriptorUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalDescriptorParameters *")] IGattLocalDescriptorParameters* parameters, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptorResult_t **")] IAsyncOperation<Pointer<IGattLocalDescriptorResult>>** operation);

        [VtblIndex(12)]
        HRESULT get_Descriptors([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptor_t **")] IVectorView<Pointer<IGattLocalDescriptor>>** value);

        [VtblIndex(13)]
        HRESULT get_UserDescription(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_PresentationFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattPresentationFormat_t **")] IVectorView<Pointer<IGattPresentationFormat>>** value);

        [VtblIndex(15)]
        HRESULT get_SubscribedClients([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattSubscribedClient_t **")] IVectorView<Pointer<IGattSubscribedClient>>** value);

        [VtblIndex(16)]
        HRESULT add_SubscribedClientsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalCharacteristic_IInspectable_t *")] ITypedEventHandler<Pointer<IGattLocalCharacteristic>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(17)]
        HRESULT remove_SubscribedClientsChanged(EventRegistrationToken token);

        [VtblIndex(18)]
        HRESULT add_ReadRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalCharacteristic_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IGattLocalCharacteristic>, Pointer<IGattReadRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(19)]
        HRESULT remove_ReadRequested(EventRegistrationToken token);

        [VtblIndex(20)]
        HRESULT add_WriteRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalCharacteristic_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IGattLocalCharacteristic>, Pointer<IGattWriteRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(21)]
        HRESULT remove_WriteRequested(EventRegistrationToken token);

        [VtblIndex(22)]
        HRESULT NotifyValueAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattClientNotificationResult_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IGattClientNotificationResult>>>>** operation);

        [VtblIndex(23)]
        HRESULT NotifyValueForSubscribedClientAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattSubscribedClient *")] IGattSubscribedClient* subscribedClient, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattClientNotificationResult_t **")] IAsyncOperation<Pointer<IGattClientNotificationResult>>** operation);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_Uuid;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_StaticValue;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattCharacteristicProperties*, int> get_CharacteristicProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel*, int> get_ReadProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel*, int> get_WriteProtectionLevel;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalDescriptorParameters *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptorResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IGattLocalDescriptorParameters*, IAsyncOperation<Pointer<IGattLocalDescriptorResult>>**, int> CreateDescriptorAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IGattLocalDescriptor>>**, int> get_Descriptors;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserDescription;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattPresentationFormat_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IGattPresentationFormat>>**, int> get_PresentationFormats;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattSubscribedClient_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IGattSubscribedClient>>**, int> get_SubscribedClients;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalCharacteristic_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGattLocalCharacteristic>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_SubscribedClientsChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SubscribedClientsChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalCharacteristic_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGattLocalCharacteristic>, Pointer<IGattReadRequestedEventArgs>>*, EventRegistrationToken*, int> add_ReadRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ReadRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalCharacteristic_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGattLocalCharacteristic>, Pointer<IGattWriteRequestedEventArgs>>*, EventRegistrationToken*, int> add_WriteRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_WriteRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattClientNotificationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IAsyncOperation<Pointer<IVectorView<Pointer<IGattClientNotificationResult>>>>**, int> NotifyValueAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattSubscribedClient *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattClientNotificationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IGattSubscribedClient*, IAsyncOperation<Pointer<IGattClientNotificationResult>>**, int> NotifyValueForSubscribedClientAsync;
    }
}
