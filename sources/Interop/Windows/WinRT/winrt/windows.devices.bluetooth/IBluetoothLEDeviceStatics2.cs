// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEDeviceStatics2.xml' path='doc/member[@name="IBluetoothLEDeviceStatics2"]/*' />
[Guid("5F12C06B-3BAC-43E8-AD16-563271BD41C2")]
[NativeTypeName("struct IBluetoothLEDeviceStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEDeviceStatics2 : IBluetoothLEDeviceStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBluetoothLEDeviceStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEDeviceStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics2*, uint>)(lpVtbl[1]))((IBluetoothLEDeviceStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics2*, uint>)(lpVtbl[2]))((IBluetoothLEDeviceStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEDeviceStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics2*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEDeviceStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEDeviceStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEDeviceStatics2.xml' path='doc/member[@name="IBluetoothLEDeviceStatics2.GetDeviceSelectorFromPairingState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceSelectorFromPairingState([NativeTypeName("boolean")] byte pairingState, HSTRING* deviceSelector)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics2*, byte, HSTRING*, int>)(lpVtbl[6]))((IBluetoothLEDeviceStatics2*)Unsafe.AsPointer(ref this), pairingState, deviceSelector);
    }

    /// <include file='IBluetoothLEDeviceStatics2.xml' path='doc/member[@name="IBluetoothLEDeviceStatics2.GetDeviceSelectorFromConnectionStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelectorFromConnectionStatus([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothConnectionStatus")] BluetoothConnectionStatus connectionStatus, HSTRING* deviceSelector)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics2*, BluetoothConnectionStatus, HSTRING*, int>)(lpVtbl[7]))((IBluetoothLEDeviceStatics2*)Unsafe.AsPointer(ref this), connectionStatus, deviceSelector);
    }

    /// <include file='IBluetoothLEDeviceStatics2.xml' path='doc/member[@name="IBluetoothLEDeviceStatics2.GetDeviceSelectorFromDeviceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeviceSelectorFromDeviceName(HSTRING deviceName, HSTRING* deviceSelector)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics2*, HSTRING, HSTRING*, int>)(lpVtbl[8]))((IBluetoothLEDeviceStatics2*)Unsafe.AsPointer(ref this), deviceName, deviceSelector);
    }

    /// <include file='IBluetoothLEDeviceStatics2.xml' path='doc/member[@name="IBluetoothLEDeviceStatics2.GetDeviceSelectorFromBluetoothAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeviceSelectorFromBluetoothAddress([NativeTypeName("UINT64")] ulong bluetoothAddress, HSTRING* deviceSelector)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics2*, ulong, HSTRING*, int>)(lpVtbl[9]))((IBluetoothLEDeviceStatics2*)Unsafe.AsPointer(ref this), bluetoothAddress, deviceSelector);
    }

    /// <include file='IBluetoothLEDeviceStatics2.xml' path='doc/member[@name="IBluetoothLEDeviceStatics2.GetDeviceSelectorFromBluetoothAddressWithBluetoothAddressType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeviceSelectorFromBluetoothAddressWithBluetoothAddressType([NativeTypeName("UINT64")] ulong bluetoothAddress, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothAddressType")] BluetoothAddressType bluetoothAddressType, HSTRING* deviceSelector)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics2*, ulong, BluetoothAddressType, HSTRING*, int>)(lpVtbl[10]))((IBluetoothLEDeviceStatics2*)Unsafe.AsPointer(ref this), bluetoothAddress, bluetoothAddressType, deviceSelector);
    }

    /// <include file='IBluetoothLEDeviceStatics2.xml' path='doc/member[@name="IBluetoothLEDeviceStatics2.GetDeviceSelectorFromAppearance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDeviceSelectorFromAppearance([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance *")] IBluetoothLEAppearance* appearance, HSTRING* deviceSelector)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics2*, IBluetoothLEAppearance*, HSTRING*, int>)(lpVtbl[11]))((IBluetoothLEDeviceStatics2*)Unsafe.AsPointer(ref this), appearance, deviceSelector);
    }

    /// <include file='IBluetoothLEDeviceStatics2.xml' path='doc/member[@name="IBluetoothLEDeviceStatics2.FromBluetoothAddressWithBluetoothAddressTypeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT FromBluetoothAddressWithBluetoothAddressTypeAsync([NativeTypeName("UINT64")] ulong bluetoothAddress, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothAddressType")] BluetoothAddressType bluetoothAddressType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothLEDevice_t **")] IAsyncOperation<Pointer<IBluetoothLEDevice>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics2*, ulong, BluetoothAddressType, IAsyncOperation<Pointer<IBluetoothLEDevice>>**, int>)(lpVtbl[12]))((IBluetoothLEDeviceStatics2*)Unsafe.AsPointer(ref this), bluetoothAddress, bluetoothAddressType, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceSelectorFromPairingState([NativeTypeName("boolean")] byte pairingState, HSTRING* deviceSelector);

        [VtblIndex(7)]
        HRESULT GetDeviceSelectorFromConnectionStatus([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothConnectionStatus")] BluetoothConnectionStatus connectionStatus, HSTRING* deviceSelector);

        [VtblIndex(8)]
        HRESULT GetDeviceSelectorFromDeviceName(HSTRING deviceName, HSTRING* deviceSelector);

        [VtblIndex(9)]
        HRESULT GetDeviceSelectorFromBluetoothAddress([NativeTypeName("UINT64")] ulong bluetoothAddress, HSTRING* deviceSelector);

        [VtblIndex(10)]
        HRESULT GetDeviceSelectorFromBluetoothAddressWithBluetoothAddressType([NativeTypeName("UINT64")] ulong bluetoothAddress, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothAddressType")] BluetoothAddressType bluetoothAddressType, HSTRING* deviceSelector);

        [VtblIndex(11)]
        HRESULT GetDeviceSelectorFromAppearance([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance *")] IBluetoothLEAppearance* appearance, HSTRING* deviceSelector);

        [VtblIndex(12)]
        HRESULT FromBluetoothAddressWithBluetoothAddressTypeAsync([NativeTypeName("UINT64")] ulong bluetoothAddress, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothAddressType")] BluetoothAddressType bluetoothAddressType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothLEDevice_t **")] IAsyncOperation<Pointer<IBluetoothLEDevice>>** operation);
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

        [NativeTypeName("HRESULT (boolean, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, HSTRING*, int> GetDeviceSelectorFromPairingState;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothConnectionStatus, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothConnectionStatus, HSTRING*, int> GetDeviceSelectorFromConnectionStatus;

        [NativeTypeName("HRESULT (HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING*, int> GetDeviceSelectorFromDeviceName;

        [NativeTypeName("HRESULT (UINT64, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, HSTRING*, int> GetDeviceSelectorFromBluetoothAddress;

        [NativeTypeName("HRESULT (UINT64, ABI::Windows::Devices::Bluetooth::BluetoothAddressType, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, BluetoothAddressType, HSTRING*, int> GetDeviceSelectorFromBluetoothAddressWithBluetoothAddressType;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance *, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEAppearance*, HSTRING*, int> GetDeviceSelectorFromAppearance;

        [NativeTypeName("HRESULT (UINT64, ABI::Windows::Devices::Bluetooth::BluetoothAddressType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothLEDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, BluetoothAddressType, IAsyncOperation<Pointer<IBluetoothLEDevice>>**, int> FromBluetoothAddressWithBluetoothAddressTypeAsync;
    }
}
