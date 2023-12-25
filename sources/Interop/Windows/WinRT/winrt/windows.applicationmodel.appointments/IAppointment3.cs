// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointment3.xml' path='doc/member[@name="IAppointment3"]/*' />
[Guid("BFCC45A9-8961-4991-934B-C48768E5A96C")]
[NativeTypeName("struct IAppointment3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointment3 : IAppointment3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointment3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointment3*, Guid*, void**, int>)(lpVtbl[0]))((IAppointment3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointment3*, uint>)(lpVtbl[1]))((IAppointment3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointment3*, uint>)(lpVtbl[2]))((IAppointment3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointment3*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointment3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointment3*, HSTRING*, int>)(lpVtbl[4]))((IAppointment3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointment3*, TrustLevel*, int>)(lpVtbl[5]))((IAppointment3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointment3.xml' path='doc/member[@name="IAppointment3.get_ChangeNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChangeNumber([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointment3*, ulong*, int>)(lpVtbl[6]))((IAppointment3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointment3.xml' path='doc/member[@name="IAppointment3.get_RemoteChangeNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RemoteChangeNumber([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointment3*, ulong*, int>)(lpVtbl[7]))((IAppointment3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointment3.xml' path='doc/member[@name="IAppointment3.put_RemoteChangeNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_RemoteChangeNumber([NativeTypeName("UINT64")] ulong value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointment3*, ulong, int>)(lpVtbl[8]))((IAppointment3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointment3.xml' path='doc/member[@name="IAppointment3.get_DetailsKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DetailsKind([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentDetailsKind *")] AppointmentDetailsKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointment3*, AppointmentDetailsKind*, int>)(lpVtbl[9]))((IAppointment3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointment3.xml' path='doc/member[@name="IAppointment3.put_DetailsKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_DetailsKind([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentDetailsKind")] AppointmentDetailsKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointment3*, AppointmentDetailsKind, int>)(lpVtbl[10]))((IAppointment3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ChangeNumber([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        HRESULT get_RemoteChangeNumber([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(8)]
        HRESULT put_RemoteChangeNumber([NativeTypeName("UINT64")] ulong value);

        [VtblIndex(9)]
        HRESULT get_DetailsKind([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentDetailsKind *")] AppointmentDetailsKind* value);

        [VtblIndex(10)]
        HRESULT put_DetailsKind([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentDetailsKind")] AppointmentDetailsKind value);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_ChangeNumber;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_RemoteChangeNumber;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, int> put_RemoteChangeNumber;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentDetailsKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentDetailsKind*, int> get_DetailsKind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentDetailsKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppointmentDetailsKind, int> put_DetailsKind;
    }
}
