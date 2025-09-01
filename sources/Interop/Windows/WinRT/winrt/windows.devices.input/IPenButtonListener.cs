// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPenButtonListener.xml' path='doc/member[@name="IPenButtonListener"]/*' />
[Guid("8245C376-1EE3-53F7-B1F7-8334A16F2815")]
[NativeTypeName("struct IPenButtonListener : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPenButtonListener : IPenButtonListener.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPenButtonListener);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenButtonListener*, Guid*, void**, int>)(lpVtbl[0]))((IPenButtonListener*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPenButtonListener*, uint>)(lpVtbl[1]))((IPenButtonListener*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPenButtonListener*, uint>)(lpVtbl[2]))((IPenButtonListener*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenButtonListener*, uint*, Guid**, int>)(lpVtbl[3]))((IPenButtonListener*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenButtonListener*, HSTRING*, int>)(lpVtbl[4]))((IPenButtonListener*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenButtonListener*, TrustLevel*, int>)(lpVtbl[5]))((IPenButtonListener*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPenButtonListener.xml' path='doc/member[@name="IPenButtonListener.IsSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsSupported([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenButtonListener*, byte*, int>)(lpVtbl[6]))((IPenButtonListener*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPenButtonListener.xml' path='doc/member[@name="IPenButtonListener.add_IsSupportedChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_IsSupportedChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_IInspectable_t *")] ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenButtonListener*, ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IPenButtonListener*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPenButtonListener.xml' path='doc/member[@name="IPenButtonListener.remove_IsSupportedChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_IsSupportedChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenButtonListener*, EventRegistrationToken, int>)(lpVtbl[8]))((IPenButtonListener*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPenButtonListener.xml' path='doc/member[@name="IPenButtonListener.add_TailButtonClicked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_TailButtonClicked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_Windows__CDevices__CInput__CPenTailButtonClickedEventArgs_t *")] ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IPenTailButtonClickedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenButtonListener*, ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IPenTailButtonClickedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IPenButtonListener*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPenButtonListener.xml' path='doc/member[@name="IPenButtonListener.remove_TailButtonClicked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_TailButtonClicked(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenButtonListener*, EventRegistrationToken, int>)(lpVtbl[10]))((IPenButtonListener*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPenButtonListener.xml' path='doc/member[@name="IPenButtonListener.add_TailButtonDoubleClicked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_TailButtonDoubleClicked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_Windows__CDevices__CInput__CPenTailButtonDoubleClickedEventArgs_t *")] ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IPenTailButtonDoubleClickedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenButtonListener*, ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IPenTailButtonDoubleClickedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IPenButtonListener*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPenButtonListener.xml' path='doc/member[@name="IPenButtonListener.remove_TailButtonDoubleClicked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_TailButtonDoubleClicked(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenButtonListener*, EventRegistrationToken, int>)(lpVtbl[12]))((IPenButtonListener*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPenButtonListener.xml' path='doc/member[@name="IPenButtonListener.add_TailButtonLongPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_TailButtonLongPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_Windows__CDevices__CInput__CPenTailButtonLongPressedEventArgs_t *")] ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IPenTailButtonLongPressedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenButtonListener*, ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IPenTailButtonLongPressedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IPenButtonListener*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPenButtonListener.xml' path='doc/member[@name="IPenButtonListener.remove_TailButtonLongPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_TailButtonLongPressed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenButtonListener*, EventRegistrationToken, int>)(lpVtbl[14]))((IPenButtonListener*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsSupported([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(7)]
        HRESULT add_IsSupportedChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_IInspectable_t *")] ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_IsSupportedChanged(EventRegistrationToken token);

        [VtblIndex(9)]
        HRESULT add_TailButtonClicked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_Windows__CDevices__CInput__CPenTailButtonClickedEventArgs_t *")] ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IPenTailButtonClickedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_TailButtonClicked(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_TailButtonDoubleClicked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_Windows__CDevices__CInput__CPenTailButtonDoubleClickedEventArgs_t *")] ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IPenTailButtonDoubleClickedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_TailButtonDoubleClicked(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT add_TailButtonLongPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_Windows__CDevices__CInput__CPenTailButtonLongPressedEventArgs_t *")] ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IPenTailButtonLongPressedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_TailButtonLongPressed(EventRegistrationToken token);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> IsSupported;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_IsSupportedChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_IsSupportedChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_Windows__CDevices__CInput__CPenTailButtonClickedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IPenTailButtonClickedEventArgs>>*, EventRegistrationToken*, int> add_TailButtonClicked;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_TailButtonClicked;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_Windows__CDevices__CInput__CPenTailButtonDoubleClickedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IPenTailButtonDoubleClickedEventArgs>>*, EventRegistrationToken*, int> add_TailButtonDoubleClicked;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_TailButtonDoubleClicked;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_Windows__CDevices__CInput__CPenTailButtonLongPressedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPenButtonListener>, Pointer<IPenTailButtonLongPressedEventArgs>>*, EventRegistrationToken*, int> add_TailButtonLongPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_TailButtonLongPressed;
    }
}
