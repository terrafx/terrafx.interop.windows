// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.rfcomm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRfcommServiceProviderStatics.xml' path='doc/member[@name="IRfcommServiceProviderStatics"]/*' />
[Guid("98888303-69CA-413A-84F7-4344C7292997")]
[NativeTypeName("struct IRfcommServiceProviderStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommServiceProviderStatics : IRfcommServiceProviderStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRfcommServiceProviderStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProviderStatics*, Guid*, void**, int>)(lpVtbl[0]))((IRfcommServiceProviderStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProviderStatics*, uint>)(lpVtbl[1]))((IRfcommServiceProviderStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProviderStatics*, uint>)(lpVtbl[2]))((IRfcommServiceProviderStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProviderStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IRfcommServiceProviderStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProviderStatics*, HSTRING*, int>)(lpVtbl[4]))((IRfcommServiceProviderStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProviderStatics*, TrustLevel*, int>)(lpVtbl[5]))((IRfcommServiceProviderStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRfcommServiceProviderStatics.xml' path='doc/member[@name="IRfcommServiceProviderStatics.CreateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")] IRfcommServiceId* serviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommServiceProvider_t **")] IAsyncOperation<Pointer<IRfcommServiceProvider>>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProviderStatics*, IRfcommServiceId*, IAsyncOperation<Pointer<IRfcommServiceProvider>>**, int>)(lpVtbl[6]))((IRfcommServiceProviderStatics*)Unsafe.AsPointer(ref this), serviceId, asyncOp);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")] IRfcommServiceId* serviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommServiceProvider_t **")] IAsyncOperation<Pointer<IRfcommServiceProvider>>** asyncOp);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommServiceProvider_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommServiceId*, IAsyncOperation<Pointer<IRfcommServiceProvider>>**, int> CreateAsync;
    }
}
