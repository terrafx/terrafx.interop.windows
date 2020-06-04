// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("75F6468D-1B8E-447C-9BC6-75FEA80B5B25")]
    public unsafe partial struct IDCompositionDevice2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionDevice2*, uint>)(lpVtbl[1]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionDevice2*, uint>)(lpVtbl[2]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* stdcall<IDCompositionDevice2*, int>)(lpVtbl[3]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForCommitCompletion()
        {
            return ((delegate* stdcall<IDCompositionDevice2*, int>)(lpVtbl[4]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics([NativeTypeName("DCOMPOSITION_FRAME_STATISTICS *")] DCOMPOSITION_FRAME_STATISTICS* statistics)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, DCOMPOSITION_FRAME_STATISTICS*, int>)(lpVtbl[5]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), statistics);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVisual([NativeTypeName("IDCompositionVisual2 **")] IDCompositionVisual2** visual)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IDCompositionVisual2**, int>)(lpVtbl[6]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), visual);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFactory([NativeTypeName("IUnknown *")] IUnknown* renderingDevice, [NativeTypeName("IDCompositionSurfaceFactory **")] IDCompositionSurfaceFactory** surfaceFactory)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IUnknown*, IDCompositionSurfaceFactory**, int>)(lpVtbl[7]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), renderingDevice, surfaceFactory);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionSurface **")] IDCompositionSurface** surface)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface**, int>)(lpVtbl[8]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVirtualSurface([NativeTypeName("UINT")] uint initialWidth, [NativeTypeName("UINT")] uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionVirtualSurface **")] IDCompositionVirtualSurface** virtualSurface)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface**, int>)(lpVtbl[9]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform([NativeTypeName("IDCompositionTranslateTransform **")] IDCompositionTranslateTransform** translateTransform)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IDCompositionTranslateTransform**, int>)(lpVtbl[10]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), translateTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform([NativeTypeName("IDCompositionScaleTransform **")] IDCompositionScaleTransform** scaleTransform)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IDCompositionScaleTransform**, int>)(lpVtbl[11]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), scaleTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform([NativeTypeName("IDCompositionRotateTransform **")] IDCompositionRotateTransform** rotateTransform)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IDCompositionRotateTransform**, int>)(lpVtbl[12]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), rotateTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSkewTransform([NativeTypeName("IDCompositionSkewTransform **")] IDCompositionSkewTransform** skewTransform)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IDCompositionSkewTransform**, int>)(lpVtbl[13]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), skewTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform([NativeTypeName("IDCompositionMatrixTransform **")] IDCompositionMatrixTransform** matrixTransform)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IDCompositionMatrixTransform**, int>)(lpVtbl[14]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), matrixTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformGroup([NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transforms, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transformGroup)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)(lpVtbl[15]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform3D([NativeTypeName("IDCompositionTranslateTransform3D **")] IDCompositionTranslateTransform3D** translateTransform3D)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IDCompositionTranslateTransform3D**, int>)(lpVtbl[16]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), translateTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform3D([NativeTypeName("IDCompositionScaleTransform3D **")] IDCompositionScaleTransform3D** scaleTransform3D)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IDCompositionScaleTransform3D**, int>)(lpVtbl[17]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), scaleTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform3D([NativeTypeName("IDCompositionRotateTransform3D **")] IDCompositionRotateTransform3D** rotateTransform3D)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IDCompositionRotateTransform3D**, int>)(lpVtbl[18]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), rotateTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform3D([NativeTypeName("IDCompositionMatrixTransform3D **")] IDCompositionMatrixTransform3D** matrixTransform3D)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IDCompositionMatrixTransform3D**, int>)(lpVtbl[19]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), matrixTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransform3DGroup([NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transforms3D, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transform3DGroup)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)(lpVtbl[20]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEffectGroup([NativeTypeName("IDCompositionEffectGroup **")] IDCompositionEffectGroup** effectGroup)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IDCompositionEffectGroup**, int>)(lpVtbl[21]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), effectGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRectangleClip([NativeTypeName("IDCompositionRectangleClip **")] IDCompositionRectangleClip** clip)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IDCompositionRectangleClip**, int>)(lpVtbl[22]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), clip);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateAnimation([NativeTypeName("IDCompositionAnimation **")] IDCompositionAnimation** animation)
        {
            return ((delegate* stdcall<IDCompositionDevice2*, IDCompositionAnimation**, int>)(lpVtbl[23]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
