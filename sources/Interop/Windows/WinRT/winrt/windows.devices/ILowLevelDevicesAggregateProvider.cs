// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILowLevelDevicesAggregateProvider.xml' path='doc/member[@name="ILowLevelDevicesAggregateProvider"]/*' />
[Guid("A73E561C-AAC1-4EC7-A852-479F7060D01F")]
[NativeTypeName("struct ILowLevelDevicesAggregateProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILowLevelDevicesAggregateProvider : ILowLevelDevicesAggregateProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILowLevelDevicesAggregateProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProvider*, Guid*, void**, int>)(lpVtbl[0]))((ILowLevelDevicesAggregateProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProvider*, uint>)(lpVtbl[1]))((ILowLevelDevicesAggregateProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProvider*, uint>)(lpVtbl[2]))((ILowLevelDevicesAggregateProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProvider*, uint*, Guid**, int>)(lpVtbl[3]))((ILowLevelDevicesAggregateProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProvider*, HSTRING*, int>)(lpVtbl[4]))((ILowLevelDevicesAggregateProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProvider*, TrustLevel*, int>)(lpVtbl[5]))((ILowLevelDevicesAggregateProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILowLevelDevicesAggregateProvider.xml' path='doc/member[@name="ILowLevelDevicesAggregateProvider.get_AdcControllerProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AdcControllerProvider([NativeTypeName("ABI::Windows::Devices::Adc::Provider::IAdcControllerProvider **")] IAdcControllerProvider** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProvider*, IAdcControllerProvider**, int>)(lpVtbl[6]))((ILowLevelDevicesAggregateProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLevelDevicesAggregateProvider.xml' path='doc/member[@name="ILowLevelDevicesAggregateProvider.get_PwmControllerProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PwmControllerProvider([NativeTypeName("ABI::Windows::Devices::Pwm::Provider::IPwmControllerProvider **")] IPwmControllerProvider** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProvider*, IPwmControllerProvider**, int>)(lpVtbl[7]))((ILowLevelDevicesAggregateProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLevelDevicesAggregateProvider.xml' path='doc/member[@name="ILowLevelDevicesAggregateProvider.get_GpioControllerProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_GpioControllerProvider([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::IGpioControllerProvider **")] IGpioControllerProvider** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProvider*, IGpioControllerProvider**, int>)(lpVtbl[8]))((ILowLevelDevicesAggregateProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLevelDevicesAggregateProvider.xml' path='doc/member[@name="ILowLevelDevicesAggregateProvider.get_I2cControllerProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_I2cControllerProvider([NativeTypeName("ABI::Windows::Devices::I2c::Provider::II2cControllerProvider **")] II2cControllerProvider** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProvider*, II2cControllerProvider**, int>)(lpVtbl[9]))((ILowLevelDevicesAggregateProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLevelDevicesAggregateProvider.xml' path='doc/member[@name="ILowLevelDevicesAggregateProvider.get_SpiControllerProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SpiControllerProvider([NativeTypeName("ABI::Windows::Devices::Spi::Provider::ISpiControllerProvider **")] ISpiControllerProvider** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesAggregateProvider*, ISpiControllerProvider**, int>)(lpVtbl[10]))((ILowLevelDevicesAggregateProvider*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AdcControllerProvider([NativeTypeName("ABI::Windows::Devices::Adc::Provider::IAdcControllerProvider **")] IAdcControllerProvider** value);

        [VtblIndex(7)]
        HRESULT get_PwmControllerProvider([NativeTypeName("ABI::Windows::Devices::Pwm::Provider::IPwmControllerProvider **")] IPwmControllerProvider** value);

        [VtblIndex(8)]
        HRESULT get_GpioControllerProvider([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::IGpioControllerProvider **")] IGpioControllerProvider** value);

        [VtblIndex(9)]
        HRESULT get_I2cControllerProvider([NativeTypeName("ABI::Windows::Devices::I2c::Provider::II2cControllerProvider **")] II2cControllerProvider** value);

        [VtblIndex(10)]
        HRESULT get_SpiControllerProvider([NativeTypeName("ABI::Windows::Devices::Spi::Provider::ISpiControllerProvider **")] ISpiControllerProvider** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Adc::Provider::IAdcControllerProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAdcControllerProvider**, int> get_AdcControllerProvider;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Pwm::Provider::IPwmControllerProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPwmControllerProvider**, int> get_PwmControllerProvider;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::Provider::IGpioControllerProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGpioControllerProvider**, int> get_GpioControllerProvider;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::I2c::Provider::II2cControllerProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, II2cControllerProvider**, int> get_I2cControllerProvider;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Spi::Provider::ISpiControllerProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpiControllerProvider**, int> get_SpiControllerProvider;
    }
}
