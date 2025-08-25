// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAdvertisementPublisher3.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher3"]/*' />
[Guid("1CFF3902-61EC-5776-AB86-9B41F94B1E66")]
[NativeTypeName("struct IBluetoothLEAdvertisementPublisher3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementPublisher3 : IBluetoothLEAdvertisementPublisher3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBluetoothLEAdvertisementPublisher3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher3*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAdvertisementPublisher3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher3*, uint>)(lpVtbl[1]))((IBluetoothLEAdvertisementPublisher3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher3*, uint>)(lpVtbl[2]))((IBluetoothLEAdvertisementPublisher3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher3*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAdvertisementPublisher3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher3*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAdvertisementPublisher3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher3*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAdvertisementPublisher3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher3.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher3.get_PrimaryPhy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PrimaryPhy([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType *")] BluetoothLEAdvertisementPhyType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher3*, BluetoothLEAdvertisementPhyType*, int>)(lpVtbl[6]))((IBluetoothLEAdvertisementPublisher3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher3.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher3.put_PrimaryPhy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_PrimaryPhy([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType")] BluetoothLEAdvertisementPhyType value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher3*, BluetoothLEAdvertisementPhyType, int>)(lpVtbl[7]))((IBluetoothLEAdvertisementPublisher3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher3.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher3.get_SecondaryPhy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SecondaryPhy([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType *")] BluetoothLEAdvertisementPhyType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher3*, BluetoothLEAdvertisementPhyType*, int>)(lpVtbl[8]))((IBluetoothLEAdvertisementPublisher3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher3.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher3.put_SecondaryPhy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SecondaryPhy([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType")] BluetoothLEAdvertisementPhyType value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher3*, BluetoothLEAdvertisementPhyType, int>)(lpVtbl[9]))((IBluetoothLEAdvertisementPublisher3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PrimaryPhy([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType *")] BluetoothLEAdvertisementPhyType* value);

        [VtblIndex(7)]
        HRESULT put_PrimaryPhy([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType")] BluetoothLEAdvertisementPhyType value);

        [VtblIndex(8)]
        HRESULT get_SecondaryPhy([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType *")] BluetoothLEAdvertisementPhyType* value);

        [VtblIndex(9)]
        HRESULT put_SecondaryPhy([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType")] BluetoothLEAdvertisementPhyType value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothLEAdvertisementPhyType*, int> get_PrimaryPhy;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothLEAdvertisementPhyType, int> put_PrimaryPhy;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothLEAdvertisementPhyType*, int> get_SecondaryPhy;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothLEAdvertisementPhyType, int> put_SecondaryPhy;
    }
}
