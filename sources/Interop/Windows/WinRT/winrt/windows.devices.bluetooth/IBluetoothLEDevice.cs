// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEDevice.xml' path='doc/member[@name="IBluetoothLEDevice"]/*' />
[Guid("B5EE2F7B-4AD8-4642-AC48-80A0B500E887")]
[NativeTypeName("struct IBluetoothLEDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEDevice : IBluetoothLEDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEDevice));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, uint>)(lpVtbl[1]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, uint>)(lpVtbl[2]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEDevice.xml' path='doc/member[@name="IBluetoothLEDevice.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, HSTRING*, int>)(lpVtbl[6]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEDevice.xml' path='doc/member[@name="IBluetoothLEDevice.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, HSTRING*, int>)(lpVtbl[7]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEDevice.xml' path='doc/member[@name="IBluetoothLEDevice.get_GattServices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Use GetGattServicesAsync instead of GattServices.  For more information, see MSDN.")]
    public HRESULT get_GattServices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, IVectorView<IntPtr>**, int>)(lpVtbl[8]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEDevice.xml' path='doc/member[@name="IBluetoothLEDevice.get_ConnectionStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ConnectionStatus([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothConnectionStatus *")] BluetoothConnectionStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, BluetoothConnectionStatus*, int>)(lpVtbl[9]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEDevice.xml' path='doc/member[@name="IBluetoothLEDevice.get_BluetoothAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BluetoothAddress([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, ulong*, int>)(lpVtbl[10]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEDevice.xml' path='doc/member[@name="IBluetoothLEDevice.GetGattService"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("Use GetGattServicesForUuidAsync instead of GetGattService.  For more information, see MSDN.")]
    public HRESULT GetGattService(Guid serviceUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattDeviceService **")] IGattDeviceService** service)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, Guid, IGattDeviceService**, int>)(lpVtbl[11]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), serviceUuid, service);
    }

    /// <include file='IBluetoothLEDevice.xml' path='doc/member[@name="IBluetoothLEDevice.add_NameChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_NameChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBluetoothLEDevice.xml' path='doc/member[@name="IBluetoothLEDevice.remove_NameChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_NameChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, EventRegistrationToken, int>)(lpVtbl[13]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IBluetoothLEDevice.xml' path='doc/member[@name="IBluetoothLEDevice.add_GattServicesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_GattServicesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBluetoothLEDevice.xml' path='doc/member[@name="IBluetoothLEDevice.remove_GattServicesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_GattServicesChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, EventRegistrationToken, int>)(lpVtbl[15]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IBluetoothLEDevice.xml' path='doc/member[@name="IBluetoothLEDevice.add_ConnectionStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_ConnectionStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[16]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBluetoothLEDevice.xml' path='doc/member[@name="IBluetoothLEDevice.remove_ConnectionStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_ConnectionStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice*, EventRegistrationToken, int>)(lpVtbl[17]))((IBluetoothLEDevice*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(8)]
        [Obsolete("Use GetGattServicesAsync instead of GattServices.  For more information, see MSDN.")]
        HRESULT get_GattServices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(9)]
        HRESULT get_ConnectionStatus([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothConnectionStatus *")] BluetoothConnectionStatus* value);

        [VtblIndex(10)]
        HRESULT get_BluetoothAddress([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(11)]
        [Obsolete("Use GetGattServicesForUuidAsync instead of GetGattService.  For more information, see MSDN.")]
        HRESULT GetGattService(Guid serviceUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattDeviceService **")] IGattDeviceService** service);

        [VtblIndex(12)]
        HRESULT add_NameChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_NameChanged(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT add_GattServicesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_GattServicesChanged(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT add_ConnectionStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(17)]
        HRESULT remove_ConnectionStatusChanged(EventRegistrationToken token);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **) __attribute__((stdcall))")]
        [Obsolete("Use GetGattServicesAsync instead of GattServices.  For more information, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> get_GattServices;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothConnectionStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothConnectionStatus*, int> get_ConnectionStatus;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_BluetoothAddress;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattDeviceService **) __attribute__((stdcall))")]
        [Obsolete("Use GetGattServicesForUuidAsync instead of GetGattService.  For more information, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IGattDeviceService**, int> GetGattService;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_NameChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_NameChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_GattServicesChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_GattServicesChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ConnectionStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ConnectionStatusChanged;
    }
}
