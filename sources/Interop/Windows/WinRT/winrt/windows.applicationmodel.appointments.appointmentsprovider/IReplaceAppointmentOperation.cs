// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.appointmentsprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IReplaceAppointmentOperation.xml' path='doc/member[@name="IReplaceAppointmentOperation"]/*' />
[Guid("F4903D9B-9E61-4DE2-A732-2687C07D1DE8")]
[NativeTypeName("struct IReplaceAppointmentOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IReplaceAppointmentOperation : IReplaceAppointmentOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IReplaceAppointmentOperation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceAppointmentOperation*, Guid*, void**, int>)(lpVtbl[0]))((IReplaceAppointmentOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceAppointmentOperation*, uint>)(lpVtbl[1]))((IReplaceAppointmentOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceAppointmentOperation*, uint>)(lpVtbl[2]))((IReplaceAppointmentOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceAppointmentOperation*, uint*, Guid**, int>)(lpVtbl[3]))((IReplaceAppointmentOperation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceAppointmentOperation*, HSTRING*, int>)(lpVtbl[4]))((IReplaceAppointmentOperation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceAppointmentOperation*, TrustLevel*, int>)(lpVtbl[5]))((IReplaceAppointmentOperation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IReplaceAppointmentOperation.xml' path='doc/member[@name="IReplaceAppointmentOperation.get_AppointmentId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AppointmentId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceAppointmentOperation*, HSTRING*, int>)(lpVtbl[6]))((IReplaceAppointmentOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReplaceAppointmentOperation.xml' path='doc/member[@name="IReplaceAppointmentOperation.get_AppointmentInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AppointmentInformation([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment **")] IAppointment** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceAppointmentOperation*, IAppointment**, int>)(lpVtbl[7]))((IReplaceAppointmentOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReplaceAppointmentOperation.xml' path='doc/member[@name="IReplaceAppointmentOperation.get_InstanceStartDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InstanceStartDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceAppointmentOperation*, IReference<DateTime>**, int>)(lpVtbl[8]))((IReplaceAppointmentOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReplaceAppointmentOperation.xml' path='doc/member[@name="IReplaceAppointmentOperation.get_SourcePackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SourcePackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceAppointmentOperation*, HSTRING*, int>)(lpVtbl[9]))((IReplaceAppointmentOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReplaceAppointmentOperation.xml' path='doc/member[@name="IReplaceAppointmentOperation.ReportCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReportCompleted(HSTRING itemId)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceAppointmentOperation*, HSTRING, int>)(lpVtbl[10]))((IReplaceAppointmentOperation*)Unsafe.AsPointer(ref this), itemId);
    }

    /// <include file='IReplaceAppointmentOperation.xml' path='doc/member[@name="IReplaceAppointmentOperation.ReportCanceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ReportCanceled()
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceAppointmentOperation*, int>)(lpVtbl[11]))((IReplaceAppointmentOperation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IReplaceAppointmentOperation.xml' path='doc/member[@name="IReplaceAppointmentOperation.ReportError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ReportError(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceAppointmentOperation*, HSTRING, int>)(lpVtbl[12]))((IReplaceAppointmentOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReplaceAppointmentOperation.xml' path='doc/member[@name="IReplaceAppointmentOperation.DismissUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DismissUI()
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceAppointmentOperation*, int>)(lpVtbl[13]))((IReplaceAppointmentOperation*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AppointmentId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_AppointmentInformation([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment **")] IAppointment** value);

        [VtblIndex(8)]
        HRESULT get_InstanceStartDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(9)]
        HRESULT get_SourcePackageFamilyName(HSTRING* value);

        [VtblIndex(10)]
        HRESULT ReportCompleted(HSTRING itemId);

        [VtblIndex(11)]
        HRESULT ReportCanceled();

        [VtblIndex(12)]
        HRESULT ReportError(HSTRING value);

        [VtblIndex(13)]
        HRESULT DismissUI();
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AppointmentId;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment**, int> get_AppointmentInformation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_InstanceStartDate;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SourcePackageFamilyName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> ReportCompleted;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ReportCanceled;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> ReportError;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> DismissUI;
    }
}
