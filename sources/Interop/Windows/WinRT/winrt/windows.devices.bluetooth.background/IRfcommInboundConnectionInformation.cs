// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRfcommInboundConnectionInformation.xml' path='doc/member[@name="IRfcommInboundConnectionInformation"]/*' />
[Guid("6D3E75A8-5429-4059-92E3-1E8B65528707")]
[NativeTypeName("struct IRfcommInboundConnectionInformation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommInboundConnectionInformation : IRfcommInboundConnectionInformation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRfcommInboundConnectionInformation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommInboundConnectionInformation*, Guid*, void**, int>)(lpVtbl[0]))((IRfcommInboundConnectionInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommInboundConnectionInformation*, uint>)(lpVtbl[1]))((IRfcommInboundConnectionInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommInboundConnectionInformation*, uint>)(lpVtbl[2]))((IRfcommInboundConnectionInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommInboundConnectionInformation*, uint*, Guid**, int>)(lpVtbl[3]))((IRfcommInboundConnectionInformation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommInboundConnectionInformation*, HSTRING*, int>)(lpVtbl[4]))((IRfcommInboundConnectionInformation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommInboundConnectionInformation*, TrustLevel*, int>)(lpVtbl[5]))((IRfcommInboundConnectionInformation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRfcommInboundConnectionInformation.xml' path='doc/member[@name="IRfcommInboundConnectionInformation.get_SdpRecord"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SdpRecord([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommInboundConnectionInformation*, IBuffer**, int>)(lpVtbl[6]))((IRfcommInboundConnectionInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommInboundConnectionInformation.xml' path='doc/member[@name="IRfcommInboundConnectionInformation.put_SdpRecord"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SdpRecord([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommInboundConnectionInformation*, IBuffer*, int>)(lpVtbl[7]))((IRfcommInboundConnectionInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommInboundConnectionInformation.xml' path='doc/member[@name="IRfcommInboundConnectionInformation.get_LocalServiceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LocalServiceId([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommInboundConnectionInformation*, IRfcommServiceId**, int>)(lpVtbl[8]))((IRfcommInboundConnectionInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommInboundConnectionInformation.xml' path='doc/member[@name="IRfcommInboundConnectionInformation.put_LocalServiceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_LocalServiceId([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")] IRfcommServiceId* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommInboundConnectionInformation*, IRfcommServiceId*, int>)(lpVtbl[9]))((IRfcommInboundConnectionInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommInboundConnectionInformation.xml' path='doc/member[@name="IRfcommInboundConnectionInformation.get_ServiceCapabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ServiceCapabilities([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities *")] BluetoothServiceCapabilities* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommInboundConnectionInformation*, BluetoothServiceCapabilities*, int>)(lpVtbl[10]))((IRfcommInboundConnectionInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommInboundConnectionInformation.xml' path='doc/member[@name="IRfcommInboundConnectionInformation.put_ServiceCapabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ServiceCapabilities([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities")] BluetoothServiceCapabilities value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommInboundConnectionInformation*, BluetoothServiceCapabilities, int>)(lpVtbl[11]))((IRfcommInboundConnectionInformation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SdpRecord([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(7)]
        HRESULT put_SdpRecord([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value);

        [VtblIndex(8)]
        HRESULT get_LocalServiceId([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** value);

        [VtblIndex(9)]
        HRESULT put_LocalServiceId([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")] IRfcommServiceId* value);

        [VtblIndex(10)]
        HRESULT get_ServiceCapabilities([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities *")] BluetoothServiceCapabilities* value);

        [VtblIndex(11)]
        HRESULT put_ServiceCapabilities([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities")] BluetoothServiceCapabilities value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_SdpRecord;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> put_SdpRecord;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommServiceId**, int> get_LocalServiceId;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommServiceId*, int> put_LocalServiceId;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothServiceCapabilities*, int> get_ServiceCapabilities;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothServiceCapabilities, int> put_ServiceCapabilities;
    }
}
