// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.rfcomm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRfcommDeviceServiceStatics2.xml' path='doc/member[@name="IRfcommDeviceServiceStatics2"]/*' />
[Guid("AA8CB1C9-E78D-4BE4-8076-0A3D87A0A05F")]
[NativeTypeName("struct IRfcommDeviceServiceStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommDeviceServiceStatics2 : IRfcommDeviceServiceStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRfcommDeviceServiceStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IRfcommDeviceServiceStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics2*, uint>)(lpVtbl[1]))((IRfcommDeviceServiceStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics2*, uint>)(lpVtbl[2]))((IRfcommDeviceServiceStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IRfcommDeviceServiceStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics2*, HSTRING*, int>)(lpVtbl[4]))((IRfcommDeviceServiceStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IRfcommDeviceServiceStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRfcommDeviceServiceStatics2.xml' path='doc/member[@name="IRfcommDeviceServiceStatics2.GetDeviceSelectorForBluetoothDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceSelectorForBluetoothDevice([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")] IBluetoothDevice* bluetoothDevice, HSTRING* selector)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics2*, IBluetoothDevice*, HSTRING*, int>)(lpVtbl[6]))((IRfcommDeviceServiceStatics2*)Unsafe.AsPointer(ref this), bluetoothDevice, selector);
    }

    /// <include file='IRfcommDeviceServiceStatics2.xml' path='doc/member[@name="IRfcommDeviceServiceStatics2.GetDeviceSelectorForBluetoothDeviceWithCacheMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelectorForBluetoothDeviceWithCacheMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")] IBluetoothDevice* bluetoothDevice, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, HSTRING* selector)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics2*, IBluetoothDevice*, BluetoothCacheMode, HSTRING*, int>)(lpVtbl[7]))((IRfcommDeviceServiceStatics2*)Unsafe.AsPointer(ref this), bluetoothDevice, cacheMode, selector);
    }

    /// <include file='IRfcommDeviceServiceStatics2.xml' path='doc/member[@name="IRfcommDeviceServiceStatics2.GetDeviceSelectorForBluetoothDeviceAndServiceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeviceSelectorForBluetoothDeviceAndServiceId([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")] IBluetoothDevice* bluetoothDevice, [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")] IRfcommServiceId* serviceId, HSTRING* selector)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics2*, IBluetoothDevice*, IRfcommServiceId*, HSTRING*, int>)(lpVtbl[8]))((IRfcommDeviceServiceStatics2*)Unsafe.AsPointer(ref this), bluetoothDevice, serviceId, selector);
    }

    /// <include file='IRfcommDeviceServiceStatics2.xml' path='doc/member[@name="IRfcommDeviceServiceStatics2.GetDeviceSelectorForBluetoothDeviceAndServiceIdWithCacheMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeviceSelectorForBluetoothDeviceAndServiceIdWithCacheMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")] IBluetoothDevice* bluetoothDevice, [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")] IRfcommServiceId* serviceId, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, HSTRING* selector)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics2*, IBluetoothDevice*, IRfcommServiceId*, BluetoothCacheMode, HSTRING*, int>)(lpVtbl[9]))((IRfcommDeviceServiceStatics2*)Unsafe.AsPointer(ref this), bluetoothDevice, serviceId, cacheMode, selector);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceSelectorForBluetoothDevice([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")] IBluetoothDevice* bluetoothDevice, HSTRING* selector);

        [VtblIndex(7)]
        HRESULT GetDeviceSelectorForBluetoothDeviceWithCacheMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")] IBluetoothDevice* bluetoothDevice, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, HSTRING* selector);

        [VtblIndex(8)]
        HRESULT GetDeviceSelectorForBluetoothDeviceAndServiceId([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")] IBluetoothDevice* bluetoothDevice, [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")] IRfcommServiceId* serviceId, HSTRING* selector);

        [VtblIndex(9)]
        HRESULT GetDeviceSelectorForBluetoothDeviceAndServiceIdWithCacheMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")] IBluetoothDevice* bluetoothDevice, [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")] IRfcommServiceId* serviceId, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, HSTRING* selector);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDevice *, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothDevice*, HSTRING*, int> GetDeviceSelectorForBluetoothDevice;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDevice *, ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothDevice*, BluetoothCacheMode, HSTRING*, int> GetDeviceSelectorForBluetoothDeviceWithCacheMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDevice *, ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothDevice*, IRfcommServiceId*, HSTRING*, int> GetDeviceSelectorForBluetoothDeviceAndServiceId;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDevice *, ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *, ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothDevice*, IRfcommServiceId*, BluetoothCacheMode, HSTRING*, int> GetDeviceSelectorForBluetoothDeviceAndServiceIdWithCacheMode;
    }
}
