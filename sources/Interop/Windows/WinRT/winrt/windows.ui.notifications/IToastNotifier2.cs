// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IToastNotifier2.xml' path='doc/member[@name="IToastNotifier2"]/*' />
[Guid("354389C6-7C01-4BD5-9C20-604340CD2B74")]
[NativeTypeName("struct IToastNotifier2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotifier2 : IToastNotifier2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastNotifier2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier2*, Guid*, void**, int>)(lpVtbl[0]))((IToastNotifier2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier2*, uint>)(lpVtbl[1]))((IToastNotifier2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier2*, uint>)(lpVtbl[2]))((IToastNotifier2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier2*, uint*, Guid**, int>)(lpVtbl[3]))((IToastNotifier2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier2*, HSTRING*, int>)(lpVtbl[4]))((IToastNotifier2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier2*, TrustLevel*, int>)(lpVtbl[5]))((IToastNotifier2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IToastNotifier2.xml' path='doc/member[@name="IToastNotifier2.UpdateWithTagAndGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UpdateWithTagAndGroup([NativeTypeName("ABI::Windows::UI::Notifications::INotificationData *")] INotificationData* data, HSTRING tag, HSTRING group, [NativeTypeName("ABI::Windows::UI::Notifications::NotificationUpdateResult *")] NotificationUpdateResult* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier2*, INotificationData*, HSTRING, HSTRING, NotificationUpdateResult*, int>)(lpVtbl[6]))((IToastNotifier2*)Unsafe.AsPointer(ref this), data, tag, group, result);
    }

    /// <include file='IToastNotifier2.xml' path='doc/member[@name="IToastNotifier2.UpdateWithTag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UpdateWithTag([NativeTypeName("ABI::Windows::UI::Notifications::INotificationData *")] INotificationData* data, HSTRING tag, [NativeTypeName("ABI::Windows::UI::Notifications::NotificationUpdateResult *")] NotificationUpdateResult* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotifier2*, INotificationData*, HSTRING, NotificationUpdateResult*, int>)(lpVtbl[7]))((IToastNotifier2*)Unsafe.AsPointer(ref this), data, tag, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT UpdateWithTagAndGroup([NativeTypeName("ABI::Windows::UI::Notifications::INotificationData *")] INotificationData* data, HSTRING tag, HSTRING group, [NativeTypeName("ABI::Windows::UI::Notifications::NotificationUpdateResult *")] NotificationUpdateResult* result);

        [VtblIndex(7)]
        HRESULT UpdateWithTag([NativeTypeName("ABI::Windows::UI::Notifications::INotificationData *")] INotificationData* data, HSTRING tag, [NativeTypeName("ABI::Windows::UI::Notifications::NotificationUpdateResult *")] NotificationUpdateResult* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::INotificationData *, HSTRING, HSTRING, ABI::Windows::UI::Notifications::NotificationUpdateResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, INotificationData*, HSTRING, HSTRING, NotificationUpdateResult*, int> UpdateWithTagAndGroup;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::INotificationData *, HSTRING, ABI::Windows::UI::Notifications::NotificationUpdateResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, INotificationData*, HSTRING, NotificationUpdateResult*, int> UpdateWithTag;
    }
}
