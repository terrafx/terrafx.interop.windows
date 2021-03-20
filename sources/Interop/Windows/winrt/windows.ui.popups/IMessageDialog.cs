// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("33F59B01-5325-43AB-9AB3-BDAE440E4121")]
    [NativeTypeName("struct IMessageDialog : IInspectable")]
    public unsafe partial struct IMessageDialog
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMessageDialog*, Guid*, void**, int>)(lpVtbl[0]))((IMessageDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMessageDialog*, uint>)(lpVtbl[1]))((IMessageDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMessageDialog*, uint>)(lpVtbl[2]))((IMessageDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IMessageDialog*, uint*, Guid**, int>)(lpVtbl[3]))((IMessageDialog*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IMessageDialog*, IntPtr*, int>)(lpVtbl[4]))((IMessageDialog*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IMessageDialog*, TrustLevel*, int>)(lpVtbl[5]))((IMessageDialog*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Title([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IMessageDialog*, IntPtr*, int>)(lpVtbl[6]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Title([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IMessageDialog*, IntPtr, int>)(lpVtbl[7]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Commands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IMessageDialog*, IVector<IntPtr>**, int>)(lpVtbl[8]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DefaultCommandIndex([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IMessageDialog*, uint*, int>)(lpVtbl[9]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DefaultCommandIndex([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IMessageDialog*, uint, int>)(lpVtbl[10]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CancelCommandIndex([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IMessageDialog*, uint*, int>)(lpVtbl[11]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CancelCommandIndex([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IMessageDialog*, uint, int>)(lpVtbl[12]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Content([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IMessageDialog*, IntPtr*, int>)(lpVtbl[13]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Content([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IMessageDialog*, IntPtr, int>)(lpVtbl[14]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<IntPtr>** messageDialogAsyncOperation)
        {
            return ((delegate* unmanaged<IMessageDialog*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[15]))((IMessageDialog*)Unsafe.AsPointer(ref this), messageDialogAsyncOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Options([NativeTypeName("ABI::Windows::UI::Popups::MessageDialogOptions *")] MessageDialogOptions* value)
        {
            return ((delegate* unmanaged<IMessageDialog*, MessageDialogOptions*, int>)(lpVtbl[16]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Options([NativeTypeName("ABI::Windows::UI::Popups::MessageDialogOptions")] MessageDialogOptions value)
        {
            return ((delegate* unmanaged<IMessageDialog*, MessageDialogOptions, int>)(lpVtbl[17]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
        }
    }
}
