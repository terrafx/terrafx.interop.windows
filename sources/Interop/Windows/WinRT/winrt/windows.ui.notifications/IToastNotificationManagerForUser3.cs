// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IToastNotificationManagerForUser3.xml' path='doc/member[@name="IToastNotificationManagerForUser3"]/*' />
[Guid("3EFCB176-6CC1-56DC-973B-251F7AACB1C5")]
[NativeTypeName("struct IToastNotificationManagerForUser3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotificationManagerForUser3 : IToastNotificationManagerForUser3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastNotificationManagerForUser3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser3*, Guid*, void**, int>)(lpVtbl[0]))((IToastNotificationManagerForUser3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser3*, uint>)(lpVtbl[1]))((IToastNotificationManagerForUser3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser3*, uint>)(lpVtbl[2]))((IToastNotificationManagerForUser3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser3*, uint*, Guid**, int>)(lpVtbl[3]))((IToastNotificationManagerForUser3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser3*, HSTRING*, int>)(lpVtbl[4]))((IToastNotificationManagerForUser3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser3*, TrustLevel*, int>)(lpVtbl[5]))((IToastNotificationManagerForUser3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IToastNotificationManagerForUser3.xml' path='doc/member[@name="IToastNotificationManagerForUser3.get_NotificationMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NotificationMode([NativeTypeName("ABI::Windows::UI::Notifications::ToastNotificationMode *")] ToastNotificationMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser3*, ToastNotificationMode*, int>)(lpVtbl[6]))((IToastNotificationManagerForUser3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IToastNotificationManagerForUser3.xml' path='doc/member[@name="IToastNotificationManagerForUser3.add_NotificationModeChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_NotificationModeChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CNotifications__CToastNotificationManagerForUser_IInspectable_t *")] ITypedEventHandler<Pointer<IToastNotificationManagerForUser>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser3*, ITypedEventHandler<Pointer<IToastNotificationManagerForUser>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IToastNotificationManagerForUser3*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IToastNotificationManagerForUser3.xml' path='doc/member[@name="IToastNotificationManagerForUser3.remove_NotificationModeChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_NotificationModeChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser3*, EventRegistrationToken, int>)(lpVtbl[8]))((IToastNotificationManagerForUser3*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NotificationMode([NativeTypeName("ABI::Windows::UI::Notifications::ToastNotificationMode *")] ToastNotificationMode* value);

        [VtblIndex(7)]
        HRESULT add_NotificationModeChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CNotifications__CToastNotificationManagerForUser_IInspectable_t *")] ITypedEventHandler<Pointer<IToastNotificationManagerForUser>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_NotificationModeChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::ToastNotificationMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ToastNotificationMode*, int> get_NotificationMode;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CNotifications__CToastNotificationManagerForUser_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IToastNotificationManagerForUser>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_NotificationModeChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_NotificationModeChanged;
    }
}
