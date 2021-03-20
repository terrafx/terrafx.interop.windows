// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("759F4D90-1DC0-55CB-AD18-B9101456F592")]
    [NativeTypeName("struct IPenDockListener : IInspectable")]
    public unsafe partial struct IPenDockListener
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPenDockListener*, Guid*, void**, int>)(lpVtbl[0]))((IPenDockListener*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPenDockListener*, uint>)(lpVtbl[1]))((IPenDockListener*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPenDockListener*, uint>)(lpVtbl[2]))((IPenDockListener*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPenDockListener*, uint*, Guid**, int>)(lpVtbl[3]))((IPenDockListener*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPenDockListener*, IntPtr*, int>)(lpVtbl[4]))((IPenDockListener*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPenDockListener*, TrustLevel*, int>)(lpVtbl[5]))((IPenDockListener*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsSupported([NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IPenDockListener*, byte*, int>)(lpVtbl[6]))((IPenDockListener*)Unsafe.AsPointer(ref this), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_IsSupportedChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenDockListener_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IPenDockListener*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IPenDockListener*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_IsSupportedChanged(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IPenDockListener*, EventRegistrationToken, int>)(lpVtbl[8]))((IPenDockListener*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Docked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenDockListener_Windows__CDevices__CInput__CPenDockedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IPenDockListener*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IPenDockListener*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Docked(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IPenDockListener*, EventRegistrationToken, int>)(lpVtbl[10]))((IPenDockListener*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Undocked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CInput__CPenDockListener_Windows__CDevices__CInput__CPenUndockedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IPenDockListener*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IPenDockListener*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Undocked(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IPenDockListener*, EventRegistrationToken, int>)(lpVtbl[12]))((IPenDockListener*)Unsafe.AsPointer(ref this), token);
        }
    }
}
