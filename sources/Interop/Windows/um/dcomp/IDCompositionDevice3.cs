// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0987CB06-F916-48BF-8D35-CE7641781BD9")]
    [NativeTypeName("struct IDCompositionDevice3 : IDCompositionDevice2")]
    [NativeInheritance("IDCompositionDevice2")]
    public unsafe partial struct IDCompositionDevice3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, uint>)(lpVtbl[1]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, uint>)(lpVtbl[2]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Commit()
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, int>)(lpVtbl[3]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT WaitForCommitCompletion()
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, int>)(lpVtbl[4]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetFrameStatistics(DCOMPOSITION_FRAME_STATISTICS* statistics)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, DCOMPOSITION_FRAME_STATISTICS*, int>)(lpVtbl[5]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), statistics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateVisual(IDCompositionVisual2** visual)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionVisual2**, int>)(lpVtbl[6]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), visual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CreateSurfaceFactory(IUnknown* renderingDevice, IDCompositionSurfaceFactory** surfaceFactory)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IUnknown*, IDCompositionSurfaceFactory**, int>)(lpVtbl[7]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), renderingDevice, surfaceFactory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT CreateSurface(uint width, uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, IDCompositionSurface** surface)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface**, int>)(lpVtbl[8]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT CreateVirtualSurface(uint initialWidth, uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, IDCompositionVirtualSurface** virtualSurface)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface**, int>)(lpVtbl[9]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT CreateTranslateTransform(IDCompositionTranslateTransform** translateTransform)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTranslateTransform**, int>)(lpVtbl[10]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), translateTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT CreateScaleTransform(IDCompositionScaleTransform** scaleTransform)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionScaleTransform**, int>)(lpVtbl[11]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), scaleTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT CreateRotateTransform(IDCompositionRotateTransform** rotateTransform)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionRotateTransform**, int>)(lpVtbl[12]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), rotateTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT CreateSkewTransform(IDCompositionSkewTransform** skewTransform)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionSkewTransform**, int>)(lpVtbl[13]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), skewTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT CreateMatrixTransform(IDCompositionMatrixTransform** matrixTransform)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionMatrixTransform**, int>)(lpVtbl[14]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), matrixTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT CreateTransformGroup(IDCompositionTransform** transforms, uint elements, IDCompositionTransform** transformGroup)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)(lpVtbl[15]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT CreateTranslateTransform3D(IDCompositionTranslateTransform3D** translateTransform3D)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTranslateTransform3D**, int>)(lpVtbl[16]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), translateTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT CreateScaleTransform3D(IDCompositionScaleTransform3D** scaleTransform3D)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionScaleTransform3D**, int>)(lpVtbl[17]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), scaleTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT CreateRotateTransform3D(IDCompositionRotateTransform3D** rotateTransform3D)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionRotateTransform3D**, int>)(lpVtbl[18]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), rotateTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT CreateMatrixTransform3D(IDCompositionMatrixTransform3D** matrixTransform3D)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionMatrixTransform3D**, int>)(lpVtbl[19]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), matrixTransform3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)(lpVtbl[20]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT CreateEffectGroup(IDCompositionEffectGroup** effectGroup)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionEffectGroup**, int>)(lpVtbl[21]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), effectGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT CreateRectangleClip(IDCompositionRectangleClip** clip)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionRectangleClip**, int>)(lpVtbl[22]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), clip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT CreateAnimation(IDCompositionAnimation** animation)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionAnimation**, int>)(lpVtbl[23]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT CreateGaussianBlurEffect(IDCompositionGaussianBlurEffect** gaussianBlurEffect)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionGaussianBlurEffect**, int>)(lpVtbl[24]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), gaussianBlurEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT CreateBrightnessEffect(IDCompositionBrightnessEffect** brightnessEffect)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionBrightnessEffect**, int>)(lpVtbl[25]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), brightnessEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT CreateColorMatrixEffect(IDCompositionColorMatrixEffect** colorMatrixEffect)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionColorMatrixEffect**, int>)(lpVtbl[26]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), colorMatrixEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT CreateShadowEffect(IDCompositionShadowEffect** shadowEffect)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionShadowEffect**, int>)(lpVtbl[27]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), shadowEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT CreateHueRotationEffect(IDCompositionHueRotationEffect** hueRotationEffect)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionHueRotationEffect**, int>)(lpVtbl[28]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), hueRotationEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT CreateSaturationEffect(IDCompositionSaturationEffect** saturationEffect)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionSaturationEffect**, int>)(lpVtbl[29]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), saturationEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT CreateTurbulenceEffect(IDCompositionTurbulenceEffect** turbulenceEffect)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTurbulenceEffect**, int>)(lpVtbl[30]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), turbulenceEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT CreateLinearTransferEffect(IDCompositionLinearTransferEffect** linearTransferEffect)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionLinearTransferEffect**, int>)(lpVtbl[31]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), linearTransferEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT CreateTableTransferEffect(IDCompositionTableTransferEffect** tableTransferEffect)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTableTransferEffect**, int>)(lpVtbl[32]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), tableTransferEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT CreateCompositeEffect(IDCompositionCompositeEffect** compositeEffect)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionCompositeEffect**, int>)(lpVtbl[33]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), compositeEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT CreateBlendEffect(IDCompositionBlendEffect** blendEffect)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionBlendEffect**, int>)(lpVtbl[34]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), blendEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT CreateArithmeticCompositeEffect(IDCompositionArithmeticCompositeEffect** arithmeticCompositeEffect)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionArithmeticCompositeEffect**, int>)(lpVtbl[35]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), arithmeticCompositeEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT CreateAffineTransform2DEffect(IDCompositionAffineTransform2DEffect** affineTransform2dEffect)
        {
            return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionAffineTransform2DEffect**, int>)(lpVtbl[36]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), affineTransform2dEffect);
        }
    }
}
