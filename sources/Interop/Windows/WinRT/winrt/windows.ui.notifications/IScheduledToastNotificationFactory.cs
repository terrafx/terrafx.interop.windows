// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IScheduledToastNotificationFactory.xml' path='doc/member[@name="IScheduledToastNotificationFactory"]/*' />
[Guid("E7BED191-0BB9-4189-8394-31761B476FD7")]
[NativeTypeName("struct IScheduledToastNotificationFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IScheduledToastNotificationFactory : IScheduledToastNotificationFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IScheduledToastNotificationFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationFactory*, Guid*, void**, int>)(lpVtbl[0]))((IScheduledToastNotificationFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationFactory*, uint>)(lpVtbl[1]))((IScheduledToastNotificationFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationFactory*, uint>)(lpVtbl[2]))((IScheduledToastNotificationFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IScheduledToastNotificationFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationFactory*, HSTRING*, int>)(lpVtbl[4]))((IScheduledToastNotificationFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationFactory*, TrustLevel*, int>)(lpVtbl[5]))((IScheduledToastNotificationFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IScheduledToastNotificationFactory.xml' path='doc/member[@name="IScheduledToastNotificationFactory.CreateScheduledToastNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateScheduledToastNotification([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument *")] IXmlDocument* content, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime deliveryTime, [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification **")] IScheduledToastNotification** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationFactory*, IXmlDocument*, WinRTDateTime, IScheduledToastNotification**, int>)(lpVtbl[6]))((IScheduledToastNotificationFactory*)Unsafe.AsPointer(ref this), content, deliveryTime, value);
    }

    /// <include file='IScheduledToastNotificationFactory.xml' path='doc/member[@name="IScheduledToastNotificationFactory.CreateScheduledToastNotificationRecurring"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateScheduledToastNotificationRecurring([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument *")] IXmlDocument* content, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime deliveryTime, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan snoozeInterval, [NativeTypeName("UINT32")] uint maximumSnoozeCount, [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification **")] IScheduledToastNotification** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotificationFactory*, IXmlDocument*, WinRTDateTime, TimeSpan, uint, IScheduledToastNotification**, int>)(lpVtbl[7]))((IScheduledToastNotificationFactory*)Unsafe.AsPointer(ref this), content, deliveryTime, snoozeInterval, maximumSnoozeCount, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateScheduledToastNotification([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument *")] IXmlDocument* content, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime deliveryTime, [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification **")] IScheduledToastNotification** value);

        [VtblIndex(7)]
        HRESULT CreateScheduledToastNotificationRecurring([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument *")] IXmlDocument* content, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime deliveryTime, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan snoozeInterval, [NativeTypeName("UINT32")] uint maximumSnoozeCount, [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification **")] IScheduledToastNotification** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlDocument *, ABI::Windows::Foundation::DateTime, ABI::Windows::UI::Notifications::IScheduledToastNotification **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlDocument*, WinRTDateTime, IScheduledToastNotification**, int> CreateScheduledToastNotification;

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlDocument *, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, UINT32, ABI::Windows::UI::Notifications::IScheduledToastNotification **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlDocument*, WinRTDateTime, TimeSpan, uint, IScheduledToastNotification**, int> CreateScheduledToastNotificationRecurring;
    }
}
