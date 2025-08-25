// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHumanPresenceSettingsStatics.xml' path='doc/member[@name="IHumanPresenceSettingsStatics"]/*' />
[Guid("7F343202-E010-52C4-AF0C-04A8F1E033DA")]
[NativeTypeName("struct IHumanPresenceSettingsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHumanPresenceSettingsStatics : IHumanPresenceSettingsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHumanPresenceSettingsStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettingsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IHumanPresenceSettingsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettingsStatics*, uint>)(lpVtbl[1]))((IHumanPresenceSettingsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettingsStatics*, uint>)(lpVtbl[2]))((IHumanPresenceSettingsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettingsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IHumanPresenceSettingsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettingsStatics*, HSTRING*, int>)(lpVtbl[4]))((IHumanPresenceSettingsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettingsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IHumanPresenceSettingsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHumanPresenceSettingsStatics.xml' path='doc/member[@name="IHumanPresenceSettingsStatics.GetCurrentSettingsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentSettingsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHumanPresenceSettings_t **")] IAsyncOperation<Pointer<IHumanPresenceSettings>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettingsStatics*, IAsyncOperation<Pointer<IHumanPresenceSettings>>**, int>)(lpVtbl[6]))((IHumanPresenceSettingsStatics*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IHumanPresenceSettingsStatics.xml' path='doc/member[@name="IHumanPresenceSettingsStatics.GetCurrentSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCurrentSettings([NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSettings **")] IHumanPresenceSettings** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettingsStatics*, IHumanPresenceSettings**, int>)(lpVtbl[7]))((IHumanPresenceSettingsStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IHumanPresenceSettingsStatics.xml' path='doc/member[@name="IHumanPresenceSettingsStatics.UpdateSettingsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UpdateSettingsAsync([NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSettings *")] IHumanPresenceSettings* settings, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettingsStatics*, IHumanPresenceSettings*, IAsyncAction**, int>)(lpVtbl[8]))((IHumanPresenceSettingsStatics*)Unsafe.AsPointer(ref this), settings, operation);
    }

    /// <include file='IHumanPresenceSettingsStatics.xml' path='doc/member[@name="IHumanPresenceSettingsStatics.UpdateSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UpdateSettings([NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSettings *")] IHumanPresenceSettings* settings)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettingsStatics*, IHumanPresenceSettings*, int>)(lpVtbl[9]))((IHumanPresenceSettingsStatics*)Unsafe.AsPointer(ref this), settings);
    }

    /// <include file='IHumanPresenceSettingsStatics.xml' path='doc/member[@name="IHumanPresenceSettingsStatics.GetSupportedFeaturesForSensorIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetSupportedFeaturesForSensorIdAsync(HSTRING sensorId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHumanPresenceFeatures_t **")] IAsyncOperation<Pointer<IHumanPresenceFeatures>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettingsStatics*, HSTRING, IAsyncOperation<Pointer<IHumanPresenceFeatures>>**, int>)(lpVtbl[10]))((IHumanPresenceSettingsStatics*)Unsafe.AsPointer(ref this), sensorId, operation);
    }

    /// <include file='IHumanPresenceSettingsStatics.xml' path='doc/member[@name="IHumanPresenceSettingsStatics.GetSupportedFeaturesForSensorId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSupportedFeaturesForSensorId(HSTRING sensorId, [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceFeatures **")] IHumanPresenceFeatures** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettingsStatics*, HSTRING, IHumanPresenceFeatures**, int>)(lpVtbl[11]))((IHumanPresenceSettingsStatics*)Unsafe.AsPointer(ref this), sensorId, result);
    }

    /// <include file='IHumanPresenceSettingsStatics.xml' path='doc/member[@name="IHumanPresenceSettingsStatics.GetSupportedLockOnLeaveTimeouts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetSupportedLockOnLeaveTimeouts([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CTimeSpan_t **")] IVectorView<TimeSpan>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettingsStatics*, IVectorView<TimeSpan>**, int>)(lpVtbl[12]))((IHumanPresenceSettingsStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IHumanPresenceSettingsStatics.xml' path='doc/member[@name="IHumanPresenceSettingsStatics.add_SettingsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_SettingsChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettingsStatics*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IHumanPresenceSettingsStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IHumanPresenceSettingsStatics.xml' path='doc/member[@name="IHumanPresenceSettingsStatics.remove_SettingsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_SettingsChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettingsStatics*, EventRegistrationToken, int>)(lpVtbl[14]))((IHumanPresenceSettingsStatics*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCurrentSettingsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHumanPresenceSettings_t **")] IAsyncOperation<Pointer<IHumanPresenceSettings>>** operation);

        [VtblIndex(7)]
        HRESULT GetCurrentSettings([NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSettings **")] IHumanPresenceSettings** result);

        [VtblIndex(8)]
        HRESULT UpdateSettingsAsync([NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSettings *")] IHumanPresenceSettings* settings, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(9)]
        HRESULT UpdateSettings([NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSettings *")] IHumanPresenceSettings* settings);

        [VtblIndex(10)]
        HRESULT GetSupportedFeaturesForSensorIdAsync(HSTRING sensorId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHumanPresenceFeatures_t **")] IAsyncOperation<Pointer<IHumanPresenceFeatures>>** operation);

        [VtblIndex(11)]
        HRESULT GetSupportedFeaturesForSensorId(HSTRING sensorId, [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceFeatures **")] IHumanPresenceFeatures** result);

        [VtblIndex(12)]
        HRESULT GetSupportedLockOnLeaveTimeouts([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CTimeSpan_t **")] IVectorView<TimeSpan>** result);

        [VtblIndex(13)]
        HRESULT add_SettingsChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_SettingsChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHumanPresenceSettings_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IHumanPresenceSettings>>**, int> GetCurrentSettingsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IHumanPresenceSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHumanPresenceSettings**, int> GetCurrentSettings;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IHumanPresenceSettings *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHumanPresenceSettings*, IAsyncAction**, int> UpdateSettingsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IHumanPresenceSettings *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHumanPresenceSettings*, int> UpdateSettings;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHumanPresenceFeatures_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IHumanPresenceFeatures>>**, int> GetSupportedFeaturesForSensorIdAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Sensors::IHumanPresenceFeatures **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHumanPresenceFeatures**, int> GetSupportedFeaturesForSensorId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<TimeSpan>**, int> GetSupportedLockOnLeaveTimeouts;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int> add_SettingsChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SettingsChanged;
    }
}
