// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.rfcomm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRfcommDeviceServiceStatics.xml' path='doc/member[@name="IRfcommDeviceServiceStatics"]/*' />
[Guid("A4A149EF-626D-41AC-B253-87AC5C27E28A")]
[NativeTypeName("struct IRfcommDeviceServiceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommDeviceServiceStatics : IRfcommDeviceServiceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRfcommDeviceServiceStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IRfcommDeviceServiceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics*, uint>)(lpVtbl[1]))((IRfcommDeviceServiceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics*, uint>)(lpVtbl[2]))((IRfcommDeviceServiceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IRfcommDeviceServiceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics*, HSTRING*, int>)(lpVtbl[4]))((IRfcommDeviceServiceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IRfcommDeviceServiceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRfcommDeviceServiceStatics.xml' path='doc/member[@name="IRfcommDeviceServiceStatics.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceService_t **")] IAsyncOperation<Pointer<IRfcommDeviceService>>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics*, HSTRING, IAsyncOperation<Pointer<IRfcommDeviceService>>**, int>)(lpVtbl[6]))((IRfcommDeviceServiceStatics*)Unsafe.AsPointer(ref this), deviceId, asyncOp);
    }

    /// <include file='IRfcommDeviceServiceStatics.xml' path='doc/member[@name="IRfcommDeviceServiceStatics.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelector([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")] IRfcommServiceId* serviceId, HSTRING* selector)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommDeviceServiceStatics*, IRfcommServiceId*, HSTRING*, int>)(lpVtbl[7]))((IRfcommDeviceServiceStatics*)Unsafe.AsPointer(ref this), serviceId, selector);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceService_t **")] IAsyncOperation<Pointer<IRfcommDeviceService>>** asyncOp);

        [VtblIndex(7)]
        HRESULT GetDeviceSelector([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")] IRfcommServiceId* serviceId, HSTRING* selector);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceService_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IRfcommDeviceService>>**, int> FromIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommServiceId*, HSTRING*, int> GetDeviceSelector;
    }
}
