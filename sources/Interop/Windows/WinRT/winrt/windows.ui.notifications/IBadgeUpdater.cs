// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBadgeUpdater.xml' path='doc/member[@name="IBadgeUpdater"]/*' />
[Guid("B5FA1FD4-7562-4F6C-BFA3-1B6ED2E57F2F")]
[NativeTypeName("struct IBadgeUpdater : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBadgeUpdater : IBadgeUpdater.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBadgeUpdater));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdater*, Guid*, void**, int>)(lpVtbl[0]))((IBadgeUpdater*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdater*, uint>)(lpVtbl[1]))((IBadgeUpdater*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdater*, uint>)(lpVtbl[2]))((IBadgeUpdater*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdater*, uint*, Guid**, int>)(lpVtbl[3]))((IBadgeUpdater*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdater*, HSTRING*, int>)(lpVtbl[4]))((IBadgeUpdater*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdater*, TrustLevel*, int>)(lpVtbl[5]))((IBadgeUpdater*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBadgeUpdater.xml' path='doc/member[@name="IBadgeUpdater.Update"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Update([NativeTypeName("ABI::Windows::UI::Notifications::IBadgeNotification *")] IBadgeNotification* notification)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdater*, IBadgeNotification*, int>)(lpVtbl[6]))((IBadgeUpdater*)Unsafe.AsPointer(ref this), notification);
    }

    /// <include file='IBadgeUpdater.xml' path='doc/member[@name="IBadgeUpdater.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdater*, int>)(lpVtbl[7]))((IBadgeUpdater*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBadgeUpdater.xml' path='doc/member[@name="IBadgeUpdater.StartPeriodicUpdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartPeriodicUpdate([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* badgeContent, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdater*, IUriRuntimeClass*, PeriodicUpdateRecurrence, int>)(lpVtbl[8]))((IBadgeUpdater*)Unsafe.AsPointer(ref this), badgeContent, requestedInterval);
    }

    /// <include file='IBadgeUpdater.xml' path='doc/member[@name="IBadgeUpdater.StartPeriodicUpdateAtTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StartPeriodicUpdateAtTime([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* badgeContent, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdater*, IUriRuntimeClass*, WinRTDateTime, PeriodicUpdateRecurrence, int>)(lpVtbl[9]))((IBadgeUpdater*)Unsafe.AsPointer(ref this), badgeContent, startTime, requestedInterval);
    }

    /// <include file='IBadgeUpdater.xml' path='doc/member[@name="IBadgeUpdater.StopPeriodicUpdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StopPeriodicUpdate()
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdater*, int>)(lpVtbl[10]))((IBadgeUpdater*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Update([NativeTypeName("ABI::Windows::UI::Notifications::IBadgeNotification *")] IBadgeNotification* notification);

        [VtblIndex(7)]
        HRESULT Clear();

        [VtblIndex(8)]
        HRESULT StartPeriodicUpdate([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* badgeContent, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval);

        [VtblIndex(9)]
        HRESULT StartPeriodicUpdateAtTime([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* badgeContent, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval);

        [VtblIndex(10)]
        HRESULT StopPeriodicUpdate();
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IBadgeNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBadgeNotification*, int> Update;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Clear;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, PeriodicUpdateRecurrence, int> StartPeriodicUpdate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::DateTime, ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, WinRTDateTime, PeriodicUpdateRecurrence, int> StartPeriodicUpdateAtTime;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> StopPeriodicUpdate;
    }
}
