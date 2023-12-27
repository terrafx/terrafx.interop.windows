// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.rfcomm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRfcommDeviceServicesResult.xml' path='doc/member[@name="IRfcommDeviceServicesResult"]/*' />
[Guid("3B48388C-7CCF-488E-9625-D259A5732D55")]
[NativeTypeName("struct IRfcommDeviceServicesResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommDeviceServicesResult : IRfcommDeviceServicesResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRfcommDeviceServicesResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServicesResult*, Guid*, void**, int>)(lpVtbl[0]))((IRfcommDeviceServicesResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServicesResult*, uint>)(lpVtbl[1]))((IRfcommDeviceServicesResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServicesResult*, uint>)(lpVtbl[2]))((IRfcommDeviceServicesResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServicesResult*, uint*, Guid**, int>)(lpVtbl[3]))((IRfcommDeviceServicesResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServicesResult*, HSTRING*, int>)(lpVtbl[4]))((IRfcommDeviceServicesResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServicesResult*, TrustLevel*, int>)(lpVtbl[5]))((IRfcommDeviceServicesResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRfcommDeviceServicesResult.xml' path='doc/member[@name="IRfcommDeviceServicesResult.get_Error"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Error([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothError *")] BluetoothError* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServicesResult*, BluetoothError*, int>)(lpVtbl[6]))((IRfcommDeviceServicesResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommDeviceServicesResult.xml' path='doc/member[@name="IRfcommDeviceServicesResult.get_Services"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Services([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceService_t **")] IVectorView<Pointer<IRfcommDeviceService>>** services)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServicesResult*, IVectorView<Pointer<IRfcommDeviceService>>**, int>)(lpVtbl[7]))((IRfcommDeviceServicesResult*)Unsafe.AsPointer(ref this), services);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Error([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothError *")] BluetoothError* value);

        [VtblIndex(7)]
        HRESULT get_Services([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceService_t **")] IVectorView<Pointer<IRfcommDeviceService>>** services);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothError *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothError*, int> get_Error;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceService_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IRfcommDeviceService>>**, int> get_Services;
    }
}
