// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAdvertisementFilter.xml' path='doc/member[@name="IBluetoothLEAdvertisementFilter"]/*' />
[Guid("131EB0D3-D04E-47B1-837E-49405BF6F80F")]
[NativeTypeName("struct IBluetoothLEAdvertisementFilter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementFilter : IBluetoothLEAdvertisementFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAdvertisementFilter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementFilter*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAdvertisementFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementFilter*, uint>)(lpVtbl[1]))((IBluetoothLEAdvertisementFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementFilter*, uint>)(lpVtbl[2]))((IBluetoothLEAdvertisementFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementFilter*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAdvertisementFilter*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementFilter*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAdvertisementFilter*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementFilter*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAdvertisementFilter*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAdvertisementFilter.xml' path='doc/member[@name="IBluetoothLEAdvertisementFilter.get_Advertisement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Advertisement([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisement **")] IBluetoothLEAdvertisement** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementFilter*, IBluetoothLEAdvertisement**, int>)(lpVtbl[6]))((IBluetoothLEAdvertisementFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementFilter.xml' path='doc/member[@name="IBluetoothLEAdvertisementFilter.put_Advertisement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Advertisement([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisement *")] IBluetoothLEAdvertisement* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementFilter*, IBluetoothLEAdvertisement*, int>)(lpVtbl[7]))((IBluetoothLEAdvertisementFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementFilter.xml' path='doc/member[@name="IBluetoothLEAdvertisementFilter.get_BytePatterns"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BytePatterns([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementBytePattern_t **")] IVector<Pointer<IBluetoothLEAdvertisementBytePattern>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementFilter*, IVector<Pointer<IBluetoothLEAdvertisementBytePattern>>**, int>)(lpVtbl[8]))((IBluetoothLEAdvertisementFilter*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Advertisement([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisement **")] IBluetoothLEAdvertisement** value);

        [VtblIndex(7)]
        HRESULT put_Advertisement([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisement *")] IBluetoothLEAdvertisement* value);

        [VtblIndex(8)]
        HRESULT get_BytePatterns([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementBytePattern_t **")] IVector<Pointer<IBluetoothLEAdvertisementBytePattern>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEAdvertisement**, int> get_Advertisement;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisement *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEAdvertisement*, int> put_Advertisement;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementBytePattern_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IBluetoothLEAdvertisementBytePattern>>**, int> get_BytePatterns;
    }
}
