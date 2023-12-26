// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothClassOfDevice.xml' path='doc/member[@name="IBluetoothClassOfDevice"]/*' />
[Guid("D640227E-D7D7-4661-9454-65039CA17A2B")]
[NativeTypeName("struct IBluetoothClassOfDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothClassOfDevice : IBluetoothClassOfDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothClassOfDevice));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDevice*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothClassOfDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDevice*, uint>)(lpVtbl[1]))((IBluetoothClassOfDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDevice*, uint>)(lpVtbl[2]))((IBluetoothClassOfDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDevice*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothClassOfDevice*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDevice*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothClassOfDevice*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDevice*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothClassOfDevice*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothClassOfDevice.xml' path='doc/member[@name="IBluetoothClassOfDevice.get_RawValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_RawValue([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDevice*, uint*, int>)(lpVtbl[6]))((IBluetoothClassOfDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothClassOfDevice.xml' path='doc/member[@name="IBluetoothClassOfDevice.get_MajorClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MajorClass([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothMajorClass *")] BluetoothMajorClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDevice*, BluetoothMajorClass*, int>)(lpVtbl[7]))((IBluetoothClassOfDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothClassOfDevice.xml' path='doc/member[@name="IBluetoothClassOfDevice.get_MinorClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinorClass([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothMinorClass *")] BluetoothMinorClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDevice*, BluetoothMinorClass*, int>)(lpVtbl[8]))((IBluetoothClassOfDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothClassOfDevice.xml' path='doc/member[@name="IBluetoothClassOfDevice.get_ServiceCapabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ServiceCapabilities([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities *")] BluetoothServiceCapabilities* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDevice*, BluetoothServiceCapabilities*, int>)(lpVtbl[9]))((IBluetoothClassOfDevice*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_RawValue([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_MajorClass([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothMajorClass *")] BluetoothMajorClass* value);

        [VtblIndex(8)]
        HRESULT get_MinorClass([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothMinorClass *")] BluetoothMinorClass* value);

        [VtblIndex(9)]
        HRESULT get_ServiceCapabilities([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities *")] BluetoothServiceCapabilities* value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_RawValue;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothMajorClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothMajorClass*, int> get_MajorClass;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothMinorClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothMinorClass*, int> get_MinorClass;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothServiceCapabilities*, int> get_ServiceCapabilities;
    }
}
