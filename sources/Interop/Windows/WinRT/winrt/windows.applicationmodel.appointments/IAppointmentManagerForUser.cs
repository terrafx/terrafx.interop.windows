// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentManagerForUser.xml' path='doc/member[@name="IAppointmentManagerForUser"]/*' />
[Guid("70261423-73CC-4660-B318-B01365302A03")]
[NativeTypeName("struct IAppointmentManagerForUser : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentManagerForUser : IAppointmentManagerForUser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppointmentManagerForUser);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, uint>)(lpVtbl[1]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, uint>)(lpVtbl[2]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentManagerForUser.xml' path='doc/member[@name="IAppointmentManagerForUser.ShowAddAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ShowAddAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, IAppointment*, Rect, IAsyncOperation<HSTRING>**, int>)(lpVtbl[6]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), appointment, selection, result);
    }

    /// <include file='IAppointmentManagerForUser.xml' path='doc/member[@name="IAppointmentManagerForUser.ShowAddAppointmentWithPlacementAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ShowAddAppointmentWithPlacementAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, IAppointment*, Rect, Placement, IAsyncOperation<HSTRING>**, int>)(lpVtbl[7]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), appointment, selection, preferredPlacement, result);
    }

    /// <include file='IAppointmentManagerForUser.xml' path='doc/member[@name="IAppointmentManagerForUser.ShowReplaceAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ShowReplaceAppointmentAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, HSTRING, IAppointment*, Rect, IAsyncOperation<HSTRING>**, int>)(lpVtbl[8]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), appointmentId, appointment, selection, result);
    }

    /// <include file='IAppointmentManagerForUser.xml' path='doc/member[@name="IAppointmentManagerForUser.ShowReplaceAppointmentWithPlacementAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ShowReplaceAppointmentWithPlacementAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, HSTRING, IAppointment*, Rect, Placement, IAsyncOperation<HSTRING>**, int>)(lpVtbl[9]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), appointmentId, appointment, selection, preferredPlacement, result);
    }

    /// <include file='IAppointmentManagerForUser.xml' path='doc/member[@name="IAppointmentManagerForUser.ShowReplaceAppointmentWithPlacementAndDateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ShowReplaceAppointmentWithPlacementAndDateAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, HSTRING, IAppointment*, Rect, Placement, WinRTDateTime, IAsyncOperation<HSTRING>**, int>)(lpVtbl[10]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), appointmentId, appointment, selection, preferredPlacement, instanceStartDate, result);
    }

    /// <include file='IAppointmentManagerForUser.xml' path='doc/member[@name="IAppointmentManagerForUser.ShowRemoveAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ShowRemoveAppointmentAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, HSTRING, Rect, IAsyncOperation<bool>**, int>)(lpVtbl[11]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), appointmentId, selection, result);
    }

    /// <include file='IAppointmentManagerForUser.xml' path='doc/member[@name="IAppointmentManagerForUser.ShowRemoveAppointmentWithPlacementAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ShowRemoveAppointmentWithPlacementAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, HSTRING, Rect, Placement, IAsyncOperation<bool>**, int>)(lpVtbl[12]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), appointmentId, selection, preferredPlacement, result);
    }

    /// <include file='IAppointmentManagerForUser.xml' path='doc/member[@name="IAppointmentManagerForUser.ShowRemoveAppointmentWithPlacementAndDateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ShowRemoveAppointmentWithPlacementAndDateAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, HSTRING, Rect, Placement, WinRTDateTime, IAsyncOperation<bool>**, int>)(lpVtbl[13]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), appointmentId, selection, preferredPlacement, instanceStartDate, result);
    }

    /// <include file='IAppointmentManagerForUser.xml' path='doc/member[@name="IAppointmentManagerForUser.ShowTimeFrameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ShowTimeFrameAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime timeToShow, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan duration, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, WinRTDateTime, TimeSpan, IAsyncAction**, int>)(lpVtbl[14]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), timeToShow, duration, result);
    }

    /// <include file='IAppointmentManagerForUser.xml' path='doc/member[@name="IAppointmentManagerForUser.ShowAppointmentDetailsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ShowAppointmentDetailsAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, HSTRING, IAsyncAction**, int>)(lpVtbl[15]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), appointmentId, result);
    }

    /// <include file='IAppointmentManagerForUser.xml' path='doc/member[@name="IAppointmentManagerForUser.ShowAppointmentDetailsWithDateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ShowAppointmentDetailsWithDateAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, HSTRING, WinRTDateTime, IAsyncAction**, int>)(lpVtbl[16]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), appointmentId, instanceStartDate, result);
    }

    /// <include file='IAppointmentManagerForUser.xml' path='doc/member[@name="IAppointmentManagerForUser.ShowEditNewAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ShowEditNewAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, IAppointment*, IAsyncOperation<HSTRING>**, int>)(lpVtbl[17]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), appointment, result);
    }

    /// <include file='IAppointmentManagerForUser.xml' path='doc/member[@name="IAppointmentManagerForUser.RequestStoreAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RequestStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentStoreAccessType")] AppointmentStoreAccessType options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentStore_t **")] IAsyncOperation<Pointer<IAppointmentStore>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, AppointmentStoreAccessType, IAsyncOperation<Pointer<IAppointmentStore>>**, int>)(lpVtbl[18]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), options, result);
    }

    /// <include file='IAppointmentManagerForUser.xml' path='doc/member[@name="IAppointmentManagerForUser.get_User"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerForUser*, IUser**, int>)(lpVtbl[19]))((IAppointmentManagerForUser*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ShowAddAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result);

        [VtblIndex(7)]
        HRESULT ShowAddAppointmentWithPlacementAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result);

        [VtblIndex(8)]
        HRESULT ShowReplaceAppointmentAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result);

        [VtblIndex(9)]
        HRESULT ShowReplaceAppointmentWithPlacementAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result);

        [VtblIndex(10)]
        HRESULT ShowReplaceAppointmentWithPlacementAndDateAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result);

        [VtblIndex(11)]
        HRESULT ShowRemoveAppointmentAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(12)]
        HRESULT ShowRemoveAppointmentWithPlacementAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(13)]
        HRESULT ShowRemoveAppointmentWithPlacementAndDateAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(14)]
        HRESULT ShowTimeFrameAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime timeToShow, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan duration, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(15)]
        HRESULT ShowAppointmentDetailsAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(16)]
        HRESULT ShowAppointmentDetailsWithDateAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(17)]
        HRESULT ShowEditNewAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result);

        [VtblIndex(18)]
        HRESULT RequestStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentStoreAccessType")] AppointmentStoreAccessType options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentStore_t **")] IAsyncOperation<Pointer<IAppointmentStore>>** result);

        [VtblIndex(19)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment*, Rect, IAsyncOperation<HSTRING>**, int> ShowAddAppointmentAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment*, Rect, Placement, IAsyncOperation<HSTRING>**, int> ShowAddAppointmentWithPlacementAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAppointment*, Rect, IAsyncOperation<HSTRING>**, int> ShowReplaceAppointmentAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAppointment*, Rect, Placement, IAsyncOperation<HSTRING>**, int> ShowReplaceAppointmentWithPlacementAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAppointment*, Rect, Placement, WinRTDateTime, IAsyncOperation<HSTRING>**, int> ShowReplaceAppointmentWithPlacementAndDateAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Rect, IAsyncOperation<bool>**, int> ShowRemoveAppointmentAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Rect, Placement, IAsyncOperation<bool>**, int> ShowRemoveAppointmentWithPlacementAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Rect, Placement, WinRTDateTime, IAsyncOperation<bool>**, int> ShowRemoveAppointmentWithPlacementAndDateAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, TimeSpan, IAsyncAction**, int> ShowTimeFrameAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> ShowAppointmentDetailsAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, WinRTDateTime, IAsyncAction**, int> ShowAppointmentDetailsWithDateAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment*, IAsyncOperation<HSTRING>**, int> ShowEditNewAppointmentAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentStoreAccessType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentStore_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentStoreAccessType, IAsyncOperation<Pointer<IAppointmentStore>>**, int> RequestStoreAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser**, int> get_User;
    }
}
