// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGeovisitTrigger.xml' path='doc/member[@name="IGeovisitTrigger"]/*' />
[Guid("4818EDAA-04E1-4127-9A4C-19351B8A80A4")]
[NativeTypeName("struct IGeovisitTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeovisitTrigger : IGeovisitTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeovisitTrigger));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitTrigger*, Guid*, void**, int>)(lpVtbl[0]))((IGeovisitTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitTrigger*, uint>)(lpVtbl[1]))((IGeovisitTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitTrigger*, uint>)(lpVtbl[2]))((IGeovisitTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((IGeovisitTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitTrigger*, HSTRING*, int>)(lpVtbl[4]))((IGeovisitTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitTrigger*, TrustLevel*, int>)(lpVtbl[5]))((IGeovisitTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGeovisitTrigger.xml' path='doc/member[@name="IGeovisitTrigger.get_MonitoringScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MonitoringScope([NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope *")] VisitMonitoringScope* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitTrigger*, VisitMonitoringScope*, int>)(lpVtbl[6]))((IGeovisitTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeovisitTrigger.xml' path='doc/member[@name="IGeovisitTrigger.put_MonitoringScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_MonitoringScope([NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope")] VisitMonitoringScope value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitTrigger*, VisitMonitoringScope, int>)(lpVtbl[7]))((IGeovisitTrigger*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MonitoringScope([NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope *")] VisitMonitoringScope* value);

        [VtblIndex(7)]
        HRESULT put_MonitoringScope([NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope")] VisitMonitoringScope value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::VisitMonitoringScope *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VisitMonitoringScope*, int> get_MonitoringScope;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::VisitMonitoringScope) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VisitMonitoringScope, int> put_MonitoringScope;
    }
}
