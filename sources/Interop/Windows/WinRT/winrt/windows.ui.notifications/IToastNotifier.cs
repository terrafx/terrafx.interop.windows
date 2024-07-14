// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IToastNotifier.xml' path='doc/member[@name="IToastNotifier"]/*' />
[Guid("75927B93-03F3-41EC-91D3-6E5BAC1B38E7")]
[NativeTypeName("struct IToastNotifier : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotifier : IToastNotifier.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastNotifier));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier*, Guid*, void**, int>)(lpVtbl[0]))((IToastNotifier*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier*, uint>)(lpVtbl[1]))((IToastNotifier*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier*, uint>)(lpVtbl[2]))((IToastNotifier*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier*, uint*, Guid**, int>)(lpVtbl[3]))((IToastNotifier*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier*, HSTRING*, int>)(lpVtbl[4]))((IToastNotifier*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier*, TrustLevel*, int>)(lpVtbl[5]))((IToastNotifier*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IToastNotifier.xml' path='doc/member[@name="IToastNotifier.Show"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Show([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")] IToastNotification* notification)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier*, IToastNotification*, int>)(lpVtbl[6]))((IToastNotifier*)Unsafe.AsPointer(ref this), notification);
    }

    /// <include file='IToastNotifier.xml' path='doc/member[@name="IToastNotifier.Hide"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Hide([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")] IToastNotification* notification)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier*, IToastNotification*, int>)(lpVtbl[7]))((IToastNotifier*)Unsafe.AsPointer(ref this), notification);
    }

    /// <include file='IToastNotifier.xml' path='doc/member[@name="IToastNotifier.get_Setting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Setting([NativeTypeName("ABI::Windows::UI::Notifications::NotificationSetting *")] NotificationSetting* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier*, NotificationSetting*, int>)(lpVtbl[8]))((IToastNotifier*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IToastNotifier.xml' path='doc/member[@name="IToastNotifier.AddToSchedule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddToSchedule([NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification *")] IScheduledToastNotification* scheduledToast)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier*, IScheduledToastNotification*, int>)(lpVtbl[9]))((IToastNotifier*)Unsafe.AsPointer(ref this), scheduledToast);
    }

    /// <include file='IToastNotifier.xml' path='doc/member[@name="IToastNotifier.RemoveFromSchedule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RemoveFromSchedule([NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification *")] IScheduledToastNotification* scheduledToast)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier*, IScheduledToastNotification*, int>)(lpVtbl[10]))((IToastNotifier*)Unsafe.AsPointer(ref this), scheduledToast);
    }

    /// <include file='IToastNotifier.xml' path='doc/member[@name="IToastNotifier.GetScheduledToastNotifications"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetScheduledToastNotifications([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CScheduledToastNotification_t **")] IVectorView<Pointer<IScheduledToastNotification>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier*, IVectorView<Pointer<IScheduledToastNotification>>**, int>)(lpVtbl[11]))((IToastNotifier*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Show([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")] IToastNotification* notification);

        [VtblIndex(7)]
        HRESULT Hide([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")] IToastNotification* notification);

        [VtblIndex(8)]
        HRESULT get_Setting([NativeTypeName("ABI::Windows::UI::Notifications::NotificationSetting *")] NotificationSetting* value);

        [VtblIndex(9)]
        HRESULT AddToSchedule([NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification *")] IScheduledToastNotification* scheduledToast);

        [VtblIndex(10)]
        HRESULT RemoveFromSchedule([NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification *")] IScheduledToastNotification* scheduledToast);

        [VtblIndex(11)]
        HRESULT GetScheduledToastNotifications([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CScheduledToastNotification_t **")] IVectorView<Pointer<IScheduledToastNotification>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IToastNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IToastNotification*, int> Show;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IToastNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IToastNotification*, int> Hide;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::NotificationSetting *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, NotificationSetting*, int> get_Setting;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IScheduledToastNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IScheduledToastNotification*, int> AddToSchedule;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IScheduledToastNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IScheduledToastNotification*, int> RemoveFromSchedule;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CScheduledToastNotification_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IScheduledToastNotification>>**, int> GetScheduledToastNotifications;
    }
}
