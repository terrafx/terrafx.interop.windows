// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITileFlyoutUpdater.xml' path='doc/member[@name="ITileFlyoutUpdater"]/*' />
[Guid("8D40C76A-C465-4052-A740-5C2654C1A089")]
[NativeTypeName("struct ITileFlyoutUpdater : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITileFlyoutUpdater : ITileFlyoutUpdater.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITileFlyoutUpdater));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdater*, Guid*, void**, int>)(lpVtbl[0]))((ITileFlyoutUpdater*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdater*, uint>)(lpVtbl[1]))((ITileFlyoutUpdater*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdater*, uint>)(lpVtbl[2]))((ITileFlyoutUpdater*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdater*, uint*, Guid**, int>)(lpVtbl[3]))((ITileFlyoutUpdater*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdater*, HSTRING*, int>)(lpVtbl[4]))((ITileFlyoutUpdater*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdater*, TrustLevel*, int>)(lpVtbl[5]))((ITileFlyoutUpdater*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITileFlyoutUpdater.xml' path='doc/member[@name="ITileFlyoutUpdater.Update"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Update([NativeTypeName("ABI::Windows::UI::Notifications::ITileFlyoutNotification *")] ITileFlyoutNotification* notification)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdater*, ITileFlyoutNotification*, int>)(lpVtbl[6]))((ITileFlyoutUpdater*)Unsafe.AsPointer(ref this), notification);
    }

    /// <include file='ITileFlyoutUpdater.xml' path='doc/member[@name="ITileFlyoutUpdater.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdater*, int>)(lpVtbl[7]))((ITileFlyoutUpdater*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITileFlyoutUpdater.xml' path='doc/member[@name="ITileFlyoutUpdater.StartPeriodicUpdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartPeriodicUpdate([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* tileFlyoutContent, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdater*, IUriRuntimeClass*, PeriodicUpdateRecurrence, int>)(lpVtbl[8]))((ITileFlyoutUpdater*)Unsafe.AsPointer(ref this), tileFlyoutContent, requestedInterval);
    }

    /// <include file='ITileFlyoutUpdater.xml' path='doc/member[@name="ITileFlyoutUpdater.StartPeriodicUpdateAtTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StartPeriodicUpdateAtTime([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* tileFlyoutContent, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdater*, IUriRuntimeClass*, WinRTDateTime, PeriodicUpdateRecurrence, int>)(lpVtbl[9]))((ITileFlyoutUpdater*)Unsafe.AsPointer(ref this), tileFlyoutContent, startTime, requestedInterval);
    }

    /// <include file='ITileFlyoutUpdater.xml' path='doc/member[@name="ITileFlyoutUpdater.StopPeriodicUpdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StopPeriodicUpdate()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdater*, int>)(lpVtbl[10]))((ITileFlyoutUpdater*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITileFlyoutUpdater.xml' path='doc/member[@name="ITileFlyoutUpdater.get_Setting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Setting([NativeTypeName("ABI::Windows::UI::Notifications::NotificationSetting *")] NotificationSetting* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdater*, NotificationSetting*, int>)(lpVtbl[11]))((ITileFlyoutUpdater*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Update([NativeTypeName("ABI::Windows::UI::Notifications::ITileFlyoutNotification *")] ITileFlyoutNotification* notification);

        [VtblIndex(7)]
        HRESULT Clear();

        [VtblIndex(8)]
        HRESULT StartPeriodicUpdate([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* tileFlyoutContent, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval);

        [VtblIndex(9)]
        HRESULT StartPeriodicUpdateAtTime([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* tileFlyoutContent, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval);

        [VtblIndex(10)]
        HRESULT StopPeriodicUpdate();

        [VtblIndex(11)]
        HRESULT get_Setting([NativeTypeName("ABI::Windows::UI::Notifications::NotificationSetting *")] NotificationSetting* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::ITileFlyoutNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITileFlyoutNotification*, int> Update;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Clear;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, PeriodicUpdateRecurrence, int> StartPeriodicUpdate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::DateTime, ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, WinRTDateTime, PeriodicUpdateRecurrence, int> StartPeriodicUpdateAtTime;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> StopPeriodicUpdate;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::NotificationSetting *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, NotificationSetting*, int> get_Setting;
    }
}
