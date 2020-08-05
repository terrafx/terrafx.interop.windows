// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5F4633FE-1E08-4CB8-8C75-CE24333F5602")]
    [NativeTypeName("struct IDCompositionDesktopDevice : IDCompositionDevice2")]
    public unsafe partial struct IDCompositionDesktopDevice
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, uint>)(lpVtbl[1]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, uint>)(lpVtbl[2]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, int>)(lpVtbl[3]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForCommitCompletion()
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, int>)(lpVtbl[4]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics([NativeTypeName("DCOMPOSITION_FRAME_STATISTICS *")] DCOMPOSITION_FRAME_STATISTICS* statistics)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, DCOMPOSITION_FRAME_STATISTICS*, int>)(lpVtbl[5]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), statistics);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVisual([NativeTypeName("IDCompositionVisual2 **")] IDCompositionVisual2** visual)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IDCompositionVisual2**, int>)(lpVtbl[6]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), visual);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFactory([NativeTypeName("IUnknown *")] IUnknown* renderingDevice, [NativeTypeName("IDCompositionSurfaceFactory **")] IDCompositionSurfaceFactory** surfaceFactory)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IUnknown*, IDCompositionSurfaceFactory**, int>)(lpVtbl[7]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), renderingDevice, surfaceFactory);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionSurface **")] IDCompositionSurface** surface)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface**, int>)(lpVtbl[8]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVirtualSurface([NativeTypeName("UINT")] uint initialWidth, [NativeTypeName("UINT")] uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionVirtualSurface **")] IDCompositionVirtualSurface** virtualSurface)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface**, int>)(lpVtbl[9]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform([NativeTypeName("IDCompositionTranslateTransform **")] IDCompositionTranslateTransform** translateTransform)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IDCompositionTranslateTransform**, int>)(lpVtbl[10]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), translateTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform([NativeTypeName("IDCompositionScaleTransform **")] IDCompositionScaleTransform** scaleTransform)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IDCompositionScaleTransform**, int>)(lpVtbl[11]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), scaleTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform([NativeTypeName("IDCompositionRotateTransform **")] IDCompositionRotateTransform** rotateTransform)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IDCompositionRotateTransform**, int>)(lpVtbl[12]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), rotateTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSkewTransform([NativeTypeName("IDCompositionSkewTransform **")] IDCompositionSkewTransform** skewTransform)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IDCompositionSkewTransform**, int>)(lpVtbl[13]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), skewTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform([NativeTypeName("IDCompositionMatrixTransform **")] IDCompositionMatrixTransform** matrixTransform)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IDCompositionMatrixTransform**, int>)(lpVtbl[14]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), matrixTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformGroup([NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transforms, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transformGroup)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)(lpVtbl[15]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform3D([NativeTypeName("IDCompositionTranslateTransform3D **")] IDCompositionTranslateTransform3D** translateTransform3D)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IDCompositionTranslateTransform3D**, int>)(lpVtbl[16]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), translateTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform3D([NativeTypeName("IDCompositionScaleTransform3D **")] IDCompositionScaleTransform3D** scaleTransform3D)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IDCompositionScaleTransform3D**, int>)(lpVtbl[17]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), scaleTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform3D([NativeTypeName("IDCompositionRotateTransform3D **")] IDCompositionRotateTransform3D** rotateTransform3D)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IDCompositionRotateTransform3D**, int>)(lpVtbl[18]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), rotateTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform3D([NativeTypeName("IDCompositionMatrixTransform3D **")] IDCompositionMatrixTransform3D** matrixTransform3D)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IDCompositionMatrixTransform3D**, int>)(lpVtbl[19]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), matrixTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransform3DGroup([NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transforms3D, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transform3DGroup)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)(lpVtbl[20]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEffectGroup([NativeTypeName("IDCompositionEffectGroup **")] IDCompositionEffectGroup** effectGroup)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IDCompositionEffectGroup**, int>)(lpVtbl[21]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), effectGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRectangleClip([NativeTypeName("IDCompositionRectangleClip **")] IDCompositionRectangleClip** clip)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IDCompositionRectangleClip**, int>)(lpVtbl[22]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), clip);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateAnimation([NativeTypeName("IDCompositionAnimation **")] IDCompositionAnimation** animation)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IDCompositionAnimation**, int>)(lpVtbl[23]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTargetForHwnd([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("BOOL")] int topmost, [NativeTypeName("IDCompositionTarget **")] IDCompositionTarget** target)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IntPtr, int, IDCompositionTarget**, int>)(lpVtbl[24]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), hwnd, topmost, target);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFromHandle([NativeTypeName("HANDLE")] IntPtr handle, [NativeTypeName("IUnknown **")] IUnknown** surface)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IntPtr, IUnknown**, int>)(lpVtbl[25]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), handle, surface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFromHwnd([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("IUnknown **")] IUnknown** surface)
        {
            return ((delegate* stdcall<IDCompositionDesktopDevice*, IntPtr, IUnknown**, int>)(lpVtbl[26]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), hwnd, surface);
        }
    }
}
