// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreInputView2.xml' path='doc/member[@name="ICoreInputView2"]/*' />
[Guid("0ED726C1-E09A-4AE8-AEDF-DFA4857D1A01")]
[NativeTypeName("struct ICoreInputView2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreInputView2 : ICoreInputView2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreInputView2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView2*, Guid*, void**, int>)(lpVtbl[0]))((ICoreInputView2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView2*, uint>)(lpVtbl[1]))((ICoreInputView2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView2*, uint>)(lpVtbl[2]))((ICoreInputView2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView2*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreInputView2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView2*, HSTRING*, int>)(lpVtbl[4]))((ICoreInputView2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView2*, TrustLevel*, int>)(lpVtbl[5]))((ICoreInputView2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreInputView2.xml' path='doc/member[@name="ICoreInputView2.add_XYFocusTransferringFromPrimaryView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_XYFocusTransferringFromPrimaryView([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_Windows__CUI__CViewManagement__CCore__CCoreInputViewTransferringXYFocusEventArgs_t *")] ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewTransferringXYFocusEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView2*, ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewTransferringXYFocusEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreInputView2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreInputView2.xml' path='doc/member[@name="ICoreInputView2.remove_XYFocusTransferringFromPrimaryView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_XYFocusTransferringFromPrimaryView(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView2*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreInputView2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICoreInputView2.xml' path='doc/member[@name="ICoreInputView2.add_XYFocusTransferredToPrimaryView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_XYFocusTransferredToPrimaryView([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_IInspectable_t *")] ITypedEventHandler<Pointer<ICoreInputView>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView2*, ITypedEventHandler<Pointer<ICoreInputView>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ICoreInputView2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreInputView2.xml' path='doc/member[@name="ICoreInputView2.remove_XYFocusTransferredToPrimaryView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_XYFocusTransferredToPrimaryView(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView2*, EventRegistrationToken, int>)(lpVtbl[9]))((ICoreInputView2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICoreInputView2.xml' path='doc/member[@name="ICoreInputView2.TryTransferXYFocusToPrimaryView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TryTransferXYFocusToPrimaryView([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect origin, [NativeTypeName("ABI::Windows::UI::ViewManagement::Core::CoreInputViewXYFocusTransferDirection")] CoreInputViewXYFocusTransferDirection direction, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView2*, Rect, CoreInputViewXYFocusTransferDirection, byte*, int>)(lpVtbl[10]))((ICoreInputView2*)Unsafe.AsPointer(ref this), origin, direction, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_XYFocusTransferringFromPrimaryView([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_Windows__CUI__CViewManagement__CCore__CCoreInputViewTransferringXYFocusEventArgs_t *")] ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewTransferringXYFocusEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_XYFocusTransferringFromPrimaryView(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_XYFocusTransferredToPrimaryView([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_IInspectable_t *")] ITypedEventHandler<Pointer<ICoreInputView>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_XYFocusTransferredToPrimaryView(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT TryTransferXYFocusToPrimaryView([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect origin, [NativeTypeName("ABI::Windows::UI::ViewManagement::Core::CoreInputViewXYFocusTransferDirection")] CoreInputViewXYFocusTransferDirection direction, [NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_Windows__CUI__CViewManagement__CCore__CCoreInputViewTransferringXYFocusEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewTransferringXYFocusEventArgs>>*, EventRegistrationToken*, int> add_XYFocusTransferringFromPrimaryView;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_XYFocusTransferringFromPrimaryView;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreInputView>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_XYFocusTransferredToPrimaryView;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_XYFocusTransferredToPrimaryView;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect, ABI::Windows::UI::ViewManagement::Core::CoreInputViewXYFocusTransferDirection, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, CoreInputViewXYFocusTransferDirection, byte*, int> TryTransferXYFocusToPrimaryView;
    }
}
