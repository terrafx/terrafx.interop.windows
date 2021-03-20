// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BBF1BB18-E47A-48EB-8807-F8F8D3EA4551")]
    [NativeTypeName("struct ICorePointerInputSource : IInspectable")]
    public unsafe partial struct ICorePointerInputSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, Guid*, void**, int>)(lpVtbl[0]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, uint>)(lpVtbl[1]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, uint>)(lpVtbl[2]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, uint*, Guid**, int>)(lpVtbl[3]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, IntPtr*, int>)(lpVtbl[4]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, TrustLevel*, int>)(lpVtbl[5]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleasePointerCapture()
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, int>)(lpVtbl[6]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPointerCapture()
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, int>)(lpVtbl[7]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_HasCapture([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, byte*, int>)(lpVtbl[8]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PointerPosition([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, Point*, int>)(lpVtbl[9]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PointerCursor([NativeTypeName("ABI::Windows::UI::Core::ICoreCursor **")] ICoreCursor** value)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, ICoreCursor**, int>)(lpVtbl[10]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_PointerCursor([NativeTypeName("ABI::Windows::UI::Core::ICoreCursor *")] ICoreCursor* value)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, ICoreCursor*, int>)(lpVtbl[11]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerCaptureLost([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[12]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerCaptureLost(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, EventRegistrationToken, int>)(lpVtbl[13]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerEntered([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[14]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerEntered(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, EventRegistrationToken, int>)(lpVtbl[15]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerExited([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[16]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerExited(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, EventRegistrationToken, int>)(lpVtbl[17]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerMoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[18]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerMoved(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, EventRegistrationToken, int>)(lpVtbl[19]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[20]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerPressed(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, EventRegistrationToken, int>)(lpVtbl[21]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[22]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerReleased(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, EventRegistrationToken, int>)(lpVtbl[23]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PointerWheelChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[24]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PointerWheelChanged(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICorePointerInputSource*, EventRegistrationToken, int>)(lpVtbl[25]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), cookie);
        }
    }
}
