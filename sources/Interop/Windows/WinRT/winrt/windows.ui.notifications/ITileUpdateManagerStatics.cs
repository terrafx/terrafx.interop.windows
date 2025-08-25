// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITileUpdateManagerStatics.xml' path='doc/member[@name="ITileUpdateManagerStatics"]/*' />
[Guid("DA159E5D-3EA9-4986-8D84-B09D5E12276D")]
[NativeTypeName("struct ITileUpdateManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITileUpdateManagerStatics : ITileUpdateManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITileUpdateManagerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdateManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((ITileUpdateManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdateManagerStatics*, uint>)(lpVtbl[1]))((ITileUpdateManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdateManagerStatics*, uint>)(lpVtbl[2]))((ITileUpdateManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdateManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ITileUpdateManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdateManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((ITileUpdateManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdateManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((ITileUpdateManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITileUpdateManagerStatics.xml' path='doc/member[@name="ITileUpdateManagerStatics.CreateTileUpdaterForApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateTileUpdaterForApplication([NativeTypeName("ABI::Windows::UI::Notifications::ITileUpdater **")] ITileUpdater** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdateManagerStatics*, ITileUpdater**, int>)(lpVtbl[6]))((ITileUpdateManagerStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITileUpdateManagerStatics.xml' path='doc/member[@name="ITileUpdateManagerStatics.CreateTileUpdaterForApplicationWithId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateTileUpdaterForApplicationWithId(HSTRING applicationId, [NativeTypeName("ABI::Windows::UI::Notifications::ITileUpdater **")] ITileUpdater** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdateManagerStatics*, HSTRING, ITileUpdater**, int>)(lpVtbl[7]))((ITileUpdateManagerStatics*)Unsafe.AsPointer(ref this), applicationId, result);
    }

    /// <include file='ITileUpdateManagerStatics.xml' path='doc/member[@name="ITileUpdateManagerStatics.CreateTileUpdaterForSecondaryTile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateTileUpdaterForSecondaryTile(HSTRING tileId, [NativeTypeName("ABI::Windows::UI::Notifications::ITileUpdater **")] ITileUpdater** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdateManagerStatics*, HSTRING, ITileUpdater**, int>)(lpVtbl[8]))((ITileUpdateManagerStatics*)Unsafe.AsPointer(ref this), tileId, result);
    }

    /// <include file='ITileUpdateManagerStatics.xml' path='doc/member[@name="ITileUpdateManagerStatics.GetTemplateContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetTemplateContent([NativeTypeName("ABI::Windows::UI::Notifications::TileTemplateType")] TileTemplateType type, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdateManagerStatics*, TileTemplateType, IXmlDocument**, int>)(lpVtbl[9]))((ITileUpdateManagerStatics*)Unsafe.AsPointer(ref this), type, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateTileUpdaterForApplication([NativeTypeName("ABI::Windows::UI::Notifications::ITileUpdater **")] ITileUpdater** result);

        [VtblIndex(7)]
        HRESULT CreateTileUpdaterForApplicationWithId(HSTRING applicationId, [NativeTypeName("ABI::Windows::UI::Notifications::ITileUpdater **")] ITileUpdater** result);

        [VtblIndex(8)]
        HRESULT CreateTileUpdaterForSecondaryTile(HSTRING tileId, [NativeTypeName("ABI::Windows::UI::Notifications::ITileUpdater **")] ITileUpdater** result);

        [VtblIndex(9)]
        HRESULT GetTemplateContent([NativeTypeName("ABI::Windows::UI::Notifications::TileTemplateType")] TileTemplateType type, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::ITileUpdater **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITileUpdater**, int> CreateTileUpdaterForApplication;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Notifications::ITileUpdater **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ITileUpdater**, int> CreateTileUpdaterForApplicationWithId;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Notifications::ITileUpdater **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ITileUpdater**, int> CreateTileUpdaterForSecondaryTile;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::TileTemplateType, ABI::Windows::Data::Xml::Dom::IXmlDocument **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TileTemplateType, IXmlDocument**, int> GetTemplateContent;
    }
}
