// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IInputPane.xml' path='doc/member[@name="IInputPane"]/*' />
[Guid("640ADA70-06F3-4C87-A678-9829C9127C28")]
[NativeTypeName("struct IInputPane : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IInputPane : IInputPane.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInputPane));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane*, Guid*, void**, int>)(lpVtbl[0]))((IInputPane*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane*, uint>)(lpVtbl[1]))((IInputPane*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane*, uint>)(lpVtbl[2]))((IInputPane*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane*, uint*, Guid**, int>)(lpVtbl[3]))((IInputPane*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane*, HSTRING*, int>)(lpVtbl[4]))((IInputPane*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane*, TrustLevel*, int>)(lpVtbl[5]))((IInputPane*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IInputPane.xml' path='doc/member[@name="IInputPane.add_Showing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_Showing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CInputPane_Windows__CUI__CViewManagement__CInputPaneVisibilityEventArgs_t *")] ITypedEventHandler<Pointer<IInputPane>, Pointer<IInputPaneVisibilityEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane*, ITypedEventHandler<Pointer<IInputPane>, Pointer<IInputPaneVisibilityEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IInputPane*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IInputPane.xml' path='doc/member[@name="IInputPane.remove_Showing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_Showing(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane*, EventRegistrationToken, int>)(lpVtbl[7]))((IInputPane*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IInputPane.xml' path='doc/member[@name="IInputPane.add_Hiding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_Hiding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CInputPane_Windows__CUI__CViewManagement__CInputPaneVisibilityEventArgs_t *")] ITypedEventHandler<Pointer<IInputPane>, Pointer<IInputPaneVisibilityEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane*, ITypedEventHandler<Pointer<IInputPane>, Pointer<IInputPaneVisibilityEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IInputPane*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IInputPane.xml' path='doc/member[@name="IInputPane.remove_Hiding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_Hiding(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane*, EventRegistrationToken, int>)(lpVtbl[9]))((IInputPane*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IInputPane.xml' path='doc/member[@name="IInputPane.get_OccludedRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_OccludedRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane*, Rect*, int>)(lpVtbl[10]))((IInputPane*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_Showing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CInputPane_Windows__CUI__CViewManagement__CInputPaneVisibilityEventArgs_t *")] ITypedEventHandler<Pointer<IInputPane>, Pointer<IInputPaneVisibilityEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_Showing(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_Hiding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CInputPane_Windows__CUI__CViewManagement__CInputPaneVisibilityEventArgs_t *")] ITypedEventHandler<Pointer<IInputPane>, Pointer<IInputPaneVisibilityEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_Hiding(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT get_OccludedRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CInputPane_Windows__CUI__CViewManagement__CInputPaneVisibilityEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInputPane>, Pointer<IInputPaneVisibilityEventArgs>>*, EventRegistrationToken*, int> add_Showing;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Showing;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CInputPane_Windows__CUI__CViewManagement__CInputPaneVisibilityEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInputPane>, Pointer<IInputPaneVisibilityEventArgs>>*, EventRegistrationToken*, int> add_Hiding;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Hiding;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> get_OccludedRect;
    }
}
