// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4E9BC6DC-880D-47FC-A0A1-72B639E62559")]
    [NativeTypeName("struct IPopupMenu : IInspectable")]
    public unsafe partial struct IPopupMenu
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPopupMenu*, Guid*, void**, int>)(lpVtbl[0]))((IPopupMenu*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPopupMenu*, uint>)(lpVtbl[1]))((IPopupMenu*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPopupMenu*, uint>)(lpVtbl[2]))((IPopupMenu*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPopupMenu*, uint*, Guid**, int>)(lpVtbl[3]))((IPopupMenu*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPopupMenu*, IntPtr*, int>)(lpVtbl[4]))((IPopupMenu*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPopupMenu*, TrustLevel*, int>)(lpVtbl[5]))((IPopupMenu*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Commands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IPopupMenu*, IVector<IntPtr>**, int>)(lpVtbl[6]))((IPopupMenu*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowAsync([NativeTypeName("ABI::Windows::Foundation::Point")] Point invocationPoint, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<IntPtr>** asyncOperation)
        {
            return ((delegate* unmanaged<IPopupMenu*, Point, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IPopupMenu*)Unsafe.AsPointer(ref this), invocationPoint, asyncOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowAsyncWithRect([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<IntPtr>** asyncOperation)
        {
            return ((delegate* unmanaged<IPopupMenu*, Rect, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IPopupMenu*)Unsafe.AsPointer(ref this), selection, asyncOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowAsyncWithRectAndPlacement([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<IntPtr>** asyncOperation)
        {
            return ((delegate* unmanaged<IPopupMenu*, Rect, Placement, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IPopupMenu*)Unsafe.AsPointer(ref this), selection, preferredPlacement, asyncOperation);
        }
    }
}
