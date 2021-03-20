// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("44FA4A24-2D09-42E1-8B5E-368208796A4C")]
    [NativeTypeName("struct IEdgeGestureEventArgs : IInspectable")]
    public unsafe partial struct IEdgeGestureEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IEdgeGestureEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IEdgeGestureEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEdgeGestureEventArgs*, uint>)(lpVtbl[1]))((IEdgeGestureEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEdgeGestureEventArgs*, uint>)(lpVtbl[2]))((IEdgeGestureEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IEdgeGestureEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IEdgeGestureEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IEdgeGestureEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IEdgeGestureEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IEdgeGestureEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IEdgeGestureEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Kind([NativeTypeName("ABI::Windows::UI::Input::EdgeGestureKind *")] EdgeGestureKind* value)
        {
            return ((delegate* unmanaged<IEdgeGestureEventArgs*, EdgeGestureKind*, int>)(lpVtbl[6]))((IEdgeGestureEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
