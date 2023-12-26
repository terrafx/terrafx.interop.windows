// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISensorDataThresholdTriggerDetails.xml' path='doc/member[@name="ISensorDataThresholdTriggerDetails"]/*' />
[Guid("9106F1B7-E88D-48B1-BC90-619C7B349391")]
[NativeTypeName("struct ISensorDataThresholdTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISensorDataThresholdTriggerDetails : ISensorDataThresholdTriggerDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISensorDataThresholdTriggerDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorDataThresholdTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((ISensorDataThresholdTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorDataThresholdTriggerDetails*, uint>)(lpVtbl[1]))((ISensorDataThresholdTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorDataThresholdTriggerDetails*, uint>)(lpVtbl[2]))((ISensorDataThresholdTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorDataThresholdTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((ISensorDataThresholdTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorDataThresholdTriggerDetails*, HSTRING*, int>)(lpVtbl[4]))((ISensorDataThresholdTriggerDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorDataThresholdTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((ISensorDataThresholdTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISensorDataThresholdTriggerDetails.xml' path='doc/member[@name="ISensorDataThresholdTriggerDetails.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorDataThresholdTriggerDetails*, HSTRING*, int>)(lpVtbl[6]))((ISensorDataThresholdTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISensorDataThresholdTriggerDetails.xml' path='doc/member[@name="ISensorDataThresholdTriggerDetails.get_SensorType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SensorType([NativeTypeName("ABI::Windows::Devices::Sensors::SensorType *")] SensorType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorDataThresholdTriggerDetails*, SensorType*, int>)(lpVtbl[7]))((ISensorDataThresholdTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_SensorType([NativeTypeName("ABI::Windows::Devices::Sensors::SensorType *")] SensorType* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::SensorType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SensorType*, int> get_SensorType;
    }
}
