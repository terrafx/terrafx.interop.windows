// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattRequestStateChangedEventArgs.xml' path='doc/member[@name="IGattRequestStateChangedEventArgs"]/*' />
[Guid("E834D92C-27BE-44B3-9D0D-4FC6E808DD3F")]
[NativeTypeName("struct IGattRequestStateChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattRequestStateChangedEventArgs : IGattRequestStateChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGattRequestStateChangedEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattRequestStateChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IGattRequestStateChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattRequestStateChangedEventArgs*, uint>)(lpVtbl[1]))((IGattRequestStateChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattRequestStateChangedEventArgs*, uint>)(lpVtbl[2]))((IGattRequestStateChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattRequestStateChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IGattRequestStateChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattRequestStateChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IGattRequestStateChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattRequestStateChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IGattRequestStateChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattRequestStateChangedEventArgs.xml' path='doc/member[@name="IGattRequestStateChangedEventArgs.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattRequestState *")] GattRequestState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattRequestStateChangedEventArgs*, GattRequestState*, int>)(lpVtbl[6]))((IGattRequestStateChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattRequestStateChangedEventArgs.xml' path='doc/member[@name="IGattRequestStateChangedEventArgs.get_Error"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Error([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothError *")] BluetoothError* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattRequestStateChangedEventArgs*, BluetoothError*, int>)(lpVtbl[7]))((IGattRequestStateChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_State([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattRequestState *")] GattRequestState* value);

        [VtblIndex(7)]
        HRESULT get_Error([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothError *")] BluetoothError* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattRequestState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattRequestState*, int> get_State;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothError *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothError*, int> get_Error;
    }
}
