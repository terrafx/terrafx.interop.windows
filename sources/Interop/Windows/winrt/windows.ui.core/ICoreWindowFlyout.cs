// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E89D854D-2050-40BB-B344-F6F355EEB314")]
    [NativeTypeName("struct ICoreWindowFlyout : IInspectable")]
    public unsafe partial struct ICoreWindowFlyout
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, uint>)(lpVtbl[1]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, uint>)(lpVtbl[2]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, IntPtr*, int>)(lpVtbl[4]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Showing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCoreWindowPopupShowingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Showing(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MaxSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, Size*, int>)(lpVtbl[8]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MinSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, Size*, int>)(lpVtbl[9]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Title([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, IntPtr*, int>)(lpVtbl[10]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Title([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, IntPtr, int>)(lpVtbl[11]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsInteractionDelayed([NativeTypeName("INT32 *")] int* value)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, int*, int>)(lpVtbl[12]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_IsInteractionDelayed([NativeTypeName("INT32")] int value)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, int, int>)(lpVtbl[13]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Commands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, IVector<IntPtr>**, int>)(lpVtbl[14]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DefaultCommandIndex([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, uint*, int>)(lpVtbl[15]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DefaultCommandIndex([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, uint, int>)(lpVtbl[16]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BackButtonCommand([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler **")] IUICommandInvokedHandler** value)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, IUICommandInvokedHandler**, int>)(lpVtbl[17]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_BackButtonCommand([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")] IUICommandInvokedHandler* value)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, IUICommandInvokedHandler*, int>)(lpVtbl[18]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<IntPtr>** asyncInfo)
        {
            return ((delegate* unmanaged<ICoreWindowFlyout*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[19]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), asyncInfo);
        }
    }
}
