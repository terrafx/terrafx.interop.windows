// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEManufacturerDataFactory.xml' path='doc/member[@name="IBluetoothLEManufacturerDataFactory"]/*' />
[Guid("C09B39F8-319A-441E-8DE5-66A81E877A6C")]
[NativeTypeName("struct IBluetoothLEManufacturerDataFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEManufacturerDataFactory : IBluetoothLEManufacturerDataFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEManufacturerDataFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerDataFactory*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEManufacturerDataFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerDataFactory*, uint>)(lpVtbl[1]))((IBluetoothLEManufacturerDataFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerDataFactory*, uint>)(lpVtbl[2]))((IBluetoothLEManufacturerDataFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerDataFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEManufacturerDataFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerDataFactory*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEManufacturerDataFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerDataFactory*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEManufacturerDataFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEManufacturerDataFactory.xml' path='doc/member[@name="IBluetoothLEManufacturerDataFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("UINT16")] ushort companyId, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEManufacturerData **")] IBluetoothLEManufacturerData** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerDataFactory*, ushort, IBuffer*, IBluetoothLEManufacturerData**, int>)(lpVtbl[6]))((IBluetoothLEManufacturerDataFactory*)Unsafe.AsPointer(ref this), companyId, data, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("UINT16")] ushort companyId, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEManufacturerData **")] IBluetoothLEManufacturerData** value);
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

        [NativeTypeName("HRESULT (UINT16, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEManufacturerData **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, IBuffer*, IBluetoothLEManufacturerData**, int> Create;
    }
}
