// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B4BAF068-8F49-446C-8DB5-8C0FFE85CC9E")]
    [NativeTypeName("struct IKeyboardDeliveryInterceptor : IInspectable")]
    public unsafe partial struct IKeyboardDeliveryInterceptor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptor*, Guid*, void**, int>)(lpVtbl[0]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptor*, uint>)(lpVtbl[1]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptor*, uint>)(lpVtbl[2]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptor*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptor*, IntPtr*, int>)(lpVtbl[4]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptor*, TrustLevel*, int>)(lpVtbl[5]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsInterceptionEnabledWhenInForeground([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptor*, byte*, int>)(lpVtbl[6]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_IsInterceptionEnabledWhenInForeground([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptor*, byte, int>)(lpVtbl[7]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_KeyDown([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CKeyboardDeliveryInterceptor_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptor*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_KeyDown(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptor*, EventRegistrationToken, int>)(lpVtbl[9]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_KeyUp([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CKeyboardDeliveryInterceptor_Windows__CUI__CCore__CKeyEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptor*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_KeyUp(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IKeyboardDeliveryInterceptor*, EventRegistrationToken, int>)(lpVtbl[11]))((IKeyboardDeliveryInterceptor*)Unsafe.AsPointer(ref this), token);
        }
    }
}
