// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentStoreChange.xml' path='doc/member[@name="IAppointmentStoreChange"]/*' />
[Guid("A5A6E035-0A33-3654-8463-B543E90C3B79")]
[NativeTypeName("struct IAppointmentStoreChange : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentStoreChange : IAppointmentStoreChange.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentStoreChange));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChange*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentStoreChange*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChange*, uint>)(lpVtbl[1]))((IAppointmentStoreChange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChange*, uint>)(lpVtbl[2]))((IAppointmentStoreChange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChange*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentStoreChange*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChange*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentStoreChange*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChange*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentStoreChange*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentStoreChange.xml' path='doc/member[@name="IAppointmentStoreChange.get_Appointment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Appointment([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment **")] IAppointment** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChange*, IAppointment**, int>)(lpVtbl[6]))((IAppointmentStoreChange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentStoreChange.xml' path='doc/member[@name="IAppointmentStoreChange.get_ChangeType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ChangeType([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentStoreChangeType *")] AppointmentStoreChangeType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChange*, AppointmentStoreChangeType*, int>)(lpVtbl[7]))((IAppointmentStoreChange*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Appointment([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment **")] IAppointment** value);

        [VtblIndex(7)]
        HRESULT get_ChangeType([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentStoreChangeType *")] AppointmentStoreChangeType* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment**, int> get_Appointment;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentStoreChangeType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentStoreChangeType*, int> get_ChangeType;
    }
}
