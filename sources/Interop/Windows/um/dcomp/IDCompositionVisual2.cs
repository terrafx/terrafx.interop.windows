// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E8DE1639-4331-4B26-BC5F-6A321D347A85")]
    [NativeTypeName("struct IDCompositionVisual2 : IDCompositionVisual")]
    public unsafe partial struct IDCompositionVisual2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionVisual2*, uint>)(lpVtbl[1]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionVisual2*, uint>)(lpVtbl[2]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX(float offsetX)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, float, int>)(lpVtbl[3]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), offsetX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY(float offsetY)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, float, int>)(lpVtbl[5]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), offsetY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, D2D_MATRIX_3X2_F*, int>)(lpVtbl[7]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("IDCompositionTransform *")] IDCompositionTransform* transform)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, IDCompositionTransform*, int>)(lpVtbl[8]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransformParent([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, IDCompositionVisual*, int>)(lpVtbl[9]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), visual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetEffect([NativeTypeName("IDCompositionEffect *")] IDCompositionEffect* effect)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, IDCompositionEffect*, int>)(lpVtbl[10]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), effect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBitmapInterpolationMode(DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, DCOMPOSITION_BITMAP_INTERPOLATION_MODE, int>)(lpVtbl[11]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBorderMode(DCOMPOSITION_BORDER_MODE borderMode)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, DCOMPOSITION_BORDER_MODE, int>)(lpVtbl[12]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), borderMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClip([NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* rect)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, D2D_RECT_F*, int>)(lpVtbl[13]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), rect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClip([NativeTypeName("IDCompositionClip *")] IDCompositionClip* clip)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, IDCompositionClip*, int>)(lpVtbl[14]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), clip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetContent([NativeTypeName("IUnknown *")] IUnknown* content)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, IUnknown*, int>)(lpVtbl[15]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), content);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddVisual([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual, [NativeTypeName("BOOL")] int insertAbove, [NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* referenceVisual)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, IDCompositionVisual*, int, IDCompositionVisual*, int>)(lpVtbl[16]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), visual, insertAbove, referenceVisual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveVisual([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, IDCompositionVisual*, int>)(lpVtbl[17]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), visual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllVisuals()
        {
            return ((delegate* stdcall<IDCompositionVisual2*, int>)(lpVtbl[18]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE compositeMode)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, DCOMPOSITION_COMPOSITE_MODE, int>)(lpVtbl[19]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), compositeMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOpacityMode(DCOMPOSITION_OPACITY_MODE mode)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, DCOMPOSITION_OPACITY_MODE, int>)(lpVtbl[20]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBackFaceVisibility(DCOMPOSITION_BACKFACE_VISIBILITY visibility)
        {
            return ((delegate* stdcall<IDCompositionVisual2*, DCOMPOSITION_BACKFACE_VISIBILITY, int>)(lpVtbl[21]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), visibility);
        }
    }
}
