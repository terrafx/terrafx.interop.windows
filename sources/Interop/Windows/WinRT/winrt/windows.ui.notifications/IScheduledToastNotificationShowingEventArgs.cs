// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IScheduledToastNotificationShowingEventArgs.xml' path='doc/member[@name="IScheduledToastNotificationShowingEventArgs"]/*' />
[Guid("6173F6B4-412A-5E2C-A6ED-A0209AEF9A09")]
[NativeTypeName("struct IScheduledToastNotificationShowingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IScheduledToastNotificationShowingEventArgs : IScheduledToastNotificationShowingEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IScheduledToastNotificationShowingEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationShowingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IScheduledToastNotificationShowingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationShowingEventArgs*, uint>)(lpVtbl[1]))((IScheduledToastNotificationShowingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationShowingEventArgs*, uint>)(lpVtbl[2]))((IScheduledToastNotificationShowingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationShowingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IScheduledToastNotificationShowingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationShowingEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IScheduledToastNotificationShowingEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationShowingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IScheduledToastNotificationShowingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IScheduledToastNotificationShowingEventArgs.xml' path='doc/member[@name="IScheduledToastNotificationShowingEventArgs.get_Cancel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Cancel([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationShowingEventArgs*, byte*, int>)(lpVtbl[6]))((IScheduledToastNotificationShowingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledToastNotificationShowingEventArgs.xml' path='doc/member[@name="IScheduledToastNotificationShowingEventArgs.put_Cancel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Cancel([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationShowingEventArgs*, byte, int>)(lpVtbl[7]))((IScheduledToastNotificationShowingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledToastNotificationShowingEventArgs.xml' path='doc/member[@name="IScheduledToastNotificationShowingEventArgs.get_ScheduledToastNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ScheduledToastNotification([NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification **")] IScheduledToastNotification** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationShowingEventArgs*, IScheduledToastNotification**, int>)(lpVtbl[8]))((IScheduledToastNotificationShowingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledToastNotificationShowingEventArgs.xml' path='doc/member[@name="IScheduledToastNotificationShowingEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationShowingEventArgs*, IDeferral**, int>)(lpVtbl[9]))((IScheduledToastNotificationShowingEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Cancel([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_Cancel([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_ScheduledToastNotification([NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification **")] IScheduledToastNotification** value);

        [VtblIndex(9)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Cancel;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_Cancel;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IScheduledToastNotification **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IScheduledToastNotification**, int> get_ScheduledToastNotification;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
