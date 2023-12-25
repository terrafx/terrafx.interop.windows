// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothDeviceStatics.xml' path='doc/member[@name="IBluetoothDeviceStatics"]/*' />
[Guid("0991DF51-57DB-4725-BBD7-84F64327EC2C")]
[NativeTypeName("struct IBluetoothDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothDeviceStatics : IBluetoothDeviceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothDeviceStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDeviceStatics*, uint>)(lpVtbl[1]))((IBluetoothDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDeviceStatics*, uint>)(lpVtbl[2]))((IBluetoothDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDeviceStatics*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothDeviceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothDeviceStatics.xml' path='doc/member[@name="IBluetoothDeviceStatics.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothDevice_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDeviceStatics*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IBluetoothDeviceStatics*)Unsafe.AsPointer(ref this), deviceId, operation);
    }

    /// <include file='IBluetoothDeviceStatics.xml' path='doc/member[@name="IBluetoothDeviceStatics.FromHostNameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FromHostNameAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* hostName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothDevice_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDeviceStatics*, IHostName*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IBluetoothDeviceStatics*)Unsafe.AsPointer(ref this), hostName, operation);
    }

    /// <include file='IBluetoothDeviceStatics.xml' path='doc/member[@name="IBluetoothDeviceStatics.FromBluetoothAddressAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FromBluetoothAddressAsync([NativeTypeName("UINT64")] ulong address, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothDevice_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDeviceStatics*, ulong, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IBluetoothDeviceStatics*)Unsafe.AsPointer(ref this), address, operation);
    }

    /// <include file='IBluetoothDeviceStatics.xml' path='doc/member[@name="IBluetoothDeviceStatics.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeviceSelector(HSTRING* deviceSelector)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDeviceStatics*, HSTRING*, int>)(lpVtbl[9]))((IBluetoothDeviceStatics*)Unsafe.AsPointer(ref this), deviceSelector);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothDevice_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(7)]
        HRESULT FromHostNameAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* hostName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothDevice_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(8)]
        HRESULT FromBluetoothAddressAsync([NativeTypeName("UINT64")] ulong address, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothDevice_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(9)]
        HRESULT GetDeviceSelector(HSTRING* deviceSelector);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> FromIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, IAsyncOperation<IntPtr>**, int> FromHostNameAsync;

        [NativeTypeName("HRESULT (UINT64, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CBluetoothDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, IAsyncOperation<IntPtr>**, int> FromBluetoothAddressAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetDeviceSelector;
    }
}
