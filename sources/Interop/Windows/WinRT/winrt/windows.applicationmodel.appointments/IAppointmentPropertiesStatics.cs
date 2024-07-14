// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics"]/*' />
[Guid("25141FE9-68AE-3AAE-855F-BC4441CAA234")]
[NativeTypeName("struct IAppointmentPropertiesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentPropertiesStatics : IAppointmentPropertiesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentPropertiesStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, uint>)(lpVtbl[1]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, uint>)(lpVtbl[2]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_Subject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Subject(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[6]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_Location"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Location(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[7]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_StartTime(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[8]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Duration(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[9]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_Reminder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Reminder(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[10]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_BusyStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_BusyStatus(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[11]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_Sensitivity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Sensitivity(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[12]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_OriginalStartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_OriginalStartTime(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[13]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_IsResponseRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsResponseRequested(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[14]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_AllowNewTimeProposal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_AllowNewTimeProposal(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[15]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_AllDay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_AllDay(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[16]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_Details"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Details(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[17]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_OnlineMeetingLink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_OnlineMeetingLink(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[18]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_ReplyTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_ReplyTime(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[19]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_Organizer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Organizer(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[20]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_UserResponse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_UserResponse(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[21]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_HasInvitees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_HasInvitees(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[22]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_IsCanceledMeeting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_IsCanceledMeeting(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[23]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_IsOrganizedByUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_IsOrganizedByUser(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[24]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_Recurrence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_Recurrence(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[25]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_Uri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Uri(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[26]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_Invitees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_Invitees(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, HSTRING*, int>)(lpVtbl[27]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentPropertiesStatics.xml' path='doc/member[@name="IAppointmentPropertiesStatics.get_DefaultProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_DefaultProperties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentPropertiesStatics*, IVector<HSTRING>**, int>)(lpVtbl[28]))((IAppointmentPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Subject(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Location(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_StartTime(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Duration(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Reminder(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_BusyStatus(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Sensitivity(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_OriginalStartTime(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_IsResponseRequested(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_AllowNewTimeProposal(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_AllDay(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_Details(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_OnlineMeetingLink(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_ReplyTime(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_Organizer(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_UserResponse(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_HasInvitees(HSTRING* value);

        [VtblIndex(23)]
        HRESULT get_IsCanceledMeeting(HSTRING* value);

        [VtblIndex(24)]
        HRESULT get_IsOrganizedByUser(HSTRING* value);

        [VtblIndex(25)]
        HRESULT get_Recurrence(HSTRING* value);

        [VtblIndex(26)]
        HRESULT get_Uri(HSTRING* value);

        [VtblIndex(27)]
        HRESULT get_Invitees(HSTRING* value);

        [VtblIndex(28)]
        HRESULT get_DefaultProperties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Subject;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Location;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_StartTime;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Duration;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Reminder;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BusyStatus;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sensitivity;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_OriginalStartTime;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_IsResponseRequested;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AllowNewTimeProposal;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AllDay;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Details;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_OnlineMeetingLink;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ReplyTime;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Organizer;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserResponse;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HasInvitees;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_IsCanceledMeeting;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_IsOrganizedByUser;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Recurrence;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Uri;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Invitees;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_DefaultProperties;
    }
}
