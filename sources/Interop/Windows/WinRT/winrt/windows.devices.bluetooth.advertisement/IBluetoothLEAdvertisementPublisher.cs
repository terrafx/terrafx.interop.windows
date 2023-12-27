// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAdvertisementPublisher.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher"]/*' />
[Guid("CDE820F9-D9FA-43D6-A264-DDD8B7DA8B78")]
[NativeTypeName("struct IBluetoothLEAdvertisementPublisher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementPublisher : IBluetoothLEAdvertisementPublisher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAdvertisementPublisher));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAdvertisementPublisher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher*, uint>)(lpVtbl[1]))((IBluetoothLEAdvertisementPublisher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher*, uint>)(lpVtbl[2]))((IBluetoothLEAdvertisementPublisher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAdvertisementPublisher*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAdvertisementPublisher*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAdvertisementPublisher*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPublisherStatus *")] BluetoothLEAdvertisementPublisherStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher*, BluetoothLEAdvertisementPublisherStatus*, int>)(lpVtbl[6]))((IBluetoothLEAdvertisementPublisher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher.get_Advertisement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Advertisement([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisement **")] IBluetoothLEAdvertisement** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher*, IBluetoothLEAdvertisement**, int>)(lpVtbl[7]))((IBluetoothLEAdvertisementPublisher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher*, int>)(lpVtbl[8]))((IBluetoothLEAdvertisementPublisher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBluetoothLEAdvertisementPublisher.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher*, int>)(lpVtbl[9]))((IBluetoothLEAdvertisementPublisher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBluetoothLEAdvertisementPublisher.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher.add_StatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_StatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementPublisher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementPublisherStatusChangedEventArgs_t *")] ITypedEventHandler<Pointer<IBluetoothLEAdvertisementPublisher>, Pointer<IBluetoothLEAdvertisementPublisherStatusChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher*, ITypedEventHandler<Pointer<IBluetoothLEAdvertisementPublisher>, Pointer<IBluetoothLEAdvertisementPublisherStatusChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IBluetoothLEAdvertisementPublisher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher.remove_StatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_StatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher*, EventRegistrationToken, int>)(lpVtbl[11]))((IBluetoothLEAdvertisementPublisher*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPublisherStatus *")] BluetoothLEAdvertisementPublisherStatus* value);

        [VtblIndex(7)]
        HRESULT get_Advertisement([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisement **")] IBluetoothLEAdvertisement** value);

        [VtblIndex(8)]
        HRESULT Start();

        [VtblIndex(9)]
        HRESULT Stop();

        [VtblIndex(10)]
        HRESULT add_StatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementPublisher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementPublisherStatusChangedEventArgs_t *")] ITypedEventHandler<Pointer<IBluetoothLEAdvertisementPublisher>, Pointer<IBluetoothLEAdvertisementPublisherStatusChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_StatusChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPublisherStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothLEAdvertisementPublisherStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEAdvertisement**, int> get_Advertisement;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementPublisher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementPublisherStatusChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IBluetoothLEAdvertisementPublisher>, Pointer<IBluetoothLEAdvertisementPublisherStatusChangedEventArgs>>*, EventRegistrationToken*, int> add_StatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StatusChanged;
    }
}
