// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEDevice3.xml' path='doc/member[@name="IBluetoothLEDevice3"]/*' />
[Guid("AEE9E493-44AC-40DC-AF33-B2C13C01CA46")]
[NativeTypeName("struct IBluetoothLEDevice3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEDevice3 : IBluetoothLEDevice3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBluetoothLEDevice3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice3*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEDevice3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice3*, uint>)(lpVtbl[1]))((IBluetoothLEDevice3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice3*, uint>)(lpVtbl[2]))((IBluetoothLEDevice3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice3*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEDevice3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice3*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEDevice3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice3*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEDevice3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEDevice3.xml' path='doc/member[@name="IBluetoothLEDevice3.get_DeviceAccessInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceAccessInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **")] IDeviceAccessInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice3*, IDeviceAccessInformation**, int>)(lpVtbl[6]))((IBluetoothLEDevice3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEDevice3.xml' path='doc/member[@name="IBluetoothLEDevice3.RequestAccessAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **")] IAsyncOperation<DeviceAccessStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice3*, IAsyncOperation<DeviceAccessStatus>**, int>)(lpVtbl[7]))((IBluetoothLEDevice3*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IBluetoothLEDevice3.xml' path='doc/member[@name="IBluetoothLEDevice3.GetGattServicesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetGattServicesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice3*, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int>)(lpVtbl[8]))((IBluetoothLEDevice3*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IBluetoothLEDevice3.xml' path='doc/member[@name="IBluetoothLEDevice3.GetGattServicesWithCacheModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetGattServicesWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice3*, BluetoothCacheMode, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int>)(lpVtbl[9]))((IBluetoothLEDevice3*)Unsafe.AsPointer(ref this), cacheMode, operation);
    }

    /// <include file='IBluetoothLEDevice3.xml' path='doc/member[@name="IBluetoothLEDevice3.GetGattServicesForUuidAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetGattServicesForUuidAsync(Guid serviceUuid, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice3*, Guid, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int>)(lpVtbl[10]))((IBluetoothLEDevice3*)Unsafe.AsPointer(ref this), serviceUuid, operation);
    }

    /// <include file='IBluetoothLEDevice3.xml' path='doc/member[@name="IBluetoothLEDevice3.GetGattServicesForUuidWithCacheModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGattServicesForUuidWithCacheModeAsync(Guid serviceUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice3*, Guid, BluetoothCacheMode, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int>)(lpVtbl[11]))((IBluetoothLEDevice3*)Unsafe.AsPointer(ref this), serviceUuid, cacheMode, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceAccessInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **")] IDeviceAccessInformation** value);

        [VtblIndex(7)]
        HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **")] IAsyncOperation<DeviceAccessStatus>** operation);

        [VtblIndex(8)]
        HRESULT GetGattServicesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation);

        [VtblIndex(9)]
        HRESULT GetGattServicesWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation);

        [VtblIndex(10)]
        HRESULT GetGattServicesForUuidAsync(Guid serviceUuid, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation);

        [VtblIndex(11)]
        HRESULT GetGattServicesForUuidWithCacheModeAsync(Guid serviceUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceAccessInformation**, int> get_DeviceAccessInformation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<DeviceAccessStatus>**, int> RequestAccessAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int> GetGattServicesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothCacheMode, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int> GetGattServicesWithCacheModeAsync;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int> GetGattServicesForUuidAsync;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, BluetoothCacheMode, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int> GetGattServicesForUuidWithCacheModeAsync;
    }
}
