// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreComponentFocusable.xml' path='doc/member[@name="ICoreComponentFocusable"]/*' />
[Guid("52F96FA3-8742-4411-AE69-79A85F29AC8B")]
[NativeTypeName("struct ICoreComponentFocusable : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreComponentFocusable : ICoreComponentFocusable.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICoreComponentFocusable);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreComponentFocusable*, Guid*, void**, int>)(lpVtbl[0]))((ICoreComponentFocusable*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreComponentFocusable*, uint>)(lpVtbl[1]))((ICoreComponentFocusable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreComponentFocusable*, uint>)(lpVtbl[2]))((ICoreComponentFocusable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreComponentFocusable*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreComponentFocusable*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreComponentFocusable*, HSTRING*, int>)(lpVtbl[4]))((ICoreComponentFocusable*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreComponentFocusable*, TrustLevel*, int>)(lpVtbl[5]))((ICoreComponentFocusable*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreComponentFocusable.xml' path='doc/member[@name="ICoreComponentFocusable.get_HasFocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_HasFocus([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreComponentFocusable*, byte*, int>)(lpVtbl[6]))((ICoreComponentFocusable*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreComponentFocusable.xml' path='doc/member[@name="ICoreComponentFocusable.add_GotFocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_GotFocus([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CCoreWindowEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<ICoreWindowEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreComponentFocusable*, ITypedEventHandler<Pointer<IInspectable>, Pointer<ICoreWindowEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((ICoreComponentFocusable*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreComponentFocusable.xml' path='doc/member[@name="ICoreComponentFocusable.remove_GotFocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_GotFocus(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreComponentFocusable*, EventRegistrationToken, int>)(lpVtbl[8]))((ICoreComponentFocusable*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreComponentFocusable.xml' path='doc/member[@name="ICoreComponentFocusable.add_LostFocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_LostFocus([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CCoreWindowEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<ICoreWindowEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreComponentFocusable*, ITypedEventHandler<Pointer<IInspectable>, Pointer<ICoreWindowEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ICoreComponentFocusable*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreComponentFocusable.xml' path='doc/member[@name="ICoreComponentFocusable.remove_LostFocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_LostFocus(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreComponentFocusable*, EventRegistrationToken, int>)(lpVtbl[10]))((ICoreComponentFocusable*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_HasFocus([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT add_GotFocus([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CCoreWindowEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<ICoreWindowEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(8)]
        HRESULT remove_GotFocus(EventRegistrationToken cookie);

        [VtblIndex(9)]
        HRESULT add_LostFocus([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CCoreWindowEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<ICoreWindowEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(10)]
        HRESULT remove_LostFocus(EventRegistrationToken cookie);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HasFocus;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CCoreWindowEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, Pointer<ICoreWindowEventArgs>>*, EventRegistrationToken*, int> add_GotFocus;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_GotFocus;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CCoreWindowEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, Pointer<ICoreWindowEventArgs>>*, EventRegistrationToken*, int> add_LostFocus;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_LostFocus;
    }
}
