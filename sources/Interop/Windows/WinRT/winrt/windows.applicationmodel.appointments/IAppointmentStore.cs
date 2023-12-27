// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore"]/*' />
[Guid("A461918C-7A47-4D96-96C9-15CD8A05A735")]
[NativeTypeName("struct IAppointmentStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentStore : IAppointmentStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentStore));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, uint>)(lpVtbl[1]))((IAppointmentStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, uint>)(lpVtbl[2]))((IAppointmentStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentStore*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentStore*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentStore*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.get_ChangeTracker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChangeTracker([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentStoreChangeTracker **")] IAppointmentStoreChangeTracker** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, IAppointmentStoreChangeTracker**, int>)(lpVtbl[6]))((IAppointmentStore*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.CreateAppointmentCalendarAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateAppointmentCalendarAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **")] IAsyncOperation<Pointer<IAppointmentCalendar>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, HSTRING, IAsyncOperation<Pointer<IAppointmentCalendar>>**, int>)(lpVtbl[7]))((IAppointmentStore*)Unsafe.AsPointer(ref this), name, operation);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.GetAppointmentCalendarAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAppointmentCalendarAsync(HSTRING calendarId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **")] IAsyncOperation<Pointer<IAppointmentCalendar>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, HSTRING, IAsyncOperation<Pointer<IAppointmentCalendar>>**, int>)(lpVtbl[8]))((IAppointmentStore*)Unsafe.AsPointer(ref this), calendarId, result);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.GetAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAppointmentAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<Pointer<IAppointment>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, HSTRING, IAsyncOperation<Pointer<IAppointment>>**, int>)(lpVtbl[9]))((IAppointmentStore*)Unsafe.AsPointer(ref this), localId, result);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.GetAppointmentInstanceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetAppointmentInstanceAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartTime, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<Pointer<IAppointment>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, HSTRING, WinRTDateTime, IAsyncOperation<Pointer<IAppointment>>**, int>)(lpVtbl[10]))((IAppointmentStore*)Unsafe.AsPointer(ref this), localId, instanceStartTime, result);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.FindAppointmentCalendarsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT FindAppointmentCalendarsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppointmentCalendar>>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, IAsyncOperation<Pointer<IVectorView<Pointer<IAppointmentCalendar>>>>**, int>)(lpVtbl[11]))((IAppointmentStore*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.FindAppointmentCalendarsAsyncWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT FindAppointmentCalendarsAsyncWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::FindAppointmentCalendarsOptions")] FindAppointmentCalendarsOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppointmentCalendar>>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, FindAppointmentCalendarsOptions, IAsyncOperation<Pointer<IVectorView<Pointer<IAppointmentCalendar>>>>**, int>)(lpVtbl[12]))((IAppointmentStore*)Unsafe.AsPointer(ref this), options, result);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.FindAppointmentsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT FindAppointmentsAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppointment>>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, WinRTDateTime, TimeSpan, IAsyncOperation<Pointer<IVectorView<Pointer<IAppointment>>>>**, int>)(lpVtbl[13]))((IAppointmentStore*)Unsafe.AsPointer(ref this), rangeStart, rangeLength, result);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.FindAppointmentsAsyncWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT FindAppointmentsAsyncWithOptions([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *")] IFindAppointmentsOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppointment>>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, WinRTDateTime, TimeSpan, IFindAppointmentsOptions*, IAsyncOperation<Pointer<IVectorView<Pointer<IAppointment>>>>**, int>)(lpVtbl[14]))((IAppointmentStore*)Unsafe.AsPointer(ref this), rangeStart, rangeLength, options, result);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.FindConflictAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT FindConflictAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentConflictResult_t **")] IAsyncOperation<Pointer<IAppointmentConflictResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, IAppointment*, IAsyncOperation<Pointer<IAppointmentConflictResult>>**, int>)(lpVtbl[15]))((IAppointmentStore*)Unsafe.AsPointer(ref this), appointment, result);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.FindConflictAsyncWithInstanceStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT FindConflictAsyncWithInstanceStart([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartTime, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentConflictResult_t **")] IAsyncOperation<Pointer<IAppointmentConflictResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, IAppointment*, WinRTDateTime, IAsyncOperation<Pointer<IAppointmentConflictResult>>**, int>)(lpVtbl[16]))((IAppointmentStore*)Unsafe.AsPointer(ref this), appointment, instanceStartTime, result);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.MoveAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT MoveAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentCalendar *")] IAppointmentCalendar* destinationCalendar, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, IAppointment*, IAppointmentCalendar*, IAsyncAction**, int>)(lpVtbl[17]))((IAppointmentStore*)Unsafe.AsPointer(ref this), appointment, destinationCalendar, asyncAction);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.ShowAddAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ShowAddAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, IAppointment*, Rect, IAsyncOperation<HSTRING>**, int>)(lpVtbl[18]))((IAppointmentStore*)Unsafe.AsPointer(ref this), appointment, selection, operation);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.ShowReplaceAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ShowReplaceAppointmentAsync(HSTRING localId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, HSTRING, IAppointment*, Rect, IAsyncOperation<HSTRING>**, int>)(lpVtbl[19]))((IAppointmentStore*)Unsafe.AsPointer(ref this), localId, appointment, selection, operation);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.ShowReplaceAppointmentWithPlacementAndDateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT ShowReplaceAppointmentWithPlacementAndDateAsync(HSTRING localId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, HSTRING, IAppointment*, Rect, Placement, WinRTDateTime, IAsyncOperation<HSTRING>**, int>)(lpVtbl[20]))((IAppointmentStore*)Unsafe.AsPointer(ref this), localId, appointment, selection, preferredPlacement, instanceStartDate, operation);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.ShowRemoveAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT ShowRemoveAppointmentAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, HSTRING, Rect, IAsyncOperation<bool>**, int>)(lpVtbl[21]))((IAppointmentStore*)Unsafe.AsPointer(ref this), localId, selection, operation);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.ShowRemoveAppointmentWithPlacementAndDateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT ShowRemoveAppointmentWithPlacementAndDateAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, HSTRING, Rect, Placement, WinRTDateTime, IAsyncOperation<bool>**, int>)(lpVtbl[22]))((IAppointmentStore*)Unsafe.AsPointer(ref this), localId, selection, preferredPlacement, instanceStartDate, operation);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.ShowAppointmentDetailsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT ShowAppointmentDetailsAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, HSTRING, IAsyncAction**, int>)(lpVtbl[23]))((IAppointmentStore*)Unsafe.AsPointer(ref this), localId, asyncAction);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.ShowAppointmentDetailsWithDateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT ShowAppointmentDetailsWithDateAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, HSTRING, WinRTDateTime, IAsyncAction**, int>)(lpVtbl[24]))((IAppointmentStore*)Unsafe.AsPointer(ref this), localId, instanceStartDate, asyncAction);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.ShowEditNewAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT ShowEditNewAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, IAppointment*, IAsyncOperation<HSTRING>**, int>)(lpVtbl[25]))((IAppointmentStore*)Unsafe.AsPointer(ref this), appointment, operation);
    }

    /// <include file='IAppointmentStore.xml' path='doc/member[@name="IAppointmentStore.FindLocalIdsFromRoamingIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT FindLocalIdsFromRoamingIdAsync(HSTRING roamingId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **")] IAsyncOperation<Pointer<IVectorView<HSTRING>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore*, HSTRING, IAsyncOperation<Pointer<IVectorView<HSTRING>>>**, int>)(lpVtbl[26]))((IAppointmentStore*)Unsafe.AsPointer(ref this), roamingId, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ChangeTracker([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentStoreChangeTracker **")] IAppointmentStoreChangeTracker** value);

        [VtblIndex(7)]
        HRESULT CreateAppointmentCalendarAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **")] IAsyncOperation<Pointer<IAppointmentCalendar>>** operation);

        [VtblIndex(8)]
        HRESULT GetAppointmentCalendarAsync(HSTRING calendarId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **")] IAsyncOperation<Pointer<IAppointmentCalendar>>** result);

        [VtblIndex(9)]
        HRESULT GetAppointmentAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<Pointer<IAppointment>>** result);

        [VtblIndex(10)]
        HRESULT GetAppointmentInstanceAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartTime, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<Pointer<IAppointment>>** result);

        [VtblIndex(11)]
        HRESULT FindAppointmentCalendarsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppointmentCalendar>>>>** result);

        [VtblIndex(12)]
        HRESULT FindAppointmentCalendarsAsyncWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::FindAppointmentCalendarsOptions")] FindAppointmentCalendarsOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppointmentCalendar>>>>** result);

        [VtblIndex(13)]
        HRESULT FindAppointmentsAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppointment>>>>** result);

        [VtblIndex(14)]
        HRESULT FindAppointmentsAsyncWithOptions([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *")] IFindAppointmentsOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppointment>>>>** result);

        [VtblIndex(15)]
        HRESULT FindConflictAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentConflictResult_t **")] IAsyncOperation<Pointer<IAppointmentConflictResult>>** result);

        [VtblIndex(16)]
        HRESULT FindConflictAsyncWithInstanceStart([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartTime, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentConflictResult_t **")] IAsyncOperation<Pointer<IAppointmentConflictResult>>** result);

        [VtblIndex(17)]
        HRESULT MoveAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentCalendar *")] IAppointmentCalendar* destinationCalendar, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);

        [VtblIndex(18)]
        HRESULT ShowAddAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(19)]
        HRESULT ShowReplaceAppointmentAsync(HSTRING localId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(20)]
        HRESULT ShowReplaceAppointmentWithPlacementAndDateAsync(HSTRING localId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(21)]
        HRESULT ShowRemoveAppointmentAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(22)]
        HRESULT ShowRemoveAppointmentWithPlacementAndDateAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(23)]
        HRESULT ShowAppointmentDetailsAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);

        [VtblIndex(24)]
        HRESULT ShowAppointmentDetailsWithDateAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);

        [VtblIndex(25)]
        HRESULT ShowEditNewAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(26)]
        HRESULT FindLocalIdsFromRoamingIdAsync(HSTRING roamingId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **")] IAsyncOperation<Pointer<IVectorView<HSTRING>>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointmentStoreChangeTracker **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointmentStoreChangeTracker**, int> get_ChangeTracker;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IAppointmentCalendar>>**, int> CreateAppointmentCalendarAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IAppointmentCalendar>>**, int> GetAppointmentCalendarAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IAppointment>>**, int> GetAppointmentAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, WinRTDateTime, IAsyncOperation<Pointer<IAppointment>>**, int> GetAppointmentInstanceAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IAppointmentCalendar>>>>**, int> FindAppointmentCalendarsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::FindAppointmentCalendarsOptions, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FindAppointmentCalendarsOptions, IAsyncOperation<Pointer<IVectorView<Pointer<IAppointmentCalendar>>>>**, int> FindAppointmentCalendarsAsyncWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, TimeSpan, IAsyncOperation<Pointer<IVectorView<Pointer<IAppointment>>>>**, int> FindAppointmentsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, TimeSpan, IFindAppointmentsOptions*, IAsyncOperation<Pointer<IVectorView<Pointer<IAppointment>>>>**, int> FindAppointmentsAsyncWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentConflictResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment*, IAsyncOperation<Pointer<IAppointmentConflictResult>>**, int> FindConflictAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentConflictResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment*, WinRTDateTime, IAsyncOperation<Pointer<IAppointmentConflictResult>>**, int> FindConflictAsyncWithInstanceStart;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::ApplicationModel::Appointments::IAppointmentCalendar *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment*, IAppointmentCalendar*, IAsyncAction**, int> MoveAppointmentAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment*, Rect, IAsyncOperation<HSTRING>**, int> ShowAddAppointmentAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAppointment*, Rect, IAsyncOperation<HSTRING>**, int> ShowReplaceAppointmentAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAppointment*, Rect, Placement, WinRTDateTime, IAsyncOperation<HSTRING>**, int> ShowReplaceAppointmentWithPlacementAndDateAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Rect, IAsyncOperation<bool>**, int> ShowRemoveAppointmentAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Rect, Placement, WinRTDateTime, IAsyncOperation<bool>**, int> ShowRemoveAppointmentWithPlacementAndDateAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> ShowAppointmentDetailsAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, WinRTDateTime, IAsyncAction**, int> ShowAppointmentDetailsWithDateAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment*, IAsyncOperation<HSTRING>**, int> ShowEditNewAppointmentAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IVectorView<HSTRING>>>**, int> FindLocalIdsFromRoamingIdAsync;
    }
}
