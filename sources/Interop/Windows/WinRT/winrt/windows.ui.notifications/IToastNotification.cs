// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IToastNotification.xml' path='doc/member[@name="IToastNotification"]/*' />
[Guid("997E2675-059E-4E60-8B06-1760917C8B80")]
[NativeTypeName("struct IToastNotification : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotification : IToastNotification.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastNotification));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification*, Guid*, void**, int>)(lpVtbl[0]))((IToastNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification*, uint>)(lpVtbl[1]))((IToastNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification*, uint>)(lpVtbl[2]))((IToastNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification*, uint*, Guid**, int>)(lpVtbl[3]))((IToastNotification*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification*, HSTRING*, int>)(lpVtbl[4]))((IToastNotification*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification*, TrustLevel*, int>)(lpVtbl[5]))((IToastNotification*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IToastNotification.xml' path='doc/member[@name="IToastNotification.get_Content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Content([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification*, IXmlDocument**, int>)(lpVtbl[6]))((IToastNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IToastNotification.xml' path='doc/member[@name="IToastNotification.put_ExpirationTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ExpirationTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification*, IReference<DateTime>*, int>)(lpVtbl[7]))((IToastNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IToastNotification.xml' path='doc/member[@name="IToastNotification.get_ExpirationTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ExpirationTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification*, IReference<DateTime>**, int>)(lpVtbl[8]))((IToastNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IToastNotification.xml' path='doc/member[@name="IToastNotification.add_Dismissed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Dismissed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CNotifications__CToastNotification_Windows__CUI__CNotifications__CToastDismissedEventArgs_t *")] ITypedEventHandler<Pointer<IToastNotification>, Pointer<IToastDismissedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification*, ITypedEventHandler<Pointer<IToastNotification>, Pointer<IToastDismissedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IToastNotification*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IToastNotification.xml' path='doc/member[@name="IToastNotification.remove_Dismissed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Dismissed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification*, EventRegistrationToken, int>)(lpVtbl[10]))((IToastNotification*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IToastNotification.xml' path='doc/member[@name="IToastNotification.add_Activated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_Activated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CNotifications__CToastNotification_IInspectable_t *")] ITypedEventHandler<Pointer<IToastNotification>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification*, ITypedEventHandler<Pointer<IToastNotification>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IToastNotification*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IToastNotification.xml' path='doc/member[@name="IToastNotification.remove_Activated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_Activated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification*, EventRegistrationToken, int>)(lpVtbl[12]))((IToastNotification*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IToastNotification.xml' path='doc/member[@name="IToastNotification.add_Failed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_Failed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CNotifications__CToastNotification_Windows__CUI__CNotifications__CToastFailedEventArgs_t *")] ITypedEventHandler<Pointer<IToastNotification>, Pointer<IToastFailedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification*, ITypedEventHandler<Pointer<IToastNotification>, Pointer<IToastFailedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IToastNotification*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IToastNotification.xml' path='doc/member[@name="IToastNotification.remove_Failed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_Failed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification*, EventRegistrationToken, int>)(lpVtbl[14]))((IToastNotification*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Content([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** value);

        [VtblIndex(7)]
        HRESULT put_ExpirationTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(8)]
        HRESULT get_ExpirationTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(9)]
        HRESULT add_Dismissed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CNotifications__CToastNotification_Windows__CUI__CNotifications__CToastDismissedEventArgs_t *")] ITypedEventHandler<Pointer<IToastNotification>, Pointer<IToastDismissedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_Dismissed(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_Activated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CNotifications__CToastNotification_IInspectable_t *")] ITypedEventHandler<Pointer<IToastNotification>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_Activated(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT add_Failed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CNotifications__CToastNotification_Windows__CUI__CNotifications__CToastFailedEventArgs_t *")] ITypedEventHandler<Pointer<IToastNotification>, Pointer<IToastFailedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_Failed(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlDocument **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlDocument**, int> get_Content;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_ExpirationTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_ExpirationTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CNotifications__CToastNotification_Windows__CUI__CNotifications__CToastDismissedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IToastNotification>, Pointer<IToastDismissedEventArgs>>*, EventRegistrationToken*, int> add_Dismissed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Dismissed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CNotifications__CToastNotification_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IToastNotification>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Activated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Activated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CNotifications__CToastNotification_Windows__CUI__CNotifications__CToastFailedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IToastNotification>, Pointer<IToastFailedEventArgs>>*, EventRegistrationToken*, int> add_Failed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Failed;
    }
}
