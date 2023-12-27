// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow"]/*' />
[Guid("79B9D5F2-879E-4B89-B798-79E47598030C")]
[NativeTypeName("struct ICoreWindow : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreWindow : ICoreWindow.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreWindow));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, uint>)(lpVtbl[1]))((ICoreWindow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, uint>)(lpVtbl[2]))((ICoreWindow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindow*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, HSTRING*, int>)(lpVtbl[4]))((ICoreWindow*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindow*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.get_AutomationHostProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AutomationHostProvider(IInspectable** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, IInspectable**, int>)(lpVtbl[6]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.get_Bounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Bounds([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, Rect*, int>)(lpVtbl[7]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.get_CustomProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CustomProperties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, IPropertySet**, int>)(lpVtbl[8]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.get_Dispatcher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Dispatcher([NativeTypeName("ABI::Windows::UI::Core::ICoreDispatcher **")] ICoreDispatcher** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ICoreDispatcher**, int>)(lpVtbl[9]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.get_FlowDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FlowDirection([NativeTypeName("ABI::Windows::UI::Core::CoreWindowFlowDirection *")] CoreWindowFlowDirection* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, CoreWindowFlowDirection*, int>)(lpVtbl[10]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.put_FlowDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_FlowDirection([NativeTypeName("ABI::Windows::UI::Core::CoreWindowFlowDirection")] CoreWindowFlowDirection value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, CoreWindowFlowDirection, int>)(lpVtbl[11]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.get_IsInputEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsInputEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, byte*, int>)(lpVtbl[12]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.put_IsInputEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_IsInputEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, byte, int>)(lpVtbl[13]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.get_PointerCursor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PointerCursor([NativeTypeName("ABI::Windows::UI::Core::ICoreCursor **")] ICoreCursor** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ICoreCursor**, int>)(lpVtbl[14]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.put_PointerCursor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_PointerCursor([NativeTypeName("ABI::Windows::UI::Core::ICoreCursor *")] ICoreCursor* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ICoreCursor*, int>)(lpVtbl[15]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.get_PointerPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_PointerPosition([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, Point*, int>)(lpVtbl[16]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.get_Visible"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Visible([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, byte*, int>)(lpVtbl[17]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.Activate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT Activate()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, int>)(lpVtbl[18]))((ICoreWindow*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.Close"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, int>)(lpVtbl[19]))((ICoreWindow*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.GetAsyncKeyState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetAsyncKeyState([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey virtualKey, [NativeTypeName("ABI::Windows::UI::Core::CoreVirtualKeyStates *")] CoreVirtualKeyStates* KeyState)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, VirtualKey, CoreVirtualKeyStates*, int>)(lpVtbl[20]))((ICoreWindow*)Unsafe.AsPointer(ref this), virtualKey, KeyState);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.GetKeyState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetKeyState([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey virtualKey, [NativeTypeName("ABI::Windows::UI::Core::CoreVirtualKeyStates *")] CoreVirtualKeyStates* KeyState)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, VirtualKey, CoreVirtualKeyStates*, int>)(lpVtbl[21]))((ICoreWindow*)Unsafe.AsPointer(ref this), virtualKey, KeyState);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.ReleasePointerCapture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT ReleasePointerCapture()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, int>)(lpVtbl[22]))((ICoreWindow*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.SetPointerCapture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetPointerCapture()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, int>)(lpVtbl[23]))((ICoreWindow*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_Activated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT add_Activated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CWindowActivatedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IWindowActivatedEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IWindowActivatedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[24]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_Activated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT remove_Activated(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[25]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_AutomationProviderRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT add_AutomationProviderRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CAutomationProviderRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IAutomationProviderRequestedEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IAutomationProviderRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[26]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_AutomationProviderRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT remove_AutomationProviderRequested(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[27]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_CharacterReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT add_CharacterReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCharacterReceivedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICharacterReceivedEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICharacterReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[28]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_CharacterReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT remove_CharacterReceived(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[29]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCoreWindowEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICoreWindowEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICoreWindowEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[30]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT remove_Closed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[31]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_InputEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT add_InputEnabled([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CInputEnabledEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IInputEnabledEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IInputEnabledEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[32]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_InputEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT remove_InputEnabled(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[33]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_KeyDown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT add_KeyDown([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IKeyEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IKeyEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[34]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_KeyDown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT remove_KeyDown(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[35]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_KeyUp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT add_KeyUp([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IKeyEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IKeyEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[36]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_KeyUp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT remove_KeyUp(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[37]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_PointerCaptureLost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT add_PointerCaptureLost([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[38]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_PointerCaptureLost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT remove_PointerCaptureLost(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[39]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_PointerEntered"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT add_PointerEntered([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[40]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_PointerEntered"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT remove_PointerEntered(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[41]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_PointerExited"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT add_PointerExited([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[42]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_PointerExited"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT remove_PointerExited(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[43]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_PointerMoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT add_PointerMoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[44]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_PointerMoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT remove_PointerMoved(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[45]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_PointerPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT add_PointerPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[46]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_PointerPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT remove_PointerPressed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[47]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_PointerReleased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT add_PointerReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[48]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_PointerReleased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT remove_PointerReleased(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[49]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_TouchHitTesting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT add_TouchHitTesting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CTouchHitTestingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ITouchHitTestingEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ITouchHitTestingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[50]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_TouchHitTesting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT remove_TouchHitTesting(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[51]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_PointerWheelChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT add_PointerWheelChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[52]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_PointerWheelChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT remove_PointerWheelChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[53]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_SizeChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT add_SizeChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CWindowSizeChangedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IWindowSizeChangedEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IWindowSizeChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[54]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_SizeChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT remove_SizeChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[55]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.add_VisibilityChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT add_VisibilityChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CVisibilityChangedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IVisibilityChangedEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IVisibilityChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[56]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreWindow.xml' path='doc/member[@name="ICoreWindow.remove_VisibilityChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT remove_VisibilityChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[57]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AutomationHostProvider(IInspectable** value);

        [VtblIndex(7)]
        HRESULT get_Bounds([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(8)]
        HRESULT get_CustomProperties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value);

        [VtblIndex(9)]
        HRESULT get_Dispatcher([NativeTypeName("ABI::Windows::UI::Core::ICoreDispatcher **")] ICoreDispatcher** value);

        [VtblIndex(10)]
        HRESULT get_FlowDirection([NativeTypeName("ABI::Windows::UI::Core::CoreWindowFlowDirection *")] CoreWindowFlowDirection* value);

        [VtblIndex(11)]
        HRESULT put_FlowDirection([NativeTypeName("ABI::Windows::UI::Core::CoreWindowFlowDirection")] CoreWindowFlowDirection value);

        [VtblIndex(12)]
        HRESULT get_IsInputEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_IsInputEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT get_PointerCursor([NativeTypeName("ABI::Windows::UI::Core::ICoreCursor **")] ICoreCursor** value);

        [VtblIndex(15)]
        HRESULT put_PointerCursor([NativeTypeName("ABI::Windows::UI::Core::ICoreCursor *")] ICoreCursor* value);

        [VtblIndex(16)]
        HRESULT get_PointerPosition([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(17)]
        HRESULT get_Visible([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(18)]
        HRESULT Activate();

        [VtblIndex(19)]
        HRESULT Close();

        [VtblIndex(20)]
        HRESULT GetAsyncKeyState([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey virtualKey, [NativeTypeName("ABI::Windows::UI::Core::CoreVirtualKeyStates *")] CoreVirtualKeyStates* KeyState);

        [VtblIndex(21)]
        HRESULT GetKeyState([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey virtualKey, [NativeTypeName("ABI::Windows::UI::Core::CoreVirtualKeyStates *")] CoreVirtualKeyStates* KeyState);

        [VtblIndex(22)]
        HRESULT ReleasePointerCapture();

        [VtblIndex(23)]
        HRESULT SetPointerCapture();

        [VtblIndex(24)]
        HRESULT add_Activated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CWindowActivatedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IWindowActivatedEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(25)]
        HRESULT remove_Activated(EventRegistrationToken cookie);

        [VtblIndex(26)]
        HRESULT add_AutomationProviderRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CAutomationProviderRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IAutomationProviderRequestedEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(27)]
        HRESULT remove_AutomationProviderRequested(EventRegistrationToken cookie);

        [VtblIndex(28)]
        HRESULT add_CharacterReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCharacterReceivedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICharacterReceivedEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(29)]
        HRESULT remove_CharacterReceived(EventRegistrationToken cookie);

        [VtblIndex(30)]
        HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCoreWindowEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICoreWindowEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(31)]
        HRESULT remove_Closed(EventRegistrationToken cookie);

        [VtblIndex(32)]
        HRESULT add_InputEnabled([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CInputEnabledEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IInputEnabledEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(33)]
        HRESULT remove_InputEnabled(EventRegistrationToken cookie);

        [VtblIndex(34)]
        HRESULT add_KeyDown([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IKeyEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(35)]
        HRESULT remove_KeyDown(EventRegistrationToken cookie);

        [VtblIndex(36)]
        HRESULT add_KeyUp([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IKeyEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(37)]
        HRESULT remove_KeyUp(EventRegistrationToken cookie);

        [VtblIndex(38)]
        HRESULT add_PointerCaptureLost([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(39)]
        HRESULT remove_PointerCaptureLost(EventRegistrationToken cookie);

        [VtblIndex(40)]
        HRESULT add_PointerEntered([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(41)]
        HRESULT remove_PointerEntered(EventRegistrationToken cookie);

        [VtblIndex(42)]
        HRESULT add_PointerExited([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(43)]
        HRESULT remove_PointerExited(EventRegistrationToken cookie);

        [VtblIndex(44)]
        HRESULT add_PointerMoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(45)]
        HRESULT remove_PointerMoved(EventRegistrationToken cookie);

        [VtblIndex(46)]
        HRESULT add_PointerPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(47)]
        HRESULT remove_PointerPressed(EventRegistrationToken cookie);

        [VtblIndex(48)]
        HRESULT add_PointerReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(49)]
        HRESULT remove_PointerReleased(EventRegistrationToken cookie);

        [VtblIndex(50)]
        HRESULT add_TouchHitTesting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CTouchHitTestingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ITouchHitTestingEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(51)]
        HRESULT remove_TouchHitTesting(EventRegistrationToken cookie);

        [VtblIndex(52)]
        HRESULT add_PointerWheelChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(53)]
        HRESULT remove_PointerWheelChanged(EventRegistrationToken cookie);

        [VtblIndex(54)]
        HRESULT add_SizeChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CWindowSizeChangedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IWindowSizeChangedEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(55)]
        HRESULT remove_SizeChanged(EventRegistrationToken cookie);

        [VtblIndex(56)]
        HRESULT add_VisibilityChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CVisibilityChangedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IVisibilityChangedEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(57)]
        HRESULT remove_VisibilityChanged(EventRegistrationToken cookie);
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

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> get_AutomationHostProvider;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> get_Bounds;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet**, int> get_CustomProperties;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::ICoreDispatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreDispatcher**, int> get_Dispatcher;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CoreWindowFlowDirection *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreWindowFlowDirection*, int> get_FlowDirection;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CoreWindowFlowDirection) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreWindowFlowDirection, int> put_FlowDirection;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsInputEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsInputEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::ICoreCursor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreCursor**, int> get_PointerCursor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::ICoreCursor *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreCursor*, int> put_PointerCursor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point*, int> get_PointerPosition;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Visible;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Activate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Close;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey, ABI::Windows::UI::Core::CoreVirtualKeyStates *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey, CoreVirtualKeyStates*, int> GetAsyncKeyState;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey, ABI::Windows::UI::Core::CoreVirtualKeyStates *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey, CoreVirtualKeyStates*, int> GetKeyState;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ReleasePointerCapture;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> SetPointerCapture;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CWindowActivatedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IWindowActivatedEventArgs>>*, EventRegistrationToken*, int> add_Activated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Activated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CAutomationProviderRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IAutomationProviderRequestedEventArgs>>*, EventRegistrationToken*, int> add_AutomationProviderRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AutomationProviderRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCharacterReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICharacterReceivedEventArgs>>*, EventRegistrationToken*, int> add_CharacterReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CharacterReceived;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCoreWindowEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICoreWindowEventArgs>>*, EventRegistrationToken*, int> add_Closed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Closed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CInputEnabledEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IInputEnabledEventArgs>>*, EventRegistrationToken*, int> add_InputEnabled;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_InputEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CKeyEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IKeyEventArgs>>*, EventRegistrationToken*, int> add_KeyDown;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_KeyDown;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CKeyEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IKeyEventArgs>>*, EventRegistrationToken*, int> add_KeyUp;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_KeyUp;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerCaptureLost;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerCaptureLost;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerEntered;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerEntered;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerExited;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerExited;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerMoved;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerMoved;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerPressed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerReleased;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerReleased;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CTouchHitTestingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ITouchHitTestingEventArgs>>*, EventRegistrationToken*, int> add_TouchHitTesting;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_TouchHitTesting;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerWheelChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerWheelChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CWindowSizeChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IWindowSizeChangedEventArgs>>*, EventRegistrationToken*, int> add_SizeChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SizeChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CVisibilityChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IVisibilityChangedEventArgs>>*, EventRegistrationToken*, int> add_VisibilityChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_VisibilityChanged;
    }
}
