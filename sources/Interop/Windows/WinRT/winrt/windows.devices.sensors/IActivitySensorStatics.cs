// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IActivitySensorStatics.xml' path='doc/member[@name="IActivitySensorStatics"]/*' />
[Guid("A71E0E9D-EE8B-45D1-B25B-08CC0DF92AB6")]
[NativeTypeName("struct IActivitySensorStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IActivitySensorStatics : IActivitySensorStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IActivitySensorStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorStatics*, Guid*, void**, int>)(lpVtbl[0]))((IActivitySensorStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorStatics*, uint>)(lpVtbl[1]))((IActivitySensorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorStatics*, uint>)(lpVtbl[2]))((IActivitySensorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IActivitySensorStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorStatics*, HSTRING*, int>)(lpVtbl[4]))((IActivitySensorStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorStatics*, TrustLevel*, int>)(lpVtbl[5]))((IActivitySensorStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IActivitySensorStatics.xml' path='doc/member[@name="IActivitySensorStatics.GetDefaultAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefaultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CActivitySensor_t **")] IAsyncOperation<Pointer<IActivitySensor>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorStatics*, IAsyncOperation<Pointer<IActivitySensor>>**, int>)(lpVtbl[6]))((IActivitySensorStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IActivitySensorStatics.xml' path='doc/member[@name="IActivitySensorStatics.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelector(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorStatics*, HSTRING*, int>)(lpVtbl[7]))((IActivitySensorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActivitySensorStatics.xml' path='doc/member[@name="IActivitySensorStatics.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CActivitySensor_t **")] IAsyncOperation<Pointer<IActivitySensor>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorStatics*, HSTRING, IAsyncOperation<Pointer<IActivitySensor>>**, int>)(lpVtbl[8]))((IActivitySensorStatics*)Unsafe.AsPointer(ref this), deviceId, result);
    }

    /// <include file='IActivitySensorStatics.xml' path='doc/member[@name="IActivitySensorStatics.GetSystemHistoryAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSystemHistoryAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime fromTime, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSensors__CActivitySensorReading_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IActivitySensorReading>>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorStatics*, WinRTDateTime, IAsyncOperation<Pointer<IVectorView<Pointer<IActivitySensorReading>>>>**, int>)(lpVtbl[9]))((IActivitySensorStatics*)Unsafe.AsPointer(ref this), fromTime, result);
    }

    /// <include file='IActivitySensorStatics.xml' path='doc/member[@name="IActivitySensorStatics.GetSystemHistoryWithDurationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetSystemHistoryWithDurationAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime fromTime, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan duration, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSensors__CActivitySensorReading_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IActivitySensorReading>>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorStatics*, WinRTDateTime, TimeSpan, IAsyncOperation<Pointer<IVectorView<Pointer<IActivitySensorReading>>>>**, int>)(lpVtbl[10]))((IActivitySensorStatics*)Unsafe.AsPointer(ref this), fromTime, duration, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDefaultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CActivitySensor_t **")] IAsyncOperation<Pointer<IActivitySensor>>** result);

        [VtblIndex(7)]
        HRESULT GetDeviceSelector(HSTRING* value);

        [VtblIndex(8)]
        HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CActivitySensor_t **")] IAsyncOperation<Pointer<IActivitySensor>>** result);

        [VtblIndex(9)]
        HRESULT GetSystemHistoryAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime fromTime, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSensors__CActivitySensorReading_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IActivitySensorReading>>>>** result);

        [VtblIndex(10)]
        HRESULT GetSystemHistoryWithDurationAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime fromTime, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan duration, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSensors__CActivitySensorReading_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IActivitySensorReading>>>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CActivitySensor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IActivitySensor>>**, int> GetDefaultAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetDeviceSelector;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CActivitySensor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IActivitySensor>>**, int> FromIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSensors__CActivitySensorReading_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, IAsyncOperation<Pointer<IVectorView<Pointer<IActivitySensorReading>>>>**, int> GetSystemHistoryAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSensors__CActivitySensorReading_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, TimeSpan, IAsyncOperation<Pointer<IVectorView<Pointer<IActivitySensorReading>>>>**, int> GetSystemHistoryWithDurationAsync;
    }
}
