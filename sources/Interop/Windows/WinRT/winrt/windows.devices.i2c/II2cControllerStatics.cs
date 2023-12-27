// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.i2c.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='II2cControllerStatics.xml' path='doc/member[@name="II2cControllerStatics"]/*' />
[Guid("40FC0365-5F05-4E7E-84BD-100DB8E0AEC5")]
[NativeTypeName("struct II2cControllerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct II2cControllerStatics : II2cControllerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_II2cControllerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cControllerStatics*, Guid*, void**, int>)(lpVtbl[0]))((II2cControllerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<II2cControllerStatics*, uint>)(lpVtbl[1]))((II2cControllerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<II2cControllerStatics*, uint>)(lpVtbl[2]))((II2cControllerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cControllerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((II2cControllerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cControllerStatics*, HSTRING*, int>)(lpVtbl[4]))((II2cControllerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cControllerStatics*, TrustLevel*, int>)(lpVtbl[5]))((II2cControllerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='II2cControllerStatics.xml' path='doc/member[@name="II2cControllerStatics.GetControllersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetControllersAsync([NativeTypeName("ABI::Windows::Devices::I2c::Provider::II2cProvider *")] II2cProvider* provider, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CI2c__CI2cController_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<II2cController>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cControllerStatics*, II2cProvider*, IAsyncOperation<Pointer<IVectorView<Pointer<II2cController>>>>**, int>)(lpVtbl[6]))((II2cControllerStatics*)Unsafe.AsPointer(ref this), provider, operation);
    }

    /// <include file='II2cControllerStatics.xml' path='doc/member[@name="II2cControllerStatics.GetDefaultAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDefaultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CI2c__CI2cController_t **")] IAsyncOperation<Pointer<II2cController>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cControllerStatics*, IAsyncOperation<Pointer<II2cController>>**, int>)(lpVtbl[7]))((II2cControllerStatics*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetControllersAsync([NativeTypeName("ABI::Windows::Devices::I2c::Provider::II2cProvider *")] II2cProvider* provider, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CI2c__CI2cController_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<II2cController>>>>** operation);

        [VtblIndex(7)]
        HRESULT GetDefaultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CI2c__CI2cController_t **")] IAsyncOperation<Pointer<II2cController>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::I2c::Provider::II2cProvider *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CI2c__CI2cController_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, II2cProvider*, IAsyncOperation<Pointer<IVectorView<Pointer<II2cController>>>>**, int> GetControllersAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CI2c__CI2cController_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<II2cController>>**, int> GetDefaultAsync;
    }
}
