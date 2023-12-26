// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.appointmentsprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoveAppointmentOperation.xml' path='doc/member[@name="IRemoveAppointmentOperation"]/*' />
[Guid("08B66ABA-FE33-46CD-A50C-A8FFB3260537")]
[NativeTypeName("struct IRemoveAppointmentOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoveAppointmentOperation : IRemoveAppointmentOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoveAppointmentOperation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoveAppointmentOperation*, Guid*, void**, int>)(lpVtbl[0]))((IRemoveAppointmentOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoveAppointmentOperation*, uint>)(lpVtbl[1]))((IRemoveAppointmentOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoveAppointmentOperation*, uint>)(lpVtbl[2]))((IRemoveAppointmentOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoveAppointmentOperation*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoveAppointmentOperation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoveAppointmentOperation*, HSTRING*, int>)(lpVtbl[4]))((IRemoveAppointmentOperation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoveAppointmentOperation*, TrustLevel*, int>)(lpVtbl[5]))((IRemoveAppointmentOperation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoveAppointmentOperation.xml' path='doc/member[@name="IRemoveAppointmentOperation.get_AppointmentId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AppointmentId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoveAppointmentOperation*, HSTRING*, int>)(lpVtbl[6]))((IRemoveAppointmentOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoveAppointmentOperation.xml' path='doc/member[@name="IRemoveAppointmentOperation.get_InstanceStartDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_InstanceStartDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoveAppointmentOperation*, IReference<DateTime>**, int>)(lpVtbl[7]))((IRemoveAppointmentOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoveAppointmentOperation.xml' path='doc/member[@name="IRemoveAppointmentOperation.get_SourcePackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SourcePackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoveAppointmentOperation*, HSTRING*, int>)(lpVtbl[8]))((IRemoveAppointmentOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoveAppointmentOperation.xml' path='doc/member[@name="IRemoveAppointmentOperation.ReportCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ReportCompleted()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoveAppointmentOperation*, int>)(lpVtbl[9]))((IRemoveAppointmentOperation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRemoveAppointmentOperation.xml' path='doc/member[@name="IRemoveAppointmentOperation.ReportCanceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReportCanceled()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoveAppointmentOperation*, int>)(lpVtbl[10]))((IRemoveAppointmentOperation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRemoveAppointmentOperation.xml' path='doc/member[@name="IRemoveAppointmentOperation.ReportError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ReportError(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoveAppointmentOperation*, HSTRING, int>)(lpVtbl[11]))((IRemoveAppointmentOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoveAppointmentOperation.xml' path='doc/member[@name="IRemoveAppointmentOperation.DismissUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DismissUI()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoveAppointmentOperation*, int>)(lpVtbl[12]))((IRemoveAppointmentOperation*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AppointmentId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_InstanceStartDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(8)]
        HRESULT get_SourcePackageFamilyName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT ReportCompleted();

        [VtblIndex(10)]
        HRESULT ReportCanceled();

        [VtblIndex(11)]
        HRESULT ReportError(HSTRING value);

        [VtblIndex(12)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_InstanceStartDate;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SourcePackageFamilyName;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ReportCompleted;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ReportCanceled;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> ReportError;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> DismissUI;
    }
}
