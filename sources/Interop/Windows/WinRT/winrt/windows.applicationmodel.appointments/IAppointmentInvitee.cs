// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentInvitee.xml' path='doc/member[@name="IAppointmentInvitee"]/*' />
[Guid("13BF0796-9842-495B-B0E7-EF8F79C0701D")]
[NativeTypeName("struct IAppointmentInvitee : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentInvitee : IAppointmentInvitee.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentInvitee));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentInvitee*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentInvitee*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentInvitee*, uint>)(lpVtbl[1]))((IAppointmentInvitee*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentInvitee*, uint>)(lpVtbl[2]))((IAppointmentInvitee*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentInvitee*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentInvitee*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentInvitee*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentInvitee*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentInvitee*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentInvitee*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentInvitee.xml' path='doc/member[@name="IAppointmentInvitee.get_Role"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Role([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantRole *")] AppointmentParticipantRole* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentInvitee*, AppointmentParticipantRole*, int>)(lpVtbl[6]))((IAppointmentInvitee*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentInvitee.xml' path='doc/member[@name="IAppointmentInvitee.put_Role"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Role([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantRole")] AppointmentParticipantRole value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentInvitee*, AppointmentParticipantRole, int>)(lpVtbl[7]))((IAppointmentInvitee*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentInvitee.xml' path='doc/member[@name="IAppointmentInvitee.get_Response"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Response([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantResponse *")] AppointmentParticipantResponse* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentInvitee*, AppointmentParticipantResponse*, int>)(lpVtbl[8]))((IAppointmentInvitee*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentInvitee.xml' path='doc/member[@name="IAppointmentInvitee.put_Response"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Response([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantResponse")] AppointmentParticipantResponse value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentInvitee*, AppointmentParticipantResponse, int>)(lpVtbl[9]))((IAppointmentInvitee*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Role([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantRole *")] AppointmentParticipantRole* value);

        [VtblIndex(7)]
        HRESULT put_Role([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantRole")] AppointmentParticipantRole value);

        [VtblIndex(8)]
        HRESULT get_Response([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantResponse *")] AppointmentParticipantResponse* value);

        [VtblIndex(9)]
        HRESULT put_Response([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantResponse")] AppointmentParticipantResponse value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantRole *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentParticipantRole*, int> get_Role;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantRole) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentParticipantRole, int> put_Role;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantResponse *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentParticipantResponse*, int> get_Response;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantResponse) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentParticipantResponse, int> put_Response;
    }
}
