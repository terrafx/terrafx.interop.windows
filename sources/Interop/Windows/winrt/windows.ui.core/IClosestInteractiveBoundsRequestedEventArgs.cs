// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("347C11D7-F6F8-40E3-B29F-AE50D3E86486")]
    [NativeTypeName("struct IClosestInteractiveBoundsRequestedEventArgs : IInspectable")]
    public unsafe partial struct IClosestInteractiveBoundsRequestedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IClosestInteractiveBoundsRequestedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IClosestInteractiveBoundsRequestedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IClosestInteractiveBoundsRequestedEventArgs*, uint>)(lpVtbl[1]))((IClosestInteractiveBoundsRequestedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IClosestInteractiveBoundsRequestedEventArgs*, uint>)(lpVtbl[2]))((IClosestInteractiveBoundsRequestedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IClosestInteractiveBoundsRequestedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IClosestInteractiveBoundsRequestedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IClosestInteractiveBoundsRequestedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IClosestInteractiveBoundsRequestedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IClosestInteractiveBoundsRequestedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IClosestInteractiveBoundsRequestedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PointerPosition([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
        {
            return ((delegate* unmanaged<IClosestInteractiveBoundsRequestedEventArgs*, Point*, int>)(lpVtbl[6]))((IClosestInteractiveBoundsRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SearchBounds([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
        {
            return ((delegate* unmanaged<IClosestInteractiveBoundsRequestedEventArgs*, Rect*, int>)(lpVtbl[7]))((IClosestInteractiveBoundsRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ClosestInteractiveBounds([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
        {
            return ((delegate* unmanaged<IClosestInteractiveBoundsRequestedEventArgs*, Rect*, int>)(lpVtbl[8]))((IClosestInteractiveBoundsRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ClosestInteractiveBounds([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value)
        {
            return ((delegate* unmanaged<IClosestInteractiveBoundsRequestedEventArgs*, Rect, int>)(lpVtbl[9]))((IClosestInteractiveBoundsRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
