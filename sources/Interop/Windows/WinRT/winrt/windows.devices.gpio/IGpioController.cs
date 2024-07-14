// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGpioController.xml' path='doc/member[@name="IGpioController"]/*' />
[Guid("284012E3-7461-469C-A8BC-61D69D08A53C")]
[NativeTypeName("struct IGpioController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGpioController : IGpioController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGpioController));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioController*, Guid*, void**, int>)(lpVtbl[0]))((IGpioController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioController*, uint>)(lpVtbl[1]))((IGpioController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioController*, uint>)(lpVtbl[2]))((IGpioController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioController*, uint*, Guid**, int>)(lpVtbl[3]))((IGpioController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioController*, HSTRING*, int>)(lpVtbl[4]))((IGpioController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioController*, TrustLevel*, int>)(lpVtbl[5]))((IGpioController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGpioController.xml' path='doc/member[@name="IGpioController.get_PinCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PinCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioController*, int*, int>)(lpVtbl[6]))((IGpioController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioController.xml' path='doc/member[@name="IGpioController.OpenPin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OpenPin([NativeTypeName("INT32")] int pinNumber, [NativeTypeName("ABI::Windows::Devices::Gpio::IGpioPin **")] IGpioPin** pin)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioController*, int, IGpioPin**, int>)(lpVtbl[7]))((IGpioController*)Unsafe.AsPointer(ref this), pinNumber, pin);
    }

    /// <include file='IGpioController.xml' path='doc/member[@name="IGpioController.OpenPinWithSharingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OpenPinWithSharingMode([NativeTypeName("INT32")] int pinNumber, [NativeTypeName("ABI::Windows::Devices::Gpio::GpioSharingMode")] GpioSharingMode sharingMode, [NativeTypeName("ABI::Windows::Devices::Gpio::IGpioPin **")] IGpioPin** pin)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioController*, int, GpioSharingMode, IGpioPin**, int>)(lpVtbl[8]))((IGpioController*)Unsafe.AsPointer(ref this), pinNumber, sharingMode, pin);
    }

    /// <include file='IGpioController.xml' path='doc/member[@name="IGpioController.TryOpenPin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TryOpenPin([NativeTypeName("INT32")] int pinNumber, [NativeTypeName("ABI::Windows::Devices::Gpio::GpioSharingMode")] GpioSharingMode sharingMode, [NativeTypeName("ABI::Windows::Devices::Gpio::IGpioPin **")] IGpioPin** pin, [NativeTypeName("ABI::Windows::Devices::Gpio::GpioOpenStatus *")] GpioOpenStatus* openStatus, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioController*, int, GpioSharingMode, IGpioPin**, GpioOpenStatus*, byte*, int>)(lpVtbl[9]))((IGpioController*)Unsafe.AsPointer(ref this), pinNumber, sharingMode, pin, openStatus, succeeded);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PinCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT OpenPin([NativeTypeName("INT32")] int pinNumber, [NativeTypeName("ABI::Windows::Devices::Gpio::IGpioPin **")] IGpioPin** pin);

        [VtblIndex(8)]
        HRESULT OpenPinWithSharingMode([NativeTypeName("INT32")] int pinNumber, [NativeTypeName("ABI::Windows::Devices::Gpio::GpioSharingMode")] GpioSharingMode sharingMode, [NativeTypeName("ABI::Windows::Devices::Gpio::IGpioPin **")] IGpioPin** pin);

        [VtblIndex(9)]
        HRESULT TryOpenPin([NativeTypeName("INT32")] int pinNumber, [NativeTypeName("ABI::Windows::Devices::Gpio::GpioSharingMode")] GpioSharingMode sharingMode, [NativeTypeName("ABI::Windows::Devices::Gpio::IGpioPin **")] IGpioPin** pin, [NativeTypeName("ABI::Windows::Devices::Gpio::GpioOpenStatus *")] GpioOpenStatus* openStatus, [NativeTypeName("boolean *")] byte* succeeded);
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

        [NativeTypeName("HRESULT (INT32, ABI::Windows::Devices::Gpio::IGpioPin **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IGpioPin**, int> OpenPin;

        [NativeTypeName("HRESULT (INT32, ABI::Windows::Devices::Gpio::GpioSharingMode, ABI::Windows::Devices::Gpio::IGpioPin **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, GpioSharingMode, IGpioPin**, int> OpenPinWithSharingMode;

        [NativeTypeName("HRESULT (INT32, ABI::Windows::Devices::Gpio::GpioSharingMode, ABI::Windows::Devices::Gpio::IGpioPin **, ABI::Windows::Devices::Gpio::GpioOpenStatus *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, GpioSharingMode, IGpioPin**, GpioOpenStatus*, byte*, int> TryOpenPin;
    }
}
