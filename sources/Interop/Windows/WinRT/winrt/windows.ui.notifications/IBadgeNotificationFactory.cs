// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBadgeNotificationFactory.xml' path='doc/member[@name="IBadgeNotificationFactory"]/*' />
[Guid("EDF255CE-0618-4D59-948A-5A61040C52F9")]
[NativeTypeName("struct IBadgeNotificationFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBadgeNotificationFactory : IBadgeNotificationFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBadgeNotificationFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotificationFactory*, Guid*, void**, int>)(lpVtbl[0]))((IBadgeNotificationFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotificationFactory*, uint>)(lpVtbl[1]))((IBadgeNotificationFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotificationFactory*, uint>)(lpVtbl[2]))((IBadgeNotificationFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotificationFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IBadgeNotificationFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotificationFactory*, HSTRING*, int>)(lpVtbl[4]))((IBadgeNotificationFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotificationFactory*, TrustLevel*, int>)(lpVtbl[5]))((IBadgeNotificationFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBadgeNotificationFactory.xml' path='doc/member[@name="IBadgeNotificationFactory.CreateBadgeNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateBadgeNotification([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument *")] IXmlDocument* content, [NativeTypeName("ABI::Windows::UI::Notifications::IBadgeNotification **")] IBadgeNotification** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotificationFactory*, IXmlDocument*, IBadgeNotification**, int>)(lpVtbl[6]))((IBadgeNotificationFactory*)Unsafe.AsPointer(ref this), content, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateBadgeNotification([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument *")] IXmlDocument* content, [NativeTypeName("ABI::Windows::UI::Notifications::IBadgeNotification **")] IBadgeNotification** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlDocument *, ABI::Windows::UI::Notifications::IBadgeNotification **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlDocument*, IBadgeNotification**, int> CreateBadgeNotification;
    }
}
