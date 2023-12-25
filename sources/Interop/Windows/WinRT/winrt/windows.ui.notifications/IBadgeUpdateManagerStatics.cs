// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBadgeUpdateManagerStatics.xml' path='doc/member[@name="IBadgeUpdateManagerStatics"]/*' />
[Guid("33400FAA-6DD5-4105-AEBC-9B50FCA492DA")]
[NativeTypeName("struct IBadgeUpdateManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBadgeUpdateManagerStatics : IBadgeUpdateManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBadgeUpdateManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBadgeUpdateManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerStatics*, uint>)(lpVtbl[1]))((IBadgeUpdateManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerStatics*, uint>)(lpVtbl[2]))((IBadgeUpdateManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBadgeUpdateManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IBadgeUpdateManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBadgeUpdateManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBadgeUpdateManagerStatics.xml' path='doc/member[@name="IBadgeUpdateManagerStatics.CreateBadgeUpdaterForApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateBadgeUpdaterForApplication([NativeTypeName("ABI::Windows::UI::Notifications::IBadgeUpdater **")] IBadgeUpdater** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerStatics*, IBadgeUpdater**, int>)(lpVtbl[6]))((IBadgeUpdateManagerStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IBadgeUpdateManagerStatics.xml' path='doc/member[@name="IBadgeUpdateManagerStatics.CreateBadgeUpdaterForApplicationWithId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateBadgeUpdaterForApplicationWithId(HSTRING applicationId, [NativeTypeName("ABI::Windows::UI::Notifications::IBadgeUpdater **")] IBadgeUpdater** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerStatics*, HSTRING, IBadgeUpdater**, int>)(lpVtbl[7]))((IBadgeUpdateManagerStatics*)Unsafe.AsPointer(ref this), applicationId, result);
    }

    /// <include file='IBadgeUpdateManagerStatics.xml' path='doc/member[@name="IBadgeUpdateManagerStatics.CreateBadgeUpdaterForSecondaryTile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateBadgeUpdaterForSecondaryTile(HSTRING tileId, [NativeTypeName("ABI::Windows::UI::Notifications::IBadgeUpdater **")] IBadgeUpdater** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerStatics*, HSTRING, IBadgeUpdater**, int>)(lpVtbl[8]))((IBadgeUpdateManagerStatics*)Unsafe.AsPointer(ref this), tileId, result);
    }

    /// <include file='IBadgeUpdateManagerStatics.xml' path='doc/member[@name="IBadgeUpdateManagerStatics.GetTemplateContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetTemplateContent([NativeTypeName("ABI::Windows::UI::Notifications::BadgeTemplateType")] BadgeTemplateType type, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeUpdateManagerStatics*, BadgeTemplateType, IXmlDocument**, int>)(lpVtbl[9]))((IBadgeUpdateManagerStatics*)Unsafe.AsPointer(ref this), type, result);
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
        HRESULT GetTemplateContent([NativeTypeName("ABI::Windows::UI::Notifications::BadgeTemplateType")] BadgeTemplateType type, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::BadgeTemplateType, ABI::Windows::Data::Xml::Dom::IXmlDocument **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BadgeTemplateType, IXmlDocument**, int> GetTemplateContent;
    }
}
