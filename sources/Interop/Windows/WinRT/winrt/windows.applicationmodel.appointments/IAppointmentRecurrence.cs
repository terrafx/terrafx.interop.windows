// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence"]/*' />
[Guid("D87B3E83-15A6-487B-B959-0C361E60E954")]
[NativeTypeName("struct IAppointmentRecurrence : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentRecurrence : IAppointmentRecurrence.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentRecurrence));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, uint>)(lpVtbl[1]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, uint>)(lpVtbl[2]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.get_Unit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Unit([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentRecurrenceUnit *")] AppointmentRecurrenceUnit* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, AppointmentRecurrenceUnit*, int>)(lpVtbl[6]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.put_Unit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Unit([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentRecurrenceUnit")] AppointmentRecurrenceUnit value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, AppointmentRecurrenceUnit, int>)(lpVtbl[7]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.get_Occurrences"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Occurrences([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, IReference<uint>**, int>)(lpVtbl[8]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.put_Occurrences"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Occurrences([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, IReference<uint>*, int>)(lpVtbl[9]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.get_Until"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Until([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, IReference<DateTime>**, int>)(lpVtbl[10]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.put_Until"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Until([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, IReference<DateTime>*, int>)(lpVtbl[11]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.get_Interval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Interval([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, uint*, int>)(lpVtbl[12]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.put_Interval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Interval([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, uint, int>)(lpVtbl[13]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.get_DaysOfWeek"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DaysOfWeek([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentDaysOfWeek *")] AppointmentDaysOfWeek* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, AppointmentDaysOfWeek*, int>)(lpVtbl[14]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.put_DaysOfWeek"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_DaysOfWeek([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentDaysOfWeek")] AppointmentDaysOfWeek value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, AppointmentDaysOfWeek, int>)(lpVtbl[15]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.get_WeekOfMonth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_WeekOfMonth([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentWeekOfMonth *")] AppointmentWeekOfMonth* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, AppointmentWeekOfMonth*, int>)(lpVtbl[16]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.put_WeekOfMonth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_WeekOfMonth([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentWeekOfMonth")] AppointmentWeekOfMonth value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, AppointmentWeekOfMonth, int>)(lpVtbl[17]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.get_Month"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Month([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, uint*, int>)(lpVtbl[18]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.put_Month"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_Month([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, uint, int>)(lpVtbl[19]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.get_Day"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Day([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, uint*, int>)(lpVtbl[20]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence.xml' path='doc/member[@name="IAppointmentRecurrence.put_Day"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_Day([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence*, uint, int>)(lpVtbl[21]))((IAppointmentRecurrence*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Unit([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentRecurrenceUnit *")] AppointmentRecurrenceUnit* value);

        [VtblIndex(7)]
        HRESULT put_Unit([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentRecurrenceUnit")] AppointmentRecurrenceUnit value);

        [VtblIndex(8)]
        HRESULT get_Occurrences([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(9)]
        HRESULT put_Occurrences([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value);

        [VtblIndex(10)]
        HRESULT get_Until([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(11)]
        HRESULT put_Until([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(12)]
        HRESULT get_Interval([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT put_Interval([NativeTypeName("UINT32")] uint value);

        [VtblIndex(14)]
        HRESULT get_DaysOfWeek([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentDaysOfWeek *")] AppointmentDaysOfWeek* value);

        [VtblIndex(15)]
        HRESULT put_DaysOfWeek([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentDaysOfWeek")] AppointmentDaysOfWeek value);

        [VtblIndex(16)]
        HRESULT get_WeekOfMonth([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentWeekOfMonth *")] AppointmentWeekOfMonth* value);

        [VtblIndex(17)]
        HRESULT put_WeekOfMonth([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentWeekOfMonth")] AppointmentWeekOfMonth value);

        [VtblIndex(18)]
        HRESULT get_Month([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(19)]
        HRESULT put_Month([NativeTypeName("UINT32")] uint value);

        [VtblIndex(20)]
        HRESULT get_Day([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(21)]
        HRESULT put_Day([NativeTypeName("UINT32")] uint value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentRecurrenceUnit *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentRecurrenceUnit*, int> get_Unit;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentRecurrenceUnit) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentRecurrenceUnit, int> put_Unit;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_Occurrences;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>*, int> put_Occurrences;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_Until;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_Until;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Interval;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_Interval;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentDaysOfWeek *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentDaysOfWeek*, int> get_DaysOfWeek;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentDaysOfWeek) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentDaysOfWeek, int> put_DaysOfWeek;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentWeekOfMonth *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentWeekOfMonth*, int> get_WeekOfMonth;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentWeekOfMonth) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentWeekOfMonth, int> put_WeekOfMonth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Month;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_Month;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Day;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_Day;
    }
}
