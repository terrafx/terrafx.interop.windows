// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattCharacteristicNotificationTriggerDetails2.xml' path='doc/member[@name="IGattCharacteristicNotificationTriggerDetails2"]/*' />
[Guid("727A50DC-949D-454A-B192-983467E3D50F")]
[NativeTypeName("struct IGattCharacteristicNotificationTriggerDetails2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattCharacteristicNotificationTriggerDetails2 : IGattCharacteristicNotificationTriggerDetails2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattCharacteristicNotificationTriggerDetails2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerDetails2*, Guid*, void**, int>)(lpVtbl[0]))((IGattCharacteristicNotificationTriggerDetails2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerDetails2*, uint>)(lpVtbl[1]))((IGattCharacteristicNotificationTriggerDetails2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerDetails2*, uint>)(lpVtbl[2]))((IGattCharacteristicNotificationTriggerDetails2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerDetails2*, uint*, Guid**, int>)(lpVtbl[3]))((IGattCharacteristicNotificationTriggerDetails2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerDetails2*, HSTRING*, int>)(lpVtbl[4]))((IGattCharacteristicNotificationTriggerDetails2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerDetails2*, TrustLevel*, int>)(lpVtbl[5]))((IGattCharacteristicNotificationTriggerDetails2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattCharacteristicNotificationTriggerDetails2.xml' path='doc/member[@name="IGattCharacteristicNotificationTriggerDetails2.get_Error"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Error([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothError *")] BluetoothError* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerDetails2*, BluetoothError*, int>)(lpVtbl[6]))((IGattCharacteristicNotificationTriggerDetails2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicNotificationTriggerDetails2.xml' path='doc/member[@name="IGattCharacteristicNotificationTriggerDetails2.get_EventTriggeringMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_EventTriggeringMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::Background::BluetoothEventTriggeringMode *")] BluetoothEventTriggeringMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerDetails2*, BluetoothEventTriggeringMode*, int>)(lpVtbl[7]))((IGattCharacteristicNotificationTriggerDetails2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicNotificationTriggerDetails2.xml' path='doc/member[@name="IGattCharacteristicNotificationTriggerDetails2.get_ValueChangedEvents"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ValueChangedEvents([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattValueChangedEventArgs_t **")] IVectorView<Pointer<IGattValueChangedEventArgs>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerDetails2*, IVectorView<Pointer<IGattValueChangedEventArgs>>**, int>)(lpVtbl[8]))((IGattCharacteristicNotificationTriggerDetails2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Error([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothError *")] BluetoothError* value);

        [VtblIndex(7)]
        HRESULT get_EventTriggeringMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::Background::BluetoothEventTriggeringMode *")] BluetoothEventTriggeringMode* value);

        [VtblIndex(8)]
        HRESULT get_ValueChangedEvents([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattValueChangedEventArgs_t **")] IVectorView<Pointer<IGattValueChangedEventArgs>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothError *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothError*, int> get_Error;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Background::BluetoothEventTriggeringMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothEventTriggeringMode*, int> get_EventTriggeringMode;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattValueChangedEventArgs_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IGattValueChangedEventArgs>>**, int> get_ValueChangedEvents;
    }
}
