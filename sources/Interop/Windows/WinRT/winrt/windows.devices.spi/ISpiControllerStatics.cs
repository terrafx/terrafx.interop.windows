// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.spi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpiControllerStatics.xml' path='doc/member[@name="ISpiControllerStatics"]/*' />
[Guid("0D5229E2-138B-4E48-B964-4F2F79B9C5A2")]
[NativeTypeName("struct ISpiControllerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpiControllerStatics : ISpiControllerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpiControllerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiControllerStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISpiControllerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiControllerStatics*, uint>)(lpVtbl[1]))((ISpiControllerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiControllerStatics*, uint>)(lpVtbl[2]))((ISpiControllerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiControllerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISpiControllerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiControllerStatics*, HSTRING*, int>)(lpVtbl[4]))((ISpiControllerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiControllerStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISpiControllerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpiControllerStatics.xml' path='doc/member[@name="ISpiControllerStatics.GetDefaultAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefaultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSpi__CSpiController_t **")] IAsyncOperation<Pointer<ISpiController>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiControllerStatics*, IAsyncOperation<Pointer<ISpiController>>**, int>)(lpVtbl[6]))((ISpiControllerStatics*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='ISpiControllerStatics.xml' path='doc/member[@name="ISpiControllerStatics.GetControllersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetControllersAsync([NativeTypeName("ABI::Windows::Devices::Spi::Provider::ISpiProvider *")] ISpiProvider* provider, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSpi__CSpiController_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<ISpiController>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiControllerStatics*, ISpiProvider*, IAsyncOperation<Pointer<IVectorView<Pointer<ISpiController>>>>**, int>)(lpVtbl[7]))((ISpiControllerStatics*)Unsafe.AsPointer(ref this), provider, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDefaultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSpi__CSpiController_t **")] IAsyncOperation<Pointer<ISpiController>>** operation);

        [VtblIndex(7)]
        HRESULT GetControllersAsync([NativeTypeName("ABI::Windows::Devices::Spi::Provider::ISpiProvider *")] ISpiProvider* provider, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSpi__CSpiController_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<ISpiController>>>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSpi__CSpiController_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<ISpiController>>**, int> GetDefaultAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Spi::Provider::ISpiProvider *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSpi__CSpiController_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpiProvider*, IAsyncOperation<Pointer<IVectorView<Pointer<ISpiController>>>>**, int> GetControllersAsync;
    }
}
