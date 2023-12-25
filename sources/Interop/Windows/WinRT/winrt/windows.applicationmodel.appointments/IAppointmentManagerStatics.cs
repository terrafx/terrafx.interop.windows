// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentManagerStatics.xml' path='doc/member[@name="IAppointmentManagerStatics"]/*' />
[Guid("3A30FA01-5C40-499D-B33F-A43050F74FC4")]
[NativeTypeName("struct IAppointmentManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentManagerStatics : IAppointmentManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics*, uint>)(lpVtbl[1]))((IAppointmentManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics*, uint>)(lpVtbl[2]))((IAppointmentManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentManagerStatics.xml' path='doc/member[@name="IAppointmentManagerStatics.ShowAddAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ShowAddAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics*, IAppointment*, Rect, IAsyncOperation<HSTRING>**, int>)(lpVtbl[6]))((IAppointmentManagerStatics*)Unsafe.AsPointer(ref this), appointment, selection, operation);
    }

    /// <include file='IAppointmentManagerStatics.xml' path='doc/member[@name="IAppointmentManagerStatics.ShowAddAppointmentWithPlacementAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ShowAddAppointmentWithPlacementAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics*, IAppointment*, Rect, Placement, IAsyncOperation<HSTRING>**, int>)(lpVtbl[7]))((IAppointmentManagerStatics*)Unsafe.AsPointer(ref this), appointment, selection, preferredPlacement, operation);
    }

    /// <include file='IAppointmentManagerStatics.xml' path='doc/member[@name="IAppointmentManagerStatics.ShowReplaceAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ShowReplaceAppointmentAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics*, HSTRING, IAppointment*, Rect, IAsyncOperation<HSTRING>**, int>)(lpVtbl[8]))((IAppointmentManagerStatics*)Unsafe.AsPointer(ref this), appointmentId, appointment, selection, operation);
    }

    /// <include file='IAppointmentManagerStatics.xml' path='doc/member[@name="IAppointmentManagerStatics.ShowReplaceAppointmentWithPlacementAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ShowReplaceAppointmentWithPlacementAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics*, HSTRING, IAppointment*, Rect, Placement, IAsyncOperation<HSTRING>**, int>)(lpVtbl[9]))((IAppointmentManagerStatics*)Unsafe.AsPointer(ref this), appointmentId, appointment, selection, preferredPlacement, operation);
    }

    /// <include file='IAppointmentManagerStatics.xml' path='doc/member[@name="IAppointmentManagerStatics.ShowReplaceAppointmentWithPlacementAndDateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ShowReplaceAppointmentWithPlacementAndDateAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics*, HSTRING, IAppointment*, Rect, Placement, DateTime, IAsyncOperation<HSTRING>**, int>)(lpVtbl[10]))((IAppointmentManagerStatics*)Unsafe.AsPointer(ref this), appointmentId, appointment, selection, preferredPlacement, instanceStartDate, operation);
    }

    /// <include file='IAppointmentManagerStatics.xml' path='doc/member[@name="IAppointmentManagerStatics.ShowRemoveAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ShowRemoveAppointmentAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics*, HSTRING, Rect, IAsyncOperation<bool>**, int>)(lpVtbl[11]))((IAppointmentManagerStatics*)Unsafe.AsPointer(ref this), appointmentId, selection, operation);
    }

    /// <include file='IAppointmentManagerStatics.xml' path='doc/member[@name="IAppointmentManagerStatics.ShowRemoveAppointmentWithPlacementAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ShowRemoveAppointmentWithPlacementAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics*, HSTRING, Rect, Placement, IAsyncOperation<bool>**, int>)(lpVtbl[12]))((IAppointmentManagerStatics*)Unsafe.AsPointer(ref this), appointmentId, selection, preferredPlacement, operation);
    }

    /// <include file='IAppointmentManagerStatics.xml' path='doc/member[@name="IAppointmentManagerStatics.ShowRemoveAppointmentWithPlacementAndDateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ShowRemoveAppointmentWithPlacementAndDateAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics*, HSTRING, Rect, Placement, DateTime, IAsyncOperation<bool>**, int>)(lpVtbl[13]))((IAppointmentManagerStatics*)Unsafe.AsPointer(ref this), appointmentId, selection, preferredPlacement, instanceStartDate, operation);
    }

    /// <include file='IAppointmentManagerStatics.xml' path='doc/member[@name="IAppointmentManagerStatics.ShowTimeFrameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ShowTimeFrameAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime timeToShow, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan duration, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics*, DateTime, TimeSpan, IAsyncAction**, int>)(lpVtbl[14]))((IAppointmentManagerStatics*)Unsafe.AsPointer(ref this), timeToShow, duration, asyncAction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ShowAddAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(7)]
        HRESULT ShowAddAppointmentWithPlacementAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(8)]
        HRESULT ShowReplaceAppointmentAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(9)]
        HRESULT ShowReplaceAppointmentWithPlacementAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(10)]
        HRESULT ShowReplaceAppointmentWithPlacementAndDateAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(11)]
        HRESULT ShowRemoveAppointmentAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(12)]
        HRESULT ShowRemoveAppointmentWithPlacementAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(13)]
        HRESULT ShowRemoveAppointmentWithPlacementAndDateAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(14)]
        HRESULT ShowTimeFrameAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime timeToShow, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan duration, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAppointment*, Rect, Placement, DateTime, IAsyncOperation<HSTRING>**, int> ShowReplaceAppointmentWithPlacementAndDateAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Rect, IAsyncOperation<bool>**, int> ShowRemoveAppointmentAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Rect, Placement, IAsyncOperation<bool>**, int> ShowRemoveAppointmentWithPlacementAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Rect, Placement, DateTime, IAsyncOperation<bool>**, int> ShowRemoveAppointmentWithPlacementAndDateAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DateTime, TimeSpan, IAsyncAction**, int> ShowTimeFrameAsync;
    }
}
