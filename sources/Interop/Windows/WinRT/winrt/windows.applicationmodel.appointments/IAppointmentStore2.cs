// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentStore2.xml' path='doc/member[@name="IAppointmentStore2"]/*' />
[Guid("25C48C20-1C41-424F-8084-67C1CFE0A854")]
[NativeTypeName("struct IAppointmentStore2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentStore2 : IAppointmentStore2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentStore2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore2*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentStore2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore2*, uint>)(lpVtbl[1]))((IAppointmentStore2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore2*, uint>)(lpVtbl[2]))((IAppointmentStore2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentStore2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore2*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentStore2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore2*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentStore2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentStore2.xml' path='doc/member[@name="IAppointmentStore2.add_StoreChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_StoreChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CAppointments__CAppointmentStore_Windows__CApplicationModel__CAppointments__CAppointmentStoreChangedEventArgs_t *")] ITypedEventHandler<Pointer<IAppointmentStore>, Pointer<IAppointmentStoreChangedEventArgs>>* pHandler, EventRegistrationToken* pToken)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore2*, ITypedEventHandler<Pointer<IAppointmentStore>, Pointer<IAppointmentStoreChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IAppointmentStore2*)Unsafe.AsPointer(ref this), pHandler, pToken);
    }

    /// <include file='IAppointmentStore2.xml' path='doc/member[@name="IAppointmentStore2.remove_StoreChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_StoreChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore2*, EventRegistrationToken, int>)(lpVtbl[7]))((IAppointmentStore2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppointmentStore2.xml' path='doc/member[@name="IAppointmentStore2.CreateAppointmentCalendarInAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateAppointmentCalendarInAccountAsync(HSTRING name, HSTRING userDataAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **")] IAsyncOperation<Pointer<IAppointmentCalendar>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStore2*, HSTRING, HSTRING, IAsyncOperation<Pointer<IAppointmentCalendar>>**, int>)(lpVtbl[8]))((IAppointmentStore2*)Unsafe.AsPointer(ref this), name, userDataAccountId, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_StoreChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CAppointments__CAppointmentStore_Windows__CApplicationModel__CAppointments__CAppointmentStoreChangedEventArgs_t *")] ITypedEventHandler<Pointer<IAppointmentStore>, Pointer<IAppointmentStoreChangedEventArgs>>* pHandler, EventRegistrationToken* pToken);

        [VtblIndex(7)]
        HRESULT remove_StoreChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT CreateAppointmentCalendarInAccountAsync(HSTRING name, HSTRING userDataAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **")] IAsyncOperation<Pointer<IAppointmentCalendar>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CAppointments__CAppointmentStore_Windows__CApplicationModel__CAppointments__CAppointmentStoreChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppointmentStore>, Pointer<IAppointmentStoreChangedEventArgs>>*, EventRegistrationToken*, int> add_StoreChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StoreChanged;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<Pointer<IAppointmentCalendar>>**, int> CreateAppointmentCalendarInAccountAsync;
    }
}
