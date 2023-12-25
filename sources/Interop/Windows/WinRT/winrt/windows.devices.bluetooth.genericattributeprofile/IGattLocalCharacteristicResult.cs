// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattLocalCharacteristicResult.xml' path='doc/member[@name="IGattLocalCharacteristicResult"]/*' />
[Guid("7975DE9B-0170-4397-9666-92F863F12EE6")]
[NativeTypeName("struct IGattLocalCharacteristicResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattLocalCharacteristicResult : IGattLocalCharacteristicResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattLocalCharacteristicResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicResult*, Guid*, void**, int>)(lpVtbl[0]))((IGattLocalCharacteristicResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicResult*, uint>)(lpVtbl[1]))((IGattLocalCharacteristicResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicResult*, uint>)(lpVtbl[2]))((IGattLocalCharacteristicResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicResult*, uint*, Guid**, int>)(lpVtbl[3]))((IGattLocalCharacteristicResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicResult*, HSTRING*, int>)(lpVtbl[4]))((IGattLocalCharacteristicResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicResult*, TrustLevel*, int>)(lpVtbl[5]))((IGattLocalCharacteristicResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattLocalCharacteristicResult.xml' path='doc/member[@name="IGattLocalCharacteristicResult.get_Characteristic"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Characteristic([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalCharacteristic **")] IGattLocalCharacteristic** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicResult*, IGattLocalCharacteristic**, int>)(lpVtbl[6]))((IGattLocalCharacteristicResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristicResult.xml' path='doc/member[@name="IGattLocalCharacteristicResult.get_Error"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Error([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothError *")] BluetoothError* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicResult*, BluetoothError*, int>)(lpVtbl[7]))((IGattLocalCharacteristicResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Characteristic([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalCharacteristic **")] IGattLocalCharacteristic** value);

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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalCharacteristic **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGattLocalCharacteristic**, int> get_Characteristic;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothError *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothError*, int> get_Error;
    }
}
