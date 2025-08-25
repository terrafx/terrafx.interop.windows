// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserNotificationChangedEventArgs.xml' path='doc/member[@name="IUserNotificationChangedEventArgs"]/*' />
[Guid("B6BD6839-79CF-4B25-82C0-0CE1EEF81F8C")]
[NativeTypeName("struct IUserNotificationChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserNotificationChangedEventArgs : IUserNotificationChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IUserNotificationChangedEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotificationChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IUserNotificationChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotificationChangedEventArgs*, uint>)(lpVtbl[1]))((IUserNotificationChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotificationChangedEventArgs*, uint>)(lpVtbl[2]))((IUserNotificationChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotificationChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IUserNotificationChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotificationChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IUserNotificationChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotificationChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IUserNotificationChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserNotificationChangedEventArgs.xml' path='doc/member[@name="IUserNotificationChangedEventArgs.get_ChangeKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChangeKind([NativeTypeName("ABI::Windows::UI::Notifications::UserNotificationChangedKind *")] UserNotificationChangedKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotificationChangedEventArgs*, UserNotificationChangedKind*, int>)(lpVtbl[6]))((IUserNotificationChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserNotificationChangedEventArgs.xml' path='doc/member[@name="IUserNotificationChangedEventArgs.get_UserNotificationId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_UserNotificationId([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotificationChangedEventArgs*, uint*, int>)(lpVtbl[7]))((IUserNotificationChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ChangeKind([NativeTypeName("ABI::Windows::UI::Notifications::UserNotificationChangedKind *")] UserNotificationChangedKind* value);

        [VtblIndex(7)]
        HRESULT get_UserNotificationId([NativeTypeName("UINT32 *")] uint* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::UserNotificationChangedKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserNotificationChangedKind*, int> get_ChangeKind;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_UserNotificationId;
    }
}
