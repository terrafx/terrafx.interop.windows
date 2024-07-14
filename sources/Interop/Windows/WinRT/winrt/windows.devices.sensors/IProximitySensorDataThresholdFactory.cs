// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProximitySensorDataThresholdFactory.xml' path='doc/member[@name="IProximitySensorDataThresholdFactory"]/*' />
[Guid("905AC121-6D27-4AD3-9DB5-6467F2A5AD9D")]
[NativeTypeName("struct IProximitySensorDataThresholdFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProximitySensorDataThresholdFactory : IProximitySensorDataThresholdFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProximitySensorDataThresholdFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensorDataThresholdFactory*, Guid*, void**, int>)(lpVtbl[0]))((IProximitySensorDataThresholdFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensorDataThresholdFactory*, uint>)(lpVtbl[1]))((IProximitySensorDataThresholdFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensorDataThresholdFactory*, uint>)(lpVtbl[2]))((IProximitySensorDataThresholdFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensorDataThresholdFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IProximitySensorDataThresholdFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensorDataThresholdFactory*, HSTRING*, int>)(lpVtbl[4]))((IProximitySensorDataThresholdFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensorDataThresholdFactory*, TrustLevel*, int>)(lpVtbl[5]))((IProximitySensorDataThresholdFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProximitySensorDataThresholdFactory.xml' path='doc/member[@name="IProximitySensorDataThresholdFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Devices::Sensors::IProximitySensor *")] IProximitySensor* sensor, [NativeTypeName("ABI::Windows::Devices::Sensors::ISensorDataThreshold **")] ISensorDataThreshold** threshold)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensorDataThresholdFactory*, IProximitySensor*, ISensorDataThreshold**, int>)(lpVtbl[6]))((IProximitySensorDataThresholdFactory*)Unsafe.AsPointer(ref this), sensor, threshold);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Devices::Sensors::IProximitySensor *")] IProximitySensor* sensor, [NativeTypeName("ABI::Windows::Devices::Sensors::ISensorDataThreshold **")] ISensorDataThreshold** threshold);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IProximitySensor *, ABI::Windows::Devices::Sensors::ISensorDataThreshold **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IProximitySensor*, ISensorDataThreshold**, int> Create;
    }
}
