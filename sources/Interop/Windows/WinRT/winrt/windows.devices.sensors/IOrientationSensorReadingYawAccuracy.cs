// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IOrientationSensorReadingYawAccuracy.xml' path='doc/member[@name="IOrientationSensorReadingYawAccuracy"]/*' />
[Guid("D1AC9824-3F5A-49A2-BC7B-1180BC38CD2B")]
[NativeTypeName("struct IOrientationSensorReadingYawAccuracy : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IOrientationSensorReadingYawAccuracy : IOrientationSensorReadingYawAccuracy.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IOrientationSensorReadingYawAccuracy);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReadingYawAccuracy*, Guid*, void**, int>)(lpVtbl[0]))((IOrientationSensorReadingYawAccuracy*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReadingYawAccuracy*, uint>)(lpVtbl[1]))((IOrientationSensorReadingYawAccuracy*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReadingYawAccuracy*, uint>)(lpVtbl[2]))((IOrientationSensorReadingYawAccuracy*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReadingYawAccuracy*, uint*, Guid**, int>)(lpVtbl[3]))((IOrientationSensorReadingYawAccuracy*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReadingYawAccuracy*, HSTRING*, int>)(lpVtbl[4]))((IOrientationSensorReadingYawAccuracy*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReadingYawAccuracy*, TrustLevel*, int>)(lpVtbl[5]))((IOrientationSensorReadingYawAccuracy*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IOrientationSensorReadingYawAccuracy.xml' path='doc/member[@name="IOrientationSensorReadingYawAccuracy.get_YawAccuracy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_YawAccuracy([NativeTypeName("ABI::Windows::Devices::Sensors::MagnetometerAccuracy *")] MagnetometerAccuracy* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReadingYawAccuracy*, MagnetometerAccuracy*, int>)(lpVtbl[6]))((IOrientationSensorReadingYawAccuracy*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_YawAccuracy([NativeTypeName("ABI::Windows::Devices::Sensors::MagnetometerAccuracy *")] MagnetometerAccuracy* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::MagnetometerAccuracy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MagnetometerAccuracy*, int> get_YawAccuracy;
    }
}
