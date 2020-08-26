// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("41E64AAE-98C0-4239-8E95-A330DD6AA18B")]
    [NativeTypeName("struct ICompositionDrawingSurfaceInterop2 : ICompositionDrawingSurfaceInterop")]
    public unsafe partial struct ICompositionDrawingSurfaceInterop2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop2*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop2*, uint>)(lpVtbl[1]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop2*, uint>)(lpVtbl[2]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginDraw([NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** updateObject, [NativeTypeName("POINT *")] POINT* updateOffset)
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop2*, RECT*, Guid*, void**, POINT*, int>)(lpVtbl[3]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, updateOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop2*, int>)(lpVtbl[4]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resize(SIZE sizePixels)
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop2*, SIZE, int>)(lpVtbl[5]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this), sizePixels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Scroll([NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY)
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop2*, RECT*, RECT*, int, int, int>)(lpVtbl[6]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this), scrollRect, clipRect, offsetX, offsetY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResumeDraw()
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop2*, int>)(lpVtbl[7]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SuspendDraw()
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop2*, int>)(lpVtbl[8]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopySurface([NativeTypeName("IUnknown *")] IUnknown* destinationResource, int destinationOffsetX, int destinationOffsetY, [NativeTypeName("const RECT *")] RECT* sourceRectangle)
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop2*, IUnknown*, int, int, RECT*, int>)(lpVtbl[9]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this), destinationResource, destinationOffsetX, destinationOffsetY, sourceRectangle);
        }
    }
}
