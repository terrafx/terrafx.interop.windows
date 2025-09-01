// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentRecurrence2.xml' path='doc/member[@name="IAppointmentRecurrence2"]/*' />
[Guid("3DF3A2E0-05A7-4F50-9F86-B03F9436254D")]
[NativeTypeName("struct IAppointmentRecurrence2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentRecurrence2 : IAppointmentRecurrence2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppointmentRecurrence2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence2*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentRecurrence2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence2*, uint>)(lpVtbl[1]))((IAppointmentRecurrence2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence2*, uint>)(lpVtbl[2]))((IAppointmentRecurrence2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentRecurrence2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence2*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentRecurrence2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence2*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentRecurrence2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentRecurrence2.xml' path='doc/member[@name="IAppointmentRecurrence2.get_RecurrenceType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_RecurrenceType([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::RecurrenceType *")] RecurrenceType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence2*, RecurrenceType*, int>)(lpVtbl[6]))((IAppointmentRecurrence2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence2.xml' path='doc/member[@name="IAppointmentRecurrence2.get_TimeZone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TimeZone(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence2*, HSTRING*, int>)(lpVtbl[7]))((IAppointmentRecurrence2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentRecurrence2.xml' path='doc/member[@name="IAppointmentRecurrence2.put_TimeZone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_TimeZone(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentRecurrence2*, HSTRING, int>)(lpVtbl[8]))((IAppointmentRecurrence2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_RecurrenceType([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::RecurrenceType *")] RecurrenceType* value);

        [VtblIndex(7)]
        HRESULT get_TimeZone(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_TimeZone(HSTRING value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::RecurrenceType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RecurrenceType*, int> get_RecurrenceType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TimeZone;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_TimeZone;
    }
}
