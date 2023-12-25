// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IApplicationView2.xml' path='doc/member[@name="IApplicationView2"]/*' />
[Guid("E876B196-A545-40DC-B594-450CBA68CC00")]
[NativeTypeName("struct IApplicationView2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationView2 : IApplicationView2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationView2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView2*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationView2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView2*, uint>)(lpVtbl[1]))((IApplicationView2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView2*, uint>)(lpVtbl[2]))((IApplicationView2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView2*, uint*, Guid**, int>)(lpVtbl[3]))((IApplicationView2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView2*, HSTRING*, int>)(lpVtbl[4]))((IApplicationView2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView2*, TrustLevel*, int>)(lpVtbl[5]))((IApplicationView2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IApplicationView2.xml' path='doc/member[@name="IApplicationView2.get_SuppressSystemOverlays"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN.")]
    public HRESULT get_SuppressSystemOverlays([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView2*, byte*, int>)(lpVtbl[6]))((IApplicationView2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView2.xml' path='doc/member[@name="IApplicationView2.put_SuppressSystemOverlays"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN.")]
    public HRESULT put_SuppressSystemOverlays([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView2*, byte, int>)(lpVtbl[7]))((IApplicationView2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView2.xml' path='doc/member[@name="IApplicationView2.get_VisibleBounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_VisibleBounds([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView2*, Rect*, int>)(lpVtbl[8]))((IApplicationView2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView2.xml' path='doc/member[@name="IApplicationView2.add_VisibleBoundsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_VisibleBoundsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CApplicationView_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView2*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IApplicationView2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IApplicationView2.xml' path='doc/member[@name="IApplicationView2.remove_VisibleBoundsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_VisibleBoundsChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView2*, EventRegistrationToken, int>)(lpVtbl[10]))((IApplicationView2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IApplicationView2.xml' path='doc/member[@name="IApplicationView2.SetDesiredBoundsMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetDesiredBoundsMode([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewBoundsMode")] ApplicationViewBoundsMode boundsMode, [NativeTypeName("boolean *")] byte* success)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView2*, ApplicationViewBoundsMode, byte*, int>)(lpVtbl[11]))((IApplicationView2*)Unsafe.AsPointer(ref this), boundsMode, success);
    }

    /// <include file='IApplicationView2.xml' path='doc/member[@name="IApplicationView2.get_DesiredBoundsMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DesiredBoundsMode([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewBoundsMode *")] ApplicationViewBoundsMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView2*, ApplicationViewBoundsMode*, int>)(lpVtbl[12]))((IApplicationView2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN.")]
        HRESULT get_SuppressSystemOverlays([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        [Obsolete("Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN.")]
        HRESULT put_SuppressSystemOverlays([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_VisibleBounds([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(9)]
        HRESULT add_VisibleBoundsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CApplicationView_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_VisibleBoundsChanged(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT SetDesiredBoundsMode([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewBoundsMode")] ApplicationViewBoundsMode boundsMode, [NativeTypeName("boolean *")] byte* success);

        [VtblIndex(12)]
        HRESULT get_DesiredBoundsMode([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewBoundsMode *")] ApplicationViewBoundsMode* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SuppressSystemOverlays;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete("Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_SuppressSystemOverlays;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> get_VisibleBounds;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CApplicationView_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_VisibleBoundsChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_VisibleBoundsChanged;

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewBoundsMode, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ApplicationViewBoundsMode, byte*, int> SetDesiredBoundsMode;

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewBoundsMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ApplicationViewBoundsMode*, int> get_DesiredBoundsMode;
    }
}
