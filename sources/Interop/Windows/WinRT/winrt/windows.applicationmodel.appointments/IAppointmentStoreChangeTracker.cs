// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentStoreChangeTracker.xml' path='doc/member[@name="IAppointmentStoreChangeTracker"]/*' />
[Guid("1B25F4B1-8ECE-4F17-93C8-E6412458FD5C")]
[NativeTypeName("struct IAppointmentStoreChangeTracker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentStoreChangeTracker : IAppointmentStoreChangeTracker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentStoreChangeTracker));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeTracker*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentStoreChangeTracker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeTracker*, uint>)(lpVtbl[1]))((IAppointmentStoreChangeTracker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeTracker*, uint>)(lpVtbl[2]))((IAppointmentStoreChangeTracker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeTracker*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentStoreChangeTracker*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeTracker*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentStoreChangeTracker*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeTracker*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentStoreChangeTracker*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentStoreChangeTracker.xml' path='doc/member[@name="IAppointmentStoreChangeTracker.GetChangeReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetChangeReader([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentStoreChangeReader **")] IAppointmentStoreChangeReader** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeTracker*, IAppointmentStoreChangeReader**, int>)(lpVtbl[6]))((IAppointmentStoreChangeTracker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentStoreChangeTracker.xml' path='doc/member[@name="IAppointmentStoreChangeTracker.Enable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Enable()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeTracker*, int>)(lpVtbl[7]))((IAppointmentStoreChangeTracker*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppointmentStoreChangeTracker.xml' path='doc/member[@name="IAppointmentStoreChangeTracker.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeTracker*, int>)(lpVtbl[8]))((IAppointmentStoreChangeTracker*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetChangeReader([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentStoreChangeReader **")] IAppointmentStoreChangeReader** value);

        [VtblIndex(7)]
        HRESULT Enable();

        [VtblIndex(8)]
        HRESULT Reset();
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointmentStoreChangeReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointmentStoreChangeReader**, int> GetChangeReader;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Enable;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Reset;
    }
}
