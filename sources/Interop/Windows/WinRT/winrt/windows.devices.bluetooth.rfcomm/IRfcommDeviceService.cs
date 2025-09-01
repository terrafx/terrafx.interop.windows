// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.rfcomm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRfcommDeviceService.xml' path='doc/member[@name="IRfcommDeviceService"]/*' />
[Guid("AE81FF1F-C5A1-4C40-8C28-F3EFD69062F3")]
[NativeTypeName("struct IRfcommDeviceService : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommDeviceService : IRfcommDeviceService.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRfcommDeviceService);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceService*, Guid*, void**, int>)(lpVtbl[0]))((IRfcommDeviceService*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceService*, uint>)(lpVtbl[1]))((IRfcommDeviceService*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceService*, uint>)(lpVtbl[2]))((IRfcommDeviceService*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceService*, uint*, Guid**, int>)(lpVtbl[3]))((IRfcommDeviceService*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceService*, HSTRING*, int>)(lpVtbl[4]))((IRfcommDeviceService*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceService*, TrustLevel*, int>)(lpVtbl[5]))((IRfcommDeviceService*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRfcommDeviceService.xml' path='doc/member[@name="IRfcommDeviceService.get_ConnectionHostName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ConnectionHostName([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceService*, IHostName**, int>)(lpVtbl[6]))((IRfcommDeviceService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommDeviceService.xml' path='doc/member[@name="IRfcommDeviceService.get_ConnectionServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ConnectionServiceName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceService*, HSTRING*, int>)(lpVtbl[7]))((IRfcommDeviceService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommDeviceService.xml' path='doc/member[@name="IRfcommDeviceService.get_ServiceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ServiceId([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceService*, IRfcommServiceId**, int>)(lpVtbl[8]))((IRfcommDeviceService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommDeviceService.xml' path='doc/member[@name="IRfcommDeviceService.get_ProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ProtectionLevel([NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel *")] SocketProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceService*, SocketProtectionLevel*, int>)(lpVtbl[9]))((IRfcommDeviceService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommDeviceService.xml' path='doc/member[@name="IRfcommDeviceService.get_MaxProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MaxProtectionLevel([NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel *")] SocketProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceService*, SocketProtectionLevel*, int>)(lpVtbl[10]))((IRfcommDeviceService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommDeviceService.xml' path='doc/member[@name="IRfcommDeviceService.GetSdpRawAttributesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSdpRawAttributesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<Pointer<IMapView<uint, Pointer<IBuffer>>>>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceService*, IAsyncOperation<Pointer<IMapView<uint, Pointer<IBuffer>>>>**, int>)(lpVtbl[11]))((IRfcommDeviceService*)Unsafe.AsPointer(ref this), asyncOp);
    }

    /// <include file='IRfcommDeviceService.xml' path='doc/member[@name="IRfcommDeviceService.GetSdpRawAttributesWithCacheModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetSdpRawAttributesWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<Pointer<IMapView<uint, Pointer<IBuffer>>>>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceService*, BluetoothCacheMode, IAsyncOperation<Pointer<IMapView<uint, Pointer<IBuffer>>>>**, int>)(lpVtbl[12]))((IRfcommDeviceService*)Unsafe.AsPointer(ref this), cacheMode, asyncOp);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ConnectionHostName([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value);

        [VtblIndex(7)]
        HRESULT get_ConnectionServiceName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_ServiceId([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** value);

        [VtblIndex(9)]
        HRESULT get_ProtectionLevel([NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel *")] SocketProtectionLevel* value);

        [VtblIndex(10)]
        HRESULT get_MaxProtectionLevel([NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel *")] SocketProtectionLevel* value);

        [VtblIndex(11)]
        HRESULT GetSdpRawAttributesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<Pointer<IMapView<uint, Pointer<IBuffer>>>>** asyncOp);

        [VtblIndex(12)]
        HRESULT GetSdpRawAttributesWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<Pointer<IMapView<uint, Pointer<IBuffer>>>>** asyncOp);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName**, int> get_ConnectionHostName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ConnectionServiceName;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommServiceId**, int> get_ServiceId;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::SocketProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SocketProtectionLevel*, int> get_ProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::SocketProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SocketProtectionLevel*, int> get_MaxProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IMapView<uint, Pointer<IBuffer>>>>**, int> GetSdpRawAttributesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothCacheMode, IAsyncOperation<Pointer<IMapView<uint, Pointer<IBuffer>>>>**, int> GetSdpRawAttributesWithCacheModeAsync;
    }
}
