// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IActivitySensor.xml' path='doc/member[@name="IActivitySensor"]/*' />
[Guid("CD7A630C-FB5F-48EB-B09B-A2708D1C61EF")]
[NativeTypeName("struct IActivitySensor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IActivitySensor : IActivitySensor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActivitySensor));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensor*, Guid*, void**, int>)(lpVtbl[0]))((IActivitySensor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensor*, uint>)(lpVtbl[1]))((IActivitySensor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensor*, uint>)(lpVtbl[2]))((IActivitySensor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensor*, uint*, Guid**, int>)(lpVtbl[3]))((IActivitySensor*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensor*, HSTRING*, int>)(lpVtbl[4]))((IActivitySensor*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensor*, TrustLevel*, int>)(lpVtbl[5]))((IActivitySensor*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IActivitySensor.xml' path='doc/member[@name="IActivitySensor.GetCurrentReadingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentReadingAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CActivitySensorReading_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensor*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IActivitySensor*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IActivitySensor.xml' path='doc/member[@name="IActivitySensor.get_SubscribedActivities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SubscribedActivities([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CSensors__CActivityType_t **")] IVector<ActivityType>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensor*, IVector<ActivityType>**, int>)(lpVtbl[7]))((IActivitySensor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActivitySensor.xml' path='doc/member[@name="IActivitySensor.get_PowerInMilliwatts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PowerInMilliwatts(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensor*, double*, int>)(lpVtbl[8]))((IActivitySensor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActivitySensor.xml' path='doc/member[@name="IActivitySensor.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensor*, HSTRING*, int>)(lpVtbl[9]))((IActivitySensor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActivitySensor.xml' path='doc/member[@name="IActivitySensor.get_SupportedActivities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SupportedActivities([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSensors__CActivityType_t **")] IVectorView<ActivityType>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensor*, IVectorView<ActivityType>**, int>)(lpVtbl[10]))((IActivitySensor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActivitySensor.xml' path='doc/member[@name="IActivitySensor.get_MinimumReportInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MinimumReportInterval([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensor*, uint*, int>)(lpVtbl[11]))((IActivitySensor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActivitySensor.xml' path='doc/member[@name="IActivitySensor.add_ReadingChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_ReadingChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CActivitySensor_Windows__CDevices__CSensors__CActivitySensorReadingChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensor*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IActivitySensor*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IActivitySensor.xml' path='doc/member[@name="IActivitySensor.remove_ReadingChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_ReadingChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensor*, EventRegistrationToken, int>)(lpVtbl[13]))((IActivitySensor*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCurrentReadingAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CActivitySensorReading_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(7)]
        HRESULT get_SubscribedActivities([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CSensors__CActivityType_t **")] IVector<ActivityType>** value);

        [VtblIndex(8)]
        HRESULT get_PowerInMilliwatts(double* value);

        [VtblIndex(9)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_SupportedActivities([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSensors__CActivityType_t **")] IVectorView<ActivityType>** value);

        [VtblIndex(11)]
        HRESULT get_MinimumReportInterval([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT add_ReadingChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CActivitySensor_Windows__CDevices__CSensors__CActivitySensorReadingChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CActivitySensorReading_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> GetCurrentReadingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CSensors__CActivityType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<ActivityType>**, int> get_SubscribedActivities;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_PowerInMilliwatts;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSensors__CActivityType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<ActivityType>**, int> get_SupportedActivities;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MinimumReportInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CActivitySensor_Windows__CDevices__CSensors__CActivitySensorReadingChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ReadingChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ReadingChanged;
    }
}
