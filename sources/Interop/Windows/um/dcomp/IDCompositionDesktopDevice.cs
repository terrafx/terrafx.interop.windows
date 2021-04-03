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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, uint>)(lpVtbl[1]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, uint>)(lpVtbl[2]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, int>)(lpVtbl[3]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForCommitCompletion()
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, int>)(lpVtbl[4]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics(DCOMPOSITION_FRAME_STATISTICS* statistics)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, DCOMPOSITION_FRAME_STATISTICS*, int>)(lpVtbl[5]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), statistics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVisual(IDCompositionVisual2** visual)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IDCompositionVisual2**, int>)(lpVtbl[6]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), visual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFactory(IUnknown* renderingDevice, IDCompositionSurfaceFactory** surfaceFactory)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IUnknown*, IDCompositionSurfaceFactory**, int>)(lpVtbl[7]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), renderingDevice, surfaceFactory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, IDCompositionSurface** surface)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface**, int>)(lpVtbl[8]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVirtualSurface([NativeTypeName("UINT")] uint initialWidth, [NativeTypeName("UINT")] uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, IDCompositionVirtualSurface** virtualSurface)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface**, int>)(lpVtbl[9]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform(IDCompositionTranslateTransform** translateTransform)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IDCompositionTranslateTransform**, int>)(lpVtbl[10]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), translateTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform(IDCompositionScaleTransform** scaleTransform)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IDCompositionScaleTransform**, int>)(lpVtbl[11]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), scaleTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform(IDCompositionRotateTransform** rotateTransform)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IDCompositionRotateTransform**, int>)(lpVtbl[12]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), rotateTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSkewTransform(IDCompositionSkewTransform** skewTransform)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IDCompositionSkewTransform**, int>)(lpVtbl[13]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), skewTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform(IDCompositionMatrixTransform** matrixTransform)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IDCompositionMatrixTransform**, int>)(lpVtbl[14]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), matrixTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTransformGroup(IDCompositionTransform** transforms, [NativeTypeName("UINT")] uint elements, IDCompositionTransform** transformGroup)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)(lpVtbl[15]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform3D(IDCompositionTranslateTransform3D** translateTransform3D)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IDCompositionTranslateTransform3D**, int>)(lpVtbl[16]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), translateTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform3D(IDCompositionScaleTransform3D** scaleTransform3D)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IDCompositionScaleTransform3D**, int>)(lpVtbl[17]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), scaleTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform3D(IDCompositionRotateTransform3D** rotateTransform3D)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IDCompositionRotateTransform3D**, int>)(lpVtbl[18]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), rotateTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform3D(IDCompositionMatrixTransform3D** matrixTransform3D)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IDCompositionMatrixTransform3D**, int>)(lpVtbl[19]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), matrixTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, [NativeTypeName("UINT")] uint elements, IDCompositionTransform3D** transform3DGroup)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)(lpVtbl[20]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEffectGroup(IDCompositionEffectGroup** effectGroup)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IDCompositionEffectGroup**, int>)(lpVtbl[21]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), effectGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRectangleClip(IDCompositionRectangleClip** clip)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IDCompositionRectangleClip**, int>)(lpVtbl[22]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), clip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAnimation(IDCompositionAnimation** animation)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IDCompositionAnimation**, int>)(lpVtbl[23]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTargetForHwnd([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("BOOL")] int topmost, IDCompositionTarget** target)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IntPtr, int, IDCompositionTarget**, int>)(lpVtbl[24]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), hwnd, topmost, target);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFromHandle([NativeTypeName("HANDLE")] IntPtr handle, IUnknown** surface)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IntPtr, IUnknown**, int>)(lpVtbl[25]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), handle, surface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFromHwnd([NativeTypeName("HWND")] IntPtr hwnd, IUnknown** surface)
        {
            return ((delegate* unmanaged<IDCompositionDesktopDevice*, IntPtr, IUnknown**, int>)(lpVtbl[26]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), hwnd, surface);
        }
    }
}
