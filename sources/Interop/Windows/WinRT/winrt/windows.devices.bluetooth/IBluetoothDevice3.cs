// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothDevice3.xml' path='doc/member[@name="IBluetoothDevice3"]/*' />
[Guid("57FFF78B-651A-4454-B90F-EB21EF0B0D71")]
[NativeTypeName("struct IBluetoothDevice3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothDevice3 : IBluetoothDevice3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothDevice3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice3*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothDevice3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice3*, uint>)(lpVtbl[1]))((IBluetoothDevice3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice3*, uint>)(lpVtbl[2]))((IBluetoothDevice3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice3*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothDevice3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice3*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothDevice3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice3*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothDevice3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothDevice3.xml' path='doc/member[@name="IBluetoothDevice3.get_DeviceAccessInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceAccessInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **")] IDeviceAccessInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice3*, IDeviceAccessInformation**, int>)(lpVtbl[6]))((IBluetoothDevice3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothDevice3.xml' path='doc/member[@name="IBluetoothDevice3.RequestAccessAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **")] IAsyncOperation<DeviceAccessStatus>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice3*, IAsyncOperation<DeviceAccessStatus>**, int>)(lpVtbl[7]))((IBluetoothDevice3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothDevice3.xml' path='doc/member[@name="IBluetoothDevice3.GetRfcommServicesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetRfcommServicesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceServicesResult_t **")] IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice3*, IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>**, int>)(lpVtbl[8]))((IBluetoothDevice3*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IBluetoothDevice3.xml' path='doc/member[@name="IBluetoothDevice3.GetRfcommServicesWithCacheModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetRfcommServicesWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceServicesResult_t **")] IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice3*, BluetoothCacheMode, IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>**, int>)(lpVtbl[9]))((IBluetoothDevice3*)Unsafe.AsPointer(ref this), cacheMode, operation);
    }

    /// <include file='IBluetoothDevice3.xml' path='doc/member[@name="IBluetoothDevice3.GetRfcommServicesForIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetRfcommServicesForIdAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")] IRfcommServiceId* serviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceServicesResult_t **")] IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice3*, IRfcommServiceId*, IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>**, int>)(lpVtbl[10]))((IBluetoothDevice3*)Unsafe.AsPointer(ref this), serviceId, operation);
    }

    /// <include file='IBluetoothDevice3.xml' path='doc/member[@name="IBluetoothDevice3.GetRfcommServicesForIdWithCacheModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetRfcommServicesForIdWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")] IRfcommServiceId* serviceId, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceServicesResult_t **")] IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice3*, IRfcommServiceId*, BluetoothCacheMode, IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>**, int>)(lpVtbl[11]))((IBluetoothDevice3*)Unsafe.AsPointer(ref this), serviceId, cacheMode, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceAccessInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **")] IDeviceAccessInformation** value);

        [VtblIndex(7)]
        HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **")] IAsyncOperation<DeviceAccessStatus>** value);

        [VtblIndex(8)]
        HRESULT GetRfcommServicesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceServicesResult_t **")] IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>** operation);

        [VtblIndex(9)]
        HRESULT GetRfcommServicesWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceServicesResult_t **")] IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>** operation);

        [VtblIndex(10)]
        HRESULT GetRfcommServicesForIdAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")] IRfcommServiceId* serviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceServicesResult_t **")] IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>** operation);

        [VtblIndex(11)]
        HRESULT GetRfcommServicesForIdWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")] IRfcommServiceId* serviceId, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceServicesResult_t **")] IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceServicesResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>**, int> GetRfcommServicesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceServicesResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothCacheMode, IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>**, int> GetRfcommServicesWithCacheModeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceServicesResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommServiceId*, IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>**, int> GetRfcommServicesForIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *, ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceServicesResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommServiceId*, BluetoothCacheMode, IAsyncOperation<Pointer<IRfcommDeviceServicesResult>>**, int> GetRfcommServicesForIdWithCacheModeAsync;
    }
}
