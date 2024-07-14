// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAdvertisementWatcherFactory.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherFactory"]/*' />
[Guid("9AAF2D56-39AC-453E-B32A-85C657E017F1")]
[NativeTypeName("struct IBluetoothLEAdvertisementWatcherFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementWatcherFactory : IBluetoothLEAdvertisementWatcherFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAdvertisementWatcherFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherFactory*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAdvertisementWatcherFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherFactory*, uint>)(lpVtbl[1]))((IBluetoothLEAdvertisementWatcherFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherFactory*, uint>)(lpVtbl[2]))((IBluetoothLEAdvertisementWatcherFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAdvertisementWatcherFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherFactory*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAdvertisementWatcherFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherFactory*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAdvertisementWatcherFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherFactory.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *")] IBluetoothLEAdvertisementFilter* advertisementFilter, [NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementWatcher **")] IBluetoothLEAdvertisementWatcher** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherFactory*, IBluetoothLEAdvertisementFilter*, IBluetoothLEAdvertisementWatcher**, int>)(lpVtbl[6]))((IBluetoothLEAdvertisementWatcherFactory*)Unsafe.AsPointer(ref this), advertisementFilter, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *")] IBluetoothLEAdvertisementFilter* advertisementFilter, [NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementWatcher **")] IBluetoothLEAdvertisementWatcher** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *, ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEAdvertisementFilter*, IBluetoothLEAdvertisementWatcher**, int> Create;
    }
}
