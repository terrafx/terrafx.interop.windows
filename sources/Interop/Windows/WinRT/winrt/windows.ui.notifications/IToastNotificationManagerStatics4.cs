// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IToastNotificationManagerStatics4.xml' path='doc/member[@name="IToastNotificationManagerStatics4"]/*' />
[Guid("8F993FD3-E516-45FB-8130-398E93FA52C3")]
[NativeTypeName("struct IToastNotificationManagerStatics4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotificationManagerStatics4 : IToastNotificationManagerStatics4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IToastNotificationManagerStatics4);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics4*, Guid*, void**, int>)(lpVtbl[0]))((IToastNotificationManagerStatics4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics4*, uint>)(lpVtbl[1]))((IToastNotificationManagerStatics4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics4*, uint>)(lpVtbl[2]))((IToastNotificationManagerStatics4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics4*, uint*, Guid**, int>)(lpVtbl[3]))((IToastNotificationManagerStatics4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics4*, HSTRING*, int>)(lpVtbl[4]))((IToastNotificationManagerStatics4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics4*, TrustLevel*, int>)(lpVtbl[5]))((IToastNotificationManagerStatics4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IToastNotificationManagerStatics4.xml' path='doc/member[@name="IToastNotificationManagerStatics4.GetForUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotificationManagerForUser **")] IToastNotificationManagerForUser** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics4*, IUser*, IToastNotificationManagerForUser**, int>)(lpVtbl[6]))((IToastNotificationManagerStatics4*)Unsafe.AsPointer(ref this), user, result);
    }

    /// <include file='IToastNotificationManagerStatics4.xml' path='doc/member[@name="IToastNotificationManagerStatics4.ConfigureNotificationMirroring"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ConfigureNotificationMirroring([NativeTypeName("ABI::Windows::UI::Notifications::NotificationMirroring")] NotificationMirroring value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics4*, NotificationMirroring, int>)(lpVtbl[7]))((IToastNotificationManagerStatics4*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotificationManagerForUser **")] IToastNotificationManagerForUser** result);

        [VtblIndex(7)]
        HRESULT ConfigureNotificationMirroring([NativeTypeName("ABI::Windows::UI::Notifications::NotificationMirroring")] NotificationMirroring value);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::UI::Notifications::IToastNotificationManagerForUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, IToastNotificationManagerForUser**, int> GetForUser;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::NotificationMirroring) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, NotificationMirroring, int> ConfigureNotificationMirroring;
    }
}
