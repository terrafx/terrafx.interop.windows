// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IOrientationSensorStatics3.xml' path='doc/member[@name="IOrientationSensorStatics3"]/*' />
[Guid("D82CE920-2777-40FF-9F59-D654B085F12F")]
[NativeTypeName("struct IOrientationSensorStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IOrientationSensorStatics3 : IOrientationSensorStatics3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOrientationSensorStatics3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IOrientationSensorStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics3*, uint>)(lpVtbl[1]))((IOrientationSensorStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics3*, uint>)(lpVtbl[2]))((IOrientationSensorStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IOrientationSensorStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics3*, HSTRING*, int>)(lpVtbl[4]))((IOrientationSensorStatics3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IOrientationSensorStatics3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IOrientationSensorStatics3.xml' path='doc/member[@name="IOrientationSensorStatics3.GetDefaultWithSensorReadingType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefaultWithSensorReadingType([NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType")] SensorReadingType sensorReadingtype, [NativeTypeName("ABI::Windows::Devices::Sensors::IOrientationSensor **")] IOrientationSensor** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics3*, SensorReadingType, IOrientationSensor**, int>)(lpVtbl[6]))((IOrientationSensorStatics3*)Unsafe.AsPointer(ref this), sensorReadingtype, result);
    }

    /// <include file='IOrientationSensorStatics3.xml' path='doc/member[@name="IOrientationSensorStatics3.GetDefaultWithSensorReadingTypeAndSensorOptimizationGoal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDefaultWithSensorReadingTypeAndSensorOptimizationGoal([NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType")] SensorReadingType sensorReadingType, [NativeTypeName("ABI::Windows::Devices::Sensors::SensorOptimizationGoal")] SensorOptimizationGoal optimizationGoal, [NativeTypeName("ABI::Windows::Devices::Sensors::IOrientationSensor **")] IOrientationSensor** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorStatics3*, SensorReadingType, SensorOptimizationGoal, IOrientationSensor**, int>)(lpVtbl[7]))((IOrientationSensorStatics3*)Unsafe.AsPointer(ref this), sensorReadingType, optimizationGoal, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDefaultWithSensorReadingType([NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType")] SensorReadingType sensorReadingtype, [NativeTypeName("ABI::Windows::Devices::Sensors::IOrientationSensor **")] IOrientationSensor** result);

        [VtblIndex(7)]
        HRESULT GetDefaultWithSensorReadingTypeAndSensorOptimizationGoal([NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType")] SensorReadingType sensorReadingType, [NativeTypeName("ABI::Windows::Devices::Sensors::SensorOptimizationGoal")] SensorOptimizationGoal optimizationGoal, [NativeTypeName("ABI::Windows::Devices::Sensors::IOrientationSensor **")] IOrientationSensor** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::SensorReadingType, ABI::Windows::Devices::Sensors::IOrientationSensor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SensorReadingType, IOrientationSensor**, int> GetDefaultWithSensorReadingType;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::SensorReadingType, ABI::Windows::Devices::Sensors::SensorOptimizationGoal, ABI::Windows::Devices::Sensors::IOrientationSensor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SensorReadingType, SensorOptimizationGoal, IOrientationSensor**, int> GetDefaultWithSensorReadingTypeAndSensorOptimizationGoal;
    }
}
