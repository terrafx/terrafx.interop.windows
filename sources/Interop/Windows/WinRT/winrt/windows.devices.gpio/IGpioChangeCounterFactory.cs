// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGpioChangeCounterFactory.xml' path='doc/member[@name="IGpioChangeCounterFactory"]/*' />
[Guid("147D94B6-0A9E-410C-B4FA-F89F4052084D")]
[NativeTypeName("struct IGpioChangeCounterFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGpioChangeCounterFactory : IGpioChangeCounterFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGpioChangeCounterFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounterFactory*, Guid*, void**, int>)(lpVtbl[0]))((IGpioChangeCounterFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounterFactory*, uint>)(lpVtbl[1]))((IGpioChangeCounterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounterFactory*, uint>)(lpVtbl[2]))((IGpioChangeCounterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounterFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IGpioChangeCounterFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounterFactory*, HSTRING*, int>)(lpVtbl[4]))((IGpioChangeCounterFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounterFactory*, TrustLevel*, int>)(lpVtbl[5]))((IGpioChangeCounterFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGpioChangeCounterFactory.xml' path='doc/member[@name="IGpioChangeCounterFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Devices::Gpio::IGpioPin *")] IGpioPin* pin, [NativeTypeName("ABI::Windows::Devices::Gpio::IGpioChangeCounter **")] IGpioChangeCounter** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounterFactory*, IGpioPin*, IGpioChangeCounter**, int>)(lpVtbl[6]))((IGpioChangeCounterFactory*)Unsafe.AsPointer(ref this), pin, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Devices::Gpio::IGpioPin *")] IGpioPin* pin, [NativeTypeName("ABI::Windows::Devices::Gpio::IGpioChangeCounter **")] IGpioChangeCounter** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::IGpioPin *, ABI::Windows::Devices::Gpio::IGpioChangeCounter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGpioPin*, IGpioChangeCounter**, int> Create;
    }
}
