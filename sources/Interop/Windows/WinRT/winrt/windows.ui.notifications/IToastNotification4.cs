// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IToastNotification4.xml' path='doc/member[@name="IToastNotification4"]/*' />
[Guid("15154935-28EA-4727-88E9-C58680E2D118")]
[NativeTypeName("struct IToastNotification4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotification4 : IToastNotification4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastNotification4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification4*, Guid*, void**, int>)(lpVtbl[0]))((IToastNotification4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification4*, uint>)(lpVtbl[1]))((IToastNotification4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification4*, uint>)(lpVtbl[2]))((IToastNotification4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification4*, uint*, Guid**, int>)(lpVtbl[3]))((IToastNotification4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification4*, HSTRING*, int>)(lpVtbl[4]))((IToastNotification4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification4*, TrustLevel*, int>)(lpVtbl[5]))((IToastNotification4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IToastNotification4.xml' path='doc/member[@name="IToastNotification4.get_Data"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Data([NativeTypeName("ABI::Windows::UI::Notifications::INotificationData **")] INotificationData** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification4*, INotificationData**, int>)(lpVtbl[6]))((IToastNotification4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IToastNotification4.xml' path='doc/member[@name="IToastNotification4.put_Data"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Data([NativeTypeName("ABI::Windows::UI::Notifications::INotificationData *")] INotificationData* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification4*, INotificationData*, int>)(lpVtbl[7]))((IToastNotification4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IToastNotification4.xml' path='doc/member[@name="IToastNotification4.get_Priority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Priority([NativeTypeName("ABI::Windows::UI::Notifications::ToastNotificationPriority *")] ToastNotificationPriority* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification4*, ToastNotificationPriority*, int>)(lpVtbl[8]))((IToastNotification4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IToastNotification4.xml' path='doc/member[@name="IToastNotification4.put_Priority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Priority([NativeTypeName("ABI::Windows::UI::Notifications::ToastNotificationPriority")] ToastNotificationPriority value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification4*, ToastNotificationPriority, int>)(lpVtbl[9]))((IToastNotification4*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Data([NativeTypeName("ABI::Windows::UI::Notifications::INotificationData **")] INotificationData** value);

        [VtblIndex(7)]
        HRESULT put_Data([NativeTypeName("ABI::Windows::UI::Notifications::INotificationData *")] INotificationData* value);

        [VtblIndex(8)]
        HRESULT get_Priority([NativeTypeName("ABI::Windows::UI::Notifications::ToastNotificationPriority *")] ToastNotificationPriority* value);

        [VtblIndex(9)]
        HRESULT put_Priority([NativeTypeName("ABI::Windows::UI::Notifications::ToastNotificationPriority")] ToastNotificationPriority value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::INotificationData **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, INotificationData**, int> get_Data;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::INotificationData *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, INotificationData*, int> put_Data;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::ToastNotificationPriority *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ToastNotificationPriority*, int> get_Priority;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::ToastNotificationPriority) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ToastNotificationPriority, int> put_Priority;
    }
}
