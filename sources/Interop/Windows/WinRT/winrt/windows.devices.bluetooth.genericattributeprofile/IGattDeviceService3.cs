// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattDeviceService3.xml' path='doc/member[@name="IGattDeviceService3"]/*' />
[Guid("B293A950-0C53-437C-A9B3-5C3210C6E569")]
[NativeTypeName("struct IGattDeviceService3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattDeviceService3 : IGattDeviceService3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattDeviceService3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, Guid*, void**, int>)(lpVtbl[0]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, uint>)(lpVtbl[1]))((IGattDeviceService3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, uint>)(lpVtbl[2]))((IGattDeviceService3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, uint*, Guid**, int>)(lpVtbl[3]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, HSTRING*, int>)(lpVtbl[4]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, TrustLevel*, int>)(lpVtbl[5]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattDeviceService3.xml' path='doc/member[@name="IGattDeviceService3.get_DeviceAccessInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceAccessInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **")] IDeviceAccessInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, IDeviceAccessInformation**, int>)(lpVtbl[6]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDeviceService3.xml' path='doc/member[@name="IGattDeviceService3.get_Session"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Session([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattSession **")] IGattSession** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, IGattSession**, int>)(lpVtbl[7]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDeviceService3.xml' path='doc/member[@name="IGattDeviceService3.get_SharingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SharingMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode *")] GattSharingMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, GattSharingMode*, int>)(lpVtbl[8]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDeviceService3.xml' path='doc/member[@name="IGattDeviceService3.RequestAccessAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **")] IAsyncOperation<DeviceAccessStatus>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, IAsyncOperation<DeviceAccessStatus>**, int>)(lpVtbl[9]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDeviceService3.xml' path='doc/member[@name="IGattDeviceService3.OpenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OpenAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode")] GattSharingMode sharingMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattOpenStatus_t **")] IAsyncOperation<GattOpenStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, GattSharingMode, IAsyncOperation<GattOpenStatus>**, int>)(lpVtbl[10]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), sharingMode, operation);
    }

    /// <include file='IGattDeviceService3.xml' path='doc/member[@name="IGattDeviceService3.GetCharacteristicsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCharacteristicsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **")] IAsyncOperation<Pointer<IGattCharacteristicsResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, IAsyncOperation<Pointer<IGattCharacteristicsResult>>**, int>)(lpVtbl[11]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IGattDeviceService3.xml' path='doc/member[@name="IGattDeviceService3.GetCharacteristicsWithCacheModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetCharacteristicsWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **")] IAsyncOperation<Pointer<IGattCharacteristicsResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, BluetoothCacheMode, IAsyncOperation<Pointer<IGattCharacteristicsResult>>**, int>)(lpVtbl[12]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), cacheMode, operation);
    }

    /// <include file='IGattDeviceService3.xml' path='doc/member[@name="IGattDeviceService3.GetCharacteristicsForUuidAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCharacteristicsForUuidAsync(Guid characteristicUuid, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **")] IAsyncOperation<Pointer<IGattCharacteristicsResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, Guid, IAsyncOperation<Pointer<IGattCharacteristicsResult>>**, int>)(lpVtbl[13]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), characteristicUuid, operation);
    }

    /// <include file='IGattDeviceService3.xml' path='doc/member[@name="IGattDeviceService3.GetCharacteristicsForUuidWithCacheModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCharacteristicsForUuidWithCacheModeAsync(Guid characteristicUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **")] IAsyncOperation<Pointer<IGattCharacteristicsResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, Guid, BluetoothCacheMode, IAsyncOperation<Pointer<IGattCharacteristicsResult>>**, int>)(lpVtbl[14]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), characteristicUuid, cacheMode, operation);
    }

    /// <include file='IGattDeviceService3.xml' path='doc/member[@name="IGattDeviceService3.GetIncludedServicesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetIncludedServicesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int>)(lpVtbl[15]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IGattDeviceService3.xml' path='doc/member[@name="IGattDeviceService3.GetIncludedServicesWithCacheModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetIncludedServicesWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, BluetoothCacheMode, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int>)(lpVtbl[16]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), cacheMode, operation);
    }

    /// <include file='IGattDeviceService3.xml' path='doc/member[@name="IGattDeviceService3.GetIncludedServicesForUuidAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetIncludedServicesForUuidAsync(Guid serviceUuid, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, Guid, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int>)(lpVtbl[17]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), serviceUuid, operation);
    }

    /// <include file='IGattDeviceService3.xml' path='doc/member[@name="IGattDeviceService3.GetIncludedServicesForUuidWithCacheModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetIncludedServicesForUuidWithCacheModeAsync(Guid serviceUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService3*, Guid, BluetoothCacheMode, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int>)(lpVtbl[18]))((IGattDeviceService3*)Unsafe.AsPointer(ref this), serviceUuid, cacheMode, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceAccessInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **")] IDeviceAccessInformation** value);

        [VtblIndex(7)]
        HRESULT get_Session([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattSession **")] IGattSession** value);

        [VtblIndex(8)]
        HRESULT get_SharingMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode *")] GattSharingMode* value);

        [VtblIndex(9)]
        HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **")] IAsyncOperation<DeviceAccessStatus>** value);

        [VtblIndex(10)]
        HRESULT OpenAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode")] GattSharingMode sharingMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattOpenStatus_t **")] IAsyncOperation<GattOpenStatus>** operation);

        [VtblIndex(11)]
        HRESULT GetCharacteristicsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **")] IAsyncOperation<Pointer<IGattCharacteristicsResult>>** operation);

        [VtblIndex(12)]
        HRESULT GetCharacteristicsWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **")] IAsyncOperation<Pointer<IGattCharacteristicsResult>>** operation);

        [VtblIndex(13)]
        HRESULT GetCharacteristicsForUuidAsync(Guid characteristicUuid, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **")] IAsyncOperation<Pointer<IGattCharacteristicsResult>>** operation);

        [VtblIndex(14)]
        HRESULT GetCharacteristicsForUuidWithCacheModeAsync(Guid characteristicUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **")] IAsyncOperation<Pointer<IGattCharacteristicsResult>>** operation);

        [VtblIndex(15)]
        HRESULT GetIncludedServicesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation);

        [VtblIndex(16)]
        HRESULT GetIncludedServicesWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation);

        [VtblIndex(17)]
        HRESULT GetIncludedServicesForUuidAsync(Guid serviceUuid, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation);

        [VtblIndex(18)]
        HRESULT GetIncludedServicesForUuidWithCacheModeAsync(Guid serviceUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **")] IAsyncOperation<Pointer<IGattDeviceServicesResult>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattSession **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGattSession**, int> get_Session;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattSharingMode*, int> get_SharingMode;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<DeviceAccessStatus>**, int> RequestAccessAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattOpenStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattSharingMode, IAsyncOperation<GattOpenStatus>**, int> OpenAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IGattCharacteristicsResult>>**, int> GetCharacteristicsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothCacheMode, IAsyncOperation<Pointer<IGattCharacteristicsResult>>**, int> GetCharacteristicsWithCacheModeAsync;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IAsyncOperation<Pointer<IGattCharacteristicsResult>>**, int> GetCharacteristicsForUuidAsync;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, BluetoothCacheMode, IAsyncOperation<Pointer<IGattCharacteristicsResult>>**, int> GetCharacteristicsForUuidWithCacheModeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int> GetIncludedServicesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothCacheMode, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int> GetIncludedServicesWithCacheModeAsync;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int> GetIncludedServicesForUuidAsync;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, BluetoothCacheMode, IAsyncOperation<Pointer<IGattDeviceServicesResult>>**, int> GetIncludedServicesForUuidWithCacheModeAsync;
    }
}
