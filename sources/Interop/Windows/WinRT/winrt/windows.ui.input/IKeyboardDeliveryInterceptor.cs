// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyboardDeliveryInterceptor.xml' path='doc/member[@name="IKeyboardDeliveryInterceptor"]/*' />
[Guid("B4BAF068-8F49-446C-8DB5-8C0FFE85CC9E")]
[NativeTypeName("struct IKeyboardDeliveryInterceptor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyboardDeliveryInterceptor : IKeyboardDeliveryInterceptor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKeyboardDeliveryInterceptor);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptor*, Guid*, void**, int>)(lpVtbl[0]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptor*, uint>)(lpVtbl[1]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptor*, uint>)(lpVtbl[2]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptor*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptor*, HSTRING*, int>)(lpVtbl[4]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptor*, TrustLevel*, int>)(lpVtbl[5]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyboardDeliveryInterceptor.xml' path='doc/member[@name="IKeyboardDeliveryInterceptor.get_IsInterceptionEnabledWhenInForeground"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsInterceptionEnabledWhenInForeground([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptor*, byte*, int>)(lpVtbl[6]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyboardDeliveryInterceptor.xml' path='doc/member[@name="IKeyboardDeliveryInterceptor.put_IsInterceptionEnabledWhenInForeground"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsInterceptionEnabledWhenInForeground([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptor*, byte, int>)(lpVtbl[7]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyboardDeliveryInterceptor.xml' path='doc/member[@name="IKeyboardDeliveryInterceptor.add_KeyDown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_KeyDown([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CKeyboardDeliveryInterceptor_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<Pointer<IKeyboardDeliveryInterceptor>, Pointer<IKeyEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptor*, ITypedEventHandler<Pointer<IKeyboardDeliveryInterceptor>, Pointer<IKeyEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IKeyboardDeliveryInterceptor.xml' path='doc/member[@name="IKeyboardDeliveryInterceptor.remove_KeyDown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_KeyDown(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptor*, EventRegistrationToken, int>)(lpVtbl[9]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IKeyboardDeliveryInterceptor.xml' path='doc/member[@name="IKeyboardDeliveryInterceptor.add_KeyUp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_KeyUp([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CKeyboardDeliveryInterceptor_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<Pointer<IKeyboardDeliveryInterceptor>, Pointer<IKeyEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptor*, ITypedEventHandler<Pointer<IKeyboardDeliveryInterceptor>, Pointer<IKeyEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IKeyboardDeliveryInterceptor.xml' path='doc/member[@name="IKeyboardDeliveryInterceptor.remove_KeyUp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_KeyUp(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptor*, EventRegistrationToken, int>)(lpVtbl[11]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsInterceptionEnabledWhenInForeground([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsInterceptionEnabledWhenInForeground([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT add_KeyDown([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CKeyboardDeliveryInterceptor_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<Pointer<IKeyboardDeliveryInterceptor>, Pointer<IKeyEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_KeyDown(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_KeyUp([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CKeyboardDeliveryInterceptor_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<Pointer<IKeyboardDeliveryInterceptor>, Pointer<IKeyEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_KeyUp(EventRegistrationToken token);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsInterceptionEnabledWhenInForeground;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsInterceptionEnabledWhenInForeground;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CKeyboardDeliveryInterceptor_Windows__CUI__CCore__CKeyEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IKeyboardDeliveryInterceptor>, Pointer<IKeyEventArgs>>*, EventRegistrationToken*, int> add_KeyDown;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_KeyDown;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CKeyboardDeliveryInterceptor_Windows__CUI__CCore__CKeyEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IKeyboardDeliveryInterceptor>, Pointer<IKeyEventArgs>>*, EventRegistrationToken*, int> add_KeyUp;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_KeyUp;
    }
}
