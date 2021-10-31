// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2775F462-B6C1-4015-B0BE-B3E7D6A4976D")]
    [NativeTypeName("struct IDCompositionVisual3 : IDCompositionVisualDebug")]
    [NativeInheritance("IDCompositionVisualDebug")]
    public unsafe partial struct IDCompositionVisual3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX(float offsetX)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, float, int>)(lpVtbl[4]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY(float offsetY)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, float, int>)(lpVtbl[6]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, D2D_MATRIX_3X2_F*, int>)(lpVtbl[8]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransform(IDCompositionTransform* transform)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionTransform*, int>)(lpVtbl[7]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransformParent(IDCompositionVisual* visual)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionVisual*, int>)(lpVtbl[9]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetEffect(IDCompositionEffect* effect)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionEffect*, int>)(lpVtbl[10]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), effect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int SetBitmapInterpolationMode(DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_BITMAP_INTERPOLATION_MODE, int>)(lpVtbl[11]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int SetBorderMode(DCOMPOSITION_BORDER_MODE borderMode)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_BORDER_MODE, int>)(lpVtbl[12]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), borderMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetClip([NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* rect)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, D2D_RECT_F*, int>)(lpVtbl[14]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), rect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int SetClip(IDCompositionClip* clip)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionClip*, int>)(lpVtbl[13]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), clip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int SetContent(IUnknown* content)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IUnknown*, int>)(lpVtbl[15]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), content);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int AddVisual(IDCompositionVisual* visual, BOOL insertAbove, IDCompositionVisual* referenceVisual)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionVisual*, BOOL, IDCompositionVisual*, int>)(lpVtbl[16]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual, insertAbove, referenceVisual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveVisual(IDCompositionVisual* visual)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionVisual*, int>)(lpVtbl[17]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllVisuals()
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, int>)(lpVtbl[18]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE compositeMode)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_COMPOSITE_MODE, int>)(lpVtbl[19]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), compositeMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int SetOpacityMode(DCOMPOSITION_OPACITY_MODE mode)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_OPACITY_MODE, int>)(lpVtbl[20]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int SetBackFaceVisibility(DCOMPOSITION_BACKFACE_VISIBILITY visibility)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_BACKFACE_VISIBILITY, int>)(lpVtbl[21]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visibility);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int EnableHeatMap([NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, DXGI_RGBA*, int>)(lpVtbl[22]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int DisableHeatMap()
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, int>)(lpVtbl[23]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int EnableRedrawRegions()
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, int>)(lpVtbl[24]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int DisableRedrawRegions()
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, int>)(lpVtbl[25]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int SetDepthMode(DCOMPOSITION_DEPTH_MODE mode)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, DCOMPOSITION_DEPTH_MODE, int>)(lpVtbl[26]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetZ(float offsetZ)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, float, int>)(lpVtbl[28]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetZ(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[27]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int SetOpacity(float opacity)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, float, int>)(lpVtbl[30]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), opacity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int SetOpacity(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[29]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("const D2D_MATRIX_4X4_F &")] D2D_MATRIX_4X4_F* matrix)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, D2D_MATRIX_4X4_F*, int>)(lpVtbl[32]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransform(IDCompositionTransform3D* transform)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, IDCompositionTransform3D*, int>)(lpVtbl[31]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int SetVisible(BOOL visible)
        {
            return ((delegate* unmanaged<IDCompositionVisual3*, BOOL, int>)(lpVtbl[33]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visible);
        }
    }
}
