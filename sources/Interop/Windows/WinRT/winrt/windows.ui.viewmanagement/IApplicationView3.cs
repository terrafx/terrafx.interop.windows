// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IApplicationView3.xml' path='doc/member[@name="IApplicationView3"]/*' />
[Guid("903C9CE5-793A-4FDF-A2B2-AF1AC21E3108")]
[NativeTypeName("struct IApplicationView3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationView3 : IApplicationView3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IApplicationView3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView3*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationView3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView3*, uint>)(lpVtbl[1]))((IApplicationView3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView3*, uint>)(lpVtbl[2]))((IApplicationView3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView3*, uint*, Guid**, int>)(lpVtbl[3]))((IApplicationView3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView3*, HSTRING*, int>)(lpVtbl[4]))((IApplicationView3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView3*, TrustLevel*, int>)(lpVtbl[5]))((IApplicationView3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IApplicationView3.xml' path='doc/member[@name="IApplicationView3.get_TitleBar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TitleBar([NativeTypeName("ABI::Windows::UI::ViewManagement::IApplicationViewTitleBar **")] IApplicationViewTitleBar** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView3*, IApplicationViewTitleBar**, int>)(lpVtbl[6]))((IApplicationView3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView3.xml' path='doc/member[@name="IApplicationView3.get_FullScreenSystemOverlayMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_FullScreenSystemOverlayMode([NativeTypeName("ABI::Windows::UI::ViewManagement::FullScreenSystemOverlayMode *")] FullScreenSystemOverlayMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView3*, FullScreenSystemOverlayMode*, int>)(lpVtbl[7]))((IApplicationView3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView3.xml' path='doc/member[@name="IApplicationView3.put_FullScreenSystemOverlayMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_FullScreenSystemOverlayMode([NativeTypeName("ABI::Windows::UI::ViewManagement::FullScreenSystemOverlayMode")] FullScreenSystemOverlayMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView3*, FullScreenSystemOverlayMode, int>)(lpVtbl[8]))((IApplicationView3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView3.xml' path='doc/member[@name="IApplicationView3.get_IsFullScreenMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsFullScreenMode([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView3*, byte*, int>)(lpVtbl[9]))((IApplicationView3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView3.xml' path='doc/member[@name="IApplicationView3.TryEnterFullScreenMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TryEnterFullScreenMode([NativeTypeName("boolean *")] byte* success)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView3*, byte*, int>)(lpVtbl[10]))((IApplicationView3*)Unsafe.AsPointer(ref this), success);
    }

    /// <include file='IApplicationView3.xml' path='doc/member[@name="IApplicationView3.ExitFullScreenMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ExitFullScreenMode()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView3*, int>)(lpVtbl[11]))((IApplicationView3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IApplicationView3.xml' path='doc/member[@name="IApplicationView3.ShowStandardSystemOverlays"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ShowStandardSystemOverlays()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView3*, int>)(lpVtbl[12]))((IApplicationView3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IApplicationView3.xml' path='doc/member[@name="IApplicationView3.TryResizeView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT TryResizeView([NativeTypeName("ABI::Windows::Foundation::Size")] Size value, [NativeTypeName("boolean *")] byte* success)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView3*, Size, byte*, int>)(lpVtbl[13]))((IApplicationView3*)Unsafe.AsPointer(ref this), value, success);
    }

    /// <include file='IApplicationView3.xml' path='doc/member[@name="IApplicationView3.SetPreferredMinSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetPreferredMinSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size minSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView3*, Size, int>)(lpVtbl[14]))((IApplicationView3*)Unsafe.AsPointer(ref this), minSize);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TitleBar([NativeTypeName("ABI::Windows::UI::ViewManagement::IApplicationViewTitleBar **")] IApplicationViewTitleBar** value);

        [VtblIndex(7)]
        HRESULT get_FullScreenSystemOverlayMode([NativeTypeName("ABI::Windows::UI::ViewManagement::FullScreenSystemOverlayMode *")] FullScreenSystemOverlayMode* value);

        [VtblIndex(8)]
        HRESULT put_FullScreenSystemOverlayMode([NativeTypeName("ABI::Windows::UI::ViewManagement::FullScreenSystemOverlayMode")] FullScreenSystemOverlayMode value);

        [VtblIndex(9)]
        HRESULT get_IsFullScreenMode([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT TryEnterFullScreenMode([NativeTypeName("boolean *")] byte* success);

        [VtblIndex(11)]
        HRESULT ExitFullScreenMode();

        [VtblIndex(12)]
        HRESULT ShowStandardSystemOverlays();

        [VtblIndex(13)]
        HRESULT TryResizeView([NativeTypeName("ABI::Windows::Foundation::Size")] Size value, [NativeTypeName("boolean *")] byte* success);

        [VtblIndex(14)]
        HRESULT SetPreferredMinSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size minSize);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::IApplicationViewTitleBar **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IApplicationViewTitleBar**, int> get_TitleBar;

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::FullScreenSystemOverlayMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FullScreenSystemOverlayMode*, int> get_FullScreenSystemOverlayMode;

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::FullScreenSystemOverlayMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FullScreenSystemOverlayMode, int> put_FullScreenSystemOverlayMode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsFullScreenMode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> TryEnterFullScreenMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ExitFullScreenMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ShowStandardSystemOverlays;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size, byte*, int> TryResizeView;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size, int> SetPreferredMinSize;
    }
}
