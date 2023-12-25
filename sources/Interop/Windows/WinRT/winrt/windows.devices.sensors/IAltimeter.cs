// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAltimeter.xml' path='doc/member[@name="IAltimeter"]/*' />
[Guid("72F057FD-8F04-49F1-B4A7-F4E363B701A2")]
[NativeTypeName("struct IAltimeter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAltimeter : IAltimeter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAltimeter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAltimeter*, Guid*, void**, int>)(lpVtbl[0]))((IAltimeter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAltimeter*, uint>)(lpVtbl[1]))((IAltimeter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAltimeter*, uint>)(lpVtbl[2]))((IAltimeter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAltimeter*, uint*, Guid**, int>)(lpVtbl[3]))((IAltimeter*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAltimeter*, HSTRING*, int>)(lpVtbl[4]))((IAltimeter*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAltimeter*, TrustLevel*, int>)(lpVtbl[5]))((IAltimeter*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAltimeter.xml' path='doc/member[@name="IAltimeter.GetCurrentReading"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentReading([NativeTypeName("ABI::Windows::Devices::Sensors::IAltimeterReading **")] IAltimeterReading** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAltimeter*, IAltimeterReading**, int>)(lpVtbl[6]))((IAltimeter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAltimeter.xml' path='doc/member[@name="IAltimeter.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAltimeter*, HSTRING*, int>)(lpVtbl[7]))((IAltimeter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAltimeter.xml' path='doc/member[@name="IAltimeter.get_MinimumReportInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinimumReportInterval([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAltimeter*, uint*, int>)(lpVtbl[8]))((IAltimeter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAltimeter.xml' path='doc/member[@name="IAltimeter.put_ReportInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ReportInterval([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAltimeter*, uint, int>)(lpVtbl[9]))((IAltimeter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAltimeter.xml' path='doc/member[@name="IAltimeter.get_ReportInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ReportInterval([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAltimeter*, uint*, int>)(lpVtbl[10]))((IAltimeter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAltimeter.xml' path='doc/member[@name="IAltimeter.add_ReadingChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_ReadingChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CAltimeter_Windows__CDevices__CSensors__CAltimeterReadingChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAltimeter*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IAltimeter*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAltimeter.xml' path='doc/member[@name="IAltimeter.remove_ReadingChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_ReadingChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAltimeter*, EventRegistrationToken, int>)(lpVtbl[12]))((IAltimeter*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCurrentReading([NativeTypeName("ABI::Windows::Devices::Sensors::IAltimeterReading **")] IAltimeterReading** value);

        [VtblIndex(7)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_MinimumReportInterval([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT put_ReportInterval([NativeTypeName("UINT32")] uint value);

        [VtblIndex(10)]
        HRESULT get_ReportInterval([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT add_ReadingChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CAltimeter_Windows__CDevices__CSensors__CAltimeterReadingChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_ReadingChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IAltimeterReading **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAltimeterReading**, int> GetCurrentReading;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MinimumReportInterval;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_ReportInterval;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ReportInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CAltimeter_Windows__CDevices__CSensors__CAltimeterReadingChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ReadingChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ReadingChanged;
    }
}
