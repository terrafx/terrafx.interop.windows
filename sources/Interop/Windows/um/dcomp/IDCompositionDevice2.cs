// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("75F6468D-1B8E-447C-9BC6-75FEA80B5B25")]
    [NativeTypeName("struct IDCompositionDevice2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDCompositionDevice2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, uint>)(lpVtbl[1]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, uint>)(lpVtbl[2]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, int>)(lpVtbl[3]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForCommitCompletion()
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, int>)(lpVtbl[4]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics(DCOMPOSITION_FRAME_STATISTICS* statistics)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, DCOMPOSITION_FRAME_STATISTICS*, int>)(lpVtbl[5]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), statistics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVisual(IDCompositionVisual2** visual)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionVisual2**, int>)(lpVtbl[6]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), visual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFactory(IUnknown* renderingDevice, IDCompositionSurfaceFactory** surfaceFactory)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IUnknown*, IDCompositionSurfaceFactory**, int>)(lpVtbl[7]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), renderingDevice, surfaceFactory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, IDCompositionSurface** surface)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface**, int>)(lpVtbl[8]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVirtualSurface([NativeTypeName("UINT")] uint initialWidth, [NativeTypeName("UINT")] uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, IDCompositionVirtualSurface** virtualSurface)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface**, int>)(lpVtbl[9]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform(IDCompositionTranslateTransform** translateTransform)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionTranslateTransform**, int>)(lpVtbl[10]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), translateTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform(IDCompositionScaleTransform** scaleTransform)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionScaleTransform**, int>)(lpVtbl[11]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), scaleTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform(IDCompositionRotateTransform** rotateTransform)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionRotateTransform**, int>)(lpVtbl[12]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), rotateTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSkewTransform(IDCompositionSkewTransform** skewTransform)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionSkewTransform**, int>)(lpVtbl[13]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), skewTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform(IDCompositionMatrixTransform** matrixTransform)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionMatrixTransform**, int>)(lpVtbl[14]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), matrixTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTransformGroup(IDCompositionTransform** transforms, [NativeTypeName("UINT")] uint elements, IDCompositionTransform** transformGroup)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)(lpVtbl[15]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform3D(IDCompositionTranslateTransform3D** translateTransform3D)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionTranslateTransform3D**, int>)(lpVtbl[16]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), translateTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform3D(IDCompositionScaleTransform3D** scaleTransform3D)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionScaleTransform3D**, int>)(lpVtbl[17]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), scaleTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform3D(IDCompositionRotateTransform3D** rotateTransform3D)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionRotateTransform3D**, int>)(lpVtbl[18]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), rotateTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform3D(IDCompositionMatrixTransform3D** matrixTransform3D)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionMatrixTransform3D**, int>)(lpVtbl[19]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), matrixTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, [NativeTypeName("UINT")] uint elements, IDCompositionTransform3D** transform3DGroup)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)(lpVtbl[20]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEffectGroup(IDCompositionEffectGroup** effectGroup)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionEffectGroup**, int>)(lpVtbl[21]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), effectGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRectangleClip(IDCompositionRectangleClip** clip)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionRectangleClip**, int>)(lpVtbl[22]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), clip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAnimation(IDCompositionAnimation** animation)
        {
            return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionAnimation**, int>)(lpVtbl[23]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
