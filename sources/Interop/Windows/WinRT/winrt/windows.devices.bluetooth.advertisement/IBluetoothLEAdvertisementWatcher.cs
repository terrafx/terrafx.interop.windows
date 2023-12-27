// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher"]/*' />
[Guid("A6AC336F-F3D3-4297-8D6C-C81EA6623F40")]
[NativeTypeName("struct IBluetoothLEAdvertisementWatcher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementWatcher : IBluetoothLEAdvertisementWatcher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAdvertisementWatcher));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, uint>)(lpVtbl[1]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, uint>)(lpVtbl[2]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.get_MinSamplingInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MinSamplingInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, TimeSpan*, int>)(lpVtbl[6]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.get_MaxSamplingInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MaxSamplingInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, TimeSpan*, int>)(lpVtbl[7]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.get_MinOutOfRangeTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinOutOfRangeTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, TimeSpan*, int>)(lpVtbl[8]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.get_MaxOutOfRangeTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MaxOutOfRangeTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, TimeSpan*, int>)(lpVtbl[9]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementWatcherStatus *")] BluetoothLEAdvertisementWatcherStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, BluetoothLEAdvertisementWatcherStatus*, int>)(lpVtbl[10]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.get_ScanningMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ScanningMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEScanningMode *")] BluetoothLEScanningMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, BluetoothLEScanningMode*, int>)(lpVtbl[11]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.put_ScanningMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_ScanningMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEScanningMode")] BluetoothLEScanningMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, BluetoothLEScanningMode, int>)(lpVtbl[12]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.get_SignalStrengthFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_SignalStrengthFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter **")] IBluetoothSignalStrengthFilter** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, IBluetoothSignalStrengthFilter**, int>)(lpVtbl[13]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.put_SignalStrengthFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_SignalStrengthFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter *")] IBluetoothSignalStrengthFilter* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, IBluetoothSignalStrengthFilter*, int>)(lpVtbl[14]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.get_AdvertisementFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_AdvertisementFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter **")] IBluetoothLEAdvertisementFilter** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, IBluetoothLEAdvertisementFilter**, int>)(lpVtbl[15]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.put_AdvertisementFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_AdvertisementFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *")] IBluetoothLEAdvertisementFilter* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, IBluetoothLEAdvertisementFilter*, int>)(lpVtbl[16]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, int>)(lpVtbl[17]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, int>)(lpVtbl[18]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.add_Received"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT add_Received([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IBluetoothLEAdvertisementWatcher>, Pointer<IBluetoothLEAdvertisementReceivedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, ITypedEventHandler<Pointer<IBluetoothLEAdvertisementWatcher>, Pointer<IBluetoothLEAdvertisementReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[19]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.remove_Received"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT remove_Received(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, EventRegistrationToken, int>)(lpVtbl[20]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.add_Stopped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT add_Stopped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcherStoppedEventArgs_t *")] ITypedEventHandler<Pointer<IBluetoothLEAdvertisementWatcher>, Pointer<IBluetoothLEAdvertisementWatcherStoppedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, ITypedEventHandler<Pointer<IBluetoothLEAdvertisementWatcher>, Pointer<IBluetoothLEAdvertisementWatcherStoppedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[21]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBluetoothLEAdvertisementWatcher.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcher.remove_Stopped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT remove_Stopped(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcher*, EventRegistrationToken, int>)(lpVtbl[22]))((IBluetoothLEAdvertisementWatcher*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MinSamplingInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(7)]
        HRESULT get_MaxSamplingInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(8)]
        HRESULT get_MinOutOfRangeTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(9)]
        HRESULT get_MaxOutOfRangeTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(10)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementWatcherStatus *")] BluetoothLEAdvertisementWatcherStatus* value);

        [VtblIndex(11)]
        HRESULT get_ScanningMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEScanningMode *")] BluetoothLEScanningMode* value);

        [VtblIndex(12)]
        HRESULT put_ScanningMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEScanningMode")] BluetoothLEScanningMode value);

        [VtblIndex(13)]
        HRESULT get_SignalStrengthFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter **")] IBluetoothSignalStrengthFilter** value);

        [VtblIndex(14)]
        HRESULT put_SignalStrengthFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter *")] IBluetoothSignalStrengthFilter* value);

        [VtblIndex(15)]
        HRESULT get_AdvertisementFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter **")] IBluetoothLEAdvertisementFilter** value);

        [VtblIndex(16)]
        HRESULT put_AdvertisementFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *")] IBluetoothLEAdvertisementFilter* value);

        [VtblIndex(17)]
        HRESULT Start();

        [VtblIndex(18)]
        HRESULT Stop();

        [VtblIndex(19)]
        HRESULT add_Received([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IBluetoothLEAdvertisementWatcher>, Pointer<IBluetoothLEAdvertisementReceivedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(20)]
        HRESULT remove_Received(EventRegistrationToken token);

        [VtblIndex(21)]
        HRESULT add_Stopped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcherStoppedEventArgs_t *")] ITypedEventHandler<Pointer<IBluetoothLEAdvertisementWatcher>, Pointer<IBluetoothLEAdvertisementWatcherStoppedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(22)]
        HRESULT remove_Stopped(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_MinSamplingInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_MaxSamplingInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_MinOutOfRangeTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_MaxOutOfRangeTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementWatcherStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothLEAdvertisementWatcherStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEScanningMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothLEScanningMode*, int> get_ScanningMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEScanningMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothLEScanningMode, int> put_ScanningMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothSignalStrengthFilter**, int> get_SignalStrengthFilter;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothSignalStrengthFilter*, int> put_SignalStrengthFilter;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEAdvertisementFilter**, int> get_AdvertisementFilter;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEAdvertisementFilter*, int> put_AdvertisementFilter;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IBluetoothLEAdvertisementWatcher>, Pointer<IBluetoothLEAdvertisementReceivedEventArgs>>*, EventRegistrationToken*, int> add_Received;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Received;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcherStoppedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IBluetoothLEAdvertisementWatcher>, Pointer<IBluetoothLEAdvertisementWatcherStoppedEventArgs>>*, EventRegistrationToken*, int> add_Stopped;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Stopped;
    }
}
