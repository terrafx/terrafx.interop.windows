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
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDCompositionVisual3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX(float offsetX)
        {
            return lpVtbl->SetOffsetX((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetOffsetX1((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY(float offsetY)
        {
            return lpVtbl->SetOffsetY((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetOffsetY1((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix)
        {
            return lpVtbl->SetTransform((IDCompositionVisual3*)Unsafe.AsPointer(ref this), matrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("IDCompositionTransform *")] IDCompositionTransform* transform)
        {
            return lpVtbl->SetTransform1((IDCompositionVisual3*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransformParent([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual)
        {
            return lpVtbl->SetTransformParent((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEffect([NativeTypeName("IDCompositionEffect *")] IDCompositionEffect* effect)
        {
            return lpVtbl->SetEffect((IDCompositionVisual3*)Unsafe.AsPointer(ref this), effect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBitmapInterpolationMode(DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode)
        {
            return lpVtbl->SetBitmapInterpolationMode((IDCompositionVisual3*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderMode(DCOMPOSITION_BORDER_MODE borderMode)
        {
            return lpVtbl->SetBorderMode((IDCompositionVisual3*)Unsafe.AsPointer(ref this), borderMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClip([NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* rect)
        {
            return lpVtbl->SetClip((IDCompositionVisual3*)Unsafe.AsPointer(ref this), rect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClip([NativeTypeName("IDCompositionClip *")] IDCompositionClip* clip)
        {
            return lpVtbl->SetClip1((IDCompositionVisual3*)Unsafe.AsPointer(ref this), clip);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContent([NativeTypeName("IUnknown *")] IUnknown* content)
        {
            return lpVtbl->SetContent((IDCompositionVisual3*)Unsafe.AsPointer(ref this), content);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddVisual([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual, [NativeTypeName("BOOL")] int insertAbove, [NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* referenceVisual)
        {
            return lpVtbl->AddVisual((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual, insertAbove, referenceVisual);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveVisual([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual)
        {
            return lpVtbl->RemoveVisual((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAllVisuals()
        {
            return lpVtbl->RemoveAllVisuals((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE compositeMode)
        {
            return lpVtbl->SetCompositeMode((IDCompositionVisual3*)Unsafe.AsPointer(ref this), compositeMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpacityMode(DCOMPOSITION_OPACITY_MODE mode)
        {
            return lpVtbl->SetOpacityMode((IDCompositionVisual3*)Unsafe.AsPointer(ref this), mode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBackFaceVisibility(DCOMPOSITION_BACKFACE_VISIBILITY visibility)
        {
            return lpVtbl->SetBackFaceVisibility((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visibility);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableHeatMap([NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color)
        {
            return lpVtbl->EnableHeatMap((IDCompositionVisual3*)Unsafe.AsPointer(ref this), color);
        }

        [return: NativeTypeName("HRESULT")]
        public int DisableHeatMap()
        {
            return lpVtbl->DisableHeatMap((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableRedrawRegions()
        {
            return lpVtbl->EnableRedrawRegions((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DisableRedrawRegions()
        {
            return lpVtbl->DisableRedrawRegions((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDepthMode(DCOMPOSITION_DEPTH_MODE mode)
        {
            return lpVtbl->SetDepthMode((IDCompositionVisual3*)Unsafe.AsPointer(ref this), mode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetZ(float offsetZ)
        {
            return lpVtbl->SetOffsetZ((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetZ);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetZ([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetOffsetZ1((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpacity(float opacity)
        {
            return lpVtbl->SetOpacity((IDCompositionVisual3*)Unsafe.AsPointer(ref this), opacity);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpacity([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetOpacity1((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("const D2D_MATRIX_4X4_F &")] D2D_MATRIX_4X4_F* matrix)
        {
            return lpVtbl->SetTransform2((IDCompositionVisual3*)Unsafe.AsPointer(ref this), matrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("IDCompositionTransform3D *")] IDCompositionTransform3D* transform)
        {
            return lpVtbl->SetTransform3((IDCompositionVisual3*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVisible([NativeTypeName("BOOL")] int visible)
        {
            return lpVtbl->SetVisible((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visible);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, uint> Release;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, float, int> SetOffsetX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, IDCompositionAnimation*, int> SetOffsetX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, float, int> SetOffsetY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, IDCompositionAnimation*, int> SetOffsetY1;

            [NativeTypeName("HRESULT (const D2D_MATRIX_3X2_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, D2D_MATRIX_3X2_F*, int> SetTransform;

            [NativeTypeName("HRESULT (IDCompositionTransform *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, IDCompositionTransform*, int> SetTransform1;

            [NativeTypeName("HRESULT (IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, IDCompositionVisual*, int> SetTransformParent;

            [NativeTypeName("HRESULT (IDCompositionEffect *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, IDCompositionEffect*, int> SetEffect;

            [NativeTypeName("HRESULT (DCOMPOSITION_BITMAP_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, DCOMPOSITION_BITMAP_INTERPOLATION_MODE, int> SetBitmapInterpolationMode;

            [NativeTypeName("HRESULT (DCOMPOSITION_BORDER_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, DCOMPOSITION_BORDER_MODE, int> SetBorderMode;

            [NativeTypeName("HRESULT (const D2D_RECT_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, D2D_RECT_F*, int> SetClip;

            [NativeTypeName("HRESULT (IDCompositionClip *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, IDCompositionClip*, int> SetClip1;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, IUnknown*, int> SetContent;

            [NativeTypeName("HRESULT (IDCompositionVisual *, BOOL, IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, IDCompositionVisual*, int, IDCompositionVisual*, int> AddVisual;

            [NativeTypeName("HRESULT (IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, IDCompositionVisual*, int> RemoveVisual;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, int> RemoveAllVisuals;

            [NativeTypeName("HRESULT (DCOMPOSITION_COMPOSITE_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, DCOMPOSITION_COMPOSITE_MODE, int> SetCompositeMode;

            [NativeTypeName("HRESULT (DCOMPOSITION_OPACITY_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, DCOMPOSITION_OPACITY_MODE, int> SetOpacityMode;

            [NativeTypeName("HRESULT (DCOMPOSITION_BACKFACE_VISIBILITY) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, DCOMPOSITION_BACKFACE_VISIBILITY, int> SetBackFaceVisibility;

            [NativeTypeName("HRESULT (const D2D1_COLOR_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, DXGI_RGBA*, int> EnableHeatMap;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, int> DisableHeatMap;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, int> EnableRedrawRegions;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, int> DisableRedrawRegions;

            [NativeTypeName("HRESULT (DCOMPOSITION_DEPTH_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, DCOMPOSITION_DEPTH_MODE, int> SetDepthMode;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, float, int> SetOffsetZ;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, IDCompositionAnimation*, int> SetOffsetZ1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, float, int> SetOpacity;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, IDCompositionAnimation*, int> SetOpacity1;

            [NativeTypeName("HRESULT (const D2D_MATRIX_4X4_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, D2D_MATRIX_4X4_F*, int> SetTransform2;

            [NativeTypeName("HRESULT (IDCompositionTransform3D *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, IDCompositionTransform3D*, int> SetTransform3;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVisual3*, int, int> SetVisible;
        }
    }
}
