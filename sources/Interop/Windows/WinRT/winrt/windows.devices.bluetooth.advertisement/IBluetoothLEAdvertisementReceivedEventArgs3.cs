// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAdvertisementReceivedEventArgs3.xml' path='doc/member[@name="IBluetoothLEAdvertisementReceivedEventArgs3"]/*' />
[Guid("8D204B54-FF86-5D84-A25A-137DCCD96F7A")]
[NativeTypeName("struct IBluetoothLEAdvertisementReceivedEventArgs3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementReceivedEventArgs3 : IBluetoothLEAdvertisementReceivedEventArgs3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBluetoothLEAdvertisementReceivedEventArgs3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs3*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAdvertisementReceivedEventArgs3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs3*, uint>)(lpVtbl[1]))((IBluetoothLEAdvertisementReceivedEventArgs3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs3*, uint>)(lpVtbl[2]))((IBluetoothLEAdvertisementReceivedEventArgs3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs3*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAdvertisementReceivedEventArgs3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs3*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAdvertisementReceivedEventArgs3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs3*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAdvertisementReceivedEventArgs3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAdvertisementReceivedEventArgs3.xml' path='doc/member[@name="IBluetoothLEAdvertisementReceivedEventArgs3.get_PrimaryPhy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PrimaryPhy([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType *")] BluetoothLEAdvertisementPhyType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs3*, BluetoothLEAdvertisementPhyType*, int>)(lpVtbl[6]))((IBluetoothLEAdvertisementReceivedEventArgs3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementReceivedEventArgs3.xml' path='doc/member[@name="IBluetoothLEAdvertisementReceivedEventArgs3.get_SecondaryPhy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SecondaryPhy([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType *")] BluetoothLEAdvertisementPhyType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs3*, BluetoothLEAdvertisementPhyType*, int>)(lpVtbl[7]))((IBluetoothLEAdvertisementReceivedEventArgs3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PrimaryPhy([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType *")] BluetoothLEAdvertisementPhyType* value);

        [VtblIndex(7)]
        HRESULT get_SecondaryPhy([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType *")] BluetoothLEAdvertisementPhyType* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPhyType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothLEAdvertisementPhyType*, int> get_SecondaryPhy;
    }
}
