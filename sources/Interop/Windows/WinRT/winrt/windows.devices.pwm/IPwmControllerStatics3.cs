// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.pwm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPwmControllerStatics3.xml' path='doc/member[@name="IPwmControllerStatics3"]/*' />
[Guid("B2581871-0229-4344-AE3F-9B7CD0E66B94")]
[NativeTypeName("struct IPwmControllerStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPwmControllerStatics3 : IPwmControllerStatics3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPwmControllerStatics3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IPwmControllerStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerStatics3*, uint>)(lpVtbl[1]))((IPwmControllerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerStatics3*, uint>)(lpVtbl[2]))((IPwmControllerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IPwmControllerStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerStatics3*, HSTRING*, int>)(lpVtbl[4]))((IPwmControllerStatics3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IPwmControllerStatics3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPwmControllerStatics3.xml' path='doc/member[@name="IPwmControllerStatics3.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceSelector(HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerStatics3*, HSTRING*, int>)(lpVtbl[6]))((IPwmControllerStatics3*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPwmControllerStatics3.xml' path='doc/member[@name="IPwmControllerStatics3.GetDeviceSelectorFromFriendlyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelectorFromFriendlyName(HSTRING friendlyName, HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerStatics3*, HSTRING, HSTRING*, int>)(lpVtbl[7]))((IPwmControllerStatics3*)Unsafe.AsPointer(ref this), friendlyName, result);
    }

    /// <include file='IPwmControllerStatics3.xml' path='doc/member[@name="IPwmControllerStatics3.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPwm__CPwmController_t **")] IAsyncOperation<Pointer<IPwmController>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerStatics3*, HSTRING, IAsyncOperation<Pointer<IPwmController>>**, int>)(lpVtbl[8]))((IPwmControllerStatics3*)Unsafe.AsPointer(ref this), deviceId, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceSelector(HSTRING* result);

        [VtblIndex(7)]
        HRESULT GetDeviceSelectorFromFriendlyName(HSTRING friendlyName, HSTRING* result);

        [VtblIndex(8)]
        HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPwm__CPwmController_t **")] IAsyncOperation<Pointer<IPwmController>>** operation);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetDeviceSelector;

        [NativeTypeName("HRESULT (HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING*, int> GetDeviceSelectorFromFriendlyName;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPwm__CPwmController_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IPwmController>>**, int> FromIdAsync;
    }
}
