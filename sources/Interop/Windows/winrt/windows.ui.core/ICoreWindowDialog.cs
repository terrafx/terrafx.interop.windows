// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E7392CE0-C78D-427E-8B2C-01FF420C69D5")]
    [NativeTypeName("struct ICoreWindowDialog : IInspectable")]
    public unsafe partial struct ICoreWindowDialog
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, uint>)(lpVtbl[1]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, uint>)(lpVtbl[2]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, IntPtr*, int>)(lpVtbl[4]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Showing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCoreWindowPopupShowingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Showing(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MaxSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, Size*, int>)(lpVtbl[8]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MinSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, Size*, int>)(lpVtbl[9]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Title([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, IntPtr*, int>)(lpVtbl[10]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Title([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, IntPtr, int>)(lpVtbl[11]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsInteractionDelayed([NativeTypeName("INT32 *")] int* value)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, int*, int>)(lpVtbl[12]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_IsInteractionDelayed([NativeTypeName("INT32")] int value)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, int, int>)(lpVtbl[13]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Commands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, IVector<IntPtr>**, int>)(lpVtbl[14]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DefaultCommandIndex([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, uint*, int>)(lpVtbl[15]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DefaultCommandIndex([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, uint, int>)(lpVtbl[16]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CancelCommandIndex([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, uint*, int>)(lpVtbl[17]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CancelCommandIndex([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, uint, int>)(lpVtbl[18]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BackButtonCommand([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler **")] IUICommandInvokedHandler** value)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, IUICommandInvokedHandler**, int>)(lpVtbl[19]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_BackButtonCommand([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")] IUICommandInvokedHandler* value)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, IUICommandInvokedHandler*, int>)(lpVtbl[20]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<IntPtr>** asyncInfo)
        {
            return ((delegate* unmanaged<ICoreWindowDialog*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[21]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), asyncInfo);
        }
    }
}
