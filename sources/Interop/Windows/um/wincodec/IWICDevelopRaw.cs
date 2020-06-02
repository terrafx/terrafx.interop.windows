// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FBEC5E44-F7BE-4B65-B7F8-C0C81FEF026D")]
    public unsafe partial struct IWICDevelopRaw
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICDevelopRaw*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICDevelopRaw*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICDevelopRaw*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return lpVtbl->GetSize((IWICDevelopRaw*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->GetPixelFormat((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResolution([NativeTypeName("double *")] double* pDpiX, [NativeTypeName("double *")] double* pDpiY)
        {
            return lpVtbl->GetResolution((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return lpVtbl->CopyPalette((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return lpVtbl->CopyPixels((IWICDevelopRaw*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryReader([NativeTypeName("IWICMetadataQueryReader **")] IWICMetadataQueryReader** ppIMetadataQueryReader)
        {
            return lpVtbl->GetMetadataQueryReader((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorContexts([NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContexts, [NativeTypeName("UINT *")] uint* pcActualCount)
        {
            return lpVtbl->GetColorContexts((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetThumbnail([NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** ppIThumbnail)
        {
            return lpVtbl->GetThumbnail((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppIThumbnail);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryRawCapabilitiesInfo([NativeTypeName("WICRawCapabilitiesInfo *")] WICRawCapabilitiesInfo* pInfo)
        {
            return lpVtbl->QueryRawCapabilitiesInfo((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadParameterSet(WICRawParameterSet ParameterSet)
        {
            return lpVtbl->LoadParameterSet((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ParameterSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentParameterSet([NativeTypeName("IPropertyBag2 **")] IPropertyBag2** ppCurrentParameterSet)
        {
            return lpVtbl->GetCurrentParameterSet((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppCurrentParameterSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetExposureCompensation(double ev)
        {
            return lpVtbl->SetExposureCompensation((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ev);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExposureCompensation([NativeTypeName("double *")] double* pEV)
        {
            return lpVtbl->GetExposureCompensation((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pEV);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointRGB([NativeTypeName("UINT")] uint Red, [NativeTypeName("UINT")] uint Green, [NativeTypeName("UINT")] uint Blue)
        {
            return lpVtbl->SetWhitePointRGB((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Red, Green, Blue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWhitePointRGB([NativeTypeName("UINT *")] uint* pRed, [NativeTypeName("UINT *")] uint* pGreen, [NativeTypeName("UINT *")] uint* pBlue)
        {
            return lpVtbl->GetWhitePointRGB((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRed, pGreen, pBlue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNamedWhitePoint(WICNamedWhitePoint WhitePoint)
        {
            return lpVtbl->SetNamedWhitePoint((IWICDevelopRaw*)Unsafe.AsPointer(ref this), WhitePoint);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNamedWhitePoint([NativeTypeName("WICNamedWhitePoint *")] WICNamedWhitePoint* pWhitePoint)
        {
            return lpVtbl->GetNamedWhitePoint((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pWhitePoint);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointKelvin([NativeTypeName("UINT")] uint WhitePointKelvin)
        {
            return lpVtbl->SetWhitePointKelvin((IWICDevelopRaw*)Unsafe.AsPointer(ref this), WhitePointKelvin);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWhitePointKelvin([NativeTypeName("UINT *")] uint* pWhitePointKelvin)
        {
            return lpVtbl->GetWhitePointKelvin((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pWhitePointKelvin);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetKelvinRangeInfo([NativeTypeName("UINT *")] uint* pMinKelvinTemp, [NativeTypeName("UINT *")] uint* pMaxKelvinTemp, [NativeTypeName("UINT *")] uint* pKelvinTempStepValue)
        {
            return lpVtbl->GetKelvinRangeInfo((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pMinKelvinTemp, pMaxKelvinTemp, pKelvinTempStepValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContrast(double Contrast)
        {
            return lpVtbl->SetContrast((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Contrast);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContrast([NativeTypeName("double *")] double* pContrast)
        {
            return lpVtbl->GetContrast((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pContrast);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGamma(double Gamma)
        {
            return lpVtbl->SetGamma((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Gamma);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGamma([NativeTypeName("double *")] double* pGamma)
        {
            return lpVtbl->GetGamma((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pGamma);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSharpness(double Sharpness)
        {
            return lpVtbl->SetSharpness((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Sharpness);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSharpness([NativeTypeName("double *")] double* pSharpness)
        {
            return lpVtbl->GetSharpness((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pSharpness);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSaturation(double Saturation)
        {
            return lpVtbl->SetSaturation((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Saturation);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSaturation([NativeTypeName("double *")] double* pSaturation)
        {
            return lpVtbl->GetSaturation((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pSaturation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTint(double Tint)
        {
            return lpVtbl->SetTint((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Tint);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTint([NativeTypeName("double *")] double* pTint)
        {
            return lpVtbl->GetTint((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pTint);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNoiseReduction(double NoiseReduction)
        {
            return lpVtbl->SetNoiseReduction((IWICDevelopRaw*)Unsafe.AsPointer(ref this), NoiseReduction);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNoiseReduction([NativeTypeName("double *")] double* pNoiseReduction)
        {
            return lpVtbl->GetNoiseReduction((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pNoiseReduction);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDestinationColorContext([NativeTypeName("IWICColorContext *")] IWICColorContext* pColorContext)
        {
            return lpVtbl->SetDestinationColorContext((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pColorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetToneCurve([NativeTypeName("UINT")] uint cbToneCurveSize, [NativeTypeName("const WICRawToneCurve *")] WICRawToneCurve* pToneCurve)
        {
            return lpVtbl->SetToneCurve((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cbToneCurveSize, pToneCurve);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetToneCurve([NativeTypeName("UINT")] uint cbToneCurveBufferSize, [NativeTypeName("WICRawToneCurve *")] WICRawToneCurve* pToneCurve, [NativeTypeName("UINT *")] uint* pcbActualToneCurveBufferSize)
        {
            return lpVtbl->GetToneCurve((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cbToneCurveBufferSize, pToneCurve, pcbActualToneCurveBufferSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotation(double Rotation)
        {
            return lpVtbl->SetRotation((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Rotation);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRotation([NativeTypeName("double *")] double* pRotation)
        {
            return lpVtbl->GetRotation((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRotation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRenderMode(WICRawRenderMode RenderMode)
        {
            return lpVtbl->SetRenderMode((IWICDevelopRaw*)Unsafe.AsPointer(ref this), RenderMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRenderMode([NativeTypeName("WICRawRenderMode *")] WICRawRenderMode* pRenderMode)
        {
            return lpVtbl->GetRenderMode((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRenderMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotificationCallback([NativeTypeName("IWICDevelopRawNotificationCallback *")] IWICDevelopRawNotificationCallback* pCallback)
        {
            return lpVtbl->SetNotificationCallback((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pCallback);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, uint*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, Guid*, int> GetPixelFormat;

            [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double*, double*, int> GetResolution;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, IWICPalette*, int> CopyPalette;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, WICRect*, uint, uint, byte*, int> CopyPixels;

            [NativeTypeName("HRESULT (IWICMetadataQueryReader **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, IWICMetadataQueryReader**, int> GetMetadataQueryReader;

            [NativeTypeName("HRESULT (UINT, IWICColorContext **, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, uint, IWICColorContext**, uint*, int> GetColorContexts;

            [NativeTypeName("HRESULT (IWICBitmapSource **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, IWICBitmapSource**, int> GetThumbnail;

            [NativeTypeName("HRESULT (WICRawCapabilitiesInfo *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, WICRawCapabilitiesInfo*, int> QueryRawCapabilitiesInfo;

            [NativeTypeName("HRESULT (WICRawParameterSet) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, WICRawParameterSet, int> LoadParameterSet;

            [NativeTypeName("HRESULT (IPropertyBag2 **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, IPropertyBag2**, int> GetCurrentParameterSet;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double, int> SetExposureCompensation;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double*, int> GetExposureCompensation;

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, uint, uint, uint, int> SetWhitePointRGB;

            [NativeTypeName("HRESULT (UINT *, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, uint*, uint*, uint*, int> GetWhitePointRGB;

            [NativeTypeName("HRESULT (WICNamedWhitePoint) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, WICNamedWhitePoint, int> SetNamedWhitePoint;

            [NativeTypeName("HRESULT (WICNamedWhitePoint *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, WICNamedWhitePoint*, int> GetNamedWhitePoint;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, uint, int> SetWhitePointKelvin;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, uint*, int> GetWhitePointKelvin;

            [NativeTypeName("HRESULT (UINT *, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, uint*, uint*, uint*, int> GetKelvinRangeInfo;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double, int> SetContrast;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double*, int> GetContrast;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double, int> SetGamma;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double*, int> GetGamma;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double, int> SetSharpness;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double*, int> GetSharpness;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double, int> SetSaturation;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double*, int> GetSaturation;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double, int> SetTint;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double*, int> GetTint;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double, int> SetNoiseReduction;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double*, int> GetNoiseReduction;

            [NativeTypeName("HRESULT (IWICColorContext *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, IWICColorContext*, int> SetDestinationColorContext;

            [NativeTypeName("HRESULT (UINT, const WICRawToneCurve *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, uint, WICRawToneCurve*, int> SetToneCurve;

            [NativeTypeName("HRESULT (UINT, WICRawToneCurve *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, uint, WICRawToneCurve*, uint*, int> GetToneCurve;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double, int> SetRotation;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, double*, int> GetRotation;

            [NativeTypeName("HRESULT (WICRawRenderMode) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, WICRawRenderMode, int> SetRenderMode;

            [NativeTypeName("HRESULT (WICRawRenderMode *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, WICRawRenderMode*, int> GetRenderMode;

            [NativeTypeName("HRESULT (IWICDevelopRawNotificationCallback *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDevelopRaw*, IWICDevelopRawNotificationCallback*, int> SetNotificationCallback;
        }
    }
}
