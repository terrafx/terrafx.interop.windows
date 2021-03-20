// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("231C9088-E469-4DF1-B208-6E490D71CB90")]
    [NativeTypeName("struct ICoreKeyboardInputSource : IInspectable")]
    public unsafe partial struct ICoreKeyboardInputSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreKeyboardInputSource*, Guid*, void**, int>)(lpVtbl[0]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreKeyboardInputSource*, uint>)(lpVtbl[1]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreKeyboardInputSource*, uint>)(lpVtbl[2]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreKeyboardInputSource*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreKeyboardInputSource*, IntPtr*, int>)(lpVtbl[4]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreKeyboardInputSource*, TrustLevel*, int>)(lpVtbl[5]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentKeyState([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey virtualKey, [NativeTypeName("ABI::Windows::UI::Core::CoreVirtualKeyStates *")] CoreVirtualKeyStates* KeyState)
        {
            return ((delegate* unmanaged<ICoreKeyboardInputSource*, VirtualKey, CoreVirtualKeyStates*, int>)(lpVtbl[6]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), virtualKey, KeyState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_CharacterReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CCharacterReceivedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreKeyboardInputSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[7]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_CharacterReceived(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreKeyboardInputSource*, EventRegistrationToken, int>)(lpVtbl[8]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_KeyDown([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreKeyboardInputSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_KeyDown(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreKeyboardInputSource*, EventRegistrationToken, int>)(lpVtbl[10]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_KeyUp([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreKeyboardInputSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[11]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_KeyUp(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreKeyboardInputSource*, EventRegistrationToken, int>)(lpVtbl[12]))((ICoreKeyboardInputSource*)Unsafe.AsPointer(ref this), cookie);
        }
    }
}
