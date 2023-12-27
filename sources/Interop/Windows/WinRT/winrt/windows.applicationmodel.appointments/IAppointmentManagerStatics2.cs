// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentManagerStatics2.xml' path='doc/member[@name="IAppointmentManagerStatics2"]/*' />
[Guid("0A81F60D-D04F-4034-AF72-A36573B45FF0")]
[NativeTypeName("struct IAppointmentManagerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentManagerStatics2 : IAppointmentManagerStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentManagerStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentManagerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics2*, uint>)(lpVtbl[1]))((IAppointmentManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics2*, uint>)(lpVtbl[2]))((IAppointmentManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentManagerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics2*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentManagerStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentManagerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentManagerStatics2.xml' path='doc/member[@name="IAppointmentManagerStatics2.ShowAppointmentDetailsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ShowAppointmentDetailsAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics2*, HSTRING, IAsyncAction**, int>)(lpVtbl[6]))((IAppointmentManagerStatics2*)Unsafe.AsPointer(ref this), appointmentId, asyncAction);
    }

    /// <include file='IAppointmentManagerStatics2.xml' path='doc/member[@name="IAppointmentManagerStatics2.ShowAppointmentDetailsWithDateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ShowAppointmentDetailsWithDateAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics2*, HSTRING, WinRTDateTime, IAsyncAction**, int>)(lpVtbl[7]))((IAppointmentManagerStatics2*)Unsafe.AsPointer(ref this), appointmentId, instanceStartDate, asyncAction);
    }

    /// <include file='IAppointmentManagerStatics2.xml' path='doc/member[@name="IAppointmentManagerStatics2.ShowEditNewAppointmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ShowEditNewAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics2*, IAppointment*, IAsyncOperation<HSTRING>**, int>)(lpVtbl[8]))((IAppointmentManagerStatics2*)Unsafe.AsPointer(ref this), appointment, operation);
    }

    /// <include file='IAppointmentManagerStatics2.xml' path='doc/member[@name="IAppointmentManagerStatics2.RequestStoreAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentStoreAccessType")] AppointmentStoreAccessType options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentStore_t **")] IAsyncOperation<Pointer<IAppointmentStore>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentManagerStatics2*, AppointmentStoreAccessType, IAsyncOperation<Pointer<IAppointmentStore>>**, int>)(lpVtbl[9]))((IAppointmentManagerStatics2*)Unsafe.AsPointer(ref this), options, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ShowAppointmentDetailsAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);

        [VtblIndex(7)]
        HRESULT ShowAppointmentDetailsWithDateAsync(HSTRING appointmentId, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);

        [VtblIndex(8)]
        HRESULT ShowEditNewAppointmentAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")] IAppointment* appointment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(9)]
        HRESULT RequestStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentStoreAccessType")] AppointmentStoreAccessType options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentStore_t **")] IAsyncOperation<Pointer<IAppointmentStore>>** operation);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> ShowAppointmentDetailsAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, WinRTDateTime, IAsyncAction**, int> ShowAppointmentDetailsWithDateAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment*, IAsyncOperation<HSTRING>**, int> ShowEditNewAppointmentAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentStoreAccessType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentStore_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentStoreAccessType, IAsyncOperation<Pointer<IAppointmentStore>>**, int> RequestStoreAsync;
    }
}
