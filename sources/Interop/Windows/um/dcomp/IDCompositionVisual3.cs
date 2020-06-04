// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2775F462-B6C1-4015-B0BE-B3E7D6A4976D")]
    public unsafe partial struct IDCompositionVisual3
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionVisual3*, uint>)(lpVtbl[1]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionVisual3*, uint>)(lpVtbl[2]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX(float offsetX)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, float, int>)(lpVtbl[3]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY(float offsetY)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, float, int>)(lpVtbl[5]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, D2D_MATRIX_3X2_F*, int>)(lpVtbl[7]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), matrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("IDCompositionTransform *")] IDCompositionTransform* transform)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, IDCompositionTransform*, int>)(lpVtbl[8]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransformParent([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, IDCompositionVisual*, int>)(lpVtbl[9]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEffect([NativeTypeName("IDCompositionEffect *")] IDCompositionEffect* effect)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, IDCompositionEffect*, int>)(lpVtbl[10]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), effect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBitmapInterpolationMode(DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, DCOMPOSITION_BITMAP_INTERPOLATION_MODE, int>)(lpVtbl[11]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderMode(DCOMPOSITION_BORDER_MODE borderMode)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, DCOMPOSITION_BORDER_MODE, int>)(lpVtbl[12]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), borderMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClip([NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* rect)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, D2D_RECT_F*, int>)(lpVtbl[13]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), rect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClip([NativeTypeName("IDCompositionClip *")] IDCompositionClip* clip)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, IDCompositionClip*, int>)(lpVtbl[14]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), clip);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContent([NativeTypeName("IUnknown *")] IUnknown* content)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, IUnknown*, int>)(lpVtbl[15]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), content);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddVisual([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual, [NativeTypeName("BOOL")] int insertAbove, [NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* referenceVisual)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, IDCompositionVisual*, int, IDCompositionVisual*, int>)(lpVtbl[16]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual, insertAbove, referenceVisual);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveVisual([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, IDCompositionVisual*, int>)(lpVtbl[17]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAllVisuals()
        {
            return ((delegate* stdcall<IDCompositionVisual3*, int>)(lpVtbl[18]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE compositeMode)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, DCOMPOSITION_COMPOSITE_MODE, int>)(lpVtbl[19]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), compositeMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpacityMode(DCOMPOSITION_OPACITY_MODE mode)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, DCOMPOSITION_OPACITY_MODE, int>)(lpVtbl[20]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), mode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBackFaceVisibility(DCOMPOSITION_BACKFACE_VISIBILITY visibility)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, DCOMPOSITION_BACKFACE_VISIBILITY, int>)(lpVtbl[21]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visibility);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableHeatMap([NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, DXGI_RGBA*, int>)(lpVtbl[22]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), color);
        }

        [return: NativeTypeName("HRESULT")]
        public int DisableHeatMap()
        {
            return ((delegate* stdcall<IDCompositionVisual3*, int>)(lpVtbl[23]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableRedrawRegions()
        {
            return ((delegate* stdcall<IDCompositionVisual3*, int>)(lpVtbl[24]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DisableRedrawRegions()
        {
            return ((delegate* stdcall<IDCompositionVisual3*, int>)(lpVtbl[25]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDepthMode(DCOMPOSITION_DEPTH_MODE mode)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, DCOMPOSITION_DEPTH_MODE, int>)(lpVtbl[26]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), mode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetZ(float offsetZ)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, float, int>)(lpVtbl[27]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetZ);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetZ([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[28]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpacity(float opacity)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, float, int>)(lpVtbl[29]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), opacity);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpacity([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[30]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("const D2D_MATRIX_4X4_F &")] D2D_MATRIX_4X4_F* matrix)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, D2D_MATRIX_4X4_F*, int>)(lpVtbl[31]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), matrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("IDCompositionTransform3D *")] IDCompositionTransform3D* transform)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, IDCompositionTransform3D*, int>)(lpVtbl[32]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVisible([NativeTypeName("BOOL")] int visible)
        {
            return ((delegate* stdcall<IDCompositionVisual3*, int, int>)(lpVtbl[33]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visible);
        }
    }
}
