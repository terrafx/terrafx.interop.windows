// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2"]/*' />
[Guid("18E7E422-2467-4E1C-A459-D8A29303D092")]
[NativeTypeName("struct IAppointmentCalendar2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentCalendar2 : IAppointmentCalendar2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentCalendar2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, uint>)(lpVtbl[1]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, uint>)(lpVtbl[2]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.get_SyncManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SyncManager([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentCalendarSyncManager **")] IAppointmentCalendarSyncManager** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, IAppointmentCalendarSyncManager**, int>)(lpVtbl[6]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.get_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RemoteId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, HSTRING*, int>)(lpVtbl[7]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.put_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_RemoteId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, HSTRING, int>)(lpVtbl[8]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.put_DisplayColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DisplayColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, Color, int>)(lpVtbl[9]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.put_IsHidden"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_IsHidden([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, byte, int>)(lpVtbl[10]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.get_UserDataAccountId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_UserDataAccountId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, HSTRING*, int>)(lpVtbl[11]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.get_CanCreateOrUpdateAppointments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CanCreateOrUpdateAppointments([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, byte*, int>)(lpVtbl[12]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.put_CanCreateOrUpdateAppointments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_CanCreateOrUpdateAppointments([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, byte, int>)(lpVtbl[13]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.get_CanCancelMeetings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_CanCancelMeetings([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, byte*, int>)(lpVtbl[14]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.put_CanCancelMeetings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_CanCancelMeetings([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, byte, int>)(lpVtbl[15]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.get_CanForwardMeetings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_CanForwardMeetings([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, byte*, int>)(lpVtbl[16]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.put_CanForwardMeetings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_CanForwardMeetings([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, byte, int>)(lpVtbl[17]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.get_CanProposeNewTimeForMeetings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_CanProposeNewTimeForMeetings([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, byte*, int>)(lpVtbl[18]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.put_CanProposeNewTimeForMeetings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_CanProposeNewTimeForMeetings([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, byte, int>)(lpVtbl[19]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.get_CanUpdateMeetingResponses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_CanUpdateMeetingResponses([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, byte*, int>)(lpVtbl[20]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.put_CanUpdateMeetingResponses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_CanUpdateMeetingResponses([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, byte, int>)(lpVtbl[21]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.get_CanNotifyInvitees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_CanNotifyInvitees([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, byte*, int>)(lpVtbl[22]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.put_CanNotifyInvitees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_CanNotifyInvitees([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, byte, int>)(lpVtbl[23]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.get_MustNofityInvitees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_MustNofityInvitees([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, byte*, int>)(lpVtbl[24]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.put_MustNofityInvitees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_MustNofityInvitees([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, byte, int>)(lpVtbl[25]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.TryCreateOrUpdateAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT TryCreateOrUpdateAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("boolean")] byte notifyInvitees, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, IAppointment*, byte, IAsyncOperation<bool>**, int>)(lpVtbl[26]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), appointment, notifyInvitees, result);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.TryCancelMeetingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT TryCancelMeetingAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* meeting, HSTRING subject, HSTRING comment, [NativeTypeName("boolean")] byte notifyInvitees, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, IAppointment*, HSTRING, HSTRING, byte, IAsyncOperation<bool>**, int>)(lpVtbl[27]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), meeting, subject, comment, notifyInvitees, result);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.TryForwardMeetingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT TryForwardMeetingAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* meeting, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CAppointments__CAppointmentInvitee_t *")] IIterable<IntPtr>* invitees, HSTRING subject, HSTRING forwardHeader, HSTRING comment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, IAppointment*, IIterable<IntPtr>*, HSTRING, HSTRING, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[28]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), meeting, invitees, subject, forwardHeader, comment, result);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.TryProposeNewTimeForMeetingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT TryProposeNewTimeForMeetingAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* meeting, [NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime newStartTime, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan newDuration, HSTRING subject, HSTRING comment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, IAppointment*, DateTime, TimeSpan, HSTRING, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[29]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), meeting, newStartTime, newDuration, subject, comment, result);
    }

    /// <include file='IAppointmentCalendar2.xml' path='doc/member[@name="IAppointmentCalendar2.TryUpdateMeetingResponseAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT TryUpdateMeetingResponseAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* meeting, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantResponse")] AppointmentParticipantResponse response, HSTRING subject, HSTRING comment, [NativeTypeName("boolean")] byte sendUpdate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar2*, IAppointment*, AppointmentParticipantResponse, HSTRING, HSTRING, byte, IAsyncOperation<bool>**, int>)(lpVtbl[30]))((IAppointmentCalendar2*)Unsafe.AsPointer(ref this), meeting, response, subject, comment, sendUpdate, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SyncManager([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentCalendarSyncManager **")] IAppointmentCalendarSyncManager** value);

        [VtblIndex(7)]
        HRESULT get_RemoteId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_RemoteId(HSTRING value);

        [VtblIndex(9)]
        HRESULT put_DisplayColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(10)]
        HRESULT put_IsHidden([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_UserDataAccountId(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_CanCreateOrUpdateAppointments([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_CanCreateOrUpdateAppointments([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT get_CanCancelMeetings([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_CanCancelMeetings([NativeTypeName("boolean")] byte value);

        [VtblIndex(16)]
        HRESULT get_CanForwardMeetings([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT put_CanForwardMeetings([NativeTypeName("boolean")] byte value);

        [VtblIndex(18)]
        HRESULT get_CanProposeNewTimeForMeetings([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT put_CanProposeNewTimeForMeetings([NativeTypeName("boolean")] byte value);

        [VtblIndex(20)]
        HRESULT get_CanUpdateMeetingResponses([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(21)]
        HRESULT put_CanUpdateMeetingResponses([NativeTypeName("boolean")] byte value);

        [VtblIndex(22)]
        HRESULT get_CanNotifyInvitees([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(23)]
        HRESULT put_CanNotifyInvitees([NativeTypeName("boolean")] byte value);

        [VtblIndex(24)]
        HRESULT get_MustNofityInvitees([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(25)]
        HRESULT put_MustNofityInvitees([NativeTypeName("boolean")] byte value);

        [VtblIndex(26)]
        HRESULT TryCreateOrUpdateAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("boolean")] byte notifyInvitees, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(27)]
        HRESULT TryCancelMeetingAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* meeting, HSTRING subject, HSTRING comment, [NativeTypeName("boolean")] byte notifyInvitees, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(28)]
        HRESULT TryForwardMeetingAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* meeting, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CAppointments__CAppointmentInvitee_t *")] IIterable<IntPtr>* invitees, HSTRING subject, HSTRING forwardHeader, HSTRING comment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(29)]
        HRESULT TryProposeNewTimeForMeetingAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* meeting, [NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime newStartTime, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan newDuration, HSTRING subject, HSTRING comment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(30)]
        HRESULT TryUpdateMeetingResponseAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* meeting, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantResponse")] AppointmentParticipantResponse response, HSTRING subject, HSTRING comment, [NativeTypeName("boolean")] byte sendUpdate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointmentCalendarSyncManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointmentCalendarSyncManager**, int> get_SyncManager;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemoteId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_RemoteId;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_DisplayColor;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsHidden;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserDataAccountId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanCreateOrUpdateAppointments;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanCreateOrUpdateAppointments;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanCancelMeetings;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanCancelMeetings;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanForwardMeetings;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanForwardMeetings;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanProposeNewTimeForMeetings;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanProposeNewTimeForMeetings;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanUpdateMeetingResponses;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanUpdateMeetingResponses;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanNotifyInvitees;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanNotifyInvitees;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_MustNofityInvitees;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_MustNofityInvitees;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, boolean, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment*, byte, IAsyncOperation<bool>**, int> TryCreateOrUpdateAppointmentAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, HSTRING, HSTRING, boolean, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment*, HSTRING, HSTRING, byte, IAsyncOperation<bool>**, int> TryCancelMeetingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CAppointments__CAppointmentInvitee_t *, HSTRING, HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment*, IIterable<IntPtr>*, HSTRING, HSTRING, HSTRING, IAsyncOperation<bool>**, int> TryForwardMeetingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment*, DateTime, TimeSpan, HSTRING, HSTRING, IAsyncOperation<bool>**, int> TryProposeNewTimeForMeetingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantResponse, HSTRING, HSTRING, boolean, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment*, AppointmentParticipantResponse, HSTRING, HSTRING, byte, IAsyncOperation<bool>**, int> TryUpdateMeetingResponseAsync;
    }
}
