// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8245C376-1EE3-53F7-B1F7-8334A16F2815")]
    [NativeTypeName("struct IPenButtonListener : IInspectable")]
    public unsafe partial struct IPenButtonListener
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPenButtonListener*, Guid*, void**, int>)(lpVtbl[0]))((IPenButtonListener*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPenButtonListener*, uint>)(lpVtbl[1]))((IPenButtonListener*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPenButtonListener*, uint>)(lpVtbl[2]))((IPenButtonListener*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPenButtonListener*, uint*, Guid**, int>)(lpVtbl[3]))((IPenButtonListener*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPenButtonListener*, IntPtr*, int>)(lpVtbl[4]))((IPenButtonListener*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPenButtonListener*, TrustLevel*, int>)(lpVtbl[5]))((IPenButtonListener*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsSupported([NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IPenButtonListener*, byte*, int>)(lpVtbl[6]))((IPenButtonListener*)Unsafe.AsPointer(ref this), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_IsSupportedChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IPenButtonListener*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IPenButtonListener*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_IsSupportedChanged(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IPenButtonListener*, EventRegistrationToken, int>)(lpVtbl[8]))((IPenButtonListener*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_TailButtonClicked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_Windows__CDevices__CInput__CPenTailButtonClickedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IPenButtonListener*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IPenButtonListener*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_TailButtonClicked(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IPenButtonListener*, EventRegistrationToken, int>)(lpVtbl[10]))((IPenButtonListener*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_TailButtonDoubleClicked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_Windows__CDevices__CInput__CPenTailButtonDoubleClickedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IPenButtonListener*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IPenButtonListener*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_TailButtonDoubleClicked(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IPenButtonListener*, EventRegistrationToken, int>)(lpVtbl[12]))((IPenButtonListener*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_TailButtonLongPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenButtonListener_Windows__CDevices__CInput__CPenTailButtonLongPressedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IPenButtonListener*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IPenButtonListener*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_TailButtonLongPressed(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IPenButtonListener*, EventRegistrationToken, int>)(lpVtbl[14]))((IPenButtonListener*)Unsafe.AsPointer(ref this), token);
        }
    }
}
