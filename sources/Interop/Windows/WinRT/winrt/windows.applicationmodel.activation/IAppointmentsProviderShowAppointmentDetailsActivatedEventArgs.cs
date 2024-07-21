// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs.xml' path='doc/member[@name="IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs"]/*' />
[Guid("3958F065-9841-4CA5-999B-885198B9EF2A")]
[NativeTypeName("struct IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs : IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*, uint>)(lpVtbl[1]))((IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*, uint>)(lpVtbl[2]))((IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs.xml' path='doc/member[@name="IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs.get_InstanceStartDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InstanceStartDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*, IReference<DateTime>**, int>)(lpVtbl[6]))((IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs.xml' path='doc/member[@name="IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs.get_LocalId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LocalId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*, HSTRING*, int>)(lpVtbl[7]))((IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs.xml' path='doc/member[@name="IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs.get_RoamingId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RoamingId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*, HSTRING*, int>)(lpVtbl[8]))((IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InstanceStartDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(7)]
        HRESULT get_LocalId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_RoamingId(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_InstanceStartDate;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LocalId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RoamingId;
    }
}
