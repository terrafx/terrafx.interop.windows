// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreKeyboardInputSource.xml' path='doc/member[@name="ICoreKeyboardInputSource"]/*' />
[Guid("231C9088-E469-4DF1-B208-6E490D71CB90")]
[NativeTypeName("struct ICoreKeyboardInputSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreKeyboardInputSource : ICoreKeyboardInputSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICoreKeyboardInputSource);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreKeyboardInputSource*, Guid*, void**, int>)(lpVtbl[0]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreKeyboardInputSource*, uint>)(lpVtbl[1]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreKeyboardInputSource*, uint>)(lpVtbl[2]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreKeyboardInputSource*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreKeyboardInputSource*, HSTRING*, int>)(lpVtbl[4]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreKeyboardInputSource*, TrustLevel*, int>)(lpVtbl[5]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreKeyboardInputSource.xml' path='doc/member[@name="ICoreKeyboardInputSource.GetCurrentKeyState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentKeyState([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey virtualKey, [NativeTypeName("ABI::Windows::UI::Core::CoreVirtualKeyStates *")] CoreVirtualKeyStates* KeyState)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreKeyboardInputSource*, VirtualKey, CoreVirtualKeyStates*, int>)(lpVtbl[6]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), virtualKey, KeyState);
    }

    /// <include file='ICoreKeyboardInputSource.xml' path='doc/member[@name="ICoreKeyboardInputSource.add_CharacterReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_CharacterReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CCharacterReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<ICharacterReceivedEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreKeyboardInputSource*, ITypedEventHandler<Pointer<IInspectable>, Pointer<ICharacterReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreKeyboardInputSource.xml' path='doc/member[@name="ICoreKeyboardInputSource.remove_CharacterReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_CharacterReceived(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreKeyboardInputSource*, EventRegistrationToken, int>)(lpVtbl[8]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreKeyboardInputSource.xml' path='doc/member[@name="ICoreKeyboardInputSource.add_KeyDown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_KeyDown([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IKeyEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreKeyboardInputSource*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IKeyEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreKeyboardInputSource.xml' path='doc/member[@name="ICoreKeyboardInputSource.remove_KeyDown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_KeyDown(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreKeyboardInputSource*, EventRegistrationToken, int>)(lpVtbl[10]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreKeyboardInputSource.xml' path='doc/member[@name="ICoreKeyboardInputSource.add_KeyUp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_KeyUp([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IKeyEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreKeyboardInputSource*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IKeyEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreKeyboardInputSource.xml' path='doc/member[@name="ICoreKeyboardInputSource.remove_KeyUp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_KeyUp(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreKeyboardInputSource*, EventRegistrationToken, int>)(lpVtbl[12]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCurrentKeyState([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey virtualKey, [NativeTypeName("ABI::Windows::UI::Core::CoreVirtualKeyStates *")] CoreVirtualKeyStates* KeyState);

        [VtblIndex(7)]
        HRESULT add_CharacterReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CCharacterReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<ICharacterReceivedEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(8)]
        HRESULT remove_CharacterReceived(EventRegistrationToken cookie);

        [VtblIndex(9)]
        HRESULT add_KeyDown([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IKeyEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(10)]
        HRESULT remove_KeyDown(EventRegistrationToken cookie);

        [VtblIndex(11)]
        HRESULT add_KeyUp([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IKeyEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(12)]
        HRESULT remove_KeyUp(EventRegistrationToken cookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey, ABI::Windows::UI::Core::CoreVirtualKeyStates *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey, CoreVirtualKeyStates*, int> GetCurrentKeyState;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CCharacterReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, Pointer<ICharacterReceivedEventArgs>>*, EventRegistrationToken*, int> add_CharacterReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CharacterReceived;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CKeyEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IKeyEventArgs>>*, EventRegistrationToken*, int> add_KeyDown;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_KeyDown;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CKeyEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IKeyEventArgs>>*, EventRegistrationToken*, int> add_KeyUp;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_KeyUp;
    }
}
