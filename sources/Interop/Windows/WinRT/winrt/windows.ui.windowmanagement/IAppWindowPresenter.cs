// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppWindowPresenter.xml' path='doc/member[@name="IAppWindowPresenter"]/*' />
[Guid("5AE9ED73-E1FD-5317-AD78-5A3ED271BBDE")]
[NativeTypeName("struct IAppWindowPresenter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppWindowPresenter : IAppWindowPresenter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppWindowPresenter);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowPresenter*, Guid*, void**, int>)(lpVtbl[0]))((IAppWindowPresenter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowPresenter*, uint>)(lpVtbl[1]))((IAppWindowPresenter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowPresenter*, uint>)(lpVtbl[2]))((IAppWindowPresenter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowPresenter*, uint*, Guid**, int>)(lpVtbl[3]))((IAppWindowPresenter*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowPresenter*, HSTRING*, int>)(lpVtbl[4]))((IAppWindowPresenter*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowPresenter*, TrustLevel*, int>)(lpVtbl[5]))((IAppWindowPresenter*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppWindowPresenter.xml' path='doc/member[@name="IAppWindowPresenter.GetConfiguration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetConfiguration([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowPresentationConfiguration **")] IAppWindowPresentationConfiguration** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowPresenter*, IAppWindowPresentationConfiguration**, int>)(lpVtbl[6]))((IAppWindowPresenter*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAppWindowPresenter.xml' path='doc/member[@name="IAppWindowPresenter.IsPresentationSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsPresentationSupported([NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowPresentationKind")] AppWindowPresentationKind presentationKind, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowPresenter*, AppWindowPresentationKind, byte*, int>)(lpVtbl[7]))((IAppWindowPresenter*)Unsafe.AsPointer(ref this), presentationKind, result);
    }

    /// <include file='IAppWindowPresenter.xml' path='doc/member[@name="IAppWindowPresenter.RequestPresentation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestPresentation([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowPresentationConfiguration *")] IAppWindowPresentationConfiguration* configuration, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowPresenter*, IAppWindowPresentationConfiguration*, byte*, int>)(lpVtbl[8]))((IAppWindowPresenter*)Unsafe.AsPointer(ref this), configuration, result);
    }

    /// <include file='IAppWindowPresenter.xml' path='doc/member[@name="IAppWindowPresenter.RequestPresentationByKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestPresentationByKind([NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowPresentationKind")] AppWindowPresentationKind presentationKind, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowPresenter*, AppWindowPresentationKind, byte*, int>)(lpVtbl[9]))((IAppWindowPresenter*)Unsafe.AsPointer(ref this), presentationKind, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetConfiguration([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowPresentationConfiguration **")] IAppWindowPresentationConfiguration** result);

        [VtblIndex(7)]
        HRESULT IsPresentationSupported([NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowPresentationKind")] AppWindowPresentationKind presentationKind, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(8)]
        HRESULT RequestPresentation([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowPresentationConfiguration *")] IAppWindowPresentationConfiguration* configuration, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(9)]
        HRESULT RequestPresentationByKind([NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowPresentationKind")] AppWindowPresentationKind presentationKind, [NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::IAppWindowPresentationConfiguration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppWindowPresentationConfiguration**, int> GetConfiguration;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::AppWindowPresentationKind, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppWindowPresentationKind, byte*, int> IsPresentationSupported;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::IAppWindowPresentationConfiguration *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppWindowPresentationConfiguration*, byte*, int> RequestPresentation;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::AppWindowPresentationKind, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppWindowPresentationKind, byte*, int> RequestPresentationByKind;
    }
}
