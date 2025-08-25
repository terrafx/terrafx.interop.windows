// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IToastNotificationManagerStatics.xml' path='doc/member[@name="IToastNotificationManagerStatics"]/*' />
[Guid("50AC103F-D235-4598-BBEF-98FE4D1A3AD4")]
[NativeTypeName("struct IToastNotificationManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotificationManagerStatics : IToastNotificationManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IToastNotificationManagerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IToastNotificationManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics*, uint>)(lpVtbl[1]))((IToastNotificationManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics*, uint>)(lpVtbl[2]))((IToastNotificationManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IToastNotificationManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IToastNotificationManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IToastNotificationManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IToastNotificationManagerStatics.xml' path='doc/member[@name="IToastNotificationManagerStatics.CreateToastNotifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateToastNotifier([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotifier **")] IToastNotifier** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics*, IToastNotifier**, int>)(lpVtbl[6]))((IToastNotificationManagerStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IToastNotificationManagerStatics.xml' path='doc/member[@name="IToastNotificationManagerStatics.CreateToastNotifierWithId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateToastNotifierWithId(HSTRING applicationId, [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotifier **")] IToastNotifier** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics*, HSTRING, IToastNotifier**, int>)(lpVtbl[7]))((IToastNotificationManagerStatics*)Unsafe.AsPointer(ref this), applicationId, result);
    }

    /// <include file='IToastNotificationManagerStatics.xml' path='doc/member[@name="IToastNotificationManagerStatics.GetTemplateContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTemplateContent([NativeTypeName("ABI::Windows::UI::Notifications::ToastTemplateType")] ToastTemplateType type, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerStatics*, ToastTemplateType, IXmlDocument**, int>)(lpVtbl[8]))((IToastNotificationManagerStatics*)Unsafe.AsPointer(ref this), type, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateToastNotifier([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotifier **")] IToastNotifier** result);

        [VtblIndex(7)]
        HRESULT CreateToastNotifierWithId(HSTRING applicationId, [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotifier **")] IToastNotifier** result);

        [VtblIndex(8)]
        HRESULT GetTemplateContent([NativeTypeName("ABI::Windows::UI::Notifications::ToastTemplateType")] ToastTemplateType type, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::ToastTemplateType, ABI::Windows::Data::Xml::Dom::IXmlDocument **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ToastTemplateType, IXmlDocument**, int> GetTemplateContent;
    }
}
