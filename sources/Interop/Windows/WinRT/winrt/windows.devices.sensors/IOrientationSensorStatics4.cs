// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IOrientationSensorStatics4.xml' path='doc/member[@name="IOrientationSensorStatics4"]/*' />
[Guid("A67FEB55-2C85-4B28-A0FE-58C4B20495F5")]
[NativeTypeName("struct IOrientationSensorStatics4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IOrientationSensorStatics4 : IOrientationSensorStatics4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOrientationSensorStatics4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics4*, Guid*, void**, int>)(lpVtbl[0]))((IOrientationSensorStatics4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics4*, uint>)(lpVtbl[1]))((IOrientationSensorStatics4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics4*, uint>)(lpVtbl[2]))((IOrientationSensorStatics4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics4*, uint*, Guid**, int>)(lpVtbl[3]))((IOrientationSensorStatics4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics4*, HSTRING*, int>)(lpVtbl[4]))((IOrientationSensorStatics4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics4*, TrustLevel*, int>)(lpVtbl[5]))((IOrientationSensorStatics4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IOrientationSensorStatics4.xml' path='doc/member[@name="IOrientationSensorStatics4.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceSelector([NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType")] SensorReadingType readingType, HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics4*, SensorReadingType, HSTRING*, int>)(lpVtbl[6]))((IOrientationSensorStatics4*)Unsafe.AsPointer(ref this), readingType, result);
    }

    /// <include file='IOrientationSensorStatics4.xml' path='doc/member[@name="IOrientationSensorStatics4.GetDeviceSelectorWithSensorReadingTypeAndSensorOptimizationGoal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelectorWithSensorReadingTypeAndSensorOptimizationGoal([NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType")] SensorReadingType readingType, [NativeTypeName("ABI::Windows::Devices::Sensors::SensorOptimizationGoal")] SensorOptimizationGoal optimizationGoal, HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics4*, SensorReadingType, SensorOptimizationGoal, HSTRING*, int>)(lpVtbl[7]))((IOrientationSensorStatics4*)Unsafe.AsPointer(ref this), readingType, optimizationGoal, result);
    }

    /// <include file='IOrientationSensorStatics4.xml' path='doc/member[@name="IOrientationSensorStatics4.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__COrientationSensor_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics4*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IOrientationSensorStatics4*)Unsafe.AsPointer(ref this), deviceId, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceSelector([NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType")] SensorReadingType readingType, HSTRING* result);

        [VtblIndex(7)]
        HRESULT GetDeviceSelectorWithSensorReadingTypeAndSensorOptimizationGoal([NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType")] SensorReadingType readingType, [NativeTypeName("ABI::Windows::Devices::Sensors::SensorOptimizationGoal")] SensorOptimizationGoal optimizationGoal, HSTRING* result);

        [VtblIndex(8)]
        HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__COrientationSensor_t **")] IAsyncOperation<IntPtr>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::SensorReadingType, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SensorReadingType, HSTRING*, int> GetDeviceSelector;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::SensorReadingType, ABI::Windows::Devices::Sensors::SensorOptimizationGoal, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SensorReadingType, SensorOptimizationGoal, HSTRING*, int> GetDeviceSelectorWithSensorReadingTypeAndSensorOptimizationGoal;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__COrientationSensor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> FromIdAsync;
    }
}
