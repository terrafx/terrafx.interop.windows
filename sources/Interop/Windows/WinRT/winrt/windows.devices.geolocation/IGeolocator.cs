// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGeolocator.xml' path='doc/member[@name="IGeolocator"]/*' />
[Guid("A9C3BF62-4524-4989-8AA9-DE019D2E551F")]
[NativeTypeName("struct IGeolocator : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeolocator : IGeolocator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeolocator));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, Guid*, void**, int>)(lpVtbl[0]))((IGeolocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, uint>)(lpVtbl[1]))((IGeolocator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, uint>)(lpVtbl[2]))((IGeolocator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, uint*, Guid**, int>)(lpVtbl[3]))((IGeolocator*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, HSTRING*, int>)(lpVtbl[4]))((IGeolocator*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, TrustLevel*, int>)(lpVtbl[5]))((IGeolocator*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGeolocator.xml' path='doc/member[@name="IGeolocator.get_DesiredAccuracy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DesiredAccuracy([NativeTypeName("ABI::Windows::Devices::Geolocation::PositionAccuracy *")] PositionAccuracy* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, PositionAccuracy*, int>)(lpVtbl[6]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeolocator.xml' path='doc/member[@name="IGeolocator.put_DesiredAccuracy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DesiredAccuracy([NativeTypeName("ABI::Windows::Devices::Geolocation::PositionAccuracy")] PositionAccuracy value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, PositionAccuracy, int>)(lpVtbl[7]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeolocator.xml' path='doc/member[@name="IGeolocator.get_MovementThreshold"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MovementThreshold(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, double*, int>)(lpVtbl[8]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeolocator.xml' path='doc/member[@name="IGeolocator.put_MovementThreshold"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MovementThreshold(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, double, int>)(lpVtbl[9]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeolocator.xml' path='doc/member[@name="IGeolocator.get_ReportInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ReportInterval([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, uint*, int>)(lpVtbl[10]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeolocator.xml' path='doc/member[@name="IGeolocator.put_ReportInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ReportInterval([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, uint, int>)(lpVtbl[11]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeolocator.xml' path='doc/member[@name="IGeolocator.get_LocationStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_LocationStatus([NativeTypeName("ABI::Windows::Devices::Geolocation::PositionStatus *")] PositionStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, PositionStatus*, int>)(lpVtbl[12]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeolocator.xml' path='doc/member[@name="IGeolocator.GetGeopositionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetGeopositionAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeoposition_t **")] IAsyncOperation<Pointer<IGeoposition>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, IAsyncOperation<Pointer<IGeoposition>>**, int>)(lpVtbl[13]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeolocator.xml' path='doc/member[@name="IGeolocator.GetGeopositionAsyncWithAgeAndTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetGeopositionAsyncWithAgeAndTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan maximumAge, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timeout, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeoposition_t **")] IAsyncOperation<Pointer<IGeoposition>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, TimeSpan, TimeSpan, IAsyncOperation<Pointer<IGeoposition>>**, int>)(lpVtbl[14]))((IGeolocator*)Unsafe.AsPointer(ref this), maximumAge, timeout, value);
    }

    /// <include file='IGeolocator.xml' path='doc/member[@name="IGeolocator.add_PositionChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_PositionChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGeolocation__CGeolocator_Windows__CDevices__CGeolocation__CPositionChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGeolocator>, Pointer<IPositionChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, ITypedEventHandler<Pointer<IGeolocator>, Pointer<IPositionChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IGeolocator*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGeolocator.xml' path='doc/member[@name="IGeolocator.remove_PositionChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_PositionChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, EventRegistrationToken, int>)(lpVtbl[16]))((IGeolocator*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGeolocator.xml' path='doc/member[@name="IGeolocator.add_StatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_StatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGeolocation__CGeolocator_Windows__CDevices__CGeolocation__CStatusChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGeolocator>, Pointer<IStatusChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, ITypedEventHandler<Pointer<IGeolocator>, Pointer<IStatusChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[17]))((IGeolocator*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGeolocator.xml' path='doc/member[@name="IGeolocator.remove_StatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_StatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocator*, EventRegistrationToken, int>)(lpVtbl[18]))((IGeolocator*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DesiredAccuracy([NativeTypeName("ABI::Windows::Devices::Geolocation::PositionAccuracy *")] PositionAccuracy* value);

        [VtblIndex(7)]
        HRESULT put_DesiredAccuracy([NativeTypeName("ABI::Windows::Devices::Geolocation::PositionAccuracy")] PositionAccuracy value);

        [VtblIndex(8)]
        HRESULT get_MovementThreshold(double* value);

        [VtblIndex(9)]
        HRESULT put_MovementThreshold(double value);

        [VtblIndex(10)]
        HRESULT get_ReportInterval([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT put_ReportInterval([NativeTypeName("UINT32")] uint value);

        [VtblIndex(12)]
        HRESULT get_LocationStatus([NativeTypeName("ABI::Windows::Devices::Geolocation::PositionStatus *")] PositionStatus* value);

        [VtblIndex(13)]
        HRESULT GetGeopositionAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeoposition_t **")] IAsyncOperation<Pointer<IGeoposition>>** value);

        [VtblIndex(14)]
        HRESULT GetGeopositionAsyncWithAgeAndTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan maximumAge, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timeout, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeoposition_t **")] IAsyncOperation<Pointer<IGeoposition>>** value);

        [VtblIndex(15)]
        HRESULT add_PositionChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGeolocation__CGeolocator_Windows__CDevices__CGeolocation__CPositionChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGeolocator>, Pointer<IPositionChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(16)]
        HRESULT remove_PositionChanged(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT add_StatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGeolocation__CGeolocator_Windows__CDevices__CGeolocation__CStatusChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGeolocator>, Pointer<IStatusChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(18)]
        HRESULT remove_StatusChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::PositionAccuracy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PositionAccuracy*, int> get_DesiredAccuracy;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::PositionAccuracy) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PositionAccuracy, int> put_DesiredAccuracy;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MovementThreshold;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_MovementThreshold;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ReportInterval;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_ReportInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::PositionStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PositionStatus*, int> get_LocationStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeoposition_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IGeoposition>>**, int> GetGeopositionAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeoposition_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, TimeSpan, IAsyncOperation<Pointer<IGeoposition>>**, int> GetGeopositionAsyncWithAgeAndTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGeolocation__CGeolocator_Windows__CDevices__CGeolocation__CPositionChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGeolocator>, Pointer<IPositionChangedEventArgs>>*, EventRegistrationToken*, int> add_PositionChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PositionChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGeolocation__CGeolocator_Windows__CDevices__CGeolocation__CStatusChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGeolocator>, Pointer<IStatusChangedEventArgs>>*, EventRegistrationToken*, int> add_StatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StatusChanged;
    }
}
