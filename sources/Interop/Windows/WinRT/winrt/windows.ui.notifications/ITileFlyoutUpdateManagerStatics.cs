// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITileFlyoutUpdateManagerStatics.xml' path='doc/member[@name="ITileFlyoutUpdateManagerStatics"]/*' />
[Guid("04363B0B-1AC0-4B99-88E7-ADA83E953D48")]
[NativeTypeName("struct ITileFlyoutUpdateManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITileFlyoutUpdateManagerStatics : ITileFlyoutUpdateManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITileFlyoutUpdateManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdateManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((ITileFlyoutUpdateManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdateManagerStatics*, uint>)(lpVtbl[1]))((ITileFlyoutUpdateManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdateManagerStatics*, uint>)(lpVtbl[2]))((ITileFlyoutUpdateManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdateManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ITileFlyoutUpdateManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdateManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((ITileFlyoutUpdateManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdateManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((ITileFlyoutUpdateManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITileFlyoutUpdateManagerStatics.xml' path='doc/member[@name="ITileFlyoutUpdateManagerStatics.CreateTileFlyoutUpdaterForApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateTileFlyoutUpdaterForApplication([NativeTypeName("ABI::Windows::UI::Notifications::ITileFlyoutUpdater **")] ITileFlyoutUpdater** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdateManagerStatics*, ITileFlyoutUpdater**, int>)(lpVtbl[6]))((ITileFlyoutUpdateManagerStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITileFlyoutUpdateManagerStatics.xml' path='doc/member[@name="ITileFlyoutUpdateManagerStatics.CreateTileFlyoutUpdaterForApplicationWithId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateTileFlyoutUpdaterForApplicationWithId(HSTRING applicationId, [NativeTypeName("ABI::Windows::UI::Notifications::ITileFlyoutUpdater **")] ITileFlyoutUpdater** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdateManagerStatics*, HSTRING, ITileFlyoutUpdater**, int>)(lpVtbl[7]))((ITileFlyoutUpdateManagerStatics*)Unsafe.AsPointer(ref this), applicationId, result);
    }

    /// <include file='ITileFlyoutUpdateManagerStatics.xml' path='doc/member[@name="ITileFlyoutUpdateManagerStatics.CreateTileFlyoutUpdaterForSecondaryTile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateTileFlyoutUpdaterForSecondaryTile(HSTRING tileId, [NativeTypeName("ABI::Windows::UI::Notifications::ITileFlyoutUpdater **")] ITileFlyoutUpdater** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdateManagerStatics*, HSTRING, ITileFlyoutUpdater**, int>)(lpVtbl[8]))((ITileFlyoutUpdateManagerStatics*)Unsafe.AsPointer(ref this), tileId, result);
    }

    /// <include file='ITileFlyoutUpdateManagerStatics.xml' path='doc/member[@name="ITileFlyoutUpdateManagerStatics.GetTemplateContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetTemplateContent([NativeTypeName("ABI::Windows::UI::Notifications::TileFlyoutTemplateType")] TileFlyoutTemplateType type, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutUpdateManagerStatics*, TileFlyoutTemplateType, IXmlDocument**, int>)(lpVtbl[9]))((ITileFlyoutUpdateManagerStatics*)Unsafe.AsPointer(ref this), type, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateTileFlyoutUpdaterForApplication([NativeTypeName("ABI::Windows::UI::Notifications::ITileFlyoutUpdater **")] ITileFlyoutUpdater** result);

        [VtblIndex(7)]
        HRESULT CreateTileFlyoutUpdaterForApplicationWithId(HSTRING applicationId, [NativeTypeName("ABI::Windows::UI::Notifications::ITileFlyoutUpdater **")] ITileFlyoutUpdater** result);

        [VtblIndex(8)]
        HRESULT CreateTileFlyoutUpdaterForSecondaryTile(HSTRING tileId, [NativeTypeName("ABI::Windows::UI::Notifications::ITileFlyoutUpdater **")] ITileFlyoutUpdater** result);

        [VtblIndex(9)]
        HRESULT GetTemplateContent([NativeTypeName("ABI::Windows::UI::Notifications::TileFlyoutTemplateType")] TileFlyoutTemplateType type, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::ITileFlyoutUpdater **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITileFlyoutUpdater**, int> CreateTileFlyoutUpdaterForApplication;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Notifications::ITileFlyoutUpdater **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ITileFlyoutUpdater**, int> CreateTileFlyoutUpdaterForApplicationWithId;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Notifications::ITileFlyoutUpdater **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ITileFlyoutUpdater**, int> CreateTileFlyoutUpdaterForSecondaryTile;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::TileFlyoutTemplateType, ABI::Windows::Data::Xml::Dom::IXmlDocument **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TileFlyoutTemplateType, IXmlDocument**, int> GetTemplateContent;
    }
}
