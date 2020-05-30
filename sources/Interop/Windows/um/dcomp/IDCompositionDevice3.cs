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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionDevice3* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionDevice3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionDevice3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Commit(IDCompositionDevice3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WaitForCommitCompletion(IDCompositionDevice3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameStatistics(IDCompositionDevice3* pThis, [NativeTypeName("DCOMPOSITION_FRAME_STATISTICS *")] DCOMPOSITION_FRAME_STATISTICS* statistics);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVisual(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionVisual2 **")] IDCompositionVisual2** visual);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSurfaceFactory(IDCompositionDevice3* pThis, [NativeTypeName("IUnknown *")] IUnknown* renderingDevice, [NativeTypeName("IDCompositionSurfaceFactory **")] IDCompositionSurfaceFactory** surfaceFactory);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSurface(IDCompositionDevice3* pThis, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionSurface **")] IDCompositionSurface** surface);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVirtualSurface(IDCompositionDevice3* pThis, [NativeTypeName("UINT")] uint initialWidth, [NativeTypeName("UINT")] uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionVirtualSurface **")] IDCompositionVirtualSurface** virtualSurface);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTranslateTransform(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionTranslateTransform **")] IDCompositionTranslateTransform** translateTransform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateScaleTransform(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionScaleTransform **")] IDCompositionScaleTransform** scaleTransform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRotateTransform(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionRotateTransform **")] IDCompositionRotateTransform** rotateTransform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSkewTransform(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionSkewTransform **")] IDCompositionSkewTransform** skewTransform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMatrixTransform(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionMatrixTransform **")] IDCompositionMatrixTransform** matrixTransform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTransformGroup(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transforms, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transformGroup);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTranslateTransform3D(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionTranslateTransform3D **")] IDCompositionTranslateTransform3D** translateTransform3D);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateScaleTransform3D(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionScaleTransform3D **")] IDCompositionScaleTransform3D** scaleTransform3D);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRotateTransform3D(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionRotateTransform3D **")] IDCompositionRotateTransform3D** rotateTransform3D);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMatrixTransform3D(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionMatrixTransform3D **")] IDCompositionMatrixTransform3D** matrixTransform3D);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTransform3DGroup(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transforms3D, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transform3DGroup);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEffectGroup(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionEffectGroup **")] IDCompositionEffectGroup** effectGroup);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRectangleClip(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionRectangleClip **")] IDCompositionRectangleClip** clip);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateAnimation(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionAnimation **")] IDCompositionAnimation** animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGaussianBlurEffect(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionGaussianBlurEffect **")] IDCompositionGaussianBlurEffect** gaussianBlurEffect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBrightnessEffect(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionBrightnessEffect **")] IDCompositionBrightnessEffect** brightnessEffect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorMatrixEffect(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionColorMatrixEffect **")] IDCompositionColorMatrixEffect** colorMatrixEffect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateShadowEffect(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionShadowEffect **")] IDCompositionShadowEffect** shadowEffect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateHueRotationEffect(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionHueRotationEffect **")] IDCompositionHueRotationEffect** hueRotationEffect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSaturationEffect(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionSaturationEffect **")] IDCompositionSaturationEffect** saturationEffect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTurbulenceEffect(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionTurbulenceEffect **")] IDCompositionTurbulenceEffect** turbulenceEffect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateLinearTransferEffect(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionLinearTransferEffect **")] IDCompositionLinearTransferEffect** linearTransferEffect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTableTransferEffect(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionTableTransferEffect **")] IDCompositionTableTransferEffect** tableTransferEffect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCompositeEffect(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionCompositeEffect **")] IDCompositionCompositeEffect** compositeEffect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBlendEffect(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionBlendEffect **")] IDCompositionBlendEffect** blendEffect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateArithmeticCompositeEffect(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionArithmeticCompositeEffect **")] IDCompositionArithmeticCompositeEffect** arithmeticCompositeEffect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateAffineTransform2DEffect(IDCompositionDevice3* pThis, [NativeTypeName("IDCompositionAffineTransform2DEffect **")] IDCompositionAffineTransform2DEffect** affineTransform2dEffect);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return Marshal.GetDelegateForFunctionPointer<_Commit>(lpVtbl->Commit)((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForCommitCompletion()
        {
            return Marshal.GetDelegateForFunctionPointer<_WaitForCommitCompletion>(lpVtbl->WaitForCommitCompletion)((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics([NativeTypeName("DCOMPOSITION_FRAME_STATISTICS *")] DCOMPOSITION_FRAME_STATISTICS* statistics)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFrameStatistics>(lpVtbl->GetFrameStatistics)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), statistics);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVisual([NativeTypeName("IDCompositionVisual2 **")] IDCompositionVisual2** visual)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVisual>(lpVtbl->CreateVisual)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), visual);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFactory([NativeTypeName("IUnknown *")] IUnknown* renderingDevice, [NativeTypeName("IDCompositionSurfaceFactory **")] IDCompositionSurfaceFactory** surfaceFactory)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSurfaceFactory>(lpVtbl->CreateSurfaceFactory)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), renderingDevice, surfaceFactory);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionSurface **")] IDCompositionSurface** surface)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSurface>(lpVtbl->CreateSurface)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVirtualSurface([NativeTypeName("UINT")] uint initialWidth, [NativeTypeName("UINT")] uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionVirtualSurface **")] IDCompositionVirtualSurface** virtualSurface)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVirtualSurface>(lpVtbl->CreateVirtualSurface)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform([NativeTypeName("IDCompositionTranslateTransform **")] IDCompositionTranslateTransform** translateTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTranslateTransform>(lpVtbl->CreateTranslateTransform)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), translateTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform([NativeTypeName("IDCompositionScaleTransform **")] IDCompositionScaleTransform** scaleTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateScaleTransform>(lpVtbl->CreateScaleTransform)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), scaleTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform([NativeTypeName("IDCompositionRotateTransform **")] IDCompositionRotateTransform** rotateTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRotateTransform>(lpVtbl->CreateRotateTransform)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), rotateTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSkewTransform([NativeTypeName("IDCompositionSkewTransform **")] IDCompositionSkewTransform** skewTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSkewTransform>(lpVtbl->CreateSkewTransform)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), skewTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform([NativeTypeName("IDCompositionMatrixTransform **")] IDCompositionMatrixTransform** matrixTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateMatrixTransform>(lpVtbl->CreateMatrixTransform)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), matrixTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformGroup([NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transforms, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transformGroup)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTransformGroup>(lpVtbl->CreateTransformGroup)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform3D([NativeTypeName("IDCompositionTranslateTransform3D **")] IDCompositionTranslateTransform3D** translateTransform3D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTranslateTransform3D>(lpVtbl->CreateTranslateTransform3D)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), translateTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform3D([NativeTypeName("IDCompositionScaleTransform3D **")] IDCompositionScaleTransform3D** scaleTransform3D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateScaleTransform3D>(lpVtbl->CreateScaleTransform3D)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), scaleTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform3D([NativeTypeName("IDCompositionRotateTransform3D **")] IDCompositionRotateTransform3D** rotateTransform3D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRotateTransform3D>(lpVtbl->CreateRotateTransform3D)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), rotateTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform3D([NativeTypeName("IDCompositionMatrixTransform3D **")] IDCompositionMatrixTransform3D** matrixTransform3D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateMatrixTransform3D>(lpVtbl->CreateMatrixTransform3D)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), matrixTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransform3DGroup([NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transforms3D, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transform3DGroup)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTransform3DGroup>(lpVtbl->CreateTransform3DGroup)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEffectGroup([NativeTypeName("IDCompositionEffectGroup **")] IDCompositionEffectGroup** effectGroup)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateEffectGroup>(lpVtbl->CreateEffectGroup)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), effectGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRectangleClip([NativeTypeName("IDCompositionRectangleClip **")] IDCompositionRectangleClip** clip)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRectangleClip>(lpVtbl->CreateRectangleClip)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), clip);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateAnimation([NativeTypeName("IDCompositionAnimation **")] IDCompositionAnimation** animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateAnimation>(lpVtbl->CreateAnimation)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGaussianBlurEffect([NativeTypeName("IDCompositionGaussianBlurEffect **")] IDCompositionGaussianBlurEffect** gaussianBlurEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGaussianBlurEffect>(lpVtbl->CreateGaussianBlurEffect)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), gaussianBlurEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBrightnessEffect([NativeTypeName("IDCompositionBrightnessEffect **")] IDCompositionBrightnessEffect** brightnessEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBrightnessEffect>(lpVtbl->CreateBrightnessEffect)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), brightnessEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorMatrixEffect([NativeTypeName("IDCompositionColorMatrixEffect **")] IDCompositionColorMatrixEffect** colorMatrixEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateColorMatrixEffect>(lpVtbl->CreateColorMatrixEffect)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), colorMatrixEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateShadowEffect([NativeTypeName("IDCompositionShadowEffect **")] IDCompositionShadowEffect** shadowEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateShadowEffect>(lpVtbl->CreateShadowEffect)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), shadowEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHueRotationEffect([NativeTypeName("IDCompositionHueRotationEffect **")] IDCompositionHueRotationEffect** hueRotationEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateHueRotationEffect>(lpVtbl->CreateHueRotationEffect)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), hueRotationEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSaturationEffect([NativeTypeName("IDCompositionSaturationEffect **")] IDCompositionSaturationEffect** saturationEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSaturationEffect>(lpVtbl->CreateSaturationEffect)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), saturationEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTurbulenceEffect([NativeTypeName("IDCompositionTurbulenceEffect **")] IDCompositionTurbulenceEffect** turbulenceEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTurbulenceEffect>(lpVtbl->CreateTurbulenceEffect)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), turbulenceEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLinearTransferEffect([NativeTypeName("IDCompositionLinearTransferEffect **")] IDCompositionLinearTransferEffect** linearTransferEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateLinearTransferEffect>(lpVtbl->CreateLinearTransferEffect)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), linearTransferEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTableTransferEffect([NativeTypeName("IDCompositionTableTransferEffect **")] IDCompositionTableTransferEffect** tableTransferEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTableTransferEffect>(lpVtbl->CreateTableTransferEffect)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), tableTransferEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompositeEffect([NativeTypeName("IDCompositionCompositeEffect **")] IDCompositionCompositeEffect** compositeEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCompositeEffect>(lpVtbl->CreateCompositeEffect)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), compositeEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlendEffect([NativeTypeName("IDCompositionBlendEffect **")] IDCompositionBlendEffect** blendEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBlendEffect>(lpVtbl->CreateBlendEffect)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), blendEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateArithmeticCompositeEffect([NativeTypeName("IDCompositionArithmeticCompositeEffect **")] IDCompositionArithmeticCompositeEffect** arithmeticCompositeEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateArithmeticCompositeEffect>(lpVtbl->CreateArithmeticCompositeEffect)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), arithmeticCompositeEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateAffineTransform2DEffect([NativeTypeName("IDCompositionAffineTransform2DEffect **")] IDCompositionAffineTransform2DEffect** affineTransform2dEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateAffineTransform2DEffect>(lpVtbl->CreateAffineTransform2DEffect)((IDCompositionDevice3*)Unsafe.AsPointer(ref this), affineTransform2dEffect);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Commit;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr WaitForCommitCompletion;

            [NativeTypeName("HRESULT (DCOMPOSITION_FRAME_STATISTICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFrameStatistics;

            [NativeTypeName("HRESULT (IDCompositionVisual2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateVisual;

            [NativeTypeName("HRESULT (IUnknown *, IDCompositionSurfaceFactory **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSurfaceFactory;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSurface;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateVirtualSurface;

            [NativeTypeName("HRESULT (IDCompositionTranslateTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTranslateTransform;

            [NativeTypeName("HRESULT (IDCompositionScaleTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateScaleTransform;

            [NativeTypeName("HRESULT (IDCompositionRotateTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateRotateTransform;

            [NativeTypeName("HRESULT (IDCompositionSkewTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSkewTransform;

            [NativeTypeName("HRESULT (IDCompositionMatrixTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateMatrixTransform;

            [NativeTypeName("HRESULT (IDCompositionTransform **, UINT, IDCompositionTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTransformGroup;

            [NativeTypeName("HRESULT (IDCompositionTranslateTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTranslateTransform3D;

            [NativeTypeName("HRESULT (IDCompositionScaleTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateScaleTransform3D;

            [NativeTypeName("HRESULT (IDCompositionRotateTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateRotateTransform3D;

            [NativeTypeName("HRESULT (IDCompositionMatrixTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateMatrixTransform3D;

            [NativeTypeName("HRESULT (IDCompositionTransform3D **, UINT, IDCompositionTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTransform3DGroup;

            [NativeTypeName("HRESULT (IDCompositionEffectGroup **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateEffectGroup;

            [NativeTypeName("HRESULT (IDCompositionRectangleClip **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateRectangleClip;

            [NativeTypeName("HRESULT (IDCompositionAnimation **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateAnimation;

            [NativeTypeName("HRESULT (IDCompositionGaussianBlurEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateGaussianBlurEffect;

            [NativeTypeName("HRESULT (IDCompositionBrightnessEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateBrightnessEffect;

            [NativeTypeName("HRESULT (IDCompositionColorMatrixEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateColorMatrixEffect;

            [NativeTypeName("HRESULT (IDCompositionShadowEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateShadowEffect;

            [NativeTypeName("HRESULT (IDCompositionHueRotationEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateHueRotationEffect;

            [NativeTypeName("HRESULT (IDCompositionSaturationEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSaturationEffect;

            [NativeTypeName("HRESULT (IDCompositionTurbulenceEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTurbulenceEffect;

            [NativeTypeName("HRESULT (IDCompositionLinearTransferEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateLinearTransferEffect;

            [NativeTypeName("HRESULT (IDCompositionTableTransferEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTableTransferEffect;

            [NativeTypeName("HRESULT (IDCompositionCompositeEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateCompositeEffect;

            [NativeTypeName("HRESULT (IDCompositionBlendEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateBlendEffect;

            [NativeTypeName("HRESULT (IDCompositionArithmeticCompositeEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateArithmeticCompositeEffect;

            [NativeTypeName("HRESULT (IDCompositionAffineTransform2DEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateAffineTransform2DEffect;
        }
    }
}
