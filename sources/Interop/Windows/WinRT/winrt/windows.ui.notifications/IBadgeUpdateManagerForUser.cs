// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBadgeUpdateManagerForUser.xml' path='doc/member[@name="IBadgeUpdateManagerForUser"]/*' />
[Guid("996B21BC-0386-44E5-BA8D-0C1077A62E92")]
[NativeTypeName("struct IBadgeUpdateManagerForUser : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBadgeUpdateManagerForUser : IBadgeUpdateManagerForUser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBadgeUpdateManagerForUser);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerForUser*, Guid*, void**, int>)(lpVtbl[0]))((IBadgeUpdateManagerForUser*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerForUser*, uint>)(lpVtbl[1]))((IBadgeUpdateManagerForUser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerForUser*, uint>)(lpVtbl[2]))((IBadgeUpdateManagerForUser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerForUser*, uint*, Guid**, int>)(lpVtbl[3]))((IBadgeUpdateManagerForUser*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerForUser*, HSTRING*, int>)(lpVtbl[4]))((IBadgeUpdateManagerForUser*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerForUser*, TrustLevel*, int>)(lpVtbl[5]))((IBadgeUpdateManagerForUser*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBadgeUpdateManagerForUser.xml' path='doc/member[@name="IBadgeUpdateManagerForUser.CreateBadgeUpdaterForApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateBadgeUpdaterForApplication([NativeTypeName("ABI::Windows::UI::Notifications::IBadgeUpdater **")] IBadgeUpdater** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerForUser*, IBadgeUpdater**, int>)(lpVtbl[6]))((IBadgeUpdateManagerForUser*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IBadgeUpdateManagerForUser.xml' path='doc/member[@name="IBadgeUpdateManagerForUser.CreateBadgeUpdaterForApplicationWithId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateBadgeUpdaterForApplicationWithId(HSTRING applicationId, [NativeTypeName("ABI::Windows::UI::Notifications::IBadgeUpdater **")] IBadgeUpdater** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerForUser*, HSTRING, IBadgeUpdater**, int>)(lpVtbl[7]))((IBadgeUpdateManagerForUser*)Unsafe.AsPointer(ref this), applicationId, result);
    }

    /// <include file='IBadgeUpdateManagerForUser.xml' path='doc/member[@name="IBadgeUpdateManagerForUser.CreateBadgeUpdaterForSecondaryTile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateBadgeUpdaterForSecondaryTile(HSTRING tileId, [NativeTypeName("ABI::Windows::UI::Notifications::IBadgeUpdater **")] IBadgeUpdater** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerForUser*, HSTRING, IBadgeUpdater**, int>)(lpVtbl[8]))((IBadgeUpdateManagerForUser*)Unsafe.AsPointer(ref this), tileId, result);
    }

    /// <include file='IBadgeUpdateManagerForUser.xml' path='doc/member[@name="IBadgeUpdateManagerForUser.get_User"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerForUser*, IUser**, int>)(lpVtbl[9]))((IBadgeUpdateManagerForUser*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateBadgeUpdaterForApplication([NativeTypeName("ABI::Windows::UI::Notifications::IBadgeUpdater **")] IBadgeUpdater** result);

        [VtblIndex(7)]
        HRESULT CreateBadgeUpdaterForApplicationWithId(HSTRING applicationId, [NativeTypeName("ABI::Windows::UI::Notifications::IBadgeUpdater **")] IBadgeUpdater** result);

        [VtblIndex(8)]
        HRESULT CreateBadgeUpdaterForSecondaryTile(HSTRING tileId, [NativeTypeName("ABI::Windows::UI::Notifications::IBadgeUpdater **")] IBadgeUpdater** result);

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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IBadgeUpdater **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBadgeUpdater**, int> CreateBadgeUpdaterForApplication;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Notifications::IBadgeUpdater **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IBadgeUpdater**, int> CreateBadgeUpdaterForApplicationWithId;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Notifications::IBadgeUpdater **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IBadgeUpdater**, int> CreateBadgeUpdaterForSecondaryTile;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser**, int> get_User;
    }
}
