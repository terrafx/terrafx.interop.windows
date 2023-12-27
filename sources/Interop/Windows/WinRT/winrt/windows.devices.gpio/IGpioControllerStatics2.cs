// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGpioControllerStatics2.xml' path='doc/member[@name="IGpioControllerStatics2"]/*' />
[Guid("912B7D20-6CA4-4106-A373-FFFD346B0E5B")]
[NativeTypeName("struct IGpioControllerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGpioControllerStatics2 : IGpioControllerStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGpioControllerStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IGpioControllerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerStatics2*, uint>)(lpVtbl[1]))((IGpioControllerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerStatics2*, uint>)(lpVtbl[2]))((IGpioControllerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IGpioControllerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerStatics2*, HSTRING*, int>)(lpVtbl[4]))((IGpioControllerStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IGpioControllerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGpioControllerStatics2.xml' path='doc/member[@name="IGpioControllerStatics2.GetControllersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetControllersAsync([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::IGpioProvider *")] IGpioProvider* provider, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CGpio__CGpioController_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IGpioController>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerStatics2*, IGpioProvider*, IAsyncOperation<Pointer<IVectorView<Pointer<IGpioController>>>>**, int>)(lpVtbl[6]))((IGpioControllerStatics2*)Unsafe.AsPointer(ref this), provider, operation);
    }

    /// <include file='IGpioControllerStatics2.xml' path='doc/member[@name="IGpioControllerStatics2.GetDefaultAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDefaultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGpio__CGpioController_t **")] IAsyncOperation<Pointer<IGpioController>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerStatics2*, IAsyncOperation<Pointer<IGpioController>>**, int>)(lpVtbl[7]))((IGpioControllerStatics2*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetControllersAsync([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::IGpioProvider *")] IGpioProvider* provider, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CGpio__CGpioController_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IGpioController>>>>** operation);

        [VtblIndex(7)]
        HRESULT GetDefaultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGpio__CGpioController_t **")] IAsyncOperation<Pointer<IGpioController>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::Provider::IGpioProvider *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CGpio__CGpioController_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGpioProvider*, IAsyncOperation<Pointer<IVectorView<Pointer<IGpioController>>>>**, int> GetControllersAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGpio__CGpioController_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IGpioController>>**, int> GetDefaultAsync;
    }
}
