// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGpioPinProvider.xml' path='doc/member[@name="IGpioPinProvider"]/*' />
[Guid("42344CB7-6ABC-40FF-9CE7-73B85301B900")]
[NativeTypeName("struct IGpioPinProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGpioPinProvider : IGpioPinProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGpioPinProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, Guid*, void**, int>)(lpVtbl[0]))((IGpioPinProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, uint>)(lpVtbl[1]))((IGpioPinProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, uint>)(lpVtbl[2]))((IGpioPinProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, uint*, Guid**, int>)(lpVtbl[3]))((IGpioPinProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, HSTRING*, int>)(lpVtbl[4]))((IGpioPinProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, TrustLevel*, int>)(lpVtbl[5]))((IGpioPinProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGpioPinProvider.xml' path='doc/member[@name="IGpioPinProvider.add_ValueChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ValueChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGpio__CProvider__CIGpioPinProvider_Windows__CDevices__CGpio__CProvider__CGpioPinProviderValueChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGpioPinProvider>, Pointer<IGpioPinProviderValueChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, ITypedEventHandler<Pointer<IGpioPinProvider>, Pointer<IGpioPinProviderValueChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IGpioPinProvider*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGpioPinProvider.xml' path='doc/member[@name="IGpioPinProvider.remove_ValueChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ValueChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, EventRegistrationToken, int>)(lpVtbl[7]))((IGpioPinProvider*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGpioPinProvider.xml' path='doc/member[@name="IGpioPinProvider.get_DebounceTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DebounceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, TimeSpan*, int>)(lpVtbl[8]))((IGpioPinProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioPinProvider.xml' path='doc/member[@name="IGpioPinProvider.put_DebounceTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DebounceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, TimeSpan, int>)(lpVtbl[9]))((IGpioPinProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioPinProvider.xml' path='doc/member[@name="IGpioPinProvider.get_PinNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PinNumber([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, int*, int>)(lpVtbl[10]))((IGpioPinProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioPinProvider.xml' path='doc/member[@name="IGpioPinProvider.get_SharingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SharingMode([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioSharingMode *")] ProviderGpioSharingMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, ProviderGpioSharingMode*, int>)(lpVtbl[11]))((IGpioPinProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioPinProvider.xml' path='doc/member[@name="IGpioPinProvider.IsDriveModeSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsDriveModeSupported([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode")] ProviderGpioPinDriveMode driveMode, [NativeTypeName("boolean *")] byte* supported)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, ProviderGpioPinDriveMode, byte*, int>)(lpVtbl[12]))((IGpioPinProvider*)Unsafe.AsPointer(ref this), driveMode, supported);
    }

    /// <include file='IGpioPinProvider.xml' path='doc/member[@name="IGpioPinProvider.GetDriveMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDriveMode([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode *")] ProviderGpioPinDriveMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, ProviderGpioPinDriveMode*, int>)(lpVtbl[13]))((IGpioPinProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioPinProvider.xml' path='doc/member[@name="IGpioPinProvider.SetDriveMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetDriveMode([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode")] ProviderGpioPinDriveMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, ProviderGpioPinDriveMode, int>)(lpVtbl[14]))((IGpioPinProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioPinProvider.xml' path='doc/member[@name="IGpioPinProvider.Write"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Write([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinValue")] ProviderGpioPinValue value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, ProviderGpioPinValue, int>)(lpVtbl[15]))((IGpioPinProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioPinProvider.xml' path='doc/member[@name="IGpioPinProvider.Read"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Read([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinValue *")] ProviderGpioPinValue* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProvider*, ProviderGpioPinValue*, int>)(lpVtbl[16]))((IGpioPinProvider*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ValueChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGpio__CProvider__CIGpioPinProvider_Windows__CDevices__CGpio__CProvider__CGpioPinProviderValueChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGpioPinProvider>, Pointer<IGpioPinProviderValueChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_ValueChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT get_DebounceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(9)]
        HRESULT put_DebounceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(10)]
        HRESULT get_PinNumber([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(11)]
        HRESULT get_SharingMode([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioSharingMode *")] ProviderGpioSharingMode* value);

        [VtblIndex(12)]
        HRESULT IsDriveModeSupported([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode")] ProviderGpioPinDriveMode driveMode, [NativeTypeName("boolean *")] byte* supported);

        [VtblIndex(13)]
        HRESULT GetDriveMode([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode *")] ProviderGpioPinDriveMode* value);

        [VtblIndex(14)]
        HRESULT SetDriveMode([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode")] ProviderGpioPinDriveMode value);

        [VtblIndex(15)]
        HRESULT Write([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinValue")] ProviderGpioPinValue value);

        [VtblIndex(16)]
        HRESULT Read([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinValue *")] ProviderGpioPinValue* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGpio__CProvider__CIGpioPinProvider_Windows__CDevices__CGpio__CProvider__CGpioPinProviderValueChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGpioPinProvider>, Pointer<IGpioPinProviderValueChangedEventArgs>>*, EventRegistrationToken*, int> add_ValueChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ValueChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_DebounceTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_DebounceTimeout;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_PinNumber;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::Provider::ProviderGpioSharingMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderGpioSharingMode*, int> get_SharingMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderGpioPinDriveMode, byte*, int> IsDriveModeSupported;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderGpioPinDriveMode*, int> GetDriveMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderGpioPinDriveMode, int> SetDriveMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinValue) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderGpioPinValue, int> Write;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinValue *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderGpioPinValue*, int> Read;
    }
}
