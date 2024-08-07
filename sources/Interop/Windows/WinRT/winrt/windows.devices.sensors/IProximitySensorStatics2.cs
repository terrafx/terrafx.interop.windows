// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProximitySensorStatics2.xml' path='doc/member[@name="IProximitySensorStatics2"]/*' />
[Guid("CBF473AE-E9CA-422F-AD67-4C3D25DF350C")]
[NativeTypeName("struct IProximitySensorStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProximitySensorStatics2 : IProximitySensorStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProximitySensorStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensorStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IProximitySensorStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensorStatics2*, uint>)(lpVtbl[1]))((IProximitySensorStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensorStatics2*, uint>)(lpVtbl[2]))((IProximitySensorStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensorStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IProximitySensorStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensorStatics2*, HSTRING*, int>)(lpVtbl[4]))((IProximitySensorStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensorStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IProximitySensorStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProximitySensorStatics2.xml' path='doc/member[@name="IProximitySensorStatics2.GetReadingsFromTriggerDetails"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetReadingsFromTriggerDetails([NativeTypeName("ABI::Windows::Devices::Sensors::ISensorDataThresholdTriggerDetails *")] ISensorDataThresholdTriggerDetails* triggerDetails, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSensors__CProximitySensorReading_t **")] IVectorView<Pointer<IProximitySensorReading>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensorStatics2*, ISensorDataThresholdTriggerDetails*, IVectorView<Pointer<IProximitySensorReading>>**, int>)(lpVtbl[6]))((IProximitySensorStatics2*)Unsafe.AsPointer(ref this), triggerDetails, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetReadingsFromTriggerDetails([NativeTypeName("ABI::Windows::Devices::Sensors::ISensorDataThresholdTriggerDetails *")] ISensorDataThresholdTriggerDetails* triggerDetails, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSensors__CProximitySensorReading_t **")] IVectorView<Pointer<IProximitySensorReading>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::ISensorDataThresholdTriggerDetails *, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSensors__CProximitySensorReading_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISensorDataThresholdTriggerDetails*, IVectorView<Pointer<IProximitySensorReading>>**, int> GetReadingsFromTriggerDetails;
    }
}
