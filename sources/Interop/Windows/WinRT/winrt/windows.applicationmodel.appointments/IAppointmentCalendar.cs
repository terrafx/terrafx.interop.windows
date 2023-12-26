// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar"]/*' />
[Guid("5273819D-8339-3D4F-A02F-64084452BB5D")]
[NativeTypeName("struct IAppointmentCalendar : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentCalendar : IAppointmentCalendar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentCalendar));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, uint>)(lpVtbl[1]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, uint>)(lpVtbl[2]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.get_DisplayColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DisplayColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, Color*, int>)(lpVtbl[6]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, HSTRING*, int>)(lpVtbl[7]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.put_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, HSTRING, int>)(lpVtbl[8]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.get_LocalId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_LocalId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, HSTRING*, int>)(lpVtbl[9]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.get_IsHidden"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsHidden([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, byte*, int>)(lpVtbl[10]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.get_OtherAppReadAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppReadAccess *")] AppointmentCalendarOtherAppReadAccess* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, AppointmentCalendarOtherAppReadAccess*, int>)(lpVtbl[11]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.put_OtherAppReadAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppReadAccess")] AppointmentCalendarOtherAppReadAccess value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, AppointmentCalendarOtherAppReadAccess, int>)(lpVtbl[12]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.get_OtherAppWriteAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppWriteAccess *")] AppointmentCalendarOtherAppWriteAccess* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, AppointmentCalendarOtherAppWriteAccess*, int>)(lpVtbl[13]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.put_OtherAppWriteAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppWriteAccess")] AppointmentCalendarOtherAppWriteAccess value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, AppointmentCalendarOtherAppWriteAccess, int>)(lpVtbl[14]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.get_SourceDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_SourceDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, HSTRING*, int>)(lpVtbl[15]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.get_SummaryCardView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_SummaryCardView([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentSummaryCardView *")] AppointmentSummaryCardView* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, AppointmentSummaryCardView*, int>)(lpVtbl[16]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.put_SummaryCardView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_SummaryCardView([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentSummaryCardView")] AppointmentSummaryCardView value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, AppointmentSummaryCardView, int>)(lpVtbl[17]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.FindAppointmentsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT FindAppointmentsAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, WinRTDateTime, TimeSpan, IAsyncOperation<IntPtr>**, int>)(lpVtbl[18]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), rangeStart, rangeLength, result);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.FindAppointmentsAsyncWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT FindAppointmentsAsyncWithOptions([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *")] IFindAppointmentsOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, WinRTDateTime, TimeSpan, IFindAppointmentsOptions*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[19]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), rangeStart, rangeLength, options, result);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.FindExceptionsFromMasterAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT FindExceptionsFromMasterAsync(HSTRING masterLocalId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentException_t **")] IAsyncOperation<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[20]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), masterLocalId, value);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.FindAllInstancesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT FindAllInstancesAsync(HSTRING masterLocalId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, HSTRING, WinRTDateTime, TimeSpan, IAsyncOperation<IntPtr>**, int>)(lpVtbl[21]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), masterLocalId, rangeStart, rangeLength, value);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.FindAllInstancesAsyncWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT FindAllInstancesAsyncWithOptions(HSTRING masterLocalId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *")] IFindAppointmentsOptions* pOptions, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, HSTRING, WinRTDateTime, TimeSpan, IFindAppointmentsOptions*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[22]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), masterLocalId, rangeStart, rangeLength, pOptions, value);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.GetAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetAppointmentAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[23]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), localId, result);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.GetAppointmentInstanceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetAppointmentInstanceAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartTime, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, HSTRING, WinRTDateTime, IAsyncOperation<IntPtr>**, int>)(lpVtbl[24]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), localId, instanceStartTime, result);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.FindUnexpandedAppointmentsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT FindUnexpandedAppointmentsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[25]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.FindUnexpandedAppointmentsAsyncWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT FindUnexpandedAppointmentsAsyncWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *")] IFindAppointmentsOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, IFindAppointmentsOptions*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[26]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), options, result);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.DeleteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, IAsyncAction**, int>)(lpVtbl[27]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), asyncAction);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.SaveAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SaveAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, IAsyncAction**, int>)(lpVtbl[28]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), asyncAction);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.DeleteAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT DeleteAppointmentAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, HSTRING, IAsyncAction**, int>)(lpVtbl[29]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), localId, asyncAction);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.DeleteAppointmentInstanceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT DeleteAppointmentInstanceAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartTime, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, HSTRING, WinRTDateTime, IAsyncAction**, int>)(lpVtbl[30]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), localId, instanceStartTime, asyncAction);
    }

    /// <include file='IAppointmentCalendar.xml' path='doc/member[@name="IAppointmentCalendar.SaveAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SaveAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* pAppointment, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentCalendar*, IAppointment*, IAsyncAction**, int>)(lpVtbl[31]))((IAppointmentCalendar*)Unsafe.AsPointer(ref this), pAppointment, asyncAction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DisplayColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(7)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_LocalId(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_IsHidden([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppReadAccess *")] AppointmentCalendarOtherAppReadAccess* value);

        [VtblIndex(12)]
        HRESULT put_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppReadAccess")] AppointmentCalendarOtherAppReadAccess value);

        [VtblIndex(13)]
        HRESULT get_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppWriteAccess *")] AppointmentCalendarOtherAppWriteAccess* value);

        [VtblIndex(14)]
        HRESULT put_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppWriteAccess")] AppointmentCalendarOtherAppWriteAccess value);

        [VtblIndex(15)]
        HRESULT get_SourceDisplayName(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_SummaryCardView([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentSummaryCardView *")] AppointmentSummaryCardView* value);

        [VtblIndex(17)]
        HRESULT put_SummaryCardView([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentSummaryCardView")] AppointmentSummaryCardView value);

        [VtblIndex(18)]
        HRESULT FindAppointmentsAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(19)]
        HRESULT FindAppointmentsAsyncWithOptions([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *")] IFindAppointmentsOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(20)]
        HRESULT FindExceptionsFromMasterAsync(HSTRING masterLocalId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentException_t **")] IAsyncOperation<IntPtr>** value);

        [VtblIndex(21)]
        HRESULT FindAllInstancesAsync(HSTRING masterLocalId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** value);

        [VtblIndex(22)]
        HRESULT FindAllInstancesAsyncWithOptions(HSTRING masterLocalId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength, [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *")] IFindAppointmentsOptions* pOptions, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** value);

        [VtblIndex(23)]
        HRESULT GetAppointmentAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(24)]
        HRESULT GetAppointmentInstanceAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartTime, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(25)]
        HRESULT FindUnexpandedAppointmentsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(26)]
        HRESULT FindUnexpandedAppointmentsAsyncWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *")] IFindAppointmentsOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(27)]
        HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);

        [VtblIndex(28)]
        HRESULT SaveAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);

        [VtblIndex(29)]
        HRESULT DeleteAppointmentAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);

        [VtblIndex(30)]
        HRESULT DeleteAppointmentInstanceAsync(HSTRING localId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartTime, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);

        [VtblIndex(31)]
        HRESULT SaveAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* pAppointment, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_DisplayColor;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LocalId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsHidden;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppReadAccess *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentCalendarOtherAppReadAccess*, int> get_OtherAppReadAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppReadAccess) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentCalendarOtherAppReadAccess, int> put_OtherAppReadAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppWriteAccess *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentCalendarOtherAppWriteAccess*, int> get_OtherAppWriteAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppWriteAccess) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentCalendarOtherAppWriteAccess, int> put_OtherAppWriteAccess;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SourceDisplayName;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentSummaryCardView *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentSummaryCardView*, int> get_SummaryCardView;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentSummaryCardView) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentSummaryCardView, int> put_SummaryCardView;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, TimeSpan, IAsyncOperation<IntPtr>**, int> FindAppointmentsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, TimeSpan, IFindAppointmentsOptions*, IAsyncOperation<IntPtr>**, int> FindAppointmentsAsyncWithOptions;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentException_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> FindExceptionsFromMasterAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, WinRTDateTime, TimeSpan, IAsyncOperation<IntPtr>**, int> FindAllInstancesAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, WinRTDateTime, TimeSpan, IFindAppointmentsOptions*, IAsyncOperation<IntPtr>**, int> FindAllInstancesAsyncWithOptions;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetAppointmentAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, WinRTDateTime, IAsyncOperation<IntPtr>**, int> GetAppointmentInstanceAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> FindUnexpandedAppointmentsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFindAppointmentsOptions*, IAsyncOperation<IntPtr>**, int> FindUnexpandedAppointmentsAsyncWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> DeleteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> SaveAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> DeleteAppointmentAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, WinRTDateTime, IAsyncAction**, int> DeleteAppointmentInstanceAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment*, IAsyncAction**, int> SaveAppointmentAsync;
    }
}
