// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPenDockListener.xml' path='doc/member[@name="IPenDockListener"]/*' />
[Guid("759F4D90-1DC0-55CB-AD18-B9101456F592")]
[NativeTypeName("struct IPenDockListener : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPenDockListener : IPenDockListener.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPenDockListener));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenDockListener*, Guid*, void**, int>)(lpVtbl[0]))((IPenDockListener*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPenDockListener*, uint>)(lpVtbl[1]))((IPenDockListener*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPenDockListener*, uint>)(lpVtbl[2]))((IPenDockListener*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenDockListener*, uint*, Guid**, int>)(lpVtbl[3]))((IPenDockListener*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenDockListener*, HSTRING*, int>)(lpVtbl[4]))((IPenDockListener*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenDockListener*, TrustLevel*, int>)(lpVtbl[5]))((IPenDockListener*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPenDockListener.xml' path='doc/member[@name="IPenDockListener.IsSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsSupported([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenDockListener*, byte*, int>)(lpVtbl[6]))((IPenDockListener*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPenDockListener.xml' path='doc/member[@name="IPenDockListener.add_IsSupportedChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_IsSupportedChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenDockListener_IInspectable_t *")] ITypedEventHandler<Pointer<IPenDockListener>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenDockListener*, ITypedEventHandler<Pointer<IPenDockListener>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IPenDockListener*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPenDockListener.xml' path='doc/member[@name="IPenDockListener.remove_IsSupportedChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_IsSupportedChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenDockListener*, EventRegistrationToken, int>)(lpVtbl[8]))((IPenDockListener*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPenDockListener.xml' path='doc/member[@name="IPenDockListener.add_Docked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Docked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenDockListener_Windows__CDevices__CInput__CPenDockedEventArgs_t *")] ITypedEventHandler<Pointer<IPenDockListener>, Pointer<IPenDockedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenDockListener*, ITypedEventHandler<Pointer<IPenDockListener>, Pointer<IPenDockedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IPenDockListener*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPenDockListener.xml' path='doc/member[@name="IPenDockListener.remove_Docked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Docked(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenDockListener*, EventRegistrationToken, int>)(lpVtbl[10]))((IPenDockListener*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPenDockListener.xml' path='doc/member[@name="IPenDockListener.add_Undocked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_Undocked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenDockListener_Windows__CDevices__CInput__CPenUndockedEventArgs_t *")] ITypedEventHandler<Pointer<IPenDockListener>, Pointer<IPenUndockedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenDockListener*, ITypedEventHandler<Pointer<IPenDockListener>, Pointer<IPenUndockedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IPenDockListener*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPenDockListener.xml' path='doc/member[@name="IPenDockListener.remove_Undocked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_Undocked(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPenDockListener*, EventRegistrationToken, int>)(lpVtbl[12]))((IPenDockListener*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsSupported([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(7)]
        HRESULT add_IsSupportedChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenDockListener_IInspectable_t *")] ITypedEventHandler<Pointer<IPenDockListener>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_IsSupportedChanged(EventRegistrationToken token);

        [VtblIndex(9)]
        HRESULT add_Docked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenDockListener_Windows__CDevices__CInput__CPenDockedEventArgs_t *")] ITypedEventHandler<Pointer<IPenDockListener>, Pointer<IPenDockedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_Docked(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_Undocked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenDockListener_Windows__CDevices__CInput__CPenUndockedEventArgs_t *")] ITypedEventHandler<Pointer<IPenDockListener>, Pointer<IPenUndockedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_Undocked(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenDockListener_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPenDockListener>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_IsSupportedChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_IsSupportedChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenDockListener_Windows__CDevices__CInput__CPenDockedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPenDockListener>, Pointer<IPenDockedEventArgs>>*, EventRegistrationToken*, int> add_Docked;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Docked;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenDockListener_Windows__CDevices__CInput__CPenUndockedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPenDockListener>, Pointer<IPenUndockedEventArgs>>*, EventRegistrationToken*, int> add_Undocked;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Undocked;
    }
}
