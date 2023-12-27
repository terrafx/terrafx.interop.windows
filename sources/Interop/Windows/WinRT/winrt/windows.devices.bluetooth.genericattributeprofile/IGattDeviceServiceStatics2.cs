// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattDeviceServiceStatics2.xml' path='doc/member[@name="IGattDeviceServiceStatics2"]/*' />
[Guid("0604186E-24A6-4B0D-A2F2-30CC01545D25")]
[NativeTypeName("struct IGattDeviceServiceStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattDeviceServiceStatics2 : IGattDeviceServiceStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattDeviceServiceStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IGattDeviceServiceStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics2*, uint>)(lpVtbl[1]))((IGattDeviceServiceStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics2*, uint>)(lpVtbl[2]))((IGattDeviceServiceStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IGattDeviceServiceStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics2*, HSTRING*, int>)(lpVtbl[4]))((IGattDeviceServiceStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IGattDeviceServiceStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattDeviceServiceStatics2.xml' path='doc/member[@name="IGattDeviceServiceStatics2.FromIdWithSharingModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromIdWithSharingModeAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode")] GattSharingMode sharingMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **")] IAsyncOperation<Pointer<IGattDeviceService>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics2*, HSTRING, GattSharingMode, IAsyncOperation<Pointer<IGattDeviceService>>**, int>)(lpVtbl[6]))((IGattDeviceServiceStatics2*)Unsafe.AsPointer(ref this), deviceId, sharingMode, operation);
    }

    /// <include file='IGattDeviceServiceStatics2.xml' path='doc/member[@name="IGattDeviceServiceStatics2.GetDeviceSelectorForBluetoothDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelectorForBluetoothDeviceId([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")] IBluetoothDeviceId* bluetoothDeviceId, HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics2*, IBluetoothDeviceId*, HSTRING*, int>)(lpVtbl[7]))((IGattDeviceServiceStatics2*)Unsafe.AsPointer(ref this), bluetoothDeviceId, result);
    }

    /// <include file='IGattDeviceServiceStatics2.xml' path='doc/member[@name="IGattDeviceServiceStatics2.GetDeviceSelectorForBluetoothDeviceIdWithCacheMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeviceSelectorForBluetoothDeviceIdWithCacheMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")] IBluetoothDeviceId* bluetoothDeviceId, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics2*, IBluetoothDeviceId*, BluetoothCacheMode, HSTRING*, int>)(lpVtbl[8]))((IGattDeviceServiceStatics2*)Unsafe.AsPointer(ref this), bluetoothDeviceId, cacheMode, result);
    }

    /// <include file='IGattDeviceServiceStatics2.xml' path='doc/member[@name="IGattDeviceServiceStatics2.GetDeviceSelectorForBluetoothDeviceIdAndUuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeviceSelectorForBluetoothDeviceIdAndUuid([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")] IBluetoothDeviceId* bluetoothDeviceId, Guid serviceUuid, HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics2*, IBluetoothDeviceId*, Guid, HSTRING*, int>)(lpVtbl[9]))((IGattDeviceServiceStatics2*)Unsafe.AsPointer(ref this), bluetoothDeviceId, serviceUuid, result);
    }

    /// <include file='IGattDeviceServiceStatics2.xml' path='doc/member[@name="IGattDeviceServiceStatics2.GetDeviceSelectorForBluetoothDeviceIdAndUuidWithCacheMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeviceSelectorForBluetoothDeviceIdAndUuidWithCacheMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")] IBluetoothDeviceId* bluetoothDeviceId, Guid serviceUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics2*, IBluetoothDeviceId*, Guid, BluetoothCacheMode, HSTRING*, int>)(lpVtbl[10]))((IGattDeviceServiceStatics2*)Unsafe.AsPointer(ref this), bluetoothDeviceId, serviceUuid, cacheMode, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromIdWithSharingModeAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode")] GattSharingMode sharingMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **")] IAsyncOperation<Pointer<IGattDeviceService>>** operation);

        [VtblIndex(7)]
        HRESULT GetDeviceSelectorForBluetoothDeviceId([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")] IBluetoothDeviceId* bluetoothDeviceId, HSTRING* result);

        [VtblIndex(8)]
        HRESULT GetDeviceSelectorForBluetoothDeviceIdWithCacheMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")] IBluetoothDeviceId* bluetoothDeviceId, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, HSTRING* result);

        [VtblIndex(9)]
        HRESULT GetDeviceSelectorForBluetoothDeviceIdAndUuid([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")] IBluetoothDeviceId* bluetoothDeviceId, Guid serviceUuid, HSTRING* result);

        [VtblIndex(10)]
        HRESULT GetDeviceSelectorForBluetoothDeviceIdAndUuidWithCacheMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")] IBluetoothDeviceId* bluetoothDeviceId, Guid serviceUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, HSTRING* result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, GattSharingMode, IAsyncOperation<Pointer<IGattDeviceService>>**, int> FromIdWithSharingModeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothDeviceId*, HSTRING*, int> GetDeviceSelectorForBluetoothDeviceId;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *, ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothDeviceId*, BluetoothCacheMode, HSTRING*, int> GetDeviceSelectorForBluetoothDeviceIdWithCacheMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *, GUID, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothDeviceId*, Guid, HSTRING*, int> GetDeviceSelectorForBluetoothDeviceIdAndUuid;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *, GUID, ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothDeviceId*, Guid, BluetoothCacheMode, HSTRING*, int> GetDeviceSelectorForBluetoothDeviceIdAndUuidWithCacheMode;
    }
}
