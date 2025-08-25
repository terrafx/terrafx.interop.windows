// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IToastNotificationManagerForUser.xml' path='doc/member[@name="IToastNotificationManagerForUser"]/*' />
[Guid("79AB57F6-43FE-487B-8A7F-99567200AE94")]
[NativeTypeName("struct IToastNotificationManagerForUser : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotificationManagerForUser : IToastNotificationManagerForUser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IToastNotificationManagerForUser);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser*, Guid*, void**, int>)(lpVtbl[0]))((IToastNotificationManagerForUser*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser*, uint>)(lpVtbl[1]))((IToastNotificationManagerForUser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser*, uint>)(lpVtbl[2]))((IToastNotificationManagerForUser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser*, uint*, Guid**, int>)(lpVtbl[3]))((IToastNotificationManagerForUser*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser*, HSTRING*, int>)(lpVtbl[4]))((IToastNotificationManagerForUser*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser*, TrustLevel*, int>)(lpVtbl[5]))((IToastNotificationManagerForUser*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IToastNotificationManagerForUser.xml' path='doc/member[@name="IToastNotificationManagerForUser.CreateToastNotifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateToastNotifier([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotifier **")] IToastNotifier** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser*, IToastNotifier**, int>)(lpVtbl[6]))((IToastNotificationManagerForUser*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IToastNotificationManagerForUser.xml' path='doc/member[@name="IToastNotificationManagerForUser.CreateToastNotifierWithId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateToastNotifierWithId(HSTRING applicationId, [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotifier **")] IToastNotifier** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser*, HSTRING, IToastNotifier**, int>)(lpVtbl[7]))((IToastNotificationManagerForUser*)Unsafe.AsPointer(ref this), applicationId, result);
    }

    /// <include file='IToastNotificationManagerForUser.xml' path='doc/member[@name="IToastNotificationManagerForUser.get_History"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_History([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotificationHistory **")] IToastNotificationHistory** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser*, IToastNotificationHistory**, int>)(lpVtbl[8]))((IToastNotificationManagerForUser*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IToastNotificationManagerForUser.xml' path='doc/member[@name="IToastNotificationManagerForUser.get_User"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser*, IUser**, int>)(lpVtbl[9]))((IToastNotificationManagerForUser*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateToastNotifier([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotifier **")] IToastNotifier** result);

        [VtblIndex(7)]
        HRESULT CreateToastNotifierWithId(HSTRING applicationId, [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotifier **")] IToastNotifier** result);

        [VtblIndex(8)]
        HRESULT get_History([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotificationHistory **")] IToastNotificationHistory** value);

        [VtblIndex(9)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IToastNotifier **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IToastNotifier**, int> CreateToastNotifier;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Notifications::IToastNotifier **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IToastNotifier**, int> CreateToastNotifierWithId;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IToastNotificationHistory **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IToastNotificationHistory**, int> get_History;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser**, int> get_User;
    }
}
