// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRfcommConnectionTriggerDetails.xml' path='doc/member[@name="IRfcommConnectionTriggerDetails"]/*' />
[Guid("F922734D-2E3C-4EFC-AB59-FC5CF96F97E3")]
[NativeTypeName("struct IRfcommConnectionTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommConnectionTriggerDetails : IRfcommConnectionTriggerDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRfcommConnectionTriggerDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((IRfcommConnectionTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTriggerDetails*, uint>)(lpVtbl[1]))((IRfcommConnectionTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTriggerDetails*, uint>)(lpVtbl[2]))((IRfcommConnectionTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IRfcommConnectionTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTriggerDetails*, HSTRING*, int>)(lpVtbl[4]))((IRfcommConnectionTriggerDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((IRfcommConnectionTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRfcommConnectionTriggerDetails.xml' path='doc/member[@name="IRfcommConnectionTriggerDetails.get_Socket"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Socket([NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocket **")] IStreamSocket** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTriggerDetails*, IStreamSocket**, int>)(lpVtbl[6]))((IRfcommConnectionTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommConnectionTriggerDetails.xml' path='doc/member[@name="IRfcommConnectionTriggerDetails.get_Incoming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Incoming([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTriggerDetails*, byte*, int>)(lpVtbl[7]))((IRfcommConnectionTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommConnectionTriggerDetails.xml' path='doc/member[@name="IRfcommConnectionTriggerDetails.get_RemoteDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RemoteDevice([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice **")] IBluetoothDevice** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTriggerDetails*, IBluetoothDevice**, int>)(lpVtbl[8]))((IRfcommConnectionTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Socket([NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocket **")] IStreamSocket** value);

        [VtblIndex(7)]
        HRESULT get_Incoming([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_RemoteDevice([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice **")] IBluetoothDevice** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::IStreamSocket **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStreamSocket**, int> get_Socket;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Incoming;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothDevice**, int> get_RemoteDevice;
    }
}
