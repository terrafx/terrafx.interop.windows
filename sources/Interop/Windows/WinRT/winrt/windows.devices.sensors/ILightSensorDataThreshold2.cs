// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILightSensorDataThreshold2.xml' path='doc/member[@name="ILightSensorDataThreshold2"]/*' />
[Guid("6F040FBD-E08B-5B97-8F61-DD4EE66B1733")]
[NativeTypeName("struct ILightSensorDataThreshold2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILightSensorDataThreshold2 : ILightSensorDataThreshold2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ILightSensorDataThreshold2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold2*, Guid*, void**, int>)(lpVtbl[0]))((ILightSensorDataThreshold2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold2*, uint>)(lpVtbl[1]))((ILightSensorDataThreshold2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold2*, uint>)(lpVtbl[2]))((ILightSensorDataThreshold2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold2*, uint*, Guid**, int>)(lpVtbl[3]))((ILightSensorDataThreshold2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold2*, HSTRING*, int>)(lpVtbl[4]))((ILightSensorDataThreshold2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold2*, TrustLevel*, int>)(lpVtbl[5]))((ILightSensorDataThreshold2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILightSensorDataThreshold2.xml' path='doc/member[@name="ILightSensorDataThreshold2.get_Chromaticity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Chromaticity([NativeTypeName("ABI::Windows::Devices::Sensors::LightSensorChromaticity *")] LightSensorChromaticity* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold2*, LightSensorChromaticity*, int>)(lpVtbl[6]))((ILightSensorDataThreshold2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILightSensorDataThreshold2.xml' path='doc/member[@name="ILightSensorDataThreshold2.put_Chromaticity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Chromaticity([NativeTypeName("ABI::Windows::Devices::Sensors::LightSensorChromaticity")] LightSensorChromaticity value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold2*, LightSensorChromaticity, int>)(lpVtbl[7]))((ILightSensorDataThreshold2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Chromaticity([NativeTypeName("ABI::Windows::Devices::Sensors::LightSensorChromaticity *")] LightSensorChromaticity* value);

        [VtblIndex(7)]
        HRESULT put_Chromaticity([NativeTypeName("ABI::Windows::Devices::Sensors::LightSensorChromaticity")] LightSensorChromaticity value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::LightSensorChromaticity *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, LightSensorChromaticity*, int> get_Chromaticity;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::LightSensorChromaticity) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, LightSensorChromaticity, int> put_Chromaticity;
    }
}
