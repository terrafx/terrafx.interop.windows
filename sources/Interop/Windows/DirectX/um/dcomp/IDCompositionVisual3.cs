// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [SupportedOSPlatform("windows8.1")]
    [Guid("2775F462-B6C1-4015-B0BE-B3E7D6A4976D")]
    [NativeTypeName("struct IDCompositionVisual3 : IDCompositionVisualDebug")]
    [NativeInheritance("IDCompositionVisualDebug")]
    public unsafe partial struct IDCompositionVisual3 : IDCompositionVisual3.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, uint>)(lpVtbl[1]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, uint>)(lpVtbl[2]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetOffsetX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetOffsetX(float offsetX)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, float, int>)(lpVtbl[4]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetOffsetY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetOffsetY(float offsetY)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, float, int>)(lpVtbl[6]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetTransform(IDCompositionTransform* transform)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionTransform*, int>)(lpVtbl[7]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetTransform([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, D2D_MATRIX_3X2_F*, int>)(lpVtbl[8]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetTransformParent(IDCompositionVisual* visual)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionVisual*, int>)(lpVtbl[9]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetEffect(IDCompositionEffect* effect)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionEffect*, int>)(lpVtbl[10]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), effect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetBitmapInterpolationMode(DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_BITMAP_INTERPOLATION_MODE, int>)(lpVtbl[11]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetBorderMode(DCOMPOSITION_BORDER_MODE borderMode)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_BORDER_MODE, int>)(lpVtbl[12]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), borderMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetClip(IDCompositionClip* clip)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionClip*, int>)(lpVtbl[13]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), clip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetClip([NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* rect)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, D2D_RECT_F*, int>)(lpVtbl[14]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), rect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetContent(IUnknown* content)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IUnknown*, int>)(lpVtbl[15]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), content);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT AddVisual(IDCompositionVisual* visual, BOOL insertAbove, IDCompositionVisual* referenceVisual)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionVisual*, BOOL, IDCompositionVisual*, int>)(lpVtbl[16]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual, insertAbove, referenceVisual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT RemoveVisual(IDCompositionVisual* visual)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionVisual*, int>)(lpVtbl[17]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT RemoveAllVisuals()
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, int>)(lpVtbl[18]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE compositeMode)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_COMPOSITE_MODE, int>)(lpVtbl[19]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), compositeMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetOpacityMode(DCOMPOSITION_OPACITY_MODE mode)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_OPACITY_MODE, int>)(lpVtbl[20]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetBackFaceVisibility(DCOMPOSITION_BACKFACE_VISIBILITY visibility)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_BACKFACE_VISIBILITY, int>)(lpVtbl[21]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visibility);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT EnableHeatMap([NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, DXGI_RGBA*, int>)(lpVtbl[22]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT DisableHeatMap()
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, int>)(lpVtbl[23]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT EnableRedrawRegions()
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, int>)(lpVtbl[24]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT DisableRedrawRegions()
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, int>)(lpVtbl[25]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SetDepthMode(DCOMPOSITION_DEPTH_MODE mode)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_DEPTH_MODE, int>)(lpVtbl[26]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetOffsetZ(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[27]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT SetOffsetZ(float offsetZ)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, float, int>)(lpVtbl[28]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT SetOpacity(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[29]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT SetOpacity(float opacity)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, float, int>)(lpVtbl[30]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), opacity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT SetTransform(IDCompositionTransform3D* transform)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionTransform3D*, int>)(lpVtbl[31]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT SetTransform([NativeTypeName("const D2D_MATRIX_4X4_F &")] D2D_MATRIX_4X4_F* matrix)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, D2D_MATRIX_4X4_F*, int>)(lpVtbl[32]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT SetVisible(BOOL visible)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, BOOL, int>)(lpVtbl[33]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visible);
        }

        public interface Interface : IDCompositionVisualDebug.Interface
        {
            [VtblIndex(26)]
            HRESULT SetDepthMode(DCOMPOSITION_DEPTH_MODE mode);

            [VtblIndex(27)]
            HRESULT SetOffsetZ(IDCompositionAnimation* animation);

            [VtblIndex(28)]
            HRESULT SetOffsetZ(float offsetZ);

            [VtblIndex(29)]
            HRESULT SetOpacity(IDCompositionAnimation* animation);

            [VtblIndex(30)]
            HRESULT SetOpacity(float opacity);

            [VtblIndex(31)]
            HRESULT SetTransform(IDCompositionTransform3D* transform);

            [VtblIndex(32)]
            HRESULT SetTransform([NativeTypeName("const D2D_MATRIX_4X4_F &")] D2D_MATRIX_4X4_F* matrix);

            [VtblIndex(33)]
            HRESULT SetVisible(BOOL visible);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, uint> Release;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, IDCompositionAnimation*, int> SetOffsetX;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, float, int> SetOffsetX1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, IDCompositionAnimation*, int> SetOffsetY;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, float, int> SetOffsetY1;

            [NativeTypeName("HRESULT (IDCompositionTransform *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, IDCompositionTransform*, int> SetTransform;

            [NativeTypeName("HRESULT (const D2D_MATRIX_3X2_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, D2D_MATRIX_3X2_F*, int> SetTransform1;

            [NativeTypeName("HRESULT (IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, IDCompositionVisual*, int> SetTransformParent;

            [NativeTypeName("HRESULT (IDCompositionEffect *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, IDCompositionEffect*, int> SetEffect;

            [NativeTypeName("HRESULT (DCOMPOSITION_BITMAP_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_BITMAP_INTERPOLATION_MODE, int> SetBitmapInterpolationMode;

            [NativeTypeName("HRESULT (DCOMPOSITION_BORDER_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_BORDER_MODE, int> SetBorderMode;

            [NativeTypeName("HRESULT (IDCompositionClip *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, IDCompositionClip*, int> SetClip;

            [NativeTypeName("HRESULT (const D2D_RECT_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, D2D_RECT_F*, int> SetClip1;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, IUnknown*, int> SetContent;

            [NativeTypeName("HRESULT (IDCompositionVisual *, BOOL, IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, IDCompositionVisual*, BOOL, IDCompositionVisual*, int> AddVisual;

            [NativeTypeName("HRESULT (IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, IDCompositionVisual*, int> RemoveVisual;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, int> RemoveAllVisuals;

            [NativeTypeName("HRESULT (DCOMPOSITION_COMPOSITE_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_COMPOSITE_MODE, int> SetCompositeMode;

            [NativeTypeName("HRESULT (DCOMPOSITION_OPACITY_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_OPACITY_MODE, int> SetOpacityMode;

            [NativeTypeName("HRESULT (DCOMPOSITION_BACKFACE_VISIBILITY) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_BACKFACE_VISIBILITY, int> SetBackFaceVisibility;

            [NativeTypeName("HRESULT (const D2D1_COLOR_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, DXGI_RGBA*, int> EnableHeatMap;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, int> DisableHeatMap;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, int> EnableRedrawRegions;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, int> DisableRedrawRegions;

            [NativeTypeName("HRESULT (DCOMPOSITION_DEPTH_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_DEPTH_MODE, int> SetDepthMode;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, IDCompositionAnimation*, int> SetOffsetZ;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, float, int> SetOffsetZ1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, IDCompositionAnimation*, int> SetOpacity;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, float, int> SetOpacity1;

            [NativeTypeName("HRESULT (IDCompositionTransform3D *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, IDCompositionTransform3D*, int> SetTransform2;

            [NativeTypeName("HRESULT (const D2D_MATRIX_4X4_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, D2D_MATRIX_4X4_F*, int> SetTransform3;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionVisual3*, BOOL, int> SetVisible;
        }
    }
}
