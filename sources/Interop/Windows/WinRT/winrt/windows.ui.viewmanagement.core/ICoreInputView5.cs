// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreInputView5.xml' path='doc/member[@name="ICoreInputView5"]/*' />
[Guid("136316E0-C6D5-5C57-811E-1AD8A99BA6AB")]
[NativeTypeName("struct ICoreInputView5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreInputView5 : ICoreInputView5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreInputView5));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView5*, Guid*, void**, int>)(lpVtbl[0]))((ICoreInputView5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView5*, uint>)(lpVtbl[1]))((ICoreInputView5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView5*, uint>)(lpVtbl[2]))((ICoreInputView5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView5*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreInputView5*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView5*, HSTRING*, int>)(lpVtbl[4]))((ICoreInputView5*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView5*, TrustLevel*, int>)(lpVtbl[5]))((ICoreInputView5*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreInputView5.xml' path='doc/member[@name="ICoreInputView5.IsKindSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsKindSupported([NativeTypeName("ABI::Windows::UI::ViewManagement::Core::CoreInputViewKind")] CoreInputViewKind type, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView5*, CoreInputViewKind, byte*, int>)(lpVtbl[6]))((ICoreInputView5*)Unsafe.AsPointer(ref this), type, result);
    }

    /// <include file='ICoreInputView5.xml' path='doc/member[@name="ICoreInputView5.add_SupportedKindsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_SupportedKindsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_IInspectable_t *")] ITypedEventHandler<Pointer<ICoreInputView>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView5*, ITypedEventHandler<Pointer<ICoreInputView>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((ICoreInputView5*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreInputView5.xml' path='doc/member[@name="ICoreInputView5.remove_SupportedKindsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_SupportedKindsChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView5*, EventRegistrationToken, int>)(lpVtbl[8]))((ICoreInputView5*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICoreInputView5.xml' path='doc/member[@name="ICoreInputView5.add_PrimaryViewAnimationStarting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_PrimaryViewAnimationStarting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_Windows__CUI__CViewManagement__CCore__CCoreInputViewAnimationStartingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewAnimationStartingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView5*, ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewAnimationStartingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ICoreInputView5*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreInputView5.xml' path='doc/member[@name="ICoreInputView5.remove_PrimaryViewAnimationStarting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_PrimaryViewAnimationStarting(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView5*, EventRegistrationToken, int>)(lpVtbl[10]))((ICoreInputView5*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsKindSupported([NativeTypeName("ABI::Windows::UI::ViewManagement::Core::CoreInputViewKind")] CoreInputViewKind type, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(7)]
        HRESULT add_SupportedKindsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_IInspectable_t *")] ITypedEventHandler<Pointer<ICoreInputView>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_SupportedKindsChanged(EventRegistrationToken token);

        [VtblIndex(9)]
        HRESULT add_PrimaryViewAnimationStarting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_Windows__CUI__CViewManagement__CCore__CCoreInputViewAnimationStartingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewAnimationStartingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_PrimaryViewAnimationStarting(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::Core::CoreInputViewKind, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreInputViewKind, byte*, int> IsKindSupported;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreInputView>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_SupportedKindsChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SupportedKindsChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_Windows__CUI__CViewManagement__CCore__CCoreInputViewAnimationStartingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewAnimationStartingEventArgs>>*, EventRegistrationToken*, int> add_PrimaryViewAnimationStarting;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PrimaryViewAnimationStarting;
    }
}
