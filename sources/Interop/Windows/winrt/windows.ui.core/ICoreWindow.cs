// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79B9D5F2-879E-4B89-B798-79E47598030C")]
    [NativeTypeName("struct ICoreWindow : IInspectable")]
    public unsafe partial struct ICoreWindow
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreWindow*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreWindow*, uint>)(lpVtbl[1]))((ICoreWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreWindow*, uint>)(lpVtbl[2]))((ICoreWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreWindow*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindow*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreWindow*, IntPtr*, int>)(lpVtbl[4]))((ICoreWindow*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreWindow*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindow*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AutomationHostProvider([NativeTypeName("IInspectable **")] IInspectable** value)
        {
            return ((delegate* unmanaged<ICoreWindow*, IInspectable**, int>)(lpVtbl[6]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Bounds([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
        {
            return ((delegate* unmanaged<ICoreWindow*, Rect*, int>)(lpVtbl[7]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CustomProperties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
        {
            return ((delegate* unmanaged<ICoreWindow*, IPropertySet**, int>)(lpVtbl[8]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Dispatcher([NativeTypeName("ABI::Windows::UI::Core::ICoreDispatcher **")] ICoreDispatcher** value)
        {
            return ((delegate* unmanaged<ICoreWindow*, ICoreDispatcher**, int>)(lpVtbl[9]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FlowDirection([NativeTypeName("ABI::Windows::UI::Core::CoreWindowFlowDirection *")] CoreWindowFlowDirection* value)
        {
            return ((delegate* unmanaged<ICoreWindow*, CoreWindowFlowDirection*, int>)(lpVtbl[10]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_FlowDirection([NativeTypeName("ABI::Windows::UI::Core::CoreWindowFlowDirection")] CoreWindowFlowDirection value)
        {
            return ((delegate* unmanaged<ICoreWindow*, CoreWindowFlowDirection, int>)(lpVtbl[11]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsInputEnabled([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ICoreWindow*, byte*, int>)(lpVtbl[12]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_IsInputEnabled([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<ICoreWindow*, byte, int>)(lpVtbl[13]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PointerCursor([NativeTypeName("ABI::Windows::UI::Core::ICoreCursor **")] ICoreCursor** value)
        {
            return ((delegate* unmanaged<ICoreWindow*, ICoreCursor**, int>)(lpVtbl[14]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_PointerCursor([NativeTypeName("ABI::Windows::UI::Core::ICoreCursor *")] ICoreCursor* value)
        {
            return ((delegate* unmanaged<ICoreWindow*, ICoreCursor*, int>)(lpVtbl[15]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PointerPosition([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
        {
            return ((delegate* unmanaged<ICoreWindow*, Point*, int>)(lpVtbl[16]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Visible([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ICoreWindow*, byte*, int>)(lpVtbl[17]))((ICoreWindow*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Activate()
        {
            return ((delegate* unmanaged<ICoreWindow*, int>)(lpVtbl[18]))((ICoreWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged<ICoreWindow*, int>)(lpVtbl[19]))((ICoreWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAsyncKeyState([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey virtualKey, [NativeTypeName("ABI::Windows::UI::Core::CoreVirtualKeyStates *")] CoreVirtualKeyStates* KeyState)
        {
            return ((delegate* unmanaged<ICoreWindow*, VirtualKey, CoreVirtualKeyStates*, int>)(lpVtbl[20]))((ICoreWindow*)Unsafe.AsPointer(ref this), virtualKey, KeyState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetKeyState([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey virtualKey, [NativeTypeName("ABI::Windows::UI::Core::CoreVirtualKeyStates *")] CoreVirtualKeyStates* KeyState)
        {
            return ((delegate* unmanaged<ICoreWindow*, VirtualKey, CoreVirtualKeyStates*, int>)(lpVtbl[21]))((ICoreWindow*)Unsafe.AsPointer(ref this), virtualKey, KeyState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleasePointerCapture()
        {
            return ((delegate* unmanaged<ICoreWindow*, int>)(lpVtbl[22]))((ICoreWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPointerCapture()
        {
            return ((delegate* unmanaged<ICoreWindow*, int>)(lpVtbl[23]))((ICoreWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Activated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CWindowActivatedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[24]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Activated(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[25]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_AutomationProviderRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CAutomationProviderRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[26]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_AutomationProviderRequested(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[27]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_CharacterReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCharacterReceivedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[28]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_CharacterReceived(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[29]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCoreWindowEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[30]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Closed(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[31]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_InputEnabled([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CInputEnabledEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[32]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_InputEnabled(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[33]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_KeyDown([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[34]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_KeyDown(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[35]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_KeyUp([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[36]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_KeyUp(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[37]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerCaptureLost([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[38]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerCaptureLost(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[39]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerEntered([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[40]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerEntered(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[41]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerExited([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[42]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerExited(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[43]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerMoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[44]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerMoved(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[45]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[46]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerPressed(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[47]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[48]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerReleased(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[49]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_TouchHitTesting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CTouchHitTestingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[50]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_TouchHitTesting(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[51]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerWheelChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[52]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerWheelChanged(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[53]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_SizeChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CWindowSizeChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[54]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_SizeChanged(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[55]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_VisibilityChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CVisibilityChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[56]))((ICoreWindow*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_VisibilityChanged(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindow*, EventRegistrationToken, int>)(lpVtbl[57]))((ICoreWindow*)Unsafe.AsPointer(ref this), cookie);
        }
    }
}
