// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGpioControllerProvider.xml' path='doc/member[@name="IGpioControllerProvider"]/*' />
[Guid("AD11CEC7-19EA-4B21-874F-B91AED4A25DB")]
[NativeTypeName("struct IGpioControllerProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGpioControllerProvider : IGpioControllerProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGpioControllerProvider);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerProvider*, Guid*, void**, int>)(lpVtbl[0]))((IGpioControllerProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerProvider*, uint>)(lpVtbl[1]))((IGpioControllerProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerProvider*, uint>)(lpVtbl[2]))((IGpioControllerProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerProvider*, uint*, Guid**, int>)(lpVtbl[3]))((IGpioControllerProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerProvider*, HSTRING*, int>)(lpVtbl[4]))((IGpioControllerProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerProvider*, TrustLevel*, int>)(lpVtbl[5]))((IGpioControllerProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGpioControllerProvider.xml' path='doc/member[@name="IGpioControllerProvider.get_PinCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PinCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerProvider*, int*, int>)(lpVtbl[6]))((IGpioControllerProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioControllerProvider.xml' path='doc/member[@name="IGpioControllerProvider.OpenPinProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OpenPinProvider([NativeTypeName("INT32")] int pin, [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioSharingMode")] ProviderGpioSharingMode sharingMode, [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::IGpioPinProvider **")] IGpioPinProvider** gpioPinProvider)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioControllerProvider*, int, ProviderGpioSharingMode, IGpioPinProvider**, int>)(lpVtbl[7]))((IGpioControllerProvider*)Unsafe.AsPointer(ref this), pin, sharingMode, gpioPinProvider);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PinCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT OpenPinProvider([NativeTypeName("INT32")] int pin, [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioSharingMode")] ProviderGpioSharingMode sharingMode, [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::IGpioPinProvider **")] IGpioPinProvider** gpioPinProvider);
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_PinCount;

        [NativeTypeName("HRESULT (INT32, ABI::Windows::Devices::Gpio::Provider::ProviderGpioSharingMode, ABI::Windows::Devices::Gpio::Provider::IGpioPinProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, ProviderGpioSharingMode, IGpioPinProvider**, int> OpenPinProvider;
    }
}
