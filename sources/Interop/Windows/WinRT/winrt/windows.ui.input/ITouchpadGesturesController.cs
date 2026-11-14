// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITouchpadGesturesController.xml' path='doc/member[@name="ITouchpadGesturesController"]/*' />
[Guid("28C13CDD-E068-549F-89C6-1A440C6FC327")]
[NativeTypeName("struct ITouchpadGesturesController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITouchpadGesturesController : ITouchpadGesturesController.Interface, INativeGuid
{
    /// <include file='ITouchpadGesturesController.xml' path='doc/member[@name="ITouchpadGesturesController.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITouchpadGesturesController);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, Guid*, void**, int>)(lpVtbl[0]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, uint>)(lpVtbl[1]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, uint>)(lpVtbl[2]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, uint*, Guid**, int>)(lpVtbl[3]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, HSTRING*, int>)(lpVtbl[4]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, TrustLevel*, int>)(lpVtbl[5]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITouchpadGesturesController.xml' path='doc/member[@name="ITouchpadGesturesController.get_Enabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Enabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, byte*, int>)(lpVtbl[6]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITouchpadGesturesController.xml' path='doc/member[@name="ITouchpadGesturesController.put_Enabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Enabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, byte, int>)(lpVtbl[7]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITouchpadGesturesController.xml' path='doc/member[@name="ITouchpadGesturesController.get_SupportedGestures"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SupportedGestures([NativeTypeName("ABI::Windows::UI::Input::TouchpadGlobalGestureKinds *")] TouchpadGlobalGestureKinds* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, TouchpadGlobalGestureKinds*, int>)(lpVtbl[8]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITouchpadGesturesController.xml' path='doc/member[@name="ITouchpadGesturesController.put_SupportedGestures"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SupportedGestures([NativeTypeName("ABI::Windows::UI::Input::TouchpadGlobalGestureKinds")] TouchpadGlobalGestureKinds value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, TouchpadGlobalGestureKinds, int>)(lpVtbl[9]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITouchpadGesturesController.xml' path='doc/member[@name="ITouchpadGesturesController.add_PointerPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_PointerPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CTouchpadGesturesController_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ITouchpadGesturesController.xml' path='doc/member[@name="ITouchpadGesturesController.remove_PointerPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_PointerPressed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, EventRegistrationToken, int>)(lpVtbl[11]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ITouchpadGesturesController.xml' path='doc/member[@name="ITouchpadGesturesController.add_PointerMoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_PointerMoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CTouchpadGesturesController_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ITouchpadGesturesController.xml' path='doc/member[@name="ITouchpadGesturesController.remove_PointerMoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_PointerMoved(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, EventRegistrationToken, int>)(lpVtbl[13]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ITouchpadGesturesController.xml' path='doc/member[@name="ITouchpadGesturesController.add_PointerReleased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_PointerReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CTouchpadGesturesController_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[14]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ITouchpadGesturesController.xml' path='doc/member[@name="ITouchpadGesturesController.remove_PointerReleased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_PointerReleased(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, EventRegistrationToken, int>)(lpVtbl[15]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ITouchpadGesturesController.xml' path='doc/member[@name="ITouchpadGesturesController.add_GlobalActionPerformed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_GlobalActionPerformed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CTouchpadGesturesController_Windows__CUI__CInput__CTouchpadGlobalActionEventArgs_t *")] ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<ITouchpadGlobalActionEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<ITouchpadGlobalActionEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[16]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ITouchpadGesturesController.xml' path='doc/member[@name="ITouchpadGesturesController.remove_GlobalActionPerformed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_GlobalActionPerformed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesController*, EventRegistrationToken, int>)(lpVtbl[17]))((ITouchpadGesturesController*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Enabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_Enabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_SupportedGestures([NativeTypeName("ABI::Windows::UI::Input::TouchpadGlobalGestureKinds *")] TouchpadGlobalGestureKinds* value);

        [VtblIndex(9)]
        HRESULT put_SupportedGestures([NativeTypeName("ABI::Windows::UI::Input::TouchpadGlobalGestureKinds")] TouchpadGlobalGestureKinds value);

        [VtblIndex(10)]
        HRESULT add_PointerPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CTouchpadGesturesController_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_PointerPressed(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_PointerMoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CTouchpadGesturesController_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_PointerMoved(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT add_PointerReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CTouchpadGesturesController_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_PointerReleased(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT add_GlobalActionPerformed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CTouchpadGesturesController_Windows__CUI__CInput__CTouchpadGlobalActionEventArgs_t *")] ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<ITouchpadGlobalActionEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(17)]
        HRESULT remove_GlobalActionPerformed(EventRegistrationToken token);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Enabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_Enabled;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::TouchpadGlobalGestureKinds *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TouchpadGlobalGestureKinds*, int> get_SupportedGestures;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::TouchpadGlobalGestureKinds) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TouchpadGlobalGestureKinds, int> put_SupportedGestures;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CTouchpadGesturesController_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerPressed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CTouchpadGesturesController_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerMoved;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerMoved;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CTouchpadGesturesController_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerReleased;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerReleased;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CTouchpadGesturesController_Windows__CUI__CInput__CTouchpadGlobalActionEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ITouchpadGesturesController>, Pointer<ITouchpadGlobalActionEventArgs>>*, EventRegistrationToken*, int> add_GlobalActionPerformed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_GlobalActionPerformed;
    }
}
