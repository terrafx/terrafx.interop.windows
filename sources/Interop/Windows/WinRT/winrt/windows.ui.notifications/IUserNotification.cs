// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserNotification.xml' path='doc/member[@name="IUserNotification"]/*' />
[Guid("ADF7E52F-4E53-42D5-9C33-EB5EA515B23E")]
[NativeTypeName("struct IUserNotification : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserNotification : IUserNotification.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_WinRT_IUserNotification));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotification*, Guid*, void**, int>)(lpVtbl[0]))((IUserNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotification*, uint>)(lpVtbl[1]))((IUserNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotification*, uint>)(lpVtbl[2]))((IUserNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotification*, uint*, Guid**, int>)(lpVtbl[3]))((IUserNotification*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotification*, HSTRING*, int>)(lpVtbl[4]))((IUserNotification*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotification*, TrustLevel*, int>)(lpVtbl[5]))((IUserNotification*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserNotification.xml' path='doc/member[@name="IUserNotification.get_Notification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Notification([NativeTypeName("ABI::Windows::UI::Notifications::INotification **")] INotification** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotification*, INotification**, int>)(lpVtbl[6]))((IUserNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserNotification.xml' path='doc/member[@name="IUserNotification.get_AppInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AppInfo([NativeTypeName("ABI::Windows::ApplicationModel::IAppInfo **")] IAppInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotification*, IAppInfo**, int>)(lpVtbl[7]))((IUserNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserNotification.xml' path='doc/member[@name="IUserNotification.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Id([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotification*, uint*, int>)(lpVtbl[8]))((IUserNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserNotification.xml' path='doc/member[@name="IUserNotification.get_CreationTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CreationTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserNotification*, WinRTDateTime*, int>)(lpVtbl[9]))((IUserNotification*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Notification([NativeTypeName("ABI::Windows::UI::Notifications::INotification **")] INotification** value);

        [VtblIndex(7)]
        HRESULT get_AppInfo([NativeTypeName("ABI::Windows::ApplicationModel::IAppInfo **")] IAppInfo** value);

        [VtblIndex(8)]
        HRESULT get_Id([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT get_CreationTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::INotification **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, INotification**, int> get_Notification;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::IAppInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppInfo**, int> get_AppInfo;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Id;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_CreationTime;
    }
}
