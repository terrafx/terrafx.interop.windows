// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEConnectionPhy.xml' path='doc/member[@name="IBluetoothLEConnectionPhy"]/*' />
[Guid("781E5E48-621E-5A7E-8BE6-1B9561FF63C9")]
[NativeTypeName("struct IBluetoothLEConnectionPhy : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEConnectionPhy : IBluetoothLEConnectionPhy.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBluetoothLEConnectionPhy);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhy*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEConnectionPhy*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhy*, uint>)(lpVtbl[1]))((IBluetoothLEConnectionPhy*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhy*, uint>)(lpVtbl[2]))((IBluetoothLEConnectionPhy*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhy*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEConnectionPhy*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhy*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEConnectionPhy*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhy*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEConnectionPhy*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEConnectionPhy.xml' path='doc/member[@name="IBluetoothLEConnectionPhy.get_TransmitInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TransmitInfo([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionPhyInfo **")] IBluetoothLEConnectionPhyInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhy*, IBluetoothLEConnectionPhyInfo**, int>)(lpVtbl[6]))((IBluetoothLEConnectionPhy*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEConnectionPhy.xml' path='doc/member[@name="IBluetoothLEConnectionPhy.get_ReceiveInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ReceiveInfo([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionPhyInfo **")] IBluetoothLEConnectionPhyInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhy*, IBluetoothLEConnectionPhyInfo**, int>)(lpVtbl[7]))((IBluetoothLEConnectionPhy*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TransmitInfo([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionPhyInfo **")] IBluetoothLEConnectionPhyInfo** value);

        [VtblIndex(7)]
        HRESULT get_ReceiveInfo([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionPhyInfo **")] IBluetoothLEConnectionPhyInfo** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionPhyInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEConnectionPhyInfo**, int> get_TransmitInfo;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionPhyInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEConnectionPhyInfo**, int> get_ReceiveInfo;
    }
}
