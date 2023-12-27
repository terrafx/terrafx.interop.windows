// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAdvertisementWatcherTriggerDetails.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTriggerDetails"]/*' />
[Guid("A7DB5AD7-2257-4E69-9784-FEE645C1DCE0")]
[NativeTypeName("struct IBluetoothLEAdvertisementWatcherTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementWatcherTriggerDetails : IBluetoothLEAdvertisementWatcherTriggerDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAdvertisementWatcherTriggerDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAdvertisementWatcherTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTriggerDetails*, uint>)(lpVtbl[1]))((IBluetoothLEAdvertisementWatcherTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTriggerDetails*, uint>)(lpVtbl[2]))((IBluetoothLEAdvertisementWatcherTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAdvertisementWatcherTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTriggerDetails*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAdvertisementWatcherTriggerDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAdvertisementWatcherTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTriggerDetails.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTriggerDetails.get_Error"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Error([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothError *")] BluetoothError* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTriggerDetails*, BluetoothError*, int>)(lpVtbl[6]))((IBluetoothLEAdvertisementWatcherTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTriggerDetails.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTriggerDetails.get_Advertisements"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Advertisements([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementReceivedEventArgs_t **")] IVectorView<Pointer<IBluetoothLEAdvertisementReceivedEventArgs>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTriggerDetails*, IVectorView<Pointer<IBluetoothLEAdvertisementReceivedEventArgs>>**, int>)(lpVtbl[7]))((IBluetoothLEAdvertisementWatcherTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTriggerDetails.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTriggerDetails.get_SignalStrengthFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SignalStrengthFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter **")] IBluetoothSignalStrengthFilter** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTriggerDetails*, IBluetoothSignalStrengthFilter**, int>)(lpVtbl[8]))((IBluetoothLEAdvertisementWatcherTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Error([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothError *")] BluetoothError* value);

        [VtblIndex(7)]
        HRESULT get_Advertisements([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementReceivedEventArgs_t **")] IVectorView<Pointer<IBluetoothLEAdvertisementReceivedEventArgs>>** value);

        [VtblIndex(8)]
        HRESULT get_SignalStrengthFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter **")] IBluetoothSignalStrengthFilter** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementReceivedEventArgs_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IBluetoothLEAdvertisementReceivedEventArgs>>**, int> get_Advertisements;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothSignalStrengthFilter**, int> get_SignalStrengthFilter;
    }
}
