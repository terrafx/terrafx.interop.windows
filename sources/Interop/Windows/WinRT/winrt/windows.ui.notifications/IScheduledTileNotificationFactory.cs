// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IScheduledTileNotificationFactory.xml' path='doc/member[@name="IScheduledTileNotificationFactory"]/*' />
[Guid("3383138A-98C0-4C3B-BBD6-4A633C7CFC29")]
[NativeTypeName("struct IScheduledTileNotificationFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IScheduledTileNotificationFactory : IScheduledTileNotificationFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IScheduledTileNotificationFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotificationFactory*, Guid*, void**, int>)(lpVtbl[0]))((IScheduledTileNotificationFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotificationFactory*, uint>)(lpVtbl[1]))((IScheduledTileNotificationFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotificationFactory*, uint>)(lpVtbl[2]))((IScheduledTileNotificationFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotificationFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IScheduledTileNotificationFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotificationFactory*, HSTRING*, int>)(lpVtbl[4]))((IScheduledTileNotificationFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotificationFactory*, TrustLevel*, int>)(lpVtbl[5]))((IScheduledTileNotificationFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IScheduledTileNotificationFactory.xml' path='doc/member[@name="IScheduledTileNotificationFactory.CreateScheduledTileNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateScheduledTileNotification([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument *")] IXmlDocument* content, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime deliveryTime, [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledTileNotification **")] IScheduledTileNotification** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotificationFactory*, IXmlDocument*, WinRTDateTime, IScheduledTileNotification**, int>)(lpVtbl[6]))((IScheduledTileNotificationFactory*)Unsafe.AsPointer(ref this), content, deliveryTime, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateScheduledTileNotification([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument *")] IXmlDocument* content, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime deliveryTime, [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledTileNotification **")] IScheduledTileNotification** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlDocument *, ABI::Windows::Foundation::DateTime, ABI::Windows::UI::Notifications::IScheduledTileNotification **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlDocument*, WinRTDateTime, IScheduledTileNotification**, int> CreateScheduledTileNotification;
    }
}
