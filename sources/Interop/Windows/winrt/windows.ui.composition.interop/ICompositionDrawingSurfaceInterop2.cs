// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("41E64AAE-98C0-4239-8E95-A330DD6AA18B")]
    [NativeTypeName("struct ICompositionDrawingSurfaceInterop2 : ICompositionDrawingSurfaceInterop")]
    [NativeInheritance("ICompositionDrawingSurfaceInterop")]
    public unsafe partial struct ICompositionDrawingSurfaceInterop2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, uint>)(lpVtbl[1]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, uint>)(lpVtbl[2]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int BeginDraw([NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, void** updateObject, POINT* updateOffset)
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, RECT*, Guid*, void**, POINT*, int>)(lpVtbl[3]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, updateOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, int>)(lpVtbl[4]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Resize(SIZE sizePixels)
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, SIZE, int>)(lpVtbl[5]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this), sizePixels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Scroll([NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY)
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, RECT*, RECT*, int, int, int>)(lpVtbl[6]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this), scrollRect, clipRect, offsetX, offsetY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int ResumeDraw()
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, int>)(lpVtbl[7]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SuspendDraw()
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, int>)(lpVtbl[8]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int CopySurface(IUnknown* destinationResource, int destinationOffsetX, int destinationOffsetY, [NativeTypeName("const RECT *")] RECT* sourceRectangle)
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, IUnknown*, int, int, RECT*, int>)(lpVtbl[9]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this), destinationResource, destinationOffsetX, destinationOffsetY, sourceRectangle);
        }
    }
}
