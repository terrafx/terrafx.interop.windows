// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothClassOfDeviceStatics.xml' path='doc/member[@name="IBluetoothClassOfDeviceStatics"]/*' />
[Guid("E46135BD-0FA2-416C-91B4-C1E48CA061C1")]
[NativeTypeName("struct IBluetoothClassOfDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothClassOfDeviceStatics : IBluetoothClassOfDeviceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothClassOfDeviceStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothClassOfDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDeviceStatics*, uint>)(lpVtbl[1]))((IBluetoothClassOfDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDeviceStatics*, uint>)(lpVtbl[2]))((IBluetoothClassOfDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothClassOfDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDeviceStatics*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothClassOfDeviceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothClassOfDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothClassOfDeviceStatics.xml' path='doc/member[@name="IBluetoothClassOfDeviceStatics.FromRawValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromRawValue([NativeTypeName("UINT32")] uint rawValue, [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothClassOfDevice **")] IBluetoothClassOfDevice** classOfDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDeviceStatics*, uint, IBluetoothClassOfDevice**, int>)(lpVtbl[6]))((IBluetoothClassOfDeviceStatics*)Unsafe.AsPointer(ref this), rawValue, classOfDevice);
    }

    /// <include file='IBluetoothClassOfDeviceStatics.xml' path='doc/member[@name="IBluetoothClassOfDeviceStatics.FromParts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FromParts([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothMajorClass")] BluetoothMajorClass majorClass, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothMinorClass")] BluetoothMinorClass minorClass, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities")] BluetoothServiceCapabilities serviceCapabilities, [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothClassOfDevice **")] IBluetoothClassOfDevice** classOfDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothClassOfDeviceStatics*, BluetoothMajorClass, BluetoothMinorClass, BluetoothServiceCapabilities, IBluetoothClassOfDevice**, int>)(lpVtbl[7]))((IBluetoothClassOfDeviceStatics*)Unsafe.AsPointer(ref this), majorClass, minorClass, serviceCapabilities, classOfDevice);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromRawValue([NativeTypeName("UINT32")] uint rawValue, [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothClassOfDevice **")] IBluetoothClassOfDevice** classOfDevice);

        [VtblIndex(7)]
        HRESULT FromParts([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothMajorClass")] BluetoothMajorClass majorClass, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothMinorClass")] BluetoothMinorClass minorClass, [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities")] BluetoothServiceCapabilities serviceCapabilities, [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothClassOfDevice **")] IBluetoothClassOfDevice** classOfDevice);
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

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Devices::Bluetooth::IBluetoothClassOfDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IBluetoothClassOfDevice**, int> FromRawValue;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothMajorClass, ABI::Windows::Devices::Bluetooth::BluetoothMinorClass, ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities, ABI::Windows::Devices::Bluetooth::IBluetoothClassOfDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothMajorClass, BluetoothMinorClass, BluetoothServiceCapabilities, IBluetoothClassOfDevice**, int> FromParts;
    }
}
