// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGeovisitMonitor.xml' path='doc/member[@name="IGeovisitMonitor"]/*' />
[Guid("80118AAF-5944-4591-83C1-396647F54F2C")]
[NativeTypeName("struct IGeovisitMonitor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeovisitMonitor : IGeovisitMonitor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeovisitMonitor));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitMonitor*, Guid*, void**, int>)(lpVtbl[0]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitMonitor*, uint>)(lpVtbl[1]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitMonitor*, uint>)(lpVtbl[2]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitMonitor*, uint*, Guid**, int>)(lpVtbl[3]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitMonitor*, HSTRING*, int>)(lpVtbl[4]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitMonitor*, TrustLevel*, int>)(lpVtbl[5]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGeovisitMonitor.xml' path='doc/member[@name="IGeovisitMonitor.get_MonitoringScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MonitoringScope([NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope *")] VisitMonitoringScope* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitMonitor*, VisitMonitoringScope*, int>)(lpVtbl[6]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeovisitMonitor.xml' path='doc/member[@name="IGeovisitMonitor.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Start([NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope")] VisitMonitoringScope value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitMonitor*, VisitMonitoringScope, int>)(lpVtbl[7]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeovisitMonitor.xml' path='doc/member[@name="IGeovisitMonitor.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitMonitor*, int>)(lpVtbl[8]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGeovisitMonitor.xml' path='doc/member[@name="IGeovisitMonitor.add_VisitStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_VisitStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGeolocation__CGeovisitMonitor_Windows__CDevices__CGeolocation__CGeovisitStateChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGeovisitMonitor>, Pointer<IGeovisitStateChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitMonitor*, ITypedEventHandler<Pointer<IGeovisitMonitor>, Pointer<IGeovisitStateChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGeovisitMonitor.xml' path='doc/member[@name="IGeovisitMonitor.remove_VisitStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_VisitStateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisitMonitor*, EventRegistrationToken, int>)(lpVtbl[10]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MonitoringScope([NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope *")] VisitMonitoringScope* value);

        [VtblIndex(7)]
        HRESULT Start([NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope")] VisitMonitoringScope value);

        [VtblIndex(8)]
        HRESULT Stop();

        [VtblIndex(9)]
        HRESULT add_VisitStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGeolocation__CGeovisitMonitor_Windows__CDevices__CGeolocation__CGeovisitStateChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGeovisitMonitor>, Pointer<IGeovisitStateChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_VisitStateChanged(EventRegistrationToken token);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, VisitMonitoringScope, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGeolocation__CGeovisitMonitor_Windows__CDevices__CGeolocation__CGeovisitStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGeovisitMonitor>, Pointer<IGeovisitStateChangedEventArgs>>*, EventRegistrationToken*, int> add_VisitStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_VisitStateChanged;
    }
}
