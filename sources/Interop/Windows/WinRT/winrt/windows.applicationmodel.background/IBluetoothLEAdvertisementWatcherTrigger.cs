// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAdvertisementWatcherTrigger.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger"]/*' />
[Guid("1AAB1819-BCE1-48EB-A827-59FB7CEE52A6")]
[NativeTypeName("struct IBluetoothLEAdvertisementWatcherTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementWatcherTrigger : IBluetoothLEAdvertisementWatcherTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBluetoothLEAdvertisementWatcherTrigger);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAdvertisementWatcherTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger*, uint>)(lpVtbl[1]))((IBluetoothLEAdvertisementWatcherTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger*, uint>)(lpVtbl[2]))((IBluetoothLEAdvertisementWatcherTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAdvertisementWatcherTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAdvertisementWatcherTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAdvertisementWatcherTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTrigger.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger.get_MinSamplingInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MinSamplingInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger*, TimeSpan*, int>)(lpVtbl[6]))((IBluetoothLEAdvertisementWatcherTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTrigger.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger.get_MaxSamplingInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MaxSamplingInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger*, TimeSpan*, int>)(lpVtbl[7]))((IBluetoothLEAdvertisementWatcherTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTrigger.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger.get_MinOutOfRangeTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinOutOfRangeTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger*, TimeSpan*, int>)(lpVtbl[8]))((IBluetoothLEAdvertisementWatcherTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTrigger.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger.get_MaxOutOfRangeTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MaxOutOfRangeTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger*, TimeSpan*, int>)(lpVtbl[9]))((IBluetoothLEAdvertisementWatcherTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTrigger.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger.get_SignalStrengthFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SignalStrengthFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter **")] IBluetoothSignalStrengthFilter** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger*, IBluetoothSignalStrengthFilter**, int>)(lpVtbl[10]))((IBluetoothLEAdvertisementWatcherTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTrigger.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger.put_SignalStrengthFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_SignalStrengthFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter *")] IBluetoothSignalStrengthFilter* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger*, IBluetoothSignalStrengthFilter*, int>)(lpVtbl[11]))((IBluetoothLEAdvertisementWatcherTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTrigger.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger.get_AdvertisementFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AdvertisementFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter **")] IBluetoothLEAdvertisementFilter** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger*, IBluetoothLEAdvertisementFilter**, int>)(lpVtbl[12]))((IBluetoothLEAdvertisementWatcherTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTrigger.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger.put_AdvertisementFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_AdvertisementFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *")] IBluetoothLEAdvertisementFilter* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger*, IBluetoothLEAdvertisementFilter*, int>)(lpVtbl[13]))((IBluetoothLEAdvertisementWatcherTrigger*)Unsafe.AsPointer(ref this), value);
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
        HRESULT get_SignalStrengthFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter **")] IBluetoothSignalStrengthFilter** value);

        [VtblIndex(11)]
        HRESULT put_SignalStrengthFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter *")] IBluetoothSignalStrengthFilter* value);

        [VtblIndex(12)]
        HRESULT get_AdvertisementFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter **")] IBluetoothLEAdvertisementFilter** value);

        [VtblIndex(13)]
        HRESULT put_AdvertisementFilter([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *")] IBluetoothLEAdvertisementFilter* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothSignalStrengthFilter**, int> get_SignalStrengthFilter;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothSignalStrengthFilter*, int> put_SignalStrengthFilter;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEAdvertisementFilter**, int> get_AdvertisementFilter;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEAdvertisementFilter*, int> put_AdvertisementFilter;
    }
}
