// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHingeAngleSensor.xml' path='doc/member[@name="IHingeAngleSensor"]/*' />
[Guid("E9D3BE02-BFDF-437F-8C29-88C77393D309")]
[NativeTypeName("struct IHingeAngleSensor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHingeAngleSensor : IHingeAngleSensor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHingeAngleSensor));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensor*, Guid*, void**, int>)(lpVtbl[0]))((IHingeAngleSensor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensor*, uint>)(lpVtbl[1]))((IHingeAngleSensor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensor*, uint>)(lpVtbl[2]))((IHingeAngleSensor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensor*, uint*, Guid**, int>)(lpVtbl[3]))((IHingeAngleSensor*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensor*, HSTRING*, int>)(lpVtbl[4]))((IHingeAngleSensor*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensor*, TrustLevel*, int>)(lpVtbl[5]))((IHingeAngleSensor*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHingeAngleSensor.xml' path='doc/member[@name="IHingeAngleSensor.GetCurrentReadingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentReadingAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHingeAngleReading_t **")] IAsyncOperation<Pointer<IHingeAngleReading>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensor*, IAsyncOperation<Pointer<IHingeAngleReading>>**, int>)(lpVtbl[6]))((IHingeAngleSensor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHingeAngleSensor.xml' path='doc/member[@name="IHingeAngleSensor.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensor*, HSTRING*, int>)(lpVtbl[7]))((IHingeAngleSensor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHingeAngleSensor.xml' path='doc/member[@name="IHingeAngleSensor.get_MinReportThresholdInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinReportThresholdInDegrees(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensor*, double*, int>)(lpVtbl[8]))((IHingeAngleSensor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHingeAngleSensor.xml' path='doc/member[@name="IHingeAngleSensor.get_ReportThresholdInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ReportThresholdInDegrees(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensor*, double*, int>)(lpVtbl[9]))((IHingeAngleSensor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHingeAngleSensor.xml' path='doc/member[@name="IHingeAngleSensor.put_ReportThresholdInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ReportThresholdInDegrees(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensor*, double, int>)(lpVtbl[10]))((IHingeAngleSensor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHingeAngleSensor.xml' path='doc/member[@name="IHingeAngleSensor.add_ReadingChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_ReadingChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CHingeAngleSensor_Windows__CDevices__CSensors__CHingeAngleSensorReadingChangedEventArgs_t *")] ITypedEventHandler<Pointer<IHingeAngleSensor>, Pointer<IHingeAngleSensorReadingChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensor*, ITypedEventHandler<Pointer<IHingeAngleSensor>, Pointer<IHingeAngleSensorReadingChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IHingeAngleSensor*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IHingeAngleSensor.xml' path='doc/member[@name="IHingeAngleSensor.remove_ReadingChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_ReadingChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensor*, EventRegistrationToken, int>)(lpVtbl[12]))((IHingeAngleSensor*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCurrentReadingAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHingeAngleReading_t **")] IAsyncOperation<Pointer<IHingeAngleReading>>** value);

        [VtblIndex(7)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_MinReportThresholdInDegrees(double* value);

        [VtblIndex(9)]
        HRESULT get_ReportThresholdInDegrees(double* value);

        [VtblIndex(10)]
        HRESULT put_ReportThresholdInDegrees(double value);

        [VtblIndex(11)]
        HRESULT add_ReadingChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CHingeAngleSensor_Windows__CDevices__CSensors__CHingeAngleSensorReadingChangedEventArgs_t *")] ITypedEventHandler<Pointer<IHingeAngleSensor>, Pointer<IHingeAngleSensorReadingChangedEventArgs>>* handler, EventRegistrationToken* token);

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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHingeAngleReading_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IHingeAngleReading>>**, int> GetCurrentReadingAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MinReportThresholdInDegrees;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_ReportThresholdInDegrees;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_ReportThresholdInDegrees;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CHingeAngleSensor_Windows__CDevices__CSensors__CHingeAngleSensorReadingChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IHingeAngleSensor>, Pointer<IHingeAngleSensorReadingChangedEventArgs>>*, EventRegistrationToken*, int> add_ReadingChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ReadingChanged;
    }
}
