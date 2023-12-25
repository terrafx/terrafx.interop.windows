// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEDevice2.xml' path='doc/member[@name="IBluetoothLEDevice2"]/*' />
[Guid("26F062B3-7AEE-4D31-BABA-B1B9775F5916")]
[NativeTypeName("struct IBluetoothLEDevice2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEDevice2 : IBluetoothLEDevice2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEDevice2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice2*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEDevice2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice2*, uint>)(lpVtbl[1]))((IBluetoothLEDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice2*, uint>)(lpVtbl[2]))((IBluetoothLEDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice2*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEDevice2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice2*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEDevice2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice2*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEDevice2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEDevice2.xml' path='doc/member[@name="IBluetoothLEDevice2.get_DeviceInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")] IDeviceInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice2*, IDeviceInformation**, int>)(lpVtbl[6]))((IBluetoothLEDevice2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEDevice2.xml' path='doc/member[@name="IBluetoothLEDevice2.get_Appearance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Appearance([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance **")] IBluetoothLEAppearance** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice2*, IBluetoothLEAppearance**, int>)(lpVtbl[7]))((IBluetoothLEDevice2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEDevice2.xml' path='doc/member[@name="IBluetoothLEDevice2.get_BluetoothAddressType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BluetoothAddressType([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothAddressType *")] BluetoothAddressType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice2*, BluetoothAddressType*, int>)(lpVtbl[8]))((IBluetoothLEDevice2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")] IDeviceInformation** value);

        [VtblIndex(7)]
        HRESULT get_Appearance([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance **")] IBluetoothLEAppearance** value);

        [VtblIndex(8)]
        HRESULT get_BluetoothAddressType([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothAddressType *")] BluetoothAddressType* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceInformation**, int> get_DeviceInformation;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEAppearance**, int> get_Appearance;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothAddressType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothAddressType*, int> get_BluetoothAddressType;
    }
}
