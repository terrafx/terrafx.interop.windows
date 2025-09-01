// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattCharacteristic3.xml' path='doc/member[@name="IGattCharacteristic3"]/*' />
[Guid("3F3C663E-93D4-406B-B817-DB81F8ED53B3")]
[NativeTypeName("struct IGattCharacteristic3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattCharacteristic3 : IGattCharacteristic3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGattCharacteristic3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic3*, Guid*, void**, int>)(lpVtbl[0]))((IGattCharacteristic3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic3*, uint>)(lpVtbl[1]))((IGattCharacteristic3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic3*, uint>)(lpVtbl[2]))((IGattCharacteristic3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic3*, uint*, Guid**, int>)(lpVtbl[3]))((IGattCharacteristic3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic3*, HSTRING*, int>)(lpVtbl[4]))((IGattCharacteristic3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic3*, TrustLevel*, int>)(lpVtbl[5]))((IGattCharacteristic3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattCharacteristic3.xml' path='doc/member[@name="IGattCharacteristic3.GetDescriptorsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDescriptorsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptorsResult_t **")] IAsyncOperation<Pointer<IGattDescriptorsResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic3*, IAsyncOperation<Pointer<IGattDescriptorsResult>>**, int>)(lpVtbl[6]))((IGattCharacteristic3*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IGattCharacteristic3.xml' path='doc/member[@name="IGattCharacteristic3.GetDescriptorsWithCacheModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDescriptorsWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptorsResult_t **")] IAsyncOperation<Pointer<IGattDescriptorsResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic3*, BluetoothCacheMode, IAsyncOperation<Pointer<IGattDescriptorsResult>>**, int>)(lpVtbl[7]))((IGattCharacteristic3*)Unsafe.AsPointer(ref this), cacheMode, operation);
    }

    /// <include file='IGattCharacteristic3.xml' path='doc/member[@name="IGattCharacteristic3.GetDescriptorsForUuidAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDescriptorsForUuidAsync(Guid descriptorUuid, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptorsResult_t **")] IAsyncOperation<Pointer<IGattDescriptorsResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic3*, Guid, IAsyncOperation<Pointer<IGattDescriptorsResult>>**, int>)(lpVtbl[8]))((IGattCharacteristic3*)Unsafe.AsPointer(ref this), descriptorUuid, operation);
    }

    /// <include file='IGattCharacteristic3.xml' path='doc/member[@name="IGattCharacteristic3.GetDescriptorsForUuidWithCacheModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDescriptorsForUuidWithCacheModeAsync(Guid descriptorUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptorsResult_t **")] IAsyncOperation<Pointer<IGattDescriptorsResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic3*, Guid, BluetoothCacheMode, IAsyncOperation<Pointer<IGattDescriptorsResult>>**, int>)(lpVtbl[9]))((IGattCharacteristic3*)Unsafe.AsPointer(ref this), descriptorUuid, cacheMode, operation);
    }

    /// <include file='IGattCharacteristic3.xml' path='doc/member[@name="IGattCharacteristic3.WriteValueWithResultAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT WriteValueWithResultAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteResult_t **")] IAsyncOperation<Pointer<IGattWriteResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic3*, IBuffer*, IAsyncOperation<Pointer<IGattWriteResult>>**, int>)(lpVtbl[10]))((IGattCharacteristic3*)Unsafe.AsPointer(ref this), value, operation);
    }

    /// <include file='IGattCharacteristic3.xml' path='doc/member[@name="IGattCharacteristic3.WriteValueWithResultAndOptionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT WriteValueWithResultAndOptionAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattWriteOption")] GattWriteOption writeOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteResult_t **")] IAsyncOperation<Pointer<IGattWriteResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic3*, IBuffer*, GattWriteOption, IAsyncOperation<Pointer<IGattWriteResult>>**, int>)(lpVtbl[11]))((IGattCharacteristic3*)Unsafe.AsPointer(ref this), value, writeOption, operation);
    }

    /// <include file='IGattCharacteristic3.xml' path='doc/member[@name="IGattCharacteristic3.WriteClientCharacteristicConfigurationDescriptorWithResultAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT WriteClientCharacteristicConfigurationDescriptorWithResultAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattClientCharacteristicConfigurationDescriptorValue")] GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteResult_t **")] IAsyncOperation<Pointer<IGattWriteResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic3*, GattClientCharacteristicConfigurationDescriptorValue, IAsyncOperation<Pointer<IGattWriteResult>>**, int>)(lpVtbl[12]))((IGattCharacteristic3*)Unsafe.AsPointer(ref this), clientCharacteristicConfigurationDescriptorValue, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDescriptorsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptorsResult_t **")] IAsyncOperation<Pointer<IGattDescriptorsResult>>** operation);

        [VtblIndex(7)]
        HRESULT GetDescriptorsWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptorsResult_t **")] IAsyncOperation<Pointer<IGattDescriptorsResult>>** operation);

        [VtblIndex(8)]
        HRESULT GetDescriptorsForUuidAsync(Guid descriptorUuid, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptorsResult_t **")] IAsyncOperation<Pointer<IGattDescriptorsResult>>** operation);

        [VtblIndex(9)]
        HRESULT GetDescriptorsForUuidWithCacheModeAsync(Guid descriptorUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptorsResult_t **")] IAsyncOperation<Pointer<IGattDescriptorsResult>>** operation);

        [VtblIndex(10)]
        HRESULT WriteValueWithResultAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteResult_t **")] IAsyncOperation<Pointer<IGattWriteResult>>** operation);

        [VtblIndex(11)]
        HRESULT WriteValueWithResultAndOptionAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattWriteOption")] GattWriteOption writeOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteResult_t **")] IAsyncOperation<Pointer<IGattWriteResult>>** operation);

        [VtblIndex(12)]
        HRESULT WriteClientCharacteristicConfigurationDescriptorWithResultAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattClientCharacteristicConfigurationDescriptorValue")] GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteResult_t **")] IAsyncOperation<Pointer<IGattWriteResult>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptorsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IGattDescriptorsResult>>**, int> GetDescriptorsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptorsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothCacheMode, IAsyncOperation<Pointer<IGattDescriptorsResult>>**, int> GetDescriptorsWithCacheModeAsync;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptorsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IAsyncOperation<Pointer<IGattDescriptorsResult>>**, int> GetDescriptorsForUuidAsync;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptorsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, BluetoothCacheMode, IAsyncOperation<Pointer<IGattDescriptorsResult>>**, int> GetDescriptorsForUuidWithCacheModeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IAsyncOperation<Pointer<IGattWriteResult>>**, int> WriteValueWithResultAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattWriteOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, GattWriteOption, IAsyncOperation<Pointer<IGattWriteResult>>**, int> WriteValueWithResultAndOptionAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattClientCharacteristicConfigurationDescriptorValue, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattClientCharacteristicConfigurationDescriptorValue, IAsyncOperation<Pointer<IGattWriteResult>>**, int> WriteClientCharacteristicConfigurationDescriptorWithResultAsync;
    }
}
