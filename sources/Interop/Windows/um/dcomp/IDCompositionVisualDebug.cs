// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FED2B808-5EB4-43A0-AEA3-35F65280F91B")]
    public unsafe partial struct IDCompositionVisualDebug
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, uint>)(lpVtbl[1]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, uint>)(lpVtbl[2]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX(float offsetX)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, float, int>)(lpVtbl[3]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), offsetX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY(float offsetY)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, float, int>)(lpVtbl[5]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), offsetY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, D2D_MATRIX_3X2_F*, int>)(lpVtbl[7]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), matrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("IDCompositionTransform *")] IDCompositionTransform* transform)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, IDCompositionTransform*, int>)(lpVtbl[8]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransformParent([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, IDCompositionVisual*, int>)(lpVtbl[9]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), visual);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEffect([NativeTypeName("IDCompositionEffect *")] IDCompositionEffect* effect)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, IDCompositionEffect*, int>)(lpVtbl[10]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), effect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBitmapInterpolationMode(DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, DCOMPOSITION_BITMAP_INTERPOLATION_MODE, int>)(lpVtbl[11]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderMode(DCOMPOSITION_BORDER_MODE borderMode)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, DCOMPOSITION_BORDER_MODE, int>)(lpVtbl[12]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), borderMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClip([NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* rect)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, D2D_RECT_F*, int>)(lpVtbl[13]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), rect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClip([NativeTypeName("IDCompositionClip *")] IDCompositionClip* clip)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, IDCompositionClip*, int>)(lpVtbl[14]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), clip);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContent([NativeTypeName("IUnknown *")] IUnknown* content)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, IUnknown*, int>)(lpVtbl[15]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), content);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddVisual([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual, [NativeTypeName("BOOL")] int insertAbove, [NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* referenceVisual)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, IDCompositionVisual*, int, IDCompositionVisual*, int>)(lpVtbl[16]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), visual, insertAbove, referenceVisual);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveVisual([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, IDCompositionVisual*, int>)(lpVtbl[17]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), visual);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAllVisuals()
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, int>)(lpVtbl[18]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE compositeMode)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, DCOMPOSITION_COMPOSITE_MODE, int>)(lpVtbl[19]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), compositeMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpacityMode(DCOMPOSITION_OPACITY_MODE mode)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, DCOMPOSITION_OPACITY_MODE, int>)(lpVtbl[20]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), mode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBackFaceVisibility(DCOMPOSITION_BACKFACE_VISIBILITY visibility)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, DCOMPOSITION_BACKFACE_VISIBILITY, int>)(lpVtbl[21]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), visibility);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableHeatMap([NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color)
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, DXGI_RGBA*, int>)(lpVtbl[22]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), color);
        }

        [return: NativeTypeName("HRESULT")]
        public int DisableHeatMap()
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, int>)(lpVtbl[23]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableRedrawRegions()
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, int>)(lpVtbl[24]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DisableRedrawRegions()
        {
            return ((delegate* stdcall<IDCompositionVisualDebug*, int>)(lpVtbl[25]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
        }
    }
}
