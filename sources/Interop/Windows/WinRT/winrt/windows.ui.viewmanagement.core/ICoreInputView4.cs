// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreInputView4.xml' path='doc/member[@name="ICoreInputView4"]/*' />
[Guid("002863D6-D9EF-57EB-8CEF-77F6CE1B7EE7")]
[NativeTypeName("struct ICoreInputView4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreInputView4 : ICoreInputView4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreInputView4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView4*, Guid*, void**, int>)(lpVtbl[0]))((ICoreInputView4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView4*, uint>)(lpVtbl[1]))((ICoreInputView4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView4*, uint>)(lpVtbl[2]))((ICoreInputView4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView4*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreInputView4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView4*, HSTRING*, int>)(lpVtbl[4]))((ICoreInputView4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView4*, TrustLevel*, int>)(lpVtbl[5]))((ICoreInputView4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreInputView4.xml' path='doc/member[@name="ICoreInputView4.add_PrimaryViewShowing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_PrimaryViewShowing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_Windows__CUI__CViewManagement__CCore__CCoreInputViewShowingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewShowingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView4*, ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewShowingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreInputView4*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreInputView4.xml' path='doc/member[@name="ICoreInputView4.remove_PrimaryViewShowing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_PrimaryViewShowing(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView4*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreInputView4*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICoreInputView4.xml' path='doc/member[@name="ICoreInputView4.add_PrimaryViewHiding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_PrimaryViewHiding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_Windows__CUI__CViewManagement__CCore__CCoreInputViewHidingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewHidingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView4*, ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewHidingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ICoreInputView4*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreInputView4.xml' path='doc/member[@name="ICoreInputView4.remove_PrimaryViewHiding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_PrimaryViewHiding(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView4*, EventRegistrationToken, int>)(lpVtbl[9]))((ICoreInputView4*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_PrimaryViewShowing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_Windows__CUI__CViewManagement__CCore__CCoreInputViewShowingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewShowingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_PrimaryViewShowing(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_PrimaryViewHiding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_Windows__CUI__CViewManagement__CCore__CCoreInputViewHidingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewHidingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_PrimaryViewHiding(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_Windows__CUI__CViewManagement__CCore__CCoreInputViewShowingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewShowingEventArgs>>*, EventRegistrationToken*, int> add_PrimaryViewShowing;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PrimaryViewShowing;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_Windows__CUI__CViewManagement__CCore__CCoreInputViewHidingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewHidingEventArgs>>*, EventRegistrationToken*, int> add_PrimaryViewHiding;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PrimaryViewHiding;
    }
}
