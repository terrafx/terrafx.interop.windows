// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.appointmentsprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAddAppointmentOperation.xml' path='doc/member[@name="IAddAppointmentOperation"]/*' />
[Guid("EC4A9AF3-620D-4C69-ADD7-9794E918081F")]
[NativeTypeName("struct IAddAppointmentOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAddAppointmentOperation : IAddAppointmentOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAddAppointmentOperation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAddAppointmentOperation*, Guid*, void**, int>)(lpVtbl[0]))((IAddAppointmentOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAddAppointmentOperation*, uint>)(lpVtbl[1]))((IAddAppointmentOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAddAppointmentOperation*, uint>)(lpVtbl[2]))((IAddAppointmentOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAddAppointmentOperation*, uint*, Guid**, int>)(lpVtbl[3]))((IAddAppointmentOperation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAddAppointmentOperation*, HSTRING*, int>)(lpVtbl[4]))((IAddAppointmentOperation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAddAppointmentOperation*, TrustLevel*, int>)(lpVtbl[5]))((IAddAppointmentOperation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAddAppointmentOperation.xml' path='doc/member[@name="IAddAppointmentOperation.get_AppointmentInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AppointmentInformation([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment **")] IAppointment** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAddAppointmentOperation*, IAppointment**, int>)(lpVtbl[6]))((IAddAppointmentOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAddAppointmentOperation.xml' path='doc/member[@name="IAddAppointmentOperation.get_SourcePackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SourcePackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAddAppointmentOperation*, HSTRING*, int>)(lpVtbl[7]))((IAddAppointmentOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAddAppointmentOperation.xml' path='doc/member[@name="IAddAppointmentOperation.ReportCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReportCompleted(HSTRING itemId)
    {
        return ((delegate* unmanaged[MemberFunction]<IAddAppointmentOperation*, HSTRING, int>)(lpVtbl[8]))((IAddAppointmentOperation*)Unsafe.AsPointer(ref this), itemId);
    }

    /// <include file='IAddAppointmentOperation.xml' path='doc/member[@name="IAddAppointmentOperation.ReportCanceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ReportCanceled()
    {
        return ((delegate* unmanaged[MemberFunction]<IAddAppointmentOperation*, int>)(lpVtbl[9]))((IAddAppointmentOperation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAddAppointmentOperation.xml' path='doc/member[@name="IAddAppointmentOperation.ReportError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReportError(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAddAppointmentOperation*, HSTRING, int>)(lpVtbl[10]))((IAddAppointmentOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAddAppointmentOperation.xml' path='doc/member[@name="IAddAppointmentOperation.DismissUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DismissUI()
    {
        return ((delegate* unmanaged[MemberFunction]<IAddAppointmentOperation*, int>)(lpVtbl[11]))((IAddAppointmentOperation*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AppointmentInformation([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment **")] IAppointment** value);

        [VtblIndex(7)]
        HRESULT get_SourcePackageFamilyName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT ReportCompleted(HSTRING itemId);

        [VtblIndex(9)]
        HRESULT ReportCanceled();

        [VtblIndex(10)]
        HRESULT ReportError(HSTRING value);

        [VtblIndex(11)]
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointment**, int> get_AppointmentInformation;

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
