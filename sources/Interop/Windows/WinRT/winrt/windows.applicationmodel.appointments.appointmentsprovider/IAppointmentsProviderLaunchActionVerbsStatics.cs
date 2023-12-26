// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.appointmentsprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentsProviderLaunchActionVerbsStatics.xml' path='doc/member[@name="IAppointmentsProviderLaunchActionVerbsStatics"]/*' />
[Guid("36DBBA28-9E2E-49C6-8EF7-3AB7A5DCC8B8")]
[NativeTypeName("struct IAppointmentsProviderLaunchActionVerbsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentsProviderLaunchActionVerbsStatics : IAppointmentsProviderLaunchActionVerbsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentsProviderLaunchActionVerbsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderLaunchActionVerbsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentsProviderLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderLaunchActionVerbsStatics*, uint>)(lpVtbl[1]))((IAppointmentsProviderLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderLaunchActionVerbsStatics*, uint>)(lpVtbl[2]))((IAppointmentsProviderLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderLaunchActionVerbsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentsProviderLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderLaunchActionVerbsStatics*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentsProviderLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderLaunchActionVerbsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentsProviderLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentsProviderLaunchActionVerbsStatics.xml' path='doc/member[@name="IAppointmentsProviderLaunchActionVerbsStatics.get_AddAppointment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AddAppointment(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderLaunchActionVerbsStatics*, HSTRING*, int>)(lpVtbl[6]))((IAppointmentsProviderLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentsProviderLaunchActionVerbsStatics.xml' path='doc/member[@name="IAppointmentsProviderLaunchActionVerbsStatics.get_ReplaceAppointment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ReplaceAppointment(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderLaunchActionVerbsStatics*, HSTRING*, int>)(lpVtbl[7]))((IAppointmentsProviderLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentsProviderLaunchActionVerbsStatics.xml' path='doc/member[@name="IAppointmentsProviderLaunchActionVerbsStatics.get_RemoveAppointment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RemoveAppointment(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderLaunchActionVerbsStatics*, HSTRING*, int>)(lpVtbl[8]))((IAppointmentsProviderLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentsProviderLaunchActionVerbsStatics.xml' path='doc/member[@name="IAppointmentsProviderLaunchActionVerbsStatics.get_ShowTimeFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ShowTimeFrame(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderLaunchActionVerbsStatics*, HSTRING*, int>)(lpVtbl[9]))((IAppointmentsProviderLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AddAppointment(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ReplaceAppointment(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_RemoveAppointment(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_ShowTimeFrame(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AddAppointment;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ReplaceAppointment;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemoveAppointment;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ShowTimeFrame;
    }
}
