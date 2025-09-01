// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic"]/*' />
[Guid("59CB50C1-5934-4F68-A198-EB864FA44E6B")]
[NativeTypeName("struct IGattCharacteristic : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattCharacteristic : IGattCharacteristic.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGattCharacteristic);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, Guid*, void**, int>)(lpVtbl[0]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, uint>)(lpVtbl[1]))((IGattCharacteristic*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, uint>)(lpVtbl[2]))((IGattCharacteristic*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, uint*, Guid**, int>)(lpVtbl[3]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, HSTRING*, int>)(lpVtbl[4]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, TrustLevel*, int>)(lpVtbl[5]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.GetDescriptors"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Use GetDescriptorsForUuidAsync instead of GetDescriptors.  For more information, see MSDN.")]
    public HRESULT GetDescriptors(Guid descriptorUuid, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptor_t **")] IVectorView<Pointer<IGattDescriptor>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, Guid, IVectorView<Pointer<IGattDescriptor>>**, int>)(lpVtbl[6]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), descriptorUuid, value);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.get_CharacteristicProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CharacteristicProperties([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties *")] GattCharacteristicProperties* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, GattCharacteristicProperties*, int>)(lpVtbl[7]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.get_ProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, GattProtectionLevel*, int>)(lpVtbl[8]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.put_ProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel")] GattProtectionLevel value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, GattProtectionLevel, int>)(lpVtbl[9]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.get_UserDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_UserDescription(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, HSTRING*, int>)(lpVtbl[10]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.get_Uuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Uuid(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, Guid*, int>)(lpVtbl[11]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.get_AttributeHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AttributeHandle([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, ushort*, int>)(lpVtbl[12]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.get_PresentationFormats"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PresentationFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattPresentationFormat_t **")] IVectorView<Pointer<IGattPresentationFormat>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, IVectorView<Pointer<IGattPresentationFormat>>**, int>)(lpVtbl[13]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.ReadValueAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ReadValueAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **")] IAsyncOperation<Pointer<IGattReadResult>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, IAsyncOperation<Pointer<IGattReadResult>>**, int>)(lpVtbl[14]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.ReadValueWithCacheModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ReadValueWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **")] IAsyncOperation<Pointer<IGattReadResult>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, BluetoothCacheMode, IAsyncOperation<Pointer<IGattReadResult>>**, int>)(lpVtbl[15]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), cacheMode, value);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.WriteValueAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT WriteValueAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **")] IAsyncOperation<GattCommunicationStatus>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, IBuffer*, IAsyncOperation<GattCommunicationStatus>**, int>)(lpVtbl[16]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), value, asyncOp);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.WriteValueWithOptionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT WriteValueWithOptionAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattWriteOption")] GattWriteOption writeOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **")] IAsyncOperation<GattCommunicationStatus>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, IBuffer*, GattWriteOption, IAsyncOperation<GattCommunicationStatus>**, int>)(lpVtbl[17]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), value, writeOption, asyncOp);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.ReadClientCharacteristicConfigurationDescriptorAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ReadClientCharacteristicConfigurationDescriptorAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadClientCharacteristicConfigurationDescriptorResult_t **")] IAsyncOperation<Pointer<IGattReadClientCharacteristicConfigurationDescriptorResult>>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, IAsyncOperation<Pointer<IGattReadClientCharacteristicConfigurationDescriptorResult>>**, int>)(lpVtbl[18]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), asyncOp);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.WriteClientCharacteristicConfigurationDescriptorAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT WriteClientCharacteristicConfigurationDescriptorAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattClientCharacteristicConfigurationDescriptorValue")] GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **")] IAsyncOperation<GattCommunicationStatus>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, GattClientCharacteristicConfigurationDescriptorValue, IAsyncOperation<GattCommunicationStatus>**, int>)(lpVtbl[19]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), clientCharacteristicConfigurationDescriptorValue, asyncOp);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.add_ValueChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT add_ValueChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattValueChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGattCharacteristic>, Pointer<IGattValueChangedEventArgs>>* valueChangedHandler, EventRegistrationToken* valueChangedEventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, ITypedEventHandler<Pointer<IGattCharacteristic>, Pointer<IGattValueChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[20]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), valueChangedHandler, valueChangedEventCookie);
    }

    /// <include file='IGattCharacteristic.xml' path='doc/member[@name="IGattCharacteristic.remove_ValueChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT remove_ValueChanged(EventRegistrationToken valueChangedEventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic*, EventRegistrationToken, int>)(lpVtbl[21]))((IGattCharacteristic*)Unsafe.AsPointer(ref this), valueChangedEventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Use GetDescriptorsForUuidAsync instead of GetDescriptors.  For more information, see MSDN.")]
        HRESULT GetDescriptors(Guid descriptorUuid, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptor_t **")] IVectorView<Pointer<IGattDescriptor>>** value);

        [VtblIndex(7)]
        HRESULT get_CharacteristicProperties([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties *")] GattCharacteristicProperties* value);

        [VtblIndex(8)]
        HRESULT get_ProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value);

        [VtblIndex(9)]
        HRESULT put_ProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel")] GattProtectionLevel value);

        [VtblIndex(10)]
        HRESULT get_UserDescription(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Uuid(Guid* value);

        [VtblIndex(12)]
        HRESULT get_AttributeHandle([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(13)]
        HRESULT get_PresentationFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattPresentationFormat_t **")] IVectorView<Pointer<IGattPresentationFormat>>** value);

        [VtblIndex(14)]
        HRESULT ReadValueAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **")] IAsyncOperation<Pointer<IGattReadResult>>** value);

        [VtblIndex(15)]
        HRESULT ReadValueWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **")] IAsyncOperation<Pointer<IGattReadResult>>** value);

        [VtblIndex(16)]
        HRESULT WriteValueAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **")] IAsyncOperation<GattCommunicationStatus>** asyncOp);

        [VtblIndex(17)]
        HRESULT WriteValueWithOptionAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattWriteOption")] GattWriteOption writeOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **")] IAsyncOperation<GattCommunicationStatus>** asyncOp);

        [VtblIndex(18)]
        HRESULT ReadClientCharacteristicConfigurationDescriptorAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadClientCharacteristicConfigurationDescriptorResult_t **")] IAsyncOperation<Pointer<IGattReadClientCharacteristicConfigurationDescriptorResult>>** asyncOp);

        [VtblIndex(19)]
        HRESULT WriteClientCharacteristicConfigurationDescriptorAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattClientCharacteristicConfigurationDescriptorValue")] GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **")] IAsyncOperation<GattCommunicationStatus>** asyncOp);

        [VtblIndex(20)]
        HRESULT add_ValueChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattValueChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGattCharacteristic>, Pointer<IGattValueChangedEventArgs>>* valueChangedHandler, EventRegistrationToken* valueChangedEventCookie);

        [VtblIndex(21)]
        HRESULT remove_ValueChanged(EventRegistrationToken valueChangedEventCookie);
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

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptor_t **) __attribute__((stdcall))")]
        [Obsolete("Use GetDescriptorsForUuidAsync instead of GetDescriptors.  For more information, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IVectorView<Pointer<IGattDescriptor>>**, int> GetDescriptors;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattCharacteristicProperties*, int> get_CharacteristicProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel*, int> get_ProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel, int> put_ProtectionLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserDescription;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_Uuid;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_AttributeHandle;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattPresentationFormat_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IGattPresentationFormat>>**, int> get_PresentationFormats;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IGattReadResult>>**, int> ReadValueAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothCacheMode, IAsyncOperation<Pointer<IGattReadResult>>**, int> ReadValueWithCacheModeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IAsyncOperation<GattCommunicationStatus>**, int> WriteValueAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattWriteOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, GattWriteOption, IAsyncOperation<GattCommunicationStatus>**, int> WriteValueWithOptionAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadClientCharacteristicConfigurationDescriptorResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IGattReadClientCharacteristicConfigurationDescriptorResult>>**, int> ReadClientCharacteristicConfigurationDescriptorAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattClientCharacteristicConfigurationDescriptorValue, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattClientCharacteristicConfigurationDescriptorValue, IAsyncOperation<GattCommunicationStatus>**, int> WriteClientCharacteristicConfigurationDescriptorAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattValueChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGattCharacteristic>, Pointer<IGattValueChangedEventArgs>>*, EventRegistrationToken*, int> add_ValueChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ValueChanged;
    }
}
