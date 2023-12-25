// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRadialController2.xml' path='doc/member[@name="IRadialController2"]/*' />
[Guid("3D577EFF-4CEE-11E6-B535-001BDC06AB3B")]
[NativeTypeName("struct IRadialController2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadialController2 : IRadialController2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRadialController2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController2*, Guid*, void**, int>)(lpVtbl[0]))((IRadialController2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController2*, uint>)(lpVtbl[1]))((IRadialController2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController2*, uint>)(lpVtbl[2]))((IRadialController2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController2*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialController2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController2*, HSTRING*, int>)(lpVtbl[4]))((IRadialController2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController2*, TrustLevel*, int>)(lpVtbl[5]))((IRadialController2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRadialController2.xml' path='doc/member[@name="IRadialController2.add_ButtonPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ButtonPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerButtonPressedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController2*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IRadialController2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRadialController2.xml' path='doc/member[@name="IRadialController2.remove_ButtonPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ButtonPressed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController2*, EventRegistrationToken, int>)(lpVtbl[7]))((IRadialController2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IRadialController2.xml' path='doc/member[@name="IRadialController2.add_ButtonHolding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_ButtonHolding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerButtonHoldingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController2*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IRadialController2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRadialController2.xml' path='doc/member[@name="IRadialController2.remove_ButtonHolding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_ButtonHolding(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController2*, EventRegistrationToken, int>)(lpVtbl[9]))((IRadialController2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IRadialController2.xml' path='doc/member[@name="IRadialController2.add_ButtonReleased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ButtonReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerButtonReleasedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController2*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IRadialController2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRadialController2.xml' path='doc/member[@name="IRadialController2.remove_ButtonReleased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ButtonReleased(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialController2*, EventRegistrationToken, int>)(lpVtbl[11]))((IRadialController2*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ButtonPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerButtonPressedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_ButtonPressed(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_ButtonHolding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerButtonHoldingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_ButtonHolding(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_ButtonReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerButtonReleasedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_ButtonReleased(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerButtonPressedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ButtonPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ButtonPressed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerButtonHoldingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ButtonHolding;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ButtonHolding;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialController_Windows__CUI__CInput__CRadialControllerButtonReleasedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ButtonReleased;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ButtonReleased;
    }
}
