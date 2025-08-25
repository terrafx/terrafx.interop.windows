// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGpioPin.xml' path='doc/member[@name="IGpioPin"]/*' />
[Guid("11D9B087-AFAE-4790-9EE9-E0EAC942D201")]
[NativeTypeName("struct IGpioPin : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGpioPin : IGpioPin.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGpioPin);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, Guid*, void**, int>)(lpVtbl[0]))((IGpioPin*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, uint>)(lpVtbl[1]))((IGpioPin*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, uint>)(lpVtbl[2]))((IGpioPin*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, uint*, Guid**, int>)(lpVtbl[3]))((IGpioPin*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, HSTRING*, int>)(lpVtbl[4]))((IGpioPin*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, TrustLevel*, int>)(lpVtbl[5]))((IGpioPin*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGpioPin.xml' path='doc/member[@name="IGpioPin.add_ValueChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ValueChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGpio__CGpioPin_Windows__CDevices__CGpio__CGpioPinValueChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGpioPin>, Pointer<IGpioPinValueChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, ITypedEventHandler<Pointer<IGpioPin>, Pointer<IGpioPinValueChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IGpioPin*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGpioPin.xml' path='doc/member[@name="IGpioPin.remove_ValueChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ValueChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, EventRegistrationToken, int>)(lpVtbl[7]))((IGpioPin*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGpioPin.xml' path='doc/member[@name="IGpioPin.get_DebounceTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DebounceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, TimeSpan*, int>)(lpVtbl[8]))((IGpioPin*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioPin.xml' path='doc/member[@name="IGpioPin.put_DebounceTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DebounceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, TimeSpan, int>)(lpVtbl[9]))((IGpioPin*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioPin.xml' path='doc/member[@name="IGpioPin.get_PinNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PinNumber([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, int*, int>)(lpVtbl[10]))((IGpioPin*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioPin.xml' path='doc/member[@name="IGpioPin.get_SharingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SharingMode([NativeTypeName("ABI::Windows::Devices::Gpio::GpioSharingMode *")] GpioSharingMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, GpioSharingMode*, int>)(lpVtbl[11]))((IGpioPin*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioPin.xml' path='doc/member[@name="IGpioPin.IsDriveModeSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsDriveModeSupported([NativeTypeName("ABI::Windows::Devices::Gpio::GpioPinDriveMode")] GpioPinDriveMode driveMode, [NativeTypeName("boolean *")] byte* supported)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, GpioPinDriveMode, byte*, int>)(lpVtbl[12]))((IGpioPin*)Unsafe.AsPointer(ref this), driveMode, supported);
    }

    /// <include file='IGpioPin.xml' path='doc/member[@name="IGpioPin.GetDriveMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDriveMode([NativeTypeName("ABI::Windows::Devices::Gpio::GpioPinDriveMode *")] GpioPinDriveMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, GpioPinDriveMode*, int>)(lpVtbl[13]))((IGpioPin*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioPin.xml' path='doc/member[@name="IGpioPin.SetDriveMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetDriveMode([NativeTypeName("ABI::Windows::Devices::Gpio::GpioPinDriveMode")] GpioPinDriveMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, GpioPinDriveMode, int>)(lpVtbl[14]))((IGpioPin*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioPin.xml' path='doc/member[@name="IGpioPin.Write"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Write([NativeTypeName("ABI::Windows::Devices::Gpio::GpioPinValue")] GpioPinValue value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, GpioPinValue, int>)(lpVtbl[15]))((IGpioPin*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioPin.xml' path='doc/member[@name="IGpioPin.Read"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Read([NativeTypeName("ABI::Windows::Devices::Gpio::GpioPinValue *")] GpioPinValue* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPin*, GpioPinValue*, int>)(lpVtbl[16]))((IGpioPin*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ValueChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGpio__CGpioPin_Windows__CDevices__CGpio__CGpioPinValueChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGpioPin>, Pointer<IGpioPinValueChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_ValueChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT get_DebounceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(9)]
        HRESULT put_DebounceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(10)]
        HRESULT get_PinNumber([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(11)]
        HRESULT get_SharingMode([NativeTypeName("ABI::Windows::Devices::Gpio::GpioSharingMode *")] GpioSharingMode* value);

        [VtblIndex(12)]
        HRESULT IsDriveModeSupported([NativeTypeName("ABI::Windows::Devices::Gpio::GpioPinDriveMode")] GpioPinDriveMode driveMode, [NativeTypeName("boolean *")] byte* supported);

        [VtblIndex(13)]
        HRESULT GetDriveMode([NativeTypeName("ABI::Windows::Devices::Gpio::GpioPinDriveMode *")] GpioPinDriveMode* value);

        [VtblIndex(14)]
        HRESULT SetDriveMode([NativeTypeName("ABI::Windows::Devices::Gpio::GpioPinDriveMode")] GpioPinDriveMode value);

        [VtblIndex(15)]
        HRESULT Write([NativeTypeName("ABI::Windows::Devices::Gpio::GpioPinValue")] GpioPinValue value);

        [VtblIndex(16)]
        HRESULT Read([NativeTypeName("ABI::Windows::Devices::Gpio::GpioPinValue *")] GpioPinValue* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGpio__CGpioPin_Windows__CDevices__CGpio__CGpioPinValueChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGpioPin>, Pointer<IGpioPinValueChangedEventArgs>>*, EventRegistrationToken*, int> add_ValueChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ValueChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_DebounceTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_DebounceTimeout;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_PinNumber;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::GpioSharingMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GpioSharingMode*, int> get_SharingMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::GpioPinDriveMode, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GpioPinDriveMode, byte*, int> IsDriveModeSupported;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::GpioPinDriveMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GpioPinDriveMode*, int> GetDriveMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::GpioPinDriveMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GpioPinDriveMode, int> SetDriveMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::GpioPinValue) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GpioPinValue, int> Write;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::GpioPinValue *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GpioPinValue*, int> Read;
    }
}
