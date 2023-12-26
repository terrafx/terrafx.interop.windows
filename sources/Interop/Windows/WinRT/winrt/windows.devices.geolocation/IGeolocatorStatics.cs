// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGeolocatorStatics.xml' path='doc/member[@name="IGeolocatorStatics"]/*' />
[Guid("9A8E7571-2DF5-4591-9F87-EB5FD894E9B7")]
[NativeTypeName("struct IGeolocatorStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeolocatorStatics : IGeolocatorStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeolocatorStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics*, uint>)(lpVtbl[1]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics*, uint>)(lpVtbl[2]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics*, HSTRING*, int>)(lpVtbl[4]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGeolocatorStatics.xml' path='doc/member[@name="IGeolocatorStatics.RequestAccessAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeolocationAccessStatus_t **")] IAsyncOperation<GeolocationAccessStatus>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics*, IAsyncOperation<GeolocationAccessStatus>**, int>)(lpVtbl[6]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IGeolocatorStatics.xml' path='doc/member[@name="IGeolocatorStatics.GetGeopositionHistoryAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetGeopositionHistoryAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CGeolocation__CGeoposition_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics*, WinRTDateTime, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this), startTime, result);
    }

    /// <include file='IGeolocatorStatics.xml' path='doc/member[@name="IGeolocatorStatics.GetGeopositionHistoryWithDurationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetGeopositionHistoryWithDurationAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan duration, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CGeolocation__CGeoposition_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics*, WinRTDateTime, TimeSpan, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this), startTime, duration, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeolocationAccessStatus_t **")] IAsyncOperation<GeolocationAccessStatus>** result);

        [VtblIndex(7)]
        HRESULT GetGeopositionHistoryAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CGeolocation__CGeoposition_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(8)]
        HRESULT GetGeopositionHistoryWithDurationAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan duration, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CGeolocation__CGeoposition_t **")] IAsyncOperation<IntPtr>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeolocationAccessStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<GeolocationAccessStatus>**, int> RequestAccessAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CGeolocation__CGeoposition_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, IAsyncOperation<IntPtr>**, int> GetGeopositionHistoryAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CGeolocation__CGeoposition_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, TimeSpan, IAsyncOperation<IntPtr>**, int> GetGeopositionHistoryWithDurationAsync;
    }
}
