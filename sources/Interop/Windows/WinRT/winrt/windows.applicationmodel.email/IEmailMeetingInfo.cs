// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo"]/*' />
[Guid("31C03FA9-7933-415F-A275-D165BA07026B")]
[NativeTypeName("struct IEmailMeetingInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMeetingInfo : IEmailMeetingInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMeetingInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, uint>)(lpVtbl[1]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, uint>)(lpVtbl[2]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, HSTRING*, int>)(lpVtbl[4]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.get_AllowNewTimeProposal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AllowNewTimeProposal([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, byte*, int>)(lpVtbl[6]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.put_AllowNewTimeProposal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AllowNewTimeProposal([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, byte, int>)(lpVtbl[7]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.get_AppointmentRoamingId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AppointmentRoamingId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, HSTRING*, int>)(lpVtbl[8]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.put_AppointmentRoamingId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AppointmentRoamingId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, HSTRING, int>)(lpVtbl[9]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.get_AppointmentOriginalStartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AppointmentOriginalStartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, IReference<DateTime>**, int>)(lpVtbl[10]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.put_AppointmentOriginalStartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_AppointmentOriginalStartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, IReference<DateTime>*, int>)(lpVtbl[11]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, TimeSpan*, int>)(lpVtbl[12]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.put_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, TimeSpan, int>)(lpVtbl[13]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.get_IsAllDay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsAllDay([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, byte*, int>)(lpVtbl[14]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.put_IsAllDay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_IsAllDay([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, byte, int>)(lpVtbl[15]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.get_IsResponseRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_IsResponseRequested([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, byte*, int>)(lpVtbl[16]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.put_IsResponseRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_IsResponseRequested([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, byte, int>)(lpVtbl[17]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.get_Location"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Location(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, HSTRING*, int>)(lpVtbl[18]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.put_Location"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_Location(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, HSTRING, int>)(lpVtbl[19]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.get_ProposedStartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_ProposedStartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** proposedStartTime)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, IReference<DateTime>**, int>)(lpVtbl[20]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), proposedStartTime);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.put_ProposedStartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_ProposedStartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* proposedStartTime)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, IReference<DateTime>*, int>)(lpVtbl[21]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), proposedStartTime);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.get_ProposedDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_ProposedDuration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** duration)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, IReference<TimeSpan>**, int>)(lpVtbl[22]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), duration);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.put_ProposedDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_ProposedDuration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* duration)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, IReference<TimeSpan>*, int>)(lpVtbl[23]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), duration);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.get_RecurrenceStartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_RecurrenceStartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, IReference<DateTime>**, int>)(lpVtbl[24]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.put_RecurrenceStartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_RecurrenceStartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, IReference<DateTime>*, int>)(lpVtbl[25]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.get_Recurrence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Recurrence([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentRecurrence **")] IAppointmentRecurrence** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, IAppointmentRecurrence**, int>)(lpVtbl[26]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.put_Recurrence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_Recurrence([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentRecurrence *")] IAppointmentRecurrence* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, IAppointmentRecurrence*, int>)(lpVtbl[27]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.get_RemoteChangeNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_RemoteChangeNumber([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, ulong*, int>)(lpVtbl[28]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.put_RemoteChangeNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_RemoteChangeNumber([NativeTypeName("UINT64")] ulong value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, ulong, int>)(lpVtbl[29]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.get_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, WinRTDateTime*, int>)(lpVtbl[30]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMeetingInfo.xml' path='doc/member[@name="IEmailMeetingInfo.put_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMeetingInfo*, WinRTDateTime, int>)(lpVtbl[31]))((IEmailMeetingInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AllowNewTimeProposal([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_AllowNewTimeProposal([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_AppointmentRoamingId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_AppointmentRoamingId(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_AppointmentOriginalStartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(11)]
        HRESULT put_AppointmentOriginalStartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(12)]
        HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(13)]
        HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(14)]
        HRESULT get_IsAllDay([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_IsAllDay([NativeTypeName("boolean")] byte value);

        [VtblIndex(16)]
        HRESULT get_IsResponseRequested([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT put_IsResponseRequested([NativeTypeName("boolean")] byte value);

        [VtblIndex(18)]
        HRESULT get_Location(HSTRING* value);

        [VtblIndex(19)]
        HRESULT put_Location(HSTRING value);

        [VtblIndex(20)]
        HRESULT get_ProposedStartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** proposedStartTime);

        [VtblIndex(21)]
        HRESULT put_ProposedStartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* proposedStartTime);

        [VtblIndex(22)]
        HRESULT get_ProposedDuration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** duration);

        [VtblIndex(23)]
        HRESULT put_ProposedDuration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* duration);

        [VtblIndex(24)]
        HRESULT get_RecurrenceStartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(25)]
        HRESULT put_RecurrenceStartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(26)]
        HRESULT get_Recurrence([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentRecurrence **")] IAppointmentRecurrence** value);

        [VtblIndex(27)]
        HRESULT put_Recurrence([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentRecurrence *")] IAppointmentRecurrence* value);

        [VtblIndex(28)]
        HRESULT get_RemoteChangeNumber([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(29)]
        HRESULT put_RemoteChangeNumber([NativeTypeName("UINT64")] ulong value);

        [VtblIndex(30)]
        HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(31)]
        HRESULT put_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AllowNewTimeProposal;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AllowNewTimeProposal;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AppointmentRoamingId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_AppointmentRoamingId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_AppointmentOriginalStartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_AppointmentOriginalStartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Duration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_Duration;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAllDay;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsAllDay;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsResponseRequested;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsResponseRequested;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Location;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Location;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_ProposedStartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_ProposedStartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_ProposedDuration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_ProposedDuration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_RecurrenceStartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_RecurrenceStartTime;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointmentRecurrence **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointmentRecurrence**, int> get_Recurrence;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointmentRecurrence *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointmentRecurrence*, int> put_Recurrence;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_RemoteChangeNumber;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, int> put_RemoteChangeNumber;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, int> put_StartTime;
    }
}
