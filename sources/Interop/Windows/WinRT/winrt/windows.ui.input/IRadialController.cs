// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRadialController.xml' path='doc/member[@name="IRadialController"]/*' />
[Guid("3055D1C8-DF51-43D4-B23B-0E1037467A09")]
[NativeTypeName("struct IRadialController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadialController : IRadialController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRadialController);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, Guid*, void**, int>)(lpVtbl[0]))((IRadialController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, uint>)(lpVtbl[1]))((IRadialController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, uint>)(lpVtbl[2]))((IRadialController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, HSTRING*, int>)(lpVtbl[4]))((IRadialController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, TrustLevel*, int>)(lpVtbl[5]))((IRadialController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.get_Menu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Menu([NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenu **")] IRadialControllerMenu** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, IRadialControllerMenu**, int>)(lpVtbl[6]))((IRadialController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.get_RotationResolutionInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RotationResolutionInDegrees(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, double*, int>)(lpVtbl[7]))((IRadialController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.put_RotationResolutionInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_RotationResolutionInDegrees(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, double, int>)(lpVtbl[8]))((IRadialController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.get_UseAutomaticHapticFeedback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_UseAutomaticHapticFeedback([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, byte*, int>)(lpVtbl[9]))((IRadialController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.put_UseAutomaticHapticFeedback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_UseAutomaticHapticFeedback([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, byte, int>)(lpVtbl[10]))((IRadialController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.add_ScreenContactStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_ScreenContactStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerScreenContactStartedEventArgs_t *")] ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerScreenContactStartedEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerScreenContactStartedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IRadialController*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.remove_ScreenContactStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_ScreenContactStarted(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, EventRegistrationToken, int>)(lpVtbl[12]))((IRadialController*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.add_ScreenContactEnded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_ScreenContactEnded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_IInspectable_t *")] ITypedEventHandler<Pointer<IRadialController>, Pointer<IInspectable>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, ITypedEventHandler<Pointer<IRadialController>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IRadialController*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.remove_ScreenContactEnded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_ScreenContactEnded(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, EventRegistrationToken, int>)(lpVtbl[14]))((IRadialController*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.add_ScreenContactContinued"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_ScreenContactContinued([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerScreenContactContinuedEventArgs_t *")] ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerScreenContactContinuedEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerScreenContactContinuedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IRadialController*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.remove_ScreenContactContinued"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_ScreenContactContinued(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, EventRegistrationToken, int>)(lpVtbl[16]))((IRadialController*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.add_ControlLost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_ControlLost([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_IInspectable_t *")] ITypedEventHandler<Pointer<IRadialController>, Pointer<IInspectable>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, ITypedEventHandler<Pointer<IRadialController>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[17]))((IRadialController*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.remove_ControlLost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_ControlLost(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, EventRegistrationToken, int>)(lpVtbl[18]))((IRadialController*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.add_RotationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT add_RotationChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerRotationChangedEventArgs_t *")] ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerRotationChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerRotationChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[19]))((IRadialController*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.remove_RotationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT remove_RotationChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, EventRegistrationToken, int>)(lpVtbl[20]))((IRadialController*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.add_ButtonClicked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT add_ButtonClicked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerButtonClickedEventArgs_t *")] ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerButtonClickedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerButtonClickedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[21]))((IRadialController*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.remove_ButtonClicked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT remove_ButtonClicked(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, EventRegistrationToken, int>)(lpVtbl[22]))((IRadialController*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.add_ControlAcquired"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT add_ControlAcquired([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerControlAcquiredEventArgs_t *")] ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerControlAcquiredEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerControlAcquiredEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[23]))((IRadialController*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IRadialController.xml' path='doc/member[@name="IRadialController.remove_ControlAcquired"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT remove_ControlAcquired(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController*, EventRegistrationToken, int>)(lpVtbl[24]))((IRadialController*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Menu([NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenu **")] IRadialControllerMenu** value);

        [VtblIndex(7)]
        HRESULT get_RotationResolutionInDegrees(double* value);

        [VtblIndex(8)]
        HRESULT put_RotationResolutionInDegrees(double value);

        [VtblIndex(9)]
        HRESULT get_UseAutomaticHapticFeedback([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_UseAutomaticHapticFeedback([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT add_ScreenContactStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerScreenContactStartedEventArgs_t *")] ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerScreenContactStartedEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(12)]
        HRESULT remove_ScreenContactStarted(EventRegistrationToken cookie);

        [VtblIndex(13)]
        HRESULT add_ScreenContactEnded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_IInspectable_t *")] ITypedEventHandler<Pointer<IRadialController>, Pointer<IInspectable>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(14)]
        HRESULT remove_ScreenContactEnded(EventRegistrationToken cookie);

        [VtblIndex(15)]
        HRESULT add_ScreenContactContinued([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerScreenContactContinuedEventArgs_t *")] ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerScreenContactContinuedEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(16)]
        HRESULT remove_ScreenContactContinued(EventRegistrationToken cookie);

        [VtblIndex(17)]
        HRESULT add_ControlLost([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_IInspectable_t *")] ITypedEventHandler<Pointer<IRadialController>, Pointer<IInspectable>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(18)]
        HRESULT remove_ControlLost(EventRegistrationToken cookie);

        [VtblIndex(19)]
        HRESULT add_RotationChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerRotationChangedEventArgs_t *")] ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerRotationChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(20)]
        HRESULT remove_RotationChanged(EventRegistrationToken token);

        [VtblIndex(21)]
        HRESULT add_ButtonClicked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerButtonClickedEventArgs_t *")] ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerButtonClickedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(22)]
        HRESULT remove_ButtonClicked(EventRegistrationToken token);

        [VtblIndex(23)]
        HRESULT add_ControlAcquired([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerControlAcquiredEventArgs_t *")] ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerControlAcquiredEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(24)]
        HRESULT remove_ControlAcquired(EventRegistrationToken cookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IRadialControllerMenu **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRadialControllerMenu**, int> get_Menu;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_RotationResolutionInDegrees;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_RotationResolutionInDegrees;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UseAutomaticHapticFeedback;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_UseAutomaticHapticFeedback;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerScreenContactStartedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerScreenContactStartedEventArgs>>*, EventRegistrationToken*, int> add_ScreenContactStarted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ScreenContactStarted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRadialController>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_ScreenContactEnded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ScreenContactEnded;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerScreenContactContinuedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerScreenContactContinuedEventArgs>>*, EventRegistrationToken*, int> add_ScreenContactContinued;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ScreenContactContinued;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRadialController>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_ControlLost;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ControlLost;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerRotationChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerRotationChangedEventArgs>>*, EventRegistrationToken*, int> add_RotationChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RotationChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerButtonClickedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerButtonClickedEventArgs>>*, EventRegistrationToken*, int> add_ButtonClicked;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ButtonClicked;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerControlAcquiredEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRadialController>, Pointer<IRadialControllerControlAcquiredEventArgs>>*, EventRegistrationToken*, int> add_ControlAcquired;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ControlAcquired;
    }
}
