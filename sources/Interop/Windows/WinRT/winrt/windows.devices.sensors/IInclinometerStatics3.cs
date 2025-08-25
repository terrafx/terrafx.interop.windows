// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IInclinometerStatics3.xml' path='doc/member[@name="IInclinometerStatics3"]/*' />
[Guid("BD9A4280-B91A-4829-9392-ABC0B6BDF2B4")]
[NativeTypeName("struct IInclinometerStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IInclinometerStatics3 : IInclinometerStatics3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IInclinometerStatics3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IInclinometerStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerStatics3*, uint>)(lpVtbl[1]))((IInclinometerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerStatics3*, uint>)(lpVtbl[2]))((IInclinometerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IInclinometerStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerStatics3*, HSTRING*, int>)(lpVtbl[4]))((IInclinometerStatics3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IInclinometerStatics3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IInclinometerStatics3.xml' path='doc/member[@name="IInclinometerStatics3.GetDefaultWithSensorReadingType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefaultWithSensorReadingType([NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType")] SensorReadingType sensorReadingtype, [NativeTypeName("ABI::Windows::Devices::Sensors::IInclinometer **")] IInclinometer** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerStatics3*, SensorReadingType, IInclinometer**, int>)(lpVtbl[6]))((IInclinometerStatics3*)Unsafe.AsPointer(ref this), sensorReadingtype, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDefaultWithSensorReadingType([NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType")] SensorReadingType sensorReadingtype, [NativeTypeName("ABI::Windows::Devices::Sensors::IInclinometer **")] IInclinometer** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::SensorReadingType, ABI::Windows::Devices::Sensors::IInclinometer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SensorReadingType, IInclinometer**, int> GetDefaultWithSensorReadingType;
    }
}
