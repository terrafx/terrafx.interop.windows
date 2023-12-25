// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILowLevelDevicesAggregateProviderFactory.xml' path='doc/member[@name="ILowLevelDevicesAggregateProviderFactory"]/*' />
[Guid("9AC4AAF6-3473-465E-96D5-36281A2C57AF")]
[NativeTypeName("struct ILowLevelDevicesAggregateProviderFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILowLevelDevicesAggregateProviderFactory : ILowLevelDevicesAggregateProviderFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILowLevelDevicesAggregateProviderFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProviderFactory*, Guid*, void**, int>)(lpVtbl[0]))((ILowLevelDevicesAggregateProviderFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProviderFactory*, uint>)(lpVtbl[1]))((ILowLevelDevicesAggregateProviderFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProviderFactory*, uint>)(lpVtbl[2]))((ILowLevelDevicesAggregateProviderFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProviderFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ILowLevelDevicesAggregateProviderFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProviderFactory*, HSTRING*, int>)(lpVtbl[4]))((ILowLevelDevicesAggregateProviderFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProviderFactory*, TrustLevel*, int>)(lpVtbl[5]))((ILowLevelDevicesAggregateProviderFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILowLevelDevicesAggregateProviderFactory.xml' path='doc/member[@name="ILowLevelDevicesAggregateProviderFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Devices::Adc::Provider::IAdcControllerProvider *")] IAdcControllerProvider* adc, [NativeTypeName("ABI::Windows::Devices::Pwm::Provider::IPwmControllerProvider *")] IPwmControllerProvider* pwm, [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::IGpioControllerProvider *")] IGpioControllerProvider* gpio, [NativeTypeName("ABI::Windows::Devices::I2c::Provider::II2cControllerProvider *")] II2cControllerProvider* i2c, [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ISpiControllerProvider *")] ISpiControllerProvider* spi, [NativeTypeName("ABI::Windows::Devices::ILowLevelDevicesAggregateProvider **")] ILowLevelDevicesAggregateProvider** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProviderFactory*, IAdcControllerProvider*, IPwmControllerProvider*, IGpioControllerProvider*, II2cControllerProvider*, ISpiControllerProvider*, ILowLevelDevicesAggregateProvider**, int>)(lpVtbl[6]))((ILowLevelDevicesAggregateProviderFactory*)Unsafe.AsPointer(ref this), adc, pwm, gpio, i2c, spi, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Devices::Adc::Provider::IAdcControllerProvider *")] IAdcControllerProvider* adc, [NativeTypeName("ABI::Windows::Devices::Pwm::Provider::IPwmControllerProvider *")] IPwmControllerProvider* pwm, [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::IGpioControllerProvider *")] IGpioControllerProvider* gpio, [NativeTypeName("ABI::Windows::Devices::I2c::Provider::II2cControllerProvider *")] II2cControllerProvider* i2c, [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ISpiControllerProvider *")] ISpiControllerProvider* spi, [NativeTypeName("ABI::Windows::Devices::ILowLevelDevicesAggregateProvider **")] ILowLevelDevicesAggregateProvider** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Adc::Provider::IAdcControllerProvider *, ABI::Windows::Devices::Pwm::Provider::IPwmControllerProvider *, ABI::Windows::Devices::Gpio::Provider::IGpioControllerProvider *, ABI::Windows::Devices::I2c::Provider::II2cControllerProvider *, ABI::Windows::Devices::Spi::Provider::ISpiControllerProvider *, ABI::Windows::Devices::ILowLevelDevicesAggregateProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAdcControllerProvider*, IPwmControllerProvider*, IGpioControllerProvider*, II2cControllerProvider*, ISpiControllerProvider*, ILowLevelDevicesAggregateProvider**, int> Create;
    }
}
