// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEDeviceStatics.xml' path='doc/member[@name="IBluetoothLEDeviceStatics"]/*' />
[Guid("C8CF1A19-F0B6-4BF0-8689-41303DE2D9F4")]
[NativeTypeName("struct IBluetoothLEDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEDeviceStatics : IBluetoothLEDeviceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBluetoothLEDeviceStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics*, uint>)(lpVtbl[1]))((IBluetoothLEDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics*, uint>)(lpVtbl[2]))((IBluetoothLEDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEDeviceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEDeviceStatics.xml' path='doc/member[@name="IBluetoothLEDeviceStatics.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothLEDevice_t **")] IAsyncOperation<Pointer<IBluetoothLEDevice>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics*, HSTRING, IAsyncOperation<Pointer<IBluetoothLEDevice>>**, int>)(lpVtbl[6]))((IBluetoothLEDeviceStatics*)Unsafe.AsPointer(ref this), deviceId, operation);
    }

    /// <include file='IBluetoothLEDeviceStatics.xml' path='doc/member[@name="IBluetoothLEDeviceStatics.FromBluetoothAddressAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FromBluetoothAddressAsync([NativeTypeName("UINT64")] ulong bluetoothAddress, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothLEDevice_t **")] IAsyncOperation<Pointer<IBluetoothLEDevice>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics*, ulong, IAsyncOperation<Pointer<IBluetoothLEDevice>>**, int>)(lpVtbl[7]))((IBluetoothLEDeviceStatics*)Unsafe.AsPointer(ref this), bluetoothAddress, operation);
    }

    /// <include file='IBluetoothLEDeviceStatics.xml' path='doc/member[@name="IBluetoothLEDeviceStatics.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeviceSelector(HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDeviceStatics*, HSTRING*, int>)(lpVtbl[8]))((IBluetoothLEDeviceStatics*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothLEDevice_t **")] IAsyncOperation<Pointer<IBluetoothLEDevice>>** operation);

        [VtblIndex(7)]
        HRESULT FromBluetoothAddressAsync([NativeTypeName("UINT64")] ulong bluetoothAddress, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothLEDevice_t **")] IAsyncOperation<Pointer<IBluetoothLEDevice>>** operation);

        [VtblIndex(8)]
        HRESULT GetDeviceSelector(HSTRING* result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothLEDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IBluetoothLEDevice>>**, int> FromIdAsync;

        [NativeTypeName("HRESULT (UINT64, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothLEDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, IAsyncOperation<Pointer<IBluetoothLEDevice>>**, int> FromBluetoothAddressAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetDeviceSelector;
    }
}
