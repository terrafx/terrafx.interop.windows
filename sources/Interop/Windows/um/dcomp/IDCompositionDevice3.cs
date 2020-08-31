// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0987CB06-F916-48BF-8D35-CE7641781BD9")]
    [NativeTypeName("struct IDCompositionDevice3 : IDCompositionDevice2")]
    public unsafe partial struct IDCompositionDevice3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionDevice3*, uint>)(lpVtbl[1]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionDevice3*, uint>)(lpVtbl[2]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* stdcall<IDCompositionDevice3*, int>)(lpVtbl[3]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForCommitCompletion()
        {
            return ((delegate* stdcall<IDCompositionDevice3*, int>)(lpVtbl[4]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics([NativeTypeName("DCOMPOSITION_FRAME_STATISTICS *")] DCOMPOSITION_FRAME_STATISTICS* statistics)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, DCOMPOSITION_FRAME_STATISTICS*, int>)(lpVtbl[5]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), statistics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVisual([NativeTypeName("IDCompositionVisual2 **")] IDCompositionVisual2** visual)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionVisual2**, int>)(lpVtbl[6]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), visual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFactory([NativeTypeName("IUnknown *")] IUnknown* renderingDevice, [NativeTypeName("IDCompositionSurfaceFactory **")] IDCompositionSurfaceFactory** surfaceFactory)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IUnknown*, IDCompositionSurfaceFactory**, int>)(lpVtbl[7]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), renderingDevice, surfaceFactory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionSurface **")] IDCompositionSurface** surface)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface**, int>)(lpVtbl[8]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVirtualSurface([NativeTypeName("UINT")] uint initialWidth, [NativeTypeName("UINT")] uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionVirtualSurface **")] IDCompositionVirtualSurface** virtualSurface)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface**, int>)(lpVtbl[9]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform([NativeTypeName("IDCompositionTranslateTransform **")] IDCompositionTranslateTransform** translateTransform)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionTranslateTransform**, int>)(lpVtbl[10]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), translateTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform([NativeTypeName("IDCompositionScaleTransform **")] IDCompositionScaleTransform** scaleTransform)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionScaleTransform**, int>)(lpVtbl[11]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), scaleTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform([NativeTypeName("IDCompositionRotateTransform **")] IDCompositionRotateTransform** rotateTransform)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionRotateTransform**, int>)(lpVtbl[12]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), rotateTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSkewTransform([NativeTypeName("IDCompositionSkewTransform **")] IDCompositionSkewTransform** skewTransform)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionSkewTransform**, int>)(lpVtbl[13]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), skewTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform([NativeTypeName("IDCompositionMatrixTransform **")] IDCompositionMatrixTransform** matrixTransform)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionMatrixTransform**, int>)(lpVtbl[14]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), matrixTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTransformGroup([NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transforms, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transformGroup)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)(lpVtbl[15]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform3D([NativeTypeName("IDCompositionTranslateTransform3D **")] IDCompositionTranslateTransform3D** translateTransform3D)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionTranslateTransform3D**, int>)(lpVtbl[16]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), translateTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform3D([NativeTypeName("IDCompositionScaleTransform3D **")] IDCompositionScaleTransform3D** scaleTransform3D)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionScaleTransform3D**, int>)(lpVtbl[17]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), scaleTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform3D([NativeTypeName("IDCompositionRotateTransform3D **")] IDCompositionRotateTransform3D** rotateTransform3D)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionRotateTransform3D**, int>)(lpVtbl[18]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), rotateTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform3D([NativeTypeName("IDCompositionMatrixTransform3D **")] IDCompositionMatrixTransform3D** matrixTransform3D)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionMatrixTransform3D**, int>)(lpVtbl[19]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), matrixTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTransform3DGroup([NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transforms3D, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transform3DGroup)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)(lpVtbl[20]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEffectGroup([NativeTypeName("IDCompositionEffectGroup **")] IDCompositionEffectGroup** effectGroup)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionEffectGroup**, int>)(lpVtbl[21]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), effectGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRectangleClip([NativeTypeName("IDCompositionRectangleClip **")] IDCompositionRectangleClip** clip)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionRectangleClip**, int>)(lpVtbl[22]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), clip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAnimation([NativeTypeName("IDCompositionAnimation **")] IDCompositionAnimation** animation)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionAnimation**, int>)(lpVtbl[23]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGaussianBlurEffect([NativeTypeName("IDCompositionGaussianBlurEffect **")] IDCompositionGaussianBlurEffect** gaussianBlurEffect)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionGaussianBlurEffect**, int>)(lpVtbl[24]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), gaussianBlurEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBrightnessEffect([NativeTypeName("IDCompositionBrightnessEffect **")] IDCompositionBrightnessEffect** brightnessEffect)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionBrightnessEffect**, int>)(lpVtbl[25]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), brightnessEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorMatrixEffect([NativeTypeName("IDCompositionColorMatrixEffect **")] IDCompositionColorMatrixEffect** colorMatrixEffect)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionColorMatrixEffect**, int>)(lpVtbl[26]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), colorMatrixEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateShadowEffect([NativeTypeName("IDCompositionShadowEffect **")] IDCompositionShadowEffect** shadowEffect)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionShadowEffect**, int>)(lpVtbl[27]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), shadowEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateHueRotationEffect([NativeTypeName("IDCompositionHueRotationEffect **")] IDCompositionHueRotationEffect** hueRotationEffect)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionHueRotationEffect**, int>)(lpVtbl[28]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), hueRotationEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSaturationEffect([NativeTypeName("IDCompositionSaturationEffect **")] IDCompositionSaturationEffect** saturationEffect)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionSaturationEffect**, int>)(lpVtbl[29]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), saturationEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTurbulenceEffect([NativeTypeName("IDCompositionTurbulenceEffect **")] IDCompositionTurbulenceEffect** turbulenceEffect)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionTurbulenceEffect**, int>)(lpVtbl[30]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), turbulenceEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateLinearTransferEffect([NativeTypeName("IDCompositionLinearTransferEffect **")] IDCompositionLinearTransferEffect** linearTransferEffect)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionLinearTransferEffect**, int>)(lpVtbl[31]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), linearTransferEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTableTransferEffect([NativeTypeName("IDCompositionTableTransferEffect **")] IDCompositionTableTransferEffect** tableTransferEffect)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionTableTransferEffect**, int>)(lpVtbl[32]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), tableTransferEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCompositeEffect([NativeTypeName("IDCompositionCompositeEffect **")] IDCompositionCompositeEffect** compositeEffect)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionCompositeEffect**, int>)(lpVtbl[33]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), compositeEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBlendEffect([NativeTypeName("IDCompositionBlendEffect **")] IDCompositionBlendEffect** blendEffect)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionBlendEffect**, int>)(lpVtbl[34]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), blendEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateArithmeticCompositeEffect([NativeTypeName("IDCompositionArithmeticCompositeEffect **")] IDCompositionArithmeticCompositeEffect** arithmeticCompositeEffect)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionArithmeticCompositeEffect**, int>)(lpVtbl[35]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), arithmeticCompositeEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAffineTransform2DEffect([NativeTypeName("IDCompositionAffineTransform2DEffect **")] IDCompositionAffineTransform2DEffect** affineTransform2dEffect)
        {
            return ((delegate* stdcall<IDCompositionDevice3*, IDCompositionAffineTransform2DEffect**, int>)(lpVtbl[36]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), affineTransform2dEffect);
        }
    }
}
