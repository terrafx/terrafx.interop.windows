// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0987CB06-F916-48BF-8D35-CE7641781BD9")]
    public unsafe partial struct IDCompositionDevice3
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDCompositionDevice3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return lpVtbl->Commit((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForCommitCompletion()
        {
            return lpVtbl->WaitForCommitCompletion((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics([NativeTypeName("DCOMPOSITION_FRAME_STATISTICS *")] DCOMPOSITION_FRAME_STATISTICS* statistics)
        {
            return lpVtbl->GetFrameStatistics((IDCompositionDevice3*)Unsafe.AsPointer(ref this), statistics);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVisual([NativeTypeName("IDCompositionVisual2 **")] IDCompositionVisual2** visual)
        {
            return lpVtbl->CreateVisual((IDCompositionDevice3*)Unsafe.AsPointer(ref this), visual);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFactory([NativeTypeName("IUnknown *")] IUnknown* renderingDevice, [NativeTypeName("IDCompositionSurfaceFactory **")] IDCompositionSurfaceFactory** surfaceFactory)
        {
            return lpVtbl->CreateSurfaceFactory((IDCompositionDevice3*)Unsafe.AsPointer(ref this), renderingDevice, surfaceFactory);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionSurface **")] IDCompositionSurface** surface)
        {
            return lpVtbl->CreateSurface((IDCompositionDevice3*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVirtualSurface([NativeTypeName("UINT")] uint initialWidth, [NativeTypeName("UINT")] uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionVirtualSurface **")] IDCompositionVirtualSurface** virtualSurface)
        {
            return lpVtbl->CreateVirtualSurface((IDCompositionDevice3*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform([NativeTypeName("IDCompositionTranslateTransform **")] IDCompositionTranslateTransform** translateTransform)
        {
            return lpVtbl->CreateTranslateTransform((IDCompositionDevice3*)Unsafe.AsPointer(ref this), translateTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform([NativeTypeName("IDCompositionScaleTransform **")] IDCompositionScaleTransform** scaleTransform)
        {
            return lpVtbl->CreateScaleTransform((IDCompositionDevice3*)Unsafe.AsPointer(ref this), scaleTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform([NativeTypeName("IDCompositionRotateTransform **")] IDCompositionRotateTransform** rotateTransform)
        {
            return lpVtbl->CreateRotateTransform((IDCompositionDevice3*)Unsafe.AsPointer(ref this), rotateTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSkewTransform([NativeTypeName("IDCompositionSkewTransform **")] IDCompositionSkewTransform** skewTransform)
        {
            return lpVtbl->CreateSkewTransform((IDCompositionDevice3*)Unsafe.AsPointer(ref this), skewTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform([NativeTypeName("IDCompositionMatrixTransform **")] IDCompositionMatrixTransform** matrixTransform)
        {
            return lpVtbl->CreateMatrixTransform((IDCompositionDevice3*)Unsafe.AsPointer(ref this), matrixTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformGroup([NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transforms, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transformGroup)
        {
            return lpVtbl->CreateTransformGroup((IDCompositionDevice3*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform3D([NativeTypeName("IDCompositionTranslateTransform3D **")] IDCompositionTranslateTransform3D** translateTransform3D)
        {
            return lpVtbl->CreateTranslateTransform3D((IDCompositionDevice3*)Unsafe.AsPointer(ref this), translateTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform3D([NativeTypeName("IDCompositionScaleTransform3D **")] IDCompositionScaleTransform3D** scaleTransform3D)
        {
            return lpVtbl->CreateScaleTransform3D((IDCompositionDevice3*)Unsafe.AsPointer(ref this), scaleTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform3D([NativeTypeName("IDCompositionRotateTransform3D **")] IDCompositionRotateTransform3D** rotateTransform3D)
        {
            return lpVtbl->CreateRotateTransform3D((IDCompositionDevice3*)Unsafe.AsPointer(ref this), rotateTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform3D([NativeTypeName("IDCompositionMatrixTransform3D **")] IDCompositionMatrixTransform3D** matrixTransform3D)
        {
            return lpVtbl->CreateMatrixTransform3D((IDCompositionDevice3*)Unsafe.AsPointer(ref this), matrixTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransform3DGroup([NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transforms3D, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transform3DGroup)
        {
            return lpVtbl->CreateTransform3DGroup((IDCompositionDevice3*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEffectGroup([NativeTypeName("IDCompositionEffectGroup **")] IDCompositionEffectGroup** effectGroup)
        {
            return lpVtbl->CreateEffectGroup((IDCompositionDevice3*)Unsafe.AsPointer(ref this), effectGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRectangleClip([NativeTypeName("IDCompositionRectangleClip **")] IDCompositionRectangleClip** clip)
        {
            return lpVtbl->CreateRectangleClip((IDCompositionDevice3*)Unsafe.AsPointer(ref this), clip);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateAnimation([NativeTypeName("IDCompositionAnimation **")] IDCompositionAnimation** animation)
        {
            return lpVtbl->CreateAnimation((IDCompositionDevice3*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGaussianBlurEffect([NativeTypeName("IDCompositionGaussianBlurEffect **")] IDCompositionGaussianBlurEffect** gaussianBlurEffect)
        {
            return lpVtbl->CreateGaussianBlurEffect((IDCompositionDevice3*)Unsafe.AsPointer(ref this), gaussianBlurEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBrightnessEffect([NativeTypeName("IDCompositionBrightnessEffect **")] IDCompositionBrightnessEffect** brightnessEffect)
        {
            return lpVtbl->CreateBrightnessEffect((IDCompositionDevice3*)Unsafe.AsPointer(ref this), brightnessEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorMatrixEffect([NativeTypeName("IDCompositionColorMatrixEffect **")] IDCompositionColorMatrixEffect** colorMatrixEffect)
        {
            return lpVtbl->CreateColorMatrixEffect((IDCompositionDevice3*)Unsafe.AsPointer(ref this), colorMatrixEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateShadowEffect([NativeTypeName("IDCompositionShadowEffect **")] IDCompositionShadowEffect** shadowEffect)
        {
            return lpVtbl->CreateShadowEffect((IDCompositionDevice3*)Unsafe.AsPointer(ref this), shadowEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHueRotationEffect([NativeTypeName("IDCompositionHueRotationEffect **")] IDCompositionHueRotationEffect** hueRotationEffect)
        {
            return lpVtbl->CreateHueRotationEffect((IDCompositionDevice3*)Unsafe.AsPointer(ref this), hueRotationEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSaturationEffect([NativeTypeName("IDCompositionSaturationEffect **")] IDCompositionSaturationEffect** saturationEffect)
        {
            return lpVtbl->CreateSaturationEffect((IDCompositionDevice3*)Unsafe.AsPointer(ref this), saturationEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTurbulenceEffect([NativeTypeName("IDCompositionTurbulenceEffect **")] IDCompositionTurbulenceEffect** turbulenceEffect)
        {
            return lpVtbl->CreateTurbulenceEffect((IDCompositionDevice3*)Unsafe.AsPointer(ref this), turbulenceEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLinearTransferEffect([NativeTypeName("IDCompositionLinearTransferEffect **")] IDCompositionLinearTransferEffect** linearTransferEffect)
        {
            return lpVtbl->CreateLinearTransferEffect((IDCompositionDevice3*)Unsafe.AsPointer(ref this), linearTransferEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTableTransferEffect([NativeTypeName("IDCompositionTableTransferEffect **")] IDCompositionTableTransferEffect** tableTransferEffect)
        {
            return lpVtbl->CreateTableTransferEffect((IDCompositionDevice3*)Unsafe.AsPointer(ref this), tableTransferEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompositeEffect([NativeTypeName("IDCompositionCompositeEffect **")] IDCompositionCompositeEffect** compositeEffect)
        {
            return lpVtbl->CreateCompositeEffect((IDCompositionDevice3*)Unsafe.AsPointer(ref this), compositeEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlendEffect([NativeTypeName("IDCompositionBlendEffect **")] IDCompositionBlendEffect** blendEffect)
        {
            return lpVtbl->CreateBlendEffect((IDCompositionDevice3*)Unsafe.AsPointer(ref this), blendEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateArithmeticCompositeEffect([NativeTypeName("IDCompositionArithmeticCompositeEffect **")] IDCompositionArithmeticCompositeEffect** arithmeticCompositeEffect)
        {
            return lpVtbl->CreateArithmeticCompositeEffect((IDCompositionDevice3*)Unsafe.AsPointer(ref this), arithmeticCompositeEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateAffineTransform2DEffect([NativeTypeName("IDCompositionAffineTransform2DEffect **")] IDCompositionAffineTransform2DEffect** affineTransform2dEffect)
        {
            return lpVtbl->CreateAffineTransform2DEffect((IDCompositionDevice3*)Unsafe.AsPointer(ref this), affineTransform2dEffect);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, int> Commit;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, int> WaitForCommitCompletion;

            [NativeTypeName("HRESULT (DCOMPOSITION_FRAME_STATISTICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, DCOMPOSITION_FRAME_STATISTICS*, int> GetFrameStatistics;

            [NativeTypeName("HRESULT (IDCompositionVisual2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionVisual2**, int> CreateVisual;

            [NativeTypeName("HRESULT (IUnknown *, IDCompositionSurfaceFactory **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IUnknown*, IDCompositionSurfaceFactory**, int> CreateSurfaceFactory;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface**, int> CreateSurface;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface**, int> CreateVirtualSurface;

            [NativeTypeName("HRESULT (IDCompositionTranslateTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionTranslateTransform**, int> CreateTranslateTransform;

            [NativeTypeName("HRESULT (IDCompositionScaleTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionScaleTransform**, int> CreateScaleTransform;

            [NativeTypeName("HRESULT (IDCompositionRotateTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionRotateTransform**, int> CreateRotateTransform;

            [NativeTypeName("HRESULT (IDCompositionSkewTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionSkewTransform**, int> CreateSkewTransform;

            [NativeTypeName("HRESULT (IDCompositionMatrixTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionMatrixTransform**, int> CreateMatrixTransform;

            [NativeTypeName("HRESULT (IDCompositionTransform **, UINT, IDCompositionTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionTransform**, uint, IDCompositionTransform**, int> CreateTransformGroup;

            [NativeTypeName("HRESULT (IDCompositionTranslateTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionTranslateTransform3D**, int> CreateTranslateTransform3D;

            [NativeTypeName("HRESULT (IDCompositionScaleTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionScaleTransform3D**, int> CreateScaleTransform3D;

            [NativeTypeName("HRESULT (IDCompositionRotateTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionRotateTransform3D**, int> CreateRotateTransform3D;

            [NativeTypeName("HRESULT (IDCompositionMatrixTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionMatrixTransform3D**, int> CreateMatrixTransform3D;

            [NativeTypeName("HRESULT (IDCompositionTransform3D **, UINT, IDCompositionTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int> CreateTransform3DGroup;

            [NativeTypeName("HRESULT (IDCompositionEffectGroup **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionEffectGroup**, int> CreateEffectGroup;

            [NativeTypeName("HRESULT (IDCompositionRectangleClip **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionRectangleClip**, int> CreateRectangleClip;

            [NativeTypeName("HRESULT (IDCompositionAnimation **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionAnimation**, int> CreateAnimation;

            [NativeTypeName("HRESULT (IDCompositionGaussianBlurEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionGaussianBlurEffect**, int> CreateGaussianBlurEffect;

            [NativeTypeName("HRESULT (IDCompositionBrightnessEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionBrightnessEffect**, int> CreateBrightnessEffect;

            [NativeTypeName("HRESULT (IDCompositionColorMatrixEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionColorMatrixEffect**, int> CreateColorMatrixEffect;

            [NativeTypeName("HRESULT (IDCompositionShadowEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionShadowEffect**, int> CreateShadowEffect;

            [NativeTypeName("HRESULT (IDCompositionHueRotationEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionHueRotationEffect**, int> CreateHueRotationEffect;

            [NativeTypeName("HRESULT (IDCompositionSaturationEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionSaturationEffect**, int> CreateSaturationEffect;

            [NativeTypeName("HRESULT (IDCompositionTurbulenceEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionTurbulenceEffect**, int> CreateTurbulenceEffect;

            [NativeTypeName("HRESULT (IDCompositionLinearTransferEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionLinearTransferEffect**, int> CreateLinearTransferEffect;

            [NativeTypeName("HRESULT (IDCompositionTableTransferEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionTableTransferEffect**, int> CreateTableTransferEffect;

            [NativeTypeName("HRESULT (IDCompositionCompositeEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionCompositeEffect**, int> CreateCompositeEffect;

            [NativeTypeName("HRESULT (IDCompositionBlendEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionBlendEffect**, int> CreateBlendEffect;

            [NativeTypeName("HRESULT (IDCompositionArithmeticCompositeEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionArithmeticCompositeEffect**, int> CreateArithmeticCompositeEffect;

            [NativeTypeName("HRESULT (IDCompositionAffineTransform2DEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionDevice3*, IDCompositionAffineTransform2DEffect**, int> CreateAffineTransform2DEffect;
        }
    }
}
